//__________________________________________________Form for Lecturers to choose tasks___________________________________________
//_______________________________________________________Only Accessable to lecturer_____________________________________________
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
    public partial class LecturerFrm : Form
    {
        public LecturerFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
        }

        //____________________________On click method exits entire application no additional prompt______________________________
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //____________Method overrides the close method so as to confirm exit and close entire app_______________________________
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you want to exit?","Exit?", MessageBoxButtons.YesNo);

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

        //____________________________On click from toolstrip to call newTestButt on click______________________________________
        private void NewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTestButt_Click(sender, e);
        }

        //____________________________On click method to create new instance of new test form___________________________________
        private void newTestButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewTestFrm newTest = new NewTestFrm();
            newTest.ShowDialog();
            newTest = null;
            this.Show();
        }

        //____________________________On click method to create new instance of mark sheet formt form___________________________
        private void markRepButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkSheetFrm markSheet = new MarkSheetFrm();
            markSheet.ShowDialog();
            markSheet = null;
            this.Show();
        }

        //____________________________On click from toolstrip to call markRep on click__________________________________________
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markRepButt_Click(sender, e);
        }

        private void editTestButt_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is not available yet, Please speak to your system admin to edit a test.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            EditTestFrm edit = new EditTestFrm();
            edit.ShowDialog();
            edit = null;
            this.Show();
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTestButt_Click(sender, e);
        }
    }
}
