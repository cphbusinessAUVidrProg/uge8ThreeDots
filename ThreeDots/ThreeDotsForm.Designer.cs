namespace ThreeDots
{
    partial class ThreeDotsForm
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
            this.threeDotControl = new ThreeDots.ThreeDotControl();
            this.colPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // threeDotControl
            // 
            this.threeDotControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeDotControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeDotControl.Location = new System.Drawing.Point(277, 12);
            this.threeDotControl.Model = null;
            this.threeDotControl.Name = "threeDotControl";
            this.threeDotControl.Size = new System.Drawing.Size(412, 652);
            this.threeDotControl.TabIndex = 0;
            // 
            // colPanel
            // 
            this.colPanel.Location = new System.Drawing.Point(13, 13);
            this.colPanel.Name = "colPanel";
            this.colPanel.Size = new System.Drawing.Size(258, 143);
            this.colPanel.TabIndex = 1;
            // 
            // ThreeDotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 685);
            this.Controls.Add(this.colPanel);
            this.Controls.Add(this.threeDotControl);
            this.Name = "ThreeDotsForm";
            this.Text = "Three Dots";
            this.Load += new System.EventHandler(this.ThreeDotsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ThreeDotControl threeDotControl;
        private System.Windows.Forms.Panel colPanel;
    }
}

