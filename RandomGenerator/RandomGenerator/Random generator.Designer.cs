namespace RandomGenerator
{
    partial class RandomGeneratorView
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borne basse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borne haute";
            // 
            // txtBotLimit
            // 
            this.txtBotLimit.Location = new System.Drawing.Point(86, 5);
            this.txtBotLimit.Name = "txtBotLimit";
            this.txtBotLimit.Size = new System.Drawing.Size(100, 20);
            this.txtBotLimit.TabIndex = 2;
            this.txtBotLimit.TextChanged += new System.EventHandler(this.txtBotLimit_TextChanged);
            // 
            // txtTopLimit
            // 
            this.txtTopLimit.Location = new System.Drawing.Point(86, 38);
            this.txtTopLimit.Name = "txtTopLimit";
            this.txtTopLimit.Size = new System.Drawing.Size(100, 20);
            this.txtTopLimit.TabIndex = 3;
            this.txtTopLimit.TextChanged += new System.EventHandler(this.txtTopLimit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultat";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(86, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(16, 124);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(170, 23);
            this.btGenerate.TabIndex = 6;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // RandomGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTopLimit);
            this.Controls.Add(this.txtBotLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RandomGeneratorView";
            this.Text = "Form1";
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
    }
}

