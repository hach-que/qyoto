//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQMainWindowSignals"></see> for signals emitted by QMainWindow
	[SmokeClass("QMainWindow")]
	public class QMainWindow : QWidget, IDisposable {
 		protected QMainWindow(Type dummy) : base((Type) null) {}
		[SmokeClass("QMainWindow")]
		interface IQMainWindowProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMainWindow), this);
			_interceptor = (QMainWindow) realProxy.GetTransparentProxy();
		}
		private QMainWindow ProxyQMainWindow() {
			return (QMainWindow) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMainWindow() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMainWindowProxy), null);
			_staticInterceptor = (IQMainWindowProxy) realProxy.GetTransparentProxy();
		}
		private static IQMainWindowProxy StaticQMainWindow() {
			return (IQMainWindowProxy) _staticInterceptor;
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
		[Q_PROPERTY("bool", "animated")]
		public bool Animated {
			get { return Property("animated").Value<bool>(); }
			set { SetProperty("animated", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("bool", "dockNestingEnabled")]
		public bool DockNestingEnabled {
			get { return Property("dockNestingEnabled").Value<bool>(); }
			set { SetProperty("dockNestingEnabled", QVariant.FromValue<bool>(value)); }
		}
		public QMainWindow(QWidget parent, int flags) : this((Type) null) {
			CreateProxy();
			NewQMainWindow(parent,flags);
		}
		[SmokeMethod("QMainWindow", "(QWidget*, Qt::WindowFlags)", "#$")]
		private void NewQMainWindow(QWidget parent, int flags) {
			ProxyQMainWindow().NewQMainWindow(parent,flags);
		}
		public QMainWindow(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMainWindow(parent);
		}
		[SmokeMethod("QMainWindow", "(QWidget*)", "#")]
		private void NewQMainWindow(QWidget parent) {
			ProxyQMainWindow().NewQMainWindow(parent);
		}
		public QMainWindow() : this((Type) null) {
			CreateProxy();
			NewQMainWindow();
		}
		[SmokeMethod("QMainWindow", "()", "")]
		private void NewQMainWindow() {
			ProxyQMainWindow().NewQMainWindow();
		}
		[SmokeMethod("isAnimated", "() const", "")]
		public bool IsAnimated() {
			return ProxyQMainWindow().IsAnimated();
		}
		[SmokeMethod("isDockNestingEnabled", "() const", "")]
		public bool IsDockNestingEnabled() {
			return ProxyQMainWindow().IsDockNestingEnabled();
		}
		[SmokeMethod("isSeparator", "(const QPoint&) const", "#")]
		public bool IsSeparator(QPoint pos) {
			return ProxyQMainWindow().IsSeparator(pos);
		}
		[SmokeMethod("menuBar", "() const", "")]
		public QMenuBar MenuBar() {
			return ProxyQMainWindow().MenuBar();
		}
		[SmokeMethod("setMenuBar", "(QMenuBar*)", "#")]
		public void SetMenuBar(QMenuBar menubar) {
			ProxyQMainWindow().SetMenuBar(menubar);
		}
		[SmokeMethod("menuWidget", "() const", "")]
		public QWidget MenuWidget() {
			return ProxyQMainWindow().MenuWidget();
		}
		[SmokeMethod("setMenuWidget", "(QWidget*)", "#")]
		public void SetMenuWidget(QWidget menubar) {
			ProxyQMainWindow().SetMenuWidget(menubar);
		}
		[SmokeMethod("statusBar", "() const", "")]
		public QStatusBar StatusBar() {
			return ProxyQMainWindow().StatusBar();
		}
		[SmokeMethod("setStatusBar", "(QStatusBar*)", "#")]
		public void SetStatusBar(QStatusBar statusbar) {
			ProxyQMainWindow().SetStatusBar(statusbar);
		}
		[SmokeMethod("centralWidget", "() const", "")]
		public QWidget CentralWidget() {
			return ProxyQMainWindow().CentralWidget();
		}
		[SmokeMethod("setCentralWidget", "(QWidget*)", "#")]
		public void SetCentralWidget(QWidget widget) {
			ProxyQMainWindow().SetCentralWidget(widget);
		}
		[SmokeMethod("setCorner", "(Qt::Corner, Qt::DockWidgetArea)", "$$")]
		public void SetCorner(Qt.Corner corner, Qt.DockWidgetArea area) {
			ProxyQMainWindow().SetCorner(corner,area);
		}
		[SmokeMethod("corner", "(Qt::Corner) const", "$")]
		public Qt.DockWidgetArea Corner(Qt.Corner corner) {
			return ProxyQMainWindow().Corner(corner);
		}
		[SmokeMethod("addToolBarBreak", "(Qt::ToolBarArea)", "$")]
		public void AddToolBarBreak(Qt.ToolBarArea area) {
			ProxyQMainWindow().AddToolBarBreak(area);
		}
		[SmokeMethod("addToolBarBreak", "()", "")]
		public void AddToolBarBreak() {
			ProxyQMainWindow().AddToolBarBreak();
		}
		[SmokeMethod("insertToolBarBreak", "(QToolBar*)", "#")]
		public void InsertToolBarBreak(QToolBar before) {
			ProxyQMainWindow().InsertToolBarBreak(before);
		}
		[SmokeMethod("addToolBar", "(Qt::ToolBarArea, QToolBar*)", "$#")]
		public void AddToolBar(Qt.ToolBarArea area, QToolBar toolbar) {
			ProxyQMainWindow().AddToolBar(area,toolbar);
		}
		[SmokeMethod("addToolBar", "(QToolBar*)", "#")]
		public void AddToolBar(QToolBar toolbar) {
			ProxyQMainWindow().AddToolBar(toolbar);
		}
		[SmokeMethod("addToolBar", "(const QString&)", "$")]
		public QToolBar AddToolBar(string title) {
			return ProxyQMainWindow().AddToolBar(title);
		}
		[SmokeMethod("insertToolBar", "(QToolBar*, QToolBar*)", "##")]
		public void InsertToolBar(QToolBar before, QToolBar toolbar) {
			ProxyQMainWindow().InsertToolBar(before,toolbar);
		}
		[SmokeMethod("removeToolBar", "(QToolBar*)", "#")]
		public void RemoveToolBar(QToolBar toolbar) {
			ProxyQMainWindow().RemoveToolBar(toolbar);
		}
		[SmokeMethod("toolBarArea", "(QToolBar*) const", "#")]
		public Qt.ToolBarArea ToolBarArea(QToolBar toolbar) {
			return ProxyQMainWindow().ToolBarArea(toolbar);
		}
		[SmokeMethod("addDockWidget", "(Qt::DockWidgetArea, QDockWidget*)", "$#")]
		public void AddDockWidget(Qt.DockWidgetArea area, QDockWidget dockwidget) {
			ProxyQMainWindow().AddDockWidget(area,dockwidget);
		}
		[SmokeMethod("addDockWidget", "(Qt::DockWidgetArea, QDockWidget*, Qt::Orientation)", "$#$")]
		public void AddDockWidget(Qt.DockWidgetArea area, QDockWidget dockwidget, Qt.Orientation orientation) {
			ProxyQMainWindow().AddDockWidget(area,dockwidget,orientation);
		}
		[SmokeMethod("splitDockWidget", "(QDockWidget*, QDockWidget*, Qt::Orientation)", "##$")]
		public void SplitDockWidget(QDockWidget after, QDockWidget dockwidget, Qt.Orientation orientation) {
			ProxyQMainWindow().SplitDockWidget(after,dockwidget,orientation);
		}
		[SmokeMethod("tabifyDockWidget", "(QDockWidget*, QDockWidget*)", "##")]
		public void TabifyDockWidget(QDockWidget first, QDockWidget second) {
			ProxyQMainWindow().TabifyDockWidget(first,second);
		}
		[SmokeMethod("removeDockWidget", "(QDockWidget*)", "#")]
		public void RemoveDockWidget(QDockWidget dockwidget) {
			ProxyQMainWindow().RemoveDockWidget(dockwidget);
		}
		[SmokeMethod("dockWidgetArea", "(QDockWidget*) const", "#")]
		public Qt.DockWidgetArea DockWidgetArea(QDockWidget dockwidget) {
			return ProxyQMainWindow().DockWidgetArea(dockwidget);
		}
		[SmokeMethod("saveState", "(int) const", "$")]
		public QByteArray SaveState(int version) {
			return ProxyQMainWindow().SaveState(version);
		}
		[SmokeMethod("saveState", "() const", "")]
		public QByteArray SaveState() {
			return ProxyQMainWindow().SaveState();
		}
		[SmokeMethod("restoreState", "(const QByteArray&, int)", "#$")]
		public bool RestoreState(QByteArray state, int version) {
			return ProxyQMainWindow().RestoreState(state,version);
		}
		[SmokeMethod("restoreState", "(const QByteArray&)", "#")]
		public bool RestoreState(QByteArray state) {
			return ProxyQMainWindow().RestoreState(state);
		}
		[SmokeMethod("createPopupMenu", "()", "")]
		public virtual QMenu CreatePopupMenu() {
			return ProxyQMainWindow().CreatePopupMenu();
		}
		[SmokeMethod("contextMenuEvent", "(QContextMenuEvent*)", "#")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQMainWindow().ContextMenuEvent(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent arg1) {
			return ProxyQMainWindow().Event(arg1);
		}
		~QMainWindow() {
			DisposeQMainWindow();
		}
		public new void Dispose() {
			DisposeQMainWindow();
		}
		[SmokeMethod("~QMainWindow", "()", "")]
		private void DisposeQMainWindow() {
			ProxyQMainWindow().DisposeQMainWindow();
		}
		public static string Tr(string s, string c) {
			return StaticQMainWindow().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQMainWindow().Tr(s);
		}
		protected new IQMainWindowSignals Emit {
			get { return (IQMainWindowSignals) Q_EMIT; }
		}
	}

	public interface IQMainWindowSignals : IQWidgetSignals {
		[Q_SIGNAL("void iconSizeChanged(const QSize&)")]
		void IconSizeChanged(QSize iconSize);
		[Q_SIGNAL("void toolButtonStyleChanged(Qt::ToolButtonStyle)")]
		void ToolButtonStyleChanged(Qt.ToolButtonStyle toolButtonStyle);
	}
}
