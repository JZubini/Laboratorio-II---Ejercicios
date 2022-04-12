using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01____Hola__Windows_Forms_
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Error(bool estadoIngresoNombre, bool estadoIngresoApellido) : this()
        {
            if (estadoIngresoNombre == false && estadoIngresoApellido == false)
            {
                this.errorNombre.Text = "Nombre";
                this.errorApellido.Text = "Apellido";
            }

            if(estadoIngresoNombre && estadoIngresoApellido == false)
            {
                this.errorApellido.Text = "Apellido";
            }

            if (estadoIngresoNombre == false && estadoIngresoApellido)
            {
                this.errorNombre.Text = "Nombre";
            }
        }

        private void errorNombre_Click(object sender, EventArgs e)
        {

        }

        private void Error_Load(object sender, EventArgs e)
        {

        }
    }
}
