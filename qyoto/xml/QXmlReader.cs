//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlReader")]
	public abstract class QXmlReader : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlReader(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlReader), "QXmlReader", this);
		}
		// void* property(const QString& arg1,bool* arg2); >>>> NOT CONVERTED
		// void* property(const QString& arg1); >>>> NOT CONVERTED
		// void setProperty(const QString& arg1,void* arg2); >>>> NOT CONVERTED
		[SmokeMethod("feature(const QString&, bool*) const")]
		public abstract bool Feature(string name, bool ok);
		[SmokeMethod("setFeature(const QString&, bool)")]
		public abstract void SetFeature(string name, bool value);
		[SmokeMethod("hasFeature(const QString&) const")]
		public abstract bool HasFeature(string name);
		[SmokeMethod("hasProperty(const QString&) const")]
		public abstract bool HasProperty(string name);
		[SmokeMethod("setEntityResolver(QXmlEntityResolver*)")]
		public abstract void SetEntityResolver(IQXmlEntityResolver handler);
		[SmokeMethod("entityResolver() const")]
		public abstract IQXmlEntityResolver EntityResolver();
		[SmokeMethod("setDTDHandler(QXmlDTDHandler*)")]
		public abstract void SetDTDHandler(IQXmlDTDHandler handler);
		[SmokeMethod("DTDHandler() const")]
		public abstract IQXmlDTDHandler DTDHandler();
		[SmokeMethod("setContentHandler(QXmlContentHandler*)")]
		public abstract void SetContentHandler(IQXmlContentHandler handler);
		[SmokeMethod("contentHandler() const")]
		public abstract IQXmlContentHandler ContentHandler();
		[SmokeMethod("setErrorHandler(QXmlErrorHandler*)")]
		public abstract void SetErrorHandler(IQXmlErrorHandler handler);
		[SmokeMethod("errorHandler() const")]
		public abstract IQXmlErrorHandler ErrorHandler();
		[SmokeMethod("setLexicalHandler(QXmlLexicalHandler*)")]
		public abstract void SetLexicalHandler(QXmlLexicalHandler handler);
		[SmokeMethod("lexicalHandler() const")]
		public abstract QXmlLexicalHandler LexicalHandler();
		[SmokeMethod("setDeclHandler(QXmlDeclHandler*)")]
		public abstract void SetDeclHandler(IQXmlDeclHandler handler);
		[SmokeMethod("declHandler() const")]
		public abstract IQXmlDeclHandler DeclHandler();
		[SmokeMethod("parse(const QXmlInputSource&)")]
		public abstract bool Parse(QXmlInputSource input);
		public QXmlReader() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlReader", "QXmlReader()", typeof(void));
		}
	}
}
