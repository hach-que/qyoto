//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QMouseEvent")]
	public class QMouseEvent : QInputEvent, IDisposable {
 		protected QMouseEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMouseEvent), this);
			_interceptor = (QMouseEvent) realProxy.GetTransparentProxy();
		}
		private QMouseEvent ProxyQMouseEvent() {
			return (QMouseEvent) _interceptor;
		}
		public QMouseEvent(QEvent.TypeOf type, QPoint pos, Qt.MouseButton button, int buttons, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQMouseEvent(type,pos,button,buttons,modifiers);
		}
		[SmokeMethod("QMouseEvent", "(QEvent::Type, const QPoint&, Qt::MouseButton, Qt::MouseButtons, Qt::KeyboardModifiers)", "$#$$$")]
		private void NewQMouseEvent(QEvent.TypeOf type, QPoint pos, Qt.MouseButton button, int buttons, int modifiers) {
			ProxyQMouseEvent().NewQMouseEvent(type,pos,button,buttons,modifiers);
		}
		public QMouseEvent(QEvent.TypeOf type, QPoint pos, QPoint globalPos, Qt.MouseButton button, int buttons, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQMouseEvent(type,pos,globalPos,button,buttons,modifiers);
		}
		[SmokeMethod("QMouseEvent", "(QEvent::Type, const QPoint&, const QPoint&, Qt::MouseButton, Qt::MouseButtons, Qt::KeyboardModifiers)", "$##$$$")]
		private void NewQMouseEvent(QEvent.TypeOf type, QPoint pos, QPoint globalPos, Qt.MouseButton button, int buttons, int modifiers) {
			ProxyQMouseEvent().NewQMouseEvent(type,pos,globalPos,button,buttons,modifiers);
		}
		[SmokeMethod("pos", "() const", "")]
		public QPoint Pos() {
			return ProxyQMouseEvent().Pos();
		}
		[SmokeMethod("globalPos", "() const", "")]
		public QPoint GlobalPos() {
			return ProxyQMouseEvent().GlobalPos();
		}
		[SmokeMethod("x", "() const", "")]
		public int X() {
			return ProxyQMouseEvent().X();
		}
		[SmokeMethod("y", "() const", "")]
		public int Y() {
			return ProxyQMouseEvent().Y();
		}
		[SmokeMethod("globalX", "() const", "")]
		public int GlobalX() {
			return ProxyQMouseEvent().GlobalX();
		}
		[SmokeMethod("globalY", "() const", "")]
		public int GlobalY() {
			return ProxyQMouseEvent().GlobalY();
		}
		[SmokeMethod("button", "() const", "")]
		public Qt.MouseButton Button() {
			return ProxyQMouseEvent().Button();
		}
		[SmokeMethod("buttons", "() const", "")]
		public int Buttons() {
			return ProxyQMouseEvent().Buttons();
		}
		~QMouseEvent() {
			DisposeQMouseEvent();
		}
		public new void Dispose() {
			DisposeQMouseEvent();
		}
		[SmokeMethod("~QMouseEvent", "()", "")]
		private void DisposeQMouseEvent() {
			ProxyQMouseEvent().DisposeQMouseEvent();
		}
	}
}
