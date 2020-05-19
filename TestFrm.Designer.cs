namespace ProblemRegistration
{
    partial class TestFrm
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
            this.lblSC = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Location = new System.Drawing.Point(43, 27);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(46, 17);
            this.lblSC.TabIndex = 0;
            this.lblSC.Text = "label1";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(264, 27);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(46, 17);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "label2";
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblSC);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.Load += new System.EventHandler(this.TestFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblPlan;
    }
}