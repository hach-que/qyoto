//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QWhatsThisClickedEvent")]
    public class QWhatsThisClickedEvent : QEvent, IDisposable {
        protected QWhatsThisClickedEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QWhatsThisClickedEvent), this);
        }
        public QWhatsThisClickedEvent(string href) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QWhatsThisClickedEvent$", "QWhatsThisClickedEvent(const QString&)", typeof(void), typeof(string), href);
        }
        public string Href() {
            return (string) interceptor.Invoke("href", "href() const", typeof(string));
        }
        ~QWhatsThisClickedEvent() {
            interceptor.Invoke("~QWhatsThisClickedEvent", "~QWhatsThisClickedEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QWhatsThisClickedEvent", "~QWhatsThisClickedEvent()", typeof(void));
        }
    }
}
