//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	///<remarks> See <see cref="IQGraphicsTextItemSignals"></see> for signals emitted by QGraphicsTextItem
	///</remarks>

	[SmokeClass("QGraphicsTextItem")]
	public class QGraphicsTextItem : QObject, IQGraphicsItem, IDisposable {
 		protected QGraphicsTextItem(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGraphicsTextItem), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QGraphicsTextItem() {
			staticInterceptor = new SmokeInvocation(typeof(QGraphicsTextItem), null);
		}
		public new const int Type = 8;

		public QGraphicsTextItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsTextItem##", "QGraphicsTextItem(QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsTextItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsTextItem#", "QGraphicsTextItem(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), parent);
		}
		public QGraphicsTextItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsTextItem", "QGraphicsTextItem()", typeof(void));
		}
		public QGraphicsTextItem(string text, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsTextItem$##", "QGraphicsTextItem(const QString&, QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(string), text, typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsTextItem(string text, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsTextItem$#", "QGraphicsTextItem(const QString&, QGraphicsItem*)", typeof(void), typeof(string), text, typeof(QGraphicsItem), parent);
		}
		public QGraphicsTextItem(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsTextItem$", "QGraphicsTextItem(const QString&)", typeof(void), typeof(string), text);
		}
		public string ToHtml() {
			return (string) interceptor.Invoke("toHtml", "toHtml() const", typeof(string));
		}
		public void SetHtml(string html) {
			interceptor.Invoke("setHtml$", "setHtml(const QString&)", typeof(void), typeof(string), html);
		}
		public string ToPlainText() {
			return (string) interceptor.Invoke("toPlainText", "toPlainText() const", typeof(string));
		}
		public void SetPlainText(string text) {
			interceptor.Invoke("setPlainText$", "setPlainText(const QString&)", typeof(void), typeof(string), text);
		}
		public QFont Font() {
			return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
		}
		public void SetFont(QFont font) {
			interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
		}
		public void SetDefaultTextColor(QColor c) {
			interceptor.Invoke("setDefaultTextColor#", "setDefaultTextColor(const QColor&)", typeof(void), typeof(QColor), c);
		}
		public QColor DefaultTextColor() {
			return (QColor) interceptor.Invoke("defaultTextColor", "defaultTextColor() const", typeof(QColor));
		}
		[SmokeMethod("boundingRect() const")]
		public virtual QRectF BoundingRect() {
			return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
		}
		[SmokeMethod("shape() const")]
		public virtual QPainterPath Shape() {
			return (QPainterPath) interceptor.Invoke("shape", "shape() const", typeof(QPainterPath));
		}
		[SmokeMethod("contains(const QPointF&) const")]
		public virtual bool Contains(QPointF point) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPointF&) const", typeof(bool), typeof(QPointF), point);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
		}
		[SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
		public virtual bool IsObscuredBy(QGraphicsItem item) {
			return (bool) interceptor.Invoke("isObscuredBy#", "isObscuredBy(const QGraphicsItem*) const", typeof(bool), typeof(QGraphicsItem), item);
		}
		[SmokeMethod("opaqueArea() const")]
		public virtual QPainterPath OpaqueArea() {
			return (QPainterPath) interceptor.Invoke("opaqueArea", "opaqueArea() const", typeof(QPainterPath));
		}
		[SmokeMethod("type() const")]
		public virtual int type() {
			return (int) interceptor.Invoke("type", "type() const", typeof(int));
		}
		public void SetTextWidth(double width) {
			interceptor.Invoke("setTextWidth$", "setTextWidth(qreal)", typeof(void), typeof(double), width);
		}
		public double TextWidth() {
			return (double) interceptor.Invoke("textWidth", "textWidth() const", typeof(double));
		}
		public void AdjustSize() {
			interceptor.Invoke("adjustSize", "adjustSize()", typeof(void));
		}
		public void SetDocument(QTextDocument document) {
			interceptor.Invoke("setDocument#", "setDocument(QTextDocument*)", typeof(void), typeof(QTextDocument), document);
		}
		public QTextDocument Document() {
			return (QTextDocument) interceptor.Invoke("document", "document() const", typeof(QTextDocument));
		}
		public void SetTextInteractionFlags(int flags) {
			interceptor.Invoke("setTextInteractionFlags$", "setTextInteractionFlags(Qt::TextInteractionFlags)", typeof(void), typeof(int), flags);
		}
		public int TextInteractionFlags() {
			return (int) interceptor.Invoke("textInteractionFlags", "textInteractionFlags() const", typeof(int));
		}
		public void SetOpenExternalLinks(bool open) {
			interceptor.Invoke("setOpenExternalLinks$", "setOpenExternalLinks(bool)", typeof(void), typeof(bool), open);
		}
		public bool OpenExternalLinks() {
			return (bool) interceptor.Invoke("openExternalLinks", "openExternalLinks() const", typeof(bool));
		}
		public void SetTextCursor(QTextCursor cursor) {
			interceptor.Invoke("setTextCursor#", "setTextCursor(const QTextCursor&)", typeof(void), typeof(QTextCursor), cursor);
		}
		public QTextCursor TextCursor() {
			return (QTextCursor) interceptor.Invoke("textCursor", "textCursor() const", typeof(QTextCursor));
		}
		[SmokeMethod("sceneEvent(QEvent*)")]
		protected virtual bool SceneEvent(QEvent arg1) {
			return (bool) interceptor.Invoke("sceneEvent#", "sceneEvent(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QGraphicsSceneMouseEvent*)")]
		protected virtual void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("mouseMoveEvent(QGraphicsSceneMouseEvent*)")]
		protected virtual void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QGraphicsSceneMouseEvent*)")]
		protected virtual void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)")]
		protected virtual void MouseDoubleClickEvent(QGraphicsSceneMouseEvent arg1) {
			interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
		}
		[SmokeMethod("contextMenuEvent(QGraphicsSceneContextMenuEvent*)")]
		protected virtual void ContextMenuEvent(QGraphicsSceneContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QGraphicsSceneContextMenuEvent*)", typeof(void), typeof(QGraphicsSceneContextMenuEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected virtual void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected virtual void KeyReleaseEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyReleaseEvent#", "keyReleaseEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected virtual void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected virtual void FocusOutEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("dragEnterEvent(QGraphicsSceneDragDropEvent*)")]
		protected virtual void DragEnterEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("dragLeaveEvent(QGraphicsSceneDragDropEvent*)")]
		protected virtual void DragLeaveEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("dragMoveEvent(QGraphicsSceneDragDropEvent*)")]
		protected virtual void DragMoveEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("dropEvent(QGraphicsSceneDragDropEvent*)")]
		protected virtual void DropEvent(QGraphicsSceneDragDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QGraphicsSceneDragDropEvent*)", typeof(void), typeof(QGraphicsSceneDragDropEvent), arg1);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected virtual void InputMethodEvent(QInputMethodEvent arg1) {
			interceptor.Invoke("inputMethodEvent#", "inputMethodEvent(QInputMethodEvent*)", typeof(void), typeof(QInputMethodEvent), arg1);
		}
		[SmokeMethod("hoverEnterEvent(QGraphicsSceneHoverEvent*)")]
		protected virtual void HoverEnterEvent(QGraphicsSceneHoverEvent arg1) {
			interceptor.Invoke("hoverEnterEvent#", "hoverEnterEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
		}
		[SmokeMethod("hoverMoveEvent(QGraphicsSceneHoverEvent*)")]
		protected virtual void HoverMoveEvent(QGraphicsSceneHoverEvent arg1) {
			interceptor.Invoke("hoverMoveEvent#", "hoverMoveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
		}
		[SmokeMethod("hoverLeaveEvent(QGraphicsSceneHoverEvent*)")]
		protected virtual void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
			interceptor.Invoke("hoverLeaveEvent#", "hoverLeaveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		protected virtual QVariant InputMethodQuery(Qt.InputMethodQuery query) {
			return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), query);
		}
		[SmokeMethod("supportsExtension(QGraphicsItem::Extension) const")]
		protected virtual bool SupportsExtension(QGraphicsItem.Extension extension) {
			return (bool) interceptor.Invoke("supportsExtension$", "supportsExtension(QGraphicsItem::Extension) const", typeof(bool), typeof(QGraphicsItem.Extension), extension);
		}
		[SmokeMethod("setExtension(QGraphicsItem::Extension, const QVariant&)")]
		protected virtual void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			interceptor.Invoke("setExtension$#", "setExtension(QGraphicsItem::Extension, const QVariant&)", typeof(void), typeof(QGraphicsItem.Extension), extension, typeof(QVariant), variant);
		}
		[SmokeMethod("extension(const QVariant&) const")]
		protected virtual QVariant extension(QVariant variant) {
			return (QVariant) interceptor.Invoke("extension#", "extension(const QVariant&) const", typeof(QVariant), typeof(QVariant), variant);
		}
		~QGraphicsTextItem() {
			interceptor.Invoke("~QGraphicsTextItem", "~QGraphicsTextItem()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QGraphicsTextItem", "~QGraphicsTextItem()", typeof(void));
		}
		public QGraphicsScene Scene() {
			return (QGraphicsScene) interceptor.Invoke("scene", "scene() const", typeof(QGraphicsScene));
		}
		public QGraphicsItem ParentItem() {
			return (QGraphicsItem) interceptor.Invoke("parentItem", "parentItem() const", typeof(QGraphicsItem));
		}
		public QGraphicsItem TopLevelItem() {
			return (QGraphicsItem) interceptor.Invoke("topLevelItem", "topLevelItem() const", typeof(QGraphicsItem));
		}
		public void SetParentItem(QGraphicsItem parent) {
			interceptor.Invoke("setParentItem#", "setParentItem(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), parent);
		}
		public List<QGraphicsItem> Children() {
			return (List<QGraphicsItem>) interceptor.Invoke("children", "children() const", typeof(List<QGraphicsItem>));
		}
		public QGraphicsItemGroup Group() {
			return (QGraphicsItemGroup) interceptor.Invoke("group", "group() const", typeof(QGraphicsItemGroup));
		}
		public void SetGroup(QGraphicsItemGroup group) {
			interceptor.Invoke("setGroup#", "setGroup(QGraphicsItemGroup*)", typeof(void), typeof(QGraphicsItemGroup), group);
		}
		public int Flags() {
			return (int) interceptor.Invoke("flags", "flags() const", typeof(int));
		}
		public void SetFlag(QGraphicsItem.GraphicsItemFlag flag, bool enabled) {
			interceptor.Invoke("setFlag$$", "setFlag(QGraphicsItem::GraphicsItemFlag, bool)", typeof(void), typeof(QGraphicsItem.GraphicsItemFlag), flag, typeof(bool), enabled);
		}
		public void SetFlag(QGraphicsItem.GraphicsItemFlag flag) {
			interceptor.Invoke("setFlag$", "setFlag(QGraphicsItem::GraphicsItemFlag)", typeof(void), typeof(QGraphicsItem.GraphicsItemFlag), flag);
		}
		public void SetFlags(int flags) {
			interceptor.Invoke("setFlags$", "setFlags(GraphicsItemFlags)", typeof(void), typeof(int), flags);
		}
		public string ToolTip() {
			return (string) interceptor.Invoke("toolTip", "toolTip() const", typeof(string));
		}
		public void SetToolTip(string toolTip) {
			interceptor.Invoke("setToolTip$", "setToolTip(const QString&)", typeof(void), typeof(string), toolTip);
		}
		public QCursor Cursor() {
			return (QCursor) interceptor.Invoke("cursor", "cursor() const", typeof(QCursor));
		}
		public void SetCursor(QCursor cursor) {
			interceptor.Invoke("setCursor#", "setCursor(const QCursor&)", typeof(void), typeof(QCursor), cursor);
		}
		public bool HasCursor() {
			return (bool) interceptor.Invoke("hasCursor", "hasCursor() const", typeof(bool));
		}
		public void UnsetCursor() {
			interceptor.Invoke("unsetCursor", "unsetCursor()", typeof(void));
		}
		public bool IsVisible() {
			return (bool) interceptor.Invoke("isVisible", "isVisible() const", typeof(bool));
		}
		public void SetVisible(bool visible) {
			interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
		}
		public void Hide() {
			interceptor.Invoke("hide", "hide()", typeof(void));
		}
		public void Show() {
			interceptor.Invoke("show", "show()", typeof(void));
		}
		public bool IsEnabled() {
			return (bool) interceptor.Invoke("isEnabled", "isEnabled() const", typeof(bool));
		}
		public void SetEnabled(bool enabled) {
			interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), enabled);
		}
		public bool IsSelected() {
			return (bool) interceptor.Invoke("isSelected", "isSelected() const", typeof(bool));
		}
		public void SetSelected(bool selected) {
			interceptor.Invoke("setSelected$", "setSelected(bool)", typeof(void), typeof(bool), selected);
		}
		public bool AcceptDrops() {
			return (bool) interceptor.Invoke("acceptDrops", "acceptDrops() const", typeof(bool));
		}
		public void SetAcceptDrops(bool on) {
			interceptor.Invoke("setAcceptDrops$", "setAcceptDrops(bool)", typeof(void), typeof(bool), on);
		}
		public int AcceptedMouseButtons() {
			return (int) interceptor.Invoke("acceptedMouseButtons", "acceptedMouseButtons() const", typeof(int));
		}
		public void SetAcceptedMouseButtons(int buttons) {
			interceptor.Invoke("setAcceptedMouseButtons$", "setAcceptedMouseButtons(Qt::MouseButtons)", typeof(void), typeof(int), buttons);
		}
		public bool AcceptsHoverEvents() {
			return (bool) interceptor.Invoke("acceptsHoverEvents", "acceptsHoverEvents() const", typeof(bool));
		}
		public void SetAcceptsHoverEvents(bool enabled) {
			interceptor.Invoke("setAcceptsHoverEvents$", "setAcceptsHoverEvents(bool)", typeof(void), typeof(bool), enabled);
		}
		public bool HandlesChildEvents() {
			return (bool) interceptor.Invoke("handlesChildEvents", "handlesChildEvents() const", typeof(bool));
		}
		public void SetHandlesChildEvents(bool enabled) {
			interceptor.Invoke("setHandlesChildEvents$", "setHandlesChildEvents(bool)", typeof(void), typeof(bool), enabled);
		}
		public bool HasFocus() {
			return (bool) interceptor.Invoke("hasFocus", "hasFocus() const", typeof(bool));
		}
		public void SetFocus(Qt.FocusReason focusReason) {
			interceptor.Invoke("setFocus$", "setFocus(Qt::FocusReason)", typeof(void), typeof(Qt.FocusReason), focusReason);
		}
		public void SetFocus() {
			interceptor.Invoke("setFocus", "setFocus()", typeof(void));
		}
		public void ClearFocus() {
			interceptor.Invoke("clearFocus", "clearFocus()", typeof(void));
		}
		public QPointF Pos() {
			return (QPointF) interceptor.Invoke("pos", "pos() const", typeof(QPointF));
		}
		public double X() {
			return (double) interceptor.Invoke("x", "x() const", typeof(double));
		}
		public double Y() {
			return (double) interceptor.Invoke("y", "y() const", typeof(double));
		}
		public QPointF ScenePos() {
			return (QPointF) interceptor.Invoke("scenePos", "scenePos() const", typeof(QPointF));
		}
		public void SetPos(QPointF pos) {
			interceptor.Invoke("setPos#", "setPos(const QPointF&)", typeof(void), typeof(QPointF), pos);
		}
		public void SetPos(double x, double y) {
			interceptor.Invoke("setPos$$", "setPos(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		public void MoveBy(double dx, double dy) {
			interceptor.Invoke("moveBy$$", "moveBy(qreal, qreal)", typeof(void), typeof(double), dx, typeof(double), dy);
		}
		public void EnsureVisible(QRectF rect, int xmargin, int ymargin) {
			interceptor.Invoke("ensureVisible#$$", "ensureVisible(const QRectF&, int, int)", typeof(void), typeof(QRectF), rect, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureVisible(QRectF rect, int xmargin) {
			interceptor.Invoke("ensureVisible#$", "ensureVisible(const QRectF&, int)", typeof(void), typeof(QRectF), rect, typeof(int), xmargin);
		}
		public void EnsureVisible(QRectF rect) {
			interceptor.Invoke("ensureVisible#", "ensureVisible(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void EnsureVisible() {
			interceptor.Invoke("ensureVisible", "ensureVisible()", typeof(void));
		}
		public void EnsureVisible(double x, double y, double w, double h, int xmargin, int ymargin) {
			interceptor.Invoke("ensureVisible$$$$$$", "ensureVisible(qreal, qreal, qreal, qreal, int, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureVisible(double x, double y, double w, double h, int xmargin) {
			interceptor.Invoke("ensureVisible$$$$$", "ensureVisible(qreal, qreal, qreal, qreal, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(int), xmargin);
		}
		public void EnsureVisible(double x, double y, double w, double h) {
			interceptor.Invoke("ensureVisible$$$$", "ensureVisible(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QMatrix Matrix() {
			return (QMatrix) interceptor.Invoke("matrix", "matrix() const", typeof(QMatrix));
		}
		public QMatrix SceneMatrix() {
			return (QMatrix) interceptor.Invoke("sceneMatrix", "sceneMatrix() const", typeof(QMatrix));
		}
		public void SetMatrix(QMatrix matrix, bool combine) {
			interceptor.Invoke("setMatrix#$", "setMatrix(const QMatrix&, bool)", typeof(void), typeof(QMatrix), matrix, typeof(bool), combine);
		}
		public void SetMatrix(QMatrix matrix) {
			interceptor.Invoke("setMatrix#", "setMatrix(const QMatrix&)", typeof(void), typeof(QMatrix), matrix);
		}
		public void ResetMatrix() {
			interceptor.Invoke("resetMatrix", "resetMatrix()", typeof(void));
		}
		public QTransform Transform() {
			return (QTransform) interceptor.Invoke("transform", "transform() const", typeof(QTransform));
		}
		public QTransform SceneTransform() {
			return (QTransform) interceptor.Invoke("sceneTransform", "sceneTransform() const", typeof(QTransform));
		}
		public QTransform DeviceTransform(QTransform viewportTransform) {
			return (QTransform) interceptor.Invoke("deviceTransform#", "deviceTransform(const QTransform&) const", typeof(QTransform), typeof(QTransform), viewportTransform);
		}
		public void SetTransform(QTransform matrix, bool combine) {
			interceptor.Invoke("setTransform#$", "setTransform(const QTransform&, bool)", typeof(void), typeof(QTransform), matrix, typeof(bool), combine);
		}
		public void SetTransform(QTransform matrix) {
			interceptor.Invoke("setTransform#", "setTransform(const QTransform&)", typeof(void), typeof(QTransform), matrix);
		}
		public void ResetTransform() {
			interceptor.Invoke("resetTransform", "resetTransform()", typeof(void));
		}
		public void Rotate(double angle) {
			interceptor.Invoke("rotate$", "rotate(qreal)", typeof(void), typeof(double), angle);
		}
		public void Scale(double sx, double sy) {
			interceptor.Invoke("scale$$", "scale(qreal, qreal)", typeof(void), typeof(double), sx, typeof(double), sy);
		}
		public void Shear(double sh, double sv) {
			interceptor.Invoke("shear$$", "shear(qreal, qreal)", typeof(void), typeof(double), sh, typeof(double), sv);
		}
		public void Translate(double dx, double dy) {
			interceptor.Invoke("translate$$", "translate(qreal, qreal)", typeof(void), typeof(double), dx, typeof(double), dy);
		}
		[SmokeMethod("advance(int)")]
		public virtual void Advance(int phase) {
			interceptor.Invoke("advance$", "advance(int)", typeof(void), typeof(int), phase);
		}
		public double ZValue() {
			return (double) interceptor.Invoke("zValue", "zValue() const", typeof(double));
		}
		public void SetZValue(double z) {
			interceptor.Invoke("setZValue$", "setZValue(qreal)", typeof(void), typeof(double), z);
		}
		public QRectF ChildrenBoundingRect() {
			return (QRectF) interceptor.Invoke("childrenBoundingRect", "childrenBoundingRect() const", typeof(QRectF));
		}
		public QRectF SceneBoundingRect() {
			return (QRectF) interceptor.Invoke("sceneBoundingRect", "sceneBoundingRect() const", typeof(QRectF));
		}
		[SmokeMethod("collidesWithItem(const QGraphicsItem*, Qt::ItemSelectionMode) const")]
		public virtual bool CollidesWithItem(QGraphicsItem other, Qt.ItemSelectionMode mode) {
			return (bool) interceptor.Invoke("collidesWithItem#$", "collidesWithItem(const QGraphicsItem*, Qt::ItemSelectionMode) const", typeof(bool), typeof(QGraphicsItem), other, typeof(Qt.ItemSelectionMode), mode);
		}
		[SmokeMethod("collidesWithItem(const QGraphicsItem*) const")]
		public virtual bool CollidesWithItem(QGraphicsItem other) {
			return (bool) interceptor.Invoke("collidesWithItem#", "collidesWithItem(const QGraphicsItem*) const", typeof(bool), typeof(QGraphicsItem), other);
		}
		[SmokeMethod("collidesWithPath(const QPainterPath&, Qt::ItemSelectionMode) const")]
		public virtual bool CollidesWithPath(QPainterPath path, Qt.ItemSelectionMode mode) {
			return (bool) interceptor.Invoke("collidesWithPath#$", "collidesWithPath(const QPainterPath&, Qt::ItemSelectionMode) const", typeof(bool), typeof(QPainterPath), path, typeof(Qt.ItemSelectionMode), mode);
		}
		[SmokeMethod("collidesWithPath(const QPainterPath&) const")]
		public virtual bool CollidesWithPath(QPainterPath path) {
			return (bool) interceptor.Invoke("collidesWithPath#", "collidesWithPath(const QPainterPath&) const", typeof(bool), typeof(QPainterPath), path);
		}
		public List<QGraphicsItem> CollidingItems(Qt.ItemSelectionMode mode) {
			return (List<QGraphicsItem>) interceptor.Invoke("collidingItems$", "collidingItems(Qt::ItemSelectionMode) const", typeof(List<QGraphicsItem>), typeof(Qt.ItemSelectionMode), mode);
		}
		public List<QGraphicsItem> CollidingItems() {
			return (List<QGraphicsItem>) interceptor.Invoke("collidingItems", "collidingItems() const", typeof(List<QGraphicsItem>));
		}
		public bool IsObscured() {
			return (bool) interceptor.Invoke("isObscured", "isObscured() const", typeof(bool));
		}
		public bool IsObscured(QRectF rect) {
			return (bool) interceptor.Invoke("isObscured#", "isObscured(const QRectF&) const", typeof(bool), typeof(QRectF), rect);
		}
		public bool IsObscured(double x, double y, double w, double h) {
			return (bool) interceptor.Invoke("isObscured$$$$", "isObscured(qreal, qreal, qreal, qreal) const", typeof(bool), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*)")]
		public virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			interceptor.Invoke("paint##", "paint(QPainter*, const QStyleOptionGraphicsItem*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option);
		}
		public void Update(QRectF rect) {
			interceptor.Invoke("update#", "update(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void Update() {
			interceptor.Invoke("update", "update()", typeof(void));
		}
		public void Update(double x, double y, double width, double height) {
			interceptor.Invoke("update$$$$", "update(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), width, typeof(double), height);
		}
		public QPointF MapToItem(QGraphicsItem item, QPointF point) {
			return (QPointF) interceptor.Invoke("mapToItem##", "mapToItem(const QGraphicsItem*, const QPointF&) const", typeof(QPointF), typeof(QGraphicsItem), item, typeof(QPointF), point);
		}
		public QPointF MapToParent(QPointF point) {
			return (QPointF) interceptor.Invoke("mapToParent#", "mapToParent(const QPointF&) const", typeof(QPointF), typeof(QPointF), point);
		}
		public QPointF MapToScene(QPointF point) {
			return (QPointF) interceptor.Invoke("mapToScene#", "mapToScene(const QPointF&) const", typeof(QPointF), typeof(QPointF), point);
		}
		public QPolygonF MapToItem(QGraphicsItem item, QRectF rect) {
			return (QPolygonF) interceptor.Invoke("mapToItem##", "mapToItem(const QGraphicsItem*, const QRectF&) const", typeof(QPolygonF), typeof(QGraphicsItem), item, typeof(QRectF), rect);
		}
		public QPolygonF MapToParent(QRectF rect) {
			return (QPolygonF) interceptor.Invoke("mapToParent#", "mapToParent(const QRectF&) const", typeof(QPolygonF), typeof(QRectF), rect);
		}
		public QPolygonF MapToScene(QRectF rect) {
			return (QPolygonF) interceptor.Invoke("mapToScene#", "mapToScene(const QRectF&) const", typeof(QPolygonF), typeof(QRectF), rect);
		}
		public QPolygonF MapToItem(QGraphicsItem item, QPolygonF polygon) {
			return (QPolygonF) interceptor.Invoke("mapToItem##", "mapToItem(const QGraphicsItem*, const QPolygonF&) const", typeof(QPolygonF), typeof(QGraphicsItem), item, typeof(QPolygonF), polygon);
		}
		public QPolygonF MapToParent(QPolygonF polygon) {
			return (QPolygonF) interceptor.Invoke("mapToParent#", "mapToParent(const QPolygonF&) const", typeof(QPolygonF), typeof(QPolygonF), polygon);
		}
		public QPolygonF MapToScene(QPolygonF polygon) {
			return (QPolygonF) interceptor.Invoke("mapToScene#", "mapToScene(const QPolygonF&) const", typeof(QPolygonF), typeof(QPolygonF), polygon);
		}
		public QPainterPath MapToItem(QGraphicsItem item, QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapToItem##", "mapToItem(const QGraphicsItem*, const QPainterPath&) const", typeof(QPainterPath), typeof(QGraphicsItem), item, typeof(QPainterPath), path);
		}
		public QPainterPath MapToParent(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapToParent#", "mapToParent(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		public QPainterPath MapToScene(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapToScene#", "mapToScene(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		public QPointF MapFromItem(QGraphicsItem item, QPointF point) {
			return (QPointF) interceptor.Invoke("mapFromItem##", "mapFromItem(const QGraphicsItem*, const QPointF&) const", typeof(QPointF), typeof(QGraphicsItem), item, typeof(QPointF), point);
		}
		public QPointF MapFromParent(QPointF point) {
			return (QPointF) interceptor.Invoke("mapFromParent#", "mapFromParent(const QPointF&) const", typeof(QPointF), typeof(QPointF), point);
		}
		public QPointF MapFromScene(QPointF point) {
			return (QPointF) interceptor.Invoke("mapFromScene#", "mapFromScene(const QPointF&) const", typeof(QPointF), typeof(QPointF), point);
		}
		public QPolygonF MapFromItem(QGraphicsItem item, QRectF rect) {
			return (QPolygonF) interceptor.Invoke("mapFromItem##", "mapFromItem(const QGraphicsItem*, const QRectF&) const", typeof(QPolygonF), typeof(QGraphicsItem), item, typeof(QRectF), rect);
		}
		public QPolygonF MapFromParent(QRectF rect) {
			return (QPolygonF) interceptor.Invoke("mapFromParent#", "mapFromParent(const QRectF&) const", typeof(QPolygonF), typeof(QRectF), rect);
		}
		public QPolygonF MapFromScene(QRectF rect) {
			return (QPolygonF) interceptor.Invoke("mapFromScene#", "mapFromScene(const QRectF&) const", typeof(QPolygonF), typeof(QRectF), rect);
		}
		public QPolygonF MapFromItem(QGraphicsItem item, QPolygonF polygon) {
			return (QPolygonF) interceptor.Invoke("mapFromItem##", "mapFromItem(const QGraphicsItem*, const QPolygonF&) const", typeof(QPolygonF), typeof(QGraphicsItem), item, typeof(QPolygonF), polygon);
		}
		public QPolygonF MapFromParent(QPolygonF polygon) {
			return (QPolygonF) interceptor.Invoke("mapFromParent#", "mapFromParent(const QPolygonF&) const", typeof(QPolygonF), typeof(QPolygonF), polygon);
		}
		public QPolygonF MapFromScene(QPolygonF polygon) {
			return (QPolygonF) interceptor.Invoke("mapFromScene#", "mapFromScene(const QPolygonF&) const", typeof(QPolygonF), typeof(QPolygonF), polygon);
		}
		public QPainterPath MapFromItem(QGraphicsItem item, QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapFromItem##", "mapFromItem(const QGraphicsItem*, const QPainterPath&) const", typeof(QPainterPath), typeof(QGraphicsItem), item, typeof(QPainterPath), path);
		}
		public QPainterPath MapFromParent(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapFromParent#", "mapFromParent(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		public QPainterPath MapFromScene(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapFromScene#", "mapFromScene(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		public QPointF MapToItem(QGraphicsItem item, double x, double y) {
			return (QPointF) interceptor.Invoke("mapToItem#$$", "mapToItem(const QGraphicsItem*, qreal, qreal) const", typeof(QPointF), typeof(QGraphicsItem), item, typeof(double), x, typeof(double), y);
		}
		public QPointF MapToParent(double x, double y) {
			return (QPointF) interceptor.Invoke("mapToParent$$", "mapToParent(qreal, qreal) const", typeof(QPointF), typeof(double), x, typeof(double), y);
		}
		public QPointF MapToScene(double x, double y) {
			return (QPointF) interceptor.Invoke("mapToScene$$", "mapToScene(qreal, qreal) const", typeof(QPointF), typeof(double), x, typeof(double), y);
		}
		public QPolygonF MapToItem(QGraphicsItem item, double x, double y, double w, double h) {
			return (QPolygonF) interceptor.Invoke("mapToItem#$$$$", "mapToItem(const QGraphicsItem*, qreal, qreal, qreal, qreal) const", typeof(QPolygonF), typeof(QGraphicsItem), item, typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QPolygonF MapToParent(double x, double y, double w, double h) {
			return (QPolygonF) interceptor.Invoke("mapToParent$$$$", "mapToParent(qreal, qreal, qreal, qreal) const", typeof(QPolygonF), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QPolygonF MapToScene(double x, double y, double w, double h) {
			return (QPolygonF) interceptor.Invoke("mapToScene$$$$", "mapToScene(qreal, qreal, qreal, qreal) const", typeof(QPolygonF), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QPointF MapFromItem(QGraphicsItem item, double x, double y) {
			return (QPointF) interceptor.Invoke("mapFromItem#$$", "mapFromItem(const QGraphicsItem*, qreal, qreal) const", typeof(QPointF), typeof(QGraphicsItem), item, typeof(double), x, typeof(double), y);
		}
		public QPointF MapFromParent(double x, double y) {
			return (QPointF) interceptor.Invoke("mapFromParent$$", "mapFromParent(qreal, qreal) const", typeof(QPointF), typeof(double), x, typeof(double), y);
		}
		public QPointF MapFromScene(double x, double y) {
			return (QPointF) interceptor.Invoke("mapFromScene$$", "mapFromScene(qreal, qreal) const", typeof(QPointF), typeof(double), x, typeof(double), y);
		}
		public QPolygonF MapFromItem(QGraphicsItem item, double x, double y, double w, double h) {
			return (QPolygonF) interceptor.Invoke("mapFromItem#$$$$", "mapFromItem(const QGraphicsItem*, qreal, qreal, qreal, qreal) const", typeof(QPolygonF), typeof(QGraphicsItem), item, typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QPolygonF MapFromParent(double x, double y, double w, double h) {
			return (QPolygonF) interceptor.Invoke("mapFromParent$$$$", "mapFromParent(qreal, qreal, qreal, qreal) const", typeof(QPolygonF), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QPolygonF MapFromScene(double x, double y, double w, double h) {
			return (QPolygonF) interceptor.Invoke("mapFromScene$$$$", "mapFromScene(qreal, qreal, qreal, qreal) const", typeof(QPolygonF), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public bool IsAncestorOf(QGraphicsItem child) {
			return (bool) interceptor.Invoke("isAncestorOf#", "isAncestorOf(const QGraphicsItem*) const", typeof(bool), typeof(QGraphicsItem), child);
		}
		public QVariant Data(int key) {
			return (QVariant) interceptor.Invoke("data$", "data(int) const", typeof(QVariant), typeof(int), key);
		}
		public void SetData(int key, QVariant value) {
			interceptor.Invoke("setData$#", "setData(int, const QVariant&)", typeof(void), typeof(int), key, typeof(QVariant), value);
		}
		public void InstallSceneEventFilter(QGraphicsItem filterItem) {
			interceptor.Invoke("installSceneEventFilter#", "installSceneEventFilter(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), filterItem);
		}
		public void RemoveSceneEventFilter(QGraphicsItem filterItem) {
			interceptor.Invoke("removeSceneEventFilter#", "removeSceneEventFilter(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), filterItem);
		}
		[SmokeMethod("sceneEventFilter(QGraphicsItem*, QEvent*)")]
		protected virtual bool SceneEventFilter(QGraphicsItem watched, QEvent arg2) {
			return (bool) interceptor.Invoke("sceneEventFilter##", "sceneEventFilter(QGraphicsItem*, QEvent*)", typeof(bool), typeof(QGraphicsItem), watched, typeof(QEvent), arg2);
		}
		[SmokeMethod("wheelEvent(QGraphicsSceneWheelEvent*)")]
		protected virtual void WheelEvent(QGraphicsSceneWheelEvent arg1) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QGraphicsSceneWheelEvent*)", typeof(void), typeof(QGraphicsSceneWheelEvent), arg1);
		}
		[SmokeMethod("itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)")]
		protected virtual QVariant ItemChange(QGraphicsItem.GraphicsItemChange change, QVariant value) {
			return (QVariant) interceptor.Invoke("itemChange$#", "itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)", typeof(QVariant), typeof(QGraphicsItem.GraphicsItemChange), change, typeof(QVariant), value);
		}
		protected void AddToIndex() {
			interceptor.Invoke("addToIndex", "addToIndex()", typeof(void));
		}
		protected void RemoveFromIndex() {
			interceptor.Invoke("removeFromIndex", "removeFromIndex()", typeof(void));
		}
		protected void PrepareGeometryChange() {
			interceptor.Invoke("prepareGeometryChange", "prepareGeometryChange()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQGraphicsTextItemSignals Emit {
			get { return (IQGraphicsTextItemSignals) Q_EMIT; }
		}
	}

	public interface IQGraphicsTextItemSignals : IQObjectSignals {
		[Q_SIGNAL("void linkActivated(const QString&)")]
		void LinkActivated(string arg1);
		[Q_SIGNAL("void linkHovered(const QString&)")]
		void LinkHovered(string arg1);
	}
}
