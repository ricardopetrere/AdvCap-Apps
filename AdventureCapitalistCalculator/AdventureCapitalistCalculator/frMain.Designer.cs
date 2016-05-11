namespace AdventureCapitalistCalculator
{
    partial class frMain
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
            this.tabPlanets = new System.Windows.Forms.TabControl();
            this.tabEarth = new System.Windows.Forms.TabPage();
            this.ucPlanetBase1 = new AdventureCapitalistCalculator.ucPlanetBase();
            this.tabMoon = new System.Windows.Forms.TabPage();
            this.ucPlanetBase2 = new AdventureCapitalistCalculator.ucPlanetBase();
            this.tabMars = new System.Windows.Forms.TabPage();
            this.ucPlanetBase3 = new AdventureCapitalistCalculator.ucPlanetBase();
            this.tabEvent = new System.Windows.Forms.TabPage();
            this.ucPlanetBase4 = new AdventureCapitalistCalculator.ucPlanetBase();
            this.tabPlanets.SuspendLayout();
            this.tabEarth.SuspendLayout();
            this.tabMoon.SuspendLayout();
            this.tabMars.SuspendLayout();
            this.tabEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPlanets
            // 
            this.tabPlanets.Controls.Add(this.tabEarth);
            this.tabPlanets.Controls.Add(this.tabMoon);
            this.tabPlanets.Controls.Add(this.tabMars);
            this.tabPlanets.Controls.Add(this.tabEvent);
            this.tabPlanets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlanets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPlanets.Location = new System.Drawing.Point(0, 0);
            this.tabPlanets.Name = "tabPlanets";
            this.tabPlanets.SelectedIndex = 0;
            this.tabPlanets.Size = new System.Drawing.Size(955, 648);
            this.tabPlanets.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPlanets.TabIndex = 0;
            // 
            // tabEarth
            // 
            this.tabEarth.Controls.Add(this.ucPlanetBase1);
            this.tabEarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEarth.Location = new System.Drawing.Point(4, 29);
            this.tabEarth.Name = "tabEarth";
            this.tabEarth.Padding = new System.Windows.Forms.Padding(3);
            this.tabEarth.Size = new System.Drawing.Size(1324, 708);
            this.tabEarth.TabIndex = 0;
            this.tabEarth.Text = "Earth";
            this.tabEarth.UseVisualStyleBackColor = true;
            // 
            // ucPlanetBase1
            // 
            this.ucPlanetBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanetBase1.Location = new System.Drawing.Point(3, 3);
            this.ucPlanetBase1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPlanetBase1.Name = "ucPlanetBase1";
            this.ucPlanetBase1.Size = new System.Drawing.Size(1318, 702);
            this.ucPlanetBase1.TabIndex = 0;
            // 
            // tabMoon
            // 
            this.tabMoon.Controls.Add(this.ucPlanetBase2);
            this.tabMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMoon.Location = new System.Drawing.Point(4, 29);
            this.tabMoon.Name = "tabMoon";
            this.tabMoon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoon.Size = new System.Drawing.Size(1324, 708);
            this.tabMoon.TabIndex = 1;
            this.tabMoon.Text = "Moon";
            this.tabMoon.UseVisualStyleBackColor = true;
            // 
            // ucPlanetBase2
            // 
            this.ucPlanetBase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanetBase2.Location = new System.Drawing.Point(3, 3);
            this.ucPlanetBase2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucPlanetBase2.Name = "ucPlanetBase2";
            this.ucPlanetBase2.Size = new System.Drawing.Size(1318, 702);
            this.ucPlanetBase2.TabIndex = 2;
            // 
            // tabMars
            // 
            this.tabMars.Controls.Add(this.ucPlanetBase3);
            this.tabMars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMars.Location = new System.Drawing.Point(4, 29);
            this.tabMars.Name = "tabMars";
            this.tabMars.Padding = new System.Windows.Forms.Padding(3);
            this.tabMars.Size = new System.Drawing.Size(1324, 708);
            this.tabMars.TabIndex = 2;
            this.tabMars.Text = "Mars";
            this.tabMars.UseVisualStyleBackColor = true;
            // 
            // ucPlanetBase3
            // 
            this.ucPlanetBase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanetBase3.Location = new System.Drawing.Point(3, 3);
            this.ucPlanetBase3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPlanetBase3.Name = "ucPlanetBase3";
            this.ucPlanetBase3.Size = new System.Drawing.Size(1318, 702);
            this.ucPlanetBase3.TabIndex = 0;
            // 
            // tabEvent
            // 
            this.tabEvent.Controls.Add(this.ucPlanetBase4);
            this.tabEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEvent.Location = new System.Drawing.Point(4, 29);
            this.tabEvent.Name = "tabEvent";
            this.tabEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvent.Size = new System.Drawing.Size(947, 615);
            this.tabEvent.TabIndex = 3;
            this.tabEvent.Text = "Event";
            this.tabEvent.UseVisualStyleBackColor = true;
            // 
            // ucPlanetBase4
            // 
            this.ucPlanetBase4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlanetBase4.Location = new System.Drawing.Point(3, 3);
            this.ucPlanetBase4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPlanetBase4.Name = "ucPlanetBase4";
            this.ucPlanetBase4.Size = new System.Drawing.Size(941, 609);
            this.ucPlanetBase4.TabIndex = 0;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(955, 648);
            this.Controls.Add(this.tabPlanets);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(840, 480);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdVenture Capitalist Calculator/Simulator";
            this.tabPlanets.ResumeLayout(false);
            this.tabEarth.ResumeLayout(false);
            this.tabMoon.ResumeLayout(false);
            this.tabMars.ResumeLayout(false);
            this.tabEvent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPlanets;
        private System.Windows.Forms.TabPage tabEarth;
        private System.Windows.Forms.TabPage tabMoon;
        private System.Windows.Forms.TabPage tabMars;
        private System.Windows.Forms.TabPage tabEvent;
        private ucPlanetBase ucPlanetBase1;
        private ucPlanetBase ucPlanetBase2;
        private ucPlanetBase ucPlanetBase3;
        private ucPlanetBase ucPlanetBase4;
    }
}

