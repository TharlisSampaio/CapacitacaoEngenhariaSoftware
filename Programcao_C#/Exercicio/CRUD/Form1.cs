using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnection = "server=localhost;uid=root;password=tss@ufac;database=csharp;";
                connection = new MySqlConnection(strConnection);
                connection.Open();

                string txtNome, txtCpf, sexo;
                DateTime dateNasci = DateTime.Parse(dateNascimento.Text.Substring(0, 10));

                txtNome = textNome.Text;
                txtCpf = textCpf.Text;

                if (radioMasculino.Checked) {
                    sexo = "Masculino";
                }
                else if(radioFeminino.Checked)
                {
                    sexo = "Feminio";
                }
                else { sexo = null; }

                MySqlCommand cmd = new MySqlCommand($"INSERT INTO csharp.paciente (nome, cpf, sexo, dataNascimento) VALUES ('{txtNome}','{txtCpf}','{sexo}','{dateNasci.ToString("yyyy/MM/dd")}')", connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Paciente cadastrado com sucesso!");

                textNome.Clear();
                textCpf.Clear();
                dateNascimento.Value = DateTime.Now;
                radioFeminino.Checked = true;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void radioFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}