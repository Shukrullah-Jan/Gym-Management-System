using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Gym_Management_System
{
    public partial class UCHome : UserControl
    {
        private DBAccess database = new DBAccess(Dashboard.dataSourcePath);
        private DataTable dtMembers;
        
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            dtMembers = new DataTable();

            try
            {
                string selectQuery = "Select * from " + Dashboard.accessTableName;
                database.readDatathroughAdapter(selectQuery, dtMembers);
                if (dtMembers.Rows.Count > 0) dgvAllMembers.DataSource = dtMembers;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

    }
}
