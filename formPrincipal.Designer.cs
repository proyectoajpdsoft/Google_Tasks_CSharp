namespace ProyectoAGoogleTasksAPI
{
    partial class formPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            groupBox1 = new GroupBox();
            btConectar = new Button();
            txtCuenta = new TextBox();
            label2 = new Label();
            txtFicheroClave = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btModificar = new Button();
            opMostrarTareasEliminadas = new CheckBox();
            opMostrarTareasOcultas = new CheckBox();
            opMostrarTareasCompletadas = new CheckBox();
            lTareasLista = new Label();
            label5 = new Label();
            btCompletarTarea = new Button();
            btListas = new Button();
            lsTareas = new ListBox();
            lsListas = new ListBox();
            btEliminarTarea = new Button();
            gAInsertarTarea = new GroupBox();
            label4 = new Label();
            txtObservacionTarea = new TextBox();
            btInsertarTarea = new Button();
            txtTituloTarea = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            btInsertarListaTareas = new Button();
            txtTituloListaTareas = new TextBox();
            label11 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label7 = new Label();
            linkLabel2 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gAInsertarTarea.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(btConectar);
            groupBox1.Controls.Add(txtCuenta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFicheroClave);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(838, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de acceso ";
            // 
            // btConectar
            // 
            btConectar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btConectar.Location = new Point(745, 24);
            btConectar.Margin = new Padding(2);
            btConectar.Name = "btConectar";
            btConectar.Size = new Size(89, 51);
            btConectar.TabIndex = 2;
            btConectar.Text = "1º Conectar";
            btConectar.UseVisualStyleBackColor = true;
            btConectar.Click += btConectar_Click;
            // 
            // txtCuenta
            // 
            txtCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCuenta.Location = new Point(120, 69);
            txtCuenta.Margin = new Padding(2);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(621, 23);
            txtCuenta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Cuenta";
            // 
            // txtFicheroClave
            // 
            txtFicheroClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFicheroClave.Location = new Point(120, 23);
            txtFicheroClave.Margin = new Padding(2);
            txtFicheroClave.Name = "txtFicheroClave";
            txtFicheroClave.Size = new Size(621, 23);
            txtFicheroClave.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Fichero de clave";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btModificar);
            groupBox2.Controls.Add(opMostrarTareasEliminadas);
            groupBox2.Controls.Add(opMostrarTareasOcultas);
            groupBox2.Controls.Add(opMostrarTareasCompletadas);
            groupBox2.Controls.Add(lTareasLista);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btCompletarTarea);
            groupBox2.Controls.Add(btListas);
            groupBox2.Controls.Add(lsTareas);
            groupBox2.Controls.Add(lsListas);
            groupBox2.Controls.Add(btEliminarTarea);
            groupBox2.Location = new Point(18, 115);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(838, 309);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tareas ";
            // 
            // btModificar
            // 
            btModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btModificar.Location = new Point(749, 145);
            btModificar.Margin = new Padding(2);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(78, 26);
            btModificar.TabIndex = 6;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // opMostrarTareasEliminadas
            // 
            opMostrarTareasEliminadas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opMostrarTareasEliminadas.AutoSize = true;
            opMostrarTareasEliminadas.Location = new Point(465, 126);
            opMostrarTareasEliminadas.Margin = new Padding(2);
            opMostrarTareasEliminadas.Name = "opMostrarTareasEliminadas";
            opMostrarTareasEliminadas.Size = new Size(83, 19);
            opMostrarTareasEliminadas.TabIndex = 2;
            opMostrarTareasEliminadas.Text = "Eliminadas";
            opMostrarTareasEliminadas.UseVisualStyleBackColor = true;
            opMostrarTareasEliminadas.CheckedChanged += lsListas_Click;
            // 
            // opMostrarTareasOcultas
            // 
            opMostrarTareasOcultas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opMostrarTareasOcultas.AutoSize = true;
            opMostrarTareasOcultas.Location = new Point(552, 125);
            opMostrarTareasOcultas.Margin = new Padding(2);
            opMostrarTareasOcultas.Name = "opMostrarTareasOcultas";
            opMostrarTareasOcultas.Size = new Size(66, 19);
            opMostrarTareasOcultas.TabIndex = 3;
            opMostrarTareasOcultas.Text = "Ocultas";
            opMostrarTareasOcultas.UseVisualStyleBackColor = true;
            opMostrarTareasOcultas.CheckedChanged += lsListas_Click;
            // 
            // opMostrarTareasCompletadas
            // 
            opMostrarTareasCompletadas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opMostrarTareasCompletadas.AutoSize = true;
            opMostrarTareasCompletadas.Location = new Point(645, 125);
            opMostrarTareasCompletadas.Margin = new Padding(2);
            opMostrarTareasCompletadas.Name = "opMostrarTareasCompletadas";
            opMostrarTareasCompletadas.Size = new Size(96, 19);
            opMostrarTareasCompletadas.TabIndex = 4;
            opMostrarTareasCompletadas.Text = "Completadas";
            opMostrarTareasCompletadas.UseVisualStyleBackColor = true;
            opMostrarTareasCompletadas.CheckedChanged += lsListas_Click;
            // 
            // lTareasLista
            // 
            lTareasLista.AutoSize = true;
            lTareasLista.Location = new Point(20, 128);
            lTareasLista.Margin = new Padding(2, 0, 2, 0);
            lTareasLista.Name = "lTareasLista";
            lTareasLista.Size = new Size(91, 15);
            lTareasLista.TabIndex = 7;
            lTareasLista.Text = "Tareas de la lista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 23);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "Listas de tareas";
            // 
            // btCompletarTarea
            // 
            btCompletarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCompletarTarea.Location = new Point(749, 177);
            btCompletarTarea.Margin = new Padding(2);
            btCompletarTarea.Name = "btCompletarTarea";
            btCompletarTarea.Size = new Size(78, 28);
            btCompletarTarea.TabIndex = 7;
            btCompletarTarea.Text = "Completar";
            btCompletarTarea.UseVisualStyleBackColor = true;
            btCompletarTarea.Click += btCompletarTarea_Click;
            // 
            // btListas
            // 
            btListas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btListas.Location = new Point(749, 40);
            btListas.Margin = new Padding(2);
            btListas.Name = "btListas";
            btListas.Size = new Size(78, 45);
            btListas.TabIndex = 0;
            btListas.Text = "2º Obtener listas";
            btListas.UseVisualStyleBackColor = true;
            btListas.Click += btListas_Click;
            // 
            // lsTareas
            // 
            lsTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsTareas.FormattingEnabled = true;
            lsTareas.ItemHeight = 15;
            lsTareas.Location = new Point(20, 145);
            lsTareas.Margin = new Padding(2);
            lsTareas.Name = "lsTareas";
            lsTareas.Size = new Size(723, 154);
            lsTareas.TabIndex = 5;
            // 
            // lsListas
            // 
            lsListas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lsListas.FormattingEnabled = true;
            lsListas.ItemHeight = 15;
            lsListas.Location = new Point(20, 40);
            lsListas.Margin = new Padding(2);
            lsListas.Name = "lsListas";
            lsListas.Size = new Size(723, 79);
            lsListas.TabIndex = 1;
            lsListas.SelectedIndexChanged += lsListas_Click;
            // 
            // btEliminarTarea
            // 
            btEliminarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btEliminarTarea.Location = new Point(747, 209);
            btEliminarTarea.Margin = new Padding(2);
            btEliminarTarea.Name = "btEliminarTarea";
            btEliminarTarea.Size = new Size(78, 29);
            btEliminarTarea.TabIndex = 9;
            btEliminarTarea.Text = "Eliminar";
            btEliminarTarea.UseVisualStyleBackColor = true;
            btEliminarTarea.Click += btEliminarTarea_Click;
            // 
            // gAInsertarTarea
            // 
            gAInsertarTarea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gAInsertarTarea.Controls.Add(label4);
            gAInsertarTarea.Controls.Add(txtObservacionTarea);
            gAInsertarTarea.Controls.Add(btInsertarTarea);
            gAInsertarTarea.Controls.Add(txtTituloTarea);
            gAInsertarTarea.Controls.Add(label3);
            gAInsertarTarea.Location = new Point(18, 432);
            gAInsertarTarea.Margin = new Padding(2);
            gAInsertarTarea.Name = "gAInsertarTarea";
            gAInsertarTarea.Padding = new Padding(2);
            gAInsertarTarea.Size = new Size(838, 103);
            gAInsertarTarea.TabIndex = 2;
            gAInsertarTarea.TabStop = false;
            gAInsertarTarea.Text = "Insertar tarea ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 50);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 4;
            label4.Text = "Observación";
            // 
            // txtObservacionTarea
            // 
            txtObservacionTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacionTarea.Location = new Point(83, 53);
            txtObservacionTarea.Margin = new Padding(2);
            txtObservacionTarea.Multiline = true;
            txtObservacionTarea.Name = "txtObservacionTarea";
            txtObservacionTarea.ScrollBars = ScrollBars.Vertical;
            txtObservacionTarea.Size = new Size(658, 42);
            txtObservacionTarea.TabIndex = 1;
            // 
            // btInsertarTarea
            // 
            btInsertarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btInsertarTarea.Location = new Point(744, 26);
            btInsertarTarea.Margin = new Padding(2);
            btInsertarTarea.Name = "btInsertarTarea";
            btInsertarTarea.Size = new Size(78, 23);
            btInsertarTarea.TabIndex = 2;
            btInsertarTarea.Text = "Insertar";
            btInsertarTarea.UseVisualStyleBackColor = true;
            btInsertarTarea.Click += btInsertarTarea_Click;
            // 
            // txtTituloTarea
            // 
            txtTituloTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTituloTarea.Location = new Point(83, 26);
            txtTituloTarea.Margin = new Padding(2);
            txtTituloTarea.Name = "txtTituloTarea";
            txtTituloTarea.Size = new Size(658, 23);
            txtTituloTarea.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "Título";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(btInsertarListaTareas);
            groupBox4.Controls.Add(txtTituloListaTareas);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(15, 543);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(841, 61);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Insertar lista de tareas ";
            // 
            // btInsertarListaTareas
            // 
            btInsertarListaTareas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btInsertarListaTareas.Location = new Point(750, 26);
            btInsertarListaTareas.Margin = new Padding(2);
            btInsertarListaTareas.Name = "btInsertarListaTareas";
            btInsertarListaTareas.Size = new Size(78, 24);
            btInsertarListaTareas.TabIndex = 1;
            btInsertarListaTareas.Text = "Insertar";
            btInsertarListaTareas.UseVisualStyleBackColor = true;
            btInsertarListaTareas.Click += btInsertarListaTareas_Click;
            // 
            // txtTituloListaTareas
            // 
            txtTituloListaTareas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTituloListaTareas.Location = new Point(83, 26);
            txtTituloListaTareas.Margin = new Padding(2);
            txtTituloListaTareas.Name = "txtTituloListaTareas";
            txtTituloListaTareas.Size = new Size(664, 23);
            txtTituloListaTareas.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 29);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 0;
            label11.Text = "Título";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(278, 609);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://proyectoa.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(18, 609);
            label6.Name = "label6";
            label6.Size = new Size(258, 15);
            label6.TabIndex = 5;
            label6.Text = "Más programas gratuitos con código fuente en:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(120, 48);
            label7.Name = "label7";
            label7.Size = new Size(349, 15);
            label7.TabIndex = 7;
            label7.Text = "Para generar el fichero de claves siga las siguientes instrucciones:";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(475, 48);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(247, 15);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Generar fichero de claves de Google Tasks API";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 632);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox4);
            Controls.Add(gAInsertarTarea);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "formPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProyectoA Google Tasks";
            FormClosing += formPrincipal_FormClosing;
            FormClosed += formPrincipal_FormClosed;
            Load += formPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gAInsertarTarea.ResumeLayout(false);
            gAInsertarTarea.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCuenta;
        private Label label2;
        private TextBox txtFicheroClave;
        private Label label1;
        private GroupBox groupBox2;
        private Button btEliminarTarea;
        private ListBox lsListas;
        private ListBox lsTareas;
        private Button btListas;
        private Button btCompletarTarea;
        private GroupBox gAInsertarTarea;
        private Button btInsertarTarea;
        private TextBox txtTituloTarea;
        private Label label3;
        private Button btConectar;
        private Label label4;
        private TextBox txtObservacionTarea;
        private Label label5;
        private Label lTareasLista;
        private CheckBox opMostrarTareasCompletadas;
        private GroupBox groupBox4;
        private Button btInsertarListaTareas;
        private TextBox txtTituloListaTareas;
        private Label label11;
        private CheckBox opMostrarTareasEliminadas;
        private CheckBox opMostrarTareasOcultas;
        private Button btModificar;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel2;
    }
}