namespace CalculateAngelInvestorRatio
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
            this.txtLifetimeEarnings = new System.Windows.Forms.TextBox();
            this.txtTotalAngels = new System.Windows.Forms.TextBox();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numExpEarnings = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numExpAngels = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rbRatio = new System.Windows.Forms.RadioButton();
            this.rbTotalAngels = new System.Windows.Forms.RadioButton();
            this.rbLifetimeEarnings = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIllionsEarnings = new System.Windows.Forms.Label();
            this.lblIllionsAngels = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numExpEarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpAngels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lifetime Earnings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Angels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ratio";
            // 
            // txtLifetimeEarnings
            // 
            this.txtLifetimeEarnings.Location = new System.Drawing.Point(187, 168);
            this.txtLifetimeEarnings.Name = "txtLifetimeEarnings";
            this.txtLifetimeEarnings.Size = new System.Drawing.Size(48, 20);
            this.txtLifetimeEarnings.TabIndex = 1;
            this.txtLifetimeEarnings.TextChanged += new System.EventHandler(this.txtLifetimeEarnings_TextChanged);
            // 
            // txtTotalAngels
            // 
            this.txtTotalAngels.Location = new System.Drawing.Point(187, 129);
            this.txtTotalAngels.Name = "txtTotalAngels";
            this.txtTotalAngels.Size = new System.Drawing.Size(48, 20);
            this.txtTotalAngels.TabIndex = 3;
            this.txtTotalAngels.TextChanged += new System.EventHandler(this.txtLifetimeEarnings_TextChanged);
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(222, 90);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(94, 20);
            this.txtRatio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "x10^";
            // 
            // numExpEarnings
            // 
            this.numExpEarnings.Location = new System.Drawing.Point(277, 169);
            this.numExpEarnings.Maximum = new decimal(new int[] {
            306,
            0,
            0,
            0});
            this.numExpEarnings.Name = "numExpEarnings";
            this.numExpEarnings.Size = new System.Drawing.Size(39, 20);
            this.numExpEarnings.TabIndex = 2;
            this.numExpEarnings.ValueChanged += new System.EventHandler(this.numExpEarnings_ValueChanged);
            this.numExpEarnings.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numExpEarnings_KeyUp);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(42, 166);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 32);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numExpAngels
            // 
            this.numExpAngels.Location = new System.Drawing.Point(277, 130);
            this.numExpAngels.Maximum = new decimal(new int[] {
            306,
            0,
            0,
            0});
            this.numExpAngels.Name = "numExpAngels";
            this.numExpAngels.Size = new System.Drawing.Size(39, 20);
            this.numExpAngels.TabIndex = 4;
            this.numExpAngels.ValueChanged += new System.EventHandler(this.numExpEarnings_ValueChanged);
            this.numExpAngels.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numExpEarnings_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "x10^";
            // 
            // rbRatio
            // 
            this.rbRatio.AutoSize = true;
            this.rbRatio.Checked = true;
            this.rbRatio.Location = new System.Drawing.Point(73, 89);
            this.rbRatio.Name = "rbRatio";
            this.rbRatio.Size = new System.Drawing.Size(50, 17);
            this.rbRatio.TabIndex = 12;
            this.rbRatio.TabStop = true;
            this.rbRatio.Text = "Ratio";
            this.rbRatio.UseVisualStyleBackColor = true;
            this.rbRatio.CheckedChanged += new System.EventHandler(this.rbRatio_CheckedChanged);
            // 
            // rbTotalAngels
            // 
            this.rbTotalAngels.AutoSize = true;
            this.rbTotalAngels.Location = new System.Drawing.Point(73, 112);
            this.rbTotalAngels.Name = "rbTotalAngels";
            this.rbTotalAngels.Size = new System.Drawing.Size(84, 17);
            this.rbTotalAngels.TabIndex = 13;
            this.rbTotalAngels.Text = "Total Angels";
            this.rbTotalAngels.UseVisualStyleBackColor = true;
            this.rbTotalAngels.CheckedChanged += new System.EventHandler(this.rbRatio_CheckedChanged);
            // 
            // rbLifetimeEarnings
            // 
            this.rbLifetimeEarnings.AutoSize = true;
            this.rbLifetimeEarnings.Location = new System.Drawing.Point(73, 135);
            this.rbLifetimeEarnings.Name = "rbLifetimeEarnings";
            this.rbLifetimeEarnings.Size = new System.Drawing.Size(105, 17);
            this.rbLifetimeEarnings.TabIndex = 14;
            this.rbLifetimeEarnings.Text = "Lifetime Earnings";
            this.rbLifetimeEarnings.UseVisualStyleBackColor = true;
            this.rbLifetimeEarnings.CheckedChanged += new System.EventHandler(this.rbRatio_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CalculateAngelInvestorRatio.Properties.Resources.formula_ratio;
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Calculate:";
            // 
            // lblIllionsEarnings
            // 
            this.lblIllionsEarnings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIllionsEarnings.Location = new System.Drawing.Point(322, 168);
            this.lblIllionsEarnings.Name = "lblIllionsEarnings";
            this.lblIllionsEarnings.Size = new System.Drawing.Size(130, 30);
            this.lblIllionsEarnings.TabIndex = 15;
            this.lblIllionsEarnings.Text = "XXX,XXX\r\n-illion";
            // 
            // lblIllionsAngels
            // 
            this.lblIllionsAngels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIllionsAngels.Location = new System.Drawing.Point(322, 129);
            this.lblIllionsAngels.Name = "lblIllionsAngels";
            this.lblIllionsAngels.Size = new System.Drawing.Size(130, 30);
            this.lblIllionsAngels.TabIndex = 16;
            this.lblIllionsAngels.Text = "XXX,XXX\r\n-illion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 211);
            this.Controls.Add(this.lblIllionsAngels);
            this.Controls.Add(this.lblIllionsEarnings);
            this.Controls.Add(this.rbLifetimeEarnings);
            this.Controls.Add(this.rbTotalAngels);
            this.Controls.Add(this.rbRatio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numExpAngels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numExpEarnings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRatio);
            this.Controls.Add(this.txtTotalAngels);
            this.Controls.Add(this.txtLifetimeEarnings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI/Earnings/Ratio Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numExpEarnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpAngels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLifetimeEarnings;
        private System.Windows.Forms.TextBox txtTotalAngels;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numExpEarnings;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numExpAngels;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbRatio;
        private System.Windows.Forms.RadioButton rbTotalAngels;
        private System.Windows.Forms.RadioButton rbLifetimeEarnings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIllionsEarnings;
        private System.Windows.Forms.Label lblIllionsAngels;
    }
}

