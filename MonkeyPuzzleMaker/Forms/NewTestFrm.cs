//__________________________________________________Form for Lecturers to create a new test______________________________________
//_______________________________________________________Only Accessable to lecturer_____________________________________________
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

namespace MonkeyPuzzleMaker
{
    public partial class NewTestFrm : Form
    {
        Test test;
        int questionCounter;
        public NewTestFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
            test = new Test();
            test.NewTestID ++;
            questionCounter = 1;
        }

        //_____________________overridden on close method to prompt user if they would like to save before exit__________________
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Would you like to save " + test.TestName, "Exit?", MessageBoxButtons.YesNoCancel);

            //________________Save and Exit___________________
            if (exit == System.Windows.Forms.DialogResult.Yes)
            {
                TestObj testObj = new TestObj
                {
                    TestID = test.NewTestID,
                    TestName = test.TestName,
                    NumberOfQuestions = test.NumberOfQuestions,
                    UserID = int.Parse(User.UserID)
                }; 
                test.saveTest(testObj, test.questionsList);
                e.Cancel = false;
            }
            //__________________Exit________________________
            else
            if (exit == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = false;
            }
            //_________________Cancel______________________
            else
            {
                e.Cancel = true;
            }

            base.OnClosing(e);
        }

        //_____________________on click method to save the name of the test and populate form for saving questions_______________
        private void saveNameButt_Click(object sender, EventArgs e)
        {
            if (questionTxt.Text == "")
            {
                questionLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                questionLbl.ForeColor = System.Drawing.Color.Black;
                questionLbl.Text = "Question " + questionCounter + ":";
                test.TestName = this.questionTxt.Text;
                questionTxt.Text = "";
                this.Text = test.TestName;
                this.saveNameButt.Hide();
                this.answersPnl.Show();
                this.saveAndExitButt.Show();
                this.nextQuesButt.Show();
            }
        }

        //______________________on click method to save the current question and move to next___________________________________
        private void nextQuesButt_Click(object sender, EventArgs e)
        {
            string correctAns = "";
            if (Housekeeping.CheckAllFields(this))
            {
                if (ansARB.Checked)
                {
                    correctAns = "A";
                }
                else
                   if (ansBRB.Checked)
                    {
                        correctAns = "B";
                    }
                    else
                        if (ansCRB.Checked)
                        {
                            correctAns = "C";
                        }
                        else
                            if (ansDRB.Checked)
                            {
                                correctAns = "D";
                            }
                test.QuestionID++;
                test.addQuestion(test.QuestionID, questionTxt.Text, test.NewTestID, ansATxt.Text, ansBTxt.Text, ansCTxt.Text, ansDTxt.Text, correctAns);
                questionCounter++;
                questionLbl.Text = "Question " + questionCounter + ":";
                Housekeeping.ResetForm(this);
            }
            else
            {
                MessageBox.Show("ALL FIELDS ARE REQUIRED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //______________________key event method to detect if user pushes enter key_____________________________________________
        private void NewTestFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && saveNameButt.Visible)
            {
                saveNameButt.PerformClick();
            }
            else
                if (e.KeyCode == Keys.Enter)
                {
                    nextQuesButt.PerformClick();
                }
                else
                    if(e.KeyCode == Keys.Enter)
                    {
                        SendKeys.Send("{TAB}");
                    }
        }

        //_______________________on click method to save the test calls on close method__________________________________________
        private void saveAndExitButt_Click(object sender, EventArgs e)
        {
            if (Housekeeping.CheckAllFields(this))
            {
                nextQuesButt_Click(sender, e);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
