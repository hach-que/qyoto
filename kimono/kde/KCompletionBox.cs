//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  A little utility class for "completion-widgets", like KLineEdit or
	///  KComboBox. KCompletionBox is a listbox, displayed as a rectangle without
	///  any window decoration, usually directly under the lineedit or combobox.
	///  It is filled with all possible matches for a completion, so the user
	///  can select the one he wants.
	///  It is used when KGlobalSettings.Completion == CompletionPopup or CompletionPopupAuto.
	///  See <see cref="IKCompletionBoxSignals"></see> for signals emitted by KCompletionBox
	/// </remarks>		<author> Carsten Pfeiffer <pfeiffer@kde.org>
	///  </author>
	/// 		<short> A helper widget for "completion-widgets" (KLineEdit, KComboBox)).</short>

	[SmokeClass("KCompletionBox")]
	public class KCompletionBox : KListWidget, IDisposable {
 		protected KCompletionBox(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KCompletionBox), this);
		}
		[Q_PROPERTY("bool", "isTabHandling")]
		public bool IsTabHandling {
			get { return (bool) interceptor.Invoke("isTabHandling", "isTabHandling()", typeof(bool)); }
			set { interceptor.Invoke("setTabHandling$", "setTabHandling(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "cancelledText")]
		public string CancelledText {
			get { return (string) interceptor.Invoke("cancelledText", "cancelledText()", typeof(string)); }
			set { interceptor.Invoke("setCancelledText$", "setCancelledText(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("bool", "activateOnSelect")]
		public bool ActivateOnSelect {
			get { return (bool) interceptor.Invoke("activateOnSelect", "activateOnSelect()", typeof(bool)); }
			set { interceptor.Invoke("setActivateOnSelect$", "setActivateOnSelect(bool)", typeof(void), typeof(bool), value); }
		}
		/// <remarks>
		///  Constructs a KCompletionBox.
		///  The parent widget is used to give the focus back when pressing the
		///  up-button on the very first item.
		///      </remarks>		<short>    Constructs a KCompletionBox.</short>
		public KCompletionBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCompletionBox#", "KCompletionBox(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KCompletionBox() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCompletionBox", "KCompletionBox()", typeof(void));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		/// <remarks>
		///  Returns a list of all items currently in the box.
		///      </remarks>		<short>    Returns a list of all items currently in the box.</short>
		[Q_SLOT("QStringList items() const")]
		public List<string> Items() {
			return (List<string>) interceptor.Invoke("items", "items() const", typeof(List<string>));
		}
		/// <remarks>
		///  Inserts <code>items</code> into the box. Does not clear the items before.
		///  <code>index</code> determines at which position <code>items</code> will be inserted.
		///  (defaults to appending them at the end)
		///      </remarks>		<short>    Inserts <code>items</code> into the box.</short>
		[Q_SLOT("void insertItems(const QStringList&, int)")]
		public void InsertItems(List<string> items, int index) {
			interceptor.Invoke("insertItems?$", "insertItems(const QStringList&, int)", typeof(void), typeof(List<string>), items, typeof(int), index);
		}
		[Q_SLOT("void insertItems(const QStringList&)")]
		public void InsertItems(List<string> items) {
			interceptor.Invoke("insertItems?", "insertItems(const QStringList&)", typeof(void), typeof(List<string>), items);
		}
		/// <remarks>
		///  Clears the box and inserts <code>items.</code>
		///      </remarks>		<short>    Clears the box and inserts <code>items.</code></short>
		[Q_SLOT("void setItems(const QStringList&)")]
		public void SetItems(List<string> items) {
			interceptor.Invoke("setItems?", "setItems(const QStringList&)", typeof(void), typeof(List<string>), items);
		}
		/// <remarks>
		///  Adjusts the size of the box to fit the width of the parent given in the
		///  constructor and pops it up at the most appropriate place, relative to
		///  the parent.
		///  Depending on the screensize and the position of the parent, this may
		///  be a different place, however the default is to pop it up and the
		///  lower left corner of the parent.
		///  Make sure to hide() the box when appropriate.
		///      </remarks>		<short>    Adjusts the size of the box to fit the width of the parent given in the  constructor and pops it up at the most appropriate place, relative to  the parent.</short>
		[Q_SLOT("void popup()")]
		[SmokeMethod("popup()")]
		public virtual void Popup() {
			interceptor.Invoke("popup", "popup()", typeof(void));
		}
		/// <remarks>
		///  Makes this widget (when visible) capture Tab-key events to traverse the
		///  items in the dropdown list.
		///  Default off, as it conflicts with the usual behavior of Tab to traverse
		///  widgets. It is useful for cases like Konqueror's Location Bar, though.
		/// </remarks>		<short>    Makes this widget (when visible) capture Tab-key events to traverse the  items in the dropdown list.</short>
		/// 		<see> isTabHandling</see>
		[Q_SLOT("void setTabHandling(bool)")]
		public void SetTabHandling(bool enable) {
			interceptor.Invoke("setTabHandling$", "setTabHandling(bool)", typeof(void), typeof(bool), enable);
		}
		/// <remarks>
		///  Default is false.
		/// </remarks>		<return> true if this widget is handling Tab-key events to traverse the
		///  items in the dropdown list, otherwise false.
		/// </return>
		/// 		<short>   </short>
		/// 		<see> setTabHandling</see>
		[Q_SLOT("bool isTabHandling() const")]
		public bool isTabHandling() {
			return (bool) interceptor.Invoke("isTabHandling", "isTabHandling() const", typeof(bool));
		}
		/// <remarks>
		///  Sets the text to be emitted if the user chooses not to
		///  pick from the available matches.
		///  If the canceled text is not set through this function, the
		///  userCancelled signal will not be emitted.
		/// <param> name="txt" the text to be emitted if the user cancels this box
		///      </param></remarks>		<short>    Sets the text to be emitted if the user chooses not to  pick from the available matches.</short>
		/// 		<see> userCancelled(</see>
		/// 		<see> const</see>
		[Q_SLOT("void setCancelledText(const QString&)")]
		public void SetCancelledText(string txt) {
			interceptor.Invoke("setCancelledText$", "setCancelledText(const QString&)", typeof(void), typeof(string), txt);
		}
		/// <remarks>
		/// </remarks>		<return> the text set via setCancelledText() or string().
		///      </return>
		/// 		<short>   </short>
		[Q_SLOT("QString cancelledText() const")]
		public string cancelledText() {
			return (string) interceptor.Invoke("cancelledText", "cancelledText() const", typeof(string));
		}
		/// <remarks>
		///  Set whether or not the selected signal should be emitted when an
		///  item is selected. By default the selected() signal is emitted.
		/// <param> name="state" false if the signal should not be emitted.
		///      </param></remarks>		<short>    Set whether or not the selected signal should be emitted when an  item is selected.</short>
		[Q_SLOT("void setActivateOnSelect(bool)")]
		public void SetActivateOnSelect(bool state) {
			interceptor.Invoke("setActivateOnSelect$", "setActivateOnSelect(bool)", typeof(void), typeof(bool), state);
		}
		/// <remarks>
		///  Moves the selection one line down or select the first item if nothing is selected yet.
		///      </remarks>		<short>    Moves the selection one line down or select the first item if nothing is selected yet.</short>
		[Q_SLOT("void down()")]
		public void Down() {
			interceptor.Invoke("down", "down()", typeof(void));
		}
		/// <remarks>
		///  Moves the selection one line up or select the first item if nothing is selected yet.
		///      </remarks>		<short>    Moves the selection one line up or select the first item if nothing is selected yet.</short>
		[Q_SLOT("void up()")]
		public void Up() {
			interceptor.Invoke("up", "up()", typeof(void));
		}
		/// <remarks>
		///  Moves the selection one page down.
		///      </remarks>		<short>    Moves the selection one page down.</short>
		[Q_SLOT("void pageDown()")]
		public void PageDown() {
			interceptor.Invoke("pageDown", "pageDown()", typeof(void));
		}
		/// <remarks>
		///  Moves the selection one page up.
		///      </remarks>		<short>    Moves the selection one page up.</short>
		[Q_SLOT("void pageUp()")]
		public void PageUp() {
			interceptor.Invoke("pageUp", "pageUp()", typeof(void));
		}
		/// <remarks>
		///  Moves the selection up to the first item.
		///      </remarks>		<short>    Moves the selection up to the first item.</short>
		[Q_SLOT("void home()")]
		public void Home() {
			interceptor.Invoke("home", "home()", typeof(void));
		}
		/// <remarks>
		///  Moves the selection down to the last item.
		///      </remarks>		<short>    Moves the selection down to the last item.</short>
		[Q_SLOT("void end()")]
		public void End() {
			interceptor.Invoke("end", "end()", typeof(void));
		}
		/// <remarks>
		///  Re-implemented for internal reasons.  API is unaffected.
		///      </remarks>		<short>    Re-implemented for internal reasons.</short>
		[Q_SLOT("void setVisible(bool)")]
		[SmokeMethod("setVisible(bool)")]
		public override void SetVisible(bool visible) {
			interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
		}
		/// <remarks>
		///  This calculates the size of the dropdown and the relative position of the top
		///  left corner with respect to the parent widget. This matches the geometry and position
		///  normally used by K/QComboBox when used with one.
		///      </remarks>		<short>    This calculates the size of the dropdown and the relative position of the top  left corner with respect to the parent widget.</short>
		protected QRect CalculateGeometry() {
			return (QRect) interceptor.Invoke("calculateGeometry", "calculateGeometry() const", typeof(QRect));
		}
		/// <remarks>
		///  This properly sizes and positions the listbox.
		///      </remarks>		<short>    This properly sizes and positions the listbox.</short>
		protected void SizeAndPosition() {
			interceptor.Invoke("sizeAndPosition", "sizeAndPosition()", typeof(void));
		}
		/// <remarks>
		///  Reimplemented from KListWidget to get events from the viewport (to hide
		///  this widget on mouse-click, Escape-presses, etc.
		///      </remarks>		<short>    Reimplemented from KListWidget to get events from the viewport (to hide  this widget on mouse-click, Escape-presses, etc.</short>
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		/// <remarks>
		///  Called when an item was activated. Emits
		///  activated() with the item.
		///      </remarks>		<short>    Called when an item was activated.</short>
		[Q_SLOT("void slotActivated(QListWidgetItem*)")]
		[SmokeMethod("slotActivated(QListWidgetItem*)")]
		protected virtual void SlotActivated(QListWidgetItem arg1) {
			interceptor.Invoke("slotActivated#", "slotActivated(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), arg1);
		}
		~KCompletionBox() {
			interceptor.Invoke("~KCompletionBox", "~KCompletionBox()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KCompletionBox", "~KCompletionBox()", typeof(void));
		}
		protected new IKCompletionBoxSignals Emit {
			get { return (IKCompletionBoxSignals) Q_EMIT; }
		}
	}

	public interface IKCompletionBoxSignals : IKListWidgetSignals {
		/// <remarks>
		///  Emitted when an item was selected, contains the text of
		///  the selected item.
		///      </remarks>		<short>    Emitted when an item was selected, contains the text of  the selected item.</short>
		[Q_SIGNAL("void activated(const QString&)")]
		void Activated(string arg1);
		/// <remarks>
		///  Emitted whenever the user chooses to ignore the available
		///  selections and close the this box.
		///      </remarks>		<short>    Emitted whenever the user chooses to ignore the available  selections and close the this box.</short>
		[Q_SIGNAL("void userCancelled(const QString&)")]
		void UserCancelled(string arg1);
	}
}