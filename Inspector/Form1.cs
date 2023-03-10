using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            build_import_list.DoWork += new DoWorkEventHandler(build_import);
            build_import_list.WorkerReportsProgress = true;
            

        }
       
        private void settings_Click(object sender, EventArgs e)
        {
            new Settings_form().Show();
        }
        public void build_import(object sender, DoWorkEventArgs e)
        {
            StreamReader import_timer = new StreamReader(".\\import_timer.txt");
            string timer = import_timer.ReadLine();
            int timer_minutes = Int32.Parse(timer) * 60000;
            while (true)
            {
                Import_list test = new Import_list();
                test.create_list_all_measurements();
                Thread.Sleep(timer_minutes);
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (build_import_list.IsBusy != true)
            {
                build_import_list.RunWorkerAsync();
            }
        }
    }
}

