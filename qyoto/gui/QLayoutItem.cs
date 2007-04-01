//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	public interface IQLayoutItem {
		QSize SizeHint();
		QSize MinimumSize();
		QSize MaximumSize();
		int ExpandingDirections();
		void SetGeometry(QRect arg1);
		QRect Geometry();
		bool IsEmpty();
		bool HasHeightForWidth();
		int HeightForWidth(int arg1);
		int MinimumHeightForWidth(int arg1);
		void Invalidate();
		QWidget Widget();
		QLayout Layout();
		QSpacerItem SpacerItem();
		int Alignment();
		void SetAlignment(int a);
	}

	[SmokeClass("QLayoutItem")]
	public abstract class QLayoutItem : Object, IQLayoutItem {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QLayoutItem(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QLayoutItem), "QLayoutItem", this);
		}
		public QLayoutItem(int alignment) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLayoutItem$", "QLayoutItem(Qt::Alignment)", typeof(void), typeof(int), alignment);
		}
		public QLayoutItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLayoutItem", "QLayoutItem()", typeof(void));
		}
		[SmokeMethod("sizeHint() const")]
		public abstract QSize SizeHint();
		[SmokeMethod("minimumSize() const")]
		public abstract QSize MinimumSize();
		[SmokeMethod("maximumSize() const")]
		public abstract QSize MaximumSize();
		[SmokeMethod("expandingDirections() const")]
		public abstract int ExpandingDirections();
		[SmokeMethod("setGeometry(const QRect&)")]
		public abstract void SetGeometry(QRect arg1);
		[SmokeMethod("geometry() const")]
		public abstract QRect Geometry();
		[SmokeMethod("isEmpty() const")]
		public abstract bool IsEmpty();
		[SmokeMethod("hasHeightForWidth() const")]
		public virtual bool HasHeightForWidth() {
			return (bool) interceptor.Invoke("hasHeightForWidth", "hasHeightForWidth() const", typeof(bool));
		}
		[SmokeMethod("heightForWidth(int) const")]
		public virtual int HeightForWidth(int arg1) {
			return (int) interceptor.Invoke("heightForWidth$", "heightForWidth(int) const", typeof(int), typeof(int), arg1);
		}
		[SmokeMethod("minimumHeightForWidth(int) const")]
		public virtual int MinimumHeightForWidth(int arg1) {
			return (int) interceptor.Invoke("minimumHeightForWidth$", "minimumHeightForWidth(int) const", typeof(int), typeof(int), arg1);
		}
		[SmokeMethod("invalidate()")]
		public virtual void Invalidate() {
			interceptor.Invoke("invalidate", "invalidate()", typeof(void));
		}
		[SmokeMethod("widget()")]
		public virtual QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget()", typeof(QWidget));
		}
		[SmokeMethod("layout()")]
		public virtual QLayout Layout() {
			return (QLayout) interceptor.Invoke("layout", "layout()", typeof(QLayout));
		}
		[SmokeMethod("spacerItem()")]
		public virtual QSpacerItem SpacerItem() {
			return (QSpacerItem) interceptor.Invoke("spacerItem", "spacerItem()", typeof(QSpacerItem));
		}
		public int Alignment() {
			return (int) interceptor.Invoke("alignment", "alignment() const", typeof(int));
		}
		public void SetAlignment(int a) {
			interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), a);
		}
	}
}
