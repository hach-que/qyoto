//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QGraphicsSceneDragDropEvent")]
    public class QGraphicsSceneDragDropEvent : QGraphicsSceneEvent, IDisposable {
        protected QGraphicsSceneDragDropEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGraphicsSceneDragDropEvent), this);
        }
        public QGraphicsSceneDragDropEvent(QEvent.TypeOf type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsSceneDragDropEvent$", "QGraphicsSceneDragDropEvent(QEvent::Type)", typeof(void), typeof(QEvent.TypeOf), type);
        }
        public QGraphicsSceneDragDropEvent() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsSceneDragDropEvent", "QGraphicsSceneDragDropEvent()", typeof(void));
        }
        public QPointF Pos() {
            return (QPointF) interceptor.Invoke("pos", "pos() const", typeof(QPointF));
        }
        public void SetPos(QPointF pos) {
            interceptor.Invoke("setPos#", "setPos(const QPointF&)", typeof(void), typeof(QPointF), pos);
        }
        public QPointF ScenePos() {
            return (QPointF) interceptor.Invoke("scenePos", "scenePos() const", typeof(QPointF));
        }
        public void SetScenePos(QPointF pos) {
            interceptor.Invoke("setScenePos#", "setScenePos(const QPointF&)", typeof(void), typeof(QPointF), pos);
        }
        public QPoint ScreenPos() {
            return (QPoint) interceptor.Invoke("screenPos", "screenPos() const", typeof(QPoint));
        }
        public void SetScreenPos(QPoint pos) {
            interceptor.Invoke("setScreenPos#", "setScreenPos(const QPoint&)", typeof(void), typeof(QPoint), pos);
        }
        public uint Buttons() {
            return (uint) interceptor.Invoke("buttons", "buttons() const", typeof(uint));
        }
        public void SetButtons(uint buttons) {
            interceptor.Invoke("setButtons$", "setButtons(Qt::MouseButtons)", typeof(void), typeof(uint), buttons);
        }
        public uint Modifiers() {
            return (uint) interceptor.Invoke("modifiers", "modifiers() const", typeof(uint));
        }
        public void SetModifiers(uint modifiers) {
            interceptor.Invoke("setModifiers$", "setModifiers(Qt::KeyboardModifiers)", typeof(void), typeof(uint), modifiers);
        }
        public uint PossibleActions() {
            return (uint) interceptor.Invoke("possibleActions", "possibleActions() const", typeof(uint));
        }
        public void SetPossibleActions(uint actions) {
            interceptor.Invoke("setPossibleActions$", "setPossibleActions(Qt::DropActions)", typeof(void), typeof(uint), actions);
        }
        public Qt.DropAction ProposedAction() {
            return (Qt.DropAction) interceptor.Invoke("proposedAction", "proposedAction() const", typeof(Qt.DropAction));
        }
        public void SetProposedAction(Qt.DropAction action) {
            interceptor.Invoke("setProposedAction$", "setProposedAction(Qt::DropAction)", typeof(void), typeof(Qt.DropAction), action);
        }
        public void AcceptProposedAction() {
            interceptor.Invoke("acceptProposedAction", "acceptProposedAction()", typeof(void));
        }
        public Qt.DropAction DropAction() {
            return (Qt.DropAction) interceptor.Invoke("dropAction", "dropAction() const", typeof(Qt.DropAction));
        }
        public void SetDropAction(Qt.DropAction action) {
            interceptor.Invoke("setDropAction$", "setDropAction(Qt::DropAction)", typeof(void), typeof(Qt.DropAction), action);
        }
        public QWidget Source() {
            return (QWidget) interceptor.Invoke("source", "source() const", typeof(QWidget));
        }
        public void SetSource(QWidget source) {
            interceptor.Invoke("setSource#", "setSource(QWidget*)", typeof(void), typeof(QWidget), source);
        }
        public QMimeData MimeData() {
            return (QMimeData) interceptor.Invoke("mimeData", "mimeData() const", typeof(QMimeData));
        }
        public void SetMimeData(QMimeData data) {
            interceptor.Invoke("setMimeData#", "setMimeData(const QMimeData*)", typeof(void), typeof(QMimeData), data);
        }
        ~QGraphicsSceneDragDropEvent() {
            interceptor.Invoke("~QGraphicsSceneDragDropEvent", "~QGraphicsSceneDragDropEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QGraphicsSceneDragDropEvent", "~QGraphicsSceneDragDropEvent()", typeof(void));
        }
    }
}
