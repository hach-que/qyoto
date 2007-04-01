//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleWidgetEx")]
	public abstract class QAccessibleWidgetEx : QAccessibleObjectEx {
 		protected QAccessibleWidgetEx(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAccessibleWidgetEx), "QAccessibleWidgetEx", this);
		}
		public QAccessibleWidgetEx(QWidget o, QAccessible.Role r, string name) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleWidgetEx#$$", "QAccessibleWidgetEx(QWidget*, QAccessible::Role, const QString&)", typeof(void), typeof(QWidget), o, typeof(QAccessible.Role), r, typeof(string), name);
		}
		public QAccessibleWidgetEx(QWidget o, QAccessible.Role r) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleWidgetEx#$", "QAccessibleWidgetEx(QWidget*, QAccessible::Role)", typeof(void), typeof(QWidget), o, typeof(QAccessible.Role), r);
		}
		public QAccessibleWidgetEx(QWidget o) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleWidgetEx#", "QAccessibleWidgetEx(QWidget*)", typeof(void), typeof(QWidget), o);
		}
		[SmokeMethod("childCount() const")]
		public override int ChildCount() {
			return (int) interceptor.Invoke("childCount", "childCount() const", typeof(int));
		}
		[SmokeMethod("indexOfChild(const QAccessibleInterface*) const")]
		public override int IndexOfChild(QAccessibleInterface child) {
			return (int) interceptor.Invoke("indexOfChild#", "indexOfChild(const QAccessibleInterface*) const", typeof(int), typeof(QAccessibleInterface), child);
		}
		[SmokeMethod("relationTo(int, const QAccessibleInterface*, int) const")]
		public override int RelationTo(int child, QAccessibleInterface other, int otherChild) {
			return (int) interceptor.Invoke("relationTo$#$", "relationTo(int, const QAccessibleInterface*, int) const", typeof(int), typeof(int), child, typeof(QAccessibleInterface), other, typeof(int), otherChild);
		}
		[SmokeMethod("childAt(int, int) const")]
		public override int ChildAt(int x, int y) {
			return (int) interceptor.Invoke("childAt$$", "childAt(int, int) const", typeof(int), typeof(int), x, typeof(int), y);
		}
		[SmokeMethod("rect(int) const")]
		public override QRect Rect(int child) {
			return (QRect) interceptor.Invoke("rect$", "rect(int) const", typeof(QRect), typeof(int), child);
		}
		[SmokeMethod("navigate(QAccessible::RelationFlag, int, QAccessibleInterface**) const")]
		public override int Navigate(QAccessible.RelationFlag rel, int entry, QAccessibleInterface target) {
			return (int) interceptor.Invoke("navigate$$?", "navigate(QAccessible::RelationFlag, int, QAccessibleInterface**) const", typeof(int), typeof(QAccessible.RelationFlag), rel, typeof(int), entry, typeof(QAccessibleInterface), target);
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
		[SmokeMethod("actionText(int, QAccessible::Text, int) const")]
		public override string ActionText(int action, QAccessible.Text t, int child) {
			return (string) interceptor.Invoke("actionText$$$", "actionText(int, QAccessible::Text, int) const", typeof(string), typeof(int), action, typeof(QAccessible.Text), t, typeof(int), child);
		}
		[SmokeMethod("doAction(int, int, const QVariantList&)")]
		public override bool DoAction(int action, int child, List<QVariant> arg3) {
			return (bool) interceptor.Invoke("doAction$$?", "doAction(int, int, const QVariantList&)", typeof(bool), typeof(int), action, typeof(int), child, typeof(List<QVariant>), arg3);
		}
		protected QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
		}
		protected QObject ParentObject() {
			return (QObject) interceptor.Invoke("parentObject", "parentObject() const", typeof(QObject));
		}
		protected void AddControllingSignal(string signal) {
			interceptor.Invoke("addControllingSignal$", "addControllingSignal(const QString&)", typeof(void), typeof(string), signal);
		}
		protected void SetValue(string value) {
			interceptor.Invoke("setValue$", "setValue(const QString&)", typeof(void), typeof(string), value);
		}
		protected void SetDescription(string desc) {
			interceptor.Invoke("setDescription$", "setDescription(const QString&)", typeof(void), typeof(string), desc);
		}
		protected void SetHelp(string help) {
			interceptor.Invoke("setHelp$", "setHelp(const QString&)", typeof(void), typeof(string), help);
		}
		protected void SetAccelerator(string accel) {
			interceptor.Invoke("setAccelerator$", "setAccelerator(const QString&)", typeof(void), typeof(string), accel);
		}
	}
}
