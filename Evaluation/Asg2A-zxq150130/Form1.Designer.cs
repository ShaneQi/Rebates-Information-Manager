namespace Asg2A_zxq150130
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.timeLabelMax = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timeLabelMin = new System.Windows.Forms.Label();
            this.timeLabelAvg = new System.Windows.Forms.Label();
            this.intervalLabelMax = new System.Windows.Forms.Label();
            this.intervalLabelMin = new System.Windows.Forms.Label();
            this.intervalLabelAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entering Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entering Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "File";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(469, 43);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.BackColor = System.Drawing.Color.White;
            this.fileLabel.Location = new System.Drawing.Point(141, 48);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.fileLabel.Size = new System.Drawing.Size(300, 15);
            this.fileLabel.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.Color.White;
            this.numberLabel.Location = new System.Drawing.Point(141, 81);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.numberLabel.Size = new System.Drawing.Size(300, 15);
            this.numberLabel.TabIndex = 2;
            // 
            // timeLabelMax
            // 
            this.timeLabelMax.BackColor = System.Drawing.Color.White;
            this.timeLabelMax.Location = new System.Drawing.Point(141, 114);
            this.timeLabelMax.Name = "timeLabelMax";
            this.timeLabelMax.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.timeLabelMax.Size = new System.Drawing.Size(88, 15);
            this.timeLabelMax.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(141, 180);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.totalLabel.Size = new System.Drawing.Size(300, 15);
            this.totalLabel.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timeLabelMin
            // 
            this.timeLabelMin.BackColor = System.Drawing.Color.White;
            this.timeLabelMin.Location = new System.Drawing.Point(247, 114);
            this.timeLabelMin.Name = "timeLabelMin";
            this.timeLabelMin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.timeLabelMin.Size = new System.Drawing.Size(88, 15);
            this.timeLabelMin.TabIndex = 2;
            // 
            // timeLabelAvg
            // 
            this.timeLabelAvg.BackColor = System.Drawing.Color.White;
            this.timeLabelAvg.Location = new System.Drawing.Point(353, 114);
            this.timeLabelAvg.Name = "timeLabelAvg";
            this.timeLabelAvg.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.timeLabelAvg.Size = new System.Drawing.Size(88, 15);
            this.timeLabelAvg.TabIndex = 2;
            // 
            // intervalLabelMax
            // 
            this.intervalLabelMax.BackColor = System.Drawing.Color.White;
            this.intervalLabelMax.Location = new System.Drawing.Point(141, 147);
            this.intervalLabelMax.Name = "intervalLabelMax";
            this.intervalLabelMax.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.intervalLabelMax.Size = new System.Drawing.Size(88, 15);
            this.intervalLabelMax.TabIndex = 2;
            // 
            // intervalLabelMin
            // 
            this.intervalLabelMin.BackColor = System.Drawing.Color.White;
            this.intervalLabelMin.Location = new System.Drawing.Point(247, 147);
            this.intervalLabelMin.Name = "intervalLabelMin";
            this.intervalLabelMin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.intervalLabelMin.Size = new System.Drawing.Size(88, 15);
            this.intervalLabelMin.TabIndex = 2;
            // 
            // intervalLabelAvg
            // 
            this.intervalLabelAvg.BackColor = System.Drawing.Color.White;
            this.intervalLabelAvg.Location = new System.Drawing.Point(353, 147);
            this.intervalLabelAvg.Name = "intervalLabelAvg";
            this.intervalLabelAvg.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.intervalLabelAvg.Size = new System.Drawing.Size(88, 15);
            this.intervalLabelAvg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 239);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.intervalLabelAvg);
            this.Controls.Add(this.timeLabelAvg);
            this.Controls.Add(this.intervalLabelMin);
            this.Controls.Add(this.timeLabelMin);
            this.Controls.Add(this.intervalLabelMax);
            this.Controls.Add(this.timeLabelMax);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label timeLabelMax;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label timeLabelMin;
        private System.Windows.Forms.Label timeLabelAvg;
        private System.Windows.Forms.Label intervalLabelMax;
        private System.Windows.Forms.Label intervalLabelMin;
        private System.Windows.Forms.Label intervalLabelAvg;
    }
}

