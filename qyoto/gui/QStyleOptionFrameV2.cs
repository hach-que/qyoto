//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QStyleOptionFrameV2")]
    public class QStyleOptionFrameV2 : QStyleOptionFrame, IDisposable {
        protected QStyleOptionFrameV2(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QStyleOptionFrameV2), this);
        }
        public enum StyleOptionVersion {
            Version = 2,
        }
        public enum FrameFeature {
            None = 0x00,
            Flat = 0x01,
        }
        public QStyleOptionFrameV2() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionFrameV2", "QStyleOptionFrameV2()", typeof(void));
        }
        public QStyleOptionFrameV2(QStyleOptionFrameV2 other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionFrameV2#", "QStyleOptionFrameV2(const QStyleOptionFrameV2&)", typeof(void), typeof(QStyleOptionFrameV2), other);
        }
        public QStyleOptionFrameV2(QStyleOptionFrame other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionFrameV2#", "QStyleOptionFrameV2(const QStyleOptionFrame&)", typeof(void), typeof(QStyleOptionFrame), other);
        }
        public QStyleOptionFrameV2(int version) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionFrameV2$", "QStyleOptionFrameV2(int)", typeof(void), typeof(int), version);
        }
        ~QStyleOptionFrameV2() {
            interceptor.Invoke("~QStyleOptionFrameV2", "~QStyleOptionFrameV2()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QStyleOptionFrameV2", "~QStyleOptionFrameV2()", typeof(void));
        }
    }
}
