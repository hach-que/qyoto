//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QItemSelection")]
	public class QItemSelection : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QItemSelection(Type dummy) {}
		[SmokeClass("QItemSelection")]
		interface IQItemSelectionProxy {
			[SmokeMethod("split", "(const QItemSelectionRange&, const QItemSelectionRange&, QItemSelection*)", "###")]
			void Split(QItemSelectionRange range, QItemSelectionRange other, QItemSelection result);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QItemSelection), this);
			_interceptor = (QItemSelection) realProxy.GetTransparentProxy();
		}
		private QItemSelection ProxyQItemSelection() {
			return (QItemSelection) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QItemSelection() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQItemSelectionProxy), null);
			_staticInterceptor = (IQItemSelectionProxy) realProxy.GetTransparentProxy();
		}
		private static IQItemSelectionProxy StaticQItemSelection() {
			return (IQItemSelectionProxy) _staticInterceptor;
		}
		public QItemSelection() : this((Type) null) {
			CreateProxy();
			NewQItemSelection();
		}
		[SmokeMethod("QItemSelection", "()", "")]
		private void NewQItemSelection() {
			ProxyQItemSelection().NewQItemSelection();
		}
		public QItemSelection(QModelIndex topLeft, QModelIndex bottomRight) : this((Type) null) {
			CreateProxy();
			NewQItemSelection(topLeft,bottomRight);
		}
		[SmokeMethod("QItemSelection", "(const QModelIndex&, const QModelIndex&)", "##")]
		private void NewQItemSelection(QModelIndex topLeft, QModelIndex bottomRight) {
			ProxyQItemSelection().NewQItemSelection(topLeft,bottomRight);
		}
		[SmokeMethod("select", "(const QModelIndex&, const QModelIndex&)", "##")]
		public void Select(QModelIndex topLeft, QModelIndex bottomRight) {
			ProxyQItemSelection().Select(topLeft,bottomRight);
		}
		[SmokeMethod("contains", "(const QModelIndex&) const", "#")]
		public bool Contains(QModelIndex index) {
			return ProxyQItemSelection().Contains(index);
		}
		[SmokeMethod("indexes", "() const", "")]
		public List<QModelIndex> Indexes() {
			return ProxyQItemSelection().Indexes();
		}
		[SmokeMethod("merge", "(const QItemSelection&, QItemSelectionModel::SelectionFlags)", "#$")]
		public void Merge(QItemSelection other, int command) {
			ProxyQItemSelection().Merge(other,command);
		}
		~QItemSelection() {
			DisposeQItemSelection();
		}
		public void Dispose() {
			DisposeQItemSelection();
		}
		[SmokeMethod("~QItemSelection", "()", "")]
		private void DisposeQItemSelection() {
			ProxyQItemSelection().DisposeQItemSelection();
		}
		public static void Split(QItemSelectionRange range, QItemSelectionRange other, QItemSelection result) {
			StaticQItemSelection().Split(range,other,result);
		}
	}
}
