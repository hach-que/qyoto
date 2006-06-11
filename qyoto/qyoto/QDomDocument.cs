//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QDomDocument")]
	public class QDomDocument : QDomNode, IDisposable {
 		protected QDomDocument(Type dummy) : base((Type) null) {}
		interface IQDomDocumentProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomDocument), this);
			_interceptor = (QDomDocument) realProxy.GetTransparentProxy();
		}
		private QDomDocument ProxyQDomDocument() {
			return (QDomDocument) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomDocument() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomDocumentProxy), null);
			_staticInterceptor = (IQDomDocumentProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomDocumentProxy StaticQDomDocument() {
			return (IQDomDocumentProxy) _staticInterceptor;
		}

		public QDomDocument() : this((Type) null) {
			CreateProxy();
			NewQDomDocument();
		}
		[SmokeMethod("QDomDocument()")]
		private void NewQDomDocument() {
			ProxyQDomDocument().NewQDomDocument();
		}
		public QDomDocument(string name) : this((Type) null) {
			CreateProxy();
			NewQDomDocument(name);
		}
		[SmokeMethod("QDomDocument(const QString&)")]
		private void NewQDomDocument(string name) {
			ProxyQDomDocument().NewQDomDocument(name);
		}
		public QDomDocument(QDomDocumentType doctype) : this((Type) null) {
			CreateProxy();
			NewQDomDocument(doctype);
		}
		[SmokeMethod("QDomDocument(const QDomDocumentType&)")]
		private void NewQDomDocument(QDomDocumentType doctype) {
			ProxyQDomDocument().NewQDomDocument(doctype);
		}
		public QDomDocument(QDomDocument x) : this((Type) null) {
			CreateProxy();
			NewQDomDocument(x);
		}
		[SmokeMethod("QDomDocument(const QDomDocument&)")]
		private void NewQDomDocument(QDomDocument x) {
			ProxyQDomDocument().NewQDomDocument(x);
		}
		[SmokeMethod("createElement(const QString&)")]
		public QDomElement CreateElement(string tagName) {
			return ProxyQDomDocument().CreateElement(tagName);
		}
		[SmokeMethod("createDocumentFragment()")]
		public QDomDocumentFragment CreateDocumentFragment() {
			return ProxyQDomDocument().CreateDocumentFragment();
		}
		[SmokeMethod("createTextNode(const QString&)")]
		public QDomText CreateTextNode(string data) {
			return ProxyQDomDocument().CreateTextNode(data);
		}
		[SmokeMethod("createComment(const QString&)")]
		public QDomComment CreateComment(string data) {
			return ProxyQDomDocument().CreateComment(data);
		}
		[SmokeMethod("createCDATASection(const QString&)")]
		public QDomCDATASection CreateCDATASection(string data) {
			return ProxyQDomDocument().CreateCDATASection(data);
		}
		[SmokeMethod("createProcessingInstruction(const QString&, const QString&)")]
		public QDomProcessingInstruction CreateProcessingInstruction(string target, string data) {
			return ProxyQDomDocument().CreateProcessingInstruction(target,data);
		}
		[SmokeMethod("createAttribute(const QString&)")]
		public QDomAttr CreateAttribute(string name) {
			return ProxyQDomDocument().CreateAttribute(name);
		}
		[SmokeMethod("createEntityReference(const QString&)")]
		public QDomEntityReference CreateEntityReference(string name) {
			return ProxyQDomDocument().CreateEntityReference(name);
		}
		[SmokeMethod("elementsByTagName(const QString&) const")]
		public ArrayList ElementsByTagName(string tagname) {
			return ProxyQDomDocument().ElementsByTagName(tagname);
		}
		[SmokeMethod("importNode(const QDomNode&, bool)")]
		public QDomNode ImportNode(QDomNode importedNode, bool deep) {
			return ProxyQDomDocument().ImportNode(importedNode,deep);
		}
		[SmokeMethod("createElementNS(const QString&, const QString&)")]
		public QDomElement CreateElementNS(string nsURI, string qName) {
			return ProxyQDomDocument().CreateElementNS(nsURI,qName);
		}
		[SmokeMethod("createAttributeNS(const QString&, const QString&)")]
		public QDomAttr CreateAttributeNS(string nsURI, string qName) {
			return ProxyQDomDocument().CreateAttributeNS(nsURI,qName);
		}
		[SmokeMethod("elementsByTagNameNS(const QString&, const QString&)")]
		public ArrayList ElementsByTagNameNS(string nsURI, string localName) {
			return ProxyQDomDocument().ElementsByTagNameNS(nsURI,localName);
		}
		[SmokeMethod("elementById(const QString&)")]
		public QDomElement ElementById(string elementId) {
			return ProxyQDomDocument().ElementById(elementId);
		}
		[SmokeMethod("doctype() const")]
		public QDomDocumentType Doctype() {
			return ProxyQDomDocument().Doctype();
		}
		[SmokeMethod("implementation() const")]
		public QDomImplementation Implementation() {
			return ProxyQDomDocument().Implementation();
		}
		[SmokeMethod("documentElement() const")]
		public QDomElement DocumentElement() {
			return ProxyQDomDocument().DocumentElement();
		}
		[SmokeMethod("nodeType() const")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomDocument().NodeType();
		}
		[SmokeMethod("setContent(const QByteArray&, bool, QString*, int*, int*)")]
		public bool SetContent(QByteArray text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(const QByteArray&, bool, QString*, int*)")]
		public bool SetContent(QByteArray text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(const QByteArray&, bool, QString*)")]
		public bool SetContent(QByteArray text, bool namespaceProcessing, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg);
		}
		[SmokeMethod("setContent(const QByteArray&, bool)")]
		public bool SetContent(QByteArray text, bool namespaceProcessing) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing);
		}
		[SmokeMethod("setContent(const QString&, bool, QString*, int*, int*)")]
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(const QString&, bool, QString*, int*)")]
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(const QString&, bool, QString*)")]
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg);
		}
		[SmokeMethod("setContent(const QString&, bool)")]
		public bool SetContent(string text, bool namespaceProcessing) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing);
		}
		[SmokeMethod("setContent(QIODevice*, bool, QString*, int*, int*)")]
		public bool SetContent(IQIODevice dev, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(QIODevice*, bool, QString*, int*)")]
		public bool SetContent(IQIODevice dev, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(QIODevice*, bool, QString*)")]
		public bool SetContent(IQIODevice dev, bool namespaceProcessing, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing,errorMsg);
		}
		[SmokeMethod("setContent(QIODevice*, bool)")]
		public bool SetContent(IQIODevice dev, bool namespaceProcessing) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing);
		}
		[SmokeMethod("setContent(const QByteArray&, QString*, int*, int*)")]
		public bool SetContent(QByteArray text, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(const QByteArray&, QString*, int*)")]
		public bool SetContent(QByteArray text, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(const QByteArray&, QString*)")]
		public bool SetContent(QByteArray text, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,errorMsg);
		}
		[SmokeMethod("setContent(const QByteArray&)")]
		public bool SetContent(QByteArray text) {
			return ProxyQDomDocument().SetContent(text);
		}
		[SmokeMethod("setContent(const QString&, QString*, int*, int*)")]
		public bool SetContent(string text, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(const QString&, QString*, int*)")]
		public bool SetContent(string text, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(const QString&, QString*)")]
		public bool SetContent(string text, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,errorMsg);
		}
		[SmokeMethod("setContent(const QString&)")]
		public bool SetContent(string text) {
			return ProxyQDomDocument().SetContent(text);
		}
		[SmokeMethod("setContent(QIODevice*, QString*, int*, int*)")]
		public bool SetContent(IQIODevice dev, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(dev,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(QIODevice*, QString*, int*)")]
		public bool SetContent(IQIODevice dev, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(dev,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(QIODevice*, QString*)")]
		public bool SetContent(IQIODevice dev, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(dev,errorMsg);
		}
		[SmokeMethod("setContent(QIODevice*)")]
		public bool SetContent(IQIODevice dev) {
			return ProxyQDomDocument().SetContent(dev);
		}
		[SmokeMethod("setContent(QXmlInputSource*, QXmlReader*, QString*, int*, int*)")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(source,reader,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent(QXmlInputSource*, QXmlReader*, QString*, int*)")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(source,reader,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent(QXmlInputSource*, QXmlReader*, QString*)")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(source,reader,errorMsg);
		}
		[SmokeMethod("setContent(QXmlInputSource*, QXmlReader*)")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader) {
			return ProxyQDomDocument().SetContent(source,reader);
		}
		[SmokeMethod("toString(int) const")]
		public new string ToString(int arg1) {
			return ProxyQDomDocument().ToString(arg1);
		}
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQDomDocument().ToString();
		}
		[SmokeMethod("toByteArray(int) const")]
		public QByteArray ToByteArray(int arg1) {
			return ProxyQDomDocument().ToByteArray(arg1);
		}
		[SmokeMethod("toByteArray() const")]
		public QByteArray ToByteArray() {
			return ProxyQDomDocument().ToByteArray();
		}
		~QDomDocument() {
			DisposeQDomDocument();
		}
		public void Dispose() {
			DisposeQDomDocument();
		}
		[SmokeMethod("~QDomDocument()")]
		private void DisposeQDomDocument() {
			ProxyQDomDocument().DisposeQDomDocument();
		}
	}
}
