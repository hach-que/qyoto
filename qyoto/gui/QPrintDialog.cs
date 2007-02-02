//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QPrintDialog")]
	public class QPrintDialog : QAbstractPrintDialog, IDisposable {
 		protected QPrintDialog(Type dummy) : base((Type) null) {}
		interface IQPrintDialogProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPrintDialog), this);
			_interceptor = (QPrintDialog) realProxy.GetTransparentProxy();
		}
		private QPrintDialog ProxyQPrintDialog() {
			return (QPrintDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPrintDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPrintDialogProxy), null);
			_staticInterceptor = (IQPrintDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQPrintDialogProxy StaticQPrintDialog() {
			return (IQPrintDialogProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QPrintDialog(QPrinter printer, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPrintDialog(printer,parent);
		}
		[SmokeMethod("QPrintDialog##", "(QPrinter*, QWidget*)")]
		private void NewQPrintDialog(QPrinter printer, QWidget parent) {
			ProxyQPrintDialog().NewQPrintDialog(printer,parent);
		}
		public QPrintDialog(QPrinter printer) : this((Type) null) {
			CreateProxy();
			NewQPrintDialog(printer);
		}
		[SmokeMethod("QPrintDialog#", "(QPrinter*)")]
		private void NewQPrintDialog(QPrinter printer) {
			ProxyQPrintDialog().NewQPrintDialog(printer);
		}
		[SmokeMethod("exec", "()")]
		public new int Exec() {
			return ProxyQPrintDialog().Exec();
		}
		[SmokeMethod("eventFilter##", "(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQPrintDialog().EventFilter(arg1,arg2);
		}
		public static new string Tr(string s, string c) {
			return StaticQPrintDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQPrintDialog().Tr(s);
		}
		~QPrintDialog() {
			DisposeQPrintDialog();
		}
		public new void Dispose() {
			DisposeQPrintDialog();
		}
		[SmokeMethod("~QPrintDialog", "()")]
		private void DisposeQPrintDialog() {
			ProxyQPrintDialog().DisposeQPrintDialog();
		}
		protected new IQPrintDialogSignals Emit {
			get {
				return (IQPrintDialogSignals) Q_EMIT;
			}
		}
	}

	public interface IQPrintDialogSignals : IQAbstractPrintDialogSignals {
	}
}
