//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QRadioButton")]
	public class QRadioButton : QAbstractButton, IDisposable {
 		protected QRadioButton(Type dummy) : base((Type) null) {}
		interface IQRadioButtonProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRadioButton), this);
			_interceptor = (QRadioButton) realProxy.GetTransparentProxy();
		}
		private QRadioButton ProxyQRadioButton() {
			return (QRadioButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRadioButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRadioButtonProxy), null);
			_staticInterceptor = (IQRadioButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQRadioButtonProxy StaticQRadioButton() {
			return (IQRadioButtonProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QRadioButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQRadioButton(parent);
		}
		[SmokeMethod("QRadioButton(QWidget*)")]
		private void NewQRadioButton(QWidget parent) {
			ProxyQRadioButton().NewQRadioButton(parent);
		}
		public QRadioButton() : this((Type) null) {
			CreateProxy();
			NewQRadioButton();
		}
		[SmokeMethod("QRadioButton()")]
		private void NewQRadioButton() {
			ProxyQRadioButton().NewQRadioButton();
		}
		public QRadioButton(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQRadioButton(text,parent);
		}
		[SmokeMethod("QRadioButton(const QString&, QWidget*)")]
		private void NewQRadioButton(string text, QWidget parent) {
			ProxyQRadioButton().NewQRadioButton(text,parent);
		}
		public QRadioButton(string text) : this((Type) null) {
			CreateProxy();
			NewQRadioButton(text);
		}
		[SmokeMethod("QRadioButton(const QString&)")]
		private void NewQRadioButton(string text) {
			ProxyQRadioButton().NewQRadioButton(text);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQRadioButton().SizeHint();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQRadioButton().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQRadioButton().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQRadioButton().Event(e);
		}
		[SmokeMethod("hitButton(const QPoint&) const")]
		protected new bool HitButton(QPoint arg1) {
			return ProxyQRadioButton().HitButton(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQRadioButton().PaintEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQRadioButton().MouseMoveEvent(arg1);
		}
		~QRadioButton() {
			DisposeQRadioButton();
		}
		public new void Dispose() {
			DisposeQRadioButton();
		}
		[SmokeMethod("~QRadioButton()")]
		private void DisposeQRadioButton() {
			ProxyQRadioButton().DisposeQRadioButton();
		}
		protected new IQRadioButtonSignals Emit() {
			return (IQRadioButtonSignals) Q_EMIT;
		}
	}

	public interface IQRadioButtonSignals : IQAbstractButtonSignals {
	}
}
