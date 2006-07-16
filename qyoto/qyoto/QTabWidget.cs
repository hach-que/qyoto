//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQTabWidgetSignals"></see> for signals emitted by QTabWidget
	[SmokeClass("QTabWidget")]
	public class QTabWidget : QWidget, IDisposable {
 		protected QTabWidget(Type dummy) : base((Type) null) {}
		interface IQTabWidgetProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTabWidget), this);
			_interceptor = (QTabWidget) realProxy.GetTransparentProxy();
		}
		private QTabWidget ProxyQTabWidget() {
			return (QTabWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTabWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTabWidgetProxy), null);
			_staticInterceptor = (IQTabWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQTabWidgetProxy StaticQTabWidget() {
			return (IQTabWidgetProxy) _staticInterceptor;
		}

		public enum TabPosition {
			North = 0,
			South = 1,
			West = 2,
			East = 3,
		}
		public enum TabShape {
			Rounded = 0,
			Triangular = 1,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTabWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTabWidget(parent);
		}
		[SmokeMethod("QTabWidget(QWidget*)")]
		private void NewQTabWidget(QWidget parent) {
			ProxyQTabWidget().NewQTabWidget(parent);
		}
		public QTabWidget() : this((Type) null) {
			CreateProxy();
			NewQTabWidget();
		}
		[SmokeMethod("QTabWidget()")]
		private void NewQTabWidget() {
			ProxyQTabWidget().NewQTabWidget();
		}
		[SmokeMethod("addTab(QWidget*, const QString&)")]
		public int AddTab(QWidget widget, string arg2) {
			return ProxyQTabWidget().AddTab(widget,arg2);
		}
		[SmokeMethod("addTab(QWidget*, const QIcon&, const QString&)")]
		public int AddTab(QWidget widget, QIcon icon, string label) {
			return ProxyQTabWidget().AddTab(widget,icon,label);
		}
		[SmokeMethod("insertTab(int, QWidget*, const QString&)")]
		public int InsertTab(int index, QWidget widget, string arg3) {
			return ProxyQTabWidget().InsertTab(index,widget,arg3);
		}
		[SmokeMethod("insertTab(int, QWidget*, const QIcon&, const QString&)")]
		public int InsertTab(int index, QWidget widget, QIcon icon, string label) {
			return ProxyQTabWidget().InsertTab(index,widget,icon,label);
		}
		[SmokeMethod("removeTab(int)")]
		public void RemoveTab(int index) {
			ProxyQTabWidget().RemoveTab(index);
		}
		[SmokeMethod("isTabEnabled(int) const")]
		public bool IsTabEnabled(int index) {
			return ProxyQTabWidget().IsTabEnabled(index);
		}
		[SmokeMethod("setTabEnabled(int, bool)")]
		public void SetTabEnabled(int index, bool arg2) {
			ProxyQTabWidget().SetTabEnabled(index,arg2);
		}
		[SmokeMethod("tabText(int) const")]
		public string TabText(int index) {
			return ProxyQTabWidget().TabText(index);
		}
		[SmokeMethod("setTabText(int, const QString&)")]
		public void SetTabText(int index, string arg2) {
			ProxyQTabWidget().SetTabText(index,arg2);
		}
		[SmokeMethod("tabIcon(int) const")]
		public QIcon TabIcon(int index) {
			return ProxyQTabWidget().TabIcon(index);
		}
		[SmokeMethod("setTabIcon(int, const QIcon&)")]
		public void SetTabIcon(int index, QIcon icon) {
			ProxyQTabWidget().SetTabIcon(index,icon);
		}
		[SmokeMethod("setTabToolTip(int, const QString&)")]
		public void SetTabToolTip(int index, string tip) {
			ProxyQTabWidget().SetTabToolTip(index,tip);
		}
		[SmokeMethod("tabToolTip(int) const")]
		public string TabToolTip(int index) {
			return ProxyQTabWidget().TabToolTip(index);
		}
		[SmokeMethod("setTabWhatsThis(int, const QString&)")]
		public void SetTabWhatsThis(int index, string text) {
			ProxyQTabWidget().SetTabWhatsThis(index,text);
		}
		[SmokeMethod("tabWhatsThis(int) const")]
		public string TabWhatsThis(int index) {
			return ProxyQTabWidget().TabWhatsThis(index);
		}
		[SmokeMethod("currentIndex() const")]
		public int CurrentIndex() {
			return ProxyQTabWidget().CurrentIndex();
		}
		[SmokeMethod("currentWidget() const")]
		public QWidget CurrentWidget() {
			return ProxyQTabWidget().CurrentWidget();
		}
		[SmokeMethod("widget(int) const")]
		public QWidget Widget(int index) {
			return ProxyQTabWidget().Widget(index);
		}
		[SmokeMethod("indexOf(QWidget*) const")]
		public int IndexOf(QWidget widget) {
			return ProxyQTabWidget().IndexOf(widget);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQTabWidget().Count();
		}
		[SmokeMethod("tabPosition() const")]
		public QTabWidget.TabPosition tabPosition() {
			return ProxyQTabWidget().tabPosition();
		}
		[SmokeMethod("setTabPosition(QTabWidget::TabPosition)")]
		public void SetTabPosition(QTabWidget.TabPosition arg1) {
			ProxyQTabWidget().SetTabPosition(arg1);
		}
		[SmokeMethod("tabShape() const")]
		public QTabWidget.TabShape tabShape() {
			return ProxyQTabWidget().tabShape();
		}
		[SmokeMethod("setTabShape(QTabWidget::TabShape)")]
		public void SetTabShape(QTabWidget.TabShape s) {
			ProxyQTabWidget().SetTabShape(s);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQTabWidget().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQTabWidget().MinimumSizeHint();
		}
		[SmokeMethod("setCornerWidget(QWidget*, Qt::Corner)")]
		public void SetCornerWidget(QWidget w, Qt.Corner corner) {
			ProxyQTabWidget().SetCornerWidget(w,corner);
		}
		[SmokeMethod("setCornerWidget(QWidget*)")]
		public void SetCornerWidget(QWidget w) {
			ProxyQTabWidget().SetCornerWidget(w);
		}
		[SmokeMethod("cornerWidget(Qt::Corner) const")]
		public QWidget CornerWidget(Qt.Corner corner) {
			return ProxyQTabWidget().CornerWidget(corner);
		}
		[SmokeMethod("cornerWidget() const")]
		public QWidget CornerWidget() {
			return ProxyQTabWidget().CornerWidget();
		}
		[SmokeMethod("elideMode() const")]
		public Qt.TextElideMode ElideMode() {
			return ProxyQTabWidget().ElideMode();
		}
		[SmokeMethod("setElideMode(Qt::TextElideMode)")]
		public void SetElideMode(Qt.TextElideMode arg1) {
			ProxyQTabWidget().SetElideMode(arg1);
		}
		[SmokeMethod("iconSize() const")]
		public QSize IconSize() {
			return ProxyQTabWidget().IconSize();
		}
		[SmokeMethod("setIconSize(const QSize&)")]
		public void SetIconSize(QSize size) {
			ProxyQTabWidget().SetIconSize(size);
		}
		[SmokeMethod("usesScrollButtons() const")]
		public bool UsesScrollButtons() {
			return ProxyQTabWidget().UsesScrollButtons();
		}
		[SmokeMethod("setUsesScrollButtons(bool)")]
		public void SetUsesScrollButtons(bool useButtons) {
			ProxyQTabWidget().SetUsesScrollButtons(useButtons);
		}
		[SmokeMethod("setCurrentIndex(int)")]
		public void SetCurrentIndex(int index) {
			ProxyQTabWidget().SetCurrentIndex(index);
		}
		[SmokeMethod("setCurrentWidget(QWidget*)")]
		public void SetCurrentWidget(QWidget widget) {
			ProxyQTabWidget().SetCurrentWidget(widget);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTabWidget().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTabWidget().Tr(s);
		}
		[SmokeMethod("tabInserted(int)")]
		protected virtual void TabInserted(int index) {
			ProxyQTabWidget().TabInserted(index);
		}
		[SmokeMethod("tabRemoved(int)")]
		protected virtual void TabRemoved(int index) {
			ProxyQTabWidget().TabRemoved(index);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQTabWidget().ShowEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQTabWidget().ResizeEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQTabWidget().KeyPressEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQTabWidget().PaintEvent(arg1);
		}
		[SmokeMethod("setTabBar(QTabBar*)")]
		protected void SetTabBar(QTabBar arg1) {
			ProxyQTabWidget().SetTabBar(arg1);
		}
		[SmokeMethod("tabBar() const")]
		protected QTabBar TabBar() {
			return ProxyQTabWidget().TabBar();
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQTabWidget().ChangeEvent(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQTabWidget().Event(arg1);
		}
		~QTabWidget() {
			DisposeQTabWidget();
		}
		public new void Dispose() {
			DisposeQTabWidget();
		}
		[SmokeMethod("~QTabWidget()")]
		private void DisposeQTabWidget() {
			ProxyQTabWidget().DisposeQTabWidget();
		}
		protected new IQTabWidgetSignals Emit() {
			return (IQTabWidgetSignals) Q_EMIT;
		}
	}

	public interface IQTabWidgetSignals : IQWidgetSignals {
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int index);
	}
}
