//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionComplex")]
	public class QStyleOptionComplex : QStyleOption, IDisposable {
 		protected QStyleOptionComplex(Type dummy) : base((Type) null) {}
		interface IQStyleOptionComplexProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionComplex), this);
			_interceptor = (QStyleOptionComplex) realProxy.GetTransparentProxy();
		}
		private QStyleOptionComplex ProxyQStyleOptionComplex() {
			return (QStyleOptionComplex) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionComplex() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionComplexProxy), null);
			_staticInterceptor = (IQStyleOptionComplexProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionComplexProxy StaticQStyleOptionComplex() {
			return (IQStyleOptionComplexProxy) _staticInterceptor;
		}

		public const int Type = (int) QStyleOption.OptionType.SO_Complex;

		public const int Version = 1;

		public QStyleOptionComplex(int version, int type) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionComplex(version,type);
		}
		[SmokeMethod("QStyleOptionComplex(int, int)")]
		private void NewQStyleOptionComplex(int version, int type) {
			ProxyQStyleOptionComplex().NewQStyleOptionComplex(version,type);
		}
		public QStyleOptionComplex(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionComplex(version);
		}
		[SmokeMethod("QStyleOptionComplex(int)")]
		private void NewQStyleOptionComplex(int version) {
			ProxyQStyleOptionComplex().NewQStyleOptionComplex(version);
		}
		public QStyleOptionComplex() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionComplex();
		}
		[SmokeMethod("QStyleOptionComplex()")]
		private void NewQStyleOptionComplex() {
			ProxyQStyleOptionComplex().NewQStyleOptionComplex();
		}
		public QStyleOptionComplex(QStyleOptionComplex other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionComplex(other);
		}
		[SmokeMethod("QStyleOptionComplex(const QStyleOptionComplex&)")]
		private void NewQStyleOptionComplex(QStyleOptionComplex other) {
			ProxyQStyleOptionComplex().NewQStyleOptionComplex(other);
		}
		~QStyleOptionComplex() {
			DisposeQStyleOptionComplex();
		}
		public void Dispose() {
			DisposeQStyleOptionComplex();
		}
		[SmokeMethod("~QStyleOptionComplex()")]
		private void DisposeQStyleOptionComplex() {
			ProxyQStyleOptionComplex().DisposeQStyleOptionComplex();
		}
	}
}
