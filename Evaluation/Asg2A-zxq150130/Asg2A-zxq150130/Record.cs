using System;
using System.Collections.Generic;

namespace Asg2A_zxq150130
{
    public class Record
    {
        public string firstName { get { return data[0]; } set { data[0] = value; } }
        public string lastName { get { return data[1]; } set { data[1] = value; } }
        public string middleInitial { get { return data[2]; } set { data[2] = value; } }
        public string addressLine1 { get { return data[3]; } set { data[3] = value; } }
        public string addressLine2 { get { return data[4]; } set { data[4] = value; } }
        public string city { get { return data[5]; } set { data[5] = value; } }
        public string state { get { return data[6]; } set { data[6] = value; } }
        public string zip { get { return data[7]; } set { data[7] = value; } }
        public string phoneNumber { get { return data[8]; } set { data[8] = value; } }
        public string email { get { return data[9]; } set { data[9] = value; } }
        public bool isProofAttached { get { return _isProofAttached; } set { _isProofAttached = value; } }
        public DateTime recieveDate { get { return _recieveDate; } set { _recieveDate = value; } }

        private string[] data = new string[10] { "", "", "", "", "", "", "", "", "", "" };

        public bool _isProofAttached = true;
        public DateTime _recieveDate = DateTime.Now;

        public string createdTime = "";
        public string updatedTime = "";

        public static List<Record> from(string text)
        {
            List<Record> records = new List<Record>();

            string[] lines = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line == "") { continue; }
                records.Add(new Record(line));
            }
            return records;
        }

        public Record(string text)
        {
            string[] words = text.Split(new string[] { "\t" }, StringSplitOptions.None);
            firstName = words[0];
            lastName = words[1];
            middleInitial = words[2];
            addressLine1 = words[3];
            addressLine2 = words[4];
            city = words[5];
            state = words[6];
            zip = words[7];
            phoneNumber = words[8];
            email = words[9];
            isProofAttached = words[10] == "1";
            recieveDate = DateTime.Parse(words[11]);
            createdTime = words[12];
            updatedTime = words[13];

        }

        public Record() { }

        public string toLine()
        {
            string result = "";
            result += firstName;
            result += ('\t' + lastName);
            result += ('\t' + middleInitial);
            result += ('\t' + addressLine1);
            result += ('\t' + addressLine2);
            result += ('\t' + city);
            result += ('\t' + state);
            result += ('\t' + zip);
            result += ('\t' + phoneNumber);
            result += ('\t' + email);
            result += ('\t' + (isProofAttached ? "1" : "0"));
            result += ('\t' + String.Format("{0:d}", recieveDate));
            result += ('\t' + createdTime);
            result += ('\t' + updatedTime);
            return result;
        }

        public string displayName()
        {
            return firstName + " " + middleInitial + " " + lastName;
        }

        public bool equalTo(Record record)
        {
            if (this.firstName == record.firstName && this.lastName == record.lastName && this.middleInitial == record.middleInitial) { return true; }
            return false;
        }

    }
}