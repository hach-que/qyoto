//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QImageFormat : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QImageFormat(Type dummy) {}
		interface IQImageFormatProxy {
		}

		protected void CreateQImageFormatProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageFormat), this);
			_interceptor = (QImageFormat) realProxy.GetTransparentProxy();
		}
		private QImageFormat ProxyQImageFormat() {
			return (QImageFormat) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QImageFormat() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageFormatProxy), null);
			_staticInterceptor = (IQImageFormatProxy) realProxy.GetTransparentProxy();
		}
		private static IQImageFormatProxy StaticQImageFormat() {
			return (IQImageFormatProxy) _staticInterceptor;
		}

		[SmokeMethod("decode(QImage&, QImageConsumer*, const uchar*, int)")]
		public virtual int Decode(QImage img, QImageConsumer consumer, char[] buffer, int length) {
			return ProxyQImageFormat().Decode(img,consumer,buffer,length);
		}
	}
}