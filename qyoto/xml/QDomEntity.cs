//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomEntity")]
	public class QDomEntity : QDomNode, IDisposable {
 		protected QDomEntity(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomEntity), this);
			_interceptor = (QDomEntity) realProxy.GetTransparentProxy();
		}
		private QDomEntity ProxyQDomEntity() {
			return (QDomEntity) _interceptor;
		}
		public QDomEntity() : this((Type) null) {
			CreateProxy();
			NewQDomEntity();
		}
		[SmokeMethod("QDomEntity", "()", "")]
		private void NewQDomEntity() {
			ProxyQDomEntity().NewQDomEntity();
		}
		public QDomEntity(QDomEntity x) : this((Type) null) {
			CreateProxy();
			NewQDomEntity(x);
		}
		[SmokeMethod("QDomEntity", "(const QDomEntity&)", "#")]
		private void NewQDomEntity(QDomEntity x) {
			ProxyQDomEntity().NewQDomEntity(x);
		}
		[SmokeMethod("publicId", "() const", "")]
		public string PublicId() {
			return ProxyQDomEntity().PublicId();
		}
		[SmokeMethod("systemId", "() const", "")]
		public string SystemId() {
			return ProxyQDomEntity().SystemId();
		}
		[SmokeMethod("notationName", "() const", "")]
		public string NotationName() {
			return ProxyQDomEntity().NotationName();
		}
		[SmokeMethod("nodeType", "() const", "")]
		public QDomNode.NodeType NodeType() {
			return ProxyQDomEntity().NodeType();
		}
		~QDomEntity() {
			DisposeQDomEntity();
		}
		public void Dispose() {
			DisposeQDomEntity();
		}
		[SmokeMethod("~QDomEntity", "()", "")]
		private void DisposeQDomEntity() {
			ProxyQDomEntity().DisposeQDomEntity();
		}
	}
}
