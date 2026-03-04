using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Gui
{
    
    public partial class PersonForm : Form
    {
        BugManagementContext context = new BugManagementContext();
        string pName;
        public PersonForm(string Name)
        {
            InitializeComponent();
            context.Bugs.Load();
            context.People.Load();
            context.Messages.Load();
            context.Messages.Load();
            context.Priorities.Load();
            context.Severities.Load();
            pName = Name;
            
            updateGridPerson();
        }
        public void updateGridPerson()
        {
            PersonView[] array = context.People.Where(condition).Select(Person => new PersonView(Person)).ToArray();
            dataGridViewPerson.DataSource = array;
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            
        }
        public bool condition(Person person)
        {
            if (person.FullName() == pName) { return true; }
            return false;
        }
        
    }
}
