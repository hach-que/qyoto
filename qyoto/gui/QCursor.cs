//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QCursor")]
	public partial class QCursor : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QCursor(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QCursor), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QCursor() {
			staticInterceptor = new SmokeInvocation(typeof(QCursor), null);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QCursor() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor", "QCursor()", typeof(void));
		}
		public QCursor(Qt.CursorShape shape) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor$", "QCursor(Qt::CursorShape)", typeof(void), typeof(Qt.CursorShape), shape);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor##$$", "QCursor(const QBitmap&, const QBitmap&, int, int)", typeof(void), typeof(QBitmap), bitmap, typeof(QBitmap), mask, typeof(int), hotX, typeof(int), hotY);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor##$", "QCursor(const QBitmap&, const QBitmap&, int)", typeof(void), typeof(QBitmap), bitmap, typeof(QBitmap), mask, typeof(int), hotX);
		}
		public QCursor(QBitmap bitmap, QBitmap mask) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor##", "QCursor(const QBitmap&, const QBitmap&)", typeof(void), typeof(QBitmap), bitmap, typeof(QBitmap), mask);
		}
		public QCursor(QPixmap pixmap, int hotX, int hotY) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor#$$", "QCursor(const QPixmap&, int, int)", typeof(void), typeof(QPixmap), pixmap, typeof(int), hotX, typeof(int), hotY);
		}
		public QCursor(QPixmap pixmap, int hotX) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor#$", "QCursor(const QPixmap&, int)", typeof(void), typeof(QPixmap), pixmap, typeof(int), hotX);
		}
		public QCursor(QPixmap pixmap) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor#", "QCursor(const QPixmap&)", typeof(void), typeof(QPixmap), pixmap);
		}
		public QCursor(QCursor cursor) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCursor#", "QCursor(const QCursor&)", typeof(void), typeof(QCursor), cursor);
		}
		public Qt.CursorShape Shape() {
			return (Qt.CursorShape) interceptor.Invoke("shape", "shape() const", typeof(Qt.CursorShape));
		}
		public void SetShape(Qt.CursorShape newShape) {
			interceptor.Invoke("setShape$", "setShape(Qt::CursorShape)", typeof(void), typeof(Qt.CursorShape), newShape);
		}
		public QBitmap Bitmap() {
			return (QBitmap) interceptor.Invoke("bitmap", "bitmap() const", typeof(QBitmap));
		}
		public QBitmap Mask() {
			return (QBitmap) interceptor.Invoke("mask", "mask() const", typeof(QBitmap));
		}
		public QPixmap Pixmap() {
			return (QPixmap) interceptor.Invoke("pixmap", "pixmap() const", typeof(QPixmap));
		}
		public QPoint HotSpot() {
			return (QPoint) interceptor.Invoke("hotSpot", "hotSpot() const", typeof(QPoint));
		}
		~QCursor() {
			interceptor.Invoke("~QCursor", "~QCursor()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QCursor", "~QCursor()", typeof(void));
		}
		public static QPoint Pos() {
			return (QPoint) staticInterceptor.Invoke("pos", "pos()", typeof(QPoint));
		}
		public static void SetPos(int x, int y) {
			staticInterceptor.Invoke("setPos$$", "setPos(int, int)", typeof(void), typeof(int), x, typeof(int), y);
		}
		public static void SetPos(QPoint p) {
			staticInterceptor.Invoke("setPos#", "setPos(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
	}
}
