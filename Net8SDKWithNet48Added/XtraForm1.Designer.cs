namespace Net8SDKWithNet48Added
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
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            cGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cGauge1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleBackgroundLayerComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleNeedleComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleSpindleCapComponent1).BeginInit();
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
            ribbonControl1.Size = new Size(1197, 292);
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
            gaugeControl1.Dock = DockStyle.Fill;
            gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] { cGauge1 });
            gaugeControl1.Location = new Point(0, 292);
            gaugeControl1.Name = "gaugeControl1";
            gaugeControl1.Size = new Size(1197, 460);
            gaugeControl1.TabIndex = 1;
            // 
            // cGauge1
            // 
            cGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] { arcScaleBackgroundLayerComponent1 });
            cGauge1.Bounds = new Rectangle(6, 6, 1185, 448);
            cGauge1.Name = "cGauge1";
            cGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] { arcScaleNeedleComponent1 });
            cGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] { arcScaleComponent1 });
            cGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] { arcScaleSpindleCapComponent1 });
            // 
            // arcScaleComponent1
            // 
            arcScaleComponent1.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Arial Narrow", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF");
            arcScaleComponent1.EndAngle = 30F;
            arcScaleComponent1.MajorTickCount = 10;
            arcScaleComponent1.MajorTickmark.AllowTickOverlap = true;
            arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            arcScaleComponent1.MajorTickmark.ShapeOffset = -9F;
            arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_2;
            arcScaleComponent1.MajorTickmark.TextOffset = -22F;
            arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            arcScaleComponent1.MaxValue = 180F;
            arcScaleComponent1.MinorTickCount = 4;
            arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style2_1;
            arcScaleComponent1.Name = "scale1";
            arcScaleComponent1.RadiusX = 91F;
            arcScaleComponent1.RadiusY = 91F;
            arcScaleComponent1.StartAngle = -240F;
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            arcScaleBackgroundLayerComponent1.ArcScale = arcScaleComponent1;
            arcScaleBackgroundLayerComponent1.Name = "bg1";
            arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style2;
            arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleNeedleComponent1
            // 
            arcScaleNeedleComponent1.ArcScale = arcScaleComponent1;
            arcScaleNeedleComponent1.EndOffset = -6F;
            arcScaleNeedleComponent1.Name = "needle1";
            arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style2;
            arcScaleNeedleComponent1.StartOffset = 9F;
            arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            arcScaleSpindleCapComponent1.ArcScale = arcScaleComponent1;
            arcScaleSpindleCapComponent1.Name = "cap1";
            arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style2;
            arcScaleSpindleCapComponent1.Size = new SizeF(32F, 32F);
            arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 752);
            Controls.Add(gaugeControl1);
            Controls.Add(ribbonControl1);
            Name = "XtraForm1";
            Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cGauge1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleBackgroundLayerComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleNeedleComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)arcScaleSpindleCapComponent1).EndInit();
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
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
    }
}