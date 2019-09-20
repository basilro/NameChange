namespace filenamechange
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directory = new System.DirectoryServices.DirectoryEntry();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnFirstChange = new System.Windows.Forms.Button();
            this.btnGetFolder = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ChangeList = new System.Windows.Forms.ListBox();
            this.List = new System.Windows.Forms.ListBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btn_PathChange = new System.Windows.Forms.Button();
            this.chkIsPath = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuForderOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.작업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFirstChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNameChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPathChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEtcRemove = new System.Windows.Forms.Button();
            this.mnuInsert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetFile
            // 
            this.btnGetFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetFile.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGetFile.Location = new System.Drawing.Point(0, 123);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(103, 23);
            this.btnGetFile.TabIndex = 1;
            this.btnGetFile.Text = "파일 가져오기";
            this.btnGetFile.UseVisualStyleBackColor = true;
            // 
            // btnFirstChange
            // 
            this.btnFirstChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFirstChange.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFirstChange.Location = new System.Drawing.Point(0, 154);
            this.btnFirstChange.Name = "btnFirstChange";
            this.btnFirstChange.Size = new System.Drawing.Size(103, 23);
            this.btnFirstChange.TabIndex = 2;
            this.btnFirstChange.Text = "뒤로보내기";
            this.btnFirstChange.UseVisualStyleBackColor = true;
            // 
            // btnGetFolder
            // 
            this.btnGetFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetFolder.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGetFolder.Location = new System.Drawing.Point(0, 77);
            this.btnGetFolder.Name = "btnGetFolder";
            this.btnGetFolder.Size = new System.Drawing.Size(103, 23);
            this.btnGetFolder.TabIndex = 3;
            this.btnGetFolder.Text = "폴더 가져오기";
            this.btnGetFolder.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOK.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(0, 23);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "변경 적용";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ChangeList
            // 
            this.ChangeList.AllowDrop = true;
            this.ChangeList.FormattingEnabled = true;
            this.ChangeList.ItemHeight = 12;
            this.ChangeList.Location = new System.Drawing.Point(263, 99);
            this.ChangeList.Name = "ChangeList";
            this.ChangeList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ChangeList.Size = new System.Drawing.Size(204, 244);
            this.ChangeList.TabIndex = 6;
            // 
            // List
            // 
            this.List.AllowDrop = true;
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 12;
            this.List.Location = new System.Drawing.Point(109, 99);
            this.List.Name = "List";
            this.List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.List.Size = new System.Drawing.Size(148, 244);
            this.List.TabIndex = 7;
            // 
            // btnRename
            // 
            this.btnRename.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRename.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRename.Location = new System.Drawing.Point(0, 200);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(103, 23);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "이름변경";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemoveName.Location = new System.Drawing.Point(0, 177);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveName.TabIndex = 9;
            this.btnRemoveName.Text = "이름지우기(길이)";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            // 
            // btn_PathChange
            // 
            this.btn_PathChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PathChange.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_PathChange.Location = new System.Drawing.Point(0, 223);
            this.btn_PathChange.Name = "btn_PathChange";
            this.btn_PathChange.Size = new System.Drawing.Size(103, 23);
            this.btn_PathChange.TabIndex = 10;
            this.btn_PathChange.Text = "경로 변경";
            this.btn_PathChange.UseVisualStyleBackColor = true;
            // 
            // chkIsPath
            // 
            this.chkIsPath.AutoSize = true;
            this.chkIsPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkIsPath.Location = new System.Drawing.Point(0, 474);
            this.chkIsPath.Name = "chkIsPath";
            this.chkIsPath.Size = new System.Drawing.Size(103, 16);
            this.chkIsPath.TabIndex = 11;
            this.chkIsPath.Text = "경로보이기";
            this.chkIsPath.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(0, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "변경취소";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(0, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "선택제거";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mnuInsert);
            this.panel1.Controls.Add(this.mnuEtcRemove);
            this.panel1.Controls.Add(this.chkIsPath);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_PathChange);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.btnRemoveName);
            this.panel1.Controls.Add(this.btnFirstChange);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnGetFile);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnGetFolder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 498);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 8);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 8);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 8);
            this.panel2.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.작업ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(494, 24);
            this.menu.TabIndex = 16;
            this.menu.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuForderOpen,
            this.mnuClear,
            this.mnuExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(150, 22);
            this.mnuFileOpen.Text = "파일 가져오기";
            // 
            // mnuForderOpen
            // 
            this.mnuForderOpen.Name = "mnuForderOpen";
            this.mnuForderOpen.Size = new System.Drawing.Size(150, 22);
            this.mnuForderOpen.Text = "폴더 가져오기";
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(150, 22);
            this.mnuClear.Text = "초기화";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(150, 22);
            this.mnuExit.Text = "종료";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOk,
            this.mnuReturn,
            this.mnuDelete});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // mnuOk
            // 
            this.mnuOk.Name = "mnuOk";
            this.mnuOk.Size = new System.Drawing.Size(162, 22);
            this.mnuOk.Text = "변경적용";
            // 
            // mnuReturn
            // 
            this.mnuReturn.Name = "mnuReturn";
            this.mnuReturn.Size = new System.Drawing.Size(162, 22);
            this.mnuReturn.Text = "변경내역 초기화";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(162, 22);
            this.mnuDelete.Text = "선택제거";
            // 
            // 작업ToolStripMenuItem
            // 
            this.작업ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFirstChange,
            this.mnuRemoveName,
            this.mnuNameChange,
            this.mnuPathChange});
            this.작업ToolStripMenuItem.Name = "작업ToolStripMenuItem";
            this.작업ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.작업ToolStripMenuItem.Text = "작업";
            // 
            // mnuFirstChange
            // 
            this.mnuFirstChange.Name = "mnuFirstChange";
            this.mnuFirstChange.Size = new System.Drawing.Size(166, 22);
            this.mnuFirstChange.Text = "뒤로보내기";
            // 
            // mnuRemoveName
            // 
            this.mnuRemoveName.Name = "mnuRemoveName";
            this.mnuRemoveName.Size = new System.Drawing.Size(166, 22);
            this.mnuRemoveName.Text = "이름지우기(길이)";
            // 
            // mnuNameChange
            // 
            this.mnuNameChange.Name = "mnuNameChange";
            this.mnuNameChange.Size = new System.Drawing.Size(166, 22);
            this.mnuNameChange.Text = "이름변경";
            // 
            // mnuPathChange
            // 
            this.mnuPathChange.Name = "mnuPathChange";
            this.mnuPathChange.Size = new System.Drawing.Size(166, 22);
            this.mnuPathChange.Text = "경로 변경";
            // 
            // mnuEtcRemove
            // 
            this.mnuEtcRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuEtcRemove.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mnuEtcRemove.Location = new System.Drawing.Point(0, 246);
            this.mnuEtcRemove.Name = "mnuEtcRemove";
            this.mnuEtcRemove.Size = new System.Drawing.Size(103, 23);
            this.mnuEtcRemove.TabIndex = 17;
            this.mnuEtcRemove.Text = "특정기호문자제거";
            this.mnuEtcRemove.UseVisualStyleBackColor = true;
            // 
            // mnuInsert
            // 
            this.mnuInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnuInsert.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mnuInsert.Location = new System.Drawing.Point(0, 269);
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(103, 23);
            this.mnuInsert.TabIndex = 18;
            this.mnuInsert.Text = "위치문자추가";
            this.mnuInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.ChangeList);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "이름변경";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directory;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnFirstChange;
        private System.Windows.Forms.Button btnGetFolder;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox ChangeList;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btn_PathChange;
        private System.Windows.Forms.CheckBox chkIsPath;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuForderOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOk;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem 작업ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFirstChange;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveName;
        private System.Windows.Forms.ToolStripMenuItem mnuNameChange;
        private System.Windows.Forms.ToolStripMenuItem mnuPathChange;
        private System.Windows.Forms.Button mnuEtcRemove;
        private System.Windows.Forms.Button mnuInsert;
    }
}

