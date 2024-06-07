using CapaPresentacion;

namespace proyectohotel
{
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mancliente re = new Mancliente();
            re.Show();
        }
    }
}
