//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlLocator")]
	public abstract class QXmlLocator : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlLocator(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlLocator), "QXmlLocator", this);
		}
		public QXmlLocator() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlLocator", "QXmlLocator()", typeof(void));
		}
		[SmokeMethod("columnNumber() const")]
		public abstract int ColumnNumber();
		[SmokeMethod("lineNumber() const")]
		public abstract int LineNumber();
	}
}
