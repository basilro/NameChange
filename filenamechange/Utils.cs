using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace filenamechange
{
    internal class Utils
    {
        
        /// <summary>
        /// 중복여부
        /// </summary>
        /// <param name="lstfile"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool IsFile(List<FileInfo> lstfile, FileInfo info)
        {
            foreach(FileInfo file in lstfile)
            {
                if(file.FullName == info.FullName)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 파일 리스트추가
        /// </summary>
        /// <param name="file"></param>
        /// <param name="lstfile"></param>
        public static void FileAdd(string[] files, List<FileInfo> lstfile)
        {
            foreach (string file in files)
            {
                FileInfo finfo = new FileInfo();
                finfo.FullName = finfo.OldFullName = file;
                finfo.SafeName = finfo.OldSafeName = file.Substring(file.LastIndexOf('\\')+1);
                finfo.Extension = finfo.OldExtension = finfo.SafeName.Substring(finfo.SafeName.LastIndexOf('.'));
                finfo.Path = finfo.Oldpath = file.Replace(finfo.SafeName, "");
                finfo.Name = finfo.SafeName.Replace(finfo.Extension, "");

                if (!IsFile(lstfile, finfo) && IsExtention(finfo.Extension))
                    lstfile.Add(finfo);
            }
        }

        /// <summary>
        /// 폴더파일 리스트에 추가
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lstfile"></param>
        public static void ForderAdd(string path, List<FileInfo> lstfile)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            if (info.GetFiles().Count() >= 1)
            {
                foreach (System.IO.FileInfo file in info.GetFiles())
                {
                    FileInfo finfo = new FileInfo();
                    finfo.Extension = finfo.OldExtension = file.Extension;
                    finfo.FullName = finfo.OldFullName = file.FullName;
                    finfo.Path = finfo.Oldpath = file.DirectoryName;
                    finfo.SafeName = finfo.OldSafeName = file.Name;
                    finfo.Name = file.Name.Replace(file.Extension, "");

                    if (!IsFile(lstfile, finfo) && IsExtention(finfo.Extension))
                        lstfile.Add(finfo);
                }
            }

            if (info.GetDirectories().Count() >= 1)
            {
                foreach (DirectoryInfo folder in info.GetDirectories())
                {
                    ForderAdd(folder.FullName, lstfile);
                }
            }
            
        }

        /// <summary>
        /// ini파일 제외
        /// </summary>
        /// <param name="extention"></param>
        /// <returns></returns>
        public static bool IsExtention(string extention)
        {
            if (extention.Substring(1, extention.Length - 1) == "ini")
            {
                return false;
            }
            return true;
        }
    }
}
