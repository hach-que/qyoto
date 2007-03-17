//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGenericArgument")]
	public class QGenericArgument : MarshalByRefObject, IDisposable {
		protected QGenericArgument interceptor = null;
		private IntPtr smokeObject;
		protected QGenericArgument(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGenericArgument), this);
			interceptor = (QGenericArgument) realProxy.GetTransparentProxy();
		}
		// QGenericArgument* QGenericArgument(const char* arg1,const void* arg2); >>>> NOT CONVERTED
		// void* data(); >>>> NOT CONVERTED
		public QGenericArgument(string aName) : this((Type) null) {
			CreateProxy();
			NewQGenericArgument(aName);
		}
		[SmokeMethod("QGenericArgument", "(const char*)", "$")]
		private void NewQGenericArgument(string aName) {
			((QGenericArgument) interceptor).NewQGenericArgument(aName);
		}
		public QGenericArgument() : this((Type) null) {
			CreateProxy();
			NewQGenericArgument();
		}
		[SmokeMethod("QGenericArgument", "()", "")]
		private void NewQGenericArgument() {
			((QGenericArgument) interceptor).NewQGenericArgument();
		}
		[SmokeMethod("name", "() const", "")]
		public string Name() {
			return ((QGenericArgument) interceptor).Name();
		}
		~QGenericArgument() {
			DisposeQGenericArgument();
		}
		public void Dispose() {
			DisposeQGenericArgument();
		}
		[SmokeMethod("~QGenericArgument", "()", "")]
		private void DisposeQGenericArgument() {
			((QGenericArgument) interceptor).DisposeQGenericArgument();
		}
	}
}
