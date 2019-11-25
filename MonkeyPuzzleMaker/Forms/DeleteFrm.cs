//__________________________________________________Form to delete a chosen user or test_________________________________________
//__________________________________________________________Only Accessable to admin_____________________________________________

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
    public partial class DeleteFrm : Form
    {
        Test test;
        bool delUser;

        Dictionary<int, String> boundDictionary;

        //______________________________Constructor accepts bool to determine whether to delete test or user______________________
        public DeleteFrm(bool delUser)
        {
            InitializeComponent();
            this.Text += " - " + User.UserName + " " + User.UserSurname;
            test = new Test();
            //______________________________Set bound dictionary and show relevant image_________________________________________
            if (delUser)
            {
                delUserPicBox.Show();
                boundDictionary = test.UsersDictionary;
                this.delUser = true;
            }
            else
            {
                delTestPicBox.Show();
                boundDictionary = test.TestsDictionary;
                this.delUser = false;
            }
            resetBindings(boundDictionary);
        }

        //________On click method to call and pass selected key to Delete method for all selected items in checklistbox__________
        private void deleteButt_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> item in adminCheckedListBox.CheckedItems)
            {
                if(test.DeleteSelectedItem(item.Key, delUser))
                {
                    boundDictionary.Remove(item.Key);
                }
            }
            resetBindings(boundDictionary);
        }

        //____________________Method to reset the data binding of checklistbox after data has changed____________________________
        private void resetBindings(Dictionary<int, String> boundDictionary)
        {
            adminCheckedListBox.DataSource = null;
            adminCheckedListBox.DataSource = new BindingSource(boundDictionary, null);
            adminCheckedListBox.DisplayMember = "Value";
            adminCheckedListBox.ValueMember = "Key";
        }
    }
}
