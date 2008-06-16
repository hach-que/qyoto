//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks> See <see cref="IComboBoxSignals"></see> for signals emitted by ComboBox
	/// </remarks>
	[SmokeClass("Plasma::ComboBox")]
	public class ComboBox : QGraphicsProxyWidget, IDisposable {
 		protected ComboBox(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(ComboBox), this);
		}
		[Q_PROPERTY("QGraphicsWidget*", "parentWidget")]
		public QGraphicsWidget ParentWidget {
			get { return (QGraphicsWidget) interceptor.Invoke("parentWidget", "parentWidget()", typeof(QGraphicsWidget)); }
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
		}
		[Q_PROPERTY("QString", "stylesheet")]
		public string Stylesheet {
			get { return (string) interceptor.Invoke("stylesheet", "stylesheet()", typeof(string)); }
			set { interceptor.Invoke("setStylesheet$", "setStylesheet(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QComboBox*", "nativeWidget")]
		public QComboBox NativeWidget {
			get { return (QComboBox) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(QComboBox)); }
		}
		public ComboBox(QGraphicsWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("ComboBox#", "ComboBox(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
		}
		public ComboBox() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("ComboBox", "ComboBox()", typeof(void));
		}
		/// <remarks>
		///  Adds an item to the combobox with the given text. The
		///  item is appended to the list of existing items.
		///      </remarks>		<short>    Adds an item to the combobox with the given text.</short>
		public void AddItem(string text) {
			interceptor.Invoke("addItem$", "addItem(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void clear()")]
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
		protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
		}
		~ComboBox() {
			interceptor.Invoke("~ComboBox", "~ComboBox()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~ComboBox", "~ComboBox()", typeof(void));
		}
		protected new IComboBoxSignals Emit {
			get { return (IComboBoxSignals) Q_EMIT; }
		}
	}

	public interface IComboBoxSignals : IQGraphicsProxyWidgetSignals {
		[Q_SIGNAL("void activated(const QString&)")]
		void Activated(string text);
	}
}
