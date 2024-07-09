using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    internal class StudentInfo
    {
        private string fname, lname;
        private int studid;

        public StudentInfo()
        {
            this.fname = "";
            this.lname = "";
            this.studid = 0;
        }
        public string firstName { 
            get {
                    return this.fname;
            } 
            set { 
                    this.fname = value;
            } 
        }
        public string lastName
        {
            get
            {
                return this.lname;
            }
            set
            {
                this.lname = value;
            }
        }
        public int studentID
        {
            get
            {
                return this.studid;
            }
            set
            {
                this.studid = value;
            }
        }





    }
}
