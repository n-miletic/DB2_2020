using System;
using System.Collections.Generic;
using System.Text;

namespace ContractingCompanyLib.Models
{
    public class Contract
    {
        public Company Company { get; set; }
        public Project Project { get; set; }
        public Manager Manager { get; set; }
        public string Description { get; set; }
        // public IEnumerable<Company> Companies { get; set; }
        
    }
}
