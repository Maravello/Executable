namespace Executable
{
    partial class RécupererUneListeJson
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            enregistréDansUnFichierToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip2 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 156);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1435, 438);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(230, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(998, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(552, 56);
            label1.Name = "label1";
            label1.Size = new Size(356, 19);
            label1.TabIndex = 2;
            label1.Text = "Veuillez insérer une route API  pour afficher le contenus";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(706, 134);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 3;
            label2.Text = "Contenu";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Right;
            menuStrip1.Items.AddRange(new ToolStripItem[] { enregistréDansUnFichierToolStripMenuItem });
            menuStrip1.Location = new Point(1435, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(81, 570);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // enregistréDansUnFichierToolStripMenuItem
            // 
            enregistréDansUnFichierToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            enregistréDansUnFichierToolStripMenuItem.Name = "enregistréDansUnFichierToolStripMenuItem";
            enregistréDansUnFichierToolStripMenuItem.Size = new Size(68, 19);
            enregistréDansUnFichierToolStripMenuItem.Text = "Enregistrer";
            enregistréDansUnFichierToolStripMenuItem.Click += enregistréDansUnFichierToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1234, 84);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 5;
            button1.Text = "Récuprer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1516, 24);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // RécupererUneListeJson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 594);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "RécupererUneListeJson";
            Text = "RécupererUneListeJson";
            Load += RécupererUneListeJson_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem enregistréDansUnFichierToolStripMenuItem;
        private Button button1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}