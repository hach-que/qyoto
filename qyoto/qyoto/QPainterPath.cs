//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QPainterPath")]
	public class QPainterPath : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QPainterPath(Type dummy) {}
		interface IQPainterPathProxy {
			bool op_equals(QPainterPath lhs, QPainterPath other);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPainterPath), this);
			_interceptor = (QPainterPath) realProxy.GetTransparentProxy();
		}
		private QPainterPath ProxyQPainterPath() {
			return (QPainterPath) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPainterPath() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPainterPathProxy), null);
			_staticInterceptor = (IQPainterPathProxy) realProxy.GetTransparentProxy();
		}
		private static IQPainterPathProxy StaticQPainterPath() {
			return (IQPainterPathProxy) _staticInterceptor;
		}

		public enum ElementType {
			MoveToElement = 0,
			LineToElement = 1,
			CurveToElement = 2,
			CurveToDataElement = 3,
		}
		public QPainterPath() : this((Type) null) {
			CreateProxy();
			NewQPainterPath();
		}
		[SmokeMethod("QPainterPath()")]
		private void NewQPainterPath() {
			ProxyQPainterPath().NewQPainterPath();
		}
		public QPainterPath(QPointF startPoint) : this((Type) null) {
			CreateProxy();
			NewQPainterPath(startPoint);
		}
		[SmokeMethod("QPainterPath(const QPointF&)")]
		private void NewQPainterPath(QPointF startPoint) {
			ProxyQPainterPath().NewQPainterPath(startPoint);
		}
		public QPainterPath(QPainterPath other) : this((Type) null) {
			CreateProxy();
			NewQPainterPath(other);
		}
		[SmokeMethod("QPainterPath(const QPainterPath&)")]
		private void NewQPainterPath(QPainterPath other) {
			ProxyQPainterPath().NewQPainterPath(other);
		}
		[SmokeMethod("closeSubpath()")]
		public void CloseSubpath() {
			ProxyQPainterPath().CloseSubpath();
		}
		[SmokeMethod("moveTo(const QPointF&)")]
		public void MoveTo(QPointF p) {
			ProxyQPainterPath().MoveTo(p);
		}
		[SmokeMethod("moveTo(qreal, qreal)")]
		public void MoveTo(double x, double y) {
			ProxyQPainterPath().MoveTo(x,y);
		}
		[SmokeMethod("lineTo(const QPointF&)")]
		public void LineTo(QPointF p) {
			ProxyQPainterPath().LineTo(p);
		}
		[SmokeMethod("lineTo(qreal, qreal)")]
		public void LineTo(double x, double y) {
			ProxyQPainterPath().LineTo(x,y);
		}
		[SmokeMethod("arcTo(const QRectF&, qreal, qreal)")]
		public void ArcTo(QRectF rect, double startAngle, double arcLength) {
			ProxyQPainterPath().ArcTo(rect,startAngle,arcLength);
		}
		[SmokeMethod("arcTo(qreal, qreal, qreal, qreal, qreal, qreal)")]
		public void ArcTo(double x, double y, double w, double h, double startAngle, double arcLength) {
			ProxyQPainterPath().ArcTo(x,y,w,h,startAngle,arcLength);
		}
		[SmokeMethod("cubicTo(const QPointF&, const QPointF&, const QPointF&)")]
		public void CubicTo(QPointF ctrlPt1, QPointF ctrlPt2, QPointF endPt) {
			ProxyQPainterPath().CubicTo(ctrlPt1,ctrlPt2,endPt);
		}
		[SmokeMethod("cubicTo(qreal, qreal, qreal, qreal, qreal, qreal)")]
		public void CubicTo(double ctrlPt1x, double ctrlPt1y, double ctrlPt2x, double ctrlPt2y, double endPtx, double endPty) {
			ProxyQPainterPath().CubicTo(ctrlPt1x,ctrlPt1y,ctrlPt2x,ctrlPt2y,endPtx,endPty);
		}
		[SmokeMethod("quadTo(const QPointF&, const QPointF&)")]
		public void QuadTo(QPointF ctrlPt, QPointF endPt) {
			ProxyQPainterPath().QuadTo(ctrlPt,endPt);
		}
		[SmokeMethod("quadTo(qreal, qreal, qreal, qreal)")]
		public void QuadTo(double ctrlPtx, double ctrlPty, double endPtx, double endPty) {
			ProxyQPainterPath().QuadTo(ctrlPtx,ctrlPty,endPtx,endPty);
		}
		[SmokeMethod("currentPosition() const")]
		public QPointF CurrentPosition() {
			return ProxyQPainterPath().CurrentPosition();
		}
		[SmokeMethod("addRect(const QRectF&)")]
		public void AddRect(QRectF rect) {
			ProxyQPainterPath().AddRect(rect);
		}
		[SmokeMethod("addRect(qreal, qreal, qreal, qreal)")]
		public void AddRect(double x, double y, double w, double h) {
			ProxyQPainterPath().AddRect(x,y,w,h);
		}
		[SmokeMethod("addEllipse(const QRectF&)")]
		public void AddEllipse(QRectF rect) {
			ProxyQPainterPath().AddEllipse(rect);
		}
		[SmokeMethod("addEllipse(qreal, qreal, qreal, qreal)")]
		public void AddEllipse(double x, double y, double w, double h) {
			ProxyQPainterPath().AddEllipse(x,y,w,h);
		}
		[SmokeMethod("addPolygon(const QPolygonF&)")]
		public void AddPolygon(QPolygonF polygon) {
			ProxyQPainterPath().AddPolygon(polygon);
		}
		[SmokeMethod("addText(const QPointF&, const QFont&, const QString&)")]
		public void AddText(QPointF point, QFont f, string text) {
			ProxyQPainterPath().AddText(point,f,text);
		}
		[SmokeMethod("addText(qreal, qreal, const QFont&, const QString&)")]
		public void AddText(double x, double y, QFont f, string text) {
			ProxyQPainterPath().AddText(x,y,f,text);
		}
		[SmokeMethod("addPath(const QPainterPath&)")]
		public void AddPath(QPainterPath path) {
			ProxyQPainterPath().AddPath(path);
		}
		[SmokeMethod("addRegion(const QRegion&)")]
		public void AddRegion(QRegion region) {
			ProxyQPainterPath().AddRegion(region);
		}
		[SmokeMethod("connectPath(const QPainterPath&)")]
		public void ConnectPath(QPainterPath path) {
			ProxyQPainterPath().ConnectPath(path);
		}
		[SmokeMethod("contains(const QPointF&) const")]
		public bool Contains(QPointF pt) {
			return ProxyQPainterPath().Contains(pt);
		}
		[SmokeMethod("contains(const QRectF&) const")]
		public bool Contains(QRectF rect) {
			return ProxyQPainterPath().Contains(rect);
		}
		[SmokeMethod("intersects(const QRectF&) const")]
		public bool Intersects(QRectF rect) {
			return ProxyQPainterPath().Intersects(rect);
		}
		[SmokeMethod("boundingRect() const")]
		public QRectF BoundingRect() {
			return ProxyQPainterPath().BoundingRect();
		}
		[SmokeMethod("controlPointRect() const")]
		public QRectF ControlPointRect() {
			return ProxyQPainterPath().ControlPointRect();
		}
		[SmokeMethod("fillRule() const")]
		public Qt.FillRule FillRule() {
			return ProxyQPainterPath().FillRule();
		}
		[SmokeMethod("setFillRule(Qt::FillRule)")]
		public void SetFillRule(Qt.FillRule fillRule) {
			ProxyQPainterPath().SetFillRule(fillRule);
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQPainterPath().IsEmpty();
		}
		[SmokeMethod("toReversed() const")]
		public QPainterPath ToReversed() {
			return ProxyQPainterPath().ToReversed();
		}
		[SmokeMethod("toSubpathPolygons(const QMatrix&) const")]
		public ArrayList ToSubpathPolygons(QMatrix matrix) {
			return ProxyQPainterPath().ToSubpathPolygons(matrix);
		}
		[SmokeMethod("toSubpathPolygons() const")]
		public ArrayList ToSubpathPolygons() {
			return ProxyQPainterPath().ToSubpathPolygons();
		}
		[SmokeMethod("toFillPolygons(const QMatrix&) const")]
		public ArrayList ToFillPolygons(QMatrix matrix) {
			return ProxyQPainterPath().ToFillPolygons(matrix);
		}
		[SmokeMethod("toFillPolygons() const")]
		public ArrayList ToFillPolygons() {
			return ProxyQPainterPath().ToFillPolygons();
		}
		[SmokeMethod("toFillPolygon(const QMatrix&) const")]
		public QPolygonF ToFillPolygon(QMatrix matrix) {
			return ProxyQPainterPath().ToFillPolygon(matrix);
		}
		[SmokeMethod("toFillPolygon() const")]
		public QPolygonF ToFillPolygon() {
			return ProxyQPainterPath().ToFillPolygon();
		}
		[SmokeMethod("elementCount() const")]
		public int ElementCount() {
			return ProxyQPainterPath().ElementCount();
		}
		// const QPainterPath::Element& elementAt(int arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator==(const QPainterPath&) const")]
		public static bool operator==(QPainterPath lhs, QPainterPath other) {
			return StaticQPainterPath().op_equals(lhs,other);
		}
		public static bool operator!=(QPainterPath lhs, QPainterPath other) {
			return !StaticQPainterPath().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QPainterPath)) { return false; }
			return this == (QPainterPath) o;
		}
		public override int GetHashCode() {
			return ProxyQPainterPath().GetHashCode();
		}
		~QPainterPath() {
			DisposeQPainterPath();
		}
		public void Dispose() {
			DisposeQPainterPath();
		}
		[SmokeMethod("~QPainterPath()")]
		private void DisposeQPainterPath() {
			ProxyQPainterPath().DisposeQPainterPath();
		}
	}
}
