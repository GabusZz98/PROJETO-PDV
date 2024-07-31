using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PDV {
    internal class Conexao {

        public string conec = "SERVER=localhost; DATABASE=pdv_ponto_copias; UID=root; PWD=; PORT=;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
                con = new MySqlConnection(conec);
                con.Open();
        }
        public void FecharConexao()
        {
                con = new MySqlConnection(conec);
                con.Close();
                con.Dispose(); //Derruba algumas conexões abertas
                con.ClearAllPoolsAsync(); //Metodo de limpeza
        }

    }
}
