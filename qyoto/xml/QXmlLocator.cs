//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlLocator")]
	public abstract class QXmlLocator : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QXmlLocator(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlLocator), this);
			_interceptor = (QXmlLocator) realProxy.GetTransparentProxy();
		}
		private QXmlLocator ProxyQXmlLocator() {
			return (QXmlLocator) _interceptor;
		}
		public QXmlLocator() : this((Type) null) {
			CreateProxy();
			NewQXmlLocator();
		}
		[SmokeMethod("QXmlLocator", "()", "")]
		private void NewQXmlLocator() {
			ProxyQXmlLocator().NewQXmlLocator();
		}
		public abstract int ColumnNumber();
		public abstract int LineNumber();
	}
}
