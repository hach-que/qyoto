//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionTabBarBase")]
	public class QStyleOptionTabBarBase : QStyleOption, IDisposable {
 		protected QStyleOptionTabBarBase(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleOptionTabBarBase), "QStyleOptionTabBarBase", this);
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_TabBarBase,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionTabBarBase() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionTabBarBase", "QStyleOptionTabBarBase()", typeof(void));
		}
		public QStyleOptionTabBarBase(QStyleOptionTabBarBase other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionTabBarBase#", "QStyleOptionTabBarBase(const QStyleOptionTabBarBase&)", typeof(void), typeof(QStyleOptionTabBarBase), other);
		}
		public QStyleOptionTabBarBase(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionTabBarBase$", "QStyleOptionTabBarBase(int)", typeof(void), typeof(int), version);
		}
		~QStyleOptionTabBarBase() {
			interceptor.Invoke("~QStyleOptionTabBarBase", "~QStyleOptionTabBarBase()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStyleOptionTabBarBase", "~QStyleOptionTabBarBase()", typeof(void));
		}
	}
}
