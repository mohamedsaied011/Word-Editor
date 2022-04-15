using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm1Word : Form
    {
        public frm1Word()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                cbxfont.Items.Add(font.Name);

            cbxfont.SelectedItem = "Arial";
        }

        private void setfont()
        {
            string strfont = "Arial";
            if (cbxfont.SelectedIndex >-1) strfont = cbxfont.SelectedItem.ToString();
            FontStyle fstyle = FontStyle.Regular;
            if (cbxb.Checked) fstyle = fstyle | FontStyle.Bold;
            if (cbxu.Checked) fstyle = fstyle | FontStyle.Underline;
            if (cbxi.Checked) fstyle = fstyle | FontStyle.Italic;

            Font myfont = new Font(strfont, (int)nudsize.Value, fstyle);
            txt.SelectionFont=myfont;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            setfont();
        }

        private void setColor(Color color )
        {

            if (rdotext.Checked) txt.SelectionColor = color;
            else txt.SelectionBackColor = color;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            setColor( ((Panel)sender).BackColor );
        }

        private void btnmore_Click(object sender, EventArgs e)
        {
            ColorDialog cDiag = new ColorDialog();
            if (cDiag.ShowDialog() == DialogResult.OK)
                setColor(cDiag.Color);
        }
    }
}
