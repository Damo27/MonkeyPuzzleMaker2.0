//_______________________________________________________Class for Question object____________________________________________
//Objects of this class are created when adding questions to a test, and objects populate a dictionary of Questions from questions
//text file for use when a student takes a test or admin wants to delete a test and all related questions.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Question
    {
        public int QuestionID{get; set;}

        public int TestID { get; set; }

        public string Quest{ get; set; }

        public string ansA{ get; set; }

        public string ansB { get; set; }

        public string ansC { get; set; }

        public string ansD { get; set; }

        public string correctAns { get; set; }
    }
}
