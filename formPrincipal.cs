using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Tasks.v1;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ProyectoAGoogleTasksAPI
{
    public partial class formPrincipal : Form
    {
        private TasksService? servicio;
        private Google.Apis.Tasks.v1.Data.Task? tareaModificar;

        public formPrincipal()
        {
            InitializeComponent();
        }

        // Iniciamos el servicio TasksService con el scope Tasks para acceso a Google Tasks API
        private TasksService? ConectarServicio(string ficheroClaves, string cuenta)
        {
            const string nombreAplicacion = "ProyectoAGoogleTasksAPI";
            var scopesL = new[] { TasksService.Scope.Tasks };

            if (servicio != null)
                servicio = null;

            try
            {
                var credencialAcceso = GoogleCredential.FromFile(ficheroClaves).CreateScoped(scopesL).CreateWithUser(cuenta);

                var servicioTask = new TasksService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credencialAcceso,
                    ApplicationName = nombreAplicacion,
                });
                return servicioTask;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void MostrarListaTareas()
        {
            //Obtenemos la lista de listas de tareas
            if (servicio != null)
            {
                try
                {
                    var consultaTasks = servicio.Tasklists.List();

                    var resultado = consultaTasks.Execute();
                    var listaTareas = resultado.Items;
                    lsListas.Items.Clear();
                    foreach (var tarea in listaTareas)
                        lsListas.Items.Add($"({tarea.Id}) {tarea.Title}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener las listas de tareas: {ex.Message}",
                        "Error al obtener listas...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe conectar con el servicio Google Tasks antes de mostrar las listas de tareas.",
                    "Conectar con servicio...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btConectar.Focus();
            }
        }

        // Mostrar las tareas de una lista
        private void MostrarTareas(string idLista)
        {
            if (servicio != null)
            {
                try
                {
                    var consultaTasks = servicio.Tasks.List(idLista);
                    consultaTasks.ShowCompleted = opMostrarTareasCompletadas.Checked;
                    consultaTasks.ShowHidden = opMostrarTareasOcultas.Checked;
                    consultaTasks.ShowDeleted = opMostrarTareasEliminadas.Checked;
                    var resultado = consultaTasks.Execute();
                    var listaTareas = resultado.Items;
                    lsTareas.Items.Clear();
                    foreach (var tarea in listaTareas)
                    {
                        string estado = "";
                        if (tarea.Status == "completed")
                            estado = "[COMPLETADA]";
                        if (tarea.Deleted != null)
                            estado = estado == "" ? estado + " [ELIMINADA]" : "[ELIMINADA]";
                        if (tarea.Hidden != null)
                            estado = estado == "" ? estado + " [OCULTA]" : "[OCULTA]";
                        lsTareas.Items.Add($"({tarea.Id}) {tarea.Title} {estado}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener las tareas de la lista [{lsListas.Text}]: {ex.Message}",
                        "Error al obtener tareas...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe conectar con el servicio Google Tasks antes de mostrar las tareas.",
                    "Conectar con servicio...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btConectar.Focus();
            }

        }

        private void btListas_Click(object sender, EventArgs e)
        {
            MostrarListaTareas();
        }

        private void lsListas_Click(object sender, EventArgs e)
        {
            // Mostramos las tareas de la lista seleccionada
            // Obtenemos el ID de la lista mediante un patrón (separado por paréntesis)
            string patron = @"\(([^)]+)\)";
            Match mtLista = Regex.Match(lsListas.Text, patron);
            if (mtLista.Success)
            {
                string idLista = mtLista.Groups[1].Value;
                lTareasLista.Text = $"Tareas de la lista [{idLista}]";
                MostrarTareas(idLista);
            }
        }

        //Insertar o modificar una tarea
        private void btInsertarTarea_Click(object sender, EventArgs e)
        {
            if (txtTituloTarea.Text != "")
            {
                // Preparamos el patrón para obtener el ID de la lista padre que se asignará la tarea (la seleccionada actualmente)
                string patron = @"\(([^)]+)\)";
                Match mtLista = Regex.Match(lsListas.Text, patron);

                // Insertar una nueva tarea
                if (btInsertarTarea.Text == "Insertar")
                {
                    if (mtLista.Success)
                    {
                        string idListaPadre = mtLista.Groups[1].Value;

                        try
                        {
                            if (servicio != null)
                            {
                                // Creamos una tarea con todos los datos
                                Google.Apis.Tasks.v1.Data.Task tarea = new()
                                {
                                    Title = txtTituloTarea.Text,
                                    Notes = txtObservacionTarea.Text,
                                    Due = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffK")
                                };
                                //Insertamos la tarea creada en nuestra cuenta de Google Tasks API, en la lista seleccionada
                                var resultado = servicio.Tasks.Insert(tarea, idListaPadre).Execute();
                                MessageBox.Show("La tarea se ha insertado correctamente.",
                                    "Insertar tarea...",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtTituloTarea.Text = "";
                                txtObservacionTarea.Text = "";
                                MostrarTareas(idListaPadre);
                            }
                            else
                            {
                                MessageBox.Show("Debe conectar con el servicio Google Tasks antes de insertar la tarea.",
                                    "Conectar con servicio...",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                btConectar.Focus();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al insertar tarea: {ex.Message}",
                                "Error al insertar tarea...",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Antes de insertar un tarea, debe elegir una lista que se le asignará.",
                            "Insertar tarea...",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lsListas.Focus();
                    }
                }

                //Modificar una tarea existente
                if (btInsertarTarea.Text == "Modificar")
                {
                    if (tareaModificar != null)
                    {
                        if (servicio != null)
                        {
                            string idListaPadre = mtLista.Groups[1].Value;

                            if (mtLista.Success)
                            {
                                // Si se ha obtenido el ID de la lista de la selección
                                // Dado que no se devuelve de tareaModificar.Parent (no se sabe el motivo)
                                // Modificamos los valores de la tarea
                                try
                                {

                                    tareaModificar.Title = txtTituloTarea.Text;
                                    tareaModificar.Notes = txtObservacionTarea.Text;
                                    // Actualizamos la tarea
                                    Google.Apis.Tasks.v1.Data.Task tareaResultado = servicio.Tasks.Update(
                                        tareaModificar, idListaPadre, tareaModificar.Id).Execute();
                                    // Si el resultado es una tarea de Google, indicará que la actualización se ha ejecutado correctamente
                                    if (tareaResultado is not null)
                                    {
                                        MessageBox.Show($"La tarea [{tareaModificar.Id}] se modificado correctamente.",
                                            "Modificar tarea...",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MostrarTareas(idListaPadre);
                                        txtTituloTarea.Text = "";
                                        txtObservacionTarea.Text = "";
                                        btInsertarTarea.Text = "Insertar";
                                        gAInsertarTarea.Text = "Insertar tarea...";
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Error al modificar la tarea [{tareaModificar.Id}].",
                                            "Error al modificar tarea...",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error al modificar la tarea [{tareaModificar.Id}]: {ex.Message}",
                                        "Error al modificar tarea...",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Antes de insertar un tarea, debe elegir una lista que se le asignará.",
                                    "Insertar tarea...",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                lsListas.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe conectar con el servicio Google Tasks antes de completar una tarea.",
                              "Conectar con servicio...",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            btConectar.Focus();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe indicar, al menos, el título de la tarea.",
                    "Insertar tarea...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTituloTarea.Focus();
            }
        }

        // Conectar con servicio Google Tasks API
        private void btConectar_Click(object sender, EventArgs e)
        {
            if (txtFicheroClave.Text == "" || txtCuenta.Text == "")
            {
                MessageBox.Show("Debe indicar el fichero de claves de su cuenta de Google y la cuenta de Google correspondiente.",
                    "Conexión servicio Tasks...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lsListas.Items.Clear();
                lsTareas.Items.Clear();

                servicio = ConectarServicio(txtFicheroClave.Text, txtCuenta.Text);
                if (servicio != null)
                {
                    MessageBox.Show("Conectado con el servicio Google Tasks API.",
                        "Conexión servicio Tasks...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido conectar con el servicio Google Tasks. Revise los datos de conexión (fichero de claves).",
                        "Conexión servicio Tasks...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Eliminar tarea
        private void btEliminarTarea_Click(object sender, EventArgs e)
        {
            // Extraemos el ID de la lista seleccionada y el ID de la tarea seleccionada
            // Será el primer valor entre paréntesis que encuentre
            string patron = @"\(([^)]+)\)";
            Match mtLista = Regex.Match(lsListas.Text, patron);
            Match mtTarea = Regex.Match(lsTareas.Text, patron);
            if (mtTarea.Success && mtLista.Success)
            {
                string idLista = mtLista.Groups[1].Value;
                string idTarea = mtTarea.Groups[1].Value;

                if (servicio != null)
                {
                    try
                    {
                        // Eliminamos la tarea seleccionada (pasando el ID de lista y el ID de tarea)
                        var llamadaEliminar = servicio.Tasks.Delete(idLista, idTarea);
                        var resultado = llamadaEliminar.Execute();
                        if (resultado == "")
                        {
                            MessageBox.Show($"La tarea [{idTarea}] se ha eliminado correctamente.",
                                "Eliminar tarea...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarTareas(idLista);
                        }
                        else
                        {
                            MessageBox.Show($"Error al eliminar la tarea [{idTarea}]" +
                                Environment.NewLine + Environment.NewLine + $"{resultado}",
                                "Error al eliminar tarea...",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la tarea [{idTarea}]: {ex.Message}",
                            "Error al eliminar tarea...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe conectar con el servicio Google Tasks antes de eliminar una tarea.",
                        "Conectar con servicio...",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btConectar.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una lista y una tarea para eliminar.",
                    "Eliminar tarea...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lsListas.Focus();
            }
        }

        // Completar una tarea existente
        private void btCompletarTarea_Click(object sender, EventArgs e)
        {
            string patron = @"\(([^)]+)\)";
            Match mtTarea = Regex.Match(lsTareas.Text, patron);
            Match mtLista = Regex.Match(lsListas.Text, patron);

            if (mtTarea.Success && mtLista.Success)
            {
                string idLista = mtLista.Groups[1].Value;
                string idTarea = mtTarea.Groups[1].Value;

                if (servicio != null)
                {
                    try
                    {
                        // Obtenemos la tarea completa actual, necesario para actualizarla a completada posteriormente
                        Google.Apis.Tasks.v1.Data.Task tarea = servicio.Tasks.Get(idLista, idTarea).Execute();
                        // Modificamos el valor de "completed"
                        tarea.Status = "completed";
                        // Actualizamos la tarea
                        Google.Apis.Tasks.v1.Data.Task task = servicio.Tasks.Update(tarea, idLista, tarea.Id).Execute();
                        var resultado = task;
                        // Si el resultado es una tarea de Google, indicará que la actualización se ha ejecutado correctamente
                        if (resultado is not null)
                        {
                            MessageBox.Show($"La tarea [{idTarea}] se completado correctamente.",
                                "Completar tarea...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarTareas(idLista);
                        }
                        else
                        {
                            MessageBox.Show($"Error al completar la tarea [{idTarea}].",
                                "Error al completar tarea...",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al completar la tarea [{idTarea}]: {ex.Message}",
                            "Error al completar tarea...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe conectar con el servicio Google Tasks antes de completar una tarea.",
                      "Conectar con servicio...",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btConectar.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una lista y una tarea para completar.",
                    "Completar tarea...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lsListas.Focus();
            }
        }

        // Insertar una lista de tareas
        private void btInsertarListaTareas_Click(object sender, EventArgs e)
        {
            if (txtTituloListaTareas.Text != "")
            {
                try
                {
                    if (servicio != null)
                    {
                        // Creamos una lista de tareas
                        Google.Apis.Tasks.v1.Data.TaskList listaTarea = new()
                        {
                            Title = txtTituloListaTareas.Text,
                        };
                        //Insertamos la tarea creada en nuestra cuenta de Google Tasks API, en la lista seleccionada
                        var resultado = servicio.Tasklists.Insert(listaTarea).Execute();
                        MessageBox.Show("La lista de tareas se ha insertado correctamente.",
                            "Insertar lista de tareas...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTituloListaTareas.Text = "";
                        MostrarListaTareas();
                    }
                    else
                    {
                        MessageBox.Show("Debe conectar con el servicio Google Tasks antes de insertar la lista de tareas.",
                            "Conectar con servicio...",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btConectar.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar lista de tareas: {ex.Message}",
                        "Error al insertar lista de tareas...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe indicar el título de la lista de tareas.",
                    "Insertar lista de tareas...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTituloListaTareas.Focus();
            }
        }

        // Modificar una tarea existente
        private void btModificar_Click(object sender, EventArgs e)
        {
            // Obtenemos mediante expresión regular el ID de la lista y el ID de la tarea
            // Extrayendo el primer valor entre paréntesis
            string patron = @"\(([^)]+)\)";
            Match mtTarea = Regex.Match(lsTareas.Text, patron);
            Match mtLista = Regex.Match(lsListas.Text, patron);
            if (mtTarea.Success && mtLista.Success)
            {
                string idLista = mtLista.Groups[1].Value;
                string idTarea = mtTarea.Groups[1].Value;

                if (servicio != null)
                {
                    try
                    {
                        // Obtenemos todos los datos de la tarea seleccionada
                        tareaModificar = servicio.Tasks.Get(idLista, idTarea).Execute();
                        txtTituloTarea.Text = tareaModificar.Title;
                        txtObservacionTarea.Text = tareaModificar.Notes;
                        gAInsertarTarea.Text = $"Modificar tarea {tareaModificar.Id}";
                        btInsertarTarea.Text = "Modificar";
                        txtTituloTarea.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener información de la tarea [{idTarea}]: {ex.Message}",
                            "Error al obtener tarea...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe conectar con el servicio Google Tasks antes de modificar una tarea.",
                      "Conectar con servicio...",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btConectar.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una lista y una tarea para modificar.",
                    "Modificar tarea...",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lsListas.Focus();
            }
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            txtFicheroClave.Text = Config.Leer("Fichero de claves");
            txtCuenta.Text = Config.Leer("Cuenta");
        }

        private void formPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Guardar("Fichero de claves", txtFicheroClave.Text);
            Config.Guardar("Cuenta", txtCuenta.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://proyectoa.com",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://proyectoa.com/acceso-a-google-tasks-con-c-sharp-de-visual-studio-net/",
                UseShellExecute = true
            });
        }
    }
}