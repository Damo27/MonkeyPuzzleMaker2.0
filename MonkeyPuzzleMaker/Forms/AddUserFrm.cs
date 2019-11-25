//__________________________________________________Form to accept input from user to add a user_________________________________
//__________________________________________________________Only Accessable to admin_____________________________________________

using Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyPuzzleMaker
{
    public partial class AddUserFrm : Form
    {
        Test test;
        UserObj user = null;
        public event EventHandler OnUserAdded;//Delegate to handle events to occur after Adding a user.
        
        public AddUserFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
            test = new Test();
            accessGrpCbox.SelectedIndex = 0;
            this.OnUserAdded += UserAdded;
        }

        //___________________Adds a user from input from user, tests user ID and passes userObj to InsertToDb method_________
        private void addUserButt_Click(object sender, EventArgs e)
        {
            if (Housekeeping.CheckAllFields(this))
            {
                if (int.TryParse(userIDTxt.Text, out int ret))//only accept int type for user ID
                {
                    if (!test.UserObjDictionary.ContainsKey(int.Parse(userIDTxt.Text)))//Check user ID doesnt already exist
                    {
                        
                        switch (accessGrpCbox.SelectedIndex)
                        {
                            case 0:
                                {
                                    user = new AdminObj();
                                    break;
                                }
                            case 1:
                                {
                                    user = new LecturerObj();
                                    break;
                                }
                            case 2:
                                {
                                    user = new StudentObj();
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }

                        user.UserID = int.Parse(userIDTxt.Text);
                        user.Name = nameTxt.Text;
                        user.Surname = surnameTxt.Text;
                        user.Password = passwordTxt.Text;

                        DatabaseUtilities.InsertToDB("Users", user);
                        Housekeeping.ResetForm(this);

                        //invoke delegate
                        OnUserAdded(this, null);
                    }
                    else
                    {
                        MessageBox.Show("User ID already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("User ID can only contain numbers!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("ALL FIELDS ARE REQUIRED!", "ERROR", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
            
        }

        //______________________Method to confirm user added________________Subscriber to OnUserAdded Delegate____________________-
        public void UserAdded(Object s, EventArgs e)
        {
            MessageBox.Show("Successfully added " + user.Name + " " + user.Surname, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

