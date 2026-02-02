namespace CleanSlate
{
    partial class CleanSlate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanSlate));
            richTextBoxMain = new RichTextBox();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            comboBox1 = new ComboBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxMain
            // 
            richTextBoxMain.BackColor = Color.SandyBrown;
            richTextBoxMain.Font = new Font("Script MT Bold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBoxMain.Location = new Point(236, 12);
            richTextBoxMain.Margin = new Padding(4, 3, 4, 3);
            richTextBoxMain.Name = "richTextBoxMain";
            richTextBoxMain.Size = new Size(852, 365);
            richTextBoxMain.TabIndex = 0;
            richTextBoxMain.Text = "";
            richTextBoxMain.TextChanged += richTextBox1_TextChanged;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(184, 26);
            toolStripMenuItem1.Text = "Save progress";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.IndianRed;
            statusStrip1.BackgroundImageLayout = ImageLayout.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 379);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1501, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "This is TBD";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Perpetua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Edit", "Undo", "Redo", "Save As", "Print" });
            comboBox1.Location = new Point(0, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "File";
            comboBox1.ClientSizeChanged += richTextBox1_TextChanged;
            comboBox1.ContextMenuStripChanged += richTextBox1_TextChanged;
            comboBox1.Click += CleanSlate_Load_1;
            // 
            // CleanSlate
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1501, 405);
            Controls.Add(comboBox1);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBoxMain);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CleanSlate";
            Text = "CleanSlate";
            Load += CleanSlate_Load_1;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxMain;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ComboBox comboBox1;
    }
}
