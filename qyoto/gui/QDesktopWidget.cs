//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQDesktopWidgetSignals"></see> for signals emitted by QDesktopWidget
    /// </remarks>
    [SmokeClass("QDesktopWidget")]
    public class QDesktopWidget : QWidget, IDisposable {
        protected QDesktopWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDesktopWidget), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QDesktopWidget() {
            staticInterceptor = new SmokeInvocation(typeof(QDesktopWidget), null);
        }
        public QDesktopWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDesktopWidget", "QDesktopWidget()", typeof(void));
        }
        public bool IsVirtualDesktop() {
            return (bool) interceptor.Invoke("isVirtualDesktop", "isVirtualDesktop() const", typeof(bool));
        }
        public int NumScreens() {
            return (int) interceptor.Invoke("numScreens", "numScreens() const", typeof(int));
        }
        public int PrimaryScreen() {
            return (int) interceptor.Invoke("primaryScreen", "primaryScreen() const", typeof(int));
        }
        public int ScreenNumber(QWidget widget) {
            return (int) interceptor.Invoke("screenNumber#", "screenNumber(const QWidget*) const", typeof(int), typeof(QWidget), widget);
        }
        public int ScreenNumber() {
            return (int) interceptor.Invoke("screenNumber", "screenNumber() const", typeof(int));
        }
        public int ScreenNumber(QPoint arg1) {
            return (int) interceptor.Invoke("screenNumber#", "screenNumber(const QPoint&) const", typeof(int), typeof(QPoint), arg1);
        }
        public QWidget Screen(int screen) {
            return (QWidget) interceptor.Invoke("screen$", "screen(int)", typeof(QWidget), typeof(int), screen);
        }
        public QWidget Screen() {
            return (QWidget) interceptor.Invoke("screen", "screen()", typeof(QWidget));
        }
        public QRect ScreenGeometry(int screen) {
            return (QRect) interceptor.Invoke("screenGeometry$", "screenGeometry(int) const", typeof(QRect), typeof(int), screen);
        }
        public QRect ScreenGeometry() {
            return (QRect) interceptor.Invoke("screenGeometry", "screenGeometry() const", typeof(QRect));
        }
        public QRect ScreenGeometry(QWidget widget) {
            return (QRect) interceptor.Invoke("screenGeometry#", "screenGeometry(const QWidget*) const", typeof(QRect), typeof(QWidget), widget);
        }
        public QRect ScreenGeometry(QPoint point) {
            return (QRect) interceptor.Invoke("screenGeometry#", "screenGeometry(const QPoint&) const", typeof(QRect), typeof(QPoint), point);
        }
        public QRect AvailableGeometry(int screen) {
            return (QRect) interceptor.Invoke("availableGeometry$", "availableGeometry(int) const", typeof(QRect), typeof(int), screen);
        }
        public QRect AvailableGeometry() {
            return (QRect) interceptor.Invoke("availableGeometry", "availableGeometry() const", typeof(QRect));
        }
        public QRect AvailableGeometry(QWidget widget) {
            return (QRect) interceptor.Invoke("availableGeometry#", "availableGeometry(const QWidget*) const", typeof(QRect), typeof(QWidget), widget);
        }
        public QRect AvailableGeometry(QPoint point) {
            return (QRect) interceptor.Invoke("availableGeometry#", "availableGeometry(const QPoint&) const", typeof(QRect), typeof(QPoint), point);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent e) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), e);
        }
        ~QDesktopWidget() {
            interceptor.Invoke("~QDesktopWidget", "~QDesktopWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDesktopWidget", "~QDesktopWidget()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQDesktopWidgetSignals Emit {
            get { return (IQDesktopWidgetSignals) Q_EMIT; }
        }
    }

    public interface IQDesktopWidgetSignals : IQWidgetSignals {
        [Q_SIGNAL("void resized(int)")]
        void Resized(int arg1);
        [Q_SIGNAL("void workAreaResized(int)")]
        void WorkAreaResized(int arg1);
    }
}
