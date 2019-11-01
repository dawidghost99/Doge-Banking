using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using MySql.Data.Entity;



namespace DogeBanking
{
    //private Connection connectionCS = new Connection();

    public partial class SendMessage : Form
    {
        public string recivertext;
        public string sendertext;
        DataTable table = new DataTable();
        

        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;");
        MySqlDataAdapter Send;
        MySqlDataAdapter Read;
        
        public SendMessage(string Sender, string Reciver)
        {
            InitializeComponent();


            reciver_lable.Text = "Send to: " + Reciver;
             sendertext = Sender;
            recivertext = Reciver;




        }

        private void MessageRead_TextChanged(object sender, EventArgs e)
        {
           MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;");
        
            Read = new MySqlDataAdapter("", connection);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void Send_button_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;
            int checkbox = 0;
            string message = textBox1.Text;

            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Can't send nothing!");
            }


            else
            {
                Send = new MySqlDataAdapter("Insert into comments(Sender_ID,Reciver_ID, Message,Important ,Date_sent) values (' " + sendertext + " ' , ' " + recivertext + "  ' , ' " + message + " ' , ' " + checkbox + " ' ,  ' " + today + " ') ", connection);


                Send.Fill(table);

            }
        }
        private void reciver_lable_Click(object sender, EventArgs e)
        {

        }


    }
}
