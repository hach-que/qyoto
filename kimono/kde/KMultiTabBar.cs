//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  A Widget for horizontal and vertical tabs.
	///  (Note that in Qt4, QTabBar can be vertical as well)
	///  It is possible to add normal buttons to the top/left
	///  The handling if only one tab at a time or multiple tabs
	///  should be raisable is left to the "user".
	/// </remarks>		<author> Joseph Wenninger
	///  </author>
	/// 		<short>    A Widget for horizontal and vertical tabs.</short>

	[SmokeClass("KMultiTabBar")]
	public class KMultiTabBar : QWidget, IDisposable {
 		protected KMultiTabBar(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KMultiTabBar), this);
		}
		public enum KMultiTabBarPosition {
			Left = 0,
			Right = 1,
			Top = 2,
			Bottom = 3,
		}
		/// <remarks>
		///  The list of available styles for KMultiTabBar
		///    - VSNET - Visual Studio .Net like, always shows icon, only show the text of active tabs
		///    - KDEV3ICON - Kdevelop 3 like, always shows the text and icons
		///      </remarks>		<short>    The list of available styles for KMultiTabBar    - VSNET - Visual Studio .</short>
		public enum KMultiTabBarStyle {
			VSNET = 0,
			KDEV3ICON = 2,
			STYLELAST = 0xffff,
		}
		public KMultiTabBar(KMultiTabBar.KMultiTabBarPosition pos, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMultiTabBar$#", "KMultiTabBar(KMultiTabBar::KMultiTabBarPosition, QWidget*)", typeof(void), typeof(KMultiTabBar.KMultiTabBarPosition), pos, typeof(QWidget), parent);
		}
		public KMultiTabBar(KMultiTabBar.KMultiTabBarPosition pos) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMultiTabBar$", "KMultiTabBar(KMultiTabBar::KMultiTabBarPosition)", typeof(void), typeof(KMultiTabBar.KMultiTabBarPosition), pos);
		}
		/// <remarks>
		///  append  a new button to the button area. The button can later on be accessed with button(ID)
		///  eg for connecting signals to it
		/// <param> name="pic" a pixmap for the button
		/// </param><param> name="id" an arbitraty ID value. It will be emitted in the clicked signal for identifying the button
		/// 	if more than one button is connected to a signals.
		/// </param><param> name="popup" A popup menu which should be displayed if the button is clicked
		/// </param><param> name="not_used_yet" will be used for a popup text in the future
		///      </param></remarks>		<short>    append  a new button to the button area.</short>
		public int AppendButton(QPixmap pic, int id, QMenu popup, string not_used_yet) {
			return (int) interceptor.Invoke("appendButton#$#$", "appendButton(const QPixmap&, int, QMenu*, const QString&)", typeof(int), typeof(QPixmap), pic, typeof(int), id, typeof(QMenu), popup, typeof(string), not_used_yet);
		}
		public int AppendButton(QPixmap pic, int id, QMenu popup) {
			return (int) interceptor.Invoke("appendButton#$#", "appendButton(const QPixmap&, int, QMenu*)", typeof(int), typeof(QPixmap), pic, typeof(int), id, typeof(QMenu), popup);
		}
		public int AppendButton(QPixmap pic, int id) {
			return (int) interceptor.Invoke("appendButton#$", "appendButton(const QPixmap&, int)", typeof(int), typeof(QPixmap), pic, typeof(int), id);
		}
		public int AppendButton(QPixmap pic) {
			return (int) interceptor.Invoke("appendButton#", "appendButton(const QPixmap&)", typeof(int), typeof(QPixmap), pic);
		}
		/// <remarks>
		///  remove a button with the given ID
		///      </remarks>		<short>    remove a button with the given ID      </short>
		public void RemoveButton(int id) {
			interceptor.Invoke("removeButton$", "removeButton(int)", typeof(void), typeof(int), id);
		}
		/// <remarks>
		///  append a new tab to the tab area. It can be accessed lateron with tabb(id);
		/// <param> name="pic" a bitmap for the tab
		/// </param><param> name="id" an arbitrary ID which can be used later on to identify the tab
		/// </param><param> name="text" if a mode with text is used it will be the tab text, otherwise a mouse over hint
		///      </param></remarks>		<short>    append a new tab to the tab area.</short>
		public int AppendTab(QPixmap pic, int id, string text) {
			return (int) interceptor.Invoke("appendTab#$$", "appendTab(const QPixmap&, int, const QString&)", typeof(int), typeof(QPixmap), pic, typeof(int), id, typeof(string), text);
		}
		public int AppendTab(QPixmap pic, int id) {
			return (int) interceptor.Invoke("appendTab#$", "appendTab(const QPixmap&, int)", typeof(int), typeof(QPixmap), pic, typeof(int), id);
		}
		public int AppendTab(QPixmap pic) {
			return (int) interceptor.Invoke("appendTab#", "appendTab(const QPixmap&)", typeof(int), typeof(QPixmap), pic);
		}
		/// <remarks>
		///  remove a tab with a given ID
		///      </remarks>		<short>    remove a tab with a given ID      </short>
		public void RemoveTab(int id) {
			interceptor.Invoke("removeTab$", "removeTab(int)", typeof(void), typeof(int), id);
		}
		/// <remarks>
		///  set a tab to "raised"
		/// <param> name="id" The ID of the tab to manipulate
		/// </param><param> name="state" true == activated/raised, false == not active
		///      </param></remarks>		<short>    set a tab to "raised" </short>
		public void SetTab(int id, bool state) {
			interceptor.Invoke("setTab$$", "setTab(int, bool)", typeof(void), typeof(int), id, typeof(bool), state);
		}
		/// <remarks>
		///  return the state of a tab, identified by its ID
		///      </remarks>		<short>    return the state of a tab, identified by its ID      </short>
		public bool IsTabRaised(int id) {
			return (bool) interceptor.Invoke("isTabRaised$", "isTabRaised(int) const", typeof(bool), typeof(int), id);
		}
		/// <remarks>
		///  get a pointer to a button within the button area identified by its ID
		///      </remarks>		<short>    get a pointer to a button within the button area identified by its ID      </short>
		public KMultiTabBarButton Button(int id) {
			return (KMultiTabBarButton) interceptor.Invoke("button$", "button(int) const", typeof(KMultiTabBarButton), typeof(int), id);
		}
		/// <remarks>
		///  get a pointer to a tab within the tab area, identiifed by its ID
		///      </remarks>		<short>    get a pointer to a tab within the tab area, identiifed by its ID      </short>
		public KMultiTabBarTab Tab(int id) {
			return (KMultiTabBarTab) interceptor.Invoke("tab$", "tab(int) const", typeof(KMultiTabBarTab), typeof(int), id);
		}
		/// <remarks>
		///  set the real position of the widget.
		/// <param> name="pos" if the mode is horizontal, only use top, bottom, if it is vertical use left or right
		///      </param></remarks>		<short>    set the real position of the widget.</short>
		public void SetPosition(KMultiTabBar.KMultiTabBarPosition pos) {
			interceptor.Invoke("setPosition$", "setPosition(KMultiTabBar::KMultiTabBarPosition)", typeof(void), typeof(KMultiTabBar.KMultiTabBarPosition), pos);
		}
		/// <remarks>
		///  get the tabbar position.
		/// </remarks>		<return> position
		///      </return>
		/// 		<short>    get the tabbar position.</short>
		public KMultiTabBar.KMultiTabBarPosition Position() {
			return (KMultiTabBar.KMultiTabBarPosition) interceptor.Invoke("position", "position() const", typeof(KMultiTabBar.KMultiTabBarPosition));
		}
		/// <remarks>
		///  set the display style of the tabs
		///      </remarks>		<short>    set the display style of the tabs      </short>
		public void SetStyle(KMultiTabBar.KMultiTabBarStyle style) {
			interceptor.Invoke("setStyle$", "setStyle(KMultiTabBar::KMultiTabBarStyle)", typeof(void), typeof(KMultiTabBar.KMultiTabBarStyle), style);
		}
		/// <remarks>
		///  get the display style of the tabs
		/// </remarks>		<return> display style
		///      </return>
		/// 		<short>    get the display style of the tabs </short>
		public KMultiTabBar.KMultiTabBarStyle TabStyle() {
			return (KMultiTabBar.KMultiTabBarStyle) interceptor.Invoke("tabStyle", "tabStyle() const", typeof(KMultiTabBar.KMultiTabBarStyle));
		}
		[SmokeMethod("fontChange(const QFont&)")]
		protected override void FontChange(QFont arg1) {
			interceptor.Invoke("fontChange#", "fontChange(const QFont&)", typeof(void), typeof(QFont), arg1);
		}
		protected void UpdateSeparator() {
			interceptor.Invoke("updateSeparator", "updateSeparator()", typeof(void));
		}
		~KMultiTabBar() {
			interceptor.Invoke("~KMultiTabBar", "~KMultiTabBar()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KMultiTabBar", "~KMultiTabBar()", typeof(void));
		}
		protected new IKMultiTabBarSignals Emit {
			get { return (IKMultiTabBarSignals) Q_EMIT; }
		}
	}

	public interface IKMultiTabBarSignals : IQWidgetSignals {
	}
}
