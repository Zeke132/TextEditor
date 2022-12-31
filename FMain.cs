using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextEditor
{
    public partial class FMain : Form
    {
        public string FileName;
        public FMain()
        {
            InitializeComponent();
            User.LoadFromFile("login.txt");
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Editor (";


            var f = new FLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Dispose();
            }
            else
            {
                Environment.Exit(0);
            }
            Text += User.CurrentUser.Power+")";
            toolStripLabel1.Text = User.CurrentUser.UserName + " HelloWorld";
            if (User.CurrentUser.Power=="Edit")
            {
                EnableEdit(true);
            }
            else
            {
                EnableEdit(false);
            }
        }
        public void EnableEdit(bool benable)
        {
            rich.ReadOnly = !benable;
            tolbtnCut.Enabled = benable;
            tolbtnPast.Enabled = benable;
            tolbtnisolite.Enabled = benable;
            tolbtnBold.Enabled = benable;
            tolbtnUnderLine.Enabled = benable;
            cbbFontsize.Enabled = benable;
            tolbtnNew.Enabled = benable;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f=new FAbout();
            f.ShowDialog();
            f.Dispose();
        }

        private void tolbtnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "文本文件|*.txt|所有文件|*.*";
            dlg.RestoreDirectory = true;
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileName = dlg.FileName;
                rich.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void tolbtnBold_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = rich.SelectionFont;
            if (oldFont == null) return;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            rich.SelectionFont = newFont;
            rich.Focus();

        }

        private void tolbtnisolite_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = rich.SelectionFont;
            if (oldFont == null) return;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            rich.SelectionFont = newFont;
            rich.Focus();
        }

        private void tolbtnUnderLine_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = rich.SelectionFont;
            if (oldFont == null) return;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            rich.SelectionFont = newFont;
            rich.Focus();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = rich.SelectionFont;
            if (oldFont == null) return;

                newFont = new Font(oldFont.FontFamily,int.Parse( cbbFontsize.Text),oldFont.Style);


            rich.SelectionFont = newFont;
            rich.Focus();
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tolbtnCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, rich.SelectedRtf);

            rich.SelectedRtf = "";
        }

        private void tolbtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, rich.SelectedRtf);
        }

        private void tolbtnPast_Click(object sender, EventArgs e)
        {
            rich.Paste();
        }
        /// <summary>
        /// save to rtf Files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tolbtnSave_Click(object sender, EventArgs e)
        {

            tolbtnSaveas.PerformClick();
        }

        private void tolbtnSaveas_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "rtf File| *.rtf";
            dlg.ShowDialog();

            string path = dlg.FileName;
            if (path == "")
            {
                return;
            }
            rich.SaveFile(path);
            MessageBox.Show("Save to File Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tolbtnNew_Click(object sender, EventArgs e)
        {
            rich.Clear();
        }
    }
}
