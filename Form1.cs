using CapaPresentacion;

namespace proyectohotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegCliente re = new RegCliente();
            re.Show();
        }
    }
}
