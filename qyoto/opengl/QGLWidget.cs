//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGLWidget")]
	public class QGLWidget : QWidget, IDisposable {
 		protected QGLWidget(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGLWidget), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QGLWidget() {
			staticInterceptor = new SmokeInvocation(typeof(QGLWidget), null);
		}
		public QGLWidget(QWidget parent, QGLWidget shareWidget, int f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget##$", "QGLWidget(QWidget*, const QGLWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(QGLWidget), shareWidget, typeof(int), f);
		}
		public QGLWidget(QWidget parent, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget##", "QGLWidget(QWidget*, const QGLWidget*)", typeof(void), typeof(QWidget), parent, typeof(QGLWidget), shareWidget);
		}
		public QGLWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget#", "QGLWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QGLWidget() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget", "QGLWidget()", typeof(void));
		}
		public QGLWidget(QGLContext context, QWidget parent, QGLWidget shareWidget, int f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget###$", "QGLWidget(QGLContext*, QWidget*, const QGLWidget*, Qt::WindowFlags)", typeof(void), typeof(QGLContext), context, typeof(QWidget), parent, typeof(QGLWidget), shareWidget, typeof(int), f);
		}
		public QGLWidget(QGLContext context, QWidget parent, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget###", "QGLWidget(QGLContext*, QWidget*, const QGLWidget*)", typeof(void), typeof(QGLContext), context, typeof(QWidget), parent, typeof(QGLWidget), shareWidget);
		}
		public QGLWidget(QGLContext context, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget##", "QGLWidget(QGLContext*, QWidget*)", typeof(void), typeof(QGLContext), context, typeof(QWidget), parent);
		}
		public QGLWidget(QGLContext context) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget#", "QGLWidget(QGLContext*)", typeof(void), typeof(QGLContext), context);
		}
		public QGLWidget(QGLFormat format, QWidget parent, QGLWidget shareWidget, int f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget###$", "QGLWidget(const QGLFormat&, QWidget*, const QGLWidget*, Qt::WindowFlags)", typeof(void), typeof(QGLFormat), format, typeof(QWidget), parent, typeof(QGLWidget), shareWidget, typeof(int), f);
		}
		public QGLWidget(QGLFormat format, QWidget parent, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget###", "QGLWidget(const QGLFormat&, QWidget*, const QGLWidget*)", typeof(void), typeof(QGLFormat), format, typeof(QWidget), parent, typeof(QGLWidget), shareWidget);
		}
		public QGLWidget(QGLFormat format, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget##", "QGLWidget(const QGLFormat&, QWidget*)", typeof(void), typeof(QGLFormat), format, typeof(QWidget), parent);
		}
		public QGLWidget(QGLFormat format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLWidget#", "QGLWidget(const QGLFormat&)", typeof(void), typeof(QGLFormat), format);
		}
		public void QglColor(QColor c) {
			interceptor.Invoke("qglColor#", "qglColor(const QColor&) const", typeof(void), typeof(QColor), c);
		}
		public void QglClearColor(QColor c) {
			interceptor.Invoke("qglClearColor#", "qglClearColor(const QColor&) const", typeof(void), typeof(QColor), c);
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public bool IsSharing() {
			return (bool) interceptor.Invoke("isSharing", "isSharing() const", typeof(bool));
		}
		public void MakeCurrent() {
			interceptor.Invoke("makeCurrent", "makeCurrent()", typeof(void));
		}
		public void DoneCurrent() {
			interceptor.Invoke("doneCurrent", "doneCurrent()", typeof(void));
		}
		public bool DoubleBuffer() {
			return (bool) interceptor.Invoke("doubleBuffer", "doubleBuffer() const", typeof(bool));
		}
		public void SwapBuffers() {
			interceptor.Invoke("swapBuffers", "swapBuffers()", typeof(void));
		}
		public QGLFormat Format() {
			return (QGLFormat) interceptor.Invoke("format", "format() const", typeof(QGLFormat));
		}
		public void SetFormat(QGLFormat format) {
			interceptor.Invoke("setFormat#", "setFormat(const QGLFormat&)", typeof(void), typeof(QGLFormat), format);
		}
		public QGLContext Context() {
			return (QGLContext) interceptor.Invoke("context", "context() const", typeof(QGLContext));
		}
		public void SetContext(QGLContext context, QGLContext shareContext, bool deleteOldContext) {
			interceptor.Invoke("setContext##$", "setContext(QGLContext*, const QGLContext*, bool)", typeof(void), typeof(QGLContext), context, typeof(QGLContext), shareContext, typeof(bool), deleteOldContext);
		}
		public void SetContext(QGLContext context, QGLContext shareContext) {
			interceptor.Invoke("setContext##", "setContext(QGLContext*, const QGLContext*)", typeof(void), typeof(QGLContext), context, typeof(QGLContext), shareContext);
		}
		public void SetContext(QGLContext context) {
			interceptor.Invoke("setContext#", "setContext(QGLContext*)", typeof(void), typeof(QGLContext), context);
		}
		public QPixmap RenderPixmap(int w, int h, bool useContext) {
			return (QPixmap) interceptor.Invoke("renderPixmap$$$", "renderPixmap(int, int, bool)", typeof(QPixmap), typeof(int), w, typeof(int), h, typeof(bool), useContext);
		}
		public QPixmap RenderPixmap(int w, int h) {
			return (QPixmap) interceptor.Invoke("renderPixmap$$", "renderPixmap(int, int)", typeof(QPixmap), typeof(int), w, typeof(int), h);
		}
		public QPixmap RenderPixmap(int w) {
			return (QPixmap) interceptor.Invoke("renderPixmap$", "renderPixmap(int)", typeof(QPixmap), typeof(int), w);
		}
		public QPixmap RenderPixmap() {
			return (QPixmap) interceptor.Invoke("renderPixmap", "renderPixmap()", typeof(QPixmap));
		}
		public QImage GrabFrameBuffer(bool withAlpha) {
			return (QImage) interceptor.Invoke("grabFrameBuffer$", "grabFrameBuffer(bool)", typeof(QImage), typeof(bool), withAlpha);
		}
		public QImage GrabFrameBuffer() {
			return (QImage) interceptor.Invoke("grabFrameBuffer", "grabFrameBuffer()", typeof(QImage));
		}
		public void MakeOverlayCurrent() {
			interceptor.Invoke("makeOverlayCurrent", "makeOverlayCurrent()", typeof(void));
		}
		public QGLContext OverlayContext() {
			return (QGLContext) interceptor.Invoke("overlayContext", "overlayContext() const", typeof(QGLContext));
		}
		public void SetMouseTracking(bool enable) {
			interceptor.Invoke("setMouseTracking$", "setMouseTracking(bool)", typeof(void), typeof(bool), enable);
		}
		public QGLColormap Colormap() {
			return (QGLColormap) interceptor.Invoke("colormap", "colormap() const", typeof(QGLColormap));
		}
		public void SetColormap(QGLColormap map) {
			interceptor.Invoke("setColormap#", "setColormap(const QGLColormap&)", typeof(void), typeof(QGLColormap), map);
		}
		public void RenderText(int x, int y, string str, QFont fnt, int listBase) {
			interceptor.Invoke("renderText$$$#$", "renderText(int, int, const QString&, const QFont&, int)", typeof(void), typeof(int), x, typeof(int), y, typeof(string), str, typeof(QFont), fnt, typeof(int), listBase);
		}
		public void RenderText(int x, int y, string str, QFont fnt) {
			interceptor.Invoke("renderText$$$#", "renderText(int, int, const QString&, const QFont&)", typeof(void), typeof(int), x, typeof(int), y, typeof(string), str, typeof(QFont), fnt);
		}
		public void RenderText(int x, int y, string str) {
			interceptor.Invoke("renderText$$$", "renderText(int, int, const QString&)", typeof(void), typeof(int), x, typeof(int), y, typeof(string), str);
		}
		public void RenderText(double x, double y, double z, string str, QFont fnt, int listBase) {
			interceptor.Invoke("renderText$$$$#$", "renderText(double, double, double, const QString&, const QFont&, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), z, typeof(string), str, typeof(QFont), fnt, typeof(int), listBase);
		}
		public void RenderText(double x, double y, double z, string str, QFont fnt) {
			interceptor.Invoke("renderText$$$$#", "renderText(double, double, double, const QString&, const QFont&)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), z, typeof(string), str, typeof(QFont), fnt);
		}
		public void RenderText(double x, double y, double z, string str) {
			interceptor.Invoke("renderText$$$$", "renderText(double, double, double, const QString&)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), z, typeof(string), str);
		}
		[SmokeMethod("paintEngine() const")]
		public override QPaintEngine PaintEngine() {
			return (QPaintEngine) interceptor.Invoke("paintEngine", "paintEngine() const", typeof(QPaintEngine));
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
		[Q_SLOT("void updateGL()")]
		[SmokeMethod("updateGL()")]
		public virtual void UpdateGL() {
			interceptor.Invoke("updateGL", "updateGL()", typeof(void));
		}
		[Q_SLOT("void updateOverlayGL()")]
		[SmokeMethod("updateOverlayGL()")]
		public virtual void UpdateOverlayGL() {
			interceptor.Invoke("updateOverlayGL", "updateOverlayGL()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("initializeGL()")]
		protected virtual void InitializeGL() {
			interceptor.Invoke("initializeGL", "initializeGL()", typeof(void));
		}
		[SmokeMethod("resizeGL(int, int)")]
		protected virtual void ResizeGL(int w, int h) {
			interceptor.Invoke("resizeGL$$", "resizeGL(int, int)", typeof(void), typeof(int), w, typeof(int), h);
		}
		[SmokeMethod("paintGL()")]
		protected virtual void PaintGL() {
			interceptor.Invoke("paintGL", "paintGL()", typeof(void));
		}
		[SmokeMethod("initializeOverlayGL()")]
		protected virtual void InitializeOverlayGL() {
			interceptor.Invoke("initializeOverlayGL", "initializeOverlayGL()", typeof(void));
		}
		[SmokeMethod("resizeOverlayGL(int, int)")]
		protected virtual void ResizeOverlayGL(int w, int h) {
			interceptor.Invoke("resizeOverlayGL$$", "resizeOverlayGL(int, int)", typeof(void), typeof(int), w, typeof(int), h);
		}
		[SmokeMethod("paintOverlayGL()")]
		protected virtual void PaintOverlayGL() {
			interceptor.Invoke("paintOverlayGL", "paintOverlayGL()", typeof(void));
		}
		protected void SetAutoBufferSwap(bool on) {
			interceptor.Invoke("setAutoBufferSwap$", "setAutoBufferSwap(bool)", typeof(void), typeof(bool), on);
		}
		protected bool AutoBufferSwap() {
			return (bool) interceptor.Invoke("autoBufferSwap", "autoBufferSwap() const", typeof(bool));
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("glInit()")]
		protected virtual void GlInit() {
			interceptor.Invoke("glInit", "glInit()", typeof(void));
		}
		[SmokeMethod("glDraw()")]
		protected virtual void GlDraw() {
			interceptor.Invoke("glDraw", "glDraw()", typeof(void));
		}
		protected int FontDisplayListBase(QFont fnt, int listBase) {
			return (int) interceptor.Invoke("fontDisplayListBase#$", "fontDisplayListBase(const QFont&, int)", typeof(int), typeof(QFont), fnt, typeof(int), listBase);
		}
		protected int FontDisplayListBase(QFont fnt) {
			return (int) interceptor.Invoke("fontDisplayListBase#", "fontDisplayListBase(const QFont&)", typeof(int), typeof(QFont), fnt);
		}
		~QGLWidget() {
			interceptor.Invoke("~QGLWidget", "~QGLWidget()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QGLWidget", "~QGLWidget()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static QImage ConvertToGLFormat(QImage img) {
			return (QImage) staticInterceptor.Invoke("convertToGLFormat#", "convertToGLFormat(const QImage&)", typeof(QImage), typeof(QImage), img);
		}
		protected new IQGLWidgetSignals Emit {
			get { return (IQGLWidgetSignals) Q_EMIT; }
		}
	}

	public interface IQGLWidgetSignals : IQWidgetSignals {
	}
}
