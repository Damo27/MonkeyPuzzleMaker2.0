//______________________________________________Class for Mark object___________________________________________________
//objects of this class are created for writing an entry to the marks file on completion of a test, and when an object of the main
//class test.cs is created a dictionary of objects of this class are created and populalated from the marks file
//for use with mark history viewing.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Mark
    {
        public int MarkID { get; set; }

        public String UserID { get; set; }

        public int TestID { get; set; }

        public int MarkInt { get; set; }

        public int MarkPercent { get; set; }
    }
}
