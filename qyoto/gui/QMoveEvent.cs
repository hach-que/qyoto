//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QMoveEvent")]
	public class QMoveEvent : QEvent, IDisposable {
 		protected QMoveEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QMoveEvent), "QMoveEvent", this);
		}
		public QMoveEvent(QPoint pos, QPoint oldPos) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMoveEvent##", "QMoveEvent(const QPoint&, const QPoint&)", typeof(void), typeof(QPoint), pos, typeof(QPoint), oldPos);
		}
		public QPoint Pos() {
			return (QPoint) interceptor.Invoke("pos", "pos() const", typeof(QPoint));
		}
		public QPoint OldPos() {
			return (QPoint) interceptor.Invoke("oldPos", "oldPos() const", typeof(QPoint));
		}
		~QMoveEvent() {
			interceptor.Invoke("~QMoveEvent", "~QMoveEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QMoveEvent", "~QMoveEvent()", typeof(void));
		}
	}
}
