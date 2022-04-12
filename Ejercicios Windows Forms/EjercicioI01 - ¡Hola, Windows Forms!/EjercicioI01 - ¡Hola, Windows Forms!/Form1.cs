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
            if (String.IsNullOrWhiteSpace(this.txtNombre.Text) && String.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                Error errorNombreApellido = new Error(false, false);
                errorNombreApellido.Show();
            }

            
            if (String.IsNullOrWhiteSpace(this.txtNombre.Text) && !(String.IsNullOrWhiteSpace(this.txtApellido.Text)))
            {
                Error errorNombreApellido = new Error(false, true);
                errorNombreApellido.ShowDialog();
            }
            if (!(String.IsNullOrWhiteSpace(this.txtNombre.Text) && String.IsNullOrWhiteSpace(this.txtNombre.Text)))
            {
                Error errorNombreApellido = new Error(true, false);
                errorNombreApellido.ShowDialog();
            }
            
            if (!(String.IsNullOrWhiteSpace(this.txtNombre.Text) && String.IsNullOrWhiteSpace(this.txtApellido.Text))) { 
                Form2 frm = new Form2("¡Hola, Windows Form!", $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.opciones.SelectedItem}");
                frm.ShowDialog();
            }
            
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
            opciones.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}