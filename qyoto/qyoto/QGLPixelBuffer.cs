//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QGLPixelBuffer")]
	public class QGLPixelBuffer : QPaintDevice, IDisposable {
 		protected QGLPixelBuffer(Type dummy) : base((Type) null) {}
		interface IQGLPixelBufferProxy {
			bool HasOpenGLPbuffers();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGLPixelBuffer), this);
			_interceptor = (QGLPixelBuffer) realProxy.GetTransparentProxy();
		}
		private QGLPixelBuffer ProxyQGLPixelBuffer() {
			return (QGLPixelBuffer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGLPixelBuffer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGLPixelBufferProxy), null);
			_staticInterceptor = (IQGLPixelBufferProxy) realProxy.GetTransparentProxy();
		}
		private static IQGLPixelBufferProxy StaticQGLPixelBuffer() {
			return (IQGLPixelBufferProxy) _staticInterceptor;
		}

		public QGLPixelBuffer(QSize size, QGLFormat format, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			NewQGLPixelBuffer(size,format,shareWidget);
		}
		[SmokeMethod("QGLPixelBuffer(const QSize&, const QGLFormat&, QGLWidget*)")]
		private void NewQGLPixelBuffer(QSize size, QGLFormat format, QGLWidget shareWidget) {
			ProxyQGLPixelBuffer().NewQGLPixelBuffer(size,format,shareWidget);
		}
		public QGLPixelBuffer(QSize size, QGLFormat format) : this((Type) null) {
			CreateProxy();
			NewQGLPixelBuffer(size,format);
		}
		[SmokeMethod("QGLPixelBuffer(const QSize&, const QGLFormat&)")]
		private void NewQGLPixelBuffer(QSize size, QGLFormat format) {
			ProxyQGLPixelBuffer().NewQGLPixelBuffer(size,format);
		}
		public QGLPixelBuffer(QSize size) : this((Type) null) {
			CreateProxy();
			NewQGLPixelBuffer(size);
		}
		[SmokeMethod("QGLPixelBuffer(const QSize&)")]
		private void NewQGLPixelBuffer(QSize size) {
			ProxyQGLPixelBuffer().NewQGLPixelBuffer(size);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQGLPixelBuffer().IsValid();
		}
		[SmokeMethod("makeCurrent()")]
		public bool MakeCurrent() {
			return ProxyQGLPixelBuffer().MakeCurrent();
		}
		[SmokeMethod("doneCurrent()")]
		public bool DoneCurrent() {
			return ProxyQGLPixelBuffer().DoneCurrent();
		}
		[SmokeMethod("generateDynamicTexture() const")]
		public uint GenerateDynamicTexture() {
			return ProxyQGLPixelBuffer().GenerateDynamicTexture();
		}
		[SmokeMethod("bindToDynamicTexture(GLuint)")]
		public bool BindToDynamicTexture(uint texture) {
			return ProxyQGLPixelBuffer().BindToDynamicTexture(texture);
		}
		[SmokeMethod("releaseFromDynamicTexture()")]
		public void ReleaseFromDynamicTexture() {
			ProxyQGLPixelBuffer().ReleaseFromDynamicTexture();
		}
		[SmokeMethod("updateDynamicTexture(GLuint) const")]
		public void UpdateDynamicTexture(uint texture_id) {
			ProxyQGLPixelBuffer().UpdateDynamicTexture(texture_id);
		}
		[SmokeMethod("bindTexture(const QImage&, GLenum)")]
		public uint BindTexture(QImage image, int target) {
			return ProxyQGLPixelBuffer().BindTexture(image,target);
		}
		[SmokeMethod("bindTexture(const QImage&)")]
		public uint BindTexture(QImage image) {
			return ProxyQGLPixelBuffer().BindTexture(image);
		}
		[SmokeMethod("bindTexture(const QPixmap&, GLenum)")]
		public uint BindTexture(QPixmap pixmap, int target) {
			return ProxyQGLPixelBuffer().BindTexture(pixmap,target);
		}
		[SmokeMethod("bindTexture(const QPixmap&)")]
		public uint BindTexture(QPixmap pixmap) {
			return ProxyQGLPixelBuffer().BindTexture(pixmap);
		}
		[SmokeMethod("bindTexture(const QString&)")]
		public uint BindTexture(string fileName) {
			return ProxyQGLPixelBuffer().BindTexture(fileName);
		}
		[SmokeMethod("deleteTexture(GLuint)")]
		public void DeleteTexture(uint texture_id) {
			ProxyQGLPixelBuffer().DeleteTexture(texture_id);
		}
		[SmokeMethod("size() const")]
		public QSize Size() {
			return ProxyQGLPixelBuffer().Size();
		}
		[SmokeMethod("toImage() const")]
		public QImage ToImage() {
			return ProxyQGLPixelBuffer().ToImage();
		}
		[SmokeMethod("paintEngine() const")]
		public new QPaintEngine PaintEngine() {
			return ProxyQGLPixelBuffer().PaintEngine();
		}
		[SmokeMethod("format() const")]
		public QGLFormat Format() {
			return ProxyQGLPixelBuffer().Format();
		}
		[SmokeMethod("hasOpenGLPbuffers()")]
		public static bool HasOpenGLPbuffers() {
			return StaticQGLPixelBuffer().HasOpenGLPbuffers();
		}
		[SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
		protected new int Metric(IQPaintDevice metric) {
			return ProxyQGLPixelBuffer().Metric(metric);
		}
		[SmokeMethod("devType() const")]
		protected new int DevType() {
			return ProxyQGLPixelBuffer().DevType();
		}
		~QGLPixelBuffer() {
			DisposeQGLPixelBuffer();
		}
		public void Dispose() {
			DisposeQGLPixelBuffer();
		}
		[SmokeMethod("~QGLPixelBuffer()")]
		private void DisposeQGLPixelBuffer() {
			ProxyQGLPixelBuffer().DisposeQGLPixelBuffer();
		}
	}
}
