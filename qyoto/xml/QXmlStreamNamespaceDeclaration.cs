//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlStreamNamespaceDeclaration")]
	public class QXmlStreamNamespaceDeclaration : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlStreamNamespaceDeclaration(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlStreamNamespaceDeclaration), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QXmlStreamNamespaceDeclaration() {
			staticInterceptor = new SmokeInvocation(typeof(QXmlStreamNamespaceDeclaration), null);
		}
		public QXmlStreamNamespaceDeclaration() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamNamespaceDeclaration", "QXmlStreamNamespaceDeclaration()", typeof(void));
		}
		public QXmlStreamNamespaceDeclaration(QXmlStreamNamespaceDeclaration arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamNamespaceDeclaration#", "QXmlStreamNamespaceDeclaration(const QXmlStreamNamespaceDeclaration&)", typeof(void), typeof(QXmlStreamNamespaceDeclaration), arg1);
		}
		public string Prefix() {
			return (string) interceptor.Invoke("prefix", "prefix() const", typeof(string));
		}
		public string NamespaceUri() {
			return (string) interceptor.Invoke("namespaceUri", "namespaceUri() const", typeof(string));
		}
		public override bool Equals(object o) {
			if (!(o is QXmlStreamNamespaceDeclaration)) { return false; }
			return this == (QXmlStreamNamespaceDeclaration) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QXmlStreamNamespaceDeclaration() {
			interceptor.Invoke("~QXmlStreamNamespaceDeclaration", "~QXmlStreamNamespaceDeclaration()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QXmlStreamNamespaceDeclaration", "~QXmlStreamNamespaceDeclaration()", typeof(void));
		}
		public static bool operator==(QXmlStreamNamespaceDeclaration lhs, QXmlStreamNamespaceDeclaration other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QXmlStreamNamespaceDeclaration&)", typeof(bool), typeof(QXmlStreamNamespaceDeclaration), lhs, typeof(QXmlStreamNamespaceDeclaration), other);
		}
		public static bool operator!=(QXmlStreamNamespaceDeclaration lhs, QXmlStreamNamespaceDeclaration other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QXmlStreamNamespaceDeclaration&)", typeof(bool), typeof(QXmlStreamNamespaceDeclaration), lhs, typeof(QXmlStreamNamespaceDeclaration), other);
		}
	}
}
