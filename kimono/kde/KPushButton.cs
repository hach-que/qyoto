//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  @brief A QPushButton with drag-support and KGuiItem support
	///  This is nothing but a QPushButton with drag-support and KGuiItem support.
	///  You must call #setDragEnabled (true) and override the method
	///  dragObject() to specify the QDragObject to be used.
	/// </remarks>		<author> Carsten Pfeiffer <pfeiffer@kde.org>
	///  </author>
	/// 		<short>    @brief A QPushButton with drag-support and KGuiItem support </short>

	[SmokeClass("KPushButton")]
	public class KPushButton : QPushButton, IDisposable {
 		protected KPushButton(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPushButton), this);
		}
		[Q_PROPERTY("bool", "isDragEnabled")]
		public bool IsDragEnabled {
			get { return (bool) interceptor.Invoke("isDragEnabled", "isDragEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setDragEnabled$", "setDragEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		/// <remarks>
		///  Default constructor.
		///      </remarks>		<short>    Default constructor.</short>
		public KPushButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton#", "KPushButton(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPushButton() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton", "KPushButton()", typeof(void));
		}
		/// <remarks>
		///  Constructor, that sets the button-text to <code>text</code>
		///      </remarks>		<short>    Constructor, that sets the button-text to <code>text</code>      </short>
		public KPushButton(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton$#", "KPushButton(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
		}
		public KPushButton(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton$", "KPushButton(const QString&)", typeof(void), typeof(string), text);
		}
		/// <remarks>
		///  Constructor, that sets an icon and the button-text to <code>text</code>
		///      </remarks>		<short>    Constructor, that sets an icon and the button-text to <code>text</code>      </short>
		public KPushButton(KIcon icon, string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton#$#", "KPushButton(const KIcon&, const QString&, QWidget*)", typeof(void), typeof(KIcon), icon, typeof(string), text, typeof(QWidget), parent);
		}
		public KPushButton(KIcon icon, string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton#$", "KPushButton(const KIcon&, const QString&)", typeof(void), typeof(KIcon), icon, typeof(string), text);
		}
		/// <remarks>
		///  Constructor that takes a KGuiItem for the text, the icon, the tooltip
		///  and the what's this help
		///      </remarks>		<short>    Constructor that takes a KGuiItem for the text, the icon, the tooltip  and the what's this help      </short>
		public KPushButton(KGuiItem item, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton##", "KPushButton(const KGuiItem&, QWidget*)", typeof(void), typeof(KGuiItem), item, typeof(QWidget), parent);
		}
		public KPushButton(KGuiItem item) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPushButton#", "KPushButton(const KGuiItem&)", typeof(void), typeof(KGuiItem), item);
		}
		/// <remarks>
		///  Sets the KGuiItem for this button.
		///      </remarks>		<short>    Sets the KGuiItem for this button.</short>
		public void SetGuiItem(KGuiItem item) {
			interceptor.Invoke("setGuiItem#", "setGuiItem(const KGuiItem&)", typeof(void), typeof(KGuiItem), item);
		}
		/// <remarks>
		///  Sets the standard KGuiItem for this button.
		///     </remarks>		<short>    Sets the standard KGuiItem for this button.</short>
		public void SetGuiItem(KStandardGuiItem.StandardItem item) {
			interceptor.Invoke("setGuiItem$", "setGuiItem(KStandardGuiItem::StandardItem)", typeof(void), typeof(KStandardGuiItem.StandardItem), item);
		}
		/// <remarks>
		///  Reads the standard KGuiItem for this button.
		///      </remarks>		<short>    Reads the standard KGuiItem for this button.</short>
		public KStandardGuiItem.StandardItem GuiItem() {
			return (KStandardGuiItem.StandardItem) interceptor.Invoke("guiItem", "guiItem() const", typeof(KStandardGuiItem.StandardItem));
		}
		/// <remarks>
		///  Sets the Icon Set for this button. It also takes into account hte
		///  KGlobalSettings.ShowIconsOnPushButtons() setting.
		///      </remarks>		<short>    Sets the Icon Set for this button.</short>
		public void SetIcon(KIcon icon) {
			interceptor.Invoke("setIcon#", "setIcon(const KIcon&)", typeof(void), typeof(KIcon), icon);
		}
		/// <remarks>
		///  Sets the text of the button
		///     </remarks>		<short>    Sets the text of the button     </short>
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		/// <remarks>
		///  Sets a delayed popup menu
		///  for consistency, since menu() isn't virtual
		///      </remarks>		<short>    Sets a delayed popup menu  for consistency, since menu() isn't virtual      </short>
		public void SetDelayedMenu(QMenu delayed_menu) {
			interceptor.Invoke("setDelayedMenu#", "setDelayedMenu(QMenu*)", typeof(void), typeof(QMenu), delayed_menu);
		}
		/// <remarks>
		///  returns a delayed popup menu
		///  since menu() isn't virtual
		///      </remarks>		<short>    returns a delayed popup menu  since menu() isn't virtual      </short>
		public QMenu DelayedMenu() {
			return (QMenu) interceptor.Invoke("delayedMenu", "delayedMenu()", typeof(QMenu));
		}
		/// <remarks>
		///  Reimplement this and return the QDrag object that should be used
		///  for the drag. Remember to give it "this" as parent.
		///  Default implementation returns 0, so that no drag is initiated.
		///      </remarks>		<short>    Reimplement this and return the QDrag object that should be used  for the drag.</short>
		[SmokeMethod("dragObject()")]
		protected virtual QDrag DragObject() {
			return (QDrag) interceptor.Invoke("dragObject", "dragObject()", typeof(QDrag));
		}
		/// <remarks>
		///  Reimplemented to add drag-support
		///      </remarks>		<short>    Reimplemented to add drag-support      </short>
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		/// <remarks>
		///  Reimplemented to add drag-support
		///      </remarks>		<short>    Reimplemented to add drag-support      </short>
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		/// <remarks>
		///  Starts a drag (dragCopy() by default) using dragObject()
		///      </remarks>		<short>    Starts a drag (dragCopy() by default) using dragObject()      </short>
		[SmokeMethod("startDrag()")]
		protected virtual void StartDrag() {
			interceptor.Invoke("startDrag", "startDrag()", typeof(void));
		}
		~KPushButton() {
			interceptor.Invoke("~KPushButton", "~KPushButton()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPushButton", "~KPushButton()", typeof(void));
		}
		protected new IKPushButtonSignals Emit {
			get { return (IKPushButtonSignals) Q_EMIT; }
		}
	}

	public interface IKPushButtonSignals : IQPushButtonSignals {
	}
}