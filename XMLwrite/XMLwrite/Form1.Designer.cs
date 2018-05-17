namespace XMLwrite
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
            this.directorySet = new System.Windows.Forms.Button();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.InputBody = new System.Windows.Forms.TextBox();
            this.writeStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySet
            // 
            this.directorySet.Location = new System.Drawing.Point(125, 37);
            this.directorySet.Name = "directorySet";
            this.directorySet.Size = new System.Drawing.Size(135, 25);
            this.directorySet.TabIndex = 0;
            this.directorySet.Text = "Set File";
            this.directorySet.UseVisualStyleBackColor = true;
            this.directorySet.Click += new System.EventHandler(this.directorySet_Click);
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(125, 82);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(588, 20);
            this.inputTitle.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(68, 85);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // InputBody
            // 
            this.InputBody.Location = new System.Drawing.Point(125, 119);
            this.InputBody.Multiline = true;
            this.InputBody.Name = "InputBody";
            this.InputBody.Size = new System.Drawing.Size(588, 319);
            this.InputBody.TabIndex = 3;
            // 
            // writeStart
            // 
            this.writeStart.Location = new System.Drawing.Point(637, 38);
            this.writeStart.Name = "writeStart";
            this.writeStart.Size = new System.Drawing.Size(75, 23);
            this.writeStart.TabIndex = 4;
            this.writeStart.Text = "Write";
            this.writeStart.UseVisualStyleBackColor = true;
            this.writeStart.Click += new System.EventHandler(this.writeStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.writeStart);
            this.Controls.Add(this.InputBody);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.directorySet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directorySet;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputBody;
        private System.Windows.Forms.Button writeStart;
    }
}

