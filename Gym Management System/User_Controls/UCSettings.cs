using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System.Properties;

namespace Gym_Management_System.User_Controls
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();
        }

        private void UCSettings_Load(object sender, EventArgs e)
        {

            tbTableName.Enabled = false;
            tbDataSourcePath.Enabled = false;
            tbImagesLocation.Enabled = false;
            btnSubmit.Enabled = false;
            btnChangeDataSource.Enabled = false;
            btnChangeImagesLocation.Enabled = false;


            // passwords
            tbCurrentPassword.Enabled = false;
            tbNewPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;
            btnChangePassword.Enabled = false;


            // user passwords
            tbCurrentPasswordUser.Enabled = false;
            tbNewPasswordUser.Enabled = false;
            tbConfirmPasswordUser.Enabled = false;
            btnChangePasswordUser.Enabled = false;
            btnResetUserPasssword.Enabled = false;

            // contact details
            tbContactNumber.Enabled = false;
            tbGymAddress.Enabled = false;
            btnChangeContactInfo.Enabled = false;
            // get data source info


            tbDataSourcePath.Text = Settings.Default[Constants.DATASOURCE_PATH].ToString();
            tbTableName.Text = Settings.Default[Constants.ACCESS_TABLE_NAME].ToString();
            tbImagesLocation.Text = Settings.Default[Constants.IMAGES_LOCATION].ToString();


            // get contact info
            tbContactNumber.Text = Settings.Default[Constants.CONTACT_NUMBER].ToString();
            tbGymAddress.Text = Settings.Default[Constants.GYM_ADDRESS].ToString();



            //if (SplashScreenForm.adminLogin == false)
            //{
            //    chbEnableEditing.Enabled = false;
            //    chbAdminChangePassword.Enabled = false;
            //    chbEnableContactControls.Enabled = false;

            //    tbAddNewProgram.Enabled = false;
            //    btnRemove.Enabled = false;

            //}
        }

        private void chbEnableEditing_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEnableEditing.Checked)
            {
                tbTableName.Enabled = true;
                tbDataSourcePath.Enabled = true;
                tbImagesLocation.Enabled = true;
                btnSubmit.Enabled = true;
                btnChangeDataSource.Enabled = true;
                btnChangeImagesLocation.Enabled = true;
            }
            else
            {
                tbTableName.Enabled = false;
                tbDataSourcePath.Enabled = false;
                tbImagesLocation.Enabled = false;
                btnSubmit.Enabled = false;
                btnChangeDataSource.Enabled = false;
                btnChangeImagesLocation.Enabled = false;

            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to change data source, access table names and images location?\n" +
         "Changing data source will cause records to be inserted, upadated, deleted to a different database", "Change Datasource", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Dashboard.dataSourcePath = tbDataSourcePath.Text.Trim();
                Dashboard.accessTableName = tbTableName.Text.Trim();


                //images
                Dashboard.imagesLocation = tbImagesLocation.Text.Trim();
                Settings.Default[Constants.IMAGES_LOCATION] = tbImagesLocation.Text.Trim();

                Settings.Default[Constants.DATASOURCE_PATH] = tbDataSourcePath.Text.Trim();
                Settings.Default[Constants.ACCESS_TABLE_NAME] = tbTableName.Text.Trim();
                Settings.Default[Constants.SETTINGS_STATE] = true;
                Settings.Default.Save();

                chbEnableEditing.Checked = false;

                MessageBox.Show("Data source, access table names and images location has been changed successfully\nCurrent" +
                    "data source: " + tbDataSourcePath.Text +
                    "\nStudents tabel name: " + tbTableName.Text +
                    "\nCurrecnt Images Location: " + tbImagesLocation.Text);
            }

        }

        private void btnChangeDataSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Access files (*.accdb) | *.accdb";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbDataSourcePath.Text = fd.FileName;

            }
        }

        private void btnChangeImagesLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbImagesLocation.Text = dialog.SelectedPath;

            }
        }
    }
}
