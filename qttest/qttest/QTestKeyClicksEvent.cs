//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTestKeyClicksEvent")]
    public class QTestKeyClicksEvent : QTestEvent, IDisposable {
        protected QTestKeyClicksEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTestKeyClicksEvent), this);
        }
        public QTestKeyClicksEvent(string keys, uint modifiers, int delay) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTestKeyClicksEvent$$$", "QTestKeyClicksEvent(const QString&, Qt::KeyboardModifiers, int)", typeof(void), typeof(string), keys, typeof(uint), modifiers, typeof(int), delay);
        }
        [SmokeMethod("clone() const")]
        public override QTestEvent Clone() {
            return (QTestEvent) interceptor.Invoke("clone", "clone() const", typeof(QTestEvent));
        }
        [SmokeMethod("simulate(QWidget*)")]
        public override void Simulate(QWidget w) {
            interceptor.Invoke("simulate#", "simulate(QWidget*)", typeof(void), typeof(QWidget), w);
        }
        ~QTestKeyClicksEvent() {
            interceptor.Invoke("~QTestKeyClicksEvent", "~QTestKeyClicksEvent()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTestKeyClicksEvent", "~QTestKeyClicksEvent()", typeof(void));
        }
    }
}