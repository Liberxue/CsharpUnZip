using System;
using System.Windows.Forms;
using System.IO;



namespace ZipUnZipLib
{
    public partial class Form1 : Form
    {

        private System.Collections.Specialized.StringCollection folderCol;
        private static ZipClass zipClass = new ZipClass();  //压缩工具类
        private static UnZipClass unZipC = new UnZipClass();  //解压缩类

        public Form1()
        {
            InitializeComponent();

            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFiledListView();
            //PaintListView(@"c:");
            //folderCol.Add(@"c:");
        }

      

        private void ZipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出工具？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void ZipForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加列标题
        /// </summary>
        private void CreateHeadersAndFiledListView()
        {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "文件名";
            colHead.Width = 200;
            listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "大小";
            colHead.Width = 80;
            listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "类型";
            colHead.Width = 80;
            listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "修改日期";
            colHead.Width = 200;
            listViewFilesAndFolders.Columns.Add(colHead);

        }

        /// <summary>
        /// 硬盘文件填充文件列表
        /// </summary>
        private void PaintListView( string root )
        {

            try {

                ListViewItem lvi;

                ListViewItem.ListViewSubItem lvis;

                if (string.IsNullOrEmpty(root))
                    return;

                DirectoryInfo dir = new DirectoryInfo( root );
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                listViewFilesAndFolders.Items.Clear();
                currentPath.Text = root;
                listViewFilesAndFolders.BeginUpdate();
               
                foreach( DirectoryInfo di in dirs )
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = dir.FullName;

                    lvis = new ListViewItem.ListViewSubItem();
                    lvis.Text = "";
                    lvi.SubItems.Add(lvis);

                    lvis = new ListViewItem.ListViewSubItem();
                    lvis.Text = "文件夹";
                    lvi.SubItems.Add(lvis);


                    lvis = new ListViewItem.ListViewSubItem();
                    lvis.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvis);
                    listViewFilesAndFolders.Items.Add(lvi);
                }

                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = dir.FullName;

                    lvis = new ListViewItem.ListViewSubItem();
                    lvis.Text = fi.Length.ToString()+" Byte";
                    lvi.SubItems.Add(lvis);

                    lvis = new ListViewItem.ListViewSubItem();
                    lvis.Text = fi.Extension;
                    lvi.SubItems.Add(lvis);


