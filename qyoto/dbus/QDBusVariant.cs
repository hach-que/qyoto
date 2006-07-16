//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDBusVariant")]
	public class QDBusVariant : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDBusVariant(Type dummy) {}
		interface IQDBusVariantProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusVariant), this);
			_interceptor = (QDBusVariant) realProxy.GetTransparentProxy();
		}
		private QDBusVariant ProxyQDBusVariant() {
			return (QDBusVariant) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusVariant() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusVariantProxy), null);
			_staticInterceptor = (IQDBusVariantProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusVariantProxy StaticQDBusVariant() {
			return (IQDBusVariantProxy) _staticInterceptor;
		}

		public QDBusVariant() : this((Type) null) {
			CreateProxy();
			NewQDBusVariant();
		}
		[SmokeMethod("QDBusVariant()")]
		private void NewQDBusVariant() {
			ProxyQDBusVariant().NewQDBusVariant();
		}
		public QDBusVariant(QVariant variant) : this((Type) null) {
			CreateProxy();
			NewQDBusVariant(variant);
		}
		[SmokeMethod("QDBusVariant(const QVariant&)")]
		private void NewQDBusVariant(QVariant variant) {
			ProxyQDBusVariant().NewQDBusVariant(variant);
		}
		~QDBusVariant() {
			DisposeQDBusVariant();
		}
		public void Dispose() {
			DisposeQDBusVariant();
		}
		[SmokeMethod("~QDBusVariant()")]
		private void DisposeQDBusVariant() {
			ProxyQDBusVariant().DisposeQDBusVariant();
		}
	}
}
