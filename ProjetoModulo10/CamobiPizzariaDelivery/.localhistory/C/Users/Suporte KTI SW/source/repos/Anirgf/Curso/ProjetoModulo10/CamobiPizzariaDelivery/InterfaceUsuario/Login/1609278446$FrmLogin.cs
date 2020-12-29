using Entidades.Sistema;
using Negocio.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Login
{
    public partial class FrmLogin : Form
    {
        public bool bFlagLogin;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersao.Text = string.Format(lblVersao.Text, version.Major, version.Minor, version.Build, version.Revision);

            CarregarUsuario();
        }

        private void CarregarUsuario()
        {
            var lista = new UsuarioNG().ListaUsuarios();
            if(lista.Count > 0)
            {
                foreach(var item in lista)
                {
                    cmbUsuarios.Items.Add(new ComboBoxItemUruario(item.Login, item.Codigo, item.Senha));
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar o login para acessar o sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenha.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar sua senha para acessar o sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (ComboBoxItemUruario)cmbUsuarios.SelectedItem;
            if( item.Senha != txtSenha.Text.Trim())
            {
                MessageBox.Show("A senha informada está incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bFlagLogin = true;

            Sessao.Usuario = new Entidades.Entidade(item.Codigo, item.Login);
            Sessao.TipoUsuario = new TipoUsuarioNG().BuscarTipoUsuarioDoUsuario(item.Codigo);

            this.Close();
        }
    }
}
