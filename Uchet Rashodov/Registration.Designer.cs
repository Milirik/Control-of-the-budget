namespace Uchet_Rashodov
{
    partial class Registration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.registrate_button = new System.Windows.Forms.Button();
            this.r_password = new System.Windows.Forms.TextBox();
            this.r_login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.registrate_button);
            this.groupBox1.Controls.Add(this.r_password);
            this.groupBox1.Controls.Add(this.r_login);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Location = new System.Drawing.Point(133, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(400, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry your data";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 272);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Нет";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(192, 244);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 21);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Да";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 68);
            this.label2.TabIndex = 7;
            this.label2.Text = "Войти ли сразу под этим \r\nлогином на главную\r\nстраницу после\r\nрегистрации?\r\n";
            // 
            // registrate_button
            // 
            this.registrate_button.Location = new System.Drawing.Point(279, 265);
            this.registrate_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrate_button.Name = "registrate_button";
            this.registrate_button.Size = new System.Drawing.Size(100, 28);
            this.registrate_button.TabIndex = 4;
            this.registrate_button.Text = "Registrate";
            this.registrate_button.UseVisualStyleBackColor = true;
            this.registrate_button.Click += new System.EventHandler(this.registrate_button_Click);
            // 
            // r_password
            // 
            this.r_password.Location = new System.Drawing.Point(84, 123);
            this.r_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r_password.Name = "r_password";
            this.r_password.Size = new System.Drawing.Size(293, 22);
            this.r_password.TabIndex = 3;
            // 
            // r_login
            // 
            this.r_login.Location = new System.Drawing.Point(84, 62);
            this.r_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.r_login.Name = "r_login";
            this.r_login.Size = new System.Drawing.Size(293, 22);
            this.r_login.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(8, 127);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 17);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(35, 65);
            this.login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(47, 17);
            this.login.TabIndex = 0;
            this.login.Text = "Login:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registrate_button;
        private System.Windows.Forms.TextBox r_password;
        private System.Windows.Forms.TextBox r_login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}