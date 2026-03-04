using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    internal class filterBug
    {
        filterBugData data= new filterBugData();
        public filterBug(filterBugData data)
        {
            this.data = data;
        }
        public bool filter(Bug bug)
        {
            if(bug==null) { return false; }
            if(data==null) { return false; }

            if(data.useId && (bug.Id<data.fromId || bug.Id>data.toId)) { return false; }
            if (data.useName && !bug.Name.Contains(data.Name)) { return false; }
            if (data.useDescription && !bug.Description.Contains(data.Description)) { return false; }
            if ( data.useCreator&& (bug.CreatorID != data.CreatorId)) { return false; }
            if (data.usePriority && (bug.Priorityid != data.Priority)) { return false; }
            if (data.useSeverity && (bug.Severityid != data.Severity)) { return false; }
            if (data.useDates && (bug.CreationDate < data.CreationDate || bug.LastUpdateDate > data.LastUpdate)) { return false; }
            if (data.useSolved && (bug.solved != data.solved)) { return false; }

            return true;

        }
    }
}
