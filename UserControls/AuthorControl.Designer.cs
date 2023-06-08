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
            flowLayoutPanel22 = new FlowLayoutPanel();
            editButtonAuthorPanel = new Button();
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
            flowLayoutPanel22.SuspendLayout();
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
            authorPanel.Size = new Size(782, 523);
            authorPanel.SplitterDistance = 161;
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
            splitContainer13.Size = new Size(782, 161);
            splitContainer13.SplitterDistance = 48;
            splitContainer13.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.Controls.Add(homeButtonAuthorPanel, 2, 0);
            tableLayoutPanel9.Controls.Add(authorLabelAuthorPanel, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(782, 48);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // homeButtonAuthorPanel
            // 
            homeButtonAuthorPanel.Anchor = AnchorStyles.Right;
            homeButtonAuthorPanel.Location = new Point(673, 7);
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
            authorLabelAuthorPanel.Size = new Size(552, 48);
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
            descriptionLabelAuthorPanel.Size = new Size(782, 109);
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
            splitContainer14.Panel2.Controls.Add(flowLayoutPanel22);
            splitContainer14.Size = new Size(782, 358);
            splitContainer14.SplitterDistance = 297;
            splitContainer14.TabIndex = 0;
            // 
            // authorBookFlow
            // 
            authorBookFlow.AutoScroll = true;
            authorBookFlow.Dock = DockStyle.Fill;
            authorBookFlow.Location = new Point(0, 0);
            authorBookFlow.Name = "authorBookFlow";
            authorBookFlow.Size = new Size(782, 297);
            authorBookFlow.TabIndex = 1;
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.Controls.Add(editButtonAuthorPanel);
            flowLayoutPanel22.Dock = DockStyle.Fill;
            flowLayoutPanel22.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel22.Location = new Point(0, 0);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Size = new Size(782, 57);
            flowLayoutPanel22.TabIndex = 1;
            // 
            // editButtonAuthorPanel
            // 
            editButtonAuthorPanel.Anchor = AnchorStyles.Right;
            editButtonAuthorPanel.Location = new Point(656, 20);
            editButtonAuthorPanel.Margin = new Padding(20);
            editButtonAuthorPanel.Name = "editButtonAuthorPanel";
            editButtonAuthorPanel.Size = new Size(106, 31);
            editButtonAuthorPanel.TabIndex = 6;
            editButtonAuthorPanel.Text = "Edit";
            editButtonAuthorPanel.UseVisualStyleBackColor = true;
            editButtonAuthorPanel.Click += editButtonAuthorPanel_Click;
            // 
            // AuthorControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(authorPanel);
            Name = "AuthorControl";
            Size = new Size(864, 611);
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
            flowLayoutPanel22.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel22;
        private Button homeButtonAuthorPanel;
        private TextBox descriptionLabelAuthorPanel;
    }
}
