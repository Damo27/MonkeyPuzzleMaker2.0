//Inherits from UserObj, overrides accessgroup to 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class StudentObj : UserObj
    {
        private int accessGroup = 2;
        public override int AccessGroup
        {
            set
            {
                accessGroup = 2;
            }
            get
            {
                return accessGroup;
            }
        }
    }
}
