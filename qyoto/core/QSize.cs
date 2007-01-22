//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSize")]
	public class QSize : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QSize(Type dummy) {}
		interface IQSizeProxy {
			QSize op_mult(QSize lhs, double c);
			QSize op_div(QSize lhs, double c);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSize), this);
			_interceptor = (QSize) realProxy.GetTransparentProxy();
		}
		private QSize ProxyQSize() {
			return (QSize) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSize() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSizeProxy), null);
			_staticInterceptor = (IQSizeProxy) realProxy.GetTransparentProxy();
		}
		private static IQSizeProxy StaticQSize() {
			return (IQSizeProxy) _staticInterceptor;
		}

		public QSize() : this((Type) null) {
			CreateProxy();
			NewQSize();
		}
		[SmokeMethod("QSize()")]
		private void NewQSize() {
			ProxyQSize().NewQSize();
		}
		public QSize(int w, int h) : this((Type) null) {
			CreateProxy();
			NewQSize(w,h);
		}
		[SmokeMethod("QSize(int, int)")]
		private void NewQSize(int w, int h) {
			ProxyQSize().NewQSize(w,h);
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQSize().IsNull();
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQSize().IsEmpty();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQSize().IsValid();
		}
		[SmokeMethod("width() const")]
		public int Width() {
			return ProxyQSize().Width();
		}
		[SmokeMethod("height() const")]
		public int Height() {
			return ProxyQSize().Height();
		}
		[SmokeMethod("setWidth(int)")]
		public void SetWidth(int w) {
			ProxyQSize().SetWidth(w);
		}
		[SmokeMethod("setHeight(int)")]
		public void SetHeight(int h) {
			ProxyQSize().SetHeight(h);
		}
		[SmokeMethod("transpose()")]
		public void Transpose() {
			ProxyQSize().Transpose();
		}
		[SmokeMethod("scale(int, int, Qt::AspectRatioMode)")]
		public void Scale(int w, int h, Qt.AspectRatioMode mode) {
			ProxyQSize().Scale(w,h,mode);
		}
		[SmokeMethod("scale(const QSize&, Qt::AspectRatioMode)")]
		public void Scale(QSize s, Qt.AspectRatioMode mode) {
			ProxyQSize().Scale(s,mode);
		}
		[SmokeMethod("expandedTo(const QSize&) const")]
		public QSize ExpandedTo(QSize arg1) {
			return ProxyQSize().ExpandedTo(arg1);
		}
		[SmokeMethod("boundedTo(const QSize&) const")]
		public QSize BoundedTo(QSize arg1) {
			return ProxyQSize().BoundedTo(arg1);
		}
		[SmokeMethod("rwidth()")]
		public int Rwidth() {
			return ProxyQSize().Rwidth();
		}
		[SmokeMethod("rheight()")]
		public int Rheight() {
			return ProxyQSize().Rheight();
		}
		[SmokeMethod("operator*=(qreal)")]
		public static QSize operator*(QSize lhs, double c) {
			return StaticQSize().op_mult(lhs,c);
		}
		[SmokeMethod("operator/=(qreal)")]
		public static QSize operator/(QSize lhs, double c) {
			return StaticQSize().op_div(lhs,c);
		}
		~QSize() {
			DisposeQSize();
		}
		public void Dispose() {
			DisposeQSize();
		}
		[SmokeMethod("~QSize()")]
		private void DisposeQSize() {
			ProxyQSize().DisposeQSize();
		}
	}
}