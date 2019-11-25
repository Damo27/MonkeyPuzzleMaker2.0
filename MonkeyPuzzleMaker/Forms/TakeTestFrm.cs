//__________________________________________________Form for Students to take specific tests____________________________________
//_______________________________________________________Only Accessable to student_____________________________________________
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace MonkeyPuzzleMaker.Forms
{
    public partial class TakeTestFrm : Form
    {
        Test test;
        int questionCount, questionNumCount = 1, memoCount = 0;
        String learnerAns = "";
        String learnerAnsString = "";

        public TakeTestFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
            test = new Test();
            testsCbox.DataSource = new BindingSource(test.TestsDictionary,null);
            testsCbox.DisplayMember = "Value";
            testsCbox.ValueMember = "Key";
        }

        //__________________On click method populates next question and saves previous answer___________________________________
        private void nextQuestButt_Click(object sender, EventArgs e)
        {
            //if list of marks from selected test does NOT contain Current UserID the user has not already taken the test
            if (!test.MarksDictionary.Values.Where(n => n.TestID == ((KeyValuePair<int, String>)testsCbox.SelectedItem).Key).Any(n => n.UserID == User.UserID))
            {
                //if combobox for test selection is still visible test has not started yet.
                if (testsCbox.Visible)
                {
                    test.ChosenTestID = ((KeyValuePair<int, String>)testsCbox.SelectedItem).Key;
                    test.TestName = test.TestsDictionary[test.ChosenTestID];
                    test.PopulateTestQuestions();
                    questionCount = test.MinValue - 1;
                    PopulateNextQuest(sender);
                    this.Text = test.TestName;
                    testsCbox.Visible = false;
                    questionLbl.Visible = true;
                    radButtPnl.Visible = true;
                    nextQuestButt.Text = "Next Question";
                }
                else
                {
                    //if answer not selected
                    if (Housekeeping.CheckAllFields(radButtPnl))
                    {
                        //if final question
                        if (questionCount == test.MaxValue)
                        {
                            setLearnerAns();
                            test.addToMemo(questionCount, learnerAns, learnerAnsString);
                            test.addToMarks();
                            Thread thread = new Thread(new ThreadStart(test.saveAnswers));
                            thread.Start();
                            memoCount++;
                            questionCount++;
                            if (test.TestMark.MarkPercent >= 50)
                            {
                                MessageBox.Show("Congratulations you got " + test.TestMark.MarkInt + "/" + test.NumberOfQuestions + " answers correct giving you " + test.TestMark.MarkPercent + "%", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Unfortunately you only got " + test.TestMark.MarkInt + "/" + test.NumberOfQuestions + " answers correct giving you " + test.TestMark.MarkPercent + "%", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            //if less than final question
                            if (questionCount < test.MaxValue)
                            {
                                if (questionCount == test.MaxValue - 1)
                                {
                                    nextQuestButt.Text = "Save and Submit";
                                }
                                setLearnerAns();
                                test.addToMemo(questionCount, learnerAns, learnerAnsString);
                                PopulateNextQuest(sender);
                                Housekeeping.ResetForm(radButtPnl);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an answer!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                //if test complete but memo not
                if (memoCount > 0 && memoCount <= test.NumberOfQuestions)
                {

                    //if first memo question
                    if (memoCount == 1)
                    {
                        //if user selects yes to view memo
                        if (MessageBox.Show("Would you like to view the Memo?", "View Memo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ansARb.Visible = false;
                            ansBRb.Visible = false;
                            ansCRb.Visible = false;
                            ansDRb.Visible = false;

                            correctAnsLbl.Visible = true;
                            youAnsLbl.Visible = true;
                            testAnsLbl.Visible = true;
                            learnerAnsLbl.Visible = true;

                            nextQuestButt.Text = "Next Question";
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    //if memo not complete but not first question
                    else
                    {
                        //if second last memo question
                        if (memoCount == test.NumberOfQuestions)
                        {
                            nextQuestButt.Text = "Exit";
                        }
                        else
                        {
                            //if memo final question
                            if (memoCount > test.NumberOfQuestions)
                            {
                                    this.Close();
                            }
                        }
                    }
                    PopulateNextMemo();
                    
                }
                else
                {   //if memo final question
                    if (memoCount > test.NumberOfQuestions)
                    {
                        this.Close();
                    }
                }
            } 
            else
            {
                MessageBox.Show("You have already taken this test.", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //__________________key event method to detect enter key keydown calls nextQuest on click_______________________________
        private void TakeTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextQuestButt.PerformClick();
            }
        }

        //__________________private method to set the learners answer depending on selected radio button_______________________
        private void setLearnerAns()
        {
            if (ansARb.Checked)
            {
                learnerAns = "A";
                learnerAnsString = "A) " + test.QuestionsDictionary[questionCount].ansA;
            }
            else {
                if (ansBRb.Checked)
                {
                    learnerAns = "B";
                    learnerAnsString = "B) " + test.QuestionsDictionary[questionCount].ansB;
                }
                else
                {
                    if (ansCRb.Checked)
                    {
                        learnerAns = "C";
                        learnerAnsString = "C) " + test.QuestionsDictionary[questionCount].ansC;
                    }
                    else
                    {
                        if (ansDRb.Checked)
                        {
                            learnerAns = "D";
                            learnerAnsString = "D) " + test.QuestionsDictionary[questionCount].ansD;
                        }
                    }
                }
            }

        }

        //__________________privat method to populate controls with next question, and increment counters______________________
        private void PopulateNextQuest(Object sender)
        {
            questionCount++;
            questionNumLbl.Text = "Question " + questionNumCount;
            questionLbl.Text = test.QuestionsDictionary[questionCount].Quest + "?";
            ansARb.Text = "A) " + test.QuestionsDictionary[questionCount].ansA;
            ansBRb.Text = "B) " + test.QuestionsDictionary[questionCount].ansB;
            ansCRb.Text = "C) " + test.QuestionsDictionary[questionCount].ansC;
            ansDRb.Text = "D) " + test.QuestionsDictionary[questionCount].ansD;
            questionNumCount++;
        }

        //private void backButt_Click(object sender, EventArgs e)
        //{
                //To Do back functionality
        //}

        //________________Private method to populate controls with next memo, and increment counters___________________________
        private void PopulateNextMemo()
        {
            if (test.Memo[memoCount - 1].IsCorrect)
            {
                learnerAnsLbl.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                learnerAnsLbl.ForeColor = System.Drawing.Color.Red;
            }
            questionNumLbl.Text = "Memo Question " + memoCount;
            questionLbl.Text = test.Memo[memoCount -1].Question + "?";
            learnerAnsLbl.Text = test.Memo[memoCount - 1].LearnersAnswer;
            testAnsLbl.Text = test.Memo[memoCount - 1].CorrectAnswer;
            memoCount++;
        }

        //____________Method overrides the close method so as to confirm exit and close entire app_______________________________
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            DialogResult exit;

            //Exit without prompt if test is finished
            if (memoCount > 0)
            {
                e.Cancel = false;
            }
            else
            {
                exit = MessageBox.Show("Are you sure you want to exit without finishing the test? All progress will be lost for " + test.TestName, "Exit?", MessageBoxButtons.YesNo);

                if (exit == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            base.OnClosing(e);
        }
    }
}
