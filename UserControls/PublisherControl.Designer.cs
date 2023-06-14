namespace LibraryDisplay.UserControls
{
    partial class PublisherControl
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
            publisherPanel = new SplitContainer();
            splitContainer4 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            editButtonPublisherPanel = new Button();
            publisherLabelPublisherPanel = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label3 = new Label();
            emailLabelPublisherPanel = new TextBox();
            label4 = new Label();
            phoneLabelPublisherPanel = new TextBox();
            splitContainer5 = new SplitContainer();
            publisherBookFlow = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            homeButtonPublisherPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)publisherPanel).BeginInit();
            publisherPanel.Panel1.SuspendLayout();
            publisherPanel.Panel2.SuspendLayout();
            publisherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // publisherPanel
            // 
            publisherPanel.Location = new Point(21, 27);
            publisherPanel.Name = "publisherPanel";
            publisherPanel.Orientation = Orientation.Horizontal;
            // 
            // publisherPanel.Panel1
            // 
            publisherPanel.Panel1.Controls.Add(splitContainer4);
            // 
            // publisherPanel.Panel2
            // 
            publisherPanel.Panel2.Controls.Add(splitContainer5);
            publisherPanel.Size = new Size(846, 696);
            publisherPanel.SplitterDistance = 132;
            publisherPanel.TabIndex = 2;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(tableLayoutPanel2);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.AutoScroll = true;
            splitContainer4.Panel2.Controls.Add(flowLayoutPanel6);
            splitContainer4.Panel2.Margin = new Padding(20);
            splitContainer4.Size = new Size(846, 132);
            splitContainer4.SplitterDistance = 81;
            splitContainer4.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.Controls.Add(editButtonPublisherPanel, 2, 0);
            tableLayoutPanel2.Controls.Add(publisherLabelPublisherPanel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(846, 81);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // editButtonPublisherPanel
            // 
            editButtonPublisherPanel.Anchor = AnchorStyles.Right;
            editButtonPublisherPanel.Location = new Point(737, 23);
            editButtonPublisherPanel.Name = "editButtonPublisherPanel";
            editButtonPublisherPanel.Size = new Size(106, 34);
            editButtonPublisherPanel.TabIndex = 6;
            editButtonPublisherPanel.Text = "Edit";
            editButtonPublisherPanel.UseVisualStyleBackColor = true;
            editButtonPublisherPanel.Click += editButtonPublisherPanel_Click;
            // 
            // publisherLabelPublisherPanel
            // 
            publisherLabelPublisherPanel.Dock = DockStyle.Fill;
            publisherLabelPublisherPanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            publisherLabelPublisherPanel.Location = new Point(115, 0);
            publisherLabelPublisherPanel.Name = "publisherLabelPublisherPanel";
            publisherLabelPublisherPanel.Size = new Size(616, 81);
            publisherLabelPublisherPanel.TabIndex = 4;
            publisherLabelPublisherPanel.Text = "Publisher Name";
            publisherLabelPublisherPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label3);
            flowLayoutPanel6.Controls.Add(emailLabelPublisherPanel);
            flowLayoutPanel6.Controls.Add(label4);
            flowLayoutPanel6.Controls.Add(phoneLabelPublisherPanel);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(0, 0);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(846, 47);
            flowLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 37);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabelPublisherPanel
            // 
            emailLabelPublisherPanel.Location = new Point(67, 3);
            emailLabelPublisherPanel.Name = "emailLabelPublisherPanel";
            emailLabelPublisherPanel.ReadOnly = true;
            emailLabelPublisherPanel.Size = new Size(223, 31);
            emailLabelPublisherPanel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(296, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 3;
            label4.Text = "PhoneNo:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneLabelPublisherPanel
            // 
            phoneLabelPublisherPanel.Location = new Point(392, 3);
            phoneLabelPublisherPanel.Name = "phoneLabelPublisherPanel";
            phoneLabelPublisherPanel.ReadOnly = true;
            phoneLabelPublisherPanel.Size = new Size(223, 31);
            phoneLabelPublisherPanel.TabIndex = 9;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(publisherBookFlow);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer5.Size = new Size(846, 560);
            splitContainer5.SplitterDistance = 466;
            splitContainer5.TabIndex = 0;
            // 
            // publisherBookFlow
            // 
            publisherBookFlow.AutoScroll = true;
            publisherBookFlow.Dock = DockStyle.Fill;
            publisherBookFlow.Location = new Point(0, 0);
            publisherBookFlow.Name = "publisherBookFlow";
            publisherBookFlow.Size = new Size(846, 466);
            publisherBookFlow.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button5, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 0);
            tableLayoutPanel1.Controls.Add(homeButtonPublisherPanel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(846, 90);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(43, 27);
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
            button4.Location = new Point(3, 27);
            button4.Margin = new Padding(3, 3, 3, 30);
            button4.Name = "button4";
            button4.Size = new Size(34, 33);
            button4.TabIndex = 1;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // homeButtonPublisherPanel
            // 
            homeButtonPublisherPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButtonPublisherPanel.Location = new Point(737, 26);
            homeButtonPublisherPanel.Margin = new Padding(3, 3, 3, 30);
            homeButtonPublisherPanel.Name = "homeButtonPublisherPanel";
            homeButtonPublisherPanel.Size = new Size(106, 34);
            homeButtonPublisherPanel.TabIndex = 8;
            homeButtonPublisherPanel.Text = "Home";
            homeButtonPublisherPanel.UseVisualStyleBackColor = true;
            homeButtonPublisherPanel.Click += homeButtonPublisherPanel_Click;
            // 
            // PublisherControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(publisherPanel);
            Name = "PublisherControl";
            Size = new Size(914, 797);
            publisherPanel.Panel1.ResumeLayout(false);
            publisherPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)publisherPanel).EndInit();
            publisherPanel.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer publisherPanel;
        private SplitContainer splitContainer4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button editButtonPublisherPanel;
        private Label publisherLabelPublisherPanel;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label3;
        private TextBox emailLabelPublisherPanel;
        private Label label4;
        private TextBox phoneLabelPublisherPanel;
        private SplitContainer splitContainer5;
        private FlowLayoutPanel publisherBookFlow;
        private Button homeButtonPublisherPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button button4;
    }
}
