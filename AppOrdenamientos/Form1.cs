namespace AppOrdenamientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtSemestre.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            Estudiante nuevoEstudiante = new Estudiante(
                int.Parse(txtID.Text),       // Convierte el ID a int
                txtNombre.Text,             
                int.Parse(txtEdad.Text),     // Edad (convierte a int)
                txtCarrera.Text,             
                int.Parse(txtSemestre.Text)  // Semestre (convierte a int)
            );

            Archivo archivo = new Archivo();

            List<Estudiante> estudiantes = archivo.LeerEstudiantes();

            estudiantes.Add(nuevoEstudiante);

            archivo.GuardarEstudiantes(estudiantes);

            txtID.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtCarrera.Clear();
            txtSemestre.Clear();

            MessageBox.Show("Estudiante agregado correctamente.");
        }

        private void btnIrAOrdenamientos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
