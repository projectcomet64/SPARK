using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using M64MM.Utils;
using static M64MM.Utils.Core;
using static CMTSpark.Looks;
using static M64MM.Utils.Looks;
using CMTSpark.Properties;

namespace CMTSpark
{
    public partial class AppearanceForm : Form
    {
        bool canStrobe = true;
        Random rand = new Random();

        public bool canRandom;

        public AppearanceForm()
        {
            InitializeComponent();
            long s04addr = SegmentedToVirtual(0x04000000, false);
            foreach (ColorPart cpart in xccDefaults)
            {
                cpart.light = cpart.default_light;
                cpart.dark = cpart.default_dark;
                shadowAddresses.Add((int)(s04addr + cpart.offset_86 + 8));
            }
            lbColors.DrawMode = DrawMode.OwnerDrawFixed;
            lbColors.ItemHeight = 16;
            lbColors.DataSource = xccDefaults;
        }

        void colorButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            colorDialog.Color = senderButton.BackColor;

            if (colorDialog.ShowDialog(this) != DialogResult.OK) return;
            if (!senderButton.Enabled) return;

            senderButton.BackColor = colorDialog.Color;
            marioSprite.Refresh();

            if ((!IsEmuOpen || BaseAddress == 0) && (modelStatus != ModelHeaderType.CLASSIC || modelStatus != ModelHeaderType.SPARK)
                && lbColors.SelectedItem == null) return;

            switch (senderButton.Name)
            {
                case "btnLightCol":
                    ((ColorPart)lbColors.SelectedItem).light = senderButton.BackColor;
                    break;
                case "btnDarkCol":
                    ((ColorPart)lbColors.SelectedItem).dark = senderButton.BackColor;
                    break;
            }
            WriteColorPart((ColorPart)lbColors.SelectedItem);
            lbColors.Refresh();
        }

        public static void WriteColorPart(ColorPart cPart)
        {
            byte[] colors_L = new byte[4];
            byte[] colors_D = new byte[4];

            colors_L[0] = cPart.light.R;
            colors_L[1] = cPart.light.G;
            colors_L[2] = cPart.light.B;
            colors_L[3] = 0x0;

            colors_D[0] = cPart.dark.R;
            colors_D[1] = cPart.dark.G;
            colors_D[2] = cPart.dark.B;
            colors_D[3] = 0x0;

            long seg04addr = SegmentedToVirtual(0x04000000, true);
            WriteBytes(seg04addr + cPart.offset_86, SwapEndian(colors_L, 4));
            WriteBytes(seg04addr + cPart.offset_88, SwapEndian(colors_D, 4));
            
        }

        void ApplyAllColors(bool defaults = false, bool refreshList = true)
        {
            if ((!IsEmuOpen || BaseAddress == 0) && (modelStatus != ModelHeaderType.CLASSIC || modelStatus != ModelHeaderType.SPARK)) return;
            foreach (ColorPart cPart in xccDefaults)
            {
                if (defaults)
                {
                    cPart.light = cPart.default_light;
                    cPart.dark = cPart.default_dark;
                }
                WriteColorPart(cPart);
            }
            btnLightCol.BackColor = ((ColorPart)lbColors.SelectedItem).light;
            btnDarkCol.BackColor = ((ColorPart)lbColors.SelectedItem).dark;
            if (refreshList)
            {
                lbColors_SelectedValueChanged(null, null);
                lbColors.Refresh();
            }
        }

        void OpenCopyPasteForm(object sender, EventArgs e)
        {
            CopyPasteForm form = new CopyPasteForm();

            Button senderButton = (Button)sender;

            if (senderButton.Name == btnImportCode.Name)
            {
                form.lblInfo.Text = "You are now importing a color code. Can be either CC or SCC.\nRemember to use the \"CC to SCC\" Transform if you're importing a CC.";

                form.ShowDialog(this);
            }
            else if (senderButton.Name == btnExportCode.Name)
            {
                form.lblInfo.Text = "Here's your CC.";
                form.btnCancel.Visible = false;
                form.tbColorCode.ReadOnly = true;
                form.tbColorCode.Lines = GenerateColorCode();

                form.ShowDialog(this);
            }
        }

        public void ParseColorCode(string code)
        {
            FromColorCode(code, ref xccDefaults, (byte)tbLeftRight.Value, (byte)tbBottomTop.Value, (byte)tbBackFront.Value);
            marioSprite.Refresh();
            lbColors.Refresh();
            ApplyAllColors();
        }

