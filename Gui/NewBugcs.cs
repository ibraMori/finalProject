using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Gui
{
    public partial class NewBugcs : Form
    {
        System.Action<Bug> callback;
        static public string[] creators;
        static public string[] priorities;
        static public string[] severities;
        Form1 form1;
        BugManagementContext context1;
        string date;
        public NewBugcs(System.Action<Bug> callback, Form1 form, BugManagementContext context)
        {
            InitializeComponent();
            this.callback = callback;
            comoboxCreator.DataSource = creators;
            comboBoxPriority.DataSource = priorities;
            comboBoxSeverity.DataSource = severities;
            form1 = form;
            context1 = context;
        }

        private void NewBugcs_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string persName="";
            callback.Invoke(GetBug());
            int last = context1.Bugs.Count();
            foreach(Bug buggy in context1.Bugs)
            {
                last = buggy.Id;
                persName = buggy.Creator.FullName();

            }
            form1.createLog(form1.GetLog("\n\nBug has been created "));
            
            form1.helpNewBug(last,persName , DateTime.Now.ToString());
            BugView[] array = context1.Bugs.Select(Bug => new BugView(Bug)).ToArray();
            form1.updateGrid();
            form1.affichLogs();



            this.Close();
        }
        Bug GetBug()
        {
            Bug bug = new Bug();
            bug.Name = txtNom.Text;
            bug.Description = txtDesc.Text;
            bug.CreatorID = comoboxCreator.SelectedIndex +1;
            bug.Priorityid = comboBoxPriority.SelectedIndex +1;
            bug.Severityid = comboBoxSeverity.SelectedIndex + 1;
            bug.CreationDate= DateTime.Now;
            bug.LastUpdateDate= DateTime.Now;
            bug.solved = "false";
            




            return bug;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
