using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace DogeBanking
{
    public partial class MainPage : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;");

        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        public string usm;
        
        public MainPage(string username)
        {


            InitializeComponent();

             usm = username;

             Username_display.Text = username;

             adapter = new MySqlDataAdapter("SELECT Username FROM users WHERE Username !='" +usm+"'", connection);


             adapter.Fill(table);

             foreach (DataRow dataRow in table.Rows)
             {
                 foreach (var item in dataRow.ItemArray)
                 {
                     listBox1.Items.Add(item);
                 }
             }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            if (listBox1.SelectedItem != null)
            {
                string intended_sender = listBox1.SelectedItem.ToString();
                SendMessage send = new SendMessage(usm, intended_sender);
                send.Show();

            }

        }
    }
}
