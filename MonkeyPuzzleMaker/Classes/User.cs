//_______________________________________________________Class for current User____________________________________________
//Properties of this class are static and the class is populated on login therefore information on the current user is set
//for the entire session and accessable from anywhere in the program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace MonkeyPuzzleMaker
{
    class User
    {
        static string userID;
        static string userName;
        static string userSurname;
        static string userPassword;
        static int userAccessgroup;
        public static void populateUser(AllUsersObj user)
        {
            UserID = user.UserID.ToString();
            UserName = user.Name;
            UserSurname = user.Surname;
            UserPassword = user.Password;
            UserAccessgroup = user.AccessGroup;
        }
        public static string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public static string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public static string UserSurname
        {
            get
            {
                return userSurname;
            }
            set
            {
                userSurname = value;
            }
        }

        public static string UserPassword
        {
            get
            {
                return userPassword;
            }
            set
            {
                userPassword = value;
            }
        }

        public static int UserAccessgroup
        {
            get
            {
                return userAccessgroup;
            }
            set
            {
                userAccessgroup = value;
            }
        }

    }
}
