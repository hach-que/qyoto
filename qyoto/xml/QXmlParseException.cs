//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlParseException")]
	public class QXmlParseException : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QXmlParseException(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlParseException), this);
			_interceptor = (QXmlParseException) realProxy.GetTransparentProxy();
		}
		private QXmlParseException ProxyQXmlParseException() {
			return (QXmlParseException) _interceptor;
		}
		public QXmlParseException(string name, int c, int l, string p, string s) : this((Type) null) {
			CreateProxy();
			NewQXmlParseException(name,c,l,p,s);
		}
		[SmokeMethod("QXmlParseException", "(const QString&, int, int, const QString&, const QString&)", "$$$$$")]
		private void NewQXmlParseException(string name, int c, int l, string p, string s) {
			ProxyQXmlParseException().NewQXmlParseException(name,c,l,p,s);
		}
		public QXmlParseException(string name, int c, int l, string p) : this((Type) null) {
			CreateProxy();
			NewQXmlParseException(name,c,l,p);
		}
		[SmokeMethod("QXmlParseException", "(const QString&, int, int, const QString&)", "$$$$")]
		private void NewQXmlParseException(string name, int c, int l, string p) {
			ProxyQXmlParseException().NewQXmlParseException(name,c,l,p);
		}
		public QXmlParseException(string name, int c, int l) : this((Type) null) {
			CreateProxy();
			NewQXmlParseException(name,c,l);
		}
		[SmokeMethod("QXmlParseException", "(const QString&, int, int)", "$$$")]
		private void NewQXmlParseException(string name, int c, int l) {
			ProxyQXmlParseException().NewQXmlParseException(name,c,l);
		}
		public QXmlParseException(string name, int c) : this((Type) null) {
			CreateProxy();
			NewQXmlParseException(name,c);
		}
		[SmokeMethod("QXmlParseException", "(const QString&, int)", "$$")]
		private void NewQXmlParseException(string name, int c) {
			ProxyQXmlParseException().NewQXmlParseException(name,c);
		}
		public QXmlParseException(string name) : this((Type) null) {
			CreateProxy();
			NewQXmlParseException(name);
		}
		[SmokeMethod("QXmlParseException", "(const QString&)", "$")]
		private void NewQXmlParseException(string name) {
			ProxyQXmlParseException().NewQXmlParseException(name);
		}
		public QXmlParseException() : this((Type) null) {
			CreateProxy();
			NewQXmlParseException();
		}
		[SmokeMethod("QXmlParseException", "()", "")]
		private void NewQXmlParseException() {
			ProxyQXmlParseException().NewQXmlParseException();
		}
		[SmokeMethod("columnNumber", "() const", "")]
		public int ColumnNumber() {
			return ProxyQXmlParseException().ColumnNumber();
		}
		[SmokeMethod("lineNumber", "() const", "")]
		public int LineNumber() {
			return ProxyQXmlParseException().LineNumber();
		}
		[SmokeMethod("publicId", "() const", "")]
		public string PublicId() {
			return ProxyQXmlParseException().PublicId();
		}
		[SmokeMethod("systemId", "() const", "")]
		public string SystemId() {
			return ProxyQXmlParseException().SystemId();
		}
		[SmokeMethod("message", "() const", "")]
		public string Message() {
			return ProxyQXmlParseException().Message();
		}
		~QXmlParseException() {
			DisposeQXmlParseException();
		}
		public void Dispose() {
			DisposeQXmlParseException();
		}
		[SmokeMethod("~QXmlParseException", "()", "")]
		private void DisposeQXmlParseException() {
			ProxyQXmlParseException().DisposeQXmlParseException();
		}
	}
}
