using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System.Linq;
using System.Security.Cryptography;
using Message = DataAccess.Message;

namespace Gui
{
    public partial class Form1 : Form
    {
        private Form1 myform;
        DataAccess.BugManagementContext context = new DataAccess.BugManagementContext();
        DataAccess.BugManagementContext context1 = new DataAccess.BugManagementContext();
        int selectId;
        string person;
        string newName;
        string newDesc;
        string newPriority;
        string newSeverity;
        string newSolved;
        string oldName;
        string oldDesc;
        string oldPriority;
        string oldSeverity;
        string oldSolved;
        string CreateDate;

        int personId = 0;
        int prioId = 0;
        int severId = 0;
        public Form1(int select, string personName, string date)
        {

            InitializeComponent();
            context.Bugs.Load();
            context.People.Load();
            context.Messages.Load();
            context.Messages.Load();
            context.Priorities.Load();
            context.Severities.Load();
            selectId = select;
            person = personName;
            CreateDate = date;
            updateGrid();
            updateGridMessage();
            affichLogs();
            NewBugcs.creators = context.People.Select(i => $"{i.Id}. {i.FullName()}").ToArray();
            NewBugcs.priorities = context.Priorities.Select(i => $"{i.id}. {i.Name}").ToArray();
            NewBugcs.severities = context.Severities.Select(i => $"{i.id}. {i.Name}").ToArray();
            MessageForm.creators = context.People.Select(i => $"{i.Id}. {i.FullName()}").ToArray();
            MessageForm.bugs = context.Bugs.Select(i => $"{i.Id}. {i.Name}").ToArray();
            foreach (DataGridViewRow row in BugGridView.Rows)
            {
                oldName = row.Cells[1].Value.ToString();
                oldDesc = row.Cells[2].Value.ToString();
                oldPriority = row.Cells[4].Value.ToString();
                oldSeverity = row.Cells[5].Value.ToString();
                oldSolved = row.Cells[8].Value.ToString();
                break;

            }
        }

        public void updateGrid()
        {
            BugView[] array = context.Bugs.Where(condition).Select(Bug => new BugView(Bug)).ToArray();
            BugGridView.DataSource = array;

            btnPerson.Text = person;
        }
        public bool condition(Bug bug)
        {
            if (bug.Id == selectId) { return true; }
            return false;
        }
        public void createBug(Bug bug)
        {
            context.Add(bug);
            context.SaveChanges();

        }
        public void createMessage(Message message)
        {
            context.Add(message);
            context.SaveChanges();

        }
        public void createLog(Logs journal)
        {
            context.Add(journal);
            context.SaveChanges();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            BugGridView.Columns["Name"].ReadOnly = true;
            BugGridView.Columns["Description"].ReadOnly = true;
            BugGridView.Columns["CreatorName"].ReadOnly = true;
            BugGridView.Columns["Priority"].ReadOnly = true;
            BugGridView.Columns["Severity"].ReadOnly = true;
            BugGridView.Columns["CreationDate"].ReadOnly = true;
            BugGridView.Columns["LastUpdateDate"].ReadOnly = true;
            BugGridView.Columns["Solved"].ReadOnly = true;


            panelEdit.Visible = false;


            btnPerson.Text = person;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewBugcs NewBugF = new NewBugcs(createBug, this, context);
            NewBugF.Show();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SelectBug selectBugF = new SelectBug();
            selectBugF.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            BugGridView.Columns["Name"].ReadOnly = false;
            BugGridView.Columns["Description"].ReadOnly = false;
            BugGridView.Columns["Priority"].ReadOnly = false;
            BugGridView.Columns["Severity"].ReadOnly = false;
            BugGridView.Columns["Solved"].ReadOnly = false;


        }

