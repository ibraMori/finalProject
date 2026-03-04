namespace Gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BugGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rchtxtLogs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BugGridView)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BugGridView
            // 
            this.BugGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BugGridView.Location = new System.Drawing.Point(12, 35);
            this.BugGridView.Name = "BugGridView";
            this.BugGridView.RowHeadersWidth = 51;
            this.BugGridView.RowTemplate.Height = 29;
            this.BugGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BugGridView.Size = new System.Drawing.Size(491, 222);
            this.BugGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "CreateBug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(859, 12);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(111, 44);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select bugs";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(702, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btncancel);
            this.panelEdit.Controls.Add(this.btnSave);
            this.panelEdit.Location = new System.Drawing.Point(630, 76);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(237, 76);
            this.panelEdit.TabIndex = 4;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(140, 25);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(543, 158);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(427, 29);
            this.btnPerson.TabIndex = 5;
            this.btnPerson.Text = "button2";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(491, 228);
            this.dataGridView1.TabIndex = 6;
            // 
            // rchtxtLogs
            // 
            this.rchtxtLogs.AcceptsTab = true;
            this.rchtxtLogs.Location = new System.Drawing.Point(509, 231);
            this.rchtxtLogs.Name = "rchtxtLogs";
            this.rchtxtLogs.Size = new System.Drawing.Size(461, 310);
            this.rchtxtLogs.TabIndex = 7;
            this.rchtxtLogs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bug";
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(175, 278);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(94, 29);
            this.btnMessage.TabIndex = 9;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Logs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchtxtLogs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BugGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BugGridView)).EndInit();
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView BugGridView;
        private Button button1;
        private Button SelectButton;
        private Button btnEdit;
        private Panel panelEdit;
        private Button btncancel;
        private Button btnSave;
        private Button btnPerson;
        private DataGridView dataGridView1;
        private RichTextBox rchtxtLogs;
        private Label label1;
        private Button btnMessage;
        private Label label2;
    }
}