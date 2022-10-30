using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managerinfo
{
    [Serializable]
    class Manager
    {
        private string Empname;

        public string empname
        {
            get
            {
                return empName;
            }

            set
            {
                empName = value;
            }
        }

        private string Id;

        public string id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private int Salary;

        public int salary
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }

        [NonSerialized]
        public string additionalInfo;
    }
}