using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_queries
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public int sectionId { get; set; }

        public Employee(int id, string name, decimal salary, int sectionId)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.sectionId = sectionId;
        }
    }
}
