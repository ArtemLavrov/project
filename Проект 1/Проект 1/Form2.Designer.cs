namespace Проект_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.YANDEXWEATHER = new System.Windows.Forms.RichTextBox();
            this.GISMETEOWEATHER = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // YANDEXWEATHER
            // 
            this.YANDEXWEATHER.BackColor = System.Drawing.Color.White;
            this.YANDEXWEATHER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YANDEXWEATHER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YANDEXWEATHER.Location = new System.Drawing.Point(11, 143);
            this.YANDEXWEATHER.Name = "YANDEXWEATHER";
            this.YANDEXWEATHER.Size = new System.Drawing.Size(327, 137);
            this.YANDEXWEATHER.TabIndex = 0;
            this.YANDEXWEATHER.Text = "";
            // 
            // GISMETEOWEATHER
            // 
            this.GISMETEOWEATHER.BackColor = System.Drawing.Color.White;
            this.GISMETEOWEATHER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GISMETEOWEATHER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GISMETEOWEATHER.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GISMETEOWEATHER.Location = new System.Drawing.Point(367, 143);
            this.GISMETEOWEATHER.Name = "GISMETEOWEATHER";
            this.GISMETEOWEATHER.Size = new System.Drawing.Size(325, 138);
            this.GISMETEOWEATHER.TabIndex = 1;
            this.GISMETEOWEATHER.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 320);
            this.Controls.Add(this.GISMETEOWEATHER);
            this.Controls.Add(this.YANDEXWEATHER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox YANDEXWEATHER;
        private System.Windows.Forms.RichTextBox GISMETEOWEATHER;
    }
}