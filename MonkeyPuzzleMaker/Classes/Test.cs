//______________________________________________________Test Object Class__________________________________________
//Serves as the main backend class, Populates all dictionaries from files on object creation and contains all calculation
//methods, population methods and deletion methods.
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using Utilities;
using System.Threading;
using System.ComponentModel;

namespace MonkeyPuzzleMaker
{
    class Test
    {

//__________________________Constructor creates instances of all Lists and Dictionaries used throughout the program_______________
        public Test()
        {
            questionsList = new List<Question>();
            Memo = new List<Memorandum>();
            TestsDictionary = new Dictionary<int, string>();
            UsersDictionary = new Dictionary<int, string>();
            QuestionsDictionary = new Dictionary<int, Question>();
            TestQuestonsDictionary = new Dictionary<int, Question>();
            MarksDictionary = new Dictionary<int, Mark>();
            UserObjDictionary = new Dictionary<int, UserObj>();
            TestObjDictionary = new Dictionary<int, TestObj>();

            //__________________________Obtain list of string lines from relevant table and split into relevant dictionary________________
            PopulateTests();
            PopulateQuestions();
            PopulateMarks();
            PopulateUsers();
            //-----------------------------------------------------------------------------------------------------------------------------------------
            NumberOfQuestions = 0;
        }

        //____Async methods to populate all Properties needed for a tesst object, made async to run on a seperate thread for efficiency_________
        public async Task PopulateTests()
        {
            foreach (String nextLine in DatabaseUtilities.ReadDB(@"Tests"))
            {
                String[] singleTest = nextLine.Split('#');
                TestsDictionary.Add(int.Parse(singleTest[0]), singleTest[1]);
                TestObjDictionary.Add(int.Parse(singleTest[0]), (new TestObj { TestName = singleTest[1], NumberOfQuestions = int.Parse(singleTest[2]), UserID = int.Parse(singleTest[3]) }));
                NewTestID = int.Parse(singleTest[0]);
            }
        }

        public async Task PopulateQuestions()
        {
            foreach (String nextLine in DatabaseUtilities.ReadDB(@"Questions"))
            {
                String[] singleQuestion = nextLine.Split('#');
                QuestionsDictionary.Add(int.Parse(singleQuestion[0]), (new Question { Quest = singleQuestion[1], TestID = int.Parse(singleQuestion[2]), ansA = singleQuestion[3], ansB = singleQuestion[4], ansC = singleQuestion[5], ansD = singleQuestion[6], correctAns = singleQuestion[7] }));
                QuestionID = int.Parse(singleQuestion[0]);
            }
        }

        public async Task PopulateMarks()
        {
            foreach (String nextLine in DatabaseUtilities.ReadDB(@"Marks"))
            {
                String[] singleMark = nextLine.Split('#');
                MarksDictionary.Add(int.Parse(singleMark[0]), (new Mark { MarkID = int.Parse(singleMark[0]), UserID = singleMark[1], TestID = int.Parse(singleMark[2]), MarkInt = int.Parse(singleMark[3]), MarkPercent = int.Parse(singleMark[4]) }));
                MarkID = (int.Parse(singleMark[0]) + 1);
            }
        }

        public async Task PopulateUsers()
        {
            foreach (String nextLine in DatabaseUtilities.ReadDB(@"Users"))
            {
                String[] singleUser = nextLine.Split('#');
                UsersDictionary.Add(int.Parse(singleUser[0]), singleUser[1] + " " + singleUser[2]);
                UserObjDictionary.Add(int.Parse(singleUser[0]), (new AllUsersObj { Name = singleUser[1], Surname = singleUser[2], Password = singleUser[3], AccessGroup = int.Parse(singleUser[4]) }));
                UserID = int.Parse(singleUser[0]);
            }
        }


        //_________________________________Properties of Test class to get and set from anywhere that creates an object of this class__________________
        public int UserID { get; set; }

        public string TestName{ get; set; }

        public int NewTestID { get; set; }

        public int ChosenTestID { get; set; }

        public int QuestionID { get; set; }

        public int MarkID { get; set; }

        public int NumberOfQuestions { get; set; }

        public Mark TestMark { get; set; }

        public List<Memorandum> Memo { get; set; }

        public List<Question> questionsList { get; set; }

        public Dictionary<int,String> TestsDictionary { get; set; }

