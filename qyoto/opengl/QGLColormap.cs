//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGLColormap")]
	public class QGLColormap : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QGLColormap(Type dummy) {}
		interface IQGLColormapProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGLColormap), this);
			_interceptor = (QGLColormap) realProxy.GetTransparentProxy();
		}
		private QGLColormap ProxyQGLColormap() {
			return (QGLColormap) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGLColormap() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGLColormapProxy), null);
			_staticInterceptor = (IQGLColormapProxy) realProxy.GetTransparentProxy();
		}
		private static IQGLColormapProxy StaticQGLColormap() {
			return (IQGLColormapProxy) _staticInterceptor;
		}

		public QGLColormap() : this((Type) null) {
			CreateProxy();
			NewQGLColormap();
		}
		[SmokeMethod("QGLColormap()")]
		private void NewQGLColormap() {
			ProxyQGLColormap().NewQGLColormap();
		}
		public QGLColormap(QGLColormap arg1) : this((Type) null) {
			CreateProxy();
			NewQGLColormap(arg1);
		}
		[SmokeMethod("QGLColormap(const QGLColormap&)")]
		private void NewQGLColormap(QGLColormap arg1) {
			ProxyQGLColormap().NewQGLColormap(arg1);
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQGLColormap().IsEmpty();
		}
		[SmokeMethod("size() const")]
		public int Size() {
			return ProxyQGLColormap().Size();
		}
		[SmokeMethod("detach()")]
		public void Detach() {
			ProxyQGLColormap().Detach();
		}
		[SmokeMethod("setEntries(int, const QRgb*, int)")]
		public void SetEntries(int count, out int colors, int arg3) {
			ProxyQGLColormap().SetEntries(count,out colors,arg3);
		}
		[SmokeMethod("setEntries(int, const QRgb*)")]
		public void SetEntries(int count, out int colors) {
			ProxyQGLColormap().SetEntries(count,out colors);
		}
		[SmokeMethod("setEntry(int, QRgb)")]
		public void SetEntry(int idx, uint color) {
			ProxyQGLColormap().SetEntry(idx,color);
		}
		[SmokeMethod("setEntry(int, const QColor&)")]
		public void SetEntry(int idx, QColor color) {
			ProxyQGLColormap().SetEntry(idx,color);
		}
		[SmokeMethod("entryRgb(int) const")]
		public uint EntryRgb(int idx) {
			return ProxyQGLColormap().EntryRgb(idx);
		}
		[SmokeMethod("entryColor(int) const")]
		public QColor EntryColor(int idx) {
			return ProxyQGLColormap().EntryColor(idx);
		}
		[SmokeMethod("find(QRgb) const")]
		public int Find(uint color) {
			return ProxyQGLColormap().Find(color);
		}
		[SmokeMethod("findNearest(QRgb) const")]
		public int FindNearest(uint color) {
			return ProxyQGLColormap().FindNearest(color);
		}
		[SmokeMethod("setHandle(Qt::HANDLE)")]
		protected void SetHandle(uint ahandle) {
			ProxyQGLColormap().SetHandle(ahandle);
		}
		~QGLColormap() {
			DisposeQGLColormap();
		}
		public void Dispose() {
			DisposeQGLColormap();
		}
		[SmokeMethod("~QGLColormap()")]
		private void DisposeQGLColormap() {
			ProxyQGLColormap().DisposeQGLColormap();
		}
	}
}