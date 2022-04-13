namespace Ejercicio_I02___Registrate
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelCursos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(36, 34);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(52, 21);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "label1";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDireccion.Location = new System.Drawing.Point(36, 55);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 21);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "label1";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEdad.Location = new System.Drawing.Point(36, 76);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(52, 21);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "label1";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenero.Location = new System.Drawing.Point(36, 97);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(52, 21);
            this.labelGenero.TabIndex = 3;
            this.labelGenero.Text = "label1";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPais.Location = new System.Drawing.Point(36, 118);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(52, 21);
            this.labelPais.TabIndex = 4;
            this.labelPais.Text = "label1";
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCursos.Location = new System.Drawing.Point(36, 139);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(52, 21);
            this.labelCursos.TabIndex = 5;
            this.labelCursos.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 193);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNombre;
        private Label labelDireccion;
        private Label labelEdad;
        private Label labelGenero;
        private Label labelPais;
        private Label labelCursos;
    }
}