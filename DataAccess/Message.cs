using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Message
    {
        public int id { get; set; }
        public int Bugid { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorId { get; set; }

        public Bug Bug { get; set; }

        public Person Creator { get; set; }
    }
}
