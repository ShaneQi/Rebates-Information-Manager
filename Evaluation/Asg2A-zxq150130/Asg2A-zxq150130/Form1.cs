using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2A_zxq150130
{
    public partial class Form1 : Form
    {
        List<Record> records = new List<Record>();
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                records.Clear();
                fileLabel.Text = openFileDialog.FileName;
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog.FileName);
                string fileStirng = sr.ReadToEnd();
                sr.Close();

                string[] lines = fileStirng.Split('\n');
                foreach (string line in lines) {
                    if (line.Split('\t').Length == 14) {
                        records.Add(new Record(line));
                    }
                }
                calculate();
            }
        }

        private void calculate() {
            numberLabel.Text = records.Count + " Records";
            totalLabel.Text = (DateTime.Parse(records.Last().updatedTime) - DateTime.Parse(records.First().createdTime)).Duration().TotalSeconds + " Seconds" ;
        }
    }
}
