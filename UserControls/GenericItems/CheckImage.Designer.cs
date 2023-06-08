namespace LibraryDisplay.UserControls
{
    partial class CheckImage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkImageGeneral = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)checkImageGeneral).BeginInit();
            SuspendLayout();
            // 
            // checkImageGeneral
            // 
            checkImageGeneral.Location = new Point(39, 40);
            checkImageGeneral.Name = "checkImageGeneral";
            checkImageGeneral.Size = new Size(150, 105);
            checkImageGeneral.TabIndex = 0;
            checkImageGeneral.TabStop = false;
            // 
            // CheckImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 244);
            Controls.Add(checkImageGeneral);
            Name = "CheckImage";
            Text = "CheckImage";
            Deactivate += CheckImage_Deactivate;
            Load += CheckImage_Load;
            ((System.ComponentModel.ISupportInitialize)checkImageGeneral).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox checkImageGeneral;
    }
}