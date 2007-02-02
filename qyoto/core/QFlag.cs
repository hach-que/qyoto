//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFlag")]
	public class QFlag : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QFlag(Type dummy) {}
		interface IQFlagProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFlag), this);
			_interceptor = (QFlag) realProxy.GetTransparentProxy();
		}
		private QFlag ProxyQFlag() {
			return (QFlag) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFlag() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFlagProxy), null);
			_staticInterceptor = (IQFlagProxy) realProxy.GetTransparentProxy();
		}
		private static IQFlagProxy StaticQFlag() {
			return (IQFlagProxy) _staticInterceptor;
		}

		public QFlag(int i) : this((Type) null) {
			CreateProxy();
			NewQFlag(i);
		}
		[SmokeMethod("QFlag$", "(int)")]
		private void NewQFlag(int i) {
			ProxyQFlag().NewQFlag(i);
		}
		//  operator int(); >>>> NOT CONVERTED
		~QFlag() {
			DisposeQFlag();
		}
		public void Dispose() {
			DisposeQFlag();
		}
		[SmokeMethod("~QFlag", "()")]
		private void DisposeQFlag() {
			ProxyQFlag().DisposeQFlag();
		}
	}
}
