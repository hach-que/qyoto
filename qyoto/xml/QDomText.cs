//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomText")]
	public class QDomText : QDomCharacterData, IDisposable {
 		protected QDomText(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDomText), this);
		}
		public QDomText() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomText", "QDomText()", typeof(void));
		}
		public QDomText(QDomText x) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomText#", "QDomText(const QDomText&)", typeof(void), typeof(QDomText), x);
		}
		public QDomText SplitText(int offset) {
			return (QDomText) interceptor.Invoke("splitText$", "splitText(int)", typeof(QDomText), typeof(int), offset);
		}
		public new QDomNode.NodeType NodeType() {
			return (QDomNode.NodeType) interceptor.Invoke("nodeType", "nodeType() const", typeof(QDomNode.NodeType));
		}
		~QDomText() {
			interceptor.Invoke("~QDomText", "~QDomText()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDomText", "~QDomText()", typeof(void));
		}
	}
}
