namespace imgRed
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ббинарныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ниблэкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глобальнаяГистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйШумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумГаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеШумаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.усреднениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PSNRlab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.SSIMlab = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.открытьToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.autoConToolStripMenuItem,
            this.ббинарныйToolStripMenuItem,
            this.шумыToolStripMenuItem,
            this.удалениеШумаToolStripMenuItem,
            this.сравнениеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // autoConToolStripMenuItem
            // 
            this.autoConToolStripMenuItem.Name = "autoConToolStripMenuItem";
            this.autoConToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoConToolStripMenuItem.Text = "AutoCon";
            this.autoConToolStripMenuItem.Click += new System.EventHandler(this.autoConToolStripMenuItem_Click);
            // 
            // ббинарныйToolStripMenuItem
            // 
            this.ббинарныйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.ниблэкToolStripMenuItem,
            this.глобальнаяГистограммаToolStripMenuItem});
            this.ббинарныйToolStripMenuItem.Name = "ббинарныйToolStripMenuItem";
            this.ббинарныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ббинарныйToolStripMenuItem.Text = "Бинарный";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // ниблэкToolStripMenuItem
            // 
            this.ниблэкToolStripMenuItem.Name = "ниблэкToolStripMenuItem";
            this.ниблэкToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ниблэкToolStripMenuItem.Text = "Ниблэк";
            this.ниблэкToolStripMenuItem.Click += new System.EventHandler(this.ниблэкToolStripMenuItem_Click_1);
            // 
            // глобальнаяГистограммаToolStripMenuItem
            // 
            this.глобальнаяГистограммаToolStripMenuItem.Name = "глобальнаяГистограммаToolStripMenuItem";
            this.глобальнаяГистограммаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.глобальнаяГистограммаToolStripMenuItem.Text = "Глобальная гистограмма";
            this.глобальнаяГистограммаToolStripMenuItem.Click += new System.EventHandler(this.глобальнаяГистограммаToolStripMenuItem_Click);
            // 
            // шумыToolStripMenuItem
            // 
            this.шумыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.белыйШумToolStripMenuItem,
            this.шумГаусаToolStripMenuItem});
            this.шумыToolStripMenuItem.Name = "шумыToolStripMenuItem";
            this.шумыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шумыToolStripMenuItem.Text = "Шумы";
            // 
            // белыйШумToolStripMenuItem
            // 
            this.белыйШумToolStripMenuItem.Name = "белыйШумToolStripMenuItem";
            this.белыйШумToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.белыйШумToolStripMenuItem.Text = "Белый шум";
            this.белыйШумToolStripMenuItem.Click += new System.EventHandler(this.белыйШумToolStripMenuItem_Click);
            // 
            // шумГаусаToolStripMenuItem
            // 
            this.шумГаусаToolStripMenuItem.Name = "шумГаусаToolStripMenuItem";
            this.шумГаусаToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.шумГаусаToolStripMenuItem.Text = "Шум Гауса";
            this.шумГаусаToolStripMenuItem.Click += new System.EventHandler(this.шумГаусаToolStripMenuItem_Click);
            // 
            // удалениеШумаToolStripMenuItem
            // 
            this.удалениеШумаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.усреднениеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem});
            this.удалениеШумаToolStripMenuItem.Name = "удалениеШумаToolStripMenuItem";
            this.удалениеШумаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалениеШумаToolStripMenuItem.Text = "Удаление шума";
            // 
            // усреднениеToolStripMenuItem
            // 
            this.усреднениеToolStripMenuItem.Name = "усреднениеToolStripMenuItem";
            this.усреднениеToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.усреднениеToolStripMenuItem.Text = "Усреднение";
            this.усреднениеToolStripMenuItem.Click += new System.EventHandler(this.усреднениеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // сравнениеToolStripMenuItem
            // 
            this.сравнениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pSNRToolStripMenuItem,
            this.sSIMToolStripMenuItem});
            this.сравнениеToolStripMenuItem.Name = "сравнениеToolStripMenuItem";
            this.сравнениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сравнениеToolStripMenuItem.Text = "Сравнение";
            // 
            // pSNRToolStripMenuItem
            // 
            this.pSNRToolStripMenuItem.Name = "pSNRToolStripMenuItem";
            this.pSNRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pSNRToolStripMenuItem.Text = "PSNR";
            this.pSNRToolStripMenuItem.Click += new System.EventHandler(this.pSNRToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 708);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PSNRlab
            // 
            this.PSNRlab.AutoSize = true;
            this.PSNRlab.Location = new System.Drawing.Point(373, 13);
            this.PSNRlab.Name = "PSNRlab";
            this.PSNRlab.Size = new System.Drawing.Size(0, 13);
            this.PSNRlab.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PSNR:";
            // 
            // sSIMToolStripMenuItem
            // 
            this.sSIMToolStripMenuItem.Name = "sSIMToolStripMenuItem";
            this.sSIMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sSIMToolStripMenuItem.Text = "SSIM";
            this.sSIMToolStripMenuItem.Click += new System.EventHandler(this.sSIMToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SSIM:";
            // 
            // SSIMlab
            // 
            this.SSIMlab.AutoSize = true;
            this.SSIMlab.Location = new System.Drawing.Point(510, 12);
            this.SSIMlab.Name = "SSIMlab";
            this.SSIMlab.Size = new System.Drawing.Size(0, 13);
            this.SSIMlab.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 783);
            this.Controls.Add(this.SSIMlab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PSNRlab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoConToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ббинарныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ниблэкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem глобальнаяГистограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйШумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумГаусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеШумаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem усреднениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pSNRToolStripMenuItem;
        private System.Windows.Forms.Label PSNRlab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sSIMToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SSIMlab;
    }
}

