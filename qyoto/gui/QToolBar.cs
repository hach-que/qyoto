//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQToolBarSignals"></see> for signals emitted by QToolBar
	[SmokeClass("QToolBar")]
	public class QToolBar : QWidget, IDisposable {
 		protected QToolBar(Type dummy) : base((Type) null) {}
		[SmokeClass("QToolBar")]
		interface IQToolBarProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolBar), this);
			interceptor = (QToolBar) realProxy.GetTransparentProxy();
		}
		private static IQToolBarProxy staticInterceptor = null;
		static QToolBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolBarProxy), null);
			staticInterceptor = (IQToolBarProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("bool", "movable")]
		public bool Movable {
			get { return Property("movable").Value<bool>(); }
			set { SetProperty("movable", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("Qt::ToolBarAreas", "allowedAreas")]
		public int AllowedAreas {
			get { return Property("allowedAreas").Value<int>(); }
			set { SetProperty("allowedAreas", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			get { return Property("orientation").Value<Qt.Orientation>(); }
			set { SetProperty("orientation", QVariant.FromValue<Qt.Orientation>(value)); }
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get { return Property("iconSize").Value<QSize>(); }
			set { SetProperty("iconSize", QVariant.FromValue<QSize>(value)); }
		}
		[Q_PROPERTY("Qt::ToolButtonStyle", "toolButtonStyle")]
		public Qt.ToolButtonStyle ToolButtonStyle {
			get { return Property("toolButtonStyle").Value<Qt.ToolButtonStyle>(); }
			set { SetProperty("toolButtonStyle", QVariant.FromValue<Qt.ToolButtonStyle>(value)); }
		}
		public QToolBar(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQToolBar(title,parent);
		}
		[SmokeMethod("QToolBar", "(const QString&, QWidget*)", "$#")]
		private void NewQToolBar(string title, QWidget parent) {
			((QToolBar) interceptor).NewQToolBar(title,parent);
		}
		public QToolBar(string title) : this((Type) null) {
			CreateProxy();
			NewQToolBar(title);
		}
		[SmokeMethod("QToolBar", "(const QString&)", "$")]
		private void NewQToolBar(string title) {
			((QToolBar) interceptor).NewQToolBar(title);
		}
		public QToolBar(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQToolBar(parent);
		}
		[SmokeMethod("QToolBar", "(QWidget*)", "#")]
		private void NewQToolBar(QWidget parent) {
			((QToolBar) interceptor).NewQToolBar(parent);
		}
		public QToolBar() : this((Type) null) {
			CreateProxy();
			NewQToolBar();
		}
		[SmokeMethod("QToolBar", "()", "")]
		private void NewQToolBar() {
			((QToolBar) interceptor).NewQToolBar();
		}
		[SmokeMethod("isMovable", "() const", "")]
		public bool IsMovable() {
			return ((QToolBar) interceptor).IsMovable();
		}
		[SmokeMethod("isAreaAllowed", "(Qt::ToolBarArea) const", "$")]
		public bool IsAreaAllowed(Qt.ToolBarArea area) {
			return ((QToolBar) interceptor).IsAreaAllowed(area);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			((QToolBar) interceptor).Clear();
		}
		[SmokeMethod("addAction", "(QAction*)", "#")]
		public void AddAction(QAction action) {
			((QToolBar) interceptor).AddAction(action);
		}
		[SmokeMethod("addAction", "(const QString&)", "$")]
		public QAction AddAction(string text) {
			return ((QToolBar) interceptor).AddAction(text);
		}
		[SmokeMethod("addAction", "(const QIcon&, const QString&)", "#$")]
		public QAction AddAction(QIcon icon, string text) {
			return ((QToolBar) interceptor).AddAction(icon,text);
		}
		[SmokeMethod("addAction", "(const QString&, const QObject*, const char*)", "$#$")]
		public QAction AddAction(string text, QObject receiver, string member) {
			return ((QToolBar) interceptor).AddAction(text,receiver,member);
		}
		[SmokeMethod("addAction", "(const QIcon&, const QString&, const QObject*, const char*)", "#$#$")]
		public QAction AddAction(QIcon icon, string text, QObject receiver, string member) {
			return ((QToolBar) interceptor).AddAction(icon,text,receiver,member);
		}
		[SmokeMethod("addSeparator", "()", "")]
		public QAction AddSeparator() {
			return ((QToolBar) interceptor).AddSeparator();
		}
		[SmokeMethod("insertSeparator", "(QAction*)", "#")]
		public QAction InsertSeparator(QAction before) {
			return ((QToolBar) interceptor).InsertSeparator(before);
		}
		[SmokeMethod("addWidget", "(QWidget*)", "#")]
		public QAction AddWidget(QWidget widget) {
			return ((QToolBar) interceptor).AddWidget(widget);
		}
		[SmokeMethod("insertWidget", "(QAction*, QWidget*)", "##")]
		public QAction InsertWidget(QAction before, QWidget widget) {
			return ((QToolBar) interceptor).InsertWidget(before,widget);
		}
		[SmokeMethod("actionGeometry", "(QAction*) const", "#")]
		public QRect ActionGeometry(QAction action) {
			return ((QToolBar) interceptor).ActionGeometry(action);
		}
		[SmokeMethod("actionAt", "(const QPoint&) const", "#")]
		public QAction ActionAt(QPoint p) {
			return ((QToolBar) interceptor).ActionAt(p);
		}
		[SmokeMethod("actionAt", "(int, int) const", "$$")]
		public QAction ActionAt(int x, int y) {
			return ((QToolBar) interceptor).ActionAt(x,y);
		}
		[SmokeMethod("toggleViewAction", "() const", "")]
		public QAction ToggleViewAction() {
			return ((QToolBar) interceptor).ToggleViewAction();
		}
		[SmokeMethod("widgetForAction", "(QAction*) const", "#")]
		public QWidget WidgetForAction(QAction action) {
			return ((QToolBar) interceptor).WidgetForAction(action);
		}
		[SmokeMethod("actionEvent", "(QActionEvent*)", "#")]
		protected override void ActionEvent(QActionEvent arg1) {
			((QToolBar) interceptor).ActionEvent(arg1);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			((QToolBar) interceptor).ChangeEvent(arg1);
		}
		[SmokeMethod("childEvent", "(QChildEvent*)", "#")]
		protected override void ChildEvent(QChildEvent arg1) {
			((QToolBar) interceptor).ChildEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			((QToolBar) interceptor).PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			((QToolBar) interceptor).ResizeEvent(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent arg1) {
			return ((QToolBar) interceptor).Event(arg1);
		}
		~QToolBar() {
			DisposeQToolBar();
		}
		public new void Dispose() {
			DisposeQToolBar();
		}
		[SmokeMethod("~QToolBar", "()", "")]
		private void DisposeQToolBar() {
			((QToolBar) interceptor).DisposeQToolBar();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQToolBarSignals Emit {
			get { return (IQToolBarSignals) Q_EMIT; }
		}
	}

	public interface IQToolBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void actionTriggered(QAction*)")]
		void ActionTriggered(QAction action);
		[Q_SIGNAL("void movableChanged(bool)")]
		void MovableChanged(bool movable);
		[Q_SIGNAL("void allowedAreasChanged(Qt::ToolBarAreas)")]
		void AllowedAreasChanged(int allowedAreas);
		[Q_SIGNAL("void orientationChanged(Qt::Orientation)")]
		void OrientationChanged(Qt.Orientation orientation);
		[Q_SIGNAL("void iconSizeChanged(const QSize&)")]
		void IconSizeChanged(QSize iconSize);
		[Q_SIGNAL("void toolButtonStyleChanged(Qt::ToolButtonStyle)")]
		void ToolButtonStyleChanged(Qt.ToolButtonStyle toolButtonStyle);
	}
}
