namespace Zadatak02
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
            this.components = new System.ComponentModel.Container();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.teskeBoje = new System.Windows.Forms.ColorDialog();
            this.opcijeDesnogKlika = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.odaberiBojuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poništiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeDesnogKlika.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(528, 268);
            this.flp.TabIndex = 0;
            // 
            // opcijeDesnogKlika
            // 
            this.opcijeDesnogKlika.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaberiBojuToolStripMenuItem,
            this.poništiToolStripMenuItem});
            this.opcijeDesnogKlika.Name = "opcijeDesnogKlika";
            this.opcijeDesnogKlika.Size = new System.Drawing.Size(181, 70);
            // 
            // odaberiBojuToolStripMenuItem
            // 
            this.odaberiBojuToolStripMenuItem.Name = "odaberiBojuToolStripMenuItem";
            this.odaberiBojuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odaberiBojuToolStripMenuItem.Text = "Odaberi boju";
            this.odaberiBojuToolStripMenuItem.Click += new System.EventHandler(this.odaberiBojuToolStripMenuItem_Click);
            // 
            // poništiToolStripMenuItem
            // 
            this.poništiToolStripMenuItem.Name = "poništiToolStripMenuItem";
            this.poništiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poništiToolStripMenuItem.Text = "Poništi";
            this.poništiToolStripMenuItem.Click += new System.EventHandler(this.poništiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 268);
            this.Controls.Add(this.flp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.opcijeDesnogKlika.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.ColorDialog teskeBoje;
        private System.Windows.Forms.ContextMenuStrip opcijeDesnogKlika;
        private System.Windows.Forms.ToolStripMenuItem odaberiBojuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poništiToolStripMenuItem;
    }
}

