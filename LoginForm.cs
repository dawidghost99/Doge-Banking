using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Sql;
//using System.Data.OleDb;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using MySql.Data.Entity;
using System.IO;
using System.Security.Cryptography;





namespace DogeBanking
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=localhost:3306;Initial Catalog=dogebank;User ID=root;Password=";


            Image image = Image.FromFile("dogelogo.jpg");
            Logo.Image = image;
            Delete();

        }
        DataTable DeleteTable = new DataTable();
        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;convert zero datetime=True");

       MySqlDataAdapter adapter;
       DataTable table = new DataTable();

        private void Delete() {
            string Query = "select ID, Date_sent from comments";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<int> Delete_comments_ID = new List<int>();

            DateTime Today = DateTime.Now;
            DateTime expiration = Today.AddMonths(-6);

            while (dr.Read())
            {
                int ID = (int)dr["ID"];
                DateTime date_sent = (DateTime)dr["Date_sent"];

                int expirationdate = DateTime.Compare(expiration, date_sent);

                if (expirationdate > 0)
                {


                
                    Delete_comments_ID.Add(ID);

                }


            }
            dr.Close();

            for (var i = 0; i < Delete_comments_ID.Count; i++)
            {

                MySqlCommand Delete = new MySqlCommand("Delete from comments where ID = '" + Delete_comments_ID[i] + "' and Important = '0'", connection);
                Delete.ExecuteNonQuery();


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        static string SHA512h(string rawData)
        {
            // Create a SHA256   
            using (SHA512 sHash = SHA512.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sHash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string salted = ("EzLQQvNebP" + password + "8bH74LNo1M");
            string hashedPassword = SHA512h(salted);
       
            MySqlCommand comm = connection.CreateCommand();
            comm = new MySqlCommand("SELECT Username, psw FROM users WHERE Username=@val1 AND psw=@val2", connection);
            comm.Parameters.AddWithValue("@val1", username);
            comm.Parameters.AddWithValue("@val2", hashedPassword);
            comm.Prepare();


            MySqlDataAdapter dap = new MySqlDataAdapter();
            dap.SelectCommand = comm;
            
            dap.Fill(table);
           

        
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username Or Password");
            }

            else
            {
                 
                
                this.Hide();
                table.Clear();
                MainPage mainpage = new MainPage(username);
                mainpage.ShowDialog();

            }




        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
