//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;


	[SmokeClass("KBookmarkGroupTraverser")]
	public class KBookmarkGroupTraverser : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KBookmarkGroupTraverser(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KBookmarkGroupTraverser), this);
		}
		public KBookmarkGroupTraverser() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KBookmarkGroupTraverser", "KBookmarkGroupTraverser()", typeof(void));
		}
		protected void Traverse(KBookmarkGroup arg1) {
			interceptor.Invoke("traverse#", "traverse(const KBookmarkGroup&)", typeof(void), typeof(KBookmarkGroup), arg1);
		}
		[SmokeMethod("visit(const KBookmark&)")]
		protected virtual void Visit(KBookmark arg1) {
			interceptor.Invoke("visit#", "visit(const KBookmark&)", typeof(void), typeof(KBookmark), arg1);
		}
		[SmokeMethod("visitEnter(const KBookmarkGroup&)")]
		protected virtual void VisitEnter(KBookmarkGroup arg1) {
			interceptor.Invoke("visitEnter#", "visitEnter(const KBookmarkGroup&)", typeof(void), typeof(KBookmarkGroup), arg1);
		}
		[SmokeMethod("visitLeave(const KBookmarkGroup&)")]
		protected virtual void VisitLeave(KBookmarkGroup arg1) {
			interceptor.Invoke("visitLeave#", "visitLeave(const KBookmarkGroup&)", typeof(void), typeof(KBookmarkGroup), arg1);
		}
	}
}
