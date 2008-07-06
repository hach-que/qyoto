//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QGraphicsSceneResizeEvent")]
    public class QGraphicsSceneResizeEvent : QGraphicsSceneEvent, IDisposable {
        protected QGraphicsSceneResizeEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGraphicsSceneResizeEvent), this);
        }
        public QGraphicsSceneResizeEvent() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsSceneResizeEvent", "QGraphicsSceneResizeEvent()", typeof(void));
        }
        public QSizeF OldSize() {
            return (QSizeF) interceptor.Invoke("oldSize", "oldSize() const", typeof(QSizeF));
        }
        public void SetOldSize(QSizeF size) {
            interceptor.Invoke("setOldSize#", "setOldSize(const QSizeF&)", typeof(void), typeof(QSizeF), size);
        }
        public QSizeF NewSize() {
            return (QSizeF) interceptor.Invoke("newSize", "newSize() const", typeof(QSizeF));
        }
        public void SetNewSize(QSizeF size) {
            interceptor.Invoke("setNewSize#", "setNewSize(const QSizeF&)", typeof(void), typeof(QSizeF), size);
        }
        ~QGraphicsSceneResizeEvent() {
            interceptor.Invoke("~QGraphicsSceneResizeEvent", "~QGraphicsSceneResizeEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QGraphicsSceneResizeEvent", "~QGraphicsSceneResizeEvent()", typeof(void));
        }
    }
}
