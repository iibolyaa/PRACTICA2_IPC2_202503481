namespace CSharpFormApp
{
    partial class Form1
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
            this.splitcontainer1 = new System.Windows.Forms.SplitContainer();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Size = new System.Drawing.Size(600, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            
            // 
            // splitcontainer1
            // 
            this.splitcontainer1.Location = new System.Drawing.Point(null, null);
            this.splitcontainer1.Name = "splitcontainer1";
            this.splitcontainer1.Size = new System.Drawing.Size(576, 408);
            this.splitcontainer1.TabIndex = 1;
            this.splitcontainer1.Text = "splitcontainer1";
            this.Controls.Add(this.splitcontainer1);
            this.ResumeLayout(false);
        }

        #endregion
    
        private System.Windows.Forms.SplitContainer splitcontainer1;}
}
