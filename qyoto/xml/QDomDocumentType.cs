//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDomDocumentType")]
	public class QDomDocumentType : QDomNode, IDisposable {
 		protected QDomDocumentType(Type dummy) : base((Type) null) {}
		interface IQDomDocumentTypeProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomDocumentType), this);
			_interceptor = (QDomDocumentType) realProxy.GetTransparentProxy();
		}
		private QDomDocumentType ProxyQDomDocumentType() {
			return (QDomDocumentType) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomDocumentType() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomDocumentTypeProxy), null);
			_staticInterceptor = (IQDomDocumentTypeProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomDocumentTypeProxy StaticQDomDocumentType() {
			return (IQDomDocumentTypeProxy) _staticInterceptor;
		}

		public QDomDocumentType() : this((Type) null) {
			CreateProxy();
			NewQDomDocumentType();
		}
		[SmokeMethod("QDomDocumentType", "()")]
		private void NewQDomDocumentType() {
			ProxyQDomDocumentType().NewQDomDocumentType();
		}
		public QDomDocumentType(QDomDocumentType x) : this((Type) null) {
			CreateProxy();
			NewQDomDocumentType(x);
		}
		[SmokeMethod("QDomDocumentType#", "(const QDomDocumentType&)")]
		private void NewQDomDocumentType(QDomDocumentType x) {
			ProxyQDomDocumentType().NewQDomDocumentType(x);
		}
		[SmokeMethod("name", "() const")]
		public string Name() {
			return ProxyQDomDocumentType().Name();
		}
		[SmokeMethod("entities", "() const")]
		public QDomNamedNodeMap Entities() {
			return ProxyQDomDocumentType().Entities();
		}
		[SmokeMethod("notations", "() const")]
		public QDomNamedNodeMap Notations() {
			return ProxyQDomDocumentType().Notations();
		}
		[SmokeMethod("publicId", "() const")]
		public string PublicId() {
			return ProxyQDomDocumentType().PublicId();
		}
		[SmokeMethod("systemId", "() const")]
		public string SystemId() {
			return ProxyQDomDocumentType().SystemId();
		}
		[SmokeMethod("internalSubset", "() const")]
		public string InternalSubset() {
			return ProxyQDomDocumentType().InternalSubset();
		}
		[SmokeMethod("nodeType", "() const")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomDocumentType().NodeType();
		}
		~QDomDocumentType() {
			DisposeQDomDocumentType();
		}
		public void Dispose() {
			DisposeQDomDocumentType();
		}
		[SmokeMethod("~QDomDocumentType", "()")]
		private void DisposeQDomDocumentType() {
			ProxyQDomDocumentType().DisposeQDomDocumentType();
		}
	}
}
