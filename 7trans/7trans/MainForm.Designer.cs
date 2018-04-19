namespace _7trans
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btEncodeCSV = new System.Windows.Forms.Button();
            this.btDecodeCSV = new System.Windows.Forms.Button();
            this.btEncodeSQLString = new System.Windows.Forms.Button();
            this.btDecodeSqlString = new System.Windows.Forms.Button();
            this.btDecodeXml = new System.Windows.Forms.Button();
            this.btEncodeXml = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.undologTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(317, 31);
            this.textBox.TabIndex = 1;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // btEncodeCSV
            // 
            this.btEncodeCSV.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEncodeCSV.Location = new System.Drawing.Point(7, 49);
            this.btEncodeCSV.Name = "btEncodeCSV";
            this.btEncodeCSV.Size = new System.Drawing.Size(48, 23);
            this.btEncodeCSV.TabIndex = 2;
            this.btEncodeCSV.Text = "Ecsv";
            this.btEncodeCSV.UseVisualStyleBackColor = true;
            this.btEncodeCSV.Click += new System.EventHandler(this.btEncodeCSV_Click);
            // 
            // btDecodeCSV
            // 
            this.btDecodeCSV.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDecodeCSV.Location = new System.Drawing.Point(61, 49);
            this.btDecodeCSV.Name = "btDecodeCSV";
            this.btDecodeCSV.Size = new System.Drawing.Size(48, 23);
            this.btDecodeCSV.TabIndex = 3;
            this.btDecodeCSV.Text = "Dcsv";
            this.btDecodeCSV.UseVisualStyleBackColor = true;
            this.btDecodeCSV.Click += new System.EventHandler(this.btDecodeCSV_Click);
            // 
            // btEncodeSQLString
            // 
            this.btEncodeSQLString.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEncodeSQLString.Location = new System.Drawing.Point(115, 49);
            this.btEncodeSQLString.Name = "btEncodeSQLString";
            this.btEncodeSQLString.Size = new System.Drawing.Size(48, 23);
            this.btEncodeSQLString.TabIndex = 4;
            this.btEncodeSQLString.Text = "Esqlstr";
            this.btEncodeSQLString.UseVisualStyleBackColor = true;
            this.btEncodeSQLString.Click += new System.EventHandler(this.btEncodeSQLString_Click);
            // 
            // btDecodeSqlString
            // 
            this.btDecodeSqlString.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDecodeSqlString.Location = new System.Drawing.Point(169, 49);
            this.btDecodeSqlString.Name = "btDecodeSqlString";
            this.btDecodeSqlString.Size = new System.Drawing.Size(48, 23);
            this.btDecodeSqlString.TabIndex = 5;
            this.btDecodeSqlString.Text = "Dsqlstr";
            this.btDecodeSqlString.UseVisualStyleBackColor = true;
            this.btDecodeSqlString.Click += new System.EventHandler(this.btDecodeSqlString_Click);
            // 
            // btDecodeXml
            // 
            this.btDecodeXml.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDecodeXml.Location = new System.Drawing.Point(276, 49);
            this.btDecodeXml.Name = "btDecodeXml";
            this.btDecodeXml.Size = new System.Drawing.Size(48, 23);
            this.btDecodeXml.TabIndex = 7;
            this.btDecodeXml.Text = "Dxml";
            this.btDecodeXml.UseVisualStyleBackColor = true;
            this.btDecodeXml.Click += new System.EventHandler(this.btDecodeXml_Click);
            // 
            // btEncodeXml
            // 
            this.btEncodeXml.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEncodeXml.Location = new System.Drawing.Point(222, 49);
            this.btEncodeXml.Name = "btEncodeXml";
            this.btEncodeXml.Size = new System.Drawing.Size(48, 23);
            this.btEncodeXml.TabIndex = 6;
            this.btEncodeXml.Text = "Exml";
            this.btEncodeXml.UseVisualStyleBackColor = true;
            this.btEncodeXml.Click += new System.EventHandler(this.btEncodeXml_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // undologTimer
            // 
            this.undologTimer.Enabled = true;
            this.undologTimer.Interval = 250;
            this.undologTimer.Tick += new System.EventHandler(this.undologTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 80);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.btDecodeXml);
            this.Controls.Add(this.btEncodeXml);
            this.Controls.Add(this.btDecodeSqlString);
            this.Controls.Add(this.btEncodeSQLString);
            this.Controls.Add(this.btDecodeCSV);
            this.Controls.Add(this.btEncodeCSV);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "7trans";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btEncodeCSV;
        private System.Windows.Forms.Button btDecodeCSV;
        private System.Windows.Forms.Button btEncodeSQLString;
        private System.Windows.Forms.Button btDecodeSqlString;
        private System.Windows.Forms.Button btDecodeXml;
        private System.Windows.Forms.Button btEncodeXml;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer undologTimer;
    }
}

