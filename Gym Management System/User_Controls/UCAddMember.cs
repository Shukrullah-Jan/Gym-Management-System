using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Gym_Management_System.Properties;
using System.Data;



namespace Gym_Management_System.User_Controls
{
    public partial class UCAddMember : UserControl
    {
        private DBAccess database = new DBAccess(Dashboard.dataSourcePath);
        private Functions functions = new Functions();

        private string mID, mName, fatherName, admissionDate, gender, gymOrFitness, timing, phoneNumber,
           mAddress, mPicturePath, lockerNumber;

        private double fees = 0.0, otherExpenses = 0.0, paid = 0.0;

        // about image
        private Image image;

        // icons
        Bitmap bitmapIcon;
        Icon icon;


        public UCAddMember()
        {
            InitializeComponent();

            timePickerFrom.Format = DateTimePickerFormat.Custom;
            timePickerTo.Format = DateTimePickerFormat.Custom;
            timePickerFrom.CustomFormat = "hh:mm tt";
            timePickerTo.CustomFormat = "hh:mm tt";
            timePickerFrom.ShowUpDown = true;
            timePickerTo.ShowUpDown = true;
        }

        private void UCAddMember_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            rbGym.Checked = true;

            // locker
            chbLocker.Checked = false;
            tbLockerNumber.Enabled = false;
            tbLockerPrice.Enabled = false;

            // set current date for dtp
            dtpAddmissionDate.Text = DateTime.Now.ToShortDateString();

            // set error providers icons
            setIcons();

            // get new reg.no and ID from database
            // check new and old student
            rbNewMember.Checked = true;
            tbRegistrationNumber.Enabled = false;
            tbRegistrationNumber.Text = functions.getNewRegistrationNumber().ToString();

            if (rbNewMember.Checked)
            {
                tbMemberID.Enabled = false;
                tbMemberID.Text = functions.getNewMemberID().ToString();
                tbMemberName.Focus();

            }
            if (rbOldMember.Checked)
            {
                tbMemberID.Enabled = true;
                tbMemberID.Text = functions.getNewMemberID().ToString();

            }