                    lvis = new ListViewItem.ListViewSubItem();
                    lvis.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvis);
                    listViewFilesAndFolders.Items.Add(lvi);
                }


                listViewFilesAndFolders.EndUpdate();


           
            }catch( SystemException ex){
                MessageBox.Show("Exception + : "+ex.Message);
            }

        }

        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView) sender;
            string fileName = lw.SelectedItems[0].Tag.ToString();
  
            string fullName = fileName +  lw.SelectedItems[0].Text + "\\";
     
    
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(fullName);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                PaintListView(fullName);
                folderCol.Add(fullName);
            }
        }

        /// <summary>
        /// 返回上一级文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if( folderCol.Count > 1 )
            {
                PaintListView(folderCol[folderCol.Count -2].ToString());
                folderCol.RemoveAt(folderCol.Count -1);
            }else{
                PaintListView(folderCol[0].ToString());
            }
        }

       
        private void LargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rdb = (RadioButton)sender;

            //if (rdb.Checked)
            //{
            //    this.listViewFilesAndFolders.View = View.LargeIcon;
            //}
            this.listViewFilesAndFolders.View = View.LargeIcon;

        }

        private void SmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rdb = (RadioButton)sender;

            //if (rdb.Checked)
            //{
            //    this.listViewFilesAndFolders.View = View.SmallIcon;
            //}
            this.listViewFilesAndFolders.View = View.SmallIcon;
        }

        private void List_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rdb = (RadioButton)sender;

            //if (rdb.Checked)
            //{
            //    this.listViewFilesAndFolders.View = View.List;
            //}
            this.listViewFilesAndFolders.View = View.List;
        }

        private void Detail_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rdb = (RadioButton)sender;

            //if (rdb.Checked)
            //{
            //    this.listViewFilesAndFolders.View = View.Details;
            //}
            this.listViewFilesAndFolders.View = View.Details;
        }

        private void Title_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rdb = (RadioButton)sender;

            //if (rdb.Checked)
            //{
            //    this.listViewFilesAndFolders.View = View.Tile;
            //}
            this.listViewFilesAndFolders.View = View.Tile;
        }

        /// <summary>
        /// 浏览Windows文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            openSelectFolder();
           
        }

        /// <summary>
        /// 显示信息提示
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        private void showMsg( string title,string content)
        {
            MessageBox.Show(title+" "+content);
       
        }

        /// <summary>
        /// 取得列表中文件的全名(目录+文件名)
        /// </summary>
        /// <returns></returns>
        private string getSelectedFileFullName()
        {
            string fileName = listViewFilesAndFolders.SelectedItems[0].Text;
            //文件夹目录
            string dir = listViewFilesAndFolders.SelectedItems[0].Tag.ToString();
            //全路径名
            string fullName = dir + fileName;

            return fullName;
        }

        //压缩文件
        private void zipFile_Click(object sender, EventArgs e)
        {
            if (listViewFilesAndFolders.SelectedItems.Count > 0)
            {  
                //
                string selectFiles = this.getSelectFilesName();
                string zipToFile = SaveFileTextBox.Text;   //压缩到哪个目录下
                if (zipToFile == "")
                {
                    showMsg("选择解压目标目录", "");
                    return;
                }
                //判断保存的文件是否是Zip文件
                if (isZipFile(zipToFile))
                {
                    if (zipClass.Zip(selectFiles, zipToFile, "123"))
                    {

                        showMsg("压缩成功", "");
                        //取得文件所在文件夹
                        string zipDir = this.getZipToDir(zipToFile);

                        PaintListView(zipDir + "\\");
                        folderCol.Add(zipDir + "\\");
                        SaveFileTextBox.Text = "";
                        currentPath.Text = "";
                    }
                    else {
                        showMsg("压缩失败", "");
                    }
                }
                else
                {
                    showMsg("请输入正确的.zip文件（后缀.zip）", "");
                }
            }
            else
            {
                showMsg("请选择操作文件", "");
            }
        }

        /// <summary>
        /// 取得传入文件的目录
        /// </summary>
        /// <returns></returns>
        private string getZipToDir(string zipToFile)
        {
            FileInfo finleInfo = new FileInfo(zipToFile);
            return finleInfo.DirectoryName;
       
        }
        /// <summary>
        /// 取得所有选择的等压缩的文件
        /// </summary>
        /// <returns></returns>

        private string getSelectFilesName()
        {
            string files = "";
   
            for (int i = 0; i < listViewFilesAndFolders.SelectedItems.Count; i++)
            {
                string fileName = listViewFilesAndFolders.SelectedItems[i].Text;
                //文件夹目录
                string dir = listViewFilesAndFolders.SelectedItems[i].Tag.ToString();
                //全路径名
                string fullName = dir + fileName;
                //选择一个直接返回
                if (listViewFilesAndFolders.SelectedItems.Count == 1)
                {
                    return fullName;
                }
                if (i < listViewFilesAndFolders.SelectedItems.Count - 1)
                {
                    files += fullName + "%";  //文件之间用%分开
                }
                else {
                    files += fullName;
                }
               
            }

            return files;
       
        }


        /// <summary>
        /// 解压选择的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnZipFile_Click(object sender, EventArgs e)
        {
            //if (listViewFilesAndFolders.SelectedItems.Count > 0)
            //{

            // string zipFile = this.getSelectedFileFullName();
            string zipFile = currentPath.Text;
                string unZipFileTo = SaveFileTextBox.Text;   //解压到哪个目录下
                if(unZipFileTo ==""){
                    showMsg("选择解压目标目录", "");
                    return;
                }
                //判断文件是否是Zip文件
                if (isZipFile(zipFile))
                {
                    if (unZipC.UnZip(zipFile, unZipFileTo,"123"))
                    {

                        showMsg("解压成功", "");
                       // PaintListView(unZipFileTo + "\\");
                        folderCol.Add(unZipFileTo + "\\");
                        SaveFileTextBox.Text = "";
                        currentPath.Text = "";
                    }
                    else {
                        showMsg("解压失败", "");
                    }
                }
                else
                {
                    showMsg("您选择的文件不是ZIP压缩文件","");
                }

                //showMsg("选择了文件", this.getSelectedFileFullName());
            }
            //else
            //{
            //    showMsg("请选择待解压文件", "");
            //}

        //判断是否是zip 文件
        private bool isZipFile(string zipFile){

            if (".zip" == zipFile.Substring(zipFile.Length - 4,4))
            {
                return true;
            }
            return false;
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出工具？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出工具？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void choiceSaveDir_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr.ToString() == "OK") //打开了文件夹
            {
                string fullFileName = folderBrowserDialog1.SelectedPath;
                SaveFileTextBox.Text = fullFileName ;
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSelectFolder();
        }

        /// <summary>
        /// 打开文件夹选择文件夹
        /// </summary>
        private void openSelectFolder()
        {

            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr.ToString() == "OK") //打开了文件夹
            {
                string fullFileName = folderBrowserDialog1.SelectedPath;


                PaintListView(fullFileName + "\\");
                folderCol.Add(fullFileName + "\\");

                //currentPath.Text = folderBrowserDialog1.SelectedPath;
            }
       
        }
    }


}
