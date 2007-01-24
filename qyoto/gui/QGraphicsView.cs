//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QGraphicsView")]
	public class QGraphicsView : QAbstractScrollArea, IDisposable {
 		protected QGraphicsView(Type dummy) : base((Type) null) {}
		interface IQGraphicsViewProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsView), this);
			_interceptor = (QGraphicsView) realProxy.GetTransparentProxy();
		}
		private QGraphicsView ProxyQGraphicsView() {
			return (QGraphicsView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsViewProxy), null);
			_staticInterceptor = (IQGraphicsViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsViewProxy StaticQGraphicsView() {
			return (IQGraphicsViewProxy) _staticInterceptor;
		}

		public enum ViewportAnchor {
			NoAnchor = 0,
			AnchorViewCenter = 1,
			AnchorUnderMouse = 2,
		}
		public enum CacheModeFlag {
			CacheNone = 0x0,
			CacheBackground = 0x1,
		}
		public enum DragMode {
			NoDrag = 0,
			ScrollHandDrag = 1,
			RubberBandDrag = 2,
		}
		public QBrush BackgroundBrush {
			get {
				return Property("backgroundBrush").Value<QBrush>();
			}
			set {
				SetProperty("backgroundBrush", QVariant.FromValue<QBrush>(value));
			}
		}
		public QBrush ForegroundBrush {
			get {
				return Property("foregroundBrush").Value<QBrush>();
			}
			set {
				SetProperty("foregroundBrush", QVariant.FromValue<QBrush>(value));
			}
		}
		public bool Interactive {
			get {
				return Property("interactive").Value<bool>();
			}
			set {
				SetProperty("interactive", QVariant.FromValue<bool>(value));
			}
		}
		public QRectF SceneRect {
			get {
				return Property("sceneRect").Value<QRectF>();
			}
			set {
				SetProperty("sceneRect", QVariant.FromValue<QRectF>(value));
			}
		}
		public int Alignment {
			get {
				return Property("alignment").Value<int>();
			}
			set {
				SetProperty("alignment", QVariant.FromValue<int>(value));
			}
		}
		public int RenderHints {
			get {
				return Property("renderHints").Value<int>();
			}
			set {
				SetProperty("renderHints", QVariant.FromValue<int>(value));
			}
		}
		public int CacheMode {
			get {
				return Property("cacheMode").Value<int>();
			}
			set {
				SetProperty("cacheMode", QVariant.FromValue<int>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QGraphicsView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsView(parent);
		}
		[SmokeMethod("QGraphicsView(QWidget*)")]
		private void NewQGraphicsView(QWidget parent) {
			ProxyQGraphicsView().NewQGraphicsView(parent);
		}
		public QGraphicsView() : this((Type) null) {
			CreateProxy();
			NewQGraphicsView();
		}
		[SmokeMethod("QGraphicsView()")]
		private void NewQGraphicsView() {
			ProxyQGraphicsView().NewQGraphicsView();
		}
		public QGraphicsView(QGraphicsScene scene, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsView(scene,parent);
		}
		[SmokeMethod("QGraphicsView(QGraphicsScene*, QWidget*)")]
		private void NewQGraphicsView(QGraphicsScene scene, QWidget parent) {
			ProxyQGraphicsView().NewQGraphicsView(scene,parent);
		}
		public QGraphicsView(QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsView(scene);
		}
		[SmokeMethod("QGraphicsView(QGraphicsScene*)")]
		private void NewQGraphicsView(QGraphicsScene scene) {
			ProxyQGraphicsView().NewQGraphicsView(scene);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQGraphicsView().SizeHint();
		}
		[SmokeMethod("setRenderHint(QPainter::RenderHint, bool)")]
		public void SetRenderHint(QPainter.RenderHint hint, bool enabled) {
			ProxyQGraphicsView().SetRenderHint(hint,enabled);
		}
		[SmokeMethod("setRenderHint(QPainter::RenderHint)")]
		public void SetRenderHint(QPainter.RenderHint hint) {
			ProxyQGraphicsView().SetRenderHint(hint);
		}
		[SmokeMethod("resetCachedContent()")]
		public void ResetCachedContent() {
			ProxyQGraphicsView().ResetCachedContent();
		}
		[SmokeMethod("isInteractive() const")]
		public bool IsInteractive() {
			return ProxyQGraphicsView().IsInteractive();
		}
		[SmokeMethod("scene() const")]
		public QGraphicsScene Scene() {
			return ProxyQGraphicsView().Scene();
		}
		[SmokeMethod("setScene(QGraphicsScene*)")]
		public void SetScene(QGraphicsScene scene) {
			ProxyQGraphicsView().SetScene(scene);
		}
		[SmokeMethod("setSceneRect(qreal, qreal, qreal, qreal)")]
		public void SetSceneRect(double x, double y, double w, double h) {
			ProxyQGraphicsView().SetSceneRect(x,y,w,h);
		}
		[SmokeMethod("matrix() const")]
		public QMatrix Matrix() {
			return ProxyQGraphicsView().Matrix();
		}
		[SmokeMethod("setMatrix(const QMatrix&, bool)")]
		public void SetMatrix(QMatrix matrix, bool combine) {
			ProxyQGraphicsView().SetMatrix(matrix,combine);
		}
		[SmokeMethod("setMatrix(const QMatrix&)")]
		public void SetMatrix(QMatrix matrix) {
			ProxyQGraphicsView().SetMatrix(matrix);
		}
		[SmokeMethod("resetMatrix()")]
		public void ResetMatrix() {
			ProxyQGraphicsView().ResetMatrix();
		}
		[SmokeMethod("rotate(qreal)")]
		public void Rotate(double angle) {
			ProxyQGraphicsView().Rotate(angle);
		}
		[SmokeMethod("scale(qreal, qreal)")]
		public void Scale(double sx, double sy) {
			ProxyQGraphicsView().Scale(sx,sy);
		}
		[SmokeMethod("shear(qreal, qreal)")]
		public void Shear(double sh, double sv) {
			ProxyQGraphicsView().Shear(sh,sv);
		}
		[SmokeMethod("translate(qreal, qreal)")]
		public void Translate(double dx, double dy) {
			ProxyQGraphicsView().Translate(dx,dy);
		}
		[SmokeMethod("centerOn(const QPointF&)")]
		public void CenterOn(QPointF pos) {
			ProxyQGraphicsView().CenterOn(pos);
		}
		[SmokeMethod("centerOn(qreal, qreal)")]
		public void CenterOn(double x, double y) {
			ProxyQGraphicsView().CenterOn(x,y);
		}
		[SmokeMethod("centerOn(const QGraphicsItem*)")]
		public void CenterOn(QGraphicsItem item) {
			ProxyQGraphicsView().CenterOn(item);
		}
		[SmokeMethod("ensureVisible(const QRectF&, int, int)")]
		public void EnsureVisible(QRectF rect, int xmargin, int ymargin) {
			ProxyQGraphicsView().EnsureVisible(rect,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible(const QRectF&, int)")]
		public void EnsureVisible(QRectF rect, int xmargin) {
			ProxyQGraphicsView().EnsureVisible(rect,xmargin);
		}
		[SmokeMethod("ensureVisible(const QRectF&)")]
		public void EnsureVisible(QRectF rect) {
			ProxyQGraphicsView().EnsureVisible(rect);
		}
		[SmokeMethod("ensureVisible(qreal, qreal, qreal, qreal, int, int)")]
		public void EnsureVisible(double x, double y, double w, double h, int xmargin, int ymargin) {
			ProxyQGraphicsView().EnsureVisible(x,y,w,h,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible(qreal, qreal, qreal, qreal, int)")]
		public void EnsureVisible(double x, double y, double w, double h, int xmargin) {
			ProxyQGraphicsView().EnsureVisible(x,y,w,h,xmargin);
		}
		[SmokeMethod("ensureVisible(qreal, qreal, qreal, qreal)")]
		public void EnsureVisible(double x, double y, double w, double h) {
			ProxyQGraphicsView().EnsureVisible(x,y,w,h);
		}
		[SmokeMethod("ensureVisible(const QGraphicsItem*, int, int)")]
		public void EnsureVisible(QGraphicsItem item, int xmargin, int ymargin) {
			ProxyQGraphicsView().EnsureVisible(item,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible(const QGraphicsItem*, int)")]
		public void EnsureVisible(QGraphicsItem item, int xmargin) {
			ProxyQGraphicsView().EnsureVisible(item,xmargin);
		}
		[SmokeMethod("ensureVisible(const QGraphicsItem*)")]
		public void EnsureVisible(QGraphicsItem item) {
			ProxyQGraphicsView().EnsureVisible(item);
		}
		[SmokeMethod("fitInView(const QRectF&, Qt::AspectRatioMode)")]
		public void FitInView(QRectF rect, Qt.AspectRatioMode aspectRadioMode) {
			ProxyQGraphicsView().FitInView(rect,aspectRadioMode);
		}
		[SmokeMethod("fitInView(const QRectF&)")]
		public void FitInView(QRectF rect) {
			ProxyQGraphicsView().FitInView(rect);
		}
		[SmokeMethod("fitInView(qreal, qreal, qreal, qreal, Qt::AspectRatioMode)")]
		public void FitInView(double x, double y, double w, double h, Qt.AspectRatioMode aspectRadioMode) {
			ProxyQGraphicsView().FitInView(x,y,w,h,aspectRadioMode);
		}
		[SmokeMethod("fitInView(qreal, qreal, qreal, qreal)")]
		public void FitInView(double x, double y, double w, double h) {
			ProxyQGraphicsView().FitInView(x,y,w,h);
		}
		[SmokeMethod("fitInView(const QGraphicsItem*, Qt::AspectRatioMode)")]
		public void FitInView(QGraphicsItem item, Qt.AspectRatioMode aspectRadioMode) {
			ProxyQGraphicsView().FitInView(item,aspectRadioMode);
		}
		[SmokeMethod("fitInView(const QGraphicsItem*)")]
		public void FitInView(QGraphicsItem item) {
			ProxyQGraphicsView().FitInView(item);
		}
		[SmokeMethod("render(QPainter*, const QRectF&, const QRect&, Qt::AspectRatioMode)")]
		public void Render(QPainter painter, QRectF target, QRect source, Qt.AspectRatioMode aspectRatioMode) {
			ProxyQGraphicsView().Render(painter,target,source,aspectRatioMode);
		}
		[SmokeMethod("render(QPainter*, const QRectF&, const QRect&)")]
		public void Render(QPainter painter, QRectF target, QRect source) {
			ProxyQGraphicsView().Render(painter,target,source);
		}
		[SmokeMethod("render(QPainter*, const QRectF&)")]
		public void Render(QPainter painter, QRectF target) {
			ProxyQGraphicsView().Render(painter,target);
		}
		[SmokeMethod("render(QPainter*)")]
		public void Render(QPainter painter) {
			ProxyQGraphicsView().Render(painter);
		}
		[SmokeMethod("items() const")]
		public List<QGraphicsItem> Items() {
			return ProxyQGraphicsView().Items();
		}
		[SmokeMethod("items(const QPoint&) const")]
		public List<QGraphicsItem> Items(QPoint pos) {
			return ProxyQGraphicsView().Items(pos);
		}
		[SmokeMethod("items(int, int) const")]
		public List<QGraphicsItem> Items(int x, int y) {
			return ProxyQGraphicsView().Items(x,y);
		}
		[SmokeMethod("items(const QRect&, Qt::ItemSelectionMode) const")]
		public List<QGraphicsItem> Items(QRect rect, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsView().Items(rect,mode);
		}
		[SmokeMethod("items(const QRect&) const")]
		public List<QGraphicsItem> Items(QRect rect) {
			return ProxyQGraphicsView().Items(rect);
		}
		[SmokeMethod("items(const QPolygon&, Qt::ItemSelectionMode) const")]
		public List<QGraphicsItem> Items(QPolygon polygon, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsView().Items(polygon,mode);
		}
		[SmokeMethod("items(const QPolygon&) const")]
		public List<QGraphicsItem> Items(QPolygon polygon) {
			return ProxyQGraphicsView().Items(polygon);
		}
		[SmokeMethod("items(const QPainterPath&, Qt::ItemSelectionMode) const")]
		public List<QGraphicsItem> Items(QPainterPath path, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsView().Items(path,mode);
		}
		[SmokeMethod("items(const QPainterPath&) const")]
		public List<QGraphicsItem> Items(QPainterPath path) {
			return ProxyQGraphicsView().Items(path);
		}
		[SmokeMethod("itemAt(const QPoint&) const")]
		public QGraphicsItem ItemAt(QPoint pos) {
			return ProxyQGraphicsView().ItemAt(pos);
		}
		[SmokeMethod("itemAt(int, int) const")]
		public QGraphicsItem ItemAt(int x, int y) {
			return ProxyQGraphicsView().ItemAt(x,y);
		}
		[SmokeMethod("mapToScene(const QPoint&) const")]
		public QPointF MapToScene(QPoint point) {
			return ProxyQGraphicsView().MapToScene(point);
		}
		[SmokeMethod("mapToScene(const QRect&) const")]
		public QPolygonF MapToScene(QRect rect) {
			return ProxyQGraphicsView().MapToScene(rect);
		}
		[SmokeMethod("mapToScene(const QPolygon&) const")]
		public QPolygonF MapToScene(QPolygon polygon) {
			return ProxyQGraphicsView().MapToScene(polygon);
		}
		[SmokeMethod("mapToScene(const QPainterPath&) const")]
		public QPainterPath MapToScene(QPainterPath path) {
			return ProxyQGraphicsView().MapToScene(path);
		}
		[SmokeMethod("mapFromScene(const QPointF&) const")]
		public QPoint MapFromScene(QPointF point) {
			return ProxyQGraphicsView().MapFromScene(point);
		}
		[SmokeMethod("mapFromScene(const QRectF&) const")]
		public QPolygon MapFromScene(QRectF rect) {
			return ProxyQGraphicsView().MapFromScene(rect);
		}
		[SmokeMethod("mapFromScene(const QPolygonF&) const")]
		public QPolygon MapFromScene(QPolygonF polygon) {
			return ProxyQGraphicsView().MapFromScene(polygon);
		}
		[SmokeMethod("mapFromScene(const QPainterPath&) const")]
		public QPainterPath MapFromScene(QPainterPath path) {
			return ProxyQGraphicsView().MapFromScene(path);
		}
		[SmokeMethod("mapToScene(int, int) const")]
		public QPointF MapToScene(int x, int y) {
			return ProxyQGraphicsView().MapToScene(x,y);
		}
		[SmokeMethod("mapToScene(int, int, int, int) const")]
		public QPolygonF MapToScene(int x, int y, int w, int h) {
			return ProxyQGraphicsView().MapToScene(x,y,w,h);
		}
		[SmokeMethod("mapFromScene(qreal, qreal) const")]
		public QPoint MapFromScene(double x, double y) {
			return ProxyQGraphicsView().MapFromScene(x,y);
		}
		[SmokeMethod("mapFromScene(qreal, qreal, qreal, qreal) const")]
		public QPolygon MapFromScene(double x, double y, double w, double h) {
			return ProxyQGraphicsView().MapFromScene(x,y,w,h);
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		public new QVariant InputMethodQuery(Qt.InputMethodQuery query) {
			return ProxyQGraphicsView().InputMethodQuery(query);
		}
		[SmokeMethod("updateScene(const QList<QRectF>&)")]
		public void UpdateScene(List<QRectF> rects) {
			ProxyQGraphicsView().UpdateScene(rects);
		}
		[SmokeMethod("updateSceneRect(const QRectF&)")]
		public void UpdateSceneRect(QRectF rect) {
			ProxyQGraphicsView().UpdateSceneRect(rect);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQGraphicsView().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQGraphicsView().Tr(s);
		}
		[SmokeMethod("setupViewport(QWidget*)")]
		protected new void SetupViewport(QWidget widget) {
			ProxyQGraphicsView().SetupViewport(widget);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQGraphicsView().Event(arg1);
		}
		[SmokeMethod("viewportEvent(QEvent*)")]
		protected new bool ViewportEvent(QEvent arg1) {
			return ProxyQGraphicsView().ViewportEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected new void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQGraphicsView().ContextMenuEvent(arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected new void DragEnterEvent(QDragEnterEvent arg1) {
			ProxyQGraphicsView().DragEnterEvent(arg1);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected new void DragLeaveEvent(QDragLeaveEvent arg1) {
			ProxyQGraphicsView().DragLeaveEvent(arg1);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected new void DragMoveEvent(QDragMoveEvent arg1) {
			ProxyQGraphicsView().DragMoveEvent(arg1);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected new void DropEvent(QDropEvent arg1) {
			ProxyQGraphicsView().DropEvent(arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected new void FocusInEvent(QFocusEvent arg1) {
			ProxyQGraphicsView().FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected new void FocusOutEvent(QFocusEvent arg1) {
			ProxyQGraphicsView().FocusOutEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQGraphicsView().KeyPressEvent(arg1);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected new void KeyReleaseEvent(QKeyEvent arg1) {
			ProxyQGraphicsView().KeyReleaseEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected new void MouseDoubleClickEvent(QMouseEvent arg1) {
			ProxyQGraphicsView().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQGraphicsView().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQGraphicsView().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQGraphicsView().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent arg1) {
			ProxyQGraphicsView().WheelEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQGraphicsView().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQGraphicsView().ResizeEvent(arg1);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected new void ScrollContentsBy(int dx, int dy) {
			ProxyQGraphicsView().ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQGraphicsView().ShowEvent(arg1);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected new void InputMethodEvent(QInputMethodEvent arg1) {
			ProxyQGraphicsView().InputMethodEvent(arg1);
		}
		[SmokeMethod("drawBackground(QPainter*, const QRectF&)")]
		protected virtual void DrawBackground(QPainter painter, QRectF rect) {
			ProxyQGraphicsView().DrawBackground(painter,rect);
		}
		[SmokeMethod("drawForeground(QPainter*, const QRectF&)")]
		protected virtual void DrawForeground(QPainter painter, QRectF rect) {
			ProxyQGraphicsView().DrawForeground(painter,rect);
		}
		// void drawItems(QPainter* arg1,int arg2,QGraphicsItem** arg3,const QStyleOptionGraphicsItem* arg4); >>>> NOT CONVERTED
		~QGraphicsView() {
			DisposeQGraphicsView();
		}
		public new void Dispose() {
			DisposeQGraphicsView();
		}
		[SmokeMethod("~QGraphicsView()")]
		private void DisposeQGraphicsView() {
			ProxyQGraphicsView().DisposeQGraphicsView();
		}
		protected new IQGraphicsViewSignals Emit() {
			return (IQGraphicsViewSignals) Q_EMIT;
		}
	}

	public interface IQGraphicsViewSignals : IQAbstractScrollAreaSignals {
	}
}
