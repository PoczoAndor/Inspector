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
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Import_list Import=new Import_list();
            FolderBrowserDialog fbd = new FolderBrowserDialog();//get path of folder with folder browser
            fbd.Description = "Selecteaza masuratorile";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string selected_path = fbd.SelectedPath;
                Import.get_all_measurements(selected_path);
            }
            
        }
    }
}
