//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QErrorMessage")]
	public class QErrorMessage : QDialog, IDisposable {
 		protected QErrorMessage(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QErrorMessage), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QErrorMessage() {
			staticInterceptor = new SmokeInvocation(typeof(QErrorMessage), null);
		}
		public QErrorMessage(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QErrorMessage#", "QErrorMessage(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QErrorMessage() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QErrorMessage", "QErrorMessage()", typeof(void));
		}
		[Q_SLOT("void showMessage(const QString&)")]
		public void ShowMessage(string message) {
			interceptor.Invoke("showMessage$", "showMessage(const QString&)", typeof(void), typeof(string), message);
		}
		[SmokeMethod("done(int)")]
		protected new virtual void Done(int arg1) {
			interceptor.Invoke("done$", "done(int)", typeof(void), typeof(int), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent e) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), e);
		}
		~QErrorMessage() {
			interceptor.Invoke("~QErrorMessage", "~QErrorMessage()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QErrorMessage", "~QErrorMessage()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static QErrorMessage QtHandler() {
			return (QErrorMessage) staticInterceptor.Invoke("qtHandler", "qtHandler()", typeof(QErrorMessage));
		}
		protected new IQErrorMessageSignals Emit {
			get { return (IQErrorMessageSignals) Q_EMIT; }
		}
	}

	public interface IQErrorMessageSignals : IQDialogSignals {
	}
}
