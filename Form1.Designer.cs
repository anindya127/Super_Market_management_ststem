namespace Supermarketinventory
{
    partial class Form1
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
            username = new TextBox();
            passwd = new TextBox();
            Login = new Label();
            label1 = new Label();
            label2 = new Label();
            role = new ComboBox();
            loginbut = new Button();
            clear = new Button();
            message = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(501, 183);
            username.Name = "username";
            username.Size = new Size(242, 27);
            username.TabIndex = 0;
            // 
            // passwd
            // 
            passwd.Location = new Point(501, 260);
            passwd.Name = "passwd";
            passwd.Size = new Size(242, 27);
            passwd.TabIndex = 1;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = SystemColors.Control;
            Login.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Login.Location = new Point(584, 34);
            Login.Name = "Login";
            Login.Size = new Size(78, 32);
            Login.TabIndex = 2;
            Login.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 186);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 263);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // role
            // 
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Admin", "Seller" });
            role.Location = new Point(501, 116);
            role.Name = "role";
            role.Size = new Size(242, 28);
            role.TabIndex = 5;
            role.Text = "Select Role";
            role.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // loginbut
            // 
            loginbut.Font = new Font("Segoe UI", 12F);
            loginbut.Location = new Point(568, 332);
            loginbut.Name = "loginbut";
            loginbut.Size = new Size(94, 41);
            loginbut.TabIndex = 6;
            loginbut.Text = "Login";
            loginbut.UseVisualStyleBackColor = true;
            loginbut.Click += loginbut_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 12F);
            clear.Location = new Point(568, 379);
            clear.Name = "clear";
            clear.Size = new Size(94, 41);
            clear.TabIndex = 7;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // message
            // 
            message.Font = new Font("Segoe UI", 20F);
            message.Location = new Point(36, 82);
            message.Name = "message";
            message.Size = new Size(292, 257);
            message.TabIndex = 8;
            message.Text = "Welcome to Supermarket Inventory Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(770, 9);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 9;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(message);
            Controls.Add(clear);
            Controls.Add(loginbut);
            Controls.Add(role);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(passwd);
            Controls.Add(username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox passwd;
        private Label Login;
        private Label label1;
        private Label label2;
        private ComboBox role;
        private Button loginbut;
        private Button clear;
        private Label message;
        private Label label3;
    }
}
