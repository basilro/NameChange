using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filenamechange
{
    public partial class frmNameChange : Form
    {
        private string _oldname;
        private string _newname;

        public string OldName
        {
            get { return _oldname; }
            set { _oldname = value; }
        }
        public string NewName
        {
            get { return _newname; }
            set { _newname = value; }
        }

        public frmNameChange()
        {
            InitializeComponent();

            btnOK.Click += OKClick;
        }

        void OKClick(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtOldname.Text.Trim()) && string.IsNullOrEmpty(txtNewname.Text.Trim())))
            {
                OldName = txtOldname.Text;
                NewName = txtNewname.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
