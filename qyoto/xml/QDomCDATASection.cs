//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomCDATASection")]
	public class QDomCDATASection : QDomText, IDisposable {
 		protected QDomCDATASection(Type dummy) : base((Type) null) {}
		interface IQDomCDATASectionProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomCDATASection), this);
			_interceptor = (QDomCDATASection) realProxy.GetTransparentProxy();
		}
		private QDomCDATASection ProxyQDomCDATASection() {
			return (QDomCDATASection) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomCDATASection() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomCDATASectionProxy), null);
			_staticInterceptor = (IQDomCDATASectionProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomCDATASectionProxy StaticQDomCDATASection() {
			return (IQDomCDATASectionProxy) _staticInterceptor;
		}

		public QDomCDATASection() : this((Type) null) {
			CreateProxy();
			NewQDomCDATASection();
		}
		[SmokeMethod("QDomCDATASection", "()")]
		private void NewQDomCDATASection() {
			ProxyQDomCDATASection().NewQDomCDATASection();
		}
		public QDomCDATASection(QDomCDATASection x) : this((Type) null) {
			CreateProxy();
			NewQDomCDATASection(x);
		}
		[SmokeMethod("QDomCDATASection#", "(const QDomCDATASection&)")]
		private void NewQDomCDATASection(QDomCDATASection x) {
			ProxyQDomCDATASection().NewQDomCDATASection(x);
		}
		[SmokeMethod("nodeType", "() const")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomCDATASection().NodeType();
		}
		~QDomCDATASection() {
			DisposeQDomCDATASection();
		}
		public void Dispose() {
			DisposeQDomCDATASection();
		}
		[SmokeMethod("~QDomCDATASection", "()")]
		private void DisposeQDomCDATASection() {
			ProxyQDomCDATASection().DisposeQDomCDATASection();
		}
	}
}
