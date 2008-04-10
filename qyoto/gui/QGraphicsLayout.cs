//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsLayout")]
	public abstract class QGraphicsLayout : QGraphicsLayoutItem {
 		protected QGraphicsLayout(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGraphicsLayout), this);
		}
		// QGraphicsLayout* QGraphicsLayout(QGraphicsLayoutPrivate& arg1,QGraphicsLayoutItem* arg2); >>>> NOT CONVERTED
		public QGraphicsLayout(QGraphicsLayoutItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsLayout#", "QGraphicsLayout(QGraphicsLayoutItem*)", typeof(void), typeof(QGraphicsLayoutItem), parent);
		}
		public QGraphicsLayout() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsLayout", "QGraphicsLayout()", typeof(void));
		}
		public void SetContentsMargins(double left, double top, double right, double bottom) {
			interceptor.Invoke("setContentsMargins$$$$", "setContentsMargins(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), left, typeof(double), top, typeof(double), right, typeof(double), bottom);
		}
		[SmokeMethod("getContentsMargins(qreal*, qreal*, qreal*, qreal*) const")]
		public override void GetContentsMargins(ref double left, ref double top, ref double right, ref double bottom) {
			StackItem[] stack = new StackItem[5];
			stack[1].s_double = left;
			stack[2].s_double = top;
			stack[3].s_double = right;
			stack[4].s_double = bottom;
			interceptor.Invoke("getContentsMargins$$$$", "getContentsMargins(qreal*, qreal*, qreal*, qreal*) const", stack);
			left = stack[1].s_double;
			top = stack[2].s_double;
			right = stack[3].s_double;
			bottom = stack[4].s_double;
			return;
		}
		public void Activate() {
			interceptor.Invoke("activate", "activate()", typeof(void));
		}
		public bool IsActivated() {
			return (bool) interceptor.Invoke("isActivated", "isActivated() const", typeof(bool));
		}
		[SmokeMethod("invalidate()")]
		public virtual void Invalidate() {
			interceptor.Invoke("invalidate", "invalidate()", typeof(void));
		}
		[SmokeMethod("widgetEvent(QEvent*)")]
		public virtual void WidgetEvent(QEvent e) {
			interceptor.Invoke("widgetEvent#", "widgetEvent(QEvent*)", typeof(void), typeof(QEvent), e);
		}
		[SmokeMethod("count() const")]
		public abstract int Count();
		[SmokeMethod("itemAt(int) const")]
		public abstract QGraphicsLayoutItem ItemAt(int i);
		[SmokeMethod("removeAt(int)")]
		public abstract void RemoveAt(int index);
	}
}