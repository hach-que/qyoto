//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	///<remarks> See <see cref="IQAbstractItemViewSignals"></see> for signals emitted by QAbstractItemView
	///</remarks>

	[SmokeClass("QAbstractItemView")]
	public abstract class QAbstractItemView : QAbstractScrollArea {
 		protected QAbstractItemView(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractItemView), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAbstractItemView() {
			staticInterceptor = new SmokeInvocation(typeof(QAbstractItemView), null);
		}
		public enum SelectionMode {
			NoSelection = 0,
			SingleSelection = 1,
			MultiSelection = 2,
			ExtendedSelection = 3,
			ContiguousSelection = 4,
		}
		public enum SelectionBehavior {
			SelectItems = 0,
			SelectRows = 1,
			SelectColumns = 2,
		}
		public enum ScrollHint {
			EnsureVisible = 0,
			PositionAtTop = 1,
			PositionAtBottom = 2,
			PositionAtCenter = 3,
		}
		public enum EditTrigger {
			NoEditTriggers = 0,
			CurrentChanged = 1,
			DoubleClicked = 2,
			SelectedClicked = 4,
			EditKeyPressed = 8,
			AnyKeyPressed = 16,
			AllEditTriggers = 31,
		}
		public enum ScrollMode {
			ScrollPerItem = 0,
			ScrollPerPixel = 1,
		}
		public enum DragDropMode {
			NoDragDrop = 0,
			DragOnly = 1,
			DropOnly = 2,
			DragDrop = 3,
			InternalMove = 4,
		}
		public enum CursorAction {
			MoveUp = 0,
			MoveDown = 1,
			MoveLeft = 2,
			MoveRight = 3,
			MoveHome = 4,
			MoveEnd = 5,
			MovePageUp = 6,
			MovePageDown = 7,
			MoveNext = 8,
			MovePrevious = 9,
		}
		public enum State {
			NoState = 0,
			DraggingState = 1,
			DragSelectingState = 2,
			EditingState = 3,
			ExpandingState = 4,
			CollapsingState = 5,
			AnimatingState = 6,
		}
		public enum DropIndicatorPosition {
			OnItem = 0,
			AboveItem = 1,
			BelowItem = 2,
			OnViewport = 3,
		}
		[Q_PROPERTY("bool", "autoScroll")]
		public bool AutoScroll {
			get { return (bool) interceptor.Invoke("hasAutoScroll", "hasAutoScroll()", typeof(bool)); }
			set { interceptor.Invoke("setAutoScroll$", "setAutoScroll(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("EditTriggers", "editTriggers")]
		public int EditTriggers {
			get { return (int) interceptor.Invoke("editTriggers", "editTriggers()", typeof(int)); }
			set { interceptor.Invoke("setEditTriggers$", "setEditTriggers(EditTriggers)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "tabKeyNavigation")]
		public bool TabKeyNavigation {
			get { return (bool) interceptor.Invoke("tabKeyNavigation", "tabKeyNavigation()", typeof(bool)); }
			set { interceptor.Invoke("setTabKeyNavigation$", "setTabKeyNavigation(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "showDropIndicator")]
		public bool ShowDropIndicator {
			get { return (bool) interceptor.Invoke("showDropIndicator", "showDropIndicator()", typeof(bool)); }
			set { interceptor.Invoke("setDropIndicatorShown$", "setDropIndicatorShown(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "dragEnabled")]
		public bool DragEnabled {
			get { return (bool) interceptor.Invoke("dragEnabled", "dragEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setDragEnabled$", "setDragEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "dragDropOverwriteMode")]
		public bool DragDropOverwriteMode {
			get { return (bool) interceptor.Invoke("dragDropOverwriteMode", "dragDropOverwriteMode()", typeof(bool)); }
			set { interceptor.Invoke("setDragDropOverwriteMode$", "setDragDropOverwriteMode(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QAbstractItemView::DragDropMode", "dragDropMode")]
		public QAbstractItemView.DragDropMode dragDropMode {
			get { return (QAbstractItemView.DragDropMode) interceptor.Invoke("dragDropMode", "dragDropMode()", typeof(QAbstractItemView.DragDropMode)); }
			set { interceptor.Invoke("setDragDropMode$", "setDragDropMode(QAbstractItemView::DragDropMode)", typeof(void), typeof(QAbstractItemView.DragDropMode), value); }
		}
		[Q_PROPERTY("bool", "alternatingRowColors")]
		public bool AlternatingRowColors {
			get { return (bool) interceptor.Invoke("alternatingRowColors", "alternatingRowColors()", typeof(bool)); }
			set { interceptor.Invoke("setAlternatingRowColors$", "setAlternatingRowColors(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QAbstractItemView::SelectionMode", "selectionMode")]
		public QAbstractItemView.SelectionMode selectionMode {
			get { return (QAbstractItemView.SelectionMode) interceptor.Invoke("selectionMode", "selectionMode()", typeof(QAbstractItemView.SelectionMode)); }
			set { interceptor.Invoke("setSelectionMode$", "setSelectionMode(QAbstractItemView::SelectionMode)", typeof(void), typeof(QAbstractItemView.SelectionMode), value); }
		}
		[Q_PROPERTY("QAbstractItemView::SelectionBehavior", "selectionBehavior")]
		public QAbstractItemView.SelectionBehavior selectionBehavior {
			get { return (QAbstractItemView.SelectionBehavior) interceptor.Invoke("selectionBehavior", "selectionBehavior()", typeof(QAbstractItemView.SelectionBehavior)); }
			set { interceptor.Invoke("setSelectionBehavior$", "setSelectionBehavior(QAbstractItemView::SelectionBehavior)", typeof(void), typeof(QAbstractItemView.SelectionBehavior), value); }
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get { return (QSize) interceptor.Invoke("iconSize", "iconSize()", typeof(QSize)); }
			set { interceptor.Invoke("setIconSize#", "setIconSize(QSize)", typeof(void), typeof(QSize), value); }
		}
		[Q_PROPERTY("Qt::TextElideMode", "textElideMode")]
		public new Qt.TextElideMode TextElideMode {
			get { return (Qt.TextElideMode) interceptor.Invoke("textElideMode", "textElideMode()", typeof(Qt.TextElideMode)); }
			set { interceptor.Invoke("setTextElideMode$", "setTextElideMode(Qt::TextElideMode)", typeof(void), typeof(Qt.TextElideMode), value); }
		}
		[Q_PROPERTY("QAbstractItemView::ScrollMode", "verticalScrollMode")]
		public QAbstractItemView.ScrollMode VerticalScrollMode {
			get { return (QAbstractItemView.ScrollMode) interceptor.Invoke("verticalScrollMode", "verticalScrollMode()", typeof(QAbstractItemView.ScrollMode)); }
			set { interceptor.Invoke("setVerticalScrollMode$", "setVerticalScrollMode(QAbstractItemView::ScrollMode)", typeof(void), typeof(QAbstractItemView.ScrollMode), value); }
		}
		[Q_PROPERTY("QAbstractItemView::ScrollMode", "horizontalScrollMode")]
		public QAbstractItemView.ScrollMode HorizontalScrollMode {
			get { return (QAbstractItemView.ScrollMode) interceptor.Invoke("horizontalScrollMode", "horizontalScrollMode()", typeof(QAbstractItemView.ScrollMode)); }
			set { interceptor.Invoke("setHorizontalScrollMode$", "setHorizontalScrollMode(QAbstractItemView::ScrollMode)", typeof(void), typeof(QAbstractItemView.ScrollMode), value); }
		}
		public QAbstractItemView(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractItemView#", "QAbstractItemView(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QAbstractItemView() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractItemView", "QAbstractItemView()", typeof(void));
		}
		[SmokeMethod("setModel(QAbstractItemModel*)")]
		public virtual void SetModel(QAbstractItemModel model) {
			interceptor.Invoke("setModel#", "setModel(QAbstractItemModel*)", typeof(void), typeof(QAbstractItemModel), model);
		}
		public QAbstractItemModel Model() {
			return (QAbstractItemModel) interceptor.Invoke("model", "model() const", typeof(QAbstractItemModel));
		}
		[SmokeMethod("setSelectionModel(QItemSelectionModel*)")]
		public virtual void SetSelectionModel(QItemSelectionModel selectionModel) {
			interceptor.Invoke("setSelectionModel#", "setSelectionModel(QItemSelectionModel*)", typeof(void), typeof(QItemSelectionModel), selectionModel);
		}
		public QItemSelectionModel SelectionModel() {
			return (QItemSelectionModel) interceptor.Invoke("selectionModel", "selectionModel() const", typeof(QItemSelectionModel));
		}
		public void SetItemDelegate(QAbstractItemDelegate arg1) {
			interceptor.Invoke("setItemDelegate#", "setItemDelegate(QAbstractItemDelegate*)", typeof(void), typeof(QAbstractItemDelegate), arg1);
		}
		public QAbstractItemDelegate ItemDelegate() {
			return (QAbstractItemDelegate) interceptor.Invoke("itemDelegate", "itemDelegate() const", typeof(QAbstractItemDelegate));
		}
		public QModelIndex CurrentIndex() {
			return (QModelIndex) interceptor.Invoke("currentIndex", "currentIndex() const", typeof(QModelIndex));
		}
		public QModelIndex RootIndex() {
			return (QModelIndex) interceptor.Invoke("rootIndex", "rootIndex() const", typeof(QModelIndex));
		}
		public bool HasAutoScroll() {
			return (bool) interceptor.Invoke("hasAutoScroll", "hasAutoScroll() const", typeof(bool));
		}
		public void SetDropIndicatorShown(bool enable) {
			interceptor.Invoke("setDropIndicatorShown$", "setDropIndicatorShown(bool)", typeof(void), typeof(bool), enable);
		}
		[SmokeMethod("keyboardSearch(const QString&)")]
		public virtual void KeyboardSearch(string search) {
			interceptor.Invoke("keyboardSearch$", "keyboardSearch(const QString&)", typeof(void), typeof(string), search);
		}
		[SmokeMethod("visualRect(const QModelIndex&) const")]
		public abstract QRect VisualRect(QModelIndex index);
		[SmokeMethod("scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)")]
		public abstract void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint);
		[SmokeMethod("indexAt(const QPoint&) const")]
		public abstract QModelIndex IndexAt(QPoint point);
		public QSize SizeHintForIndex(QModelIndex index) {
			return (QSize) interceptor.Invoke("sizeHintForIndex#", "sizeHintForIndex(const QModelIndex&) const", typeof(QSize), typeof(QModelIndex), index);
		}
		[SmokeMethod("sizeHintForRow(int) const")]
		public virtual int SizeHintForRow(int row) {
			return (int) interceptor.Invoke("sizeHintForRow$", "sizeHintForRow(int) const", typeof(int), typeof(int), row);
		}
		[SmokeMethod("sizeHintForColumn(int) const")]
		public virtual int SizeHintForColumn(int column) {
			return (int) interceptor.Invoke("sizeHintForColumn$", "sizeHintForColumn(int) const", typeof(int), typeof(int), column);
		}
		public void OpenPersistentEditor(QModelIndex index) {
			interceptor.Invoke("openPersistentEditor#", "openPersistentEditor(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		public void ClosePersistentEditor(QModelIndex index) {
			interceptor.Invoke("closePersistentEditor#", "closePersistentEditor(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		public void SetIndexWidget(QModelIndex index, QWidget widget) {
			interceptor.Invoke("setIndexWidget##", "setIndexWidget(const QModelIndex&, QWidget*)", typeof(void), typeof(QModelIndex), index, typeof(QWidget), widget);
		}
		public QWidget IndexWidget(QModelIndex index) {
			return (QWidget) interceptor.Invoke("indexWidget#", "indexWidget(const QModelIndex&) const", typeof(QWidget), typeof(QModelIndex), index);
		}
		public void SetItemDelegateForRow(int row, QAbstractItemDelegate arg2) {
			interceptor.Invoke("setItemDelegateForRow$#", "setItemDelegateForRow(int, QAbstractItemDelegate*)", typeof(void), typeof(int), row, typeof(QAbstractItemDelegate), arg2);
		}
		public QAbstractItemDelegate ItemDelegateForRow(int row) {
			return (QAbstractItemDelegate) interceptor.Invoke("itemDelegateForRow$", "itemDelegateForRow(int) const", typeof(QAbstractItemDelegate), typeof(int), row);
		}
		public void SetItemDelegateForColumn(int column, QAbstractItemDelegate arg2) {
			interceptor.Invoke("setItemDelegateForColumn$#", "setItemDelegateForColumn(int, QAbstractItemDelegate*)", typeof(void), typeof(int), column, typeof(QAbstractItemDelegate), arg2);
		}
		public QAbstractItemDelegate ItemDelegateForColumn(int column) {
			return (QAbstractItemDelegate) interceptor.Invoke("itemDelegateForColumn$", "itemDelegateForColumn(int) const", typeof(QAbstractItemDelegate), typeof(int), column);
		}
		public QAbstractItemDelegate ItemDelegate(QModelIndex index) {
			return (QAbstractItemDelegate) interceptor.Invoke("itemDelegate#", "itemDelegate(const QModelIndex&) const", typeof(QAbstractItemDelegate), typeof(QModelIndex), index);
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		public override QVariant InputMethodQuery(Qt.InputMethodQuery query) {
			return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), query);
		}
		[Q_SLOT("void reset()")]
		[SmokeMethod("reset()")]
		public virtual void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		[Q_SLOT("void setRootIndex(const QModelIndex&)")]
		[SmokeMethod("setRootIndex(const QModelIndex&)")]
		public virtual void SetRootIndex(QModelIndex index) {
			interceptor.Invoke("setRootIndex#", "setRootIndex(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		[Q_SLOT("void doItemsLayout()")]
		[SmokeMethod("doItemsLayout()")]
		public virtual void DoItemsLayout() {
			interceptor.Invoke("doItemsLayout", "doItemsLayout()", typeof(void));
		}
		[Q_SLOT("void selectAll()")]
		[SmokeMethod("selectAll()")]
		public virtual void SelectAll() {
			interceptor.Invoke("selectAll", "selectAll()", typeof(void));
		}
		[Q_SLOT("void edit(const QModelIndex&)")]
		public void Edit(QModelIndex index) {
			interceptor.Invoke("edit#", "edit(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		[Q_SLOT("void clearSelection()")]
		public void ClearSelection() {
			interceptor.Invoke("clearSelection", "clearSelection()", typeof(void));
		}
		[Q_SLOT("void setCurrentIndex(const QModelIndex&)")]
		public void SetCurrentIndex(QModelIndex index) {
			interceptor.Invoke("setCurrentIndex#", "setCurrentIndex(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		[Q_SLOT("void scrollToTop()")]
		public void ScrollToTop() {
			interceptor.Invoke("scrollToTop", "scrollToTop()", typeof(void));
		}
		[Q_SLOT("void scrollToBottom()")]
		public void ScrollToBottom() {
			interceptor.Invoke("scrollToBottom", "scrollToBottom()", typeof(void));
		}
		[Q_SLOT("void updateIndex(const QModelIndex&)")]
		public void UpdateIndex(QModelIndex index) {
			interceptor.Invoke("updateIndex#", "updateIndex(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		protected void SetHorizontalStepsPerItem(int steps) {
			interceptor.Invoke("setHorizontalStepsPerItem$", "setHorizontalStepsPerItem(int)", typeof(void), typeof(int), steps);
		}
		protected int HorizontalStepsPerItem() {
			return (int) interceptor.Invoke("horizontalStepsPerItem", "horizontalStepsPerItem() const", typeof(int));
		}
		protected void SetVerticalStepsPerItem(int steps) {
			interceptor.Invoke("setVerticalStepsPerItem$", "setVerticalStepsPerItem(int)", typeof(void), typeof(int), steps);
		}
		protected int VerticalStepsPerItem() {
			return (int) interceptor.Invoke("verticalStepsPerItem", "verticalStepsPerItem() const", typeof(int));
		}
		[SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected abstract QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, int modifiers);
		[SmokeMethod("horizontalOffset() const")]
		protected abstract int HorizontalOffset();
		[SmokeMethod("verticalOffset() const")]
		protected abstract int VerticalOffset();
		[SmokeMethod("isIndexHidden(const QModelIndex&) const")]
		protected abstract bool IsIndexHidden(QModelIndex index);
		[SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected abstract void SetSelection(QRect rect, int command);
		[SmokeMethod("visualRegionForSelection(const QItemSelection&) const")]
		protected abstract QRegion VisualRegionForSelection(QItemSelection selection);
		[SmokeMethod("selectedIndexes() const")]
		protected virtual List<QModelIndex> SelectedIndexes() {
			return (List<QModelIndex>) interceptor.Invoke("selectedIndexes", "selectedIndexes() const", typeof(List<QModelIndex>));
		}
		[SmokeMethod("edit(const QModelIndex&, QAbstractItemView::EditTrigger, QEvent*)")]
		protected virtual bool Edit(QModelIndex index, QAbstractItemView.EditTrigger trigger, QEvent arg3) {
			return (bool) interceptor.Invoke("edit#$#", "edit(const QModelIndex&, QAbstractItemView::EditTrigger, QEvent*)", typeof(bool), typeof(QModelIndex), index, typeof(QAbstractItemView.EditTrigger), trigger, typeof(QEvent), arg3);
		}
		[SmokeMethod("selectionCommand(const QModelIndex&, const QEvent*) const")]
		protected virtual int SelectionCommand(QModelIndex index, QEvent arg2) {
			return (int) interceptor.Invoke("selectionCommand##", "selectionCommand(const QModelIndex&, const QEvent*) const", typeof(int), typeof(QModelIndex), index, typeof(QEvent), arg2);
		}
		[SmokeMethod("selectionCommand(const QModelIndex&) const")]
		protected virtual int SelectionCommand(QModelIndex index) {
			return (int) interceptor.Invoke("selectionCommand#", "selectionCommand(const QModelIndex&) const", typeof(int), typeof(QModelIndex), index);
		}
		[SmokeMethod("startDrag(Qt::DropActions)")]
		protected virtual void StartDrag(int supportedActions) {
			interceptor.Invoke("startDrag$", "startDrag(Qt::DropActions)", typeof(void), typeof(int), supportedActions);
		}
		[SmokeMethod("viewOptions() const")]
		protected virtual QStyleOptionViewItem ViewOptions() {
			return (QStyleOptionViewItem) interceptor.Invoke("viewOptions", "viewOptions() const", typeof(QStyleOptionViewItem));
		}
		protected QAbstractItemView.State state() {
			return (QAbstractItemView.State) interceptor.Invoke("state", "state() const", typeof(QAbstractItemView.State));
		}
		protected void SetState(QAbstractItemView.State state) {
			interceptor.Invoke("setState$", "setState(QAbstractItemView::State)", typeof(void), typeof(QAbstractItemView.State), state);
		}
		protected void ScheduleDelayedItemsLayout() {
			interceptor.Invoke("scheduleDelayedItemsLayout", "scheduleDelayedItemsLayout()", typeof(void));
		}
		protected void ExecuteDelayedItemsLayout() {
			interceptor.Invoke("executeDelayedItemsLayout", "executeDelayedItemsLayout()", typeof(void));
		}
		protected void SetDirtyRegion(QRegion region) {
			interceptor.Invoke("setDirtyRegion#", "setDirtyRegion(const QRegion&)", typeof(void), typeof(QRegion), region);
		}
		protected void ScrollDirtyRegion(int dx, int dy) {
			interceptor.Invoke("scrollDirtyRegion$$", "scrollDirtyRegion(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		protected QPoint DirtyRegionOffset() {
			return (QPoint) interceptor.Invoke("dirtyRegionOffset", "dirtyRegionOffset() const", typeof(QPoint));
		}
		protected void StartAutoScroll() {
			interceptor.Invoke("startAutoScroll", "startAutoScroll()", typeof(void));
		}
		protected void StopAutoScroll() {
			interceptor.Invoke("stopAutoScroll", "stopAutoScroll()", typeof(void));
		}
		protected void DoAutoScroll() {
			interceptor.Invoke("doAutoScroll", "doAutoScroll()", typeof(void));
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("viewportEvent(QEvent*)")]
		protected override bool ViewportEvent(QEvent arg1) {
			return (bool) interceptor.Invoke("viewportEvent#", "viewportEvent(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected override void MouseDoubleClickEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected override void DragEnterEvent(QDragEnterEvent arg1) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QDragEnterEvent*)", typeof(void), typeof(QDragEnterEvent), arg1);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected override void DragMoveEvent(QDragMoveEvent arg1) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), arg1);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected override void DragLeaveEvent(QDragLeaveEvent arg1) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QDragLeaveEvent*)", typeof(void), typeof(QDragLeaveEvent), arg1);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected override void TimerEvent(QTimerEvent arg1) {
			interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected override void InputMethodEvent(QInputMethodEvent arg1) {
			interceptor.Invoke("inputMethodEvent#", "inputMethodEvent(QInputMethodEvent*)", typeof(void), typeof(QInputMethodEvent), arg1);
		}
		protected QAbstractItemView.DropIndicatorPosition dropIndicatorPosition() {
			return (QAbstractItemView.DropIndicatorPosition) interceptor.Invoke("dropIndicatorPosition", "dropIndicatorPosition() const", typeof(QAbstractItemView.DropIndicatorPosition));
		}
		[Q_SLOT("void dataChanged(const QModelIndex&, const QModelIndex&)")]
		[SmokeMethod("dataChanged(const QModelIndex&, const QModelIndex&)")]
		protected virtual void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			interceptor.Invoke("dataChanged##", "dataChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), topLeft, typeof(QModelIndex), bottomRight);
		}
		[Q_SLOT("void rowsInserted(const QModelIndex&, int, int)")]
		[SmokeMethod("rowsInserted(const QModelIndex&, int, int)")]
		protected virtual void RowsInserted(QModelIndex parent, int start, int end) {
			interceptor.Invoke("rowsInserted#$$", "rowsInserted(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
		}
		[Q_SLOT("void rowsAboutToBeRemoved(const QModelIndex&, int, int)")]
		[SmokeMethod("rowsAboutToBeRemoved(const QModelIndex&, int, int)")]
		protected virtual void RowsAboutToBeRemoved(QModelIndex parent, int start, int end) {
			interceptor.Invoke("rowsAboutToBeRemoved#$$", "rowsAboutToBeRemoved(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
		}
		[Q_SLOT("void selectionChanged(const QItemSelection&, const QItemSelection&)")]
		[SmokeMethod("selectionChanged(const QItemSelection&, const QItemSelection&)")]
		protected virtual void SelectionChanged(QItemSelection selected, QItemSelection deselected) {
			interceptor.Invoke("selectionChanged##", "selectionChanged(const QItemSelection&, const QItemSelection&)", typeof(void), typeof(QItemSelection), selected, typeof(QItemSelection), deselected);
		}
		[Q_SLOT("void currentChanged(const QModelIndex&, const QModelIndex&)")]
		[SmokeMethod("currentChanged(const QModelIndex&, const QModelIndex&)")]
		protected virtual void CurrentChanged(QModelIndex current, QModelIndex previous) {
			interceptor.Invoke("currentChanged##", "currentChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), current, typeof(QModelIndex), previous);
		}
		[Q_SLOT("void updateEditorData()")]
		[SmokeMethod("updateEditorData()")]
		protected virtual void UpdateEditorData() {
			interceptor.Invoke("updateEditorData", "updateEditorData()", typeof(void));
		}
		[Q_SLOT("void updateEditorGeometries()")]
		[SmokeMethod("updateEditorGeometries()")]
		protected virtual void UpdateEditorGeometries() {
			interceptor.Invoke("updateEditorGeometries", "updateEditorGeometries()", typeof(void));
		}
		[Q_SLOT("void updateGeometries()")]
		[SmokeMethod("updateGeometries()")]
		protected virtual void UpdateGeometries() {
			interceptor.Invoke("updateGeometries", "updateGeometries()", typeof(void));
		}
		[Q_SLOT("void verticalScrollbarAction(int)")]
		[SmokeMethod("verticalScrollbarAction(int)")]
		protected virtual void VerticalScrollbarAction(int action) {
			interceptor.Invoke("verticalScrollbarAction$", "verticalScrollbarAction(int)", typeof(void), typeof(int), action);
		}
		[Q_SLOT("void horizontalScrollbarAction(int)")]
		[SmokeMethod("horizontalScrollbarAction(int)")]
		protected virtual void HorizontalScrollbarAction(int action) {
			interceptor.Invoke("horizontalScrollbarAction$", "horizontalScrollbarAction(int)", typeof(void), typeof(int), action);
		}
		[Q_SLOT("void verticalScrollbarValueChanged(int)")]
		[SmokeMethod("verticalScrollbarValueChanged(int)")]
		protected virtual void VerticalScrollbarValueChanged(int value) {
			interceptor.Invoke("verticalScrollbarValueChanged$", "verticalScrollbarValueChanged(int)", typeof(void), typeof(int), value);
		}
		[Q_SLOT("void horizontalScrollbarValueChanged(int)")]
		[SmokeMethod("horizontalScrollbarValueChanged(int)")]
		protected virtual void HorizontalScrollbarValueChanged(int value) {
			interceptor.Invoke("horizontalScrollbarValueChanged$", "horizontalScrollbarValueChanged(int)", typeof(void), typeof(int), value);
		}
		[Q_SLOT("void closeEditor(QWidget*, QAbstractItemDelegate::EndEditHint)")]
		[SmokeMethod("closeEditor(QWidget*, QAbstractItemDelegate::EndEditHint)")]
		protected virtual void CloseEditor(QWidget editor, QAbstractItemDelegate.EndEditHint hint) {
			interceptor.Invoke("closeEditor#$", "closeEditor(QWidget*, QAbstractItemDelegate::EndEditHint)", typeof(void), typeof(QWidget), editor, typeof(QAbstractItemDelegate.EndEditHint), hint);
		}
		[Q_SLOT("void commitData(QWidget*)")]
		[SmokeMethod("commitData(QWidget*)")]
		protected virtual void CommitData(QWidget editor) {
			interceptor.Invoke("commitData#", "commitData(QWidget*)", typeof(void), typeof(QWidget), editor);
		}
		[Q_SLOT("void editorDestroyed(QObject*)")]
		[SmokeMethod("editorDestroyed(QObject*)")]
		protected virtual void EditorDestroyed(QObject editor) {
			interceptor.Invoke("editorDestroyed#", "editorDestroyed(QObject*)", typeof(void), typeof(QObject), editor);
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQAbstractItemViewSignals Emit {
			get { return (IQAbstractItemViewSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractItemViewSignals : IQAbstractScrollAreaSignals {
		[Q_SIGNAL("void pressed(const QModelIndex&)")]
		void Pressed(QModelIndex index);
		[Q_SIGNAL("void clicked(const QModelIndex&)")]
		void Clicked(QModelIndex index);
		[Q_SIGNAL("void doubleClicked(const QModelIndex&)")]
		void DoubleClicked(QModelIndex index);
		[Q_SIGNAL("void activated(const QModelIndex&)")]
		void Activated(QModelIndex index);
		[Q_SIGNAL("void entered(const QModelIndex&)")]
		void Entered(QModelIndex index);
		[Q_SIGNAL("void viewportEntered()")]
		void ViewportEntered();
	}
}
