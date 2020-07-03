using System;
using System.Windows.Forms;

namespace POOF
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string nameIn = txtLoginUser.Text;
            string passIn = txtLoginPass.Text;
            if (nameIn.Equals("") || passIn.Equals(""))
                MessageBox.Show("Rellene los campos de informacion.");
            else
            {

                try
                {
                    User auxUser = UserDAO.GetUser(nameIn);
                    if (auxUser.password.Equals(passIn))
                    {
                        this.Hide();
                        MainForm form2 = new MainForm(auxUser);
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña inválidos.");
                        txtLoginUser.Text = "";
                        txtLoginPass.Text = "";
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Usuario o contraseña inválidos.");
                }
            }
        }
    }
}