//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QPushButton")]
    public class QPushButton : QAbstractButton, IDisposable {
        protected QPushButton(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QPushButton), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QPushButton() {
            staticInterceptor = new SmokeInvocation(typeof(QPushButton), null);
        }
        [Q_PROPERTY("bool", "autoDefault")]
        public bool AutoDefault {
            get { return (bool) interceptor.Invoke("autoDefault", "autoDefault()", typeof(bool)); }
            set { interceptor.Invoke("setAutoDefault$", "setAutoDefault(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "default")]
        public bool Default {
            get { return (bool) interceptor.Invoke("isDefault", "isDefault()", typeof(bool)); }
            set { interceptor.Invoke("setDefault$", "setDefault(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "flat")]
        public bool Flat {
            get { return (bool) interceptor.Invoke("isFlat", "isFlat()", typeof(bool)); }
            set { interceptor.Invoke("setFlat$", "setFlat(bool)", typeof(void), typeof(bool), value); }
        }
        // QPushButton* QPushButton(QPushButtonPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
        // QPushButton* QPushButton(QPushButtonPrivate& arg1); >>>> NOT CONVERTED
        public QPushButton(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPushButton#", "QPushButton(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QPushButton() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPushButton", "QPushButton()", typeof(void));
        }
        public QPushButton(string text, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPushButton$#", "QPushButton(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
        }
        public QPushButton(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPushButton$", "QPushButton(const QString&)", typeof(void), typeof(string), text);
        }
        public QPushButton(QIcon icon, string text, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPushButton#$#", "QPushButton(const QIcon&, const QString&, QWidget*)", typeof(void), typeof(QIcon), icon, typeof(string), text, typeof(QWidget), parent);
        }
        public QPushButton(QIcon icon, string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPushButton#$", "QPushButton(const QIcon&, const QString&)", typeof(void), typeof(QIcon), icon, typeof(string), text);
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
        [Q_SLOT("void showMenu()")]
        public void ShowMenu() {
            interceptor.Invoke("showMenu", "showMenu()", typeof(void));
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("keyPressEvent(QKeyEvent*)")]
        protected override void KeyPressEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        [SmokeMethod("focusInEvent(QFocusEvent*)")]
        protected override void FocusInEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        [SmokeMethod("focusOutEvent(QFocusEvent*)")]
        protected override void FocusOutEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        protected void InitStyleOption(QStyleOptionButton option) {
            interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionButton*) const", typeof(void), typeof(QStyleOptionButton), option);
        }
        ~QPushButton() {
            interceptor.Invoke("~QPushButton", "~QPushButton()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QPushButton", "~QPushButton()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQPushButtonSignals Emit {
            get { return (IQPushButtonSignals) Q_EMIT; }
        }
    }

    public interface IQPushButtonSignals : IQAbstractButtonSignals {
    }
}
