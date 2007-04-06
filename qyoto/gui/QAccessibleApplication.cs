//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleApplication")]
	public abstract class QAccessibleApplication : QAccessibleObject {
 		protected QAccessibleApplication(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAccessibleApplication), this);
		}
		public QAccessibleApplication() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleApplication", "QAccessibleApplication()", typeof(void));
		}
		[SmokeMethod("childCount() const")]
		public override int ChildCount() {
			return (int) interceptor.Invoke("childCount", "childCount() const", typeof(int));
		}
		[SmokeMethod("indexOfChild(const QAccessibleInterface*) const")]
		public override int IndexOfChild(QAccessibleInterface arg1) {
			return (int) interceptor.Invoke("indexOfChild#", "indexOfChild(const QAccessibleInterface*) const", typeof(int), typeof(QAccessibleInterface), arg1);
		}
		[SmokeMethod("relationTo(int, const QAccessibleInterface*, int) const")]
		public override int RelationTo(int arg1, QAccessibleInterface arg2, int arg3) {
			return (int) interceptor.Invoke("relationTo$#$", "relationTo(int, const QAccessibleInterface*, int) const", typeof(int), typeof(int), arg1, typeof(QAccessibleInterface), arg2, typeof(int), arg3);
		}
		[SmokeMethod("childAt(int, int) const")]
		public override int ChildAt(int x, int y) {
			return (int) interceptor.Invoke("childAt$$", "childAt(int, int) const", typeof(int), typeof(int), x, typeof(int), y);
		}
		[SmokeMethod("navigate(QAccessible::RelationFlag, int, QAccessibleInterface**) const")]
		public override int Navigate(QAccessible.RelationFlag arg1, int arg2, QAccessibleInterface arg3) {
			return (int) interceptor.Invoke("navigate$$?", "navigate(QAccessible::RelationFlag, int, QAccessibleInterface**) const", typeof(int), typeof(QAccessible.RelationFlag), arg1, typeof(int), arg2, typeof(QAccessibleInterface), arg3);
		}
		[SmokeMethod("text(QAccessible::Text, int) const")]
		public override string Text(QAccessible.Text t, int child) {
			return (string) interceptor.Invoke("text$$", "text(QAccessible::Text, int) const", typeof(string), typeof(QAccessible.Text), t, typeof(int), child);
		}
		[SmokeMethod("role(int) const")]
		public override QAccessible.Role Role(int child) {
			return (QAccessible.Role) interceptor.Invoke("role$", "role(int) const", typeof(QAccessible.Role), typeof(int), child);
		}
		[SmokeMethod("state(int) const")]
		public override int State(int child) {
			return (int) interceptor.Invoke("state$", "state(int) const", typeof(int), typeof(int), child);
		}
		[SmokeMethod("userActionCount(int) const")]
		public override int UserActionCount(int child) {
			return (int) interceptor.Invoke("userActionCount$", "userActionCount(int) const", typeof(int), typeof(int), child);
		}
		[SmokeMethod("doAction(int, int, const QVariantList&)")]
		public override bool DoAction(int action, int child, List<QVariant> arg3) {
			return (bool) interceptor.Invoke("doAction$$?", "doAction(int, int, const QVariantList&)", typeof(bool), typeof(int), action, typeof(int), child, typeof(List<QVariant>), arg3);
		}
		[SmokeMethod("actionText(int, QAccessible::Text, int) const")]
		public override string ActionText(int action, QAccessible.Text t, int child) {
			return (string) interceptor.Invoke("actionText$$$", "actionText(int, QAccessible::Text, int) const", typeof(string), typeof(int), action, typeof(QAccessible.Text), t, typeof(int), child);
		}
	}
}
