//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QIconSet : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QIconSet(Type dummy) {}
		interface IQIconSetProxy {
			void SetIconSize(int which, QSize size);
			QSize IconSize(int which);
		}

		protected void CreateQIconSetProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIconSet), this);
			_interceptor = (QIconSet) realProxy.GetTransparentProxy();
		}
		private QIconSet ProxyQIconSet() {
			return (QIconSet) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIconSet() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIconSetProxy), null);
			_staticInterceptor = (IQIconSetProxy) realProxy.GetTransparentProxy();
		}
		private static IQIconSetProxy StaticQIconSet() {
			return (IQIconSetProxy) _staticInterceptor;
		}

		enum Size {
			Automatic = 0,
			Small = 1,
			Large = 2,
		}
		enum Mode {
			Normal = 0,
			Disabled = 1,
			Active = 2,
		}
		enum State {
			On = 0,
			Off = 1,
		}
		public QIconSet() : this((Type) null) {
			CreateQIconSetProxy();
			NewQIconSet();
		}
		[SmokeMethod("QIconSet()")]
		private void NewQIconSet() {
			ProxyQIconSet().NewQIconSet();
		}
		public QIconSet(QPixmap pixmap, int size) : this((Type) null) {
			CreateQIconSetProxy();
			NewQIconSet(pixmap,size);
		}
		[SmokeMethod("QIconSet(const QPixmap&, QIconSet::Size)")]
		private void NewQIconSet(QPixmap pixmap, int size) {
			ProxyQIconSet().NewQIconSet(pixmap,size);
		}
		public QIconSet(QPixmap pixmap) : this((Type) null) {
			CreateQIconSetProxy();
			NewQIconSet(pixmap);
		}
		[SmokeMethod("QIconSet(const QPixmap&)")]
		private void NewQIconSet(QPixmap pixmap) {
			ProxyQIconSet().NewQIconSet(pixmap);
		}
		public QIconSet(QPixmap smallPix, QPixmap largePix) : this((Type) null) {
			CreateQIconSetProxy();
			NewQIconSet(smallPix,largePix);
		}
		[SmokeMethod("QIconSet(const QPixmap&, const QPixmap&)")]
		private void NewQIconSet(QPixmap smallPix, QPixmap largePix) {
			ProxyQIconSet().NewQIconSet(smallPix,largePix);
		}
		public QIconSet(QIconSet other) : this((Type) null) {
			CreateQIconSetProxy();
			NewQIconSet(other);
		}
		[SmokeMethod("QIconSet(const QIconSet&)")]
		private void NewQIconSet(QIconSet other) {
			ProxyQIconSet().NewQIconSet(other);
		}
		[SmokeMethod("reset(const QPixmap&, QIconSet::Size)")]
		public void Reset(QPixmap pixmap, int size) {
			ProxyQIconSet().Reset(pixmap,size);
		}
		[SmokeMethod("setPixmap(const QPixmap&, QIconSet::Size, QIconSet::Mode, QIconSet::State)")]
		public virtual void SetPixmap(QPixmap pixmap, int size, int mode, int state) {
			ProxyQIconSet().SetPixmap(pixmap,size,mode,state);
		}
		[SmokeMethod("setPixmap(const QPixmap&, QIconSet::Size, QIconSet::Mode)")]
		public virtual void SetPixmap(QPixmap pixmap, int size, int mode) {
			ProxyQIconSet().SetPixmap(pixmap,size,mode);
		}
		[SmokeMethod("setPixmap(const QPixmap&, QIconSet::Size)")]
		public virtual void SetPixmap(QPixmap pixmap, int size) {
			ProxyQIconSet().SetPixmap(pixmap,size);
		}
		[SmokeMethod("setPixmap(const QString&, QIconSet::Size, QIconSet::Mode, QIconSet::State)")]
		public virtual void SetPixmap(string fileName, int size, int mode, int state) {
			ProxyQIconSet().SetPixmap(fileName,size,mode,state);
		}
		[SmokeMethod("setPixmap(const QString&, QIconSet::Size, QIconSet::Mode)")]
		public virtual void SetPixmap(string fileName, int size, int mode) {
			ProxyQIconSet().SetPixmap(fileName,size,mode);
		}
		[SmokeMethod("setPixmap(const QString&, QIconSet::Size)")]
		public virtual void SetPixmap(string fileName, int size) {
			ProxyQIconSet().SetPixmap(fileName,size);
		}
		[SmokeMethod("pixmap(QIconSet::Size, QIconSet::Mode, QIconSet::State) const")]
		public QPixmap Pixmap(int size, int mode, int state) {
			return ProxyQIconSet().Pixmap(size,mode,state);
		}
		[SmokeMethod("pixmap(QIconSet::Size, QIconSet::Mode) const")]
		public QPixmap Pixmap(int size, int mode) {
			return ProxyQIconSet().Pixmap(size,mode);
		}
		[SmokeMethod("pixmap(QIconSet::Size, bool, QIconSet::State) const")]
		public QPixmap Pixmap(int size, bool enabled, int state) {
			return ProxyQIconSet().Pixmap(size,enabled,state);
		}
		[SmokeMethod("pixmap(QIconSet::Size, bool) const")]
		public QPixmap Pixmap(int size, bool enabled) {
			return ProxyQIconSet().Pixmap(size,enabled);
		}
		[SmokeMethod("pixmap() const")]
		public QPixmap Pixmap() {
			return ProxyQIconSet().Pixmap();
		}
		[SmokeMethod("isGenerated(QIconSet::Size, QIconSet::Mode, QIconSet::State) const")]
		public bool IsGenerated(int size, int mode, int state) {
			return ProxyQIconSet().IsGenerated(size,mode,state);
		}
		[SmokeMethod("isGenerated(QIconSet::Size, QIconSet::Mode) const")]
		public bool IsGenerated(int size, int mode) {
			return ProxyQIconSet().IsGenerated(size,mode);
		}
		[SmokeMethod("clearGenerated()")]
		public void ClearGenerated() {
			ProxyQIconSet().ClearGenerated();
		}
		// void installIconFactory(QIconFactory* arg1); >>>> NOT CONVERTED
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQIconSet().IsNull();
		}
		[SmokeMethod("detach()")]
		public void Detach() {
			ProxyQIconSet().Detach();
		}
		[SmokeMethod("setIconSize(QIconSet::Size, const QSize&)")]
		public static void SetIconSize(int which, QSize size) {
			StaticQIconSet().SetIconSize(which,size);
		}
		[SmokeMethod("iconSize(QIconSet::Size)")]
		public static QSize IconSize(int which) {
			return StaticQIconSet().IconSize(which);
		}
		~QIconSet() {
			DisposeQIconSet();
		}
		public void Dispose() {
			DisposeQIconSet();
		}
		private void DisposeQIconSet() {
			ProxyQIconSet().DisposeQIconSet();
		}
	}
}