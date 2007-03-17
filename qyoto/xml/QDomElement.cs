//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomElement")]
	public class QDomElement : QDomNode, IDisposable {
 		protected QDomElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomElement), this);
			interceptor = (QDomElement) realProxy.GetTransparentProxy();
		}
		public QDomElement() : this((Type) null) {
			CreateProxy();
			NewQDomElement();
		}
		[SmokeMethod("QDomElement", "()", "")]
		private void NewQDomElement() {
			((QDomElement) interceptor).NewQDomElement();
		}
		public QDomElement(QDomElement x) : this((Type) null) {
			CreateProxy();
			NewQDomElement(x);
		}
		[SmokeMethod("QDomElement", "(const QDomElement&)", "#")]
		private void NewQDomElement(QDomElement x) {
			((QDomElement) interceptor).NewQDomElement(x);
		}
		[SmokeMethod("attribute", "(const QString&, const QString&) const", "$$")]
		public string Attribute(string name, string defValue) {
			return ((QDomElement) interceptor).Attribute(name,defValue);
		}
		[SmokeMethod("attribute", "(const QString&) const", "$")]
		public string Attribute(string name) {
			return ((QDomElement) interceptor).Attribute(name);
		}
		[SmokeMethod("setAttribute", "(const QString&, const QString&)", "$$")]
		public void SetAttribute(string name, string value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, qlonglong)", "$?")]
		public void SetAttribute(string name, long value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, qulonglong)", "$$")]
		public void SetAttribute(string name, ulong value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, int)", "$$")]
		public void SetAttribute(string name, int value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, uint)", "$$")]
		public void SetAttribute(string name, uint value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, float)", "$$")]
		public void SetAttribute(string name, float value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, double)", "$$")]
		public void SetAttribute(string name, double value) {
			((QDomElement) interceptor).SetAttribute(name,value);
		}
		[SmokeMethod("removeAttribute", "(const QString&)", "$")]
		public void RemoveAttribute(string name) {
			((QDomElement) interceptor).RemoveAttribute(name);
		}
		[SmokeMethod("attributeNode", "(const QString&)", "$")]
		public QDomAttr AttributeNode(string name) {
			return ((QDomElement) interceptor).AttributeNode(name);
		}
		[SmokeMethod("setAttributeNode", "(const QDomAttr&)", "#")]
		public QDomAttr SetAttributeNode(QDomAttr newAttr) {
			return ((QDomElement) interceptor).SetAttributeNode(newAttr);
		}
		[SmokeMethod("removeAttributeNode", "(const QDomAttr&)", "#")]
		public QDomAttr RemoveAttributeNode(QDomAttr oldAttr) {
			return ((QDomElement) interceptor).RemoveAttributeNode(oldAttr);
		}
		[SmokeMethod("elementsByTagName", "(const QString&) const", "$")]
		public QDomNodeList ElementsByTagName(string tagname) {
			return ((QDomElement) interceptor).ElementsByTagName(tagname);
		}
		[SmokeMethod("hasAttribute", "(const QString&) const", "$")]
		public bool HasAttribute(string name) {
			return ((QDomElement) interceptor).HasAttribute(name);
		}
		[SmokeMethod("attributeNS", "(const QString, const QString&, const QString&) const", "$$$")]
		public string AttributeNS(string nsURI, string localName, string defValue) {
			return ((QDomElement) interceptor).AttributeNS(nsURI,localName,defValue);
		}
		[SmokeMethod("attributeNS", "(const QString, const QString&) const", "$$")]
		public string AttributeNS(string nsURI, string localName) {
			return ((QDomElement) interceptor).AttributeNS(nsURI,localName);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, const QString&)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, string value) {
			((QDomElement) interceptor).SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, int)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, int value) {
			((QDomElement) interceptor).SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, uint)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, uint value) {
			((QDomElement) interceptor).SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, qlonglong)", "$$?")]
		public void SetAttributeNS(string nsURI, string qName, long value) {
			((QDomElement) interceptor).SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, qulonglong)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, ulong value) {
			((QDomElement) interceptor).SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, double)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, double value) {
			((QDomElement) interceptor).SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("removeAttributeNS", "(const QString&, const QString&)", "$$")]
		public void RemoveAttributeNS(string nsURI, string localName) {
			((QDomElement) interceptor).RemoveAttributeNS(nsURI,localName);
		}
		[SmokeMethod("attributeNodeNS", "(const QString&, const QString&)", "$$")]
		public QDomAttr AttributeNodeNS(string nsURI, string localName) {
			return ((QDomElement) interceptor).AttributeNodeNS(nsURI,localName);
		}
		[SmokeMethod("setAttributeNodeNS", "(const QDomAttr&)", "#")]
		public QDomAttr SetAttributeNodeNS(QDomAttr newAttr) {
			return ((QDomElement) interceptor).SetAttributeNodeNS(newAttr);
		}
		[SmokeMethod("elementsByTagNameNS", "(const QString&, const QString&) const", "$$")]
		public QDomNodeList ElementsByTagNameNS(string nsURI, string localName) {
			return ((QDomElement) interceptor).ElementsByTagNameNS(nsURI,localName);
		}
		[SmokeMethod("hasAttributeNS", "(const QString&, const QString&) const", "$$")]
		public bool HasAttributeNS(string nsURI, string localName) {
			return ((QDomElement) interceptor).HasAttributeNS(nsURI,localName);
		}
		[SmokeMethod("tagName", "() const", "")]
		public string TagName() {
			return ((QDomElement) interceptor).TagName();
		}
		[SmokeMethod("setTagName", "(const QString&)", "$")]
		public void SetTagName(string name) {
			((QDomElement) interceptor).SetTagName(name);
		}
		[SmokeMethod("attributes", "() const", "")]
		public QDomNamedNodeMap Attributes() {
			return ((QDomElement) interceptor).Attributes();
		}
		[SmokeMethod("nodeType", "() const", "")]
		public QDomNode.NodeType NodeType() {
			return ((QDomElement) interceptor).NodeType();
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ((QDomElement) interceptor).Text();
		}
		~QDomElement() {
			DisposeQDomElement();
		}
		public void Dispose() {
			DisposeQDomElement();
		}
		[SmokeMethod("~QDomElement", "()", "")]
		private void DisposeQDomElement() {
			((QDomElement) interceptor).DisposeQDomElement();
		}
	}
}
