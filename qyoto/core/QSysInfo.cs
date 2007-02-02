//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSysInfo")]
	public class QSysInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QSysInfo(Type dummy) {}
		interface IQSysInfoProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSysInfo), this);
			_interceptor = (QSysInfo) realProxy.GetTransparentProxy();
		}
		private QSysInfo ProxyQSysInfo() {
			return (QSysInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSysInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSysInfoProxy), null);
			_staticInterceptor = (IQSysInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQSysInfoProxy StaticQSysInfo() {
			return (IQSysInfoProxy) _staticInterceptor;
		}

		public enum Sizes {
			WordSize = (4<<3),
		}
		public enum Endian {
			BigEndian = 0,
			LittleEndian = 1,
		}
		public QSysInfo() : this((Type) null) {
			CreateProxy();
			NewQSysInfo();
		}
		[SmokeMethod("QSysInfo", "()")]
		private void NewQSysInfo() {
			ProxyQSysInfo().NewQSysInfo();
		}
		~QSysInfo() {
			DisposeQSysInfo();
		}
		public void Dispose() {
			DisposeQSysInfo();
		}
		[SmokeMethod("~QSysInfo", "()")]
		private void DisposeQSysInfo() {
			ProxyQSysInfo().DisposeQSysInfo();
		}
	}
}
