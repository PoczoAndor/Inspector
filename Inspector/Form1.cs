using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //need to create a list of all the reports in the folder(get_report_files)
            //need write in a  list all the imported report(get_imported_files)
            //need to compare the two and create a list of files to be imported(create_listOfFiles_ToBeImported)
            //start import proces based on the created list
            //measurement_file_location
            //folder_path
            Import_list test = new Import_list();
            test.create_list_all_measurements();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            new Settings_form().Show();
        }
    }
}

