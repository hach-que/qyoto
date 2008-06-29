//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks> See <see cref="IWebContentSignals"></see> for signals emitted by WebContent
	/// </remarks>
	[SmokeClass("Plasma::WebContent")]
	public class WebContent : QGraphicsWidget, IDisposable {
 		protected WebContent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(WebContent), this);
		}
		public WebContent(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("WebContent#", "WebContent(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), parent);
		}
		public WebContent() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("WebContent", "WebContent()", typeof(void));
		}
		/// <remarks>
		///  Sets the URL to display. Loading may happen asynchronously.
		/// <param> name="url" the location of the content to load.
		///          </param></remarks>		<short>    Sets the URL to display.</short>
		public void SetUrl(QUrl url) {
			interceptor.Invoke("setUrl#", "setUrl(const QUrl&)", typeof(void), typeof(QUrl), url);
		}
		/// <remarks>
		///  Sets the html to be shown along with a base URL to be used
		///  to resolve relative references.
		/// <param> name="html" the html (in utf8) to display in the content area
		/// </param><param> name="baseUrl" the base url for relative references
		///          </param></remarks>		<short>    Sets the html to be shown along with a base URL to be used  to resolve relative references.</short>
		public void SetHtml(QByteArray html, QUrl baseUrl) {
			interceptor.Invoke("setHtml##", "setHtml(const QByteArray&, const QUrl&)", typeof(void), typeof(QByteArray), html, typeof(QUrl), baseUrl);
		}
		public void SetHtml(QByteArray html) {
			interceptor.Invoke("setHtml#", "setHtml(const QByteArray&)", typeof(void), typeof(QByteArray), html);
		}
		/// <remarks>
		///  Sets the html to be shown along with a base URL to be used
		///  to resolve relative references.
		/// <param> name="html" the html (in utf8) to display in the content area
		/// </param><param> name="baseUrl" the base url for relative references
		///          </param></remarks>		<short>    Sets the html to be shown along with a base URL to be used  to resolve relative references.</short>
		public void SetHtml(string html, QUrl baseUrl) {
			interceptor.Invoke("setHtml$#", "setHtml(const QString&, const QUrl&)", typeof(void), typeof(string), html, typeof(QUrl), baseUrl);
		}
		public void SetHtml(string html) {
			interceptor.Invoke("setHtml$", "setHtml(const QString&)", typeof(void), typeof(string), html);
		}
		/// <remarks>
		///  Reimplementation
		///          </remarks>		<short>    Reimplementation          </short>
		public new QRectF Geometry() {
			return (QRectF) interceptor.Invoke("geometry", "geometry() const", typeof(QRectF));
		}
		/// <remarks>
		///  Sets the page to use in this item. The owner of the webpage remains,
		///  however if this WebContent object is the owner of the current page,
		///  then the current page is deleted
		/// <param> name="page" the page to set in this view
		///          </param></remarks>		<short>    Sets the page to use in this item.</short>
		public void SetPage(QWebPage page) {
			interceptor.Invoke("setPage#", "setPage(QWebPage*)", typeof(void), typeof(QWebPage), page);
		}
		/// <remarks>
		///  The QWebPage associated with this item. Useful when more
		///  of the features of the full QWebPage object need to be accessed.
		///          </remarks>		<short>    The QWebPage associated with this item.</short>
		public QWebPage Page() {
			return (QWebPage) interceptor.Invoke("page", "page() const", typeof(QWebPage));
		}
		/// <remarks>
		///  The main web frame associated with this item.
		///          </remarks>		<short>    The main web frame associated with this item.</short>
		public QWebFrame MainFrame() {
			return (QWebFrame) interceptor.Invoke("mainFrame", "mainFrame() const", typeof(QWebFrame));
		}
		/// <remarks>
		///  Reimplementation
		///          </remarks>		<short>    Reimplementation          </short>
		[SmokeMethod("setGeometry(const QRectF&)")]
		public override void SetGeometry(QRectF geometry) {
			interceptor.Invoke("setGeometry#", "setGeometry(const QRectF&)", typeof(void), typeof(QRectF), geometry);
		}
		/// <remarks>
		///  Reimplementation
		///          </remarks>		<short>    Reimplementation          </short>
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*)")]
		protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			interceptor.Invoke("paint##", "paint(QPainter*, const QStyleOptionGraphicsItem*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option);
		}
		[SmokeMethod("mouseMoveEvent(QGraphicsSceneMouseEvent*)")]
		protected override void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QGraphicsSceneMouseEvent*)")]
		protected override void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)")]
		protected override void MouseDoubleClickEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QGraphicsSceneMouseEvent*)")]
		protected override void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("contextMenuEvent(QGraphicsSceneContextMenuEvent*)")]
		protected override void ContextMenuEvent(QGraphicsSceneContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QGraphicsSceneContextMenuEvent*)", typeof(void), typeof(QGraphicsSceneContextMenuEvent), arg1);
		}
		[SmokeMethod("wheelEvent(QGraphicsSceneWheelEvent*)")]
		protected override void WheelEvent(QGraphicsSceneWheelEvent arg1) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QGraphicsSceneWheelEvent*)", typeof(void), typeof(QGraphicsSceneWheelEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected override void KeyReleaseEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyReleaseEvent#", "keyReleaseEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("dragEnterEvent(QGraphicsSceneDragDropEvent*)")]
		protected override void DragEnterEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("dragLeaveEvent(QGraphicsSceneDragDropEvent*)")]
		protected override void DragLeaveEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("dragMoveEvent(QGraphicsSceneDragDropEvent*)")]
		protected override void DragMoveEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("dropEvent(QGraphicsSceneDragDropEvent*)")]
		protected override void DropEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		~WebContent() {
			interceptor.Invoke("~WebContent", "~WebContent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~WebContent", "~WebContent()", typeof(void));
		}
		protected new IWebContentSignals Emit {
			get { return (IWebContentSignals) Q_EMIT; }
		}
	}

	public interface IWebContentSignals : IQGraphicsWidgetSignals {
		/// <remarks>
		///  During loading progress, this signal is emitted. The values
		///  are always between 0 and 100, inclusive.
		/// <param> name="percent" the estimated amount the loading is complete
		///          </param></remarks>		<short>    During loading progress, this signal is emitted.</short>
		[Q_SIGNAL("void loadProgress(int)")]
		void LoadProgress(int percent);
		/// <remarks>
		///  This signal is emitted when loading is completed.
		/// <param> name="success" true if the content was loaded successfully,
		///                 otherwise false
		///          </param></remarks>		<short>    This signal is emitted when loading is completed.</short>
		[Q_SIGNAL("void loadDone(bool)")]
		void LoadDone(bool success);
	}
}
