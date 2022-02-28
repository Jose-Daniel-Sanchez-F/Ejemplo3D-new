namespace Ejemplo3D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelsalida = new System.Windows.Forms.Label();
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelFechadeNacimiento = new System.Windows.Forms.Label();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.labelEdad = new System.Windows.Forms.Label();
            this.buttonAbrirCuenta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttoNGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(139, 39);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(200, 20);
            this.textBoxDpi.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(139, 121);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(200, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(176, 273);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(141, 43);
            this.buttonIngresar.TabIndex = 6;
            this.buttonIngresar.Text = "INGRESAR";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(139, 157);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(139, 83);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono: ";
            // 
            // labelsalida
            // 
            this.labelsalida.AutoSize = true;
            this.labelsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelsalida.Location = new System.Drawing.Point(416, 3);
            this.labelsalida.Name = "labelsalida";
            this.labelsalida.Size = new System.Drawing.Size(84, 25);
            this.labelsalida.TabIndex = 13;
            this.labelsalida.Text = "SALIDA";
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDpi.Location = new System.Drawing.Point(434, 40);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(12, 17);
            this.labelDpi.TabIndex = 14;
            this.labelDpi.Text = ".";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNombre.Location = new System.Drawing.Point(434, 73);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(12, 17);
            this.labelNombre.TabIndex = 15;
            this.labelNombre.Text = ".";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelApellido.Location = new System.Drawing.Point(434, 111);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(12, 17);
            this.labelApellido.TabIndex = 16;
            this.labelApellido.Text = ".";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTelefono.Location = new System.Drawing.Point(434, 141);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(12, 17);
            this.labelTelefono.TabIndex = 17;
            this.labelTelefono.Text = ".";
            // 
            // labelFechadeNacimiento
            // 
            this.labelFechadeNacimiento.AutoSize = true;
            this.labelFechadeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFechadeNacimiento.Location = new System.Drawing.Point(434, 171);
            this.labelFechadeNacimiento.Name = "labelFechadeNacimiento";
            this.labelFechadeNacimiento.Size = new System.Drawing.Size(12, 17);
            this.labelFechadeNacimiento.TabIndex = 19;
            this.labelFechadeNacimiento.Text = ".";
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Location = new System.Drawing.Point(512, 332);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(141, 43);
            this.buttonMostrarDatos.TabIndex = 20;
            this.buttonMostrarDatos.Text = "Mostrar Datos";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarDatos_Click);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEdad.Location = new System.Drawing.Point(434, 216);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(12, 17);
            this.labelEdad.TabIndex = 21;
            this.labelEdad.Text = ".";
            // 
            // buttonAbrirCuenta
            // 
            this.buttonAbrirCuenta.Location = new System.Drawing.Point(512, 395);
            this.buttonAbrirCuenta.Name = "buttonAbrirCuenta";
            this.buttonAbrirCuenta.Size = new System.Drawing.Size(141, 43);
            this.buttonAbrirCuenta.TabIndex = 22;
            this.buttonAbrirCuenta.Text = "Abrir Cuenta";
            this.buttonAbrirCuenta.UseVisualStyleBackColor = true;
            this.buttonAbrirCuenta.Click += new System.EventHandler(this.buttonAbrirCuenta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 296);
            this.dataGridView1.TabIndex = 23;
            // 
            // buttoNGuardar
            // 
            this.buttoNGuardar.Location = new System.Drawing.Point(699, 362);
            this.buttoNGuardar.Name = "buttoNGuardar";
            this.buttoNGuardar.Size = new System.Drawing.Size(139, 46);
            this.buttoNGuardar.TabIndex = 24;
            this.buttoNGuardar.Text = "GUARDAR DATOS";
            this.buttoNGuardar.UseVisualStyleBackColor = true;
            this.buttoNGuardar.Click += new System.EventHandler(this.buttoNGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.buttoNGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAbrirCuenta);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.buttonMostrarDatos);
            this.Controls.Add(this.labelFechadeNacimiento);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDpi);
            this.Controls.Add(this.labelsalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxDpi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelsalida;
        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelFechadeNacimiento;
        private System.Windows.Forms.Button buttonMostrarDatos;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Button buttonAbrirCuenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoNGuardar;
    }
}

