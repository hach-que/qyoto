//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QBitRef")]
	public class QBitRef : MarshalByRefObject {
		protected QBitRef interceptor = null;
		private IntPtr smokeObject;
		protected QBitRef(Type dummy) {}
		[SmokeClass("QBitRef")]
		interface IQBitRefProxy {
			[SmokeMethod("operator!", "() const", "")]
			bool op_not(QBitRef lhs);
		}
		private static IQBitRefProxy staticInterceptor = null;
		static QBitRef() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBitRefProxy), null);
			staticInterceptor = (IQBitRefProxy) realProxy.GetTransparentProxy();
		}
		//  operator bool(); >>>> NOT CONVERTED
		public static bool operator!(QBitRef lhs) {
			return staticInterceptor.op_not(lhs);
		}
	}
}
