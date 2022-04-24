using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class ChatWindow : Form
    {
        string userName;
        Database database = new Database();
        bool isMessageSend = false;
        public ChatWindow(string name)
        {
            userName = name;
            InitializeComponent();
        }
        public void LoadMessages()
        {
            
            foreach (var message in database.Messages)
            {
                Chat.Items.Add(message.UserName + ": " + message.Message);
            }
        }
        private void ChatWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Sending_Click(object sender, EventArgs e)
        {
            if (isMessageSend != true)
            {
                isMessageSend = false;
                LoadMessages();
            }
            Chat.Items.Add(userName + ": " + Message.Text + "\n");
            Messages messages = new Messages() { UserName = userName, Message = Message.Text };
            database.InsertMessage(messages);
            Message.Clear();
        }
    }
}
