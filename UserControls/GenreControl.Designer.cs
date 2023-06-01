namespace LibraryDisplay.UserControls
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
            editButtonGenrePanel = new Button();
            genreLabelGenrePanel = new Label();
            idGenrePanel = new Label();
            flowLayoutPanel17 = new FlowLayoutPanel();
            splitContainer14 = new SplitContainer();
            genreBookFlow = new FlowLayoutPanel();
            flowLayoutPanel22 = new FlowLayoutPanel();
            homeButtonGenrePanel = new Button();
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
            flowLayoutPanel22.SuspendLayout();
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
            genrePanel.Size = new Size(745, 469);
            genrePanel.SplitterDistance = 78;
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
            splitContainer13.Panel2.Controls.Add(flowLayoutPanel17);
            splitContainer13.Panel2.Margin = new Padding(20);
            splitContainer13.Size = new Size(745, 78);
            splitContainer13.SplitterDistance = 37;
            splitContainer13.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel9.Controls.Add(editButtonGenrePanel, 2, 0);
            tableLayoutPanel9.Controls.Add(genreLabelGenrePanel, 1, 0);
            tableLayoutPanel9.Controls.Add(idGenrePanel, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(745, 37);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // editButtonGenrePanel
            // 
            editButtonGenrePanel.Anchor = AnchorStyles.Right;
            editButtonGenrePanel.Location = new Point(636, 3);
            editButtonGenrePanel.Name = "editButtonGenrePanel";
            editButtonGenrePanel.Size = new Size(106, 31);
            editButtonGenrePanel.TabIndex = 6;
            editButtonGenrePanel.Text = "Edit";
            editButtonGenrePanel.UseVisualStyleBackColor = true;
            // 
            // genreLabelGenrePanel
            // 
            genreLabelGenrePanel.Dock = DockStyle.Fill;
            genreLabelGenrePanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            genreLabelGenrePanel.Location = new Point(115, 0);
            genreLabelGenrePanel.Name = "genreLabelGenrePanel";
            genreLabelGenrePanel.Size = new Size(515, 37);
            genreLabelGenrePanel.TabIndex = 4;
            genreLabelGenrePanel.Text = "Genre";
            genreLabelGenrePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idGenrePanel
            // 
            idGenrePanel.AutoSize = true;
            idGenrePanel.Location = new Point(3, 0);
            idGenrePanel.Name = "idGenrePanel";
            idGenrePanel.Size = new Size(0, 25);
            idGenrePanel.TabIndex = 7;
            idGenrePanel.Visible = false;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.Dock = DockStyle.Fill;
            flowLayoutPanel17.Location = new Point(0, 0);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new Size(745, 37);
            flowLayoutPanel17.TabIndex = 0;
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
            splitContainer14.Panel2.Controls.Add(flowLayoutPanel22);
            splitContainer14.Size = new Size(745, 387);
            splitContainer14.SplitterDistance = 322;
            splitContainer14.TabIndex = 0;
            // 
            // genreBookFlow
            // 
            genreBookFlow.AutoScroll = true;
            genreBookFlow.Dock = DockStyle.Fill;
            genreBookFlow.Location = new Point(0, 0);
            genreBookFlow.Name = "genreBookFlow";
            genreBookFlow.Size = new Size(745, 322);
            genreBookFlow.TabIndex = 1;
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.Controls.Add(homeButtonGenrePanel);
            flowLayoutPanel22.Dock = DockStyle.Fill;
            flowLayoutPanel22.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel22.Location = new Point(0, 0);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Size = new Size(745, 61);
            flowLayoutPanel22.TabIndex = 1;
            // 
            // homeButtonGenrePanel
            // 
            homeButtonGenrePanel.Anchor = AnchorStyles.Right;
            homeButtonGenrePanel.Location = new Point(630, 3);
            homeButtonGenrePanel.Name = "homeButtonGenrePanel";
            homeButtonGenrePanel.Size = new Size(112, 34);
            homeButtonGenrePanel.TabIndex = 8;
            homeButtonGenrePanel.Text = "Home";
            homeButtonGenrePanel.UseVisualStyleBackColor = true;
            homeButtonGenrePanel.Click += homeButtonGenrePanel_Click;
            // 
            // GenreControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(genrePanel);
            Name = "GenreControl";
            Size = new Size(844, 565);
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
            tableLayoutPanel9.PerformLayout();
            splitContainer14.Panel1.ResumeLayout(false);
            splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer14).EndInit();
            splitContainer14.ResumeLayout(false);
            flowLayoutPanel22.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer genrePanel;
        private SplitContainer splitContainer13;
        private TableLayoutPanel tableLayoutPanel9;
        private Button editButtonGenrePanel;
        private Label genreLabelGenrePanel;
        private Label idGenrePanel;
        private FlowLayoutPanel flowLayoutPanel17;
        private SplitContainer splitContainer14;
        private FlowLayoutPanel genreBookFlow;
        private FlowLayoutPanel flowLayoutPanel22;
        private Button homeButtonGenrePanel;
    }
}
