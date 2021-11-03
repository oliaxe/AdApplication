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
    public partial class Form1 : Form
    {
        public string _sqlConnectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(_sqlConnectionString);
            NoUser();
        }
        private void Search_click(object sender, EventArgs e)
        {
            Search();
        }
        private void delete_click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("User: " + User1.GetUser().Username.Trim()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("spDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Title", Titlebox.SelectedItem));
                    cmd.Parameters.Add(new SqlParameter("@Username", User1.GetUser().Username));
                    SqlDataReader reader = cmd.ExecuteReader();
                    Titlebox.Items.Remove(Titlebox.Items[Titlebox.SelectedIndex]);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("You can only delete your own ads.");
            }
            textBox2.Clear();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = '" + usertxt.Text + "' AND password = '" + pwdtxt.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                LoginHide();
                MessageBox.Show("You are now logged in.");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User1.GetUser().Password = reader.GetValue(0).ToString().Trim();
                    User1.GetUser().Name = reader.GetValue(1).ToString().Trim();
                    User1.GetUser().Address = reader.GetValue(2).ToString().Trim();
                    User1.GetUser().Username = reader.GetValue(3).ToString().Trim();
                    usernametxt.Text = reader.GetValue(3).ToString().Trim();
                    label1.Text = "Welcome " + User1.GetUser().Name;
                }
            }
            else
            {
                MessageBox.Show("Wrong credentials, please try again.");
            }
            conn.Close();
        }
        private void saveAdbtn_Click(object sender, EventArgs e)
        {
            AddAd();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            updateADbtn.Show();
            saveAdbtn.Hide();
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("select username, title, categoryname, price, information from ads where title = '"
                + Titlebox.SelectedItem + "'", conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString().Trim() == User1.GetUser().Username)
                    {
                        usernametxt.Text = reader.GetValue(0).ToString().Trim();
                        titletxt.Text = reader.GetValue(1).ToString().Trim();
                        category.Text = reader.GetValue(2).ToString().Trim();
                        pricetxt.Text = reader.GetValue(3).ToString().Trim();
                        infotxt.Text = reader.GetValue(4).ToString().Trim();
                    }
                    else
                    {
                        MessageBox.Show("You can only update your own ads.");
                        break;
                    }
                }
                reader.Close();
            }
            conn.Close();
        }
        private void UpdateAD_Click(object sender, EventArgs e)
        {
            titletxt.Show();
            textBox2.Clear();
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("spUpdate", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CategoryName", category.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Title", titletxt.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Price", pricetxt.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Information", infotxt.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Date", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@LTitle", Titlebox.SelectedItem));

                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Update successful.");
            }
            conn.Close();
        }
        private void searchtxt_MouseClick(object sender, MouseEventArgs e)
        {
            searchtxt.Clear();
        }
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You logged out.");
            usertxt.Clear();
            pwdtxt.Clear();
            NoUser();
        }
        private void Titlebox_Click(object sender, EventArgs e)
        {
            ShowAd1();
        }
        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titlebox.Items.Clear();
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("select title from ads where categoryname = '" + categoryBox.Text + "' order by " + SortBox.Text + " DESC", conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Titlebox.Items.Add(reader.GetValue(0));
                }
                reader.Close();
            }
            if (categoryBox.Text == "All categories")

                using (SqlCommand cmd = new SqlCommand("select title from Ads order by " + SortBox.Text + " DESC", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Titlebox.Items.Add(reader.GetValue(0));
                    }
                    reader.Close();
                }
            conn.Close();
        }
        private void CategoryBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void register_btn_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
        }
        public void AddAd()
        {
            textBox2.Clear();

            conn.Open();
            using (SqlCommand cmd = new SqlCommand("spAdd", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", User1.GetUser().Username));
                cmd.Parameters.Add(new SqlParameter("@CategoryName", category.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Title", titletxt.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Price", pricetxt.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Information", infotxt.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Date", DateTime.Now));
                SqlDataReader reader = cmd.ExecuteReader();
            }
            conn.Close();
            titletxt.Clear();
            pricetxt.Clear();
            infotxt.Clear();
            MessageBox.Show("Your ad was added.");
        }
        public void ShowAd1()
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("select username, categoryname, title, information, price, date from ads where title = '" + Titlebox.SelectedItem + "'", conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = "User: " + reader.GetValue(0).ToString().Trim() +
                   "\r\nCategory: " + reader.GetValue(1).ToString().Trim() +
                        "\r\nProduct: " + reader.GetValue(2).ToString().Trim() +
                        "\r\nInformation: " + reader.GetValue(3).ToString().Trim() +
                        "\r\nPrice: " + reader.GetValue(4).ToString().Trim() + " SEK" +
                    "\r\nDate: " + reader.GetValue(5).ToString().Trim();
                }
                reader.Close();
            }
            conn.Close();
        }
        private void Search()
        {
            textBox2.Clear();
            Titlebox.Items.Clear();
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("select title from Ads Where title LIKE '%" + searchtxt.Text + "%' and categoryname LIKE '%" + categoryBox.Text + "%'", conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Titlebox.Items.Add(reader.GetValue(0));
                }
                reader.Close();
            }
            if (categoryBox.Text == "All categories")
            {
                using (SqlCommand cmd = new SqlCommand("select title from Ads Where title LIKE '%" + searchtxt.Text + "%'", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Titlebox.Items.Add(reader.GetValue(0));
                    }
                    reader.Close();
                }
            }
            conn.Close();
        }
        public void LoginHide()
        {
            usertxt.Hide();
            pwdtxt.Hide();
            button3.Hide();
            button2.Show();
            deletebtn.Show();
            label6.Hide();
            label5.Hide();
            label12.Hide();
            usernametxt.Show();
            category.Show();
            titletxt.Show();
            pricetxt.Show();
            infotxt.Show();
            saveAdbtn.Show();
            label8.Show();
            label7.Show();
            label11.Show();
            label9.Show();
            pictureBox1.Hide();
            label4.Hide();
            updateADbtn.Hide();
            register_btn.Hide();
            label2.Hide();
            logoutbtn.Show();
            button3.Hide();
            label16.Show();
        }
        public void NoUser()
        {
            label4.Text = "Log in for more features.";
            button2.Hide();
            deletebtn.Hide();
            label12.Hide();
            usernametxt.Hide();
            category.Hide();
            titletxt.Hide();
            pricetxt.Hide();
            infotxt.Hide();
            saveAdbtn.Hide();
            label8.Hide();
            label7.Hide();
            label11.Hide();
            label9.Hide();
            updateADbtn.Hide();
            label16.Hide();
            label18.Hide();
            pictureBox1.Show();
            usertxt.Show();
            pwdtxt.Show();
            register_btn.Show();
            label2.Show();
            logoutbtn.Hide();
            button3.Show();
            titletxt.Clear();
            pricetxt.Clear();
            infotxt.Clear();
            Titlebox.Items.Clear();
            textBox2.Clear();
            label1.Text = "Login to create and update ads";
        }
    }
}
