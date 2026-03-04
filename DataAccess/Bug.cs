using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataAccess
{
    public class Bug
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string? Description { get; set; }
        public int CreatorID { get; set; }
        public int Priorityid { get; set; }
        public int Severityid { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string? solved { get; set; }
        public List<Message>? Messages { get; set; }

        public List<Logs>? Logs { get; set; }


        public virtual Person? Creator { get; set; }

        public virtual Priority? Priority { get; set; }

        public virtual Severity ? Severity { get; set; }




    }
}
