//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTimerEvent")]
	public class QTimerEvent : QEvent, IDisposable {
 		protected QTimerEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTimerEvent), this);
			_interceptor = (QTimerEvent) realProxy.GetTransparentProxy();
		}
		private QTimerEvent ProxyQTimerEvent() {
			return (QTimerEvent) _interceptor;
		}
		public QTimerEvent(int timerId) : this((Type) null) {
			CreateProxy();
			NewQTimerEvent(timerId);
		}
		[SmokeMethod("QTimerEvent", "(int)", "$")]
		private void NewQTimerEvent(int timerId) {
			ProxyQTimerEvent().NewQTimerEvent(timerId);
		}
		[SmokeMethod("timerId", "() const", "")]
		public int TimerId() {
			return ProxyQTimerEvent().TimerId();
		}
		~QTimerEvent() {
			DisposeQTimerEvent();
		}
		public new void Dispose() {
			DisposeQTimerEvent();
		}
		[SmokeMethod("~QTimerEvent", "()", "")]
		private void DisposeQTimerEvent() {
			ProxyQTimerEvent().DisposeQTimerEvent();
		}
	}
}
