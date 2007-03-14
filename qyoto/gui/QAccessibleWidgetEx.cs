//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleWidgetEx")]
	public abstract class QAccessibleWidgetEx : QAccessibleObjectEx {
 		protected QAccessibleWidgetEx(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAccessibleWidgetEx), this);
			_interceptor = (QAccessibleWidgetEx) realProxy.GetTransparentProxy();
		}
		private QAccessibleWidgetEx ProxyQAccessibleWidgetEx() {
			return (QAccessibleWidgetEx) _interceptor;
		}
		public QAccessibleWidgetEx(QWidget o, QAccessible.Role r, string name) : this((Type) null) {
			CreateProxy();
			NewQAccessibleWidgetEx(o,r,name);
		}
		[SmokeMethod("QAccessibleWidgetEx", "(QWidget*, QAccessible::Role, const QString&)", "#$$")]
		private void NewQAccessibleWidgetEx(QWidget o, QAccessible.Role r, string name) {
			ProxyQAccessibleWidgetEx().NewQAccessibleWidgetEx(o,r,name);
		}
		public QAccessibleWidgetEx(QWidget o, QAccessible.Role r) : this((Type) null) {
			CreateProxy();
			NewQAccessibleWidgetEx(o,r);
		}
		[SmokeMethod("QAccessibleWidgetEx", "(QWidget*, QAccessible::Role)", "#$")]
		private void NewQAccessibleWidgetEx(QWidget o, QAccessible.Role r) {
			ProxyQAccessibleWidgetEx().NewQAccessibleWidgetEx(o,r);
		}
		public QAccessibleWidgetEx(QWidget o) : this((Type) null) {
			CreateProxy();
			NewQAccessibleWidgetEx(o);
		}
		[SmokeMethod("QAccessibleWidgetEx", "(QWidget*)", "#")]
		private void NewQAccessibleWidgetEx(QWidget o) {
			ProxyQAccessibleWidgetEx().NewQAccessibleWidgetEx(o);
		}
		[SmokeMethod("childCount", "() const", "")]
		public override int ChildCount() {
			return ProxyQAccessibleWidgetEx().ChildCount();
		}
		[SmokeMethod("indexOfChild", "(const QAccessibleInterface*) const", "#")]
		public override int IndexOfChild(QAccessibleInterface child) {
			return ProxyQAccessibleWidgetEx().IndexOfChild(child);
		}
		[SmokeMethod("relationTo", "(int, const QAccessibleInterface*, int) const", "$#$")]
		public override int RelationTo(int child, QAccessibleInterface other, int otherChild) {
			return ProxyQAccessibleWidgetEx().RelationTo(child,other,otherChild);
		}
		[SmokeMethod("childAt", "(int, int) const", "$$")]
		public override int ChildAt(int x, int y) {
			return ProxyQAccessibleWidgetEx().ChildAt(x,y);
		}
		[SmokeMethod("rect", "(int) const", "$")]
		public override QRect Rect(int child) {
			return ProxyQAccessibleWidgetEx().Rect(child);
		}
		[SmokeMethod("navigate", "(QAccessible::RelationFlag, int, QAccessibleInterface**) const", "$$?")]
		public override int Navigate(QAccessible.RelationFlag rel, int entry, QAccessibleInterface target) {
			return ProxyQAccessibleWidgetEx().Navigate(rel,entry,target);
		}
		[SmokeMethod("text", "(QAccessible::Text, int) const", "$$")]
		public override string Text(QAccessible.Text t, int child) {
			return ProxyQAccessibleWidgetEx().Text(t,child);
		}
		[SmokeMethod("role", "(int) const", "$")]
		public override QAccessible.Role Role(int child) {
			return ProxyQAccessibleWidgetEx().Role(child);
		}
		[SmokeMethod("state", "(int) const", "$")]
		public override int State(int child) {
			return ProxyQAccessibleWidgetEx().State(child);
		}
		[SmokeMethod("actionText", "(int, QAccessible::Text, int) const", "$$$")]
		public override string ActionText(int action, QAccessible.Text t, int child) {
			return ProxyQAccessibleWidgetEx().ActionText(action,t,child);
		}
		[SmokeMethod("doAction", "(int, int, const QVariantList&)", "$$?")]
		public override bool DoAction(int action, int child, List<QVariant> arg3) {
			return ProxyQAccessibleWidgetEx().DoAction(action,child,arg3);
		}
		[SmokeMethod("widget", "() const", "")]
		protected QWidget Widget() {
			return ProxyQAccessibleWidgetEx().Widget();
		}
		[SmokeMethod("parentObject", "() const", "")]
		protected QObject ParentObject() {
			return ProxyQAccessibleWidgetEx().ParentObject();
		}
		[SmokeMethod("addControllingSignal", "(const QString&)", "$")]
		protected void AddControllingSignal(string signal) {
			ProxyQAccessibleWidgetEx().AddControllingSignal(signal);
		}
		[SmokeMethod("setValue", "(const QString&)", "$")]
		protected void SetValue(string value) {
			ProxyQAccessibleWidgetEx().SetValue(value);
		}
		[SmokeMethod("setDescription", "(const QString&)", "$")]
		protected void SetDescription(string desc) {
			ProxyQAccessibleWidgetEx().SetDescription(desc);
		}
		[SmokeMethod("setHelp", "(const QString&)", "$")]
		protected void SetHelp(string help) {
			ProxyQAccessibleWidgetEx().SetHelp(help);
		}
		[SmokeMethod("setAccelerator", "(const QString&)", "$")]
		protected void SetAccelerator(string accel) {
			ProxyQAccessibleWidgetEx().SetAccelerator(accel);
		}
	}
}
