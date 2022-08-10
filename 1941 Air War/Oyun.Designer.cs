namespace DogukanBaser
{
    partial class oyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyun));
            this.txtskor = new System.Windows.Forms.Label();
            this.oyunsüresi = new System.Windows.Forms.Timer(this.components);
            this.mermi = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.dusman3 = new System.Windows.Forms.PictureBox();
            this.dusman2 = new System.Windows.Forms.PictureBox();
            this.dusman1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtskor
            // 
            this.txtskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtskor.Location = new System.Drawing.Point(55, 192);
            this.txtskor.Name = "txtskor";
            this.txtskor.Size = new System.Drawing.Size(689, 264);
            this.txtskor.TabIndex = 5;
            this.txtskor.Text = "0";
            this.txtskor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyunsüresi
            // 
            this.oyunsüresi.Interval = 30;
            this.oyunsüresi.Tick += new System.EventHandler(this.oyunsüresiolayı);
            // 
            // mermi
            // 
            this.mermi.Image = global::DogukanBaser.Properties.Resources.bullet;
            this.mermi.Location = new System.Drawing.Point(396, 472);
            this.mermi.Name = "mermi";
            this.mermi.Size = new System.Drawing.Size(7, 27);
            this.mermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mermi.TabIndex = 4;
            this.mermi.TabStop = false;
            this.mermi.Click += new System.EventHandler(this.mermi_Click);
            // 
            // player
            // 
            this.player.Image = global::DogukanBaser.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(345, 505);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // dusman3
            // 
            this.dusman3.Image = global::DogukanBaser.Properties.Resources.enemy;
            this.dusman3.Location = new System.Drawing.Point(644, 53);
            this.dusman3.Name = "dusman3";
            this.dusman3.Size = new System.Drawing.Size(100, 85);
            this.dusman3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dusman3.TabIndex = 2;
            this.dusman3.TabStop = false;
            // 
            // dusman2
            // 
            this.dusman2.Image = global::DogukanBaser.Properties.Resources.enemy;
            this.dusman2.Location = new System.Drawing.Point(355, 53);
            this.dusman2.Name = "dusman2";
            this.dusman2.Size = new System.Drawing.Size(100, 85);
            this.dusman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dusman2.TabIndex = 1;
            this.dusman2.TabStop = false;
            this.dusman2.Click += new System.EventHandler(this.dusman2_Click);
            // 
            // dusman1
            // 
            this.dusman1.Image = global::DogukanBaser.Properties.Resources.enemy;
            this.dusman1.Location = new System.Drawing.Point(55, 53);
            this.dusman1.Name = "dusman1";
            this.dusman1.Size = new System.Drawing.Size(100, 85);
            this.dusman1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dusman1.TabIndex = 0;
            this.dusman1.TabStop = false;
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(140)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(808, 687);
            this.Controls.Add(this.mermi);
            this.Controls.Add(this.player);
            this.Controls.Add(this.dusman3);
            this.Controls.Add(this.dusman2);
            this.Controls.Add(this.dusman1);
            this.Controls.Add(this.txtskor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "oyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "1941 Air War";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keysup);
            ((System.ComponentModel.ISupportInitialize)(this.mermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusman1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dusman1;
        private System.Windows.Forms.PictureBox dusman2;
        private System.Windows.Forms.PictureBox dusman3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox mermi;
        private System.Windows.Forms.Label txtskor;
        private System.Windows.Forms.Timer oyunsüresi;
    }
}

