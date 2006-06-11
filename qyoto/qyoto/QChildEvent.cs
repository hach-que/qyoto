//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QChildEvent")]
	public class QChildEvent : QEvent, IDisposable {
 		protected QChildEvent(Type dummy) : base((Type) null) {}
		interface IQChildEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QChildEvent), this);
			_interceptor = (QChildEvent) realProxy.GetTransparentProxy();
		}
		private QChildEvent ProxyQChildEvent() {
			return (QChildEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QChildEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQChildEventProxy), null);
			_staticInterceptor = (IQChildEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQChildEventProxy StaticQChildEvent() {
			return (IQChildEventProxy) _staticInterceptor;
		}

		public QChildEvent(QEvent.E_Type type, QObject child) : this((Type) null) {
			CreateProxy();
			NewQChildEvent(type,child);
		}
		[SmokeMethod("QChildEvent(QEvent::Type, QObject*)")]
		private void NewQChildEvent(QEvent.E_Type type, QObject child) {
			ProxyQChildEvent().NewQChildEvent(type,child);
		}
		[SmokeMethod("child() const")]
		public QObject Child() {
			return ProxyQChildEvent().Child();
		}
		[SmokeMethod("added() const")]
		public bool Added() {
			return ProxyQChildEvent().Added();
		}
		[SmokeMethod("polished() const")]
		public bool Polished() {
			return ProxyQChildEvent().Polished();
		}
		[SmokeMethod("removed() const")]
		public bool Removed() {
			return ProxyQChildEvent().Removed();
		}
		~QChildEvent() {
			DisposeQChildEvent();
		}
		public new void Dispose() {
			DisposeQChildEvent();
		}
		[SmokeMethod("~QChildEvent()")]
		private void DisposeQChildEvent() {
			ProxyQChildEvent().DisposeQChildEvent();
		}
	}
}
