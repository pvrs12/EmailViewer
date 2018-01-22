namespace EmailViewer
{
    partial class FrmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMailBody = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiles = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDump = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            //this.txtMail = new ScintillaNET.Scintilla();
            this.txtMail = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.toolStripSeparator1,
            this.btnMailBody,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.btnFiles,
            this.toolStripSeparator4,
            this.btnDump,
            this.toolStripSeparator2,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 22);
            this.btnOpen.Text = "&Open";
            this.btnOpen.ToolTipText = "Choose a .msg file";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMailBody
            // 
            this.btnMailBody.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMailBody.Image = ((System.Drawing.Image)(resources.GetObject("btnMailBody.Image")));
            this.btnMailBody.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMailBody.Name = "btnMailBody";
            this.btnMailBody.Size = new System.Drawing.Size(34, 22);
            this.btnMailBody.Text = "Mail";
            this.btnMailBody.ToolTipText = "view the content of the Mail";
            this.btnMailBody.Click += new System.EventHandler(this.btnMailBody_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFiles
            // 
            this.btnFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnFiles.Image")));
            this.btnFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(88, 22);
            this.btnFiles.Text = "Attachments";
            this.btnFiles.ToolTipText = "view the Attachment(plain text only)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDump
            // 
            this.btnDump.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDump.ForeColor = System.Drawing.Color.Maroon;
            this.btnDump.Image = ((System.Drawing.Image)(resources.GetObject("btnDump.Image")));
            this.btnDump.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(132, 22);
            this.btnDump.Text = "Save Attatchments As..";
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(44, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtMail
            // 
            this.txtMail.AllowDrop = true;
            this.txtMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMail.Location = new System.Drawing.Point(0, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(693, 493);
            this.txtMail.TabIndex = 1;
            //this.txtMail.UseTabs = false;
            //this.txtMail.WrapVisualFlagLocation = ScintillaNET.WrapVisualFlagLocation.EndByText;
            //this.txtMail.WrapVisualFlags = ((ScintillaNET.WrapVisualFlags)(((ScintillaNET.WrapVisualFlags.End | ScintillaNET.WrapVisualFlags.Start) 
            //| ScintillaNET.WrapVisualFlags.Margin)));
            //this.txtMail.StyleNeeded += new System.EventHandler<ScintillaNET.StyleNeededEventArgs>(this.txtMail_StyleNeeded);
            this.txtMail.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMail_DragDrop);
            this.txtMail.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtMail_DragEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 19);
            this.lblStatus.Text = "-";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "msg";
            this.openFileDialog1.Filter = "Msg files (*.msg)|*.msg|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Please choose msg file from outlook";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Metadata";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 542);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain2";
            this.Text = "EmailViewer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.RichTextBox txtMail;
        //private Scintilla txtMail;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btnFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnMailBody;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDump;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

