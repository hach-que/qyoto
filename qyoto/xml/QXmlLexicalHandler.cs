//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlLexicalHandler")]
	public abstract class QXmlLexicalHandler : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QXmlLexicalHandler(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlLexicalHandler), this);
			_interceptor = (QXmlLexicalHandler) realProxy.GetTransparentProxy();
		}
		private QXmlLexicalHandler ProxyQXmlLexicalHandler() {
			return (QXmlLexicalHandler) _interceptor;
		}
		public abstract bool StartDTD(string name, string publicId, string systemId);
		public abstract bool EndDTD();
		public abstract bool StartEntity(string name);
		public abstract bool EndEntity(string name);
		public abstract bool StartCDATA();
		public abstract bool EndCDATA();
		public abstract bool Comment(string ch);
		public abstract string ErrorString();
		public QXmlLexicalHandler() : this((Type) null) {
			CreateProxy();
			NewQXmlLexicalHandler();
		}
		[SmokeMethod("QXmlLexicalHandler", "()", "")]
		private void NewQXmlLexicalHandler() {
			ProxyQXmlLexicalHandler().NewQXmlLexicalHandler();
		}
	}
}
