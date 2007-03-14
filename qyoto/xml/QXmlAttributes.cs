//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlAttributes")]
	public class QXmlAttributes : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QXmlAttributes(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlAttributes), this);
			_interceptor = (QXmlAttributes) realProxy.GetTransparentProxy();
		}
		private QXmlAttributes ProxyQXmlAttributes() {
			return (QXmlAttributes) _interceptor;
		}
		public QXmlAttributes() : this((Type) null) {
			CreateProxy();
			NewQXmlAttributes();
		}
		[SmokeMethod("QXmlAttributes", "()", "")]
		private void NewQXmlAttributes() {
			ProxyQXmlAttributes().NewQXmlAttributes();
		}
		[SmokeMethod("index", "(const QString&) const", "$")]
		public int Index(string qName) {
			return ProxyQXmlAttributes().Index(qName);
		}
		[SmokeMethod("index", "(const QString&, const QString&) const", "$$")]
		public int Index(string uri, string localPart) {
			return ProxyQXmlAttributes().Index(uri,localPart);
		}
		[SmokeMethod("length", "() const", "")]
		public int Length() {
			return ProxyQXmlAttributes().Length();
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ProxyQXmlAttributes().Count();
		}
		[SmokeMethod("localName", "(int) const", "$")]
		public string LocalName(int index) {
			return ProxyQXmlAttributes().LocalName(index);
		}
		[SmokeMethod("qName", "(int) const", "$")]
		public string QName(int index) {
			return ProxyQXmlAttributes().QName(index);
		}
		[SmokeMethod("uri", "(int) const", "$")]
		public string Uri(int index) {
			return ProxyQXmlAttributes().Uri(index);
		}
		[SmokeMethod("type", "(int) const", "$")]
		public string type(int index) {
			return ProxyQXmlAttributes().type(index);
		}
		[SmokeMethod("type", "(const QString&) const", "$")]
		public string type(string qName) {
			return ProxyQXmlAttributes().type(qName);
		}
		[SmokeMethod("type", "(const QString&, const QString&) const", "$$")]
		public string type(string uri, string localName) {
			return ProxyQXmlAttributes().type(uri,localName);
		}
		[SmokeMethod("value", "(int) const", "$")]
		public string Value(int index) {
			return ProxyQXmlAttributes().Value(index);
		}
		[SmokeMethod("value", "(const QString&) const", "$")]
		public string Value(string qName) {
			return ProxyQXmlAttributes().Value(qName);
		}
		[SmokeMethod("value", "(const QString&, const QString&) const", "$$")]
		public string Value(string uri, string localName) {
			return ProxyQXmlAttributes().Value(uri,localName);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQXmlAttributes().Clear();
		}
		[SmokeMethod("append", "(const QString&, const QString&, const QString&, const QString&)", "$$$$")]
		public void Append(string qName, string uri, string localPart, string value) {
			ProxyQXmlAttributes().Append(qName,uri,localPart,value);
		}
		~QXmlAttributes() {
			DisposeQXmlAttributes();
		}
		public void Dispose() {
			DisposeQXmlAttributes();
		}
		[SmokeMethod("~QXmlAttributes", "()", "")]
		private void DisposeQXmlAttributes() {
			ProxyQXmlAttributes().DisposeQXmlAttributes();
		}
	}
}
