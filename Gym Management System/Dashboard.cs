using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System.User_Controls;
using Gym_Management_System.Properties;
using System.IO;
using System.Data.OleDb;

namespace Gym_Management_System
{
    public partial class Dashboard : Form
    {
        DBAccess database;
        private Functions functions = new Functions();
        private DataTable dtMembers;

        // settings variables
        public static string dataSourcePath;
        public static string accessTableName;
        public static string databaseName;
        public static string imagesLocation;
        public static Boolean settingsState;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // check datasource related information
            settingsState = (Boolean)Settings.Default[Constants.SETTINGS_STATE];

            if (settingsState == false)
            {

                string imagesPath = Path.Combine(functions.getAvailableDriveName(), "Gym Management System\\RECORDS\\Members images");
                if (!(Directory.Exists(imagesPath)))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                imagesLocation = imagesPath;
                dataSourcePath = Path.Combine(functions.getAvailableDriveName(), "Gym Management System\\RECORDS\\Members Database.accdb");
                accessTableName = "members";
                databaseName = Path.GetFileName(dataSourcePath);

                // save settings
                Settings.Default[Constants.IMAGES_LOCATION] = imagesLocation;
                Settings.Default[Constants.DATASOURCE_PATH] = dataSourcePath;
                Settings.Default[Constants.ACCESS_TABLE_NAME] = accessTableName;
                // change settings state 
                Settings.Default[Constants.SETTINGS_STATE] = true;
                Settings.Default.Save();

            }
            else
            {

                dataSourcePath = Settings.Default[Constants.DATASOURCE_PATH].ToString();
                accessTableName = Settings.Default[Constants.ACCESS_TABLE_NAME].ToString();
                databaseName = Path.GetFileName(dataSourcePath);
                imagesLocation = Settings.Default[Constants.IMAGES_LOCATION].ToString();

                Settings.Default.Save();

            }

            database = new DBAccess(dataSourcePath);

            try
            {
                database.createConn();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Can't establish connection \nError in the Data source!!!\n\n" +
                    "Tip: go to settings and make sure the access database path and table name is correct\n" +
                    ex.Message, "Data source connection failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
      

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addUserControl(new UCHome());
        }


        private void btnAddMember_Click(object sender, EventArgs e)
        {
            addUserControl(new UCAddMember());
        }

        private void addUserControl(UserControl userControl)
        {
            // check user control type
            if (userControl is UCHome)
            {
                pbClose.Visible = false;
                lblUserControlName.Text = "HOME";
            }
            else if (userControl is UCAddMember)
            {
                lblUserControlName.Text = "ADD MEMBER";
                pbClose.Visible = true;
            }
            else if (userControl is UCSettings)
            {
                lblUserControlName.Text = "SETTINGS";
                pbClose.Visible = true;
            }
            else
            {
                pbClose.Visible = true;
            }

            userControl.Dock = DockStyle.Fill;
            panelUserControls.Controls.Clear();
            userControl.BringToFront();
            panelUserControls.Controls.Add(userControl);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            addUserControl(new UCSettings());
        }
    }


}