        public static void ChangeShadow(int amount, ShadowParts part)
        {
            byte[] data = new byte[1];
            data[0] = (byte)amount;

            foreach (int address in shadowAddresses)
            {
                switch (part)
                {
                    case ShadowParts.X:
                        WriteBytes(BaseAddress + address + 3, data);
                        break;
                    case ShadowParts.Y:
                        WriteBytes(BaseAddress + address + 2, data);
                        break;
                    case ShadowParts.Z:
                        WriteBytes(BaseAddress + address + 1, data);
                        break;
                }
            }
        }

        string[] GenerateColorCode()
        {
            List<string> code = new List<string>();
            // It's like this because I want color codes to be "universal" so if S04 ends up
            // being in another location I just subtract 0x7EC20 from each line
            long seg04Addr = 0x7EC20;
            foreach(ColorPart cPart in xccDefaults)
            {
                string[] addressToWrite = new string[2];
                addressToWrite[0] = (seg04Addr + cPart.offset_88).ToString("X6");
                addressToWrite[1] = (seg04Addr + cPart.offset_88+2).ToString("X6");
                code.Add("81" + addressToWrite[0] + " " + cPart.dark.R.ToString("X2") + cPart.dark.G.ToString("X2"));
                code.Add("81" + addressToWrite[1] + " " + cPart.dark.B.ToString("X2") + "00");
                addressToWrite[0] = (seg04Addr + cPart.offset_86).ToString("X6");
                addressToWrite[1] = (seg04Addr + cPart.offset_86+2).ToString("X6");
                code.Add("81" + addressToWrite[0] + " " + cPart.light.R.ToString("X2") + cPart.light.G.ToString("X2"));
                code.Add("81" + addressToWrite[1] + " " + cPart.light.B.ToString("X2") + "00");
            }
            return code.ToArray();
        }

        void ResetColors(object sender, EventArgs e)
        {
            marioSprite.Refresh();
            lbColors.Refresh();
            ApplyAllColors(true);
        }

        void LoadFromGame(object sender, EventArgs e)
        {
            if ((!IsEmuOpen || BaseAddress == 0) && modelStatus != M64MM.Utils.Looks.ModelHeaderType.CLASSIC) return;
            long seg04addr = SegmentedToVirtual(0x04000000, true);
            foreach (ColorPart cPart in xccDefaults)
            {
                byte[] colorData;
                colorData = Core.SwapEndian(ReadBytes(seg04addr + cPart.offset_86, 4), 4);
                cPart.light = Color.FromArgb(colorData[0], colorData[1], colorData[2]);
                colorData = SwapEndian(ReadBytes(seg04addr + cPart.offset_88, 4), 4);
                cPart.dark = Color.FromArgb(colorData[0], colorData[1], colorData[2]);
            }
            lbColors.Refresh();
            marioSprite.Refresh();
        }

        void marioSprite_DoubleClick(object sender, EventArgs e)
        {
            canRandom = !canRandom;
            lbColors.Refresh();
        }

        public void ExecuteRandomCC()
        {
            if (!canStrobe)
                return;
            foreach (ColorPart cPart in xccDefaults)
            {
                    cPart.light = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                    cPart.dark = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            }

            marioSprite.Refresh();
            ApplyAllColors(false, false);
        }

        void UpdateTrackbar(object sender, EventArgs e)
        {
            TrackBar changedBar = ((TrackBar)sender);
            ShadowParts part = ShadowParts.X;
            switch (changedBar.Name)
            {
                case "tbLeftRight":
                    part = ShadowParts.X;
                    break;
                case "tbBottomTop":
                    part = ShadowParts.Y;
                    break;
                case "tbBackFront":
                    part = ShadowParts.Z;
                    break;
            }
            ChangeShadow(changedBar.Value, part);
        }


        void ResetShadows(object sender, EventArgs e)
        {
            tbLeftRight.Value = 0x28;
            tbBottomTop.Value = 0x28;
            tbBackFront.Value = 0x28;
        }

        void RandomizeShadows(object sender, EventArgs e)
        {
            tbLeftRight.Value = rand.Next(-127, 128);
            tbBottomTop.Value = rand.Next(-127, 128);
            tbBackFront.Value = rand.Next(-127, 128);
        }

