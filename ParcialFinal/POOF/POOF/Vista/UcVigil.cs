using System;
using System.Windows.Forms;

namespace POOF
{
    public partial class UcVigil : UserControl
    {
        private User currentUser;
        private string[] InOut = {"Entrando" , "Saliendo"};
        
        public UcVigil(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        
        private void UcVigil_Load(object sender, EventArgs e)
        {
            dgvVigil.DataSource = LogDao.GetLogs();
            cmbVigilInOut.DataSource = InOut;
        }
       

        private void btnVigil_Click(object sender, EventArgs e)
        {
            try
            {
                int idUser = Convert.ToInt32(txtVigilUser.Text);
                bool isWorking = cmbVigilInOut.SelectedIndex == 0 ? true : false;
                double temp = Convert.ToDouble(txtVigilTemp.Text);
            
                LogDao.CreateLog(idUser , isWorking , temp);
                MessageBox.Show("Entrada registrada correctamente.");
                txtVigilUser.Text = "";
                txtVigilTemp.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Verifique que toda la información sea correcta.");
            }

            dgvVigil.DataSource = null;
            dgvVigil.DataSource = LogDao.GetLogs();
        }
    }
}