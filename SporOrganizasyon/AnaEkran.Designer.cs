namespace SporOrganizasyon
{
    partial class AnaEkran
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
            this.labelGiris = new System.Windows.Forms.Label();
            this.buttonEtkinlik = new System.Windows.Forms.Button();
            this.buttonKatil = new System.Windows.Forms.Button();
            this.buttonMekan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGiris
            // 
            this.labelGiris.AutoSize = true;
            this.labelGiris.Location = new System.Drawing.Point(3, 13);
            this.labelGiris.Name = "labelGiris";
            this.labelGiris.Size = new System.Drawing.Size(54, 13);
            this.labelGiris.TabIndex = 3;
            this.labelGiris.Text = "Hosgeldin";
            // 
            // buttonEtkinlik
            // 
            this.buttonEtkinlik.Location = new System.Drawing.Point(12, 119);
            this.buttonEtkinlik.Name = "buttonEtkinlik";
            this.buttonEtkinlik.Size = new System.Drawing.Size(145, 23);
            this.buttonEtkinlik.TabIndex = 4;
            this.buttonEtkinlik.Text = "Etkinlikler";
            this.buttonEtkinlik.UseVisualStyleBackColor = true;
            this.buttonEtkinlik.Click += new System.EventHandler(this.buttonEtkinlik_Click);
            // 
            // buttonKatil
            // 
            this.buttonKatil.Location = new System.Drawing.Point(366, 119);
            this.buttonKatil.Name = "buttonKatil";
            this.buttonKatil.Size = new System.Drawing.Size(145, 23);
            this.buttonKatil.TabIndex = 5;
            this.buttonKatil.Text = "Katıl";
            this.buttonKatil.UseVisualStyleBackColor = true;
            this.buttonKatil.Click += new System.EventHandler(this.buttonKatil_Click);
            // 
            // buttonMekan
            // 
            this.buttonMekan.Location = new System.Drawing.Point(740, 119);
            this.buttonMekan.Name = "buttonMekan";
            this.buttonMekan.Size = new System.Drawing.Size(145, 23);
            this.buttonMekan.TabIndex = 6;
            this.buttonMekan.Text = "Mekan Ekle";
            this.buttonMekan.UseVisualStyleBackColor = true;
            this.buttonMekan.Click += new System.EventHandler(this.buttonMekan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 277);
            this.dataGridView1.TabIndex = 8;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMekan);
            this.Controls.Add(this.buttonKatil);
            this.Controls.Add(this.buttonEtkinlik);
            this.Controls.Add(this.labelGiris);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaEkran_FormClosed);
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGiris;
        private System.Windows.Forms.Button buttonEtkinlik;
        private System.Windows.Forms.Button buttonKatil;
        private System.Windows.Forms.Button buttonMekan;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}