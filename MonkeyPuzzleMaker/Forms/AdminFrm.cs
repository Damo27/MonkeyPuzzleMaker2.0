//__________________________________________________Form for Administrator to choose tasks__________________________________________
//__________________________________________________________Only Accessable to admin_____________________________________________
using MonkeyPuzzleMaker.Forms;
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
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
        }

        //______________________________On click method to open add user form___________________________________________________
        private void addUserButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserFrm addUser = new AddUserFrm();
            addUser.ShowDialog();
            addUser = null;
            this.Show();
        }

        //______________________________On click method to open delete form with delUser bool true______________________________
        private void delUserButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteFrm deleteUser = new DeleteFrm(true);
            deleteUser.ShowDialog();
            deleteUser = null;
            this.Show();
        }

        //______________________________On click method to open delete form with delUser bool false______________________________
        private void delTestButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteFrm deleteTest = new DeleteFrm(false);
            deleteTest.ShowDialog();
            deleteTest = null;
            this.Show();
        }

        //______________________________On click method to call addUser On click method_________________________________________
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserButt_Click(sender, e);
        }

        //______________________________On click method to call deleteUser On click method______________________________________
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delUserButt_Click(sender, e);
        }

        //______________________________On click method to call deleteTest On click method_____________________________________
        private void deleteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delTestButt_Click(sender, e);
        }

        //____________Method overrides the close method so as to confirm exit and close entire app_______________________________
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo);

            if (exit == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

            base.OnClosing(e);
        }

        //____________________________On click method exits entire application no additional prompt______________________________
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewUsersBtn_Click(object sender, EventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.Show();
        }
    }
}
