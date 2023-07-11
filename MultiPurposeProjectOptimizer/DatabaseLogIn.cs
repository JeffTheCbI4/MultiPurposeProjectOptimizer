using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPurposeProjectOptimizer
{
    public partial class DatabaseLogInForm : Form
    {
        Form PreviousForm;
        bool connectionSuccess = false;
        public DatabaseLogInForm(Form previousForm)
        {
            InitializeComponent();
            PreviousForm = previousForm;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            DBManager.User = "";
            DBManager.Password = "";
            DBManager.DataSource = "";
            DBManager.InitialCatalog = "";
            DBManager.IntegratedSecurity = false;

            if (LocalServerCheckbox.Checked)
            {
                string machineName = Environment.MachineName;
                DBManager.DataSource = machineName + "\\SQLEXPRESS";
            } else
            {
                DBManager.DataSource = ServerNameTextbox.Text;
            }

            DBManager.InitialCatalog = DatabaseNameTextbox.Text;

            if (WindowsAuthCheckbox.Checked)
            {
                DBManager.IntegratedSecurity = true;
            }
            else
            {
                DBManager.User = UserNameTextbox.Text;
                DBManager.Password = PasswordTextbox.Text;
            }

            /*DBManager.User = "USER-PC\\User";
            DBManager.Password = "";
            DBManager.DataSource = "USER-PC\\SQLEXPRESS";
            DBManager.InitialCatalog = "MPPOptimizerDB";
            DBManager.IntegratedSecurity = true;*/
            try
            {
                DBManager.ConnectToDB();
            } catch (Exception exception)
            {
                MessageBox.Show("Ошибка при подключении базы данных:\n" +
                    exception.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connectionSuccess = true;
            this.Close();
        }

        private void LocalServerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ServerNameTextbox.Enabled = !ServerNameTextbox.Enabled;
        }

        private void WindwisAuthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UserNameTextbox.Enabled = !UserNameTextbox.Enabled;
            PasswordTextbox.Enabled = !PasswordTextbox.Enabled;
        }

        private void DatabaseLogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(connectionSuccess)
            {
                PreviousForm.Enabled = true;
            } else
            {
                PreviousForm.Close();
            }
        }
    }
}
