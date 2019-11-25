//_______________________________________________________Class for User object____________________________________________
//Objects of this class are created to populate a dictionary of all users from users.txt file to populate select list boxe 
//so admin can select which user to  delete. User objects are also created when adding a user so that a user ID cannot be 
//added twice, and when populating mark sheets in order to gather user info related to a specific test id.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public abstract class UserObj
    {
        public int UserID { get; set; }

        public String Name { get; set; }

        public String Surname { get; set; }

        public String Password { get; set; }

        public abstract int AccessGroup { get; set; }

    }
}
