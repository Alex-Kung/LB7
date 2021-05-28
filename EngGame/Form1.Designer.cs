namespace EngGame
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
            this.Ruseng = new System.Windows.Forms.Button();
            this.Engrus = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.Label();
            this.transword = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.pts = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ruseng
            // 
            this.Ruseng.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Ruseng.Location = new System.Drawing.Point(304, 79);
            this.Ruseng.Name = "Ruseng";
            this.Ruseng.Size = new System.Drawing.Size(174, 54);
            this.Ruseng.TabIndex = 0;
            this.Ruseng.Text = "RusEng";
            this.Ruseng.UseVisualStyleBackColor = false;
            this.Ruseng.Click += new System.EventHandler(this.Ruseng_Click);
            // 
            // Engrus
            // 
            this.Engrus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Engrus.Location = new System.Drawing.Point(304, 144);
            this.Engrus.Name = "Engrus";
            this.Engrus.Size = new System.Drawing.Size(174, 54);
            this.Engrus.TabIndex = 1;
            this.Engrus.Text = "EngRus";
            this.Engrus.UseVisualStyleBackColor = false;
            this.Engrus.Click += new System.EventHandler(this.Engrus_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Exit.Location = new System.Drawing.Point(304, 204);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(174, 54);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(484, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 346);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.Location = new System.Drawing.Point(146, 192);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(152, 55);
            this.word.TabIndex = 4;
            this.word.Text = "label1";
            // 
            // transword
            // 
            this.transword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.transword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transword.Location = new System.Drawing.Point(12, 258);
            this.transword.Name = "transword";
            this.transword.Size = new System.Drawing.Size(447, 47);
            this.transword.TabIndex = 5;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 321);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(447, 54);
            this.check.TabIndex = 7;
            this.check.Text = "Проверка";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.Check_Click);
            // 
            // pts
            // 
            this.pts.AutoSize = true;
            this.pts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pts.Location = new System.Drawing.Point(109, 12);
            this.pts.Name = "pts";
            this.pts.Size = new System.Drawing.Size(100, 37);
            this.pts.TabIndex = 8;
            this.pts.Text = "label1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menu.Location = new System.Drawing.Point(304, 19);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(174, 54);
            this.menu.TabIndex = 9;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Очки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pts);
            this.Controls.Add(this.check);
            this.Controls.Add(this.transword);
            this.Controls.Add(this.word);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Engrus);
            this.Controls.Add(this.Ruseng);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "English Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ruseng;
        private System.Windows.Forms.Button Engrus;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.TextBox transword;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label pts;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label1;
    }
}

