using System;
using System.Collections.Generic;
using System.Text;

namespace ContractingCompanyLib.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contract Contract { get; set; }
    }
}
