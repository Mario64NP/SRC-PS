using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Aplikacija.Server
{
    public partial class frmMain : Form
    {
        bool IsOn = false;
        readonly Server server;
        public frmMain()
        {
            InitializeComponent();
            server = new Server();
            server.ClientConnected += DisplayConnectedClient;
            server.ClientDisconnected += DisplayDisconnectedClient;
            server.ClientLoggedIn += DisplayLoggedInClient;
        }

        private void DisplayLoggedInClient(object sender, ServerEventArgs e)
        {
            Invoke(new Action(() =>
            {
                foreach (ListViewItem item in lvConnectedClients.Items)
                    if (item.Text == e.EP.ToString())
                        Invoke(new Action(() => item.SubItems[1].Text = $"Logged in as {e.User}"));
            }));
        }

        private void DisplayDisconnectedClient(object sender, ServerEventArgs e)
        {
            Invoke(new Action(() =>
            {
                foreach (ListViewItem item in lvConnectedClients.Items)
                    if (item.Text == e.EP.ToString())
                        Invoke(new Action(() => item.SubItems[1].Text = "Disconnected"));
            }));
        }

        private void DisplayConnectedClient(object sender, ServerEventArgs e)
        {
            ListViewItem item = new ListViewItem(e.EP.ToString());
            item.SubItems.Add("Connected");
            Invoke(new Action(() => lvConnectedClients.Items.Add(item)));
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (IsOn)
            {
                server.Stop();
                SetComponentsOff();
                return;
            }

            Thread serverThread = new Thread(server.Start);
            serverThread.IsBackground = true;
            serverThread.Start();
            SetComponentsOn();
        }

        private void SetComponentsOn()
        {
            lblState.Text = "On";
            lblState.ForeColor = Color.Green;
            btnSwitch.Text = "Turn off";
            IsOn = true;
        }

        private void SetComponentsOff()
        {
            lblState.Text = "Off";
            lblState.ForeColor = Color.Red;
            btnSwitch.Text = "Start";
            lvConnectedClients.Items.Clear();
            IsOn = false;
        }
    }
}