namespace LibraryDisplay.UserControls
{
    partial class AuthorControl
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
            authorPanel = new SplitContainer();
            splitContainer13 = new SplitContainer();
            tableLayoutPanel9 = new TableLayoutPanel();
            homeButtonAuthorPanel = new Button();
            authorLabelAuthorPanel = new Label();
            descriptionLabelAuthorPanel = new TextBox();
            splitContainer14 = new SplitContainer();
            authorBookFlow = new FlowLayoutPanel();
            editButtonAuthorPanel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)authorPanel).BeginInit();
            authorPanel.Panel1.SuspendLayout();
            authorPanel.Panel2.SuspendLayout();
            authorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer13).BeginInit();
            splitContainer13.Panel1.SuspendLayout();
            splitContainer13.Panel2.SuspendLayout();
            splitContainer13.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer14).BeginInit();
            splitContainer14.Panel1.SuspendLayout();
            splitContainer14.Panel2.SuspendLayout();
            splitContainer14.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // authorPanel
            // 
            authorPanel.Location = new Point(49, 58);
            authorPanel.Name = "authorPanel";
            authorPanel.Orientation = Orientation.Horizontal;
            // 
            // authorPanel.Panel1
            // 
            authorPanel.Panel1.Controls.Add(splitContainer13);
            // 
            // authorPanel.Panel2
            // 
            authorPanel.Panel2.Controls.Add(splitContainer14);
            authorPanel.Size = new Size(865, 651);
            authorPanel.SplitterDistance = 200;
            authorPanel.TabIndex = 8;
            // 
            // splitContainer13
            // 
            splitContainer13.Dock = DockStyle.Fill;
            splitContainer13.Location = new Point(0, 0);
            splitContainer13.Name = "splitContainer13";
            splitContainer13.Orientation = Orientation.Horizontal;
            // 
            // splitContainer13.Panel1
            // 
            splitContainer13.Panel1.Controls.Add(tableLayoutPanel9);
            // 
            // splitContainer13.Panel2
            // 
            splitContainer13.Panel2.AutoScroll = true;
            splitContainer13.Panel2.Controls.Add(descriptionLabelAuthorPanel);
            splitContainer13.Panel2.Margin = new Padding(20);
            splitContainer13.Size = new Size(865, 200);
            splitContainer13.SplitterDistance = 59;
            splitContainer13.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.Controls.Add(editButtonAuthorPanel, 2, 0);
            tableLayoutPanel9.Controls.Add(authorLabelAuthorPanel, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(865, 59);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // homeButtonAuthorPanel
            // 
            homeButtonAuthorPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButtonAuthorPanel.Location = new Point(756, 9);
            homeButtonAuthorPanel.Margin = new Padding(3, 3, 3, 30);
            homeButtonAuthorPanel.Name = "homeButtonAuthorPanel";
            homeButtonAuthorPanel.Size = new Size(106, 34);
            homeButtonAuthorPanel.TabIndex = 8;
            homeButtonAuthorPanel.Text = "Home";
            homeButtonAuthorPanel.UseVisualStyleBackColor = true;
            homeButtonAuthorPanel.Click += homeButtonAuthorPanel_Click;
            // 
            // authorLabelAuthorPanel
            // 
            authorLabelAuthorPanel.Dock = DockStyle.Fill;
            authorLabelAuthorPanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            authorLabelAuthorPanel.Location = new Point(115, 0);
            authorLabelAuthorPanel.Name = "authorLabelAuthorPanel";
            authorLabelAuthorPanel.Size = new Size(635, 59);
            authorLabelAuthorPanel.TabIndex = 4;
            authorLabelAuthorPanel.Text = "Author";
            authorLabelAuthorPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabelAuthorPanel
            // 
            descriptionLabelAuthorPanel.Dock = DockStyle.Fill;
            descriptionLabelAuthorPanel.Location = new Point(0, 0);
            descriptionLabelAuthorPanel.Multiline = true;
            descriptionLabelAuthorPanel.Name = "descriptionLabelAuthorPanel";
            descriptionLabelAuthorPanel.ReadOnly = true;
            descriptionLabelAuthorPanel.ScrollBars = ScrollBars.Vertical;
            descriptionLabelAuthorPanel.Size = new Size(865, 137);
            descriptionLabelAuthorPanel.TabIndex = 4;
            descriptionLabelAuthorPanel.Text = "Description";
            // 
            // splitContainer14
            // 
            splitContainer14.Dock = DockStyle.Fill;
            splitContainer14.Location = new Point(0, 0);
            splitContainer14.Name = "splitContainer14";
            splitContainer14.Orientation = Orientation.Horizontal;
            // 
            // splitContainer14.Panel1
            // 
            splitContainer14.Panel1.Controls.Add(authorBookFlow);
            // 
            // splitContainer14.Panel2
            // 
            splitContainer14.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer14.Size = new Size(865, 447);
            splitContainer14.SplitterDistance = 370;
            splitContainer14.TabIndex = 0;
            // 
            // authorBookFlow
            // 
            authorBookFlow.AutoScroll = true;
            authorBookFlow.Dock = DockStyle.Fill;
            authorBookFlow.Location = new Point(0, 0);
            authorBookFlow.Name = "authorBookFlow";
            authorBookFlow.Size = new Size(865, 370);
            authorBookFlow.TabIndex = 1;
            // 
            // editButtonAuthorPanel
            // 
            editButtonAuthorPanel.Anchor = AnchorStyles.Right;
            editButtonAuthorPanel.Location = new Point(756, 14);
            editButtonAuthorPanel.Name = "editButtonAuthorPanel";
            editButtonAuthorPanel.Size = new Size(106, 31);
            editButtonAuthorPanel.TabIndex = 6;
            editButtonAuthorPanel.Text = "Edit";
            editButtonAuthorPanel.UseVisualStyleBackColor = true;
            editButtonAuthorPanel.Click += editButtonAuthorPanel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button5, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(3, 37);
            button5.Margin = new Padding(3, 3, 3, 30);
            button5.Name = "button5";
            button5.Size = new Size(34, 33);
            button5.TabIndex = 2;
            button5.Text = ">";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(3, 37);
            button4.Margin = new Padding(3, 3, 3, 30);
            button4.Name = "button4";
            button4.Size = new Size(34, 33);
            button4.TabIndex = 1;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 0, 0);
            tableLayoutPanel2.Controls.Add(homeButtonAuthorPanel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(865, 73);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(43, 10);
            button1.Margin = new Padding(3, 3, 3, 30);
            button1.Name = "button1";
            button1.Size = new Size(34, 33);
            button1.TabIndex = 2;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(3, 10);
            button2.Margin = new Padding(3, 3, 3, 30);
            button2.Name = "button2";
            button2.Size = new Size(34, 33);
            button2.TabIndex = 1;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            // 
            // AuthorControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(authorPanel);
            Name = "AuthorControl";
            Size = new Size(1013, 862);
            Load += AuthorControl_Load;
            authorPanel.Panel1.ResumeLayout(false);
            authorPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)authorPanel).EndInit();
            authorPanel.ResumeLayout(false);
            splitContainer13.Panel1.ResumeLayout(false);
            splitContainer13.Panel2.ResumeLayout(false);
            splitContainer13.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer13).EndInit();
            splitContainer13.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            splitContainer14.Panel1.ResumeLayout(false);
            splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer14).EndInit();
            splitContainer14.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer authorPanel;
        private SplitContainer splitContainer13;
        private TableLayoutPanel tableLayoutPanel9;
        private Button editButtonAuthorPanel;
        private Label authorLabelAuthorPanel;
        private SplitContainer splitContainer14;
        private FlowLayoutPanel authorBookFlow;
        private Button homeButtonAuthorPanel;
        private TextBox descriptionLabelAuthorPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button button4;
    }
}
