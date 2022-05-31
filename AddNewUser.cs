using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaFram
{
    public partial class AddNewUser : Form
    {
        User newuser = new User();

        public AddNewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void HireDate_Click(object sender, EventArgs e)
        {

        }

        private void newUserUsername_Click(object sender, EventArgs e)
        {

        }

        private void newUserpassword_Click(object sender, EventArgs e)
        {

        }

        private void NewUserCancel_Click(object sender, EventArgs e)
        {
            Clear();

        }

        void Clear()
        {
            txtnewuseName.Text = txtHireDate.Text = newUserUsername.Text = newUserpassword.Text = "";
            newUserAdd.Text = "Save";
            NewUserDelete.Enabled = false;
            newuser.userID = 0;

        }

        private void newUserAdd_Click(object sender, EventArgs e)
        {
            newuser.Name = txtnewuseName.Text.Trim();
            newuser.username = txtNewUsername.Text.Trim();
            newuser.password = txtnewuserPassword.Text.Trim();
            newuser.hireDate = txtHireDate.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                db.Users.Add(newuser);
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Submittesd Successfully");

        }
    }
}
