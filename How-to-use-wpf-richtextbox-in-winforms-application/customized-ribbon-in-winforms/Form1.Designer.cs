#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System.Drawing;
using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Media.Imaging;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.Generic;

namespace BackStageDemo
{
    partial class Form1 
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
            this.link = new ToolStripEx();

            this.linkb = new ToolStripButton();
            this.picture = new ToolStripButton();
            this.table = new ToolStripDropDownButton();
            this.proofing = new ToolStripEx();
            this.spelling = new ToolStripButton();
            this.replace = new ToolStripButton();
            this.pagebreak = new ToolStripEx();
            this.breakbutton = new ToolStripButton();
            this.styles = new ToolStripEx();
            this.stylebutton = new ToolStripDropDownButton();
            this.Bullet = new ToolStripSplitButton();
            this.Numbering = new ToolStripSplitButton();
            this.numbering = new ToolStripDropDownButton();
            this.multilist = new ToolStripDropDownButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.lefttoright = new ToolStripButton();
            this.righttoleft = new ToolStripButton();
            this.createLabel = new Label();
            this.t1 = new SuperToolTip();
            this.t1.VisualStyle = Syncfusion.Windows.Forms.Tools.SuperToolTip.Appearance.Office2016Black;
            this.labelcreate = new Label();
            this.panelcreate = new Panel();

            this.labelcreate1 = new Label();
            this.panelcreate1 = new Panel();
            this.panelcreate2 = new Panel();
            this.labelcreate2 = new Label();
            this.labelcreate3 = new Label();
            this.panelcreate3 = new Panel();
            this.labelcreate4 = new Label();
            this.panelcreate4 = new Panel();
            this.labelcreate5 = new Label();
            this.panelcreate5 = new Panel();
            this.Multilist = new ToolStripSplitButton();

