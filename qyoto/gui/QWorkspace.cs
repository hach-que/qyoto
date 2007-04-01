//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQWorkspaceSignals"></see> for signals emitted by QWorkspace
	[SmokeClass("QWorkspace")]
	public class QWorkspace : QWidget, IDisposable {
 		protected QWorkspace(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QWorkspace), "QWorkspace", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QWorkspace() {
			staticInterceptor = new SmokeInvocation(typeof(QWorkspace), "QWorkspace", null);
		}
		public enum WindowOrder {
			CreationOrder = 0,
			StackingOrder = 1,
		}
		[Q_PROPERTY("bool", "scrollBarsEnabled")]
		public bool ScrollBarsEnabled {
			get { return (bool) interceptor.Invoke("scrollBarsEnabled", "scrollBarsEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setScrollBarsEnabled$", "setScrollBarsEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QBrush", "background")]
		public QBrush Background {
			get { return (QBrush) interceptor.Invoke("background", "background()", typeof(QBrush)); }
			set { interceptor.Invoke("setBackground#", "setBackground(QBrush)", typeof(void), typeof(QBrush), value); }
		}
		public QWorkspace(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWorkspace#", "QWorkspace(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QWorkspace() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWorkspace", "QWorkspace()", typeof(void));
		}
		public QWidget ActiveWindow() {
			return (QWidget) interceptor.Invoke("activeWindow", "activeWindow() const", typeof(QWidget));
		}
		public List<QWidget> WindowList(QWorkspace.WindowOrder order) {
			return (List<QWidget>) interceptor.Invoke("windowList$", "windowList(QWorkspace::WindowOrder) const", typeof(List<QWidget>), typeof(QWorkspace.WindowOrder), order);
		}
		public List<QWidget> WindowList() {
			return (List<QWidget>) interceptor.Invoke("windowList", "windowList() const", typeof(List<QWidget>));
		}
		public QWidget AddWindow(QWidget w, int flags) {
			return (QWidget) interceptor.Invoke("addWindow#$", "addWindow(QWidget*, Qt::WindowFlags)", typeof(QWidget), typeof(QWidget), w, typeof(int), flags);
		}
		public QWidget AddWindow(QWidget w) {
			return (QWidget) interceptor.Invoke("addWindow#", "addWindow(QWidget*)", typeof(QWidget), typeof(QWidget), w);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[Q_SLOT("void setActiveWindow(QWidget*)")]
		public void SetActiveWindow(QWidget w) {
			interceptor.Invoke("setActiveWindow#", "setActiveWindow(QWidget*)", typeof(void), typeof(QWidget), w);
		}
		[Q_SLOT("void cascade()")]
		public void Cascade() {
			interceptor.Invoke("cascade", "cascade()", typeof(void));
		}
		[Q_SLOT("void tile()")]
		public void Tile() {
			interceptor.Invoke("tile", "tile()", typeof(void));
		}
		[Q_SLOT("void arrangeIcons()")]
		public void ArrangeIcons() {
			interceptor.Invoke("arrangeIcons", "arrangeIcons()", typeof(void));
		}
		[Q_SLOT("void closeActiveWindow()")]
		public void CloseActiveWindow() {
			interceptor.Invoke("closeActiveWindow", "closeActiveWindow()", typeof(void));
		}
		[Q_SLOT("void closeAllWindows()")]
		public void CloseAllWindows() {
			interceptor.Invoke("closeAllWindows", "closeAllWindows()", typeof(void));
		}
		[Q_SLOT("void activateNextWindow()")]
		public void ActivateNextWindow() {
			interceptor.Invoke("activateNextWindow", "activateNextWindow()", typeof(void));
		}
		[Q_SLOT("void activatePreviousWindow()")]
		public void ActivatePreviousWindow() {
			interceptor.Invoke("activatePreviousWindow", "activatePreviousWindow()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent e) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("childEvent(QChildEvent*)")]
		protected override void ChildEvent(QChildEvent arg1) {
			interceptor.Invoke("childEvent#", "childEvent(QChildEvent*)", typeof(void), typeof(QChildEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent e) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), e);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected override void HideEvent(QHideEvent e) {
			interceptor.Invoke("hideEvent#", "hideEvent(QHideEvent*)", typeof(void), typeof(QHideEvent), e);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent e) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), e);
		}
		~QWorkspace() {
			interceptor.Invoke("~QWorkspace", "~QWorkspace()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QWorkspace", "~QWorkspace()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQWorkspaceSignals Emit {
			get { return (IQWorkspaceSignals) Q_EMIT; }
		}
	}

	public interface IQWorkspaceSignals : IQWidgetSignals {
		[Q_SIGNAL("void windowActivated(QWidget*)")]
		void WindowActivated(QWidget w);
	}
}
