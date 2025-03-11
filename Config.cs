using System.Configuration;

namespace ProyectoAGoogleTasksAPI
{
    class Config
    {
        //Lee un valor de una clave en el fichero de configuración XML de la aplicación
        public static string Leer(string clave)
        {
            try
            {
                return ConfigurationManager.AppSettings[clave] ?? "";
            }
            catch
            {
                return "";
            }
        }


        //Guarda un valor en una clave en el fichero de configuración XML de la aplicación
        public static void Guardar(string clave, string valor)
        {
            try
            {
                Configuration ficheroConfXML =
                    ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                //Eliminamos la clave actual (si existe), de lo contrario los valores
                //se irán acumulando separados por coma
                ficheroConfXML.AppSettings.Settings.Remove(clave);

                //Asignamos el valor en la clave indicada
                ficheroConfXML.AppSettings.Settings.Add(clave, valor);

                //Guardamos los cambios definitivamente en el fichero de configuración
                ficheroConfXML.Save(ConfigurationSaveMode.Modified);
            }
            catch
            {
                // Silencioso
            }
        }
    }
}

