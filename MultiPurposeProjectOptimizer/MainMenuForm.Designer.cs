
namespace MultiPurposeProjectOptimizer
{
    partial class MainMenuForm
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
            this.ProjectAndPropertiesButton = new System.Windows.Forms.Button();
            this.SilverInputsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectAndPropertiesButton
            // 
            this.ProjectAndPropertiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectAndPropertiesButton.Location = new System.Drawing.Point(12, 71);
            this.ProjectAndPropertiesButton.Name = "ProjectAndPropertiesButton";
            this.ProjectAndPropertiesButton.Size = new System.Drawing.Size(406, 53);
            this.ProjectAndPropertiesButton.TabIndex = 0;
            this.ProjectAndPropertiesButton.Text = "Проекты и свойства";
            this.ProjectAndPropertiesButton.UseVisualStyleBackColor = true;
            this.ProjectAndPropertiesButton.Click += new System.EventHandler(this.ProjectAndPropertiesButton_Click);
            // 
            // SilverInputsButton
            // 
            this.SilverInputsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SilverInputsButton.Location = new System.Drawing.Point(12, 12);
            this.SilverInputsButton.Name = "SilverInputsButton";
            this.SilverInputsButton.Size = new System.Drawing.Size(406, 53);
            this.SilverInputsButton.TabIndex = 1;
            this.SilverInputsButton.Text = "Решение задач";
            this.SilverInputsButton.UseVisualStyleBackColor = true;
            this.SilverInputsButton.Click += new System.EventHandler(this.SilverInputsButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 142);
            this.Controls.Add(this.SilverInputsButton);
            this.Controls.Add(this.ProjectAndPropertiesButton);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProjectAndPropertiesButton;
        private System.Windows.Forms.Button SilverInputsButton;
    }
}