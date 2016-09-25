using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_zxq150130
{
    class RecordRow
    {
        
        public string fullName { get; set; }

        public string phoneNumber { get; set; }

        public RecordRow(Record record) {
            this.fullName = record.displayName();
            this.phoneNumber = record.phoneNumber;
        }

    }

    

}
