using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Utilities;
using System.Threading;

namespace MonkeyPuzzleMaker
{
    public partial class LoginFrm : Form
    {
        //Declare class variables
        string uID, pWord;//declare strings for username and password check
        Boolean loginSuccess;
        List<AllUsersObj> users;
        int count = 0;

        public LoginFrm()
        {
            InitializeComponent();
            if (File.Exists(@"readme.txt"))
            {
                System.Diagnostics.Process.Start(@"readme.txt");
            }
        }

        //_______________________Button Click method for signin button_____________________________________________
        private void signInBut_Click(object sender, EventArgs e)
        {
            //Declare method variables
            loginSuccess = false;
            users = DatabaseUtilities.ReadDB(@"Users", new List<AllUsersObj>());
            count = 0;

            uID = uIDTBox.Text;//get user input username
            pWord = pWordTBox.Text;//get user inputted password

            //___________If else statements to make labels red if text box is empty________________________________
            if (uID == "")
            {
                uIDLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                uIDLbl.ForeColor = System.Drawing.Color.Black;
            }
            if (pWord == "")
            {
                pWordLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                pWordLbl.ForeColor = System.Drawing.Color.Black;
            }

            //___________If textboxes aren't empty_________________________________________________________________
            if (uID != "" && pWord != "")
            {
                bg_AuthoriseLogin.RunWorkerAsync();
                signInBut.Visible = false;
                pb_Authorise.Visible = true;
                lbl_Authorise.Visible = true;
                lbl_Percent.Visible = true;
            }
        }

        private void bg_AuthoriseLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            while (count < users.Count && !loginSuccess)
            {
                if (users[count].UserID.ToString() == uID && users[count].Password == pWord)//if comparisons are a match flag login
                {
                    loginSuccess = true;
                    User.populateUser(users[count]);
                }
                Thread.Sleep(100);
                bg_AuthoriseLogin.ReportProgress(count);
                count++;
            }
        }

        private void bg_AuthoriseLogin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int percent = (100*count)/users.Count;
            pb_Authorise.Value = percent;
            lbl_Percent.Text = percent.ToString() + " %";
        }

        private void bg_AuthoriseLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (loginSuccess)//if flagged
            {
                pb_Authorise.Value = pb_Authorise.Maximum;
                lbl_Percent.Text = "100 %";
                switch (User.UserAccessgroup)//switch statement to check access group
                {
                    case 0:
                        AdminFrm admin = new AdminFrm();
                        admin.Show();
                        this.Hide();
                        break;
                    case 1:
                        LecturerFrm lecturer = new LecturerFrm();
                        lecturer.Show();
                        this.Hide();
                        break;
                    case 2:
                        Forms.StudentFrm student = new Forms.StudentFrm();
                        student.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Unknown Access Group please contact you system admin", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pb_Authorise.Visible = false;
                lbl_Percent.Visible = false;
                lbl_Authorise.Visible = false;
                signInBut.Visible = true;
            }
        }

        //_______________________KeyEvent method to detect press of Enter key______________________________________
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInBut.PerformClick();
            }
        }
    }
}
