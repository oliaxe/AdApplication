using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdApplication
{
    public partial class Register : Form
    {
        public string _sqlConnectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
         SqlConnection conn;

        public Register()
        {
            InitializeComponent();
            conn = new SqlConnection(_sqlConnectionString);
        }

        private void Register_Btn(object sender, EventArgs e)
        {
            var context = new AD_ApplicationEntities();
            var user = new Users
            {
                Password = pwdtxt.Text,
                Name = nametxt.Text,
                Address = addresstxt.Text,
                Username = usernametxt.Text
            };
            User1.GetUser().Password = user.Password;
            User1.GetUser().Name = user.Name;
            User1.GetUser().Address = user.Address;
            User1.GetUser().Username = user.Username;

            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Congratulations! \nRegistration complete. \nYou can now login.");
            this.Close();
        }
    }
}