//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QClipboardEvent")]
	public class QClipboardEvent : QEvent, IDisposable {
 		protected QClipboardEvent(Type dummy) : base((Type) null) {}
		interface IQClipboardEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QClipboardEvent), this);
			_interceptor = (QClipboardEvent) realProxy.GetTransparentProxy();
		}
		private QClipboardEvent ProxyQClipboardEvent() {
			return (QClipboardEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QClipboardEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQClipboardEventProxy), null);
			_staticInterceptor = (IQClipboardEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQClipboardEventProxy StaticQClipboardEvent() {
			return (IQClipboardEventProxy) _staticInterceptor;
		}

		// QClipboardEvent* QClipboardEvent(QEventPrivate* arg1); >>>> NOT CONVERTED
		// QEventPrivate* data(); >>>> NOT CONVERTED
		~QClipboardEvent() {
			DisposeQClipboardEvent();
		}
		public new void Dispose() {
			DisposeQClipboardEvent();
		}
		[SmokeMethod("~QClipboardEvent", "()")]
		private void DisposeQClipboardEvent() {
			ProxyQClipboardEvent().DisposeQClipboardEvent();
		}
	}
}
