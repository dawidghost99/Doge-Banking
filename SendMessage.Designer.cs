namespace DogeBanking
{
    partial class SendMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageRead = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.reciver_lable = new System.Windows.Forms.Label();
            this.FlagBox = new System.Windows.Forms.CheckBox();
          
            // 
            // MessageRead
            // 
            this.MessageRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MessageRead.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MessageRead.Location = new System.Drawing.Point(104, 55);
            this.MessageRead.Multiline = true;
            this.MessageRead.Name = "MessageRead";
            this.MessageRead.PlaceholderText = "No Messages. Much Empty :(";
            this.MessageRead.ReadOnly = true;
            this.MessageRead.Size = new System.Drawing.Size(577, 303);
            this.MessageRead.TabIndex = 0;
            this.MessageRead.TextChanged += new System.EventHandler(this.MessageRead_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(104, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.MaxLength = 255;
            this.textBox1.PlaceholderText = "Your Message";
            this.textBox1.Size = new System.Drawing.Size(499, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(609, 364);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(72, 62);
            this.Send_button.TabIndex = 2;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // reciver_lable
            // 
            this.reciver_lable.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reciver_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reciver_lable.Location = new System.Drawing.Point(104, 7);
            this.reciver_lable.Name = "reciver_lable";
            this.reciver_lable.Size = new System.Drawing.Size(482, 45);
            this.reciver_lable.TabIndex = 3;
            this.reciver_lable.Text = "label1";
            this.reciver_lable.Click += new System.EventHandler(this.reciver_lable_Click);
            // 
            // FlagBox
            // 
            this.FlagBox.AutoSize = true;
            this.FlagBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FlagBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FlagBox.ForeColor = System.Drawing.Color.White;
            this.FlagBox.Location = new System.Drawing.Point(687, 364);
            this.FlagBox.Name = "FlagBox";
            this.FlagBox.Size = new System.Drawing.Size(87, 48);
            this.FlagBox.TabIndex = 4;
            this.FlagBox.Text = "Mark Message\r\nas Urgent";
            this.FlagBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FlagBox.UseVisualStyleBackColor = false;
            this.FlagBox.CheckedChanged += new System.EventHandler(this.FlagBox_CheckedChanged);
            // 
            // listBox1
            // 

            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.FlagBox);
            this.Controls.Add(this.reciver_lable);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MessageRead);
            this.Name = "SendMessage";
            this.Text = "SendMessage";

        }

        #endregion

        private System.Windows.Forms.TextBox MessageRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Label reciver_lable;
        private System.Windows.Forms.CheckBox FlagBox;
   
    }
}