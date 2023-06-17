namespace LibraryDisplay.UserControls
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            homePanel = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            createButtonHomePanel = new Button();
            flowLayoutPanel11 = new FlowLayoutPanel();
            collectionButtonHomePanel = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            searchTextBox = new TextBox();
            searchButton = new Button();
            flowLayoutPanel12 = new FlowLayoutPanel();
            backButtonHomePanel = new Button();
            forwardButtonHomePanel = new Button();
            flowLayoutPanel8 = new FlowLayoutPanel();
            publishersCheckBox = new CheckBox();
            authorsCheckBox = new CheckBox();
            booksCheckBox = new CheckBox();
            allCheckBox = new CheckBox();
            splitContainer8 = new SplitContainer();
            genreTreeView = new TreeView();
            searchListView = new ListView();
            result = new ColumnHeader();
            category = new ColumnHeader();
            homePanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.Panel2.SuspendLayout();
            splitContainer8.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.ColumnCount = 1;
            homePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            homePanel.Controls.Add(tableLayoutPanel5, 0, 3);
            homePanel.Controls.Add(tableLayoutPanel4, 0, 0);
            homePanel.Controls.Add(flowLayoutPanel8, 0, 1);
            homePanel.Controls.Add(splitContainer8, 0, 2);
            homePanel.Location = new Point(34, 35);
            homePanel.Name = "homePanel";
            homePanel.RowCount = 4;
            homePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            homePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            homePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            homePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            homePanel.Size = new Size(1157, 1150);
            homePanel.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(flowLayoutPanel10, 2, 0);
            tableLayoutPanel5.Controls.Add(flowLayoutPanel11, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 1038);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1151, 109);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Controls.Add(createButtonHomePanel);
            flowLayoutPanel10.Dock = DockStyle.Fill;
            flowLayoutPanel10.Location = new Point(865, 3);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(283, 103);
            flowLayoutPanel10.TabIndex = 0;
            // 
            // createButtonHomePanel
            // 
            createButtonHomePanel.AutoSize = true;
            createButtonHomePanel.Location = new Point(3, 3);
            createButtonHomePanel.Name = "createButtonHomePanel";
            createButtonHomePanel.Size = new Size(112, 35);
            createButtonHomePanel.TabIndex = 0;
            createButtonHomePanel.Text = "Create...";
            createButtonHomePanel.UseVisualStyleBackColor = true;
            createButtonHomePanel.Click += createButtonHomePanel_Click;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Controls.Add(collectionButtonHomePanel);
            flowLayoutPanel11.Dock = DockStyle.Fill;
            flowLayoutPanel11.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel11.Location = new Point(3, 3);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(281, 103);
            flowLayoutPanel11.TabIndex = 1;
            // 
            // collectionButtonHomePanel
            // 
            collectionButtonHomePanel.AutoSize = true;
            collectionButtonHomePanel.Location = new Point(148, 3);
            collectionButtonHomePanel.Name = "collectionButtonHomePanel";
            collectionButtonHomePanel.Size = new Size(130, 35);
            collectionButtonHomePanel.TabIndex = 0;
            collectionButtonHomePanel.Text = "My Collection";
            collectionButtonHomePanel.UseVisualStyleBackColor = true;
            collectionButtonHomePanel.Click += collectionButtonHomePanel_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.45482F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.54518F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel9, 1, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel12, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1151, 109);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(searchTextBox);
            flowLayoutPanel9.Controls.Add(searchButton);
            flowLayoutPanel9.Dock = DockStyle.Fill;
            flowLayoutPanel9.Location = new Point(376, 3);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(772, 103);
            flowLayoutPanel9.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(3, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(413, 31);
            searchTextBox.TabIndex = 0;
            searchTextBox.KeyPress += searchTextBox_KeyPress;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(422, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Controls.Add(backButtonHomePanel);
            flowLayoutPanel12.Controls.Add(forwardButtonHomePanel);
            flowLayoutPanel12.Dock = DockStyle.Fill;
            flowLayoutPanel12.Location = new Point(3, 3);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(367, 103);
            flowLayoutPanel12.TabIndex = 1;
            // 
            // backButtonHomePanel
            // 
            backButtonHomePanel.Location = new Point(3, 3);
            backButtonHomePanel.Name = "backButtonHomePanel";
            backButtonHomePanel.Size = new Size(34, 34);
            backButtonHomePanel.TabIndex = 0;
            backButtonHomePanel.Text = "<";
            backButtonHomePanel.UseVisualStyleBackColor = true;
            // 
            // forwardButtonHomePanel
            // 
            forwardButtonHomePanel.Location = new Point(43, 3);
            forwardButtonHomePanel.Name = "forwardButtonHomePanel";
            forwardButtonHomePanel.Size = new Size(34, 34);
            forwardButtonHomePanel.TabIndex = 1;
            forwardButtonHomePanel.Text = ">";
            forwardButtonHomePanel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(publishersCheckBox);
            flowLayoutPanel8.Controls.Add(authorsCheckBox);
            flowLayoutPanel8.Controls.Add(booksCheckBox);
            flowLayoutPanel8.Controls.Add(allCheckBox);
            flowLayoutPanel8.Dock = DockStyle.Fill;
            flowLayoutPanel8.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel8.Location = new Point(3, 118);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(450, 0, 0, 0);
            flowLayoutPanel8.Size = new Size(1151, 109);
            flowLayoutPanel8.TabIndex = 1;
            // 
            // publishersCheckBox
            // 
            publishersCheckBox.AutoSize = true;
            publishersCheckBox.Location = new Point(580, 3);
            publishersCheckBox.Name = "publishersCheckBox";
            publishersCheckBox.Size = new Size(118, 29);
            publishersCheckBox.TabIndex = 3;
            publishersCheckBox.Text = "Publishers";
            publishersCheckBox.UseVisualStyleBackColor = true;
            // 
            // authorsCheckBox
            // 
            authorsCheckBox.AutoSize = true;
            authorsCheckBox.Location = new Point(473, 3);
            authorsCheckBox.Name = "authorsCheckBox";
            authorsCheckBox.Size = new Size(101, 29);
            authorsCheckBox.TabIndex = 2;
            authorsCheckBox.Text = "Authors";
            authorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // booksCheckBox
            // 
            booksCheckBox.AutoSize = true;
            booksCheckBox.Checked = true;
            booksCheckBox.CheckState = CheckState.Checked;
            booksCheckBox.Location = new Point(380, 3);
            booksCheckBox.Name = "booksCheckBox";
            booksCheckBox.Size = new Size(87, 29);
            booksCheckBox.TabIndex = 1;
            booksCheckBox.Text = "Books";
            booksCheckBox.UseVisualStyleBackColor = true;
            // 
            // allCheckBox
            // 
            allCheckBox.AutoSize = true;
            allCheckBox.Location = new Point(316, 3);
            allCheckBox.Name = "allCheckBox";
            allCheckBox.Size = new Size(58, 29);
            allCheckBox.TabIndex = 0;
            allCheckBox.Text = "All";
            allCheckBox.UseVisualStyleBackColor = true;
            allCheckBox.CheckedChanged += allCheckBox_CheckedChanged;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = DockStyle.Fill;
            splitContainer8.Location = new Point(3, 233);
            splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(genreTreeView);
            // 
            // splitContainer8.Panel2
            // 
            splitContainer8.Panel2.Controls.Add(searchListView);
            splitContainer8.Size = new Size(1151, 799);
            splitContainer8.SplitterDistance = 382;
            splitContainer8.TabIndex = 2;
            // 
            // genreTreeView
            // 
            genreTreeView.Cursor = Cursors.Hand;
            genreTreeView.Dock = DockStyle.Fill;
            genreTreeView.Location = new Point(0, 0);
            genreTreeView.Name = "genreTreeView";
            genreTreeView.Size = new Size(382, 799);
            genreTreeView.TabIndex = 0;
            genreTreeView.NodeMouseClick += genreTreeView_NodeMouseClick;
            // 
            // searchListView
            // 
            searchListView.Columns.AddRange(new ColumnHeader[] { result, category });
            searchListView.Cursor = Cursors.Hand;
            searchListView.Dock = DockStyle.Fill;
            searchListView.FullRowSelect = true;
            searchListView.Location = new Point(0, 0);
            searchListView.MultiSelect = false;
            searchListView.Name = "searchListView";
            searchListView.Size = new Size(765, 799);
            searchListView.TabIndex = 0;
            searchListView.UseCompatibleStateImageBehavior = false;
            searchListView.View = View.Details;
            searchListView.Click += searchListView_Click;
            // 
            // result
            // 
            result.Text = "Result";
            result.Width = 300;
            // 
            // category
            // 
            category.Text = "Category";
            category.Width = 100;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(homePanel);
            Name = "HomeControl";
            Size = new Size(1423, 1233);
            homePanel.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel12.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel homePanel;
        private TableLayoutPanel tableLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel10;
        private Button createButtonHomePanel;
        private FlowLayoutPanel flowLayoutPanel11;
        private Button collectionButtonHomePanel;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button searchButton;
        private FlowLayoutPanel flowLayoutPanel12;
        private TextBox searchTextBox;
        private FlowLayoutPanel flowLayoutPanel8;
        private CheckBox allCheckBox;
        private CheckBox booksCheckBox;
        private CheckBox authorsCheckBox;
        private CheckBox publishersCheckBox;
        private SplitContainer splitContainer8;
        private TreeView genreTreeView;
        private ListView searchListView;
        private ColumnHeader result;
        private ColumnHeader category;
        private Button backButtonHomePanel;
        private Button forwardButtonHomePanel;
    }
}
