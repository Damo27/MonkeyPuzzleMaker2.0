//Inherits from UserObj, overrides accessgroup to 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class LecturerObj : UserObj
    {
        private int accessGroup = 1;
        public override int AccessGroup
        {
            get
            {
                return accessGroup;
            }
            set
            {
                accessGroup = 1;
            }
        }
    }
}
