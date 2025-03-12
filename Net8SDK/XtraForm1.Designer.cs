namespace Net8SDK
{
    partial class XtraForm1
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
            components = new System.ComponentModel.Container();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            cGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            dockManager1 = new DevExpress.XtraBars.Docking.DockManager(components);
            dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cGauge1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleBackgroundLayerComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleNeedleComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleComponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dockManager1).BeginInit();
            dockPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 1;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1144, 292);
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gaugeControl1
            // 
            gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] { cGauge1 });
            gaugeControl1.Location = new Point(493, 367);
            gaugeControl1.Name = "gaugeControl1";
            gaugeControl1.Size = new Size(651, 267);
            gaugeControl1.TabIndex = 1;
            // 
            // cGauge1
            // 
            cGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] { arcScaleBackgroundLayerComponent1 });
            cGauge1.Bounds = new Rectangle(6, 6, 639, 255);
            cGauge1.Name = "cGauge1";
            cGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] { arcScaleNeedleComponent1 });
            cGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] { arcScaleComponent1, arcScaleComponent2 });
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            arcScaleBackgroundLayerComponent1.ArcScale = arcScaleComponent1;
            arcScaleBackgroundLayerComponent1.Name = "bg1";
            arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style11;
            arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent1.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(0F, 0F);
            arcScaleComponent1.EndAngle = 60F;
            arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            arcScaleComponent1.MajorTickmark.ShapeOffset = -5F;
            arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_4;
            arcScaleComponent1.MajorTickmark.TextOffset = -17F;
            arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            arcScaleComponent1.MaxValue = 100F;
            arcScaleComponent1.MinorTickCount = 4;
            arcScaleComponent1.MinorTickmark.ShapeOffset = -2.5F;
            arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_3;
            arcScaleComponent1.Name = "scale1";
            arcScaleComponent1.RadiusX = 107F;
            arcScaleComponent1.RadiusY = 107F;
            arcScaleComponent1.StartAngle = -240F;
            // 
            // arcScaleNeedleComponent1
            // 
            arcScaleNeedleComponent1.ArcScale = arcScaleComponent1;
            arcScaleNeedleComponent1.EndOffset = 5F;
            arcScaleNeedleComponent1.Name = "needle1";
            arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style11;
            arcScaleNeedleComponent1.StartOffset = -9.5F;
            arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleComponent2
            // 
            arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            arcScaleComponent2.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(0F, 0F);
            arcScaleComponent2.EndAngle = -30F;
            arcScaleComponent2.MajorTickCount = 8;
            arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_2;
            arcScaleComponent2.MajorTickmark.TextOffset = -15F;
            arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            arcScaleComponent2.MaxValue = 700F;
            arcScaleComponent2.MinorTickCount = 4;
            arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style11_1;
            arcScaleComponent2.Name = "scale2";
            arcScaleComponent2.RadiusX = 70F;
            arcScaleComponent2.RadiusY = 70F;
            arcScaleComponent2.StartAngle = -240F;
            arcScaleComponent2.ZOrder = -1;
            // 
            // dockManager1
            // 
            dockManager1.Form = this;
            dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { dockPanel1 });
            dockManager1.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl" });
            // 
            // dockPanel1
            // 
            dockPanel1.Controls.Add(dockPanel1_Container);
            dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            dockPanel1.ID = new Guid("15aa8227-2d10-4157-8b7b-15ffca5fb482");
            dockPanel1.Location = new Point(0, 292);
            dockPanel1.Name = "dockPanel1";
            dockPanel1.OriginalSize = new Size(200, 200);
            dockPanel1.Size = new Size(200, 342);
            dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            dockPanel1_Container.Location = new Point(6, 52);
            dockPanel1_Container.Name = "dockPanel1_Container";
            dockPanel1_Container.Size = new Size(183, 284);
            dockPanel1_Container.TabIndex = 0;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 634);
            Controls.Add(gaugeControl1);
            Controls.Add(dockPanel1);
            Controls.Add(ribbonControl1);
            Name = "XtraForm1";
            Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cGauge1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleBackgroundLayerComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleNeedleComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleComponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dockManager1).EndInit();
            dockPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge cGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    }
}