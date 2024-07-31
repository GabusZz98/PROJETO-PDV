using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;



namespace PDV.cadastros
{
    public partial class FrmCadFuncionario : Form
    {

        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string foto;


        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //tratar os dados
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo \"Nome\"", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo \"CPF\"", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }
             
                con.AbrirConexao();
                sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, numero, bairro, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, @numero, @bairro, curDate(), @foto)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@foto", img()); //img() é o metodo criado p/ tratar imagem p/ bd.
                cmd.ExecuteNonQuery();
                con.FecharConexao();

            LimparFoto();
            //Listar();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            cbCargo.Enabled = false;
            btnFoto.Enabled = false;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.filter = "Arquivos(*.jpg)|*.jpg | Arquivos(*.PNG)| *.png;| All (*.*) | *.*"; //mostra um de cada vez 
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png"; // Mostra jpg e png
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString(); //pegando o caminho da imagem q selecionei e dei ok
                image.ImageLocation = foto; //jogando caminho da imagem p/ componente image p/ exibir no form
                //alterouImagem = "sim"; //p/ usou editar alterando a imagem
            }
        }

        private byte[] img() //este método é padrão, serve sempre que desejar enviar uma imagem para o banco de dados
        {
            byte[] imagem_byte = null; //essa var vou usar para enviar o comprimento da imagem
            if (foto == "") { //a string foto, nunca vai estar vazia, pq no metodo LimparFoto() foi passado o caminho de uma imagem 'sem_foto'.
                return null;
            }

            // usar o FileStream para enviar imagem para o banco de ~dados e tres paramentros 'local(foto), tipo de imagem(FileMode), tipo de acesso(FileAcess)'
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read); //isso aqui é padrao.

            BinaryReader br = new BinaryReader(fs); //Serve para trabalhar com o FileStream

            imagem_byte = br.ReadBytes((int)fs.Length); //*pegando o comprimento de FileStream jogando dentro de um tipo IMAGEM BYTE.

            return imagem_byte;
        }

        private void LimparFoto()
        {
            image.Image = Properties.Resources.sem_foto; //aqui coloca a imagem sem_foto na picture do form
            foto = "IMG/sem_foto.png"; //atribuindo um caminho de foto (assim este imagem tem que estar na pasta debug)
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            btnFoto.Enabled = true;
            cbCargo.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            cbCargo.Text = "";
        }

    }
}
