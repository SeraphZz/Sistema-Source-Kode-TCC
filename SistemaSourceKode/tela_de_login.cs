using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSourceKode
{
    public partial class tela_de_login : Form
    {
        public tela_de_login()
        {
            InitializeComponent();
        }

        private void cadastroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stucchiDataSet);

        }

        private void tela_de_login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'stucchiDataSet.cadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroTableAdapter.Fill(this.stucchiDataSet.cadastro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTableReader read = new DataTableReader(stucchiDataSet.cadastro);
            bool logado = false;
            if (String.Compare(loginTextBox.Text, "") != 0 && (String.Compare(senhaTextBox.Text,
           "") != 0) && (String.Compare(nivelComboBox.Text, "") != 0))
            {
                while (read.Read())
                {
                    if (String.Compare(loginTextBox.Text, read.GetString(0)) == 0 &&
                   (String.Compare(senhaTextBox.Text, read.GetString(1))) == 0 && (String.Compare(nivelComboBox.Text,
                   read.GetString(2))) == 0) logado = true;
                }
                if (logado)
                {
                    if (nivelComboBox.Text == "ADM")
                    {
                        menu_principal principal = new menu_principal(); principal.menu2.Enabled = true;
                        principal.ShowDialog();
                    }
                    else
                    {
                       menu_principal principal = new menu_principal(); principal.menu2.Enabled = false;
                        principal.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorretos");
                }
            }
        }
    }
}