namespace Lab4
{
    partial class MainForm
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCharacteristics = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxQueueLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServiceTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIntensity = new System.Windows.Forms.TextBox();
            this.txtMinQueueLength = new System.Windows.Forms.TextBox();
            this.txtChannelsCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(11, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(127, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCharacteristics);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 299);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System characteristics";
            // 
            // txtCharacteristics
            // 
            this.txtCharacteristics.Location = new System.Drawing.Point(7, 18);
            this.txtCharacteristics.Multiline = true;
            this.txtCharacteristics.Name = "txtCharacteristics";
            this.txtCharacteristics.ReadOnly = true;
            this.txtCharacteristics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacteristics.Size = new System.Drawing.Size(335, 273);
            this.txtCharacteristics.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMaxQueueLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtServiceTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIntensity);
            this.groupBox1.Controls.Add(this.txtMinQueueLength);
            this.groupBox1.Controls.Add(this.txtChannelsCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System parameters";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "to";
            // 
            // txtMaxQueueLength
            // 
            this.txtMaxQueueLength.Location = new System.Drawing.Point(203, 44);
            this.txtMaxQueueLength.Name = "txtMaxQueueLength";
            this.txtMaxQueueLength.Size = new System.Drawing.Size(26, 20);
            this.txtMaxQueueLength.TabIndex = 9;
            this.txtMaxQueueLength.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "from";
            // 
            // txtServiceTime
            // 
            this.txtServiceTime.Location = new System.Drawing.Point(125, 98);
            this.txtServiceTime.Name = "txtServiceTime";
            this.txtServiceTime.Size = new System.Drawing.Size(104, 20);
            this.txtServiceTime.TabIndex = 7;
            this.txtServiceTime.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "service time (min/car)";
            // 
            // txtIntensity
            // 
            this.txtIntensity.Location = new System.Drawing.Point(125, 71);
            this.txtIntensity.Name = "txtIntensity";
            this.txtIntensity.Size = new System.Drawing.Size(104, 20);
            this.txtIntensity.TabIndex = 5;
            this.txtIntensity.Text = "1";
            // 
            // txtMinQueueLength
            // 
            this.txtMinQueueLength.Location = new System.Drawing.Point(153, 44);
            this.txtMinQueueLength.Name = "txtMinQueueLength";
            this.txtMinQueueLength.Size = new System.Drawing.Size(26, 20);
            this.txtMinQueueLength.TabIndex = 4;
            this.txtMinQueueLength.Text = "3";
            // 
            // txtChannelsCount
            // 
            this.txtChannelsCount.Location = new System.Drawing.Point(125, 17);
            this.txtChannelsCount.Name = "txtChannelsCount";
            this.txtChannelsCount.Size = new System.Drawing.Size(104, 20);
            this.txtChannelsCount.TabIndex = 3;
            this.txtChannelsCount.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "intensity (car/min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "m (queue places)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n (channels)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 320);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Gas station";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxQueueLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServiceTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIntensity;
        private System.Windows.Forms.TextBox txtMinQueueLength;
        private System.Windows.Forms.TextBox txtChannelsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharacteristics;
    }
}

