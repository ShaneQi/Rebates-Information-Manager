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
                
                string result = calculate();
                System.IO.StreamWriter sw = new System.IO.StreamWriter("./Evaluation-Result.txt");
                sw.Write(result);
                sw.Close();
            }
        }

        private string calculate() {
            string result = "";

            //  Number of records.
            numberLabel.Text = records.Count + " Records";
            result += "Number of records: " + records.Count + " Records" + Environment.NewLine;

            //  Entering time.
            double[] enteringTimes = new double[records.Count];
            for (int i = 0; i < records.Count; i++) {
                enteringTimes[i] = (records[i].createdTime - records[i].updatedTime).Duration().TotalSeconds;
            }
            result += "Entering time: ";
            // Limiting double to 2 decimal places.
            double avg = Math.Truncate(enteringTimes.Average() * 100) / 100;
            double max = enteringTimes.Max();
            double min = enteringTimes.Min();
            timeLabelMax.Text = "max: " + max + " s";
            result += "max: " + max + " s\t";
            timeLabelMin.Text = "min: " + min + " s";
            result += "min: " + min + " s\t";
            timeLabelAvg.Text = "avg: " + avg + " s";
            result += "avg: " + avg + " s" + Environment.NewLine;

            //  Entering interval.
            double[] intervalTimes = new double[records.Count - 1];
            for (int i = 0; i < records.Count - 1; i++)
            {
                intervalTimes[i] = (records[i + 1].createdTime - records[i].updatedTime).Duration().TotalSeconds;
            }
            result += "Entering interval: ";
            //  Limiting double to 2 decimal places.
            double iAvg = Math.Truncate(intervalTimes.Average() * 100) / 100;
            double iMax = intervalTimes.Max();
            double iMin = intervalTimes.Min();
            intervalLabelMax.Text = "max: " + iMax + " s";
            result += "max: " + iMax + " s\t";
            intervalLabelMin.Text = "min: " + iMin + " s";
            result += "min: " + iMin + " s\t";
            intervalLabelAvg.Text = "avg: " + iAvg + " s";
            result += "avg: " + iAvg + " s" + Environment.NewLine;

            //  Total time.
            totalLabel.Text = (records.Last().updatedTime - records.First().createdTime).Duration().TotalSeconds + " Seconds";
            result += "Total time: " + (records.Last().updatedTime - records.First().createdTime).Duration().TotalSeconds + " Seconds";

            return result;
        }
    }
}
