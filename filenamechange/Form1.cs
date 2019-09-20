using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace filenamechange
{
    public partial class Form1 : Form
    {
        private string _path;   //경로저장
        private List<FileInfo> lstfile;
        private string dialogPath = @"D:\";

        public Form1()
        {
            InitializeComponent();

            btnGetFile.Click += FileSearch;
            btnGetFolder.Click += FolderSearch;
            btnFirstChange.Click += FirstMove;
            btnOK.Click += OKClicked;
            btnRemoveName.Click += RemoveName;
            btnRename.Click += ReName;
            btn_PathChange.Click += btn_PathChange_Click;
            chkIsPath.CheckedChanged += chkIsPath_CheckedChanged;
            btnReset.Click += btnReset_Click;
            btnClear.Click += btnClear_Click;
            btnDelete.Click += btnDelete_Click;
            List.SelectedIndexChanged += List_SelectedIndexChanged;
            ChangeList.SelectedIndexChanged += ChangeList_SelectedIndexChanged;
            List.DragDrop += List_DragDrop;
            List.DragEnter += List_DragEnter;

            mnuOk.Click += OKClicked;
            mnuFileOpen.Click += FileSearch;
            mnuForderOpen.Click += FolderSearch;
            mnuDelete.Click += btnDelete_Click;
            mnuFirstChange.Click += FirstMove;
            mnuNameChange.Click += ReName;
            mnuPathChange.Click += btn_PathChange_Click;
            mnuRemoveName.Click += RemoveName;
            mnuClear.Click += btnClear_Click;
            mnuReturn.Click += btnReset_Click;
            mnuDelete.Click += btnDelete_Click;
            mnuEtcRemove.Click += mnuEtcRemove_Click;
            mnuExit.Click += (snd, ev) =>
            {
                this.Close();
            };
            

            lstfile = new List<FileInfo>();
        }

        /// <summary>
        /// 드래그
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void List_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }

        /// <summary>
        /// 드래그처리
        /// </summary>
        void List_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                Utils.FileAdd(files, lstfile);
                ListAdd();
            }
        }

        /// <summary>
        /// 파일선택
        /// </summary>
        void ChangeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List.SelectedIndexChanged -= List_SelectedIndexChanged;
            List.ClearSelected();
            List.SelectedIndexChanged += List_SelectedIndexChanged;
        }

        /// <summary>
        /// 파일선택
        /// </summary>
        void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeList.SelectedIndexChanged -= ChangeList_SelectedIndexChanged;
            ChangeList.ClearSelected();
            ChangeList.SelectedIndexChanged += ChangeList_SelectedIndexChanged;
        }

        /// <summary>
        /// 파일 삭제
        /// </summary>
        void btnDelete_Click(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count > 1)
            { 
                for (int i = List.SelectedItems.Count - 1; i >= 0  ; i--)
                {
                    lstfile.RemoveAt(List.SelectedIndices[i]);
                    if(ChangeList.Items.Count > 0) ChangeList.Items.RemoveAt(List.SelectedIndices[i]);
                    List.Items.RemoveAt(List.SelectedIndices[i]);
                }
            }
            else if (ChangeList.SelectedItems.Count > 1)
            {
                for (int i = ChangeList.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstfile.RemoveAt(ChangeList.SelectedIndices[i]);
                    List.Items.RemoveAt(ChangeList.SelectedIndices[i]);
                    ChangeList.Items.RemoveAt(ChangeList.SelectedIndices[i]);
                }
            }
        }

        /// <summary>
        /// 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnClear_Click(object sender, EventArgs e)
        {
            lstfile.Clear();
            List.Items.Clear();
            ChangeList.Items.Clear();
        }

        /// <summary>
        /// 변경내역 취소
        /// </summary>
        void btnReset_Click(object sender, EventArgs e)
        {
            ChangeList.Items.Clear();
            foreach (FileInfo file in lstfile)
            {
                file.Path = file.Oldpath;
                file.Extension = file.OldExtension;
                file.SafeName = file.OldSafeName;
                file.Name = file.OldSafeName.Replace(file.OldExtension, "");
                file.FullName = file.OldFullName;
                if (chkIsPath.Checked)
                {
                    ChangeList.Items.Add(file.FullName);
                }
                else
                {
                    ChangeList.Items.Add(file.SafeName);
                }
            }
        }

        /// <summary>
        /// 확장자보임변경
        /// </summary>
        void chkIsPath_CheckedChanged(object sender, EventArgs e)
        {
            ChangeList.Items.Clear();
            foreach (FileInfo file in lstfile)
            {
                if (chkIsPath.Checked)
                {
                    ChangeList.Items.Add(file.FullName);
                }
                else
                {
                    ChangeList.Items.Add(file.SafeName);
                }
            }

            //화면길이조정
            using (Graphics g = this.CreateGraphics())
            {
                int width = (int)g.MeasureString(ChangeList.Items[0].ToString(), ChangeList.Font).Width-100;    //폰트길이계산
                if (width >= 200)
                {
                    if (chkIsPath.Checked)
                    {
                        ChangeList.Width += width;
                        this.Width += (width);
                    }
                    else
                    {
                        ChangeList.Width = 204;
                        this.Width = 510;
                    }
                }
            }
        }

        /// <summary>
        /// 경로변경
        /// </summary>
        void btn_PathChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            
            DialogResult result = dialog.ShowDialog();
            
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!chkIsPath.Checked) chkIsPath.Checked = true;
                ChangeList.Items.Clear();
                foreach (FileInfo file in lstfile)
                {
                    file.Path = dialog.SelectedPath.Substring(dialog.SelectedPath.Length - 2, 2).Equals("\\") ? dialog.SelectedPath : dialog.SelectedPath + "\\";
                    file.FullName = file.Path + file.SafeName;
                    ChangeList.Items.Add(file.FullName);
                }
            }
        }

        /// <summary>
        /// 적용처리
        /// </summary>
        private void OKClicked(object sender, EventArgs e)
        {
            if (ChangeList.Items.Count < 1)
            {
                MessageBox.Show("적용할 항목이 없습니다.");
                return;
            }
            try
            {
                foreach (FileInfo file in lstfile)
                {
                    File.Move(file.OldFullName, file.FullName);
                }

            }
            catch (Exception ex) { }

            MessageBox.Show("적용이 완료되었습니다.");
            lstfile.Clear();
            List.Items.Clear();
            ChangeList.Items.Clear();
        }

        /// <summary>
        /// 파일목록 조회
        /// </summary>
        private void FileSearch(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = dialogPath;
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //파일정보
                //for (int i = 0; i < dialog.FileNames.Count();i++ )
                //{
                //    FileInfo finfo = new FileInfo();
                //    finfo.Path = finfo.Oldpath = dialog.FileNames[i].Replace(dialog.SafeFileNames[i], "");
                //    finfo.Extension = finfo.OldExtension = dialog.SafeFileNames[i].Substring(dialog.SafeFileNames[i].LastIndexOf('.'));
                //    finfo.Name = dialog.SafeFileNames[i].Substring(0, dialog.SafeFileNames[i].IndexOf('.'));
                //    finfo.FullName = finfo.OldFullName = dialog.FileNames[i];
                //    finfo.SafeName = finfo.OldSafeName = dialog.SafeFileNames[i];
                //    if (!Utils.IsFile(lstfile, finfo) && Utils.IsExtention(finfo.Extension))
                //        lstfile.Add(finfo);

                //    if (i == 0)
                //        dialogPath = finfo.Path;
                //}
                dialogPath = dialog.FileName.Replace(dialog.SafeFileName, "");
                Utils.FileAdd(dialog.FileNames, lstfile);

                ListAdd();
            }
        }

        /// <summary>
        /// 폴더 조회
        /// </summary>
        private void FolderSearch(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            dialog.SelectedPath = dialogPath;
            
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                dialogPath = dialog.SelectedPath;

                Utils.ForderAdd(dialogPath, lstfile);

                ListAdd();
            }
        }

        /// <summary>
        /// 화면 표출
        /// </summary>
        private void ListAdd()
        {
            foreach (FileInfo file in lstfile)
            {
                if (!List.Items.Contains(file.SafeName))
                {
                    List.Items.Add(file.SafeName);
                }
            }
        }

        /// <summary>
        /// 갯수만큼 앞문자 뒤로보내기
        /// </summary>
        private void FirstMove(object sender, EventArgs e)
        {
            if (List.Items.Count < 1)
            {
                MessageBox.Show("수정할 항목이 없습니다.");
                return;
            }

            FirstLastChange frm = new FirstLastChange();
            DialogResult result = frm.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ChangeList.Items.Clear();
                foreach (FileInfo file in lstfile)
                {
                    string oldName = file.Name;
                    string moveval = oldName.Substring(0, frm.Cnt);

                    oldName = oldName.Remove(0, frm.Cnt);

                    NameChange(file, oldName + moveval);

                    ChangeList.Items.Add(file.SafeName);
                }
            }
        }

        /// <summary>
        /// 이름지우기
        /// </summary>
        private void RemoveName(object sender, EventArgs e)
        {
            if (List.Items.Count < 1)
            {
                MessageBox.Show("수정할 항목이 없습니다.");
                return;
            }

            RemoveName frm = new RemoveName();
            DialogResult result = frm.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ChangeList.Items.Clear();
                foreach (FileInfo file in lstfile)
                {
                    string oldName = file.Name;
                    string newName = oldName.Remove(frm.StartCnt, frm.EndCnt);
                    NameChange(file, newName);

                    ChangeList.Items.Add(file.SafeName);
                }
            }
        }

        /// <summary>
        /// 이름변경
        /// </summary>
        private void ReName(object sender, EventArgs e)
        {
            if (List.Items.Count < 1)
            {
                MessageBox.Show("수정할 항목이 없습니다.");
                return;
            }

            frmNameChange frm = new frmNameChange();
            DialogResult result = frm.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ChangeList.Items.Clear();
                foreach (FileInfo file in lstfile)
                {
                    string name = file.Name;
                    name = name.Replace(frm.OldName, frm.NewName);
                    NameChange(file, name);

                    ChangeList.Items.Add(file.SafeName);
                }
            }
        }

        void mnuEtcRemove_Click(object sender, EventArgs e)
        {
            if (List.Items.Count < 1)
            {
                MessageBox.Show("수정할 항목이 없습니다.");
                return;
            }

            EtcRemove frm = new EtcRemove();
            DialogResult result = frm.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ChangeList.Items.Clear();
                foreach (FileInfo file in lstfile)
                {
                    string name = file.Name;
                    name = frm.Namechange(name);

                    ChangeList.Items.Add(file.SafeName);
                }
            }
        }

        /// <summary>
        /// 이름변경 적용
        /// </summary>
        private void NameChange(FileInfo file, string name)
        {
            file.Name = file.SafeName = file.FullName = string.Empty;
            file.Name = name;
            file.SafeName = file.Name + file.Extension;
            file.FullName = file.Path + file.SafeName;
        }
    }
}
