
namespace MultiPurposeProjectOptimizer
{
    partial class DatabaseLogInForm
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
            this.ServerNameTextbox = new System.Windows.Forms.TextBox();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LocalServerCheckbox = new System.Windows.Forms.CheckBox();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.WindowsAuthCheckbox = new System.Windows.Forms.CheckBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServerNameTextbox
            // 
            this.ServerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerNameTextbox.Location = new System.Drawing.Point(231, 18);
            this.ServerNameTextbox.Name = "ServerNameTextbox";
            this.ServerNameTextbox.Size = new System.Drawing.Size(286, 31);
            this.ServerNameTextbox.TabIndex = 0;
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerNameLabel.Location = new System.Drawing.Point(28, 19);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(141, 25);
            this.ServerNameLabel.TabIndex = 1;
            this.ServerNameLabel.Text = "Имя сервера";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(28, 95);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(197, 25);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // LocalServerCheckbox
            // 
            this.LocalServerCheckbox.AutoSize = true;
            this.LocalServerCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalServerCheckbox.Location = new System.Drawing.Point(523, 18);
            this.LocalServerCheckbox.Name = "LocalServerCheckbox";
            this.LocalServerCheckbox.Size = new System.Drawing.Size(219, 29);
            this.LocalServerCheckbox.TabIndex = 3;
            this.LocalServerCheckbox.Text = "Локальный сервер";
            this.LocalServerCheckbox.UseVisualStyleBackColor = true;
            this.LocalServerCheckbox.CheckedChanged += new System.EventHandler(this.LocalServerCheckbox_CheckedChanged);
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameTextbox.Location = new System.Drawing.Point(231, 92);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(286, 31);
            this.UserNameTextbox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(28, 132);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextbox.Location = new System.Drawing.Point(231, 129);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(286, 31);
            this.PasswordTextbox.TabIndex = 6;
            // 
            // WindowsAuthCheckbox
            // 
            this.WindowsAuthCheckbox.AutoSize = true;
            this.WindowsAuthCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsAuthCheckbox.Location = new System.Drawing.Point(523, 95);
            this.WindowsAuthCheckbox.Name = "WindowsAuthCheckbox";
            this.WindowsAuthCheckbox.Size = new System.Drawing.Size(253, 29);
            this.WindowsAuthCheckbox.TabIndex = 7;
            this.WindowsAuthCheckbox.Text = "Авторизация Windows";
            this.WindowsAuthCheckbox.UseVisualStyleBackColor = true;
            this.WindowsAuthCheckbox.CheckedChanged += new System.EventHandler(this.WindwisAuthCheckbox_CheckedChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectButton.Location = new System.Drawing.Point(287, 174);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(181, 40);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя базы данных";
            // 
            // DatabaseNameTextbox
            // 
            this.DatabaseNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatabaseNameTextbox.Location = new System.Drawing.Point(231, 55);
            this.DatabaseNameTextbox.Name = "DatabaseNameTextbox";
            this.DatabaseNameTextbox.Size = new System.Drawing.Size(286, 31);
            this.DatabaseNameTextbox.TabIndex = 10;
            this.DatabaseNameTextbox.Text = "MPPOptimizerDB";
            // 
            // DatabaseLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 235);
            this.Controls.Add(this.DatabaseNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.WindowsAuthCheckbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.LocalServerCheckbox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ServerNameLabel);
            this.Controls.Add(this.ServerNameTextbox);
            this.Name = "DatabaseLogInForm";
            this.Text = "Подключение к базе данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseLogInForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerNameTextbox;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.CheckBox LocalServerCheckbox;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.CheckBox WindowsAuthCheckbox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DatabaseNameTextbox;
    }
}