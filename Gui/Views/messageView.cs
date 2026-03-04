using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Message = DataAccess.Message;

namespace Gui
{
    internal class messageView
    {
        public int id { get; set; }
        public string Bug { get; set; }
        public string Text { get; set; }

        public string CreatorId { get; set; }
        public DateTime CreationDate { get; set; }

        public messageView( Message message)
        {

            id = message.id;
            Bug = message.Bug.Name;
            Text = message.Text;
            CreatorId= message.Creator.FullName();
            
            CreationDate = message.CreationDate;
           

        }
    }
}
