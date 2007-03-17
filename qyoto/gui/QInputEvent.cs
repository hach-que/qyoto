//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QInputEvent")]
	public class QInputEvent : QEvent, IDisposable {
 		protected QInputEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QInputEvent), this);
			interceptor = (QInputEvent) realProxy.GetTransparentProxy();
		}
		public QInputEvent(QEvent.TypeOf type, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQInputEvent(type,modifiers);
		}
		[SmokeMethod("QInputEvent", "(QEvent::Type, Qt::KeyboardModifiers)", "$$")]
		private void NewQInputEvent(QEvent.TypeOf type, int modifiers) {
			((QInputEvent) interceptor).NewQInputEvent(type,modifiers);
		}
		public QInputEvent(QEvent.TypeOf type) : this((Type) null) {
			CreateProxy();
			NewQInputEvent(type);
		}
		[SmokeMethod("QInputEvent", "(QEvent::Type)", "$")]
		private void NewQInputEvent(QEvent.TypeOf type) {
			((QInputEvent) interceptor).NewQInputEvent(type);
		}
		[SmokeMethod("modifiers", "() const", "")]
		public int Modifiers() {
			return ((QInputEvent) interceptor).Modifiers();
		}
		~QInputEvent() {
			DisposeQInputEvent();
		}
		public new void Dispose() {
			DisposeQInputEvent();
		}
		[SmokeMethod("~QInputEvent", "()", "")]
		private void DisposeQInputEvent() {
			((QInputEvent) interceptor).DisposeQInputEvent();
		}
	}
}
