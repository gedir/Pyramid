namespace SumTree
{
    partial class frmTask
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
            this.cbExit = new System.Windows.Forms.Button();
            this.rtTree = new System.Windows.Forms.RichTextBox();
            this.cbRefresh = new System.Windows.Forms.Button();
            this.tvTree = new System.Windows.Forms.TreeView();
            this.rtBranches = new System.Windows.Forms.RichTextBox();
            this.lRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbExit
            // 
            this.cbExit.Location = new System.Drawing.Point(823, 521);
            this.cbExit.Name = "cbExit";
            this.cbExit.Size = new System.Drawing.Size(75, 23);
            this.cbExit.TabIndex = 0;
            this.cbExit.Text = "Exit";
            this.cbExit.UseVisualStyleBackColor = true;
            this.cbExit.Click += new System.EventHandler(this.cbExit_Click);
            // 
            // rtTree
            // 
            this.rtTree.Location = new System.Drawing.Point(25, 33);
            this.rtTree.Name = "rtTree";
            this.rtTree.Size = new System.Drawing.Size(445, 220);
            this.rtTree.TabIndex = 1;
            this.rtTree.Text = "";
            // 
            // cbRefresh
            // 
            this.cbRefresh.Location = new System.Drawing.Point(451, 259);
            this.cbRefresh.Name = "cbRefresh";
            this.cbRefresh.Size = new System.Drawing.Size(75, 23);
            this.cbRefresh.TabIndex = 2;
            this.cbRefresh.Text = "Refresh";
            this.cbRefresh.UseVisualStyleBackColor = true;
            this.cbRefresh.Click += new System.EventHandler(this.cbRefresh_Click);
            // 
            // tvTree
            // 
            this.tvTree.Location = new System.Drawing.Point(492, 33);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(406, 220);
            this.tvTree.TabIndex = 4;
            // 
            // rtBranches
            // 
            this.rtBranches.Location = new System.Drawing.Point(25, 296);
            this.rtBranches.Name = "rtBranches";
            this.rtBranches.Size = new System.Drawing.Size(873, 175);
            this.rtBranches.TabIndex = 5;
            this.rtBranches.Text = "";
            // 
            // lRes
            // 
            this.lRes.AutoSize = true;
            this.lRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lRes.Location = new System.Drawing.Point(22, 484);
            this.lRes.Name = "lRes";
            this.lRes.Size = new System.Drawing.Size(24, 20);
            this.lRes.TabIndex = 6;
            this.lRes.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Full Branches";
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRes);
            this.Controls.Add(this.rtBranches);
            this.Controls.Add(this.tvTree);
            this.Controls.Add(this.cbRefresh);
            this.Controls.Add(this.rtTree);
            this.Controls.Add(this.cbExit);
            this.Name = "frmTask";
            this.Text = "Pyramid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cbExit;
        private System.Windows.Forms.RichTextBox rtTree;
        private System.Windows.Forms.Button cbRefresh;
        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.RichTextBox rtBranches;
        private System.Windows.Forms.Label lRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

