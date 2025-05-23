﻿using Arction.WinForms.Charting;
using Arction.WinForms.Charting.Axes;
using Arction.WinForms.Charting.SeriesXY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayControl
{
    public class PlotMethod
    {
        public static LightningChartUltimate CreateChart(Control parent)
        {
            RenderingSettings settings = new RenderingSettings();
            settings.DeviceType = RendererDeviceType.AutoPreferD11;
            LightningChartUltimate lc = new LightningChartUltimate(settings);
            lc.Parent = parent;
            lc.Dock = DockStyle.Fill;
            lc.Visible = true;
            return lc;
        }
        public static void formatLcuXY(LightningChartUltimate lcu, string title, string ytitle,double ymin, double ymax)
        {
            lcu.BeginUpdate();
            //Reduce memory usage and increase performance. Destroys out-scrolled data. 
            lcu.ViewXY.DropOldSeriesData = false;
            lcu.Title.Text = title;
            lcu.Dock = DockStyle.Fill;
            lcu.ColorTheme = ColorTheme.LightGray;
            lcu.Background.Color = Color.White;
            lcu.Background.GradientColor = Color.Transparent;
            lcu.Background.Style = RectFillStyle.ColorOnly;
            lcu.ViewXY.GraphBackground.Color = Color.Transparent;
            lcu.ViewXY.GraphBackground.GradientColor = Color.Transparent;
            lcu.ViewXY.AxisLayout.AutoAdjustMargins = false;
            lcu.ViewXY.AxisLayout.XAxisTitleAutoPlacement = true;
            lcu.ViewXY.AxisLayout.YAxisTitleAutoPlacement = true;
            lcu.ViewXY.LegendBoxes[0].Visible = true;
            lcu.ViewXY.LegendBoxes[0].Layout = LegendBoxLayout.Vertical;
            lcu.ViewXY.XAxes[0].ScrollMode = XAxisScrollMode.None;
            lcu.ViewXY.XAxes[0].AutoDivSpacing = true;
            lcu.ViewXY.YAxes[0].AutoDivSpacing = true;

            //Configure x-axis
            AxisX xAxis = lcu.ViewXY.XAxes[0];
            xAxis.ValueType = AxisValueType.DateTime;
            xAxis.Title.Text = "时间";
            xAxis.Title.Visible = false;
            xAxis.AutoFormatLabels = false;
            xAxis.LabelsTimeFormat = "HH:mm:ss.fff";
            xAxis.LabelsAngle = 90;
            xAxis.LabelsFont = new Font(FontFamily.GenericSansSerif, 2, FontStyle.Regular);
            xAxis.ScrollMode = XAxisScrollMode.Scrolling;

            //Convert DateTime values to axis values
            DateTime now = DateTime.Now;
            double minX = xAxis.DateTimeToAxisValue(now);
            double maxX = xAxis.DateTimeToAxisValue(now) + 60;
            xAxis.SetRange(minX, maxX);

            //Configure y-axis
            AxisY yAxis = lcu.ViewXY.YAxes[0];
            yAxis.Title.Text = ytitle;
            yAxis.Title.Visible = true;
            yAxis.SetRange(ymin, ymax);
            //Don't show legendbox
            lcu.ViewXY.LegendBoxes[0].Visible = false;
            lcu.ViewXY.LegendBoxes[0].ValueLabelFont = new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular);
            lcu.ViewXY.LegendBoxes[0].Layout = LegendBoxLayout.Vertical;
            lcu.ViewXY.LegendBoxes[0].Position = LegendBoxPositionXY.TopRight;
            //Allow chart rendering
            lcu.EndUpdate();
        }
        public static void addDefaultLine(LightningChartUltimate lcu,string tilte="")
        {
            lcu.BeginUpdate();
            PointLineSeries series = new PointLineSeries(lcu.ViewXY, lcu.ViewXY.XAxes[0], lcu.ViewXY.YAxes[0]);
            series.ShowInLegendBox = true;
            series.Title.Text = "当前角度";
            series.LineStyle.Color = Color.Blue;
            lcu.ViewXY.PointLineSeries.Add(series);
            lcu.EndUpdate();
        }
        public static void formatLcuAxis(LightningChartUltimate lcu, DateTime xmax)
        {
            lcu.BeginUpdate();
            AxisX xAxis = lcu.ViewXY.XAxes[0];
            //Convert DateTime values to axis values
            DateTime now = DateTime.Now;
            double minX = xAxis.DateTimeToAxisValue(now);
            double maxX = xAxis.DateTimeToAxisValue(xmax);
            xAxis.SetRange(minX, maxX);

            lcu.EndUpdate();
        }
        public static void trackPlot(LightningChartUltimate lcu, double angle, int lineIndex)
        {
            lcu.BeginUpdate();
            SeriesPoint[] points = new SeriesPoint[1];
            points[0].X = lcu.ViewXY.XAxes[0].DateTimeToAxisValue(DateTime.Now);
            points[0].Y = angle;
            lcu.ViewXY.PointLineSeries[lineIndex].AddPoints(points, false);
            lcu.ViewXY.YAxes[0].SetRange(lcu.ViewXY.PointLineSeries[lineIndex].GetYValues().Min(), lcu.ViewXY.PointLineSeries[lineIndex].GetYValues().Max());
            lcu.EndUpdate();
        }
        public static void trackPlot(LightningChartUltimate lcu, DateTime time, double value, int lineIndex)
        {
            lcu.BeginUpdate();
            SeriesPoint[] points = new SeriesPoint[1];
            points[0].X = lcu.ViewXY.XAxes[0].DateTimeToAxisValue(time);
            points[0].Y = value;
            lcu.ViewXY.PointLineSeries[lineIndex].AddPoints(points, false);
            lcu.ViewXY.XAxes[0].ScrollPosition = points[0].X;
            lcu.ViewXY.YAxes[0].SetRange(lcu.ViewXY.PointLineSeries[lineIndex].GetYValues().Min(), lcu.ViewXY.PointLineSeries[lineIndex].GetYValues().Max());
            lcu.EndUpdate();
        }
        public static void AddLineXY(LightningChartUltimate lcu,List<DateTime> time,List<double> value,string name,Color col)
        {
            lcu.BeginUpdate();
            PointLineSeries ls = new PointLineSeries(lcu.ViewXY, lcu.ViewXY.XAxes[0], lcu.ViewXY.YAxes[0]);
            ls.PointsVisible = false;
            ls.LineVisible = true;
            SeriesPoint[] points = new SeriesPoint[time.Count];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X= lcu.ViewXY.XAxes[0].DateTimeToAxisValue(time[i]);
                points[i].Y = value[i];
            }
            ls.Points = points;
            ls.InvalidateData();
            ls.Title.Text = name;
            ls.LineStyle.Color = col;
            ls.ShowInLegendBox = true;
            lcu.ViewXY.PointLineSeries.Add(ls);
            lcu.ViewXY.LegendBoxes[0].Visible = true;
            lcu.ViewXY.ZoomToFit();
            lcu.EndUpdate();
        }
        public static void AddLineXY(LightningChartUltimate lcu, List<double> value, string name, Color col)
        {
            lcu.BeginUpdate();
            PointLineSeries ls = new PointLineSeries(lcu.ViewXY, lcu.ViewXY.XAxes[0], lcu.ViewXY.YAxes[0]);
            ls.PointsVisible = false;
            ls.LineVisible = true;
            SeriesPoint[] points = new SeriesPoint[value.Count];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = i;
                points[i].Y = value[i];
            }
            ls.Points = points;
            ls.InvalidateData();
            ls.Title.Text = name;
            ls.LineStyle.Color = col;
            ls.ShowInLegendBox = true;
            lcu.ViewXY.PointLineSeries.Add(ls);
            lcu.ViewXY.LegendBoxes[0].Visible = true;
            lcu.ViewXY.ZoomToFit();
            lcu.EndUpdate();
        }
        public static void ClearLines(LightningChartUltimate lcu)
        {
            lcu.BeginUpdate();
            lcu.ViewXY.PointLineSeries.Clear();
            lcu.EndUpdate();
        }
        public static void clearPlot(LightningChartUltimate lcu)
        {
            for (int i = 0; i < lcu.ViewXY.PointLineSeries.Count; i++)
            {
                lcu.ViewXY.PointLineSeries[i].DeletePointsBeforeX(lcu.ViewXY.XAxes[0].DateTimeToAxisValue(DateTime.MaxValue));
            }
        }
    }
}
