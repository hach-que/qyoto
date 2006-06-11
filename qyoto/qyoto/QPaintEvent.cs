//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QPaintEvent")]
	public class QPaintEvent : QEvent, IDisposable {
 		protected QPaintEvent(Type dummy) : base((Type) null) {}
		interface IQPaintEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPaintEvent), this);
			_interceptor = (QPaintEvent) realProxy.GetTransparentProxy();
		}
		private QPaintEvent ProxyQPaintEvent() {
			return (QPaintEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPaintEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPaintEventProxy), null);
			_staticInterceptor = (IQPaintEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQPaintEventProxy StaticQPaintEvent() {
			return (IQPaintEventProxy) _staticInterceptor;
		}

		public QPaintEvent(QRegion paintRegion) : this((Type) null) {
			CreateProxy();
			NewQPaintEvent(paintRegion);
		}
		[SmokeMethod("QPaintEvent(const QRegion&)")]
		private void NewQPaintEvent(QRegion paintRegion) {
			ProxyQPaintEvent().NewQPaintEvent(paintRegion);
		}
		public QPaintEvent(QRect paintRect) : this((Type) null) {
			CreateProxy();
			NewQPaintEvent(paintRect);
		}
		[SmokeMethod("QPaintEvent(const QRect&)")]
		private void NewQPaintEvent(QRect paintRect) {
			ProxyQPaintEvent().NewQPaintEvent(paintRect);
		}
		[SmokeMethod("rect() const")]
		public QRect Rect() {
			return ProxyQPaintEvent().Rect();
		}
		[SmokeMethod("region() const")]
		public QRegion Region() {
			return ProxyQPaintEvent().Region();
		}
		~QPaintEvent() {
			DisposeQPaintEvent();
		}
		public new void Dispose() {
			DisposeQPaintEvent();
		}
		[SmokeMethod("~QPaintEvent()")]
		private void DisposeQPaintEvent() {
			ProxyQPaintEvent().DisposeQPaintEvent();
		}
	}
}
