using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class Info
    {
        public string Name { get; set; }

        public string FullName { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        
    }
}
