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

namespace Absolute_Mods
{
    public partial class RDRSP : DevComponents.DotNetBar.Office2007Form
    {
        public RDRSP()
        {
            InitializeComponent();
        }

        private void RDRSP_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            try
            {
                OFD1.ShowDialog();
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0);
                reader.Position = 0x14136;
                textBoxX1.Text = reader.ReadInt32().ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            string FileName;
            OFD2.ShowDialog();
            FileName = OFD2.FileName;
            Reader reader = new Reader(FileName, Endian.Big, 0L);
            reader.Position = 0x0000D964;
            textBoxX3.Text = Convert.ToString(reader.ReadSingle());
            reader.Close();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            try
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0);
                writer.Position = 0x14136;
                writer.WriteInt32(int.Parse(textBoxX2.Text));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Finished. Be sure to rehash and resign");
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            System.IO.FileStream fs = null;
            System.IO.BinaryWriter bw = null;
            fs = new System.IO.FileStream(OFD2.FileName, System.IO.FileMode.OpenOrCreate);
            bw = new System.IO.BinaryWriter(fs);
            

            fs.Position = 0x18EAA;
                bw.Write(103);
            fs.Position = 0x18EAB;
                bw.Write(77);
            fs.Position = 0x18EAC;
                bw.Write(80);
            fs.Position = 0x18EAD;
                bw.Write(95);
            fs.Position = 0x18EAE;
                bw.Write(71);
            fs.Position = 0x18EAF; 
              bw.Write(111);
            fs.Position = 0x18EB0; 
              bw.Write(108);
            fs.Position = 0x18EB1; 
              bw.Write(100);
            fs.Position = 0x18EB2;
              bw.Write(101);
            fs.Position = 0x18EB3;
              bw.Write(110);
            fs.Position = 0x18EB4;
              bw.Write(87);
            fs.Position = 0x18EB5;
              bw.Write(101);
            fs.Position = 0x18EB6;
              bw.Write(97);
            fs.Position = 0x18EB7;
              bw.Write(112);
            fs.Position = 0x18EB8;
              bw.Write(111);
            fs.Position = 0x18EB9;
              bw.Write(1);
            fs.Position = 0x18EBA;
              bw.Write(1);
            fs.Position = 0x18EBB;
              bw.Write(0);
            fs.Position = 0x18EBC;
              bw.Write(0);
            fs.Position = 0x18EBD;
              bw.Write(0);
            fs.Position = 0x18EBE;
              bw.Write(-92);
            fs.Position = 0x18EBF;
              bw.Write(0);
            fs.Position = 0x18EC0;
              bw.Write(0);
            fs.Position = 0x18EC1;
              bw.Write(0);
            fs.Position = 0x18EC2;
              bw.Write(40);
            fs.Position = 0x18EC3;
              bw.Write(0);
            fs.Position = 0x18EC4;
              bw.Write(0);
            fs.Position = 0x18EC5;
              bw.Write(0);
            fs.Position = 0x18EC6;
              bw.Write(1);
            fs.Position = 0x18EC7;
              bw.Write(0);
            fs.Position = 0x18EC8;
              bw.Write(0);
            fs.Position = 0x18EC9;
              bw.Write(0);
            fs.Position = 0x18ECA;
              bw.Write(1);
            fs.Position = 0x18ECB;
              bw.Write(0);
            fs.Position = 0x18ECC;
              bw.Write(0);
            fs.Position = 0x18ECD;
              bw.Write(0);
            fs.Position = 0x18ECE;
              bw.Write(1);
            fs.Position = 0x18ECF;
              bw.Write(0);
            fs.Position = 0x18ED0;
              bw.Write(0);
            fs.Position = 0x18ED1;
              bw.Write(0);
            fs.Position = 0x18ED2;
              bw.Write(1);
            fs.Position = 0x18ED3;
              bw.Write(0);
            fs.Position = 0x18ED4;
              bw.Write(0);
            fs.Position = 0x18ED5;
              bw.Write(0);
            fs.Position = 0x18ED6;
              bw.Write(0);
            fs.Position = 0x18ED7;
              bw.Write(0);
            fs.Position = 0x18ED8;
              bw.Write(0);
            fs.Position = 0x18ED9;
              bw.Write(0);
            fs.Position = 0x18EDA;
              bw.Write(1);
            fs.Position = 0x18EDB;
              bw.Write(0);
            fs.Position = 0x18EDC;
              bw.Write(0);
            fs.Position = 0x18EDD;
              bw.Write(0);
            fs.Position = 0x18EDE;
              bw.Write(1);
            fs.Position = 0x18EDF;
              bw.Write(0);
            fs.Position = 0x18EE0;
              bw.Write(0);
            fs.Position = 0x18EE1;
              bw.Write(0);
            fs.Position = 0x18EE2;
              bw.Write(1);
            fs.Position = 0x18EE3;
              bw.Write(0);
            fs.Position = 0x18EE4;
              bw.Write(0);
            fs.Position = 0x18EE5;
              bw.Write(0);
            fs.Position = 0x18EE6;
              bw.Write(1);
            fs.Position = 0x18EE7;
              bw.Write(0);
            fs.Position = 0x18EE8;
              bw.Write(0);
            fs.Position = 0x18EE9;
              bw.Write(0);
            fs.Position = 0x18EEA;
              bw.Write(1);
            fs.Position = 0x18EEB;
              bw.Write(0);
            fs.Position = 0x18EEC;
              bw.Write(0);
            fs.Position = 0x18EED;
              bw.Write(0);
            fs.Position = 0x18EEE;
              bw.Write(1);
            fs.Position = 0x18EEF;
              bw.Write(0);
            fs.Position = 0x18EF0;
              bw.Write(0);
            fs.Position = 0x18EF1;
              bw.Write(0);
            fs.Position = 0x18EF2;
              bw.Write(1);
            fs.Position = 0x18EF3;
              bw.Write(0);
            fs.Position = 0x18EF4;
              bw.Write(0);
            fs.Position = 0x18EF5;
              bw.Write(0);
            fs.Position = 0x18EF6;
              bw.Write(1);
            fs.Position = 0x18EF7;
              bw.Write(0);
            fs.Position = 0x18EF8;
              bw.Write(0);
            fs.Position = 0x18EF9;
              bw.Write(0);
            fs.Position = 0x18EFA;
              bw.Write(1);
            fs.Position = 0x18EFB;
              bw.Write(0);
            fs.Position = 0x18EFC;
              bw.Write(0);
            fs.Position = 0x18EFD;
              bw.Write(0);
            fs.Position = 0x18EFE;
              bw.Write(1);
            fs.Position = 0x18EFF;
              bw.Write(0);
            fs.Position = 0x18F00;
              bw.Write(0);
            fs.Position = 0x18F01;
              bw.Write(0);
            fs.Position = 0x18F02;
              bw.Write(1);
            fs.Position = 0x18F03;
              bw.Write(0);
            fs.Position = 0x18F04;
              bw.Write(0);
            fs.Position = 0x18F05;
              bw.Write(0);
            fs.Position = 0x18F06;
              bw.Write(1);
            fs.Position = 0x18F07;
              bw.Write(0);
            fs.Position = 0x18F08;
              bw.Write(0);
            fs.Position = 0x18F09;
              bw.Write(0);
            fs.Position = 0x18F0A;
              bw.Write(1);
            fs.Position = 0x18F0B;
              bw.Write(0);
            fs.Position = 0x18F0C;
              bw.Write(0);
            fs.Position = 0x18F0D;
              bw.Write(0);
            fs.Position = 0x18F0E;
              bw.Write(1);
            fs.Position = 0x18F0F;
              bw.Write(0);
            fs.Position = 0x18F10;
              bw.Write(1);
            fs.Position = 0x18F11;
              bw.Write(0);
            fs.Position = 0x18F12;
              bw.Write(0);
            fs.Position = 0x18F13;
              bw.Write(1);
            fs.Position = 0x18F14;
              bw.Write(0);
            fs.Position = 0x18F15;
              bw.Write(0);
            fs.Position = 0x18F16;
              bw.Write(0);
            fs.Position = 0x18F17;
              bw.Write(1);
            fs.Position = 0x18F18;
              bw.Write(0);
            fs.Position = 0x18F19;
              bw.Write(0);
            fs.Position = 0x18F1A;
              bw.Write(0);
            fs.Position = 0x18F1B;
              bw.Write(0);
            fs.Position = 0x18F1C;
              bw.Write(0);
            fs.Position = 0x18F1D;
              bw.Write(0);
            fs.Position = 0x18F1E;
              bw.Write(0);
            fs.Position = 0x18F1F;
              bw.Write(0);
            fs.Position = 0x18F20;
              bw.Write(0);
            fs.Position = 0x18F21;
              bw.Write(0);
            fs.Position = 0x18F22;
              bw.Write(0);
            fs.Position = 0x18F23;
              bw.Write(0);
            fs.Position = 0x18F24;
              bw.Write(0);
            fs.Position = 0x18F25;
              bw.Write(0);
            fs.Position = 0x18F26;
              bw.Write(0);
            fs.Position = 0x18F27;
              bw.Write(0);
            fs.Position = 0x18F28;
              bw.Write(0);
            fs.Position = 0x18F29;
              bw.Write(0);
            fs.Position = 0x18F2A;
              bw.Write(0);
            fs.Position = 0x18F2B;
              bw.Write(0);
            fs.Position = 0x18F2C;
              bw.Write(0);
            fs.Position = 0x18F2D;
              bw.Write(0);
            fs.Position = 0x18F2E;
              bw.Write(0);
            fs.Position = 0x18F2F;
              bw.Write(0);
            fs.Position = 0x18F30;
              bw.Write(0);
            fs.Position = 0x18F31;
              bw.Write(0);
            fs.Position = 0x18F32;
              bw.Write(0);
            fs.Position = 0x18F33;
              bw.Write(0);
            fs.Position = 0x18F34;
              bw.Write(0);
             fs.Position = 0x18F35;
              bw.Write(0);
            fs.Position = 0x18F36;
              bw.Write(0);
            fs.Position = 0x18F37;
              bw.Write(0);
            fs.Position = 0x18F38;
              bw.Write(0);
            fs.Position = 0x18F39;
              bw.Write(0);
            fs.Position = 0x18F3A;
              bw.Write(0);
            fs.Position = 0x18F3B;
              bw.Write(0);
            fs.Position = 0x18F3C;
              bw.Write(0);
            fs.Position = 0x18F3D;
              bw.Write(0);
            fs.Position = 0x18F3E;
              bw.Write(0);
            fs.Position = 0x18F3F;
              bw.Write(0);
            fs.Position = 0x18F40;
              bw.Write(0);
            fs.Position = 0x18F41;
              bw.Write(0);
            fs.Position = 0x18F42;
              bw.Write(0);
            fs.Position = 0x18F43;
              bw.Write(0);
            fs.Position = 0x18F44;
              bw.Write(0);
            fs.Position = 0x18F45;
              bw.Write(0);
            fs.Position = 0x18F46;
              bw.Write(0);
            fs.Position = 0x18F47;
              bw.Write(0);
            fs.Position = 0x18F48;
              bw.Write(0);
            fs.Position = 0x18F49;
              bw.Write(0);
            fs.Position = 0x18F4A;
              bw.Write(0);
            fs.Position = 0x18F4B;
              bw.Write(0);
            fs.Position = 0x18F4C;
              bw.Write(0);
            fs.Position = 0x18F4D;
              bw.Write(0);
            fs.Position = 0x18F4E;
              bw.Write(0);
            fs.Position = 0x18F4F;
              bw.Write(0);
            fs.Position = 0x18F50;
              bw.Write(0);
            fs.Position = 0x18F51;
              bw.Write(0);
            fs.Position = 0x18F52;
              bw.Write(0);
            fs.Position = 0x18F53;
              bw.Write(0);
            fs.Position = 0x18F54;
              bw.Write(0);
            fs.Position = 0x18F55;
              bw.Write(0);
            fs.Position = 0x18F56;
              bw.Write(0);
            fs.Position = 0x18F57;
              bw.Write(0);
            fs.Position = 0x18F58;
              bw.Write(0);
            fs.Position = 0x18F59;
              bw.Write(0);
            fs.Position = 0x18F5A;
              bw.Write(0);
            fs.Position = 0x18F5B;
              bw.Write(0);
            fs.Position = 0x18F5C;
             bw.Write(0);
            fs.Position = 0x18F5D;
             bw.Write(0);
            fs.Position = 0x18F5E;
             bw.Write(0);
            fs.Position = 0x18F5F;
             bw.Write(0);
            fs.Position = 0x18F60;
             bw.Write(0);
            fs.Position = 0x18F61;
             bw.Write(0);
            fs.Position = 0x18F62;
             bw.Write(0);
            fs.Position = 0x18F63;
             bw.Write(0);
            fs.Position = 0x18F64;
             bw.Write(0);
            fs.Position = 0x18F65;
             bw.Write(13);

             fs.Close();
             bw.Close();
             MessageBox.Show("golden guns unlocked. Be sure to rehash and resign");
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            try
            {
                Writer writer = new Writer(OFD2.FileName, Endian.Big, 0L);
                writer.Position = 0x0000D964;
                writer.WriteSingle((float)Convert.ToSingle(textBoxX4.Text));
                writer.Close();
                MessageBox.Show("Saved, Please Rehash and Resign");
            }
            catch (Exception ex)
            {
                if (textBoxX4.Text.Contains(" "))
                {
                    MessageBox.Show("Do not add spaces");
                    return;
                }
                if (textBoxX4.Text == "")
                {
                    MessageBox.Show("Field is blank");
                    return;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxX4.Text = listBox1.Text.Remove(0, 5);
        }
    }
}
