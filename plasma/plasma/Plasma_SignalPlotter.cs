//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class SignalPlotter plasma/widgets/signalplotter.h <Plasma/Widgets/SignalPlotter>
    /// </remarks>        <short> Provides a signal plotter for plasma.  </short>
    [SmokeClass("Plasma::SignalPlotter")]
    public class SignalPlotter : QGraphicsWidget, IDisposable {
        protected SignalPlotter(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(SignalPlotter), this);
        }
        [Q_PROPERTY("QString", "title")]
        public string Title {
            get { return (string) interceptor.Invoke("title", "title()", typeof(string)); }
            set { interceptor.Invoke("setTitle$", "setTitle(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "unit")]
        public string Unit {
            get { return (string) interceptor.Invoke("unit", "unit()", typeof(string)); }
            set { interceptor.Invoke("setUnit$", "setUnit(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("qreal", "scale")]
        public double Scale {
            get { return (double) interceptor.Invoke("scaledBy", "scaledBy()", typeof(double)); }
            set { interceptor.Invoke("scale$", "scale(qreal)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("bool", "useAutoRange")]
        public bool UseAutoRange {
            get { return (bool) interceptor.Invoke("useAutoRange", "useAutoRange()", typeof(bool)); }
            set { interceptor.Invoke("setUseAutoRange$", "setUseAutoRange(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("uint", "horizontalScale")]
        public uint HorizontalScale {
            get { return (uint) interceptor.Invoke("horizontalScale", "horizontalScale()", typeof(uint)); }
            set { interceptor.Invoke("setHorizontalScale$", "setHorizontalScale(uint)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("bool", "showVerticalLines")]
        public bool ShowVerticalLines {
            get { return (bool) interceptor.Invoke("showVerticalLines", "showVerticalLines()", typeof(bool)); }
            set { interceptor.Invoke("setShowVerticalLines$", "setShowVerticalLines(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QColor", "verticalLinesColor")]
        public QColor VerticalLinesColor {
            get { return (QColor) interceptor.Invoke("verticalLinesColor", "verticalLinesColor()", typeof(QColor)); }
            set { interceptor.Invoke("setVerticalLinesColor#", "setVerticalLinesColor(QColor)", typeof(void), typeof(QColor), value); }
        }
        [Q_PROPERTY("uint", "verticalLinesDistance")]
        public uint VerticalLinesDistance {
            get { return (uint) interceptor.Invoke("verticalLinesDistance", "verticalLinesDistance()", typeof(uint)); }
            set { interceptor.Invoke("setVerticalLinesDistance$", "setVerticalLinesDistance(uint)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("bool", "verticalLinesScroll")]
        public bool VerticalLinesScroll {
            get { return (bool) interceptor.Invoke("verticalLinesScroll", "verticalLinesScroll()", typeof(bool)); }
            set { interceptor.Invoke("setVerticalLinesScroll$", "setVerticalLinesScroll(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "showHorizontalLines")]
        public bool ShowHorizontalLines {
            get { return (bool) interceptor.Invoke("showHorizontalLines", "showHorizontalLines()", typeof(bool)); }
            set { interceptor.Invoke("setShowHorizontalLines$", "setShowHorizontalLines(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QColor", "horizontalLinesColor")]
        public QColor HorizontalLinesColor {
            get { return (QColor) interceptor.Invoke("horizontalLinesColor", "horizontalLinesColor()", typeof(QColor)); }
            set { interceptor.Invoke("setHorizontalLinesColor#", "setHorizontalLinesColor(QColor)", typeof(void), typeof(QColor), value); }
        }
        [Q_PROPERTY("QColor", "fontColor")]
        public QColor FontColor {
            get { return (QColor) interceptor.Invoke("fontColor", "fontColor()", typeof(QColor)); }
            set { interceptor.Invoke("setFontColor#", "setFontColor(QColor)", typeof(void), typeof(QColor), value); }
        }
        [Q_PROPERTY("QFont", "font")]
        public new QFont Font {
            get { return (QFont) interceptor.Invoke("font", "font()", typeof(QFont)); }
            set { interceptor.Invoke("setFont#", "setFont(QFont)", typeof(void), typeof(QFont), value); }
        }
        [Q_PROPERTY("uint", "horizontalLinesCount")]
        public uint HorizontalLinesCount {
            get { return (uint) interceptor.Invoke("horizontalLinesCount", "horizontalLinesCount()", typeof(uint)); }
            set { interceptor.Invoke("setHorizontalLinesCount$", "setHorizontalLinesCount(uint)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("bool", "showLabels")]
        public bool ShowLabels {
            get { return (bool) interceptor.Invoke("showLabels", "showLabels()", typeof(bool)); }
            set { interceptor.Invoke("setShowLabels$", "setShowLabels(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "showTopBar")]
        public bool ShowTopBar {
            get { return (bool) interceptor.Invoke("showTopBar", "showTopBar()", typeof(bool)); }
            set { interceptor.Invoke("setShowTopBar$", "setShowTopBar(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QColor", "backgroundColor")]
        public QColor BackgroundColor {
            get { return (QColor) interceptor.Invoke("backgroundColor", "backgroundColor()", typeof(QColor)); }
            set { interceptor.Invoke("setBackgroundColor#", "setBackgroundColor(QColor)", typeof(void), typeof(QColor), value); }
        }
        [Q_PROPERTY("QString", "svgBackground")]
        public string SvgBackground {
            get { return (string) interceptor.Invoke("svgBackground", "svgBackground()", typeof(string)); }
            set { interceptor.Invoke("setSvgBackground$", "setSvgBackground(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("bool", "thinFrame")]
        public bool ThinFrame {
            get { return (bool) interceptor.Invoke("setThinFrame", "setThinFrame()", typeof(bool)); }
        }
        [Q_PROPERTY("bool", "stackPlots")]
        public bool StackPlots {
            get { return (bool) interceptor.Invoke("stackPlots", "stackPlots()", typeof(bool)); }
            set { interceptor.Invoke("setStackPlots$", "setStackPlots(bool)", typeof(void), typeof(bool), value); }
        }
        public SignalPlotter(IQGraphicsItem parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("SignalPlotter#", "SignalPlotter(QGraphicsItem*)", typeof(void), typeof(IQGraphicsItem), parent);
        }
        public SignalPlotter() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("SignalPlotter", "SignalPlotter()", typeof(void));
        }
        /// <remarks>
        ///  Add a new line to the graph plotter, with the specified color.
        ///  Note that the order you add the plots must be the same order that
        ///  the same data is given in (unless you reorder the plots).
        /// <param> name="color" the color to use for this plot
        ///      </param></remarks>        <short>    Add a new line to the graph plotter, with the specified color.</short>
        public void AddPlot(QColor color) {
            interceptor.Invoke("addPlot#", "addPlot(const QColor&)", typeof(void), typeof(QColor), color);
        }
        /// <remarks>
        ///  Add data to the graph, and advance the graph by one time period.
        ///  The data must be given as a list in the same order that the plots were
        ///  added (or consequently reordered).
        /// <param> name="samples" a list with the new value for each plot
        ///      </param></remarks>        <short>    Add data to the graph, and advance the graph by one time period.</short>
        public void AddSample(List<double> samples) {
            interceptor.Invoke("addSample?", "addSample(const QList<double>&)", typeof(void), typeof(List<double>), samples);
        }
        /// <remarks>
        ///  Reorder the plots into the order given.  For example:
        ///  <pre>
        ///   KSignalPlotter s = KSignalPlotter(parent);
        ///   s.AddPlot(Qt.Blue);
        ///   s.AddPlot(Qt.Green);
        ///   QList neworder;
        ///   neworder << 1 << 0;
        ///   reorderPlots(newOrder);
        ///   //Now the order is Green then Blue
        ///  </pre>
        /// <param> name="newOrder" a list with the new position of each plot
        ///      </param></remarks>        <short>    Reorder the plots into the order given.</short>
        public void ReorderPlots(List<uint> newOrder) {
            interceptor.Invoke("reorderPlots?", "reorderPlots(const QList<uint>&)", typeof(void), typeof(List<uint>), newOrder);
        }
        /// <remarks>
        ///  Removes the plot at the specified index.
        /// <param> name="pos" the index of the plot to be removed
        ///      </param></remarks>        <short>    Removes the plot at the specified index.</short>
        public void RemovePlot(uint pos) {
            interceptor.Invoke("removePlot$", "removePlot(uint)", typeof(void), typeof(uint), pos);
        }
        /// <remarks>
        ///  Return the list of plot colors, in the order that the plots
        ///  were added (or later reordered).
        /// </remarks>        <return> a list containing the color of every plot
        ///      </return>
        ///         <short>    Return the list of plot colors, in the order that the plots  were added (or later reordered).</short>
        public List<Plasma.PlotColor> PlotColors() {
            return (List<Plasma.PlotColor>) interceptor.Invoke("plotColors", "plotColors()", typeof(List<Plasma.PlotColor>));
        }
        /// <remarks>
        ///  Change the minimum and maximum values drawn on the graph.
        ///  Note that these values are sanitised.  For example, if you
        ///  set the minimum as 3, and the maximum as 97, then the graph
        ///  would be drawn between 0 and 100.  The algorithm to determine
        ///  this "nice range" attempts to minimize the number of non-zero
        ///  digits.
        ///  Use setAutoRange instead to determine the range automatically
        ///  from the data.
        /// <param> name="min" the minimum value to use for the vertical axis
        /// </param><param> name="max" the maximum value to use for the vertical axis
        ///      </param></remarks>        <short>    Change the minimum and maximum values drawn on the graph.</short>
        public void SetVerticalRange(double min, double max) {
            interceptor.Invoke("setVerticalRange$$", "setVerticalRange(double, double)", typeof(void), typeof(double), min, typeof(double), max);
        }
        /// <remarks>
        ///  Get the min value of the vertical axis.  @see changeRange
        /// </remarks>        <return> the minimum value to use for the vertical axis
        ///      </return>
        ///         <short>    Get the min value of the vertical axis.</short>
        public double VerticalMinValue() {
            return (double) interceptor.Invoke("verticalMinValue", "verticalMinValue() const", typeof(double));
        }
        /// <remarks>
        ///  Get the max value of the vertical axis.  @see changeRange
        /// </remarks>        <return> the maximum value to use for the vertical axis
        ///      </return>
        ///         <short>    Get the max value of the vertical axis.</short>
        public double VerticalMaxValue() {
            return (double) interceptor.Invoke("verticalMaxValue", "verticalMaxValue() const", typeof(double));
        }
        /// <remarks>
        ///  Return the last value that we have for plot i. Returns 0 if not known.
        /// <param> name="i" the plot we like to have the last value from
        /// </param></remarks>        <return> the last value of this plot or 0 if not found
        ///      </return>
        ///         <short>    Return the last value that we have for plot i.</short>
        public double LastValue(uint i) {
            return (double) interceptor.Invoke("lastValue$", "lastValue(uint) const", typeof(double), typeof(uint), i);
        }
        /// <remarks>
        ///  Return a translated string like: "34 %" or "100 KB" for plot i
        /// <param> name="i" the plot we like to have the value as string from
        /// </param></remarks>        <return> the last value of this plot as a string
        ///      </return>
        ///         <short>    Return a translated string like: "34 %" or "100 KB" for plot i </short>
        public string LastValueAsString(uint i) {
            return (string) interceptor.Invoke("lastValueAsString$", "lastValueAsString(uint) const", typeof(string), typeof(uint), i);
        }
        /// <remarks>
        ///  Render the graph to the specified width and height, and return it
        ///  as an image.  This is useful, for example, if you draw a small version
        ///  of the graph, but then want to show a large version in a tooltip etc
        /// <param> name="width" the width of the snapshot
        /// </param><param> name="height" the height of the snapshot
        /// </param></remarks>        <return> a snapshot of the plotter as an image
        ///      </return>
        ///         <short>    Render the graph to the specified width and height, and return it  as an image.</short>
        public QPixmap GetSnapshotImage(uint width, uint height) {
            return (QPixmap) interceptor.Invoke("getSnapshotImage$$", "getSnapshotImage(uint, uint)", typeof(QPixmap), typeof(uint), width, typeof(uint), height);
        }
        /// <remarks>
        ///  Overwritten to be notified of size changes. Needed to update the
        ///  data buffers that are used to store the samples.
        ///      </remarks>        <short>    Overwritten to be notified of size changes.</short>
        [SmokeMethod("setGeometry(const QRectF&)")]
        public override void SetGeometry(QRectF geometry) {
            interceptor.Invoke("setGeometry#", "setGeometry(const QRectF&)", typeof(void), typeof(QRectF), geometry);
        }
        protected void UpdateDataBuffers() {
            interceptor.Invoke("updateDataBuffers", "updateDataBuffers()", typeof(void));
        }
        protected void CalculateNiceRange() {
            interceptor.Invoke("calculateNiceRange", "calculateNiceRange()", typeof(void));
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        }
        protected void DrawWidget(QPainter p, uint w, uint height, int horizontalScale) {
            interceptor.Invoke("drawWidget#$$$", "drawWidget(QPainter*, uint, uint, int)", typeof(void), typeof(QPainter), p, typeof(uint), w, typeof(uint), height, typeof(int), horizontalScale);
        }
        protected void DrawBackground(QPainter p, int w, int h) {
            interceptor.Invoke("drawBackground#$$", "drawBackground(QPainter*, int, int)", typeof(void), typeof(QPainter), p, typeof(int), w, typeof(int), h);
        }
        protected void DrawThinFrame(QPainter p, int w, int h) {
            interceptor.Invoke("drawThinFrame#$$", "drawThinFrame(QPainter*, int, int)", typeof(void), typeof(QPainter), p, typeof(int), w, typeof(int), h);
        }
        protected void DrawTopBarFrame(QPainter p, int separatorX, int height) {
            interceptor.Invoke("drawTopBarFrame#$$", "drawTopBarFrame(QPainter*, int, int)", typeof(void), typeof(QPainter), p, typeof(int), separatorX, typeof(int), height);
        }
        protected void DrawTopBarContents(QPainter p, int x, int width, int height) {
            interceptor.Invoke("drawTopBarContents#$$$", "drawTopBarContents(QPainter*, int, int, int)", typeof(void), typeof(QPainter), p, typeof(int), x, typeof(int), width, typeof(int), height);
        }
        protected void DrawVerticalLines(QPainter p, int top, int w, int h) {
            interceptor.Invoke("drawVerticalLines#$$$", "drawVerticalLines(QPainter*, int, int, int)", typeof(void), typeof(QPainter), p, typeof(int), top, typeof(int), w, typeof(int), h);
        }
        protected void DrawPlots(QPainter p, int top, int w, int h, int horizontalScale) {
            interceptor.Invoke("drawPlots#$$$$", "drawPlots(QPainter*, int, int, int, int)", typeof(void), typeof(QPainter), p, typeof(int), top, typeof(int), w, typeof(int), h, typeof(int), horizontalScale);
        }
        protected void DrawAxisText(QPainter p, int top, int h) {
            interceptor.Invoke("drawAxisText#$$", "drawAxisText(QPainter*, int, int)", typeof(void), typeof(QPainter), p, typeof(int), top, typeof(int), h);
        }
        protected void DrawHorizontalLines(QPainter p, int top, int w, int h) {
            interceptor.Invoke("drawHorizontalLines#$$$", "drawHorizontalLines(QPainter*, int, int, int)", typeof(void), typeof(QPainter), p, typeof(int), top, typeof(int), w, typeof(int), h);
        }
        ~SignalPlotter() {
            interceptor.Invoke("~SignalPlotter", "~SignalPlotter()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~SignalPlotter", "~SignalPlotter()", typeof(void));
        }
        protected new ISignalPlotterSignals Emit {
            get { return (ISignalPlotterSignals) Q_EMIT; }
        }
    }

    public interface ISignalPlotterSignals : IQGraphicsWidgetSignals {
    }
}
