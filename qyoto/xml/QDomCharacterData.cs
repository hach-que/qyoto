//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomCharacterData")]
	public class QDomCharacterData : QDomNode, IDisposable {
 		protected QDomCharacterData(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDomCharacterData), this);
		}
		public QDomCharacterData() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomCharacterData", "QDomCharacterData()", typeof(void));
		}
		public QDomCharacterData(QDomCharacterData x) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomCharacterData#", "QDomCharacterData(const QDomCharacterData&)", typeof(void), typeof(QDomCharacterData), x);
		}
		public string SubstringData(ulong offset, ulong count) {
			return (string) interceptor.Invoke("substringData$$", "substringData(unsigned long, unsigned long)", typeof(string), typeof(ulong), offset, typeof(ulong), count);
		}
		public void AppendData(string arg) {
			interceptor.Invoke("appendData$", "appendData(const QString&)", typeof(void), typeof(string), arg);
		}
		public void InsertData(ulong offset, string arg) {
			interceptor.Invoke("insertData$$", "insertData(unsigned long, const QString&)", typeof(void), typeof(ulong), offset, typeof(string), arg);
		}
		public void DeleteData(ulong offset, ulong count) {
			interceptor.Invoke("deleteData$$", "deleteData(unsigned long, unsigned long)", typeof(void), typeof(ulong), offset, typeof(ulong), count);
		}
		public void ReplaceData(ulong offset, ulong count, string arg) {
			interceptor.Invoke("replaceData$$$", "replaceData(unsigned long, unsigned long, const QString&)", typeof(void), typeof(ulong), offset, typeof(ulong), count, typeof(string), arg);
		}
		public uint Length() {
			return (uint) interceptor.Invoke("length", "length() const", typeof(uint));
		}
		public string Data() {
			return (string) interceptor.Invoke("data", "data() const", typeof(string));
		}
		public void SetData(string arg1) {
			interceptor.Invoke("setData$", "setData(const QString&)", typeof(void), typeof(string), arg1);
		}
		public new QDomNode.NodeType NodeType() {
			return (QDomNode.NodeType) interceptor.Invoke("nodeType", "nodeType() const", typeof(QDomNode.NodeType));
		}
		~QDomCharacterData() {
			interceptor.Invoke("~QDomCharacterData", "~QDomCharacterData()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDomCharacterData", "~QDomCharacterData()", typeof(void));
		}
	}
}
