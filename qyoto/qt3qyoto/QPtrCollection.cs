//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QPtrCollection : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPtrCollection(Type dummy) {}
		interface IQPtrCollectionProxy {
		}

		protected void CreateQPtrCollectionProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPtrCollection), this);
			_interceptor = (QPtrCollection) realProxy.GetTransparentProxy();
		}
		private QPtrCollection ProxyQPtrCollection() {
			return (QPtrCollection) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPtrCollection() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPtrCollectionProxy), null);
			_staticInterceptor = (IQPtrCollectionProxy) realProxy.GetTransparentProxy();
		}
		private static IQPtrCollectionProxy StaticQPtrCollection() {
			return (IQPtrCollectionProxy) _staticInterceptor;
		}

		[SmokeMethod("autoDelete() const")]
		public bool AutoDelete() {
			return ProxyQPtrCollection().AutoDelete();
		}
		[SmokeMethod("setAutoDelete(bool)")]
		public void SetAutoDelete(bool enable) {
			ProxyQPtrCollection().SetAutoDelete(enable);
		}
		[SmokeMethod("count() const")]
		public virtual uint Count() {
			return ProxyQPtrCollection().Count();
		}
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			ProxyQPtrCollection().Clear();
		}
	}
}