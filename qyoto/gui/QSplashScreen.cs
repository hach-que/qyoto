//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQSplashScreenSignals"></see> for signals emitted by QSplashScreen
	[SmokeClass("QSplashScreen")]
	public class QSplashScreen : QWidget, IDisposable {
 		protected QSplashScreen(Type dummy) : base((Type) null) {}
		interface IQSplashScreenProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSplashScreen), this);
			_interceptor = (QSplashScreen) realProxy.GetTransparentProxy();
		}
		private QSplashScreen ProxyQSplashScreen() {
			return (QSplashScreen) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSplashScreen() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSplashScreenProxy), null);
			_staticInterceptor = (IQSplashScreenProxy) realProxy.GetTransparentProxy();
		}
		private static IQSplashScreenProxy StaticQSplashScreen() {
			return (IQSplashScreenProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSplashScreen(QPixmap pixmap, int f) : this((Type) null) {
			CreateProxy();
			NewQSplashScreen(pixmap,f);
		}
		[SmokeMethod("QSplashScreen(const QPixmap&, Qt::WindowFlags)")]
		private void NewQSplashScreen(QPixmap pixmap, int f) {
			ProxyQSplashScreen().NewQSplashScreen(pixmap,f);
		}
		public QSplashScreen(QPixmap pixmap) : this((Type) null) {
			CreateProxy();
			NewQSplashScreen(pixmap);
		}
		[SmokeMethod("QSplashScreen(const QPixmap&)")]
		private void NewQSplashScreen(QPixmap pixmap) {
			ProxyQSplashScreen().NewQSplashScreen(pixmap);
		}
		public QSplashScreen() : this((Type) null) {
			CreateProxy();
			NewQSplashScreen();
		}
		[SmokeMethod("QSplashScreen()")]
		private void NewQSplashScreen() {
			ProxyQSplashScreen().NewQSplashScreen();
		}
		public QSplashScreen(QWidget parent, QPixmap pixmap, int f) : this((Type) null) {
			CreateProxy();
			NewQSplashScreen(parent,pixmap,f);
		}
		[SmokeMethod("QSplashScreen(QWidget*, const QPixmap&, Qt::WindowFlags)")]
		private void NewQSplashScreen(QWidget parent, QPixmap pixmap, int f) {
			ProxyQSplashScreen().NewQSplashScreen(parent,pixmap,f);
		}
		public QSplashScreen(QWidget parent, QPixmap pixmap) : this((Type) null) {
			CreateProxy();
			NewQSplashScreen(parent,pixmap);
		}
		[SmokeMethod("QSplashScreen(QWidget*, const QPixmap&)")]
		private void NewQSplashScreen(QWidget parent, QPixmap pixmap) {
			ProxyQSplashScreen().NewQSplashScreen(parent,pixmap);
		}
		public QSplashScreen(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSplashScreen(parent);
		}
		[SmokeMethod("QSplashScreen(QWidget*)")]
		private void NewQSplashScreen(QWidget parent) {
			ProxyQSplashScreen().NewQSplashScreen(parent);
		}
		[SmokeMethod("setPixmap(const QPixmap&)")]
		public void SetPixmap(QPixmap pixmap) {
			ProxyQSplashScreen().SetPixmap(pixmap);
		}
		[SmokeMethod("pixmap() const")]
		public QPixmap Pixmap() {
			return ProxyQSplashScreen().Pixmap();
		}
		[SmokeMethod("finish(QWidget*)")]
		public void Finish(QWidget w) {
			ProxyQSplashScreen().Finish(w);
		}
		[SmokeMethod("repaint()")]
		public new void Repaint() {
			ProxyQSplashScreen().Repaint();
		}
		[SmokeMethod("showMessage(const QString&, int, const QColor&)")]
		public void ShowMessage(string message, int alignment, QColor color) {
			ProxyQSplashScreen().ShowMessage(message,alignment,color);
		}
		[SmokeMethod("showMessage(const QString&, int)")]
		public void ShowMessage(string message, int alignment) {
			ProxyQSplashScreen().ShowMessage(message,alignment);
		}
		[SmokeMethod("showMessage(const QString&)")]
		public void ShowMessage(string message) {
			ProxyQSplashScreen().ShowMessage(message);
		}
		[SmokeMethod("clearMessage()")]
		public void ClearMessage() {
			ProxyQSplashScreen().ClearMessage();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSplashScreen().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSplashScreen().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQSplashScreen().Event(e);
		}
		[SmokeMethod("drawContents(QPainter*)")]
		protected virtual void DrawContents(QPainter painter) {
			ProxyQSplashScreen().DrawContents(painter);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQSplashScreen().MousePressEvent(arg1);
		}
		~QSplashScreen() {
			DisposeQSplashScreen();
		}
		public new void Dispose() {
			DisposeQSplashScreen();
		}
		[SmokeMethod("~QSplashScreen()")]
		private void DisposeQSplashScreen() {
			ProxyQSplashScreen().DisposeQSplashScreen();
		}
		protected new IQSplashScreenSignals Emit {
			get {
				return (IQSplashScreenSignals) Q_EMIT;
			}
		}
	}

	public interface IQSplashScreenSignals : IQWidgetSignals {
		[Q_SIGNAL("void messageChanged(const QString&)")]
		void MessageChanged(string message);
	}
}
