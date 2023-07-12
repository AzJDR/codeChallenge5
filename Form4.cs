using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codeChallenge5
{
    public partial class FontPropertyChanger : Form
    {
        public FontPropertyChanger()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                fontList.Items.Add(font.Name.ToString());
            }


            //sir eto lang po yung mga available na font style and kahit Iconnect ko po sa listbox1 parang nothing happen lang po 
            foreach (FontStyle fontStyle in Enum.GetValues(typeof(FontStyle)))
            {
                fontStyleList.Items.Add(fontStyle.ToString());
            }

            int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in fontSizes)
            {
                sizes.Items.Add(size.ToString());
            }

            comboBox1.Items.Add("Western");
            comboBox1.Items.Add("Hebrew");
            comboBox1.Items.Add("Arabic");
            comboBox1.Items.Add("Greek");
            comboBox1.Items.Add("Turkish");
            comboBox1.Items.Add("Baltic");
            comboBox1.Items.Add("Central European");
            comboBox1.Items.Add("Cyrillic");
            comboBox1.Items.Add("Vietnamese");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtInput1.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                int index = fontList.FindString(searchText);
                if (index != ListBox.NoMatches)
                {
                    fontList.SelectedIndexChanged -= listBox1_SelectedIndexChanged; // Temporarily remove event handler
                    fontList.SetSelected(index, true);
                    fontList.TopIndex = index;
                    fontList.SelectedIndexChanged += listBox1_SelectedIndexChanged; // Reattach event handler
                }
                else
                {
                    fontList.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
                    fontList.ClearSelected();
                    fontList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
                }
            }
            else
            {
                fontList.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
                fontList.ClearSelected();
                fontList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fontList.SelectedItem != null)
                {
                    string selectedFont = fontList.SelectedItem.ToString();
                    label2.Font = new Font(selectedFont, label2.Font.Size, label2.Font.Style);
                    txtInput1.Text = selectedFont;
                    txtInput1.SelectAll();
                    txtInput1.Focus();
                }
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtInput2.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                int index = fontStyleList.FindString(searchText);
                if (index != ListBox.NoMatches)
                {
                    fontStyleList.SelectedIndexChanged -= listBox2_SelectedIndexChanged; // Temporarily remove event handler
                    fontStyleList.SetSelected(index, true);
                    fontStyleList.TopIndex = index;
                    fontStyleList.SelectedIndexChanged += listBox2_SelectedIndexChanged; // Reattach event handler
                }
                else
                {
                    fontStyleList.SelectedIndexChanged -= listBox2_SelectedIndexChanged;
                    fontStyleList.ClearSelected();
                    fontStyleList.SelectedIndexChanged += listBox2_SelectedIndexChanged;
                }
            }
            else
            {
                fontStyleList.SelectedIndexChanged -= listBox2_SelectedIndexChanged;
                fontStyleList.ClearSelected();
                fontStyleList.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fontStyleList.SelectedItem != null)
                {
                    string selectedStyle = fontStyleList.SelectedItem.ToString();
                    txtInput2.Text = selectedStyle;
                    txtInput2.SelectAll();
                    txtInput2.Focus();

                    FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), selectedStyle);

                    label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, fontStyle);
                }
            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtInput3.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                int index = sizes.FindString(searchText);
                if (index != ListBox.NoMatches)
                {
                    sizes.SelectedIndexChanged -= listBox3_SelectedIndexChanged; // Temporarily remove event handler
                    sizes.SetSelected(index, true);
                    sizes.TopIndex = index;
                    sizes.SelectedIndexChanged += listBox3_SelectedIndexChanged; // Reattach event handler
                }
                else
                {
                    sizes.SelectedIndexChanged -= listBox3_SelectedIndexChanged;
                    sizes.ClearSelected();
                    sizes.SelectedIndexChanged += listBox3_SelectedIndexChanged;
                }
            }
            else
            {
                sizes.SelectedIndexChanged -= listBox3_SelectedIndexChanged;
                sizes.ClearSelected();
                sizes.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sizes.SelectedItem != null)
                {
                    int selectedSize = int.Parse(sizes.SelectedItem.ToString());
                    txtInput3.Text = selectedSize.ToString();
                    txtInput3.SelectAll();
                    txtInput3.Focus();

                    label2.AutoSize = true;
                    label2.Font = new Font(label2.Font.FontFamily, selectedSize, label2.Font.Style);

                    label2.Width = label2.PreferredWidth;
                    label2.Height = label2.PreferredHeight;

                    label2.Anchor = AnchorStyles.None;
                    label2.Dock = DockStyle.None;
                    label2.Location = new Point((label2.Parent.Width - label2.Width) / 2, label2.Location.Y);



                }
            }
            catch { }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle labelFontStyle = label2.Font.Style;

            if (checkBox1.Checked)
            {
                labelFontStyle |= FontStyle.Strikeout;
            }
            else
            {
                labelFontStyle &= ~FontStyle.Strikeout;
            }

            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, labelFontStyle);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle labelFontStyle = label2.Font.Style;

            if (checkBox2.Checked)
            {
                labelFontStyle |= FontStyle.Underline;
            }
            else
            {
                labelFontStyle &= ~FontStyle.Underline;
            }


            label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, labelFontStyle);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedScript = comboBox1.SelectedItem.ToString();
            Font labelFont = label2.Font;

            switch (selectedScript)
            {
                case "Western":
                    labelFont = new Font(labelFont.FontFamily, labelFont.Size, label2.Font.Style);
                    break;
                case "Hebrew":
                    labelFont = new Font("Arial", labelFont.Size, FontStyle.Regular);
                    break;
                case "Arabic":
                    labelFont = new Font("Tahoma", labelFont.Size, FontStyle.Regular);
                    break;
                case "Greek":
                    labelFont = new Font("Times New Roman", labelFont.Size, FontStyle.Regular);
                    break;
                case "Turkish":
                    labelFont = new Font("Arial", labelFont.Size, FontStyle.Regular);
                    break;
                case "Baltic":
                    labelFont = new Font("Arial", labelFont.Size, FontStyle.Regular);
                    break;
                case "Central European":
                    labelFont = new Font("Arial", labelFont.Size, FontStyle.Regular);
                    break;
                case "Cyrillic":
                    labelFont = new Font("Arial", labelFont.Size, FontStyle.Regular);
                    break;
                case "Vietnamese":
                    labelFont = new Font("Arial", labelFont.Size, FontStyle.Regular);
                    break;
            }

            label2.Font = labelFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }
    }
}
