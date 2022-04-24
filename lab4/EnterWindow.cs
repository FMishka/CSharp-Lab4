using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class EnterWindow : Form
    {
        Database Database = new Database();
        public EnterWindow()
        {
            InitializeComponent();
        }
        private void Register_Click(object sender, EventArgs e)
        {
            
            bool err = false;
            if (Login.Text is "" || Password.Text is "")
            {
                MessageBox.Show("Вы не ввели логин или пароль!");
            }
            else
            {
                foreach (var nowUser in Database.Users)
                {
                    if (Login.Text == nowUser.login)
                    {
                        err = true;
                        MessageBox.Show("Логин уже занят!");
                    }
                }
                if (err != true)
                {
                    Users user = new Users() { login = Login.Text, password = Password.Text };
                    Database.InsertUser(user);
                    ChatWindow chat = new ChatWindow(Login.Text);
                    this.Hide();
                    chat.Show();
                }
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            bool err = false;
            if (Login.Text is "" || Password.Text is "")
            {
                MessageBox.Show("Вы не ввели логин или пароль!");
            }
            else
            {
                foreach (var nowUser in Database.Users)
                {
                    if (Login.Text == nowUser.login || Password.Text == nowUser.password)
                    {
                        err = false;
                    }
                }
                if (err == false)
                {
                    ChatWindow chat = new ChatWindow(Login.Text);
                    chat.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно!");
                }
            }
        }
    }
}
