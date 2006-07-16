//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QRadialGradient")]
	public class QRadialGradient : QGradient, IDisposable {
 		protected QRadialGradient(Type dummy) : base((Type) null) {}
		interface IQRadialGradientProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRadialGradient), this);
			_interceptor = (QRadialGradient) realProxy.GetTransparentProxy();
		}
		private QRadialGradient ProxyQRadialGradient() {
			return (QRadialGradient) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRadialGradient() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRadialGradientProxy), null);
			_staticInterceptor = (IQRadialGradientProxy) realProxy.GetTransparentProxy();
		}
		private static IQRadialGradientProxy StaticQRadialGradient() {
			return (IQRadialGradientProxy) _staticInterceptor;
		}

		public QRadialGradient() : this((Type) null) {
			CreateProxy();
			NewQRadialGradient();
		}
		[SmokeMethod("QRadialGradient()")]
		private void NewQRadialGradient() {
			ProxyQRadialGradient().NewQRadialGradient();
		}
		public QRadialGradient(QPointF center, double radius, QPointF focalPoint) : this((Type) null) {
			CreateProxy();
			NewQRadialGradient(center,radius,focalPoint);
		}
		[SmokeMethod("QRadialGradient(const QPointF&, qreal, const QPointF&)")]
		private void NewQRadialGradient(QPointF center, double radius, QPointF focalPoint) {
			ProxyQRadialGradient().NewQRadialGradient(center,radius,focalPoint);
		}
		public QRadialGradient(double cx, double cy, double radius, double fx, double fy) : this((Type) null) {
			CreateProxy();
			NewQRadialGradient(cx,cy,radius,fx,fy);
		}
		[SmokeMethod("QRadialGradient(qreal, qreal, qreal, qreal, qreal)")]
		private void NewQRadialGradient(double cx, double cy, double radius, double fx, double fy) {
			ProxyQRadialGradient().NewQRadialGradient(cx,cy,radius,fx,fy);
		}
		public QRadialGradient(QPointF center, double radius) : this((Type) null) {
			CreateProxy();
			NewQRadialGradient(center,radius);
		}
		[SmokeMethod("QRadialGradient(const QPointF&, qreal)")]
		private void NewQRadialGradient(QPointF center, double radius) {
			ProxyQRadialGradient().NewQRadialGradient(center,radius);
		}
		public QRadialGradient(double cx, double cy, double radius) : this((Type) null) {
			CreateProxy();
			NewQRadialGradient(cx,cy,radius);
		}
		[SmokeMethod("QRadialGradient(qreal, qreal, qreal)")]
		private void NewQRadialGradient(double cx, double cy, double radius) {
			ProxyQRadialGradient().NewQRadialGradient(cx,cy,radius);
		}
		[SmokeMethod("center() const")]
		public QPointF Center() {
			return ProxyQRadialGradient().Center();
		}
		[SmokeMethod("setCenter(const QPointF&)")]
		public void SetCenter(QPointF center) {
			ProxyQRadialGradient().SetCenter(center);
		}
		[SmokeMethod("setCenter(qreal, qreal)")]
		public void SetCenter(double x, double y) {
			ProxyQRadialGradient().SetCenter(x,y);
		}
		[SmokeMethod("focalPoint() const")]
		public QPointF FocalPoint() {
			return ProxyQRadialGradient().FocalPoint();
		}
		[SmokeMethod("setFocalPoint(const QPointF&)")]
		public void SetFocalPoint(QPointF focalPoint) {
			ProxyQRadialGradient().SetFocalPoint(focalPoint);
		}
		[SmokeMethod("setFocalPoint(qreal, qreal)")]
		public void SetFocalPoint(double x, double y) {
			ProxyQRadialGradient().SetFocalPoint(x,y);
		}
		[SmokeMethod("radius() const")]
		public double Radius() {
			return ProxyQRadialGradient().Radius();
		}
		[SmokeMethod("setRadius(qreal)")]
		public void SetRadius(double radius) {
			ProxyQRadialGradient().SetRadius(radius);
		}
		~QRadialGradient() {
			DisposeQRadialGradient();
		}
		public void Dispose() {
			DisposeQRadialGradient();
		}
		[SmokeMethod("~QRadialGradient()")]
		private void DisposeQRadialGradient() {
			ProxyQRadialGradient().DisposeQRadialGradient();
		}
	}
}
