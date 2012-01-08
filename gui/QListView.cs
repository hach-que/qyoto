//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQListViewSignals"></see> for signals emitted by QListView
    /// </remarks>
    [SmokeClass("QListView")]
    public class QListView : QAbstractItemView, IDisposable {
        protected QListView(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QListView), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QListView() {
            staticInterceptor = new SmokeInvocation(typeof(QListView), null);
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
            get { return (QListView.Movement) interceptor.Invoke("movement", "movement()", typeof(QListView.Movement)); }
            set { interceptor.Invoke("setMovement$", "setMovement(QListView::Movement)", typeof(void), typeof(QListView.Movement), value); }
        }
        [Q_PROPERTY("QListView::Flow", "flow")]
        public QListView.Flow flow {
            get { return (QListView.Flow) interceptor.Invoke("flow", "flow()", typeof(QListView.Flow)); }
            set { interceptor.Invoke("setFlow$", "setFlow(QListView::Flow)", typeof(void), typeof(QListView.Flow), value); }
        }
        [Q_PROPERTY("bool", "isWrapping")]
        public bool IsWrapping {
            get { return (bool) interceptor.Invoke("isWrapping", "isWrapping()", typeof(bool)); }
            set { interceptor.Invoke("setWrapping$", "setWrapping(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QListView::ResizeMode", "resizeMode")]
        public QListView.ResizeMode resizeMode {
            get { return (QListView.ResizeMode) interceptor.Invoke("resizeMode", "resizeMode()", typeof(QListView.ResizeMode)); }
            set { interceptor.Invoke("setResizeMode$", "setResizeMode(QListView::ResizeMode)", typeof(void), typeof(QListView.ResizeMode), value); }
        }
        [Q_PROPERTY("QListView::LayoutMode", "layoutMode")]
        public QListView.LayoutMode layoutMode {
            get { return (QListView.LayoutMode) interceptor.Invoke("layoutMode", "layoutMode()", typeof(QListView.LayoutMode)); }
            set { interceptor.Invoke("setLayoutMode$", "setLayoutMode(QListView::LayoutMode)", typeof(void), typeof(QListView.LayoutMode), value); }
        }
        [Q_PROPERTY("int", "spacing")]
        public int Spacing {
            get { return (int) interceptor.Invoke("spacing", "spacing()", typeof(int)); }
            set { interceptor.Invoke("setSpacing$", "setSpacing(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("QSize", "gridSize")]
        public QSize GridSize {
            get { return (QSize) interceptor.Invoke("gridSize", "gridSize()", typeof(QSize)); }
            set { interceptor.Invoke("setGridSize#", "setGridSize(QSize)", typeof(void), typeof(QSize), value); }
        }
        [Q_PROPERTY("QListView::ViewMode", "viewMode")]
        public QListView.ViewMode viewMode {
            get { return (QListView.ViewMode) interceptor.Invoke("viewMode", "viewMode()", typeof(QListView.ViewMode)); }
            set { interceptor.Invoke("setViewMode$", "setViewMode(QListView::ViewMode)", typeof(void), typeof(QListView.ViewMode), value); }
        }
        [Q_PROPERTY("int", "modelColumn")]
        public int ModelColumn {
            get { return (int) interceptor.Invoke("modelColumn", "modelColumn()", typeof(int)); }
            set { interceptor.Invoke("setModelColumn$", "setModelColumn(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("bool", "uniformItemSizes")]
        public bool UniformItemSizes {
            get { return (bool) interceptor.Invoke("uniformItemSizes", "uniformItemSizes()", typeof(bool)); }
            set { interceptor.Invoke("setUniformItemSizes$", "setUniformItemSizes(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("int", "batchSize")]
        public int BatchSize {
            get { return (int) interceptor.Invoke("batchSize", "batchSize()", typeof(int)); }
            set { interceptor.Invoke("setBatchSize$", "setBatchSize(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("bool", "wordWrap")]
        public bool WordWrap {
            get { return (bool) interceptor.Invoke("wordWrap", "wordWrap()", typeof(bool)); }
            set { interceptor.Invoke("setWordWrap$", "setWordWrap(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "selectionRectVisible")]
        public bool SelectionRectVisible {
            get { return (bool) interceptor.Invoke("isSelectionRectVisible", "isSelectionRectVisible()", typeof(bool)); }
            set { interceptor.Invoke("setSelectionRectVisible$", "setSelectionRectVisible(bool)", typeof(void), typeof(bool), value); }
        }
        // QListView* QListView(QListViewPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
        // QListView* QListView(QListViewPrivate& arg1); >>>> NOT CONVERTED
        public QListView(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QListView#", "QListView(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QListView() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QListView", "QListView()", typeof(void));
        }
        public void ClearPropertyFlags() {
            interceptor.Invoke("clearPropertyFlags", "clearPropertyFlags()", typeof(void));
        }
        public bool IsRowHidden(int row) {
            return (bool) interceptor.Invoke("isRowHidden$", "isRowHidden(int) const", typeof(bool), typeof(int), row);
        }
        public void SetRowHidden(int row, bool hide) {
            interceptor.Invoke("setRowHidden$$", "setRowHidden(int, bool)", typeof(void), typeof(int), row, typeof(bool), hide);
        }
        [SmokeMethod("visualRect(const QModelIndex&) const")]
        public override QRect VisualRect(QModelIndex index) {
            return (QRect) interceptor.Invoke("visualRect#", "visualRect(const QModelIndex&) const", typeof(QRect), typeof(QModelIndex), index);
        }
        [SmokeMethod("scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)")]
        public override void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
            interceptor.Invoke("scrollTo#$", "scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)", typeof(void), typeof(QModelIndex), index, typeof(QAbstractItemView.ScrollHint), hint);
        }
        [SmokeMethod("scrollTo(const QModelIndex&)")]
        public virtual void ScrollTo(QModelIndex index) {
            interceptor.Invoke("scrollTo#", "scrollTo(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
        }
        [SmokeMethod("indexAt(const QPoint&) const")]
        public override QModelIndex IndexAt(QPoint p) {
            return (QModelIndex) interceptor.Invoke("indexAt#", "indexAt(const QPoint&) const", typeof(QModelIndex), typeof(QPoint), p);
        }
        [SmokeMethod("doItemsLayout()")]
        public override void DoItemsLayout() {
            interceptor.Invoke("doItemsLayout", "doItemsLayout()", typeof(void));
        }
        [SmokeMethod("reset()")]
        public override void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        [SmokeMethod("setRootIndex(const QModelIndex&)")]
        public override void SetRootIndex(QModelIndex index) {
            interceptor.Invoke("setRootIndex#", "setRootIndex(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("scrollContentsBy(int, int)")]
        protected override void ScrollContentsBy(int dx, int dy) {
            interceptor.Invoke("scrollContentsBy$$", "scrollContentsBy(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
        }
        protected void ResizeContents(int width, int height) {
            interceptor.Invoke("resizeContents$$", "resizeContents(int, int)", typeof(void), typeof(int), width, typeof(int), height);
        }
        protected QSize ContentsSize() {
            return (QSize) interceptor.Invoke("contentsSize", "contentsSize() const", typeof(QSize));
        }
        [SmokeMethod("dataChanged(const QModelIndex&, const QModelIndex&)")]
        protected override void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
            interceptor.Invoke("dataChanged##", "dataChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), topLeft, typeof(QModelIndex), bottomRight);
        }
        [SmokeMethod("rowsInserted(const QModelIndex&, int, int)")]
        protected override void RowsInserted(QModelIndex parent, int start, int end) {
            interceptor.Invoke("rowsInserted#$$", "rowsInserted(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
        }
        [SmokeMethod("rowsAboutToBeRemoved(const QModelIndex&, int, int)")]
        protected override void RowsAboutToBeRemoved(QModelIndex parent, int start, int end) {
            interceptor.Invoke("rowsAboutToBeRemoved#$$", "rowsAboutToBeRemoved(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
        }
        [SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
        protected override void MouseMoveEvent(QMouseEvent e) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
        }
        [SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
        protected override void MouseReleaseEvent(QMouseEvent e) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
        }
        [SmokeMethod("timerEvent(QTimerEvent*)")]
        protected override void TimerEvent(QTimerEvent e) {
            interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), e);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent e) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), e);
        }
        [SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
        protected override void DragMoveEvent(QDragMoveEvent e) {
            interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), e);
        }
        [SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
        protected override void DragLeaveEvent(QDragLeaveEvent e) {
            interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QDragLeaveEvent*)", typeof(void), typeof(QDragLeaveEvent), e);
        }
        [SmokeMethod("dropEvent(QDropEvent*)")]
        protected override void DropEvent(QDropEvent e) {
            interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), e);
        }
        [SmokeMethod("startDrag(Qt::DropActions)")]
        protected override void StartDrag(uint supportedActions) {
            interceptor.Invoke("startDrag$", "startDrag(Qt::DropActions)", typeof(void), typeof(uint), supportedActions);
        }
        protected void InternalDrop(QDropEvent e) {
            interceptor.Invoke("internalDrop#", "internalDrop(QDropEvent*)", typeof(void), typeof(QDropEvent), e);
        }
        protected void InternalDrag(uint supportedActions) {
            interceptor.Invoke("internalDrag$", "internalDrag(Qt::DropActions)", typeof(void), typeof(uint), supportedActions);
        }
        [SmokeMethod("viewOptions() const")]
        protected override QStyleOptionViewItem ViewOptions() {
            return (QStyleOptionViewItem) interceptor.Invoke("viewOptions", "viewOptions() const", typeof(QStyleOptionViewItem));
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent e) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
        }
        [SmokeMethod("horizontalOffset() const")]
        protected override int HorizontalOffset() {
            return (int) interceptor.Invoke("horizontalOffset", "horizontalOffset() const", typeof(int));
        }
        [SmokeMethod("verticalOffset() const")]
        protected override int VerticalOffset() {
            return (int) interceptor.Invoke("verticalOffset", "verticalOffset() const", typeof(int));
        }
        [SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
        protected override QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, uint modifiers) {
            return (QModelIndex) interceptor.Invoke("moveCursor$$", "moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)", typeof(QModelIndex), typeof(QAbstractItemView.CursorAction), cursorAction, typeof(uint), modifiers);
        }
        protected QRect RectForIndex(QModelIndex index) {
            return (QRect) interceptor.Invoke("rectForIndex#", "rectForIndex(const QModelIndex&) const", typeof(QRect), typeof(QModelIndex), index);
        }
        protected void SetPositionForIndex(QPoint position, QModelIndex index) {
            interceptor.Invoke("setPositionForIndex##", "setPositionForIndex(const QPoint&, const QModelIndex&)", typeof(void), typeof(QPoint), position, typeof(QModelIndex), index);
        }
        [SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
        protected override void SetSelection(QRect rect, uint command) {
            interceptor.Invoke("setSelection#$", "setSelection(const QRect&, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(QRect), rect, typeof(uint), command);
        }
        [SmokeMethod("visualRegionForSelection(const QItemSelection&) const")]
        protected override QRegion VisualRegionForSelection(QItemSelection selection) {
            return (QRegion) interceptor.Invoke("visualRegionForSelection#", "visualRegionForSelection(const QItemSelection&) const", typeof(QRegion), typeof(QItemSelection), selection);
        }
        [SmokeMethod("selectedIndexes() const")]
        protected override List<QModelIndex> SelectedIndexes() {
            return (List<QModelIndex>) interceptor.Invoke("selectedIndexes", "selectedIndexes() const", typeof(List<QModelIndex>));
        }
        [SmokeMethod("updateGeometries()")]
        protected override void UpdateGeometries() {
            interceptor.Invoke("updateGeometries", "updateGeometries()", typeof(void));
        }
        [SmokeMethod("isIndexHidden(const QModelIndex&) const")]
        protected override bool IsIndexHidden(QModelIndex index) {
            return (bool) interceptor.Invoke("isIndexHidden#", "isIndexHidden(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), index);
        }
        [SmokeMethod("selectionChanged(const QItemSelection&, const QItemSelection&)")]
        protected override void SelectionChanged(QItemSelection selected, QItemSelection deselected) {
            interceptor.Invoke("selectionChanged##", "selectionChanged(const QItemSelection&, const QItemSelection&)", typeof(void), typeof(QItemSelection), selected, typeof(QItemSelection), deselected);
        }
        [SmokeMethod("currentChanged(const QModelIndex&, const QModelIndex&)")]
        protected override void CurrentChanged(QModelIndex current, QModelIndex previous) {
            interceptor.Invoke("currentChanged##", "currentChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), current, typeof(QModelIndex), previous);
        }
        ~QListView() {
            interceptor.Invoke("~QListView", "~QListView()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QListView", "~QListView()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQListViewSignals Emit {
            get { return (IQListViewSignals) Q_EMIT; }
        }
    }

    public interface IQListViewSignals : IQAbstractItemViewSignals {
        [Q_SIGNAL("void indexesMoved(QModelIndexList)")]
        void IndexesMoved(List<QModelIndex> indexes);
    }
}