namespace WeatherChencker
{
    partial class WeatherChenkerFrom
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.areaBox = new System.Windows.Forms.ComboBox();
            this.都道府県選択 = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Weatherinfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaBox
            // 
            this.areaBox.FormattingEnabled = true;
            this.areaBox.IntegralHeight = false;
            this.areaBox.Location = new System.Drawing.Point(12, 90);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(121, 20);
            this.areaBox.TabIndex = 0;
            this.areaBox.SelectedIndexChanged += new System.EventHandler(this.CitySelected);
            // 
            // 都道府県選択
            // 
            this.都道府県選択.AutoSize = true;
            this.都道府県選択.Location = new System.Drawing.Point(12, 75);
            this.都道府県選択.Name = "都道府県選択";
            this.都道府県選択.Size = new System.Drawing.Size(77, 12);
            this.都道府県選択.TabIndex = 1;
            this.都道府県選択.Text = "都道府県選択";
            // 
            // weatherIcon
            // 
            this.weatherIcon.Location = new System.Drawing.Point(143, 27);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(24, 24);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherIcon.TabIndex = 2;
            this.weatherIcon.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuClicked);
            // 
            // Weatherinfo
            // 
            this.Weatherinfo.Location = new System.Drawing.Point(173, 27);
            this.Weatherinfo.Multiline = true;
            this.Weatherinfo.Name = "Weatherinfo";
            this.Weatherinfo.Size = new System.Drawing.Size(178, 99);
            this.Weatherinfo.TabIndex = 4;
            // 
            // WeatherChenkerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(376, 140);
            this.Controls.Add(this.Weatherinfo);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.都道府県選択);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WeatherChenkerFrom";
            this.Text = "WeatherChenker";
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox areaBox;
        private System.Windows.Forms.Label 都道府県選択;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TextBox Weatherinfo;
    }
}

