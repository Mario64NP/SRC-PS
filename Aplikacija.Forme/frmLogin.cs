using System.Windows.Forms;

namespace Aplikacija.Forme
{
    public partial class frmLogin : Form
    {
        public Button LoginButton { get => btnLogin; }
        public TextBox UsernameTBox { get => txtUsername; }
        public TextBox PasswordTBox { get => txtPassword; }
        public frmLogin()
        {
            InitializeComponent();
        }
    }
}