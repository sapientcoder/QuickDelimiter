using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickDelimiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDelimiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ConvertData();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertData();
        }

        private void ConvertData()
        {
            var cursor = Cursor;
            Cursor = Cursors.WaitCursor;

            string source = (txtSourceData.Text ?? "");

            string[] values = (
                from row in source.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                select (chkTrimSourceData.Checked ? row : row.Trim())
            ).ToArray();

            lblCount.Text = $"{values.Length} value(s)";

            txtOutput.Text = $"{txtPrefix.Text ?? ""}{string.Join(txtDelimiter.Text ?? "", values)}{txtSuffix.Text ?? ""}";

            Cursor = cursor;
        }

        private void btnCopyOutput_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            btnCopyOutput.Enabled = !string.IsNullOrEmpty(txtOutput.Text);
        }
    }
}
