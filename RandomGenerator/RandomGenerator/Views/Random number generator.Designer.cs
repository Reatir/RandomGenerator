namespace RandomGenerator
{
    partial class RandomNumberGeneratorView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBotLimit = new System.Windows.Forms.TextBox();
            this.txtTopLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemPickNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPickString = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSortList = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelListResult = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borne basse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borne haute";
            // 
            // txtBotLimit
            // 
            this.txtBotLimit.Location = new System.Drawing.Point(98, 56);
            this.txtBotLimit.Name = "txtBotLimit";
            this.txtBotLimit.Size = new System.Drawing.Size(100, 20);
            this.txtBotLimit.TabIndex = 2;
            this.txtBotLimit.TextChanged += new System.EventHandler(this.txtBotLimit_TextChanged);
            // 
            // txtTopLimit
            // 
            this.txtTopLimit.Location = new System.Drawing.Point(98, 89);
            this.txtTopLimit.Name = "txtTopLimit";
            this.txtTopLimit.Size = new System.Drawing.Size(100, 20);
            this.txtTopLimit.TabIndex = 3;
            this.txtTopLimit.TextChanged += new System.EventHandler(this.txtTopLimit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultat";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(98, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(28, 175);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(170, 23);
            this.btGenerate.TabIndex = 6;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
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
            this.menuStrip1.TabIndex = 7;
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
            this.MenuItemPickString.Click += new System.EventHandler(this.MenuItemPickString_Click);
            // 
            // MenuItemSortList
            // 
            this.MenuItemSortList.Name = "MenuItemSortList";
            this.MenuItemSortList.Size = new System.Drawing.Size(152, 20);
            this.MenuItemSortList.Text = "Trier une liste en aléatoire";
            this.MenuItemSortList.Click += new System.EventHandler(this.MenuItemSortList_Click);
            // 
            // PanelListResult
            // 
            this.PanelListResult.AutoScroll = true;
            this.PanelListResult.Location = new System.Drawing.Point(588, 27);
            this.PanelListResult.Name = "PanelListResult";
            this.PanelListResult.Size = new System.Drawing.Size(200, 411);
            this.PanelListResult.TabIndex = 8;
            // 
            // RandomNumberGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelListResult);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTopLimit);
            this.Controls.Add(this.txtBotLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RandomNumberGeneratorView";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBotLimit;
        private System.Windows.Forms.TextBox txtTopLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPickNumber;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPickString;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSortList;
        private System.Windows.Forms.FlowLayoutPanel PanelListResult;
    }
}

