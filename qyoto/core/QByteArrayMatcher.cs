//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QByteArrayMatcher")]
	public class QByteArrayMatcher : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QByteArrayMatcher(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QByteArrayMatcher), this);
		}
		public QByteArrayMatcher() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArrayMatcher", "QByteArrayMatcher()", typeof(void));
		}
		public QByteArrayMatcher(QByteArray pattern) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArrayMatcher#", "QByteArrayMatcher(const QByteArray&)", typeof(void), typeof(QByteArray), pattern);
		}
		public QByteArrayMatcher(QByteArrayMatcher other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArrayMatcher#", "QByteArrayMatcher(const QByteArrayMatcher&)", typeof(void), typeof(QByteArrayMatcher), other);
		}
		public void SetPattern(QByteArray pattern) {
			interceptor.Invoke("setPattern#", "setPattern(const QByteArray&)", typeof(void), typeof(QByteArray), pattern);
		}
		public int IndexIn(QByteArray ba, int from) {
			return (int) interceptor.Invoke("indexIn#$", "indexIn(const QByteArray&, int) const", typeof(int), typeof(QByteArray), ba, typeof(int), from);
		}
		public int IndexIn(QByteArray ba) {
			return (int) interceptor.Invoke("indexIn#", "indexIn(const QByteArray&) const", typeof(int), typeof(QByteArray), ba);
		}
		public QByteArray Pattern() {
			return (QByteArray) interceptor.Invoke("pattern", "pattern() const", typeof(QByteArray));
		}
		~QByteArrayMatcher() {
			interceptor.Invoke("~QByteArrayMatcher", "~QByteArrayMatcher()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QByteArrayMatcher", "~QByteArrayMatcher()", typeof(void));
		}
	}
}
