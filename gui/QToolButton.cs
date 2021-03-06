//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQToolButtonSignals"></see> for signals emitted by QToolButton
    /// </remarks>
    [SmokeClass("QToolButton")]
    public class QToolButton : QAbstractButton, IDisposable {
        protected QToolButton(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QToolButton), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QToolButton() {
            staticInterceptor = new SmokeInvocation(typeof(QToolButton), null);
        }
        public enum ToolButtonPopupMode {
            DelayedPopup = 0,
            MenuButtonPopup = 1,
            InstantPopup = 2,
        }
        [Q_PROPERTY("QToolButton::ToolButtonPopupMode", "popupMode")]
        public QToolButton.ToolButtonPopupMode PopupMode {
            get { return (QToolButton.ToolButtonPopupMode) interceptor.Invoke("popupMode", "popupMode()", typeof(QToolButton.ToolButtonPopupMode)); }
            set { interceptor.Invoke("setPopupMode$", "setPopupMode(QToolButton::ToolButtonPopupMode)", typeof(void), typeof(QToolButton.ToolButtonPopupMode), value); }
        }
        [Q_PROPERTY("Qt::ToolButtonStyle", "toolButtonStyle")]
        public new Qt.ToolButtonStyle ToolButtonStyle {
            get { return (Qt.ToolButtonStyle) interceptor.Invoke("toolButtonStyle", "toolButtonStyle()", typeof(Qt.ToolButtonStyle)); }
            set { interceptor.Invoke("setToolButtonStyle$", "setToolButtonStyle(Qt::ToolButtonStyle)", typeof(void), typeof(Qt.ToolButtonStyle), value); }
        }
        [Q_PROPERTY("bool", "autoRaise")]
        public bool AutoRaise {
            get { return (bool) interceptor.Invoke("autoRaise", "autoRaise()", typeof(bool)); }
            set { interceptor.Invoke("setAutoRaise$", "setAutoRaise(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("Qt::ArrowType", "arrowType")]
        public new Qt.ArrowType ArrowType {
            get { return (Qt.ArrowType) interceptor.Invoke("arrowType", "arrowType()", typeof(Qt.ArrowType)); }
            set { interceptor.Invoke("setArrowType$", "setArrowType(Qt::ArrowType)", typeof(void), typeof(Qt.ArrowType), value); }
        }
        // QToolButton* QToolButton(QToolButtonPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
        public QToolButton(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolButton#", "QToolButton(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QToolButton() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolButton", "QToolButton()", typeof(void));
        }
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        [SmokeMethod("minimumSizeHint() const")]
        public override QSize MinimumSizeHint() {
            return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
        }
        public void SetMenu(QMenu menu) {
            interceptor.Invoke("setMenu#", "setMenu(QMenu*)", typeof(void), typeof(QMenu), menu);
        }
        public QMenu Menu() {
            return (QMenu) interceptor.Invoke("menu", "menu() const", typeof(QMenu));
        }
        public QAction DefaultAction() {
            return (QAction) interceptor.Invoke("defaultAction", "defaultAction() const", typeof(QAction));
        }
        [Q_SLOT("void showMenu()")]
        public void ShowMenu() {
            interceptor.Invoke("showMenu", "showMenu()", typeof(void));
        }
        [Q_SLOT("void setToolButtonStyle(Qt::ToolButtonStyle)")]
        public void SetToolButtonStyle(Qt.ToolButtonStyle style) {
            interceptor.Invoke("setToolButtonStyle$", "setToolButtonStyle(Qt::ToolButtonStyle)", typeof(void), typeof(Qt.ToolButtonStyle), style);
        }
        [Q_SLOT("void setDefaultAction(QAction*)")]
        public void SetDefaultAction(QAction arg1) {
            interceptor.Invoke("setDefaultAction#", "setDefaultAction(QAction*)", typeof(void), typeof(QAction), arg1);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("mousePressEvent(QMouseEvent*)")]
        protected override void MousePressEvent(QMouseEvent arg1) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
        protected override void MouseReleaseEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("actionEvent(QActionEvent*)")]
        protected override void ActionEvent(QActionEvent arg1) {
            interceptor.Invoke("actionEvent#", "actionEvent(QActionEvent*)", typeof(void), typeof(QActionEvent), arg1);
        }
        [SmokeMethod("enterEvent(QEvent*)")]
        protected override void EnterEvent(QEvent arg1) {
            interceptor.Invoke("enterEvent#", "enterEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("leaveEvent(QEvent*)")]
        protected override void LeaveEvent(QEvent arg1) {
            interceptor.Invoke("leaveEvent#", "leaveEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("timerEvent(QTimerEvent*)")]
        protected override void TimerEvent(QTimerEvent arg1) {
            interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("hitButton(const QPoint&) const")]
        protected override bool HitButton(QPoint pos) {
            return (bool) interceptor.Invoke("hitButton#", "hitButton(const QPoint&) const", typeof(bool), typeof(QPoint), pos);
        }
        [SmokeMethod("nextCheckState()")]
        protected override void NextCheckState() {
            interceptor.Invoke("nextCheckState", "nextCheckState()", typeof(void));
        }
        protected void InitStyleOption(QStyleOptionToolButton option) {
            interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionToolButton*) const", typeof(void), typeof(QStyleOptionToolButton), option);
        }
        ~QToolButton() {
            interceptor.Invoke("~QToolButton", "~QToolButton()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QToolButton", "~QToolButton()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
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
