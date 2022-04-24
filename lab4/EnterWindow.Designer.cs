namespace lab4
{
    partial class EnterWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 34);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(288, 23);
            this.Login.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 78);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(288, 23);
            this.Password.TabIndex = 2;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(92, 107);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(127, 23);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Вход";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(92, 136);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(127, 23);
            this.Register.TabIndex = 4;
            this.Register.Text = "Регистрация";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // EnterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Name = "EnterWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label2;
    }
}
