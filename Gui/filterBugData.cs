using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    public class filterBugData
    {
        public int fromId;
        public int toId;
        public string Name;
        public string Description;
        public int CreatorId;
        public int Priority;
        public int Severity;
        public DateTime CreationDate;
        public DateTime LastUpdate;
        public string solved;

        public bool useId;
        public bool useName;
        public bool useDescription;
        public bool useCreator;
        public bool usePriority;
        public bool useSeverity;
        public bool useDates;
        public bool useSolved;


    }
}
