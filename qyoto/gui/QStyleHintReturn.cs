//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleHintReturn")]
	public class QStyleHintReturn : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QStyleHintReturn(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleHintReturn), "QStyleHintReturn", this);
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
			interceptor.Invoke("QStyleHintReturn$$", "QStyleHintReturn(int, int)", typeof(void), typeof(int), version, typeof(int), type);
		}
		public QStyleHintReturn(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleHintReturn$", "QStyleHintReturn(int)", typeof(void), typeof(int), version);
		}
		public QStyleHintReturn() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleHintReturn", "QStyleHintReturn()", typeof(void));
		}
		~QStyleHintReturn() {
			interceptor.Invoke("~QStyleHintReturn", "~QStyleHintReturn()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStyleHintReturn", "~QStyleHintReturn()", typeof(void));
		}
	}
}
