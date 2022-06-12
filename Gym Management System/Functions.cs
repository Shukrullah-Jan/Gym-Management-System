using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Gym_Management_System
{
    internal class Functions
    {
        private DBAccess database = new DBAccess(Dashboard.dataSourcePath);
        // functions for returning unique registration number 
        public int getNewRegistrationNumber()
        {
            DataTable dtRegNumbers = new DataTable();
            string query = "Select " +Constants.COL_REG_NO + " from " + Dashboard.accessTableName;
            int oldRegNumber = 0;

            try
            {
                database.readDatathroughAdapter(query, dtRegNumbers);

                if (dtRegNumbers.Rows.Count > 0)
                {
                    try
                    {
                        foreach (DataRow row in dtRegNumbers.Rows)
                        {

                            oldRegNumber = int.Parse(row[Constants.COL_REG_NO].ToString());
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                return ++oldRegNumber;

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Can't read reg.no column\n" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ++oldRegNumber;

        }

        // function to get a valid student ID for new students
        public int getNewMemberID()
        {
            DataTable dtMemberID = new DataTable();
            string query = "Select "+ Constants.COL_MEMBER_ID + " from " + Dashboard.accessTableName;

            List<int> ids = new List<int>();
            int id = 1;
            int i;

            try
            {
                database.readDatathroughAdapter(query, dtMemberID);

                if (dtMemberID.Rows.Count > 0)
                {
                    foreach (DataRow row in dtMemberID.Rows)
                    {
                        string memberID = row[Constants.COL_MEMBER_ID].ToString();

                        try
                        {
                            i = int.Parse(memberID.Trim());
                            ids.Add(i);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }

                    }

                    for (id = 1; id <= ids.Count; id++)
                    {
                        if (!(ids.Contains(id)))
                        {
                            return id;
                        }
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Can't read member ID column\n" + ex.Message);

            }

            return id++;

        }

        // if ID exists return ID
        // else -1
        public int checkMemberIDInDatabase(int oldID)
        {
            DataTable dtMemberIDs = new DataTable();
            string query = "Select " + Constants.COL_MEMBER_ID + " from " + Dashboard.accessTableName;

            List<int> ids = new List<int>();
            int i;

            try
            {
                database.readDatathroughAdapter(query, dtMemberIDs);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Can't read member ID column\n" + ex.Message);
                return -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!\n"+ex.Message);
                return -1;
            }


            if (dtMemberIDs.Rows.Count > 0)
            {
                foreach (DataRow row in dtMemberIDs.Rows)
                {
                    string memberID = row[Constants.COL_MEMBER_ID].ToString();

                    try
                    {
                        i = int.Parse(memberID.Trim());
                        ids.Add(i);
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }


            if (ids.Contains(oldID)) return oldID;

            return -1;
        }


        public static Boolean areColumnNamesValid(Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            try
            {
                if (dgv.Columns["ID"] != null && dgv.Columns["studentName"] != null &&
                  dgv.Columns["fatherName"] != null && dgv.Columns["studentID"] != null &&
                 dgv.Columns["program"] != null && dgv.Columns["duration"] != null &&
                 dgv.Columns["timing"] != null && dgv.Columns["amount"] != null &&
                 dgv.Columns["paid"] != null && dgv.Columns["admissionDate"] != null &&
                 dgv.Columns["phoneNumber"] != null &&
                 dgv.Columns["cashier"] != null && dgv.Columns["notePrice"] != null &&
                 dgv.Columns["studentAddress"] != null && dgv.Columns["picture"] != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public string getAvailableDriveName()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Boolean isCDriveReady = false;

            foreach (DriveInfo d in allDrives)
            {

                //Console.WriteLine("Drive {0}", d.Name);
                //Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {

                    if (d.Name != "C:\\" && d.TotalFreeSpace >= 1000000000 && d.DriveType == DriveType.Fixed)
                    {
                        return d.Name;
                    }

                    if (d.Name == "C:\\" && d.TotalFreeSpace >= 5000000000 && d.DriveType == DriveType.Fixed)
                    {
                        isCDriveReady = true;
                    }

                    //Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    //Console.WriteLine("  File system: {0}", d.DriveFormat);
                    //Console.WriteLine(
                    //    "  Available space to current user:{0, 15} bytes",
                    //    d.AvailableFreeSpace);

                    //Console.WriteLine(
                    //    "  Total available space:          {0, 15} bytes",
                    //    d.TotalFreeSpace);

                    //Console.WriteLine(
                    //    "  Total size of drive:            {0, 15} bytes ",
                    //    d.TotalSize);
                }
                else
                {
                    MessageBox.Show("No drive in your computer is ready or drives are out of minimum space for this operation\nStop any file operation and try again", "Drives are not ready");
                }

            }

            if (isCDriveReady == true) return "C:\\";

            return "";
        }
    }
}
