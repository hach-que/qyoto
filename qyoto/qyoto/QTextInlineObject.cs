//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QTextInlineObject : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextInlineObject(Type dummy) {}
		interface IQTextInlineObjectProxy {
		}

		protected void CreateQTextInlineObjectProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextInlineObject), this);
			_interceptor = (QTextInlineObject) realProxy.GetTransparentProxy();
		}
		private QTextInlineObject ProxyQTextInlineObject() {
			return (QTextInlineObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextInlineObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextInlineObjectProxy), null);
			_staticInterceptor = (IQTextInlineObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextInlineObjectProxy StaticQTextInlineObject() {
			return (IQTextInlineObjectProxy) _staticInterceptor;
		}

		// QTextInlineObject* QTextInlineObject(int arg1,QTextEngine* arg2); >>>> NOT CONVERTED
		public QTextInlineObject() : this((Type) null) {
			CreateQTextInlineObjectProxy();
			NewQTextInlineObject();
		}
		private void NewQTextInlineObject() {
			ProxyQTextInlineObject().NewQTextInlineObject();
		}
		public bool IsValid() {
			return ProxyQTextInlineObject().IsValid();
		}
		public QRectF Rect() {
			return ProxyQTextInlineObject().Rect();
		}
		public double Width() {
			return ProxyQTextInlineObject().Width();
		}
		public double Ascent() {
			return ProxyQTextInlineObject().Ascent();
		}
		public double Descent() {
			return ProxyQTextInlineObject().Descent();
		}
		public double Height() {
			return ProxyQTextInlineObject().Height();
		}
		public int TextDirection() {
			return ProxyQTextInlineObject().TextDirection();
		}
		public void SetWidth(double w) {
			ProxyQTextInlineObject().SetWidth(w);
		}
		public void SetAscent(double a) {
			ProxyQTextInlineObject().SetAscent(a);
		}
		public void SetDescent(double d) {
			ProxyQTextInlineObject().SetDescent(d);
		}
		public int TextPosition() {
			return ProxyQTextInlineObject().TextPosition();
		}
		public int FormatIndex() {
			return ProxyQTextInlineObject().FormatIndex();
		}
		// QTextFormat format(); >>>> NOT CONVERTED
		~QTextInlineObject() {
			ProxyQTextInlineObject().Dispose();
		}
		public void Dispose() {
			ProxyQTextInlineObject().Dispose();
		}
	}
}
