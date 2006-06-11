//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQDragSignals"></see> for signals emitted by QDrag
	[SmokeClass("QDrag")]
	public class QDrag : QObject, IDisposable {
 		protected QDrag(Type dummy) : base((Type) null) {}
		interface IQDragProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDrag), this);
			_interceptor = (QDrag) realProxy.GetTransparentProxy();
		}
		private QDrag ProxyQDrag() {
			return (QDrag) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDrag() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDragProxy), null);
			_staticInterceptor = (IQDragProxy) realProxy.GetTransparentProxy();
		}
		private static IQDragProxy StaticQDrag() {
			return (IQDragProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDrag(QWidget dragSource) : this((Type) null) {
			CreateProxy();
			NewQDrag(dragSource);
		}
		[SmokeMethod("QDrag(QWidget*)")]
		private void NewQDrag(QWidget dragSource) {
			ProxyQDrag().NewQDrag(dragSource);
		}
		[SmokeMethod("setMimeData(QMimeData*)")]
		public void SetMimeData(QMimeData data) {
			ProxyQDrag().SetMimeData(data);
		}
		[SmokeMethod("mimeData() const")]
		public QMimeData MimeData() {
			return ProxyQDrag().MimeData();
		}
		[SmokeMethod("setPixmap(const QPixmap&)")]
		public void SetPixmap(QPixmap arg1) {
			ProxyQDrag().SetPixmap(arg1);
		}
		[SmokeMethod("pixmap() const")]
		public QPixmap Pixmap() {
			return ProxyQDrag().Pixmap();
		}
		[SmokeMethod("setHotSpot(const QPoint&)")]
		public void SetHotSpot(QPoint hotspot) {
			ProxyQDrag().SetHotSpot(hotspot);
		}
		[SmokeMethod("hotSpot() const")]
		public QPoint HotSpot() {
			return ProxyQDrag().HotSpot();
		}
		[SmokeMethod("source() const")]
		public QWidget Source() {
			return ProxyQDrag().Source();
		}
		[SmokeMethod("target() const")]
		public QWidget Target() {
			return ProxyQDrag().Target();
		}
		[SmokeMethod("start(Qt::DropActions)")]
		public Qt.DropAction Start(int supportedActions) {
			return ProxyQDrag().Start(supportedActions);
		}
		[SmokeMethod("start()")]
		public Qt.DropAction Start() {
			return ProxyQDrag().Start();
		}
		[SmokeMethod("setDragCursor(const QPixmap&, Qt::DropAction)")]
		public void SetDragCursor(QPixmap cursor, Qt.DropAction action) {
			ProxyQDrag().SetDragCursor(cursor,action);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDrag().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDrag().Tr(s);
		}
		~QDrag() {
			DisposeQDrag();
		}
		public new void Dispose() {
			DisposeQDrag();
		}
		[SmokeMethod("~QDrag()")]
		private void DisposeQDrag() {
			ProxyQDrag().DisposeQDrag();
		}
		protected new IQDragSignals Emit() {
			return (IQDragSignals) Q_EMIT;
		}
	}

	public interface IQDragSignals : IQObjectSignals {
		[Q_SIGNAL("void actionChanged(Qt::DropAction)")]
		void ActionChanged(Qt.DropAction action);
		[Q_SIGNAL("void targetChanged(QWidget*)")]
		void TargetChanged(QWidget newTarget);
	}
}
