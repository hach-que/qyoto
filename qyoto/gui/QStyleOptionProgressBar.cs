//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionProgressBar")]
	public class QStyleOptionProgressBar : QStyleOption, IDisposable {
 		protected QStyleOptionProgressBar(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleOptionProgressBar), "QStyleOptionProgressBar", this);
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_ProgressBar,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionProgressBar() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionProgressBar", "QStyleOptionProgressBar()", typeof(void));
		}
		public QStyleOptionProgressBar(QStyleOptionProgressBar other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionProgressBar#", "QStyleOptionProgressBar(const QStyleOptionProgressBar&)", typeof(void), typeof(QStyleOptionProgressBar), other);
		}
		public QStyleOptionProgressBar(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionProgressBar$", "QStyleOptionProgressBar(int)", typeof(void), typeof(int), version);
		}
		~QStyleOptionProgressBar() {
			interceptor.Invoke("~QStyleOptionProgressBar", "~QStyleOptionProgressBar()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStyleOptionProgressBar", "~QStyleOptionProgressBar()", typeof(void));
		}
	}
}
