//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QTextEncoder")]
	public class QTextEncoder : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QTextEncoder(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextEncoder), this);
		}
		public QTextEncoder(QTextCodec codec) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextEncoder#", "QTextEncoder(const QTextCodec*)", typeof(void), typeof(QTextCodec), codec);
		}
		public QByteArray FromUnicode(string str) {
			return (QByteArray) interceptor.Invoke("fromUnicode$", "fromUnicode(const QString&)", typeof(QByteArray), typeof(string), str);
		}
		public QByteArray FromUnicode(QChar uc, int len) {
			return (QByteArray) interceptor.Invoke("fromUnicode#$", "fromUnicode(const QChar*, int)", typeof(QByteArray), typeof(QChar), uc, typeof(int), len);
		}
		~QTextEncoder() {
			interceptor.Invoke("~QTextEncoder", "~QTextEncoder()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QTextEncoder", "~QTextEncoder()", typeof(void));
		}
	}
}
