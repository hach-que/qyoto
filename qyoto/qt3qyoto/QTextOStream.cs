//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QTextOStream : QTextStream, IDisposable {
 		protected QTextOStream(Type dummy) : base((Type) null) {}
		interface IQTextOStreamProxy {
		}

		protected void CreateQTextOStreamProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextOStream), this);
			_interceptor = (QTextOStream) realProxy.GetTransparentProxy();
		}
		private QTextOStream ProxyQTextOStream() {
			return (QTextOStream) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextOStream() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextOStreamProxy), null);
			_staticInterceptor = (IQTextOStreamProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextOStreamProxy StaticQTextOStream() {
			return (IQTextOStreamProxy) _staticInterceptor;
		}

		public QTextOStream(StringBuilder s) : this((Type) null) {
			CreateQTextOStreamProxy();
			NewQTextOStream(s);
		}
		[SmokeMethod("QTextOStream(QString*)")]
		private void NewQTextOStream(StringBuilder s) {
			ProxyQTextOStream().NewQTextOStream(s);
		}
		public QTextOStream(QByteArray ba) : this((Type) null) {
			CreateQTextOStreamProxy();
			NewQTextOStream(ba);
		}
		[SmokeMethod("QTextOStream(QByteArray)")]
		private void NewQTextOStream(QByteArray ba) {
			ProxyQTextOStream().NewQTextOStream(ba);
		}
		~QTextOStream() {
			DisposeQTextOStream();
		}
		public new void Dispose() {
			DisposeQTextOStream();
		}
		private void DisposeQTextOStream() {
			ProxyQTextOStream().DisposeQTextOStream();
		}
	}
}