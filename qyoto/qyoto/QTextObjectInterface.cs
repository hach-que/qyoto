//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextObjectInterface")]
	public class QTextObjectInterface : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QTextObjectInterface(Type dummy) {}
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

		// QSizeF intrinsicSize(QTextDocument* arg1,int arg2,const QTextFormat& arg3); >>>> NOT CONVERTED
		// void drawObject(QPainter* arg1,const QRectF& arg2,QTextDocument* arg3,int arg4,const QTextFormat& arg5); >>>> NOT CONVERTED
		public QTextObjectInterface() : this((Type) null) {
			CreateProxy();
			NewQTextObjectInterface();
		}
		[SmokeMethod("QTextObjectInterface()")]
		private void NewQTextObjectInterface() {
			ProxyQTextObjectInterface().NewQTextObjectInterface();
		}
		~QTextObjectInterface() {
			DisposeQTextObjectInterface();
		}
		public void Dispose() {
			DisposeQTextObjectInterface();
		}
		[SmokeMethod("~QTextObjectInterface()")]
		private void DisposeQTextObjectInterface() {
			ProxyQTextObjectInterface().DisposeQTextObjectInterface();
		}
	}
}
