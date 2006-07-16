//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDBusObjectPath")]
	public class QDBusObjectPath : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDBusObjectPath(Type dummy) {}
		interface IQDBusObjectPathProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusObjectPath), this);
			_interceptor = (QDBusObjectPath) realProxy.GetTransparentProxy();
		}
		private QDBusObjectPath ProxyQDBusObjectPath() {
			return (QDBusObjectPath) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusObjectPath() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusObjectPathProxy), null);
			_staticInterceptor = (IQDBusObjectPathProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusObjectPathProxy StaticQDBusObjectPath() {
			return (IQDBusObjectPathProxy) _staticInterceptor;
		}

		public QDBusObjectPath() : this((Type) null) {
			CreateProxy();
			NewQDBusObjectPath();
		}
		[SmokeMethod("QDBusObjectPath()")]
		private void NewQDBusObjectPath() {
			ProxyQDBusObjectPath().NewQDBusObjectPath();
		}
		public QDBusObjectPath(string path) : this((Type) null) {
			CreateProxy();
			NewQDBusObjectPath(path);
		}
		[SmokeMethod("QDBusObjectPath(const char*)")]
		private void NewQDBusObjectPath(string path) {
			ProxyQDBusObjectPath().NewQDBusObjectPath(path);
		}
		// QDBusObjectPath* QDBusObjectPath(const QLatin1String& arg1); >>>> NOT CONVERTED
		~QDBusObjectPath() {
			DisposeQDBusObjectPath();
		}
		public void Dispose() {
			DisposeQDBusObjectPath();
		}
		[SmokeMethod("~QDBusObjectPath()")]
		private void DisposeQDBusObjectPath() {
			ProxyQDBusObjectPath().DisposeQDBusObjectPath();
		}
	}
}
