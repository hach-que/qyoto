//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomAttr")]
	public class QDomAttr : QDomNode, IDisposable {
 		protected QDomAttr(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomAttr), this);
			_interceptor = (QDomAttr) realProxy.GetTransparentProxy();
		}
		private QDomAttr ProxyQDomAttr() {
			return (QDomAttr) _interceptor;
		}
		public QDomAttr() : this((Type) null) {
			CreateProxy();
			NewQDomAttr();
		}
		[SmokeMethod("QDomAttr", "()", "")]
		private void NewQDomAttr() {
			ProxyQDomAttr().NewQDomAttr();
		}
		public QDomAttr(QDomAttr x) : this((Type) null) {
			CreateProxy();
			NewQDomAttr(x);
		}
		[SmokeMethod("QDomAttr", "(const QDomAttr&)", "#")]
		private void NewQDomAttr(QDomAttr x) {
			ProxyQDomAttr().NewQDomAttr(x);
		}
		[SmokeMethod("name", "() const", "")]
		public string Name() {
			return ProxyQDomAttr().Name();
		}
		[SmokeMethod("specified", "() const", "")]
		public bool Specified() {
			return ProxyQDomAttr().Specified();
		}
		[SmokeMethod("ownerElement", "() const", "")]
		public QDomElement OwnerElement() {
			return ProxyQDomAttr().OwnerElement();
		}
		[SmokeMethod("value", "() const", "")]
		public string Value() {
			return ProxyQDomAttr().Value();
		}
		[SmokeMethod("setValue", "(const QString&)", "$")]
		public void SetValue(string arg1) {
			ProxyQDomAttr().SetValue(arg1);
		}
		[SmokeMethod("nodeType", "() const", "")]
		public QDomNode.NodeType NodeType() {
			return ProxyQDomAttr().NodeType();
		}
		~QDomAttr() {
			DisposeQDomAttr();
		}
		public void Dispose() {
			DisposeQDomAttr();
		}
		[SmokeMethod("~QDomAttr", "()", "")]
		private void DisposeQDomAttr() {
			ProxyQDomAttr().DisposeQDomAttr();
		}
	}
}
