//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDomDocument")]
	public class QDomDocument : QDomNode, IDisposable {
 		protected QDomDocument(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomDocument), this);
			interceptor = (QDomDocument) realProxy.GetTransparentProxy();
		}
		public QDomDocument() : this((Type) null) {
			CreateProxy();
			NewQDomDocument();
		}
		[SmokeMethod("QDomDocument", "()", "")]
		private void NewQDomDocument() {
			((QDomDocument) interceptor).NewQDomDocument();
		}
		public QDomDocument(string name) : this((Type) null) {
			CreateProxy();
			NewQDomDocument(name);
		}
		[SmokeMethod("QDomDocument", "(const QString&)", "$")]
		private void NewQDomDocument(string name) {
			((QDomDocument) interceptor).NewQDomDocument(name);
		}
		public QDomDocument(QDomDocumentType doctype) : this((Type) null) {
			CreateProxy();
			NewQDomDocument(doctype);
		}
		[SmokeMethod("QDomDocument", "(const QDomDocumentType&)", "#")]
		private void NewQDomDocument(QDomDocumentType doctype) {
			((QDomDocument) interceptor).NewQDomDocument(doctype);
		}
		public QDomDocument(QDomDocument x) : this((Type) null) {
			CreateProxy();
			NewQDomDocument(x);
		}
		[SmokeMethod("QDomDocument", "(const QDomDocument&)", "#")]
		private void NewQDomDocument(QDomDocument x) {
			((QDomDocument) interceptor).NewQDomDocument(x);
		}
		[SmokeMethod("createElement", "(const QString&)", "$")]
		public QDomElement CreateElement(string tagName) {
			return ((QDomDocument) interceptor).CreateElement(tagName);
		}
		[SmokeMethod("createDocumentFragment", "()", "")]
		public QDomDocumentFragment CreateDocumentFragment() {
			return ((QDomDocument) interceptor).CreateDocumentFragment();
		}
		[SmokeMethod("createTextNode", "(const QString&)", "$")]
		public QDomText CreateTextNode(string data) {
			return ((QDomDocument) interceptor).CreateTextNode(data);
		}
		[SmokeMethod("createComment", "(const QString&)", "$")]
		public QDomComment CreateComment(string data) {
			return ((QDomDocument) interceptor).CreateComment(data);
		}
		[SmokeMethod("createCDATASection", "(const QString&)", "$")]
		public QDomCDATASection CreateCDATASection(string data) {
			return ((QDomDocument) interceptor).CreateCDATASection(data);
		}
		[SmokeMethod("createProcessingInstruction", "(const QString&, const QString&)", "$$")]
		public QDomProcessingInstruction CreateProcessingInstruction(string target, string data) {
			return ((QDomDocument) interceptor).CreateProcessingInstruction(target,data);
		}
		[SmokeMethod("createAttribute", "(const QString&)", "$")]
		public QDomAttr CreateAttribute(string name) {
			return ((QDomDocument) interceptor).CreateAttribute(name);
		}
		[SmokeMethod("createEntityReference", "(const QString&)", "$")]
		public QDomEntityReference CreateEntityReference(string name) {
			return ((QDomDocument) interceptor).CreateEntityReference(name);
		}
		[SmokeMethod("elementsByTagName", "(const QString&) const", "$")]
		public QDomNodeList ElementsByTagName(string tagname) {
			return ((QDomDocument) interceptor).ElementsByTagName(tagname);
		}
		[SmokeMethod("importNode", "(const QDomNode&, bool)", "#$")]
		public QDomNode ImportNode(QDomNode importedNode, bool deep) {
			return ((QDomDocument) interceptor).ImportNode(importedNode,deep);
		}
		[SmokeMethod("createElementNS", "(const QString&, const QString&)", "$$")]
		public QDomElement CreateElementNS(string nsURI, string qName) {
			return ((QDomDocument) interceptor).CreateElementNS(nsURI,qName);
		}
		[SmokeMethod("createAttributeNS", "(const QString&, const QString&)", "$$")]
		public QDomAttr CreateAttributeNS(string nsURI, string qName) {
			return ((QDomDocument) interceptor).CreateAttributeNS(nsURI,qName);
		}
		[SmokeMethod("elementsByTagNameNS", "(const QString&, const QString&)", "$$")]
		public QDomNodeList ElementsByTagNameNS(string nsURI, string localName) {
			return ((QDomDocument) interceptor).ElementsByTagNameNS(nsURI,localName);
		}
		[SmokeMethod("elementById", "(const QString&)", "$")]
		public QDomElement ElementById(string elementId) {
			return ((QDomDocument) interceptor).ElementById(elementId);
		}
		[SmokeMethod("doctype", "() const", "")]
		public QDomDocumentType Doctype() {
			return ((QDomDocument) interceptor).Doctype();
		}
		[SmokeMethod("implementation", "() const", "")]
		public QDomImplementation Implementation() {
			return ((QDomDocument) interceptor).Implementation();
		}
		[SmokeMethod("documentElement", "() const", "")]
		public QDomElement DocumentElement() {
			return ((QDomDocument) interceptor).DocumentElement();
		}
		[SmokeMethod("nodeType", "() const", "")]
		public QDomNode.NodeType NodeType() {
			return ((QDomDocument) interceptor).NodeType();
		}
		[SmokeMethod("setContent", "(const QByteArray&, bool, QString*, int*, int*)", "#$$$$")]
		public bool SetContent(QByteArray text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(const QByteArray&, bool, QString*, int*)", "#$$$")]
		public bool SetContent(QByteArray text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(const QByteArray&, bool, QString*)", "#$$")]
		public bool SetContent(QByteArray text, bool namespaceProcessing, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing,errorMsg);
		}
		[SmokeMethod("setContent", "(const QByteArray&, bool)", "#$")]
		public bool SetContent(QByteArray text, bool namespaceProcessing) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing);
		}
		[SmokeMethod("setContent", "(const QString&, bool, QString*, int*, int*)", "$$$$$")]
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(const QString&, bool, QString*, int*)", "$$$$")]
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(const QString&, bool, QString*)", "$$$")]
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing,errorMsg);
		}
		[SmokeMethod("setContent", "(const QString&, bool)", "$$")]
		public bool SetContent(string text, bool namespaceProcessing) {
			return ((QDomDocument) interceptor).SetContent(text,namespaceProcessing);
		}
		[SmokeMethod("setContent", "(QIODevice*, bool, QString*, int*, int*)", "#$$$$")]
		public bool SetContent(QIODevice dev, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(dev,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(QIODevice*, bool, QString*, int*)", "#$$$")]
		public bool SetContent(QIODevice dev, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(dev,namespaceProcessing,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(QIODevice*, bool, QString*)", "#$$")]
		public bool SetContent(QIODevice dev, bool namespaceProcessing, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(dev,namespaceProcessing,errorMsg);
		}
		[SmokeMethod("setContent", "(QIODevice*, bool)", "#$")]
		public bool SetContent(QIODevice dev, bool namespaceProcessing) {
			return ((QDomDocument) interceptor).SetContent(dev,namespaceProcessing);
		}
		[SmokeMethod("setContent", "(const QByteArray&, QString*, int*, int*)", "#$$$")]
		public bool SetContent(QByteArray text, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(text,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(const QByteArray&, QString*, int*)", "#$$")]
		public bool SetContent(QByteArray text, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(text,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(const QByteArray&, QString*)", "#$")]
		public bool SetContent(QByteArray text, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(text,errorMsg);
		}
		[SmokeMethod("setContent", "(const QByteArray&)", "#")]
		public bool SetContent(QByteArray text) {
			return ((QDomDocument) interceptor).SetContent(text);
		}
		[SmokeMethod("setContent", "(const QString&, QString*, int*, int*)", "$$$$")]
		public bool SetContent(string text, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(text,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(const QString&, QString*, int*)", "$$$")]
		public bool SetContent(string text, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(text,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(const QString&, QString*)", "$$")]
		public bool SetContent(string text, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(text,errorMsg);
		}
		[SmokeMethod("setContent", "(const QString&)", "$")]
		public bool SetContent(string text) {
			return ((QDomDocument) interceptor).SetContent(text);
		}
		[SmokeMethod("setContent", "(QIODevice*, QString*, int*, int*)", "#$$$")]
		public bool SetContent(QIODevice dev, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(dev,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(QIODevice*, QString*, int*)", "#$$")]
		public bool SetContent(QIODevice dev, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(dev,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(QIODevice*, QString*)", "#$")]
		public bool SetContent(QIODevice dev, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(dev,errorMsg);
		}
		[SmokeMethod("setContent", "(QIODevice*)", "#")]
		public bool SetContent(QIODevice dev) {
			return ((QDomDocument) interceptor).SetContent(dev);
		}
		[SmokeMethod("setContent", "(QXmlInputSource*, QXmlReader*, QString*, int*, int*)", "##$$$")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ((QDomDocument) interceptor).SetContent(source,reader,errorMsg,out errorLine,out errorColumn);
		}
		[SmokeMethod("setContent", "(QXmlInputSource*, QXmlReader*, QString*, int*)", "##$$")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg, out int errorLine) {
			return ((QDomDocument) interceptor).SetContent(source,reader,errorMsg,out errorLine);
		}
		[SmokeMethod("setContent", "(QXmlInputSource*, QXmlReader*, QString*)", "##$")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg) {
			return ((QDomDocument) interceptor).SetContent(source,reader,errorMsg);
		}
		[SmokeMethod("setContent", "(QXmlInputSource*, QXmlReader*)", "##")]
		public bool SetContent(QXmlInputSource source, QXmlReader reader) {
			return ((QDomDocument) interceptor).SetContent(source,reader);
		}
		[SmokeMethod("toString", "(int) const", "$")]
		public string ToString(int arg1) {
			return ((QDomDocument) interceptor).ToString(arg1);
		}
		[SmokeMethod("toString", "() const", "")]
		public string ToString() {
			return ((QDomDocument) interceptor).ToString();
		}
		[SmokeMethod("toByteArray", "(int) const", "$")]
		public QByteArray ToByteArray(int arg1) {
			return ((QDomDocument) interceptor).ToByteArray(arg1);
		}
		[SmokeMethod("toByteArray", "() const", "")]
		public QByteArray ToByteArray() {
			return ((QDomDocument) interceptor).ToByteArray();
		}
		~QDomDocument() {
			DisposeQDomDocument();
		}
		public void Dispose() {
			DisposeQDomDocument();
		}
		[SmokeMethod("~QDomDocument", "()", "")]
		private void DisposeQDomDocument() {
			((QDomDocument) interceptor).DisposeQDomDocument();
		}
	}
}
