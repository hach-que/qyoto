//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQListViewSignals"></see> for signals emitted by QListView
	[SmokeClass("QListView")]
	public class QListView : QAbstractItemView, IDisposable {
 		protected QListView(Type dummy) : base((Type) null) {}
		interface IQListViewProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
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
		[Q_PROPERTY("QListView::Movement", "movement")]
		public QListView.Movement movement {
			get {
				return Property("movement").Value<QListView.Movement>();
			}
			set {
				SetProperty("movement", QVariant.FromValue<QListView.Movement>(value));
			}
		}
		[Q_PROPERTY("QListView::Flow", "flow")]
		public QListView.Flow flow {
			get {
				return Property("flow").Value<QListView.Flow>();
			}
			set {
				SetProperty("flow", QVariant.FromValue<QListView.Flow>(value));
			}
		}
		[Q_PROPERTY("bool", "isWrapping")]
		public bool IsWrapping {
			get {
				return Property("isWrapping").Value<bool>();
			}
			set {
				SetProperty("isWrapping", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("QListView::ResizeMode", "resizeMode")]
		public QListView.ResizeMode resizeMode {
			get {
				return Property("resizeMode").Value<QListView.ResizeMode>();
			}
			set {
				SetProperty("resizeMode", QVariant.FromValue<QListView.ResizeMode>(value));
			}
		}
		[Q_PROPERTY("QListView::LayoutMode", "layoutMode")]
		public QListView.LayoutMode layoutMode {
			get {
				return Property("layoutMode").Value<QListView.LayoutMode>();
			}
			set {
				SetProperty("layoutMode", QVariant.FromValue<QListView.LayoutMode>(value));
			}
		}
		[Q_PROPERTY("int", "spacing")]
		public int Spacing {
			get {
				return Property("spacing").Value<int>();
			}
			set {
				SetProperty("spacing", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("QSize", "gridSize")]
		public QSize GridSize {
			get {
				return Property("gridSize").Value<QSize>();
			}
			set {
				SetProperty("gridSize", QVariant.FromValue<QSize>(value));
			}
		}
		[Q_PROPERTY("QListView::ViewMode", "viewMode")]
		public QListView.ViewMode viewMode {
			get {
				return Property("viewMode").Value<QListView.ViewMode>();
			}
			set {
				SetProperty("viewMode", QVariant.FromValue<QListView.ViewMode>(value));
			}
		}
		[Q_PROPERTY("int", "modelColumn")]
		public int ModelColumn {
			get {
				return Property("modelColumn").Value<int>();
			}
			set {
				SetProperty("modelColumn", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "uniformItemSizes")]
		public bool UniformItemSizes {
			get {
				return Property("uniformItemSizes").Value<bool>();
			}
			set {
				SetProperty("uniformItemSizes", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("int", "batchSize")]
		public int BatchSize {
			get {
				return Property("batchSize").Value<int>();
			}
			set {
				SetProperty("batchSize", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "wordWrap")]
		public bool WordWrap {
			get {
				return Property("wordWrap").Value<bool>();
			}
			set {
				SetProperty("wordWrap", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QListView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQListView(parent);
		}
		[SmokeMethod("QListView#", "(QWidget*)")]
		private void NewQListView(QWidget parent) {
			ProxyQListView().NewQListView(parent);
		}
		public QListView() : this((Type) null) {
			CreateProxy();
			NewQListView();
		}
		[SmokeMethod("QListView", "()")]
		private void NewQListView() {
			ProxyQListView().NewQListView();
		}
		[SmokeMethod("setWrapping$", "(bool)")]
		public void SetWrapping(bool enable) {
			ProxyQListView().SetWrapping(enable);
		}
		[SmokeMethod("clearPropertyFlags", "()")]
		public void ClearPropertyFlags() {
			ProxyQListView().ClearPropertyFlags();
		}
		[SmokeMethod("isRowHidden$", "(int) const")]
		public bool IsRowHidden(int row) {
			return ProxyQListView().IsRowHidden(row);
		}
		[SmokeMethod("setRowHidden$$", "(int, bool)")]
		public void SetRowHidden(int row, bool hide) {
			ProxyQListView().SetRowHidden(row,hide);
		}
		[SmokeMethod("visualRect#", "(const QModelIndex&) const")]
		public new QRect VisualRect(QModelIndex index) {
			return ProxyQListView().VisualRect(index);
		}
		[SmokeMethod("scrollTo##", "(const QModelIndex&, QAbstractItemView::ScrollHint)")]
		public new void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			ProxyQListView().ScrollTo(index,hint);
		}
		[SmokeMethod("scrollTo#", "(const QModelIndex&)")]
		public new void ScrollTo(QModelIndex index) {
			ProxyQListView().ScrollTo(index);
		}
		[SmokeMethod("indexAt#", "(const QPoint&) const")]
		public new QModelIndex IndexAt(QPoint p) {
			return ProxyQListView().IndexAt(p);
		}
		[SmokeMethod("doItemsLayout", "()")]
		public new void DoItemsLayout() {
			ProxyQListView().DoItemsLayout();
		}
		[SmokeMethod("reset", "()")]
		public new void Reset() {
			ProxyQListView().Reset();
		}
		[SmokeMethod("setRootIndex#", "(const QModelIndex&)")]
		public new void SetRootIndex(QModelIndex index) {
			ProxyQListView().SetRootIndex(index);
		}
		public static new string Tr(string s, string c) {
			return StaticQListView().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQListView().Tr(s);
		}
		[SmokeMethod("event#", "(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQListView().Event(e);
		}
		[SmokeMethod("scrollContentsBy$$", "(int, int)")]
		protected new void ScrollContentsBy(int dx, int dy) {
			ProxyQListView().ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("resizeContents$$", "(int, int)")]
		protected void ResizeContents(int width, int height) {
			ProxyQListView().ResizeContents(width,height);
		}
		[SmokeMethod("contentsSize", "() const")]
		protected QSize ContentsSize() {
			return ProxyQListView().ContentsSize();
		}
		[SmokeMethod("dataChanged##", "(const QModelIndex&, const QModelIndex&)")]
		protected new void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			ProxyQListView().DataChanged(topLeft,bottomRight);
		}
		[SmokeMethod("rowsInserted###", "(const QModelIndex&, int, int)")]
		protected new void RowsInserted(QModelIndex parent, int start, int end) {
			ProxyQListView().RowsInserted(parent,start,end);
		}
		[SmokeMethod("rowsAboutToBeRemoved###", "(const QModelIndex&, int, int)")]
		protected new void RowsAboutToBeRemoved(QModelIndex parent, int start, int end) {
			ProxyQListView().RowsAboutToBeRemoved(parent,start,end);
		}
		[SmokeMethod("mouseMoveEvent#", "(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent e) {
			ProxyQListView().MouseMoveEvent(e);
		}
		[SmokeMethod("mouseReleaseEvent#", "(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent e) {
			ProxyQListView().MouseReleaseEvent(e);
		}
		[SmokeMethod("timerEvent#", "(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent e) {
			ProxyQListView().TimerEvent(e);
		}
		[SmokeMethod("resizeEvent#", "(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent e) {
			ProxyQListView().ResizeEvent(e);
		}
		[SmokeMethod("dragMoveEvent#", "(QDragMoveEvent*)")]
		protected new void DragMoveEvent(QDragMoveEvent e) {
			ProxyQListView().DragMoveEvent(e);
		}
		[SmokeMethod("dragLeaveEvent#", "(QDragLeaveEvent*)")]
		protected new void DragLeaveEvent(QDragLeaveEvent e) {
			ProxyQListView().DragLeaveEvent(e);
		}
		[SmokeMethod("dropEvent#", "(QDropEvent*)")]
		protected new void DropEvent(QDropEvent e) {
			ProxyQListView().DropEvent(e);
		}
		[SmokeMethod("startDrag$", "(Qt::DropActions)")]
		protected new void StartDrag(int supportedActions) {
			ProxyQListView().StartDrag(supportedActions);
		}
		[SmokeMethod("internalDrop#", "(QDropEvent*)")]
		protected void InternalDrop(QDropEvent e) {
			ProxyQListView().InternalDrop(e);
		}
		[SmokeMethod("internalDrag$", "(Qt::DropActions)")]
		protected void InternalDrag(int supportedActions) {
			ProxyQListView().InternalDrag(supportedActions);
		}
		[SmokeMethod("viewOptions", "() const")]
		protected new QStyleOptionViewItem ViewOptions() {
			return ProxyQListView().ViewOptions();
		}
		[SmokeMethod("paintEvent#", "(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent e) {
			ProxyQListView().PaintEvent(e);
		}
		[SmokeMethod("horizontalOffset", "() const")]
		protected new int HorizontalOffset() {
			return ProxyQListView().HorizontalOffset();
		}
		[SmokeMethod("verticalOffset", "() const")]
		protected new int VerticalOffset() {
			return ProxyQListView().VerticalOffset();
		}
		[SmokeMethod("moveCursor$$", "(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected new QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, int modifiers) {
			return ProxyQListView().MoveCursor(cursorAction,modifiers);
		}
		[SmokeMethod("rectForIndex#", "(const QModelIndex&) const")]
		protected QRect RectForIndex(QModelIndex index) {
			return ProxyQListView().RectForIndex(index);
		}
		[SmokeMethod("setPositionForIndex##", "(const QPoint&, const QModelIndex&)")]
		protected void SetPositionForIndex(QPoint position, QModelIndex index) {
			ProxyQListView().SetPositionForIndex(position,index);
		}
		[SmokeMethod("setSelection##", "(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected new void SetSelection(QRect rect, int command) {
			ProxyQListView().SetSelection(rect,command);
		}
		[SmokeMethod("visualRegionForSelection#", "(const QItemSelection&) const")]
		protected new QRegion VisualRegionForSelection(QItemSelection selection) {
			return ProxyQListView().VisualRegionForSelection(selection);
		}
		[SmokeMethod("selectedIndexes", "() const")]
		protected new List<QModelIndex> SelectedIndexes() {
			return ProxyQListView().SelectedIndexes();
		}
		[SmokeMethod("updateGeometries", "()")]
		protected new void UpdateGeometries() {
			ProxyQListView().UpdateGeometries();
		}
		[SmokeMethod("isIndexHidden#", "(const QModelIndex&) const")]
		protected new bool IsIndexHidden(QModelIndex index) {
			return ProxyQListView().IsIndexHidden(index);
		}
		~QListView() {
			DisposeQListView();
		}
		public new void Dispose() {
			DisposeQListView();
		}
		[SmokeMethod("~QListView", "()")]
		private void DisposeQListView() {
			ProxyQListView().DisposeQListView();
		}
		protected new IQListViewSignals Emit {
			get {
				return (IQListViewSignals) Q_EMIT;
			}
		}
	}

	public interface IQListViewSignals : IQAbstractItemViewSignals {
		[Q_SIGNAL("void (const QModelIndexList&)")]
		void IndexesMoved(List<QModelIndex> indexes);
	}
}
