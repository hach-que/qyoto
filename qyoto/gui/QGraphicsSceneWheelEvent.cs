//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsSceneWheelEvent")]
	public class QGraphicsSceneWheelEvent : QGraphicsSceneEvent, IDisposable {
 		protected QGraphicsSceneWheelEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSceneWheelEvent), this);
			_interceptor = (QGraphicsSceneWheelEvent) realProxy.GetTransparentProxy();
		}
		private QGraphicsSceneWheelEvent ProxyQGraphicsSceneWheelEvent() {
			return (QGraphicsSceneWheelEvent) _interceptor;
		}
		public QGraphicsSceneWheelEvent(QEvent.TypeOf type) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneWheelEvent(type);
		}
		[SmokeMethod("QGraphicsSceneWheelEvent", "(QEvent::Type)", "$")]
		private void NewQGraphicsSceneWheelEvent(QEvent.TypeOf type) {
			ProxyQGraphicsSceneWheelEvent().NewQGraphicsSceneWheelEvent(type);
		}
		public QGraphicsSceneWheelEvent() : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneWheelEvent();
		}
		[SmokeMethod("QGraphicsSceneWheelEvent", "()", "")]
		private void NewQGraphicsSceneWheelEvent() {
			ProxyQGraphicsSceneWheelEvent().NewQGraphicsSceneWheelEvent();
		}
		[SmokeMethod("pos", "() const", "")]
		public QPointF Pos() {
			return ProxyQGraphicsSceneWheelEvent().Pos();
		}
		[SmokeMethod("setPos", "(const QPointF&)", "#")]
		public void SetPos(QPointF pos) {
			ProxyQGraphicsSceneWheelEvent().SetPos(pos);
		}
		[SmokeMethod("scenePos", "() const", "")]
		public QPointF ScenePos() {
			return ProxyQGraphicsSceneWheelEvent().ScenePos();
		}
		[SmokeMethod("setScenePos", "(const QPointF&)", "#")]
		public void SetScenePos(QPointF pos) {
			ProxyQGraphicsSceneWheelEvent().SetScenePos(pos);
		}
		[SmokeMethod("screenPos", "() const", "")]
		public QPoint ScreenPos() {
			return ProxyQGraphicsSceneWheelEvent().ScreenPos();
		}
		[SmokeMethod("setScreenPos", "(const QPoint&)", "#")]
		public void SetScreenPos(QPoint pos) {
			ProxyQGraphicsSceneWheelEvent().SetScreenPos(pos);
		}
		[SmokeMethod("buttons", "() const", "")]
		public int Buttons() {
			return ProxyQGraphicsSceneWheelEvent().Buttons();
		}
		[SmokeMethod("setButtons", "(Qt::MouseButtons)", "$")]
		public void SetButtons(int buttons) {
			ProxyQGraphicsSceneWheelEvent().SetButtons(buttons);
		}
		[SmokeMethod("modifiers", "() const", "")]
		public int Modifiers() {
			return ProxyQGraphicsSceneWheelEvent().Modifiers();
		}
		[SmokeMethod("setModifiers", "(Qt::KeyboardModifiers)", "$")]
		public void SetModifiers(int modifiers) {
			ProxyQGraphicsSceneWheelEvent().SetModifiers(modifiers);
		}
		[SmokeMethod("delta", "() const", "")]
		public int Delta() {
			return ProxyQGraphicsSceneWheelEvent().Delta();
		}
		[SmokeMethod("setDelta", "(int)", "$")]
		public void SetDelta(int delta) {
			ProxyQGraphicsSceneWheelEvent().SetDelta(delta);
		}
		~QGraphicsSceneWheelEvent() {
			DisposeQGraphicsSceneWheelEvent();
		}
		public new void Dispose() {
			DisposeQGraphicsSceneWheelEvent();
		}
		[SmokeMethod("~QGraphicsSceneWheelEvent", "()", "")]
		private void DisposeQGraphicsSceneWheelEvent() {
			ProxyQGraphicsSceneWheelEvent().DisposeQGraphicsSceneWheelEvent();
		}
	}
}
