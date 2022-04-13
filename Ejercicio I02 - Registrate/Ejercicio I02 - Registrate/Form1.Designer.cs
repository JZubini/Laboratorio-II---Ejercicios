namespace Ejercicio_I02___Registrate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.direccionBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.edadBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBNoBinario = new System.Windows.Forms.RadioButton();
            this.radioBFemenino = new System.Windows.Forms.RadioButton();
            this.radioBMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkJavaScript = new System.Windows.Forms.CheckBox();
            this.checkCPlusPlus = new System.Windows.Forms.CheckBox();
            this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listaPaises = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.direccionBox);
            this.groupBox1.Controls.Add(this.nombreBox);
            this.groupBox1.Controls.Add(this.edadBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 172);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(174, 29);
            this.numericUpDown1.TabIndex = 6;
            // 
            // direccionBox
            // 
            this.direccionBox.Location = new System.Drawing.Point(113, 117);
            this.direccionBox.Name = "direccionBox";
            this.direccionBox.Size = new System.Drawing.Size(174, 29);
            this.direccionBox.TabIndex = 4;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(113, 62);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(174, 29);
            this.nombreBox.TabIndex = 3;
            // 
            // edadBox
            // 
            this.edadBox.AutoSize = true;
            this.edadBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edadBox.Location = new System.Drawing.Point(27, 174);
            this.edadBox.Name = "edadBox";
            this.edadBox.Size = new System.Drawing.Size(44, 21);
            this.edadBox.TabIndex = 2;
            this.edadBox.Text = "Edad";
            this.edadBox.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBNoBinario);
            this.groupBox2.Controls.Add(this.radioBFemenino);
            this.groupBox2.Controls.Add(this.radioBMasculino);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(388, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Género";
            // 
            // radioBNoBinario
            // 
            this.radioBNoBinario.AutoSize = true;
            this.radioBNoBinario.Location = new System.Drawing.Point(28, 121);
            this.radioBNoBinario.Name = "radioBNoBinario";
            this.radioBNoBinario.Size = new System.Drawing.Size(102, 25);
            this.radioBNoBinario.TabIndex = 2;
            this.radioBNoBinario.TabStop = true;
            this.radioBNoBinario.Text = "No binario";
            this.radioBNoBinario.UseVisualStyleBackColor = true;
            // 
            // radioBFemenino
            // 
            this.radioBFemenino.AutoSize = true;
            this.radioBFemenino.Location = new System.Drawing.Point(28, 78);
            this.radioBFemenino.Name = "radioBFemenino";
            this.radioBFemenino.Size = new System.Drawing.Size(97, 25);
            this.radioBFemenino.TabIndex = 1;
            this.radioBFemenino.TabStop = true;
            this.radioBFemenino.Text = "Femenino";
            this.radioBFemenino.UseVisualStyleBackColor = true;
            this.radioBFemenino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioBMasculino
            // 
            this.radioBMasculino.AutoSize = true;
            this.radioBMasculino.Location = new System.Drawing.Point(28, 37);
            this.radioBMasculino.Name = "radioBMasculino";
            this.radioBMasculino.Size = new System.Drawing.Size(99, 25);
            this.radioBMasculino.TabIndex = 0;
            this.radioBMasculino.TabStop = true;
            this.radioBMasculino.Text = "Masculino";
            this.radioBMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkJavaScript);
            this.groupBox3.Controls.Add(this.checkCPlusPlus);
            this.groupBox3.Controls.Add(this.checkBoxCSharp);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(388, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursos";
            // 
            // checkJavaScript
            // 
            this.checkJavaScript.AutoSize = true;
            this.checkJavaScript.Location = new System.Drawing.Point(25, 123);
            this.checkJavaScript.Name = "checkJavaScript";
            this.checkJavaScript.Size = new System.Drawing.Size(99, 25);
            this.checkJavaScript.TabIndex = 2;
            this.checkJavaScript.Text = "JavaScript";
            this.checkJavaScript.UseVisualStyleBackColor = true;
            // 
            // checkCPlusPlus
            // 
            this.checkCPlusPlus.AutoSize = true;
            this.checkCPlusPlus.Location = new System.Drawing.Point(25, 81);
            this.checkCPlusPlus.Name = "checkCPlusPlus";
            this.checkCPlusPlus.Size = new System.Drawing.Size(61, 25);
            this.checkCPlusPlus.TabIndex = 1;
            this.checkCPlusPlus.Text = "C++";
            this.checkCPlusPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            this.checkBoxCSharp.AutoSize = true;
            this.checkBoxCSharp.Location = new System.Drawing.Point(25, 39);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(48, 25);
            this.checkBoxCSharp.TabIndex = 0;
            this.checkBoxCSharp.Text = "C#";
            this.checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(431, 419);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(128, 29);
            this.botonIngresar.TabIndex = 3;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listaPaises);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(29, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 152);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "País";
            // 
            // listaPaises
            // 
            this.listaPaises.FormattingEnabled = true;
            this.listaPaises.ItemHeight = 21;
            this.listaPaises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listaPaises.Location = new System.Drawing.Point(6, 28);
            this.listaPaises.Name = "listaPaises";
            this.listaPaises.Size = new System.Drawing.Size(318, 109);
            this.listaPaises.TabIndex = 0;
            this.listaPaises.SelectedIndexChanged += new System.EventHandler(this.listaPaises_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 471);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox direccionBox;
        private TextBox nombreBox;
        private Label edadBox;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioBNoBinario;
        private RadioButton radioBFemenino;
        private RadioButton radioBMasculino;
        private GroupBox groupBox3;
        private Button botonIngresar;
        private NumericUpDown numericUpDown1;
        private CheckBox checkJavaScript;
        private CheckBox checkCPlusPlus;
        private CheckBox checkBoxCSharp;
        private GroupBox groupBox4;
        private ListBox listaPaises;
    }
}