namespace Clustering
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnTrainMdl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrainMdl
            // 
            this.btnTrainMdl.Location = new System.Drawing.Point(291, 22);
            this.btnTrainMdl.Name = "btnTrainMdl";
            this.btnTrainMdl.Size = new System.Drawing.Size(116, 41);
            this.btnTrainMdl.TabIndex = 0;
            this.btnTrainMdl.Text = "Train Model";
            this.btnTrainMdl.UseVisualStyleBackColor = true;
            this.btnTrainMdl.Click += new System.EventHandler(this.btnTrainMdl_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrainMdl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ML.Net Clustering";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrainMdl;
    }
}

