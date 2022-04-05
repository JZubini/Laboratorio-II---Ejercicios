namespace EjercicioI01____Hola__Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bSaludar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("¡Hola, Windows Form!",$"Soy {this.txtNombre.Text} {this.txtApellido.Text}");
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            opciones.Items.Add("Programacion I");
            opciones.Items.Add("Laboratorio I");
            opciones.Items.Add("Ingles I");
            opciones.Items.Add("Matemática");
            opciones.Items.Add("Sistemas de procesamientos de datos");
            opciones.Items.Add("Programacion II");
            opciones.Items.Add("Laboratorio II");
            opciones.Items.Add("Estadística");
            opciones.Items.Add("Metodología de la investigación");
            opciones.Items.Add("Ingles II");
            opciones.Items.Add("Arquitectura de sistemas");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}