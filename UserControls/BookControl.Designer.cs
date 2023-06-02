namespace LibraryDisplay.UserControls
{
    partial class BookControl
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
            bookPanel = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            editButtonBookPanel = new Button();
            bookLabelBookPanel = new Label();
            flowLayoutPanel13 = new FlowLayoutPanel();
            homeButtonBookPanel = new Button();
            panel1 = new Panel();
            descriptionLabelBookPanel = new TextBox();
            splitContainer1 = new SplitContainer();
            pictureBoxBookPanel = new PictureBox();
            flowLayoutPanel15 = new FlowLayoutPanel();
            authorFlowBookPanel = new FlowLayoutPanel();
            label7 = new Label();
            publisherFlowBookPanel = new FlowLayoutPanel();
            label11 = new Label();
            flowLayoutPanel19 = new FlowLayoutPanel();
            label14 = new Label();
            pagesLabelBookPanel = new TextBox();
            flowLayoutPanel20 = new FlowLayoutPanel();
            label15 = new Label();
            publicationDateLabelBookPanel = new TextBox();
            flowLayoutPanel21 = new FlowLayoutPanel();
            label16 = new Label();
            isbnLabelBookPanel = new TextBox();
            genreFlowBookPanel = new FlowLayoutPanel();
            label17 = new Label();
            bookPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel13.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBookPanel).BeginInit();
            flowLayoutPanel15.SuspendLayout();
            authorFlowBookPanel.SuspendLayout();
            publisherFlowBookPanel.SuspendLayout();
            flowLayoutPanel19.SuspendLayout();
            flowLayoutPanel20.SuspendLayout();
            flowLayoutPanel21.SuspendLayout();
            genreFlowBookPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bookPanel
            // 
            bookPanel.ColumnCount = 1;
            bookPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bookPanel.Controls.Add(tableLayoutPanel3, 0, 0);
            bookPanel.Controls.Add(flowLayoutPanel13, 0, 3);
            bookPanel.Controls.Add(panel1, 0, 2);
            bookPanel.Controls.Add(splitContainer1, 0, 1);
            bookPanel.Location = new Point(41, 55);
            bookPanel.Name = "bookPanel";
            bookPanel.RowCount = 4;
            bookPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            bookPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.7373047F));
            bookPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0437832F));
            bookPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            bookPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bookPanel.Size = new Size(658, 599);
            bookPanel.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.Controls.Add(editButtonBookPanel, 2, 0);
            tableLayoutPanel3.Controls.Add(bookLabelBookPanel, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(652, 84);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // editButtonBookPanel
            // 
            editButtonBookPanel.Anchor = AnchorStyles.None;
            editButtonBookPanel.Location = new Point(543, 25);
            editButtonBookPanel.Name = "editButtonBookPanel";
            editButtonBookPanel.Size = new Size(106, 34);
            editButtonBookPanel.TabIndex = 4;
            editButtonBookPanel.Text = "Edit";
            editButtonBookPanel.UseVisualStyleBackColor = true;
            editButtonBookPanel.Click += editButtonBookPanel_Click;
            // 
            // bookLabelBookPanel
            // 
            bookLabelBookPanel.Dock = DockStyle.Fill;
            bookLabelBookPanel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bookLabelBookPanel.Location = new Point(115, 0);
            bookLabelBookPanel.Name = "bookLabelBookPanel";
            bookLabelBookPanel.Size = new Size(422, 84);
            bookLabelBookPanel.TabIndex = 6;
            bookLabelBookPanel.Text = "Book Title";
            bookLabelBookPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Controls.Add(homeButtonBookPanel);
            flowLayoutPanel13.Dock = DockStyle.Fill;
            flowLayoutPanel13.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel13.Location = new Point(3, 541);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(652, 55);
            flowLayoutPanel13.TabIndex = 0;
            // 
            // homeButtonBookPanel
            // 
            homeButtonBookPanel.Location = new Point(537, 3);
            homeButtonBookPanel.Name = "homeButtonBookPanel";
            homeButtonBookPanel.Size = new Size(112, 34);
            homeButtonBookPanel.TabIndex = 0;
            homeButtonBookPanel.Text = "Home";
            homeButtonBookPanel.UseVisualStyleBackColor = true;
            homeButtonBookPanel.Click += homeButtonBookPanel_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(descriptionLabelBookPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 144);
            panel1.TabIndex = 2;
            // 
            // descriptionLabelBookPanel
            // 
            descriptionLabelBookPanel.Dock = DockStyle.Fill;
            descriptionLabelBookPanel.Location = new Point(0, 0);
            descriptionLabelBookPanel.Multiline = true;
            descriptionLabelBookPanel.Name = "descriptionLabelBookPanel";
            descriptionLabelBookPanel.ReadOnly = true;
            descriptionLabelBookPanel.ScrollBars = ScrollBars.Vertical;
            descriptionLabelBookPanel.Size = new Size(652, 144);
            descriptionLabelBookPanel.TabIndex = 3;
            descriptionLabelBookPanel.Text = "Description";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 93);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBoxBookPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel15);
            splitContainer1.Size = new Size(652, 292);
            splitContainer1.SplitterDistance = 255;
            splitContainer1.TabIndex = 3;
            // 
            // pictureBoxBookPanel
            // 
            pictureBoxBookPanel.Dock = DockStyle.Fill;
            pictureBoxBookPanel.Location = new Point(0, 0);
            pictureBoxBookPanel.Name = "pictureBoxBookPanel";
            pictureBoxBookPanel.Size = new Size(255, 292);
            pictureBoxBookPanel.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBookPanel.TabIndex = 0;
            pictureBoxBookPanel.TabStop = false;
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.Controls.Add(authorFlowBookPanel);
            flowLayoutPanel15.Controls.Add(publisherFlowBookPanel);
            flowLayoutPanel15.Controls.Add(flowLayoutPanel19);
            flowLayoutPanel15.Controls.Add(flowLayoutPanel20);
            flowLayoutPanel15.Controls.Add(flowLayoutPanel21);
            flowLayoutPanel15.Controls.Add(genreFlowBookPanel);
            flowLayoutPanel15.Dock = DockStyle.Fill;
            flowLayoutPanel15.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel15.Location = new Point(0, 0);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(393, 292);
            flowLayoutPanel15.TabIndex = 0;
            // 
            // authorFlowBookPanel
            // 
            authorFlowBookPanel.AutoSize = true;
            authorFlowBookPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            authorFlowBookPanel.Controls.Add(label7);
            authorFlowBookPanel.Location = new Point(3, 3);
            authorFlowBookPanel.Name = "authorFlowBookPanel";
            authorFlowBookPanel.Size = new Size(77, 25);
            authorFlowBookPanel.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 6;
            label7.Text = "Author:";
            // 
            // publisherFlowBookPanel
            // 
            publisherFlowBookPanel.AutoSize = true;
            publisherFlowBookPanel.Controls.Add(label11);
            publisherFlowBookPanel.Location = new Point(3, 34);
            publisherFlowBookPanel.Name = "publisherFlowBookPanel";
            publisherFlowBookPanel.Size = new Size(94, 25);
            publisherFlowBookPanel.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 6;
            label11.Text = "Publisher:";
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.AutoSize = true;
            flowLayoutPanel19.Controls.Add(label14);
            flowLayoutPanel19.Controls.Add(pagesLabelBookPanel);
            flowLayoutPanel19.Location = new Point(3, 65);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new Size(362, 37);
            flowLayoutPanel19.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(62, 25);
            label14.TabIndex = 6;
            label14.Text = "Pages:";
            // 
            // pagesLabelBookPanel
            // 
            pagesLabelBookPanel.Location = new Point(71, 3);
            pagesLabelBookPanel.Name = "pagesLabelBookPanel";
            pagesLabelBookPanel.ReadOnly = true;
            pagesLabelBookPanel.Size = new Size(288, 31);
            pagesLabelBookPanel.TabIndex = 7;
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.AutoSize = true;
            flowLayoutPanel20.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel20.Controls.Add(label15);
            flowLayoutPanel20.Controls.Add(publicationDateLabelBookPanel);
            flowLayoutPanel20.Location = new Point(3, 108);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(362, 37);
            flowLayoutPanel20.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(145, 25);
            label15.TabIndex = 6;
            label15.Text = "Publication Date:";
            // 
            // publicationDateLabelBookPanel
            // 
            publicationDateLabelBookPanel.Location = new Point(154, 3);
            publicationDateLabelBookPanel.Name = "publicationDateLabelBookPanel";
            publicationDateLabelBookPanel.ReadOnly = true;
            publicationDateLabelBookPanel.Size = new Size(205, 31);
            publicationDateLabelBookPanel.TabIndex = 7;
            // 
            // flowLayoutPanel21
            // 
            flowLayoutPanel21.AutoSize = true;
            flowLayoutPanel21.Controls.Add(label16);
            flowLayoutPanel21.Controls.Add(isbnLabelBookPanel);
            flowLayoutPanel21.Location = new Point(3, 151);
            flowLayoutPanel21.Name = "flowLayoutPanel21";
            flowLayoutPanel21.Size = new Size(362, 37);
            flowLayoutPanel21.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 25);
            label16.TabIndex = 6;
            label16.Text = "ISBN:";
            // 
            // isbnLabelBookPanel
            // 
            isbnLabelBookPanel.Location = new Point(63, 3);
            isbnLabelBookPanel.Name = "isbnLabelBookPanel";
            isbnLabelBookPanel.ReadOnly = true;
            isbnLabelBookPanel.Size = new Size(296, 31);
            isbnLabelBookPanel.TabIndex = 7;
            // 
            // genreFlowBookPanel
            // 
            genreFlowBookPanel.AutoSize = true;
            genreFlowBookPanel.Controls.Add(label17);
            genreFlowBookPanel.Location = new Point(3, 194);
            genreFlowBookPanel.Name = "genreFlowBookPanel";
            genreFlowBookPanel.Size = new Size(68, 25);
            genreFlowBookPanel.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(62, 25);
            label17.TabIndex = 6;
            label17.Text = "Genre:";
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bookPanel);
            Name = "BookControl";
            Size = new Size(779, 720);
            bookPanel.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel13.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBookPanel).EndInit();
            flowLayoutPanel15.ResumeLayout(false);
            flowLayoutPanel15.PerformLayout();
            authorFlowBookPanel.ResumeLayout(false);
            authorFlowBookPanel.PerformLayout();
            publisherFlowBookPanel.ResumeLayout(false);
            publisherFlowBookPanel.PerformLayout();
            flowLayoutPanel19.ResumeLayout(false);
            flowLayoutPanel19.PerformLayout();
            flowLayoutPanel20.ResumeLayout(false);
            flowLayoutPanel20.PerformLayout();
            flowLayoutPanel21.ResumeLayout(false);
            flowLayoutPanel21.PerformLayout();
            genreFlowBookPanel.ResumeLayout(false);
            genreFlowBookPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel bookPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button editButtonBookPanel;
        private Label bookLabelBookPanel;
        private FlowLayoutPanel flowLayoutPanel13;
        private Button homeButtonBookPanel;
        private Panel panel1;
        private TextBox descriptionLabelBookPanel;
        private SplitContainer splitContainer1;
        private PictureBox pictureBoxBookPanel;
        private FlowLayoutPanel flowLayoutPanel15;
        private FlowLayoutPanel authorFlowBookPanel;
        private Label label7;
        private FlowLayoutPanel publisherFlowBookPanel;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel19;
        private Label label14;
        private TextBox pagesLabelBookPanel;
        private FlowLayoutPanel flowLayoutPanel20;
        private Label label15;
        private TextBox publicationDateLabelBookPanel;
        private FlowLayoutPanel flowLayoutPanel21;
        private Label label16;
        private TextBox isbnLabelBookPanel;
        private FlowLayoutPanel genreFlowBookPanel;
        private Label label17;
    }
}
