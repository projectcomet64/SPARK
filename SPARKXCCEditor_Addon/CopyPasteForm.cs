using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMTSpark
{
    public partial class CopyPasteForm : Form
    {
        public CopyPasteForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Don't re-parse the color code if we're exporting
            if (tbColorCode.ReadOnly)
            {
                this.Close();
                return;
            }

            string wholeCode = "";
            for (int lineNum = 0; lineNum < tbColorCode.Lines.Length; lineNum++)
            {
                //Remove spaces from each line so they don't mess up the character count
                string line = tbColorCode.Lines[lineNum].Replace(" ", "");

                //If the line is empty, ignore it
                if (string.IsNullOrEmpty(line)) continue;

                //If each line isn't exactly 12 characters long, it's not a valid code
                if (line.Length != 12)
                {
                    string errorMsg = String.Format("{0}, {1}", lineNum + 1, line.Length > 12 ? "Too Long" : "Too Short");
                    MessageBox.Show(this, errorMsg, "Invalid CC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If the code tries to write data outside of where Mario's colors are located, it's not a valid code
                // Just do like CMTS and ignore it, then
                // (CC Cleanse)
                int address = int.Parse(line.Substring(2, 6), NumberStyles.HexNumber);
                if (address < 0x07EC20 || address > 0x080000)
                {
                    continue;
                }

                wholeCode += tbColorCode.Lines[lineNum] + (lineNum == tbColorCode.Lines.Length-1 ? "" : "\n");
            }

            ((AppearanceForm) this.Owner).ParseColorCode(wholeCode);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
