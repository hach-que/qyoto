//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleInterfaceEx")]
	public abstract class QAccessibleInterfaceEx : QAccessibleInterface {
 		protected QAccessibleInterfaceEx(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAccessibleInterfaceEx), "QAccessibleInterfaceEx", this);
		}
		[SmokeMethod("invokeMethodEx(QAccessible::Method, int, const QVariantList&)")]
		public abstract QVariant InvokeMethodEx(QAccessible.Method method, int child, List<QVariant> arg3);
		public QAccessibleInterfaceEx() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleInterfaceEx", "QAccessibleInterfaceEx()", typeof(void));
		}
	}
}
