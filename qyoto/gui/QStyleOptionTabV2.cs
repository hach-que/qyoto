//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QStyleOptionTabV2")]
    public class QStyleOptionTabV2 : QStyleOptionTab, IDisposable {
        protected QStyleOptionTabV2(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QStyleOptionTabV2), this);
        }
        public enum StyleOptionVersion {
            Version = 2,
        }
        public QStyleOptionTabV2() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTabV2", "QStyleOptionTabV2()", typeof(void));
        }
        public QStyleOptionTabV2(QStyleOptionTabV2 other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTabV2#", "QStyleOptionTabV2(const QStyleOptionTabV2&)", typeof(void), typeof(QStyleOptionTabV2), other);
        }
        public QStyleOptionTabV2(QStyleOptionTab other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTabV2#", "QStyleOptionTabV2(const QStyleOptionTab&)", typeof(void), typeof(QStyleOptionTab), other);
        }
        public QStyleOptionTabV2(int version) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTabV2$", "QStyleOptionTabV2(int)", typeof(void), typeof(int), version);
        }
        ~QStyleOptionTabV2() {
            interceptor.Invoke("~QStyleOptionTabV2", "~QStyleOptionTabV2()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QStyleOptionTabV2", "~QStyleOptionTabV2()", typeof(void));
        }
    }
}
