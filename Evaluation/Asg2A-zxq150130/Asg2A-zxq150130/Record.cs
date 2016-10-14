using System;
using System.Collections.Generic;

namespace Asg2A_zxq150130
{
    public class Record
    {

        public DateTime createdTime;
        public DateTime updatedTime;


        public Record(string text)
        {
            string[] words = text.Split(new string[] { "\t" }, StringSplitOptions.None);
            createdTime = DateTime.Parse(words[12]);
            updatedTime = DateTime.Parse(words[13]);

        }

    }
}