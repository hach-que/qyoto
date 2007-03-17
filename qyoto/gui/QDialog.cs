//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQDialogSignals"></see> for signals emitted by QDialog
	[SmokeClass("QDialog")]
	public class QDialog : QWidget, IDisposable {
 		protected QDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QDialog")]
		interface IQDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDialog), this);
			interceptor = (QDialog) realProxy.GetTransparentProxy();
		}
		private static IQDialogProxy staticInterceptor = null;
		static QDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialogProxy), null);
			staticInterceptor = (IQDialogProxy) realProxy.GetTransparentProxy();
		}
		public enum DialogCode {
			Rejected = 0,
			Accepted = 1,
		}
		[Q_PROPERTY("bool", "sizeGripEnabled")]
		public bool SizeGripEnabled {
			get { return Property("sizeGripEnabled").Value<bool>(); }
			set { SetProperty("sizeGripEnabled", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("bool", "modal")]
		public bool Modal {
			get { return Property("modal").Value<bool>(); }
			set { SetProperty("modal", QVariant.FromValue<bool>(value)); }
		}
		public QDialog(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQDialog(parent,f);
		}
		[SmokeMethod("QDialog", "(QWidget*, Qt::WindowFlags)", "#$")]
		private void NewQDialog(QWidget parent, int f) {
			((QDialog) interceptor).NewQDialog(parent,f);
		}
		public QDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDialog(parent);
		}
		[SmokeMethod("QDialog", "(QWidget*)", "#")]
		private void NewQDialog(QWidget parent) {
			((QDialog) interceptor).NewQDialog(parent);
		}
		public QDialog() : this((Type) null) {
			CreateProxy();
			NewQDialog();
		}
		[SmokeMethod("QDialog", "()", "")]
		private void NewQDialog() {
			((QDialog) interceptor).NewQDialog();
		}
		[SmokeMethod("result", "() const", "")]
		public int Result() {
			return ((QDialog) interceptor).Result();
		}
		[SmokeMethod("setVisible", "(bool)", "$")]
		public override void SetVisible(bool visible) {
			((QDialog) interceptor).SetVisible(visible);
		}
		[SmokeMethod("setOrientation", "(Qt::Orientation)", "$")]
		public void SetOrientation(Qt.Orientation orientation) {
			((QDialog) interceptor).SetOrientation(orientation);
		}
		[SmokeMethod("orientation", "() const", "")]
		public Qt.Orientation Orientation() {
			return ((QDialog) interceptor).Orientation();
		}
		[SmokeMethod("setExtension", "(QWidget*)", "#")]
		public void SetExtension(QWidget extension) {
			((QDialog) interceptor).SetExtension(extension);
		}
		[SmokeMethod("extension", "() const", "")]
		public QWidget Extension() {
			return ((QDialog) interceptor).Extension();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QDialog) interceptor).SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ((QDialog) interceptor).MinimumSizeHint();
		}
		[SmokeMethod("isSizeGripEnabled", "() const", "")]
		public bool IsSizeGripEnabled() {
			return ((QDialog) interceptor).IsSizeGripEnabled();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new virtual bool Event(QEvent arg1) {
			return ((QDialog) interceptor).Event(arg1);
		}
		[SmokeMethod("setResult", "(int)", "$")]
		public void SetResult(int r) {
			((QDialog) interceptor).SetResult(r);
		}
		[Q_SLOT("int exec()")]
		[SmokeMethod("exec", "()", "")]
		public int Exec() {
			return ((QDialog) interceptor).Exec();
		}
		[Q_SLOT("void done(int)")]
		[SmokeMethod("done", "(int)", "$")]
		public virtual void Done(int arg1) {
			((QDialog) interceptor).Done(arg1);
		}
		[Q_SLOT("void accept()")]
		[SmokeMethod("accept", "()", "")]
		public virtual void Accept() {
			((QDialog) interceptor).Accept();
		}
		[Q_SLOT("void reject()")]
		[SmokeMethod("reject", "()", "")]
		public virtual void Reject() {
			((QDialog) interceptor).Reject();
		}
		[Q_SLOT("void showExtension(bool)")]
		[SmokeMethod("showExtension", "(bool)", "$")]
		public void ShowExtension(bool arg1) {
			((QDialog) interceptor).ShowExtension(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			((QDialog) interceptor).KeyPressEvent(arg1);
		}
		[SmokeMethod("closeEvent", "(QCloseEvent*)", "#")]
		protected override void CloseEvent(QCloseEvent arg1) {
			((QDialog) interceptor).CloseEvent(arg1);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		protected override void ShowEvent(QShowEvent arg1) {
			((QDialog) interceptor).ShowEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			((QDialog) interceptor).ResizeEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent", "(QContextMenuEvent*)", "#")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			((QDialog) interceptor).ContextMenuEvent(arg1);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return ((QDialog) interceptor).EventFilter(arg1,arg2);
		}
		[SmokeMethod("adjustPosition", "(QWidget*)", "#")]
		protected void AdjustPosition(QWidget arg1) {
			((QDialog) interceptor).AdjustPosition(arg1);
		}
		~QDialog() {
			DisposeQDialog();
		}
		public new void Dispose() {
			DisposeQDialog();
		}
		[SmokeMethod("~QDialog", "()", "")]
		private void DisposeQDialog() {
			((QDialog) interceptor).DisposeQDialog();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQDialogSignals Emit {
			get { return (IQDialogSignals) Q_EMIT; }
		}
	}

	public interface IQDialogSignals : IQWidgetSignals {
		[Q_SIGNAL("void finished(int)")]
		void Finished(int result);
		[Q_SIGNAL("void accepted()")]
		void Accepted();
		[Q_SIGNAL("void rejected()")]
		void Rejected();
	}
}
