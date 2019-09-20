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
    public partial class FirstLastChange : Form
    {
        private int _cnt;

        public int Cnt
        {
            get { return _cnt; }
            set { _cnt = value; }
        }

        public FirstLastChange()
        {
            InitializeComponent();

            btnOK.Click += OKClick;
        }

        void OKClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLeng.Text.Trim()))
            {
                Cnt = int.Parse(txtLeng.Text);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
