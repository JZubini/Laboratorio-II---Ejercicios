using Ingresante;

namespace Ejercicio_I02___Registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listaPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            string[] cursos = new string[2];
            string direccion;
            int edad;
            string genero;
            string nombre;
            string pais;
            int i;
            i = 0;
            
            if (checkBoxCSharp.Checked)
            {
                cursos[i] = checkBoxCSharp.Text;
                i++;
            }
            if (checkCPlusPlus.Checked)
            {
                cursos[i] = checkCPlusPlus.Text;
                i++;
            }
            if (checkJavaScript.Checked)
            {
                cursos[i] = checkJavaScript.Text;
                i++;
            }
            direccion = direccionBox.Text;
            edad = Int32.Parse(edadBox.Text);
            if (radioBMasculino.Checked)
            {
                genero = radioBMasculino.Text;
            }
            if (radioBFemenino.Checked)
            {
                genero = radioBFemenino.Text;
            }
            genero = radioBNoBinario.Text;
            nombre = nombreBox.Text;
            pais = listaPaises.Text;

            Ingresantes ingresanteNuevo = new Ingresantes(cursos,direccion,edad,genero,nombre,pais);



        }
    }
}