//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QUndoView")]
	public class QUndoView : QListView, IDisposable {
 		protected QUndoView(Type dummy) : base((Type) null) {}
		interface IQUndoViewProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUndoView), this);
			_interceptor = (QUndoView) realProxy.GetTransparentProxy();
		}
		private QUndoView ProxyQUndoView() {
			return (QUndoView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUndoView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUndoViewProxy), null);
			_staticInterceptor = (IQUndoViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQUndoViewProxy StaticQUndoView() {
			return (IQUndoViewProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QUndoView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQUndoView(parent);
		}
		[SmokeMethod("QUndoView(QWidget*)")]
		private void NewQUndoView(QWidget parent) {
			ProxyQUndoView().NewQUndoView(parent);
		}
		public QUndoView() : this((Type) null) {
			CreateProxy();
			NewQUndoView();
		}
		[SmokeMethod("QUndoView()")]
		private void NewQUndoView() {
			ProxyQUndoView().NewQUndoView();
		}
		public QUndoView(QUndoStack stack, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQUndoView(stack,parent);
		}
		[SmokeMethod("QUndoView(QUndoStack*, QWidget*)")]
		private void NewQUndoView(QUndoStack stack, QWidget parent) {
			ProxyQUndoView().NewQUndoView(stack,parent);
		}
		public QUndoView(QUndoStack stack) : this((Type) null) {
			CreateProxy();
			NewQUndoView(stack);
		}
		[SmokeMethod("QUndoView(QUndoStack*)")]
		private void NewQUndoView(QUndoStack stack) {
			ProxyQUndoView().NewQUndoView(stack);
		}
		public QUndoView(QUndoGroup group, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQUndoView(group,parent);
		}
		[SmokeMethod("QUndoView(QUndoGroup*, QWidget*)")]
		private void NewQUndoView(QUndoGroup group, QWidget parent) {
			ProxyQUndoView().NewQUndoView(group,parent);
		}
		public QUndoView(QUndoGroup group) : this((Type) null) {
			CreateProxy();
			NewQUndoView(group);
		}
		[SmokeMethod("QUndoView(QUndoGroup*)")]
		private void NewQUndoView(QUndoGroup group) {
			ProxyQUndoView().NewQUndoView(group);
		}
		[SmokeMethod("stack() const")]
		public QUndoStack Stack() {
			return ProxyQUndoView().Stack();
		}
		[SmokeMethod("group() const")]
		public QUndoGroup Group() {
			return ProxyQUndoView().Group();
		}
		[SmokeMethod("setEmptyLabel(const QString&)")]
		public void SetEmptyLabel(string label) {
			ProxyQUndoView().SetEmptyLabel(label);
		}
		[SmokeMethod("emptyLabel() const")]
		public string EmptyLabel() {
			return ProxyQUndoView().EmptyLabel();
		}
		[SmokeMethod("setCleanIcon(const QIcon&)")]
		public void SetCleanIcon(QIcon icon) {
			ProxyQUndoView().SetCleanIcon(icon);
		}
		[SmokeMethod("cleanIcon() const")]
		public QIcon CleanIcon() {
			return ProxyQUndoView().CleanIcon();
		}
		[SmokeMethod("setStack(QUndoStack*)")]
		public void SetStack(QUndoStack stack) {
			ProxyQUndoView().SetStack(stack);
		}
		[SmokeMethod("setGroup(QUndoGroup*)")]
		public void SetGroup(QUndoGroup group) {
			ProxyQUndoView().SetGroup(group);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQUndoView().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQUndoView().Tr(s);
		}
		~QUndoView() {
			DisposeQUndoView();
		}
		public new void Dispose() {
			DisposeQUndoView();
		}
		[SmokeMethod("~QUndoView()")]
		private void DisposeQUndoView() {
			ProxyQUndoView().DisposeQUndoView();
		}
		protected new IQUndoViewSignals Emit() {
			return (IQUndoViewSignals) Q_EMIT;
		}
	}

	public interface IQUndoViewSignals : IQListViewSignals {
	}
}