namespace Проект_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SEARCH = new System.Windows.Forms.Button();
            this.TEMPERATURE2 = new System.Windows.Forms.TextBox();
            this.TEMPERATURE1 = new System.Windows.Forms.TextBox();
            this.CITY = new System.Windows.Forms.TextBox();
            this.WeakWeather = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SEARCH
            // 
            this.SEARCH.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEARCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SEARCH.Location = new System.Drawing.Point(609, 12);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(98, 28);
            this.SEARCH.TabIndex = 0;
            this.SEARCH.Text = "ПОИСК";
            this.SEARCH.UseVisualStyleBackColor = false;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // TEMPERATURE2
            // 
            this.TEMPERATURE2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TEMPERATURE2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEMPERATURE2.Font = new System.Drawing.Font("Century Gothic", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TEMPERATURE2.Location = new System.Drawing.Point(431, 145);
            this.TEMPERATURE2.Multiline = true;
            this.TEMPERATURE2.Name = "TEMPERATURE2";
            this.TEMPERATURE2.ReadOnly = true;
            this.TEMPERATURE2.Size = new System.Drawing.Size(276, 114);
            this.TEMPERATURE2.TabIndex = 1;
            this.TEMPERATURE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TEMPERATURE2.WordWrap = false;
            // 
            // TEMPERATURE1
            // 
            this.TEMPERATURE1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TEMPERATURE1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEMPERATURE1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEMPERATURE1.Font = new System.Drawing.Font("Century Gothic", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TEMPERATURE1.Location = new System.Drawing.Point(109, 145);
            this.TEMPERATURE1.Name = "TEMPERATURE1";
            this.TEMPERATURE1.ReadOnly = true;
            this.TEMPERATURE1.Size = new System.Drawing.Size(240, 107);
            this.TEMPERATURE1.TabIndex = 1;
            this.TEMPERATURE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TEMPERATURE1.WordWrap = false;
            // 
            // CITY
            // 
            this.CITY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CITY.Location = new System.Drawing.Point(461, 12);
            this.CITY.Name = "CITY";
            this.CITY.Size = new System.Drawing.Size(142, 27);
            this.CITY.TabIndex = 3;
            this.CITY.Text = "Ввeдите город";
            this.CITY.Click += new System.EventHandler(this.CITY_Click);
            this.CITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CITY_KeyPress);
            // 
            // WeakWeather
            // 
            this.WeakWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeakWeather.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeakWeather.Location = new System.Drawing.Point(189, 372);
            this.WeakWeather.Name = "WeakWeather";
            this.WeakWeather.Size = new System.Drawing.Size(354, 27);
            this.WeakWeather.TabIndex = 4;
            this.WeakWeather.Text = "Погода на неделю";
            this.WeakWeather.UseVisualStyleBackColor = true;
            this.WeakWeather.Click += new System.EventHandler(this.WeakWeather_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelCity.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(-4, 70);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(204, 41);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "Ярославль";
            this.labelCity.DoubleClick += new System.EventHandler(this.labelCity_Click);
            this.labelCity.MouseEnter += new System.EventHandler(this.labelCity_MouseEnter);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 411);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.WeakWeather);
            this.Controls.Add(this.CITY);
            this.Controls.Add(this.TEMPERATURE1);
            this.Controls.Add(this.TEMPERATURE2);
            this.Controls.Add(this.SEARCH);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 450);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.TextBox TEMPERATURE2;
        private System.Windows.Forms.TextBox TEMPERATURE1;
        private System.Windows.Forms.TextBox CITY;
        private System.Windows.Forms.Button WeakWeather;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

