namespace readtext
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            vidéoToolStripMenuItem = new ToolStripMenuItem();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            apiToolStripMenuItem = new ToolStripMenuItem();
            newsToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 24);
            button1.Name = "button1";
            button1.Size = new Size(1469, 23);
            button1.TabIndex = 1;
            button1.Text = "Ajouter un document";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1469, 749);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { vidéoToolStripMenuItem, applicationToolStripMenuItem, modifierToolStripMenuItem, apiToolStripMenuItem, newsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1469, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // vidéoToolStripMenuItem
            // 
            vidéoToolStripMenuItem.Name = "vidéoToolStripMenuItem";
            vidéoToolStripMenuItem.Size = new Size(49, 20);
            vidéoToolStripMenuItem.Text = "Vidéo";
            vidéoToolStripMenuItem.Click += vidéoToolStripMenuItem_Click;
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(80, 20);
            applicationToolStripMenuItem.Text = "Application";
            applicationToolStripMenuItem.Click += applicationToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(64, 20);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // apiToolStripMenuItem
            // 
            apiToolStripMenuItem.Name = "apiToolStripMenuItem";
            apiToolStripMenuItem.Size = new Size(37, 20);
            apiToolStripMenuItem.Text = "Api";
            apiToolStripMenuItem.Click += apiToolStripMenuItem_Click;
            // 
            // newsToolStripMenuItem
            // 
            newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            newsToolStripMenuItem.Size = new Size(48, 20);
            newsToolStripMenuItem.Text = "News";
            newsToolStripMenuItem.Click += newsToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 781);
            label1.MaximumSize = new Size(0, 900);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 4;
            label1.Text = "En attente de document....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 796);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Ajout d'un document";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem vidéoToolStripMenuItem;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem apiToolStripMenuItem;
        private ToolStripMenuItem newsToolStripMenuItem;
    }
}
