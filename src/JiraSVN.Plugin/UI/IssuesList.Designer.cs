﻿namespace CSharpTest.Net.JiraSVN.Plugin.UI
{
    partial class IssuesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.FlowLayoutPanel panel1;
            System.Windows.Forms.BindingSource possibleAssignmentsBindingSource;
            System.Windows.Forms.BindingSource actionsAvailableBindingSource;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.GroupBox panel2;
            System.Windows.Forms.BindingSource filtersBindingSource;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.BindingSource statusFilterBindingSource;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.BindingSource assignmentFilterBindingSource;
            System.Windows.Forms.ColumnHeader hdrId;
            System.Windows.Forms.ColumnHeader hdrSummary;
            System.Windows.Forms.ColumnHeader hdrAssignedTo;
            System.Windows.Forms.ColumnHeader hdrReportedBy;
            System.Windows.Forms.ColumnHeader hdrLastMod;
            System.Windows.Forms.ColumnHeader hdrCreated;
            System.Windows.Forms.ColumnHeader hdrStatus;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuesList));
            this._showHideMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTimeTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this._binding = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._filters = new CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox();
            this._search = new System.Windows.Forms.TextBox();
            this._status = new CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox();
            this._assigned = new CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox();
            this._listView = new System.Windows.Forms.ListView();
            this._contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._doTakeAction = new System.Windows.Forms.CheckBox();
            this._assignTo = new CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox();
            this._takeAction = new CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox();
            this._doAssignTo = new System.Windows.Forms.CheckBox();
            this._comment = new System.Windows.Forms.TextBox();
            this._addWorklog = new System.Windows.Forms.CheckBox();
            this._worklogAction = new CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox();
            this.remainingEstimateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._worklog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._worklogGroup = new System.Windows.Forms.GroupBox();
            this._hideTimeTracking = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._splitter = new System.Windows.Forms.SplitContainer();
            panel1 = new System.Windows.Forms.FlowLayoutPanel();
            possibleAssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            actionsAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label6 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.GroupBox();
            filtersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            statusFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            assignmentFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            hdrId = new System.Windows.Forms.ColumnHeader();
            hdrSummary = new System.Windows.Forms.ColumnHeader();
            hdrAssignedTo = new System.Windows.Forms.ColumnHeader();
            hdrReportedBy = new System.Windows.Forms.ColumnHeader();
            hdrLastMod = new System.Windows.Forms.ColumnHeader();
            hdrCreated = new System.Windows.Forms.ColumnHeader();
            hdrStatus = new System.Windows.Forms.ColumnHeader();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            panel1.SuspendLayout();
            this._showHideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(possibleAssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._binding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(actionsAvailableBindingSource)).BeginInit();
            panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(filtersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(statusFilterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(assignmentFilterBindingSource)).BeginInit();
            groupBox1.SuspendLayout();
            this._contextMenu.SuspendLayout();
            groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remainingEstimateBindingSource)).BeginInit();
            this._worklogGroup.SuspendLayout();
            this._hideTimeTracking.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._splitter.Panel1.SuspendLayout();
            this._splitter.Panel2.SuspendLayout();
            this._splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.ContextMenuStrip = this._showHideMenu;
            panel1.Controls.Add(this.cancelButton);
            panel1.Controls.Add(this.okButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            panel1.Location = new System.Drawing.Point(3, 459);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(1);
            panel1.Size = new System.Drawing.Size(646, 31);
            panel1.TabIndex = 2;
            // 
            // _showHideMenu
            // 
            this._showHideMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTimeTrackingToolStripMenuItem});
            this._showHideMenu.Name = "_showHideMenu";
            this._showHideMenu.Size = new System.Drawing.Size(165, 26);
            // 
            // showTimeTrackingToolStripMenuItem
            // 
            this.showTimeTrackingToolStripMenuItem.Checked = true;
            this.showTimeTrackingToolStripMenuItem.CheckOnClick = true;
            this.showTimeTrackingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTimeTrackingToolStripMenuItem.Name = "showTimeTrackingToolStripMenuItem";
            this.showTimeTrackingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showTimeTrackingToolStripMenuItem.Text = "Show time tracking";
            this.showTimeTrackingToolStripMenuItem.Click += new System.EventHandler(this.showTimeTrackingToolStripMenuItem_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(566, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(485, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // possibleAssignmentsBindingSource
            // 
            possibleAssignmentsBindingSource.DataMember = "PossibleAssignments";
            possibleAssignmentsBindingSource.DataSource = this._binding;
            // 
            // _binding
            // 
            this._binding.DataSource = typeof(CSharpTest.Net.JiraSVN.Plugin.UI.IssuesListView);
            // 
            // actionsAvailableBindingSource
            // 
            actionsAvailableBindingSource.DataMember = "ActionsAvailable";
            actionsAvailableBindingSource.DataSource = this._binding;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "AddWorklog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            label6.Location = new System.Drawing.Point(301, 7);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 13);
            label6.TabIndex = 2;
            label6.Text = "and update estimate:";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(this.tableLayoutPanel3);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(646, 73);
            panel2.TabIndex = 0;
            panel2.TabStop = false;
            panel2.Text = "Filter";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._filters, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._search, 5, 1);
            this.tableLayoutPanel3.Controls.Add(label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(label3, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this._status, 3, 1);
            this.tableLayoutPanel3.Controls.Add(label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(label4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this._assigned, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(640, 54);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // _filters
            // 
            this._filters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this._filters, 5);
            this._filters.DataBindings.Add(new System.Windows.Forms.Binding("IndexSelected", this._binding, "SelectedFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._filters.DataSource = filtersBindingSource;
            this._filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._filters.FormattingEnabled = true;
            this._filters.IndexSelected = -1;
            this._filters.Location = new System.Drawing.Point(79, 3);
            this._filters.Name = "_filters";
            this._filters.Size = new System.Drawing.Size(558, 21);
            this._filters.TabIndex = 1;
            // 
            // filtersBindingSource
            // 
            filtersBindingSource.DataMember = "Filters";
            filtersBindingSource.DataSource = this._binding;
            // 
            // _search
            // 
            this._search.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._binding, "TextFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._search.Dock = System.Windows.Forms.DockStyle.Fill;
            this._search.Location = new System.Drawing.Point(421, 30);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(216, 20);
            this._search.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 13);
            label2.TabIndex = 0;
            label2.Text = "Apply Filter:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(364, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 6;
            label3.Text = "Contains:";
            // 
            // _status
            // 
            this._status.DataBindings.Add(new System.Windows.Forms.Binding("IndexSelected", this._binding, "SelectedStatusFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._status.DataSource = statusFilterBindingSource;
            this._status.Dock = System.Windows.Forms.DockStyle.Fill;
            this._status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._status.FormattingEnabled = true;
            this._status.IndexSelected = -1;
            this._status.Location = new System.Drawing.Point(250, 30);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(105, 21);
            this._status.TabIndex = 5;
            // 
            // statusFilterBindingSource
            // 
            statusFilterBindingSource.DataMember = "StatusFilter";
            statusFilterBindingSource.DataSource = this._binding;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 2;
            label1.Text = "Assinged to:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(204, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 4;
            label4.Text = "Status:";
            // 
            // _assigned
            // 
            this._assigned.DataBindings.Add(new System.Windows.Forms.Binding("IndexSelected", this._binding, "SelectedAssignmentFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._assigned.DataSource = assignmentFilterBindingSource;
            this._assigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this._assigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._assigned.FormattingEnabled = true;
            this._assigned.IndexSelected = -1;
            this._assigned.Location = new System.Drawing.Point(79, 30);
            this._assigned.Name = "_assigned";
            this._assigned.Size = new System.Drawing.Size(105, 21);
            this._assigned.TabIndex = 3;
            // 
            // assignmentFilterBindingSource
            // 
            assignmentFilterBindingSource.DataMember = "AssignmentFilter";
            assignmentFilterBindingSource.DataSource = this._binding;
            // 
            // hdrId
            // 
            hdrId.Text = "Id";
            // 
            // hdrSummary
            // 
            hdrSummary.Text = "Summary";
            hdrSummary.Width = 400;
            // 
            // hdrAssignedTo
            // 
            hdrAssignedTo.Text = "Assigned To";
            hdrAssignedTo.Width = 100;
            // 
            // hdrReportedBy
            // 
            hdrReportedBy.Text = "Reported By";
            hdrReportedBy.Width = 100;
            // 
            // hdrLastMod
            // 
            hdrLastMod.Text = "Last Modified";
            hdrLastMod.Width = 100;
            // 
            // hdrCreated
            // 
            hdrCreated.Text = "Created On";
            hdrCreated.Width = 100;
            // 
            // hdrStatus
            // 
            hdrStatus.Text = "Status";
            hdrStatus.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this._listView);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(640, 201);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Issues";
            // 
            // _listView
            // 
            this._listView.CheckBoxes = true;
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            hdrId,
            hdrSummary,
            hdrStatus,
            hdrAssignedTo,
            hdrReportedBy,
            hdrLastMod,
            hdrCreated});
            this._listView.ContextMenuStrip = this._contextMenu;
            this._listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listView.FullRowSelect = true;
            this._listView.Location = new System.Drawing.Point(3, 16);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(634, 182);
            this._listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._listView.TabIndex = 0;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            this._listView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
            this._listView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this._listView_ItemMouseHover);
            this._listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this._listView_MouseMove);
            this._listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDown);
            // 
            // _contextMenu
            // 
            this._contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewIssueToolStripMenuItem,
            this.refreshIssueToolStripMenuItem,
            this.toolStripSeparator1});
            this._contextMenu.Name = "_contextMenu";
            this._contextMenu.Size = new System.Drawing.Size(166, 54);
            this._contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // viewIssueToolStripMenuItem
            // 
            this.viewIssueToolStripMenuItem.Name = "viewIssueToolStripMenuItem";
            this.viewIssueToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewIssueToolStripMenuItem.Text = "&View Issue...";
            this.viewIssueToolStripMenuItem.ToolTipText = "Open the issue in the default viewer.";
            this.viewIssueToolStripMenuItem.Click += new System.EventHandler(this.listView_ViewSelectedItem);
            // 
            // refreshIssueToolStripMenuItem
            // 
            this.refreshIssueToolStripMenuItem.Name = "refreshIssueToolStripMenuItem";
            this.refreshIssueToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.refreshIssueToolStripMenuItem.Text = "&Refresh Issues List";
            this.refreshIssueToolStripMenuItem.ToolTipText = "Requery the server and refresh the list.";
            this.refreshIssueToolStripMenuItem.Click += new System.EventHandler(this.RefreshContents);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(this.tableLayoutPanel2);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox2.Location = new System.Drawing.Point(3, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(640, 46);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.15783F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.84217F));
            this.tableLayoutPanel2.Controls.Add(this._doTakeAction, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._assignTo, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this._takeAction, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._doAssignTo, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 27);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // _doTakeAction
            // 
            this._doTakeAction.AutoSize = true;
            this._doTakeAction.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._binding, "PerformAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._doTakeAction.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "CanPerformActions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._doTakeAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this._doTakeAction.Location = new System.Drawing.Point(3, 3);
            this._doTakeAction.Name = "_doTakeAction";
            this._doTakeAction.Size = new System.Drawing.Size(70, 21);
            this._doTakeAction.TabIndex = 6;
            this._doTakeAction.Text = "Set:";
            this._doTakeAction.UseVisualStyleBackColor = true;
            // 
            // _assignTo
            // 
            this._assignTo.DataBindings.Add(new System.Windows.Forms.Binding("IndexSelected", this._binding, "SelectedAssignee", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._assignTo.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "CanAssignTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._assignTo.DataSource = possibleAssignmentsBindingSource;
            this._assignTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._assignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._assignTo.FormattingEnabled = true;
            this._assignTo.IndexSelected = -1;
            this._assignTo.Location = new System.Drawing.Point(415, 3);
            this._assignTo.Name = "_assignTo";
            this._assignTo.Size = new System.Drawing.Size(216, 21);
            this._assignTo.TabIndex = 9;
            // 
            // _takeAction
            // 
            this._takeAction.DataBindings.Add(new System.Windows.Forms.Binding("IndexSelected", this._binding, "SelectedAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._takeAction.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "PerformAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._takeAction.DataSource = actionsAvailableBindingSource;
            this._takeAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this._takeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._takeAction.FormattingEnabled = true;
            this._takeAction.IndexSelected = -1;
            this._takeAction.Location = new System.Drawing.Point(79, 3);
            this._takeAction.Name = "_takeAction";
            this._takeAction.Size = new System.Drawing.Size(216, 21);
            this._takeAction.TabIndex = 7;
            // 
            // _doAssignTo
            // 
            this._doAssignTo.AutoSize = true;
            this._doAssignTo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._binding, "AssignTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._doAssignTo.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "PerformAction", true));
            this._doAssignTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._doAssignTo.Location = new System.Drawing.Point(301, 3);
            this._doAssignTo.Name = "_doAssignTo";
            this._doAssignTo.Size = new System.Drawing.Size(108, 21);
            this._doAssignTo.TabIndex = 8;
            this._doAssignTo.Text = "and assign to:";
            this._doAssignTo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(this._comment);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(640, 74);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Comment";
            // 
            // _comment
            // 
            this._comment.AcceptsReturn = true;
            this._comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._binding, "Comments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comment.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._comment.Location = new System.Drawing.Point(3, 16);
            this._comment.Multiline = true;
            this._comment.Name = "_comment";
            this._comment.Size = new System.Drawing.Size(634, 55);
            this._comment.TabIndex = 1;
            // 
            // _addWorklog
            // 
            this._addWorklog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._addWorklog.AutoSize = true;
            this._addWorklog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._binding, "AddWorklog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._addWorklog.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "CanAddWorklog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._addWorklog.Location = new System.Drawing.Point(3, 5);
            this._addWorklog.Name = "_addWorklog";
            this._addWorklog.Size = new System.Drawing.Size(69, 17);
            this._addWorklog.TabIndex = 0;
            this._addWorklog.Text = "Log time:";
            this._addWorklog.UseVisualStyleBackColor = true;
            // 
            // _worklogAction
            // 
            this._worklogAction.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "AddWorklog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._worklogAction.DataBindings.Add(new System.Windows.Forms.Binding("IndexSelected", this._binding, "TimeEstimateRecalcualation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._worklogAction.DataSource = this.remainingEstimateBindingSource;
            this._worklogAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this._worklogAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._worklogAction.FormattingEnabled = true;
            this._worklogAction.IndexSelected = -1;
            this._worklogAction.Location = new System.Drawing.Point(79, 3);
            this._worklogAction.Name = "_worklogAction";
            this._worklogAction.Size = new System.Drawing.Size(216, 21);
            this._worklogAction.TabIndex = 3;
            // 
            // remainingEstimateBindingSource
            // 
            this.remainingEstimateBindingSource.DataMember = "TimeEstimateMethodsAvailable";
            this.remainingEstimateBindingSource.DataSource = this._binding;
            // 
            // _worklog
            // 
            this._worklog.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "AddWorklog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._worklog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._binding, "TimeSpent", true));
            this._worklog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._worklog.Location = new System.Drawing.Point(415, 3);
            this._worklog.Name = "_worklog";
            this._worklog.Size = new System.Drawing.Size(117, 20);
            this._worklog.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._binding, "NewTimeEstimate", true));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "CanSpecifyNewEstimate", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(538, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 4;
            // 
            // _worklogGroup
            // 
            this._worklogGroup.AccessibleDescription = "";
            this._worklogGroup.AutoSize = true;
            this._worklogGroup.ContextMenuStrip = this._hideTimeTracking;
            this._worklogGroup.Controls.Add(this.tableLayoutPanel1);
            this._worklogGroup.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this._binding, "CanAddWorklog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._worklogGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._worklogGroup.Location = new System.Drawing.Point(3, 77);
            this._worklogGroup.Name = "_worklogGroup";
            this._worklogGroup.Size = new System.Drawing.Size(640, 46);
            this._worklogGroup.TabIndex = 6;
            this._worklogGroup.TabStop = false;
            this._worklogGroup.Text = "Time tracking";
            // 
            // _hideTimeTracking
            // 
            this._hideTimeTracking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem});
            this._hideTimeTracking.Name = "_hideTimeTracking";
            this._hideTimeTracking.Size = new System.Drawing.Size(96, 26);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.hideToolStripMenuItem.Text = "&Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.87611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.12389F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this._worklog, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._worklogAction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._addWorklog, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 27);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // _splitter
            // 
            this._splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitter.Location = new System.Drawing.Point(3, 76);
            this._splitter.Name = "_splitter";
            this._splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitter.Panel1
            // 
            this._splitter.Panel1.Controls.Add(groupBox1);
            this._splitter.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // _splitter.Panel2
            // 
            this._splitter.Panel2.Controls.Add(groupBox3);
            this._splitter.Panel2.Controls.Add(this._worklogGroup);
            this._splitter.Panel2.Controls.Add(groupBox2);
            this._splitter.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this._splitter.Size = new System.Drawing.Size(646, 383);
            this._splitter.SplitterDistance = 207;
            this._splitter.TabIndex = 1;
            // 
            // IssuesList
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(652, 493);
            this.Controls.Add(this._splitter);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "IssuesList";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Issue(s)";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            panel1.ResumeLayout(false);
            this._showHideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(possibleAssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._binding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(actionsAvailableBindingSource)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(filtersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(statusFilterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(assignmentFilterBindingSource)).EndInit();
            groupBox1.ResumeLayout(false);
            this._contextMenu.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remainingEstimateBindingSource)).EndInit();
            this._worklogGroup.ResumeLayout(false);
            this._worklogGroup.PerformLayout();
            this._hideTimeTracking.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._splitter.Panel1.ResumeLayout(false);
            this._splitter.Panel2.ResumeLayout(false);
            this._splitter.Panel2.PerformLayout();
            this._splitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ListView _listView;
		private System.Windows.Forms.CheckBox _doTakeAction;
		private CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox _filters;
		private System.Windows.Forms.TextBox _search;
		private CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox _status;
		private CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox _assigned;
		private System.Windows.Forms.TextBox _comment;
		private System.Windows.Forms.SplitContainer _splitter;
		private System.Windows.Forms.CheckBox _doAssignTo;
		private CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox _takeAction;
        private CSharpTest.Net.JiraSVN.Plugin.UI.BindingComboBox _assignTo;
		private System.Windows.Forms.BindingSource _binding;
		private System.Windows.Forms.ContextMenuStrip _contextMenu;
		private System.Windows.Forms.ToolStripMenuItem viewIssueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource remainingEstimateBindingSource;
        private System.Windows.Forms.GroupBox _worklogGroup;
        private BindingComboBox _worklogAction;
        private System.Windows.Forms.TextBox _worklog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox _addWorklog;
        private System.Windows.Forms.ContextMenuStrip _showHideMenu;
        private System.Windows.Forms.ToolStripMenuItem showTimeTrackingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _hideTimeTracking;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}