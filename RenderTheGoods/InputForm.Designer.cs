namespace RenderTheGoods
{
    partial class InputForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumberofRectangles = new System.Windows.Forms.Label();
            this.nudNumofRectangles = new System.Windows.Forms.NumericUpDown();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlDisplayOutput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumofRectangles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberofRectangles
            // 
            this.lblNumberofRectangles.AutoSize = true;
            this.lblNumberofRectangles.Location = new System.Drawing.Point(611, 44);
            this.lblNumberofRectangles.Name = "lblNumberofRectangles";
            this.lblNumberofRectangles.Size = new System.Drawing.Size(197, 20);
            this.lblNumberofRectangles.TabIndex = 0;
            this.lblNumberofRectangles.Text = "Enter Number Of Rectangles";
            // 
            // nudNumofRectangles
            // 
            this.nudNumofRectangles.Location = new System.Drawing.Point(670, 67);
            this.nudNumofRectangles.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumofRectangles.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNumofRectangles.Name = "nudNumofRectangles";
            this.nudNumofRectangles.Size = new System.Drawing.Size(79, 27);
            this.nudNumofRectangles.TabIndex = 1;
            this.nudNumofRectangles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumofRectangles.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(647, 100);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 42);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Submit";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplay.Location = new System.Drawing.Point(12, 215);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(695, 345);
            this.pnlDisplay.TabIndex = 3;
            this.pnlDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDisplay_Paint);
            // 
            // pnlDisplayOutput
            // 
            this.pnlDisplayOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplayOutput.Location = new System.Drawing.Point(713, 215);
            this.pnlDisplayOutput.Name = "pnlDisplayOutput";
            this.pnlDisplayOutput.Size = new System.Drawing.Size(695, 345);
            this.pnlDisplayOutput.TabIndex = 4;
            this.pnlDisplayOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDisplayOutput_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input Based Rectangles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Based Rectangles";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDisplayOutput);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.nudNumofRectangles);
            this.Controls.Add(this.lblNumberofRectangles);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Rectangles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Enter += new System.EventHandler(this.btnEnter_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumofRectangles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumberofRectangles;
        private NumericUpDown nudNumofRectangles;
        private Button btnEnter;
        private Panel pnlDisplay;
        private Panel pnlDisplayOutput;
        private Label label1;
        private Label label2;
    }
}