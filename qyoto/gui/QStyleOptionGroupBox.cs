//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QStyleOptionGroupBox")]
    public class QStyleOptionGroupBox : QStyleOptionComplex, IDisposable {
        protected QStyleOptionGroupBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QStyleOptionGroupBox), this);
        }
        public enum StyleOptionType {
            Type = QStyleOption.OptionType.SO_GroupBox,
        }
        public enum StyleOptionVersion {
            Version = 1,
        }
        public QStyleOptionGroupBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionGroupBox", "QStyleOptionGroupBox()", typeof(void));
        }
        public QStyleOptionGroupBox(QStyleOptionGroupBox other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionGroupBox#", "QStyleOptionGroupBox(const QStyleOptionGroupBox&)", typeof(void), typeof(QStyleOptionGroupBox), other);
        }
        public QStyleOptionGroupBox(int version) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionGroupBox$", "QStyleOptionGroupBox(int)", typeof(void), typeof(int), version);
        }
        ~QStyleOptionGroupBox() {
            interceptor.Invoke("~QStyleOptionGroupBox", "~QStyleOptionGroupBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QStyleOptionGroupBox", "~QStyleOptionGroupBox()", typeof(void));
        }
    }
}
