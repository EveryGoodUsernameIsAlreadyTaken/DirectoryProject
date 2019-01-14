namespace DirectoryProject
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
            this.btnMainOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainOpen
            // 
            this.btnMainOpen.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainOpen.Location = new System.Drawing.Point(535, 154);
            this.btnMainOpen.Name = "btnMainOpen";
            this.btnMainOpen.Size = new System.Drawing.Size(104, 58);
            this.btnMainOpen.TabIndex = 3;
            this.btnMainOpen.Text = "Open Main";
            this.btnMainOpen.UseVisualStyleBackColor = true;
            this.btnMainOpen.Click += new System.EventHandler(this.btnOpenMain);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(19, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(484, 336);
            this.treeView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Treeview";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnMainOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMainOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
    }
}

