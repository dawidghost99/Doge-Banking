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
        DataTable SendTable = new DataTable();
        //DataTable ReadTable = new DataTable();


        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;  convert zero datetime=True");
        MySqlDataAdapter Send;
        
        
        public SendMessage(string Sender, string Reciver)
        {
            InitializeComponent();


            reciver_lable.Text = "Send to: " + Reciver;
             sendertext = Sender;
            recivertext = Reciver;
            MessageRead.ScrollBars = ScrollBars.Both;

            readmessages();
           

        }

        private void readmessages() {
            MessageRead.Clear();
            string Read_Query = "select * from comments where Sender_ID = '" + sendertext + "' and Reciver_ID = '" + recivertext + "' or Sender_ID = '"+recivertext+"' and Reciver_ID = '"+sendertext +"' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Read_Query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();

            
            DateTime today = DateTime.Now;




            while (dr.Read())
            {
              
                if (dr["Important"].ToString() == "1") {
                    MessageRead.Text += "!!!";
                   // MessageRead.BackColor = Color.Red;
                }
                //MessageRead.BackColor = Color.Red;
                DateTime date_sent = (DateTime)dr["Date_sent"];
                MessageRead.Text += date_sent.ToString("HH:mm:ss");
                MessageRead.Text += ": ";
                MessageRead.Text += dr["Sender_ID"].ToString();
                MessageRead.Text += ": ";
                MessageRead.Text += dr["message"].ToString();
                MessageRead.Text += "\r\n";
              
            }


           // MessageRead.Text += "test \r\n";


            connection.Close();


        }

        private void MessageRead_TextChanged(object sender, EventArgs e)
        {
            

            // Read = new MySqlDataAdapter("select * from comments where Sender_ID = '" + sendertext + "' and Reciver_ID = ' " +recivertext+ "' ", connection);
            // Read.Fill(ReadTable);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void Send_button_Click(object sender, EventArgs e)
        {

          
            DateTime today = DateTime.Now;
           // MessageBox.Show(today.ToString());
            int checkbox = 0 ;
            string message = textBox1.Text;


           
          string strtoday = today.ToString("yyyy-MM-dd HH:mm:ss tt");


            if (FlagBox.Checked) {


                checkbox = 1;


            }

            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Can't send nothing!");
            }


            else
            {
                connection.Open();
                Send = new MySqlDataAdapter("Insert into comments(Sender_ID,Reciver_ID, Message,Important ,Date_sent) values ('" + sendertext + "' , '" + recivertext + "' , '" + message + "' , '" + checkbox + "' ,  '" + strtoday + "') ", connection);


                Send.Fill(SendTable);
                connection.Close();
            }

            FlagBox.Checked = false;
            textBox1.Clear();
            readmessages();


        }
        private void reciver_lable_Click(object sender, EventArgs e)
        {

        }

        private void FlagBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
