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
    public partial class UsersControl : UserControl
    {
        private string userEmail;
        private int studentModuleID;
        public UsersControl()
        {
            InitializeComponent();
        }
        public UsersControl(int StudentModuleID, string Email)
        {
            InitializeComponent();
            userEmail = Email;
            studentModuleID = StudentModuleID;
        }


            BusinessLogicLayer bll = new BusinessLogicLayer();


        private void btnAssessments_Click(object sender, EventArgs e)
        {
            StudAssessments stud = new StudAssessments(userEmail);
            stud.Show();
            this.Hide();
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            DAL.Fields userData = bll.ViewLecturerMoDetails(studentModuleID, userEmail);

            if (userData != null)
            {
                // Display the user's details in the control
                txtLecturerName.Text = userData.Name + " " + userData.Surname;
                lblModName.Text = userData.ModuleName;
                txtLecturerEmail.Text = userData.Email;

            }
        }
    }
}