            List<string> listNames = new List<string>()
                {
                    "_Bullet_Dot", "_Bullet_Square", "_Bullet_Circle", "_Bullet_Flower", "_Bullet_Tick", "_Bullet_Arrow" ,
                    "_Numbering_LowLetter_Brace","_Numbering_LowLetter_Dot","_Numbering_Number_Brace","_Numbering_Number_Dot","_Numbering_UpLetter","_Numbering_UpRoman","_Numbering_LowRoman",
                    "_List_Normal","_List_Multilevel","_List_Bullet"
                };
            foreach (string listName in listNames)
            {
                lists.Add(listName, CreateList(listName));
            }


            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitButton1 = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.toolstripitem1 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem2 = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.Info = new Syncfusion.Windows.Forms.BackStage();
            this.backStageTab1 = new Syncfusion.Windows.Forms.BackStageTab();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.backStageTab2 = new Syncfusion.Windows.Forms.BackStageTab();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label15 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.create = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel14 = new System.Windows.Forms.Panel();
            this.backStageButton1 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton2 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton3 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageButton4 = new Syncfusion.Windows.Forms.BackStageButton();
            this.backStageTab3 = new Syncfusion.Windows.Forms.BackStageTab();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label19 = new System.Windows.Forms.Label();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.panel = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.fontFamilyToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.increaseFontSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseFontSizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.strikethroughToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.subscriptToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.superscriptToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hightlightColorToolStripSplitButtonEx = new Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx();
            this.YellowHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightGreenHightlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TurquoiseHightlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PinkHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RedHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkBlueHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TealHightlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VioletHighlightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripSplitButtonEx = new ToolStripSplitButton();
            this.toolStripEx5 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem6 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripPanelItem8 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.leftindent = new System.Windows.Forms.ToolStripButton();
            this.rightindent = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem9 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.leftTextAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.centerTextAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.rightTextAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.justifyTextAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.linespacing = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEx9 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem5 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx10 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx11 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx12 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripEx4 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripTabItem3 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx8 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripTabItem4 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx14 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripEx13 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.insertTableToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.insertImageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.deleteCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.previousCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showCommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton35 = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem7 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripButton36 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton37 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton38 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.backStage5 = new Syncfusion.Windows.Forms.BackStage();
            this.backStage4 = new Syncfusion.Windows.Forms.BackStage();
            this.backStage3 = new Syncfusion.Windows.Forms.BackStage();
            this.backStage2 = new Syncfusion.Windows.Forms.BackStage();
            this.toolStripEx6 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayout5 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            this.Info.SuspendLayout();
            this.backStageTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.backStageTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).BeginInit();
            this.splitContainerAdv2.Panel1.SuspendLayout();
            this.splitContainerAdv2.Panel2.SuspendLayout();
            this.splitContainerAdv2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel17.SuspendLayout();
            this.backStageTab3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx5.SuspendLayout();
            this.toolStripEx9.SuspendLayout();
            this.toolStripEx10.SuspendLayout();
            this.toolStripEx11.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.toolStripTabItem3.Panel.SuspendLayout();
            this.toolStripTabItem4.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backStage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backStage2)).BeginInit();
            this.toolStripEx6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitButton1
            // 
            this.splitButton1.BackColor = System.Drawing.SystemColors.Control;
            this.splitButton1.BeforeTouchSize = new System.Drawing.Size(119, 86);
            this.splitButton1.DropDownItems.Add(this.toolstripitem1);
            this.splitButton1.DropDownItems.Add(this.toolstripitem2);
            this.splitButton1.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton1.ForeColor = System.Drawing.Color.Black;
            this.splitButton1.Location = new System.Drawing.Point(52, 29);
            this.splitButton1.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton1.Name = "splitButton1";
            splitButtonRenderer2.SplitButton = this.splitButton1;
            this.splitButton1.Renderer = splitButtonRenderer2;
            this.splitButton1.ShowDropDownOnButtonClick = false;
            this.splitButton1.Size = new System.Drawing.Size(119, 86);
            this.splitButton1.TabIndex = 0;
            this.splitButton1.Text = "Protect Document";
            this.splitButton1.ThemeName = "Default";
         
            
            
           
            // 
            // toolstripitem1
            // 
            this.toolstripitem1.Name = "toolstripitem1";
            this.toolstripitem1.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem1.Text = "Restrict Editing";
            this.toolstripitem1.Click += Toolstripitem1_Click;
           
            // 
            // toolstripitem2
            // 
            this.toolstripitem2.Name = "toolstripitem2";
            this.toolstripitem2.Size = new System.Drawing.Size(80, 50);
            this.toolstripitem2.Text = "Encrypt with password";
           // this.toolstripitem2.Image = global::WindowsFormsApplication626.Properties.;
            this.toolstripitem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolstripitem2.Click += Toolstripitem2_Click;
           
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem3);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem4);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1623, 224);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2013";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.Info;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            
            // 
            // Info
            // 
            this.Info.AllowDrop = true;
            this.Info.BackStagePanelWidth = 190;
            this.Info.BeforeTouchSize = new System.Drawing.Size(1619, 890);
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.ChildItemSize = new System.Drawing.Size(80, 140);
            this.Info.Controls.Add(this.backStageTab1);
            this.Info.Controls.Add(this.backStageTab2);
            this.Info.Controls.Add(this.backStageButton1);
            this.Info.Controls.Add(this.backStageButton2);
            this.Info.Controls.Add(this.backStageButton3);
            this.Info.Controls.Add(this.backStageButton4);
            this.Info.Controls.Add(this.backStageTab3);
            this.Info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Info.ItemSize = new System.Drawing.Size(258, 40);
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Info.Name = "backStage1";
            this.Info.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver;
            this.Info.Size = new System.Drawing.Size(1619, 890);
            this.Info.TabIndex = 1;
            this.Info.ThemeName = "BackStage2013Renderer";
            this.Info.Visible = false;
           
            // 
            // backStageTab1
            // 
            this.backStageTab1.Accelerator = "";
            this.backStageTab1.BackColor = System.Drawing.Color.White;
            this.backStageTab1.Controls.Add(this.splitContainerAdv1);
            this.backStageTab1.Image = null;
            this.backStageTab1.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab1.Location = new System.Drawing.Point(257, 0);
            this.backStageTab1.Name = "backStageTab1";
            this.backStageTab1.Position = new System.Drawing.Point(11, 59);
            this.backStageTab1.ShowCloseButton = true;
            this.backStageTab1.Size = new System.Drawing.Size(1362, 890);
            this.backStageTab1.TabIndex = 2;
            this.backStageTab1.Text = "Info";
            this.backStageTab1.ThemesEnabled = true;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 1;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2016White;
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.panel9);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.panel11);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1362, 890);
            this.splitContainerAdv1.SplitterDistance = 688;
            this.splitContainerAdv1.SplitterWidth = 1;
            this.splitContainerAdv1.TabIndex = 1;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(686, 888);
            this.panel9.TabIndex = 0;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(236, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(319, 89);
            this.label14.TabIndex = 2;
            this.label14.Text = "Control what types of changes people can make to this document.";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.splitButton1);
            this.panel10.Location = new System.Drawing.Point(28, 107);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(596, 174);
            this.panel10.TabIndex = 1;
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";

            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(213, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Protect Document";


            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonAdv1);
            this.panel11.Location = new System.Drawing.Point(137, 107);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(493, 301);
            this.panel11.BorderStyle = BorderStyle.None;
            this.panel11.TabIndex = 2;

            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(493, 301);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv1.Location = new System.Drawing.Point(0, 0);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(493, 301);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Image = global::WindowsFormsApplication626.Properties.Resources.RTE;
            this.buttonAdv1.TextImageRelation = TextImageRelation.Overlay;
            this.buttonAdv1.Click += ButtonAdv1_Click;
            // 
            // backStageTab2
            // 
            this.backStageTab2.Accelerator = "";
            this.backStageTab2.BackColor = System.Drawing.Color.White;
            this.backStageTab2.Controls.Add(this.splitContainerAdv2);
            this.backStageTab2.Image = null;
            this.backStageTab2.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab2.Location = new System.Drawing.Point(257, 0);
            this.backStageTab2.Name = "backStageTab2";
            this.backStageTab2.Position = new System.Drawing.Point(60, 108);
            this.backStageTab2.ShowCloseButton = true;
            this.backStageTab2.Size = new System.Drawing.Size(1362, 890);
            this.backStageTab2.TabIndex = 3;
            this.backStageTab2.Text = "New";
            this.backStageTab2.ThemesEnabled = false;
            // 
            // splitContainerAdv2
            // 
            this.splitContainerAdv2.BeforeTouchSize = 2;
            this.splitContainerAdv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv2.IsSplitterFixed = true;
            this.splitContainerAdv2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv2.Name = "splitContainerAdv2";
            // 
            // splitContainerAdv2.Panel1
            // 
            this.splitContainerAdv2.Panel1.Controls.Add(this.panel12);
            // 
            // splitContainerAdv2.Panel2
            // 
            this.splitContainerAdv2.Panel2.Controls.Add(this.panel17);
            this.splitContainerAdv2.Size = new System.Drawing.Size(1362, 890);
            this.splitContainerAdv2.SplitterDistance = 631;
            this.splitContainerAdv2.SplitterWidth = 2;
            this.splitContainerAdv2.TabIndex = 6;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            this.splitContainerAdv2.ThemeName = "None";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.label15);
            this.panel12.Controls.Add(this.panelcreate1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(629, 888);
            this.panel12.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label17);
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.buttonAdv2);
            this.panel13.Controls.Add(this.panelcreate1);
            this.panel13.Controls.Add(this.panelcreate2);
            this.panel13.Location = new System.Drawing.Point(39, 110);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(548, 800);
            this.panel13.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(180, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 73);
            this.label17.TabIndex = 2;
            this.label17.Text = "It creates the new empty document.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(180, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Blank Document";

            //label1

            this.labelcreate1.Location = new System.Drawing.Point(30, 8);
            this.labelcreate1.Name = "label17";
            this.labelcreate1.Size = new System.Drawing.Size(600, 73);
            this.labelcreate1.TabIndex = 2;
            this.labelcreate1.Text = "------------------------------------------------------------";

            //panel1
            this.panelcreate1.Location = new System.Drawing.Point(30, 8);
            this.panelcreate1.Name = "panel13";
            this.panelcreate1.Size = new System.Drawing.Size(700, 146);
            this.panelcreate1.TabIndex = 1;
            this.panelcreate1.Controls.Add(this.labelcreate1);

            //label2

            this.labelcreate2.Location = new System.Drawing.Point(30, 87);
            this.labelcreate2.Name = "label17";
            this.labelcreate2.Size = new System.Drawing.Size(600, 73);
            this.labelcreate2.TabIndex = 2;
            this.labelcreate2.Text = "------------------------------------------------------------";

            //panel2
            this.panelcreate2.Location = new System.Drawing.Point(30, 87);
            this.panelcreate2.Name = "panel13";
            this.panelcreate2.Size = new System.Drawing.Size(700, 146);
            this.panelcreate2.TabIndex = 1;
            this.panelcreate2.Controls.Add(this.labelcreate2);

            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(109, 110);
            this.buttonAdv2.Location = new System.Drawing.Point(54, 50);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(109, 110);
            this.buttonAdv2.TabIndex = 0;
            this.buttonAdv2.Text = "Blank Document";
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            this.buttonAdv2.Image = global::WindowsFormsApplication626.Properties.Resources.BlankPage32;
            this.buttonAdv2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(97, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Available Templates";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label18);
            this.panel17.Controls.Add(this.create);
            //this.panel17.Controls.Add(this.panel14);
            this.panel17.Controls.Add(this.panelcreate);
           
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(727, 888);
            this.panel17.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 23);
            this.label18.TabIndex = 3;
            this.label18.Text = "Blank Document";
            // 
            // create
            // 
            this.create.BeforeTouchSize = new System.Drawing.Size(109, 110);
            this.create.Location = new System.Drawing.Point(20, 600);
            this.create.Name = "buttonAdv2";
            this.create.Size = new System.Drawing.Size(109, 110);
            this.create.TabIndex = 0;
            this.create.Text = "Create";
            this.create.Image = global::WindowsFormsApplication626.Properties.Resources.New32;
            this.create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.create.Click += Create_Click;

            //labelceate
            this.labelcreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelcreate.Location = new System.Drawing.Point(0, 0);
            this.labelcreate.Name = "panel17";
            this.labelcreate.Size = new System.Drawing.Size(301, 493);
            this.labelcreate.TabIndex = 5;
            this.labelcreate.Text = " ";
            this.labelcreate.Dock = System.Windows.Forms.DockStyle.Fill;

            //panelcreate
            this.panelcreate.Controls.Add(this.labelcreate);
            this.panelcreate.Location = new System.Drawing.Point(28, 80);
            this.panelcreate.Name = "panel11";
            this.panelcreate.Size = new System.Drawing.Size(301, 493);
            this.panelcreate.BorderStyle = BorderStyle.None;
            this.panelcreate.TabIndex = 2;
            this.panelcreate.BorderStyle = BorderStyle.FixedSingle;

            //createLabel
            this.createLabel.AutoSize = true;
            this.createLabel.Location = new System.Drawing.Point(48, 411);
            this.createLabel.Name = "label18";
            this.createLabel.Size = new System.Drawing.Size(136, 23);
            this.createLabel.TabIndex = 3;
            this.createLabel.Text = "Hello World ";

            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(26, 62);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(308, 240);
            this.panel14.TabIndex = 2;
            // 
            // backStageButton1
            // 
            this.backStageButton1.Accelerator = "";
            this.backStageButton1.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton1.Location = new System.Drawing.Point(40, 108);
            this.backStageButton1.Name = "backStageButton1";
            this.backStageButton1.Size = new System.Drawing.Size(308, 240);
            this.backStageButton1.TabIndex = 4;
            this.backStageButton1.Text = "Open";
            this.backStageButton1.Click += new System.EventHandler(this.backStageButton1_Click_1);
            // 
            // backStageButton2
            // 
            this.backStageButton2.Accelerator = "";
            this.backStageButton2.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton2.Location = new System.Drawing.Point(40, 133);
            this.backStageButton2.Name = "backStageButton2";
            this.backStageButton2.Size = new System.Drawing.Size(188, 37);
            this.backStageButton2.TabIndex = 5;
            this.backStageButton2.Text = "Save";
            this.backStageButton2.Click += new System.EventHandler(this.backStageButton2_Click_1);
            // 
            // backStageButton3
            // 
            this.backStageButton3.Accelerator = "";
            this.backStageButton3.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton3.Location = new System.Drawing.Point(40, 158);
            this.backStageButton3.Name = "backStageButton3";
            this.backStageButton3.Size = new System.Drawing.Size(188, 37);
            this.backStageButton3.TabIndex = 6;
            this.backStageButton3.Text = "Save as";
            this.backStageButton3.Click += new System.EventHandler(this.backStageButton3_Click_1);
            // 
            // backStageButton4
            // 
            this.backStageButton4.Accelerator = "";
            this.backStageButton4.BackColor = System.Drawing.Color.Transparent;
            this.backStageButton4.Location = new System.Drawing.Point(40, 183);
            this.backStageButton4.Name = "backStageButton4";
            this.backStageButton4.Size = new System.Drawing.Size(188, 37);
            this.backStageButton4.TabIndex = 7;
            this.backStageButton4.Text = "Print";
            this.backStageButton4.Click += new System.EventHandler(this.backStageButton4_Click);
            // 
            // backStageTab3
            // 
            this.backStageTab3.Accelerator = "";
            this.backStageTab3.BackColor = System.Drawing.Color.White;
            this.backStageTab3.Controls.Add(this.panel15);
            this.backStageTab3.Image = null;
            this.backStageTab3.ImageSize = new System.Drawing.Size(16, 16);
            this.backStageTab3.Location = new System.Drawing.Point(257, 0);
            this.backStageTab3.Name = "backStageTab3";
            this.backStageTab3.Position = new System.Drawing.Point(109, 157);
            this.backStageTab3.ShowCloseButton = true;
            this.backStageTab3.Size = new System.Drawing.Size(1362, 890);
            this.backStageTab3.TabIndex = 8;
            this.backStageTab3.Text = "Help";
            this.backStageTab3.ThemesEnabled = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.label19);
            
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1362, 1800);
            this.panel15.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label23);
            this.panel16.Controls.Add(this.label22);
            this.panel16.Controls.Add(this.label21);
            this.panel16.Controls.Add(this.label20);
            this.panel16.Controls.Add(this.buttonAdv4);
            this.panel16.Controls.Add(this.buttonAdv3);
            this.panel16.Controls.Add(this.panelcreate4);
            this.panel16.Controls.Add(this.panelcreate3);
            this.panel16.Controls.Add(this.panelcreate5);
           
          

            this.panel16.Location = new System.Drawing.Point(84, 117);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1600, 1200);
            this.panel16.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(160, 220);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 23);
            this.label23.TabIndex = 5;
            this.label23.Text = "A complete information on Syncfusion RichTextBox \n contorl and its usage.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(160, 180);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 50);
            this.label22.TabIndex = 4;
            this.label22.Text = "Getting Started";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(160, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 180);
            this.label21.TabIndex = 3;

            this.label21.Text = "UG documents helps understanding the usage of \n our Syncfusion UI components.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(160, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 100);
            this.label20.TabIndex = 2;
            this.label20.Text = "Online Help";
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(137, 43);
            this.buttonAdv4.Location = new System.Drawing.Point(35, 180);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(109,90);
            this.buttonAdv4.TabIndex = 1;
            this.buttonAdv4.Text = "Getting Started";
            this.buttonAdv4.Image = global::WindowsFormsApplication626.Properties.Resources.Started;
            this.buttonAdv4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdv4.Click += ButtonAdv4_Click;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(137, 58);
            this.buttonAdv3.Location = new System.Drawing.Point(38, 40);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(109, 90);
            this.buttonAdv3.TabIndex = 0;
            this.buttonAdv3.Text = "Online Help";
            this.buttonAdv3.Image = global::WindowsFormsApplication626.Properties.Resources.help;
            this.buttonAdv3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAdv3.Click += ButtonAdv3_Click;

            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(118, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(275, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Syncfusion User Interface Help";


            //label3

            this.labelcreate3.Location = new System.Drawing.Point(25, 1);
            this.labelcreate3.Name = "label17";
            this.labelcreate3.Size = new System.Drawing.Size(600, 73);
            this.labelcreate3.TabIndex = 2;
            this.labelcreate3.Text = "------------------------------------------------------------";

            //panel3
            this.panelcreate3.Location = new System.Drawing.Point(25, 1);
            this.panelcreate3.Name = "panel13";
            this.panelcreate3.Size = new System.Drawing.Size(700, 146);
            this.panelcreate3.TabIndex = 1;
            this.panelcreate3.Controls.Add(this.labelcreate3);

            //label4

            this.labelcreate4.Location = new System.Drawing.Point(25, 68);
            this.labelcreate4.Name = "label17";
            this.labelcreate4.Size = new System.Drawing.Size(600, 73);
            this.labelcreate4.TabIndex = 2;
            this.labelcreate4.Text = "------------------------------------------------------------";

            //panel4
            this.panelcreate4.Location = new System.Drawing.Point(25, 68);
            this.panelcreate4.Name = "panel13";
            this.panelcreate4.Size = new System.Drawing.Size(700, 146);
            this.panelcreate4.TabIndex = 1;
            this.panelcreate4.Controls.Add(this.labelcreate4);

            //label5

            this.labelcreate5.Location = new System.Drawing.Point(25, 69);
            this.labelcreate5.Name = "label17";
            this.labelcreate5.Size = new System.Drawing.Size(600, 73);
            this.labelcreate5.TabIndex = 2;
            this.labelcreate5.Text = "------------------------------------------------------------";

            //panel5
            this.panelcreate5.Location = new System.Drawing.Point(25, 69);
            this.panelcreate5.Name = "panel13";
            this.panelcreate5.Size = new System.Drawing.Size(700, 146);
            this.panelcreate5.TabIndex = 1;
            this.panelcreate5.Controls.Add(this.labelcreate5);


            // 
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx5);
            //this.toolStripTabItem1.Panel.Controls.Add(this.styles);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx9);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx10);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx11);
            

            this.toolStripTabItem1.Panel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 53, 0);
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 0;
            this.toolStripTabItem1.Panel.Text = "Home";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(87, 101);
            this.toolStripTabItem1.Text = "Home";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripButton,
            this.toolStripPanelItem1});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx1.Size = new System.Drawing.Size(200, 132);
            this.toolStripEx1.TabIndex = 3;
            this.toolStripEx1.Text = "Clipboard";
            this.toolStripEx1.LauncherClick += ToolStripEx1_LauncherClick;
            this.toolStripEx1.ShowLauncher = false;
            // 

            // pasteToolStripButton
            // 
            this.pasteToolStripButton.AutoSize = true;
            this.pasteToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Paste32;
            this.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(87, 101);
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();

           
            toolTipInfo1.Header.Text = "Paste (Ctrl +v )";
            toolTipInfo1.Body.Text = "Add Content on the Clipboard to your Document";
            toolTipInfo1.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.pasteToolStripButton, toolTipInfo1);



            // 
            // toolStripPanelItem1
            // cc
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripButton,
            this.copyToolStripButton});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripPanelItem1.Size = new System.Drawing.Size(89, 104);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
          
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(63, 30);
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton2_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo2.Header.Text = "Cut (Ctrl+x)";
            toolTipInfo2.Body.Text = "Remove the Selectiona and put it on the Clipboard , so you can paste it somewhere else";
            toolTipInfo2.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.cutToolStripButton, toolTipInfo2);

            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(83, 30);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton3_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo3.Header.Text = "Copy (Ctrl+c)";
            toolTipInfo3.Body.Text = "Remove the Selectiona and put it on the Clipboard , so you can paste it somewhere else";
            toolTipInfo3.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.copyToolStripButton, toolTipInfo3);
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.AutoSize = false;
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem2});
            this.toolStripEx2.Location = new System.Drawing.Point(165, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx2.Size = new System.Drawing.Size(368, 132);
            this.toolStripEx2.TabIndex = 2;
            this.toolStripEx2.Text = "Font";
            this.toolStripEx2.LauncherClick += ToolStripEx2_LauncherClick;
            // 
            // toolStripPanelItem2
            // 
            this.toolStripPanelItem2.CausesValidation = false;
            this.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem3,
            this.toolStripPanelItem4});
            this.toolStripPanelItem2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripPanelItem2.Name = "toolStripPanelItem2";
            this.toolStripPanelItem2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripPanelItem2.RowCount = 2;
            this.toolStripPanelItem2.Size = new System.Drawing.Size(328, 104);
            this.toolStripPanelItem2.Text = "toolStripPanelItem2";
            this.toolStripPanelItem2.Transparent = false;
            // 
            // toolStripPanelItem3
            // 
            this.toolStripPanelItem3.CausesValidation = false;
            this.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontFamilyToolStripComboBox,
            this.fontSizeToolStripComboBox,
            this.increaseFontSizeToolStripButton,
            this.decreaseFontSizeToolStripButton});
            this.toolStripPanelItem3.Name = "toolStripPanelItem3";
            this.toolStripPanelItem3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripPanelItem3.RowCount = 1;
            this.toolStripPanelItem3.Size = new System.Drawing.Size(320, 44);
            this.toolStripPanelItem3.Transparent = true;
            // 
            // fontFamilyToolStripComboBox
            // 
            this.fontFamilyToolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fontFamilyToolStripComboBox.Name = "fontFamilyToolStripComboBox";
            this.fontFamilyToolStripComboBox.Size = new System.Drawing.Size(100, 40);
            this.fontFamilyToolStripComboBox.Text = "Calibri";
            this.fontFamilyToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyToolStripComboBox_SelectedIndexChanged);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo25 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo25.Header.Text = "Font (ctrl +shift+f)";
            toolTipInfo25.Body.Text = "Pick a new font for your text ";
            toolTipInfo25.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.fontFamilyToolStripComboBox, toolTipInfo25);
            // 
            // fontSizeToolStripComboBox
            // 
            this.fontSizeToolStripComboBox.AutoSize = false;
            this.fontSizeToolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fontSizeToolStripComboBox.Name = "fontSizeToolStripComboBox";
            this.fontSizeToolStripComboBox.Size = new System.Drawing.Size(40, 40);
            this.fontSizeToolStripComboBox.Text = "24";
            this.fontSizeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeToolStripComboBox_SelectedIndexChanged);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo26 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo26.Header.Text = " Font size (ctrl +shift +p)";
            toolTipInfo26.Body.Text = "Change the Size of your Text ";
            toolTipInfo26.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.fontSizeToolStripComboBox, toolTipInfo26);
            // 
            // increaseFontSizeToolStripButton
            // 
            this.increaseFontSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseFontSizeToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.GrowFont16;
            this.increaseFontSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.increaseFontSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseFontSizeToolStripButton.Name = "increaseFontSizeToolStripButton";
            this.increaseFontSizeToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.increaseFontSizeToolStripButton.Text = "Grow Font";
            this.increaseFontSizeToolStripButton.Click += new System.EventHandler(this.increaseFontSizeToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo27 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo27.Header.Text = " Increase Font size (ctrl +shift + >)";
            toolTipInfo27.Body.Text = "Make your Text a Bit Bigger";
            toolTipInfo27.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.increaseFontSizeToolStripButton, toolTipInfo27);
            // 
            // decreaseFontSizeToolStripButton
            // 
            this.decreaseFontSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseFontSizeToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.ShrinkFont16;
            this.decreaseFontSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseFontSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseFontSizeToolStripButton.Name = "decreaseFontSizeToolStripButton";
            this.decreaseFontSizeToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.decreaseFontSizeToolStripButton.Text = "Shrink Font";
            this.decreaseFontSizeToolStripButton.Click += new System.EventHandler(this.decreaseFontSizeToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo28 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo28.Header.Text = " DecreaseFontsize (ctrl+shift+<)";
            toolTipInfo28.Body.Text = "Make your Text a Bit Smaller";
            toolTipInfo28.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.decreaseFontSizeToolStripButton, toolTipInfo28);
            // 
            // toolStripPanelItem4
            // 
            this.toolStripPanelItem4.CausesValidation = false;
            this.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripButton,
            this.italicToolStripButton,
            this.underlineToolStripButton,
            this.strikethroughToolStripButton,
            this.subscriptToolStripButton,
            this.superscriptToolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator4,
            this.hightlightColorToolStripSplitButtonEx,
            this.fontColorToolStripSplitButtonEx});
            this.toolStripPanelItem4.Name = "toolStripPanelItem4";
            this.toolStripPanelItem4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripPanelItem4.RowCount = 1;
            this.toolStripPanelItem4.Size = new System.Drawing.Size(294, 37);
            this.toolStripPanelItem4.Text = "toolStripPanelItem4";
            this.toolStripPanelItem4.Transparent = true;
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Bold16;
            this.boldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(33, 30);
            this.boldToolStripButton.Text = "Bold";
            this.ribbonControlAdv1.SetUseInQuickAccessMenu(this.boldToolStripButton, true);
            this.boldToolStripButton.Click += new System.EventHandler(this.boldToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo29 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo29.Header.Text = " Bold (ctrl +B)";
            toolTipInfo29.Body.Text = "Make your Text Bold";
            toolTipInfo29.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.boldToolStripButton, toolTipInfo29);



            // 
            // italicToolStripButton
            // 
            this.italicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Italic16;
            this.italicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripButton.Name = "italicToolStripButton";
            this.italicToolStripButton.Size = new System.Drawing.Size(33, 30);
            this.italicToolStripButton.Text = "Italic";
            this.italicToolStripButton.Click += new System.EventHandler(this.italicToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo30 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo30.Header.Text = " Italic (ctrl +i)";
            toolTipInfo30.Body.Text = "Italicize your Text";
            toolTipInfo30.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.italicToolStripButton, toolTipInfo30);
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Underline16;
            this.underlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(33, 30);
            this.underlineToolStripButton.Text = "Underline";
            this.underlineToolStripButton.Click += new System.EventHandler(this.underlineToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo31 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo31.Header.Text = " Underline (ctrl+v)";
            toolTipInfo31.Body.Text = "Underline your Text";
            toolTipInfo31.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.underlineToolStripButton, toolTipInfo31);
            // 
            // 
            // strikethroughToolStripButton
            // 
            this.strikethroughToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikethroughToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Strikethrough16;
            this.strikethroughToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikethroughToolStripButton.Name = "strikethroughToolStripButton";
            this.strikethroughToolStripButton.Size = new System.Drawing.Size(33, 30);
            this.strikethroughToolStripButton.Text = "Strikethrough";
            this.strikethroughToolStripButton.Click += new System.EventHandler(this.strikethroughToolStripButton_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo32 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo32.Header.Text = "Strike Through";
            toolTipInfo32.Body.Text = "Cross Something out by drawing a line through it";
            toolTipInfo32.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.strikethroughToolStripButton, toolTipInfo32);


            // toolStripSeparator4
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(4, 33);
            // 
            // subscriptToolStripButton
            // 
            this.subscriptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subscriptToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Subscript16;
            this.subscriptToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.subscriptToolStripButton.Name = "subscriptToolStripButton";
            this.subscriptToolStripButton.Size = new System.Drawing.Size(33, 30);
            this.subscriptToolStripButton.Text = "Subscript";
            this.subscriptToolStripButton.Click += new System.EventHandler(this.subscriptToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo33 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo33.Header.Text = "Subscript (ctrl + =)";
            toolTipInfo33.Body.Text = "Type very small letter just above the line of Text";
            toolTipInfo33.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.subscriptToolStripButton, toolTipInfo33);
            // 
            // superscriptToolStripButton
            // 
            this.superscriptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.superscriptToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Superscript16;
            this.superscriptToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.superscriptToolStripButton.Name = "superscriptToolStripButton";
            this.superscriptToolStripButton.Size = new System.Drawing.Size(33, 30);
            this.superscriptToolStripButton.Text = "Superscript";
            this.superscriptToolStripButton.Click += new System.EventHandler(this.superscriptToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo34 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo34.Header.Text = "Superscript (ctrl+ shift+ +)";
            toolTipInfo34.Body.Text = "Type very small letter just above the line of Text";
            toolTipInfo34.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.superscriptToolStripButton, toolTipInfo34);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(4, 33);

            // toolStripSeparator2
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(4, 33);

            // toolStripSeparator3
            this.toolStripSeparator3.Name = "toolStripSeparator1";
            this.toolStripSeparator3.Size = new System.Drawing.Size(4, 33);

            // hightlightColorToolStripSplitButtonEx
            // 
            this.hightlightColorToolStripSplitButtonEx.AutoSize = false;
            this.hightlightColorToolStripSplitButtonEx.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YellowHighlightButton,
            this.BrightGreenHightlightButton,
            this.TurquoiseHightlightButton,
            this.PinkHighlightButton,
            this.BlueHighlightButton,
            this.RedHighlightButton,
            this.DarkBlueHighlightButton,
            this.TealHightlightButton,
            this.GreenHighlightButton,
            this.VioletHighlightButton});
            this.hightlightColorToolStripSplitButtonEx.Image = global::WindowsFormsApplication626.Properties.Resources.TextHighlightColor16;
            this.hightlightColorToolStripSplitButtonEx.Name = "hightlightColorToolStripSplitButtonEx";
            this.hightlightColorToolStripSplitButtonEx.Size = new System.Drawing.Size(43, 30);
            this.hightlightColorToolStripSplitButtonEx.ToolTipText = "TextHighlight Color";
            this.hightlightColorToolStripSplitButtonEx.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HightlightColorToolStripSplitButtonEx_DropDownItemClicked);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo35 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo35.Header.Text = "Text Hightlight Color";
            toolTipInfo35.Body.Text = "Make your Text pop by Highlighting it in a Bright color";
            toolTipInfo35.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.hightlightColorToolStripSplitButtonEx, toolTipInfo35);
            // 
            // YellowHighlightButton
            // 
            this.YellowHighlightButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowHighlightButton.Name = "YellowHighlightButton";
            this.YellowHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.YellowHighlightButton.Tag = "Yellow";
            // 
            // BrightGreenHightlightButton
            // 
            this.BrightGreenHightlightButton.BackColor = System.Drawing.Color.Chartreuse;
            this.BrightGreenHightlightButton.Name = "BrightGreenHightlightButton";
            this.BrightGreenHightlightButton.Size = new System.Drawing.Size(72, 22);
            this.BrightGreenHightlightButton.Tag = "BrightGreen";
            // 
            // TurquoiseHightlightButton
            // 
            this.TurquoiseHightlightButton.BackColor = System.Drawing.Color.Turquoise;
            this.TurquoiseHightlightButton.Name = "TurquoiseHightlightButton";
            this.TurquoiseHightlightButton.Size = new System.Drawing.Size(72, 22);
            this.TurquoiseHightlightButton.Tag = "Turquoise";
            // 
            // PinkHighlightButton
            // 
            this.PinkHighlightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PinkHighlightButton.Name = "PinkHighlightButton";
            this.PinkHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.PinkHighlightButton.Tag = "Pink";
            // 
            // BlueHighlightButton
            // 
            this.BlueHighlightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BlueHighlightButton.Name = "BlueHighlightButton";
            this.BlueHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.BlueHighlightButton.Tag = "Blue";
            // 
            // RedHighlightButton
            // 
            this.RedHighlightButton.BackColor = System.Drawing.Color.Red;
            this.RedHighlightButton.Name = "RedHighlightButton";
            this.RedHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.RedHighlightButton.Tag = "Red";
            // 
            // DarkBlueHighlightButton
            // 
            this.DarkBlueHighlightButton.BackColor = System.Drawing.Color.DarkBlue;
            this.DarkBlueHighlightButton.Name = "DarkBlueHighlightButton";
            this.DarkBlueHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.DarkBlueHighlightButton.Tag = "DarkBlue";
            // 
            // TealHightlightButton
            // 
            this.TealHightlightButton.BackColor = System.Drawing.Color.Teal;
            this.TealHightlightButton.Name = "TealHightlightButton";
            this.TealHightlightButton.Size = new System.Drawing.Size(72, 22);
            this.TealHightlightButton.Tag = "Teal";
            // 
            // GreenHighlightButton
            // 
            this.GreenHighlightButton.BackColor = System.Drawing.Color.Green;
            this.GreenHighlightButton.Name = "GreenHighlightButton";
            this.GreenHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.GreenHighlightButton.Tag = "Green";
            // 
            // VioletHighlightButton
            // 
            this.VioletHighlightButton.BackColor = System.Drawing.Color.Violet;
            this.VioletHighlightButton.Name = "VioletHighlightButton";
            this.VioletHighlightButton.Size = new System.Drawing.Size(72, 22);
            this.VioletHighlightButton.Tag = "Violet";
            // 
            // fontColorToolStripSplitButtonEx
            // 
            this.fontColorToolStripSplitButtonEx.Image = global::WindowsFormsApplication626.Properties.Resources.FontColor16;
            this.fontColorToolStripSplitButtonEx.Name = "fontColorToolStripSplitButtonEx";
            this.fontColorToolStripSplitButtonEx.Size = new System.Drawing.Size(43, 30);
            this.fontColorToolStripSplitButtonEx.ToolTipText = "Font Color";

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo36 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo36.Header.Text = "Font Color";
            toolTipInfo36.Body.Text = "Change the Color of your Text";
            toolTipInfo36.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.fontColorToolStripSplitButtonEx, toolTipInfo36);
            // 
            // toolStripEx5
            // 
            this.toolStripEx5.AutoSize = false;
            this.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx5.Image = null;
            this.toolStripEx5.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem6,});
            this.toolStripEx5.Location = new System.Drawing.Point(535, 1);
            this.toolStripEx5.Name = "toolStripEx5";
            this.toolStripEx5.Office12Mode = false;
            this.toolStripEx5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx5.Size = new System.Drawing.Size(300, 132);
            this.toolStripEx5.TabIndex = 2;
            this.toolStripEx5.Text = "Paragraph";
         
            this.toolStripEx5.LauncherClick += ToolStripEx5_LauncherClick;


         
            // 
            // toolStripPanelItem6
            // 
            this.toolStripPanelItem6.CausesValidation = false;
            this.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem8, this.toolStripPanelItem9
           });
            this.toolStripPanelItem6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripPanelItem6.Name = "toolStripPanelItem6";
            this.toolStripPanelItem6.RowCount = 2;
            this.toolStripPanelItem6.Size = new System.Drawing.Size(125, 104);
            this.toolStripPanelItem6.Text = "toolStripPanelItem6";
            this.toolStripPanelItem6.Transparent = true;
            // 
            // toolStripPanelItem8
            // 
            this.toolStripPanelItem8.AutoSize = false;
            this.toolStripPanelItem8.CausesValidation = false;
            this.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
             this.Bullet,
            this.Numbering,
            this.Multilist,
            this.toolStripSeparator2,
            this.leftindent,
            this.rightindent,
            this.toolStripSeparator3,
            this.lefttoright,
            this.righttoleft,


            });
            this.toolStripPanelItem8.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStripPanelItem8.Name = "toolStripPanelItem8";
            this.toolStripPanelItem8.Size = new System.Drawing.Size(37, 70);
            this.toolStripPanelItem8.Text = "toolStripPanelItem8";
            this.toolStripPanelItem8.Transparent = true;
            this.toolStripPanelItem8.RowCount = 1;
            // 
            // leftindent
            // 
            this.leftindent.AutoSize = false;
            this.leftindent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftindent.Image = global::WindowsFormsApplication626.Properties.Resources.DecreaseIndent16;
            this.leftindent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftindent.Name = "toolStripButton12";
            this.leftindent.Size = new System.Drawing.Size(33, 30);
            this.leftindent.Text = "toolStripButton12";
            this.leftindent.Click += new System.EventHandler(this.toolStripButton12_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo40 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo40.Header.Text = "Decrease Indent";
            toolTipInfo40.Body.Text = "Move Your Paragraph Close to the Margin";
            toolTipInfo40.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.leftindent, toolTipInfo40);
            // 
            // rightindent
            // 
            this.rightindent.AutoSize = false;
            this.rightindent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightindent.Image = global::WindowsFormsApplication626.Properties.Resources.IncreaseIndent16;
            this.rightindent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightindent.Name = "toolStripButton13";
            this.rightindent.Size = new System.Drawing.Size(33, 30);
            this.rightindent.Text = "toolStripButton13";
            this.rightindent.Click += new System.EventHandler(this.toolStripButton13_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo41 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo41.Header.Text = "Increase Indent";
            toolTipInfo41.Body.Text = "Move Your Paragraph Farther away from  the Margin";
            toolTipInfo41.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.rightindent, toolTipInfo41);
            // 
            // toolStripPanelItem9
            // 
            this.toolStripPanelItem9.AutoSize = false;
            this.toolStripPanelItem9.CausesValidation = false;
            this.toolStripPanelItem9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftTextAlignmentButton,
            this.centerTextAlignmentButton,
            this.rightTextAlignmentButton,
            this.justifyTextAlignmentButton,
            this.toolStripSeparator1,
            this.linespacing,
            
            });
            this.toolStripPanelItem9.Name = "toolStripPanelItem9";
            this.toolStripPanelItem9.Size = new System.Drawing.Size(80, 103);
            this.toolStripPanelItem9.Text = "toolStripPanelItem9";
            this.toolStripPanelItem9.Transparent = true;
            this.toolStripPanelItem9.RowCount = 1;
            // 
            // leftTextAlignmentButton
            // 
            this.leftTextAlignmentButton.AutoSize = false;
            this.leftTextAlignmentButton.CheckOnClick = true;
            this.leftTextAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftTextAlignmentButton.Image = global::WindowsFormsApplication626.Properties.Resources.AlignTextLeft16;
            this.leftTextAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftTextAlignmentButton.Name = "leftTextAlignmentButton";
            this.leftTextAlignmentButton.Size = new System.Drawing.Size(33, 30);
            this.leftTextAlignmentButton.Text = "toolStripButton39";
            this.leftTextAlignmentButton.Click += new System.EventHandler(this.leftTextAlignmentButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo42 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo42.Header.Text = "Align Left (ctrl + L)";
            toolTipInfo42.Body.Text = "Align your Content with the Left Margin";
            toolTipInfo42.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.leftTextAlignmentButton, toolTipInfo42);
            // 
            // centerTextAlignmentButton
            // 
            this.centerTextAlignmentButton.AutoSize = false;
            this.centerTextAlignmentButton.CheckOnClick = true;
            this.centerTextAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerTextAlignmentButton.Image = global::WindowsFormsApplication626.Properties.Resources.AlignTextCenter16;
            this.centerTextAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerTextAlignmentButton.Name = "centerTextAlignmentButton";
            this.centerTextAlignmentButton.Size = new System.Drawing.Size(33, 30);
            this.centerTextAlignmentButton.Text = "toolStripButton40";
            this.centerTextAlignmentButton.Click += new System.EventHandler(this.centerTextAlignmentButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo43 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo43.Header.Text = "Centre (ctrl + E)";
            toolTipInfo43.Body.Text = "Center Your Content on the Page";
            toolTipInfo43.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.centerTextAlignmentButton, toolTipInfo43);
            // 
            // rightTextAlignmentButton
            // 
            this.rightTextAlignmentButton.AutoSize = false;
            this.rightTextAlignmentButton.CheckOnClick = true;
            this.rightTextAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightTextAlignmentButton.Image = global::WindowsFormsApplication626.Properties.Resources.AlignTextRight16;
            this.rightTextAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightTextAlignmentButton.Name = "rightTextAlignmentButton";
            this.rightTextAlignmentButton.Size = new System.Drawing.Size(33, 30);
            this.rightTextAlignmentButton.Text = "toolStripButton41";
            this.rightTextAlignmentButton.Click += new System.EventHandler(this.rightTextAlignmentButton_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo44 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo44.Header.Text = "Align Right (ctrl + R)";
            toolTipInfo44.Body.Text = "Align your Content with the Right Margin";
            toolTipInfo44.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.rightTextAlignmentButton, toolTipInfo44);
            // 
            // justifyTextAlignmentButton
            // 
            this.justifyTextAlignmentButton.AutoSize = false;
            this.justifyTextAlignmentButton.CheckOnClick = true;
            this.justifyTextAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.justifyTextAlignmentButton.Image = global::WindowsFormsApplication626.Properties.Resources.AlignTextJustify16;
            this.justifyTextAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.justifyTextAlignmentButton.Name = "justifyTextAlignmentButton";
            this.justifyTextAlignmentButton.Size = new System.Drawing.Size(33, 30);
            this.justifyTextAlignmentButton.Text = "toolStripButton42";
            this.justifyTextAlignmentButton.Click += new System.EventHandler(this.justifyTextAlignmentButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo45 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo45.Header.Text = "Justify (ctrl + J)";
            toolTipInfo45.Body.Text = "Didtribute your Text Eventually between the Margin";
            toolTipInfo45.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.justifyTextAlignmentButton, toolTipInfo45);
            // 
            // linespacing
            // 
            this.linespacing.AutoSize = false;
            this.linespacing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linespacing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26});
            this.linespacing.Image = global::WindowsFormsApplication626.Properties.Resources.LineSpacing16;
            this.linespacing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linespacing.Name = "linespacing";
            this.linespacing.Size = new System.Drawing.Size(43, 30);
            this.linespacing.Text = "linespacing";
            this.linespacing.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.lineSpacingToolStripDropDown_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo46 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo46.Header.Text = "Line Spacing";
            toolTipInfo46.Body.Text = "Choose how much space appears between the Line of text";
            toolTipInfo46.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.linespacing, toolTipInfo46);

            
            this.none = new ToolStripMenuItem();
            this.none.Name = "noneMenuItem";
            this.none.Size = new System.Drawing.Size(104, 22);
            this.none.Text = "None";
            this.none.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_None;
            // 
            // bulletMenuItem
            // 
            this.bullet_dot = new ToolStripMenuItem();
            this.bullet_dot.Image = global::WindowsFormsApplication626.Properties.Resources.Bullet_Dot;
            this.bullet_dot.Name = "bulletMenuItem";
            this.bullet_dot.Size = new System.Drawing.Size(104, 22);
            this.bullet_dot.Text = "Bullet Dot";

            this.bullet_circle = new ToolStripMenuItem();
            this.bullet_circle.Image = global::WindowsFormsApplication626.Properties.Resources.Bullet_Circle;
            this.bullet_circle.Name = "bulletMenuItem";
            this.bullet_circle.Size = new System.Drawing.Size(104, 22);
            this.bullet_circle.Text = "Bullet CIrcle";

            this.bullet_square = new ToolStripMenuItem();
            this.bullet_square.Image = global::WindowsFormsApplication626.Properties.Resources.Bullet_Square;
            this.bullet_square.Name = "bulletMenuItem";
            this.bullet_square.Size = new System.Drawing.Size(104, 22);
            this.bullet_square.Text = "Bullet Square";

            this.bullet_flower = new ToolStripMenuItem();
            this.bullet_flower.Image = global::WindowsFormsApplication626.Properties.Resources.Bullet_Flower;
            this.bullet_flower.Name = "bulletMenuItem";
            this.bullet_flower.Size = new System.Drawing.Size(104, 22);
            this.bullet_flower.Text = "Bullet Flower";

            this.bullet_arrow = new ToolStripMenuItem();
            this.bullet_arrow.Image = global::WindowsFormsApplication626.Properties.Resources.Bullet_Arrow;
            this.bullet_arrow.Name = "bulletMenuItem";
            this.bullet_arrow.Size = new System.Drawing.Size(104, 22);
            this.bullet_arrow.Text = "Bullet Arrow";

            this.bullet_tick = new ToolStripMenuItem();
            this.bullet_tick.Image = global::WindowsFormsApplication626.Properties.Resources.Bullet_Tick;
            this.bullet_tick.Name = "bulletMenuItem";
            this.bullet_tick.Size = new System.Drawing.Size(104, 22);
            this.bullet_tick.Text = "Bullet Tick";
            

            this.library = new ToolStripMenuItem();
            this.library.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.library.Text = " Bullet Libary";
            this.library.Size = new System.Drawing.Size(104, 22);

            this.Bullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bullet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.library,
               this.none,
               this.bullet_dot,
               this.bullet_circle,
               this.bullet_square,
               this.bullet_flower,
               this.bullet_arrow,
               this.bullet_tick,
           });
            this.Bullet.Image = global::WindowsFormsApplication626.Properties.Resources.List_Bullets;
            this.Bullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bullet.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Bullet.Name = "bulletSplitButton";
            this.Bullet.Size = new System.Drawing.Size(35, 60);
            this.Bullet.Text = "Bullets";
            
            this.Bullet.DropDownItemClicked += Bullet_DropDownItemClicked;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo37 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo37.Header.Text = "Create Bullet List";
            toolTipInfo37.Body.Text = "Change the Color of your Text \n\nClick the Arrow to change the Look of the Bullet";
           
            toolTipInfo37.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.Bullet, toolTipInfo37);
            
            this.library1 = new ToolStripMenuItem();
            this.library1 = new ToolStripMenuItem();
            this.library1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.library1.Text = " Numbering Libary";
            this.library1.Size = new System.Drawing.Size(104, 22);

            this.num_none = new ToolStripMenuItem();
            this.num_none.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_None;
            this.num_none.Name = "bulletMenuItem";
            this.num_none.Size = new System.Drawing.Size(104, 22);
            this.num_none.Text = " None";


            this.num_lowlwtter_brace = new ToolStripMenuItem();
            this.num_lowlwtter_brace.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_LowLetter_Brace;
            this.num_lowlwtter_brace.Name = "bulletMenuItem";
            this.num_lowlwtter_brace.Size = new System.Drawing.Size(104, 22);
            this.num_lowlwtter_brace.Text = " Lowletter Brace";


            this.num__lowlwtter_dot = new ToolStripMenuItem();
            this.num__lowlwtter_dot.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_LowLetter_Dot;
            this.num__lowlwtter_dot.Name = "bulletMenuItem";
            this.num__lowlwtter_dot.Size = new System.Drawing.Size(104, 22);
            this.num__lowlwtter_dot.Text = " Lowletter Dot";


            this.num_number_brace = new ToolStripMenuItem();
            this.num_number_brace.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_Number_Brace;
            this.num_number_brace.Name = "bulletMenuItem";
            this.num_number_brace.Size = new System.Drawing.Size(104, 22);
            this.num_number_brace.Text = " Number Brace";


            this.num_number_dot = new ToolStripMenuItem();
            this.num_number_dot.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_Number_Dot;
            this.num_number_dot.Name = "bulletMenuItem";
            this.num_number_dot.Size = new System.Drawing.Size(104, 22);
            this.num_number_dot.Text = " Number Dot";


            this.num_upletter = new ToolStripMenuItem();
            this.num_upletter.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_UpLetter;
            this.num_upletter.Name = "bulletMenuItem";
            this.num_upletter.Size = new System.Drawing.Size(104, 22);
            this.num_upletter.Text = " Upletter";


            this.num_uproman = new ToolStripMenuItem();
            this.num_uproman.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_UpRoman;
            this.num_uproman.Name = "bulletMenuItem";
            this.num_uproman.Size = new System.Drawing.Size(104, 22);
            this.num_uproman.Text = " Up Roman";


            this.num_lowroman = new ToolStripMenuItem();
            this.num_lowroman.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_LowRoman;
            this.num_lowroman.Name = "bulletMenuItem";
            this.num_lowroman.Size = new System.Drawing.Size(104, 22);
            this.num_lowroman.Text = " Low Roman";

          
            this.Numbering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Numbering.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.library1,
                this.num_none,
                this.num_lowlwtter_brace,
                this.num__lowlwtter_dot,
                this.num_number_brace,
                this.num_number_dot,
                this.num_upletter,
                this.num_uproman,
                this.num_lowroman,
            });
            this.Numbering.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering16;
            this.Numbering.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Numbering.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Numbering.Name = "Numbering split Button";
            this.Numbering.Size = new System.Drawing.Size(40, 24);
            this.Numbering.Text = "Numbering";
            this.Numbering.DropDownItemClicked += Numbering_DropDownItemClicked;
            
            this.libary2 = new ToolStripMenuItem();
            this.libary2 = new ToolStripMenuItem();
            this.libary2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libary2.Text = " Multilevel List";
            this.libary2.Size = new System.Drawing.Size(104, 22);


            this.list_none = new ToolStripMenuItem();
            this.list_none.Image = global::WindowsFormsApplication626.Properties.Resources.Numbering_None;
            this.list_none.Name = "bulletMenuItem";
            this.list_none.Size = new System.Drawing.Size(104, 22);
            this.list_none.Text = " Number None";


            this.list_normal = new ToolStripMenuItem();
            this.list_normal.Image = global::WindowsFormsApplication626.Properties.Resources.List_Normal;
            this.list_normal.Name = "bulletMenuItem";
            this.list_normal.Size = new System.Drawing.Size(104, 22);
            this.list_normal.Text = "List Normal";


            this.list_multilevel = new ToolStripMenuItem();
            this.list_multilevel.Image = global::WindowsFormsApplication626.Properties.Resources.List_Multilevel;
            this.list_multilevel.Name = "bulletMenuItem";
            this.list_multilevel.Size = new System.Drawing.Size(104, 22);
            this.list_multilevel.Text = " List Multilevel";


            this.list_bullets = new ToolStripMenuItem();
            this.list_bullets.Image = global::WindowsFormsApplication626.Properties.Resources.List_Bullets;
            this.list_bullets.Name = "bulletMenuItem";
            this.list_bullets.Size = new System.Drawing.Size(104, 22);
            this.list_bullets.Text = " List Bullets";


            this.list_new = new ToolStripMenuItem();
            this.list_new.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_new.Name = "bulletMenuItem";
            this.list_new.Size = new System.Drawing.Size(104, 22);
            this.list_new.Text = "Define new Multilevel List";
            this.list_new.Click += List_new_Click;

            this.Multilist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Multilist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.libary2,
                this.list_none,
                this.list_normal,
                this.list_multilevel,
                this.list_bullets,
                this.list_new,
           });
            this.Multilist.Image = global::WindowsFormsApplication626.Properties.Resources.List_Multilevel;
            this.Multilist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Multilist.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Multilist.Name = "bulletSplitButton";
            this.Multilist.Size = new System.Drawing.Size(35, 24);
            this.Multilist.Text = "Multi List";
            this.Multilist.DropDownItemClicked += Multilist_DropDownItemClicked;
            

            //lefttoright
            this.lefttoright.AutoSize = false;
            this.lefttoright.CheckOnClick = true;
            this.lefttoright.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lefttoright.Image = global::WindowsFormsApplication626.Properties.Resources.LeftToRight16;
            this.lefttoright.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lefttoright.Name = "lefttoright";
            this.lefttoright.Size = new System.Drawing.Size(33, 30);
            this.lefttoright.Text = "Lefttoright";
            this.lefttoright.Checked = true;
            this.lefttoright.Click += Lefttoright_Click;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo48 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo48.Header.Text = "Left-to-right Text Direction";
            toolTipInfo48.Body.Text = "Set the Text to Read From Left to right";
            toolTipInfo48.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.lefttoright, toolTipInfo48);



            //righttoleft
            this.righttoleft.AutoSize = false;
            this.righttoleft.CheckOnClick = true;
            this.righttoleft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.righttoleft.Image = global::WindowsFormsApplication626.Properties.Resources.RightToLeft16;
            this.righttoleft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.righttoleft.Name = "righttoleft";
            this.righttoleft.Size = new System.Drawing.Size(33, 30);
            this.righttoleft.Text = "Righttoleft";
            this.righttoleft.Click += Righttoleft_Click;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo47 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo47.Header.Text = "Right-to-Left Text Direction";
            toolTipInfo47.Body.Text = "Set the Text to Read From Right to Left";
            toolTipInfo47.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.righttoleft, toolTipInfo47);

            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem21.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(112, 30);
            this.toolStripMenuItem21.Text = "1.0";
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem22.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(112, 30);
            this.toolStripMenuItem22.Text = "1.15";
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem23.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(112, 30);
            this.toolStripMenuItem23.Text = "1.5";
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem24.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(112, 30);
            this.toolStripMenuItem24.Text = "2.0";
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem25.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(112, 30);
            this.toolStripMenuItem25.Text = "2.5";
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem26.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(112, 30);
            this.toolStripMenuItem26.Text = "3.0";
            // 
            // toolStripEx9
            // 
            this.toolStripEx9.AutoSize = false;
            this.toolStripEx9.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx9.Image = null;
            this.toolStripEx9.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton14,
            this.toolStripPanelItem5,
            });
            this.toolStripEx9.Location = new System.Drawing.Point(687, 1);
            this.toolStripEx9.Name = "toolStripEx9";
            this.toolStripEx9.Office12Mode = false;
            this.toolStripEx9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx9.Size = new System.Drawing.Size(200, 132);
            this.toolStripEx9.TabIndex = 5;
            this.toolStripEx9.Text = "Editing";
            this.toolStripEx9.ShowLauncher = false;
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.Image = global::WindowsFormsApplication626.Properties.Resources.RestrictEditing;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(150, 101);
            this.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton14.ToolTipText = "Read only ";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo24 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo24.Header.Text = "Restrict Editing";
            toolTipInfo24.Body.Text = "Restrict the Content Editing and Formatting changes  ";
            toolTipInfo24.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton14, toolTipInfo24);


            // findToolStripButton
            // 
            this.findToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripButton.Image")));
            this.findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripButton.Name = "findToolStripButton";
            this.findToolStripButton.Size = new System.Drawing.Size(75, 30);
            this.findToolStripButton.Text = "Find";
            this.findToolStripButton.Click += new System.EventHandler(this.findToolStripButton_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo22 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo22.Header.Text = "Find (Ctrl+F)";
            toolTipInfo22.Body.Text = " Find the Text or other Content in the Document ";
            toolTipInfo22.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.findToolStripButton, toolTipInfo22);



            //replace
            // findToolStripButton
            // 

            this.replace.Image = global::WindowsFormsApplication626.Properties.Resources.Replace;
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(75, 30);
            this.replace.Text = "Replace";
            this.replace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.replace.Click += Replace_Click;


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo23 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo23.Header.Text = "Replace (ctrl+h)";
            toolTipInfo23.Body.Text = "Search for the text you'd like to change and Replace it with something else ";
            toolTipInfo23.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.replace, toolTipInfo23);

            // 
            // toolStripPanelItem5
            // 
            this.toolStripPanelItem5.AutoSize = false;
            this.toolStripPanelItem5.CausesValidation = false;
            this.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripButton,this.replace});
            this.toolStripPanelItem5.Name = "toolStripPanelItem5";
            this.toolStripPanelItem5.Size = new System.Drawing.Size(79, 104);
            this.toolStripPanelItem5.Text = "toolStripPanelItem5";
            this.toolStripPanelItem5.Transparent = true;
           
            // 


            //styles group
            this.styles.AutoSize = true;
            this.styles.Dock = System.Windows.Forms.DockStyle.None;
            this.styles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.styles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.styles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.styles.Image = null;
            this.styles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.styles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
           this.stylebutton});
            this.styles.Location = new System.Drawing.Point(687, 1);
            this.styles.Name = "toolStripEx9";
            this.styles.Office12Mode = false;
            this.styles.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.styles.Size = new System.Drawing.Size(200, 132);
            this.styles.TabIndex = 5;
            this.styles.Text = " ";

            //style button
            //this.findToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripButton.Image")));
            this.stylebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stylebutton.Name = "findToolStripButton";
            this.stylebutton.Size = new System.Drawing.Size(75, 30);
            this.stylebutton.Text = "Styles";
            this.stylebutton.Click += Stylebutton_Click;

            // 
            // toolStripEx10
            // 
            this.toolStripEx10.AutoSize = false;
            this.toolStripEx10.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx10.Image = null;
            this.toolStripEx10.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton28,
            this.toolStripButton30});
            this.toolStripEx10.Location = new System.Drawing.Point(1119, 1);
            this.toolStripEx10.Name = "toolStripEx10";
            this.toolStripEx10.Office12Mode = false;
            this.toolStripEx10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx10.Size = new System.Drawing.Size(199, 139);
            this.toolStripEx10.TabIndex = 6;
            this.toolStripEx10.Text = "Others";
            this.toolStripEx10.Visible = false;
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.AutoSize = false;
            this.toolStripButton28.Image = global::WindowsFormsApplication626.Properties.Resources.PrintArea;
            this.toolStripButton28.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton28.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.Size = new System.Drawing.Size(50, 108);
            this.toolStripButton28.Text = "Print";
            this.toolStripButton28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton30
            // 
            this.toolStripButton30.Image = global::WindowsFormsApplication626.Properties.Resources._0356_NewComment_32;
            this.toolStripButton30.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton30.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButton30.Name = "toolStripButton30";
            this.toolStripButton30.Size = new System.Drawing.Size(90, 131);
            this.toolStripButton30.Text = "Comment";
            this.toolStripButton30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEx11
            // 
            this.toolStripEx11.AutoSize = false;
            this.toolStripEx11.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx11.Image = null;
            this.toolStripEx11.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox5});
            this.toolStripEx11.Location = new System.Drawing.Point(1121, 1);
            this.toolStripEx11.Name = "toolStripEx11";
            this.toolStripEx11.Office12Mode = false;
            this.toolStripEx11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx11.Size = new System.Drawing.Size(213, 151);
            this.toolStripEx11.TabIndex = 7;
            this.toolStripEx11.Text = "ColorScheme";
            this.toolStripEx11.Visible = false;
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripComboBox5.Items.AddRange(new object[] {
            "White",
            "DarkGray",
            "LightGray"});
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(136, 146);
            this.toolStripComboBox5.Visible = false;
            // 
            // toolStripTabItem2
            // 
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripTabItem2.Panel.Controls.AddRange(new Control[] {this.pagebreak,this.toolStripEx12, this.toolStripEx4,this.link });
            
            this.toolStripTabItem2.Panel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 53, 0);
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 1;
            this.toolStripTabItem2.Panel.Text = "Insert";
            this.toolStripTabItem2.Position = 1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(83, 43);
            this.toolStripTabItem2.Text = "Insert";


            //breakbutton
            this.breakbutton.AutoSize = true;
            this.breakbutton.Image = global::WindowsFormsApplication626.Properties.Resources.PageBreak32;
            this.breakbutton.Text = "PageBreak";
            this.breakbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.breakbutton.Size = new System.Drawing.Size(87, 101);
            this.breakbutton.Click += Breakbutton_Click;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo18 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo18.Header.Text = "Insert a Page Break (ctrl+Return)";
            toolTipInfo18.Body.Text = " End the Current Page Here and Move to the Next page ";
            toolTipInfo18.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.breakbutton, toolTipInfo18);

            //pagebreak
            this.pagebreak.AutoSize = true;
            this.pagebreak.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pagebreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pagebreak.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pagebreak.Image = null;
            this.pagebreak.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pagebreak.Location = new System.Drawing.Point(0, 1);
            this.pagebreak.Name = "toolStripEx12";
            this.pagebreak.Office12Mode = false;
            this.pagebreak.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.pagebreak.Size = new System.Drawing.Size(15, 132);
            this.pagebreak.TabIndex = 2;
            this.pagebreak.Text = "Pages";
            this.pagebreak.Items.AddRange(new ToolStripItem[] { this.breakbutton });
            this.pagebreak.ShowLauncher = false;

            // 
            // toolStripEx12
            // 
            this.toolStripEx12.AutoSize = true;
            this.toolStripEx12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx12.Image = null;
            this.toolStripEx12.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx12.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx12.Name = "toolStripEx12";
            this.toolStripEx12.Office12Mode = false;
            this.toolStripEx12.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.toolStripEx12.Size = new System.Drawing.Size(15, 132);
            this.toolStripEx12.TabIndex = 2;
            this.toolStripEx12.Text = "Tables";
            this.toolStripEx12.Items.AddRange(new ToolStripItem[] { this.insertTableToolStripButton });
            this.toolStripEx12.ShowLauncher = false;
            // 
            // toolStripEx4
            // 
            this.toolStripEx4.AutoSize = true;
            this.toolStripEx4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx4.Image = null;
            this.toolStripEx4.ImageScalingSize = new System.Drawing.Size(50, 20);
            this.toolStripEx4.Location = new System.Drawing.Point(17, 1);
            this.toolStripEx4.Name = "toolStripEx4";
            this.toolStripEx4.Office12Mode = false;
            this.toolStripEx4.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.toolStripEx4.Size = new System.Drawing.Size(100, 50);
            this.toolStripEx4.TabIndex = 1;
            this.toolStripEx4.Text = "Ilustrations";
            this.toolStripEx4.Items.AddRange(new ToolStripItem[] { this.insertImageToolStripButton });
            this.toolStripEx4.ShowLauncher = false;

            //toolstripLinks

            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.link.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.link.Image = null;
            this.link.ImageScalingSize = new System.Drawing.Size(50, 20);
            this.link.Location = new System.Drawing.Point(17, 1);
            this.link.Name = "toolStripEx4";
            this.link.Office12Mode = true;
            this.link.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.link.Size = new System.Drawing.Size(15, 132);
            this.link.TabIndex = 1;
            this.link.Text = "Link";
            this.link.Items.AddRange(new ToolStripItem[] { this.linkb });
            this.link.ShowLauncher = false;
          



            //linkbutton name
            this.linkb.AutoSize = true;
             this.linkb.Image = global::WindowsFormsApplication626.Properties.Resources.Hyperlink32;
            this.linkb.Text = "HyperLink";
            this.linkb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.linkb.Size = new System.Drawing.Size(87, 101);
            this.linkb.Click += Linkb_Click;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo19 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo19.Header.Text = "Add a Hyperlink (ctrl + k)";
            toolTipInfo19.Body.Text = " create a link in your Document for QuickAccess to Webpages and Files ";
            toolTipInfo19.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.linkb, toolTipInfo19);

            // insertTableToolStripButton
            // 
            this.insertTableToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.Table32;
            this.insertTableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertTableToolStripButton.Name = "insertTableToolStripButton";
            this.insertTableToolStripButton.Size = new System.Drawing.Size(56, 17);
            this.insertTableToolStripButton.Text = "Table";
            this.insertTableToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.insertTableToolStripButton.Click += InsertTableToolStripButton_Click;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo20 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo20.Header.Text = "Add a Table";
            toolTipInfo20.Body.Text = " A table is a great way to organize information within your Documnet ";
            toolTipInfo20.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.insertTableToolStripButton, toolTipInfo20);

            // insertImageToolStripButton
            // 
            this.insertImageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("insertImageToolStripButton.Image")));
            this.insertImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertImageToolStripButton.Name = "insertImageToolStripButton";
            this.insertImageToolStripButton.Size = new System.Drawing.Size(69, 17);
            this.insertImageToolStripButton.Text = "Picture";
            this.insertImageToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.insertImageToolStripButton.Click += new System.EventHandler(this.insertImageToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo21 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo21.Header.Text = "From File";
            toolTipInfo21.Body.Text = " Insert a Picture From your Computer or From other Computer that You are Connected to ";
            toolTipInfo21.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.insertImageToolStripButton, toolTipInfo21);

            // 
            // toolStripTabItem3
            // 
            this.toolStripTabItem3.Name = "toolStripTabItem3";
            // 
            // ribbonControlAdv1.ribbonPanel3
            // 
            this.toolStripTabItem3.Panel.Controls.Add(this.toolStripEx8);
            this.toolStripTabItem3.Panel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.toolStripTabItem3.Panel.Name = "ribbonPanel3";
            this.toolStripTabItem3.Panel.Padding = new System.Windows.Forms.Padding(0, 1, 53, 0);
            this.toolStripTabItem3.Panel.ScrollPosition = 0;
            this.toolStripTabItem3.Panel.TabIndex = 2;
            this.toolStripTabItem3.Panel.Text = "Review";
            this.toolStripTabItem3.Position = 2;
            this.toolStripTabItem3.Size = new System.Drawing.Size(92, 43);
            this.toolStripTabItem3.Text = "Review";
            this.toolStripTabItem3.Panel.Controls.AddRange(new Control[] {  this.proofing , this.toolStripEx8});
            
            // 
            // toolStripEx8
            // 
            this.toolStripEx8.AutoSize = true;
            this.toolStripEx8.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx8.Image = null;
            this.toolStripEx8.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx8.Location = new System.Drawing.Point(1,20);
            this.toolStripEx8.Name = "toolStripEx8";
            this.toolStripEx8.Office12Mode = true;
            this.toolStripEx8.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripEx8.Size = new System.Drawing.Size(30, 10);
            this.toolStripEx8.TabIndex = 3;
            this.toolStripEx8.Text = "Comments";
            this.toolStripEx8.Items.AddRange(new ToolStripItem[] { this.toolStripButton26, this.deleteCommentToolStripButton, this.previousCommentToolStripButton , this.nextCommentToolStripButton , this.showCommentToolStripButton });
            this.toolStripEx8.ShowLauncher = false;
            // toolStripButton26
            // 
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.Size = new System.Drawing.Size(135, 61);
            this.toolStripButton26.Text = "New Comment";
            this.toolStripButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton26.Click += new System.EventHandler(this.toolStripButton26_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo113 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo113.Header.Text = "Insert a Comment";
            toolTipInfo113.Body.Text = " Add a Note about this part of the Document";
            toolTipInfo113.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton26, toolTipInfo113);

            // 
            // deleteCommentToolStripButton
            // 
            this.deleteCommentToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.DeleteComment;
            this.deleteCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteCommentToolStripButton.Name = "deleteCommentToolStripButton";
            this.deleteCommentToolStripButton.Size = new System.Drawing.Size(66, 53);
            this.deleteCommentToolStripButton.Text = "Delete";
            this.deleteCommentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteCommentToolStripButton.Click += new System.EventHandler(this.deleteCommentToolStripButton_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo114 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo114.Header.Text = "Delete Comment";
            toolTipInfo114.Body.Text = " Delete the Selected Comment";
            toolTipInfo114.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.deleteCommentToolStripButton, toolTipInfo114);
            // 
            // previousCommentToolStripButton
            // 
            this.previousCommentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("previousCommentToolStripButton.Image")));
            this.previousCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previousCommentToolStripButton.Name = "previousCommentToolStripButton";
            this.previousCommentToolStripButton.Size = new System.Drawing.Size(83, 53);
            this.previousCommentToolStripButton.Text = "Previous";
            this.previousCommentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.previousCommentToolStripButton.Click += new System.EventHandler(this.previousCommentToolStripButton_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo115 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo115.Header.Text = "previous Comment";
            toolTipInfo115.Body.Text = " Jump to the Previous Comment";
            toolTipInfo115.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.previousCommentToolStripButton, toolTipInfo115);
            // 
            // nextCommentToolStripButton
            // 
            this.nextCommentToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.NextComment;
            this.nextCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextCommentToolStripButton.Name = "nextCommentToolStripButton";
            this.nextCommentToolStripButton.Size = new System.Drawing.Size(52, 53);
            this.nextCommentToolStripButton.Text = "Next";
            this.nextCommentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nextCommentToolStripButton.Click += new System.EventHandler(this.nextCommentToolStripButton_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo16 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo16.Header.Text = "Next Comment";
            toolTipInfo16.Body.Text = " Jump to the Next Comment";
            toolTipInfo16.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.nextCommentToolStripButton, toolTipInfo16);
            // 
            // showCommentToolStripButton
            // 
            this.showCommentToolStripButton.Image = global::WindowsFormsApplication626.Properties.Resources.ShowComments;
            this.showCommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showCommentToolStripButton.Name = "showCommentToolStripButton";
            this.showCommentToolStripButton.Size = new System.Drawing.Size(152, 53);
            this.showCommentToolStripButton.Text = "Show Comments";
            this.showCommentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showCommentToolStripButton.Click += new System.EventHandler(this.showCommentToolStripButton_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo17 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo17.Header.Text = "Show Comment";
            toolTipInfo17.Body.Text = " See all the Documents alongside the Documnet";
            toolTipInfo17.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.showCommentToolStripButton, toolTipInfo17);
            //proofing 
            this.proofing.AutoSize = true;
            this.proofing.Dock = System.Windows.Forms.DockStyle.None;
            this.proofing.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.proofing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.proofing.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.proofing.Image = null;
            this.proofing.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.proofing.Location = new System.Drawing.Point(1, 100);
            this.proofing.Name = "toolStripEx8";
            this.proofing.Office12Mode = false;
            this.proofing.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.proofing.Size = new System.Drawing.Size(30, 10);
            this.proofing.TabIndex = 3;
            this.proofing.Text = "Proofing";
            this.proofing.Items.AddRange(new ToolStripItem[] { this.spelling });
            this.proofing.ShowLauncher = false;

            //speeling Button
            this.spelling.AutoSize = true;
            this.spelling.Image = global::WindowsFormsApplication626.Properties.Resources.spelling_32;
            this.spelling.Text = "Spelling";
            this.spelling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.spelling.Click += Spelling_Click;

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo12 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo12.Header.Text = "Spelling (f7)";
            toolTipInfo12.Body.Text = "Typos ? Not on our Watch . Let us check your Spelling";
            toolTipInfo12.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.spelling, toolTipInfo12);

            // 
            // toolStripTabItem4
            // 
            this.toolStripTabItem4.Name = "toolStripTabItem4";
            // 
            // ribbonControlAdv1.ribbonPanel4
            // 
            this.toolStripTabItem4.Panel.Controls.Add(this.toolStripEx14);
            this.toolStripTabItem4.Panel.Controls.Add(this.toolStripEx13);
            this.toolStripTabItem4.Panel.Name = "ribbonPanel4";
            this.toolStripTabItem4.Panel.ScrollPosition = 0;
            this.toolStripTabItem4.Panel.TabIndex = 3;
            this.toolStripTabItem4.Panel.Text = "View";
            this.toolStripTabItem4.Position = 3;
            this.toolStripTabItem4.Size = new System.Drawing.Size(76, 43);
            this.toolStripTabItem4.Tag = "4";
            this.toolStripTabItem4.Text = "View";
            this.toolStripTabItem4.Panel.Controls.AddRange(new Control[] { this.toolStripEx14, this.toolStripEx13 });
            // 
            // toolStripEx14
            // 
            this.toolStripEx14.AutoSize = true;
            this.toolStripEx14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx14.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx14.Image = null;
            this.toolStripEx14.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx14.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx14.Name = "toolStripEx14";
            this.toolStripEx14.Office12Mode = false;
            this.toolStripEx14.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx14.Size = new System.Drawing.Size(15, 0);
            this.toolStripEx14.TabIndex = 1;
            this.toolStripEx14.Text = "Views";
            this.toolStripEx14.Items.AddRange(new ToolStripItem[] { this.toolStripButton31, this.toolStripButton32 });
            this.toolStripEx14.ShowLauncher = false;

            // 
            // toolStripButton31
            // 
            this.toolStripButton31.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton31.Image")));
            this.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.Size = new System.Drawing.Size(110, 53);
            this.toolStripButton31.Text = "Print Layout";
            this.toolStripButton31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton31.Click += new System.EventHandler(this.toolStripButton31_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo11 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo11.Header.Text = "Print Layout";
            toolTipInfo11.Body.Text = "Check out how your Document look when it's Printed";
            toolTipInfo11.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton31, toolTipInfo11);
            // 
            // toolStripButton32
            // 
            this.toolStripButton32.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton32.Image")));
            this.toolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton32.Name = "toolStripButton32";
            this.toolStripButton32.Size = new System.Drawing.Size(110, 53);
            this.toolStripButton32.Text = "Web Layout";
            this.toolStripButton32.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton32.Click += new System.EventHandler(this.toolStripButton32_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo10 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo10.Header.Text = "Web Layout";
            toolTipInfo10.Body.Text = "See How your Document would look as webpage. This Layout is also great if you have Wide table in your Document";
            toolTipInfo10.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton32, toolTipInfo10);
            // 
            // 
            // toolStripEx13
            // 
            this.toolStripEx13.AutoSize = true;
            this.toolStripEx13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx13.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx13.Image = null;
            this.toolStripEx13.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx13.Location = new System.Drawing.Point(17, 1);
            this.toolStripEx13.Name = "toolStripEx13";
            this.toolStripEx13.Office12Mode = false;
            this.toolStripEx13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripEx13.Size = new System.Drawing.Size(15, 0);
            this.toolStripEx13.TabIndex = 0;
            this.toolStripEx13.Text = "Zoom";
            this.toolStripEx13.Items.AddRange(new ToolStripItem[] { this.toolStripButton33 , this.toolStripButton34 , this.toolStripButton35 , toolStripPanelItem7 });
            this.toolStripEx13.ShowLauncher = false;

            // toolStripButton33
            // 
            this.toolStripButton33.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton33.Image")));
            this.toolStripButton33.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton33.Name = "toolStripButton33";
            this.toolStripButton33.Size = new System.Drawing.Size(84, 53);
            this.toolStripButton33.Text = "Zoom In";
            this.toolStripButton33.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton33.Click += new System.EventHandler(this.toolStripButton33_Click);
            

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo9 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo9.Header.Text = "Zoom in";
            toolTipInfo9.Body.Text = "Increase the Zoom Level";
            toolTipInfo9.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton33, toolTipInfo9);
            // 
            // toolStripButton34
            // 
            this.toolStripButton34.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton34.Image")));
            this.toolStripButton34.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton34.Name = "toolStripButton34";
            this.toolStripButton34.Size = new System.Drawing.Size(99, 53);
            this.toolStripButton34.Text = "Zoom Out";
            this.toolStripButton34.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton34.Click += new System.EventHandler(this.toolStripButton34_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo8 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo8.Header.Text = "Zoom out";
            toolTipInfo8.Body.Text = "Decrease the Zoom Level";
            toolTipInfo8.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton34, toolTipInfo8);

            // 
            // toolStripButton35
            // 
            this.toolStripButton35.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton35.Image")));
            this.toolStripButton35.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton35.Name = "toolStripButton35";
            this.toolStripButton35.Size = new System.Drawing.Size(61, 53);
            this.toolStripButton35.Text = "100%";
            this.toolStripButton35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton35.Click += new System.EventHandler(this.toolStripButton35_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo7 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo7.Header.Text = "100%";
            toolTipInfo7.Body.Text = "Zoom your Document to 100%";
            toolTipInfo7.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton35, toolTipInfo7);




            // 
            // toolStripPanelItem7
            // 
            this.toolStripPanelItem7.CausesValidation = false;
            this.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton36,
            this.toolStripButton37,
            this.toolStripButton38});
            this.toolStripPanelItem7.Name = "toolStripPanelItem7";
            this.toolStripPanelItem7.Size = new System.Drawing.Size(152, 103);
            this.toolStripPanelItem7.Text = "toolStripPanelItem7";
            this.toolStripPanelItem7.Transparent = true;
            // 
            // toolStripButton36
            // 
            this.toolStripButton36.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton36.Image")));
            this.toolStripButton36.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton36.Name = "toolStripButton36";
            this.toolStripButton36.Size = new System.Drawing.Size(111, 29);
            this.toolStripButton36.Text = "OnePage";
            this.toolStripButton36.Click += new System.EventHandler(this.toolStripButton36_Click);


            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo4.Header.Text = "One page";
            toolTipInfo4.Body.Text = "Zoom the Document so that you can see the entire page in Winodw ";
            toolTipInfo4.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton36, toolTipInfo4);
            // 
            // toolStripButton37
            // 
            this.toolStripButton37.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton37.Image")));
            this.toolStripButton37.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton37.Name = "toolStripButton37";
            this.toolStripButton37.Size = new System.Drawing.Size(147, 29);
            this.toolStripButton37.Text = "Multiple Page";
            this.toolStripButton37.Click += new System.EventHandler(this.toolStripButton37_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo5 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo5.Header.Text = "Multi pages";
            toolTipInfo5.Body.Text = "Zoom the Document so that you can see the entire  Multiple pages in Winodw ";
            toolTipInfo5.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton37, toolTipInfo5);
            // 
            // toolStripButton38
            // 
            this.toolStripButton38.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton38.Image")));
            this.toolStripButton38.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton38.Name = "toolStripButton38";
            this.toolStripButton38.Size = new System.Drawing.Size(131, 29);
            this.toolStripButton38.Text = "Page Width";
            this.toolStripButton38.Click += new System.EventHandler(this.toolStripButton38_Click);

            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo6 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            toolTipInfo6.Header.Text = "Page Width";
            toolTipInfo6.Body.Text = "Zoom the Document so that the Width of the page Matches the Width of the Window ";
            toolTipInfo6.BackColor = System.Drawing.SystemColors.Window;
            this.t1.SetToolTip(this.toolStripButton38, toolTipInfo6);

            // 



            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "Colorful",
            "DarkGray",
            "Black",
            "White"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(160, 33);
            this.toolStripComboBox3.Visible = false;
            // 
            // backStage5
            // 
            this.backStage5.AllowDrop = true;
            this.backStage5.BackStagePanelWidth = 190;
            this.backStage5.BeforeTouchSize = new System.Drawing.Size(450, 461);
            this.backStage5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage5.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage5.ItemSize = new System.Drawing.Size(60, 40);
            this.backStage5.Location = new System.Drawing.Point(0, 0);
            this.backStage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backStage5.Name = "backStage5";
            this.backStage5.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.backStage5.Size = new System.Drawing.Size(450, 461);
            this.backStage5.TabIndex = 0;
            this.backStage5.ThemeName = "BackStageRenderer";
            this.backStage5.Visible = false;
            // 
            // backStage4
            // 
            this.backStage4.AllowDrop = true;
            this.backStage4.BackStagePanelWidth = 190;
            this.backStage4.BeforeTouchSize = new System.Drawing.Size(450, 461);
            this.backStage4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage4.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage4.ItemSize = new System.Drawing.Size(60, 40);
            this.backStage4.Location = new System.Drawing.Point(0, 0);
            this.backStage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backStage4.Name = "backStage4";
            this.backStage4.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.backStage4.Size = new System.Drawing.Size(450, 461);
            this.backStage4.TabIndex = 0;
            this.backStage4.ThemeName = "BackStageRenderer";
            this.backStage4.Visible = false;
            // 
            // backStage3
            // 
            this.backStage3.AllowDrop = true;
            this.backStage3.BackStagePanelWidth = 190;
            this.backStage3.BeforeTouchSize = new System.Drawing.Size(450, 461);
            this.backStage3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage3.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage3.ItemSize = new System.Drawing.Size(60, 40);
            this.backStage3.Location = new System.Drawing.Point(0, 0);
            this.backStage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backStage3.Name = "backStage3";
            this.backStage3.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.backStage3.Size = new System.Drawing.Size(450, 461);
            this.backStage3.TabIndex = 0;
            this.backStage3.ThemeName = "BackStageRenderer";
            this.backStage3.Visible = false;
            // 
            // backStage2
            // 
            this.backStage2.AllowDrop = true;
            this.backStage2.BackStagePanelWidth = 190;
            this.backStage2.BeforeTouchSize = new System.Drawing.Size(450, 461);
            this.backStage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage2.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage2.ItemSize = new System.Drawing.Size(60, 40);
            this.backStage2.Location = new System.Drawing.Point(0, 0);
            this.backStage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backStage2.Name = "backStage2";
            this.backStage2.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.backStage2.Size = new System.Drawing.Size(450, 461);
            this.backStage2.TabIndex = 0;
            this.backStage2.ThemeName = "BackStageRenderer";
            this.backStage2.Visible = false;
            // 
            // toolStripEx6
            // 
            this.toolStripEx6.AutoSize = false;
            this.toolStripEx6.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx6.Image = null;
            this.toolStripEx6.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEx6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton22});
            this.toolStripEx6.Location = new System.Drawing.Point(212, 1);
            this.toolStripEx6.Name = "toolStripEx6";
            this.toolStripEx6.Office12Mode = false;
            this.toolStripEx6.Size = new System.Drawing.Size(71, 92);
            this.toolStripEx6.TabIndex = 1;
            this.toolStripEx6.Text = "Illustrations";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.Image = global::WindowsFormsApplication626.Properties.Resources.Picture32;
            this.toolStripButton22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.Size = new System.Drawing.Size(71, 61);
            this.toolStripButton22.Text = "Editing";
            this.toolStripButton22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 229);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1619, 712);
            this.panel7.TabIndex = 3;
            // 
            // flowLayout5
            // 
            this.flowLayout5.TopMargin = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Borders = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ClientSize = new System.Drawing.Size(1621, 942);
            this.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver;
            this.Controls.Add(this.Info);
            this.Controls.Add(this.backStage5);
            this.Controls.Add(this.backStage4);
            this.Controls.Add(this.backStage3);
            this.Controls.Add(this.backStage2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.ribbonControlAdv1);
            this.HelpButtonImage = ((System.Drawing.Image)(resources.GetObject("$this.HelpButtonImage")));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1201, 942);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.Text = "Ribbon Style Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            this.Info.ResumeLayout(false);
            this.backStageTab1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.backStageTab2.ResumeLayout(false);
            this.splitContainerAdv2.Panel1.ResumeLayout(false);
            this.splitContainerAdv2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).EndInit();
            this.splitContainerAdv2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.backStageTab3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem1.Panel.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx5.ResumeLayout(false);
            this.toolStripEx5.PerformLayout();
            this.toolStripEx9.ResumeLayout(false);
            this.toolStripEx9.PerformLayout();
            this.toolStripEx10.ResumeLayout(false);
            this.toolStripEx10.PerformLayout();
            this.toolStripEx11.ResumeLayout(false);
            this.toolStripEx11.PerformLayout();
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.toolStripTabItem3.Panel.ResumeLayout(false);
            this.toolStripTabItem4.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backStage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backStage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backStage2)).EndInit();
            this.toolStripEx6.ResumeLayout(false);
            this.toolStripEx6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout5)).EndInit();
            this.ResumeLayout(false);

        }

        private void Multilist_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == list_none)
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(null);
            else if (e.ClickedItem == list_normal)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_List_Normal"]);
            }
            else if (e.ClickedItem == list_multilevel)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_List_Multilevel"]);
            }
            else if (e.ClickedItem == list_bullets)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_List_Bullet"]);
            }
        }

        private void Numbering_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == num_none)
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(null);
            else if (e.ClickedItem == num_lowlwtter_brace)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Numbering_LowLetter_Brace"]);
            }
            else if (e.ClickedItem == num_number_dot)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Numbering_LowLetter_Dot"]);
            }
            else if (e.ClickedItem == num_number_brace)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Numbering_Number_Brace"]);
            }
            else if (e.ClickedItem == num_number_dot)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Numbering_Number_Dot"]);
            }
            else if (e.ClickedItem == num_uproman)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Numbering_UpRoman"]);
            }
            else if (e.ClickedItem == num_lowroman)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Numbering_LowRoman"]);
            }
        }

        private void Bullet_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == none)
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(null);
            else if(e.ClickedItem == bullet_dot)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Bullet_Dot"]);
            }
            else if (e.ClickedItem == bullet_circle)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Bullet_Circle"]);
            }
            else if (e.ClickedItem == bullet_arrow)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Bullet_Arrow"]);
            }
            else if (e.ClickedItem == bullet_flower)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Bullet_Flower"]);
            }
            else if (e.ClickedItem == bullet_square)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Bullet_Square"]);
            }
            else if (e.ClickedItem == bullet_tick)
            {
                this.sfRichTextBoxAdv.Selection.ParagraphFormat.SetList(lists["_Bullet_Tick"]);
            }


        }
        
        private void Lefttoright_Click(object sender, EventArgs e)
        {
            if (lefttoright.Checked)
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.Bidi = false;
                righttoleft.Checked = false;
            }
            else
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.Bidi = true;
                righttoleft.Checked = true;
            }
        }

        private void Righttoleft_Click(object sender, EventArgs e)
        {
            if (righttoleft.Checked)
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.Bidi = true;
                lefttoright.Checked = false;
            }
            else
            {
                this.RichTextBoxAdv.Selection.ParagraphFormat.Bidi = false;
                lefttoright.Checked = true;
            }
        }

        private void List_new_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowListDialogCommand.Execute(null, RichTextBoxAdv);
        }

        private void ButtonAdv1_Click(object sender, EventArgs e)
        {
           
        }

        private void Breakbutton_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.InsertBreakCommand.Execute("PageBreak", RichTextBoxAdv);
        }
        
        private void Spelling_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowSpellingPaneCommand.Execute(null, RichTextBoxAdv);
        }

       
      

        private void Toolstripitem2_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowEncryptDocumentDialogCommand.Execute(null, RichTextBoxAdv);
        }

        private void Toolstripitem1_Click(object sender, EventArgs e)
        {
            this.toolStripButton14.Checked = !this.toolStripButton14.Checked;
            if (this.toolStripButton14.Checked)
                this.RichTextBoxAdv.IsReadOnly = true;
            else
                this.RichTextBoxAdv.IsReadOnly = false;
        }

        private void ButtonAdv4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://help.syncfusion.com/wpf/richtextbox/getting-started");

        }

        private void ButtonAdv3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://help.syncfusion.com/wpf/welcome-to-syncfusion-essential-wpf");

        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.backStageView1.IsVisible = false;
            SfRichTextBoxAdv.NewDocumentCommand.Execute(null, RichTextBoxAdv);

           
        }

            private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Linkb_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowHyperlinkDialogCommand.Execute(null, RichTextBoxAdv);
        }

       




      

        private void Replace_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowFindAndReplaceDialogCommand.Execute(null, RichTextBoxAdv);
        }

        private void InsertTableToolStripButton_Click(object sender, EventArgs e)
        {
           
            SfRichTextBoxAdv.ShowInsertTableDialogCommand.Execute(null, RichTextBoxAdv);
                }
        private void Stylebutton_Click(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowStylesDialogCommand.Execute(null, RichTextBoxAdv);
                }

        private void ToolStripEx5_LauncherClick(object sender, EventArgs e)
        {
            SfRichTextBoxAdv.ShowParagraphDialogCommand.Execute(null, RichTextBoxAdv);
            
        }

        private void ToolStripEx2_LauncherClick(object sender, EventArgs e)
        {
           
            SfRichTextBoxAdv.ShowFontDialogCommand.Execute(null, RichTextBoxAdv);
        }

        private void ToolStripEx1_LauncherClick(object sender, EventArgs e)
        {
           
        }

        public void DrawText(PaintEventArgs e, string text, Font font, Color color, int totalwidth, int totalheight, int splitwidth)
        {
            throw new NotImplementedException();
        }

        public void DrawBorder(PaintEventArgs e, int width, int height, int splitwidth, Color outerColor, Color innerColor, Color arrowOuter, Color arrowInner, Color buttonInner)
        {
            throw new NotImplementedException();
        }

        public void DrawArrow(int left, int top, int width, int height, PaintEventArgs e, Color ArrowColor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the list
        /// </summary>
        /// <param name="listName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        internal ListAdv CreateList(string listName)
        {
            AbstractListAdv abstractListAdv = new AbstractListAdv(null);
            ListAdv list = new ListAdv(null);
            list.AbstractList = abstractListAdv;
            if (listName.StartsWith("_List"))
                AddListLevels(abstractListAdv, listName);
            else
            {
                ListLevelAdv listLevel = new ListLevelAdv(abstractListAdv);
                abstractListAdv.Levels.Add(listLevel);
                if (listName.StartsWith("_Bullet"))
                {
                    listLevel.ListLevelPattern = ListLevelPattern.Bullet;
                    switch (listName.Substring(8))
                    {
                        case "Dot":
                            listLevel.NumberFormat = "\uf0b7";
                            listLevel.CharacterFormat.FontFamily = new System.Windows.Media.FontFamily("Symbol");
                            break;
                        case "Square":
                            listLevel.NumberFormat = "\uf0a7";
                            listLevel.CharacterFormat.FontFamily = new System.Windows.Media.FontFamily("Wingdings");
                            break;
                        case "Circle":
                            listLevel.NumberFormat = "\uf06f" + "\u0020";
                            listLevel.CharacterFormat.FontFamily = new System.Windows.Media.FontFamily("Symbol");
                            break;
                        case "Flower":
                            listLevel.NumberFormat = "\uf076";
                            listLevel.CharacterFormat.FontFamily = new System.Windows.Media.FontFamily("Wingdings");
                            break;
                        case "Arrow":
                            listLevel.NumberFormat = "\uf0d8";
                            listLevel.CharacterFormat.FontFamily = new System.Windows.Media.FontFamily("Wingdings");
                            break;
                        case "Tick":
                            listLevel.NumberFormat = "\uf0fc";
                            listLevel.CharacterFormat.FontFamily = new System.Windows.Media.FontFamily("Wingdings");
                            break;
                    }
                }
                else
                {
                    if (listName.Contains("UpRoman"))
                        listLevel.ListLevelPattern = ListLevelPattern.UpRoman;
                    else if (listName.Contains("LowRoman"))
                        listLevel.ListLevelPattern = ListLevelPattern.LowRoman;
                    else if (listName.Contains("UpLetter"))
                        listLevel.ListLevelPattern = ListLevelPattern.UpLetter;
                    else if (listName.Contains("LowLetter"))
                        listLevel.ListLevelPattern = ListLevelPattern.LowLetter;
                    else if (listName.Contains("Number"))
                        listLevel.ListLevelPattern = ListLevelPattern.Arabic;
                    if (listName.EndsWith("Brace"))
                        listLevel.NumberFormat = "%1)";
                    else
                        listLevel.NumberFormat = "%1.";
                    listLevel.StartAt = 1;
                }
                listLevel.ParagraphFormat.LeftIndent = 48;
                listLevel.ParagraphFormat.FirstLineIndent = -24;
            }
            return list;
        }
        /// <summary>
        /// Adds the list levels
        /// </summary>
        /// <param name="abstractListAdv"></param>
        /// <param name="listName"></param>
        /// <remarks></remarks>
        internal void AddListLevels(AbstractListAdv abstractListAdv, string listName)
        {
            List<string> bulletCharacters = new List<string>() { "\uf076", "\uf0d8", "\uf0a7", "\uf0b7", "\uf0a8" };
            for (int i = abstractListAdv.Levels.Count; i < 9; i++)
            {
                ListLevelAdv listLevel = new ListLevelAdv(abstractListAdv);
                if (listName.Contains("Bullet"))
                {
                    listLevel.ListLevelPattern = ListLevelPattern.Bullet;
                    listLevel.NumberFormat = bulletCharacters[i < 5 ? i % 5 : i % 5 + 1];
                    listLevel.CharacterFormat.FontFamily = i < 3 || i == 5 ? new System.Windows.Media.FontFamily("Wingdings") : new System.Windows.Media.FontFamily("Symbol");
                }
                else
                {
                    if (listName.Contains("Multilevel"))
                    {
                        for (int j = 0; j < i + 1; j++)
                            listLevel.NumberFormat += "%" + (j + 1).ToString() + ".";
                        listLevel.ListLevelPattern = ListLevelPattern.Arabic;
                    }
                    else
                    {
                        listLevel.NumberFormat = "%" + (i + 1).ToString() + ")";
                        listLevel.ListLevelPattern = i % 3 == 0 ? ListLevelPattern.Arabic
                       : i % 3 == 1 ? ListLevelPattern.LowLetter : ListLevelPattern.LowRoman;
                    }
                    listLevel.StartAt = 1;
                    listLevel.RestartLevel = i;
                }
                listLevel.ParagraphFormat.LeftIndent = 48 * i;
                listLevel.ParagraphFormat.FirstLineIndent = -24;
                abstractListAdv.Levels.Add(listLevel);
            }
        }
        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStage Info;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem3;
        private System.Windows.Forms.ToolStripComboBox fontFamilyToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox fontSizeToolStripComboBox;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem4;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.ToolStripButton strikethroughToolStripButton;
        private System.Windows.Forms.ToolStripButton subscriptToolStripButton;
        private System.Windows.Forms.ToolStripButton superscriptToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx hightlightColorToolStripSplitButtonEx;
        private ToolStripSplitButton fontColorToolStripSplitButtonEx;
        private System.Windows.Forms.ToolStripButton increaseFontSizeToolStripButton;
        private System.Windows.Forms.ToolStripButton decreaseFontSizeToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx8;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx6;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.Panel panel7;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout5;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx5;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx9;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx10;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.ToolStripButton toolStripButton30;
        private Syncfusion.Windows.Forms.BackStage backStage2;
        private Syncfusion.Windows.Forms.BackStage backStage3;
        private Syncfusion.Windows.Forms.BackStage backStage4;
        private Syncfusion.Windows.Forms.BackStage backStage5;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx11;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox5;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem5;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx12;
        private System.Windows.Forms.ToolStripDropDownButton insertTableToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx4;
        private System.Windows.Forms.ToolStripButton insertImageToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteCommentToolStripButton;
        private System.Windows.Forms.ToolStripButton previousCommentToolStripButton;
        private System.Windows.Forms.ToolStripButton nextCommentToolStripButton;
        private System.Windows.Forms.ToolStripButton showCommentToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem4;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx14;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx13;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private System.Windows.Forms.ToolStripButton toolStripButton32;
        private System.Windows.Forms.ToolStripButton toolStripButton33;
        private System.Windows.Forms.ToolStripButton toolStripButton34;
        private System.Windows.Forms.ToolStripButton toolStripButton35;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem7;
        private System.Windows.Forms.ToolStripButton toolStripButton36;
        private System.Windows.Forms.ToolStripButton toolStripButton37;
        private System.Windows.Forms.ToolStripButton toolStripButton38;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem6;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem8;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem9;
        private Syncfusion.Windows.Forms.BackStageTab backStageTab1;
        private Syncfusion.Windows.Forms.BackStageTab backStageTab2;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton1;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton2;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton3;
        private Syncfusion.Windows.Forms.BackStageButton backStageButton4;
        private Syncfusion.Windows.Forms.BackStageTab backStageTab3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton1;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem1;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem2;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel14;
        private Syncfusion.Windows.Forms.ButtonAdv create;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private SplitContainerAdv splitContainerAdv2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.ToolStripButton leftindent;
        private System.Windows.Forms.ToolStripButton rightindent;
        private System.Windows.Forms.ToolStripButton leftTextAlignmentButton;
        private System.Windows.Forms.ToolStripButton centerTextAlignmentButton;
        private System.Windows.Forms.ToolStripButton rightTextAlignmentButton;
        private System.Windows.Forms.ToolStripButton justifyTextAlignmentButton;
        private System.Windows.Forms.ToolStripDropDownButton linespacing;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem YellowHighlightButton;
        private System.Windows.Forms.ToolStripMenuItem BrightGreenHightlightButton;
        private System.Windows.Forms.ToolStripMenuItem TurquoiseHightlightButton;
        private System.Windows.Forms.ToolStripMenuItem PinkHighlightButton;
        private System.Windows.Forms.ToolStripMenuItem BlueHighlightButton;
        private System.Windows.Forms.ToolStripMenuItem RedHighlightButton;
        private System.Windows.Forms.ToolStripMenuItem DarkBlueHighlightButton;
        private System.Windows.Forms.ToolStripMenuItem TealHightlightButton;
        private System.Windows.Forms.ToolStripMenuItem GreenHighlightButton;
        private System.Windows.Forms.ToolStripMenuItem VioletHighlightButton;
        private ToolStripMenuItem toolStripMenuItem21;
        private ToolStripMenuItem toolStripMenuItem22;

        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem panel;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx link;
        private System.Windows.Forms.ToolStripButton linkb;
        private System.Windows.Forms.ToolStripButton picture;
        private System.Windows.Forms.ToolStripDropDownButton table;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx proofing;
        private System.Windows.Forms.ToolStripButton spelling;
    
        private Syncfusion.Windows.Forms.Tools.ToolStripEx pagebreak;
        private System.Windows.Forms.ToolStripButton breakbutton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx styles;
        private System.Windows.Forms.ToolStripDropDownButton stylebutton;
        private System.Windows.Forms.ToolStripSplitButton Bullet;
        private System.Windows.Forms.ToolStripDropDownButton numbering;
        private System.Windows.Forms.ToolStripDropDownButton multilist;
        private System.Windows.Forms.ToolStripButton righttoleft;
        private System.Windows.Forms.ToolStripButton lefttoright;
        private System.Windows.Forms.ToolStripButton replace;

        private System.Windows.Forms.ToolStripMenuItem image;
        private System.Windows.Forms.Label createLabel;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip t1;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip t2;
        private  System.Windows.Forms.Label labelcreate;
        private System.Windows.Forms.Panel panelcreate;

        private System.Windows.Forms.Label labelcreate1;
        private System.Windows.Forms.Panel panelcreate1;
        private System.Windows.Forms.Label labelcreate2;
        private System.Windows.Forms.Panel panelcreate2;
        private System.Windows.Forms.Label labelcreate3;
        private System.Windows.Forms.Panel panelcreate3;
        private System.Windows.Forms.Label labelcreate4;
        private System.Windows.Forms.Panel panelcreate4;
        private System.Windows.Forms.Label labelcreate5;
        private System.Windows.Forms.Panel panelcreate5;

       

        private ToolStripMenuItem bullet_dot;
        private ToolStripMenuItem bullet_circle;
        private ToolStripMenuItem bullet_square;
        private ToolStripMenuItem bullet_flower;
        private ToolStripMenuItem bullet_arrow;
        private ToolStripMenuItem bullet_tick;
        private ToolStripMenuItem none;
        private ToolStripMenuItem library;

        private ToolStripMenuItem num_none;
        private ToolStripMenuItem num_lowlwtter_brace;
        private ToolStripMenuItem num__lowlwtter_dot;
        private ToolStripMenuItem num_number_brace;
        private ToolStripMenuItem num_number_dot;
        private ToolStripMenuItem num_upletter;
        private ToolStripMenuItem num_uproman;
        private ToolStripMenuItem num_lowroman;
        private ToolStripMenuItem library1;
        private System.Windows.Forms.ToolStripSplitButton Numbering;


        private System.Windows.Forms.ToolStripSplitButton Multilist;
        private ToolStripMenuItem list_none;
        private ToolStripMenuItem list_normal;
        private ToolStripMenuItem list_multilevel;
        private ToolStripMenuItem list_bullets;
        private ToolStripMenuItem list_new;
        private ToolStripMenuItem libary2;

        private Dictionary<string, ListAdv> lists = new Dictionary<string, ListAdv>();
        ColorPickerUIAdv colorpicker1 = new ColorPickerUIAdv();
    }

    #region Custom DropDown
    /// <summary>
    ///  Custom dropdown for DropDownbutton
    /// </summary>
    public class CustomDropDown : ToolStripDropDown
    {
        public CustomDropDown(ColorPickerUIAdv colorpicker)
        {
            this.Height = colorpicker.Height;
            this.Items.Add(new ToolStripControlHost(colorpicker));
        }
    }
    #endregion
}

