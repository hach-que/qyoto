//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks>
	///  @brief A theme aware image-centric SVG class
	///  Plasma.Svg provides a class for rendering SVG images to a QPainter in a
	///  convenient manner. Unless an absolute path to a file is provided, it loads
	///  the SVG document using Plasma.Theme. It also provides a number of internal
	///  optimizations to help lower the cost of painting SVGs, such as caching.
	///  See <see cref="ISvgSignals"></see> for signals emitted by Svg
	/// </remarks>		<short>    @brief A theme aware image-centric SVG class </short>
	[SmokeClass("Plasma::Svg")]
	public class Svg : QObject, IDisposable {
 		protected Svg(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Svg), this);
		}
		[Q_PROPERTY("QSize", "size")]
		public QSize Size {
			get { return (QSize) interceptor.Invoke("size", "size()", typeof(QSize)); }
		}
		[Q_PROPERTY("bool", "multipleImages")]
		public bool MultipleImages {
			get { return (bool) interceptor.Invoke("containsMultipleImages", "containsMultipleImages()", typeof(bool)); }
			set { interceptor.Invoke("setContainsMultipleImages$", "setContainsMultipleImages(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "filePath")]
		public string FilePath {
			get { return (string) interceptor.Invoke("imagePath", "imagePath()", typeof(string)); }
			set { interceptor.Invoke("setImagePath$", "setImagePath(QString)", typeof(void), typeof(string), value); }
		}
		/// <remarks>
		///  Constructs an SVG object that implicitly shares and caches rendering
		///  As opposed to QSvgRenderer, which this class uses internally,
		///  Plasma.Svg represents an image generated from an SVG. As such, it
		///  has a related size and transform matrix (the latter being provided
		///  by the painter used to paint the image).
		///  The size is initialized to be the SVG's native size.
		///  @arg parent options QObject to parent this to
		///  @related Plasma.Theme
		///          </remarks>		<short>    Constructs an SVG object that implicitly shares and caches rendering  As opposed to QSvgRenderer, which this class uses internally,  Plasma.Svg represents an image generated from an SVG.</short>
		public Svg(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Svg#", "Svg(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public Svg() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Svg", "Svg()", typeof(void));
		}
		/// <remarks>
		///  Paints the SVG represented by this object
		///  @arg painter the QPainter to use
		///  @arg point the position to start drawing; the entire svg will be
		///       drawn starting at this point.
		///          </remarks>		<short>    Paints the SVG represented by this object  @arg painter the QPainter to use  @arg point the position to start drawing; the entire svg will be       drawn starting at this point.</short>
		public void Paint(QPainter painter, QPointF point, string elementID) {
			interceptor.Invoke("paint##$", "paint(QPainter*, const QPointF&, const QString&)", typeof(void), typeof(QPainter), painter, typeof(QPointF), point, typeof(string), elementID);
		}
		public void Paint(QPainter painter, QPointF point) {
			interceptor.Invoke("paint##", "paint(QPainter*, const QPointF&)", typeof(void), typeof(QPainter), painter, typeof(QPointF), point);
		}
		/// <remarks>
		///  Paints the SVG represented by this object
		///  @arg painter the QPainter to use
		///  @arg x the horizontal coordinate to start painting from
		///  @arg y the vertical coordinate to start painting from
		///          </remarks>		<short>    Paints the SVG represented by this object  @arg painter the QPainter to use  @arg x the horizontal coordinate to start painting from  @arg y the vertical coordinate to start painting from          </short>
		public void Paint(QPainter painter, int x, int y, string elementID) {
			interceptor.Invoke("paint#$$$", "paint(QPainter*, int, int, const QString&)", typeof(void), typeof(QPainter), painter, typeof(int), x, typeof(int), y, typeof(string), elementID);
		}
		public void Paint(QPainter painter, int x, int y) {
			interceptor.Invoke("paint#$$", "paint(QPainter*, int, int)", typeof(void), typeof(QPainter), painter, typeof(int), x, typeof(int), y);
		}
		/// <remarks>
		///  Paints the SVG represented by this object
		///  @arg painter the QPainter to use
		///  @arg rect the rect to draw into; if small than the current size
		///            of the 
		///       drawn starting at this point.
		///          </remarks>		<short>    Paints the SVG represented by this object  @arg painter the QPainter to use  @arg rect the rect to draw into; if small than the current size            of the        drawn starting at this point.</short>
		public void Paint(QPainter painter, QRectF rect, string elementID) {
			interceptor.Invoke("paint##$", "paint(QPainter*, const QRectF&, const QString&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect, typeof(string), elementID);
		}
		public void Paint(QPainter painter, QRectF rect) {
			interceptor.Invoke("paint##", "paint(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect);
		}
		/// <remarks>
		///  Resizes the rendered image. Rendering will actually take place on
		///  the next call to paint.
		///  @arg width the new width
		///  @arg height the new height
		/// </remarks>		<short>    Resizes the rendered image.</short>
		public void Resize(double width, double height) {
			interceptor.Invoke("resize$$", "resize(qreal, qreal)", typeof(void), typeof(double), width, typeof(double), height);
		}
		/// <remarks>
		///  Resizes the rendered image. Rendering will actually take place on
		///  the next call to paint.
		///  @arg size the new size of the image
		/// </remarks>		<short>    Resizes the rendered image.</short>
		public void Resize(QSizeF size) {
			interceptor.Invoke("resize#", "resize(const QSizeF&)", typeof(void), typeof(QSizeF), size);
		}
		/// <remarks>
		///  Resizes the rendered image to the natural size of the SVG.
		///  Rendering will actually take place on the next call to paint.
		/// </remarks>		<short>    Resizes the rendered image to the natural size of the SVG.</short>
		public void Resize() {
			interceptor.Invoke("resize", "resize()", typeof(void));
		}
		/// <remarks>
		///  Size of a given element
		///  @arg elementId the id of the element to check
		/// </remarks>		<return> the current size of a given element, given the current size of the Svg
		/// </return>
		/// 		<short>    Size of a given element  @arg elementId the id of the element to check </short>
		public QSize ElementSize(string elementId) {
			return (QSize) interceptor.Invoke("elementSize$", "elementSize(const QString&) const", typeof(QSize), typeof(string), elementId);
		}
		/// <remarks>
		///  The bounding rect of a given element
		///  @arg elementId the id of the element to check
		/// </remarks>		<return> the current rect of a given element, given the current size of the Svg
		/// </return>
		/// 		<short>    The bounding rect of a given element  @arg elementId the id of the element to check </short>
		public QRectF ElementRect(string elementId) {
			return (QRectF) interceptor.Invoke("elementRect$", "elementRect(const QString&) const", typeof(QRectF), typeof(string), elementId);
		}
		/// <remarks>
		///  Check when an element exists in the loaded Svg
		///  @arg elementId the id of the element to check
		/// </remarks>		<return> true if the element is defined in the Svg, otherwise false
		/// </return>
		/// 		<short>    Check when an element exists in the loaded Svg  @arg elementId the id of the element to check </short>
		public bool HasElement(string elementId) {
			return (bool) interceptor.Invoke("hasElement$", "hasElement(const QString&) const", typeof(bool), typeof(string), elementId);
		}
		/// <remarks>
		///  Returns the element (by id) at the given point. An empty string is
		///  returned if no element is at that point.
		///          </remarks>		<short>    Returns the element (by id) at the given point.</short>
		public string ElementAtPoint(QPoint point) {
			return (string) interceptor.Invoke("elementAtPoint#", "elementAtPoint(const QPoint&) const", typeof(string), typeof(QPoint), point);
		}
		/// <remarks>
		/// </remarks>		<return> true if the SVG file exists and the document is valid,
		///          otherwise false. This method can be expensive as it
		///          causes disk access.
		/// </return>
		/// 		<short>   </short>
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		~Svg() {
			interceptor.Invoke("~Svg", "~Svg()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Svg", "~Svg()", typeof(void));
		}
		protected new ISvgSignals Emit {
			get { return (ISvgSignals) Q_EMIT; }
		}
	}

	public interface ISvgSignals : IQObjectSignals {
		[Q_SIGNAL("void repaintNeeded()")]
		void RepaintNeeded();
	}
}
