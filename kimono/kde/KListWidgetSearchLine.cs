//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  This class makes it easy to add a search line for filtering the items in a
	///  listwidget based on a simple text search.
	///  No changes to the application other than instantiating this class with an
	///  appropriate QListWidget should be needed.
	///  </remarks>		<short>    This class makes it easy to add a search line for filtering the items in a  listwidget based on a simple text search.</short>
	[SmokeClass("KListWidgetSearchLine")]
	public class KListWidgetSearchLine : KLineEdit, IDisposable {
 		protected KListWidgetSearchLine(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KListWidgetSearchLine), this);
		}
		/// <remarks>
		///  Constructs a KListWidgetSearchLine with \a listWidget being the QListWidget to
		///  be filtered.
		///  If \a listWidget is null then the widget will be disabled until a listWidget
		///  is set with setListWidget().
		///      </remarks>		<short>    Constructs a KListWidgetSearchLine with \a listWidget being the QListWidget to  be filtered.</short>
		public KListWidgetSearchLine(QWidget parent, QListWidget listWidget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KListWidgetSearchLine##", "KListWidgetSearchLine(QWidget*, QListWidget*)", typeof(void), typeof(QWidget), parent, typeof(QListWidget), listWidget);
		}
		public KListWidgetSearchLine(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KListWidgetSearchLine#", "KListWidgetSearchLine(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KListWidgetSearchLine() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KListWidgetSearchLine", "KListWidgetSearchLine()", typeof(void));
		}
		/// <remarks>
		///  Returns if the search is case sensitive.  This defaults to Qt.CaseInsensitive.
		/// </remarks>		<short>    Returns if the search is case sensitive.</short>
		/// 		<see> setCaseSensitive</see>
		public Qt.CaseSensitivity CaseSensitive() {
			return (Qt.CaseSensitivity) interceptor.Invoke("caseSensitive", "caseSensitive() const", typeof(Qt.CaseSensitivity));
		}
		/// <remarks>
		///  Returns the listWidget that is currently filtered by the search.
		/// </remarks>		<short>    Returns the listWidget that is currently filtered by the search.</short>
		/// 		<see> setListWidget</see>
		public QListWidget ListWidget() {
			return (QListWidget) interceptor.Invoke("listWidget", "listWidget() const", typeof(QListWidget));
		}
		/// <remarks>
		///  Updates search to only make visible the items that match \a s.  If
		///  \a s is null then the line edit's text will be used.
		///      </remarks>		<short>    Updates search to only make visible the items that match \a s.</short>
		[Q_SLOT("void updateSearch(const QString&)")]
		[SmokeMethod("updateSearch(const QString&)")]
		public virtual void UpdateSearch(string s) {
			interceptor.Invoke("updateSearch$", "updateSearch(const QString&)", typeof(void), typeof(string), s);
		}
		[Q_SLOT("void updateSearch()")]
		[SmokeMethod("updateSearch()")]
		public virtual void UpdateSearch() {
			interceptor.Invoke("updateSearch", "updateSearch()", typeof(void));
		}
		/// <remarks>
		///  Make the search case sensitive or case insensitive.
		/// </remarks>		<short>    Make the search case sensitive or case insensitive.</short>
		/// 		<see> caseSenstive</see>
		[Q_SLOT("void setCaseSensitivity(Qt::CaseSensitivity)")]
		public void SetCaseSensitivity(Qt.CaseSensitivity cs) {
			interceptor.Invoke("setCaseSensitivity$", "setCaseSensitivity(Qt::CaseSensitivity)", typeof(void), typeof(Qt.CaseSensitivity), cs);
		}
		/// <remarks>
		///  Sets the QListWidget that is filtered by this search line.  If \a lv is null
		///  then the widget will be disabled.
		/// </remarks>		<short>    Sets the QListWidget that is filtered by this search line.</short>
		/// 		<see> listWidget</see>
		[Q_SLOT("void setListWidget(QListWidget*)")]
		public void SetListWidget(QListWidget lv) {
			interceptor.Invoke("setListWidget#", "setListWidget(QListWidget*)", typeof(void), typeof(QListWidget), lv);
		}
		/// <remarks>
		///  Clear line edit and empty hiddenItems, returning elements to listWidget.
		///      </remarks>		<short>    Clear line edit and empty hiddenItems, returning elements to listWidget.</short>
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public override void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		/// <remarks>
		///  Returns true if \a item matches the search \a s.  This will be evaluated
		///  based on the value of caseSensitive().  This can be overridden in
		///  subclasses to implement more complicated matching schemes.
		///      </remarks>		<short>    Returns true if \a item matches the search \a s.</short>
		[SmokeMethod("itemMatches(const QListWidgetItem*, const QString&) const")]
		protected virtual bool ItemMatches(QListWidgetItem item, string s) {
			return (bool) interceptor.Invoke("itemMatches#$", "itemMatches(const QListWidgetItem*, const QString&) const", typeof(bool), typeof(QListWidgetItem), item, typeof(string), s);
		}
		/// <remarks>
		///  Re-implemented for internal reasons.  API not affected.
		///      </remarks>		<short>    Re-implemented for internal reasons.</short>
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		~KListWidgetSearchLine() {
			interceptor.Invoke("~KListWidgetSearchLine", "~KListWidgetSearchLine()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KListWidgetSearchLine", "~KListWidgetSearchLine()", typeof(void));
		}
		protected new IKListWidgetSearchLineSignals Emit {
			get { return (IKListWidgetSearchLineSignals) Q_EMIT; }
		}
	}

	public interface IKListWidgetSearchLineSignals : IKLineEditSignals {
	}
}