using System;
using System.Windows.Forms;

namespace POOF
{
    public partial class UcAdmin : UserControl
    {
        private string[] depts = {"Administrativo" , "Seguridad" , "Ejecutivo"};
        private User currentUser;
        private delegate void myDel();
        public UcAdmin(User user)
        {
            InitializeComponent();

            currentUser = user;
            RechargeGDV();
        }

        private void RechargeGDV()
        {
            cmbAdminDept.DataSource = depts;
            dgvAdminLogs.DataSource = LogDao.GetLogs();
            dgvAdminSum.DataSource = LogDao.Working();
            dgvAdminSum2.DataSource = DeptDao.MostPopDept();
        }

        private void ResetTxt()
        {
            txtAdminName.Text = "";
            txtAdminLname.Text = "";
            txtAdminPass.Text = "";
            txtAdminDUI.Text = "";
        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            RechargeGDV();
        }

        private void btnAdminAddUser_Click(object sender, EventArgs e)
        {
            myDel methods = RechargeGDV;
            methods += ResetTxt;

            try
            {
                string name = txtAdminName.Text;
                string lastName = txtAdminLname.Text;
                string pass = txtAdminPass.Text;
                string dui = txtAdminDUI.Text;
                DateTime dateTime = dtpAdminBirth.Value;
                string sqlFormattedDate = dateTime.ToString("yyyy-MM-dd");
                int dept = cmbAdminDept.SelectedIndex + 1;

                if (name.Equals("") || pass.Equals("") || dui.Equals(""))
                    MessageBox.Show("Asegúrese de ingresar correctamente la información.");
                else
                {
                    UserDAO.CreateUser(pass ,name , lastName , dui , sqlFormattedDate , dept);
                    MessageBox.Show("Usuario creado correctamente.\nAsegúrese de guardar la contraseña.");
                    methods.Invoke();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Asegúrese de ingresar correctamente la información.");
            }
        }
    }
}