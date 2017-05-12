using System;
using System.Windows.Forms;

namespace ZipUnZipLib
{
    public partial class Form2 : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;
        private static ZipClass zipClass = new ZipClass();  //压缩工具类
        private static UnZipClass unZipC = new UnZipClass();  //解压缩类
        public Form2()
        {
            InitializeComponent();
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
        }
        ///// <summary>
        ///// 判断文件是否是zip
        ///// </summary>
        ///// <param name="zipFile"></param>
        ///// <returns></returns>
        //private bool isZipFile(string zipFile)
        //{
        //    if (".zip" == zipFile.Substring(zipFile.Length - 4, 4))
        //    {
        //        return true;
        //    }
        //    return false;

        //}
        /// <summary>
        /// 显示信息 byliberxue 全局显示
        /// </summary>
        /// <param name="titile"></param>
        /// <param name="content"></param>
        private void showMsg(string titile, string content)
        {
            MessageBox.Show(titile + "" + content);

        }
        //获取文件目录
        private string  getZipToDir(string zipToFile)
        {
            string files = "";

            //for (int i = 0; i < selectFiles; i++)
            //{
            //    string fileName = listViewFilesAndFolders.SelectedItems[i].Text;
            //    //文件夹目录
            //    string dir = listViewFilesAndFolders.SelectedItems[i].Tag.ToString();
            //    //全路径名
            //    string fullName = dir + fileName;
            //    //选择一个直接返回
            //    if (listViewFilesAndFolders.SelectedItems.Count == 1)
            //    {
            //        return fullName;
            //    }
            //    if (i < listViewFilesAndFolders.SelectedItems.Count - 1)
            //    {
            //        files += fullName + "%";  //文件之间用%分开
            //    }
            //    else
            //    {
            //        files += fullName;
            //    }

            //}

            return files;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            string selectFiles = currentPath.Text.ToString();
            string zipToFile = SaveFileTextBox.Text;   //压缩到哪个目录下
            //判断保存的文件是否是Zip文件
            if (isZipFile(zipToFile))
            {
                if (zipClass.Zip(selectFiles, zipToFile, "123"))
                {

                    showMsg("压缩成功", "");
                    //取得文件所在文件夹
                    string zipDir = this.getZipToDir(zipToFile);

                    //PaintListView(zipDir + "\\");
                    //folderCol.Add(zipDir + "\\");
                    SaveFileTextBox.Text = "";
                    currentPath.Text = "";
                }
                else
                {
                    showMsg("压缩失败", "");
                }
            }
            else
            {
                showMsg("请输入正确的.zip文件（后缀.zip）", "");
            }
        }
        
        private void button2_Click(object sender, System.EventArgs e)
        {
            // string zipFile = this.getSelectedFileFullName();
            string zipFile = currentPath.Text;
            string unZipFileTo = SaveFileTextBox.Text;   //解压到哪个目录下
            if (unZipFileTo == "")
            {
                showMsg("选择解压目标目录", "");
                return;
            }
            //判断文件是否是Zip文件
            if (isZipFile(zipFile))
            {
                if (unZipC.UnZip(zipFile, unZipFileTo, "123"))
                {

                    showMsg("解压成功", "");
                    // PaintListView(unZipFileTo + "\\");
                    folderCol.Add(unZipFileTo + "\\");
                    SaveFileTextBox.Text = "";
                    currentPath.Text = "";
                }
                else
                {
                    showMsg("解压失败", "");
                }
            }
            else
            {
                showMsg("您选择的文件不是ZIP压缩文件", "");
            }

            //showMsg("选择了文件", this.getSelectedFileFullName());
        }
        //else
        //{
        //    showMsg("请选择待解压文件", "");
        //}

        //判断是否是zip 文件
        private bool isZipFile(string zipFile)
        {

            if (".zip" == zipFile.Substring(zipFile.Length - 4, 4))
            {
                return true;
            }
            return false;

        }
    }
}
