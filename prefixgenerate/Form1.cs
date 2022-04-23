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

namespace prefixgenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] subdirs = Directory.GetDirectories(fbd.SelectedPath);
                    
                    foreach (string x in subdirs)
                    {
                        string path = x.Remove(0, 3);
                        string path_create = x + ".txt";
                        if (File.Exists(path_create))
                            {
                                File.Delete(path_create);
                            }
                        using (StreamWriter sw = File.CreateText(path_create))
                        {
                            sw.WriteLine("Prefix=" + path + @"\");
                            sw.WriteLine("product=Arma 3");
                            sw.WriteLine("version=149197");
                        }


                }
                    
                }

}
    }
}
