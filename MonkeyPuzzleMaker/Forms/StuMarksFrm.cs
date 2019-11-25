//__________________________________________________Form for Students to view marks in DataGridView__________________________________
//_______________________________________________________Only Accessable to student_____________________________________________

using MonkeyPuzzleMaker.Classes;
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
    public partial class StuMarksFrm : Form
    {
        public StuMarksFrm(List<DisplayMark> marksLst)
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
            var list = new BindingList<DisplayMark>(marksLst);
            dg_Marks.DataSource = list;
        }
    }
}
