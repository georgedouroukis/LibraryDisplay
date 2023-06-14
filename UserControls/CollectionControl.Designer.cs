namespace LibraryDisplay.UserControls
{
    partial class CollectionControl
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
            collectionPanel = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            splitContainer7 = new SplitContainer();
            collectionBookFlow = new FlowLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            homeButtonAuthorPanel = new Button();
            authorLabelAuthorPanel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)collectionPanel).BeginInit();
            collectionPanel.Panel1.SuspendLayout();
            collectionPanel.Panel2.SuspendLayout();
            collectionPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // collectionPanel
            // 
            collectionPanel.Location = new Point(50, 43);
            collectionPanel.Name = "collectionPanel";
            collectionPanel.Orientation = Orientation.Horizontal;
            // 
            // collectionPanel.Panel1
            // 
            collectionPanel.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // collectionPanel.Panel2
            // 
            collectionPanel.Panel2.Controls.Add(splitContainer7);
            collectionPanel.Size = new Size(859, 697);
            collectionPanel.SplitterDistance = 62;
            collectionPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(859, 62);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 0);
            label1.Name = "label1";
            label1.Size = new Size(629, 62);
            label1.TabIndex = 4;
            label1.Text = "My Collection";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(collectionBookFlow);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer7.Size = new Size(859, 631);
            splitContainer7.SplitterDistance = 546;
            splitContainer7.TabIndex = 1;
            // 
            // collectionBookFlow
            // 
            collectionBookFlow.AutoScroll = true;
            collectionBookFlow.Dock = DockStyle.Fill;
            collectionBookFlow.Location = new Point(0, 0);
            collectionBookFlow.Name = "collectionBookFlow";
            collectionBookFlow.Size = new Size(859, 546);
            collectionBookFlow.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.Controls.Add(homeButtonAuthorPanel, 2, 0);
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.Size = new Size(200, 100);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // homeButtonAuthorPanel
            // 
            homeButtonAuthorPanel.Anchor = AnchorStyles.Right;
            homeButtonAuthorPanel.Location = new Point(91, 33);
            homeButtonAuthorPanel.Name = "homeButtonAuthorPanel";
            homeButtonAuthorPanel.Size = new Size(106, 34);
            homeButtonAuthorPanel.TabIndex = 8;
            homeButtonAuthorPanel.Text = "Home";
            homeButtonAuthorPanel.UseVisualStyleBackColor = true;
            // 
            // authorLabelAuthorPanel
            // 
            authorLabelAuthorPanel.Dock = DockStyle.Fill;
            authorLabelAuthorPanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            authorLabelAuthorPanel.Location = new Point(115, 0);
            authorLabelAuthorPanel.Name = "authorLabelAuthorPanel";
            authorLabelAuthorPanel.Size = new Size(629, 123);
            authorLabelAuthorPanel.TabIndex = 4;
            authorLabelAuthorPanel.Text = "Author";
            authorLabelAuthorPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(button5, 0, 0);
            tableLayoutPanel2.Controls.Add(button4, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(859, 81);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(43, 17);
            button5.Margin = new Padding(3, 3, 3, 30);
            button5.Name = "button5";
            button5.Size = new Size(34, 34);
            button5.TabIndex = 2;
            button5.Text = ">";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(3, 17);
            button4.Margin = new Padding(3, 3, 3, 30);
            button4.Name = "button4";
            button4.Size = new Size(34, 34);
            button4.TabIndex = 1;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(744, 17);
            button1.Margin = new Padding(3, 3, 3, 30);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // CollectionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(collectionPanel);
            Name = "CollectionControl";
            Size = new Size(968, 802);
            Load += CollectionControl_Load;
            collectionPanel.Panel1.ResumeLayout(false);
            collectionPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)collectionPanel).EndInit();
            collectionPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer collectionPanel;
        private SplitContainer splitContainer7;
        private FlowLayoutPanel collectionBookFlow;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel9;
        private Button homeButtonAuthorPanel;
        private Label authorLabelAuthorPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button5;
        private Button button4;
        private Button button1;
    }
}
