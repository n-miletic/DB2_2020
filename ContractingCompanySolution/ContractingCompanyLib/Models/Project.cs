using System;
using System.Collections.Generic;
using System.Text;

namespace ContractingCompanyLib.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Contract Contract { get; set; }
        public IEnumerable<IsAssigned> Assigned { get; set; }
    }
}
