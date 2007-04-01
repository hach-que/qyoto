//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QContextMenuEvent")]
	public class QContextMenuEvent : QInputEvent, IDisposable {
 		protected QContextMenuEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QContextMenuEvent), "QContextMenuEvent", this);
		}
		public enum Reason {
			Mouse = 0,
			Keyboard = 1,
			Other = 2,
		}
		public QContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, QPoint globalPos) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QContextMenuEvent$##", "QContextMenuEvent(QContextMenuEvent::Reason, const QPoint&, const QPoint&)", typeof(void), typeof(QContextMenuEvent.Reason), reason, typeof(QPoint), pos, typeof(QPoint), globalPos);
		}
		public QContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QContextMenuEvent$#", "QContextMenuEvent(QContextMenuEvent::Reason, const QPoint&)", typeof(void), typeof(QContextMenuEvent.Reason), reason, typeof(QPoint), pos);
		}
		public int X() {
			return (int) interceptor.Invoke("x", "x() const", typeof(int));
		}
		public int Y() {
			return (int) interceptor.Invoke("y", "y() const", typeof(int));
		}
		public int GlobalX() {
			return (int) interceptor.Invoke("globalX", "globalX() const", typeof(int));
		}
		public int GlobalY() {
			return (int) interceptor.Invoke("globalY", "globalY() const", typeof(int));
		}
		public QPoint Pos() {
			return (QPoint) interceptor.Invoke("pos", "pos() const", typeof(QPoint));
		}
		public QPoint GlobalPos() {
			return (QPoint) interceptor.Invoke("globalPos", "globalPos() const", typeof(QPoint));
		}
		public QContextMenuEvent.Reason reason() {
			return (QContextMenuEvent.Reason) interceptor.Invoke("reason", "reason() const", typeof(QContextMenuEvent.Reason));
		}
		~QContextMenuEvent() {
			interceptor.Invoke("~QContextMenuEvent", "~QContextMenuEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QContextMenuEvent", "~QContextMenuEvent()", typeof(void));
		}
	}
}
