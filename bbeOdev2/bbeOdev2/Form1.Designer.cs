namespace bbeOdev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.grpBilgiler = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.mskTxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTek = new System.Windows.Forms.TabPage();
            this.listViewTek = new System.Windows.Forms.ListView();
            this.tabPageCift = new System.Windows.Forms.TabPage();
            this.listViewCift = new System.Windows.Forms.ListView();
            this.tabPageAsal = new System.Windows.Forms.TabPage();
            this.listViewAsal = new System.Windows.Forms.ListView();
            this.tabPageArmstrong = new System.Windows.Forms.TabPage();
            this.listViewArmstrong = new System.Windows.Forms.ListView();
            this.btnListeTemizle = new System.Windows.Forms.Button();
            this.grpBilgiler.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTek.SuspendLayout();
            this.tabPageCift.SuspendLayout();
            this.tabPageAsal.SuspendLayout();
            this.tabPageArmstrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(6, 22);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(53, 13);
            this.lblBaslangic.TabIndex = 5;
            this.lblBaslangic.Text = "Başlangıç";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(6, 46);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(26, 13);
            this.lblBitis.TabIndex = 6;
            this.lblBitis.Text = "Bitiş";
            // 
            // grpBilgiler
            // 
            this.grpBilgiler.Controls.Add(this.btnHesapla);
            this.grpBilgiler.Controls.Add(this.btnİleri);
            this.grpBilgiler.Controls.Add(this.btnGeri);
            this.grpBilgiler.Controls.Add(this.btnTemizle);
            this.grpBilgiler.Controls.Add(this.mskTxtBitis);
            this.grpBilgiler.Controls.Add(this.mskTxtBaslangic);
            this.grpBilgiler.Controls.Add(this.lblBitis);
            this.grpBilgiler.Controls.Add(this.lblBaslangic);
            this.grpBilgiler.Location = new System.Drawing.Point(12, 12);
            this.grpBilgiler.Name = "grpBilgiler";
            this.grpBilgiler.Size = new System.Drawing.Size(652, 90);
            this.grpBilgiler.TabIndex = 15;
            this.grpBilgiler.TabStop = false;
            this.grpBilgiler.Text = "Bilgiler";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(244, 13);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(84, 23);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnİleri.Location = new System.Drawing.Point(461, 36);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 23);
            this.btnİleri.TabIndex = 6;
            this.btnİleri.Text = "İleri";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGeri.Location = new System.Drawing.Point(380, 36);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(244, 41);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(84, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // mskTxtBitis
            // 
            this.mskTxtBitis.Location = new System.Drawing.Point(90, 43);
            this.mskTxtBitis.Mask = "000000";
            this.mskTxtBitis.Name = "mskTxtBitis";
            this.mskTxtBitis.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBitis.TabIndex = 2;
            // 
            // mskTxtBaslangic
            // 
            this.mskTxtBaslangic.Location = new System.Drawing.Point(90, 15);
            this.mskTxtBaslangic.Mask = "000000";
            this.mskTxtBaslangic.Name = "mskTxtBaslangic";
            this.mskTxtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBaslangic.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPageTek);
            this.tabControl1.Controls.Add(this.tabPageCift);
            this.tabControl1.Controls.Add(this.tabPageAsal);
            this.tabControl1.Controls.Add(this.tabPageArmstrong);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 288);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Tag = "";
            // 
            // tabPageTek
            // 
            this.tabPageTek.Controls.Add(this.listViewTek);
            this.tabPageTek.Location = new System.Drawing.Point(4, 25);
            this.tabPageTek.Name = "tabPageTek";
            this.tabPageTek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTek.Size = new System.Drawing.Size(772, 259);
            this.tabPageTek.TabIndex = 0;
            this.tabPageTek.Text = "Tek Sayılar";
            this.tabPageTek.UseVisualStyleBackColor = true;
            // 
            // listViewTek
            // 
            this.listViewTek.HideSelection = false;
            this.listViewTek.Location = new System.Drawing.Point(0, 0);
            this.listViewTek.Name = "listViewTek";
            this.listViewTek.Size = new System.Drawing.Size(772, 277);
            this.listViewTek.TabIndex = 25;
            this.listViewTek.UseCompatibleStateImageBehavior = false;
            this.listViewTek.View = System.Windows.Forms.View.List;
            // 
            // tabPageCift
            // 
            this.tabPageCift.Controls.Add(this.listViewCift);
            this.tabPageCift.Location = new System.Drawing.Point(4, 25);
            this.tabPageCift.Name = "tabPageCift";
            this.tabPageCift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCift.Size = new System.Drawing.Size(772, 259);
            this.tabPageCift.TabIndex = 1;
            this.tabPageCift.Text = "Çift Sayılar";
            this.tabPageCift.UseVisualStyleBackColor = true;
            // 
            // listViewCift
            // 
            this.listViewCift.HideSelection = false;
            this.listViewCift.Location = new System.Drawing.Point(0, 0);
            this.listViewCift.Name = "listViewCift";
            this.listViewCift.Size = new System.Drawing.Size(772, 277);
            this.listViewCift.TabIndex = 1;
            this.listViewCift.UseCompatibleStateImageBehavior = false;
            this.listViewCift.View = System.Windows.Forms.View.List;
            // 
            // tabPageAsal
            // 
            this.tabPageAsal.Controls.Add(this.listViewAsal);
            this.tabPageAsal.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsal.Name = "tabPageAsal";
            this.tabPageAsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsal.Size = new System.Drawing.Size(772, 259);
            this.tabPageAsal.TabIndex = 2;
            this.tabPageAsal.Text = "Asal Sayılar";
            this.tabPageAsal.UseVisualStyleBackColor = true;
            // 
            // listViewAsal
            // 
            this.listViewAsal.HideSelection = false;
            this.listViewAsal.Location = new System.Drawing.Point(0, 0);
            this.listViewAsal.Name = "listViewAsal";
            this.listViewAsal.Size = new System.Drawing.Size(772, 277);
            this.listViewAsal.TabIndex = 1;
            this.listViewAsal.UseCompatibleStateImageBehavior = false;
            this.listViewAsal.View = System.Windows.Forms.View.List;
            // 
            // tabPageArmstrong
            // 
            this.tabPageArmstrong.Controls.Add(this.listViewArmstrong);
            this.tabPageArmstrong.Location = new System.Drawing.Point(4, 25);
            this.tabPageArmstrong.Name = "tabPageArmstrong";
            this.tabPageArmstrong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArmstrong.Size = new System.Drawing.Size(772, 259);
            this.tabPageArmstrong.TabIndex = 3;
            this.tabPageArmstrong.Text = "Armstrong Sayıları";
            this.tabPageArmstrong.UseVisualStyleBackColor = true;
            // 
            // listViewArmstrong
            // 
            this.listViewArmstrong.HideSelection = false;
            this.listViewArmstrong.Location = new System.Drawing.Point(0, 0);
            this.listViewArmstrong.Name = "listViewArmstrong";
            this.listViewArmstrong.Size = new System.Drawing.Size(772, 277);
            this.listViewArmstrong.TabIndex = 1;
            this.listViewArmstrong.UseCompatibleStateImageBehavior = false;
            this.listViewArmstrong.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnListeTemizle
            // 
            this.btnListeTemizle.Location = new System.Drawing.Point(674, 125);
            this.btnListeTemizle.Name = "btnListeTemizle";
            this.btnListeTemizle.Size = new System.Drawing.Size(118, 23);
            this.btnListeTemizle.TabIndex = 11;
            this.btnListeTemizle.Text = "Listeyi Temizle";
            this.btnListeTemizle.UseVisualStyleBackColor = true;
            this.btnListeTemizle.Click += new System.EventHandler(this.btnListeTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 429);
            this.Controls.Add(this.btnListeTemizle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBilgiler);
            this.Name = "Form1";
            this.Text = "Odev2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBilgiler.ResumeLayout(false);
            this.grpBilgiler.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTek.ResumeLayout(false);
            this.tabPageCift.ResumeLayout(false);
            this.tabPageAsal.ResumeLayout(false);
            this.tabPageArmstrong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.MaskedTextBox mskTxtBitis;
        private System.Windows.Forms.MaskedTextBox mskTxtBaslangic;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTek;
        private System.Windows.Forms.TabPage tabPageCift;
        private System.Windows.Forms.TabPage tabPageAsal;
        private System.Windows.Forms.TabPage tabPageArmstrong;
        private System.Windows.Forms.ListView listViewTek;
        private System.Windows.Forms.ListView listViewCift;
        private System.Windows.Forms.ListView listViewAsal;
        private System.Windows.Forms.ListView listViewArmstrong;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnListeTemizle;
    }
}

