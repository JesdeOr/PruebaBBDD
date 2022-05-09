namespace PruebaBBDD
{
    partial class Form1
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.etiquetaID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.radioButtonAgregar = new System.Windows.Forms.RadioButton();
            this.radioButtonModificar = new System.Windows.Forms.RadioButton();
            this.radioButtonEliminar = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(172, 39);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(224, 23);
            this.textBoxID.TabIndex = 0;
            // 
            // etiquetaID
            // 
            this.etiquetaID.AutoSize = true;
            this.etiquetaID.Location = new System.Drawing.Point(145, 42);
            this.etiquetaID.Name = "etiquetaID";
            this.etiquetaID.Size = new System.Drawing.Size(21, 15);
            this.etiquetaID.TabIndex = 1;
            this.etiquetaID.Text = "ID:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(112, 71);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 15);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(172, 68);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(224, 23);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(107, 101);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(59, 15);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(172, 97);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(224, 23);
            this.textBoxApellidos.TabIndex = 4;
            // 
            // radioButtonAgregar
            // 
            this.radioButtonAgregar.AutoSize = true;
            this.radioButtonAgregar.Location = new System.Drawing.Point(502, 43);
            this.radioButtonAgregar.Name = "radioButtonAgregar";
            this.radioButtonAgregar.Size = new System.Drawing.Size(67, 19);
            this.radioButtonAgregar.TabIndex = 6;
            this.radioButtonAgregar.TabStop = true;
            this.radioButtonAgregar.Text = "Agregar";
            this.radioButtonAgregar.UseVisualStyleBackColor = true;
            // 
            // radioButtonModificar
            // 
            this.radioButtonModificar.AutoSize = true;
            this.radioButtonModificar.Location = new System.Drawing.Point(502, 72);
            this.radioButtonModificar.Name = "radioButtonModificar";
            this.radioButtonModificar.Size = new System.Drawing.Size(76, 19);
            this.radioButtonModificar.TabIndex = 7;
            this.radioButtonModificar.TabStop = true;
            this.radioButtonModificar.Text = "Modificar";
            this.radioButtonModificar.UseVisualStyleBackColor = true;
            // 
            // radioButtonEliminar
            // 
            this.radioButtonEliminar.AutoSize = true;
            this.radioButtonEliminar.Location = new System.Drawing.Point(502, 101);
            this.radioButtonEliminar.Name = "radioButtonEliminar";
            this.radioButtonEliminar.Size = new System.Drawing.Size(68, 19);
            this.radioButtonEliminar.TabIndex = 8;
            this.radioButtonEliminar.TabStop = true;
            this.radioButtonEliminar.Text = "Eliminar";
            this.radioButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(172, 162);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(321, 162);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Conexión BBDD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.radioButtonEliminar);
            this.Controls.Add(this.radioButtonModificar);
            this.Controls.Add(this.radioButtonAgregar);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.etiquetaID);
            this.Controls.Add(this.textBoxID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxID;
        private Label etiquetaID;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelApellidos;
        private TextBox textBoxApellidos;
        private RadioButton radioButtonAgregar;
        private RadioButton radioButtonModificar;
        private RadioButton radioButtonEliminar;
        private Button buttonAceptar;
        private Button buttonLimpiar;
        GroupBox botonesSeleccion = new GroupBox();
        private Button button1;
    }
}