namespace P3_3_1184018
{
    partial class Percobaan1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Percobaan1));
            this.LabelPercobaan1 = new System.Windows.Forms.Label();
            this.gbPercobaan1 = new System.Windows.Forms.GroupBox();
            this.rbMonitor = new System.Windows.Forms.RadioButton();
            this.rbKeyboard = new System.Windows.Forms.RadioButton();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.rbPrinter = new System.Windows.Forms.RadioButton();
            this.rbScanner = new System.Windows.Forms.RadioButton();
            this.tsGambar = new System.Windows.Forms.ToolStrip();
            this.tbsMouse = new System.Windows.Forms.ToolStripButton();
            this.tbMonitor = new System.Windows.Forms.ToolStripButton();
            this.tbPrinter = new System.Windows.Forms.ToolStripButton();
            this.tbKeyboard = new System.Windows.Forms.ToolStripButton();
            this.tbScanner = new System.Windows.Forms.ToolStripButton();
            this.tslKetGambar = new System.Windows.Forms.ToolStripLabel();
            this.gbPercobaan1.SuspendLayout();
            this.tsGambar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPercobaan1
            // 
            this.LabelPercobaan1.AutoSize = true;
            this.LabelPercobaan1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPercobaan1.Location = new System.Drawing.Point(12, 20);
            this.LabelPercobaan1.Name = "LabelPercobaan1";
            this.LabelPercobaan1.Size = new System.Drawing.Size(477, 18);
            this.LabelPercobaan1.TabIndex = 0;
            this.LabelPercobaan1.Text = "Pilih salah satu item berikut dan klik pada gambar yang sesuai!";
            // 
            // gbPercobaan1
            // 
            this.gbPercobaan1.Controls.Add(this.rbScanner);
            this.gbPercobaan1.Controls.Add(this.rbPrinter);
            this.gbPercobaan1.Controls.Add(this.rbMouse);
            this.gbPercobaan1.Controls.Add(this.rbKeyboard);
            this.gbPercobaan1.Controls.Add(this.rbMonitor);
            this.gbPercobaan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPercobaan1.Location = new System.Drawing.Point(45, 80);
            this.gbPercobaan1.Name = "gbPercobaan1";
            this.gbPercobaan1.Size = new System.Drawing.Size(175, 220);
            this.gbPercobaan1.TabIndex = 1;
            this.gbPercobaan1.TabStop = false;
            this.gbPercobaan1.Text = "Nama Gambar";
            // 
            // rbMonitor
            // 
            this.rbMonitor.AutoSize = true;
            this.rbMonitor.Location = new System.Drawing.Point(41, 33);
            this.rbMonitor.Name = "rbMonitor";
            this.rbMonitor.Size = new System.Drawing.Size(80, 22);
            this.rbMonitor.TabIndex = 0;
            this.rbMonitor.Text = "Monitor";
            this.rbMonitor.UseVisualStyleBackColor = true;
            // 
            // rbKeyboard
            // 
            this.rbKeyboard.AutoSize = true;
            this.rbKeyboard.Location = new System.Drawing.Point(41, 69);
            this.rbKeyboard.Name = "rbKeyboard";
            this.rbKeyboard.Size = new System.Drawing.Size(92, 22);
            this.rbKeyboard.TabIndex = 1;
            this.rbKeyboard.Text = "Keyboard";
            this.rbKeyboard.UseVisualStyleBackColor = true;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(41, 106);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(75, 22);
            this.rbMouse.TabIndex = 2;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            // 
            // rbPrinter
            // 
            this.rbPrinter.AutoSize = true;
            this.rbPrinter.Location = new System.Drawing.Point(41, 143);
            this.rbPrinter.Name = "rbPrinter";
            this.rbPrinter.Size = new System.Drawing.Size(72, 22);
            this.rbPrinter.TabIndex = 3;
            this.rbPrinter.Text = "Printer";
            this.rbPrinter.UseVisualStyleBackColor = true;
            // 
            // rbScanner
            // 
            this.rbScanner.AutoSize = true;
            this.rbScanner.Location = new System.Drawing.Point(41, 180);
            this.rbScanner.Name = "rbScanner";
            this.rbScanner.Size = new System.Drawing.Size(84, 22);
            this.rbScanner.TabIndex = 4;
            this.rbScanner.Text = "Scanner";
            this.rbScanner.UseVisualStyleBackColor = false;
            // 
            // tsGambar
            // 
            this.tsGambar.AutoSize = false;
            this.tsGambar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsGambar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGambar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsGambar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsMouse,
            this.tbMonitor,
            this.tbPrinter,
            this.tbKeyboard,
            this.tbScanner,
            this.tslKetGambar});
            this.tsGambar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsGambar.Location = new System.Drawing.Point(0, 328);
            this.tsGambar.Name = "tsGambar";
            this.tsGambar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsGambar.Size = new System.Drawing.Size(520, 623);
            this.tsGambar.TabIndex = 2;
            this.tsGambar.Text = "tsGambar";
            // 
            // tbsMouse
            // 
            this.tbsMouse.AutoSize = false;
            this.tbsMouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsMouse.Image = ((System.Drawing.Image)(resources.GetObject("tbsMouse.Image")));
            this.tbsMouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsMouse.Name = "tbsMouse";
            this.tbsMouse.Size = new System.Drawing.Size(60, 60);
            this.tbsMouse.Tag = "Mouse";
            this.tbsMouse.Text = "Mouse";
            this.tbsMouse.Click += new System.EventHandler(this.tbsMouse_Click);
            // 
            // tbMonitor
            // 
            this.tbMonitor.AutoSize = false;
            this.tbMonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMonitor.Image = ((System.Drawing.Image)(resources.GetObject("tbMonitor.Image")));
            this.tbMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Size = new System.Drawing.Size(60, 60);
            this.tbMonitor.Tag = "Monitor";
            this.tbMonitor.Text = "Monitor";
            this.tbMonitor.Click += new System.EventHandler(this.tbMonitor_Click);
            // 
            // tbPrinter
            // 
            this.tbPrinter.AutoSize = false;
            this.tbPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("tbPrinter.Image")));
            this.tbPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPrinter.Name = "tbPrinter";
            this.tbPrinter.Size = new System.Drawing.Size(60, 60);
            this.tbPrinter.Tag = "Printer";
            this.tbPrinter.Text = "Printer";
            this.tbPrinter.Click += new System.EventHandler(this.tbPrinter_Click);
            // 
            // tbKeyboard
            // 
            this.tbKeyboard.AutoSize = false;
            this.tbKeyboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("tbKeyboard.Image")));
            this.tbKeyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbKeyboard.Name = "tbKeyboard";
            this.tbKeyboard.Size = new System.Drawing.Size(60, 60);
            this.tbKeyboard.Tag = "Keyboard";
            this.tbKeyboard.Text = "Keyboard";
            this.tbKeyboard.Click += new System.EventHandler(this.tbKeyboard_Click);
            // 
            // tbScanner
            // 
            this.tbScanner.AutoSize = false;
            this.tbScanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbScanner.Image = ((System.Drawing.Image)(resources.GetObject("tbScanner.Image")));
            this.tbScanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbScanner.Name = "tbScanner";
            this.tbScanner.Size = new System.Drawing.Size(60, 60);
            this.tbScanner.Tag = "Scanner";
            this.tbScanner.Text = "Scanner";
            this.tbScanner.Click += new System.EventHandler(this.tbScanner_Click);
            // 
            // tslKetGambar
            // 
            this.tslKetGambar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tslKetGambar.ForeColor = System.Drawing.Color.Red;
            this.tslKetGambar.Name = "tslKetGambar";
            this.tslKetGambar.Size = new System.Drawing.Size(496, 0);
            this.tslKetGambar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Percobaan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 951);
            this.Controls.Add(this.tsGambar);
            this.Controls.Add(this.gbPercobaan1);
            this.Controls.Add(this.LabelPercobaan1);
            this.Name = "Percobaan1";
            this.Text = "Percobaan1";
            this.gbPercobaan1.ResumeLayout(false);
            this.gbPercobaan1.PerformLayout();
            this.tsGambar.ResumeLayout(false);
            this.tsGambar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPercobaan1;
        private System.Windows.Forms.GroupBox gbPercobaan1;
        private System.Windows.Forms.RadioButton rbScanner;
        private System.Windows.Forms.RadioButton rbPrinter;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.RadioButton rbKeyboard;
        private System.Windows.Forms.RadioButton rbMonitor;
        private System.Windows.Forms.ToolStrip tsGambar;
        private System.Windows.Forms.ToolStripButton tbsMouse;
        private System.Windows.Forms.ToolStripButton tbMonitor;
        private System.Windows.Forms.ToolStripButton tbPrinter;
        private System.Windows.Forms.ToolStripButton tbKeyboard;
        private System.Windows.Forms.ToolStripButton tbScanner;
        private System.Windows.Forms.ToolStripLabel tslKetGambar;
    }
}

