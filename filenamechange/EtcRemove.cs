using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filenamechange
{
    public partial class EtcRemove : Form
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
        Regex rex;

        public EtcRemove()
        {
            InitializeComponent();

            btnOK.Click += btnOK_Click;
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            string txt = txtinput.Text;
            if (txt.Length != 2)
            {
                MessageBox.Show("열고닫는 기호 두개를 입력해주세요");
                return;
            }

            char[] val = txt.ToArray();
            txt = "\\" + val[0].ToString() + "(.+)" + "\\" + val[1].ToString();
            //Console.WriteLine(txt);
            rex = new Regex(txt);
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        internal string Namechange(string oldname){

            NewName = rex.Replace(oldname, "");

            if (NewName.Substring(0, 1) == " ")
                NewName = NewName.Remove(0, 1);

            return NewName;
        }

    }
}
