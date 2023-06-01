namespace LibraryDisplay
{
    partial class LibraryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer3 = new SplitContainer();
            splitContainer11 = new SplitContainer();
            tableLayoutPanel8 = new TableLayoutPanel();
            button4 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).BeginInit();
            splitContainer11.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer3
            // 
            splitContainer3.Location = new Point(2178, 16);
            splitContainer3.Margin = new Padding(25);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            splitContainer3.Size = new Size(150, 100);
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer11
            // 
            splitContainer11.Dock = DockStyle.Fill;
            splitContainer11.Location = new Point(0, 0);
            splitContainer11.Name = "splitContainer11";
            splitContainer11.Orientation = Orientation.Horizontal;
            splitContainer11.Size = new Size(150, 100);
            splitContainer11.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel8.Controls.Add(button4, 2, 0);
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(200, 100);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(91, 33);
            button4.Name = "button4";
            button4.Size = new Size(106, 34);
            button4.TabIndex = 4;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(115, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 68);
            label6.TabIndex = 6;
            label6.Text = "Author Name";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1190, 869);
            Name = "LibraryForm";
            Text = "My Library";
            Load += LibraryForm_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer11).EndInit();
            splitContainer11.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label DescriptionLabelAuthorPanel;
        private TextBox textBox14;
        private TextBox textBox13;
        private global::System.Windows.Forms.SplitContainer splitContainer3;
        private global::System.Windows.Forms.SplitContainer splitContainer11;
        private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private global::System.Windows.Forms.Button button4;
        private global::System.Windows.Forms.Label label6;
    }
}