//__________________________________________________Form for Students to choose tasks___________________________________________
//_______________________________________________________Only Accessable to student_____________________________________________
using MonkeyPuzzleMaker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;


namespace MonkeyPuzzleMaker.Forms
{
    public partial class StudentFrm : Form
    {
        public StudentFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
        }

        //_______________________On click method closes application with no further prompt______________________________________
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
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

        //___________on click method from tool strip calls takeTest on click method______________________________________________
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            takeTestButt_Click(sender, e);
        }

        //___________on click method creates new instance of take test form_____________________________________________________
        private void takeTestButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakeTestFrm takeTest = new TakeTestFrm();
            takeTest.ShowDialog();
            takeTest = null;
            this.Show();
        }

        //___________on click method populates users marks into a MessageBox____________________________________________________
        private void viewMarksButt_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            String printString = "";

            if (test.MarksDictionary.Values.Any(n => n.UserID == User.UserID))
            {
                List<Mark> marks = test.MarksDictionary.Values.Where(n => n.UserID == User.UserID).ToList<Mark>();
                List<DisplayMark> displayMarks = new List<DisplayMark>();

                foreach (var item in marks)
                {
                    if (test.TestsDictionary.Any(n => n.Key == item.TestID))
                    {
                        displayMarks.Add(new DisplayMark { Test = test.TestsDictionary.First(n => n.Key == item.TestID).Value, Mark = item.MarkPercent });
                    }
                }

                StuMarksFrm stuMarksFrm = new StuMarksFrm(displayMarks);
                stuMarksFrm.Show();
            }
            else
            {
                MessageBox.Show(printString, "You have not taken any tests yet.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }

        //___________on click mthod from tool strip calls viewMarks on click method______________________________________________
        private void viewMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewMarksButt_Click(sender, e);
        }
    }
}
