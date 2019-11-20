namespace Uchet_Rashodov
{
    partial class Enter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registration_label_link = new System.Windows.Forms.LinkLabel();
            this.login_button = new System.Windows.Forms.Button();
            this.password1 = new System.Windows.Forms.TextBox();
            this.login1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registration_label_link);
            this.groupBox1.Controls.Add(this.login_button);
            this.groupBox1.Controls.Add(this.password1);
            this.groupBox1.Controls.Add(this.login1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Location = new System.Drawing.Point(100, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry your data";
            // 
            // registration_label_link
            // 
            this.registration_label_link.AutoSize = true;
            this.registration_label_link.Location = new System.Drawing.Point(60, 141);
            this.registration_label_link.Name = "registration_label_link";
            this.registration_label_link.Size = new System.Drawing.Size(63, 13);
            this.registration_label_link.TabIndex = 1;
            this.registration_label_link.TabStop = true;
            this.registration_label_link.Text = "Registration";
            this.registration_label_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_label_link_LinkClicked);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(209, 161);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(63, 105);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(221, 20);
            this.password1.TabIndex = 3;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(63, 52);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(221, 20);
            this.login1.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(6, 108);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(26, 55);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(36, 13);
            this.login.TabIndex = 0;
            this.login.Text = "Login:";
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Enter";
            this.Text = "Enter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox login1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.LinkLabel registration_label_link;
    }
}

