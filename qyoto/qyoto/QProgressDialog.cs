//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQProgressDialogSignals"></see> for signals emitted by QProgressDialog
	[SmokeClass("QProgressDialog")]
	public class QProgressDialog : QDialog, IDisposable {
 		protected QProgressDialog(Type dummy) : base((Type) null) {}
		interface IQProgressDialogProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QProgressDialog), this);
			_interceptor = (QProgressDialog) realProxy.GetTransparentProxy();
		}
		private QProgressDialog ProxyQProgressDialog() {
			return (QProgressDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QProgressDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQProgressDialogProxy), null);
			_staticInterceptor = (IQProgressDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQProgressDialogProxy StaticQProgressDialog() {
			return (IQProgressDialogProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QProgressDialog(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(parent,f);
		}
		[SmokeMethod("QProgressDialog(QWidget*, Qt::WindowFlags)")]
		private void NewQProgressDialog(QWidget parent, int f) {
			ProxyQProgressDialog().NewQProgressDialog(parent,f);
		}
		public QProgressDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(parent);
		}
		[SmokeMethod("QProgressDialog(QWidget*)")]
		private void NewQProgressDialog(QWidget parent) {
			ProxyQProgressDialog().NewQProgressDialog(parent);
		}
		public QProgressDialog() : this((Type) null) {
			CreateProxy();
			NewQProgressDialog();
		}
		[SmokeMethod("QProgressDialog()")]
		private void NewQProgressDialog() {
			ProxyQProgressDialog().NewQProgressDialog();
		}
		public QProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent,f);
		}
		[SmokeMethod("QProgressDialog(const QString&, const QString&, int, int, QWidget*, Qt::WindowFlags)")]
		private void NewQProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent, int f) {
			ProxyQProgressDialog().NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent,f);
		}
		public QProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent);
		}
		[SmokeMethod("QProgressDialog(const QString&, const QString&, int, int, QWidget*)")]
		private void NewQProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent) {
			ProxyQProgressDialog().NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent);
		}
		public QProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(labelText,cancelButtonText,minimum,maximum);
		}
		[SmokeMethod("QProgressDialog(const QString&, const QString&, int, int)")]
		private void NewQProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum) {
			ProxyQProgressDialog().NewQProgressDialog(labelText,cancelButtonText,minimum,maximum);
		}
		[SmokeMethod("setLabel(QLabel*)")]
		public void SetLabel(QLabel label) {
			ProxyQProgressDialog().SetLabel(label);
		}
		[SmokeMethod("setCancelButton(QPushButton*)")]
		public void SetCancelButton(QPushButton button) {
			ProxyQProgressDialog().SetCancelButton(button);
		}
		[SmokeMethod("setBar(QProgressBar*)")]
		public void SetBar(QProgressBar bar) {
			ProxyQProgressDialog().SetBar(bar);
		}
		[SmokeMethod("wasCanceled() const")]
		public bool WasCanceled() {
			return ProxyQProgressDialog().WasCanceled();
		}
		[SmokeMethod("minimum() const")]
		public int Minimum() {
			return ProxyQProgressDialog().Minimum();
		}
		[SmokeMethod("maximum() const")]
		public int Maximum() {
			return ProxyQProgressDialog().Maximum();
		}
		[SmokeMethod("setRange(int, int)")]
		public void SetRange(int minimum, int maximum) {
			ProxyQProgressDialog().SetRange(minimum,maximum);
		}
		[SmokeMethod("value() const")]
		public int Value() {
			return ProxyQProgressDialog().Value();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQProgressDialog().SizeHint();
		}
		[SmokeMethod("labelText() const")]
		public string LabelText() {
			return ProxyQProgressDialog().LabelText();
		}
		[SmokeMethod("minimumDuration() const")]
		public int MinimumDuration() {
			return ProxyQProgressDialog().MinimumDuration();
		}
		[SmokeMethod("setAutoReset(bool)")]
		public void SetAutoReset(bool b) {
			ProxyQProgressDialog().SetAutoReset(b);
		}
		[SmokeMethod("autoReset() const")]
		public bool AutoReset() {
			return ProxyQProgressDialog().AutoReset();
		}
		[SmokeMethod("setAutoClose(bool)")]
		public void SetAutoClose(bool b) {
			ProxyQProgressDialog().SetAutoClose(b);
		}
		[SmokeMethod("autoClose() const")]
		public bool AutoClose() {
			return ProxyQProgressDialog().AutoClose();
		}
		[SmokeMethod("cancel()")]
		public void Cancel() {
			ProxyQProgressDialog().Cancel();
		}
		[SmokeMethod("reset()")]
		public void Reset() {
			ProxyQProgressDialog().Reset();
		}
		[SmokeMethod("setMaximum(int)")]
		public void SetMaximum(int maximum) {
			ProxyQProgressDialog().SetMaximum(maximum);
		}
		[SmokeMethod("setMinimum(int)")]
		public void SetMinimum(int minimum) {
			ProxyQProgressDialog().SetMinimum(minimum);
		}
		[SmokeMethod("setValue(int)")]
		public void SetValue(int progress) {
			ProxyQProgressDialog().SetValue(progress);
		}
		[SmokeMethod("setLabelText(const QString&)")]
		public void SetLabelText(string arg1) {
			ProxyQProgressDialog().SetLabelText(arg1);
		}
		[SmokeMethod("setCancelButtonText(const QString&)")]
		public void SetCancelButtonText(string arg1) {
			ProxyQProgressDialog().SetCancelButtonText(arg1);
		}
		[SmokeMethod("setMinimumDuration(int)")]
		public void SetMinimumDuration(int ms) {
			ProxyQProgressDialog().SetMinimumDuration(ms);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQProgressDialog().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQProgressDialog().Tr(s);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQProgressDialog().ResizeEvent(arg1);
		}
		[SmokeMethod("closeEvent(QCloseEvent*)")]
		protected new void CloseEvent(QCloseEvent arg1) {
			ProxyQProgressDialog().CloseEvent(arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQProgressDialog().ChangeEvent(arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent e) {
			ProxyQProgressDialog().ShowEvent(e);
		}
		[SmokeMethod("forceShow()")]
		protected void ForceShow() {
			ProxyQProgressDialog().ForceShow();
		}
		~QProgressDialog() {
			DisposeQProgressDialog();
		}
		public new void Dispose() {
			DisposeQProgressDialog();
		}
		[SmokeMethod("~QProgressDialog()")]
		private void DisposeQProgressDialog() {
			ProxyQProgressDialog().DisposeQProgressDialog();
		}
		protected new IQProgressDialogSignals Emit() {
			return (IQProgressDialogSignals) Q_EMIT;
		}
	}

	public interface IQProgressDialogSignals : IQDialogSignals {
		[Q_SIGNAL("void canceled()")]
		void Canceled();
	}
}
