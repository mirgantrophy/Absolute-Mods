namespace Absolute_Mods
{
    partial class RDRSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDRSP));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.OFD2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 1);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(451, 49);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.buttonItem3,
            this.buttonItem4});
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "Open";
            // 
            // itemContainer1
            // 
            this.itemContainer1.Name = "itemContainer1";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "Singleplayer Save";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Multiplayer Save";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.buttonItem5,
            this.buttonItem6});
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "Save";
            // 
            // itemContainer2
            // 
            this.itemContainer2.Name = "itemContainer2";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "Save Singleplayer File";
            this.buttonItem5.Click += new System.EventHandler(this.buttonItem5_Click);
            // 
            // buttonItem6
            // 
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "Save Multiplayer File";
            this.buttonItem6.Click += new System.EventHandler(this.buttonItem6_Click);
            // 
            // OFD1
            // 
            this.OFD1.Title = "Open your RDR Singleplayer save";
            // 
            // OFD2
            // 
            this.OFD2.Title = "Open your RDR Multiplayer Save";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(451, 217);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.labelX2);
            this.tabControlPanel1.Controls.Add(this.labelX1);
            this.tabControlPanel1.Controls.Add(this.textBoxX2);
            this.tabControlPanel1.Controls.Add(this.textBoxX1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(451, 191);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = -90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(12, 42);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Desired Money";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(12, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 20);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Current Money";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Location = new System.Drawing.Point(117, 43);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(121, 20);
            this.textBoxX2.TabIndex = 1;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(117, 17);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(121, 20);
            this.textBoxX1.TabIndex = 0;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.tabItem1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Silver;
            this.tabItem1.Text = "Single Player";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.labelX4);
            this.tabControlPanel2.Controls.Add(this.labelX3);
            this.tabControlPanel2.Controls.Add(this.textBoxX4);
            this.tabControlPanel2.Controls.Add(this.textBoxX3);
            this.tabControlPanel2.Controls.Add(this.listBox1);
            this.tabControlPanel2.Controls.Add(this.checkBoxX1);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(451, 191);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = -90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(156, 79);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(53, 20);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "New EXP";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(134, 53);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 20);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Current EXP";
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Location = new System.Drawing.Point(215, 79);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(100, 20);
            this.textBoxX4.TabIndex = 3;
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Location = new System.Drawing.Point(215, 53);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.ReadOnly = true;
            this.textBoxX3.Size = new System.Drawing.Size(100, 20);
            this.textBoxX3.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "01 - 0",
            "02 - 150",
            "03 - 510",
            "04 - 1080",
            "05 - 1860",
            "06 - 2050",
            "07 - 4050",
            "08 - 5460",
            "09 - 7080",
            "10 - 8910",
            "11 - 10950",
            "12 - 13290",
            "13 - 15930",
            "14 - 18870",
            "15 - 22110",
            "16 - 25650",
            "17 - 29490",
            "18 - 33630",
            "19 - 38070",
            "20 - 42810",
            "21 - 47850",
            "22 - 53190",
            "23 - 58830",
            "24 - 64770",
            "25 - 71010",
            "26 - 77550",
            "27 - 84930",
            "28 - 91530",
            "29 - 98970",
            "30 - 106710",
            "31 - 114810",
            "32 - 123270",
            "33 - 132090",
            "34 - 141270",
            "35 - 150810",
            "36 - 160710",
            "37 - 170970",
            "38 - 181590",
            "39 - 192570",
            "40 - 203910",
            "41 - 215610",
            "42 - 227670",
            "43 - 240090",
            "44 - 252870",
            "45 - 266010",
            "46 - 279510",
            "47 - 293370",
            "48 - 307590",
            "49 - 322170",
            "50 - 337110"});
            this.listBox1.Location = new System.Drawing.Point(321, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.Location = new System.Drawing.Point(12, 4);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(169, 28);
            this.checkBoxX1.TabIndex = 0;
            this.checkBoxX1.Text = "Unlock All Golden Weapons";
            this.checkBoxX1.CheckedChanged += new System.EventHandler(this.checkBoxX1_CheckedChanged);
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.tabItem2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Silver;
            this.tabItem2.Text = "Multiplayer";
            // 
            // RDRSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 267);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonBar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RDRSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Dead Multi Tool";
            this.Load += new System.EventHandler(this.RDRSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private System.Windows.Forms.OpenFileDialog OFD2;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private System.Windows.Forms.ListBox listBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}