        private void btnPerson_Click(object sender, EventArgs e)
        {


            PersonForm pForm = new PersonForm(person);
            pForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BugGridView.Rows)
            {
                newName = row.Cells[1].Value.ToString();
                newDesc = row.Cells[2].Value.ToString();
                newPriority = row.Cells[4].Value.ToString();
                newSeverity = row.Cells[5].Value.ToString();
                newSolved = row.Cells[8].Value.ToString();
                break;

            }

            updateBug(getBug());

            updateGrid();

            BugGridView.Columns["Name"].ReadOnly = true;
            BugGridView.Columns["Description"].ReadOnly = true;
            BugGridView.Columns["Priority"].ReadOnly = true;
            BugGridView.Columns["Severity"].ReadOnly = true;
            BugGridView.Columns["Solved"].ReadOnly = true;
            panelEdit.Visible = false;
            if (oldDesc != newDesc || oldName != newName || oldPriority == newPriority
                || oldSeverity != newSeverity || oldSolved != newSolved)
            {
                createLog(GetLog(CreatelogText()));
                Form1 form = new Form1(selectId, person, CreateDate);
                this.Dispose();
                form.Show();
            }
           

            

        }
        public void updateBug(Bug bug)
        {
            context1.Update(bug);
            context1.SaveChanges();
            
        }
        public Bug getBug()
        {
            
            
            
            foreach(Bug buggy in context.Bugs)
            {
                if (buggy.Id == selectId)
                {
                    personId = buggy.CreatorID;
                    
                    break;
                }
                
            }
            foreach (Priority prio in context.Priorities)
            {
                if ( prio.Name== newPriority)
                {
                    prioId = prio.id;
                    break;
                }
                
            }
            foreach (Severity sever in context.Severities)
            {
                if (sever.Name == newSeverity)
                {
                    severId = sever.id;
                    break;
                }
                
            }

            Bug bug = new Bug();
            bug.Id = selectId;
            bug.Name = newName;
            bug.CreatorID= personId;
            bug.Description = newDesc;
            bug.Priorityid = prioId;
            bug.Severityid = severId;
            bug.CreationDate = DateTime.Parse(CreateDate);
            bug.LastUpdateDate = DateTime.Now;
            bug.solved = newSolved;
            return bug;

            
        }
        public Logs GetLog(string text)
        {
            Logs journal = new Logs();
            journal.bugid = selectId;
            journal.text = text;
            journal.CreationDate = DateTime.Now;
            return journal;
        }
        public void affichLogs()
        {
            rchtxtLogs.Clear();
            foreach(Logs journal in context.Logs)
            {
                rchtxtLogs.Text += journal.Print();
            }
        }
        public void updateGridMessage()
        {
            messageView[] array = context.Messages.Select(Message => new messageView(Message)).ToArray();
            dataGridView1.DataSource = array;
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageForm MessageF = new MessageForm(createMessage, this, context);
            MessageF.Show();
        }
        public void helpNewBug(int select, string name, string date)
        {
            selectId = select;
            person = name;
            CreateDate= date;
        }
        public string CreatelogText()
        {
            string output = "\n";
            if(oldName!= newName) { output += $" Name has been changed to {newName}  \n ";  }
            if(oldDesc!= newDesc) { output += $" Description has been changed to {newDesc} \n"; }
            if (oldPriority!= newPriority) { output += $" Priority has been changed to {newPriority} \n"; }
            if (oldSeverity!= newSeverity) { output += $" Severity has been changed to {newSeverity} \n"; }
            if (oldSolved!= newSolved) { output += $" Solved has been changed to {newSolved}  \n"; }
            return output;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            BugGridView.Columns["Name"].ReadOnly = true;
            BugGridView.Columns["Description"].ReadOnly = true;
            BugGridView.Columns["Priority"].ReadOnly = true;
            BugGridView.Columns["Severity"].ReadOnly = true;
            BugGridView.Columns["Solved"].ReadOnly = true;
            panelEdit.Visible = false;
            Form1 form = new Form1(selectId, person, CreateDate);
            this.Dispose();
            form.Show();
        }
        
    }
}