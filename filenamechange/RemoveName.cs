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
    public partial class RemoveName : Form
    {
        private int _startcnt;
        private int _endcnt;

        public int StartCnt
        {
            get { return _startcnt -1; }
            set { _startcnt = value; }
        }
        public int EndCnt
        {
            get { return _endcnt; }
            set { _endcnt = value; }
        }

        public RemoveName()
        {
            InitializeComponent();

            btnOK.Click += OKClick;
        }

        void OKClick(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtstart.Text.Trim()) && string.IsNullOrEmpty(txtend.Text.Trim())))
            {
                StartCnt = int.Parse(txtstart.Text);
                EndCnt = int.Parse(txtend.Text);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
