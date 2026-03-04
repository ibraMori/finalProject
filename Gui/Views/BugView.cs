using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    internal class BugView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string CreatorName { get; set; }
        public string Priority { get; set; }
        public string Severity { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string solved { get; set; }
        
        public BugView(Bug bug)
        {
            
            Id = bug.Id;
            Name = bug.Name;
            Description = bug.Description;
            Priority = bug.Priority.Name;
            CreatorName = bug.Creator.FullName();
            
            Severity = bug.Severity.Name;
            CreationDate = bug.CreationDate;
            LastUpdateDate = bug.LastUpdateDate;
            solved = bug.solved;
            
        }
    }
}
