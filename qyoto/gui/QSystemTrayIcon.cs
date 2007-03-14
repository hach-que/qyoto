//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQSystemTrayIconSignals"></see> for signals emitted by QSystemTrayIcon
	[SmokeClass("QSystemTrayIcon")]
	public class QSystemTrayIcon : QObject, IDisposable {
 		protected QSystemTrayIcon(Type dummy) : base((Type) null) {}
		[SmokeClass("QSystemTrayIcon")]
		interface IQSystemTrayIconProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("isSystemTrayAvailable", "()", "")]
			bool IsSystemTrayAvailable();
			[SmokeMethod("supportsMessages", "()", "")]
			bool SupportsMessages();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSystemTrayIcon), this);
			_interceptor = (QSystemTrayIcon) realProxy.GetTransparentProxy();
		}
		private QSystemTrayIcon ProxyQSystemTrayIcon() {
			return (QSystemTrayIcon) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSystemTrayIcon() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSystemTrayIconProxy), null);
			_staticInterceptor = (IQSystemTrayIconProxy) realProxy.GetTransparentProxy();
		}
		private static IQSystemTrayIconProxy StaticQSystemTrayIcon() {
			return (IQSystemTrayIconProxy) _staticInterceptor;
		}
		public enum ActivationReason {
			Unknown = 0,
			Context = 1,
			DoubleClick = 2,
			Trigger = 3,
			MiddleClick = 4,
		}
		public enum MessageIcon {
			NoIcon = 0,
			Information = 1,
			Warning = 2,
			Critical = 3,
		}
		[Q_PROPERTY("QString", "toolTip")]
		public string ToolTip {
			get { return Property("toolTip").Value<string>(); }
			set { SetProperty("toolTip", QVariant.FromValue<string>(value)); }
		}
		[Q_PROPERTY("QIcon", "icon")]
		public QIcon Icon {
			get { return Property("icon").Value<QIcon>(); }
			set { SetProperty("icon", QVariant.FromValue<QIcon>(value)); }
		}
		[Q_PROPERTY("bool", "visible")]
		public bool Visible {
			get { return Property("visible").Value<bool>(); }
			set { SetProperty("visible", QVariant.FromValue<bool>(value)); }
		}
		public QSystemTrayIcon(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSystemTrayIcon(parent);
		}
		[SmokeMethod("QSystemTrayIcon", "(QObject*)", "#")]
		private void NewQSystemTrayIcon(QObject parent) {
			ProxyQSystemTrayIcon().NewQSystemTrayIcon(parent);
		}
		public QSystemTrayIcon() : this((Type) null) {
			CreateProxy();
			NewQSystemTrayIcon();
		}
		[SmokeMethod("QSystemTrayIcon", "()", "")]
		private void NewQSystemTrayIcon() {
			ProxyQSystemTrayIcon().NewQSystemTrayIcon();
		}
		public QSystemTrayIcon(QIcon icon, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSystemTrayIcon(icon,parent);
		}
		[SmokeMethod("QSystemTrayIcon", "(const QIcon&, QObject*)", "##")]
		private void NewQSystemTrayIcon(QIcon icon, QObject parent) {
			ProxyQSystemTrayIcon().NewQSystemTrayIcon(icon,parent);
		}
		public QSystemTrayIcon(QIcon icon) : this((Type) null) {
			CreateProxy();
			NewQSystemTrayIcon(icon);
		}
		[SmokeMethod("QSystemTrayIcon", "(const QIcon&)", "#")]
		private void NewQSystemTrayIcon(QIcon icon) {
			ProxyQSystemTrayIcon().NewQSystemTrayIcon(icon);
		}
		[SmokeMethod("setContextMenu", "(QMenu*)", "#")]
		public void SetContextMenu(QMenu menu) {
			ProxyQSystemTrayIcon().SetContextMenu(menu);
		}
		[SmokeMethod("contextMenu", "() const", "")]
		public QMenu ContextMenu() {
			return ProxyQSystemTrayIcon().ContextMenu();
		}
		[SmokeMethod("showMessage", "(const QString&, const QString&, QSystemTrayIcon::MessageIcon, int)", "$$$$")]
		public void ShowMessage(string title, string msg, QSystemTrayIcon.MessageIcon icon, int msecs) {
			ProxyQSystemTrayIcon().ShowMessage(title,msg,icon,msecs);
		}
		[SmokeMethod("showMessage", "(const QString&, const QString&, QSystemTrayIcon::MessageIcon)", "$$$")]
		public void ShowMessage(string title, string msg, QSystemTrayIcon.MessageIcon icon) {
			ProxyQSystemTrayIcon().ShowMessage(title,msg,icon);
		}
		[SmokeMethod("showMessage", "(const QString&, const QString&)", "$$")]
		public void ShowMessage(string title, string msg) {
			ProxyQSystemTrayIcon().ShowMessage(title,msg);
		}
		[SmokeMethod("isVisible", "() const", "")]
		public bool IsVisible() {
			return ProxyQSystemTrayIcon().IsVisible();
		}
		[Q_SLOT("void show()")]
		[SmokeMethod("show", "()", "")]
		public void Show() {
			ProxyQSystemTrayIcon().Show();
		}
		[Q_SLOT("void hide()")]
		[SmokeMethod("hide", "()", "")]
		public void Hide() {
			ProxyQSystemTrayIcon().Hide();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected new virtual bool Event(QEvent arg1) {
			return ProxyQSystemTrayIcon().Event(arg1);
		}
		~QSystemTrayIcon() {
			DisposeQSystemTrayIcon();
		}
		public new void Dispose() {
			DisposeQSystemTrayIcon();
		}
		[SmokeMethod("~QSystemTrayIcon", "()", "")]
		private void DisposeQSystemTrayIcon() {
			ProxyQSystemTrayIcon().DisposeQSystemTrayIcon();
		}
		public static string Tr(string s, string c) {
			return StaticQSystemTrayIcon().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQSystemTrayIcon().Tr(s);
		}
		public static bool IsSystemTrayAvailable() {
			return StaticQSystemTrayIcon().IsSystemTrayAvailable();
		}
		public static bool SupportsMessages() {
			return StaticQSystemTrayIcon().SupportsMessages();
		}
		protected new IQSystemTrayIconSignals Emit {
			get { return (IQSystemTrayIconSignals) Q_EMIT; }
		}
	}

	public interface IQSystemTrayIconSignals : IQObjectSignals {
		[Q_SIGNAL("void activated(QSystemTrayIcon::ActivationReason)")]
		void Activated(QSystemTrayIcon.ActivationReason reason);
		[Q_SIGNAL("void messageClicked()")]
		void MessageClicked();
	}
}
