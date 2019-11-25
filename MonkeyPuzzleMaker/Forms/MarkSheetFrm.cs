//________________________________________________Form for Lecturers to print or save Marksheet___________________________________________
//_______________________________________________________Only Accessable to lecturer_____________________________________________
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyPuzzleMaker
{
    public partial class MarkSheetFrm : Form
    {
        Test test;
        public MarkSheetFrm()
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
            test = new Test();
            testsCbox.DataSource = new BindingSource(test.TestsDictionary, null);
            testsCbox.DisplayMember = "Value";
            testsCbox.ValueMember = "Key";
        }

        //________________Method accepts a filename(including path) and creates Marksheet there__________________________________
        //_________________________returns true if marks exist for the chosen test_______________________________________________
        private bool generateFile(String fileName)
        {
            bool marksExist = false;
            test.ChosenTestID = ((KeyValuePair<int, String>)testsCbox.SelectedItem).Key;
            test.TestName = test.TestsDictionary[test.ChosenTestID];
            marksExist = test.PopulateMarkSheet(fileName, marksExist);
            return marksExist;
        }

        //_______________on click method to open file after creation in default location________________________________________
        private void openSheetButt_Click(object sender, EventArgs e)
        {
            if (generateFile(@"MarkSheet.txt"))
            {
                System.Diagnostics.Process.Start(@"MarkSheet.txt");
            }
        }

        //_______________on click method to generate and save file in chosen location__________________________________________
        private void saveSheetButt_Click(object sender, EventArgs e)
        {
            if (generateFile(@"MarkSheet.txt"))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    generateFile(saveFileDialog1.FileName);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
