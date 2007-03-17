//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QShortcutEvent")]
	public class QShortcutEvent : QEvent, IDisposable {
 		protected QShortcutEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QShortcutEvent), this);
			interceptor = (QShortcutEvent) realProxy.GetTransparentProxy();
		}
		public QShortcutEvent(QKeySequence key, int id, bool ambiguous) : this((Type) null) {
			CreateProxy();
			NewQShortcutEvent(key,id,ambiguous);
		}
		[SmokeMethod("QShortcutEvent", "(const QKeySequence&, int, bool)", "#$$")]
		private void NewQShortcutEvent(QKeySequence key, int id, bool ambiguous) {
			((QShortcutEvent) interceptor).NewQShortcutEvent(key,id,ambiguous);
		}
		public QShortcutEvent(QKeySequence key, int id) : this((Type) null) {
			CreateProxy();
			NewQShortcutEvent(key,id);
		}
		[SmokeMethod("QShortcutEvent", "(const QKeySequence&, int)", "#$")]
		private void NewQShortcutEvent(QKeySequence key, int id) {
			((QShortcutEvent) interceptor).NewQShortcutEvent(key,id);
		}
		[SmokeMethod("key", "()", "")]
		public QKeySequence Key() {
			return ((QShortcutEvent) interceptor).Key();
		}
		[SmokeMethod("shortcutId", "()", "")]
		public int ShortcutId() {
			return ((QShortcutEvent) interceptor).ShortcutId();
		}
		[SmokeMethod("isAmbiguous", "()", "")]
		public bool IsAmbiguous() {
			return ((QShortcutEvent) interceptor).IsAmbiguous();
		}
		~QShortcutEvent() {
			DisposeQShortcutEvent();
		}
		public new void Dispose() {
			DisposeQShortcutEvent();
		}
		[SmokeMethod("~QShortcutEvent", "()", "")]
		private void DisposeQShortcutEvent() {
			((QShortcutEvent) interceptor).DisposeQShortcutEvent();
		}
	}
}
