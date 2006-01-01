//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QIntValidator : QValidator, IDisposable {
 		protected QIntValidator(Type dummy) : base((Type) null) {}
		interface IQIntValidatorProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQIntValidatorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIntValidator), this);
			_interceptor = (QIntValidator) realProxy.GetTransparentProxy();
		}
		private QIntValidator ProxyQIntValidator() {
			return (QIntValidator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIntValidator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIntValidatorProxy), null);
			_staticInterceptor = (IQIntValidatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQIntValidatorProxy StaticQIntValidator() {
			return (IQIntValidatorProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQIntValidator().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQIntValidator().ClassName();
		}
		public QIntValidator(QObject parent, string name) : this((Type) null) {
			CreateQIntValidatorProxy();
			CreateQIntValidatorSignalProxy();
			NewQIntValidator(parent,name);
		}
		[SmokeMethod("QIntValidator(QObject*, const char*)")]
		private void NewQIntValidator(QObject parent, string name) {
			ProxyQIntValidator().NewQIntValidator(parent,name);
		}
		public QIntValidator(QObject parent) : this((Type) null) {
			CreateQIntValidatorProxy();
			CreateQIntValidatorSignalProxy();
			NewQIntValidator(parent);
		}
		[SmokeMethod("QIntValidator(QObject*)")]
		private void NewQIntValidator(QObject parent) {
			ProxyQIntValidator().NewQIntValidator(parent);
		}
		public QIntValidator(int bottom, int top, QObject parent, string name) : this((Type) null) {
			CreateQIntValidatorProxy();
			CreateQIntValidatorSignalProxy();
			NewQIntValidator(bottom,top,parent,name);
		}
		[SmokeMethod("QIntValidator(int, int, QObject*, const char*)")]
		private void NewQIntValidator(int bottom, int top, QObject parent, string name) {
			ProxyQIntValidator().NewQIntValidator(bottom,top,parent,name);
		}
		public QIntValidator(int bottom, int top, QObject parent) : this((Type) null) {
			CreateQIntValidatorProxy();
			CreateQIntValidatorSignalProxy();
			NewQIntValidator(bottom,top,parent);
		}
		[SmokeMethod("QIntValidator(int, int, QObject*)")]
		private void NewQIntValidator(int bottom, int top, QObject parent) {
			ProxyQIntValidator().NewQIntValidator(bottom,top,parent);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public new int Validate(StringBuilder arg1, out int arg2) {
			return ProxyQIntValidator().Validate(arg1,out arg2);
		}
		[SmokeMethod("setBottom(int)")]
		public void SetBottom(int arg1) {
			ProxyQIntValidator().SetBottom(arg1);
		}
		[SmokeMethod("setTop(int)")]
		public void SetTop(int arg1) {
			ProxyQIntValidator().SetTop(arg1);
		}
		[SmokeMethod("setRange(int, int)")]
		public virtual void SetRange(int bottom, int top) {
			ProxyQIntValidator().SetRange(bottom,top);
		}
		[SmokeMethod("bottom() const")]
		public int Bottom() {
			return ProxyQIntValidator().Bottom();
		}
		[SmokeMethod("top() const")]
		public int Top() {
			return ProxyQIntValidator().Top();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQIntValidator().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQIntValidator().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQIntValidator().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQIntValidator().TrUtf8(arg1);
		}
		~QIntValidator() {
			DisposeQIntValidator();
		}
		public new void Dispose() {
			DisposeQIntValidator();
		}
		private void DisposeQIntValidator() {
			ProxyQIntValidator().DisposeQIntValidator();
		}
		protected void CreateQIntValidatorSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQIntValidatorSignals), this);
			_signalInterceptor = (IQIntValidatorSignals) realProxy.GetTransparentProxy();
		}
		protected new IQIntValidatorSignals Emit() {
			return (IQIntValidatorSignals) _signalInterceptor;
		}
	}

	public interface IQIntValidatorSignals : IQValidatorSignals {
	}
}