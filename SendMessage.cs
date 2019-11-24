using System;
using System.Security.Cryptography;

using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace DogeBanking
{
  

    public partial class SendMessage : Form
    {


        
        public string recivertext;
        public string sendertext;


        MySqlConnection connection = new MySqlConnection("Data Source=localhost;Initial Catalog=dogebank;User ID=root; Password=;  convert zero datetime=True");

        public SendMessage(string Sender, string Reciver)
        {
            InitializeComponent();
            textBox1.Focus();
            textBox1.Select(0, 0);
            reciver_lable.Text = "Send to: " + Reciver;
            sendertext = Sender;
            recivertext = Reciver;
            MessageRead.ScrollBars = ScrollBars.Both;
            


            InitTimer();


        }

        private System.Windows.Forms.Timer timer1;

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readmessages();
            
        }


        private void readmessages() {
            MessageRead.Clear();
            MessageRead.ScrollToCaret();
            string Read_Query = "select * from comments where Sender_ID = '" + sendertext + "' and Reciver_ID = '" + recivertext + "' or Sender_ID = '"+recivertext+"' and Reciver_ID = '"+sendertext +"' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Read_Query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();

            
            DateTime today = DateTime.Now;


            string text;

            while (dr.Read())   
            {
              


                DateTime date_sent = (DateTime)dr["Date_sent"];
                MessageRead.Text += date_sent.ToString("dddd HH:mm");
                MessageRead.Text += ": ";
                MessageRead.Text += dr["Sender_ID"].ToString();
                MessageRead.Text += ": ";
                if (dr["Important"].ToString() == "1")
                {
                    MessageRead.Text += "<<<IMPORTANT>>>";

                }
               string message  = dr["message"].ToString();
  


                using (Aes myAes = Aes.Create())
                  {
             
                      text = SendClass.Decrypt(message);
                  }

                MessageRead.Text += text.ToString();
  
                if (dr["Important"].ToString() == "1")
                {
                    MessageRead.Text += "<<<IMPORTANT>>>";

                }
                MessageRead.Text += (Environment.NewLine);
               
            }

            connection.Close();


        }

        private void MessageRead_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               
            
        }


 

        private void Send_button_Click(object sender, EventArgs e)
        {

          
            DateTime today = DateTime.Now;
            int checkbox = 0 ;
            string encrypted_message;
            string message = textBox1.Text;

            using (Aes myAes = Aes.Create())
            {

                encrypted_message = SendClass.Encrypt(message);
            }
            
            
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
                MySqlCommand comm = connection.CreateCommand();
                comm.CommandText = "INSERT INTO comments(Sender_ID,Reciver_ID, Message,Important ,Date_sent) VALUES(?sendertext, ?recivertext, ?encrypted_message, ?checkbox, ?date)";
                comm.Parameters.AddWithValue("?sendertext", sendertext);
                comm.Parameters.AddWithValue("?recivertext", recivertext);
                comm.Parameters.AddWithValue("?encrypted_message", encrypted_message);
          
                comm.Parameters.AddWithValue("?checkbox", checkbox);
                comm.Parameters.AddWithValue("?date", strtoday);
                comm.ExecuteNonQuery();

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
