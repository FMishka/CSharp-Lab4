namespace lab4
{
    partial class ChatWindow
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
            this.Chat = new System.Windows.Forms.ListBox();
            this.Sending = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Chat
            // 
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 15;
            this.Chat.Location = new System.Drawing.Point(12, 12);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(776, 364);
            this.Chat.TabIndex = 2;
            // 
            // Sending
            // 
            this.Sending.Location = new System.Drawing.Point(713, 382);
            this.Sending.Name = "Sending";
            this.Sending.Size = new System.Drawing.Size(75, 23);
            this.Sending.TabIndex = 3;
            this.Sending.Text = "Отправить";
            this.Sending.UseVisualStyleBackColor = true;
            this.Sending.Click += new System.EventHandler(this.Sending_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 382);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(695, 23);
            this.Message.TabIndex = 4;
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Sending);
            this.Controls.Add(this.Chat);
            this.Name = "ChatWindow";
            this.Text = "ChatWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Chat;
        private System.Windows.Forms.Button Sending;
        private System.Windows.Forms.TextBox Message;
    }
}
