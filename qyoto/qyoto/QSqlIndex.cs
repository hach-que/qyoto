//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QSqlIndex")]
	public class QSqlIndex : QSqlRecord, IDisposable {
 		protected QSqlIndex(Type dummy) : base((Type) null) {}
		interface IQSqlIndexProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlIndex), this);
			_interceptor = (QSqlIndex) realProxy.GetTransparentProxy();
		}
		private QSqlIndex ProxyQSqlIndex() {
			return (QSqlIndex) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlIndex() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlIndexProxy), null);
			_staticInterceptor = (IQSqlIndexProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlIndexProxy StaticQSqlIndex() {
			return (IQSqlIndexProxy) _staticInterceptor;
		}

		public QSqlIndex(string cursorName, string name) : this((Type) null) {
			CreateProxy();
			NewQSqlIndex(cursorName,name);
		}
		[SmokeMethod("QSqlIndex(const QString&, const QString&)")]
		private void NewQSqlIndex(string cursorName, string name) {
			ProxyQSqlIndex().NewQSqlIndex(cursorName,name);
		}
		public QSqlIndex(string cursorName) : this((Type) null) {
			CreateProxy();
			NewQSqlIndex(cursorName);
		}
		[SmokeMethod("QSqlIndex(const QString&)")]
		private void NewQSqlIndex(string cursorName) {
			ProxyQSqlIndex().NewQSqlIndex(cursorName);
		}
		public QSqlIndex() : this((Type) null) {
			CreateProxy();
			NewQSqlIndex();
		}
		[SmokeMethod("QSqlIndex()")]
		private void NewQSqlIndex() {
			ProxyQSqlIndex().NewQSqlIndex();
		}
		public QSqlIndex(QSqlIndex other) : this((Type) null) {
			CreateProxy();
			NewQSqlIndex(other);
		}
		[SmokeMethod("QSqlIndex(const QSqlIndex&)")]
		private void NewQSqlIndex(QSqlIndex other) {
			ProxyQSqlIndex().NewQSqlIndex(other);
		}
		[SmokeMethod("setCursorName(const QString&)")]
		public void SetCursorName(string cursorName) {
			ProxyQSqlIndex().SetCursorName(cursorName);
		}
		[SmokeMethod("cursorName() const")]
		public string CursorName() {
			return ProxyQSqlIndex().CursorName();
		}
		[SmokeMethod("setName(const QString&)")]
		public void SetName(string name) {
			ProxyQSqlIndex().SetName(name);
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQSqlIndex().Name();
		}
		[SmokeMethod("append(const QSqlField&)")]
		public new void Append(QSqlField field) {
			ProxyQSqlIndex().Append(field);
		}
		[SmokeMethod("append(const QSqlField&, bool)")]
		public new void Append(QSqlField field, bool desc) {
			ProxyQSqlIndex().Append(field,desc);
		}
		[SmokeMethod("isDescending(int) const")]
		public bool IsDescending(int i) {
			return ProxyQSqlIndex().IsDescending(i);
		}
		[SmokeMethod("setDescending(int, bool)")]
		public void SetDescending(int i, bool desc) {
			ProxyQSqlIndex().SetDescending(i,desc);
		}
		~QSqlIndex() {
			DisposeQSqlIndex();
		}
		public void Dispose() {
			DisposeQSqlIndex();
		}
		[SmokeMethod("~QSqlIndex()")]
		private void DisposeQSqlIndex() {
			ProxyQSqlIndex().DisposeQSqlIndex();
		}
	}
}
