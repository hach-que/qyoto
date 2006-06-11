//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QCursor")]
	public class QCursor : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QCursor(Type dummy) {}
		interface IQCursorProxy {
			QPoint Pos();
			void SetPos(int x, int y);
			void SetPos(QPoint p);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCursor), this);
			_interceptor = (QCursor) realProxy.GetTransparentProxy();
		}
		private QCursor ProxyQCursor() {
			return (QCursor) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCursor() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCursorProxy), null);
			_staticInterceptor = (IQCursorProxy) realProxy.GetTransparentProxy();
		}
		private static IQCursorProxy StaticQCursor() {
			return (IQCursorProxy) _staticInterceptor;
		}

		public QCursor() : this((Type) null) {
			CreateProxy();
			NewQCursor();
		}
		[SmokeMethod("QCursor()")]
		private void NewQCursor() {
			ProxyQCursor().NewQCursor();
		}
		public QCursor(Qt.CursorShape shape) : this((Type) null) {
			CreateProxy();
			NewQCursor(shape);
		}
		[SmokeMethod("QCursor(Qt::CursorShape)")]
		private void NewQCursor(Qt.CursorShape shape) {
			ProxyQCursor().NewQCursor(shape);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) : this((Type) null) {
			CreateProxy();
			NewQCursor(bitmap,mask,hotX,hotY);
		}
		[SmokeMethod("QCursor(const QBitmap&, const QBitmap&, int, int)")]
		private void NewQCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) {
			ProxyQCursor().NewQCursor(bitmap,mask,hotX,hotY);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX) : this((Type) null) {
			CreateProxy();
			NewQCursor(bitmap,mask,hotX);
		}
		[SmokeMethod("QCursor(const QBitmap&, const QBitmap&, int)")]
		private void NewQCursor(QBitmap bitmap, QBitmap mask, int hotX) {
			ProxyQCursor().NewQCursor(bitmap,mask,hotX);
		}
		public QCursor(QBitmap bitmap, QBitmap mask) : this((Type) null) {
			CreateProxy();
			NewQCursor(bitmap,mask);
		}
		[SmokeMethod("QCursor(const QBitmap&, const QBitmap&)")]
		private void NewQCursor(QBitmap bitmap, QBitmap mask) {
			ProxyQCursor().NewQCursor(bitmap,mask);
		}
		public QCursor(QPixmap pixmap, int hotX, int hotY) : this((Type) null) {
			CreateProxy();
			NewQCursor(pixmap,hotX,hotY);
		}
		[SmokeMethod("QCursor(const QPixmap&, int, int)")]
		private void NewQCursor(QPixmap pixmap, int hotX, int hotY) {
			ProxyQCursor().NewQCursor(pixmap,hotX,hotY);
		}
		public QCursor(QPixmap pixmap, int hotX) : this((Type) null) {
			CreateProxy();
			NewQCursor(pixmap,hotX);
		}
		[SmokeMethod("QCursor(const QPixmap&, int)")]
		private void NewQCursor(QPixmap pixmap, int hotX) {
			ProxyQCursor().NewQCursor(pixmap,hotX);
		}
		public QCursor(QPixmap pixmap) : this((Type) null) {
			CreateProxy();
			NewQCursor(pixmap);
		}
		[SmokeMethod("QCursor(const QPixmap&)")]
		private void NewQCursor(QPixmap pixmap) {
			ProxyQCursor().NewQCursor(pixmap);
		}
		public QCursor(QCursor cursor) : this((Type) null) {
			CreateProxy();
			NewQCursor(cursor);
		}
		[SmokeMethod("QCursor(const QCursor&)")]
		private void NewQCursor(QCursor cursor) {
			ProxyQCursor().NewQCursor(cursor);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("shape() const")]
		public Qt.CursorShape Shape() {
			return ProxyQCursor().Shape();
		}
		[SmokeMethod("setShape(Qt::CursorShape)")]
		public void SetShape(Qt.CursorShape newShape) {
			ProxyQCursor().SetShape(newShape);
		}
		[SmokeMethod("bitmap() const")]
		public QBitmap Bitmap() {
			return ProxyQCursor().Bitmap();
		}
		[SmokeMethod("mask() const")]
		public QBitmap Mask() {
			return ProxyQCursor().Mask();
		}
		[SmokeMethod("pixmap() const")]
		public QPixmap Pixmap() {
			return ProxyQCursor().Pixmap();
		}
		[SmokeMethod("hotSpot() const")]
		public QPoint HotSpot() {
			return ProxyQCursor().HotSpot();
		}
		[SmokeMethod("pos()")]
		public static QPoint Pos() {
			return StaticQCursor().Pos();
		}
		[SmokeMethod("setPos(int, int)")]
		public static void SetPos(int x, int y) {
			StaticQCursor().SetPos(x,y);
		}
		[SmokeMethod("setPos(const QPoint&)")]
		public static void SetPos(QPoint p) {
			StaticQCursor().SetPos(p);
		}
		~QCursor() {
			DisposeQCursor();
		}
		public void Dispose() {
			DisposeQCursor();
		}
		[SmokeMethod("~QCursor()")]
		private void DisposeQCursor() {
			ProxyQCursor().DisposeQCursor();
		}
	}
}
