//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionTabV2")]
	public class QStyleOptionTabV2 : QStyleOptionTab, IDisposable {
 		protected QStyleOptionTabV2(Type dummy) : base((Type) null) {}
		interface IQStyleOptionTabV2Proxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionTabV2), this);
			_interceptor = (QStyleOptionTabV2) realProxy.GetTransparentProxy();
		}
		private QStyleOptionTabV2 ProxyQStyleOptionTabV2() {
			return (QStyleOptionTabV2) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionTabV2() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionTabV2Proxy), null);
			_staticInterceptor = (IQStyleOptionTabV2Proxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionTabV2Proxy StaticQStyleOptionTabV2() {
			return (IQStyleOptionTabV2Proxy) _staticInterceptor;
		}

		public const int Version = 2;

		public QStyleOptionTabV2() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabV2();
		}
		[SmokeMethod("QStyleOptionTabV2()")]
		private void NewQStyleOptionTabV2() {
			ProxyQStyleOptionTabV2().NewQStyleOptionTabV2();
		}
		public QStyleOptionTabV2(QStyleOptionTabV2 other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabV2(other);
		}
		[SmokeMethod("QStyleOptionTabV2(const QStyleOptionTabV2&)")]
		private void NewQStyleOptionTabV2(QStyleOptionTabV2 other) {
			ProxyQStyleOptionTabV2().NewQStyleOptionTabV2(other);
		}
		public QStyleOptionTabV2(QStyleOptionTab other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabV2(other);
		}
		[SmokeMethod("QStyleOptionTabV2(const QStyleOptionTab&)")]
		private void NewQStyleOptionTabV2(QStyleOptionTab other) {
			ProxyQStyleOptionTabV2().NewQStyleOptionTabV2(other);
		}
		public QStyleOptionTabV2(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabV2(version);
		}
		[SmokeMethod("QStyleOptionTabV2(int)")]
		private void NewQStyleOptionTabV2(int version) {
			ProxyQStyleOptionTabV2().NewQStyleOptionTabV2(version);
		}
		~QStyleOptionTabV2() {
			DisposeQStyleOptionTabV2();
		}
		public void Dispose() {
			DisposeQStyleOptionTabV2();
		}
		[SmokeMethod("~QStyleOptionTabV2()")]
		private void DisposeQStyleOptionTabV2() {
			ProxyQStyleOptionTabV2().DisposeQStyleOptionTabV2();
		}
	}
}
