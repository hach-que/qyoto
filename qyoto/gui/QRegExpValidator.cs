//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QRegExpValidator")]
	public class QRegExpValidator : QValidator, IDisposable {
 		protected QRegExpValidator(Type dummy) : base((Type) null) {}
		interface IQRegExpValidatorProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRegExpValidator), this);
			_interceptor = (QRegExpValidator) realProxy.GetTransparentProxy();
		}
		private QRegExpValidator ProxyQRegExpValidator() {
			return (QRegExpValidator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRegExpValidator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRegExpValidatorProxy), null);
			_staticInterceptor = (IQRegExpValidatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQRegExpValidatorProxy StaticQRegExpValidator() {
			return (IQRegExpValidatorProxy) _staticInterceptor;
		}

		public QRegExp RegExp {
			get {
				return Property("regExp").Value<QRegExp>();
			}
			set {
				SetProperty("regExp", QVariant.FromValue<QRegExp>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QRegExpValidator(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQRegExpValidator(parent);
		}
		[SmokeMethod("QRegExpValidator(QObject*)")]
		private void NewQRegExpValidator(QObject parent) {
			ProxyQRegExpValidator().NewQRegExpValidator(parent);
		}
		public QRegExpValidator(QRegExp rx, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQRegExpValidator(rx,parent);
		}
		[SmokeMethod("QRegExpValidator(const QRegExp&, QObject*)")]
		private void NewQRegExpValidator(QRegExp rx, QObject parent) {
			ProxyQRegExpValidator().NewQRegExpValidator(rx,parent);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public new virtual int Validate(StringBuilder input, out int pos) {
			return ProxyQRegExpValidator().Validate(input,out pos);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQRegExpValidator().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQRegExpValidator().Tr(s);
		}
		~QRegExpValidator() {
			DisposeQRegExpValidator();
		}
		public new void Dispose() {
			DisposeQRegExpValidator();
		}
		[SmokeMethod("~QRegExpValidator()")]
		private void DisposeQRegExpValidator() {
			ProxyQRegExpValidator().DisposeQRegExpValidator();
		}
		protected new IQRegExpValidatorSignals Emit() {
			return (IQRegExpValidatorSignals) Q_EMIT;
		}
	}

	public interface IQRegExpValidatorSignals : IQValidatorSignals {
	}
}
