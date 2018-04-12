using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PackageIO;

namespace Absolute_Mods
{
    public partial class MLB2K11 : DevComponents.DotNetBar.Office2007Form
    {
        public MLB2K11()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                OFD1.ShowDialog();
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0);
                reader.Position = 0xD018;
                textBoxX1.Text = reader.ReadInt32().ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0);
                reader.Position = 0xD00C;
                textBoxX3.Text = reader.ReadInt32().ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0);
                reader.Position = 0xD010;
                textBoxX5.Text = reader.ReadInt32().ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0);
                reader.Position = 0xD014;
                textBoxX7.Text = reader.ReadInt32().ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0);
                writer.Position = 0xD018;
                writer.WriteInt32(int.Parse(textBoxX2.Text));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0);
                writer.Position = 0xD00C;
                writer.WriteInt32(int.Parse(textBoxX4.Text));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0);
                writer.Position = 0xD010;
                writer.WriteInt32(int.Parse(textBoxX6.Text));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0);
                writer.Position = 0xD014;
                writer.WriteInt32(int.Parse(textBoxX8.Text));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Finished Writing to offsets, be sure to rehash and resign");
        }

        private void MLB2K11_Load(object sender, EventArgs e)
        {

        }
    }
}