        private void lbColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            SolidBrush textColor = new SolidBrush(((Control)sender).ForeColor);
            SolidBrush SelectedColor = new SolidBrush(Color.White);
            SolidBrush lightColor = new SolidBrush(((ColorPart)lbColors.Items[e.Index]).light);
            SolidBrush darkColor = new SolidBrush(((ColorPart)lbColors.Items[e.Index]).dark);
            if (canRandom)
            {
                e.Graphics.DrawImageUnscaled(Resources.randomSlot, new Point(e.Bounds.X, e.Bounds.Y));
                e.Graphics.DrawImageUnscaled(Resources.randomSlot, new Point(e.Bounds.X+16, e.Bounds.Y));
            }
            else
            {
                e.Graphics.FillRectangle(lightColor, new Rectangle(new Point(e.Bounds.X, e.Bounds.Y), new Size(16, 16)));
                e.Graphics.FillRectangle(darkColor, new Rectangle(new Point(e.Bounds.X + 16, e.Bounds.Y), new Size(16, 16)));
            }
            e.Graphics.DrawString(((ColorPart)lbColors.Items[e.Index]).name, DefaultFont, ((ListBox)sender).SelectedIndex == e.Index ? SelectedColor : textColor, new Point(e.Bounds.X + 32, e.Bounds.Y));
        }

        private void lbColors_SelectedValueChanged(object sender, EventArgs e)
        {
            btnLightCol.BackColor = ((ColorPart)lbColors.SelectedItem).light;
            btnDarkCol.BackColor = ((ColorPart)lbColors.SelectedItem).dark;
            lbColors.Refresh();
        }

        private void btnTFCC2SCC_Click(object sender, EventArgs e)
        {
            ColorPart hatShirt = xccDefaults.Where(x => x.name == "Hat").FirstOrDefault();
            IEnumerable<ColorPart> hatTransform = xccDefaults.Where(x => x.name == "Arms" || x.name == "Shoulders" || x.name == "Shirt");

            ColorPart overall = xccDefaults.Where(x => x.name == "Overalls Top").FirstOrDefault();
            IEnumerable<ColorPart> overallTransform = xccDefaults.Where(x => x.name.StartsWith("Leg") || x.name == "Overalls Bottom");

            foreach(ColorPart cp in hatTransform)
            {
                cp.light = hatShirt.light;
                cp.dark = hatShirt.dark;
            }

            foreach (ColorPart cp in overallTransform)
            {
                cp.light = overall.light;
                cp.dark = overall.dark;
            }
            ApplyAllColors();
        }

        private void btnTFShirtPants_Click(object sender, EventArgs e)
        {
            ColorPart shirt = xccDefaults.Where(x => x.name == "Shirt").FirstOrDefault();
            ColorPart overall = xccDefaults.Where(x => x.name == "Overalls Top").FirstOrDefault();

            IEnumerable<ColorPart> shirtTransform = xccDefaults.Where(x => x.name == "Arms" || x.name == "Shoulders" || x.name == "Overalls Top");
            IEnumerable<ColorPart> overallTransform = xccDefaults.Where(x => x.name.StartsWith("Leg") || x.name == "Overalls Bottom");

            foreach (ColorPart cp in overallTransform)
            {
                cp.light = overall.light;
                cp.dark = overall.dark;
            }

            foreach (ColorPart cp in shirtTransform)
            {
                cp.light = shirt.light;
                cp.dark = shirt.dark;
            }
            ApplyAllColors();
        }

        private void btnTFShorties_Click(object sender, EventArgs e)
        {
            ColorPart skin = xccDefaults.Where(x => x.name == "Skin").FirstOrDefault();
            ColorPart legbottom = xccDefaults.Where(x => x.name == "Leg Bottom").FirstOrDefault();

            legbottom.light = skin.light;
            legbottom.dark = skin.dark;

            ApplyAllColors();
        }

        private void btnTFSCCSleeves_Click(object sender, EventArgs e)
        {
            ColorPart skin = xccDefaults.Where(x => x.name == "Skin").FirstOrDefault();
            ColorPart arm = xccDefaults.Where(x => x.name == "Arms").FirstOrDefault();

            arm.light = skin.light;
            arm.dark = skin.dark;

            ApplyAllColors();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnTFCustomRestore_Click(object sender, EventArgs e)
        {
            IEnumerable<ColorPart> customTransform = xccDefaults.Where(x => x.name.StartsWith("Custom"));

            foreach(ColorPart cPart in customTransform)
            {
                cPart.light = Color.White;
                cPart.dark = Color.FromArgb(128, 128, 128);
            }

            ApplyAllColors();
        }

        private void aboutSPARKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        private void epilepsyWarningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doubleclicking the SPARK icon will trigger the CC Randomizer. This is incredibly eyestraining.\nIt updates as fast as the game updates. If you have suffered from an epileptic seizure or are otherwise sensitive to strobing lights/flashing colors, look away and/or minimize PJ64 when using this function, or do not use it at all.\n\nDo you wish to disable this feature (for as long as you keep M64MM open) to avoid accidental double clicks?", "Epileptic seizure warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            canStrobe = (dr == DialogResult.No);
        }
    }
}
