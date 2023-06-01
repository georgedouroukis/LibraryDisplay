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
            label1 = new Label();
            splitContainer7 = new SplitContainer();
            collectionBookFlow = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            homeButtonCollectionPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)collectionPanel).BeginInit();
            collectionPanel.Panel1.SuspendLayout();
            collectionPanel.Panel2.SuspendLayout();
            collectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
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
            collectionPanel.Panel1.Controls.Add(label1);
            // 
            // collectionPanel.Panel2
            // 
            collectionPanel.Panel2.Controls.Add(splitContainer7);
            collectionPanel.Size = new Size(859, 697);
            collectionPanel.SplitterDistance = 123;
            collectionPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(859, 123);
            label1.TabIndex = 3;
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
            splitContainer7.Panel2.Controls.Add(flowLayoutPanel4);
            splitContainer7.Size = new Size(859, 570);
            splitContainer7.SplitterDistance = 478;
            splitContainer7.TabIndex = 1;
            // 
            // collectionBookFlow
            // 
            collectionBookFlow.AutoScroll = true;
            collectionBookFlow.Dock = DockStyle.Fill;
            collectionBookFlow.Location = new Point(0, 0);
            collectionBookFlow.Name = "collectionBookFlow";
            collectionBookFlow.Size = new Size(859, 478);
            collectionBookFlow.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(homeButtonCollectionPanel);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(859, 88);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // homeButtonCollectionPanel
            // 
            homeButtonCollectionPanel.Anchor = AnchorStyles.Right;
            homeButtonCollectionPanel.Location = new Point(744, 3);
            homeButtonCollectionPanel.Name = "homeButtonCollectionPanel";
            homeButtonCollectionPanel.Size = new Size(112, 34);
            homeButtonCollectionPanel.TabIndex = 7;
            homeButtonCollectionPanel.Text = "Home";
            homeButtonCollectionPanel.UseVisualStyleBackColor = true;
            homeButtonCollectionPanel.Click += homeButtonCollectionPanel_Click;
            // 
            // CollectionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(collectionPanel);
            Name = "CollectionControl";
            Size = new Size(968, 802);
            collectionPanel.Panel1.ResumeLayout(false);
            collectionPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)collectionPanel).EndInit();
            collectionPanel.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer collectionPanel;
        private Label label1;
        private SplitContainer splitContainer7;
        private FlowLayoutPanel collectionBookFlow;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button homeButtonCollectionPanel;
    }
}
