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
    }
}
