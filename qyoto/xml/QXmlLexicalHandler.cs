//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlLexicalHandler")]
	public abstract class QXmlLexicalHandler : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlLexicalHandler(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlLexicalHandler), this);
		}
		[SmokeMethod("startDTD(const QString&, const QString&, const QString&)")]
		public abstract bool StartDTD(string name, string publicId, string systemId);
		[SmokeMethod("endDTD()")]
		public abstract bool EndDTD();
		[SmokeMethod("startEntity(const QString&)")]
		public abstract bool StartEntity(string name);
		[SmokeMethod("endEntity(const QString&)")]
		public abstract bool EndEntity(string name);
		[SmokeMethod("startCDATA()")]
		public abstract bool StartCDATA();
		[SmokeMethod("endCDATA()")]
		public abstract bool EndCDATA();
		[SmokeMethod("comment(const QString&)")]
		public abstract bool Comment(string ch);
		[SmokeMethod("errorString() const")]
		public abstract string ErrorString();
		public QXmlLexicalHandler() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlLexicalHandler", "QXmlLexicalHandler()", typeof(void));
		}
	}
}
