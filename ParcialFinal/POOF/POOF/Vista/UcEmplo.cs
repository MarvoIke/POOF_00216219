using System;
using System.Windows.Forms;

namespace POOF
{
    public partial class UcEmplo : UserControl
    {
        private User currentUser;
        public UcEmplo(User user)
        {
            InitializeComponent();

            currentUser = user;
        }

        private void UcEmplo_Load(object sender, EventArgs e)
        {
            lblEmplo.Text += currentUser.name + ": ";
            dgvEmplo.DataSource = LogDao.GetUserLogs(currentUser);
        }
    }
}