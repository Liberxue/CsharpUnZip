namespace ZipUnZipLib
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPath = new System.Windows.Forms.TextBox();
            this.SaveFileTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewFilesAndFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(0, 0);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(1123, 343);
            this.listViewFilesAndFolders.TabIndex = 0;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.List;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看模式ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 查看模式ToolStripMenuItem
            // 
            this.查看模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表模式ToolStripMenuItem,
            this.数据列表ToolStripMenuItem});
            this.查看模式ToolStripMenuItem.Name = "查看模式ToolStripMenuItem";
            this.查看模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看模式ToolStripMenuItem.Text = "查看模式";
            // 
            // 图标ToolStripMenuItem
            // 
            this.图标ToolStripMenuItem.Name = "图标ToolStripMenuItem";
            this.图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.图标ToolStripMenuItem.Text = "大图标";
            this.图标ToolStripMenuItem.Click += new System.EventHandler(this.LargeIcon_CheckedChanged);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.SmallIcon_CheckedChanged);
            // 
            // 列表模式ToolStripMenuItem
            // 
            this.列表模式ToolStripMenuItem.Name = "列表模式ToolStripMenuItem";
            this.列表模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表模式ToolStripMenuItem.Text = "列表模式";
            this.列表模式ToolStripMenuItem.Click += new System.EventHandler(this.Title_CheckedChanged);
            // 
            // 数据列表ToolStripMenuItem
            // 
            this.数据列表ToolStripMenuItem.Name = "数据列表ToolStripMenuItem";
            this.数据列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.数据列表ToolStripMenuItem.Text = "数据列表";
            this.数据列表ToolStripMenuItem.Click += new System.EventHandler(this.Detail_CheckedChanged);
            // 
            // currentPath
            // 
            this.currentPath.Location = new System.Drawing.Point(66, 12);
            this.currentPath.Name = "currentPath";
            this.currentPath.Size = new System.Drawing.Size(100, 21);
            this.currentPath.TabIndex = 1;
            this.currentPath.Text = "E:\\www";
            // 
            // SaveFileTextBox
            // 
            this.SaveFileTextBox.Location = new System.Drawing.Point(230, 12);
            this.SaveFileTextBox.Name = "SaveFileTextBox";
            this.SaveFileTextBox.Size = new System.Drawing.Size(100, 21);
            this.SaveFileTextBox.TabIndex = 2;
            this.SaveFileTextBox.Text = "E:\\www\\13.zip";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.currentPath);
            this.panel1.Controls.Add(this.SaveFileTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 44);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(667, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "解压文件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.UnZipFile_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(586, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "压缩文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.zipFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1020, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "退出工具";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "浏览Windows文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回上一级";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewFilesAndFolders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 343);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.TextBox currentPath;
        private System.Windows.Forms.TextBox SaveFileTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据列表ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

