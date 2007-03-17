//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleInterface")]
	public abstract class QAccessibleInterface : QAccessible {
 		protected QAccessibleInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAccessibleInterface), this);
			interceptor = (QAccessibleInterface) realProxy.GetTransparentProxy();
		}
		[SmokeMethod("isValid", "() const", "")]
		public abstract bool IsValid();
		[SmokeMethod("object", "() const", "")]
		public abstract QObject Object();
		[SmokeMethod("childCount", "() const", "")]
		public abstract int ChildCount();
		[SmokeMethod("indexOfChild", "(const QAccessibleInterface*) const", "#")]
		public abstract int IndexOfChild(QAccessibleInterface arg1);
		[SmokeMethod("relationTo", "(int, const QAccessibleInterface*, int) const", "$#$")]
		public abstract int RelationTo(int child, QAccessibleInterface other, int otherChild);
		[SmokeMethod("childAt", "(int, int) const", "$$")]
		public abstract int ChildAt(int x, int y);
		[SmokeMethod("navigate", "(QAccessible::RelationFlag, int, QAccessibleInterface**) const", "$$?")]
		public abstract int Navigate(QAccessible.RelationFlag relation, int index, QAccessibleInterface iface);
		[SmokeMethod("text", "(QAccessible::Text, int) const", "$$")]
		public abstract string Text(QAccessible.Text t, int child);
		[SmokeMethod("setText", "(QAccessible::Text, int, const QString&)", "$$$")]
		public abstract void SetText(QAccessible.Text t, int child, string text);
		[SmokeMethod("rect", "(int) const", "$")]
		public abstract QRect Rect(int child);
		[SmokeMethod("role", "(int) const", "$")]
		public abstract QAccessible.Role Role(int child);
		[SmokeMethod("state", "(int) const", "$")]
		public abstract int State(int child);
		[SmokeMethod("userActionCount", "(int) const", "$")]
		public abstract int UserActionCount(int child);
		[SmokeMethod("actionText", "(int, QAccessible::Text, int) const", "$$$")]
		public abstract string ActionText(int action, QAccessible.Text t, int child);
		[SmokeMethod("doAction", "(int, int, const QVariantList&)", "$$?")]
		public abstract bool DoAction(int action, int child, List<QVariant> arg3);
		[SmokeMethod("invokeMethod", "(QAccessible::Method, int, const QVariantList&)", "$$?")]
		public QVariant InvokeMethod(QAccessible.Method method, int child, List<QVariant> arg3) {
			return ((QAccessibleInterface) interceptor).InvokeMethod(method,child,arg3);
		}
		[SmokeMethod("invokeMethod", "(QAccessible::Method, int)", "$$")]
		public QVariant InvokeMethod(QAccessible.Method method, int child) {
			return ((QAccessibleInterface) interceptor).InvokeMethod(method,child);
		}
		[SmokeMethod("invokeMethod", "(QAccessible::Method)", "$")]
		public QVariant InvokeMethod(QAccessible.Method method) {
			return ((QAccessibleInterface) interceptor).InvokeMethod(method);
		}
		public QAccessibleInterface() : this((Type) null) {
			CreateProxy();
			NewQAccessibleInterface();
		}
		[SmokeMethod("QAccessibleInterface", "()", "")]
		private void NewQAccessibleInterface() {
			((QAccessibleInterface) interceptor).NewQAccessibleInterface();
		}
	}
}
