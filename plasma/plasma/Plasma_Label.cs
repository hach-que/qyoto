//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	[SmokeClass("Plasma::Label")]
	public class Label : QGraphicsProxyWidget, IDisposable {
 		protected Label(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Label), this);
		}
		[Q_PROPERTY("QGraphicsWidget*", "parentWidget")]
		public QGraphicsWidget ParentWidget {
			get { return (QGraphicsWidget) interceptor.Invoke("parentWidget", "parentWidget()", typeof(QGraphicsWidget)); }
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
			set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "image")]
		public string Image {
			get { return (string) interceptor.Invoke("image", "image()", typeof(string)); }
			set { interceptor.Invoke("setImage$", "setImage(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "styleSheet")]
		public string StyleSheet {
			get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
			set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QLabel*", "nativeWidget")]
		public QLabel NativeWidget {
			get { return (QLabel) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(QLabel)); }
		}
		public Label(QGraphicsWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Label#", "Label(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
		}
		public Label() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Label", "Label()", typeof(void));
		}
		[SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
		protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
		}
		~Label() {
			interceptor.Invoke("~Label", "~Label()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Label", "~Label()", typeof(void));
		}
		protected new ILabelSignals Emit {
			get { return (ILabelSignals) Q_EMIT; }
		}
	}

	public interface ILabelSignals : IQGraphicsProxyWidgetSignals {
	}
}
