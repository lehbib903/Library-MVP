﻿
namespace LibraryMVP.Views.Forms
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(629, 173);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ادارة المكتبة الشخصية";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem1.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "تصنيفات الكتب";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "المؤلفين";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "اماكن الكتب";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem5.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem5.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem5.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem5.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem5.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem5.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "دار النشر";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "الدول";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem7.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem7.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem7.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem7.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem7.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "ادارة الكتب";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem8.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem8.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem8.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem8.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem8.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem8.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "بحث عن الكتب";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem9.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem9.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem9.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "بيانات المسعيرين";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem10.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem10.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem10.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "استعارة كتاب";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem11.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem11.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem11.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem11.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem11.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem11.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "تقارير الإستعارات";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.LargeImage")));
            this.barButtonItem12.ItemAppearance.Hovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem12.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem12.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemAppearance.Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem12.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem12.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemAppearance.Pressed.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem12.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem12.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "اعدادات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "الكتب";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "الإستعارات";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup8.ImageOptions.Image")));
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup9.ImageOptions.Image")));
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup10.ImageOptions.Image")));
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 458);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(629, 24);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.EnableBonusSkins = true;
            // 
            // Frm_Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(629, 482);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Main";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "النافذة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}