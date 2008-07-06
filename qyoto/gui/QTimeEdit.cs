//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTimeEdit")]
    public class QTimeEdit : QDateTimeEdit, IDisposable {
        protected QTimeEdit(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTimeEdit), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTimeEdit() {
            staticInterceptor = new SmokeInvocation(typeof(QTimeEdit), null);
        }
        [Q_PROPERTY("QTime", "time")]
        public new QTime Time {
            get { return (QTime) interceptor.Invoke("time", "time()", typeof(QTime)); }
            set { interceptor.Invoke("setTime#", "setTime(QTime)", typeof(void), typeof(QTime), value); }
        }
        public QTimeEdit(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeEdit#", "QTimeEdit(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QTimeEdit() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeEdit", "QTimeEdit()", typeof(void));
        }
        public QTimeEdit(QTime time, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeEdit##", "QTimeEdit(const QTime&, QWidget*)", typeof(void), typeof(QTime), time, typeof(QWidget), parent);
        }
        public QTimeEdit(QTime time) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeEdit#", "QTimeEdit(const QTime&)", typeof(void), typeof(QTime), time);
        }
        ~QTimeEdit() {
            interceptor.Invoke("~QTimeEdit", "~QTimeEdit()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTimeEdit", "~QTimeEdit()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTimeEditSignals Emit {
            get { return (IQTimeEditSignals) Q_EMIT; }
        }
    }

    public interface IQTimeEditSignals : IQDateTimeEditSignals {
    }
}
