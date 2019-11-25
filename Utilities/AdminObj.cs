//Inherits from UserObj, overrides accessgroup to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class AdminObj : UserObj
    {
        private int accessGroup = 0;
        public override int AccessGroup
        {
            get
            {
                return accessGroup;
            }
            set
            {
                accessGroup = 0;
            }
        }
    }
}
