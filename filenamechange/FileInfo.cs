using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filenamechange
{
    public class FileInfo
    {
        private string _name;
        private string _path;
        private string _extension;
        private string _fullName;
        private string _safeName;
        private string _oldFullName;
        private string _oldSafeName;
        private string _oldExtension;
        private string _oldpath;

        /// <summary>
        /// 순수이름
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 경로
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        /// <summary>
        /// 확장자
        /// </summary>
        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }
        /// <summary>
        /// 전체이름
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        /// <summary>
        /// 파일명
        /// </summary>
        public string SafeName
        {
            get{return _safeName;}
            set { _safeName = value; }
        }
        /// <summary>
        /// 초기전체이름
        /// </summary>
        public string OldFullName
        {
            get { return _oldFullName; }
            set { _oldFullName = value; }
        }
        /// <summary>
        /// 초기확장자
        /// </summary>
        public string OldExtension
        {
            get { return _oldExtension; }
            set { _oldExtension = value; }
        }
        /// <summary>
        /// 초기경로
        /// </summary>
        public string Oldpath
        {
            get { return _oldpath; }
            set { _oldpath = value; }
        }
        /// <summary>
        /// 초기이름
        /// </summary>
        public string OldSafeName
        {
            get { return _oldSafeName; }
            set { _oldSafeName = value; }
        }

        public FileInfo()
        {
        }
    }
}
