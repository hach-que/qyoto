//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QBool")]
	public class QBool : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QBool(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QBool), "QBool", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QBool() {
			staticInterceptor = new SmokeInvocation(typeof(QBool), "QBool", null);
		}
		//  operator const void *(); >>>> NOT CONVERTED
		public QBool(bool B) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBool$", "QBool(bool)", typeof(void), typeof(bool), B);
		}
		~QBool() {
			interceptor.Invoke("~QBool", "~QBool()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QBool", "~QBool()", typeof(void));
		}
		public static bool operator==(QBool b1, bool b2) {
			return (bool) staticInterceptor.Invoke("operator==#$", "operator==(QBool, bool)", typeof(bool), typeof(QBool), b1, typeof(bool), b2);
		}
		public static bool operator!=(QBool b1, bool b2) {
			return !(bool) staticInterceptor.Invoke("operator==#$", "operator==(QBool, bool)", typeof(bool), typeof(QBool), b1, typeof(bool), b2);
		}
		public static bool operator==(bool b1, QBool b2) {
			return (bool) staticInterceptor.Invoke("operator==$#", "operator==(bool, QBool)", typeof(bool), typeof(bool), b1, typeof(QBool), b2);
		}
		public static bool operator!=(bool b1, QBool b2) {
			return !(bool) staticInterceptor.Invoke("operator==$#", "operator==(bool, QBool)", typeof(bool), typeof(bool), b1, typeof(QBool), b2);
		}
		public static bool operator==(QBool b1, QBool b2) {
			return (bool) staticInterceptor.Invoke("operator==##", "operator==(QBool, QBool)", typeof(bool), typeof(QBool), b1, typeof(QBool), b2);
		}
		public static bool operator!=(QBool b1, QBool b2) {
			return !(bool) staticInterceptor.Invoke("operator==##", "operator==(QBool, QBool)", typeof(bool), typeof(QBool), b1, typeof(QBool), b2);
		}
	}
}
