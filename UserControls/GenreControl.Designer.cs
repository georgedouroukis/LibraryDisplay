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
            genreLabelGenrePanel = new Label();
            editButtonGenrePanel = new Button();
            flowLayoutPanel17 = new FlowLayoutPanel();
            splitContainer14 = new SplitContainer();
            genreBookFlow = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            homeButtonGenrePanel = new Button();
            button5 = new Button();
            button4 = new Button();
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
            genrePanel.SplitterDistance = 104;
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
            splitContainer13.Size = new Size(1069, 104);
            splitContainer13.SplitterDistance = 75;
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
            tableLayoutPanel9.Size = new Size(1069, 75);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // genreLabelGenrePanel
            // 
            genreLabelGenrePanel.Dock = DockStyle.Fill;
            genreLabelGenrePanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            genreLabelGenrePanel.Location = new Point(115, 0);
            genreLabelGenrePanel.Name = "genreLabelGenrePanel";
            genreLabelGenrePanel.Size = new Size(839, 75);
            genreLabelGenrePanel.TabIndex = 4;
            genreLabelGenrePanel.Text = "Genre";
            genreLabelGenrePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editButtonGenrePanel
            // 
            editButtonGenrePanel.Anchor = AnchorStyles.Right;
            editButtonGenrePanel.Location = new Point(960, 20);
            editButtonGenrePanel.Name = "editButtonGenrePanel";
            editButtonGenrePanel.Size = new Size(106, 34);
            editButtonGenrePanel.TabIndex = 7;
            editButtonGenrePanel.Text = "Edit";
            editButtonGenrePanel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.Dock = DockStyle.Fill;
            flowLayoutPanel17.Location = new Point(0, 0);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new Size(1069, 25);
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
            splitContainer14.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer14.Size = new Size(1069, 754);
            splitContainer14.SplitterDistance = 669;
            splitContainer14.TabIndex = 0;
            // 
            // genreBookFlow
            // 
            genreBookFlow.AutoScroll = true;
            genreBookFlow.Dock = DockStyle.Fill;
            genreBookFlow.Location = new Point(0, 0);
            genreBookFlow.Name = "genreBookFlow";
            genreBookFlow.Size = new Size(1069, 669);
            genreBookFlow.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(homeButtonGenrePanel, 0, 0);
            tableLayoutPanel2.Controls.Add(button5, 0, 0);
            tableLayoutPanel2.Controls.Add(button4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1069, 81);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // homeButtonGenrePanel
            // 
            homeButtonGenrePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButtonGenrePanel.Location = new Point(960, 20);
            homeButtonGenrePanel.Margin = new Padding(3, 3, 3, 30);
            homeButtonGenrePanel.Name = "homeButtonGenrePanel";
            homeButtonGenrePanel.Size = new Size(106, 31);
            homeButtonGenrePanel.TabIndex = 9;
            homeButtonGenrePanel.Text = "Home";
            homeButtonGenrePanel.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(43, 18);
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
            button4.Location = new Point(3, 18);
            button4.Margin = new Padding(3, 3, 3, 30);
            button4.Name = "button4";
            button4.Size = new Size(34, 33);
            button4.TabIndex = 1;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
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
        private FlowLayoutPanel flowLayoutPanel17;
        private SplitContainer splitContainer14;
        private FlowLayoutPanel genreBookFlow;
        private Button editButtonGenrePanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button homeButtonGenrePanel;
        private Button button5;
        private Button button4;
    }
}
