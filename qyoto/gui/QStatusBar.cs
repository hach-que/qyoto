//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQStatusBarSignals"></see> for signals emitted by QStatusBar
	[SmokeClass("QStatusBar")]
	public class QStatusBar : QWidget, IDisposable {
 		protected QStatusBar(Type dummy) : base((Type) null) {}
		interface IQStatusBarProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStatusBar), this);
			_interceptor = (QStatusBar) realProxy.GetTransparentProxy();
		}
		private QStatusBar ProxyQStatusBar() {
			return (QStatusBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStatusBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStatusBarProxy), null);
			_staticInterceptor = (IQStatusBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQStatusBarProxy StaticQStatusBar() {
			return (IQStatusBarProxy) _staticInterceptor;
		}

		public bool SizeGripEnabled {
			get {
				return Property("sizeGripEnabled").Value<bool>();
			}
			set {
				SetProperty("sizeGripEnabled", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QStatusBar(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQStatusBar(parent);
		}
		[SmokeMethod("QStatusBar(QWidget*)")]
		private void NewQStatusBar(QWidget parent) {
			ProxyQStatusBar().NewQStatusBar(parent);
		}
		public QStatusBar() : this((Type) null) {
			CreateProxy();
			NewQStatusBar();
		}
		[SmokeMethod("QStatusBar()")]
		private void NewQStatusBar() {
			ProxyQStatusBar().NewQStatusBar();
		}
		[SmokeMethod("addWidget(QWidget*, int)")]
		public void AddWidget(QWidget widget, int stretch) {
			ProxyQStatusBar().AddWidget(widget,stretch);
		}
		[SmokeMethod("addWidget(QWidget*)")]
		public void AddWidget(QWidget widget) {
			ProxyQStatusBar().AddWidget(widget);
		}
		[SmokeMethod("insertWidget(int, QWidget*, int)")]
		public int InsertWidget(int index, QWidget widget, int stretch) {
			return ProxyQStatusBar().InsertWidget(index,widget,stretch);
		}
		[SmokeMethod("insertWidget(int, QWidget*)")]
		public int InsertWidget(int index, QWidget widget) {
			return ProxyQStatusBar().InsertWidget(index,widget);
		}
		[SmokeMethod("addPermanentWidget(QWidget*, int)")]
		public void AddPermanentWidget(QWidget widget, int stretch) {
			ProxyQStatusBar().AddPermanentWidget(widget,stretch);
		}
		[SmokeMethod("addPermanentWidget(QWidget*)")]
		public void AddPermanentWidget(QWidget widget) {
			ProxyQStatusBar().AddPermanentWidget(widget);
		}
		[SmokeMethod("insertPermanentWidget(int, QWidget*, int)")]
		public int InsertPermanentWidget(int index, QWidget widget, int stretch) {
			return ProxyQStatusBar().InsertPermanentWidget(index,widget,stretch);
		}
		[SmokeMethod("insertPermanentWidget(int, QWidget*)")]
		public int InsertPermanentWidget(int index, QWidget widget) {
			return ProxyQStatusBar().InsertPermanentWidget(index,widget);
		}
		[SmokeMethod("removeWidget(QWidget*)")]
		public void RemoveWidget(QWidget widget) {
			ProxyQStatusBar().RemoveWidget(widget);
		}
		[SmokeMethod("isSizeGripEnabled() const")]
		public bool IsSizeGripEnabled() {
			return ProxyQStatusBar().IsSizeGripEnabled();
		}
		[SmokeMethod("currentMessage() const")]
		public string CurrentMessage() {
			return ProxyQStatusBar().CurrentMessage();
		}
		[SmokeMethod("showMessage(const QString&, int)")]
		public void ShowMessage(string text, int timeout) {
			ProxyQStatusBar().ShowMessage(text,timeout);
		}
		[SmokeMethod("showMessage(const QString&)")]
		public void ShowMessage(string text) {
			ProxyQStatusBar().ShowMessage(text);
		}
		[SmokeMethod("clearMessage()")]
		public void ClearMessage() {
			ProxyQStatusBar().ClearMessage();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQStatusBar().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQStatusBar().Tr(s);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQStatusBar().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQStatusBar().ResizeEvent(arg1);
		}
		[SmokeMethod("reformat()")]
		protected void Reformat() {
			ProxyQStatusBar().Reformat();
		}
		[SmokeMethod("hideOrShow()")]
		protected void HideOrShow() {
			ProxyQStatusBar().HideOrShow();
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQStatusBar().Event(arg1);
		}
		~QStatusBar() {
			DisposeQStatusBar();
		}
		public new void Dispose() {
			DisposeQStatusBar();
		}
		[SmokeMethod("~QStatusBar()")]
		private void DisposeQStatusBar() {
			ProxyQStatusBar().DisposeQStatusBar();
		}
		protected new IQStatusBarSignals Emit {
			get {
				return (IQStatusBarSignals) Q_EMIT;
			}
		}
	}

	public interface IQStatusBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void messageChanged(const QString&)")]
		void MessageChanged(string text);
	}
}
