namespace Biblioteca.Presentation
{
    public partial class Form1 : Form
    {
        private FormAutor? _formAutor;
        private FormConsultaAutores? _formConsultaAutores;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(FormAutor formAutor, FormConsultaAutores formConsultaAutores)
        {
            InitializeComponent();

            _formAutor = formAutor;
            _formConsultaAutores = formConsultaAutores;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            _formAutor?.ShowDialog(this);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            _formConsultaAutores?.ShowDialog(this);
        }
    }
}
