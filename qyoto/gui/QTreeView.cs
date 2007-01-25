//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQTreeViewSignals"></see> for signals emitted by QTreeView
	[SmokeClass("QTreeView")]
	public class QTreeView : QAbstractItemView, IDisposable {
 		protected QTreeView(Type dummy) : base((Type) null) {}
		interface IQTreeViewProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTreeView), this);
			_interceptor = (QTreeView) realProxy.GetTransparentProxy();
		}
		private QTreeView ProxyQTreeView() {
			return (QTreeView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTreeView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTreeViewProxy), null);
			_staticInterceptor = (IQTreeViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQTreeViewProxy StaticQTreeView() {
			return (IQTreeViewProxy) _staticInterceptor;
		}

		public int Indentation {
			get {
				return Property("indentation").Value<int>();
			}
			set {
				SetProperty("indentation", QVariant.FromValue<int>(value));
			}
		}
		public bool RootIsDecorated {
			get {
				return Property("rootIsDecorated").Value<bool>();
			}
			set {
				SetProperty("rootIsDecorated", QVariant.FromValue<bool>(value));
			}
		}
		public bool UniformRowHeights {
			get {
				return Property("uniformRowHeights").Value<bool>();
			}
			set {
				SetProperty("uniformRowHeights", QVariant.FromValue<bool>(value));
			}
		}
		public bool ItemsExpandable {
			get {
				return Property("itemsExpandable").Value<bool>();
			}
			set {
				SetProperty("itemsExpandable", QVariant.FromValue<bool>(value));
			}
		}
		public bool SortingEnabled {
			get {
				return Property("sortingEnabled").Value<bool>();
			}
			set {
				SetProperty("sortingEnabled", QVariant.FromValue<bool>(value));
			}
		}
		public bool Animated {
			get {
				return Property("animated").Value<bool>();
			}
			set {
				SetProperty("animated", QVariant.FromValue<bool>(value));
			}
		}
		public bool AllColumnsShowFocus {
			get {
				return Property("allColumnsShowFocus").Value<bool>();
			}
			set {
				SetProperty("allColumnsShowFocus", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTreeView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTreeView(parent);
		}
		[SmokeMethod("QTreeView(QWidget*)")]
		private void NewQTreeView(QWidget parent) {
			ProxyQTreeView().NewQTreeView(parent);
		}
		public QTreeView() : this((Type) null) {
			CreateProxy();
			NewQTreeView();
		}
		[SmokeMethod("QTreeView()")]
		private void NewQTreeView() {
			ProxyQTreeView().NewQTreeView();
		}
		[SmokeMethod("setModel(QAbstractItemModel*)")]
		public new void SetModel(QAbstractItemModel model) {
			ProxyQTreeView().SetModel(model);
		}
		[SmokeMethod("setRootIndex(const QModelIndex&)")]
		public new void SetRootIndex(QModelIndex index) {
			ProxyQTreeView().SetRootIndex(index);
		}
		[SmokeMethod("setSelectionModel(QItemSelectionModel*)")]
		public new void SetSelectionModel(QItemSelectionModel selectionModel) {
			ProxyQTreeView().SetSelectionModel(selectionModel);
		}
		[SmokeMethod("header() const")]
		public QHeaderView Header() {
			return ProxyQTreeView().Header();
		}
		[SmokeMethod("setHeader(QHeaderView*)")]
		public void SetHeader(QHeaderView header) {
			ProxyQTreeView().SetHeader(header);
		}
		[SmokeMethod("columnViewportPosition(int) const")]
		public int ColumnViewportPosition(int column) {
			return ProxyQTreeView().ColumnViewportPosition(column);
		}
		[SmokeMethod("columnWidth(int) const")]
		public int ColumnWidth(int column) {
			return ProxyQTreeView().ColumnWidth(column);
		}
		[SmokeMethod("setColumnWidth(int, int)")]
		public void SetColumnWidth(int column, int width) {
			ProxyQTreeView().SetColumnWidth(column,width);
		}
		[SmokeMethod("columnAt(int) const")]
		public int ColumnAt(int x) {
			return ProxyQTreeView().ColumnAt(x);
		}
		[SmokeMethod("isColumnHidden(int) const")]
		public bool IsColumnHidden(int column) {
			return ProxyQTreeView().IsColumnHidden(column);
		}
		[SmokeMethod("setColumnHidden(int, bool)")]
		public void SetColumnHidden(int column, bool hide) {
			ProxyQTreeView().SetColumnHidden(column,hide);
		}
		[SmokeMethod("isRowHidden(int, const QModelIndex&) const")]
		public bool IsRowHidden(int row, QModelIndex parent) {
			return ProxyQTreeView().IsRowHidden(row,parent);
		}
		[SmokeMethod("setRowHidden(int, const QModelIndex&, bool)")]
		public void SetRowHidden(int row, QModelIndex parent, bool hide) {
			ProxyQTreeView().SetRowHidden(row,parent,hide);
		}
		[SmokeMethod("isExpanded(const QModelIndex&) const")]
		public bool IsExpanded(QModelIndex index) {
			return ProxyQTreeView().IsExpanded(index);
		}
		[SmokeMethod("setExpanded(const QModelIndex&, bool)")]
		public void SetExpanded(QModelIndex index, bool expand) {
			ProxyQTreeView().SetExpanded(index,expand);
		}
		[SmokeMethod("isSortingEnabled() const")]
		public bool IsSortingEnabled() {
			return ProxyQTreeView().IsSortingEnabled();
		}
		[SmokeMethod("isAnimated() const")]
		public bool IsAnimated() {
			return ProxyQTreeView().IsAnimated();
		}
		[SmokeMethod("keyboardSearch(const QString&)")]
		public new void KeyboardSearch(string search) {
			ProxyQTreeView().KeyboardSearch(search);
		}
		[SmokeMethod("visualRect(const QModelIndex&) const")]
		public new QRect VisualRect(QModelIndex index) {
			return ProxyQTreeView().VisualRect(index);
		}
		[SmokeMethod("scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)")]
		public new void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			ProxyQTreeView().ScrollTo(index,hint);
		}
		[SmokeMethod("scrollTo(const QModelIndex&)")]
		public new void ScrollTo(QModelIndex index) {
			ProxyQTreeView().ScrollTo(index);
		}
		[SmokeMethod("indexAt(const QPoint&) const")]
		public new QModelIndex IndexAt(QPoint p) {
			return ProxyQTreeView().IndexAt(p);
		}
		[SmokeMethod("indexAbove(const QModelIndex&) const")]
		public QModelIndex IndexAbove(QModelIndex index) {
			return ProxyQTreeView().IndexAbove(index);
		}
		[SmokeMethod("indexBelow(const QModelIndex&) const")]
		public QModelIndex IndexBelow(QModelIndex index) {
			return ProxyQTreeView().IndexBelow(index);
		}
		[SmokeMethod("doItemsLayout()")]
		public new void DoItemsLayout() {
			ProxyQTreeView().DoItemsLayout();
		}
		[SmokeMethod("reset()")]
		public new void Reset() {
			ProxyQTreeView().Reset();
		}
		[SmokeMethod("sortByColumn(int, Qt::SortOrder)")]
		public void SortByColumn(int column, Qt.SortOrder order) {
			ProxyQTreeView().SortByColumn(column,order);
		}
		[SmokeMethod("dataChanged(const QModelIndex&, const QModelIndex&)")]
		public new void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			ProxyQTreeView().DataChanged(topLeft,bottomRight);
		}
		[SmokeMethod("hideColumn(int)")]
		public void HideColumn(int column) {
			ProxyQTreeView().HideColumn(column);
		}
		[SmokeMethod("showColumn(int)")]
		public void ShowColumn(int column) {
			ProxyQTreeView().ShowColumn(column);
		}
		[SmokeMethod("expand(const QModelIndex&)")]
		public void Expand(QModelIndex index) {
			ProxyQTreeView().Expand(index);
		}
		[SmokeMethod("collapse(const QModelIndex&)")]
		public void Collapse(QModelIndex index) {
			ProxyQTreeView().Collapse(index);
		}
		[SmokeMethod("resizeColumnToContents(int)")]
		public void ResizeColumnToContents(int column) {
			ProxyQTreeView().ResizeColumnToContents(column);
		}
		[SmokeMethod("sortByColumn(int)")]
		public void SortByColumn(int column) {
			ProxyQTreeView().SortByColumn(column);
		}
		[SmokeMethod("selectAll()")]
		public new void SelectAll() {
			ProxyQTreeView().SelectAll();
		}
		[SmokeMethod("expandAll()")]
		public void ExpandAll() {
			ProxyQTreeView().ExpandAll();
		}
		[SmokeMethod("collapseAll()")]
		public void CollapseAll() {
			ProxyQTreeView().CollapseAll();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTreeView().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTreeView().Tr(s);
		}
		[SmokeMethod("columnResized(int, int, int)")]
		protected void ColumnResized(int column, int oldSize, int newSize) {
			ProxyQTreeView().ColumnResized(column,oldSize,newSize);
		}
		[SmokeMethod("columnCountChanged(int, int)")]
		protected void ColumnCountChanged(int oldCount, int newCount) {
			ProxyQTreeView().ColumnCountChanged(oldCount,newCount);
		}
		[SmokeMethod("columnMoved()")]
		protected void ColumnMoved() {
			ProxyQTreeView().ColumnMoved();
		}
		[SmokeMethod("reexpand()")]
		protected void Reexpand() {
			ProxyQTreeView().Reexpand();
		}
		[SmokeMethod("rowsRemoved(const QModelIndex&, int, int)")]
		protected void RowsRemoved(QModelIndex parent, int first, int last) {
			ProxyQTreeView().RowsRemoved(parent,first,last);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected new void ScrollContentsBy(int dx, int dy) {
			ProxyQTreeView().ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("rowsInserted(const QModelIndex&, int, int)")]
		protected new void RowsInserted(QModelIndex parent, int start, int end) {
			ProxyQTreeView().RowsInserted(parent,start,end);
		}
		[SmokeMethod("rowsAboutToBeRemoved(const QModelIndex&, int, int)")]
		protected new void RowsAboutToBeRemoved(QModelIndex parent, int start, int end) {
			ProxyQTreeView().RowsAboutToBeRemoved(parent,start,end);
		}
		[SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected new QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, int modifiers) {
			return ProxyQTreeView().MoveCursor(cursorAction,modifiers);
		}
		[SmokeMethod("horizontalOffset() const")]
		protected new int HorizontalOffset() {
			return ProxyQTreeView().HorizontalOffset();
		}
		[SmokeMethod("verticalOffset() const")]
		protected new int VerticalOffset() {
			return ProxyQTreeView().VerticalOffset();
		}
		[SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected new void SetSelection(QRect rect, int command) {
			ProxyQTreeView().SetSelection(rect,command);
		}
		[SmokeMethod("visualRegionForSelection(const QItemSelection&) const")]
		protected new QRegion VisualRegionForSelection(QItemSelection selection) {
			return ProxyQTreeView().VisualRegionForSelection(selection);
		}
		[SmokeMethod("selectedIndexes() const")]
		protected new List<QModelIndex> SelectedIndexes() {
			return ProxyQTreeView().SelectedIndexes();
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQTreeView().TimerEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQTreeView().PaintEvent(arg1);
		}
		[SmokeMethod("drawTree(QPainter*, const QRegion&) const")]
		protected void DrawTree(QPainter painter, QRegion region) {
			ProxyQTreeView().DrawTree(painter,region);
		}
		[SmokeMethod("drawRow(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		protected virtual void DrawRow(QPainter painter, QStyleOptionViewItem options, QModelIndex index) {
			ProxyQTreeView().DrawRow(painter,options,index);
		}
		[SmokeMethod("drawBranches(QPainter*, const QRect&, const QModelIndex&) const")]
		protected virtual void DrawBranches(QPainter painter, QRect rect, QModelIndex index) {
			ProxyQTreeView().DrawBranches(painter,rect,index);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQTreeView().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQTreeView().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected new void MouseDoubleClickEvent(QMouseEvent arg1) {
			ProxyQTreeView().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQTreeView().MouseMoveEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQTreeView().KeyPressEvent(arg1);
		}
		[SmokeMethod("updateGeometries()")]
		protected new void UpdateGeometries() {
			ProxyQTreeView().UpdateGeometries();
		}
		[SmokeMethod("sizeHintForColumn(int) const")]
		protected new int SizeHintForColumn(int column) {
			return ProxyQTreeView().SizeHintForColumn(column);
		}
		[SmokeMethod("indexRowSizeHint(const QModelIndex&) const")]
		protected int IndexRowSizeHint(QModelIndex index) {
			return ProxyQTreeView().IndexRowSizeHint(index);
		}
		[SmokeMethod("horizontalScrollbarAction(int)")]
		protected new void HorizontalScrollbarAction(int action) {
			ProxyQTreeView().HorizontalScrollbarAction(action);
		}
		[SmokeMethod("isIndexHidden(const QModelIndex&) const")]
		protected new bool IsIndexHidden(QModelIndex index) {
			return ProxyQTreeView().IsIndexHidden(index);
		}
		~QTreeView() {
			DisposeQTreeView();
		}
		public new void Dispose() {
			DisposeQTreeView();
		}
		[SmokeMethod("~QTreeView()")]
		private void DisposeQTreeView() {
			ProxyQTreeView().DisposeQTreeView();
		}
		protected new IQTreeViewSignals Emit {
			get {
				return (IQTreeViewSignals) Q_EMIT;
			}
		}
	}

	public interface IQTreeViewSignals : IQAbstractItemViewSignals {
		[Q_SIGNAL("void expanded(const QModelIndex&)")]
		void Expanded(QModelIndex index);
		[Q_SIGNAL("void collapsed(const QModelIndex&)")]
		void Collapsed(QModelIndex index);
	}
}
