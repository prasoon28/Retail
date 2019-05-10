using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Student
    {
        int studid;
        string name;
        int sem;

        public int Studid
        {
            get
            {
                return studid;
            }

            set
            {
                studid = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Sem
        {
            get
            {
                return sem;
            }

            set
            {
                sem = value;
            }
        }
    }
}