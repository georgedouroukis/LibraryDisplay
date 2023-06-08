namespace LibraryDisplay.UserControls
{
    abstract partial class AbstractEditCreate
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
            editPanel = new SplitContainer();
            tableLayoutPanel7 = new TableLayoutPanel();
            saveButtonEditPanel = new Button();
            pageTitle = new Label();
            splitContainer10 = new SplitContainer();
            editTabs = new TabControl();
            bookEditTab = new TabPage();
            flowLayoutPanel42 = new FlowLayoutPanel();
            flowLayoutPanel43 = new FlowLayoutPanel();
            label26 = new Label();
            titleTextBoxEditBookPanel = new TextBox();
            flowLayoutPanel44 = new FlowLayoutPanel();
            label27 = new Label();
            authorComboBoxEditBookPanel = new ComboBox();
            authorFlowBookEditPanel = new FlowLayoutPanel();
            flowLayoutPanel46 = new FlowLayoutPanel();
            label28 = new Label();
            publisherComboBoxEditBookPanel = new ComboBox();
            flowLayoutPanel47 = new FlowLayoutPanel();
            label29 = new Label();
            pagesTextBoxEditBookPanel = new TextBox();
            flowLayoutPanel48 = new FlowLayoutPanel();
            label30 = new Label();
            dateTextBoxEditBookPanel = new TextBox();
            flowLayoutPanel49 = new FlowLayoutPanel();
            label31 = new Label();
            isbnTextBoxEditBookPanel = new TextBox();
            flowLayoutPanel50 = new FlowLayoutPanel();
            label32 = new Label();
            genreComboBoxEditBookPanel = new ComboBox();
            genreFlowBookEditPanel = new FlowLayoutPanel();
            descriptionTextBoxEditBookPanel = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            imageURLTextBoxEditBookPanel = new TextBox();
            imageCheckButonEditBookPanel = new Button();
            authorEditTab = new TabPage();
            flowLayoutPanel53 = new FlowLayoutPanel();
            flowLayoutPanel54 = new FlowLayoutPanel();
            label34 = new Label();
            firstNameTextBoxEditAuthorPanel = new TextBox();
            flowLayoutPanel55 = new FlowLayoutPanel();
            label35 = new Label();
            lastNameTextBoxEditAuthorPanel = new TextBox();
            flowLayoutPanel56 = new FlowLayoutPanel();
            label36 = new Label();
            middleNameTextBoxEditAuthorPanel = new TextBox();
            descriptionTextBoxEditAuthorPanel = new TextBox();
            publisherEditTab = new TabPage();
            flowLayoutPanel57 = new FlowLayoutPanel();
            flowLayoutPanel58 = new FlowLayoutPanel();
            label37 = new Label();
            nameTextBoxEditPublisherPanel = new TextBox();
            flowLayoutPanel59 = new FlowLayoutPanel();
            label38 = new Label();
            emailTextBoxEditPublisherPanel = new TextBox();
            flowLayoutPanel60 = new FlowLayoutPanel();
            label39 = new Label();
            phoneTextBoxEditPublisherPanel = new TextBox();
            genreEditTab = new TabPage();
            flowLayoutPanel61 = new FlowLayoutPanel();
            flowLayoutPanel67 = new FlowLayoutPanel();
            label43 = new Label();
            genreTextBoxEditGenrePanel = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            parentGenreComboBoxEditGenrePanel = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            subComboBoxEditGenrePanel = new ComboBox();
            subFlowEditGenrePanel = new FlowLayoutPanel();
            flowLayoutPanel62 = new FlowLayoutPanel();
            homeButtonEditPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)editPanel).BeginInit();
            editPanel.Panel1.SuspendLayout();
            editPanel.Panel2.SuspendLayout();
            editPanel.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).BeginInit();
            splitContainer10.Panel1.SuspendLayout();
            splitContainer10.Panel2.SuspendLayout();
            splitContainer10.SuspendLayout();
            editTabs.SuspendLayout();
            bookEditTab.SuspendLayout();
            flowLayoutPanel42.SuspendLayout();
            flowLayoutPanel43.SuspendLayout();
            flowLayoutPanel44.SuspendLayout();
            flowLayoutPanel46.SuspendLayout();
            flowLayoutPanel47.SuspendLayout();
            flowLayoutPanel48.SuspendLayout();
            flowLayoutPanel49.SuspendLayout();
            flowLayoutPanel50.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            authorEditTab.SuspendLayout();
            flowLayoutPanel53.SuspendLayout();
            flowLayoutPanel54.SuspendLayout();
            flowLayoutPanel55.SuspendLayout();
            flowLayoutPanel56.SuspendLayout();
            publisherEditTab.SuspendLayout();
            flowLayoutPanel57.SuspendLayout();
            flowLayoutPanel58.SuspendLayout();
            flowLayoutPanel59.SuspendLayout();
            flowLayoutPanel60.SuspendLayout();
            genreEditTab.SuspendLayout();
            flowLayoutPanel61.SuspendLayout();
            flowLayoutPanel67.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel62.SuspendLayout();
            SuspendLayout();
            // 
            // editPanel
            // 
            editPanel.Location = new Point(41, 31);
            editPanel.Name = "editPanel";
            editPanel.Orientation = Orientation.Horizontal;
            // 
            // editPanel.Panel1
            // 
            editPanel.Panel1.Controls.Add(tableLayoutPanel7);
            // 
            // editPanel.Panel2
            // 
            editPanel.Panel2.Controls.Add(splitContainer10);
            editPanel.Size = new Size(1122, 1093);
            editPanel.SplitterDistance = 83;
            editPanel.TabIndex = 6;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel7.Controls.Add(pageTitle, 1, 0);
            tableLayoutPanel7.Controls.Add(homeButtonEditPanel, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1122, 83);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // saveButtonEditPanel
            // 
            saveButtonEditPanel.Anchor = AnchorStyles.None;
            saveButtonEditPanel.Location = new Point(1013, 3);
            saveButtonEditPanel.Name = "saveButtonEditPanel";
            saveButtonEditPanel.Size = new Size(106, 34);
            saveButtonEditPanel.TabIndex = 4;
            saveButtonEditPanel.Text = "Save";
            saveButtonEditPanel.UseVisualStyleBackColor = true;
            saveButtonEditPanel.Click += saveButtonEditPanel_Click;
            // 
            // pageTitle
            // 
            pageTitle.Dock = DockStyle.Fill;
            pageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pageTitle.Location = new Point(115, 0);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(892, 83);
            pageTitle.TabIndex = 6;
            pageTitle.Text = "Create/Edit";
            pageTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer10
            // 
            splitContainer10.Dock = DockStyle.Fill;
            splitContainer10.Location = new Point(0, 0);
            splitContainer10.Name = "splitContainer10";
            splitContainer10.Orientation = Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            splitContainer10.Panel1.Controls.Add(editTabs);
            // 
            // splitContainer10.Panel2
            // 
            splitContainer10.Panel2.Controls.Add(flowLayoutPanel62);
            splitContainer10.Size = new Size(1122, 1006);
            splitContainer10.SplitterDistance = 916;
            splitContainer10.TabIndex = 0;
            // 
            // editTabs
            // 
            editTabs.Controls.Add(bookEditTab);
            editTabs.Controls.Add(authorEditTab);
            editTabs.Controls.Add(publisherEditTab);
            editTabs.Controls.Add(genreEditTab);
            editTabs.Dock = DockStyle.Fill;
            editTabs.Location = new Point(0, 0);
            editTabs.Name = "editTabs";
            editTabs.SelectedIndex = 0;
            editTabs.Size = new Size(1122, 916);
            editTabs.TabIndex = 0;
            editTabs.Selecting += editTabs_Selecting;
            // 
            // bookEditTab
            // 
            bookEditTab.Controls.Add(flowLayoutPanel42);
            bookEditTab.Location = new Point(4, 34);
            bookEditTab.Name = "bookEditTab";
            bookEditTab.Padding = new Padding(3);
            bookEditTab.Size = new Size(1114, 878);
            bookEditTab.TabIndex = 0;
            bookEditTab.Text = "Book";
            bookEditTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel42
            // 
            flowLayoutPanel42.Controls.Add(flowLayoutPanel43);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel44);
            flowLayoutPanel42.Controls.Add(authorFlowBookEditPanel);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel46);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel47);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel48);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel49);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel50);
            flowLayoutPanel42.Controls.Add(genreFlowBookEditPanel);
            flowLayoutPanel42.Controls.Add(descriptionTextBoxEditBookPanel);
            flowLayoutPanel42.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel42.Dock = DockStyle.Fill;
            flowLayoutPanel42.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel42.Location = new Point(3, 3);
            flowLayoutPanel42.Name = "flowLayoutPanel42";
            flowLayoutPanel42.Padding = new Padding(20);
            flowLayoutPanel42.Size = new Size(1108, 872);
            flowLayoutPanel42.TabIndex = 0;
            // 
            // flowLayoutPanel43
            // 
            flowLayoutPanel43.AutoSize = true;
            flowLayoutPanel43.Controls.Add(label26);
            flowLayoutPanel43.Controls.Add(titleTextBoxEditBookPanel);
            flowLayoutPanel43.Location = new Point(23, 23);
            flowLayoutPanel43.Name = "flowLayoutPanel43";
            flowLayoutPanel43.Size = new Size(608, 37);
            flowLayoutPanel43.TabIndex = 13;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(3, 0);
            label26.Name = "label26";
            label26.Size = new Size(48, 25);
            label26.TabIndex = 6;
            label26.Text = "Title:";
            // 
            // titleTextBoxEditBookPanel
            // 
            titleTextBoxEditBookPanel.Location = new Point(57, 3);
            titleTextBoxEditBookPanel.Name = "titleTextBoxEditBookPanel";
            titleTextBoxEditBookPanel.Size = new Size(548, 31);
            titleTextBoxEditBookPanel.TabIndex = 7;
            // 
            // flowLayoutPanel44
            // 
            flowLayoutPanel44.AutoSize = true;
            flowLayoutPanel44.Controls.Add(label27);
            flowLayoutPanel44.Controls.Add(authorComboBoxEditBookPanel);
            flowLayoutPanel44.Location = new Point(20, 78);
            flowLayoutPanel44.Margin = new Padding(0, 15, 0, 0);
            flowLayoutPanel44.Name = "flowLayoutPanel44";
            flowLayoutPanel44.Size = new Size(608, 39);
            flowLayoutPanel44.TabIndex = 15;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(3, 0);
            label27.Name = "label27";
            label27.Size = new Size(71, 25);
            label27.TabIndex = 6;
            label27.Text = "Author:";
            // 
            // authorComboBoxEditBookPanel
            // 
            authorComboBoxEditBookPanel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            authorComboBoxEditBookPanel.AutoCompleteSource = AutoCompleteSource.ListItems;
            authorComboBoxEditBookPanel.FormattingEnabled = true;
            authorComboBoxEditBookPanel.Location = new Point(80, 3);
            authorComboBoxEditBookPanel.Name = "authorComboBoxEditBookPanel";
            authorComboBoxEditBookPanel.Size = new Size(525, 33);
            authorComboBoxEditBookPanel.TabIndex = 7;
            authorComboBoxEditBookPanel.SelectedIndexChanged += authorComboBoxEditBookPanel_SelectedIndexChanged;
            // 
            // authorFlowBookEditPanel
            // 
            authorFlowBookEditPanel.AutoSize = true;
            authorFlowBookEditPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            authorFlowBookEditPanel.Location = new Point(23, 120);
            authorFlowBookEditPanel.Margin = new Padding(3, 3, 3, 15);
            authorFlowBookEditPanel.Name = "authorFlowBookEditPanel";
            authorFlowBookEditPanel.Size = new Size(0, 0);
            authorFlowBookEditPanel.TabIndex = 17;
            authorFlowBookEditPanel.ControlAdded += authorFlowBookEditPanel_ControlAdded;
            authorFlowBookEditPanel.ControlRemoved += authorFlowBookEditPanel_ControlRemoved;
            // 
            // flowLayoutPanel46
            // 
            flowLayoutPanel46.AutoSize = true;
            flowLayoutPanel46.Controls.Add(label28);
            flowLayoutPanel46.Controls.Add(publisherComboBoxEditBookPanel);
            flowLayoutPanel46.Location = new Point(23, 138);
            flowLayoutPanel46.Name = "flowLayoutPanel46";
            flowLayoutPanel46.Size = new Size(608, 39);
            flowLayoutPanel46.TabIndex = 16;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(3, 0);
            label28.Name = "label28";
            label28.Size = new Size(88, 25);
            label28.TabIndex = 6;
            label28.Text = "Publisher:";
            // 
            // publisherComboBoxEditBookPanel
            // 
            publisherComboBoxEditBookPanel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            publisherComboBoxEditBookPanel.AutoCompleteSource = AutoCompleteSource.ListItems;
            publisherComboBoxEditBookPanel.FormattingEnabled = true;
            publisherComboBoxEditBookPanel.Location = new Point(97, 3);
            publisherComboBoxEditBookPanel.Name = "publisherComboBoxEditBookPanel";
            publisherComboBoxEditBookPanel.Size = new Size(508, 33);
            publisherComboBoxEditBookPanel.TabIndex = 7;
            publisherComboBoxEditBookPanel.SelectedIndexChanged += publisherComboBoxEditBookPanel_SelectedIndexChanged;
            // 
            // flowLayoutPanel47
            // 
            flowLayoutPanel47.AutoSize = true;
            flowLayoutPanel47.Controls.Add(label29);
            flowLayoutPanel47.Controls.Add(pagesTextBoxEditBookPanel);
            flowLayoutPanel47.Location = new Point(23, 183);
            flowLayoutPanel47.Name = "flowLayoutPanel47";
            flowLayoutPanel47.Size = new Size(608, 37);
            flowLayoutPanel47.TabIndex = 8;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(3, 0);
            label29.Name = "label29";
            label29.Size = new Size(62, 25);
            label29.TabIndex = 6;
            label29.Text = "Pages:";
            // 
            // pagesTextBoxEditBookPanel
            // 
            pagesTextBoxEditBookPanel.Location = new Point(71, 3);
            pagesTextBoxEditBookPanel.Name = "pagesTextBoxEditBookPanel";
            pagesTextBoxEditBookPanel.Size = new Size(534, 31);
            pagesTextBoxEditBookPanel.TabIndex = 7;
            pagesTextBoxEditBookPanel.TextChanged += pagesTextBoxEditBookPanel_TextChanged;
            // 
            // flowLayoutPanel48
            // 
            flowLayoutPanel48.AutoSize = true;
            flowLayoutPanel48.Controls.Add(label30);
            flowLayoutPanel48.Controls.Add(dateTextBoxEditBookPanel);
            flowLayoutPanel48.Location = new Point(23, 226);
            flowLayoutPanel48.Name = "flowLayoutPanel48";
            flowLayoutPanel48.Size = new Size(608, 37);
            flowLayoutPanel48.TabIndex = 9;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(3, 0);
            label30.Name = "label30";
            label30.Size = new Size(145, 25);
            label30.TabIndex = 6;
            label30.Text = "Publication Date:";
            // 
            // dateTextBoxEditBookPanel
            // 
            dateTextBoxEditBookPanel.Location = new Point(154, 3);
            dateTextBoxEditBookPanel.Name = "dateTextBoxEditBookPanel";
            dateTextBoxEditBookPanel.Size = new Size(451, 31);
            dateTextBoxEditBookPanel.TabIndex = 7;
            // 
            // flowLayoutPanel49
            // 
            flowLayoutPanel49.AutoSize = true;
            flowLayoutPanel49.Controls.Add(label31);
            flowLayoutPanel49.Controls.Add(isbnTextBoxEditBookPanel);
            flowLayoutPanel49.Location = new Point(23, 269);
            flowLayoutPanel49.Name = "flowLayoutPanel49";
            flowLayoutPanel49.Size = new Size(608, 37);
            flowLayoutPanel49.TabIndex = 10;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(3, 0);
            label31.Name = "label31";
            label31.Size = new Size(54, 25);
            label31.TabIndex = 6;
            label31.Text = "ISBN:";
            // 
            // isbnTextBoxEditBookPanel
            // 
            isbnTextBoxEditBookPanel.Location = new Point(63, 3);
            isbnTextBoxEditBookPanel.Name = "isbnTextBoxEditBookPanel";
            isbnTextBoxEditBookPanel.Size = new Size(542, 31);
            isbnTextBoxEditBookPanel.TabIndex = 7;
            // 
            // flowLayoutPanel50
            // 
            flowLayoutPanel50.AutoSize = true;
            flowLayoutPanel50.Controls.Add(label32);
            flowLayoutPanel50.Controls.Add(genreComboBoxEditBookPanel);
            flowLayoutPanel50.Location = new Point(23, 312);
            flowLayoutPanel50.Name = "flowLayoutPanel50";
            flowLayoutPanel50.Size = new Size(608, 39);
            flowLayoutPanel50.TabIndex = 11;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(3, 0);
            label32.Name = "label32";
            label32.Size = new Size(62, 25);
            label32.TabIndex = 6;
            label32.Text = "Genre:";
            // 
            // genreComboBoxEditBookPanel
            // 
            genreComboBoxEditBookPanel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            genreComboBoxEditBookPanel.AutoCompleteSource = AutoCompleteSource.ListItems;
            genreComboBoxEditBookPanel.FormattingEnabled = true;
            genreComboBoxEditBookPanel.Location = new Point(71, 3);
            genreComboBoxEditBookPanel.Name = "genreComboBoxEditBookPanel";
            genreComboBoxEditBookPanel.Size = new Size(534, 33);
            genreComboBoxEditBookPanel.TabIndex = 7;
            genreComboBoxEditBookPanel.SelectedIndexChanged += genreComboBoxEditBookPanel_SelectedIndexChanged;
            // 
            // genreFlowBookEditPanel
            // 
            genreFlowBookEditPanel.AutoSize = true;
            genreFlowBookEditPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            genreFlowBookEditPanel.Location = new Point(23, 357);
            genreFlowBookEditPanel.Margin = new Padding(3, 3, 3, 15);
            genreFlowBookEditPanel.Name = "genreFlowBookEditPanel";
            genreFlowBookEditPanel.Size = new Size(0, 0);
            genreFlowBookEditPanel.TabIndex = 14;
            genreFlowBookEditPanel.ControlAdded += genreFlowBookEditPanel_ControlAdded;
            genreFlowBookEditPanel.ControlRemoved += genreFlowBookEditPanel_ControlRemoved;
            // 
            // descriptionTextBoxEditBookPanel
            // 
            descriptionTextBoxEditBookPanel.BorderStyle = BorderStyle.None;
            descriptionTextBoxEditBookPanel.Location = new Point(20, 397);
            descriptionTextBoxEditBookPanel.Margin = new Padding(0, 25, 0, 15);
            descriptionTextBoxEditBookPanel.Multiline = true;
            descriptionTextBoxEditBookPanel.Name = "descriptionTextBoxEditBookPanel";
            descriptionTextBoxEditBookPanel.PlaceholderText = "Description";
            descriptionTextBoxEditBookPanel.ScrollBars = ScrollBars.Vertical;
            descriptionTextBoxEditBookPanel.Size = new Size(640, 269);
            descriptionTextBoxEditBookPanel.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(imageURLTextBoxEditBookPanel);
            flowLayoutPanel1.Controls.Add(imageCheckButonEditBookPanel);
            flowLayoutPanel1.Location = new Point(23, 684);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(636, 40);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 6;
            label1.Text = "Image URL:";
            // 
            // imageURLTextBoxEditBookPanel
            // 
            imageURLTextBoxEditBookPanel.Location = new Point(111, 3);
            imageURLTextBoxEditBookPanel.Name = "imageURLTextBoxEditBookPanel";
            imageURLTextBoxEditBookPanel.Size = new Size(404, 31);
            imageURLTextBoxEditBookPanel.TabIndex = 7;
            // 
            // imageCheckButonEditBookPanel
            // 
            imageCheckButonEditBookPanel.Location = new Point(521, 3);
            imageCheckButonEditBookPanel.Name = "imageCheckButonEditBookPanel";
            imageCheckButonEditBookPanel.Size = new Size(112, 34);
            imageCheckButonEditBookPanel.TabIndex = 19;
            imageCheckButonEditBookPanel.Text = "Check";
            imageCheckButonEditBookPanel.UseVisualStyleBackColor = true;
            // 
            // authorEditTab
            // 
            authorEditTab.Controls.Add(flowLayoutPanel53);
            authorEditTab.Location = new Point(4, 34);
            authorEditTab.Name = "authorEditTab";
            authorEditTab.Padding = new Padding(3);
            authorEditTab.Size = new Size(1114, 878);
            authorEditTab.TabIndex = 1;
            authorEditTab.Text = "Author";
            authorEditTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel53
            // 
            flowLayoutPanel53.Controls.Add(flowLayoutPanel54);
            flowLayoutPanel53.Controls.Add(flowLayoutPanel55);
            flowLayoutPanel53.Controls.Add(flowLayoutPanel56);
            flowLayoutPanel53.Controls.Add(descriptionTextBoxEditAuthorPanel);
            flowLayoutPanel53.Dock = DockStyle.Fill;
            flowLayoutPanel53.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel53.Location = new Point(3, 3);
            flowLayoutPanel53.Name = "flowLayoutPanel53";
            flowLayoutPanel53.Padding = new Padding(20);
            flowLayoutPanel53.Size = new Size(1108, 872);
            flowLayoutPanel53.TabIndex = 0;
            // 
            // flowLayoutPanel54
            // 
            flowLayoutPanel54.AutoSize = true;
            flowLayoutPanel54.Controls.Add(label34);
            flowLayoutPanel54.Controls.Add(firstNameTextBoxEditAuthorPanel);
            flowLayoutPanel54.Location = new Point(23, 23);
            flowLayoutPanel54.Name = "flowLayoutPanel54";
            flowLayoutPanel54.Size = new Size(651, 37);
            flowLayoutPanel54.TabIndex = 20;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(3, 0);
            label34.Name = "label34";
            label34.Size = new Size(101, 25);
            label34.TabIndex = 6;
            label34.Text = "First Name:";
            // 
            // firstNameTextBoxEditAuthorPanel
            // 
            firstNameTextBoxEditAuthorPanel.Location = new Point(110, 3);
            firstNameTextBoxEditAuthorPanel.Name = "firstNameTextBoxEditAuthorPanel";
            firstNameTextBoxEditAuthorPanel.Size = new Size(538, 31);
            firstNameTextBoxEditAuthorPanel.TabIndex = 7;
            // 
            // flowLayoutPanel55
            // 
            flowLayoutPanel55.AutoSize = true;
            flowLayoutPanel55.Controls.Add(label35);
            flowLayoutPanel55.Controls.Add(lastNameTextBoxEditAuthorPanel);
            flowLayoutPanel55.Location = new Point(23, 66);
            flowLayoutPanel55.Name = "flowLayoutPanel55";
            flowLayoutPanel55.Size = new Size(651, 37);
            flowLayoutPanel55.TabIndex = 21;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(3, 0);
            label35.Name = "label35";
            label35.Size = new Size(99, 25);
            label35.TabIndex = 6;
            label35.Text = "Last Name:";
            // 
            // lastNameTextBoxEditAuthorPanel
            // 
            lastNameTextBoxEditAuthorPanel.Location = new Point(108, 3);
            lastNameTextBoxEditAuthorPanel.Name = "lastNameTextBoxEditAuthorPanel";
            lastNameTextBoxEditAuthorPanel.Size = new Size(540, 31);
            lastNameTextBoxEditAuthorPanel.TabIndex = 7;
            // 
            // flowLayoutPanel56
            // 
            flowLayoutPanel56.AutoSize = true;
            flowLayoutPanel56.Controls.Add(label36);
            flowLayoutPanel56.Controls.Add(middleNameTextBoxEditAuthorPanel);
            flowLayoutPanel56.Location = new Point(23, 109);
            flowLayoutPanel56.Name = "flowLayoutPanel56";
            flowLayoutPanel56.Size = new Size(651, 37);
            flowLayoutPanel56.TabIndex = 22;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(3, 0);
            label36.Name = "label36";
            label36.Size = new Size(123, 25);
            label36.TabIndex = 6;
            label36.Text = "Middle Name:";
            // 
            // middleNameTextBoxEditAuthorPanel
            // 
            middleNameTextBoxEditAuthorPanel.Location = new Point(132, 3);
            middleNameTextBoxEditAuthorPanel.Name = "middleNameTextBoxEditAuthorPanel";
            middleNameTextBoxEditAuthorPanel.Size = new Size(516, 31);
            middleNameTextBoxEditAuthorPanel.TabIndex = 7;
            // 
            // descriptionTextBoxEditAuthorPanel
            // 
            descriptionTextBoxEditAuthorPanel.Location = new Point(23, 152);
            descriptionTextBoxEditAuthorPanel.Multiline = true;
            descriptionTextBoxEditAuthorPanel.Name = "descriptionTextBoxEditAuthorPanel";
            descriptionTextBoxEditAuthorPanel.PlaceholderText = "Description";
            descriptionTextBoxEditAuthorPanel.ScrollBars = ScrollBars.Vertical;
            descriptionTextBoxEditAuthorPanel.Size = new Size(651, 330);
            descriptionTextBoxEditAuthorPanel.TabIndex = 23;
            // 
            // publisherEditTab
            // 
            publisherEditTab.Controls.Add(flowLayoutPanel57);
            publisherEditTab.Location = new Point(4, 34);
            publisherEditTab.Name = "publisherEditTab";
            publisherEditTab.Padding = new Padding(3);
            publisherEditTab.Size = new Size(1114, 878);
            publisherEditTab.TabIndex = 2;
            publisherEditTab.Text = "Publisher";
            publisherEditTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel57
            // 
            flowLayoutPanel57.Controls.Add(flowLayoutPanel58);
            flowLayoutPanel57.Controls.Add(flowLayoutPanel59);
            flowLayoutPanel57.Controls.Add(flowLayoutPanel60);
            flowLayoutPanel57.Dock = DockStyle.Fill;
            flowLayoutPanel57.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel57.Location = new Point(3, 3);
            flowLayoutPanel57.Name = "flowLayoutPanel57";
            flowLayoutPanel57.Padding = new Padding(20);
            flowLayoutPanel57.Size = new Size(1108, 872);
            flowLayoutPanel57.TabIndex = 0;
            // 
            // flowLayoutPanel58
            // 
            flowLayoutPanel58.AutoSize = true;
            flowLayoutPanel58.Controls.Add(label37);
            flowLayoutPanel58.Controls.Add(nameTextBoxEditPublisherPanel);
            flowLayoutPanel58.Location = new Point(23, 23);
            flowLayoutPanel58.Name = "flowLayoutPanel58";
            flowLayoutPanel58.Size = new Size(618, 37);
            flowLayoutPanel58.TabIndex = 17;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(3, 0);
            label37.Name = "label37";
            label37.Size = new Size(63, 25);
            label37.TabIndex = 6;
            label37.Text = "Name:";
            // 
            // nameTextBoxEditPublisherPanel
            // 
            nameTextBoxEditPublisherPanel.Location = new Point(72, 3);
            nameTextBoxEditPublisherPanel.Name = "nameTextBoxEditPublisherPanel";
            nameTextBoxEditPublisherPanel.Size = new Size(543, 31);
            nameTextBoxEditPublisherPanel.TabIndex = 7;
            // 
            // flowLayoutPanel59
            // 
            flowLayoutPanel59.AutoSize = true;
            flowLayoutPanel59.Controls.Add(label38);
            flowLayoutPanel59.Controls.Add(emailTextBoxEditPublisherPanel);
            flowLayoutPanel59.Location = new Point(23, 66);
            flowLayoutPanel59.Name = "flowLayoutPanel59";
            flowLayoutPanel59.Size = new Size(618, 37);
            flowLayoutPanel59.TabIndex = 18;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(3, 0);
            label38.Name = "label38";
            label38.Size = new Size(58, 25);
            label38.TabIndex = 6;
            label38.Text = "Email:";
            // 
            // emailTextBoxEditPublisherPanel
            // 
            emailTextBoxEditPublisherPanel.Location = new Point(67, 3);
            emailTextBoxEditPublisherPanel.Name = "emailTextBoxEditPublisherPanel";
            emailTextBoxEditPublisherPanel.Size = new Size(548, 31);
            emailTextBoxEditPublisherPanel.TabIndex = 7;
            // 
            // flowLayoutPanel60
            // 
            flowLayoutPanel60.AutoSize = true;
            flowLayoutPanel60.Controls.Add(label39);
            flowLayoutPanel60.Controls.Add(phoneTextBoxEditPublisherPanel);
            flowLayoutPanel60.Location = new Point(23, 109);
            flowLayoutPanel60.Name = "flowLayoutPanel60";
            flowLayoutPanel60.Size = new Size(618, 37);
            flowLayoutPanel60.TabIndex = 19;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(3, 0);
            label39.Name = "label39";
            label39.Size = new Size(90, 25);
            label39.TabIndex = 6;
            label39.Text = "PhoneNo:";
            // 
            // phoneTextBoxEditPublisherPanel
            // 
            phoneTextBoxEditPublisherPanel.Location = new Point(99, 3);
            phoneTextBoxEditPublisherPanel.Name = "phoneTextBoxEditPublisherPanel";
            phoneTextBoxEditPublisherPanel.Size = new Size(516, 31);
            phoneTextBoxEditPublisherPanel.TabIndex = 7;
            // 
            // genreEditTab
            // 
            genreEditTab.Controls.Add(flowLayoutPanel61);
            genreEditTab.Location = new Point(4, 34);
            genreEditTab.Name = "genreEditTab";
            genreEditTab.Padding = new Padding(3);
            genreEditTab.Size = new Size(1114, 878);
            genreEditTab.TabIndex = 3;
            genreEditTab.Text = "Genre";
            genreEditTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel61
            // 
            flowLayoutPanel61.Controls.Add(flowLayoutPanel67);
            flowLayoutPanel61.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel61.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel61.Controls.Add(subFlowEditGenrePanel);
            flowLayoutPanel61.Dock = DockStyle.Fill;
            flowLayoutPanel61.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel61.Location = new Point(3, 3);
            flowLayoutPanel61.Name = "flowLayoutPanel61";
            flowLayoutPanel61.Padding = new Padding(20);
            flowLayoutPanel61.Size = new Size(1108, 872);
            flowLayoutPanel61.TabIndex = 0;
            // 
            // flowLayoutPanel67
            // 
            flowLayoutPanel67.AutoSize = true;
            flowLayoutPanel67.Controls.Add(label43);
            flowLayoutPanel67.Controls.Add(genreTextBoxEditGenrePanel);
            flowLayoutPanel67.Location = new Point(23, 23);
            flowLayoutPanel67.Name = "flowLayoutPanel67";
            flowLayoutPanel67.Size = new Size(647, 37);
            flowLayoutPanel67.TabIndex = 20;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(3, 0);
            label43.Name = "label43";
            label43.Size = new Size(62, 25);
            label43.TabIndex = 6;
            label43.Text = "Genre:";
            // 
            // genreTextBoxEditGenrePanel
            // 
            genreTextBoxEditGenrePanel.Location = new Point(71, 3);
            genreTextBoxEditGenrePanel.Name = "genreTextBoxEditGenrePanel";
            genreTextBoxEditGenrePanel.Size = new Size(573, 31);
            genreTextBoxEditGenrePanel.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(parentGenreComboBoxEditGenrePanel);
            flowLayoutPanel4.Location = new Point(23, 66);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(636, 39);
            flowLayoutPanel4.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 6;
            label3.Text = "Parent Genre:";
            // 
            // parentGenreComboBoxEditGenrePanel
            // 
            parentGenreComboBoxEditGenrePanel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            parentGenreComboBoxEditGenrePanel.AutoCompleteSource = AutoCompleteSource.ListItems;
            parentGenreComboBoxEditGenrePanel.FormattingEnabled = true;
            parentGenreComboBoxEditGenrePanel.Location = new Point(125, 3);
            parentGenreComboBoxEditGenrePanel.Name = "parentGenreComboBoxEditGenrePanel";
            parentGenreComboBoxEditGenrePanel.Size = new Size(508, 33);
            parentGenreComboBoxEditGenrePanel.TabIndex = 7;
            parentGenreComboBoxEditGenrePanel.SelectedIndexChanged += parentGenreComboBoxEditGenrePanel_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(subComboBoxEditGenrePanel);
            flowLayoutPanel2.Location = new Point(20, 123);
            flowLayoutPanel2.Margin = new Padding(0, 15, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(665, 39);
            flowLayoutPanel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 6;
            label2.Text = "Subcategories:";
            // 
            // subComboBoxEditGenrePanel
            // 
            subComboBoxEditGenrePanel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            subComboBoxEditGenrePanel.AutoCompleteSource = AutoCompleteSource.ListItems;
            subComboBoxEditGenrePanel.FormattingEnabled = true;
            subComboBoxEditGenrePanel.Location = new Point(137, 3);
            subComboBoxEditGenrePanel.Name = "subComboBoxEditGenrePanel";
            subComboBoxEditGenrePanel.Size = new Size(525, 33);
            subComboBoxEditGenrePanel.TabIndex = 7;
            subComboBoxEditGenrePanel.SelectedIndexChanged += subComboBoxEditGenrePanel_SelectedIndexChanged;
            subComboBoxEditGenrePanel.ControlAdded += subComboBoxEditGenrePanel_ControlAdded;
            subComboBoxEditGenrePanel.ControlRemoved += subComboBoxEditGenrePanel_ControlRemoved;
            // 
            // subFlowEditGenrePanel
            // 
            subFlowEditGenrePanel.AutoSize = true;
            subFlowEditGenrePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            subFlowEditGenrePanel.Location = new Point(23, 165);
            subFlowEditGenrePanel.Margin = new Padding(3, 3, 3, 15);
            subFlowEditGenrePanel.Name = "subFlowEditGenrePanel";
            subFlowEditGenrePanel.Size = new Size(0, 0);
            subFlowEditGenrePanel.TabIndex = 23;
            // 
            // flowLayoutPanel62
            // 
            flowLayoutPanel62.Controls.Add(saveButtonEditPanel);
            flowLayoutPanel62.Dock = DockStyle.Fill;
            flowLayoutPanel62.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel62.Location = new Point(0, 0);
            flowLayoutPanel62.Name = "flowLayoutPanel62";
            flowLayoutPanel62.Size = new Size(1122, 86);
            flowLayoutPanel62.TabIndex = 1;
            // 
            // homeButtonEditPanel
            // 
            homeButtonEditPanel.Anchor = AnchorStyles.Right;
            homeButtonEditPanel.Location = new Point(1013, 24);
            homeButtonEditPanel.Name = "homeButtonEditPanel";
            homeButtonEditPanel.Size = new Size(106, 34);
            homeButtonEditPanel.TabIndex = 7;
            homeButtonEditPanel.Text = "Home";
            homeButtonEditPanel.UseVisualStyleBackColor = true;
            homeButtonEditPanel.Click += homeButtonEditPanel_Click;
            // 
            // AbstractEditCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editPanel);
            Name = "AbstractEditCreate";
            Size = new Size(1263, 1222);
            editPanel.Panel1.ResumeLayout(false);
            editPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)editPanel).EndInit();
            editPanel.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            splitContainer10.Panel1.ResumeLayout(false);
            splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer10).EndInit();
            splitContainer10.ResumeLayout(false);
            editTabs.ResumeLayout(false);
            bookEditTab.ResumeLayout(false);
            flowLayoutPanel42.ResumeLayout(false);
            flowLayoutPanel42.PerformLayout();
            flowLayoutPanel43.ResumeLayout(false);
            flowLayoutPanel43.PerformLayout();
            flowLayoutPanel44.ResumeLayout(false);
            flowLayoutPanel44.PerformLayout();
            flowLayoutPanel46.ResumeLayout(false);
            flowLayoutPanel46.PerformLayout();
            flowLayoutPanel47.ResumeLayout(false);
            flowLayoutPanel47.PerformLayout();
            flowLayoutPanel48.ResumeLayout(false);
            flowLayoutPanel48.PerformLayout();
            flowLayoutPanel49.ResumeLayout(false);
            flowLayoutPanel49.PerformLayout();
            flowLayoutPanel50.ResumeLayout(false);
            flowLayoutPanel50.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            authorEditTab.ResumeLayout(false);
            flowLayoutPanel53.ResumeLayout(false);
            flowLayoutPanel53.PerformLayout();
            flowLayoutPanel54.ResumeLayout(false);
            flowLayoutPanel54.PerformLayout();
            flowLayoutPanel55.ResumeLayout(false);
            flowLayoutPanel55.PerformLayout();
            flowLayoutPanel56.ResumeLayout(false);
            flowLayoutPanel56.PerformLayout();
            publisherEditTab.ResumeLayout(false);
            flowLayoutPanel57.ResumeLayout(false);
            flowLayoutPanel57.PerformLayout();
            flowLayoutPanel58.ResumeLayout(false);
            flowLayoutPanel58.PerformLayout();
            flowLayoutPanel59.ResumeLayout(false);
            flowLayoutPanel59.PerformLayout();
            flowLayoutPanel60.ResumeLayout(false);
            flowLayoutPanel60.PerformLayout();
            genreEditTab.ResumeLayout(false);
            flowLayoutPanel61.ResumeLayout(false);
            flowLayoutPanel61.PerformLayout();
            flowLayoutPanel67.ResumeLayout(false);
            flowLayoutPanel67.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel62.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected SplitContainer editPanel;
        protected TableLayoutPanel tableLayoutPanel7;
        protected Button saveButtonEditPanel;
        protected Label pageTitle;
        protected SplitContainer splitContainer10;
        protected FlowLayoutPanel flowLayoutPanel62;
        protected TabControl editTabs;
        protected TabPage bookEditTab;
        protected FlowLayoutPanel flowLayoutPanel42;
        protected FlowLayoutPanel flowLayoutPanel43;
        protected Label label26;
        protected TextBox titleTextBoxEditBookPanel;
        protected FlowLayoutPanel flowLayoutPanel44;
        protected Label label27;
        protected ComboBox authorComboBoxEditBookPanel;
        protected FlowLayoutPanel authorFlowBookEditPanel;
        protected FlowLayoutPanel flowLayoutPanel46;
        protected Label label28;
        protected ComboBox publisherComboBoxEditBookPanel;
        protected FlowLayoutPanel flowLayoutPanel47;
        protected Label label29;
        protected TextBox pagesTextBoxEditBookPanel;
        protected FlowLayoutPanel flowLayoutPanel48;
        protected Label label30;
        protected TextBox dateTextBoxEditBookPanel;
        protected FlowLayoutPanel flowLayoutPanel49;
        protected Label label31;
        protected TextBox isbnTextBoxEditBookPanel;
        protected FlowLayoutPanel flowLayoutPanel50;
        protected Label label32;
        protected ComboBox genreComboBoxEditBookPanel;
        protected FlowLayoutPanel genreFlowBookEditPanel;
        protected TextBox descriptionTextBoxEditBookPanel;
        protected FlowLayoutPanel flowLayoutPanel1;
        protected Label label1;
        protected TextBox imageURLTextBoxEditBookPanel;
        protected Button imageCheckButonEditBookPanel;
        protected TabPage authorEditTab;
        protected FlowLayoutPanel flowLayoutPanel53;
        protected FlowLayoutPanel flowLayoutPanel54;
        protected Label label34;
        protected TextBox firstNameTextBoxEditAuthorPanel;
        protected FlowLayoutPanel flowLayoutPanel55;
        protected Label label35;
        protected TextBox lastNameTextBoxEditAuthorPanel;
        protected FlowLayoutPanel flowLayoutPanel56;
        protected Label label36;
        protected TextBox middleNameTextBoxEditAuthorPanel;
        protected TextBox descriptionTextBoxEditAuthorPanel;
        protected TabPage publisherEditTab;
        protected FlowLayoutPanel flowLayoutPanel57;
        protected FlowLayoutPanel flowLayoutPanel58;
        protected Label label37;
        protected TextBox nameTextBoxEditPublisherPanel;
        protected FlowLayoutPanel flowLayoutPanel59;
        protected Label label38;
        protected TextBox emailTextBoxEditPublisherPanel;
        protected FlowLayoutPanel flowLayoutPanel60;
        protected Label label39;
        protected TextBox phoneTextBoxEditPublisherPanel;
        protected TabPage genreEditTab;
        protected FlowLayoutPanel flowLayoutPanel61;
        protected FlowLayoutPanel flowLayoutPanel67;
        protected Label label43;
        protected TextBox genreTextBoxEditGenrePanel;
        protected FlowLayoutPanel flowLayoutPanel4;
        protected Label label3;
        protected ComboBox parentGenreComboBoxEditGenrePanel;
        protected FlowLayoutPanel flowLayoutPanel2;
        protected Label label2;
        protected ComboBox subComboBoxEditGenrePanel;
        protected FlowLayoutPanel subFlowEditGenrePanel;
        protected Button homeButtonEditPanel;
    }
}
