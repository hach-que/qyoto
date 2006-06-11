//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QSizeGrip")]
	public class QSizeGrip : QWidget, IDisposable {
 		protected QSizeGrip(Type dummy) : base((Type) null) {}
		interface IQSizeGripProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSizeGrip), this);
			_interceptor = (QSizeGrip) realProxy.GetTransparentProxy();
		}
		private QSizeGrip ProxyQSizeGrip() {
			return (QSizeGrip) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSizeGrip() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSizeGripProxy), null);
			_staticInterceptor = (IQSizeGripProxy) realProxy.GetTransparentProxy();
		}
		private static IQSizeGripProxy StaticQSizeGrip() {
			return (IQSizeGripProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSizeGrip(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSizeGrip(parent);
		}
		[SmokeMethod("QSizeGrip(QWidget*)")]
		private void NewQSizeGrip(QWidget parent) {
			ProxyQSizeGrip().NewQSizeGrip(parent);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQSizeGrip().SizeHint();
		}
		[SmokeMethod("setVisible(bool)")]
		public new void SetVisible(bool arg1) {
			ProxyQSizeGrip().SetVisible(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSizeGrip().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSizeGrip().Tr(s);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQSizeGrip().PaintEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQSizeGrip().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQSizeGrip().MouseMoveEvent(arg1);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQSizeGrip().EventFilter(arg1,arg2);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQSizeGrip().Event(arg1);
		}
		~QSizeGrip() {
			DisposeQSizeGrip();
		}
		public new void Dispose() {
			DisposeQSizeGrip();
		}
		[SmokeMethod("~QSizeGrip()")]
		private void DisposeQSizeGrip() {
			ProxyQSizeGrip().DisposeQSizeGrip();
		}
		protected new IQSizeGripSignals Emit() {
			return (IQSizeGripSignals) Q_EMIT;
		}
	}

	public interface IQSizeGripSignals : IQWidgetSignals {
	}
}
