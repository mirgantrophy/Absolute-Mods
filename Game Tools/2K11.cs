using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents;
using PackageIO;
using System.IO;


namespace Absolute_Mods
{
    public partial class _2K11 : DevComponents.DotNetBar.Office2007Form
    {
        public _2K11()
        {
            InitializeComponent();
        }

        private void _2K11_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OFD1.ShowDialog();
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0);
                reader.Position = 0x19A90;
                textBoxX1.Text = reader.ReadInt32().ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
             try
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0);
                writer.Position = 0x19A90;
                writer.WriteInt32(int.Parse(textBoxX2.Text));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Finished. Be sure to rehash and resign with Absolute Signer");
        }
    }
}

