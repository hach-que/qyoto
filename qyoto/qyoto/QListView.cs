//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Collections;
	using System.Text;

	[SmokeClass("QListView")]
	public class QListView : QAbstractItemView, IDisposable {
 		protected QListView(Type dummy) : base((Type) null) {}
		interface IQListViewProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QListView), this);
			_interceptor = (QListView) realProxy.GetTransparentProxy();
		}
		private QListView ProxyQListView() {
			return (QListView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QListView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQListViewProxy), null);
			_staticInterceptor = (IQListViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQListViewProxy StaticQListView() {
			return (IQListViewProxy) _staticInterceptor;
		}

		public enum Movement {
			Static = 0,
			Free = 1,
			Snap = 2,
		}
		public enum Flow {
			LeftToRight = 0,
			TopToBottom = 1,
		}
		public enum ResizeMode {
			Fixed = 0,
			Adjust = 1,
		}
		public enum LayoutMode {
			SinglePass = 0,
			Batched = 1,
		}
		public enum ViewMode {
			ListMode = 0,
			IconMode = 1,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QListView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQListView(parent);
		}
		[SmokeMethod("QListView(QWidget*)")]
		private void NewQListView(QWidget parent) {
			ProxyQListView().NewQListView(parent);
		}
		public QListView() : this((Type) null) {
			CreateProxy();
			NewQListView();
		}
		[SmokeMethod("QListView()")]
		private void NewQListView() {
			ProxyQListView().NewQListView();
		}
		[SmokeMethod("setMovement(QListView::Movement)")]
		public void SetMovement(QListView.Movement movement) {
			ProxyQListView().SetMovement(movement);
		}
		[SmokeMethod("movement() const")]
		public QListView.Movement movement() {
			return ProxyQListView().movement();
		}
		[SmokeMethod("setFlow(QListView::Flow)")]
		public void SetFlow(QListView.Flow flow) {
			ProxyQListView().SetFlow(flow);
		}
		[SmokeMethod("flow() const")]
		public QListView.Flow flow() {
			return ProxyQListView().flow();
		}
		[SmokeMethod("setWrapping(bool)")]
		public void SetWrapping(bool enable) {
			ProxyQListView().SetWrapping(enable);
		}
		[SmokeMethod("isWrapping() const")]
		public bool IsWrapping() {
			return ProxyQListView().IsWrapping();
		}
		[SmokeMethod("setResizeMode(QListView::ResizeMode)")]
		public void SetResizeMode(QListView.ResizeMode mode) {
			ProxyQListView().SetResizeMode(mode);
		}
		[SmokeMethod("resizeMode() const")]
		public QListView.ResizeMode resizeMode() {
			return ProxyQListView().resizeMode();
		}
		[SmokeMethod("setLayoutMode(QListView::LayoutMode)")]
		public void SetLayoutMode(QListView.LayoutMode mode) {
			ProxyQListView().SetLayoutMode(mode);
		}
		[SmokeMethod("layoutMode() const")]
		public QListView.LayoutMode layoutMode() {
			return ProxyQListView().layoutMode();
		}
		[SmokeMethod("setSpacing(int)")]
		public void SetSpacing(int space) {
			ProxyQListView().SetSpacing(space);
		}
		[SmokeMethod("spacing() const")]
		public int Spacing() {
			return ProxyQListView().Spacing();
		}
		[SmokeMethod("setGridSize(const QSize&)")]
		public void SetGridSize(QSize size) {
			ProxyQListView().SetGridSize(size);
		}
		[SmokeMethod("gridSize() const")]
		public QSize GridSize() {
			return ProxyQListView().GridSize();
		}
		[SmokeMethod("setViewMode(QListView::ViewMode)")]
		public void SetViewMode(QListView.ViewMode mode) {
			ProxyQListView().SetViewMode(mode);
		}
		[SmokeMethod("viewMode() const")]
		public QListView.ViewMode viewMode() {
			return ProxyQListView().viewMode();
		}
		[SmokeMethod("clearPropertyFlags()")]
		public void ClearPropertyFlags() {
			ProxyQListView().ClearPropertyFlags();
		}
		[SmokeMethod("isRowHidden(int) const")]
		public bool IsRowHidden(int row) {
			return ProxyQListView().IsRowHidden(row);
		}
		[SmokeMethod("setRowHidden(int, bool)")]
		public void SetRowHidden(int row, bool hide) {
			ProxyQListView().SetRowHidden(row,hide);
		}
		[SmokeMethod("setModelColumn(int)")]
		public void SetModelColumn(int column) {
			ProxyQListView().SetModelColumn(column);
		}
		[SmokeMethod("modelColumn() const")]
		public int ModelColumn() {
			return ProxyQListView().ModelColumn();
		}
		[SmokeMethod("setUniformItemSizes(bool)")]
		public void SetUniformItemSizes(bool enable) {
			ProxyQListView().SetUniformItemSizes(enable);
		}
		[SmokeMethod("uniformItemSizes() const")]
		public bool UniformItemSizes() {
			return ProxyQListView().UniformItemSizes();
		}
		[SmokeMethod("visualRect(const QModelIndex&) const")]
		public new QRect VisualRect(QModelIndex index) {
			return ProxyQListView().VisualRect(index);
		}
		[SmokeMethod("scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)")]
		public new void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			ProxyQListView().ScrollTo(index,hint);
		}
		[SmokeMethod("scrollTo(const QModelIndex&)")]
		public new void ScrollTo(QModelIndex index) {
			ProxyQListView().ScrollTo(index);
		}
		[SmokeMethod("indexAt(const QPoint&) const")]
		public new QModelIndex IndexAt(QPoint p) {
			return ProxyQListView().IndexAt(p);
		}
		[SmokeMethod("doItemsLayout()")]
		public new void DoItemsLayout() {
			ProxyQListView().DoItemsLayout();
		}
		[SmokeMethod("reset()")]
		public new void Reset() {
			ProxyQListView().Reset();
		}
		[SmokeMethod("setRootIndex(const QModelIndex&)")]
		public new void SetRootIndex(QModelIndex index) {
			ProxyQListView().SetRootIndex(index);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQListView().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQListView().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQListView().Event(e);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected new void ScrollContentsBy(int dx, int dy) {
			ProxyQListView().ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("resizeContents(int, int)")]
		protected void ResizeContents(int width, int height) {
			ProxyQListView().ResizeContents(width,height);
		}
		[SmokeMethod("contentsSize() const")]
		protected QSize ContentsSize() {
			return ProxyQListView().ContentsSize();
		}
		[SmokeMethod("dataChanged(const QModelIndex&, const QModelIndex&)")]
		protected new void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			ProxyQListView().DataChanged(topLeft,bottomRight);
		}
		[SmokeMethod("rowsInserted(const QModelIndex&, int, int)")]
		protected new void RowsInserted(QModelIndex parent, int start, int end) {
			ProxyQListView().RowsInserted(parent,start,end);
		}
		[SmokeMethod("rowsAboutToBeRemoved(const QModelIndex&, int, int)")]
		protected new void RowsAboutToBeRemoved(QModelIndex parent, int start, int end) {
			ProxyQListView().RowsAboutToBeRemoved(parent,start,end);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent e) {
			ProxyQListView().MouseMoveEvent(e);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent e) {
			ProxyQListView().MouseReleaseEvent(e);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent e) {
			ProxyQListView().TimerEvent(e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent e) {
			ProxyQListView().ResizeEvent(e);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected new void DragMoveEvent(QDragMoveEvent e) {
			ProxyQListView().DragMoveEvent(e);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected new void DragLeaveEvent(QDragLeaveEvent e) {
			ProxyQListView().DragLeaveEvent(e);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected new void DropEvent(QDropEvent e) {
			ProxyQListView().DropEvent(e);
		}
		[SmokeMethod("startDrag(Qt::DropActions)")]
		protected new void StartDrag(int supportedActions) {
			ProxyQListView().StartDrag(supportedActions);
		}
		[SmokeMethod("internalDrop(QDropEvent*)")]
		protected void InternalDrop(QDropEvent e) {
			ProxyQListView().InternalDrop(e);
		}
		[SmokeMethod("internalDrag(Qt::DropActions)")]
		protected void InternalDrag(int supportedActions) {
			ProxyQListView().InternalDrag(supportedActions);
		}
		[SmokeMethod("viewOptions() const")]
		protected new QStyleOptionViewItem ViewOptions() {
			return ProxyQListView().ViewOptions();
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent e) {
			ProxyQListView().PaintEvent(e);
		}
		[SmokeMethod("horizontalOffset() const")]
		protected new int HorizontalOffset() {
			return ProxyQListView().HorizontalOffset();
		}
		[SmokeMethod("verticalOffset() const")]
		protected new int VerticalOffset() {
			return ProxyQListView().VerticalOffset();
		}
		[SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected new QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, int modifiers) {
			return ProxyQListView().MoveCursor(cursorAction,modifiers);
		}
		[SmokeMethod("rectForIndex(const QModelIndex&) const")]
		protected QRect RectForIndex(QModelIndex index) {
			return ProxyQListView().RectForIndex(index);
		}
		[SmokeMethod("setPositionForIndex(const QPoint&, const QModelIndex&)")]
		protected void SetPositionForIndex(QPoint position, QModelIndex index) {
			ProxyQListView().SetPositionForIndex(position,index);
		}
		[SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected new void SetSelection(QRect rect, int command) {
			ProxyQListView().SetSelection(rect,command);
		}
		[SmokeMethod("visualRegionForSelection(const QItemSelection&) const")]
		protected new QRegion VisualRegionForSelection(QItemSelection selection) {
			return ProxyQListView().VisualRegionForSelection(selection);
		}
		[SmokeMethod("selectedIndexes() const")]
		protected new ArrayList SelectedIndexes() {
			return ProxyQListView().SelectedIndexes();
		}
		[SmokeMethod("updateGeometries()")]
		protected new void UpdateGeometries() {
			ProxyQListView().UpdateGeometries();
		}
		[SmokeMethod("isIndexHidden(const QModelIndex&) const")]
		protected new bool IsIndexHidden(QModelIndex index) {
			return ProxyQListView().IsIndexHidden(index);
		}
		~QListView() {
			DisposeQListView();
		}
		public new void Dispose() {
			DisposeQListView();
		}
		[SmokeMethod("~QListView()")]
		private void DisposeQListView() {
			ProxyQListView().DisposeQListView();
		}

		protected new IQListViewSignals Emit() {
			return (IQListViewSignals) Q_EMIT;
		}
	}

	public interface IQListViewSignals : IQAbstractItemViewSignals {
	}
}
