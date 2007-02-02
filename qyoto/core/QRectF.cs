//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QRectF")]
	public class QRectF : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QRectF(Type dummy) {}
		interface IQRectFProxy {
			QRectF op_or(QRectF lhs, QRectF r);
			QRectF op_and(QRectF lhs, QRectF r);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRectF), this);
			_interceptor = (QRectF) realProxy.GetTransparentProxy();
		}
		private QRectF ProxyQRectF() {
			return (QRectF) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRectF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRectFProxy), null);
			_staticInterceptor = (IQRectFProxy) realProxy.GetTransparentProxy();
		}
		private static IQRectFProxy StaticQRectF() {
			return (IQRectFProxy) _staticInterceptor;
		}

		public QRectF() : this((Type) null) {
			CreateProxy();
			NewQRectF();
		}
		[SmokeMethod("QRectF", "()")]
		private void NewQRectF() {
			ProxyQRectF().NewQRectF();
		}
		public QRectF(QPointF topleft, QSizeF size) : this((Type) null) {
			CreateProxy();
			NewQRectF(topleft,size);
		}
		[SmokeMethod("QRectF##", "(const QPointF&, const QSizeF&)")]
		private void NewQRectF(QPointF topleft, QSizeF size) {
			ProxyQRectF().NewQRectF(topleft,size);
		}
		public QRectF(double left, double top, double width, double height) : this((Type) null) {
			CreateProxy();
			NewQRectF(left,top,width,height);
		}
		[SmokeMethod("QRectF$$$$", "(qreal, qreal, qreal, qreal)")]
		private void NewQRectF(double left, double top, double width, double height) {
			ProxyQRectF().NewQRectF(left,top,width,height);
		}
		public QRectF(QRect rect) : this((Type) null) {
			CreateProxy();
			NewQRectF(rect);
		}
		[SmokeMethod("QRectF#", "(const QRect&)")]
		private void NewQRectF(QRect rect) {
			ProxyQRectF().NewQRectF(rect);
		}
		[SmokeMethod("isNull", "() const")]
		public bool IsNull() {
			return ProxyQRectF().IsNull();
		}
		[SmokeMethod("isEmpty", "() const")]
		public bool IsEmpty() {
			return ProxyQRectF().IsEmpty();
		}
		[SmokeMethod("isValid", "() const")]
		public bool IsValid() {
			return ProxyQRectF().IsValid();
		}
		[SmokeMethod("normalized", "() const")]
		public QRectF Normalized() {
			return ProxyQRectF().Normalized();
		}
		[SmokeMethod("left", "() const")]
		public double Left() {
			return ProxyQRectF().Left();
		}
		[SmokeMethod("top", "() const")]
		public double Top() {
			return ProxyQRectF().Top();
		}
		[SmokeMethod("right", "() const")]
		public double Right() {
			return ProxyQRectF().Right();
		}
		[SmokeMethod("bottom", "() const")]
		public double Bottom() {
			return ProxyQRectF().Bottom();
		}
		[SmokeMethod("x", "() const")]
		public double X() {
			return ProxyQRectF().X();
		}
		[SmokeMethod("y", "() const")]
		public double Y() {
			return ProxyQRectF().Y();
		}
		[SmokeMethod("setLeft$", "(qreal)")]
		public void SetLeft(double pos) {
			ProxyQRectF().SetLeft(pos);
		}
		[SmokeMethod("setTop$", "(qreal)")]
		public void SetTop(double pos) {
			ProxyQRectF().SetTop(pos);
		}
		[SmokeMethod("setRight$", "(qreal)")]
		public void SetRight(double pos) {
			ProxyQRectF().SetRight(pos);
		}
		[SmokeMethod("setBottom$", "(qreal)")]
		public void SetBottom(double pos) {
			ProxyQRectF().SetBottom(pos);
		}
		[SmokeMethod("topLeft", "() const")]
		public QPointF TopLeft() {
			return ProxyQRectF().TopLeft();
		}
		[SmokeMethod("bottomRight", "() const")]
		public QPointF BottomRight() {
			return ProxyQRectF().BottomRight();
		}
		[SmokeMethod("topRight", "() const")]
		public QPointF TopRight() {
			return ProxyQRectF().TopRight();
		}
		[SmokeMethod("bottomLeft", "() const")]
		public QPointF BottomLeft() {
			return ProxyQRectF().BottomLeft();
		}
		[SmokeMethod("center", "() const")]
		public QPointF Center() {
			return ProxyQRectF().Center();
		}
		[SmokeMethod("setTopLeft#", "(const QPointF&)")]
		public void SetTopLeft(QPointF p) {
			ProxyQRectF().SetTopLeft(p);
		}
		[SmokeMethod("setBottomRight#", "(const QPointF&)")]
		public void SetBottomRight(QPointF p) {
			ProxyQRectF().SetBottomRight(p);
		}
		[SmokeMethod("setTopRight#", "(const QPointF&)")]
		public void SetTopRight(QPointF p) {
			ProxyQRectF().SetTopRight(p);
		}
		[SmokeMethod("setBottomLeft#", "(const QPointF&)")]
		public void SetBottomLeft(QPointF p) {
			ProxyQRectF().SetBottomLeft(p);
		}
		[SmokeMethod("moveLeft$", "(qreal)")]
		public void MoveLeft(double pos) {
			ProxyQRectF().MoveLeft(pos);
		}
		[SmokeMethod("moveTop$", "(qreal)")]
		public void MoveTop(double pos) {
			ProxyQRectF().MoveTop(pos);
		}
		[SmokeMethod("moveRight$", "(qreal)")]
		public void MoveRight(double pos) {
			ProxyQRectF().MoveRight(pos);
		}
		[SmokeMethod("moveBottom$", "(qreal)")]
		public void MoveBottom(double pos) {
			ProxyQRectF().MoveBottom(pos);
		}
		[SmokeMethod("moveTopLeft#", "(const QPointF&)")]
		public void MoveTopLeft(QPointF p) {
			ProxyQRectF().MoveTopLeft(p);
		}
		[SmokeMethod("moveBottomRight#", "(const QPointF&)")]
		public void MoveBottomRight(QPointF p) {
			ProxyQRectF().MoveBottomRight(p);
		}
		[SmokeMethod("moveTopRight#", "(const QPointF&)")]
		public void MoveTopRight(QPointF p) {
			ProxyQRectF().MoveTopRight(p);
		}
		[SmokeMethod("moveBottomLeft#", "(const QPointF&)")]
		public void MoveBottomLeft(QPointF p) {
			ProxyQRectF().MoveBottomLeft(p);
		}
		[SmokeMethod("moveCenter#", "(const QPointF&)")]
		public void MoveCenter(QPointF p) {
			ProxyQRectF().MoveCenter(p);
		}
		[SmokeMethod("translate$$", "(qreal, qreal)")]
		public void Translate(double dx, double dy) {
			ProxyQRectF().Translate(dx,dy);
		}
		[SmokeMethod("translate#", "(const QPointF&)")]
		public void Translate(QPointF p) {
			ProxyQRectF().Translate(p);
		}
		[SmokeMethod("translated$$", "(qreal, qreal) const")]
		public QRectF Translated(double dx, double dy) {
			return ProxyQRectF().Translated(dx,dy);
		}
		[SmokeMethod("translated#", "(const QPointF&) const")]
		public QRectF Translated(QPointF p) {
			return ProxyQRectF().Translated(p);
		}
		[SmokeMethod("moveTo$$", "(qreal, qreal)")]
		public void MoveTo(double x, double t) {
			ProxyQRectF().MoveTo(x,t);
		}
		[SmokeMethod("moveTo#", "(const QPointF&)")]
		public void MoveTo(QPointF p) {
			ProxyQRectF().MoveTo(p);
		}
		[SmokeMethod("setRect$$$$", "(qreal, qreal, qreal, qreal)")]
		public void SetRect(double x, double y, double w, double h) {
			ProxyQRectF().SetRect(x,y,w,h);
		}
		// void getRect(qreal* arg1,qreal* arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		[SmokeMethod("setCoords$$$$", "(qreal, qreal, qreal, qreal)")]
		public void SetCoords(double x1, double y1, double x2, double y2) {
			ProxyQRectF().SetCoords(x1,y1,x2,y2);
		}
		// void getCoords(qreal* arg1,qreal* arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		[SmokeMethod("adjust$$$$", "(qreal, qreal, qreal, qreal)")]
		public void Adjust(double x1, double y1, double x2, double y2) {
			ProxyQRectF().Adjust(x1,y1,x2,y2);
		}
		[SmokeMethod("adjusted$$$$", "(qreal, qreal, qreal, qreal) const")]
		public QRectF Adjusted(double x1, double y1, double x2, double y2) {
			return ProxyQRectF().Adjusted(x1,y1,x2,y2);
		}
		[SmokeMethod("size", "() const")]
		public QSizeF Size() {
			return ProxyQRectF().Size();
		}
		[SmokeMethod("width", "() const")]
		public double Width() {
			return ProxyQRectF().Width();
		}
		[SmokeMethod("height", "() const")]
		public double Height() {
			return ProxyQRectF().Height();
		}
		[SmokeMethod("setWidth$", "(qreal)")]
		public void SetWidth(double w) {
			ProxyQRectF().SetWidth(w);
		}
		[SmokeMethod("setHeight$", "(qreal)")]
		public void SetHeight(double h) {
			ProxyQRectF().SetHeight(h);
		}
		[SmokeMethod("setSize#", "(const QSizeF&)")]
		public void SetSize(QSizeF s) {
			ProxyQRectF().SetSize(s);
		}
		[SmokeMethod("operator|#", "(const QRectF&) const")]
		public static QRectF operator|(QRectF lhs, QRectF r) {
			return StaticQRectF().op_or(lhs,r);
		}
		[SmokeMethod("operator&#", "(const QRectF&) const")]
		public static QRectF operator&(QRectF lhs, QRectF r) {
			return StaticQRectF().op_and(lhs,r);
		}
		[SmokeMethod("contains#", "(const QPointF&) const")]
		public bool Contains(QPointF p) {
			return ProxyQRectF().Contains(p);
		}
		[SmokeMethod("contains$$", "(qreal, qreal) const")]
		public bool Contains(double x, double y) {
			return ProxyQRectF().Contains(x,y);
		}
		[SmokeMethod("contains#", "(const QRectF&) const")]
		public bool Contains(QRectF r) {
			return ProxyQRectF().Contains(r);
		}
		[SmokeMethod("unite#", "(const QRectF&) const")]
		public QRectF Unite(QRectF r) {
			return ProxyQRectF().Unite(r);
		}
		[SmokeMethod("united#", "(const QRectF&) const")]
		public QRectF United(QRectF other) {
			return ProxyQRectF().United(other);
		}
		[SmokeMethod("intersect#", "(const QRectF&) const")]
		public QRectF Intersect(QRectF r) {
			return ProxyQRectF().Intersect(r);
		}
		[SmokeMethod("intersected#", "(const QRectF&) const")]
		public QRectF Intersected(QRectF other) {
			return ProxyQRectF().Intersected(other);
		}
		[SmokeMethod("intersects#", "(const QRectF&) const")]
		public bool Intersects(QRectF r) {
			return ProxyQRectF().Intersects(r);
		}
		[SmokeMethod("toRect", "() const")]
		public QRect ToRect() {
			return ProxyQRectF().ToRect();
		}
		~QRectF() {
			DisposeQRectF();
		}
		public void Dispose() {
			DisposeQRectF();
		}
		[SmokeMethod("~QRectF", "()")]
		private void DisposeQRectF() {
			ProxyQRectF().DisposeQRectF();
		}
	}
}
