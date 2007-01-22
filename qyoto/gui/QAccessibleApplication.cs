//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleApplication")]
	public class QAccessibleApplication : QAccessibleObject, IDisposable {
 		protected QAccessibleApplication(Type dummy) : base((Type) null) {}
		interface IQAccessibleApplicationProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAccessibleApplication), this);
			_interceptor = (QAccessibleApplication) realProxy.GetTransparentProxy();
		}
		private QAccessibleApplication ProxyQAccessibleApplication() {
			return (QAccessibleApplication) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAccessibleApplication() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAccessibleApplicationProxy), null);
			_staticInterceptor = (IQAccessibleApplicationProxy) realProxy.GetTransparentProxy();
		}
		private static IQAccessibleApplicationProxy StaticQAccessibleApplication() {
			return (IQAccessibleApplicationProxy) _staticInterceptor;
		}

		public QAccessibleApplication() : this((Type) null) {
			CreateProxy();
			NewQAccessibleApplication();
		}
		[SmokeMethod("QAccessibleApplication()")]
		private void NewQAccessibleApplication() {
			ProxyQAccessibleApplication().NewQAccessibleApplication();
		}
		[SmokeMethod("childCount() const")]
		public new int ChildCount() {
			return ProxyQAccessibleApplication().ChildCount();
		}
		[SmokeMethod("indexOfChild(const QAccessibleInterface*) const")]
		public new int IndexOfChild(QAccessibleInterface arg1) {
			return ProxyQAccessibleApplication().IndexOfChild(arg1);
		}
		[SmokeMethod("relationTo(int, const QAccessibleInterface*, int) const")]
		public new int RelationTo(int arg1, QAccessibleInterface arg2, int arg3) {
			return ProxyQAccessibleApplication().RelationTo(arg1,arg2,arg3);
		}
		[SmokeMethod("childAt(int, int) const")]
		public new int ChildAt(int x, int y) {
			return ProxyQAccessibleApplication().ChildAt(x,y);
		}
		[SmokeMethod("navigate(QAccessible::RelationFlag, int, QAccessibleInterface**) const")]
		public new int Navigate(QAccessible.RelationFlag arg1, int arg2, QAccessibleInterface arg3) {
			return ProxyQAccessibleApplication().Navigate(arg1,arg2,arg3);
		}
		[SmokeMethod("text(QAccessible::Text, int) const")]
		public new string Text(QAccessible.Text t, int child) {
			return ProxyQAccessibleApplication().Text(t,child);
		}
		[SmokeMethod("role(int) const")]
		public new QAccessible.Role Role(int child) {
			return ProxyQAccessibleApplication().Role(child);
		}
		[SmokeMethod("state(int) const")]
		public new int State(int child) {
			return ProxyQAccessibleApplication().State(child);
		}
		[SmokeMethod("userActionCount(int) const")]
		public new int UserActionCount(int child) {
			return ProxyQAccessibleApplication().UserActionCount(child);
		}
		[SmokeMethod("doAction(int, int, const QVariantList&)")]
		public new bool DoAction(int action, int child, List<QVariant> arg3) {
			return ProxyQAccessibleApplication().DoAction(action,child,arg3);
		}
		[SmokeMethod("actionText(int, QAccessible::Text, int) const")]
		public new string ActionText(int action, QAccessible.Text t, int child) {
			return ProxyQAccessibleApplication().ActionText(action,t,child);
		}
		~QAccessibleApplication() {
			DisposeQAccessibleApplication();
		}
		public new void Dispose() {
			DisposeQAccessibleApplication();
		}
		[SmokeMethod("~QAccessibleApplication()")]
		private void DisposeQAccessibleApplication() {
			ProxyQAccessibleApplication().DisposeQAccessibleApplication();
		}
	}
}