//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDragLeaveEvent")]
	public class QDragLeaveEvent : QEvent, IDisposable {
 		protected QDragLeaveEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDragLeaveEvent), this);
			interceptor = (QDragLeaveEvent) realProxy.GetTransparentProxy();
		}
		public QDragLeaveEvent() : this((Type) null) {
			CreateProxy();
			NewQDragLeaveEvent();
		}
		[SmokeMethod("QDragLeaveEvent", "()", "")]
		private void NewQDragLeaveEvent() {
			((QDragLeaveEvent) interceptor).NewQDragLeaveEvent();
		}
		~QDragLeaveEvent() {
			DisposeQDragLeaveEvent();
		}
		public new void Dispose() {
			DisposeQDragLeaveEvent();
		}
		[SmokeMethod("~QDragLeaveEvent", "()", "")]
		private void DisposeQDragLeaveEvent() {
			((QDragLeaveEvent) interceptor).DisposeQDragLeaveEvent();
		}
	}
}
