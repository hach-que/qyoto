//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGenericReturnArgument")]
	public class QGenericReturnArgument : QGenericArgument, IDisposable {
 		protected QGenericReturnArgument(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGenericReturnArgument), this);
			interceptor = (QGenericReturnArgument) realProxy.GetTransparentProxy();
		}
		// QGenericReturnArgument* QGenericReturnArgument(const char* arg1,void* arg2); >>>> NOT CONVERTED
		public QGenericReturnArgument(string aName) : this((Type) null) {
			CreateProxy();
			NewQGenericReturnArgument(aName);
		}
		[SmokeMethod("QGenericReturnArgument", "(const char*)", "$")]
		private void NewQGenericReturnArgument(string aName) {
			((QGenericReturnArgument) interceptor).NewQGenericReturnArgument(aName);
		}
		public QGenericReturnArgument() : this((Type) null) {
			CreateProxy();
			NewQGenericReturnArgument();
		}
		[SmokeMethod("QGenericReturnArgument", "()", "")]
		private void NewQGenericReturnArgument() {
			((QGenericReturnArgument) interceptor).NewQGenericReturnArgument();
		}
		~QGenericReturnArgument() {
			DisposeQGenericReturnArgument();
		}
		public void Dispose() {
			DisposeQGenericReturnArgument();
		}
		[SmokeMethod("~QGenericReturnArgument", "()", "")]
		private void DisposeQGenericReturnArgument() {
			((QGenericReturnArgument) interceptor).DisposeQGenericReturnArgument();
		}
	}
}