        public Dictionary<int, TestObj> TestObjDictionary { get; set; }

        public Dictionary<int, UserObj> UserObjDictionary { get; set; }

        public Dictionary<int, String> UsersDictionary { get; set; }

        public Dictionary<int, Mark> MarksDictionary { get; set; }

        public Dictionary<int, Question> QuestionsDictionary { get; set; }

        public Dictionary<int, Question> TestQuestonsDictionary { get; set; }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        //----------------------------------------------------------------------------------------------------------------------------------------------------

        //______________________________Method to add a single question object to the questionList property of test object___________________________________________
        public void addQuestion(int questID, String quest, int testID, String ansA, String ansB, String ansC, String ansD, String correctAnswer)
        {
            NumberOfQuestions = NumberOfQuestions + 1;
            questionsList.Add(new Question
            {
                QuestionID = questID,
                Quest = quest,
                TestID = testID,
                ansA = ansA,
                ansB = ansB,
                ansC = ansC,
                ansD = ansD,
                correctAns = correctAnswer
            });
        }

        //_____________________________Method to add Question objects to a dictionary of Questions specific for a selected Test_____________________________________
        public void PopulateTestQuestions()
        {
            

            foreach (KeyValuePair<int, Question> question in QuestionsDictionary)
            {
                question.Value.QuestionID = question.Key;

                if (question.Value.TestID == this.ChosenTestID)
                {
                    TestQuestonsDictionary.Add(question.Key, question.Value);
                }
            }
            
            MinValue = TestQuestonsDictionary.Keys.Min();
            MaxValue = TestQuestonsDictionary.Keys.Max();
            NumberOfQuestions = MaxValue - MinValue + 1;

        }

