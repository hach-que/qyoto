//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QShowEvent : QEvent, IDisposable {
 		protected QShowEvent(Type dummy) : base((Type) null) {}
		interface IQShowEventProxy {
		}

		protected void CreateQShowEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QShowEvent), this);
			_interceptor = (QShowEvent) realProxy.GetTransparentProxy();
		}
		private QShowEvent ProxyQShowEvent() {
			return (QShowEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QShowEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQShowEventProxy), null);
			_staticInterceptor = (IQShowEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQShowEventProxy StaticQShowEvent() {
			return (IQShowEventProxy) _staticInterceptor;
		}

		public QShowEvent() : this((Type) null) {
			CreateQShowEventProxy();
			NewQShowEvent();
		}
		[SmokeMethod("QShowEvent()")]
		private void NewQShowEvent() {
			ProxyQShowEvent().NewQShowEvent();
		}
		~QShowEvent() {
			DisposeQShowEvent();
		}
		public new void Dispose() {
			DisposeQShowEvent();
		}
		private void DisposeQShowEvent() {
			ProxyQShowEvent().DisposeQShowEvent();
		}
	}
}