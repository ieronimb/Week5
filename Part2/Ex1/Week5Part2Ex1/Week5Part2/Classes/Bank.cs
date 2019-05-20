using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2.Classes
{
    public class Bank
    {
        private string bankNname;

        public Bank(string bankNname)
        {
            this.bankNname = bankNname;
        }
        public string Name
        {
            get { return this.bankNname; }
            set { this.bankNname = value; }
        }
        public override string ToString()
        {
            return string.Format($"The bank's name is: {bankNname}");
        }
    }
    
}
