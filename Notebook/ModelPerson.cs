using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class ModelPerson
    {
        public string id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string number { get; set; }

        public ModelPerson(string id, string fName, string lName, string number)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.number = number;
        }
    }
}
