namespace Gewinnspiel.Forms
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gewinnspielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearebeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einemGewinnpielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gewinnspielToolStripMenuItem,
            this.teilnehmerToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(781, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gewinnspielToolStripMenuItem
            // 
            this.gewinnspielToolStripMenuItem.Name = "gewinnspielToolStripMenuItem";
            this.gewinnspielToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.gewinnspielToolStripMenuItem.Text = "Gewinnspiel";
            // 
            // teilnehmerToolStripMenuItem
            // 
            this.teilnehmerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerlisteToolStripMenuItem,
            this.hinzufügenToolStripMenuItem,
            this.bearebeitenToolStripMenuItem,
            this.deaktivierenToolStripMenuItem,
            this.einemGewinnpielHinzufügenToolStripMenuItem});
            this.teilnehmerToolStripMenuItem.Name = "teilnehmerToolStripMenuItem";
            this.teilnehmerToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.teilnehmerToolStripMenuItem.Text = "Teilnehmer";
            // 
            // teilnehmerlisteToolStripMenuItem
            // 
            this.teilnehmerlisteToolStripMenuItem.Name = "teilnehmerlisteToolStripMenuItem";
            this.teilnehmerlisteToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.teilnehmerlisteToolStripMenuItem.Text = "Teilnehmerliste";
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            // 
            // bearebeitenToolStripMenuItem
            // 
            this.bearebeitenToolStripMenuItem.Name = "bearebeitenToolStripMenuItem";
            this.bearebeitenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.bearebeitenToolStripMenuItem.Text = "Bearebeiten";
            // 
            // deaktivierenToolStripMenuItem
            // 
            this.deaktivierenToolStripMenuItem.Name = "deaktivierenToolStripMenuItem";
            this.deaktivierenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.deaktivierenToolStripMenuItem.Text = "De/aktivieren";
            // 
            // einemGewinnpielHinzufügenToolStripMenuItem
            // 
            this.einemGewinnpielHinzufügenToolStripMenuItem.Name = "einemGewinnpielHinzufügenToolStripMenuItem";
            this.einemGewinnpielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.einemGewinnpielHinzufügenToolStripMenuItem.Text = "einem Gewinnpiel hinzufügen";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 389);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gewinnspielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearebeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einemGewinnpielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}