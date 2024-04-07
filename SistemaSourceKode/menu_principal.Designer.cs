
namespace SistemaSourceKode
{
    partial class menu_principal
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
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadstroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadstroToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(55, 20);
            this.menu1.Text = "Admin";
            // 
            // menu2
            // 
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(69, 20);
            this.menu2.Text = "Operador";
            // 
            // cadstroToolStripMenuItem
            // 
            this.cadstroToolStripMenuItem.Name = "cadstroToolStripMenuItem";
            this.cadstroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadstroToolStripMenuItem.Text = "Cadstro";
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menu1;
        public System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem cadstroToolStripMenuItem;
    }
}