namespace DirectoryProject
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbLineCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(764, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 56);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button_Delete);
            // 
            // tbLineCount
            // 
            this.tbLineCount.Location = new System.Drawing.Point(92, 93);
            this.tbLineCount.Name = "tbLineCount";
            this.tbLineCount.ReadOnly = true;
            this.tbLineCount.Size = new System.Drawing.Size(100, 20);
            this.tbLineCount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Line Counter:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(22, 119);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(839, 279);
            this.tbText.TabIndex = 11;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_Changed);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 56);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveAs);
            // 
            // tbSave
            // 
            this.tbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSave.Location = new System.Drawing.Point(267, 44);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(142, 29);
            this.tbSave.TabIndex = 13;
            this.tbSave.Visible = false;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(264, 28);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(86, 13);
            this.lblSave.TabIndex = 14;
            this.lblSave.Text = "Name of text file:";
            this.lblSave.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(425, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 56);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 422);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLineCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbLineCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnCancel;
    }
}