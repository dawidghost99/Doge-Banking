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
            this.Important = new System.Windows.Forms.CheckBox();
            // 
            // MessageRead
            // 
            this.MessageRead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MessageRead.Location = new System.Drawing.Point(104, 46);
            this.MessageRead.Multiline = true;
            this.MessageRead.Name = "MessageRead";
            this.MessageRead.PlaceholderText = "No Messages. Much Empty :(";
            this.MessageRead.ReadOnly = true;
            this.MessageRead.Size = new System.Drawing.Size(577, 312);
            this.MessageRead.TabIndex = 0;
            this.MessageRead.TextChanged += new System.EventHandler(this.MessageRead_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Your Message";
            this.textBox1.Size = new System.Drawing.Size(499, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
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
            this.reciver_lable.Location = new System.Drawing.Point(104, -2);
            this.reciver_lable.Name = "reciver_lable";
            this.reciver_lable.Size = new System.Drawing.Size(482, 45);
            this.reciver_lable.TabIndex = 3;
            this.reciver_lable.Text = "label1";
            this.reciver_lable.Click += new System.EventHandler(this.reciver_lable_Click);
            // 
            // Important
            // 
            this.Important.AutoSize = true;
            this.Important.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Important.Location = new System.Drawing.Point(687, 372);
            this.Important.Name = "Important";
            this.Important.Size = new System.Drawing.Size(82, 48);
            this.Important.TabIndex = 4;
            this.Important.Text = "Flag Message\r\nas Important";
            this.Important.UseVisualStyleBackColor = true;
            this.Important.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Important);
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
        private System.Windows.Forms.CheckBox Important;
    }
}