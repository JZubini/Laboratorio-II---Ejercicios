namespace EjercicioI01____Hola__Windows_Forms_
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
            this.label1 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.bSaludar = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apellido.Location = new System.Drawing.Point(225, 26);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(67, 21);
            this.Apellido.TabIndex = 1;
            this.Apellido.Text = "Apellido";
            this.Apellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(26, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(225, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // bSaludar
            // 
            this.bSaludar.Location = new System.Drawing.Point(322, 165);
            this.bSaludar.Name = "bSaludar";
            this.bSaludar.Size = new System.Drawing.Size(135, 31);
            this.bSaludar.TabIndex = 4;
            this.bSaludar.Text = "Saludar";
            this.bSaludar.UseVisualStyleBackColor = true;
            this.bSaludar.Click += new System.EventHandler(this.bSaludar_Click);
            // 
            // txtMateria
            // 
            this.txtMateria.AutoSize = true;
            this.txtMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMateria.Location = new System.Drawing.Point(26, 103);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(120, 21);
            this.txtMateria.TabIndex = 5;
            this.txtMateria.Text = "Materia favorita";
            // 
            // opciones
            // 
            this.opciones.FormattingEnabled = true;
            this.opciones.Location = new System.Drawing.Point(26, 145);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(165, 23);
            this.opciones.TabIndex = 6;
            this.opciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 220);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.bSaludar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Apellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button bSaludar;
        private Label txtMateria;
        private ComboBox opciones;
    }
}