namespace EjercicioI01____Hola__Windows_Forms_
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
            this.txtCartel = new System.Windows.Forms.Label();
            this.txtSaludar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCartel
            // 
            this.txtCartel.AutoSize = true;
            this.txtCartel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCartel.Location = new System.Drawing.Point(23, 40);
            this.txtCartel.Name = "txtCartel";
            this.txtCartel.Size = new System.Drawing.Size(0, 25);
            this.txtCartel.TabIndex = 0;
            // 
            // txtSaludar
            // 
            this.txtSaludar.AutoSize = true;
            this.txtSaludar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaludar.Location = new System.Drawing.Point(23, 108);
            this.txtSaludar.Name = "txtSaludar";
            this.txtSaludar.Size = new System.Drawing.Size(0, 25);
            this.txtSaludar.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 185);
            this.Controls.Add(this.txtSaludar);
            this.Controls.Add(this.txtCartel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtCartel;
        private Label txtSaludar;
    }
}