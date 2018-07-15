using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents;
using System.Xml;
using PackageIO;
using X360;
using xPackage3;

namespace Absolute_Mods
{
    public partial class Home : DevComponents.DotNetBar.Office2007Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private void office2007StartButton1_Click(object sender, EventArgs e)
        {

        }
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.se7ensins.com");
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.absolutelygrim.x10.bz");
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.se7ensins.com/forums/index.php?app=core&module=global&section=register");
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.absolutelygrim.x10.bz/");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please contact me via email at absolutelygrim@aol.com");
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            {
                string downloadUrl = "http://www.mediafire.com/xzombeast#1,1";
                Version newVersion = null;
                string aboutUpdate = "";
                string xmlUrl = "http://www.absolutelygrim.x10.bz/updates/update.xml";
                XmlTextReader reader = null;
                try
                {
                    reader = new XmlTextReader(xmlUrl);
                    reader.MoveToContent();
                    string elementName = "";
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "appinfo"))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                elementName = reader.Name;
                            }
                            else
                            {
                                if ((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                                    switch (elementName)
                                    {
                                        case "version":
                                            newVersion = new Version(reader.Value);
                                            break;
                                        case "link":
                                            downloadUrl = reader.Value;
                                            break;
                                        case "about":
                                            aboutUpdate = reader.Value;
                                            break;
                                    }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(1);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
                Version applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                if (applicationVersion.CompareTo(newVersion) < 0)
                {
                    string str = String.Format("New version found!\nYour version: {0}.\nNewest version: {1}. \nAdded in this version: {2}. ", applicationVersion, newVersion, aboutUpdate);
                    if (DialogResult.No != MessageBox.Show(str + "\nWould you like to download this update?", "Check for updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("http://www.mediafire.com/xzombeast#1,1");
                            System.Diagnostics.Process.Start("http://www.absolutelygrim.x10.bz/updates");
                        }
                        catch { }
                        return;
                    }
                    else
                    {
                        ;
                    }
                }
                else
                {
                    MessageBox.Show("Your version: " + applicationVersion + "  is up to date.", "Check for Updates", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.se7ensins.com");
        }

        private void buttonItem13_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.se7ensins.com/forums/");
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.se7ensins.com/forums/index.php?app=core&module=global&section=register");
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.se7ensins.com/index.php/premium-tos");
        }

        private void reflectionImage2_Click(object sender, EventArgs e)
        {
            Form _2K11 = new _2K11();
            _2K11.Show();
        }

        private void reflectionImage3_Click(object sender, EventArgs e)
        {
            Form _2K10 = new _2K10();
            _2K10.Show();
        }

        private void reflectionImage4_Click(object sender, EventArgs e)
        {
            Form Signer = new Signer();
            Signer.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
        }

        private void ribbonBar5_ItemClick(object sender, EventArgs e)
        {

        }

        private void reflectionImage5_Click(object sender, EventArgs e)
        {
            Form RDRSP = new RDRSP();
            RDRSP.Show();
        }

        private void reflectionImage6_Click(object sender, EventArgs e)
        {
            Form MLB2K11 = new MLB2K11();
            MLB2K11.Show();
        }
    }
}
