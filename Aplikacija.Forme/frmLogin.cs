using Aplikacija.Domen;
using System;
using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GUIController.Instance.TryLogin(new User(txtUsername.Text, txtPassword.Text)))
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Your username/password combination is not correct. Try again.", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}