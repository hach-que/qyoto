//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomDocumentFragment")]
	public class QDomDocumentFragment : QDomNode, IDisposable {
 		protected QDomDocumentFragment(Type dummy) : base((Type) null) {}
		interface IQDomDocumentFragmentProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomDocumentFragment), this);
			_interceptor = (QDomDocumentFragment) realProxy.GetTransparentProxy();
		}
		private QDomDocumentFragment ProxyQDomDocumentFragment() {
			return (QDomDocumentFragment) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomDocumentFragment() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomDocumentFragmentProxy), null);
			_staticInterceptor = (IQDomDocumentFragmentProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomDocumentFragmentProxy StaticQDomDocumentFragment() {
			return (IQDomDocumentFragmentProxy) _staticInterceptor;
		}

		public QDomDocumentFragment() : this((Type) null) {
			CreateProxy();
			NewQDomDocumentFragment();
		}
		[SmokeMethod("QDomDocumentFragment()")]
		private void NewQDomDocumentFragment() {
			ProxyQDomDocumentFragment().NewQDomDocumentFragment();
		}
		public QDomDocumentFragment(QDomDocumentFragment x) : this((Type) null) {
			CreateProxy();
			NewQDomDocumentFragment(x);
		}
		[SmokeMethod("QDomDocumentFragment(const QDomDocumentFragment&)")]
		private void NewQDomDocumentFragment(QDomDocumentFragment x) {
			ProxyQDomDocumentFragment().NewQDomDocumentFragment(x);
		}
		[SmokeMethod("nodeType() const")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomDocumentFragment().NodeType();
		}
		~QDomDocumentFragment() {
			DisposeQDomDocumentFragment();
		}
		public void Dispose() {
			DisposeQDomDocumentFragment();
		}
		[SmokeMethod("~QDomDocumentFragment()")]
		private void DisposeQDomDocumentFragment() {
			ProxyQDomDocumentFragment().DisposeQDomDocumentFragment();
		}
	}
}
