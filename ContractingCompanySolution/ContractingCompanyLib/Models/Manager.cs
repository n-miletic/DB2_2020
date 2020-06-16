using System;
using System.Collections.Generic;
using System.Text;

namespace ContractingCompanyLib.Models
{
    public class Manager : Employee
    {
        public IEnumerable<Project> Projects { get; set; }
    }
}
