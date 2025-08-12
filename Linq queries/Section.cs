using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_queries
{
    class Marketing
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Marketing(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
