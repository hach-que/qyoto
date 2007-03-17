//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	public interface IQXmlContentHandler {
		void SetDocumentLocator(QXmlLocator locator);
		bool StartDocument();
		bool EndDocument();
		bool StartPrefixMapping(string prefix, string uri);
		bool EndPrefixMapping(string prefix);
		bool StartElement(string namespaceURI, string localName, string qName, QXmlAttributes atts);
		bool EndElement(string namespaceURI, string localName, string qName);
		bool Characters(string ch);
		bool IgnorableWhitespace(string ch);
		bool ProcessingInstruction(string target, string data);
		bool SkippedEntity(string name);
		string ErrorString();
	}

	[SmokeClass("QXmlContentHandler")]
	public abstract class QXmlContentHandler : MarshalByRefObject, IQXmlContentHandler {
		protected QXmlContentHandler interceptor = null;
		private IntPtr smokeObject;
		protected QXmlContentHandler(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlContentHandler), this);
			interceptor = (QXmlContentHandler) realProxy.GetTransparentProxy();
		}
		[SmokeMethod("setDocumentLocator", "(QXmlLocator*)", "#")]
		public abstract void SetDocumentLocator(QXmlLocator locator);
		[SmokeMethod("startDocument", "()", "")]
		public abstract bool StartDocument();
		[SmokeMethod("endDocument", "()", "")]
		public abstract bool EndDocument();
		[SmokeMethod("startPrefixMapping", "(const QString&, const QString&)", "$$")]
		public abstract bool StartPrefixMapping(string prefix, string uri);
		[SmokeMethod("endPrefixMapping", "(const QString&)", "$")]
		public abstract bool EndPrefixMapping(string prefix);
		[SmokeMethod("startElement", "(const QString&, const QString&, const QString&, const QXmlAttributes&)", "$$$#")]
		public abstract bool StartElement(string namespaceURI, string localName, string qName, QXmlAttributes atts);
		[SmokeMethod("endElement", "(const QString&, const QString&, const QString&)", "$$$")]
		public abstract bool EndElement(string namespaceURI, string localName, string qName);
		[SmokeMethod("characters", "(const QString&)", "$")]
		public abstract bool Characters(string ch);
		[SmokeMethod("ignorableWhitespace", "(const QString&)", "$")]
		public abstract bool IgnorableWhitespace(string ch);
		[SmokeMethod("processingInstruction", "(const QString&, const QString&)", "$$")]
		public abstract bool ProcessingInstruction(string target, string data);
		[SmokeMethod("skippedEntity", "(const QString&)", "$")]
		public abstract bool SkippedEntity(string name);
		[SmokeMethod("errorString", "() const", "")]
		public abstract string ErrorString();
		public QXmlContentHandler() : this((Type) null) {
			CreateProxy();
			NewQXmlContentHandler();
		}
		[SmokeMethod("QXmlContentHandler", "()", "")]
		private void NewQXmlContentHandler() {
			((QXmlContentHandler) interceptor).NewQXmlContentHandler();
		}
	}
}
