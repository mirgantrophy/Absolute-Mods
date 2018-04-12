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
    public partial class _2K10 : DevComponents.DotNetBar.Office2007Form
    {
        public _2K10()
        {
            InitializeComponent();
        }

        private void _2K10_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            try //tries to do the following noted with //
            {
                OFD1.ShowDialog(); //Opens the file dialog
                PackageIO.Reader reader = new PackageIO.Reader(OFD1.FileName, Endian.Big, 0); //Opens the Offset reader
                reader.Position = 0x12FB0; //Starts reading the offset at 19A90
                textBoxX1.Text = reader.ReadInt32().ToString(); //Prints the current offset to an Int32 integer
                reader.Close(); //closes the reader so you can recall it or don't get file in use error
            }
            catch (Exception ex) //logs the error
            {
                MessageBox.Show(ex.Message); //shows the error message if something happens while opening
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
             try //tries to do the following noted with
            {
                PackageIO.Writer writer = new PackageIO.Writer(OFD1.FileName, Endian.Big, 0); //creates a new Endian File writer
                writer.Position = 0x12FB0; //starts writing to the offset at 19A90
                writer.WriteInt32(int.Parse(textBoxX2.Text)); //converts your typed code to Int32 and writes to the file
                writer.Close(); //closes the writer so file in use error doesn't occur
            }
            catch (Exception ex) //logs the error
            {
                MessageBox.Show(ex.Message); //shows the error message if something is wrong
            }
            MessageBox.Show("Finished. Be sure to rehash and resign with Absolute"); //reminder to user about rehashing and resigning
        }
     }
 }
  
