//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QValidator")]
	public class QValidator : QObject, IDisposable {
 		protected QValidator(Type dummy) : base((Type) null) {}
		interface IQValidatorProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QValidator), this);
			_interceptor = (QValidator) realProxy.GetTransparentProxy();
		}
		private QValidator ProxyQValidator() {
			return (QValidator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QValidator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQValidatorProxy), null);
			_staticInterceptor = (IQValidatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQValidatorProxy StaticQValidator() {
			return (IQValidatorProxy) _staticInterceptor;
		}

		public enum State {
			Invalid = 0,
			Intermediate = 1,
			Acceptable = 2,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QValidator(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQValidator(parent);
		}
		[SmokeMethod("QValidator(QObject*)")]
		private void NewQValidator(QObject parent) {
			ProxyQValidator().NewQValidator(parent);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public virtual int Validate(StringBuilder arg1, out int arg2) {
			return ProxyQValidator().Validate(arg1,out arg2);
		}
		[SmokeMethod("fixup(QString&) const")]
		public virtual void Fixup(StringBuilder arg1) {
			ProxyQValidator().Fixup(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQValidator().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQValidator().Tr(s);
		}
		~QValidator() {
			DisposeQValidator();
		}
		public new void Dispose() {
			DisposeQValidator();
		}
		[SmokeMethod("~QValidator()")]
		private void DisposeQValidator() {
			ProxyQValidator().DisposeQValidator();
		}
		protected new IQValidatorSignals Emit {
			get {
				return (IQValidatorSignals) Q_EMIT;
			}
		}
	}

	public interface IQValidatorSignals : IQObjectSignals {
	}
}
