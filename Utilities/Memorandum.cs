//_______________________________________________________Class for Memorandum object____________________________________________
//Objects of this class are made when a student answers a question and added to a list of memorandum objects.
//The objects are then be used to determine the students result and display the memorandum to the student.
//As of update 1.4 objects are also utilised to save Student Answers to the database.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Memorandum
    {
        public String Question { get; set; }

        public bool IsCorrect { get; set; }

        public String LearnersAnswer { get; set; }

        public String CorrectAnswer { get; set; }

        public int QuestionID { get; set; }

        public int userID { get; set; }

        public String SelectedAnswer { get; set; }
    }
}
