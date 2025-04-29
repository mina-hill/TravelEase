using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEaseSystem
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "localconfig.json";
            //MessageBox.Show("Looking for config at: " + Path.GetFullPath(path));

            var config = LocalConfig.LoadConfig(path);
            string connectionString = config?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string not loaded.");
                return;
            }

            MessageBox.Show("Connection string loaded:\n" + connectionString);
        }
    }
}
