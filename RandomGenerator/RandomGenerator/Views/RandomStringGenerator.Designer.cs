namespace RandomGenerator.Views
{
    partial class ViewRandomStringGenerator
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
            this.MenuItemPickNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPickString = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSortList = new System.Windows.Forms.ToolStripMenuItem();
            this.btplus = new System.Windows.Forms.Button();
            this.btmoins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPickNumber,
            this.MenuItemPickString,
            this.MenuItemSortList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemPickNumber
            // 
            this.MenuItemPickNumber.Name = "MenuItemPickNumber";
            this.MenuItemPickNumber.Size = new System.Drawing.Size(104, 20);
            this.MenuItemPickNumber.Text = "Tirer un nombre";
            this.MenuItemPickNumber.Click += new System.EventHandler(this.MenuItemPickNumber_Click);
            // 
            // MenuItemPickString
            // 
            this.MenuItemPickString.Name = "MenuItemPickString";
            this.MenuItemPickString.Size = new System.Drawing.Size(103, 20);
            this.MenuItemPickString.Text = "Tirer une chaine";
            // 
            // MenuItemSortList
            // 
            this.MenuItemSortList.Name = "MenuItemSortList";
            this.MenuItemSortList.Size = new System.Drawing.Size(152, 20);
            this.MenuItemSortList.Text = "Trier une liste en aléatoire";
            // 
            // btplus
            // 
            this.btplus.Location = new System.Drawing.Point(59, 76);
            this.btplus.Name = "btplus";
            this.btplus.Size = new System.Drawing.Size(75, 23);
            this.btplus.TabIndex = 9;
            this.btplus.Text = "+";
            this.btplus.UseVisualStyleBackColor = true;
            this.btplus.Click += new System.EventHandler(this.btplus_Click);
            // 
            // btmoins
            // 
            this.btmoins.Location = new System.Drawing.Point(59, 145);
            this.btmoins.Name = "btmoins";
            this.btmoins.Size = new System.Drawing.Size(75, 23);
            this.btmoins.TabIndex = 10;
            this.btmoins.Text = "-";
            this.btmoins.UseVisualStyleBackColor = true;
            this.btmoins.Click += new System.EventHandler(this.btmoins_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // ViewRandomStringGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmoins);
            this.Controls.Add(this.btplus);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewRandomStringGenerator";
            this.Text = "RandomStringGenerator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPickNumber;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPickString;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSortList;
        private System.Windows.Forms.Button btplus;
        private System.Windows.Forms.Button btmoins;
        private System.Windows.Forms.Label label1;
    }
}