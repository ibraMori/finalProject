using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Logs
    {
        public int id { get; set; }
        public int bugid { get; set; }
        public string text { get; set; }

        public DateTime CreationDate { get; set; }

        public Bug Bug { get; set; }

        public string Print()
        {
            return CreationDate.ToString() +"\n"+text;
        }
    }
    
}
