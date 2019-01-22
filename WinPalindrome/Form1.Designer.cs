namespace WinPalindrome
{
    partial class Form1
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
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.LstAll = new System.Windows.Forms.ListBox();
            this.LstPalindrome = new System.Windows.Forms.ListBox();
            this.LstNotPalindrome = new System.Windows.Forms.ListBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(29, 33);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(198, 23);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Lire Fichier Palindrome";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // LstAll
            // 
            this.LstAll.FormattingEnabled = true;
            this.LstAll.Location = new System.Drawing.Point(29, 77);
            this.LstAll.Name = "LstAll";
            this.LstAll.Size = new System.Drawing.Size(198, 355);
            this.LstAll.TabIndex = 1;
            // 
            // LstPalindrome
            // 
            this.LstPalindrome.FormattingEnabled = true;
            this.LstPalindrome.Location = new System.Drawing.Point(442, 77);
            this.LstPalindrome.Name = "LstPalindrome";
            this.LstPalindrome.Size = new System.Drawing.Size(150, 355);
            this.LstPalindrome.TabIndex = 2;
            // 
            // LstNotPalindrome
            // 
            this.LstNotPalindrome.FormattingEnabled = true;
            this.LstNotPalindrome.Location = new System.Drawing.Point(631, 77);
            this.LstNotPalindrome.Name = "LstNotPalindrome";
            this.LstNotPalindrome.Size = new System.Drawing.Size(143, 355);
            this.LstNotPalindrome.TabIndex = 3;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(252, 193);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(159, 49);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Filtrer les Palindromes";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.LstNotPalindrome);
            this.Controls.Add(this.LstPalindrome);
            this.Controls.Add(this.LstAll);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReadFile;
        private System.Windows.Forms.ListBox LstAll;
        private System.Windows.Forms.ListBox LstPalindrome;
        private System.Windows.Forms.ListBox LstNotPalindrome;
        private System.Windows.Forms.Button BtnFilter;
    }
}

