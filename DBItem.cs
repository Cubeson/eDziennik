using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edziennik
{
    public class DBItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DBItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    

}
