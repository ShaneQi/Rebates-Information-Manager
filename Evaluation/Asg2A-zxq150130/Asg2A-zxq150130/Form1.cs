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
                //  Clean up previous loaded records.
                records.Clear();
                //  Read file.
                fileLabel.Text = openFileDialog.FileName;
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog.FileName);
                string fileStirng = sr.ReadToEnd();
                sr.Close();

                //  Split file to lines.
                string[] lines = fileStirng.Split('\n');
                //  Convert line to Record object.
                foreach (string line in lines) {
                    //  Skip invalid lines.
                    if (line.Split('\t').Length == 14) {
                        records.Add(new Record(line));
                    }
                }

                //  Calculate data and render them.
                calculate();
            }
        }

        private void calculate() {
            //  Number of records.
            numberLabel.Text = records.Count + " Records";
            //  Entering time.
            double[] enteringTimes = new double[records.Count];
            for (int i = 0; i < records.Count; i++) {
                enteringTimes[i] = (records[i].createdTime - records[i].updatedTime).Duration().TotalSeconds;
            }
            // Limiting double to 2 decimal places.
            double avg = Math.Truncate(enteringTimes.Average() * 100) / 100;
            double max = enteringTimes.Max();
            double min = enteringTimes.Min();
            timeLabelMax.Text = "max: " + max + " s";
            timeLabelMin.Text = "min: " + min + " s";
            timeLabelAvg.Text = "avg: " + avg + " s";

            //  Entering interval.
            double[] intervalTimes = new double[records.Count - 1];
            for (int i = 0; i < records.Count - 1; i++)
            {
                intervalTimes[i] = (records[i + 1].createdTime - records[i].updatedTime).Duration().TotalSeconds;
            }
            //  Limiting double to 2 decimal places.
            double iAvg = Math.Truncate(intervalTimes.Average() * 100) / 100;
            double iMax = intervalTimes.Max();
            double iMin = intervalTimes.Min();
            intervalLabelMax.Text = "max: " + iMax + " s";
            intervalLabelMin.Text = "min: " + iMin + " s";
            intervalLabelAvg.Text = "avg: " + iAvg + " s";

            //  Total time.
            totalLabel.Text = (records.Last().updatedTime - records.First().createdTime).Duration().TotalSeconds + " Seconds" ;
        }
    }
}
