//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QFontInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFontInfo(Type dummy) {}
		interface IQFontInfoProxy {
		}

		protected void CreateQFontInfoProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontInfo), this);
			_interceptor = (QFontInfo) realProxy.GetTransparentProxy();
		}
		private QFontInfo ProxyQFontInfo() {
			return (QFontInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontInfoProxy), null);
			_staticInterceptor = (IQFontInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontInfoProxy StaticQFontInfo() {
			return (IQFontInfoProxy) _staticInterceptor;
		}

		public QFontInfo(QFont arg1) : this((Type) null) {
			CreateQFontInfoProxy();
			NewQFontInfo(arg1);
		}
		private void NewQFontInfo(QFont arg1) {
			ProxyQFontInfo().NewQFontInfo(arg1);
		}
		public QFontInfo(QFontInfo arg1) : this((Type) null) {
			CreateQFontInfoProxy();
			NewQFontInfo(arg1);
		}
		private void NewQFontInfo(QFontInfo arg1) {
			ProxyQFontInfo().NewQFontInfo(arg1);
		}
		public string Family() {
			return ProxyQFontInfo().Family();
		}
		public int PixelSize() {
			return ProxyQFontInfo().PixelSize();
		}
		public int PointSize() {
			return ProxyQFontInfo().PointSize();
		}
		public double PointSizeF() {
			return ProxyQFontInfo().PointSizeF();
		}
		public bool Italic() {
			return ProxyQFontInfo().Italic();
		}
		public int Style() {
			return ProxyQFontInfo().Style();
		}
		public int Weight() {
			return ProxyQFontInfo().Weight();
		}
		public bool Bold() {
			return ProxyQFontInfo().Bold();
		}
		public bool Underline() {
			return ProxyQFontInfo().Underline();
		}
		public bool Overline() {
			return ProxyQFontInfo().Overline();
		}
		public bool StrikeOut() {
			return ProxyQFontInfo().StrikeOut();
		}
		public bool FixedPitch() {
			return ProxyQFontInfo().FixedPitch();
		}
		public int StyleHint() {
			return ProxyQFontInfo().StyleHint();
		}
		public bool RawMode() {
			return ProxyQFontInfo().RawMode();
		}
		public bool ExactMatch() {
			return ProxyQFontInfo().ExactMatch();
		}
		~QFontInfo() {
			ProxyQFontInfo().Dispose();
		}
		public void Dispose() {
			ProxyQFontInfo().Dispose();
		}
	}
}
