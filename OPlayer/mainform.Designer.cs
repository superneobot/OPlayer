
using System.Windows.Forms;

namespace OPlayer
{
    partial class mainform
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
            this.components = new System.ComponentModel.Container();
            this.top = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.forma = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.dload = new System.Windows.Forms.Button();
            this.film_show = new System.Windows.Forms.Button();
            this.quality_list = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Panel();
            this.list_links = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genre_list = new System.Windows.Forms.ComboBox();
            this.search_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.get_films = new System.Windows.Forms.Button();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.loading = new OPlayer.MyProgressBar();
            this.bar = new OPlayer.MyProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.top.SuspendLayout();
            this.forma.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.left.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.top.Controls.Add(this.label4);
            this.top.Controls.Add(this.exit);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(1, 1);
            this.top.Name = "top";
            this.top.Padding = new System.Windows.Forms.Padding(1);
            this.top.Size = new System.Drawing.Size(395, 30);
            this.top.TabIndex = 0;
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Online Video Filmoteka";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(369, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 24);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // forma
            // 
            this.forma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.forma.Controls.Add(this.main);
            this.forma.Controls.Add(this.left);
            this.forma.Controls.Add(this.statusbar);
            this.forma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forma.Location = new System.Drawing.Point(1, 31);
            this.forma.Name = "forma";
            this.forma.Size = new System.Drawing.Size(395, 568);
            this.forma.TabIndex = 1;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.main.Controls.Add(this.loading);
            this.main.Controls.Add(this.dload);
            this.main.Controls.Add(this.film_show);
            this.main.Controls.Add(this.quality_list);
            this.main.Controls.Add(this.label5);
            this.main.Controls.Add(this.pbox);
            this.main.Controls.Add(this.title);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(175, 0);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(1);
            this.main.Size = new System.Drawing.Size(220, 546);
            this.main.TabIndex = 2;
            this.main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            // 
            // dload
            // 
            this.dload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dload.Enabled = false;
            this.dload.FlatAppearance.BorderSize = 0;
            this.dload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.dload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dload.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dload.ForeColor = System.Drawing.Color.LightGray;
            this.dload.Location = new System.Drawing.Point(9, 402);
            this.dload.Name = "dload";
            this.dload.Size = new System.Drawing.Size(200, 30);
            this.dload.TabIndex = 5;
            this.dload.Text = "Скачать фильм";
            this.dload.UseVisualStyleBackColor = false;
            this.dload.Click += new System.EventHandler(this.dload_Click);
            // 
            // film_show
            // 
            this.film_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.film_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.film_show.Enabled = false;
            this.film_show.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.film_show.FlatAppearance.BorderSize = 0;
            this.film_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.film_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.film_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film_show.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.film_show.ForeColor = System.Drawing.Color.LightGray;
            this.film_show.Location = new System.Drawing.Point(9, 366);
            this.film_show.Name = "film_show";
            this.film_show.Size = new System.Drawing.Size(200, 30);
            this.film_show.TabIndex = 4;
            this.film_show.Text = "Смотреть онлайн";
            this.film_show.UseVisualStyleBackColor = false;
            this.film_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // quality_list
            // 
            this.quality_list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.quality_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quality_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quality_list.Enabled = false;
            this.quality_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quality_list.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quality_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quality_list.FormattingEnabled = true;
            this.quality_list.Items.AddRange(new object[] {
            "Half SD (240p)",
            "SD (360p)",
            "HD (720p)",
            "Full HD (1080p)"});
            this.quality_list.Location = new System.Drawing.Point(9, 337);
            this.quality_list.Name = "quality_list";
            this.quality_list.Size = new System.Drawing.Size(200, 23);
            this.quality_list.TabIndex = 3;
            this.quality_list.SelectedIndexChanged += new System.EventHandler(this.quality_list_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(7, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Качество";
            // 
            // pbox
            // 
            this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox.Location = new System.Drawing.Point(9, 24);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(200, 294);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 1;
            this.pbox.TabStop = false;
            this.pbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.LightGray;
            this.title.Location = new System.Drawing.Point(7, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 13);
            this.title.TabIndex = 0;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.left.Controls.Add(this.bar);
            this.left.Controls.Add(this.list_links);
            this.left.Controls.Add(this.label3);
            this.left.Controls.Add(this.label2);
            this.left.Controls.Add(this.genre_list);
            this.left.Controls.Add(this.search_value);
            this.left.Controls.Add(this.label1);
            this.left.Controls.Add(this.panel1);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Padding = new System.Windows.Forms.Padding(4);
            this.left.Size = new System.Drawing.Size(175, 546);
            this.left.TabIndex = 1;
            // 
            // list_links
            // 
            this.list_links.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.list_links.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_links.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_links.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_links.FormattingEnabled = true;
            this.list_links.ItemHeight = 14;
            this.list_links.Location = new System.Drawing.Point(4, 108);
            this.list_links.Name = "list_links";
            this.list_links.Size = new System.Drawing.Size(167, 368);
            this.list_links.TabIndex = 8;
            this.list_links.Click += new System.EventHandler(this.list_links_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список фильмов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список жанров";
            // 
            // genre_list
            // 
            this.genre_list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.genre_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genre_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genre_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genre_list.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genre_list.FormattingEnabled = true;
            this.genre_list.Location = new System.Drawing.Point(4, 64);
            this.genre_list.Name = "genre_list";
            this.genre_list.Size = new System.Drawing.Size(167, 23);
            this.genre_list.TabIndex = 5;
            this.genre_list.SelectedIndexChanged += new System.EventHandler(this.genre_list_SelectedIndexChanged);
            // 
            // search_value
            // 
            this.search_value.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_value.Location = new System.Drawing.Point(3, 20);
            this.search_value.Name = "search_value";
            this.search_value.Size = new System.Drawing.Size(167, 23);
            this.search_value.TabIndex = 4;
            this.search_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск фильма";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.get_films);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 509);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(167, 33);
            this.panel1.TabIndex = 2;
            // 
            // get_films
            // 
            this.get_films.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.get_films.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get_films.Dock = System.Windows.Forms.DockStyle.Fill;
            this.get_films.Enabled = false;
            this.get_films.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.get_films.FlatAppearance.BorderSize = 0;
            this.get_films.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.get_films.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.get_films.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get_films.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_films.ForeColor = System.Drawing.Color.LightGray;
            this.get_films.Location = new System.Drawing.Point(1, 1);
            this.get_films.Name = "get_films";
            this.get_films.Size = new System.Drawing.Size(165, 31);
            this.get_films.TabIndex = 0;
            this.get_films.Text = "Обновить список";
            this.get_films.UseVisualStyleBackColor = false;
            this.get_films.Click += new System.EventHandler(this.get_films_Click);
            // 
            // statusbar
            // 
            this.statusbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusbar.Location = new System.Drawing.Point(0, 546);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(395, 22);
            this.statusbar.TabIndex = 0;
            this.statusbar.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Control;
            this.status.Font = new System.Drawing.Font("Calibri", 10F);
            this.status.ForeColor = System.Drawing.Color.LightGray;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 17);
            this.status.Text = "Готов";
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.loading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loading.Location = new System.Drawing.Point(10, 438);
            this.loading.Maximum = 100;
            this.loading.Minimum = 0;
            this.loading.Name = "loading";
            this.loading.Progress = null;
            this.loading.Size = new System.Drawing.Size(199, 25);
            this.loading.Step = 1;
            this.loading.TabIndex = 6;
            this.loading.Value = 0;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.bar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bar.Location = new System.Drawing.Point(5, 480);
            this.bar.Maximum = 10;
            this.bar.Minimum = 0;
            this.bar.Name = "bar";
            this.bar.Progress = null;
            this.bar.Size = new System.Drawing.Size(165, 23);
            this.bar.Step = 1;
            this.bar.TabIndex = 9;
            this.bar.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(397, 600);
            this.Controls.Add(this.forma);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.forma.ResumeLayout(false);
            this.forma.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel forma;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button get_films;
        private System.Windows.Forms.TextBox search_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genre_list;
        private System.Windows.Forms.ListBox list_links;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.ComboBox quality_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button film_show;
        private System.Windows.Forms.Button dload;
        private OPlayer.MyProgressBar loading;
        private OPlayer.MyProgressBar bar;
        private Timer timer1;
    }
}

