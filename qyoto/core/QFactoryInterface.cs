//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QFactoryInterface")]
	public abstract class QFactoryInterface : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QFactoryInterface(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFactoryInterface), this);
			_interceptor = (QFactoryInterface) realProxy.GetTransparentProxy();
		}
		private QFactoryInterface ProxyQFactoryInterface() {
			return (QFactoryInterface) _interceptor;
		}
		public abstract List<string> Keys();
		public QFactoryInterface() : this((Type) null) {
			CreateProxy();
			NewQFactoryInterface();
		}
		[SmokeMethod("QFactoryInterface", "()", "")]
		private void NewQFactoryInterface() {
			ProxyQFactoryInterface().NewQFactoryInterface();
		}
	}
}
