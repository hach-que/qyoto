//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QAbstractFileEngineHandler")]
	public class QAbstractFileEngineHandler : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QAbstractFileEngineHandler(Type dummy) {}
		interface IQAbstractFileEngineHandlerProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractFileEngineHandler), this);
			_interceptor = (QAbstractFileEngineHandler) realProxy.GetTransparentProxy();
		}
		private QAbstractFileEngineHandler ProxyQAbstractFileEngineHandler() {
			return (QAbstractFileEngineHandler) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractFileEngineHandler() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractFileEngineHandlerProxy), null);
			_staticInterceptor = (IQAbstractFileEngineHandlerProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractFileEngineHandlerProxy StaticQAbstractFileEngineHandler() {
			return (IQAbstractFileEngineHandlerProxy) _staticInterceptor;
		}

		public QAbstractFileEngineHandler() : this((Type) null) {
			CreateProxy();
			NewQAbstractFileEngineHandler();
		}
		[SmokeMethod("QAbstractFileEngineHandler", "()")]
		private void NewQAbstractFileEngineHandler() {
			ProxyQAbstractFileEngineHandler().NewQAbstractFileEngineHandler();
		}
		[SmokeMethod("create$", "(const QString&) const")]
		public virtual QAbstractFileEngine Create(string fileName) {
			return ProxyQAbstractFileEngineHandler().Create(fileName);
		}
		~QAbstractFileEngineHandler() {
			DisposeQAbstractFileEngineHandler();
		}
		public void Dispose() {
			DisposeQAbstractFileEngineHandler();
		}
		[SmokeMethod("~QAbstractFileEngineHandler", "()")]
		private void DisposeQAbstractFileEngineHandler() {
			ProxyQAbstractFileEngineHandler().DisposeQAbstractFileEngineHandler();
		}
	}
}
