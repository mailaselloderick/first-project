using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PROJECT_ONT23
{
    public partial class Users : Form
    {
        private string userEmail;
        public Users()
        {
            InitializeComponent();
        }
        public Users(string Email)
        {
            InitializeComponent();
            userEmail = Email;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        
        private void btnUserManSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserManExit_Click(object sender, EventArgs e)
        {
            SystemAdmin admin = new SystemAdmin(userEmail);
            admin.Show();
            this.Hide();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            //userTitles
            cmbUserTitle.Items.Add("Mr");
            cmbUserTitle.Items.Add("Ms");
            cmbUserTitle.Items.Add("Mrs");

            //user roles
            cmbUserRole.Items.Add("Administrator");
            cmbUserRole.Items.Add("Lecturer");
            cmbUserRole.Items.Add("Student");

            //User Status
            cmbUserStatus.Items.Add("Active");
            cmbUserStatus.Items.Add("Inactive");
            //user Filter roles
            cmbFilterByRole.Items.Add("Administrator");
            cmbFilterByRole.Items.Add("Lecturer");
            cmbFilterByRole.Items.Add("Student");
        }
        public void ClearData()
        {
            txtUserName.Text = " ";
            txtUserSurname.Text = " ";
            cmbUserTitle.Text = " ";
            cmbUserRole.Text = " ";
            txtUserEmail.Text = " ";
            txtUserPassword.Text = " ";
            cmbUserStatus.Text = " ";

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.Name = txtUserName.Text;
            fields.Surname = txtUserSurname.Text;
            fields.Title = cmbUserTitle.Text;
            fields.Role = cmbUserRole.Text;
            fields.Email = txtUserEmail.Text;
            fields.Password = txtUserPassword.Text;
            fields.UserStatus = cmbUserStatus.Text;

            int x = bll.InsertUsers(fields);

            ClearData();
            dgvDisplayUsers.DataSource = bll.GetUser();
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            dgvDisplayUsers.DataSource = bll.GetUser();
        }

        private void dgvDisplayUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayUsers.SelectedRows.Count>0)
            {
                txtUserID.Text = dgvDisplayUsers.SelectedRows[0].Cells["UserID"].Value.ToString();
                txtUserName.Text = dgvDisplayUsers.SelectedRows[0].Cells["Name"].Value.ToString();
                txtUserSurname.Text = dgvDisplayUsers.SelectedRows[0].Cells["Surname"].Value.ToString();
                cmbUserTitle.Text = dgvDisplayUsers.SelectedRows[0].Cells["Title"].Value.ToString();
                cmbUserRole.Text = dgvDisplayUsers.SelectedRows[0].Cells["Role"].Value.ToString();
                txtUserEmail.Text = dgvDisplayUsers.SelectedRows[0].Cells["Email"].Value.ToString();
                txtUserPassword.Text = dgvDisplayUsers.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbUserStatus.Text = dgvDisplayUsers.SelectedRows[0].Cells["UserStatus"].Value.ToString();

            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            fields.UserID = int.Parse(txtUserID.Text);
            fields.Surname = txtUserSurname.Text;
            fields.Title = cmbUserTitle.Text;
            fields.Password = txtUserPassword.Text;
            fields.UserStatus = cmbUserStatus.Text;
            int x = bll.UpdateUsers(fields);

            
            dgvDisplayUsers.DataSource = bll.GetUser();

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            // Get the selected role from the ComboBox
            fields.Role = cmbFilterByRole.SelectedItem.ToString();
            dgvDisplayUsers.DataSource = bll.GetUserRole(fields.Role);

        }

        private void txtFilterUserName_TextChanged(object sender, EventArgs e)
        {
            Fields fields = new Fields();
            // Get the selected role from the ComboBox
            fields.Name = txtFilterUserName.Text;
            dgvDisplayUsers.DataSource = bll.GetUserByName(fields.Name);

        }
    }
}
