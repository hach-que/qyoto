//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QMouseEvent")]
    public class QMouseEvent : QInputEvent, IDisposable {
        protected QMouseEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QMouseEvent), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QMouseEvent() {
            staticInterceptor = new SmokeInvocation(typeof(QMouseEvent), null);
        }
        public QMouseEvent(QEvent.TypeOf type, QPoint pos, Qt.MouseButton button, uint buttons, uint modifiers) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QMouseEvent$#$$$", "QMouseEvent(QEvent::Type, const QPoint&, Qt::MouseButton, Qt::MouseButtons, Qt::KeyboardModifiers)", typeof(void), typeof(QEvent.TypeOf), type, typeof(QPoint), pos, typeof(Qt.MouseButton), button, typeof(uint), buttons, typeof(uint), modifiers);
        }
        public QMouseEvent(QEvent.TypeOf type, QPoint pos, QPoint globalPos, Qt.MouseButton button, uint buttons, uint modifiers) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QMouseEvent$##$$$", "QMouseEvent(QEvent::Type, const QPoint&, const QPoint&, Qt::MouseButton, Qt::MouseButtons, Qt::KeyboardModifiers)", typeof(void), typeof(QEvent.TypeOf), type, typeof(QPoint), pos, typeof(QPoint), globalPos, typeof(Qt.MouseButton), button, typeof(uint), buttons, typeof(uint), modifiers);
        }
        public QPoint Pos() {
            return (QPoint) interceptor.Invoke("pos", "pos() const", typeof(QPoint));
        }
        public QPoint GlobalPos() {
            return (QPoint) interceptor.Invoke("globalPos", "globalPos() const", typeof(QPoint));
        }
        public int X() {
            return (int) interceptor.Invoke("x", "x() const", typeof(int));
        }
        public int Y() {
            return (int) interceptor.Invoke("y", "y() const", typeof(int));
        }
        public int GlobalX() {
            return (int) interceptor.Invoke("globalX", "globalX() const", typeof(int));
        }
        public int GlobalY() {
            return (int) interceptor.Invoke("globalY", "globalY() const", typeof(int));
        }
        public Qt.MouseButton Button() {
            return (Qt.MouseButton) interceptor.Invoke("button", "button() const", typeof(Qt.MouseButton));
        }
        public uint Buttons() {
            return (uint) interceptor.Invoke("buttons", "buttons() const", typeof(uint));
        }
        public bool HasExtendedInfo() {
            return (bool) interceptor.Invoke("hasExtendedInfo", "hasExtendedInfo() const", typeof(bool));
        }
        public QPointF PosF() {
            return (QPointF) interceptor.Invoke("posF", "posF() const", typeof(QPointF));
        }
        ~QMouseEvent() {
            interceptor.Invoke("~QMouseEvent", "~QMouseEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QMouseEvent", "~QMouseEvent()", typeof(void));
        }
        public static QMouseEvent CreateExtendedMouseEvent(QEvent.TypeOf type, QPointF pos, QPoint globalPos, Qt.MouseButton button, uint buttons, uint modifiers) {
            return (QMouseEvent) staticInterceptor.Invoke("createExtendedMouseEvent$##$$$", "createExtendedMouseEvent(QEvent::Type, const QPointF&, const QPoint&, Qt::MouseButton, Qt::MouseButtons, Qt::KeyboardModifiers)", typeof(QMouseEvent), typeof(QEvent.TypeOf), type, typeof(QPointF), pos, typeof(QPoint), globalPos, typeof(Qt.MouseButton), button, typeof(uint), buttons, typeof(uint), modifiers);
        }
    }
}