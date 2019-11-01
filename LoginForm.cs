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





namespace DogeBanking
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=localhost:3306;Initial Catalog=dogebank;User ID=root;Password=";




        }
        
        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;");

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        


   
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

        private void button1_Click(object sender, EventArgs e)
        {


            string username = textBox1.Text;
            string password = textBox2.Text;


            adapter = new MySqlDataAdapter("SELECT Username, psw FROM users WHERE Username = '" + username + "' AND psw = '" + password + "'", connection);

           // string test_str = "input: " + username + " " + password ;

           // MessageBox.Show(test_str);

           // Console.WriteLine(table);
            adapter.Fill(table);


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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                MessageBox.Show(ex.Message); //shows what error actually occurs
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
