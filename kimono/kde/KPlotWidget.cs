//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	/// @class KPlotWidget
	/// Widget for drawing plots. The basic idea behind KPlotWidget is that 
	/// you don't have to worry about any transformation from your data's 
	/// natural units to screen pixel coordinates; this is handled internally
	/// by the widget.  
	/// Data to be plotted are represented by one or more instances of 
	/// KPlotObject.  KPlotObject contains a list of QPointFs to be plotted 
	/// (again, in the data's natural units), as well as information about how 
	/// the data are to be rendered in the plot (i.e., as separate points or 
	/// connected by lines?  With what color and point style? etc).  See 
	/// KPlotObject for more information.
	/// KPlotWidget automatically adds axis labels with tickmarks and tick 
	/// labels.  These are encapsulated in the KPlotAxis class.  All you have 
	/// to do is set the limits of the plotting area in data units, and 
	/// KPlotWidget wil figure out the optimal positions and labels for the 
	/// tickmarks on the axes.
	/// Example of usage:
	///  @code
	/// KPlotWidget kpw = new KPlotWidget( parent );
	/// // setting our limits for the plot
	/// kpw.SetLimits( 1.0, 5.0, 1.0, 25.0 );
	/// // creating a plot object whose points are connected by red lines ...
	/// KPlotObject kpo = new KPlotObject( Qt.Red, KPlotObject.Lines );
	/// // ... adding some points to it ...
	/// for ( float x = 1.0; x <= 5.0; x += 0.1 )
	///     kpo.AddPoint( x, xx );
	/// // ... and adding the object to the plot widget
	/// kpw.AddPlotObject( kpo );
	///  @endcode
	/// @note KPlotWidget will take care of the objects added to it, so when
	/// clearing the objects list (eg with removeAllPlotObjects()) any previous 
	/// reference to a KPlotObject already added to a KPlotWidget will be invalid.
	/// </remarks>		<author> Jason Harris
	/// </author>
	/// 		<version> 1.1
	///  </version>
	/// 		<short> Generic data plotting widget. </short>

	[SmokeClass("KPlotWidget")]
	public class KPlotWidget : QFrame, IDisposable {
 		protected KPlotWidget(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPlotWidget), this);
		}
		/// <remarks>
		///  The four types of plot axes.
		///      </remarks>		<short>    The four types of plot axes.</short>
		public enum Axis {
			LeftAxis = 0,
			BottomAxis = 1,
			RightAxis = 2,
			TopAxis = 3,
		}
		[Q_PROPERTY("int", "leftPadding")]
		public int LeftPadding {
			get { return (int) interceptor.Invoke("leftPadding", "leftPadding()", typeof(int)); }
		}
		[Q_PROPERTY("int", "rightPadding")]
		public int RightPadding {
			get { return (int) interceptor.Invoke("rightPadding", "rightPadding()", typeof(int)); }
		}
		[Q_PROPERTY("int", "topPadding")]
		public int TopPadding {
			get { return (int) interceptor.Invoke("topPadding", "topPadding()", typeof(int)); }
		}
		[Q_PROPERTY("int", "bottomPadding")]
		public int BottomPadding {
			get { return (int) interceptor.Invoke("bottomPadding", "bottomPadding()", typeof(int)); }
		}
		[Q_PROPERTY("QColor", "backgroundColor")]
		public QColor BackgroundColor {
			get { return (QColor) interceptor.Invoke("backgroundColor", "backgroundColor()", typeof(QColor)); }
			set { interceptor.Invoke("setBackgroundColor#", "setBackgroundColor(QColor)", typeof(void), typeof(QColor), value); }
		}
		[Q_PROPERTY("QColor", "foregroundColor")]
		public QColor ForegroundColor {
			get { return (QColor) interceptor.Invoke("foregroundColor", "foregroundColor()", typeof(QColor)); }
			set { interceptor.Invoke("setForegroundColor#", "setForegroundColor(QColor)", typeof(void), typeof(QColor), value); }
		}
		[Q_PROPERTY("QColor", "gridColor")]
		public QColor GridColor {
			get { return (QColor) interceptor.Invoke("gridColor", "gridColor()", typeof(QColor)); }
			set { interceptor.Invoke("setGridColor#", "setGridColor(QColor)", typeof(void), typeof(QColor), value); }
		}
		[Q_PROPERTY("bool", "grid")]
		public bool Grid {
			get { return (bool) interceptor.Invoke("isGridShown", "isGridShown()", typeof(bool)); }
			set { interceptor.Invoke("setShowGrid$", "setShowGrid(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "objectToolTip")]
		public bool ObjectToolTip {
			get { return (bool) interceptor.Invoke("isObjectToolTipShown", "isObjectToolTipShown()", typeof(bool)); }
			set { interceptor.Invoke("setObjectToolTipShown$", "setObjectToolTipShown(bool)", typeof(void), typeof(bool), value); }
		}
		/// <remarks>
		/// <param> name="parent" the parent widget
		///      </param></remarks>		<short> Constructor. </short>
		public KPlotWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPlotWidget#", "KPlotWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPlotWidget() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPlotWidget", "KPlotWidget()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> suggested minimum size for the plot widget
		///      </return>
		/// 		<short>   </short>
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		/// <remarks>
		/// </remarks>		<return> suggested size for the plot widget
		///      </return>
		/// 		<short>   </short>
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		/// <remarks>
		///  Set new data limits for the plot.
		/// <param> name="x1" the minimum X value in data units
		/// </param><param> name="x2" the maximum X value in data units
		/// </param><param> name="y1" the minimum Y value in data units
		/// </param><param> name="y2" the maximum Y value in data units
		///      </param></remarks>		<short>    Set new data limits for the plot.</short>
		public void SetLimits(double x1, double x2, double y1, double y2) {
			interceptor.Invoke("setLimits$$$$", "setLimits(double, double, double, double)", typeof(void), typeof(double), x1, typeof(double), x2, typeof(double), y1, typeof(double), y2);
		}
		/// <remarks>
		///  All data points are plotted using the coordinates 
		///  defined by setLimits(), so this function is only useful for 
		///  showing alternate tickmark labels along the top and right 
		///  edges.  For example, if you were plotting temperature on the 
		///  X-axis, you could use Centigrade units for the primary 
		///  (bottom) axis, using setLimits( 0.0, 100.0, 0.0, 1.0 ).  If
		///  you also wanted to show Farenheit units along the secondary 
		///  (top) axis, you would additionally use 
		///  setSecondaryLimits( 32.0, 212.0, 0.0, 1.0 ).  The data 
		///  added to the plot would have x-coordinates in Centigrade degrees.
		/// <param> name="x1" the minimum X value in secondary data units
		/// </param><param> name="x2" the maximum X value in secondary data units
		/// </param><param> name="y1" the minimum Y value in secondary data units
		/// </param><param> name="y2" the maximum Y value in secondary data units
		///  @sa setLimits()
		///      </param></remarks>		<short> Reset the secondary data limits, which control the   values displayed along the top and right axes. </short>
		public void SetSecondaryLimits(double x1, double x2, double y1, double y2) {
			interceptor.Invoke("setSecondaryLimits$$$$", "setSecondaryLimits(double, double, double, double)", typeof(void), typeof(double), x1, typeof(double), x2, typeof(double), y1, typeof(double), y2);
		}
		/// <remarks>
		///  Unset the secondary limits, so the top and right axes 
		///  show the same tickmarks as the bottom and left axes (no tickmark
		///  labels will be drawn for the top and right axes in this case)
		///      </remarks>		<short>    Unset the secondary limits, so the top and right axes   show the same tickmarks as the bottom and left axes (no tickmark  labels will be drawn for the top and right axes in this case)      </short>
		public void ClearSecondaryLimits() {
			interceptor.Invoke("clearSecondaryLimits", "clearSecondaryLimits()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> the rectangle representing the boundaries of the current plot, 
		///  in natural data units.
		///  @sa setLimits()
		///      </return>
		/// 		<short>   </short>
		public QRectF DataRect() {
			return (QRectF) interceptor.Invoke("dataRect", "dataRect() const", typeof(QRectF));
		}
		/// <remarks>
		/// </remarks>		<return> the rectangle representing the boundaries of the secondary 
		///  data limits, if they have been set.  Otherwise, this function 
		///  behaves the same as dataRect().
		///  @sa setSecondaryLimits()
		///      </return>
		/// 		<short>   </short>
		public QRectF SecondaryDataRect() {
			return (QRectF) interceptor.Invoke("secondaryDataRect", "secondaryDataRect() const", typeof(QRectF));
		}
		/// <remarks>
		/// </remarks>		<return> the rectangle representing the boundaries of the current plot, 
		///  in screen pixel units.
		///       </return>
		/// 		<short>   </short>
		public QRect PixRect() {
			return (QRect) interceptor.Invoke("pixRect", "pixRect() const", typeof(QRect));
		}
		/// <remarks>
		///  Add an item to the list of KPlotObjects to be plotted.
		///  @note do not use this multiple time if many objects have to be added,
		///  addPlotObjects() is strongly suggested in this case
		/// <param> name="object" the KPlotObject to be added
		///      </param></remarks>		<short>    Add an item to the list of KPlotObjects to be plotted.</short>
		public void AddPlotObject(KPlotObject arg1) {
			interceptor.Invoke("addPlotObject#", "addPlotObject(KPlotObject*)", typeof(void), typeof(KPlotObject), arg1);
		}
		/// <remarks>
		///  Add more than one KPlotObject at one time.
		/// <param> name="objects" the list of KPlotObjects to be added
		///      </param></remarks>		<short>    Add more than one KPlotObject at one time.</short>
		public void AddPlotObjects(List<KPlotObject> objects) {
			interceptor.Invoke("addPlotObjects?", "addPlotObjects(const QList<KPlotObject*>&)", typeof(void), typeof(List<KPlotObject>), objects);
		}
		/// <remarks>
		/// </remarks>		<return> the current list of plot objects
		///      </return>
		/// 		<short>   </short>
		public List<KPlotObject> PlotObjects() {
			return (List<KPlotObject>) interceptor.Invoke("plotObjects", "plotObjects() const", typeof(List<KPlotObject>));
		}
		/// <remarks>
		///  Remove and delete all items from the list of KPlotObjects
		///      </remarks>		<short>    Remove and delete all items from the list of KPlotObjects      </short>
		public void RemoveAllPlotObjects() {
			interceptor.Invoke("removeAllPlotObjects", "removeAllPlotObjects()", typeof(void));
		}
		/// <remarks>
		///  Reset the mask used for non-overlapping labels so that all 
		///  regions of the plot area are considered empty.
		///      </remarks>		<short>    Reset the mask used for non-overlapping labels so that all   regions of the plot area are considered empty.</short>
		public void ResetPlotMask() {
			interceptor.Invoke("resetPlotMask", "resetPlotMask()", typeof(void));
		}
		/// <remarks>
		///  Clear the object list, reset the data limits, and remove axis labels
		///      </remarks>		<short>    Clear the object list, reset the data limits, and remove axis labels      </short>
		public void ResetPlot() {
			interceptor.Invoke("resetPlot", "resetPlot()", typeof(void));
		}
		/// <remarks>
		///  Replace an item in the KPlotObject list.
		/// <param> name="i" the index of the item to be replaced
		/// </param><param> name="o" pointer to the replacement KPlotObject
		///      </param></remarks>		<short>    Replace an item in the KPlotObject list.</short>
		public void ReplacePlotObject(int i, KPlotObject o) {
			interceptor.Invoke("replacePlotObject$#", "replacePlotObject(int, KPlotObject*)", typeof(void), typeof(int), i, typeof(KPlotObject), o);
		}
		/// <remarks>
		/// </remarks>		<return> whether the antialiasing is active
		///  Antialiasing is not active by default.
		///      </return>
		/// 		<short>   </short>
		public bool Antialiasing() {
			return (bool) interceptor.Invoke("antialiasing", "antialiasing() const", typeof(bool));
		}
		/// <remarks>
		///  Toggle antialiased drawing.
		/// <param> name="b" if true, the plot graphics will be antialiased.
		///      </param></remarks>		<short>    Toggle antialiased drawing.</short>
		public void SetAntialiasing(bool b) {
			interceptor.Invoke("setAntialiasing$", "setAntialiasing(bool)", typeof(void), typeof(bool), b);
		}
		/// <remarks>
		/// </remarks>		<short> Revert all four padding values to -1, so that they will be   automatically determined.      </short>
		public void SetDefaultPaddings() {
			interceptor.Invoke("setDefaultPaddings", "setDefaultPaddings()", typeof(void));
		}
		/// <remarks>
		/// <param> name="p" the point to be converted, in natural data units
		/// </param></remarks>		<return> the coordinate in the pixel coordinate system
		///      </return>
		/// 		<short> Map a coordinate @param p from the data rect to the physical   pixel rect.  Used mainly when drawing. </short>
		public QPointF MapToWidget(QPointF p) {
			return (QPointF) interceptor.Invoke("mapToWidget#", "mapToWidget(const QPointF&) const", typeof(QPointF), typeof(QPointF), p);
		}
		/// <remarks>
		///  Indicate that object labels should try to avoid the given 
		///  rectangle in the plot.  The rectangle is in pixel coordinates.
		///  @note You should not normally call this function directly.
		///  It is called by KPlotObject when points, bars and labels are drawn.
		/// <param> name="r" the rectangle defining the region in the plot that 
		///  text labels should avoid (in pixel coordinates)
		/// </param><param> name="value" Allows you to determine how strongly the rectangle 
		///  should be avoided.  Larger values are avoided more strongly.
		///      </param></remarks>		<short>    Indicate that object labels should try to avoid the given   rectangle in the plot.</short>
		public void MaskRect(QRectF r, float value) {
			interceptor.Invoke("maskRect#$", "maskRect(const QRectF&, float)", typeof(void), typeof(QRectF), r, typeof(float), value);
		}
		public void MaskRect(QRectF r) {
			interceptor.Invoke("maskRect#", "maskRect(const QRectF&)", typeof(void), typeof(QRectF), r);
		}
		/// <remarks>
		///  Indicate that object labels should try to avoid the line 
		///  joining the two given points (in pixel coordinates).
		///  @note You should not normally call this function directly.
		///  It is called by KPlotObject when lines are drawn in the plot.
		/// <param> name="p1" the starting point for the line
		/// </param><param> name="p2" the ending point for the line
		/// </param><param> name="value" Allows you to determine how strongly the line
		///  should be avoided.  Larger values are avoided more strongly.
		///      </param></remarks>		<short>    Indicate that object labels should try to avoid the line   joining the two given points (in pixel coordinates).</short>
		public void MaskAlongLine(QPointF p1, QPointF p2, float value) {
			interceptor.Invoke("maskAlongLine##$", "maskAlongLine(const QPointF&, const QPointF&, float)", typeof(void), typeof(QPointF), p1, typeof(QPointF), p2, typeof(float), value);
		}
		public void MaskAlongLine(QPointF p1, QPointF p2) {
			interceptor.Invoke("maskAlongLine##", "maskAlongLine(const QPointF&, const QPointF&)", typeof(void), typeof(QPointF), p1, typeof(QPointF), p2);
		}
		/// <remarks>
		///  Place an object label optimally in the plot.  This function will
		///  attempt to place the label as close as it can to the point to which 
		///  the label belongs, while avoiding overlap with regions of the plot 
		///  that have been masked. 
		///  @note You should not normally call this function directly.
		///  It is called internally in KPlotObject.Draw().
		/// <param> name="painter" Pointer to the painter on which to draw the label
		/// </param><param> name="pp" pointer to the KPlotPoint whose label is to be drawn.
		///      </param></remarks>		<short>    Place an object label optimally in the plot.</short>
		public void PlaceLabel(QPainter painter, KPlotPoint pp) {
			interceptor.Invoke("placeLabel##", "placeLabel(QPainter*, KPlotPoint*)", typeof(void), typeof(QPainter), painter, typeof(KPlotPoint), pp);
		}
		/// <remarks>
		/// </remarks>		<return> the axis of the specified <code>type</code>, or 0 if no axis has been set.
		///  @sa Axis
		///      </return>
		/// 		<short>   </short>
		public KPlotAxis axis(KPlotWidget.Axis type) {
			return (KPlotAxis) interceptor.Invoke("axis$", "axis(KPlotWidget::Axis)", typeof(KPlotAxis), typeof(KPlotWidget.Axis), type);
		}
		/// <remarks>
		///  Toggle whether grid lines are drawn at major tickmarks.
		/// <param> name="show" if true, grid lines will be drawn.
		///  @sa isGridShown()
		///      </param></remarks>		<short>    Toggle whether grid lines are drawn at major tickmarks.</short>
		[Q_SLOT("void setShowGrid(bool)")]
		public void SetShowGrid(bool show) {
			interceptor.Invoke("setShowGrid$", "setShowGrid(bool)", typeof(void), typeof(bool), show);
		}
		/// <remarks>
		///  Toggle the display of a tooltip for point objects.
		/// <param> name="show" whether show the tooltip.
		///  @sa isObjectToolTipShown()
		///      </param></remarks>		<short>    Toggle the display of a tooltip for point objects.</short>
		[Q_SLOT("void setObjectToolTipShown(bool)")]
		public void SetObjectToolTipShown(bool show) {
			interceptor.Invoke("setObjectToolTipShown$", "setObjectToolTipShown(bool)", typeof(void), typeof(bool), show);
		}
		/// <remarks>
		///  Generic event handler.
		///      </remarks>		<short>    Generic event handler.</short>
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		/// <remarks>
		///  The paint event handler, executed when update() or repaint() is called.
		///      </remarks>		<short>    The paint event handler, executed when update() or repaint() is called.</short>
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		/// <remarks>
		///  The resize event handler, called when the widget is resized.
		///      </remarks>		<short>    The resize event handler, called when the widget is resized.</short>
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		/// <remarks>
		///  Draws the plot axes and axis labels.
		///  to draw the widget with axes and all objects.
		/// <param> name="p" pointer to the painter on which we are drawing
		///      </param></remarks>		<short>    Draws the plot axes and axis labels.</short>
		[SmokeMethod("drawAxes(QPainter*)")]
		protected virtual void DrawAxes(QPainter p) {
			interceptor.Invoke("drawAxes#", "drawAxes(QPainter*)", typeof(void), typeof(QPainter), p);
		}
		/// <remarks>
		///  Synchronize the PixRect with the current widget size and 
		///  padding settings.
		///      </remarks>		<short>    Synchronize the PixRect with the current widget size and   padding settings.</short>
		protected void SetPixRect() {
			interceptor.Invoke("setPixRect", "setPixRect()", typeof(void));
		}
		/// <remarks>
		/// <param> name="p" The screen position from which to check for plot points.
		///      </param></remarks>		<return> a list of points in the plot which are within 4 pixels
		///  of the screen position given as an argument.
		/// </return>
		/// 		<short>   </short>
		protected List<KPlotPoint> PointsUnderPoint(QPoint p) {
			return (List<KPlotPoint>) interceptor.Invoke("pointsUnderPoint#", "pointsUnderPoint(const QPoint&) const", typeof(List<KPlotPoint>), typeof(QPoint), p);
		}
		~KPlotWidget() {
			interceptor.Invoke("~KPlotWidget", "~KPlotWidget()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPlotWidget", "~KPlotWidget()", typeof(void));
		}
		protected new IKPlotWidgetSignals Emit {
			get { return (IKPlotWidgetSignals) Q_EMIT; }
		}
	}

	public interface IKPlotWidgetSignals : IQFrameSignals {
	}
}
