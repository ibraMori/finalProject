using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using Message = DataAccess.Message;

namespace Gui
{
    public partial class MessageForm : Form
    {
        System.Action<Message> callback;
        static public string[] creators;
        static public string[] bugs;

        Form1 form1;
        BugManagementContext context1;
        public MessageForm(System.Action<Message> callback, Form1 form, BugManagementContext context)
        {
            InitializeComponent();
            this.callback = callback;
            comoboxCreator.DataSource = creators;
            comboBug.DataSource = bugs;
            form1 = form;
            context1 = context;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            callback.Invoke(GetMessage());
            messageView[] array = context1.Messages.Select(Message => new messageView(Message)).ToArray();
            form1.updateGridMessage();
            this.Close();
        }
        Message GetMessage()
        {
            Message message = new Message();
            message.Bugid = comboBug.SelectedIndex +1;
            message.Title = txtTitle.Text;
            message.Text = txtText.Text;
            message.CreatorId = comoboxCreator.SelectedIndex + 1;

            message.CreationDate = DateTime.Now;
            return message;
        }
    }
}
