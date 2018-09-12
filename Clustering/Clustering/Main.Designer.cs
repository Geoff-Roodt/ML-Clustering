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
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblSplLgth = new System.Windows.Forms.Label();
            this.lblSplWdth = new System.Windows.Forms.Label();
            this.lblPtlWdth = new System.Windows.Forms.Label();
            this.lblPtlLgth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSplWdth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSplLgth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPtlLgth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPtlWdth = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblPredictions = new System.Windows.Forms.Label();
            this.txtPredictions = new System.Windows.Forms.TextBox();
            this.pnlData.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrainMdl
            // 
            this.btnTrainMdl.Location = new System.Drawing.Point(311, 26);
            this.btnTrainMdl.Name = "btnTrainMdl";
            this.btnTrainMdl.Size = new System.Drawing.Size(116, 41);
            this.btnTrainMdl.TabIndex = 0;
            this.btnTrainMdl.Text = "Train Model";
            this.btnTrainMdl.UseVisualStyleBackColor = true;
            this.btnTrainMdl.Click += new System.EventHandler(this.btnTrainMdl_ClickAsync);
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.btnPredict);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.txtPtlLgth);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.txtPtlWdth);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txtSplLgth);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.txtSplWdth);
            this.pnlData.Controls.Add(this.lblPtlWdth);
            this.pnlData.Controls.Add(this.lblPtlLgth);
            this.pnlData.Controls.Add(this.lblSplWdth);
            this.pnlData.Controls.Add(this.lblSplLgth);
            this.pnlData.Location = new System.Drawing.Point(12, 73);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(353, 337);
            this.pnlData.TabIndex = 1;
            // 
            // lblSplLgth
            // 
            this.lblSplLgth.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplLgth.Location = new System.Drawing.Point(3, 88);
            this.lblSplLgth.Name = "lblSplLgth";
            this.lblSplLgth.Size = new System.Drawing.Size(123, 34);
            this.lblSplLgth.TabIndex = 1;
            this.lblSplLgth.Text = "Sepal Length:";
            this.lblSplLgth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSplWdth
            // 
            this.lblSplWdth.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplWdth.Location = new System.Drawing.Point(3, 20);
            this.lblSplWdth.Name = "lblSplWdth";
            this.lblSplWdth.Size = new System.Drawing.Size(123, 34);
            this.lblSplWdth.TabIndex = 2;
            this.lblSplWdth.Text = "Sepal Width:";
            this.lblSplWdth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPtlWdth
            // 
            this.lblPtlWdth.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtlWdth.Location = new System.Drawing.Point(3, 156);
            this.lblPtlWdth.Name = "lblPtlWdth";
            this.lblPtlWdth.Size = new System.Drawing.Size(123, 34);
            this.lblPtlWdth.TabIndex = 4;
            this.lblPtlWdth.Text = "Petal Width:";
            this.lblPtlWdth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPtlLgth
            // 
            this.lblPtlLgth.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtlLgth.Location = new System.Drawing.Point(3, 224);
            this.lblPtlLgth.Name = "lblPtlLgth";
            this.lblPtlLgth.Size = new System.Drawing.Size(123, 34);
            this.lblPtlLgth.TabIndex = 3;
            this.lblPtlLgth.Text = "Petal Length:";
            this.lblPtlLgth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "cm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSplWdth
            // 
            this.txtSplWdth.Enabled = false;
            this.txtSplWdth.Location = new System.Drawing.Point(152, 34);
            this.txtSplWdth.Name = "txtSplWdth";
            this.txtSplWdth.Size = new System.Drawing.Size(100, 20);
            this.txtSplWdth.TabIndex = 7;
            this.txtSplWdth.TextChanged += new System.EventHandler(this.txtSplWdth_TextChanged);
            this.txtSplWdth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSplWdth_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "cm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSplLgth
            // 
            this.txtSplLgth.Enabled = false;
            this.txtSplLgth.Location = new System.Drawing.Point(152, 102);
            this.txtSplLgth.Name = "txtSplLgth";
            this.txtSplLgth.Size = new System.Drawing.Size(100, 20);
            this.txtSplLgth.TabIndex = 9;
            this.txtSplLgth.TextChanged += new System.EventHandler(this.txtSplLgth_TextChanged);
            this.txtSplLgth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSplLgth_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "cm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPtlLgth
            // 
            this.txtPtlLgth.Enabled = false;
            this.txtPtlLgth.Location = new System.Drawing.Point(152, 238);
            this.txtPtlLgth.Name = "txtPtlLgth";
            this.txtPtlLgth.Size = new System.Drawing.Size(100, 20);
            this.txtPtlLgth.TabIndex = 13;
            this.txtPtlLgth.TextChanged += new System.EventHandler(this.txtPtlLgth_TextChanged);
            this.txtPtlLgth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPtlLgth_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "cm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPtlWdth
            // 
            this.txtPtlWdth.Enabled = false;
            this.txtPtlWdth.Location = new System.Drawing.Point(152, 170);
            this.txtPtlWdth.Name = "txtPtlWdth";
            this.txtPtlWdth.Size = new System.Drawing.Size(100, 20);
            this.txtPtlWdth.TabIndex = 11;
            this.txtPtlWdth.TextChanged += new System.EventHandler(this.txtPtlWdth_TextChanged);
            this.txtPtlWdth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPtlWdth_KeyPress);
            // 
            // btnPredict
            // 
            this.btnPredict.Enabled = false;
            this.btnPredict.Location = new System.Drawing.Point(96, 278);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(116, 41);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict Iris";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.txtPredictions);
            this.pnlInfo.Controls.Add(this.lblPredictions);
            this.pnlInfo.Location = new System.Drawing.Point(371, 73);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(417, 241);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblPredictions
            // 
            this.lblPredictions.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictions.Location = new System.Drawing.Point(148, 0);
            this.lblPredictions.Name = "lblPredictions";
            this.lblPredictions.Size = new System.Drawing.Size(123, 34);
            this.lblPredictions.TabIndex = 15;
            this.lblPredictions.Text = "Predictions:";
            this.lblPredictions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPredictions
            // 
            this.txtPredictions.Location = new System.Drawing.Point(29, 39);
            this.txtPredictions.Multiline = true;
            this.txtPredictions.Name = "txtPredictions";
            this.txtPredictions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPredictions.Size = new System.Drawing.Size(359, 179);
            this.txtPredictions.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnTrainMdl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ML.Net Clustering";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrainMdl;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblSplLgth;
        private System.Windows.Forms.Label lblPtlWdth;
        private System.Windows.Forms.Label lblPtlLgth;
        private System.Windows.Forms.Label lblSplWdth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPtlLgth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPtlWdth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSplLgth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSplWdth;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblPredictions;
        private System.Windows.Forms.TextBox txtPredictions;
    }
}

