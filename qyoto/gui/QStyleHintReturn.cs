//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleHintReturn")]
	public class QStyleHintReturn : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QStyleHintReturn(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleHintReturn), this);
			_interceptor = (QStyleHintReturn) realProxy.GetTransparentProxy();
		}
		private QStyleHintReturn ProxyQStyleHintReturn() {
			return (QStyleHintReturn) _interceptor;
		}
		public enum HintReturnType {
			SH_Default = 0xf000,
			SH_Mask = 0,
		}
		public enum StyleOptionType {
			Type = QStyleHintReturn.HintReturnType.SH_Default,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleHintReturn(int version, int type) : this((Type) null) {
			CreateProxy();
			NewQStyleHintReturn(version,type);
		}
		[SmokeMethod("QStyleHintReturn", "(int, int)", "$$")]
		private void NewQStyleHintReturn(int version, int type) {
			ProxyQStyleHintReturn().NewQStyleHintReturn(version,type);
		}
		public QStyleHintReturn(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleHintReturn(version);
		}
		[SmokeMethod("QStyleHintReturn", "(int)", "$")]
		private void NewQStyleHintReturn(int version) {
			ProxyQStyleHintReturn().NewQStyleHintReturn(version);
		}
		public QStyleHintReturn() : this((Type) null) {
			CreateProxy();
			NewQStyleHintReturn();
		}
		[SmokeMethod("QStyleHintReturn", "()", "")]
		private void NewQStyleHintReturn() {
			ProxyQStyleHintReturn().NewQStyleHintReturn();
		}
		~QStyleHintReturn() {
			DisposeQStyleHintReturn();
		}
		public void Dispose() {
			DisposeQStyleHintReturn();
		}
		[SmokeMethod("~QStyleHintReturn", "()", "")]
		private void DisposeQStyleHintReturn() {
			ProxyQStyleHintReturn().DisposeQStyleHintReturn();
		}
	}
}
