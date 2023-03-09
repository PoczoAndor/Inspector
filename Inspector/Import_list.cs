using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Inspector
{
     public class Import_list
    {
        public void get_all_measurements(string path)
        {
            using (StreamWriter writer = new StreamWriter(".\\Path_of_measurements.txt"))
            {
                writer.WriteLine(path);
            }
        }
        public void create_list_all_measurements()
        {
            StreamReader path_of_all_measurements = new StreamReader(".\\Path_of_measurements.txt");
            string measurements_path = path_of_all_measurements.ReadLine();
            string[] measurements = Directory.GetFiles(@measurements_path, "*.XLSX", SearchOption.AllDirectories);
            int measurements_lenght= measurements.Length;
            int loop=0;
            System.IO.File.Delete(".\\List_of_all_measurements.txt");
            while (loop != measurements_lenght) 
            {
                using (StreamWriter writer = new StreamWriter(".\\List_of_all_measurements.txt",true))
                {
                    writer.WriteLine(measurements[loop]);
                    writer.Close();
                }
                loop++;
            }
                
            
        }
    }
}
    
