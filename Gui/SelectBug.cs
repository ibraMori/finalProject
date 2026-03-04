using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class SelectBug : Form
    {
        DataAccess.BugManagementContext context = new DataAccess.BugManagementContext();

        
        
        public SelectBug()
        {
            InitializeComponent();
            context.Bugs.Load();
            context.People.Load();
            context.Messages.Load();
            context.Messages.Load();
            context.Priorities.Load();
            context.Severities.Load();
            comboBoxCreator.DataSource= context.People.Select(i => $"{i.Id}. {i.FullName()}").ToArray();
            comboBoxPriority.DataSource = context.Priorities.Select(i => $"{i.id}. {i.Name}").ToArray();
            comboBoxSeverity.DataSource = context.Severities.Select(i => $"{i.id}. {i.Name}").ToArray();
            
            

        }
        public void updateGridView(filterBugData data)

        {
            filterBug filter = new filterBug(data);
            
            BugView[] array = context.Bugs.Where(filter.filter).Select(Bug => new BugView(Bug)).ToArray();
            BugGridViewS.DataSource = array;
        }

        private void SelectBug_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        public filterBugData Getdata()
        {
            filterBugData filter = new filterBugData();
            if (txtFromId.Text != "") { filter.fromId = int.Parse(txtFromId.Text); }
            else { filter.fromId = 0; }
            if (txtToId.Text != "") { filter.toId = int.Parse(txtToId.Text); }
            else { filter.toId = 0; }
         
            filter.Name = txtName.Text;
            filter.Description = txtDescription.Text;
            filter.CreatorId = comboBoxCreator.SelectedIndex +1;
            filter.Priority = comboBoxPriority.SelectedIndex +1;
            filter.Severity = comboBoxSeverity.SelectedIndex +1;
            filter.CreationDate = dateTimeCreate.Value;
            filter.LastUpdate = dateTimeLastUpdate.Value;
            if(comboBox1.SelectedItem== null) { filter.solved = ""; } else { filter.solved = comboBox1.SelectedItem.ToString(); }
            filter.useId = !(filter.fromId == filter.toId);
            filter.useName = filter.Name != "";
            filter.useDescription = filter.Description != "";
            filter.useCreator = filter.CreatorId != 1;
            filter.usePriority= filter.Priority != 1;
            filter.useSeverity = filter.Severity != 1;
            filter.useDates = !(filter.CreationDate == filter.LastUpdate);
            filter.useSolved = filter.solved != "";
            
            return filter;
        }

        private void btnselc_Click(object sender, EventArgs e)
        {
            updateGridView(Getdata());
            panel1.Visible = true;
        }

        private void BugGridViewS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectId=0;
            string personName = "";
            
            string Createdate="";
            foreach (DataGridViewRow row in BugGridViewS.SelectedRows)
            {
                selectId = int.Parse(row.Cells[0].Value.ToString());
                break;
                
                
            }
            foreach (DataGridViewRow row in BugGridViewS.SelectedRows)
            {
                personName = row.Cells[3].Value.ToString();
                break;

            }
            foreach (DataGridViewRow row in BugGridViewS.SelectedRows)
            {
                 Createdate = row.Cells[6].Value.ToString();
                break;

            }
            

            BugGridViewS.SelectedRows.ToString();
            Form1 form = new Form1(selectId,personName,Createdate);
            form.Show();
        }
    }
}
