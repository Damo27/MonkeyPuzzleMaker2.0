//__________________________________________________Form for Admin to view users___________________________________________
//_______________________________________________________Only Accessable to Admin_____________________________________________

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace MonkeyPuzzleMaker.Forms
{
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
            List<AllUsersObj> usersLst = DatabaseUtilities.ReadDB(@"Users", new List<AllUsersObj>());
            var list = new BindingList<AllUsersObj>(usersLst);
            dg_Users.DataSource = list;
        }
    }
}
