using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Asg2_zxq150130
{
    public partial class Form : System.Windows.Forms.Form
    {

        private string filePath = "./CS6326Asg2.txt";
        List<Record> records = new List<Record>();
        Record thisRecord = new Record();


        public Form()
        {
            InitializeComponent();

            if (!File.Exists(filePath)) { File.Create(filePath).Close(); }
            string text = File.ReadAllText(filePath);
            records = Record.from(text);

            recordBindingSource.DataSource = thisRecord;
            reloadGridData();
        }

        private void didClickSubmitButton(object sender, EventArgs e)
        {
            if (!validate()) { return; }
            insertOrUpdate();
            saveBackToFile();
        }

        private void didClickResetButton(object sender, EventArgs e)
        {
            setFormDataSource(new Record());
        }


        private void didClickDeleteButton(object sender, EventArgs e)
        {
            records.Remove(thisRecord);
            setFormDataSource(new Record());
            saveBackToFile();
        }

        private void didClickGirdCell(object sender, DataGridViewCellEventArgs e)
        {
            setFormDataSource(records[grid.CurrentCell.RowIndex]);
        }





        private bool validate() {
            bool validate = true;
            Label[] labels = new Label[] { firstNameErrorLabel, lastNameErrorLabel, middleInitialErrorLabel,
                addressLine1ErrorLabel, addressLine2ErrorLabel, cityErrorLabel,
                stateErrorLabel, zipErrorLabel, phoneNumberErrorLabel, emailErrorLabel };
            foreach (Label label in labels) {
                label.Text = "";
            }
            if (thisRecord.firstName == "") {
                firstNameErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (thisRecord.lastName == "")
            {
                lastNameErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (thisRecord.addressLine1 == "")
            {
                addressLine1ErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (thisRecord.city == "")
            {
                cityErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (thisRecord.state == "")
            {
                stateErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (!Regex.IsMatch(thisRecord.state, "^[a-z][a-z]$", RegexOptions.IgnoreCase))
            {
                stateErrorLabel.Text = "SHOULD BE TWO LETTERS.";
                validate = false;
            }
            if (thisRecord.zip == "")
            {
                zipErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (!Regex.IsMatch(thisRecord.zip, "^[0-9]*$", RegexOptions.IgnoreCase))
            {
                zipErrorLabel.Text = "ONLY NUMBERS PERMITTED.";
                validate = false;
            }
            if (thisRecord.phoneNumber == "")
            {
                phoneNumberErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (!Regex.IsMatch(thisRecord.phoneNumber, "^[^a-z]*$", RegexOptions.IgnoreCase))
            {
                phoneNumberErrorLabel.Text = "LETTERS NOT PERMITTED.";
                validate = false;
            }
            if (thisRecord.email == "")
            {
                emailErrorLabel.Text = "CAN'T BE EMPTY.";
                validate = false;
            }
            if (!Regex.IsMatch(thisRecord.email, "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$", RegexOptions.IgnoreCase))
            {
                emailErrorLabel.Text = "INVALID EMAIL.";
                validate = false;
            }
            return validate;
        }


        private void setFormDataSource(Record source)
        {
            thisRecord = source;
            recordBindingSource.DataSource = thisRecord;
        }

        private void reloadGridData()
        {
            List<RecordRow> result = new List<RecordRow>();
            foreach (Record record in records)
            {
                string fullName = record.firstName + " " + record.middleInitial + " " + record.lastName;
                result.Add(new RecordRow(record));
            }
            BindingSource gridDataSource = new BindingSource();
            gridDataSource.DataSource = result;
            grid.DataSource = gridDataSource;
        }

        private void insertOrUpdate()
        {
            thisRecord.updatedTime = String.Format("{0:u}", DateTime.Now);
            for (int i = 0; i < records.Count(); i++)
            {
                if (records[i].equalTo(thisRecord))
                {
                    thisRecord.createdTime = records[i].createdTime;
                    records[i] = thisRecord;
                    setFormDataSource(new Record());
                    return;
                }
            }

            records.Add(thisRecord);
            setFormDataSource(new Record());
        }
        private void saveBackToFile()
        {
            reloadGridData();
            string text = "";
            foreach (Record record in records)
            {
                text += record.toLine();
                text += Environment.NewLine;
            }
            if (records.Count != 0) { text.Remove(text.Length - 1); }

            File.WriteAllText(filePath, text);
        }
    }
}
