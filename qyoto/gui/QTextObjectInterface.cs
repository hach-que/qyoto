//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextObjectInterface")]
	public class QTextObjectInterface : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTextObjectInterface(Type dummy) {}
		[SmokeClass("QTextObjectInterface")]
		interface IQTextObjectInterfaceProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextObjectInterface), this);
			_interceptor = (QTextObjectInterface) realProxy.GetTransparentProxy();
		}
		private QTextObjectInterface ProxyQTextObjectInterface() {
			return (QTextObjectInterface) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextObjectInterface() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextObjectInterfaceProxy), null);
			_staticInterceptor = (IQTextObjectInterfaceProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextObjectInterfaceProxy StaticQTextObjectInterface() {
			return (IQTextObjectInterfaceProxy) _staticInterceptor;
		}
		[SmokeMethod("intrinsicSize", "(QTextDocument*, int, const QTextFormat&)", "#$#")]
		public virtual QSizeF IntrinsicSize(QTextDocument doc, int posInDocument, QTextFormat format) {
			return ProxyQTextObjectInterface().IntrinsicSize(doc,posInDocument,format);
		}
		[SmokeMethod("drawObject", "(QPainter*, const QRectF&, QTextDocument*, int, const QTextFormat&)", "###$#")]
		public virtual void DrawObject(QPainter painter, QRectF rect, QTextDocument doc, int posInDocument, QTextFormat format) {
			ProxyQTextObjectInterface().DrawObject(painter,rect,doc,posInDocument,format);
		}
		public QTextObjectInterface() : this((Type) null) {
			CreateProxy();
			NewQTextObjectInterface();
		}
		[SmokeMethod("QTextObjectInterface", "()", "")]
		private void NewQTextObjectInterface() {
			ProxyQTextObjectInterface().NewQTextObjectInterface();
		}
		~QTextObjectInterface() {
			DisposeQTextObjectInterface();
		}
		public void Dispose() {
			DisposeQTextObjectInterface();
		}
		[SmokeMethod("~QTextObjectInterface", "()", "")]
		private void DisposeQTextObjectInterface() {
			ProxyQTextObjectInterface().DisposeQTextObjectInterface();
		}
	}
}
