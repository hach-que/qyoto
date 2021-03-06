//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QDateEdit")]
    public class QDateEdit : QDateTimeEdit, IDisposable {
        protected QDateEdit(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDateEdit), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QDateEdit() {
            staticInterceptor = new SmokeInvocation(typeof(QDateEdit), null);
        }
        [Q_PROPERTY("QDate", "date")]
        public new QDate Date {
            get { return (QDate) interceptor.Invoke("date", "date()", typeof(QDate)); }
            set { interceptor.Invoke("setDate#", "setDate(QDate)", typeof(void), typeof(QDate), value); }
        }
        public QDateEdit(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDateEdit#", "QDateEdit(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QDateEdit() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDateEdit", "QDateEdit()", typeof(void));
        }
        public QDateEdit(QDate date, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDateEdit##", "QDateEdit(const QDate&, QWidget*)", typeof(void), typeof(QDate), date, typeof(QWidget), parent);
        }
        public QDateEdit(QDate date) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDateEdit#", "QDateEdit(const QDate&)", typeof(void), typeof(QDate), date);
        }
        ~QDateEdit() {
            interceptor.Invoke("~QDateEdit", "~QDateEdit()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDateEdit", "~QDateEdit()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQDateEditSignals Emit {
            get { return (IQDateEditSignals) Q_EMIT; }
        }
    }

    public interface IQDateEditSignals : IQDateTimeEditSignals {
    }
}