        //_____________________________Method to Print to a marksheet at the passed path returns true if marks exist for the selected test__________________________
        public bool PopulateMarkSheet(String fileName, bool marksExist)
        {
            if (MarksDictionary.Any(n => n.Value.TestID == this.ChosenTestID))
            {
                StreamWriter sw = new StreamWriter(fileName);
                int highestMark = 0, lowestMark = 100, average = 0, count = 0;
                String space = "                     ", highestMarkString = null, lowestMarkString = null;
                int spaceLength = 25;
                sw.WriteLine("Marks for " + TestName);
                sw.WriteLine("-----------------------------------------------------");
                sw.WriteLine("Name" + space + "|    Mark");
                sw.WriteLine("-----------------------------------------------------");

                //___________________Writeline for each user that has completed chosen test, calculate highest, lowest and average______________________________
                foreach (KeyValuePair<int, Mark> mark in MarksDictionary.Where(n => n.Value.TestID == this.ChosenTestID))
                {
                    space = "";
                    foreach (KeyValuePair<int, String> user in UsersDictionary)
                    {
                        if (user.Key == int.Parse(MarksDictionary[mark.Key].UserID))
                        {
                            for (int i = 0; i < spaceLength - user.Value.Length; i++)
                            {
                                space += " ";
                            }
                            sw.WriteLine(user.Value + space + "|    " + MarksDictionary[mark.Key].MarkPercent.ToString() + "%");
                            average += MarksDictionary[mark.Key].MarkPercent;

                            if (MarksDictionary[mark.Key].MarkPercent > highestMark)
                            {
                                highestMark = MarksDictionary[mark.Key].MarkPercent;
                                highestMarkString = user.Value + space + "|    " + MarksDictionary[mark.Key].MarkPercent.ToString() + "%";
                            }
                            else
                            {
                                if (MarksDictionary[mark.Key].MarkPercent == highestMark)
                                {
                                    highestMarkString += "\n" + user.Value + space + "|    " + MarksDictionary[mark.Key].MarkPercent.ToString() + "%";
                                }
                            }

                            if (MarksDictionary[mark.Key].MarkPercent < lowestMark)
                            {
                                lowestMark = MarksDictionary[mark.Key].MarkPercent;
                                lowestMarkString = user.Value + space + "|    " + MarksDictionary[mark.Key].MarkPercent.ToString() + "%";
                            }
                            else
                            {
                                if (MarksDictionary[mark.Key].MarkPercent == lowestMark)
                                {
                                    lowestMarkString += "\n" + user.Value + space + "|    " + MarksDictionary[mark.Key].MarkPercent.ToString() + "%";
                                }
                            }
                        }
                    }
                    count++;
                }
                //__________________________________Output highest, lowest and average__________________________________________
                average = average / count;
                sw.WriteLine("------------------Highest Mark/s---------------------");
                sw.WriteLine(highestMarkString);
                sw.WriteLine("-------------------Lowest Mark/s---------------------");
                sw.WriteLine(lowestMarkString);
                sw.WriteLine("-------------------Class Average---------------------");
                sw.WriteLine("Class Average             |    " + average + "%");
                sw.Close();
                marksExist = true;
            }
            else
            {
                MessageBox.Show("No Marks exist for that test yet!", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                marksExist = false;
            }
            return marksExist;
        }

        //_____________________________Method to save the accepted specific Test object and a list of its related questions to relevant table in db____________________________
        public void saveTest(TestObj testObj, List<Question> questionList)
        {
            DatabaseUtilities.InsertToDB("Tests", testObj);

            foreach (Question question in questionList)
            {
                DatabaseUtilities.InsertToDB("Questions", question);
            }
        }

        //_____________________________Method to add a single Memorandum object to Memo List________________________________________
        public void addToMemo(int questionCount, String learnerAns, String learnersAnswer)
        {
            String correctAnswer = "";
            bool isCorrect;

            if (QuestionsDictionary[questionCount].correctAns.Equals(learnerAns))
            {
                isCorrect = true;
            }
            else
            {
                isCorrect = false;
            }

            switch (QuestionsDictionary[questionCount].correctAns)
            {
                case "A":
                    {
                        correctAnswer = "A) " + QuestionsDictionary[questionCount].ansA;
                        break;
                    }
                case "B":
                    {
                        correctAnswer = "B) " + QuestionsDictionary[questionCount].ansB;
                        break;
                    }
                case "C":
                    {
                        correctAnswer = "C) " + QuestionsDictionary[questionCount].ansC;
                        break;
                    }
                case "D":
                    {
                        correctAnswer = "D) " + QuestionsDictionary[questionCount].ansD;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            Memo.Add(new Memorandum
            {
                Question = QuestionsDictionary[questionCount].Quest,
                IsCorrect = isCorrect,
                LearnersAnswer = learnersAnswer,
                CorrectAnswer = correctAnswer,
                QuestionID = QuestionsDictionary[questionCount].QuestionID,
                userID = int.Parse(User.UserID),
                SelectedAnswer = learnerAns
            });
        }

        //____________________________Writes a single Mark object to Marks Table in db_____________________________________________
        public void addToMarks()
        {
            int markInt = 0;
            foreach (Memorandum memo in Memo)
            {
                if (memo.IsCorrect)
                {
                    markInt++;
                }
            }

            TestMark = new Mark
            {
                MarkID = this.MarkID,
                UserID = User.UserID,
                TestID = ChosenTestID,
                MarkInt = markInt,
                MarkPercent = (100 * markInt) /NumberOfQuestions
            };

            DatabaseUtilities.InsertToDB("Marks", TestMark);
        }

        //___________Saves all items in the Memo to a database including Student Answers, Recomended to run on seperate thread_____________
        public void saveAnswers()
        {
            foreach (Memorandum memo in Memo)
            {
                DatabaseUtilities.InsertToDB("StudentAnswers", memo);
            }
        }

        //___________________________Deletes item(User or test) at the accepted key from the relevant table in db_________________________________________
        public bool DeleteSelectedItem(int key, bool delUser)
        {
            bool deleteSuccess = false;
            //__________________Deletes a User if delUser bool is true_________________________________
            if (delUser)
            {
                if (MessageBox.Show("This will permenantly delete User: " + UserObjDictionary[key].Name +" "+ UserObjDictionary[key].Surname + ", as well as all Tests the user has created and all marks associated to the tests.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    UserObjDictionary.Remove(key);
                    DatabaseUtilities.DeleteFromDB("Users", "userID", key);
                    deleteSuccess = true;
                }
            }
            //__________________Deletes a Test if delUser bool is false_________________________________
            else
            {
                if (MessageBox.Show("This will permenantly delete "+ TestObjDictionary[key].TestName+ ", as well as all Questions and Marks associated with the test.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    TestObjDictionary.Remove(key);
                    DatabaseUtilities.DeleteFromDB("Tests", "testID", key);
                    deleteSuccess = true;
                }
            }
            return deleteSuccess;
        }
    }
}
