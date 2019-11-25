//_______________________________________________________Class for Test object____________________________________________
//Objects of this class are created to populate a dictionary of all tests from tests.txt file to populate select list boxes 
// and combo boxes so users can select which test to take or delete. Test objects are also created when adding a test to the
//tests file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class TestObj
    {
        public int TestID { get; set; }

        public String TestName { get; set; }

        public int NumberOfQuestions { get; set; }

        public int UserID { get; set; }

        public override string ToString()
        {
            return TestName;
        }

    }
}
