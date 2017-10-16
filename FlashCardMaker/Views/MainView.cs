using FlashCardMaker.Controllers;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FlashCardMaker
{
    public partial class MainView : Form
    {
        DataIOController dataIOController;
        OpenFileDialog ofd1 = new OpenFileDialog();

        public MainView()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            DefaultTestStuff();
        }

        public void setDataIOController(DataIOController dataIOController)
        {
            this.dataIOController = dataIOController;
        }

        public void DefaultTestStuff()
        {

        }

        public void Print(string v)
        {
            lblOutput.Text = v;
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.ofd1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "My Image Browser";
        }

        private void btnBrowseAddToDatabase_Click(object sender, EventArgs e)
        {
            this.ofd1.Filter = "Excel Files (*.xls;*.xlx)|*.xls;*.xlx|All files (*.*)|*.*";
            this.ofd1.Multiselect = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                if (ofd1.FileNames.Length > 1)
                {
                    StringBuilder StringBuilder1 = new StringBuilder();

                    foreach (String file in ofd1.FileNames)
                    {
                        StringBuilder1.Append("\"" + file + "\" ; ");
                    }

                    StringBuilder1.Remove(StringBuilder1.Length - 3, 3);

                    txtbxAddToDatabase.Text = StringBuilder1.ToString();
                }
                else
                {
                    txtbxAddToDatabase.Text = ofd1.FileNames[0];
                }
            }
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            ArrayList Files = new ArrayList();
            String[] FileNames = txtbxAddToDatabase.Text.Replace(" ; \"","").Split('\"');

            dataIOController.addFilesContentToDatabase(FileNames, this);
        }

        private void test_Click(object sender, EventArgs e)
        {
            
        }
    }
}
