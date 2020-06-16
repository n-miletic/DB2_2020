using System;
using System.Collections.Generic;
using System.Text;

namespace ContractingCompanyLib.Models
{
    public class Engineer : Employee
    {
        public EngineerType Type { get; set; }
        public IEnumerable<IsAssigned> Assigned { get; set; }
    }

    public enum EngineerType
    {
        SOFTWARE = 0,
        ELECTRIC,
        CIVIL,
        TELECOMUNICATION
    }
}
