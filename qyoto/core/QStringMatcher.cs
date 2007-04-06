//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStringMatcher")]
	public class QStringMatcher : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QStringMatcher(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStringMatcher), this);
		}
		public QStringMatcher() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStringMatcher", "QStringMatcher()", typeof(void));
		}
		public QStringMatcher(string pattern, Qt.CaseSensitivity cs) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStringMatcher$$", "QStringMatcher(const QString&, Qt::CaseSensitivity)", typeof(void), typeof(string), pattern, typeof(Qt.CaseSensitivity), cs);
		}
		public QStringMatcher(string pattern) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStringMatcher$", "QStringMatcher(const QString&)", typeof(void), typeof(string), pattern);
		}
		public void SetPattern(string pattern) {
			interceptor.Invoke("setPattern$", "setPattern(const QString&)", typeof(void), typeof(string), pattern);
		}
		public void SetCaseSensitivity(Qt.CaseSensitivity cs) {
			interceptor.Invoke("setCaseSensitivity$", "setCaseSensitivity(Qt::CaseSensitivity)", typeof(void), typeof(Qt.CaseSensitivity), cs);
		}
		public int IndexIn(string str, int from) {
			return (int) interceptor.Invoke("indexIn$$", "indexIn(const QString&, int) const", typeof(int), typeof(string), str, typeof(int), from);
		}
		public int IndexIn(string str) {
			return (int) interceptor.Invoke("indexIn$", "indexIn(const QString&) const", typeof(int), typeof(string), str);
		}
		public string Pattern() {
			return (string) interceptor.Invoke("pattern", "pattern() const", typeof(string));
		}
		public Qt.CaseSensitivity CaseSensitivity() {
			return (Qt.CaseSensitivity) interceptor.Invoke("caseSensitivity", "caseSensitivity() const", typeof(Qt.CaseSensitivity));
		}
		~QStringMatcher() {
			interceptor.Invoke("~QStringMatcher", "~QStringMatcher()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStringMatcher", "~QStringMatcher()", typeof(void));
		}
	}
}
