//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGLContext")]
	public class QGLContext : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QGLContext(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGLContext), "QGLContext", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QGLContext() {
			staticInterceptor = new SmokeInvocation(typeof(QGLContext), "QGLContext", null);
		}
		public static QGLContext CurrentCtx() {
			return (QGLContext) staticInterceptor.Invoke("currentCtx", "currentCtx()", typeof(QGLContext));
		}
		// void* getProcAddress(const QString& arg1); >>>> NOT CONVERTED
		public QGLContext(QGLFormat format, IQPaintDevice device) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLContext##", "QGLContext(const QGLFormat&, QPaintDevice*)", typeof(void), typeof(QGLFormat), format, typeof(IQPaintDevice), device);
		}
		public QGLContext(QGLFormat format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLContext#", "QGLContext(const QGLFormat&)", typeof(void), typeof(QGLFormat), format);
		}
		[SmokeMethod("create(const QGLContext*)")]
		public virtual bool Create(QGLContext shareContext) {
			return (bool) interceptor.Invoke("create#", "create(const QGLContext*)", typeof(bool), typeof(QGLContext), shareContext);
		}
		[SmokeMethod("create()")]
		public virtual bool Create() {
			return (bool) interceptor.Invoke("create", "create()", typeof(bool));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public bool IsSharing() {
			return (bool) interceptor.Invoke("isSharing", "isSharing() const", typeof(bool));
		}
		public void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		public QGLFormat Format() {
			return (QGLFormat) interceptor.Invoke("format", "format() const", typeof(QGLFormat));
		}
		public QGLFormat RequestedFormat() {
			return (QGLFormat) interceptor.Invoke("requestedFormat", "requestedFormat() const", typeof(QGLFormat));
		}
		public void SetFormat(QGLFormat format) {
			interceptor.Invoke("setFormat#", "setFormat(const QGLFormat&)", typeof(void), typeof(QGLFormat), format);
		}
		[SmokeMethod("makeCurrent()")]
		public virtual void MakeCurrent() {
			interceptor.Invoke("makeCurrent", "makeCurrent()", typeof(void));
		}
		[SmokeMethod("doneCurrent()")]
		public virtual void DoneCurrent() {
			interceptor.Invoke("doneCurrent", "doneCurrent()", typeof(void));
		}
		[SmokeMethod("swapBuffers() const")]
		public virtual void SwapBuffers() {
			interceptor.Invoke("swapBuffers", "swapBuffers() const", typeof(void));
		}
		public uint BindTexture(QImage image, int target, int format) {
			return (uint) interceptor.Invoke("bindTexture#$$", "bindTexture(const QImage&, GLenum, GLint)", typeof(uint), typeof(QImage), image, typeof(int), target, typeof(int), format);
		}
		public uint BindTexture(QImage image, int target) {
			return (uint) interceptor.Invoke("bindTexture#$", "bindTexture(const QImage&, GLenum)", typeof(uint), typeof(QImage), image, typeof(int), target);
		}
		public uint BindTexture(QImage image) {
			return (uint) interceptor.Invoke("bindTexture#", "bindTexture(const QImage&)", typeof(uint), typeof(QImage), image);
		}
		public uint BindTexture(QPixmap pixmap, int target, int format) {
			return (uint) interceptor.Invoke("bindTexture#$$", "bindTexture(const QPixmap&, GLenum, GLint)", typeof(uint), typeof(QPixmap), pixmap, typeof(int), target, typeof(int), format);
		}
		public uint BindTexture(QPixmap pixmap, int target) {
			return (uint) interceptor.Invoke("bindTexture#$", "bindTexture(const QPixmap&, GLenum)", typeof(uint), typeof(QPixmap), pixmap, typeof(int), target);
		}
		public uint BindTexture(QPixmap pixmap) {
			return (uint) interceptor.Invoke("bindTexture#", "bindTexture(const QPixmap&)", typeof(uint), typeof(QPixmap), pixmap);
		}
		public uint BindTexture(string fileName) {
			return (uint) interceptor.Invoke("bindTexture$", "bindTexture(const QString&)", typeof(uint), typeof(string), fileName);
		}
		public void DeleteTexture(uint tx_id) {
			interceptor.Invoke("deleteTexture$", "deleteTexture(GLuint)", typeof(void), typeof(uint), tx_id);
		}
		public IQPaintDevice Device() {
			return (IQPaintDevice) interceptor.Invoke("device", "device() const", typeof(IQPaintDevice));
		}
		public QColor OverlayTransparentColor() {
			return (QColor) interceptor.Invoke("overlayTransparentColor", "overlayTransparentColor() const", typeof(QColor));
		}
		[SmokeMethod("chooseContext(const QGLContext*)")]
		protected virtual bool ChooseContext(QGLContext shareContext) {
			return (bool) interceptor.Invoke("chooseContext#", "chooseContext(const QGLContext*)", typeof(bool), typeof(QGLContext), shareContext);
		}
		[SmokeMethod("chooseContext()")]
		protected virtual bool ChooseContext() {
			return (bool) interceptor.Invoke("chooseContext", "chooseContext()", typeof(bool));
		}
		protected bool DeviceIsPixmap() {
			return (bool) interceptor.Invoke("deviceIsPixmap", "deviceIsPixmap() const", typeof(bool));
		}
		protected bool WindowCreated() {
			return (bool) interceptor.Invoke("windowCreated", "windowCreated() const", typeof(bool));
		}
		protected void SetWindowCreated(bool on) {
			interceptor.Invoke("setWindowCreated$", "setWindowCreated(bool)", typeof(void), typeof(bool), on);
		}
		protected bool Initialized() {
			return (bool) interceptor.Invoke("initialized", "initialized() const", typeof(bool));
		}
		protected void SetInitialized(bool on) {
			interceptor.Invoke("setInitialized$", "setInitialized(bool)", typeof(void), typeof(bool), on);
		}
		protected void GenerateFontDisplayLists(QFont fnt, int listBase) {
			interceptor.Invoke("generateFontDisplayLists#$", "generateFontDisplayLists(const QFont&, int)", typeof(void), typeof(QFont), fnt, typeof(int), listBase);
		}
		protected uint ColorIndex(QColor c) {
			return (uint) interceptor.Invoke("colorIndex#", "colorIndex(const QColor&) const", typeof(uint), typeof(QColor), c);
		}
		protected void SetValid(bool valid) {
			interceptor.Invoke("setValid$", "setValid(bool)", typeof(void), typeof(bool), valid);
		}
		protected void SetDevice(IQPaintDevice pDev) {
			interceptor.Invoke("setDevice#", "setDevice(QPaintDevice*)", typeof(void), typeof(IQPaintDevice), pDev);
		}
		~QGLContext() {
			interceptor.Invoke("~QGLContext", "~QGLContext()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QGLContext", "~QGLContext()", typeof(void));
		}
		public static void SetTextureCacheLimit(int size) {
			staticInterceptor.Invoke("setTextureCacheLimit$", "setTextureCacheLimit(int)", typeof(void), typeof(int), size);
		}
		public static int TextureCacheLimit() {
			return (int) staticInterceptor.Invoke("textureCacheLimit", "textureCacheLimit()", typeof(int));
		}
		public static QGLContext CurrentContext() {
			return (QGLContext) staticInterceptor.Invoke("currentContext", "currentContext()", typeof(QGLContext));
		}
	}
}
