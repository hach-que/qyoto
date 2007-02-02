//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDBusMetaType")]
	public class QDBusMetaType : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDBusMetaType(Type dummy) {}
		interface IQDBusMetaTypeProxy {
			[SmokeMethod("signatureToType$", "(const char*)")]
			int SignatureToType(string signature);
			[SmokeMethod("typeToSignature$", "(int)")]
			string TypeToSignature(int type);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusMetaType), this);
			_interceptor = (QDBusMetaType) realProxy.GetTransparentProxy();
		}
		private QDBusMetaType ProxyQDBusMetaType() {
			return (QDBusMetaType) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusMetaType() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusMetaTypeProxy), null);
			_staticInterceptor = (IQDBusMetaTypeProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusMetaTypeProxy StaticQDBusMetaType() {
			return (IQDBusMetaTypeProxy) _staticInterceptor;
		}

		public QDBusMetaType() : this((Type) null) {
			CreateProxy();
			NewQDBusMetaType();
		}
		[SmokeMethod("QDBusMetaType", "()")]
		private void NewQDBusMetaType() {
			ProxyQDBusMetaType().NewQDBusMetaType();
		}
		// void registerMarshallOperators(int arg1,MarshallFunction arg2,DemarshallFunction arg3); >>>> NOT CONVERTED
		// bool marshall(QDBusArgument& arg1,int arg2,const void* arg3); >>>> NOT CONVERTED
		// bool demarshall(const QDBusArgument& arg1,int arg2,void* arg3); >>>> NOT CONVERTED
		public static int SignatureToType(string signature) {
			return StaticQDBusMetaType().SignatureToType(signature);
		}
		public static string TypeToSignature(int type) {
			return StaticQDBusMetaType().TypeToSignature(type);
		}
		~QDBusMetaType() {
			DisposeQDBusMetaType();
		}
		public void Dispose() {
			DisposeQDBusMetaType();
		}
		[SmokeMethod("~QDBusMetaType", "()")]
		private void DisposeQDBusMetaType() {
			ProxyQDBusMetaType().DisposeQDBusMetaType();
		}
	}
}
