using MySql.Data.MySqlClient;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;

namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        private readonly string strConnection = "server=localhost;uid=root;password=tss@ufac;database=csharp;";
        public Form1()
        {
            InitializeComponent();
            atualizaTabela();
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
                connection = new MySqlConnection(this.strConnection);

                string txtNome, txtCpf, sexo;
                DateTime dateNasci = DateTime.Parse(dateNascimento.Text.Substring(0, 10));

                txtNome = textNome.Text;
                txtCpf = textCpf.Text;

                if (radioMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else if (radioFeminino.Checked)
                {
                    sexo = "Feminio";
                }
                else { sexo = null; }

                MySqlCommand cmd = new MySqlCommand($"INSERT INTO csharp.paciente (nome, cpf, sexo, dataNascimento) VALUES ('{txtNome}','{txtCpf}','{sexo}','{dateNasci.ToString("yyyy/MM/dd")}')", connection);
                MessageBox.Show("Paciente cadastrado com sucesso!");

                textNome.Clear();
                textCpf.Clear();
                dateNascimento.Value = DateTime.Now;
                radioFeminino.Checked = true;

                connection.Open();
                cmd.ExecuteNonQuery();

                atualizaTabela();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataRegistroPaciente.CurrentRow.Cells[0].Value.ToString();
            textNome.Text = dataRegistroPaciente.CurrentRow.Cells[1].Value.ToString();
            textCpf.Text = dataRegistroPaciente.CurrentRow.Cells[2].Value.ToString();
            string sexo = dataRegistroPaciente.CurrentRow.Cells[3].Value.ToString();
            if (sexo == "Masculino")
            {
                radioMasculino.Checked = true;
            }
            else
            {
                radioMasculino.Checked = false;
                radioFeminino.Checked = true;
            }
            dateNascimento.Text = dataRegistroPaciente.CurrentRow.Cells[4].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAtualizarTabela_Click(object sender, EventArgs e)
        {
            atualizaTabela();
        }
        public void atualizaTabela()
        {
            try
            {
                connection = new MySqlConnection(this.strConnection);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paciente;", connection);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataRegistroPaciente.DataSource = ds;
                dataRegistroPaciente.DataMember = ds.Tables[0].TableName;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            textId.Clear();
            textNome.Clear();
            textCpf.Clear();
            dateNascimento.DataContext = DateTime.Now;
            radioFeminino.Checked = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(this.strConnection);
                connection.Open();

                int idPaciente = Convert.ToInt32(textId.Text);

                MySqlCommand cmd = new MySqlCommand($"DELETE FROM paciente WHERE id = {idPaciente}", connection);

                DialogResult dr = MessageBox.Show("Você realmente deseja deletar o registro do paciente?", "Test", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro deletado com sucesso");
                limparCampos();
                atualizaTabela();

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(this.strConnection);

                int idPaciente = Convert.ToInt32(textId.Text);
                string nome = textNome.Text;
                string cpf = textCpf.Text;
                string sexo;
                DateTime dateNasci = DateTime.Parse(dateNascimento.Text.Substring(0, 10));
                if (radioMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                else if (radioFeminino.Checked)
                {
                    sexo = "Feminio";
                }
                else { sexo = null; }

                string sqlCommand = $"UPDATE paciente SET nome='{nome}', cpf='{cpf}', sexo='{sexo}', dataNascimento='{dateNasci.ToString("yyyy/MM/dd")}' WHERE (id={idPaciente})";
                MySqlCommand cmd = new MySqlCommand(sqlCommand, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro atualizado com sucesso!");

                limparCampos();
                atualizaTabela();

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
    }
}