//_______Edit test Form Populates a GridView with Test questions and allows Lecturers to edit them in a disconnected platform_____________________
//_____________________________________________________Only accessable by Lecturers_________________________________________________
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
    public partial class EditTestFrm : Form
    {
        Test test;
        DataSet ds;

        //__________________________Constructor Binds the GridView and the combobox____________________________________
        public EditTestFrm()
        {
            InitializeComponent();
            test = new Test();
            testCBox.DataSource = new BindingSource(test.TestObjDictionary.Where(x => x.Value.UserID == int.Parse(User.UserID)), null);
            testCBox.DisplayMember = "Value";
            testCBox.ValueMember = "Key";
            dg_Questions.DataSource = ds.Tables[0];
        }

        //___________Event handler for changing selection on combobox populates questions of selected test______________________________________
        private void testCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = DatabaseUtilities.PopulateDataset("Questions", "Select * from Questions where testID = " + ((KeyValuePair<int, TestObj>)testCBox.SelectedItem).Key);
            testIDLbl.Text = "TestID: " + ((KeyValuePair<int, TestObj>)testCBox.SelectedItem).Key;
            dg_Questions.DataSource = ds.Tables[0];
        }

        //_______________Event Handler for saving changes____________________________________________
        private void saveChangesButt_Click(object sender, EventArgs e)
        {
            DatabaseUtilities.SaveDataset(ds, "Questions", "Select * from Questions");
        }
    }
}
