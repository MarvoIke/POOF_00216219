using System;
using System.Windows.Forms;

namespace POOF
{
    public partial class MainForm : Form
    {
        private UserControl currentControl;
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();

            currentUser = user;
            //Height = ClientSize.Height;
            //Width = ClientSize.Width;
            
            switch(currentUser.idZone)
            {
                case 1:
                    currentControl = new UcAdmin(currentUser);
                    break;
                case 2:
                    currentControl = new UcEmplo(currentUser);
                    break;
                case 3:
                    currentControl = new UcVigil(currentUser);
                    break;
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            currentControl.Dock = DockStyle.Fill;
            Controls.Add(currentControl);
            currentControl.Width = Width;
            currentControl.Height = Height;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}