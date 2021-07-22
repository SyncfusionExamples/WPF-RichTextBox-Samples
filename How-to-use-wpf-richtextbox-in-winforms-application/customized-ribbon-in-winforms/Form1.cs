#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using WindowsFormsApplication626.Properties;
using System.Runtime.InteropServices;
using System.Windows.Forms.Integration;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using WindowsFormsApplication626;
using Syncfusion.Windows.Tools.Controls;
using System.Collections;
using System.Windows.Media;
using System.Linq;

namespace BackStageDemo
{

    public partial class Form1 : RibbonForm
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;

        Syncfusion.Windows.Forms.Tools.ToolStripTabGroup toolStripTabGroup1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabGroup();
        private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton18));
            //this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton5));
            //this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3));
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            toolStripTabGroup1.Name = "Layout";
            toolStripTabGroup1.Visible = true;
            this.toolStripButton18.Enabled = false;
            this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.HorizontalItemsSpacing = 5;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(25, 52);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 149);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(181, 195);
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            this.backStageTab1.Controls.Add(this.colorPickerUIAdv1);
            this.colorPickerUIAdv1.Visible = false;


            Point[] point = new Point[2];

            getMenu();
            this.fontFamilyToolStripComboBox.Items.Add("Agency FB");
            this.fontFamilyToolStripComboBox.Items.Add("Algerian");
            this.fontFamilyToolStripComboBox.Items.Add("Arial");
            this.fontFamilyToolStripComboBox.Items.Add("Arial Rounded MT");
            this.fontFamilyToolStripComboBox.Items.Add("Baskerville Old Face");
            this.fontFamilyToolStripComboBox.Items.Add("Bauhaus 93");
            this.fontFamilyToolStripComboBox.Items.Add("Bell MT");
            this.fontFamilyToolStripComboBox.Items.Add("Berlin Sans FB");
            this.fontFamilyToolStripComboBox.Items.Add("Bernard MT");
            this.fontFamilyToolStripComboBox.Items.Add("Blackadder ITC");
            this.fontFamilyToolStripComboBox.Items.Add("Bodoni MT");
            this.fontFamilyToolStripComboBox.Items.Add("Bodoni MT Poster");
            this.fontFamilyToolStripComboBox.Items.Add("Book Antiqua");
            this.fontFamilyToolStripComboBox.Items.Add("Bookman Old Style");
            this.fontFamilyToolStripComboBox.Items.Add("Bookshelf Symbol 7");
            this.fontFamilyToolStripComboBox.Items.Add("Bradley Hand ITC");
            this.fontFamilyToolStripComboBox.Items.Add("Britannic");
            this.fontFamilyToolStripComboBox.Items.Add("Broadway");
            this.fontFamilyToolStripComboBox.Items.Add("Brush Script MT");
            this.fontFamilyToolStripComboBox.Items.Add("Buxton Sketch");
            this.fontFamilyToolStripComboBox.Items.Add("Calibri");
            this.fontFamilyToolStripComboBox.Items.Add("Californian FB");
            this.fontFamilyToolStripComboBox.Items.Add("Calisto MT");
            this.fontFamilyToolStripComboBox.Items.Add("Cambria");
            this.fontFamilyToolStripComboBox.Items.Add("Cambria Math");
            this.fontFamilyToolStripComboBox.Items.Add("Candara");
            this.fontFamilyToolStripComboBox.Items.Add("Castellar");
            this.fontFamilyToolStripComboBox.Items.Add("Centaur");
            this.fontFamilyToolStripComboBox.Items.Add("Century");
            this.fontFamilyToolStripComboBox.Items.Add("Century Gothic");
            this.fontFamilyToolStripComboBox.Items.Add("Century School Book");
            this.fontFamilyToolStripComboBox.Items.Add("Chillar");
            this.fontFamilyToolStripComboBox.Items.Add("Colona MT");
            this.fontFamilyToolStripComboBox.Items.Add("Comic Sans MS");
            this.fontFamilyToolStripComboBox.Items.Add("Consolas");
            this.fontFamilyToolStripComboBox.Items.Add("Constantia");
            this.fontFamilyToolStripComboBox.Items.Add("Cooper");
            this.fontFamilyToolStripComboBox.Items.Add("Copperplate Gothic");
            this.fontFamilyToolStripComboBox.Items.Add("Corbel");
            this.fontFamilyToolStripComboBox.Items.Add("Courier New");
            this.fontFamilyToolStripComboBox.Items.Add("Curlz MT");
            this.fontFamilyToolStripComboBox.Items.Add("Dengxian");
            this.fontFamilyToolStripComboBox.Items.Add("Ebrima");
            this.fontFamilyToolStripComboBox.Items.Add("Edwardian Script ITC");
            this.fontFamilyToolStripComboBox.Items.Add("Elephant");
            this.fontFamilyToolStripComboBox.Items.Add("Engravers MT");
            this.fontFamilyToolStripComboBox.Items.Add("Eras ITC");
            this.fontFamilyToolStripComboBox.Items.Add("Felix Titling");
            this.fontFamilyToolStripComboBox.Items.Add("Footlight MT");
            this.fontFamilyToolStripComboBox.Items.Add("Forte");
            this.fontFamilyToolStripComboBox.Items.Add("Franklin Gothic");
            this.fontFamilyToolStripComboBox.Items.Add("Franklin Goothic Book");
            this.fontFamilyToolStripComboBox.Items.Add("Freestyle Script");
            this.fontFamilyToolStripComboBox.Items.Add("French Script MT");
            this.fontFamilyToolStripComboBox.Items.Add("Gabriola");
            this.fontFamilyToolStripComboBox.Items.Add("Gadugi");
            this.fontFamilyToolStripComboBox.Items.Add("Garamond");
            this.fontFamilyToolStripComboBox.Items.Add("Georgia");
            this.fontFamilyToolStripComboBox.Items.Add("Gigi");
            this.fontFamilyToolStripComboBox.Items.Add("Gill Sans");
            this.fontFamilyToolStripComboBox.Items.Add("Gill Sans MT");
            this.fontFamilyToolStripComboBox.Items.Add("Global Monospace");
            this.fontFamilyToolStripComboBox.Items.Add("Global Sans Serif");
            this.fontFamilyToolStripComboBox.Items.Add("Global Serif");
            this.fontFamilyToolStripComboBox.Items.Add("Global User Interface");
            this.fontFamilyToolStripComboBox.Items.Add("Gloucester MT");
            this.fontFamilyToolStripComboBox.Items.Add("Goudy Old Style");
            this.fontFamilyToolStripComboBox.Items.Add("Goudy Stout");
            this.fontFamilyToolStripComboBox.Items.Add("Haettenschweiler");
            this.fontFamilyToolStripComboBox.Items.Add("Haelow Solid");
            this.fontFamilyToolStripComboBox.Items.Add("Harrington");
            this.fontFamilyToolStripComboBox.Items.Add("High Tower Text");
            this.fontFamilyToolStripComboBox.Items.Add("Impact");
            this.fontFamilyToolStripComboBox.Items.Add("Imprint MT Shadow");
            this.fontFamilyToolStripComboBox.Items.Add("Informal Roman");
            this.fontFamilyToolStripComboBox.Items.Add("Javanese Text");
            this.fontFamilyToolStripComboBox.Items.Add("Jokerman");
            this.fontFamilyToolStripComboBox.Items.Add("Juice ITC");
            this.fontFamilyToolStripComboBox.Items.Add("Kristen ITC");
            this.fontFamilyToolStripComboBox.Items.Add("Kunstler Script");
            this.fontFamilyToolStripComboBox.Items.Add("Leelawadee");
            this.fontFamilyToolStripComboBox.Items.Add("Leelawadee UI");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Bright");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Calligraphy");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Console");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Fax");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Handwriting");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Sans");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Sans Typewriter");
            this.fontFamilyToolStripComboBox.Items.Add("Lucida Sans Unicode");
            this.fontFamilyToolStripComboBox.Items.Add("Magneto");
            this.fontFamilyToolStripComboBox.Items.Add("Maiandea GD");
            this.fontFamilyToolStripComboBox.Items.Add("Malgun Gothic");
            this.fontFamilyToolStripComboBox.Items.Add("Marlett");
            this.fontFamilyToolStripComboBox.Items.Add("Matura MT Script Capitals");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft Himalaya");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft JhengHei UI");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft MHei");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft NeoGothic");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft New Tai Lue");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft Phagspa");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft Sans Serif");
            this.fontFamilyToolStripComboBox.Items.Add("Microsoft Tai Le");
            this.fontFamilyToolStripComboBox.Items.Add("Segoe UI");
            this.fontSizeToolStripComboBox.Items.Add("8");
            this.fontSizeToolStripComboBox.Items.Add("9");
            this.fontSizeToolStripComboBox.Items.Add("10");
            this.fontSizeToolStripComboBox.Items.Add("12");
            this.fontSizeToolStripComboBox.Items.Add("14");
            this.fontSizeToolStripComboBox.Items.Add("16");
            this.fontSizeToolStripComboBox.Items.Add("18");
            this.fontSizeToolStripComboBox.Items.Add("20");
            this.fontSizeToolStripComboBox.Items.Add("24");
            this.fontSizeToolStripComboBox.Items.Add("26");
            this.fontSizeToolStripComboBox.Items.Add("28");
            this.fontSizeToolStripComboBox.Items.Add("36");
            this.fontSizeToolStripComboBox.Items.Add("48");
            this.fontSizeToolStripComboBox.Items.Add("72");
            this.fontSizeToolStripComboBox.Items.Add("96");


            //if (ribbonControlAdv1.RibbonStyle == RibbonStyle.Office2016)
            //{
            //    this.ribbonControlAdv1.Height = 163;
            //    this.toolStripComboBox3.Visible = true;
            //}
            this.Info.VisibleChanged += new EventHandler(backStage1_VisibleChanged);
            foreach (ToolStripTabItem items in this.ribbonControlAdv1.Header.MainItems)
            {
                foreach (ToolStripEx item in items.Panel.Controls)
                {
                    if (item == toolStripEx2 && item == toolStripEx9)
                        item.LauncherClick += new EventHandler(item_LauncherClick);
                }
            }
            //this.ribbonControlAdv1.SizeChanged += new EventHandler(ribbonControlAdv1_SizeChanged);
            //this.ribbonControlAdv1.PanelStateChanged += new EventHandler(ribbonControlAdv1_PanelStateChanged);
        }

        void backStage1_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.ribbonControlAdv1.BackStageView.IsVisible && ribbonControlAdv1.RibbonStyle == RibbonStyle.Office2016)
                this.ribbonControlAdv1.Height = 163;
        }


        /// <summary>
        /// This event raises when the launcher is clicked
        /// </summary>
        /// <param name="sender">Instance of the Object</param>
        /// <param name="e">Contains data for the source</param>
        void item_LauncherClick(object sender, EventArgs e)
        {

            //MessageBox.Show("Launcher is clicked", "Launcher");
        }




        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }
        #region Avoid flickering
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
        //        return cp;
        //    }
        //}
        #endregion

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            toolStripTabGroup1.Color = this.ribbonControlAdv1.MenuColor = this.colorPickerUIAdv1.SelectedColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backStageButton1_Click(object sender, EventArgs e)
        {


        }

        private void backStageButton2_Click(object sender, EventArgs e)
        {

        }

        private void backStageButton3_Click(object sender, EventArgs e)
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.ribbonControlAdv1.Focus();
            base.OnKeyUp(e);
        }

        #region Fields
        ElementHost elementHost = new ElementHost();
        SfRichTextBoxAdv sfRichTextBoxAdv = new SfRichTextBoxAdv();
        #endregion
        public ElementHost ElementHost
        {
            get
            {
                return elementHost;
            }
        }
        public SfRichTextBoxAdv RichTextBoxAdv
        {
            get
            {
                return sfRichTextBoxAdv;
            }
            set
            {
                sfRichTextBoxAdv = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.HelpButton = true;
            ElementHost.Dock = DockStyle.Fill;
            RichTextBoxAdv.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(241, 241, 241));
            RichTextBoxAdv.SelectionChanged += RichTextBoxAdv_SelectionChanged;
            RichTextBoxAdv.Load("..//..//GettingStarted.docx");
            ElementHost.Child = RichTextBoxAdv;
            panel7.Controls.Add(ElementHost);
            this.ribbonControlAdv1.ShowMinimizeButton = true;
            GetToolStripbuttonImage(this.ribbonControlAdv1.RibbonStyle);
            ToolStripButton saveItem = new ToolStripButton(Resources.Save32);
            this.ribbonControlAdv1.Header.AddQuickItem(saveItem);

            ToolStripButton undoItem = new ToolStripButton(Resources.Undo16);
            undoItem.Enabled = false;
            this.ribbonControlAdv1.Header.AddQuickItem(undoItem);

            ToolStripButton redoItem = new ToolStripButton(Resources.Redo16);
            redoItem.Enabled = false;
            this.ribbonControlAdv1.Header.AddQuickItem(redoItem);

            this.fontColorToolStripSplitButtonEx.DropDown = new CustomDropDown(colorpicker1);
            colorpicker1.Picked += Colorpicker1_Picked;
        }

        private void Colorpicker1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.sfRichTextBoxAdv.Selection.CharacterFormat.FontColor = System.Windows.Media.Color.FromArgb(args.Color.A, args.Color.R, args.Color.G, args.Color.B);
        }

        private void RichTextBoxAdv_SelectionChanged(object obj, SelectionChangedEventArgs args)
        {
            if(RichTextBoxAdv != null )
            {
                if(RichTextBoxAdv.Selection.CharacterFormat.Bold.HasValue)
                    boldToolStripButton.Checked = RichTextBoxAdv.Selection.CharacterFormat.Bold.Value;
                if(RichTextBoxAdv.Selection.CharacterFormat.Italic.HasValue)
                    italicToolStripButton.Checked = RichTextBoxAdv.Selection.CharacterFormat.Italic.Value;
                if (RichTextBoxAdv.Selection.CharacterFormat.Underline.HasValue)
                    underlineToolStripButton.Checked = RichTextBoxAdv.Selection.CharacterFormat.Underline.Value != Underline.None;
                if (RichTextBoxAdv.Selection.CharacterFormat.StrikeThrough.HasValue)
                    strikethroughToolStripButton.Checked = RichTextBoxAdv.Selection.CharacterFormat.StrikeThrough.Value != StrikeThrough.None;
                if (RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment.HasValue)
                    subscriptToolStripButton.Checked = RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment.Value == BaselineAlignment.Subscript;
                if (RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment.HasValue)
                    superscriptToolStripButton.Checked = RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment.Value == BaselineAlignment.Superscript;
                if (RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment.HasValue)
                {
                    leftTextAlignmentButton.CheckState = RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment.Value == System.Windows.TextAlignment.Left ? CheckState.Checked : CheckState.Unchecked;
                    rightTextAlignmentButton.CheckState = RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment.Value == System.Windows.TextAlignment.Right ? CheckState.Checked : CheckState.Unchecked;
                    centerTextAlignmentButton.CheckState = RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment.Value == System.Windows.TextAlignment.Center ? CheckState.Checked : CheckState.Unchecked;
                    justifyTextAlignmentButton.CheckState = RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment.Value == System.Windows.TextAlignment.Justify ? CheckState.Checked : CheckState.Unchecked;
                }

                if(RichTextBoxAdv.Selection.CharacterFormat.FontFamily != null)
                fontFamilyToolStripComboBox.SelectedItem = RichTextBoxAdv.Selection.CharacterFormat.FontFamily.ToString();
                fontSizeToolStripComboBox.SelectedItem = RichTextBoxAdv.Selection.CharacterFormat.FontSize.ToString();
                //Update page layout buttons
                this.toolStripButton31.CheckState = RichTextBoxAdv.LayoutType == LayoutType.Pages ? CheckState.Checked : CheckState.Unchecked;
                this.toolStripButton32.CheckState = RichTextBoxAdv.LayoutType == LayoutType.Continuous ? CheckState.Checked: CheckState.Unchecked;
            }
        }

        private void GetToolStripbuttonImage(RibbonStyle ribbonStyle)
        {
            if (ribbonStyle == RibbonStyle.Office2010)
            {
                //this.toolStripButton1.Image = global::WindowsFormsApplication626.Properties.Resources.Paste32;
                //this.toolStripButton2.Image = global::WindowsFormsApplication626.Properties.Resources.Cut16;
                //this.toolStripButton3.Image = global::WindowsFormsApplication626.Properties.Resources.Copy16;
                //this.toolStripButton4.Image = global::WindowsFormsApplication626.Properties.Resources.FormatPainter16;
                //this.toolStripButton11.Image =global::WindowsFormsApplication626.Properties.Resources.GrowFont16;
                //this.toolStripButton16.Image =global::WindowsFormsApplication626.Properties.Resources.ShrinkFont16;
                //this.toolStripButton5.Image = global::WindowsFormsApplication626.Properties.Resources.Bold16;
                //this.toolStripButton6.Image = global::WindowsFormsApplication626.Properties.Resources.Italic16;
                //this.toolStripButton7.Image = global::WindowsFormsApplication626.Properties.Resources.Underline16;
                //this.toolStripButton8.Image = global::WindowsFormsApplication626.Properties.Resources.Strikethrough16;
                //this.toolStripButton9.Image = global::WindowsFormsApplication626.Properties.Resources.Subscript16;
                //this.toolStripButton10.Image =global::WindowsFormsApplication626.Properties.Resources.Superscript16;
                //this.toolStripSplitButtonEx1.Image= global::WindowsFormsApplication626.Properties.Resources.TextHighlightColor16;
                //this.toolStripSplitButtonEx3.Image= global::WindowsFormsApplication626.Properties.Resources.FontColor16;
                //this.toolStripButton18.Image = global::WindowsFormsApplication626.Properties.Resources.Save16;


                //this.toolStripButton28.Image = global::WindowsFormsApplication626.Properties.Resources.PrintArea;
                //this.toolStripButton30.Image = global::WindowsFormsApplication626.Properties.Resources._0356_NewComment_32;

                //this.toolStripButton24.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;
                //this.toolStripButton25.Image = global::WindowsFormsApplication626.Properties.Resources.IssueTracking_32x32;
                //this.toolStripButton26.Image = global::WindowsFormsApplication626.Properties.Resources.Table_32;
            }
            else
            {
                this.pasteToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Paste32flat.png");
                this.cutToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Cut16flat.png");
                this.copyToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Copy16flat.png");
                this.toolStripButton4.Image = Bitmap.FromFile("..//..//FlatIcons//FormatPainter16flat.png");
                this.increaseFontSizeToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//GrowFont16flat.png");
                this.decreaseFontSizeToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//ShrinkFont16flat.png");
                this.boldToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Bold16flat.png");
                this.italicToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Italic16flat.png");
                this.underlineToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Underline16flat.png");
                this.strikethroughToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Strike.png");
                this.subscriptToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//Subscript16flat.png");
                this.superscriptToolStripButton.Image = Bitmap.FromFile("..//..//FlatIcons//SuperScript16flat.png");
                this.hightlightColorToolStripSplitButtonEx.Image = Bitmap.FromFile("..//..//FlatIcons//TextHighlightColor16flat.png");
                this.fontColorToolStripSplitButtonEx.Image = Bitmap.FromFile("..//..//FlatIcons//FontColor16flat.png");
                this.toolStripButton18.Image = Bitmap.FromFile("..//..//FlatIcons//Save16flat.png");


                this.toolStripButton28.Image = Bitmap.FromFile("..//..//FlatIcons//PrintAreaflat.png");
                this.toolStripButton30.Image = Bitmap.FromFile("..//..//FlatIcons//0356_NewComment_32flat.png");

                this.nextCommentToolStripButton.Image = Bitmap.FromFile("..//..//Resources//NextComment.png");
                this.showCommentToolStripButton.Image = Bitmap.FromFile("..//..//Resources//ShowComments.png");
                this.deleteCommentToolStripButton.Image = Bitmap.FromFile("..//..//Resources//DeleteComment.png");
                this.previousCommentToolStripButton.Image = Bitmap.FromFile("..//..//Resources//PreviousComment.png");
                this.toolStripButton26.Image = Bitmap.FromFile("..//..//Resources//NewComment.png");
            }
        }

        /// <summary>
        /// To get the toolstrip button size.
        /// </summary>
        private void getSize()
        {
            if (this.ribbonControlAdv1.RibbonStyle == RibbonStyle.Office2007)
            {
                this.pasteToolStripButton.Size = new Size(39, 68);

                this.toolStripButton28.Size = new Size(39, 68);

                this.toolStripButton30.Size = new Size(39, 68);
            }
            else
            {
                this.pasteToolStripButton.Size = new Size(39, 74);

                this.toolStripButton28.Size = new Size(39, 74);

                this.toolStripButton30.Size = new Size(39, 74);
            }
        }
        private void getMenu()
        {

            ToolStripButton toolStripButton231 = new ToolStripButton();
            ToolStripButton toolStripButton81 = new ToolStripButton();
            ToolStripButton toolStripButton91 = new ToolStripButton();
            ToolStripButton toolStripButton101 = new ToolStripButton();

            ToolStripLabel toolStripLabel13 = new ToolStripLabel();
            ToolStripLabel toolStripLabel17 = new ToolStripLabel();
            ToolStripLabel toolStripLabel18 = new ToolStripLabel();

            ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();

            toolStripButton231.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton231.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.toolStripButton231.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            toolStripButton231.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton231.Name = "toolStripButton23";
            toolStripButton231.Padding = new System.Windows.Forms.Padding(5);
            toolStripButton231.Size = new System.Drawing.Size(128, 27);
            toolStripButton231.Text = "Recent Documents";


            // 
            // toolStripButton8
            // 
            toolStripButton81.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;

            toolStripButton81.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton81.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton81.Name = "toolStripButton8";
            toolStripButton81.Size = new System.Drawing.Size(69, 36);
            toolStripButton81.Text = "New";

            // 
            // toolStripButton9
            // 
            toolStripButton91.Image = global::WindowsFormsApplication626.Properties.Resources.Open32;
            toolStripButton91.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton91.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton91.Name = "toolStripButton9";
            toolStripButton91.Size = new System.Drawing.Size(69, 36);
            toolStripButton91.Text = "Open";
            // 
            // toolStripButton10
            // 
            toolStripButton101.Image = global::WindowsFormsApplication626.Properties.Resources.Save32;
            toolStripButton101.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripButton101.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton101.Name = "toolStripButton10";
            toolStripButton101.Size = new System.Drawing.Size(69, 36);
            toolStripButton101.Text = "Save";
            toolStripButton101.Enabled = false;

            // 
            // toolStripLabel13
            // 
            toolStripLabel13.Name = "toolStripLabel13";
            toolStripLabel13.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel13.Size = new System.Drawing.Size(128, 23);
            toolStripLabel13.Text = "1. Document.doc";
            toolStripLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel17
            // 
            toolStripLabel17.Name = "toolStripLabel17";
            toolStripLabel17.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel17.Size = new System.Drawing.Size(128, 23);
            toolStripLabel17.Text = "2. New Features.doc";
            toolStripLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel18
            // 
            toolStripLabel18.Name = "toolStripLabel18";
            toolStripLabel18.Padding = new System.Windows.Forms.Padding(5);
            toolStripLabel18.Size = new System.Drawing.Size(128, 23);
            toolStripLabel18.Text = "3. Report.doc";
            toolStripLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Padding = new System.Windows.Forms.Padding(5);
            toolStripSeparator1.Size = new System.Drawing.Size(112, 2);

            this.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton231,
            toolStripSeparator1,
            toolStripLabel13,
            toolStripLabel17,
            toolStripLabel18});
            ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButton81,
            toolStripButton91,
            toolStripButton101});
        }
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.backStageView1.IsVisible = false;
            SfRichTextBoxAdv.NewDocumentCommand.Execute(null, RichTextBoxAdv);
         
        }

        private void backStageButton1_Click_1(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.OpenDocumentCommand.Execute(null, RichTextBoxAdv);
            this.backStageView1.IsVisible = false;
        }

        private void backStageButton2_Click_1(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.SaveDocumentCommand.Execute(null, RichTextBoxAdv);
            this.backStageView1.IsVisible = false;
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            // Paste
            //Clipboard.GetText();
            SfRichTextBoxAdv.PasteCommand.Execute(null, RichTextBoxAdv);
        }

        private void cutToolStripButton2_Click(object sender, EventArgs e)
        {
            //string text = (ElementHost.Child as SfRichTextBoxAdv).Selection.Text;
            ////(eh.Child as SfRichTextBoxAdv).Selection.
            ////cut
            //Clipboard.SetText(text);
            SfRichTextBoxAdv.CutCommand.Execute(null, RichTextBoxAdv);

        }

        private void copyToolStripButton3_Click(object sender, EventArgs e)
        {
            //string text = (ElementHost.Child as SfRichTextBoxAdv).Selection.Text;
            ////copy
            //Clipboard.SetText(text);
            SfRichTextBoxAdv.CopyCommand.Execute(null, RichTextBoxAdv);

        }

        private void fontFamilyToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Font family
            string font = (sender as ToolStripComboBox).SelectedItem.ToString();
            System.Windows.Media.FontFamily fontfamily = new System.Windows.Media.FontFamily(font);
            if (ElementHost.Child != null)
            {
                (ElementHost.Child as SfRichTextBoxAdv).Selection.CharacterFormat.FontFamily = fontfamily;
            }
        }
        private void increaseFontSizeToolStripButton_Click(object sender, EventArgs e)
        {
            //Increase Font Size.
            this.increaseFontSizeToolStripButton.Checked = !this.increaseFontSizeToolStripButton.Checked;
            this.RichTextBoxAdv.Selection.CharacterFormat.FontSize++;
        }

        private void decreaseFontSizeToolStripButton_Click(object sender, EventArgs e)
        {
            //Decrease Font Size.
            this.decreaseFontSizeToolStripButton.Checked = !this.decreaseFontSizeToolStripButton.Checked;
            this.RichTextBoxAdv.Selection.CharacterFormat.FontSize--;
        }

        private void fontSizeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Font Size.
            double font = Convert.ToDouble((sender as ToolStripComboBox).SelectedItem.ToString());
            if (ElementHost.Child != null)
                (ElementHost.Child as SfRichTextBoxAdv).Selection.CharacterFormat.FontSize = font;
        }

        private void HightlightColorToolStripSplitButtonEx_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString() == "Yellow")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Yellow;
            else if (e.ClickedItem.Tag.ToString() == "BrightGreen")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.BrightGreen;
            else if (e.ClickedItem.Tag.ToString() == "Turquoise")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Turquoise;
            else if (e.ClickedItem.Tag.ToString() == "Pink")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Pink;
            else if (e.ClickedItem.Tag.ToString() == "Blue")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Blue;
            else if (e.ClickedItem.Tag.ToString() == "Red")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Red;
            else if (e.ClickedItem.Tag.ToString() == "DarkBlue")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.DarkBlue;
            else if (e.ClickedItem.Tag.ToString() == "Teal")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Teal;
            else if (e.ClickedItem.Tag.ToString() == "Green")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Green;
            else if (e.ClickedItem.Tag.ToString() == "Violet")
                RichTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Violet;
        }

        private void backStageButton3_Click_1(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.SaveAsDocumentCommand.Execute(null, RichTextBoxAdv);
            this.backStageView1.IsVisible = false;
        }
        private void backStageButton4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
            this.backStageView1.IsVisible = false;

        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            // Bold
            this.boldToolStripButton.Checked = !this.boldToolStripButton.Checked;
            this.RichTextBoxAdv.Selection.CharacterFormat.Bold = this.boldToolStripButton.Checked;
        }

        private void italicToolStripButton_Click(object sender, EventArgs e)
        {
            // Italic
            this.italicToolStripButton.Checked = !this.italicToolStripButton.Checked;
            this.RichTextBoxAdv.Selection.CharacterFormat.Italic = this.italicToolStripButton.Checked;
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            //UnderLine
            this.underlineToolStripButton.Checked = !this.underlineToolStripButton.Checked;
            if (this.underlineToolStripButton.Checked)
                this.RichTextBoxAdv.Selection.CharacterFormat.Underline = Underline.Single;
            else
                this.RichTextBoxAdv.Selection.CharacterFormat.Underline = Underline.None;
        }

        private void strikethroughToolStripButton_Click(object sender, EventArgs e)
        {
            //StrikeThrough
            this.strikethroughToolStripButton.Checked = !this.strikethroughToolStripButton.Checked;
            if (this.strikethroughToolStripButton.Checked)
                this.RichTextBoxAdv.Selection.CharacterFormat.StrikeThrough = StrikeThrough.SingleStrike;
            else
                this.RichTextBoxAdv.Selection.CharacterFormat.StrikeThrough = StrikeThrough.None;
        }

        private void subscriptToolStripButton_Click(object sender, EventArgs e)
        {
            //SubScript
            this.subscriptToolStripButton.Checked = !this.subscriptToolStripButton.Checked;
            if (this.subscriptToolStripButton.Checked)
                this.RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment = BaselineAlignment.Subscript;
            else
                this.RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment = BaselineAlignment.Normal;
        }

        private void superscriptToolStripButton_Click(object sender, EventArgs e)
        {
            //Superscript
            this.superscriptToolStripButton.Checked = !this.superscriptToolStripButton.Checked;
            if (this.superscriptToolStripButton.Checked)
                this.RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment = BaselineAlignment.Superscript;
            else
                this.RichTextBoxAdv.Selection.CharacterFormat.BaselineAlignment = BaselineAlignment.Normal;

        }

        private void leftTextAlignmentButton_Click(object sender, EventArgs e)
        {
            //Left aligment
            if (this.leftTextAlignmentButton.Checked)
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Left;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
                justifyTextAlignmentButton.CheckState = CheckState.Unchecked;
            }
                
            else
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Justify;
                justifyTextAlignmentButton.CheckState = CheckState.Checked;
                leftTextAlignmentButton.CheckState = CheckState.Unchecked;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
            }

        }

        private void centerTextAlignmentButton_Click(object sender, EventArgs e)
        {
            //Center alignment.
            if (this.centerTextAlignmentButton.Checked)
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Center;
                leftTextAlignmentButton.CheckState = CheckState.Unchecked;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                justifyTextAlignmentButton.CheckState = CheckState.Unchecked;
            }
      
            else
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Left;
                leftTextAlignmentButton.CheckState = CheckState.Checked;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
                justifyTextAlignmentButton.CheckState = CheckState.Unchecked;
            }

        }

        private void rightTextAlignmentButton_Click(object sender, EventArgs e)
        {
            //Right Alignement
            if (this.rightTextAlignmentButton.Checked)
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Right;
                leftTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
                justifyTextAlignmentButton.CheckState = CheckState.Unchecked;
            }

            else
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Left;
                leftTextAlignmentButton.CheckState = CheckState.Checked;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
                justifyTextAlignmentButton.CheckState = CheckState.Unchecked;
            }

        }

        private void justifyTextAlignmentButton_Click(object sender, EventArgs e)
        {
            //Justify alignment
            if (this.justifyTextAlignmentButton.Checked)
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Justify;
                leftTextAlignmentButton.CheckState = CheckState.Unchecked;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
            }
            else
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.TextAlignment = System.Windows.TextAlignment.Left;
                leftTextAlignmentButton.CheckState = CheckState.Checked;
                rightTextAlignmentButton.CheckState = CheckState.Unchecked;
                centerTextAlignmentButton.CheckState = CheckState.Unchecked;
                justifyTextAlignmentButton.CheckState = CheckState.Unchecked;
            }
        }
        
        private void lineSpacingToolStripDropDown_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            //Line spacing
            if(RichTextBoxAdv != null)
            {
                RichTextBoxAdv.Selection.ParagraphFormat.LineSpacing = Convert.ToDouble(e.ClickedItem.Text.ToString());
              
            }
        }


        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            // Read Only
            this.toolStripButton14.Checked = !this.toolStripButton14.Checked;
            if (this.toolStripButton14.Checked)
                this.RichTextBoxAdv.IsReadOnly = true;
            else
                this.RichTextBoxAdv.IsReadOnly = false;
        }


        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowOptionsPaneCommand.Execute(null, RichTextBoxAdv);
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {
            //Print Layout
            this.toolStripButton31.Checked = true;
            if (this.toolStripButton31.Checked && this.toolStripButton32.Checked)
                this.toolStripButton32.CheckState = CheckState.Unchecked;
            this.RichTextBoxAdv.LayoutType = LayoutType.Pages;
        }

        private void toolStripButton32_Click(object sender, EventArgs e)
        {
            // Web Layout
            this.toolStripButton32.Checked = true;
            if (this.toolStripButton32.Checked && this.toolStripButton31.Checked)
                this.toolStripButton31.CheckState = CheckState.Unchecked;
            this.RichTextBoxAdv.LayoutType = LayoutType.Continuous;
        }

        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            //Zoom in
            if (RichTextBoxAdv != null)
            {
                if (RichTextBoxAdv.ZoomFactor + 10 > 500)
                    RichTextBoxAdv.ZoomFactor = 500;
                else
                    RichTextBoxAdv.ZoomFactor += 10;
            }
        }
        private void toolStripButton34_Click(object sender, EventArgs e)
        {
            //Zoom Out
            if (RichTextBoxAdv != null)
            {
                if (RichTextBoxAdv.ZoomFactor - 10 < 10)
                    RichTextBoxAdv.ZoomFactor = 10;
                else
                    RichTextBoxAdv.ZoomFactor -= 10;
            }
        }

        private void toolStripButton36_Click(object sender, EventArgs e)
        {
            // One page
            SfRichTextBoxAdv.PageFitCommand.Execute("FitFullPage", RichTextBoxAdv);
        }


        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            //LeftIndent
            this.RichTextBoxAdv.Selection.ParagraphFormat.LeftIndent = this.RichTextBoxAdv.Selection.ParagraphFormat.LeftIndent - 20;
            
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            //Right Indent
            this.RichTextBoxAdv.Selection.ParagraphFormat.RightIndent = this.RichTextBoxAdv.Selection.ParagraphFormat.RightIndent + 20;
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            //100%
            SfRichTextBoxAdv.PageFitCommand.Execute(null, RichTextBoxAdv);
        }

        private void toolStripButton37_Click(object sender, EventArgs e)
        {
            //Multiple page
            SfRichTextBoxAdv.PageFitCommand.Execute("FitMultiplePages", RichTextBoxAdv);
        }

        private void toolStripButton38_Click(object sender, EventArgs e)
        {
            //Page Width
            SfRichTextBoxAdv.PageFitCommand.Execute("FitPageWidth", RichTextBoxAdv);
        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            //New Comment
            SfRichTextBoxAdv.NewCommentCommand.Execute(null, RichTextBoxAdv);
        }

        private void deleteCommentToolStripButton_Click(object sender, EventArgs e)
        {
           SfRichTextBoxAdv.DeleteCommentCommand.Execute(null, RichTextBoxAdv);
        }

        private void previousCommentToolStripButton_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.PreviousCommentCommand.Execute(null, RichTextBoxAdv);
        }

        private void nextCommentToolStripButton_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.NextCommentCommand.Execute(null, RichTextBoxAdv);
        }

        private void showCommentToolStripButton_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowCommentsCommand.Execute(null, RichTextBoxAdv);
            
        }

        private void insertTableToolStripButton_Click(object sender, EventArgs e)
        {
            //Insert Table
            SfRichTextBoxAdv.InsertTableCommand.Execute("2,2", RichTextBoxAdv);
        }

        private void insertImageToolStripButton_Click(object sender, EventArgs e)
        {
            //Picture 
            SfRichTextBoxAdv.InsertPictureCommand.Execute(null, RichTextBoxAdv);

          
        }

      

    }
}
