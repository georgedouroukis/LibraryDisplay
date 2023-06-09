﻿namespace LibraryDisplay.UserControls
{
    partial class GenreControl
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
            genrePanel = new SplitContainer();
            splitContainer13 = new SplitContainer();
            tableLayoutPanel9 = new TableLayoutPanel();
            genreLabelGenrePanel = new Label();
            editButtonGenrePanel = new Button();
            genrePathFlowGenrePanel = new FlowLayoutPanel();
            splitContainer14 = new SplitContainer();
            genreBookFlow = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            homeButtonGenrePanel = new Button();
            forwardButtonGenrePanel = new Button();
            backButtonGenrePanel = new Button();
            ((System.ComponentModel.ISupportInitialize)genrePanel).BeginInit();
            genrePanel.Panel1.SuspendLayout();
            genrePanel.Panel2.SuspendLayout();
            genrePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer13).BeginInit();
            splitContainer13.Panel1.SuspendLayout();
            splitContainer13.Panel2.SuspendLayout();
            splitContainer13.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer14).BeginInit();
            splitContainer14.Panel1.SuspendLayout();
            splitContainer14.Panel2.SuspendLayout();
            splitContainer14.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // genrePanel
            // 
            genrePanel.Location = new Point(52, 43);
            genrePanel.Name = "genrePanel";
            genrePanel.Orientation = Orientation.Horizontal;
            // 
            // genrePanel.Panel1
            // 
            genrePanel.Panel1.Controls.Add(splitContainer13);
            // 
            // genrePanel.Panel2
            // 
            genrePanel.Panel2.Controls.Add(splitContainer14);
            genrePanel.Size = new Size(1069, 862);
            genrePanel.SplitterDistance = 134;
            genrePanel.TabIndex = 7;
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
            splitContainer13.Panel2.Controls.Add(genrePathFlowGenrePanel);
            splitContainer13.Panel2.Margin = new Padding(20);
            splitContainer13.Size = new Size(1069, 134);
            splitContainer13.SplitterDistance = 88;
            splitContainer13.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.Controls.Add(genreLabelGenrePanel, 1, 0);
            tableLayoutPanel9.Controls.Add(editButtonGenrePanel, 2, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(1069, 88);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // genreLabelGenrePanel
            // 
            genreLabelGenrePanel.Dock = DockStyle.Fill;
            genreLabelGenrePanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            genreLabelGenrePanel.Location = new Point(115, 0);
            genreLabelGenrePanel.Name = "genreLabelGenrePanel";
            genreLabelGenrePanel.Size = new Size(839, 88);
            genreLabelGenrePanel.TabIndex = 4;
            genreLabelGenrePanel.Text = "Genre";
            genreLabelGenrePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editButtonGenrePanel
            // 
            editButtonGenrePanel.Anchor = AnchorStyles.Right;
            editButtonGenrePanel.Location = new Point(960, 27);
            editButtonGenrePanel.Name = "editButtonGenrePanel";
            editButtonGenrePanel.Size = new Size(106, 33);
            editButtonGenrePanel.TabIndex = 7;
            editButtonGenrePanel.Text = "Edit";
            editButtonGenrePanel.UseVisualStyleBackColor = true;
            editButtonGenrePanel.Click += editButtonGenrePanel_Click;
            // 
            // genrePathFlowGenrePanel
            // 
            genrePathFlowGenrePanel.Dock = DockStyle.Fill;
            genrePathFlowGenrePanel.Location = new Point(0, 0);
            genrePathFlowGenrePanel.Name = "genrePathFlowGenrePanel";
            genrePathFlowGenrePanel.Padding = new Padding(40, 0, 40, 0);
            genrePathFlowGenrePanel.Size = new Size(1069, 42);
            genrePathFlowGenrePanel.TabIndex = 0;
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
            splitContainer14.Panel1.Controls.Add(genreBookFlow);
            // 
            // splitContainer14.Panel2
            // 
            splitContainer14.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer14.Size = new Size(1069, 724);
            splitContainer14.SplitterDistance = 641;
            splitContainer14.TabIndex = 0;
            // 
            // genreBookFlow
            // 
            genreBookFlow.AutoScroll = true;
            genreBookFlow.Dock = DockStyle.Fill;
            genreBookFlow.Location = new Point(0, 0);
            genreBookFlow.Name = "genreBookFlow";
            genreBookFlow.Size = new Size(1069, 641);
            genreBookFlow.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(homeButtonGenrePanel, 0, 0);
            tableLayoutPanel2.Controls.Add(forwardButtonGenrePanel, 0, 0);
            tableLayoutPanel2.Controls.Add(backButtonGenrePanel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1069, 79);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // homeButtonGenrePanel
            // 
            homeButtonGenrePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButtonGenrePanel.Location = new Point(960, 18);
            homeButtonGenrePanel.Margin = new Padding(3, 3, 3, 30);
            homeButtonGenrePanel.Name = "homeButtonGenrePanel";
            homeButtonGenrePanel.Size = new Size(106, 31);
            homeButtonGenrePanel.TabIndex = 9;
            homeButtonGenrePanel.Text = "Home";
            homeButtonGenrePanel.UseVisualStyleBackColor = true;
            homeButtonGenrePanel.Click += homeButtonGenrePanel_Click;
            // 
            // forwardButtonGenrePanel
            // 
            forwardButtonGenrePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            forwardButtonGenrePanel.Location = new Point(43, 16);
            forwardButtonGenrePanel.Margin = new Padding(3, 3, 3, 30);
            forwardButtonGenrePanel.Name = "forwardButtonGenrePanel";
            forwardButtonGenrePanel.Size = new Size(34, 33);
            forwardButtonGenrePanel.TabIndex = 2;
            forwardButtonGenrePanel.Text = ">";
            forwardButtonGenrePanel.UseVisualStyleBackColor = true;
            // 
            // backButtonGenrePanel
            // 
            backButtonGenrePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButtonGenrePanel.Location = new Point(3, 16);
            backButtonGenrePanel.Margin = new Padding(3, 3, 3, 30);
            backButtonGenrePanel.Name = "backButtonGenrePanel";
            backButtonGenrePanel.Size = new Size(34, 33);
            backButtonGenrePanel.TabIndex = 1;
            backButtonGenrePanel.Text = "<";
            backButtonGenrePanel.UseVisualStyleBackColor = true;
            // 
            // GenreControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(genrePanel);
            Name = "GenreControl";
            Size = new Size(1156, 935);
            Load += GenreControl_Load;
            genrePanel.Panel1.ResumeLayout(false);
            genrePanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)genrePanel).EndInit();
            genrePanel.ResumeLayout(false);
            splitContainer13.Panel1.ResumeLayout(false);
            splitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer13).EndInit();
            splitContainer13.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            splitContainer14.Panel1.ResumeLayout(false);
            splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer14).EndInit();
            splitContainer14.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer genrePanel;
        private SplitContainer splitContainer13;
        private TableLayoutPanel tableLayoutPanel9;
        private Label genreLabelGenrePanel;
        private SplitContainer splitContainer14;
        private FlowLayoutPanel genreBookFlow;
        private Button editButtonGenrePanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button homeButtonGenrePanel;
        private Button forwardButtonGenrePanel;
        private Button backButtonGenrePanel;
        private FlowLayoutPanel genrePathFlowGenrePanel;
    }
}
