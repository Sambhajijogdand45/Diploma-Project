using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System.Diagnostics;
using System.IO;
using MyDownloader.App;
using MyDownloader.Core;
using MyDownloader.Extension;
using MyDownloader.IEPlugin;
using MyDownloader.Spider;
using NLSFT_WB;

namespace Ribbonpad
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        #region Component Ctreate

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private DevComponents.DotNetBar.TabStrip tabStrip1;
		private System.ComponentModel.IContainer components;
		private BalloonSearch m_Search=null;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.LabelItem labelStatus;
		internal DevComponents.DotNetBar.LabelItem labelPosition;
		private DevComponents.DotNetBar.RibbonControl ribbonControl1;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
		private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
		private DevComponents.DotNetBar.ComboBoxItem comboFont;
		private DevComponents.DotNetBar.ComboBoxItem comboFontSize;
		private DevComponents.DotNetBar.ItemContainer itemContainer2;
		private DevComponents.DotNetBar.ItemContainer itemContainer3;
		private DevComponents.DotNetBar.ButtonItem buttonFontItalic;
		private DevComponents.DotNetBar.ButtonItem buttonFontUnderline;
		private DevComponents.DotNetBar.ButtonItem buttonFontStrike;
		private DevComponents.DotNetBar.ColorPickerDropDown buttonTextColor;
		private DevComponents.DotNetBar.ButtonItem buttonAlignLeft;
		private DevComponents.DotNetBar.ButtonItem buttonAlignCenter;
        private DevComponents.DotNetBar.ButtonItem buttonAlignRight;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.ButtonItem buttonItem4;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.ItemContainer itemContainer6;
		private DevComponents.DotNetBar.ItemContainer itemContainer7;
		private DevComponents.DotNetBar.ItemContainer itemContainer8;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
		private DevComponents.DotNetBar.ButtonItem buttonFontBold;
		private DevComponents.Editors.ComboItem comboItem1;
		private DevComponents.Editors.ComboItem comboItem2;
		private DevComponents.Editors.ComboItem comboItem3;
		private DevComponents.Editors.ComboItem comboItem4;
		private DevComponents.Editors.ComboItem comboItem5;
		private DevComponents.Editors.ComboItem comboItem6;
		private DevComponents.Editors.ComboItem comboItem7;
		private DevComponents.Editors.ComboItem comboItem8;
		private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItemFS10;
        private DevComponents.Editors.ComboItem comboItemFS11;
        private DevComponents.Editors.ComboItem comboItemFS12;
        private DevComponents.Editors.ComboItem comboItemFS13;
        private DevComponents.Editors.ComboItem comboItemFS14;
        private DevComponents.Editors.ComboItem comboItemFS15;
        private DevComponents.Editors.ComboItem comboItemFS16;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
         
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabContext;
		private DevComponents.DotNetBar.SuperTooltip superTooltip1;
		private DevComponents.DotNetBar.ItemContainer itemContainer9;
		private DevComponents.DotNetBar.ButtonItem buttonItem13;
		private DevComponents.DotNetBar.ButtonItem buttonItem14;
		private DevComponents.DotNetBar.ButtonItem buttonItem15;
		private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
		private DevComponents.DotNetBar.ButtonItem buttonItem20;
        private DevComponents.DotNetBar.ButtonItem buttonItem21;
		private DevComponents.DotNetBar.ButtonItem buttonItem25;
		private DevComponents.DotNetBar.LabelItem labelItem8;
		private DevComponents.DotNetBar.ButtonItem buttonItem26;
		private DevComponents.DotNetBar.ButtonItem buttonItem27;
		private DevComponents.DotNetBar.ButtonItem buttonItem28;
		private DevComponents.DotNetBar.ButtonItem buttonItem29;
		private DevComponents.DotNetBar.ButtonItem buttonFileSaveAs;
		private DevComponents.DotNetBar.ItemContainer menuFileContainer;
		private DevComponents.DotNetBar.ItemContainer menuFileTwoColumnContainer;
		private DevComponents.DotNetBar.ItemContainer menuFileItems;
		private DevComponents.DotNetBar.ItemContainer menuFileMRU;
		private DevComponents.DotNetBar.ItemContainer menuFileBottomContainer;
		private DevComponents.DotNetBar.ButtonItem buttonOptions;
        private DevComponents.DotNetBar.ButtonItem buttonExit;
		private System.Windows.Forms.Timer progressBarTimer;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
		private DevComponents.DotNetBar.SliderItem zoomSlider;
		private DevComponents.DotNetBar.ItemContainer itemContainer13;
		private Command AppCommandNew;
		private Command AppCommandOpen;
		private Command AppCommandSave;
		private Command AppCommandSaveAs;
		private Command AppCommandTheme;
        private Command AppCommandExit;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private Command AppCommandGoToUrl;
        private Command RibbonStateCommand;
        private RibbonBar ribbonBar4;
        private ButtonItem buttonFind;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.Editors.ComboItem comboItem13;
        private DevComponents.Editors.ComboItem comboItem14;
        private DevComponents.Editors.ComboItem comboItem15;
        private DevComponents.Editors.ComboItem comboItem16;
        private DevComponents.Editors.ComboItem comboItem17;
        private DevComponents.Editors.ComboItem comboItem18;
        private GalleryContainer galleryContainer1;
        private ButtonItem buttonItem47;
        private ButtonItem buttonItem48;
        private ButtonItem buttonItem49;
        private ButtonItem buttonItem18;
        private ButtonItem buttonItem19;
        private ButtonItem buttonItem22;
        private ButtonItem buttonItem30;
        private ButtonItem buttonItem31;
        private ButtonItem buttonItem32;
        private ButtonItem buttonItem33;
        private ButtonItem buttonItem34;
        private ButtonItem buttonItem35;
        private ButtonItem buttonItem36;
        private ButtonItem buttonItem37;
        private ButtonItem buttonItem38;
        private ButtonItem buttonItem39;
        private ButtonItem buttonItem40;
        private ButtonItem buttonItem41;
        private ButtonItem buttonItem42;
        private ButtonItem buttonItem43;
        private ButtonItem buttonItem44;
        private ButtonItem buttonItem45;
        private ButtonItem buttonItem46;
        private ButtonItem buttonItem60;
        private ButtonItem buttonItem62;
        private ButtonItem buttonItem79;
        private ItemContainer itemContainer11;
        private ButtonItem buttonItem80;
        private ButtonItem buttonItem81;
        private ButtonItem buttonItem82;
        private DevComponents.Editors.ComboItem comboItem28;
        private DevComponents.Editors.ComboItem comboItem29;
        private DevComponents.Editors.ComboItem comboItem30;
        private DevComponents.Editors.ComboItem comboItem31;
        private DevComponents.Editors.ComboItem comboItem32;
        private DevComponents.Editors.ComboItem comboItem33;
        private DevComponents.Editors.ComboItem comboItem34;
        private DevComponents.Editors.ComboItem comboItem35;
        private DevComponents.Editors.ComboItem comboItem36;
        private DevComponents.Editors.ComboItem comboItem19;
        private DevComponents.Editors.ComboItem comboItem20;
        private DevComponents.Editors.ComboItem comboItem21;
        private DevComponents.Editors.ComboItem comboItem22;
        private DevComponents.Editors.ComboItem comboItem23;
        private DevComponents.Editors.ComboItem comboItem24;
        private DevComponents.Editors.ComboItem comboItem25;
        private DevComponents.Editors.ComboItem comboItem26;
        private DevComponents.Editors.ComboItem comboItem27;
        private ItemContainer itemContainer10;
        private ComboBoxItem comboBoxItem3;
        private ComboBoxItem comboBoxItem4;
        private DevComponents.Editors.ComboItem comboItem37;
        private DevComponents.Editors.ComboItem comboItem38;
        private DevComponents.Editors.ComboItem comboItem39;
        private DevComponents.Editors.ComboItem comboItem40;
        private DevComponents.Editors.ComboItem comboItem41;
        private DevComponents.Editors.ComboItem comboItem42;
        private DevComponents.Editors.ComboItem comboItem43;
        private DevComponents.Editors.ComboItem comboItem44;
        private DevComponents.Editors.ComboItem comboItem45;
        private ItemContainer itemContainer16;
        private ButtonItem buttonItem88;
        private ButtonItem buttonItem89;
        private ButtonItem buttonItem90;
        private ButtonItem buttonItem91;
        private ColorPickerDropDown colorPickerDropDown2;
        private ItemContainer itemContainer17;
        private ItemContainer itemContainer18;
        private ButtonItem buttonItem92;
        private ButtonItem buttonItem93;
        private ButtonItem buttonItem94;
        private ButtonItem buttonItem95;
        private ItemContainer itemContainer21;
        private ButtonItem buttonItem96;
        private ButtonItem buttonItem97;
        private ButtonItem buttonItem98;
        private ButtonItem buttonItem99;
        private ItemContainer itemContainer22;
        private ButtonItem buttonItem100;
        private ButtonItem buttonItem101;
        private ItemContainer itemContainer19;
        private ComboBoxItem comboBoxItem5;
        private ItemContainer itemContainer20;
        private ButtonItem buttonItem102;
        private ButtonItem buttonItem103;
        private ButtonItem buttonItem104;
        private ItemContainer itemContainer23;
        private ButtonItem buttonItem53;
        private ButtonItem buttonItem54;
        private ButtonItem buttonItem105;
        private ButtonItem buttonItem106;
        private ButtonItem buttonItem107;
        private ButtonItem buttonItem108;
        private ItemContainer itemContainer24;
        private ButtonItem buttonItem109;
        private ButtonItem buttonItem110;
        private ButtonItem Delete;
        private ButtonItem buttonItem112;
        private ButtonItem buttonItem113;
        private ButtonItem buttonItem114;
        private ItemContainer itemContainer25;
        private ButtonItem buttonItem111;
        private ButtonItem buttonItem115;
        private ButtonItem buttonItem116;
        private ButtonItem buttonItem117;
        private ButtonItem buttonItem118;
        private ButtonItem buttonItem123;
        private ButtonItem buttonItem124;
        private ButtonItem buttonItem125;
        private ButtonItem buttonItem126;
        private ButtonItem buttonItem119;
        private ButtonItem buttonItem120;
        private ItemContainer itemContainer26;
        private ButtonItem buttonItem121;
        private ItemContainer itemContainer27;
        private ButtonItem buttonItem127;
        private RibbonPanel ribbonPanel5;
        private RibbonBar ribbonBar9;
        private RibbonBar ribbonBar16;
        private ItemContainer itemContainer15;
        private ItemContainer itemContainer28;
        private ButtonItem buttonItem69;
        private ButtonItem buttonItem70;
        private ButtonItem buttonItem71;
        private ItemContainer itemContainer29;
        private RibbonBar ribbonBar17;
        private DevComponents.Editors.ComboItem comboItem46;
        private DevComponents.Editors.ComboItem comboItem47;
        private DevComponents.Editors.ComboItem comboItem48;
        private DevComponents.Editors.ComboItem comboItem49;
        private DevComponents.Editors.ComboItem comboItem50;
        private DevComponents.Editors.ComboItem comboItem51;
        private DevComponents.Editors.ComboItem comboItem52;
        private DevComponents.Editors.ComboItem comboItem53;
        private DevComponents.Editors.ComboItem comboItem54;
        private ItemContainer itemContainer32;
        private ButtonItem buttonItem122;
        private ButtonItem buttonItem128;
        private ButtonItem buttonItem129;
        private ButtonItem buttonItem130;
        private RibbonBar ribbonBar18;
        private ButtonItem buttonItem131;
        private ButtonItem buttonItem132;
        private ButtonItem buttonItem133;
		private DevComponents.DotNetBar.Office2007StartButton buttonFile;
        #endregion

        private RibbonBar ribbonBar1;
        private ButtonItem buttonPaste;
        private ItemContainer itemContainer34;
        private ButtonItem buttonCut;
        private ButtonItem bCopy;
        private ButtonItem buttonItem147;
        private ButtonItem buttonItem134;
        private ButtonItem buttonItem135;
        private ButtonItem buttonItem150;
        private ButtonItem buttonItem151;
        private ButtonItem buttonItem152;
        private ButtonItem buttonItem153;
        private ButtonItem buttonItem154;
        private ButtonItem buttonItem156;
        private ItemContainer itemContainer33;
        private ButtonItem buttonItem161;
        private ItemContainer itemContainer31;
        private ButtonItem buttonItem64;
        private ButtonItem buttonItem65;
        private ButtonItem buttonItem66;
        private ButtonItem buttonItem67;
        private ButtonItem buttonItem61;
        private ButtonItem buttonItem63;
        private ItemContainer itemContainer30;
        private ButtonItem buttonItem74;
        private ItemContainer itemContainer35;
        private ItemContainer itemContainer36;
        private ItemContainer itemContainer37;
        private ButtonItem buttonItem78;
        private ButtonItem buttonItem144;
        private ButtonItem buttonItem143;
        private ItemContainer itemContainer38;
        private ButtonItem buttonItem68;
        private ButtonItem buttonItem75;
        private ButtonItem buttonItem76;
        private ButtonItem buttonItem1;
        private ButtonItem buttonItem8;
        private ButtonItem buttonItem12;

        public static Boolean richTextOpened = false;
        frmMainRTE objfrmMainRTE = null;
        private ButtonItem buttonItem136;
        private ButtonItem buttonItem72;
        private OpenFileDialog openFileDialog2;
        private ItemContainer itemContainer14;
        private ButtonItem buttonItem142;
        private ItemContainer itemContainer39;
        private ButtonItem buttonItem148;
        private ItemContainer itemContainer40;
        private ButtonItem buttonItem149;
        private ButtonItem buttonItem155;
        private ButtonItem buttonItem157;
        private ButtonItem buttonItem55;
        private ButtonItem buttonItem83;
        private ButtonItem buttonItem84;
        private ButtonItem buttonItem137;
        private ButtonItem buttonItem73;
        private OpenFileDialog openFileDialog3;
        private RibbonBar ribbonBar5;
        private ButtonItem buttonMargins;
        private ButtonItem buttonItem9;
        private ButtonItem buttonItem50;
        private ButtonItem buttonItem51;
        private ButtonItem buttonItem52;
        private ButtonItem buttonItem10;
        private ButtonItem buttonItem11;
        private ButtonItem buttonItem6;
        private ButtonItem buttonItem7;
        private ButtonItem buttonItem23;
        private ButtonItem buttonItem24;
        public static frmMain objfrmMain = null;
        private ButtonItem buttonItem56;
        private ButtonItem buttonItem57;
        Form1 formExcel = new Form1();

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			
            SetupBackstageContent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelStatus = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.labelPosition = new DevComponents.DotNetBar.LabelItem();
            this.zoomSlider = new DevComponents.DotNetBar.SliderItem();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonMargins = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem50 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem51 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem52 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonFind = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonAlignLeft = new DevComponents.DotNetBar.ButtonItem();
            this.buttonAlignCenter = new DevComponents.DotNetBar.ButtonItem();
            this.buttonAlignRight = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem73 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.comboFont = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboFontSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItemFS10 = new DevComponents.Editors.ComboItem();
            this.comboItemFS11 = new DevComponents.Editors.ComboItem();
            this.comboItemFS12 = new DevComponents.Editors.ComboItem();
            this.comboItemFS13 = new DevComponents.Editors.ComboItem();
            this.comboItemFS14 = new DevComponents.Editors.ComboItem();
            this.comboItemFS15 = new DevComponents.Editors.ComboItem();
            this.comboItemFS16 = new DevComponents.Editors.ComboItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonFontBold = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontItalic = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontUnderline = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFontStrike = new DevComponents.DotNetBar.ButtonItem();
            this.buttonTextColor = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonPaste = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer34 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonCut = new DevComponents.DotNetBar.ButtonItem();
            this.bCopy = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem147 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar16 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer15 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer28 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem69 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem70 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem71 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer29 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem137 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar17 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer32 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem63 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem122 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem128 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem129 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem130 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer33 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem161 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem61 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar18 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem131 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer35 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer36 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem132 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem133 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer30 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem134 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem135 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer38 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem68 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem75 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem150 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem151 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem156 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem152 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem153 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem154 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem76 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.menuFileContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileTwoColumnContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileItems = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandNew = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandOpen = new DevComponents.DotNetBar.Command(this.components);
            this.buttonFileSaveAs = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandSaveAs = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
            this.menuFileMRU = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem26 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem27 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem28 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem29 = new DevComponents.DotNetBar.ButtonItem();
            this.menuFileBottomContainer = new DevComponents.DotNetBar.ItemContainer();
            this.buttonOptions = new DevComponents.DotNetBar.ButtonItem();
            this.buttonExit = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandExit = new DevComponents.DotNetBar.Command(this.components);
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabContext = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem155 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem157 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem55 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem83 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem84 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem56 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem57 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer25 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem111 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem115 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem116 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem117 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem118 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem123 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem124 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem125 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem126 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem119 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem120 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer26 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem121 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer27 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem127 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer24 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem109 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem110 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.Delete = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem112 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem113 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem114 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer23 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem53 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem54 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem105 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem106 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem107 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem108 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer19 = new DevComponents.DotNetBar.ItemContainer();
            this.comboBoxItem5 = new DevComponents.DotNetBar.ComboBoxItem();
            this.itemContainer20 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem102 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem103 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem104 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer17 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer18 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem92 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem93 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem94 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem95 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer21 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem96 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem97 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem98 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem99 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer22 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem100 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem101 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.comboBoxItem3 = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboBoxItem4 = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem37 = new DevComponents.Editors.ComboItem();
            this.comboItem38 = new DevComponents.Editors.ComboItem();
            this.comboItem39 = new DevComponents.Editors.ComboItem();
            this.comboItem40 = new DevComponents.Editors.ComboItem();
            this.comboItem41 = new DevComponents.Editors.ComboItem();
            this.comboItem42 = new DevComponents.Editors.ComboItem();
            this.comboItem43 = new DevComponents.Editors.ComboItem();
            this.comboItem44 = new DevComponents.Editors.ComboItem();
            this.comboItem45 = new DevComponents.Editors.ComboItem();
            this.itemContainer16 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem88 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem89 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem90 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem91 = new DevComponents.DotNetBar.ButtonItem();
            this.colorPickerDropDown2 = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.buttonItem60 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem62 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem79 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer11 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem80 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem81 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem82 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command(this.components);
            this.AppCommandGoToUrl = new DevComponents.DotNetBar.Command(this.components);
            this.itemContainer40 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem149 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandSave = new DevComponents.DotNetBar.Command(this.components);
            this.itemContainer39 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem148 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer14 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem142 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.buttonItem47 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem48 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem49 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem22 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem30 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem31 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem32 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem33 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem34 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem35 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem36 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem37 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem38 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem39 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem40 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem41 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem42 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem43 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem44 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem45 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem46 = new DevComponents.DotNetBar.ButtonItem();
            this.comboItem46 = new DevComponents.Editors.ComboItem();
            this.comboItem47 = new DevComponents.Editors.ComboItem();
            this.comboItem48 = new DevComponents.Editors.ComboItem();
            this.comboItem49 = new DevComponents.Editors.ComboItem();
            this.comboItem50 = new DevComponents.Editors.ComboItem();
            this.comboItem51 = new DevComponents.Editors.ComboItem();
            this.comboItem52 = new DevComponents.Editors.ComboItem();
            this.comboItem53 = new DevComponents.Editors.ComboItem();
            this.comboItem54 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.comboItem13 = new DevComponents.Editors.ComboItem();
            this.comboItem14 = new DevComponents.Editors.ComboItem();
            this.comboItem15 = new DevComponents.Editors.ComboItem();
            this.comboItem16 = new DevComponents.Editors.ComboItem();
            this.comboItem17 = new DevComponents.Editors.ComboItem();
            this.comboItem18 = new DevComponents.Editors.ComboItem();
            this.RibbonStateCommand = new DevComponents.DotNetBar.Command(this.components);
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.buttonItem67 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem66 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem65 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem64 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem74 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem78 = new DevComponents.DotNetBar.ButtonItem();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.comboItem19 = new DevComponents.Editors.ComboItem();
            this.comboItem20 = new DevComponents.Editors.ComboItem();
            this.comboItem21 = new DevComponents.Editors.ComboItem();
            this.comboItem22 = new DevComponents.Editors.ComboItem();
            this.comboItem23 = new DevComponents.Editors.ComboItem();
            this.comboItem24 = new DevComponents.Editors.ComboItem();
            this.comboItem25 = new DevComponents.Editors.ComboItem();
            this.comboItem26 = new DevComponents.Editors.ComboItem();
            this.comboItem27 = new DevComponents.Editors.ComboItem();
            this.comboItem28 = new DevComponents.Editors.ComboItem();
            this.comboItem29 = new DevComponents.Editors.ComboItem();
            this.comboItem30 = new DevComponents.Editors.ComboItem();
            this.comboItem31 = new DevComponents.Editors.ComboItem();
            this.comboItem32 = new DevComponents.Editors.ComboItem();
            this.comboItem33 = new DevComponents.Editors.ComboItem();
            this.comboItem34 = new DevComponents.Editors.ComboItem();
            this.comboItem35 = new DevComponents.Editors.ComboItem();
            this.comboItem36 = new DevComponents.Editors.ComboItem();
            this.itemContainer31 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer37 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem144 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem143 = new DevComponents.DotNetBar.ButtonItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonItem136 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem72 = new DevComponents.DotNetBar.ButtonItem();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.rtf";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.Title = "Open File";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.rtf";
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.Title = "Save File";
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonOnTabsVisible = true;
            this.tabStrip1.CloseButtonVisible = false;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Location = new System.Drawing.Point(5, 150);
            this.tabStrip1.MdiForm = this;
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip1.Size = new System.Drawing.Size(931, 26);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip1.TabIndex = 6;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.Text = "tabStrip1";
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelStatus,
            this.itemContainer9,
            this.progressBarItem1,
            this.itemContainer13});
            this.bar1.ItemSpacing = 2;
            this.bar1.Location = new System.Drawing.Point(5, 477);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(931, 21);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "barStatus";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.PaddingLeft = 2;
            this.labelStatus.PaddingRight = 2;
            this.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelStatus.Stretch = true;
            // 
            // itemContainer9
            // 
            // 
            // 
            // 
            this.itemContainer9.BackgroundStyle.Class = "";
            this.itemContainer9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer9.BeginGroup = true;
            this.itemContainer9.Name = "itemContainer9";
            this.itemContainer9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem13,
            this.buttonItem14,
            this.buttonItem15,
            this.buttonItem16,
            this.buttonItem17});
            // 
            // buttonItem13
            // 
            this.buttonItem13.Checked = true;
            this.buttonItem13.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem13.Image")));
            this.buttonItem13.ImagePaddingVertical = 9;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.OptionGroup = "statusGroup";
            this.buttonItem13.Text = "Print Layout";
            this.buttonItem13.Tooltip = "Print Layout";
            // 
            // buttonItem14
            // 
            this.buttonItem14.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem14.Image")));
            this.buttonItem14.ImagePaddingVertical = 9;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.OptionGroup = "statusGroup";
            this.buttonItem14.Text = "Web Layout";
            this.buttonItem14.Tooltip = "Web Layout";
            // 
            // buttonItem15
            // 
            this.buttonItem15.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem15.Image")));
            this.buttonItem15.ImagePaddingVertical = 9;
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.OptionGroup = "statusGroup";
            this.buttonItem15.Text = "Full Screen";
            this.buttonItem15.Tooltip = "Full Screen Reading";
            // 
            // buttonItem16
            // 
            this.buttonItem16.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem16.Image")));
            this.buttonItem16.ImagePaddingVertical = 9;
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.OptionGroup = "statusGroup";
            this.buttonItem16.Text = "Outline";
            this.buttonItem16.Tooltip = "Outline";
            // 
            // buttonItem17
            // 
            this.buttonItem17.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem17.Image")));
            this.buttonItem17.ImagePaddingVertical = 9;
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.OptionGroup = "statusGroup";
            this.buttonItem17.Text = "Draft";
            this.buttonItem17.Tooltip = "Draft";
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.Class = "";
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.Class = "Office2007StatusBarBackground2";
            this.itemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer13.Name = "itemContainer13";
            this.itemContainer13.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelPosition,
            this.zoomSlider});
            // 
            // labelPosition
            // 
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.PaddingLeft = 2;
            this.labelPosition.PaddingRight = 2;
            this.labelPosition.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelPosition.Width = 100;
            // 
            // zoomSlider
            // 
            this.zoomSlider.Maximum = 200;
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Step = 5;
            this.zoomSlider.Text = "100%";
            this.zoomSlider.Value = 100;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.ribbonTabItem1,
            this.ribbonTabContext,
            this.buttonItem155,
            this.buttonItem157,
            this.buttonItem55,
            this.buttonItem83,
            this.buttonItem84,
            this.buttonItem56,
            this.buttonItem57});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.MdiSystemItemVisible = false;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(931, 149);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 8;
            this.ribbonControl1.Text = "Universal Office";
            this.ribbonControl1.TitleTextMarkupLinkClick += new DevComponents.DotNetBar.MarkupLinkClickEventHandler(this.ribbonControl1_TitleTextMarkupLinkClick);
            this.ribbonControl1.BeforeRibbonPanelPopupClose += new DevComponents.DotNetBar.RibbonPopupCloseEventHandler(this.ribbonControl1_BeforeRibbonPanelPopupClose);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar5);
            this.ribbonPanel1.Controls.Add(this.ribbonBar4);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(931, 94);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.Class = "";
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.DialogLauncherVisible = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonMargins,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            this.ribbonBar5.Location = new System.Drawing.Point(556, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(219, 91);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 5;
            this.ribbonBar5.Text = "Page Setup";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.Class = "";
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.Class = "";
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonMargins
            // 
            this.buttonMargins.Image = ((System.Drawing.Image)(resources.GetObject("buttonMargins.Image")));
            this.buttonMargins.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonMargins.Name = "buttonMargins";
            this.buttonMargins.Text = "Margins";
            // 
            // buttonItem9
            // 
            this.buttonItem9.AutoExpandOnClick = true;
            this.buttonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem9.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem9.Image")));
            this.buttonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem50,
            this.buttonItem51,
            this.buttonItem52});
            this.buttonItem9.Text = "Orientation <expand/>";
            // 
            // buttonItem50
            // 
            this.buttonItem50.Checked = true;
            this.buttonItem50.Name = "buttonItem50";
            this.buttonItem50.OptionGroup = "orientation";
            this.buttonItem50.Text = "Auto";
            // 
            // buttonItem51
            // 
            this.buttonItem51.Name = "buttonItem51";
            this.buttonItem51.OptionGroup = "orientation";
            this.buttonItem51.Text = "Horizontal";
            // 
            // buttonItem52
            // 
            this.buttonItem52.Name = "buttonItem52";
            this.buttonItem52.OptionGroup = "orientation";
            this.buttonItem52.Text = "Vertical";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem10.Image")));
            this.buttonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "Size";
            // 
            // buttonItem11
            // 
            this.buttonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem11.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem11.Image")));
            this.buttonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "Print Area";
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.Class = "";
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.DialogLauncherVisible = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFind});
            this.ribbonBar4.Location = new System.Drawing.Point(415, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(141, 91);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar4, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar4.TabIndex = 4;
            this.ribbonBar4.Text = "Fi&nd";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.Class = "";
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.Class = "";
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonFind
            // 
            this.buttonFind.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonFind.Image = ((System.Drawing.Image)(resources.GetObject("buttonFind.Image")));
            this.buttonFind.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF);
            this.superTooltip1.SetSuperTooltip(this.buttonFind, new DevComponents.DotNetBar.SuperTooltipInfo("Find (Ctrl+F)", "", "Find text in document.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFind.Text = "&Find";
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.DialogLauncherVisible = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer6,
            this.itemContainer4});
            this.ribbonBar3.Location = new System.Drawing.Point(231, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(184, 91);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar3, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "&Paragraph";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.ribbonBar3.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.Class = "";
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.ItemSpacing = 3;
            this.itemContainer6.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7,
            this.itemContainer8});
            this.itemContainer6.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.Class = "";
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.BeginGroup = true;
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonAlignLeft,
            this.buttonAlignCenter,
            this.buttonAlignRight,
            this.buttonItem73});
            // 
            // buttonAlignLeft
            // 
            this.buttonAlignLeft.Enabled = false;
            this.buttonAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignLeft.Image")));
            this.buttonAlignLeft.Name = "buttonAlignLeft";
            this.buttonAlignLeft.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignLeft, new DevComponents.DotNetBar.SuperTooltipInfo("Align Left (Ctrl+L)", "", "Align text to left.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignLeft.Text = "Align &Left";
            // 
            // buttonAlignCenter
            // 
            this.buttonAlignCenter.Enabled = false;
            this.buttonAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignCenter.Image")));
            this.buttonAlignCenter.Name = "buttonAlignCenter";
            this.buttonAlignCenter.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignCenter, new DevComponents.DotNetBar.SuperTooltipInfo("Center (Ctrl+E)", "", "Center text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignCenter.Text = "Align &Center";
            // 
            // buttonAlignRight
            // 
            this.buttonAlignRight.Enabled = false;
            this.buttonAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlignRight.Image")));
            this.buttonAlignRight.Name = "buttonAlignRight";
            this.buttonAlignRight.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR);
            this.superTooltip1.SetSuperTooltip(this.buttonAlignRight, new DevComponents.DotNetBar.SuperTooltipInfo("Align Right (Ctrl+R)", "", "Align text to the right.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonAlignRight.Text = "Align &Right";
            // 
            // buttonItem73
            // 
            this.buttonItem73.Image = global::Ribbonpad.Properties.Resources.image_b;
            this.buttonItem73.Name = "buttonItem73";
            this.buttonItem73.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR);
            this.superTooltip1.SetSuperTooltip(this.buttonItem73, new DevComponents.DotNetBar.SuperTooltipInfo("Align Right (Ctrl+R)", "", "Align text to the right.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem73.Text = "Align &Right";
            this.buttonItem73.Click += new System.EventHandler(this.buttonItem73_Click);
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.Class = "";
            this.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.BeginGroup = true;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5});
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.Name = "buttonItem2";
            this.superTooltip1.SetSuperTooltip(this.buttonItem2, new DevComponents.DotNetBar.SuperTooltipInfo("Numbering", "", "Add numbering to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem2.Text = "&Numbered Bullets";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.Name = "buttonItem3";
            this.superTooltip1.SetSuperTooltip(this.buttonItem3, new DevComponents.DotNetBar.SuperTooltipInfo("Bullets", "", "Add bullets to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem3.Text = "&Bullets";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.superTooltip1.SetSuperTooltip(this.buttonItem4, new DevComponents.DotNetBar.SuperTooltipInfo("Increase Indent", "", "Change the indentation of text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem4.Text = "&Indent";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.Name = "buttonItem5";
            this.superTooltip1.SetSuperTooltip(this.buttonItem5, new DevComponents.DotNetBar.SuperTooltipInfo("Decrease Indent", "", "Change the indentation of text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem5.Text = "&Outdent";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.ItemSpacing = 3;
            this.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.DialogLauncherVisible = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer3});
            this.ribbonBar2.ItemSpacing = 5;
            this.ribbonBar2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ribbonBar2.Location = new System.Drawing.Point(76, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.ResizeItemsToFit = false;
            this.ribbonBar2.Size = new System.Drawing.Size(155, 91);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar2, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "F&ont";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.ribbonBar2.PopupContainerUnload += new System.EventHandler(this.UnloadPopup);
            this.ribbonBar2.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.comboFont,
            this.comboFontSize});
            // 
            // comboFont
            // 
            this.comboFont.ComboWidth = 96;
            this.comboFont.DropDownHeight = 106;
            this.comboFont.DropDownWidth = 242;
            this.comboFont.Enabled = false;
            this.comboFont.FontCombo = true;
            this.comboFont.ItemHeight = 14;
            this.comboFont.Name = "comboFont";
            this.superTooltip1.SetSuperTooltip(this.comboFont, new DevComponents.DotNetBar.SuperTooltipInfo("Font", "", "Change the font face.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            // 
            // comboFontSize
            // 
            this.comboFontSize.ComboWidth = 40;
            this.comboFontSize.DropDownHeight = 106;
            this.comboFontSize.Enabled = false;
            this.comboFontSize.ItemHeight = 14;
            this.comboFontSize.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8,
            this.comboItem9,
            this.comboItemFS10,
            this.comboItemFS11,
            this.comboItemFS12,
            this.comboItemFS13,
            this.comboItemFS14,
            this.comboItemFS15,
            this.comboItemFS16});
            this.comboFontSize.Name = "comboFontSize";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "8";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "9";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "10";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "11";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "12";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "14";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "16";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "18";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "20";
            // 
            // comboItemFS10
            // 
            this.comboItemFS10.Text = "22";
            // 
            // comboItemFS11
            // 
            this.comboItemFS11.Text = "24";
            // 
            // comboItemFS12
            // 
            this.comboItemFS12.Text = "26";
            // 
            // comboItemFS13
            // 
            this.comboItemFS13.Text = "28";
            // 
            // comboItemFS14
            // 
            this.comboItemFS14.Text = "36";
            // 
            // comboItemFS15
            // 
            this.comboItemFS15.Text = "42";
            // 
            // comboItemFS16
            // 
            this.comboItemFS16.Text = "72";
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.BeginGroup = true;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFontBold,
            this.buttonFontItalic,
            this.buttonFontUnderline,
            this.buttonFontStrike,
            this.buttonTextColor});
            // 
            // buttonFontBold
            // 
            this.buttonFontBold.Enabled = false;
            this.buttonFontBold.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontBold.Image")));
            this.buttonFontBold.Name = "buttonFontBold";
            this.buttonFontBold.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.superTooltip1.SetSuperTooltip(this.buttonFontBold, new DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontBold.Text = "&Bold";
            // 
            // buttonFontItalic
            // 
            this.buttonFontItalic.Enabled = false;
            this.buttonFontItalic.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontItalic.Image")));
            this.buttonFontItalic.Name = "buttonFontItalic";
            this.buttonFontItalic.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonFontItalic, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontItalic.Text = "&Italic";
            // 
            // buttonFontUnderline
            // 
            this.buttonFontUnderline.Enabled = false;
            this.buttonFontUnderline.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontUnderline.Image")));
            this.buttonFontUnderline.Name = "buttonFontUnderline";
            this.buttonFontUnderline.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU);
            this.superTooltip1.SetSuperTooltip(this.buttonFontUnderline, new DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontUnderline.Text = "&Underline";
            // 
            // buttonFontStrike
            // 
            this.buttonFontStrike.Enabled = false;
            this.buttonFontStrike.Image = ((System.Drawing.Image)(resources.GetObject("buttonFontStrike.Image")));
            this.buttonFontStrike.Name = "buttonFontStrike";
            this.superTooltip1.SetSuperTooltip(this.buttonFontStrike, new DevComponents.DotNetBar.SuperTooltipInfo("Strikethrough", "", "Draw a line through the middle of the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonFontStrike.Text = "&Strike";
            // 
            // buttonTextColor
            // 
            this.buttonTextColor.Enabled = false;
            this.buttonTextColor.Image = ((System.Drawing.Image)(resources.GetObject("buttonTextColor.Image")));
            this.buttonTextColor.Name = "buttonTextColor";
            this.buttonTextColor.SelectedColorImageRectangle = new System.Drawing.Rectangle(0, 13, 16, 3);
            this.superTooltip1.SetSuperTooltip(this.buttonTextColor, new DevComponents.DotNetBar.SuperTooltipInfo("Text Color", "", "Change the selected text color.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonTextColor.Text = "Text &Color";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.DialogLauncherVisible = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonPaste,
            this.itemContainer34});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(73, 91);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar1, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "&Clipboard";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.LaunchDialog += new System.EventHandler(this.LaunchRibbonDialog);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste.Image")));
            this.buttonPaste.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.SplitButton = true;
            this.superTooltip1.SetSuperTooltip(this.buttonPaste, new DevComponents.DotNetBar.SuperTooltipInfo("Paste (Ctrl+V)", "", "Paste text from clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonPaste.Text = "&Paste";
            // 
            // itemContainer34
            // 
            // 
            // 
            // 
            this.itemContainer34.BackgroundStyle.Class = "";
            this.itemContainer34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer34.ItemSpacing = 0;
            this.itemContainer34.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer34.Name = "itemContainer34";
            this.itemContainer34.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonCut,
            this.bCopy,
            this.buttonItem147});
            // 
            // buttonCut
            // 
            this.buttonCut.Image = ((System.Drawing.Image)(resources.GetObject("buttonCut.Image")));
            this.buttonCut.Name = "buttonCut";
            this.superTooltip1.SetSuperTooltip(this.buttonCut, new DevComponents.DotNetBar.SuperTooltipInfo("Cut (Ctrl+X)", "", "Removes selected text and copies it to clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonCut.Text = "Cu&t";
            this.buttonCut.Click += new System.EventHandler(this.buttonItem145_Click);
            // 
            // bCopy
            // 
            this.bCopy.Image = ((System.Drawing.Image)(resources.GetObject("bCopy.Image")));
            this.bCopy.Name = "bCopy";
            this.superTooltip1.SetSuperTooltip(this.bCopy, new DevComponents.DotNetBar.SuperTooltipInfo("Copy (Ctrl+C)", "", "Copy selected text to clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.bCopy.Text = "&Copy";
            // 
            // buttonItem147
            // 
            this.buttonItem147.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem147.Image")));
            this.buttonItem147.Name = "buttonItem147";
            this.superTooltip1.SetSuperTooltip(this.buttonItem147, new DevComponents.DotNetBar.SuperTooltipInfo("Format Painter", "This command is not implemented", "Copy formatting from one place and apply it to another.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem147.Text = "Format Painter";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonPanel5);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(931, 94);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 4;
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Controls.Add(this.ribbonBar9);
            this.ribbonPanel5.Controls.Add(this.ribbonBar16);
            this.ribbonPanel5.Controls.Add(this.ribbonBar17);
            this.ribbonPanel5.Controls.Add(this.ribbonBar18);
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(3, 0);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(925, 91);
            // 
            // 
            // 
            this.ribbonPanel5.Style.Class = "";
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.Class = "";
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.Class = "";
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 2;
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundStyle.Class = "";
            this.ribbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar9.ContainerControlProcessDialogKey = true;
            this.ribbonBar9.DialogLauncherVisible = true;
            this.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem8,
            this.buttonItem12});
            this.ribbonBar9.Location = new System.Drawing.Point(677, 0);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(164, 88);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar9.TabIndex = 3;
            this.ribbonBar9.Text = "Print";
            // 
            // 
            // 
            this.ribbonBar9.TitleStyle.Class = "";
            this.ribbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyleMouseOver.Class = "";
            this.ribbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Page Setup";
            this.buttonItem1.Tooltip = "Page Setup";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem8
            // 
            this.buttonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem8.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem8.Image")));
            this.buttonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem8.Name = "buttonItem8";
            this.superTooltip1.SetSuperTooltip(this.buttonItem8, new DevComponents.DotNetBar.SuperTooltipInfo("Find (Ctrl+F)", "", "Find text in document.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem8.Text = "Print Preview";
            this.buttonItem8.Tooltip = "Print Preview";
            this.buttonItem8.Click += new System.EventHandler(this.buttonItem8_Click);
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem12.Image")));
            this.buttonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.Text = "Print";
            this.buttonItem12.Tooltip = "Print";
            this.buttonItem12.Click += new System.EventHandler(this.buttonItem12_Click);
            // 
            // ribbonBar16
            // 
            this.ribbonBar16.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar16.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar16.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar16.BackgroundStyle.Class = "";
            this.ribbonBar16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar16.ContainerControlProcessDialogKey = true;
            this.ribbonBar16.DialogLauncherVisible = true;
            this.ribbonBar16.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar16.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer15});
            this.ribbonBar16.Location = new System.Drawing.Point(493, 0);
            this.ribbonBar16.Name = "ribbonBar16";
            this.ribbonBar16.Size = new System.Drawing.Size(184, 88);
            this.ribbonBar16.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar16, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar16.TabIndex = 2;
            this.ribbonBar16.Text = "&Paragraph";
            // 
            // 
            // 
            this.ribbonBar16.TitleStyle.Class = "";
            this.ribbonBar16.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar16.TitleStyleMouseOver.Class = "";
            this.ribbonBar16.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar16.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer15
            // 
            // 
            // 
            // 
            this.itemContainer15.BackgroundStyle.Class = "";
            this.itemContainer15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer15.ItemSpacing = 3;
            this.itemContainer15.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer15.Name = "itemContainer15";
            this.itemContainer15.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer28,
            this.itemContainer29});
            this.itemContainer15.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer28
            // 
            // 
            // 
            // 
            this.itemContainer28.BackgroundStyle.Class = "";
            this.itemContainer28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer28.BeginGroup = true;
            this.itemContainer28.Name = "itemContainer28";
            this.itemContainer28.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem69,
            this.buttonItem70,
            this.buttonItem71});
            // 
            // buttonItem69
            // 
            this.buttonItem69.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem69.Image")));
            this.buttonItem69.Name = "buttonItem69";
            this.buttonItem69.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.superTooltip1.SetSuperTooltip(this.buttonItem69, new DevComponents.DotNetBar.SuperTooltipInfo("Align Left (Ctrl+L)", "", "Align text to left.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem69.Text = "Align &Left";
            this.buttonItem69.Click += new System.EventHandler(this.buttonItem69_Click);
            // 
            // buttonItem70
            // 
            this.buttonItem70.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem70.Image")));
            this.buttonItem70.Name = "buttonItem70";
            this.buttonItem70.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.superTooltip1.SetSuperTooltip(this.buttonItem70, new DevComponents.DotNetBar.SuperTooltipInfo("Center (Ctrl+E)", "", "Center text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem70.Text = "Align &Center";
            this.buttonItem70.Click += new System.EventHandler(this.buttonItem70_Click);
            // 
            // buttonItem71
            // 
            this.buttonItem71.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem71.Image")));
            this.buttonItem71.Name = "buttonItem71";
            this.buttonItem71.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR);
            this.superTooltip1.SetSuperTooltip(this.buttonItem71, new DevComponents.DotNetBar.SuperTooltipInfo("Align Right (Ctrl+R)", "", "Align text to the right.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem71.Text = "Align &Right";
            this.buttonItem71.Click += new System.EventHandler(this.buttonItem71_Click);
            // 
            // itemContainer29
            // 
            // 
            // 
            // 
            this.itemContainer29.BackgroundStyle.Class = "";
            this.itemContainer29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer29.BeginGroup = true;
            this.itemContainer29.Name = "itemContainer29";
            this.itemContainer29.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem137});
            // 
            // buttonItem137
            // 
            this.buttonItem137.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem137.Image")));
            this.buttonItem137.Name = "buttonItem137";
            this.superTooltip1.SetSuperTooltip(this.buttonItem137, new DevComponents.DotNetBar.SuperTooltipInfo("Bullets", "", "Add bullets to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem137.Text = "&Bullets";
            this.buttonItem137.Click += new System.EventHandler(this.buttonItem137_Click);
            // 
            // ribbonBar17
            // 
            this.ribbonBar17.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar17.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar17.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar17.BackgroundStyle.Class = "";
            this.ribbonBar17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar17.ContainerControlProcessDialogKey = true;
            this.ribbonBar17.DialogLauncherVisible = true;
            this.ribbonBar17.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar17.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer32,
            this.itemContainer33});
            this.ribbonBar17.ItemSpacing = 5;
            this.ribbonBar17.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ribbonBar17.Location = new System.Drawing.Point(296, 0);
            this.ribbonBar17.Name = "ribbonBar17";
            this.ribbonBar17.ResizeItemsToFit = false;
            this.ribbonBar17.Size = new System.Drawing.Size(197, 88);
            this.ribbonBar17.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar17, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher Button", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar17.TabIndex = 1;
            this.ribbonBar17.Text = "F&ont";
            // 
            // 
            // 
            this.ribbonBar17.TitleStyle.Class = "";
            this.ribbonBar17.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar17.TitleStyleMouseOver.Class = "";
            this.ribbonBar17.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar17.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer32
            // 
            // 
            // 
            // 
            this.itemContainer32.BackgroundStyle.Class = "";
            this.itemContainer32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer32.BeginGroup = true;
            this.itemContainer32.Name = "itemContainer32";
            this.itemContainer32.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem63,
            this.buttonItem122,
            this.buttonItem128,
            this.buttonItem129,
            this.buttonItem130});
            // 
            // buttonItem63
            // 
            this.buttonItem63.Name = "buttonItem63";
            this.buttonItem63.Text = " A ";
            this.buttonItem63.Tooltip = "Select Font";
            this.buttonItem63.Click += new System.EventHandler(this.buttonItem63_Click);
            // 
            // buttonItem122
            // 
            this.buttonItem122.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem122.Image")));
            this.buttonItem122.Name = "buttonItem122";
            this.buttonItem122.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.superTooltip1.SetSuperTooltip(this.buttonItem122, new DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem122.Text = "&Bold";
            this.buttonItem122.Tooltip = "Bold";
            this.buttonItem122.Click += new System.EventHandler(this.buttonItem122_Click);
            // 
            // buttonItem128
            // 
            this.buttonItem128.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem128.Image")));
            this.buttonItem128.Name = "buttonItem128";
            this.buttonItem128.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonItem128, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem128.Text = "&Italic";
            this.buttonItem128.Tooltip = "Italic";
            this.buttonItem128.Click += new System.EventHandler(this.buttonItem128_Click);
            // 
            // buttonItem129
            // 
            this.buttonItem129.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem129.Image")));
            this.buttonItem129.Name = "buttonItem129";
            this.buttonItem129.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU);
            this.superTooltip1.SetSuperTooltip(this.buttonItem129, new DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem129.Text = "&Underline";
            this.buttonItem129.Tooltip = "Under Line";
            this.buttonItem129.Click += new System.EventHandler(this.buttonItem129_Click);
            // 
            // buttonItem130
            // 
            this.buttonItem130.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem130.Image")));
            this.buttonItem130.Name = "buttonItem130";
            this.superTooltip1.SetSuperTooltip(this.buttonItem130, new DevComponents.DotNetBar.SuperTooltipInfo("Strikethrough", "", "Draw a line through the middle of the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem130.Text = "&Strike";
            this.buttonItem130.Tooltip = "Normal";
            this.buttonItem130.Click += new System.EventHandler(this.buttonItem130_Click);
            // 
            // itemContainer33
            // 
            // 
            // 
            // 
            this.itemContainer33.BackgroundStyle.Class = "";
            this.itemContainer33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer33.BeginGroup = true;
            this.itemContainer33.Name = "itemContainer33";
            this.itemContainer33.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem161,
            this.buttonItem61});
            // 
            // buttonItem161
            // 
            this.buttonItem161.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem161.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem161.Image")));
            this.buttonItem161.Name = "buttonItem161";
            this.superTooltip1.SetSuperTooltip(this.buttonItem161, new DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text.\r\n\r\nThis feature has not been implemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem161.Text = "Font Color";
            this.buttonItem161.Tooltip = "Font Color";
            this.buttonItem161.Click += new System.EventHandler(this.buttonItem161_Click);
            // 
            // buttonItem61
            // 
            this.buttonItem61.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem61.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem61.Image")));
            this.buttonItem61.Name = "buttonItem61";
            this.superTooltip1.SetSuperTooltip(this.buttonItem61, new DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text.\r\n\r\nThis feature has not been implemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem61.Text = "Page Color";
            this.buttonItem61.Tooltip = "Page Color";
            this.buttonItem61.Click += new System.EventHandler(this.buttonItem61_Click_1);
            // 
            // ribbonBar18
            // 
            this.ribbonBar18.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar18.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar18.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar18.BackgroundStyle.Class = "";
            this.ribbonBar18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar18.ContainerControlProcessDialogKey = true;
            this.ribbonBar18.DialogLauncherVisible = true;
            this.ribbonBar18.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar18.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem131,
            this.itemContainer35});
            this.ribbonBar18.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar18.Name = "ribbonBar18";
            this.ribbonBar18.Size = new System.Drawing.Size(293, 88);
            this.ribbonBar18.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ribbonBar18, new DevComponents.DotNetBar.SuperTooltipInfo("SuperTooltip for Dialog Launcher", "", "Assigning the Super Tooltip to the Ribbon Bar control will display it when mouse " +
                        "hovers over the Dialog Launcher button.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.ribbonBar18.TabIndex = 0;
            this.ribbonBar18.Text = "File";
            // 
            // 
            // 
            this.ribbonBar18.TitleStyle.Class = "";
            this.ribbonBar18.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar18.TitleStyleMouseOver.Class = "";
            this.ribbonBar18.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem131
            // 
            this.buttonItem131.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem131.Name = "buttonItem131";
            this.buttonItem131.SplitButton = true;
            this.superTooltip1.SetSuperTooltip(this.buttonItem131, new DevComponents.DotNetBar.SuperTooltipInfo("Paste (Ctrl+V)", "", "Paste text from clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem131.Text = "File";
            // 
            // itemContainer35
            // 
            // 
            // 
            // 
            this.itemContainer35.BackgroundStyle.Class = "";
            this.itemContainer35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer35.ItemSpacing = 3;
            this.itemContainer35.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer35.Name = "itemContainer35";
            this.itemContainer35.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer36,
            this.itemContainer38});
            this.itemContainer35.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer36
            // 
            // 
            // 
            // 
            this.itemContainer36.BackgroundStyle.Class = "";
            this.itemContainer36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer36.BeginGroup = true;
            this.itemContainer36.Name = "itemContainer36";
            this.itemContainer36.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem132,
            this.buttonItem133,
            this.itemContainer30});
            // 
            // buttonItem132
            // 
            this.buttonItem132.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem132.Icon")));
            this.buttonItem132.Name = "buttonItem132";
            this.buttonItem132.Text = "New";
            this.buttonItem132.Tooltip = "New";
            this.buttonItem132.Click += new System.EventHandler(this.buttonItem132_Click);
            // 
            // buttonItem133
            // 
            this.buttonItem133.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem133.Icon")));
            this.buttonItem133.Name = "buttonItem133";
            this.buttonItem133.Text = "Open";
            this.buttonItem133.Tooltip = "Open";
            this.buttonItem133.Click += new System.EventHandler(this.buttonItem133_Click);
            // 
            // itemContainer30
            // 
            // 
            // 
            // 
            this.itemContainer30.BackgroundStyle.Class = "";
            this.itemContainer30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer30.Name = "itemContainer30";
            this.itemContainer30.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem134,
            this.buttonItem135});
            // 
            // buttonItem134
            // 
            this.buttonItem134.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem134.Icon")));
            this.buttonItem134.Name = "buttonItem134";
            this.buttonItem134.Text = "Save";
            this.buttonItem134.Tooltip = "Save";
            this.buttonItem134.Click += new System.EventHandler(this.buttonItem134_Click);
            // 
            // buttonItem135
            // 
            this.buttonItem135.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem135.Icon")));
            this.buttonItem135.Name = "buttonItem135";
            this.buttonItem135.Text = "Save As.";
            this.buttonItem135.Tooltip = "Save As";
            this.buttonItem135.Click += new System.EventHandler(this.buttonItem135_Click);
            // 
            // itemContainer38
            // 
            // 
            // 
            // 
            this.itemContainer38.BackgroundStyle.Class = "";
            this.itemContainer38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer38.BeginGroup = true;
            this.itemContainer38.Name = "itemContainer38";
            this.itemContainer38.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem68,
            this.buttonItem75,
            this.buttonItem150,
            this.buttonItem151,
            this.buttonItem156,
            this.buttonItem152,
            this.buttonItem153,
            this.buttonItem154,
            this.buttonItem76});
            this.itemContainer38.Click += new System.EventHandler(this.buttonItem143_Click);
            // 
            // buttonItem68
            // 
            this.buttonItem68.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem68.Icon")));
            this.buttonItem68.Name = "buttonItem68";
            this.buttonItem68.Text = "New";
            this.buttonItem68.Tooltip = "Undo";
            this.buttonItem68.Click += new System.EventHandler(this.buttonItem143_Click);
            // 
            // buttonItem75
            // 
            this.buttonItem75.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem75.Icon")));
            this.buttonItem75.Name = "buttonItem75";
            this.buttonItem75.Text = "Open";
            this.buttonItem75.Tooltip = "Redo";
            this.buttonItem75.Click += new System.EventHandler(this.buttonItem144_Click);
            // 
            // buttonItem150
            // 
            this.buttonItem150.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem150.Icon")));
            this.buttonItem150.Name = "buttonItem150";
            this.buttonItem150.Text = "Find";
            this.buttonItem150.Tooltip = "Find";
            this.buttonItem150.Click += new System.EventHandler(this.buttonItem150_Click);
            // 
            // buttonItem151
            // 
            this.buttonItem151.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem151.Icon")));
            this.buttonItem151.Name = "buttonItem151";
            this.buttonItem151.Text = "Find and Replace";
            this.buttonItem151.Tooltip = "Find and Replace";
            this.buttonItem151.Click += new System.EventHandler(this.buttonItem151_Click);
            // 
            // buttonItem156
            // 
            this.buttonItem156.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem156.Icon")));
            this.buttonItem156.Name = "buttonItem156";
            this.buttonItem156.Text = "Select All";
            this.buttonItem156.Tooltip = "Select All";
            this.buttonItem156.Click += new System.EventHandler(this.buttonItem156_Click);
            // 
            // buttonItem152
            // 
            this.buttonItem152.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem152.Icon")));
            this.buttonItem152.Name = "buttonItem152";
            this.buttonItem152.Text = "Copy";
            this.buttonItem152.Tooltip = "Copy";
            this.buttonItem152.Click += new System.EventHandler(this.buttonItem152_Click);
            // 
            // buttonItem153
            // 
            this.buttonItem153.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem153.Icon")));
            this.buttonItem153.Name = "buttonItem153";
            this.buttonItem153.Text = "Cut";
            this.buttonItem153.Tooltip = "Cut";
            this.buttonItem153.Click += new System.EventHandler(this.buttonItem153_Click);
            // 
            // buttonItem154
            // 
            this.buttonItem154.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem154.Icon")));
            this.buttonItem154.Name = "buttonItem154";
            this.buttonItem154.Text = "Past";
            this.buttonItem154.Tooltip = "Past";
            this.buttonItem154.Click += new System.EventHandler(this.buttonItem154_Click);
            // 
            // buttonItem76
            // 
            this.buttonItem76.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem76.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem76.Image")));
            this.buttonItem76.Name = "buttonItem76";
            this.superTooltip1.SetSuperTooltip(this.buttonItem76, new DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text.\r\n\r\nThis feature has not been implemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem76.Tooltip = "Inser Image";
            this.buttonItem76.Click += new System.EventHandler(this.buttonItem76_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile.Image")));
            this.buttonFile.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonFile.ImagePaddingHorizontal = 0;
            this.buttonFile.ImagePaddingVertical = 0;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileContainer});
            this.buttonFile.Text = "&File";
            // 
            // menuFileContainer
            // 
            // 
            // 
            // 
            this.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileContainer.Name = "menuFileContainer";
            this.menuFileContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileTwoColumnContainer,
            this.menuFileBottomContainer});
            // 
            // menuFileTwoColumnContainer
            // 
            // 
            // 
            // 
            this.menuFileTwoColumnContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.menuFileTwoColumnContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingBottom = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingLeft = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingRight = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingTop = 2;
            this.menuFileTwoColumnContainer.ItemSpacing = 0;
            this.menuFileTwoColumnContainer.Name = "menuFileTwoColumnContainer";
            this.menuFileTwoColumnContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileItems,
            this.menuFileMRU});
            // 
            // menuFileItems
            // 
            // 
            // 
            // 
            this.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileItems.ItemSpacing = 5;
            this.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileItems.MinimumSize = new System.Drawing.Size(120, 0);
            this.menuFileItems.Name = "menuFileItems";
            this.menuFileItems.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem20,
            this.buttonItem21,
            this.buttonFileSaveAs,
            this.buttonItem25});
            // 
            // buttonItem20
            // 
            this.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem20.Command = this.AppCommandNew;
            this.buttonItem20.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem20.Image")));
            this.buttonItem20.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonItem20.ImageSmall")));
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem6});
            this.buttonItem20.SubItemsExpandWidth = 24;
            this.buttonItem20.Text = "&New";
            // 
            // AppCommandNew
            // 
            this.AppCommandNew.Name = "AppCommandNew";
            this.AppCommandNew.Executed += new System.EventHandler(this.AppCommandNew_Executed);
            // 
            // buttonItem6
            // 
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "buttonItem6";
            // 
            // buttonItem21
            // 
            this.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem21.Command = this.AppCommandOpen;
            this.buttonItem21.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem21.Image")));
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItemsExpandWidth = 24;
            this.buttonItem21.Text = "&Open...";
            // 
            // AppCommandOpen
            // 
            this.AppCommandOpen.Name = "AppCommandOpen";
            this.AppCommandOpen.Executed += new System.EventHandler(this.AppCommandOpen_Executed);
            // 
            // buttonFileSaveAs
            // 
            this.buttonFileSaveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonFileSaveAs.Command = this.AppCommandSaveAs;
            this.buttonFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileSaveAs.Image")));
            this.buttonFileSaveAs.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonFileSaveAs.ImageSmall")));
            this.buttonFileSaveAs.Name = "buttonFileSaveAs";
            this.buttonFileSaveAs.SubItemsExpandWidth = 24;
            this.buttonFileSaveAs.Text = "&Save";
            this.buttonFileSaveAs.ExpandChange += new System.EventHandler(this.buttonFileSaveAs_ExpandChange);
            this.buttonFileSaveAs.Click += new System.EventHandler(this.buttonFileSaveAs_Click);
            // 
            // AppCommandSaveAs
            // 
            this.AppCommandSaveAs.Name = "AppCommandSaveAs";
            this.AppCommandSaveAs.Executed += new System.EventHandler(this.AppCommandSaveAs_Executed);
            // 
            // buttonItem25
            // 
            this.buttonItem25.BeginGroup = true;
            this.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem25.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem25.Image")));
            this.buttonItem25.Name = "buttonItem25";
            this.buttonItem25.SubItemsExpandWidth = 24;
            this.buttonItem25.Text = "&Close";
            // 
            // menuFileMRU
            // 
            // 
            // 
            // 
            this.menuFileMRU.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.menuFileMRU.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileMRU.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileMRU.MinimumSize = new System.Drawing.Size(225, 0);
            this.menuFileMRU.Name = "menuFileMRU";
            this.menuFileMRU.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem26,
            this.buttonItem27,
            this.buttonItem28,
            this.buttonItem29});
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem26
            // 
            this.buttonItem26.Name = "buttonItem26";
            this.buttonItem26.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem27
            // 
            this.buttonItem27.Name = "buttonItem27";
            this.buttonItem27.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem28
            // 
            this.buttonItem28.Name = "buttonItem28";
            this.buttonItem28.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem29
            // 
            this.buttonItem29.Name = "buttonItem29";
            this.buttonItem29.Text = "&4. example.rtf";
            // 
            // menuFileBottomContainer
            // 
            // 
            // 
            // 
            this.menuFileBottomContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.menuFileBottomContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileBottomContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.menuFileBottomContainer.Name = "menuFileBottomContainer";
            this.menuFileBottomContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonOptions,
            this.buttonExit});
            // 
            // buttonOptions
            // 
            this.buttonOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.SubItemsExpandWidth = 24;
            this.buttonOptions.Text = "RibbonPad Opt&ions";
            // 
            // buttonExit
            // 
            this.buttonExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonExit.Command = this.AppCommandExit;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.SubItemsExpandWidth = 24;
            this.buttonExit.Text = "E&xit RibbonPad";
            // 
            // AppCommandExit
            // 
            this.AppCommandExit.Name = "AppCommandExit";
            this.AppCommandExit.Executed += new System.EventHandler(this.AppCommandExit_Executed);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Universal Document";
            this.ribbonTabItem1.Click += new System.EventHandler(this.ribbonTabItem1_Click);
            // 
            // ribbonTabContext
            // 
            this.ribbonTabContext.Checked = true;
            this.ribbonTabContext.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Orange;
            this.ribbonTabContext.Name = "ribbonTabContext";
            this.ribbonTabContext.Panel = this.ribbonPanel2;
            this.ribbonTabContext.Text = "Universal Editor";
            this.ribbonTabContext.Click += new System.EventHandler(this.ribbonTabContext_Click);
            // 
            // buttonItem155
            // 
            this.buttonItem155.Name = "buttonItem155";
            this.buttonItem155.Text = "Create PDF";
            this.buttonItem155.Click += new System.EventHandler(this.buttonItem155_Click);
            // 
            // buttonItem157
            // 
            this.buttonItem157.Name = "buttonItem157";
            this.buttonItem157.Text = "PDF Reader";
            this.buttonItem157.Click += new System.EventHandler(this.buttonItem157_Click);
            // 
            // buttonItem55
            // 
            this.buttonItem55.Name = "buttonItem55";
            this.buttonItem55.Text = "Video Downloader";
            this.buttonItem55.Click += new System.EventHandler(this.buttonItem55_Click);
            // 
            // buttonItem83
            // 
            this.buttonItem83.Name = "buttonItem83";
            this.buttonItem83.Text = "Media Player";
            this.buttonItem83.Click += new System.EventHandler(this.buttonItem83_Click);
            // 
            // buttonItem84
            // 
            this.buttonItem84.Name = "buttonItem84";
            this.buttonItem84.Text = "Browser";
            this.buttonItem84.Click += new System.EventHandler(this.buttonItem84_Click);
            // 
            // buttonItem56
            // 
            this.buttonItem56.Name = "buttonItem56";
            this.buttonItem56.Click += new System.EventHandler(this.buttonItem56_Click);
            // 
            // buttonItem57
            // 
            this.buttonItem57.Name = "buttonItem57";
            this.buttonItem57.Click += new System.EventHandler(this.buttonItem57_Click);
            // 
            // itemContainer25
            // 
            // 
            // 
            // 
            this.itemContainer25.BackgroundStyle.Class = "";
            this.itemContainer25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer25.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer25.Name = "itemContainer25";
            this.itemContainer25.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem111,
            this.buttonItem123,
            this.buttonItem119});
            // 
            // buttonItem111
            // 
            this.buttonItem111.Image = global::Ribbonpad.Properties.Resources.sum;
            this.buttonItem111.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem111.Name = "buttonItem111";
            this.buttonItem111.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem115,
            this.buttonItem116,
            this.buttonItem117,
            this.buttonItem118});
            this.buttonItem111.Text = "buttonItem111";
            // 
            // buttonItem115
            // 
            this.buttonItem115.Name = "buttonItem115";
            this.buttonItem115.Text = "buttonItem115";
            // 
            // buttonItem116
            // 
            this.buttonItem116.Name = "buttonItem116";
            this.buttonItem116.Text = "buttonItem116";
            // 
            // buttonItem117
            // 
            this.buttonItem117.Name = "buttonItem117";
            this.buttonItem117.Text = "buttonItem117";
            // 
            // buttonItem118
            // 
            this.buttonItem118.Name = "buttonItem118";
            this.buttonItem118.Text = "buttonItem118";
            // 
            // buttonItem123
            // 
            this.buttonItem123.Image = global::Ribbonpad.Properties.Resources.arrow_down_blue;
            this.buttonItem123.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem123.Name = "buttonItem123";
            this.buttonItem123.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem124,
            this.buttonItem125,
            this.buttonItem126});
            this.buttonItem123.Text = "buttonItem123";
            // 
            // buttonItem124
            // 
            this.buttonItem124.Name = "buttonItem124";
            this.buttonItem124.Text = "buttonItem124";
            // 
            // buttonItem125
            // 
            this.buttonItem125.Name = "buttonItem125";
            this.buttonItem125.Text = "buttonItem125";
            // 
            // buttonItem126
            // 
            this.buttonItem126.Name = "buttonItem126";
            this.buttonItem126.Text = "buttonItem126";
            // 
            // buttonItem119
            // 
            this.buttonItem119.Name = "buttonItem119";
            this.buttonItem119.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem120});
            this.buttonItem119.Text = "Eraser";
            // 
            // buttonItem120
            // 
            this.buttonItem120.Name = "buttonItem120";
            this.buttonItem120.Text = "buttonItem120";
            // 
            // itemContainer26
            // 
            // 
            // 
            // 
            this.itemContainer26.BackgroundStyle.Class = "";
            this.itemContainer26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer26.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer26.Name = "itemContainer26";
            this.itemContainer26.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem121});
            this.itemContainer26.Text = "Sort & Filter";
            // 
            // buttonItem121
            // 
            this.buttonItem121.Image = global::Ribbonpad.Properties.Resources.Flash_Live_Icon_06;
            this.buttonItem121.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.buttonItem121.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem121.Name = "buttonItem121";
            this.buttonItem121.Text = "Sort & Filter";
            // 
            // itemContainer27
            // 
            // 
            // 
            // 
            this.itemContainer27.BackgroundStyle.Class = "";
            this.itemContainer27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer27.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer27.Name = "itemContainer27";
            this.itemContainer27.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem127});
            // 
            // buttonItem127
            // 
            this.buttonItem127.Image = global::Ribbonpad.Properties.Resources.search_b;
            this.buttonItem127.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.buttonItem127.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem127.Name = "buttonItem127";
            this.buttonItem127.Text = "Find & Replace";
            this.buttonItem127.Click += new System.EventHandler(this.buttonItem127_Click);
            // 
            // itemContainer24
            // 
            // 
            // 
            // 
            this.itemContainer24.BackgroundStyle.Class = "";
            this.itemContainer24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer24.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer24.Name = "itemContainer24";
            this.itemContainer24.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem109,
            this.Delete,
            this.buttonItem113});
            // 
            // buttonItem109
            // 
            this.buttonItem109.Image = global::Ribbonpad.Properties.Resources.merge_cells;
            this.buttonItem109.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem109.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem109.Name = "buttonItem109";
            this.buttonItem109.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem110,
            this.buttonItem7});
            this.buttonItem109.Text = "Insert";
            // 
            // buttonItem110
            // 
            this.buttonItem110.Name = "buttonItem110";
            this.buttonItem110.Text = "Column";
            this.buttonItem110.Click += new System.EventHandler(this.buttonItem110_Click);
            // 
            // buttonItem7
            // 
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.Text = "Row";
            this.buttonItem7.Click += new System.EventHandler(this.buttonItem7_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem112,
            this.buttonItem23});
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.buttonItem111_Click);
            // 
            // buttonItem112
            // 
            this.buttonItem112.Name = "buttonItem112";
            this.buttonItem112.Text = "Column";
            this.buttonItem112.Click += new System.EventHandler(this.buttonItem112_Click);
            // 
            // buttonItem23
            // 
            this.buttonItem23.Name = "buttonItem23";
            this.buttonItem23.Text = "Row";
            this.buttonItem23.Click += new System.EventHandler(this.buttonItem23_Click);
            // 
            // buttonItem113
            // 
            this.buttonItem113.Name = "buttonItem113";
            this.buttonItem113.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem114});
            this.buttonItem113.Text = "Format";
            // 
            // buttonItem114
            // 
            this.buttonItem114.Name = "buttonItem114";
            this.buttonItem114.Text = "buttonItem114";
            // 
            // itemContainer23
            // 
            // 
            // 
            // 
            this.itemContainer23.BackgroundStyle.Class = "";
            this.itemContainer23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer23.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer23.Name = "itemContainer23";
            this.itemContainer23.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem53,
            this.buttonItem105,
            this.buttonItem107});
            // 
            // buttonItem53
            // 
            this.buttonItem53.Name = "buttonItem53";
            this.buttonItem53.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem54});
            this.buttonItem53.Text = "Conditional Forwarding";
            // 
            // buttonItem54
            // 
            this.buttonItem54.Name = "buttonItem54";
            this.buttonItem54.Text = "buttonItem54";
            // 
            // buttonItem105
            // 
            this.buttonItem105.Name = "buttonItem105";
            this.buttonItem105.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem106});
            this.buttonItem105.Text = "Format As Table";
            // 
            // buttonItem106
            // 
            this.buttonItem106.Name = "buttonItem106";
            this.buttonItem106.Text = "buttonItem106";
            // 
            // buttonItem107
            // 
            this.buttonItem107.Name = "buttonItem107";
            this.buttonItem107.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem108});
            this.buttonItem107.Text = "Cells";
            // 
            // buttonItem108
            // 
            this.buttonItem108.Name = "buttonItem108";
            this.buttonItem108.Text = "buttonItem108";
            // 
            // itemContainer19
            // 
            // 
            // 
            // 
            this.itemContainer19.BackgroundStyle.Class = "";
            this.itemContainer19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer19.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer19.Name = "itemContainer19";
            this.itemContainer19.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.comboBoxItem5,
            this.itemContainer20});
            this.itemContainer19.Visible = false;
            // 
            // comboBoxItem5
            // 
            this.comboBoxItem5.ComboWidth = 100;
            this.comboBoxItem5.DropDownHeight = 106;
            this.comboBoxItem5.Name = "comboBoxItem5";
            this.comboBoxItem5.Text = "comboBoxItem5";
            // 
            // itemContainer20
            // 
            // 
            // 
            // 
            this.itemContainer20.BackgroundStyle.Class = "";
            this.itemContainer20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer20.BeginGroup = true;
            this.itemContainer20.Name = "itemContainer20";
            this.itemContainer20.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem102,
            this.buttonItem103,
            this.buttonItem104});
            // 
            // buttonItem102
            // 
            this.buttonItem102.Enabled = false;
            this.buttonItem102.Image = global::Ribbonpad.Properties.Resources._256;
            this.buttonItem102.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem102.Name = "buttonItem102";
            this.buttonItem102.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.superTooltip1.SetSuperTooltip(this.buttonItem102, new DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem102.Text = "B";
            // 
            // buttonItem103
            // 
            this.buttonItem103.Enabled = false;
            this.buttonItem103.FontBold = true;
            this.buttonItem103.Name = "buttonItem103";
            this.buttonItem103.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonItem103, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem103.Text = "%";
            this.buttonItem103.Click += new System.EventHandler(this.buttonItem103_Click);
            // 
            // buttonItem104
            // 
            this.buttonItem104.Enabled = false;
            this.buttonItem104.Name = "buttonItem104";
            this.buttonItem104.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU);
            this.superTooltip1.SetSuperTooltip(this.buttonItem104, new DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem104.Text = ",";
            this.buttonItem104.Click += new System.EventHandler(this.buttonItem104_Click);
            // 
            // itemContainer17
            // 
            // 
            // 
            // 
            this.itemContainer17.BackgroundStyle.Class = "";
            this.itemContainer17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer17.ItemSpacing = 3;
            this.itemContainer17.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer17.Name = "itemContainer17";
            this.itemContainer17.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer18,
            this.itemContainer21});
            this.itemContainer17.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.itemContainer17.Visible = false;
            // 
            // itemContainer18
            // 
            // 
            // 
            // 
            this.itemContainer18.BackgroundStyle.Class = "";
            this.itemContainer18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer18.BeginGroup = true;
            this.itemContainer18.Name = "itemContainer18";
            this.itemContainer18.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem92,
            this.buttonItem93,
            this.buttonItem94,
            this.buttonItem95});
            // 
            // buttonItem92
            // 
            this.buttonItem92.Enabled = false;
            this.buttonItem92.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem92.Image")));
            this.buttonItem92.Name = "buttonItem92";
            this.buttonItem92.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.superTooltip1.SetSuperTooltip(this.buttonItem92, new DevComponents.DotNetBar.SuperTooltipInfo("Align Left (Ctrl+L)", "", "Align text to left.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem92.Text = "Align &Left";
            // 
            // buttonItem93
            // 
            this.buttonItem93.Enabled = false;
            this.buttonItem93.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem93.Image")));
            this.buttonItem93.Name = "buttonItem93";
            this.buttonItem93.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.superTooltip1.SetSuperTooltip(this.buttonItem93, new DevComponents.DotNetBar.SuperTooltipInfo("Center (Ctrl+E)", "", "Center text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem93.Text = "Align &Center";
            // 
            // buttonItem94
            // 
            this.buttonItem94.Enabled = false;
            this.buttonItem94.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem94.Image")));
            this.buttonItem94.Name = "buttonItem94";
            this.buttonItem94.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR);
            this.superTooltip1.SetSuperTooltip(this.buttonItem94, new DevComponents.DotNetBar.SuperTooltipInfo("Align Right (Ctrl+R)", "", "Align text to the right.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem94.Text = "Align &Right";
            // 
            // buttonItem95
            // 
            this.buttonItem95.Enabled = false;
            this.buttonItem95.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem95.Image")));
            this.buttonItem95.Name = "buttonItem95";
            this.buttonItem95.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlJ);
            this.superTooltip1.SetSuperTooltip(this.buttonItem95, new DevComponents.DotNetBar.SuperTooltipInfo("Justify (Ctrl+J)", "", "Align text to both the left and right margins, adding extra space between words a" +
                        "s necessary.\r\n\r\nThis creates a clean look along the left and right side of the p" +
                        "age.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem95.Text = "&Justify";
            // 
            // itemContainer21
            // 
            // 
            // 
            // 
            this.itemContainer21.BackgroundStyle.Class = "";
            this.itemContainer21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer21.BeginGroup = true;
            this.itemContainer21.Name = "itemContainer21";
            this.itemContainer21.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem96,
            this.buttonItem97,
            this.buttonItem98,
            this.buttonItem99});
            // 
            // buttonItem96
            // 
            this.buttonItem96.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem96.Image")));
            this.buttonItem96.Name = "buttonItem96";
            this.superTooltip1.SetSuperTooltip(this.buttonItem96, new DevComponents.DotNetBar.SuperTooltipInfo("Numbering", "", "Add numbering to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem96.Text = "&Numbered Bullets";
            // 
            // buttonItem97
            // 
            this.buttonItem97.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem97.Image")));
            this.buttonItem97.Name = "buttonItem97";
            this.superTooltip1.SetSuperTooltip(this.buttonItem97, new DevComponents.DotNetBar.SuperTooltipInfo("Bullets", "", "Add bullets to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem97.Text = "&Bullets";
            // 
            // buttonItem98
            // 
            this.buttonItem98.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem98.Image")));
            this.buttonItem98.Name = "buttonItem98";
            this.superTooltip1.SetSuperTooltip(this.buttonItem98, new DevComponents.DotNetBar.SuperTooltipInfo("Increase Indent", "", "Change the indentation of text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem98.Text = "&Indent";
            // 
            // buttonItem99
            // 
            this.buttonItem99.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem99.Image")));
            this.buttonItem99.Name = "buttonItem99";
            this.superTooltip1.SetSuperTooltip(this.buttonItem99, new DevComponents.DotNetBar.SuperTooltipInfo("Decrease Indent", "", "Change the indentation of text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem99.Text = "&Outdent";
            // 
            // itemContainer22
            // 
            // 
            // 
            // 
            this.itemContainer22.BackgroundStyle.Class = "";
            this.itemContainer22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer22.ItemSpacing = 3;
            this.itemContainer22.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer22.Name = "itemContainer22";
            this.itemContainer22.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem100,
            this.buttonItem101});
            this.itemContainer22.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.itemContainer22.Visible = false;
            // 
            // buttonItem100
            // 
            this.buttonItem100.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem100.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem100.Image")));
            this.buttonItem100.Name = "buttonItem100";
            this.superTooltip1.SetSuperTooltip(this.buttonItem100, new DevComponents.DotNetBar.SuperTooltipInfo("Borders", "", "Change borders of the selected text.\r\n\r\nThis feature has not been implemented yet" +
                        ".", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem100.Text = "&Borders";
            // 
            // buttonItem101
            // 
            this.buttonItem101.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem101.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem101.Image")));
            this.buttonItem101.Name = "buttonItem101";
            this.superTooltip1.SetSuperTooltip(this.buttonItem101, new DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text.\r\n\r\nThis feature has not been implemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem101.Text = "&Shading";
            // 
            // itemContainer10
            // 
            // 
            // 
            // 
            this.itemContainer10.BackgroundStyle.Class = "";
            this.itemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer10.Name = "itemContainer10";
            this.itemContainer10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.comboBoxItem3,
            this.comboBoxItem4});
            // 
            // comboBoxItem3
            // 
            this.comboBoxItem3.ComboWidth = 96;
            this.comboBoxItem3.DropDownHeight = 106;
            this.comboBoxItem3.DropDownWidth = 242;
            this.comboBoxItem3.Enabled = false;
            this.comboBoxItem3.FontCombo = true;
            this.comboBoxItem3.ItemHeight = 14;
            this.comboBoxItem3.Name = "comboBoxItem3";
            this.superTooltip1.SetSuperTooltip(this.comboBoxItem3, new DevComponents.DotNetBar.SuperTooltipInfo("Font", "", "Change the font face.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            // 
            // comboBoxItem4
            // 
            this.comboBoxItem4.ComboWidth = 40;
            this.comboBoxItem4.DropDownHeight = 106;
            this.comboBoxItem4.Enabled = false;
            this.comboBoxItem4.ItemHeight = 14;
            this.comboBoxItem4.Items.AddRange(new object[] {
            this.comboItem37,
            this.comboItem38,
            this.comboItem39,
            this.comboItem40,
            this.comboItem41,
            this.comboItem42,
            this.comboItem43,
            this.comboItem44,
            this.comboItem45});
            this.comboBoxItem4.Name = "comboBoxItem4";
            this.comboBoxItem4.Click += new System.EventHandler(this.comboBoxItem4_Click);
            // 
            // comboItem37
            // 
            this.comboItem37.Text = "6";
            // 
            // comboItem38
            // 
            this.comboItem38.Text = "7";
            // 
            // comboItem39
            // 
            this.comboItem39.Text = "8";
            // 
            // comboItem40
            // 
            this.comboItem40.Text = "9";
            // 
            // comboItem41
            // 
            this.comboItem41.Text = "10";
            // 
            // comboItem42
            // 
            this.comboItem42.Text = "11";
            // 
            // comboItem43
            // 
            this.comboItem43.Text = "12";
            // 
            // comboItem44
            // 
            this.comboItem44.Text = "13";
            // 
            // comboItem45
            // 
            this.comboItem45.Text = "14";
            // 
            // itemContainer16
            // 
            // 
            // 
            // 
            this.itemContainer16.BackgroundStyle.Class = "";
            this.itemContainer16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer16.BeginGroup = true;
            this.itemContainer16.Name = "itemContainer16";
            this.itemContainer16.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem88,
            this.buttonItem89,
            this.buttonItem90,
            this.buttonItem91,
            this.colorPickerDropDown2});
            // 
            // buttonItem88
            // 
            this.buttonItem88.Enabled = false;
            this.buttonItem88.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem88.Image")));
            this.buttonItem88.Name = "buttonItem88";
            this.buttonItem88.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB);
            this.superTooltip1.SetSuperTooltip(this.buttonItem88, new DevComponents.DotNetBar.SuperTooltipInfo("Bold (Ctrl+B)", "", "Make selected text bold", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem88.Text = "&Bold";
            // 
            // buttonItem89
            // 
            this.buttonItem89.Enabled = false;
            this.buttonItem89.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem89.Image")));
            this.buttonItem89.Name = "buttonItem89";
            this.buttonItem89.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonItem89, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem89.Text = "&Italic";
            // 
            // buttonItem90
            // 
            this.buttonItem90.Enabled = false;
            this.buttonItem90.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem90.Image")));
            this.buttonItem90.Name = "buttonItem90";
            this.buttonItem90.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU);
            this.superTooltip1.SetSuperTooltip(this.buttonItem90, new DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem90.Text = "&Underline";
            // 
            // buttonItem91
            // 
            this.buttonItem91.Enabled = false;
            this.buttonItem91.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem91.Image")));
            this.buttonItem91.Name = "buttonItem91";
            this.superTooltip1.SetSuperTooltip(this.buttonItem91, new DevComponents.DotNetBar.SuperTooltipInfo("Strikethrough", "", "Draw a line through the middle of the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem91.Text = "&Strike";
            // 
            // colorPickerDropDown2
            // 
            this.colorPickerDropDown2.Enabled = false;
            this.colorPickerDropDown2.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerDropDown2.Image")));
            this.colorPickerDropDown2.Name = "colorPickerDropDown2";
            this.colorPickerDropDown2.SelectedColorImageRectangle = new System.Drawing.Rectangle(0, 13, 16, 3);
            this.superTooltip1.SetSuperTooltip(this.colorPickerDropDown2, new DevComponents.DotNetBar.SuperTooltipInfo("Text Color", "", "Change the selected text color.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.colorPickerDropDown2.Text = "Text &Color";
            // 
            // buttonItem60
            // 
            this.buttonItem60.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem60.Image")));
            this.buttonItem60.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem60.Name = "buttonItem60";
            this.buttonItem60.SplitButton = true;
            this.buttonItem60.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem62,
            this.buttonItem79});
            this.superTooltip1.SetSuperTooltip(this.buttonItem60, new DevComponents.DotNetBar.SuperTooltipInfo("Paste (Ctrl+V)", "", "Paste text from clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem60.Text = "&Paste";
            // 
            // buttonItem62
            // 
            this.buttonItem62.Enabled = false;
            this.buttonItem62.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem62.Image")));
            this.buttonItem62.Name = "buttonItem62";
            this.buttonItem62.Text = "&Paste";
            // 
            // buttonItem79
            // 
            this.buttonItem79.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem79.Image")));
            this.buttonItem79.Name = "buttonItem79";
            this.buttonItem79.Text = "Paste &Special...";
            // 
            // itemContainer11
            // 
            // 
            // 
            // 
            this.itemContainer11.BackgroundStyle.Class = "";
            this.itemContainer11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer11.ItemSpacing = 0;
            this.itemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer11.Name = "itemContainer11";
            this.itemContainer11.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem80,
            this.buttonItem81,
            this.buttonItem82});
            // 
            // buttonItem80
            // 
            this.buttonItem80.Enabled = false;
            this.buttonItem80.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem80.Image")));
            this.buttonItem80.Name = "buttonItem80";
            this.superTooltip1.SetSuperTooltip(this.buttonItem80, new DevComponents.DotNetBar.SuperTooltipInfo("Cut (Ctrl+X)", "", "Removes selected text and copies it to clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem80.Text = "Cu&t";
            // 
            // buttonItem81
            // 
            this.buttonItem81.Enabled = false;
            this.buttonItem81.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem81.Image")));
            this.buttonItem81.Name = "buttonItem81";
            this.superTooltip1.SetSuperTooltip(this.buttonItem81, new DevComponents.DotNetBar.SuperTooltipInfo("Copy (Ctrl+C)", "", "Copy selected text to clipboard.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem81.Text = "&Copy";
            // 
            // buttonItem82
            // 
            this.buttonItem82.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem82.Image")));
            this.buttonItem82.Name = "buttonItem82";
            this.superTooltip1.SetSuperTooltip(this.buttonItem82, new DevComponents.DotNetBar.SuperTooltipInfo("Format Painter", "This command is not implemented", "Copy formatting from one place and apply it to another.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem82.Text = "Format Painter";
            // 
            // buttonItem24
            // 
            this.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem24.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem24.Image")));
            this.buttonItem24.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonItem24.ImageSmall")));
            this.buttonItem24.Name = "buttonItem24";
            this.buttonItem24.SubItemsExpandWidth = 24;
            this.buttonItem24.Text = "&Save";
            this.buttonItem24.Click += new System.EventHandler(this.buttonItem24_Click);
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Name = "AppCommandTheme";
            this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
            // 
            // AppCommandGoToUrl
            // 
            this.AppCommandGoToUrl.Name = "AppCommandGoToUrl";
            this.AppCommandGoToUrl.Executed += new System.EventHandler(this.AppCommandGoToUrl_Executed);
            // 
            // itemContainer40
            // 
            // 
            // 
            // 
            this.itemContainer40.BackgroundStyle.Class = "";
            this.itemContainer40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer40.ItemSpacing = 0;
            this.itemContainer40.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer40.Name = "itemContainer40";
            this.itemContainer40.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem149});
            // 
            // buttonItem149
            // 
            this.buttonItem149.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem149.Image")));
            this.buttonItem149.Name = "buttonItem149";
            this.buttonItem149.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonItem149.Text = "Open Media Player";
            this.buttonItem149.Tooltip = "Open Media Player";
            // 
            // AppCommandSave
            // 
            this.AppCommandSave.Name = "AppCommandSave";
            this.AppCommandSave.Executed += new System.EventHandler(this.AppCommandSave_Executed);
            // 
            // itemContainer39
            // 
            // 
            // 
            // 
            this.itemContainer39.BackgroundStyle.Class = "";
            this.itemContainer39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer39.ItemSpacing = 0;
            this.itemContainer39.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer39.Name = "itemContainer39";
            this.itemContainer39.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem148});
            // 
            // buttonItem148
            // 
            this.buttonItem148.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem148.Image")));
            this.buttonItem148.Name = "buttonItem148";
            this.buttonItem148.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonItem148.Text = "Open Media Player";
            this.buttonItem148.Tooltip = "Open Media Player";
            // 
            // itemContainer14
            // 
            // 
            // 
            // 
            this.itemContainer14.BackgroundStyle.Class = "";
            this.itemContainer14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer14.ItemSpacing = 0;
            this.itemContainer14.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer14.Name = "itemContainer14";
            this.itemContainer14.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem142});
            // 
            // buttonItem142
            // 
            this.buttonItem142.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem142.Image")));
            this.buttonItem142.Name = "buttonItem142";
            this.buttonItem142.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonItem142.Text = "Open Downloader";
            this.buttonItem142.Tooltip = "Open Downloader";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonGalleryContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.DefaultSize = new System.Drawing.Size(200, 58);
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(58, 58);
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupGalleryItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem47,
            this.buttonItem48,
            this.buttonItem49});
            this.galleryContainer1.StretchGallery = true;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem18,
            this.buttonItem19,
            this.buttonItem22,
            this.buttonItem30,
            this.buttonItem31,
            this.buttonItem32,
            this.buttonItem33,
            this.buttonItem34,
            this.buttonItem35,
            this.buttonItem36,
            this.buttonItem37,
            this.buttonItem38,
            this.buttonItem39,
            this.buttonItem40,
            this.buttonItem41,
            this.buttonItem42,
            this.buttonItem43,
            this.buttonItem44,
            this.buttonItem45,
            this.buttonItem46});
            // 
            // buttonItem47
            // 
            this.buttonItem47.BeginGroup = true;
            this.buttonItem47.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem47.Image")));
            this.buttonItem47.Name = "buttonItem47";
            this.buttonItem47.Text = "Search for Templates Online...";
            // 
            // buttonItem48
            // 
            this.buttonItem48.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem48.Image")));
            this.buttonItem48.Name = "buttonItem48";
            this.buttonItem48.Text = "Browse for Templates...";
            // 
            // buttonItem49
            // 
            this.buttonItem49.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem49.Image")));
            this.buttonItem49.Name = "buttonItem49";
            this.buttonItem49.Text = "Save Current Template...";
            // 
            // buttonItem18
            // 
            this.buttonItem18.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem18.Image")));
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.Text = "Apex";
            this.buttonItem18.Tooltip = "Apex";
            // 
            // buttonItem19
            // 
            this.buttonItem19.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem19.Image")));
            this.buttonItem19.Name = "buttonItem19";
            this.buttonItem19.Text = "Aspect";
            this.buttonItem19.Tooltip = "Aspect";
            // 
            // buttonItem22
            // 
            this.buttonItem22.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem22.Image")));
            this.buttonItem22.Name = "buttonItem22";
            this.buttonItem22.Text = "Concourse";
            this.buttonItem22.Tooltip = "Concourse";
            // 
            // buttonItem30
            // 
            this.buttonItem30.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem30.Image")));
            this.buttonItem30.Name = "buttonItem30";
            this.buttonItem30.Text = "Currency";
            this.buttonItem30.Tooltip = "Currency";
            // 
            // buttonItem31
            // 
            this.buttonItem31.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem31.Image")));
            this.buttonItem31.Name = "buttonItem31";
            this.buttonItem31.Text = "Deluxe";
            this.buttonItem31.Tooltip = "Deluxe";
            // 
            // buttonItem32
            // 
            this.buttonItem32.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem32.Image")));
            this.buttonItem32.Name = "buttonItem32";
            this.buttonItem32.Text = "Equity";
            this.buttonItem32.Tooltip = "Equity";
            // 
            // buttonItem33
            // 
            this.buttonItem33.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem33.Image")));
            this.buttonItem33.Name = "buttonItem33";
            this.buttonItem33.Text = "Flow";
            this.buttonItem33.Tooltip = "Flow";
            // 
            // buttonItem34
            // 
            this.buttonItem34.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem34.Image")));
            this.buttonItem34.Name = "buttonItem34";
            this.buttonItem34.Text = "Foundry";
            this.buttonItem34.Tooltip = "Foundry";
            // 
            // buttonItem35
            // 
            this.buttonItem35.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem35.Image")));
            this.buttonItem35.Name = "buttonItem35";
            this.buttonItem35.Text = "Median";
            this.buttonItem35.Tooltip = "Median";
            // 
            // buttonItem36
            // 
            this.buttonItem36.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem36.Image")));
            this.buttonItem36.Name = "buttonItem36";
            this.buttonItem36.Text = "Metro";
            this.buttonItem36.Tooltip = "Metro";
            // 
            // buttonItem37
            // 
            this.buttonItem37.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem37.Image")));
            this.buttonItem37.Name = "buttonItem37";
            this.buttonItem37.Text = "Office";
            this.buttonItem37.Tooltip = "Office";
            // 
            // buttonItem38
            // 
            this.buttonItem38.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem38.Image")));
            this.buttonItem38.Name = "buttonItem38";
            this.buttonItem38.Text = "Opulent";
            this.buttonItem38.Tooltip = "Opulent";
            // 
            // buttonItem39
            // 
            this.buttonItem39.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem39.Image")));
            this.buttonItem39.Name = "buttonItem39";
            this.buttonItem39.Text = "Oriel";
            this.buttonItem39.Tooltip = "Oriel";
            // 
            // buttonItem40
            // 
            this.buttonItem40.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem40.Image")));
            this.buttonItem40.Name = "buttonItem40";
            this.buttonItem40.Text = "Origin";
            this.buttonItem40.Tooltip = "Origin";
            // 
            // buttonItem41
            // 
            this.buttonItem41.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem41.Image")));
            this.buttonItem41.Name = "buttonItem41";
            this.buttonItem41.Text = "Civic";
            this.buttonItem41.Tooltip = "Civic";
            // 
            // buttonItem42
            // 
            this.buttonItem42.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem42.Image")));
            this.buttonItem42.Name = "buttonItem42";
            this.buttonItem42.Text = "Solstice";
            this.buttonItem42.Tooltip = "Solstice";
            // 
            // buttonItem43
            // 
            this.buttonItem43.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem43.Image")));
            this.buttonItem43.Name = "buttonItem43";
            this.buttonItem43.Text = "Technic";
            this.buttonItem43.Tooltip = "Technic";
            // 
            // buttonItem44
            // 
            this.buttonItem44.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem44.Image")));
            this.buttonItem44.Name = "buttonItem44";
            this.buttonItem44.Text = "Trek";
            this.buttonItem44.Tooltip = "Trek";
            // 
            // buttonItem45
            // 
            this.buttonItem45.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem45.Image")));
            this.buttonItem45.Name = "buttonItem45";
            this.buttonItem45.Text = "Urban";
            this.buttonItem45.Tooltip = "Urban";
            // 
            // buttonItem46
            // 
            this.buttonItem46.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem46.Image")));
            this.buttonItem46.Name = "buttonItem46";
            this.buttonItem46.Text = "Verve";
            this.buttonItem46.Tooltip = "Verve";
            // 
            // comboItem46
            // 
            this.comboItem46.Text = "6";
            // 
            // comboItem47
            // 
            this.comboItem47.Text = "7";
            // 
            // comboItem48
            // 
            this.comboItem48.Text = "8";
            // 
            // comboItem49
            // 
            this.comboItem49.Text = "9";
            // 
            // comboItem50
            // 
            this.comboItem50.Text = "10";
            // 
            // comboItem51
            // 
            this.comboItem51.Text = "11";
            // 
            // comboItem52
            // 
            this.comboItem52.Text = "12";
            // 
            // comboItem53
            // 
            this.comboItem53.Text = "13";
            // 
            // comboItem54
            // 
            this.comboItem54.Text = "14";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "6";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "7";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "8";
            // 
            // comboItem13
            // 
            this.comboItem13.Text = "9";
            // 
            // comboItem14
            // 
            this.comboItem14.Text = "10";
            // 
            // comboItem15
            // 
            this.comboItem15.Text = "11";
            // 
            // comboItem16
            // 
            this.comboItem16.Text = "12";
            // 
            // comboItem17
            // 
            this.comboItem17.Text = "13";
            // 
            // comboItem18
            // 
            this.comboItem18.Text = "14";
            // 
            // RibbonStateCommand
            // 
            this.RibbonStateCommand.Name = "RibbonStateCommand";
            this.RibbonStateCommand.Executed += new System.EventHandler(this.RibbonStateCommand_Executed);
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTooltip1.MinimumTooltipSize = new System.Drawing.Size(150, 50);
            // 
            // buttonItem67
            // 
            this.buttonItem67.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem67.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem67.Image")));
            this.buttonItem67.Name = "buttonItem67";
            this.superTooltip1.SetSuperTooltip(this.buttonItem67, new DevComponents.DotNetBar.SuperTooltipInfo("Shading", "", "Changes shading of selected text.\r\n\r\nThis feature has not been implemented yet.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem67.Text = "Font Color";
            // 
            // buttonItem66
            // 
            this.buttonItem66.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem66.Image")));
            this.buttonItem66.Name = "buttonItem66";
            this.superTooltip1.SetSuperTooltip(this.buttonItem66, new DevComponents.DotNetBar.SuperTooltipInfo("Strikethrough", "", "Draw a line through the middle of the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem66.Text = "&Strike";
            // 
            // buttonItem65
            // 
            this.buttonItem65.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem65.Image")));
            this.buttonItem65.Name = "buttonItem65";
            this.buttonItem65.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU);
            this.superTooltip1.SetSuperTooltip(this.buttonItem65, new DevComponents.DotNetBar.SuperTooltipInfo("Underline (Ctrl+U)", "", "Underline the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem65.Text = "&Underline";
            // 
            // buttonItem64
            // 
            this.buttonItem64.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem64.Image")));
            this.buttonItem64.Name = "buttonItem64";
            this.buttonItem64.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI);
            this.superTooltip1.SetSuperTooltip(this.buttonItem64, new DevComponents.DotNetBar.SuperTooltipInfo("Italic (Ctrl+I)", "", "Italicize the selected text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem64.Text = "&Italic";
            // 
            // buttonItem74
            // 
            this.buttonItem74.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem74.Image")));
            this.buttonItem74.Name = "buttonItem74";
            this.superTooltip1.SetSuperTooltip(this.buttonItem74, new DevComponents.DotNetBar.SuperTooltipInfo("Bullets", "", "Add bullets to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem74.Text = "&Bullets";
            // 
            // buttonItem78
            // 
            this.buttonItem78.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem78.Image")));
            this.buttonItem78.Name = "buttonItem78";
            this.superTooltip1.SetSuperTooltip(this.buttonItem78, new DevComponents.DotNetBar.SuperTooltipInfo("Numbering", "", "Add numbering to the text.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.buttonItem78.Tooltip = "Undo";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Enabled = true;
            this.progressBarTimer.Interval = 800;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // comboItem19
            // 
            this.comboItem19.Text = "6";
            // 
            // comboItem20
            // 
            this.comboItem20.Text = "7";
            // 
            // comboItem21
            // 
            this.comboItem21.Text = "8";
            // 
            // comboItem22
            // 
            this.comboItem22.Text = "9";
            // 
            // comboItem23
            // 
            this.comboItem23.Text = "10";
            // 
            // comboItem24
            // 
            this.comboItem24.Text = "11";
            // 
            // comboItem25
            // 
            this.comboItem25.Text = "12";
            // 
            // comboItem26
            // 
            this.comboItem26.Text = "13";
            // 
            // comboItem27
            // 
            this.comboItem27.Text = "14";
            // 
            // comboItem28
            // 
            this.comboItem28.Text = "6";
            // 
            // comboItem29
            // 
            this.comboItem29.Text = "7";
            // 
            // comboItem30
            // 
            this.comboItem30.Text = "8";
            // 
            // comboItem31
            // 
            this.comboItem31.Text = "9";
            // 
            // comboItem32
            // 
            this.comboItem32.Text = "10";
            // 
            // comboItem33
            // 
            this.comboItem33.Text = "11";
            // 
            // comboItem34
            // 
            this.comboItem34.Text = "12";
            // 
            // comboItem35
            // 
            this.comboItem35.Text = "13";
            // 
            // comboItem36
            // 
            this.comboItem36.Text = "14";
            // 
            // itemContainer31
            // 
            // 
            // 
            // 
            this.itemContainer31.BackgroundStyle.Class = "";
            this.itemContainer31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer31.BeginGroup = true;
            this.itemContainer31.Name = "itemContainer31";
            this.itemContainer31.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem64,
            this.buttonItem65,
            this.buttonItem66,
            this.buttonItem67});
            // 
            // itemContainer37
            // 
            // 
            // 
            // 
            this.itemContainer37.BackgroundStyle.Class = "";
            this.itemContainer37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer37.BeginGroup = true;
            this.itemContainer37.Name = "itemContainer37";
            this.itemContainer37.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem78});
            // 
            // buttonItem144
            // 
            this.buttonItem144.Name = "buttonItem144";
            this.buttonItem144.Text = "Redo";
            this.buttonItem144.Click += new System.EventHandler(this.buttonItem144_Click);
            // 
            // buttonItem143
            // 
            this.buttonItem143.Name = "buttonItem143";
            this.buttonItem143.Text = "Undo";
            this.buttonItem143.Click += new System.EventHandler(this.buttonItem143_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // buttonItem136
            // 
            this.buttonItem136.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem136.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem136.Image")));
            this.buttonItem136.Name = "buttonItem136";
            this.buttonItem136.SubItemsExpandWidth = 24;
            this.buttonItem136.Text = "&Open...";
            // 
            // buttonItem72
            // 
            this.buttonItem72.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem72.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem72.Image")));
            this.buttonItem72.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonItem72.ImageSmall")));
            this.buttonItem72.Name = "buttonItem72";
            this.buttonItem72.SubItemsExpandWidth = 24;
            this.buttonItem72.Text = "&New";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.DefaultExt = "*.png";
            this.openFileDialog3.FilterIndex = 2;
            this.openFileDialog3.Title = "Open File";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(941, 500);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Universal Office";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.MdiChildActivated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Move += new System.EventHandler(this.frmMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region AppCreation
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}
		#endregion

		public void EditContextMenu()
		{
			
		}

		/// <summary>
		/// Verifies current context and enables/disables menu items...
		/// </summary>
		private void EnableFileItems()
		{
			// Accessing items through the Items collection and setting the properties on them
			// will propagate certain properties to all items with the same name...
			if(this.ActiveMdiChild==null)
			{
				AppCommandSave.Enabled=false;
				AppCommandSaveAs.Enabled = false;
			}
			else
			{
				AppCommandSave.Enabled = true;
				AppCommandSaveAs.Enabled = true;
				if(this.ActiveMdiChild is frmDocument)
					((frmDocument)this.ActiveMdiChild).FormActivated();
			}
		}

		private void MdiChildActivated(object sender, System.EventArgs e)
		{
			EnableFileItems();
			UpdateTitle();
			BindDocumentCommands();
		}

		internal void SaveDocument(frmDocument doc)
		{
			if(doc.FileName=="")
			{
				if(saveFileDialog1.ShowDialog()!=DialogResult.OK)
					return;
				if(saveFileDialog1.FileName=="")
					return;
				doc.FileName=saveFileDialog1.FileName;
			}
			if(doc.FileName!="")
				doc.SaveFile();
		}

		private void UnloadPopup(object sender, System.EventArgs e)
		{
			ButtonItem item=sender as ButtonItem;
			if(item.Name=="bTabColor")
			{
				DevComponents.DotNetBar.PopupContainerControl container=item.PopupContainerControl as PopupContainerControl;
				ColorPicker clr=container.Controls[0] as ColorPicker;
				if(clr.SelectedColor!=Color.Empty)
				{
					tabStrip1.ColorScheme.TabBackground=ControlPaint.LightLight(clr.SelectedColor);
					tabStrip1.ColorScheme.TabBackground2=clr.SelectedColor;
					tabStrip1.Refresh();
				}
				// Close popup menu, since it is not closed when Popup Container is closed...
				item.Parent.Expanded=false;
			}
		}

		private void TaskPaneShowAtStartup(object sender, EventArgs e)
		{
			MessageBoxEx.Show("This item is here for demonstration purposes only and code should be added to save the state of it.");
		}

		private void dotNetBarManager1_MouseEnter(object sender, System.EventArgs e)
		{
			// Sync Status-bar with the item tooltip...
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;
			labelStatus.Text=item.Tooltip;
		}

		private void dotNetBarManager1_MouseLeave(object sender, System.EventArgs e)
		{
			labelStatus.Text="";		
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			// Create the list of frequently used commands for the QAT Customize menu
			ribbonControl1.QatFrequentCommands.Add(buttonItem20);
			ribbonControl1.QatFrequentCommands.Add(buttonItem21);
			ribbonControl1.QatFrequentCommands.Add(buttonItem25);

			EnableFileItems();

            //AppCommandNew.Execute();

			// Load Quick Access Toolbar layout if one is saved from last session...
			Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
			if(key!=null)
			{
				try
				{
					string layout = key.GetValue("RibbonPadCSLayout","").ToString();
					if(layout!="" && layout!=null)
						ribbonControl1.QatLayout = layout;
				}
				finally
				{
					key.Close();
				}
			}
            //UpdateTitle();
            this.Text = "UNIVERASL EDITOR";
			// Pulse the Application Button
            //buttonFile.Pulse(11);
            objfrmMain = this;
		}

		private void frmMain_Move(object sender, System.EventArgs e)
		{
			this.CloseSearch();
		}

		private void CloseSearch()
		{
			if(m_Search!=null)
			{
				m_Search.Close();
				m_Search.Dispose();
				m_Search=null;
			}
		}

		public void SearchActiveDocument(string text)
		{
			frmDocument activedocument=this.ActiveMdiChild as frmDocument;
			if (activedocument != null)
			{
				buttonFind.CommandParameter = text;
				activedocument.CommandFind.Execute(buttonFind);
			}
		}

		private void LaunchRibbonDialog(object sender, System.EventArgs e)
		{
			MessageBoxEx.Show("Start <i>Ribbon Dialog</i> with more options here...","Ribbon Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void buttonFind_Click(object sender, System.EventArgs e)
		{
			if(m_Search==null || m_Search.IsDisposed)
			{
				m_Search=new BalloonSearch();
				m_Search.Owner=this;
				m_Search.Show(sender as BaseItem,true);
			}
		}

		private void MdiClientControlAddRemove(object sender, ControlEventArgs e)
		{
			if(this.MdiChildren.Length>0)
			{
				if(!ribbonTabContext.Visible)
				{
					ribbonTabContext.Visible=true;
					ribbonControl1.RecalcLayout();
				}
			}
			else
			{
				if(ribbonTabContext.Visible)
				{
					if(ribbonTabContext.Checked)
						ribbonTabItem1.Checked=true;
					ribbonTabContext.Visible=false;
					ribbonControl1.RecalcLayout();
				}
			}
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Save Quick Access Toolbar layout if it has changed...
			if(ribbonControl1.QatLayoutChanged)
			{
				Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
				try
				{
					key.SetValue("RibbonPadCSLayout", ribbonControl1.QatLayout);
				}
				finally
				{
					key.Close();
				}
			}
		}

		private void progressBarTimer_Tick(object sender, System.EventArgs e)
		{
			if(progressBarItem1.Value>=progressBarItem1.Maximum)
			{
				progressBarTimer.Stop();
				progressBarItem1.Value = 50;
			}
			else
				progressBarItem1.Value+=4;
		}

		private void ribbonControl1_BeforeRibbonPanelPopupClose(object sender, DevComponents.DotNetBar.RibbonPopupCloseEventArgs e)
		{
			// Don't close ribbon tab menu if Find button is clicked since it display the balloon popup
			if(e.Source == buttonFind)
				e.Cancel = true;
		}

		#region Automatic Color Scheme creation based on the selected color table
		private bool m_ColorSelected = false;
		private eStyle m_BaseStyle = eStyle.Office2010Silver;
		private void buttonStyleCustom_ExpandChange(object sender, System.EventArgs e)
		{
			 
		}

		private void buttonStyleCustom_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
		{
			StyleManager.ColorTint = e.Color;
		}

		private void buttonStyleCustom_SelectedColorChanged(object sender, System.EventArgs e)
		{

		}
		#endregion

		private void buttonFileSaveAs_ExpandChange(object sender, System.EventArgs e)
		{
			// Position the Save As sub menu on top of the recent files box
			if(buttonFileSaveAs.Expanded)
			{
				buttonFileSaveAs.PopupLocation = menuFileMRU.DisplayRectangle.Location;
			}
		}

		/// <summary>
		/// Updates the title displayed on Ribbon using the rich text markup
		/// </summary>
		private void UpdateTitle()
		{
			string t = "";
			if(this.ActiveMdiChild!=null)
			{
				// Note the usage of SysCaptionTextExtra for as the value of color attribute.
				// It specifies the system color that changes based on selected color table.
				t+="<font color=\"SysCaptionTextExtra\">" + this.ActiveMdiChild.Text + "</font> ";
			}
			t+= "<b>Universal Office</b>";
			t+=" <b><a name=\"tip\"><font color=\"SysCaptionTextExtra\"></font></a></b>";
			ribbonControl1.TitleText = t;
		}

		private void ribbonControl1_TitleTextMarkupLinkClick(object sender, DevComponents.DotNetBar.MarkupLinkClickEventArgs e)
		{
			MessageBoxEx.Show("TitleText property on Ribbon fully supports our text-markup as demonstrated here. However, try keeping things simpler in title bar, perhaps using hyperlinks is pushing it too far ;-) <br/><br/>See <b>UpdateTitle()</b> method in source for details.", "RibbonControl.TitleText property tip");
		}

        #region Commands Implementation
		private void BindDocumentCommands()
		{
			frmDocument document = this.ActiveMdiChild as frmDocument;
			if (document == null)
			{
				// Note that when Command is set to null the button will be automatically 
				// disabled if it had command associated previously
				//buttonCopy.Command = null;
				
		 
				buttonAlignCenter.Command = null;
				buttonAlignLeft.Command = null;
				buttonAlignRight.Command = null;
				buttonFind.Command = null;
				comboFont.Command = null;
				buttonFontBold.Command = null;
				buttonFontItalic.Command = null;
				comboFontSize.Command = null;
				buttonFontStrike.Command = null;
				buttonFontUnderline.Command = null;
				buttonTextColor.Command = null;
				zoomSlider.Command = null;
				labelStatus.Command = null;
				
			}
			else
			{
                bCopy.Command = document.CommandCopy;
                buttonCut.Command = document.CommandCut;
                buttonPaste.Command = document.CommandPaste;
                buttonItem4.Command = document.CommandAlignRight;
                buttonItem5.Command = document.CommandAlignLeft;
                
				buttonAlignCenter.Command = document.CommandAlignCenter;
				buttonAlignLeft.Command = document.CommandAlignLeft;
                buttonPaste.Command = document.CommandPaste;
				buttonAlignRight.Command = document.CommandAlignRight;
				buttonFind.Command = document.CommandFind;
				comboFont.Command = document.CommandFont;
				buttonFontBold.Command = document.CommandFontBold;
				buttonFontItalic.Command = document.CommandFontItalic;
				comboFontSize.Command = document.CommandFontSize;
				buttonFontStrike.Command = document.CommandFontStrike;
				buttonFontUnderline.Command = document.CommandFontUnderline;
				buttonTextColor.Command = document.CommandTextColor;
				zoomSlider.Command = document.CommandZoom;
				labelStatus.Command = document.CommandStatus;
			}
		}

		private void AppCommandNew_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;
            buttonItem3.Checked = false;
			frmDocument doc = new frmDocument();
			doc.Text = "New Document " + (this.MdiChildren.Length + 1);
			doc.MdiParent = this;
			doc.WindowState = FormWindowState.Maximized;
			doc.Show();
			doc.Update();
		}

		private void AppCommandOpen_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			openFileDialog1.FileName = "";
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName == "")
				return;
			frmDocument doc = new frmDocument();
			doc.Text = openFileDialog1.FileName;
			doc.MdiParent = this;
			doc.Show();
			doc.OpenFile(openFileDialog1.FileName);
		}

		private void AppCommandSave_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			frmDocument doc = this.ActiveMdiChild as frmDocument;
			if (doc == null || !doc.DocumentChanged)
				return;
			SaveDocument(doc);
		}

		private void AppCommandSaveAs_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			if (this.ActiveMdiChild == null)
				return;

			// Close menu popup if needed since File Dialogs can interfer with it
			if(sender is BaseItem)
				BaseItem.CollapseAll(sender as BaseItem);

			frmDocument doc = this.ActiveMdiChild as frmDocument;
			if (doc == null || !doc.DocumentChanged)
				return;
			if (doc.FileName == "")
			{
				SaveDocument(doc);
				return;
			}

			saveFileDialog1.ShowDialog();
			if (saveFileDialog1.ShowDialog() != DialogResult.OK)
				return;
			if (saveFileDialog1.FileName == "")
				return;
			doc.FileName = saveFileDialog1.FileName;
			doc.SaveFile();
		}

		private void AppCommandTheme_Executed(object sender, EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if (source.CommandParameter is string)
			{
				eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
				// Using StyleManager change the style and color tinting
				StyleManager.ChangeStyle(style, Color.Empty);
                if (style == eStyle.Office2007Black || style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2007VistaGlass)
                    buttonFile.BackstageTabEnabled = false;
                else
                    buttonFile.BackstageTabEnabled = true;
			}
			else if (source.CommandParameter is Color)
			{
				StyleManager.ColorTint = (Color)source.CommandParameter;
			}
		}

		private void AppCommandExit_Executed(object sender, EventArgs e)
		{
			this.Close();
		}

        private void AppCommandGoToUrl_Executed(object sender, EventArgs e)
        {
            // Close Application Menu
            buttonFile.Expanded = false;
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                string url = (string)source.CommandParameter;
                System.Diagnostics.Process.Start(url);
            }
            else
                MessageBoxEx.Show("This command must have CommandParameter set to the URL you want to navigate to.");
        }

        private void RibbonStateCommand_Executed(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = RibbonStateCommand.Checked;
            RibbonStateCommand.Checked = !RibbonStateCommand.Checked;
        }
        #endregion

        #region Backstage Application Menu Content Setup
        private void SetupBackstageContent()
        {
            SetupRecentTab();
        }
        private void SetupRecentTab()
        {
            
        }

        private BaseItem CreateMruPlaceView(MruItem item)
        {
            ItemDockContainer container = new ItemDockContainer();
            container.LastChildFill = true;
            // Create Pin Button
            ButtonItem pinButton = new ButtonItem();
            pinButton.ImagePaddingHorizontal = 6;
            pinButton.Image = global::Ribbonpad.Properties.Resources.Unpinned;
            container.SetDock(pinButton, eItemDock.Right); // Position pin button on right side
            container.SubItems.Add(pinButton);
            // Create button with file name and folder
            ButtonItem fileButton = new ButtonItem();
            fileButton.ForeColor = Color.Black;
            fileButton.ButtonStyle = eButtonStyle.ImageAndText;
            fileButton.ImagePosition = eImagePosition.Left;
            fileButton.Text = item.FileName + "<br/><font color=\"Gray\">" + item.Folder + "</font>";
            fileButton.Image = global::Ribbonpad.Properties.Resources.OpenExistingPlace;
            container.SubItems.Add(fileButton);

            return container;
        }

        private BaseItem CreateMruFileView(MruItem item)
        {
            ItemDockContainer container = new ItemDockContainer();
            container.LastChildFill = true;
            // Create Pin Button
            ButtonItem pinButton = new ButtonItem();
            pinButton.ImagePaddingHorizontal = 6;
            pinButton.Image = global::Ribbonpad.Properties.Resources.Unpinned;
            container.SetDock(pinButton, eItemDock.Right); // Position pin button on right side
            container.SubItems.Add(pinButton);
            // Create button with file name and folder
            ButtonItem fileButton = new ButtonItem();
            fileButton.ForeColor = Color.Black;
            fileButton.ButtonStyle = eButtonStyle.ImageAndText;
            fileButton.ImagePosition = eImagePosition.Left;
            fileButton.Text = item.FileName + "<br/><font color=\"Gray\">" + item.Folder + "</font>";
            fileButton.Image = global::Ribbonpad.Properties.Resources.Document;
            container.SubItems.Add(fileButton);

            return container;
        }

        private MruItem[] GetMruPlaces()
        {
            return new MruItem[3] {
                new MruItem("Documents",@"\\fileserver\Documents"),
                new MruItem("My Documents",@"c:\My Documents"),
                new MruItem("Transfer",@"\\droboshare\drobo\Transfer")
            };
        }
        private MruItem[] GetMruFiles()
        {
            return new MruItem[10] {
                new MruItem("Services Invoice 108.rtf",@"\\fileserver\Documents"),
                new MruItem("Services Invoice 109.rtf",@"\\fileserver\Documents"),
                new MruItem("Sales Report.rtf",@"\\fileserver\Documents"),
                new MruItem("Marketing Draft.rtf",@"c:\My Documents"),
                new MruItem("Compensation Report.rtf",@"c:\My Documents"),
                new MruItem("Jim Review.rtf",@"c:\My Documents"),
                new MruItem("Kathy Review.rtf",@"c:\My Documents"),
                new MruItem("Invoice10201.rtf",@"c:\My Documents"),
                new MruItem("Invoice10202.rtf",@"c:\My Documents"),
                new MruItem("Invoice10203.rtf",@"c:\My Documents")
            };
        }

        private class MruItem
        {
            public MruItem(string fileName, string folder)
            {
                FileName = fileName;
                Folder = folder;
            }
            public string FileName;
            public string Folder;
        }
        #endregion

        private void ribbonBar10_ItemClick(object sender, EventArgs e)
        {

        }

        private void superTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void comboBoxItem4_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem103_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem104_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem111_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem61_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonTabContext_Click(object sender, EventArgs e)
        {
            if (!richTextOpened)
            {
                objfrmMainRTE = new frmMainRTE();
                objfrmMainRTE.MdiParent = this;
                objfrmMainRTE.Show();
                richTextOpened = true;
            }
        }

        private void buttonItem133_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.OpenToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem134_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.SaveToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem135_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.SaveAsToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem143_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.mnuUndo_Click(sender, e);
        }

        private void buttonItem144_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.mnuRedo_Click(sender, e);
        }

        private void buttonItem150_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.FindToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem151_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.FindAndReplaceToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem156_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.SelectAllToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem152_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.CopyToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem153_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.CutToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem154_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.PasteToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem142_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem122_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.BoldToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem128_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.ItalicToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem129_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.UnderlineToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem130_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.NormalToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem161_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.FontColorToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem61_Click_1(object sender, EventArgs e)
        {
            objfrmMainRTE.PageColorToolStripMenuItem_Click(sender, e);
        }

        private void colorPickerDropDown1_SelectedColorChanged(object sender, EventArgs e)
        {

        }

        private void buttonItem63_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.SelectFontToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem132_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.NewToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem76_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.InsertImageToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem69_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.tbrLeft_Click(sender, e);
        }

        private void buttonItem70_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.tbrCenter_Click(sender, e);
        }

        private void buttonItem71_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.tbrRight_Click(sender, e);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.mnuPageSetup_Click(sender, e);
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.PreviewToolStripMenuItem_Click(sender, e);
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            objfrmMainRTE.PrintToolStripMenuItem_Click(sender, e);
        }
 
 
         private void buttonItem155_Click(object sender, EventArgs e)
        {

            CcreatePDF pdf1 = new CcreatePDF();

            pdf1.MdiParent = this;
            pdf1.Show();
            ribbonControl1.Expanded = false;
            RibbonStateCommand.Checked = false; 

            
        }

        private void buttonItem157_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string fileNmae = openFileDialog2.FileName;
            if (fileNmae != "")
            {
                frmPDFViewer f = new frmPDFViewer(fileNmae);
                f.MdiParent = this;
                f.Show();
            }

            ribbonControl1.Expanded = false;
            RibbonStateCommand.Checked = false; 
            
        }

        private void Downloader_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem55_Click(object sender, EventArgs e)
        {
            //MyDownloader.App.UI.MainForm m = new MyDownloader.App.UI.MainForm();
            //m.MdiParent = this;
            //m.Show();

            Process.Start("YouTube Downloader.exe");
            
            ribbonControl1.Expanded = false;
            RibbonStateCommand.Checked = false;
         }

        private void buttonItem83_Click(object sender, EventArgs e)
        {
            Process.Start("MoviePlayer.exe");

            ribbonControl1.Expanded = false;
            RibbonStateCommand.Checked = false;
        }

        private void buttonItem84_Click(object sender, EventArgs e)
        {
            NLSFT_WB.frmMain fm = new NLSFT_WB.frmMain();
            fm.MdiParent = this;
            fm.Show();

            ribbonControl1.Expanded = false;
            RibbonStateCommand.Checked = false;

        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {
            try
            {
                formExcel.MdiParent = this;
                formExcel.Show();
            }
            catch (Exception ex)
            {
                formExcel = new Form1();
                formExcel.MdiParent = this;
                formExcel.Show();
            }
        }

        private void buttonItem127_Click(object sender, EventArgs e)
        {
            if (m_Search == null || m_Search.IsDisposed)
            {
                m_Search = new BalloonSearch();
                m_Search.Owner = this;
                m_Search.Show(sender as BaseItem, true);
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {

        }

        private void buttonGoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            try
            {
                buttonItem3.Checked = (!buttonItem3.Checked);
                frmDocument document = this.ActiveMdiChild as frmDocument;
                document.UpdateBulletStyle(buttonItem3.Checked);
            }
            catch (Exception ex) { }
        }

        private void buttonItem137_Click(object sender, EventArgs e)
        {
            if (buttonItem137.Checked)
                objfrmMainRTE.RemoveBulletsToolStripMenuItem_Click(sender, e);
            else
                objfrmMainRTE.AddBulletsToolStripMenuItem_Click(sender, e);
            
            buttonItem137.Checked = !buttonItem137.Checked;
        }

        private void buttonItem145_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem73_Click(object sender, EventArgs e)
        {
            frmDocument document = this.ActiveMdiChild as frmDocument;
            openFileDialog3.ShowDialog();
            document.addImage(openFileDialog3.FileName);
        }

        private void buttonFileSaveAs_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            try
            {
                formExcel.btnSave_Click(sender, e);
            }
            catch (Exception ex)
            { }
        }

        private void buttonItem110_Click(object sender, EventArgs e)
        {
            formExcel.addColumn();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            formExcel.addRow();
        }

        private void buttonItem112_Click(object sender, EventArgs e)
        {
            formExcel.removeColumn();
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            formExcel.removeRow();
        }

        private void buttonItem56_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Server\\ChatServer.exe");
        }

        private void buttonItem57_Click(object sender, EventArgs e)
        {
            ChatClient.ChatClientForm chForm = new ChatClient.ChatClientForm();

            chForm.MdiParent = this;
            chForm.Show();

            ribbonControl1.Expanded = false;
            RibbonStateCommand.Checked = false;
            //Process.Start(Application.StartupPath + "\\Client\\ChatClient.exe");

        }
	}
}