            epMemberID.SetError(tbMemberID, "");
        }
        private void chbLocker_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLocker.Checked)
            {
                tbLockerNumber.Enabled = true;
                tbLockerPrice.Enabled = true;
            }
            else
            {
                tbLockerNumber.Enabled = false;
                tbLockerPrice.Enabled = false;
            }
        }

        private void timePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = timePickerFrom.Value;
            timePickerTo.Value = dt.AddHours(1);
        }

        private void rbNewMember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewMember.Checked)
            {
                tbRegistrationNumber.Text = functions.getNewRegistrationNumber().ToString();
                tbMemberID.Enabled = false;
                tbMemberID.Text = functions.getNewMemberID().ToString();
                epMemberID.SetError(tbMemberID, "");

            }
        }

        private void rbOldMember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOldMember.Checked)
            {

                tbMemberID.Enabled = true;

                try
                {
                    int oldID = int.Parse(tbMemberID.Text.Trim());
                    int result = functions.checkMemberIDInDatabase(oldID);


                    if (oldID < 1)
                    {
                        changeEPIconError(epMemberID);
                        epMemberID.SetError(tbMemberID, "Invalid ID\nID should not be 0 or negative numbers");

                        tbMemberID.Focus();
                        return;
                    }

                    if (!(result == -1))
                    {
                        changeEPIconTick(epMemberID);

                        epMemberID.SetError(tbMemberID, "Valid ID");
                        epMemberName.SetError(tbMemberName, "");
                        epFatherName.SetError(tbFatherName, "");

                    }
                    else
                    {
                        // epSID icon
                        changeEPIconError(epMemberID);
                        epMemberID.SetError(tbMemberID, "Invalid ID\nID does not exists in database");

                    }

                }
                catch (FormatException)
                {
                    // epSID icon

                    changeEPIconError(epMemberID);
                    epMemberID.SetError(tbMemberID, "Invalid ID\n" +
                                "ID should not contain letters");

                    tbMemberName.Text = "";
                    tbFatherName.Text = "";
                    epMemberName.SetError(tbMemberName, "");
                    epFatherName.SetError(tbFatherName, "");

                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    return;

                }

            }
        }

        private void tbMemberID_TextChanged(object sender, EventArgs e)
        {
            // Note: check whether rb unknown student id is checked or not
            try
            {

                int oldID = int.Parse(tbMemberID.Text.Trim());
                int result = functions.checkMemberIDInDatabase(oldID);
 
                if (oldID < 1)
                {
                    changeEPIconError(epMemberID);
                    epMemberID.SetError(tbMemberID, "Invalid ID\nID should not be 0 or negative numbers");

                    tbMemberID.Focus();
                    return;
                }

                if (rbOldMember.Checked)
                {
                    if (result == -1)
                    {
                        changeEPIconError(epMemberID);

                        epMemberID.SetError(tbMemberID, "Invalid ID\n" +
                            "Old member IDs should be inside database\ntry a different ID");
                        tbMemberName.Text = "";
                        tbFatherName.Text = "";
                        epMemberName.SetError(tbMemberName, "");
                        epFatherName.SetError(tbFatherName, "");
                        return;
                    }
                    else
                    {
                        // epSID icon
                        changeEPIconTick(epMemberID);
                        epMemberID.SetError(tbMemberID, "Valid ID");
                        DataTable dtStudentData = new DataTable();
                        string query = "Select * from " + Dashboard.accessTableName + " Where " +
                            Constants.COL_MEMBER_ID + " = '" + oldID.ToString() + "'";

                        database.readDatathroughAdapter(query, dtStudentData);

                        if (dtStudentData.Rows.Count > 0)
                        {
                            if (dtStudentData.Rows[0][Constants.COL_MEMBER_NAME].ToString().Equals(""))
                            {
                                tbMemberName.Text = "Unknown";
                            }
                            else
                            {
                                tbMemberName.Text = dtStudentData.Rows[0][Constants.COL_MEMBER_NAME].ToString();
                            }
                            if (dtStudentData.Rows[0][Constants.COL_FATHER_NAME].ToString().Equals(""))
                            {
                                tbFatherName.Text = "Unknown";
                            }
                            else
                            {
                                tbFatherName.Text = dtStudentData.Rows[0][Constants.COL_FATHER_NAME].ToString();
                            }

                        }

                    }

                }
            }
            catch (FormatException)
            {

                // epSID icon
                changeEPIconError(epMemberID);
                epMemberID.SetError(tbMemberID, "Invalid ID\n" +
                           "ID should not contain letters or whitespace");

                tbMemberName.Text = "";
                tbFatherName.Text = "";
                epMemberName.SetError(tbMemberName, "");
                epFatherName.SetError(tbFatherName, "");

                return;


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error!!!\n" + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add record to database?", "Add new record", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    database.createConn();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Can't establish connection\nTry Again\nTip: check access database path in settings" + ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't establish connection\nTry Again\n" + ex.Message);
                    return;
                }



                mID = tbMemberID.Text.Trim();
                mName = tbMemberName.Text.Trim();
                fatherName = tbFatherName.Text.Trim();
                admissionDate = dtpAddmissionDate.Text.Trim();
                gender = getGender();
                gymOrFitness = getGymOrFitness();
                timing = timePickerFrom.Text.Trim() + " To " + timePickerTo.Text.Trim();
                if (chbLocker.Checked) lockerNumber = tbLockerNumber.Text.Trim();
                else lockerNumber = "";
                phoneNumber = tbPhoneNumber.Text.Trim();
                mAddress = tbAddress.Text.Trim();



                // validation
                if (validateMemberID())
                {

                    if (validateMemberNameAndFatherName())
                    {

                        // validate fees, paid and noteprice controls
                        try
                        {
                            fees = double.Parse(tbFees.Text.Trim());
                        }
                        catch (FormatException)
                        {
                            fees = 0.0;
                        }
                        try
                        {
                            paid = double.Parse(tbPaid.Text.Trim());
                        }
                        catch (FormatException)
                        {
                            paid = 0.0;
                        }
                        try
                        {
                            otherExpenses = double.Parse(tbOtherExpenses.Text.Trim());
                        }
                        catch (FormatException)
                        {
                            otherExpenses = 0.0;
                        }

                        // deduct fees from total 
                        paid = paid - otherExpenses;


                        // all about image

                        string imagePath = "";
                        string imgLocation = Settings.Default[Constants.IMAGES_LOCATION].ToString();
                        //random int number for student picture
                        Random rand = new Random();
                        rand.Next(200);

                        try
                        {

                            if (Directory.Exists(imgLocation))
                            {
                                if (!(string.IsNullOrEmpty(mPicturePath)))
                                {
                                    if (!(pbMemberPicture.Image.Equals(Resources.gym_male_icon) ||
                                        pbMemberPicture.Image.Equals(Resources.female_icon)))
                                    {

                                        string imageName = Path.GetFileName(mPicturePath);
                                        imagePath = Path.Combine(imgLocation, tbMemberName.Text.Trim() + rand.Next(2000) + imageName + ".jpg");

                                        // save image to particular folder
                                        image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    }

                                }
                                else if (TakePictureForm.isDoneClicked && TakePictureForm.capturedImage != null)
                                {
                                    if (!(pbMemberPicture.Image.Equals(Resources.gym_male_icon) ||
                                        pbMemberPicture.Image.Equals(Resources.female_icon)))
                                    {
                                        imagePath = Path.Combine(imgLocation, tbMemberName.Text.Trim() + rand.Next(2000) + ".jpg");
                                        image = TakePictureForm.capturedImage;
                                        image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    }
                                }


                            }
                            else
                            {
                                Directory.CreateDirectory(imgLocation);
                                if (!(string.IsNullOrEmpty(mPicturePath)))
                                {
                                    if (!(pbMemberPicture.Image.Equals(Resources.gym_male_icon) ||
                                         pbMemberPicture.Image.Equals(Resources.female_icon)))
                                    {
                                        string imageName = Path.GetFileName(mPicturePath);
                                        imagePath = Path.Combine(imgLocation, tbMemberName.Text.Trim() + rand.Next(2000) + imageName + ".jpg");

                                        // save image to particular folder
                                        image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    }

                                }
                                else if (TakePictureForm.isDoneClicked && TakePictureForm.capturedImage != null)
                                {
                                    if (!(pbMemberPicture.Image.Equals(Resources.gym_male_icon) ||
                                         pbMemberPicture.Image.Equals(Resources.female_icon)))
                                    {
                                        imagePath = Path.Combine(imgLocation, tbMemberName.Text.Trim() + rand.Next(2000) + ".jpg");
                                        image = TakePictureForm.capturedImage;
                                        image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    }
                                }

                            }

                            string query = "Insert into " + Dashboard.accessTableName +
                                " (" + Constants.COL_MEMBER_ID + "," + Constants.COL_MEMBER_NAME + "," +
                                Constants.COL_FATHER_NAME + "," + Constants.COL_ADMISSION_DATE + "," +
                                Constants.COL_GENDER + "," + Constants.COL_GYM_OR_FITNESS + "," +
                                Constants.COL_TIMING + "," + Constants.COL_FEES + ","+ Constants.COL_OTHER_EXPENSES + "," +
                               Constants.COL_PAID + "," + Constants.COL_LOCKER + "," + Constants.COL_PHONE_NUM + "," +
                                Constants.COL_ADDRESS + "," + Constants.COL_MEMBER_PICTURE + ") " +
                                "values (@mID, @mName, @fatherName, @admissionDate, @gender, @gymOrFitness," +
                                " @timing, @fees, @otherExpenses, @paid, @locker, @phoneNumber, @mAddress, @imagePath)";

                            OleDbCommand command = new OleDbCommand(query);

                            command.Parameters.AddWithValue("@" + Constants.COL_MEMBER_ID, mID);
                            command.Parameters.AddWithValue("@" + Constants.COL_MEMBER_NAME, mName);
                            command.Parameters.AddWithValue("@" + Constants.COL_FATHER_NAME, fatherName);
                            command.Parameters.AddWithValue("@" + Constants.COL_ADMISSION_DATE, admissionDate);
                            command.Parameters.AddWithValue("@" + Constants.COL_GENDER, gender);
                            command.Parameters.AddWithValue("@" + Constants.COL_GYM_OR_FITNESS, gymOrFitness);
                            command.Parameters.AddWithValue("@" + Constants.COL_TIMING, timing);
                            command.Parameters.AddWithValue("@" + Constants.COL_FEES, fees);
                            command.Parameters.AddWithValue("@" + Constants.COL_OTHER_EXPENSES, otherExpenses);
                            command.Parameters.AddWithValue("@" + Constants.COL_PAID, paid);
                            command.Parameters.AddWithValue("@" + Constants.COL_LOCKER, lockerNumber);
                            command.Parameters.AddWithValue("@" + Constants.COL_PHONE_NUM, phoneNumber);
                            command.Parameters.AddWithValue("@" + Constants.COL_ADDRESS, mAddress);
                            command.Parameters.AddWithValue("@" + Constants.COL_MEMBER_PICTURE, imagePath);


                            try
                            {
                                database.executeQuery(command);
                                MessageBox.Show("Record added successfully\n"
                                 + "Member ID: " + mID + "\n"
                                  + "Member Name: " + mName + "\n" +
                                 "Father Name: " + fatherName + "\n" + "Addmission Date: " + admissionDate + "\n"
                                  + "Gender: " + gender + "\n" + "Gym/Fitness: " + gymOrFitness + "\n"
                                 + "Timing: " + timing + "\nLocker#: " + lockerNumber + "\n"
                                 + "Phone Number: " + phoneNumber + "\n");

                                // reset some controls
                                tbMemberID.Text = functions.getNewMemberID().ToString();
                                tbRegistrationNumber.Text = functions.getNewRegistrationNumber().ToString();
                                tbMemberName.Text = "";
                                tbFatherName.Text = "";
                                tbFees.Text = "";
                                tbPaid.Text = "";
                                tbOtherExpenses.Text = "";
                                epMemberName.SetError(tbMemberName, "");
                                epFatherName.SetError(tbFatherName, "");

                                //epFees.SetError(tbFees, "");
                                //epPaid.SetError(tbPaid, "");
                                // clear picture box picture and path of the image
                                mPicturePath = "";
                                image = Resources.gym_male_icon;
                                pbMemberPicture.Image = Resources.gym_male_icon;
                                TakePictureForm.isDoneClicked = false;
                            }
                            catch (OleDbException ex)
                            {
                                MessageBox.Show("Error!!! Can't insert record to database\n" + ex.Message);

                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }


                            //lblFeesError.Visible = false;
                            database.closeConn();

                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Can't add record\nStudent name and father name is not in correct format", "Unsaved record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {

                    try
                    {
                        if (int.Parse(tbMemberID.Text.Trim()) < 1)
                        {

                            changeEPIconError(epMemberID);
                            epMemberID.SetError(tbMemberID, "Invalid student ID\nID should not be 0 or negative numbers");
                            tbMemberID.Focus();
                            return;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error!!!\nInvalid Member ID\nID should not contain letters", "Invalid Member ID Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        epMemberID.SetError(tbMemberID, "Invalid Member ID\nID should not contain letters");
                        return;
                    }

                }

            }
        }

        private bool validateMemberNameAndFatherName()
        {
            if (string.IsNullOrEmpty(mName))
            {
                epMemberName.SetError(tbMemberName, "Error!!!\nMember name should not be empty");
                return false;

            }

            if (string.IsNullOrEmpty(mName))
            {
                epFatherName.SetError(tbFatherName, "Error!!!\nMember's father name should not be empty");
                return false;
            }

            return true;
        }

        private bool validateMemberID()
        {
            try
            {
                //if (rbUnkownStudentID.Checked)
                //{
                //    int oldStudentId = int.Parse(sID.Trim());
                //    int result = functions.checkStudentIDInDatabase(oldStudentId);

                //    if (oldStudentId < 1)
                //    {
                //        MessageBox.Show("Error!!!\nInvalid student ID\nID should not be below 0 or negative numbers", "Unsaved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        changeEPIconError(epSID);
                //        epSID.SetError(tbStudentID, "Invalid student ID\nID should not be below 0 or negative numbers");

                //        tbStudentID.Focus();
                //        return false;
                //    }
                //    if (result == -1) return true;
                //    else
                //    {

                //        MessageBox.Show("Error!!!\nCan't add record\nID you have entered" +
                //            " exists inside the database", "ID exists");
                //        return false;
                //    }

                //}

                if (rbOldMember.Checked)
                {
                    int oldMemberID = int.Parse(mID.Trim());
                    int result = functions.checkMemberIDInDatabase(oldMemberID);

                    if (oldMemberID < 1)
                    {
                        MessageBox.Show("Error!!!\nInvalid student ID\nID should not be below 0 or negative numbers", "Unsaved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeEPIconError(epMemberID);
                        epMemberID.SetError(tbMemberID, "Invalid student ID\nID should not be below 0 or negative numbers");

                        tbMemberID.Focus();
                        return false;
                    }

                    if (result == -1)
                    {
                        MessageBox.Show("Error: Can't insert record\nStudent ID you have entered is not in database\ntry a" +
                            " student ID that should be in the database", "Unsaved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changeEPIconError(epMemberID);
                        epMemberID.SetError(tbMemberID, "Error!!!\nStudent ID you have entered is not in database\ntry a student ID that should be in the database");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (FormatException)
            {
                //if (rbUnkownStudentID.Checked)
                //{
                //    if ((string.IsNullOrEmpty(tbStudentID.Text.Trim())))
                //    {
                //        changeEPIconTick(epSID);
                //        epSID.SetError(tbStudentID, "unassigned student ID\n" +
                //                   "This record will be added without an ID");


                //        epName.SetError(tbStudentName, "");
                //        epFatherName.SetError(tbFatherName, "");
                //        return true;

                //    }
                //    else
                //    {
                //        // epSID icon
                //        changeEPIconError(epSID);
                //        epSID.SetError(tbStudentID, "Invalid Student ID\n" +
                //                   "Unknown student ID should not contain letters");

                //        epName.SetError(tbStudentName, "");
                //        epFatherName.SetError(tbFatherName, "");

                //        changeEPIconError(epSID);
                //        epSID.SetError(tbStudentID, "Unknown student ID you have entered contains letters");

                //        return false;
                //    }
                //}
                //else
                //{
                //    epSID.SetError(tbStudentID, "Invalid Student ID\nshould not contain letters or whitespace");

                //    return false;
                //}


            }
            catch (Exception)
            {
                return false;

            }
            epMemberID.SetError(tbMemberID, "");
            return true;
        }

        private string getGymOrFitness()
        {
            if (rbGym.Checked) return "gym";
            else return "fitness";
        }

        private string getGender()
        {
            if (rbMale.Checked) return "male";
            else if (rbFemale.Checked) return "female";
            else return "other";

        }

        public void changeEPIconError(ErrorProvider ep)
        {
            bitmapIcon = new Bitmap(Resources.epIcon);
            bitmapIcon.MakeTransparent(Color.White);
            System.IntPtr icH = bitmapIcon.GetHicon();
            icon = Icon.FromHandle(icH);
            ep.Icon = icon;
        }
        public void changeEPIconTick(ErrorProvider ep)
        {
            bitmapIcon = new Bitmap(Resources.epTickIcon);
            bitmapIcon.MakeTransparent(Color.White);
            System.IntPtr icH = bitmapIcon.GetHicon();
            icon = Icon.FromHandle(icH);
            ep.Icon = icon;
        }
        private void setIcons()
        {
            bitmapIcon = new Bitmap(Resources.epIcon);
            bitmapIcon.MakeTransparent(Color.White);
            System.IntPtr icH = bitmapIcon.GetHicon();
            icon = Icon.FromHandle(icH);


            epFees.Icon = icon;
            epFatherName.Icon = icon;
            epMemberID.Icon = icon;
            epMemberName.Icon = icon;
            epPaid.Icon = icon;


        }
    }
}
