//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQHeaderViewSignals"></see> for signals emitted by QHeaderView
	[SmokeClass("QHeaderView")]
	public class QHeaderView : QAbstractItemView, IDisposable {
 		protected QHeaderView(Type dummy) : base((Type) null) {}
		interface IQHeaderViewProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHeaderView), this);
			_interceptor = (QHeaderView) realProxy.GetTransparentProxy();
		}
		private QHeaderView ProxyQHeaderView() {
			return (QHeaderView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHeaderView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHeaderViewProxy), null);
			_staticInterceptor = (IQHeaderViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQHeaderViewProxy StaticQHeaderView() {
			return (IQHeaderViewProxy) _staticInterceptor;
		}

		public enum ResizeMode {
			Interactive = 0,
			Stretch = 1,
			Fixed = 2,
			Custom = Fixed,
			ResizeToContents = 3,
		}
		public bool ShowSortIndicator {
			get {
				return Property("showSortIndicator").Value<bool>();
			}
			set {
				SetProperty("showSortIndicator", QVariant.FromValue<bool>(value));
			}
		}
		public bool HighlightSections {
			get {
				return Property("highlightSections").Value<bool>();
			}
			set {
				SetProperty("highlightSections", QVariant.FromValue<bool>(value));
			}
		}
		public bool StretchLastSection {
			get {
				return Property("stretchLastSection").Value<bool>();
			}
			set {
				SetProperty("stretchLastSection", QVariant.FromValue<bool>(value));
			}
		}
		public bool CascadingSectionResizes {
			get {
				return Property("cascadingSectionResizes").Value<bool>();
			}
			set {
				SetProperty("cascadingSectionResizes", QVariant.FromValue<bool>(value));
			}
		}
		public int DefaultSectionSize {
			get {
				return Property("defaultSectionSize").Value<int>();
			}
			set {
				SetProperty("defaultSectionSize", QVariant.FromValue<int>(value));
			}
		}
		public int MinimumSectionSize {
			get {
				return Property("minimumSectionSize").Value<int>();
			}
			set {
				SetProperty("minimumSectionSize", QVariant.FromValue<int>(value));
			}
		}
		public int DefaultAlignment {
			get {
				return Property("defaultAlignment").Value<int>();
			}
			set {
				SetProperty("defaultAlignment", QVariant.FromValue<int>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QHeaderView(Qt.Orientation orientation, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQHeaderView(orientation,parent);
		}
		[SmokeMethod("QHeaderView(Qt::Orientation, QWidget*)")]
		private void NewQHeaderView(Qt.Orientation orientation, QWidget parent) {
			ProxyQHeaderView().NewQHeaderView(orientation,parent);
		}
		public QHeaderView(Qt.Orientation orientation) : this((Type) null) {
			CreateProxy();
			NewQHeaderView(orientation);
		}
		[SmokeMethod("QHeaderView(Qt::Orientation)")]
		private void NewQHeaderView(Qt.Orientation orientation) {
			ProxyQHeaderView().NewQHeaderView(orientation);
		}
		[SmokeMethod("setModel(QAbstractItemModel*)")]
		public new void SetModel(QAbstractItemModel model) {
			ProxyQHeaderView().SetModel(model);
		}
		[SmokeMethod("orientation() const")]
		public Qt.Orientation Orientation() {
			return ProxyQHeaderView().Orientation();
		}
		[SmokeMethod("offset() const")]
		public int Offset() {
			return ProxyQHeaderView().Offset();
		}
		[SmokeMethod("length() const")]
		public int Length() {
			return ProxyQHeaderView().Length();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQHeaderView().SizeHint();
		}
		[SmokeMethod("sectionSizeHint(int) const")]
		public int SectionSizeHint(int logicalIndex) {
			return ProxyQHeaderView().SectionSizeHint(logicalIndex);
		}
		[SmokeMethod("visualIndexAt(int) const")]
		public int VisualIndexAt(int position) {
			return ProxyQHeaderView().VisualIndexAt(position);
		}
		[SmokeMethod("logicalIndexAt(int) const")]
		public int LogicalIndexAt(int position) {
			return ProxyQHeaderView().LogicalIndexAt(position);
		}
		[SmokeMethod("logicalIndexAt(int, int) const")]
		public int LogicalIndexAt(int x, int y) {
			return ProxyQHeaderView().LogicalIndexAt(x,y);
		}
		[SmokeMethod("logicalIndexAt(const QPoint&) const")]
		public int LogicalIndexAt(QPoint pos) {
			return ProxyQHeaderView().LogicalIndexAt(pos);
		}
		[SmokeMethod("sectionSize(int) const")]
		public int SectionSize(int logicalIndex) {
			return ProxyQHeaderView().SectionSize(logicalIndex);
		}
		[SmokeMethod("sectionPosition(int) const")]
		public int SectionPosition(int logicalIndex) {
			return ProxyQHeaderView().SectionPosition(logicalIndex);
		}
		[SmokeMethod("sectionViewportPosition(int) const")]
		public int SectionViewportPosition(int logicalIndex) {
			return ProxyQHeaderView().SectionViewportPosition(logicalIndex);
		}
		[SmokeMethod("moveSection(int, int)")]
		public void MoveSection(int from, int to) {
			ProxyQHeaderView().MoveSection(from,to);
		}
		[SmokeMethod("swapSections(int, int)")]
		public void SwapSections(int first, int second) {
			ProxyQHeaderView().SwapSections(first,second);
		}
		[SmokeMethod("resizeSection(int, int)")]
		public void ResizeSection(int logicalIndex, int size) {
			ProxyQHeaderView().ResizeSection(logicalIndex,size);
		}
		[SmokeMethod("resizeSections(QHeaderView::ResizeMode)")]
		public void ResizeSections(QHeaderView.ResizeMode mode) {
			ProxyQHeaderView().ResizeSections(mode);
		}
		[SmokeMethod("isSectionHidden(int) const")]
		public bool IsSectionHidden(int logicalIndex) {
			return ProxyQHeaderView().IsSectionHidden(logicalIndex);
		}
		[SmokeMethod("setSectionHidden(int, bool)")]
		public void SetSectionHidden(int logicalIndex, bool hide) {
			ProxyQHeaderView().SetSectionHidden(logicalIndex,hide);
		}
		[SmokeMethod("hiddenSectionCount() const")]
		public int HiddenSectionCount() {
			return ProxyQHeaderView().HiddenSectionCount();
		}
		[SmokeMethod("hideSection(int)")]
		public void HideSection(int logicalIndex) {
			ProxyQHeaderView().HideSection(logicalIndex);
		}
		[SmokeMethod("showSection(int)")]
		public void ShowSection(int logicalIndex) {
			ProxyQHeaderView().ShowSection(logicalIndex);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQHeaderView().Count();
		}
		[SmokeMethod("visualIndex(int) const")]
		public int VisualIndex(int logicalIndex) {
			return ProxyQHeaderView().VisualIndex(logicalIndex);
		}
		[SmokeMethod("logicalIndex(int) const")]
		public int LogicalIndex(int visualIndex) {
			return ProxyQHeaderView().LogicalIndex(visualIndex);
		}
		[SmokeMethod("setMovable(bool)")]
		public void SetMovable(bool movable) {
			ProxyQHeaderView().SetMovable(movable);
		}
		[SmokeMethod("isMovable() const")]
		public bool IsMovable() {
			return ProxyQHeaderView().IsMovable();
		}
		[SmokeMethod("setClickable(bool)")]
		public void SetClickable(bool clickable) {
			ProxyQHeaderView().SetClickable(clickable);
		}
		[SmokeMethod("isClickable() const")]
		public bool IsClickable() {
			return ProxyQHeaderView().IsClickable();
		}
		[SmokeMethod("setResizeMode(QHeaderView::ResizeMode)")]
		public void SetResizeMode(QHeaderView.ResizeMode mode) {
			ProxyQHeaderView().SetResizeMode(mode);
		}
		[SmokeMethod("setResizeMode(int, QHeaderView::ResizeMode)")]
		public void SetResizeMode(int logicalIndex, QHeaderView.ResizeMode mode) {
			ProxyQHeaderView().SetResizeMode(logicalIndex,mode);
		}
		[SmokeMethod("resizeMode(int) const")]
		public QHeaderView.ResizeMode resizeMode(int logicalIndex) {
			return ProxyQHeaderView().resizeMode(logicalIndex);
		}
		[SmokeMethod("stretchSectionCount() const")]
		public int StretchSectionCount() {
			return ProxyQHeaderView().StretchSectionCount();
		}
		[SmokeMethod("setSortIndicatorShown(bool)")]
		public void SetSortIndicatorShown(bool show) {
			ProxyQHeaderView().SetSortIndicatorShown(show);
		}
		[SmokeMethod("isSortIndicatorShown() const")]
		public bool IsSortIndicatorShown() {
			return ProxyQHeaderView().IsSortIndicatorShown();
		}
		[SmokeMethod("setSortIndicator(int, Qt::SortOrder)")]
		public void SetSortIndicator(int logicalIndex, Qt.SortOrder order) {
			ProxyQHeaderView().SetSortIndicator(logicalIndex,order);
		}
		[SmokeMethod("sortIndicatorSection() const")]
		public int SortIndicatorSection() {
			return ProxyQHeaderView().SortIndicatorSection();
		}
		[SmokeMethod("sortIndicatorOrder() const")]
		public Qt.SortOrder SortIndicatorOrder() {
			return ProxyQHeaderView().SortIndicatorOrder();
		}
		[SmokeMethod("doItemsLayout()")]
		public new void DoItemsLayout() {
			ProxyQHeaderView().DoItemsLayout();
		}
		[SmokeMethod("sectionsMoved() const")]
		public bool SectionsMoved() {
			return ProxyQHeaderView().SectionsMoved();
		}
		[SmokeMethod("sectionsHidden() const")]
		public bool SectionsHidden() {
			return ProxyQHeaderView().SectionsHidden();
		}
		[SmokeMethod("setOffset(int)")]
		public void SetOffset(int offset) {
			ProxyQHeaderView().SetOffset(offset);
		}
		[SmokeMethod("setOffsetToSectionPosition(int)")]
		public void SetOffsetToSectionPosition(int visualIndex) {
			ProxyQHeaderView().SetOffsetToSectionPosition(visualIndex);
		}
		[SmokeMethod("headerDataChanged(Qt::Orientation, int, int)")]
		public void HeaderDataChanged(Qt.Orientation orientation, int logicalFirst, int logicalLast) {
			ProxyQHeaderView().HeaderDataChanged(orientation,logicalFirst,logicalLast);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQHeaderView().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQHeaderView().Tr(s);
		}
		[SmokeMethod("updateSection(int)")]
		protected void UpdateSection(int logicalIndex) {
			ProxyQHeaderView().UpdateSection(logicalIndex);
		}
		[SmokeMethod("resizeSections()")]
		protected void ResizeSections() {
			ProxyQHeaderView().ResizeSections();
		}
		[SmokeMethod("sectionsInserted(const QModelIndex&, int, int)")]
		protected void SectionsInserted(QModelIndex parent, int logicalFirst, int logicalLast) {
			ProxyQHeaderView().SectionsInserted(parent,logicalFirst,logicalLast);
		}
		[SmokeMethod("sectionsAboutToBeRemoved(const QModelIndex&, int, int)")]
		protected void SectionsAboutToBeRemoved(QModelIndex parent, int logicalFirst, int logicalLast) {
			ProxyQHeaderView().SectionsAboutToBeRemoved(parent,logicalFirst,logicalLast);
		}
		[SmokeMethod("initialize()")]
		protected void Initialize() {
			ProxyQHeaderView().Initialize();
		}
		[SmokeMethod("initializeSections()")]
		protected void InitializeSections() {
			ProxyQHeaderView().InitializeSections();
		}
		[SmokeMethod("initializeSections(int, int)")]
		protected void InitializeSections(int start, int end) {
			ProxyQHeaderView().InitializeSections(start,end);
		}
		[SmokeMethod("currentChanged(const QModelIndex&, const QModelIndex&)")]
		protected new void CurrentChanged(QModelIndex current, QModelIndex old) {
			ProxyQHeaderView().CurrentChanged(current,old);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQHeaderView().Event(e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent e) {
			ProxyQHeaderView().PaintEvent(e);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent e) {
			ProxyQHeaderView().MousePressEvent(e);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent e) {
			ProxyQHeaderView().MouseMoveEvent(e);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent e) {
			ProxyQHeaderView().MouseReleaseEvent(e);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected new void MouseDoubleClickEvent(QMouseEvent e) {
			ProxyQHeaderView().MouseDoubleClickEvent(e);
		}
		[SmokeMethod("viewportEvent(QEvent*)")]
		protected new bool ViewportEvent(QEvent e) {
			return ProxyQHeaderView().ViewportEvent(e);
		}
		[SmokeMethod("paintSection(QPainter*, const QRect&, int) const")]
		protected virtual void PaintSection(QPainter painter, QRect rect, int logicalIndex) {
			ProxyQHeaderView().PaintSection(painter,rect,logicalIndex);
		}
		[SmokeMethod("sectionSizeFromContents(int) const")]
		protected virtual QSize SectionSizeFromContents(int logicalIndex) {
			return ProxyQHeaderView().SectionSizeFromContents(logicalIndex);
		}
		[SmokeMethod("horizontalOffset() const")]
		protected new int HorizontalOffset() {
			return ProxyQHeaderView().HorizontalOffset();
		}
		[SmokeMethod("verticalOffset() const")]
		protected new int VerticalOffset() {
			return ProxyQHeaderView().VerticalOffset();
		}
		[SmokeMethod("updateGeometries()")]
		protected new void UpdateGeometries() {
			ProxyQHeaderView().UpdateGeometries();
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected new void ScrollContentsBy(int dx, int dy) {
			ProxyQHeaderView().ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("dataChanged(const QModelIndex&, const QModelIndex&)")]
		protected new void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			ProxyQHeaderView().DataChanged(topLeft,bottomRight);
		}
		[SmokeMethod("rowsInserted(const QModelIndex&, int, int)")]
		protected new void RowsInserted(QModelIndex parent, int start, int end) {
			ProxyQHeaderView().RowsInserted(parent,start,end);
		}
		[SmokeMethod("visualRect(const QModelIndex&) const")]
		protected new QRect VisualRect(QModelIndex index) {
			return ProxyQHeaderView().VisualRect(index);
		}
		[SmokeMethod("scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)")]
		protected new void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			ProxyQHeaderView().ScrollTo(index,hint);
		}
		[SmokeMethod("indexAt(const QPoint&) const")]
		protected new QModelIndex IndexAt(QPoint p) {
			return ProxyQHeaderView().IndexAt(p);
		}
		[SmokeMethod("isIndexHidden(const QModelIndex&) const")]
		protected new bool IsIndexHidden(QModelIndex index) {
			return ProxyQHeaderView().IsIndexHidden(index);
		}
		[SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected new QModelIndex MoveCursor(QAbstractItemView.CursorAction arg1, int arg2) {
			return ProxyQHeaderView().MoveCursor(arg1,arg2);
		}
		[SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected new void SetSelection(QRect arg1, int arg2) {
			ProxyQHeaderView().SetSelection(arg1,arg2);
		}
		[SmokeMethod("visualRegionForSelection(const QItemSelection&) const")]
		protected new QRegion VisualRegionForSelection(QItemSelection selection) {
			return ProxyQHeaderView().VisualRegionForSelection(selection);
		}
		~QHeaderView() {
			DisposeQHeaderView();
		}
		public new void Dispose() {
			DisposeQHeaderView();
		}
		[SmokeMethod("~QHeaderView()")]
		private void DisposeQHeaderView() {
			ProxyQHeaderView().DisposeQHeaderView();
		}
		protected new IQHeaderViewSignals Emit {
			get {
				return (IQHeaderViewSignals) Q_EMIT;
			}
		}
	}

	public interface IQHeaderViewSignals : IQAbstractItemViewSignals {
		[Q_SIGNAL("void sectionMoved(int, int, int)")]
		void SectionMoved(int logicalIndex, int oldVisualIndex, int newVisualIndex);
		[Q_SIGNAL("void sectionResized(int, int, int)")]
		void SectionResized(int logicalIndex, int oldSize, int newSize);
		[Q_SIGNAL("void sectionPressed(int)")]
		void SectionPressed(int logicalIndex);
		[Q_SIGNAL("void sectionClicked(int)")]
		void SectionClicked(int logicalIndex);
		[Q_SIGNAL("void sectionDoubleClicked(int)")]
		void SectionDoubleClicked(int logicalIndex);
		[Q_SIGNAL("void sectionCountChanged(int, int)")]
		void SectionCountChanged(int oldCount, int newCount);
		[Q_SIGNAL("void sectionHandleDoubleClicked(int)")]
		void SectionHandleDoubleClicked(int logicalIndex);
		[Q_SIGNAL("void sectionAutoResize(int, QHeaderView::ResizeMode)")]
		void SectionAutoResize(int logicalIndex, QHeaderView.ResizeMode mode);
		[Q_SIGNAL("void geometriesChanged()")]
		void GeometriesChanged();
	}
}
