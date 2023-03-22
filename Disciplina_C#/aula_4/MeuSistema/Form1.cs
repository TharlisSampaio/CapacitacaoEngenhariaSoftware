namespace MeuSistema
{
    public partial class resultado : Form
    {
        public resultado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void somar_Click(object sender, EventArgs e)
        {
            Double result = (Convert.ToDouble(entrada1.Text) + Convert.ToDouble(entrada2.Text));
            res.Text = Convert.ToString(result);
        }
    }
}