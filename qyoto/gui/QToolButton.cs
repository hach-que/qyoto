//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQToolButtonSignals"></see> for signals emitted by QToolButton
	[SmokeClass("QToolButton")]
	public class QToolButton : QAbstractButton, IDisposable {
 		protected QToolButton(Type dummy) : base((Type) null) {}
		[SmokeClass("QToolButton")]
		interface IQToolButtonProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolButton), this);
			_interceptor = (QToolButton) realProxy.GetTransparentProxy();
		}
		private QToolButton ProxyQToolButton() {
			return (QToolButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolButtonProxy), null);
			_staticInterceptor = (IQToolButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolButtonProxy StaticQToolButton() {
			return (IQToolButtonProxy) _staticInterceptor;
		}
		public enum ToolButtonPopupMode {
			DelayedPopup = 0,
			MenuButtonPopup = 1,
			InstantPopup = 2,
		}
		[Q_PROPERTY("QToolButton::ToolButtonPopupMode", "popupMode")]
		public QToolButton.ToolButtonPopupMode PopupMode {
			get { return Property("popupMode").Value<QToolButton.ToolButtonPopupMode>(); }
			set { SetProperty("popupMode", QVariant.FromValue<QToolButton.ToolButtonPopupMode>(value)); }
		}
		[Q_PROPERTY("Qt::ToolButtonStyle", "toolButtonStyle")]
		public Qt.ToolButtonStyle ToolButtonStyle {
			get { return Property("toolButtonStyle").Value<Qt.ToolButtonStyle>(); }
			set { SetProperty("toolButtonStyle", QVariant.FromValue<Qt.ToolButtonStyle>(value)); }
		}
		[Q_PROPERTY("bool", "autoRaise")]
		public bool AutoRaise {
			get { return Property("autoRaise").Value<bool>(); }
			set { SetProperty("autoRaise", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("Qt::ArrowType", "arrowType")]
		public Qt.ArrowType ArrowType {
			get { return Property("arrowType").Value<Qt.ArrowType>(); }
			set { SetProperty("arrowType", QVariant.FromValue<Qt.ArrowType>(value)); }
		}
		public QToolButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQToolButton(parent);
		}
		[SmokeMethod("QToolButton", "(QWidget*)", "#")]
		private void NewQToolButton(QWidget parent) {
			ProxyQToolButton().NewQToolButton(parent);
		}
		public QToolButton() : this((Type) null) {
			CreateProxy();
			NewQToolButton();
		}
		[SmokeMethod("QToolButton", "()", "")]
		private void NewQToolButton() {
			ProxyQToolButton().NewQToolButton();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ProxyQToolButton().SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ProxyQToolButton().MinimumSizeHint();
		}
		[SmokeMethod("setMenu", "(QMenu*)", "#")]
		public void SetMenu(QMenu menu) {
			ProxyQToolButton().SetMenu(menu);
		}
		[SmokeMethod("menu", "() const", "")]
		public QMenu Menu() {
			return ProxyQToolButton().Menu();
		}
		[SmokeMethod("defaultAction", "() const", "")]
		public QAction DefaultAction() {
			return ProxyQToolButton().DefaultAction();
		}
		[Q_SLOT("void showMenu()")]
		[SmokeMethod("showMenu", "()", "")]
		public void ShowMenu() {
			ProxyQToolButton().ShowMenu();
		}
		[Q_SLOT("void setDefaultAction(QAction*)")]
		[SmokeMethod("setDefaultAction", "(QAction*)", "#")]
		public void SetDefaultAction(QAction arg1) {
			ProxyQToolButton().SetDefaultAction(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ProxyQToolButton().Event(e);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			ProxyQToolButton().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQToolButton().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			ProxyQToolButton().PaintEvent(arg1);
		}
		[SmokeMethod("actionEvent", "(QActionEvent*)", "#")]
		protected override void ActionEvent(QActionEvent arg1) {
			ProxyQToolButton().ActionEvent(arg1);
		}
		[SmokeMethod("enterEvent", "(QEvent*)", "#")]
		protected override void EnterEvent(QEvent arg1) {
			ProxyQToolButton().EnterEvent(arg1);
		}
		[SmokeMethod("leaveEvent", "(QEvent*)", "#")]
		protected override void LeaveEvent(QEvent arg1) {
			ProxyQToolButton().LeaveEvent(arg1);
		}
		[SmokeMethod("timerEvent", "(QTimerEvent*)", "#")]
		protected override void TimerEvent(QTimerEvent arg1) {
			ProxyQToolButton().TimerEvent(arg1);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			ProxyQToolButton().ChangeEvent(arg1);
		}
		[SmokeMethod("hitButton", "(const QPoint&) const", "#")]
		protected override bool HitButton(QPoint pos) {
			return ProxyQToolButton().HitButton(pos);
		}
		[SmokeMethod("nextCheckState", "()", "")]
		protected override void NextCheckState() {
			ProxyQToolButton().NextCheckState();
		}
		~QToolButton() {
			DisposeQToolButton();
		}
		public new void Dispose() {
			DisposeQToolButton();
		}
		[SmokeMethod("~QToolButton", "()", "")]
		private void DisposeQToolButton() {
			ProxyQToolButton().DisposeQToolButton();
		}
		public static string Tr(string s, string c) {
			return StaticQToolButton().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQToolButton().Tr(s);
		}
		protected new IQToolButtonSignals Emit {
			get { return (IQToolButtonSignals) Q_EMIT; }
		}
	}

	public interface IQToolButtonSignals : IQAbstractButtonSignals {
		[Q_SIGNAL("void triggered(QAction*)")]
		void Triggered(QAction arg1);
	}
}
