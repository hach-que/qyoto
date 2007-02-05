//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQGraphicsTextItemSignals"></see> for signals emitted by QGraphicsTextItem
	[SmokeClass("QGraphicsTextItem")]
	public class QGraphicsTextItem : QObject, IQGraphicsItem, IDisposable {
 		protected QGraphicsTextItem(Type dummy) : base((Type) null) {}
		[SmokeClass("QGraphicsTextItem")]
		interface IQGraphicsTextItemProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsTextItem), this);
			_interceptor = (QGraphicsTextItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsTextItem ProxyQGraphicsTextItem() {
			return (QGraphicsTextItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsTextItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsTextItemProxy), null);
			_staticInterceptor = (IQGraphicsTextItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsTextItemProxy StaticQGraphicsTextItem() {
			return (IQGraphicsTextItemProxy) _staticInterceptor;
		}
		public const int Type = 8;

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QGraphicsTextItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsTextItem(parent,scene);
		}
		[SmokeMethod("QGraphicsTextItem", "(QGraphicsItem*, QGraphicsScene*)", "##")]
		private void NewQGraphicsTextItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsTextItem().NewQGraphicsTextItem(parent,scene);
		}
		public QGraphicsTextItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsTextItem(parent);
		}
		[SmokeMethod("QGraphicsTextItem", "(QGraphicsItem*)", "#")]
		private void NewQGraphicsTextItem(QGraphicsItem parent) {
			ProxyQGraphicsTextItem().NewQGraphicsTextItem(parent);
		}
		public QGraphicsTextItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsTextItem();
		}
		[SmokeMethod("QGraphicsTextItem", "()", "")]
		private void NewQGraphicsTextItem() {
			ProxyQGraphicsTextItem().NewQGraphicsTextItem();
		}
		public QGraphicsTextItem(string text, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsTextItem(text,parent,scene);
		}
		[SmokeMethod("QGraphicsTextItem", "(const QString&, QGraphicsItem*, QGraphicsScene*)", "$##")]
		private void NewQGraphicsTextItem(string text, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsTextItem().NewQGraphicsTextItem(text,parent,scene);
		}
		public QGraphicsTextItem(string text, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsTextItem(text,parent);
		}
		[SmokeMethod("QGraphicsTextItem", "(const QString&, QGraphicsItem*)", "$#")]
		private void NewQGraphicsTextItem(string text, QGraphicsItem parent) {
			ProxyQGraphicsTextItem().NewQGraphicsTextItem(text,parent);
		}
		public QGraphicsTextItem(string text) : this((Type) null) {
			CreateProxy();
			NewQGraphicsTextItem(text);
		}
		[SmokeMethod("QGraphicsTextItem", "(const QString&)", "$")]
		private void NewQGraphicsTextItem(string text) {
			ProxyQGraphicsTextItem().NewQGraphicsTextItem(text);
		}
		[SmokeMethod("toHtml", "() const", "")]
		public string ToHtml() {
			return ProxyQGraphicsTextItem().ToHtml();
		}
		[SmokeMethod("setHtml", "(const QString&)", "$")]
		public void SetHtml(string html) {
			ProxyQGraphicsTextItem().SetHtml(html);
		}
		[SmokeMethod("toPlainText", "() const", "")]
		public string ToPlainText() {
			return ProxyQGraphicsTextItem().ToPlainText();
		}
		[SmokeMethod("setPlainText", "(const QString&)", "$")]
		public void SetPlainText(string text) {
			ProxyQGraphicsTextItem().SetPlainText(text);
		}
		[SmokeMethod("font", "() const", "")]
		public QFont Font() {
			return ProxyQGraphicsTextItem().Font();
		}
		[SmokeMethod("setFont", "(const QFont&)", "#")]
		public void SetFont(QFont font) {
			ProxyQGraphicsTextItem().SetFont(font);
		}
		[SmokeMethod("setDefaultTextColor", "(const QColor&)", "#")]
		public void SetDefaultTextColor(QColor c) {
			ProxyQGraphicsTextItem().SetDefaultTextColor(c);
		}
		[SmokeMethod("defaultTextColor", "() const", "")]
		public QColor DefaultTextColor() {
			return ProxyQGraphicsTextItem().DefaultTextColor();
		}
		[SmokeMethod("boundingRect", "() const", "")]
		public QRectF BoundingRect() {
			return ProxyQGraphicsTextItem().BoundingRect();
		}
		[SmokeMethod("shape", "() const", "")]
		public QPainterPath Shape() {
			return ProxyQGraphicsTextItem().Shape();
		}
		[SmokeMethod("contains", "(const QPointF&) const", "#")]
		public bool Contains(QPointF point) {
			return ProxyQGraphicsTextItem().Contains(point);
		}
		[SmokeMethod("paint", "(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", "###")]
		public void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsTextItem().Paint(painter,option,widget);
		}
		[SmokeMethod("isObscuredBy", "(const QGraphicsItem*) const", "#")]
		public bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsTextItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea", "() const", "")]
		public QPainterPath OpaqueArea() {
			return ProxyQGraphicsTextItem().OpaqueArea();
		}
		[SmokeMethod("type", "() const", "")]
		public int type() {
			return ProxyQGraphicsTextItem().type();
		}
		[SmokeMethod("setTextWidth", "(qreal)", "$")]
		public void SetTextWidth(double width) {
			ProxyQGraphicsTextItem().SetTextWidth(width);
		}
		[SmokeMethod("textWidth", "() const", "")]
		public double TextWidth() {
			return ProxyQGraphicsTextItem().TextWidth();
		}
		[SmokeMethod("adjustSize", "()", "")]
		public void AdjustSize() {
			ProxyQGraphicsTextItem().AdjustSize();
		}
		[SmokeMethod("setDocument", "(QTextDocument*)", "#")]
		public void SetDocument(QTextDocument document) {
			ProxyQGraphicsTextItem().SetDocument(document);
		}
		[SmokeMethod("document", "() const", "")]
		public QTextDocument Document() {
			return ProxyQGraphicsTextItem().Document();
		}
		[SmokeMethod("setTextInteractionFlags", "(Qt::TextInteractionFlags)", "$")]
		public void SetTextInteractionFlags(int flags) {
			ProxyQGraphicsTextItem().SetTextInteractionFlags(flags);
		}
		[SmokeMethod("textInteractionFlags", "() const", "")]
		public int TextInteractionFlags() {
			return ProxyQGraphicsTextItem().TextInteractionFlags();
		}
		[SmokeMethod("setOpenExternalLinks", "(bool)", "$")]
		public void SetOpenExternalLinks(bool open) {
			ProxyQGraphicsTextItem().SetOpenExternalLinks(open);
		}
		[SmokeMethod("openExternalLinks", "() const", "")]
		public bool OpenExternalLinks() {
			return ProxyQGraphicsTextItem().OpenExternalLinks();
		}
		[SmokeMethod("setTextCursor", "(const QTextCursor&)", "#")]
		public void SetTextCursor(QTextCursor cursor) {
			ProxyQGraphicsTextItem().SetTextCursor(cursor);
		}
		[SmokeMethod("textCursor", "() const", "")]
		public QTextCursor TextCursor() {
			return ProxyQGraphicsTextItem().TextCursor();
		}
		public static new string Tr(string s, string c) {
			return StaticQGraphicsTextItem().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQGraphicsTextItem().Tr(s);
		}
		[SmokeMethod("sceneEvent", "(QEvent*)", "#")]
		protected bool SceneEvent(QEvent arg1) {
			return ProxyQGraphicsTextItem().SceneEvent(arg1);
		}
		[SmokeMethod("mousePressEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsTextItem().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsTextItem().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsTextItem().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected void MouseDoubleClickEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsTextItem().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent", "(QGraphicsSceneContextMenuEvent*)", "#")]
		protected void ContextMenuEvent(QGraphicsSceneContextMenuEvent arg1) {
			ProxyQGraphicsTextItem().ContextMenuEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected void KeyPressEvent(QKeyEvent arg1) {
			ProxyQGraphicsTextItem().KeyPressEvent(arg1);
		}
		[SmokeMethod("keyReleaseEvent", "(QKeyEvent*)", "#")]
		protected void KeyReleaseEvent(QKeyEvent arg1) {
			ProxyQGraphicsTextItem().KeyReleaseEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected void FocusInEvent(QFocusEvent arg1) {
			ProxyQGraphicsTextItem().FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent", "(QFocusEvent*)", "#")]
		protected void FocusOutEvent(QFocusEvent arg1) {
			ProxyQGraphicsTextItem().FocusOutEvent(arg1);
		}
		[SmokeMethod("dragEnterEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected void DragEnterEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsTextItem().DragEnterEvent(arg1);
		}
		[SmokeMethod("dragLeaveEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected void DragLeaveEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsTextItem().DragLeaveEvent(arg1);
		}
		[SmokeMethod("dragMoveEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected void DragMoveEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsTextItem().DragMoveEvent(arg1);
		}
		[SmokeMethod("dropEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected void DropEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsTextItem().DropEvent(arg1);
		}
		[SmokeMethod("inputMethodEvent", "(QInputMethodEvent*)", "#")]
		protected void InputMethodEvent(QInputMethodEvent arg1) {
			ProxyQGraphicsTextItem().InputMethodEvent(arg1);
		}
		[SmokeMethod("hoverEnterEvent", "(QGraphicsSceneHoverEvent*)", "#")]
		protected void HoverEnterEvent(QGraphicsSceneHoverEvent arg1) {
			ProxyQGraphicsTextItem().HoverEnterEvent(arg1);
		}
		[SmokeMethod("hoverMoveEvent", "(QGraphicsSceneHoverEvent*)", "#")]
		protected void HoverMoveEvent(QGraphicsSceneHoverEvent arg1) {
			ProxyQGraphicsTextItem().HoverMoveEvent(arg1);
		}
		[SmokeMethod("hoverLeaveEvent", "(QGraphicsSceneHoverEvent*)", "#")]
		protected void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
			ProxyQGraphicsTextItem().HoverLeaveEvent(arg1);
		}
		[SmokeMethod("inputMethodQuery", "(Qt::InputMethodQuery) const", "$")]
		protected QVariant InputMethodQuery(Qt.InputMethodQuery query) {
			return ProxyQGraphicsTextItem().InputMethodQuery(query);
		}
		[SmokeMethod("supportsExtension", "(QGraphicsItem::Extension) const", "$")]
		protected bool SupportsExtension(QGraphicsItem.Extension extension) {
			return ProxyQGraphicsTextItem().SupportsExtension(extension);
		}
		[SmokeMethod("setExtension", "(QGraphicsItem::Extension, const QVariant&)", "$#")]
		protected void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			ProxyQGraphicsTextItem().SetExtension(extension,variant);
		}
		[SmokeMethod("extension", "(const QVariant&) const", "#")]
		protected QVariant Extension(QVariant variant) {
			return ProxyQGraphicsTextItem().Extension(variant);
		}
		~QGraphicsTextItem() {
			DisposeQGraphicsTextItem();
		}
		public new void Dispose() {
			DisposeQGraphicsTextItem();
		}
		[SmokeMethod("~QGraphicsTextItem", "()", "")]
		private void DisposeQGraphicsTextItem() {
			ProxyQGraphicsTextItem().DisposeQGraphicsTextItem();
		}
		[SmokeMethod("scene", "() const", "")]
		public QGraphicsScene Scene() {
			return ProxyQGraphicsTextItem().Scene();
		}
		[SmokeMethod("parentItem", "() const", "")]
		public QGraphicsItem ParentItem() {
			return ProxyQGraphicsTextItem().ParentItem();
		}
		[SmokeMethod("topLevelItem", "() const", "")]
		public QGraphicsItem TopLevelItem() {
			return ProxyQGraphicsTextItem().TopLevelItem();
		}
		[SmokeMethod("setParentItem", "(QGraphicsItem*)", "#")]
		public void SetParentItem(QGraphicsItem parent) {
			ProxyQGraphicsTextItem().SetParentItem(parent);
		}
		[SmokeMethod("children", "() const", "")]
		public List<QGraphicsItem> Children() {
			return ProxyQGraphicsTextItem().Children();
		}
		[SmokeMethod("group", "() const", "")]
		public QGraphicsItemGroup Group() {
			return ProxyQGraphicsTextItem().Group();
		}
		[SmokeMethod("setGroup", "(QGraphicsItemGroup*)", "#")]
		public void SetGroup(QGraphicsItemGroup group) {
			ProxyQGraphicsTextItem().SetGroup(group);
		}
		[SmokeMethod("flags", "() const", "")]
		public int Flags() {
			return ProxyQGraphicsTextItem().Flags();
		}
		[SmokeMethod("setFlag", "(QGraphicsItem::GraphicsItemFlag, bool)", "$$")]
		public void SetFlag(QGraphicsItem.GraphicsItemFlag flag, bool enabled) {
			ProxyQGraphicsTextItem().SetFlag(flag,enabled);
		}
		[SmokeMethod("setFlag", "(QGraphicsItem::GraphicsItemFlag)", "$")]
		public void SetFlag(QGraphicsItem.GraphicsItemFlag flag) {
			ProxyQGraphicsTextItem().SetFlag(flag);
		}
		[SmokeMethod("setFlags", "(GraphicsItemFlags)", "$")]
		public void SetFlags(int flags) {
			ProxyQGraphicsTextItem().SetFlags(flags);
		}
		[SmokeMethod("toolTip", "() const", "")]
		public string ToolTip() {
			return ProxyQGraphicsTextItem().ToolTip();
		}
		[SmokeMethod("setToolTip", "(const QString&)", "$")]
		public void SetToolTip(string toolTip) {
			ProxyQGraphicsTextItem().SetToolTip(toolTip);
		}
		[SmokeMethod("cursor", "() const", "")]
		public QCursor Cursor() {
			return ProxyQGraphicsTextItem().Cursor();
		}
		[SmokeMethod("setCursor", "(const QCursor&)", "#")]
		public void SetCursor(QCursor cursor) {
			ProxyQGraphicsTextItem().SetCursor(cursor);
		}
		[SmokeMethod("hasCursor", "() const", "")]
		public bool HasCursor() {
			return ProxyQGraphicsTextItem().HasCursor();
		}
		[SmokeMethod("unsetCursor", "()", "")]
		public void UnsetCursor() {
			ProxyQGraphicsTextItem().UnsetCursor();
		}
		[SmokeMethod("isVisible", "() const", "")]
		public bool IsVisible() {
			return ProxyQGraphicsTextItem().IsVisible();
		}
		[SmokeMethod("setVisible", "(bool)", "$")]
		public void SetVisible(bool visible) {
			ProxyQGraphicsTextItem().SetVisible(visible);
		}
		[SmokeMethod("hide", "()", "")]
		public void Hide() {
			ProxyQGraphicsTextItem().Hide();
		}
		[SmokeMethod("show", "()", "")]
		public void Show() {
			ProxyQGraphicsTextItem().Show();
		}
		[SmokeMethod("isEnabled", "() const", "")]
		public bool IsEnabled() {
			return ProxyQGraphicsTextItem().IsEnabled();
		}
		[SmokeMethod("setEnabled", "(bool)", "$")]
		public void SetEnabled(bool enabled) {
			ProxyQGraphicsTextItem().SetEnabled(enabled);
		}
		[SmokeMethod("isSelected", "() const", "")]
		public bool IsSelected() {
			return ProxyQGraphicsTextItem().IsSelected();
		}
		[SmokeMethod("setSelected", "(bool)", "$")]
		public void SetSelected(bool selected) {
			ProxyQGraphicsTextItem().SetSelected(selected);
		}
		[SmokeMethod("acceptDrops", "() const", "")]
		public bool AcceptDrops() {
			return ProxyQGraphicsTextItem().AcceptDrops();
		}
		[SmokeMethod("setAcceptDrops", "(bool)", "$")]
		public void SetAcceptDrops(bool on) {
			ProxyQGraphicsTextItem().SetAcceptDrops(on);
		}
		[SmokeMethod("acceptedMouseButtons", "() const", "")]
		public int AcceptedMouseButtons() {
			return ProxyQGraphicsTextItem().AcceptedMouseButtons();
		}
		[SmokeMethod("setAcceptedMouseButtons", "(Qt::MouseButtons)", "$")]
		public void SetAcceptedMouseButtons(int buttons) {
			ProxyQGraphicsTextItem().SetAcceptedMouseButtons(buttons);
		}
		[SmokeMethod("acceptsHoverEvents", "() const", "")]
		public bool AcceptsHoverEvents() {
			return ProxyQGraphicsTextItem().AcceptsHoverEvents();
		}
		[SmokeMethod("setAcceptsHoverEvents", "(bool)", "$")]
		public void SetAcceptsHoverEvents(bool enabled) {
			ProxyQGraphicsTextItem().SetAcceptsHoverEvents(enabled);
		}
		[SmokeMethod("handlesChildEvents", "() const", "")]
		public bool HandlesChildEvents() {
			return ProxyQGraphicsTextItem().HandlesChildEvents();
		}
		[SmokeMethod("setHandlesChildEvents", "(bool)", "$")]
		public void SetHandlesChildEvents(bool enabled) {
			ProxyQGraphicsTextItem().SetHandlesChildEvents(enabled);
		}
		[SmokeMethod("hasFocus", "() const", "")]
		public bool HasFocus() {
			return ProxyQGraphicsTextItem().HasFocus();
		}
		[SmokeMethod("setFocus", "(Qt::FocusReason)", "$")]
		public void SetFocus(Qt.FocusReason focusReason) {
			ProxyQGraphicsTextItem().SetFocus(focusReason);
		}
		[SmokeMethod("setFocus", "()", "")]
		public void SetFocus() {
			ProxyQGraphicsTextItem().SetFocus();
		}
		[SmokeMethod("clearFocus", "()", "")]
		public void ClearFocus() {
			ProxyQGraphicsTextItem().ClearFocus();
		}
		[SmokeMethod("pos", "() const", "")]
		public QPointF Pos() {
			return ProxyQGraphicsTextItem().Pos();
		}
		[SmokeMethod("x", "() const", "")]
		public double X() {
			return ProxyQGraphicsTextItem().X();
		}
		[SmokeMethod("y", "() const", "")]
		public double Y() {
			return ProxyQGraphicsTextItem().Y();
		}
		[SmokeMethod("scenePos", "() const", "")]
		public QPointF ScenePos() {
			return ProxyQGraphicsTextItem().ScenePos();
		}
		[SmokeMethod("setPos", "(const QPointF&)", "#")]
		public void SetPos(QPointF pos) {
			ProxyQGraphicsTextItem().SetPos(pos);
		}
		[SmokeMethod("setPos", "(qreal, qreal)", "$$")]
		public void SetPos(double x, double y) {
			ProxyQGraphicsTextItem().SetPos(x,y);
		}
		[SmokeMethod("moveBy", "(qreal, qreal)", "$$")]
		public void MoveBy(double dx, double dy) {
			ProxyQGraphicsTextItem().MoveBy(dx,dy);
		}
		[SmokeMethod("ensureVisible", "(const QRectF&, int, int)", "#$$")]
		public void EnsureVisible(QRectF rect, int xmargin, int ymargin) {
			ProxyQGraphicsTextItem().EnsureVisible(rect,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible", "(const QRectF&, int)", "#$")]
		public void EnsureVisible(QRectF rect, int xmargin) {
			ProxyQGraphicsTextItem().EnsureVisible(rect,xmargin);
		}
		[SmokeMethod("ensureVisible", "(const QRectF&)", "#")]
		public void EnsureVisible(QRectF rect) {
			ProxyQGraphicsTextItem().EnsureVisible(rect);
		}
		[SmokeMethod("ensureVisible", "()", "")]
		public void EnsureVisible() {
			ProxyQGraphicsTextItem().EnsureVisible();
		}
		[SmokeMethod("ensureVisible", "(qreal, qreal, qreal, qreal, int, int)", "$$$$$$")]
		public void EnsureVisible(double x, double y, double w, double h, int xmargin, int ymargin) {
			ProxyQGraphicsTextItem().EnsureVisible(x,y,w,h,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible", "(qreal, qreal, qreal, qreal, int)", "$$$$$")]
		public void EnsureVisible(double x, double y, double w, double h, int xmargin) {
			ProxyQGraphicsTextItem().EnsureVisible(x,y,w,h,xmargin);
		}
		[SmokeMethod("ensureVisible", "(qreal, qreal, qreal, qreal)", "$$$$")]
		public void EnsureVisible(double x, double y, double w, double h) {
			ProxyQGraphicsTextItem().EnsureVisible(x,y,w,h);
		}
		[SmokeMethod("matrix", "() const", "")]
		public QMatrix Matrix() {
			return ProxyQGraphicsTextItem().Matrix();
		}
		[SmokeMethod("sceneMatrix", "() const", "")]
		public QMatrix SceneMatrix() {
			return ProxyQGraphicsTextItem().SceneMatrix();
		}
		[SmokeMethod("setMatrix", "(const QMatrix&, bool)", "#$")]
		public void SetMatrix(QMatrix matrix, bool combine) {
			ProxyQGraphicsTextItem().SetMatrix(matrix,combine);
		}
		[SmokeMethod("setMatrix", "(const QMatrix&)", "#")]
		public void SetMatrix(QMatrix matrix) {
			ProxyQGraphicsTextItem().SetMatrix(matrix);
		}
		[SmokeMethod("resetMatrix", "()", "")]
		public void ResetMatrix() {
			ProxyQGraphicsTextItem().ResetMatrix();
		}
		[SmokeMethod("rotate", "(qreal)", "$")]
		public void Rotate(double angle) {
			ProxyQGraphicsTextItem().Rotate(angle);
		}
		[SmokeMethod("scale", "(qreal, qreal)", "$$")]
		public void Scale(double sx, double sy) {
			ProxyQGraphicsTextItem().Scale(sx,sy);
		}
		[SmokeMethod("shear", "(qreal, qreal)", "$$")]
		public void Shear(double sh, double sv) {
			ProxyQGraphicsTextItem().Shear(sh,sv);
		}
		[SmokeMethod("translate", "(qreal, qreal)", "$$")]
		public void Translate(double dx, double dy) {
			ProxyQGraphicsTextItem().Translate(dx,dy);
		}
		[SmokeMethod("advance", "(int)", "$")]
		public virtual void Advance(int phase) {
			ProxyQGraphicsTextItem().Advance(phase);
		}
		[SmokeMethod("zValue", "() const", "")]
		public double ZValue() {
			return ProxyQGraphicsTextItem().ZValue();
		}
		[SmokeMethod("setZValue", "(qreal)", "$")]
		public void SetZValue(double z) {
			ProxyQGraphicsTextItem().SetZValue(z);
		}
		[SmokeMethod("childrenBoundingRect", "() const", "")]
		public QRectF ChildrenBoundingRect() {
			return ProxyQGraphicsTextItem().ChildrenBoundingRect();
		}
		[SmokeMethod("sceneBoundingRect", "() const", "")]
		public QRectF SceneBoundingRect() {
			return ProxyQGraphicsTextItem().SceneBoundingRect();
		}
		[SmokeMethod("collidesWithItem", "(const QGraphicsItem*, Qt::ItemSelectionMode) const", "#$")]
		public virtual bool CollidesWithItem(QGraphicsItem other, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsTextItem().CollidesWithItem(other,mode);
		}
		[SmokeMethod("collidesWithItem", "(const QGraphicsItem*) const", "#")]
		public virtual bool CollidesWithItem(QGraphicsItem other) {
			return ProxyQGraphicsTextItem().CollidesWithItem(other);
		}
		[SmokeMethod("collidesWithPath", "(const QPainterPath&, Qt::ItemSelectionMode) const", "#$")]
		public virtual bool CollidesWithPath(QPainterPath path, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsTextItem().CollidesWithPath(path,mode);
		}
		[SmokeMethod("collidesWithPath", "(const QPainterPath&) const", "#")]
		public virtual bool CollidesWithPath(QPainterPath path) {
			return ProxyQGraphicsTextItem().CollidesWithPath(path);
		}
		[SmokeMethod("collidingItems", "(Qt::ItemSelectionMode) const", "$")]
		public List<QGraphicsItem> CollidingItems(Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsTextItem().CollidingItems(mode);
		}
		[SmokeMethod("collidingItems", "() const", "")]
		public List<QGraphicsItem> CollidingItems() {
			return ProxyQGraphicsTextItem().CollidingItems();
		}
		[SmokeMethod("isObscured", "() const", "")]
		public bool IsObscured() {
			return ProxyQGraphicsTextItem().IsObscured();
		}
		[SmokeMethod("paint", "(QPainter*, const QStyleOptionGraphicsItem*)", "##")]
		public virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			ProxyQGraphicsTextItem().Paint(painter,option);
		}
		[SmokeMethod("update", "(const QRectF&)", "#")]
		public void Update(QRectF rect) {
			ProxyQGraphicsTextItem().Update(rect);
		}
		[SmokeMethod("update", "()", "")]
		public void Update() {
			ProxyQGraphicsTextItem().Update();
		}
		[SmokeMethod("update", "(qreal, qreal, qreal, qreal)", "$$$$")]
		public void Update(double x, double y, double width, double height) {
			ProxyQGraphicsTextItem().Update(x,y,width,height);
		}
		[SmokeMethod("mapToItem", "(const QGraphicsItem*, const QPointF&) const", "##")]
		public QPointF MapToItem(QGraphicsItem item, QPointF point) {
			return ProxyQGraphicsTextItem().MapToItem(item,point);
		}
		[SmokeMethod("mapToParent", "(const QPointF&) const", "#")]
		public QPointF MapToParent(QPointF point) {
			return ProxyQGraphicsTextItem().MapToParent(point);
		}
		[SmokeMethod("mapToScene", "(const QPointF&) const", "#")]
		public QPointF MapToScene(QPointF point) {
			return ProxyQGraphicsTextItem().MapToScene(point);
		}
		[SmokeMethod("mapToItem", "(const QGraphicsItem*, const QRectF&) const", "##")]
		public QPolygonF MapToItem(QGraphicsItem item, QRectF rect) {
			return ProxyQGraphicsTextItem().MapToItem(item,rect);
		}
		[SmokeMethod("mapToParent", "(const QRectF&) const", "#")]
		public QPolygonF MapToParent(QRectF rect) {
			return ProxyQGraphicsTextItem().MapToParent(rect);
		}
		[SmokeMethod("mapToScene", "(const QRectF&) const", "#")]
		public QPolygonF MapToScene(QRectF rect) {
			return ProxyQGraphicsTextItem().MapToScene(rect);
		}
		[SmokeMethod("mapToItem", "(const QGraphicsItem*, const QPolygonF&) const", "##")]
		public QPolygonF MapToItem(QGraphicsItem item, QPolygonF polygon) {
			return ProxyQGraphicsTextItem().MapToItem(item,polygon);
		}
		[SmokeMethod("mapToParent", "(const QPolygonF&) const", "#")]
		public QPolygonF MapToParent(QPolygonF polygon) {
			return ProxyQGraphicsTextItem().MapToParent(polygon);
		}
		[SmokeMethod("mapToScene", "(const QPolygonF&) const", "#")]
		public QPolygonF MapToScene(QPolygonF polygon) {
			return ProxyQGraphicsTextItem().MapToScene(polygon);
		}
		[SmokeMethod("mapToItem", "(const QGraphicsItem*, const QPainterPath&) const", "##")]
		public QPainterPath MapToItem(QGraphicsItem item, QPainterPath path) {
			return ProxyQGraphicsTextItem().MapToItem(item,path);
		}
		[SmokeMethod("mapToParent", "(const QPainterPath&) const", "#")]
		public QPainterPath MapToParent(QPainterPath path) {
			return ProxyQGraphicsTextItem().MapToParent(path);
		}
		[SmokeMethod("mapToScene", "(const QPainterPath&) const", "#")]
		public QPainterPath MapToScene(QPainterPath path) {
			return ProxyQGraphicsTextItem().MapToScene(path);
		}
		[SmokeMethod("mapFromItem", "(const QGraphicsItem*, const QPointF&) const", "##")]
		public QPointF MapFromItem(QGraphicsItem item, QPointF point) {
			return ProxyQGraphicsTextItem().MapFromItem(item,point);
		}
		[SmokeMethod("mapFromParent", "(const QPointF&) const", "#")]
		public QPointF MapFromParent(QPointF point) {
			return ProxyQGraphicsTextItem().MapFromParent(point);
		}
		[SmokeMethod("mapFromScene", "(const QPointF&) const", "#")]
		public QPointF MapFromScene(QPointF point) {
			return ProxyQGraphicsTextItem().MapFromScene(point);
		}
		[SmokeMethod("mapFromItem", "(const QGraphicsItem*, const QRectF&) const", "##")]
		public QPolygonF MapFromItem(QGraphicsItem item, QRectF rect) {
			return ProxyQGraphicsTextItem().MapFromItem(item,rect);
		}
		[SmokeMethod("mapFromParent", "(const QRectF&) const", "#")]
		public QPolygonF MapFromParent(QRectF rect) {
			return ProxyQGraphicsTextItem().MapFromParent(rect);
		}
		[SmokeMethod("mapFromScene", "(const QRectF&) const", "#")]
		public QPolygonF MapFromScene(QRectF rect) {
			return ProxyQGraphicsTextItem().MapFromScene(rect);
		}
		[SmokeMethod("mapFromItem", "(const QGraphicsItem*, const QPolygonF&) const", "##")]
		public QPolygonF MapFromItem(QGraphicsItem item, QPolygonF polygon) {
			return ProxyQGraphicsTextItem().MapFromItem(item,polygon);
		}
		[SmokeMethod("mapFromParent", "(const QPolygonF&) const", "#")]
		public QPolygonF MapFromParent(QPolygonF polygon) {
			return ProxyQGraphicsTextItem().MapFromParent(polygon);
		}
		[SmokeMethod("mapFromScene", "(const QPolygonF&) const", "#")]
		public QPolygonF MapFromScene(QPolygonF polygon) {
			return ProxyQGraphicsTextItem().MapFromScene(polygon);
		}
		[SmokeMethod("mapFromItem", "(const QGraphicsItem*, const QPainterPath&) const", "##")]
		public QPainterPath MapFromItem(QGraphicsItem item, QPainterPath path) {
			return ProxyQGraphicsTextItem().MapFromItem(item,path);
		}
		[SmokeMethod("mapFromParent", "(const QPainterPath&) const", "#")]
		public QPainterPath MapFromParent(QPainterPath path) {
			return ProxyQGraphicsTextItem().MapFromParent(path);
		}
		[SmokeMethod("mapFromScene", "(const QPainterPath&) const", "#")]
		public QPainterPath MapFromScene(QPainterPath path) {
			return ProxyQGraphicsTextItem().MapFromScene(path);
		}
		[SmokeMethod("mapToItem", "(const QGraphicsItem*, qreal, qreal) const", "#$$")]
		public QPointF MapToItem(QGraphicsItem item, double x, double y) {
			return ProxyQGraphicsTextItem().MapToItem(item,x,y);
		}
		[SmokeMethod("mapToParent", "(qreal, qreal) const", "$$")]
		public QPointF MapToParent(double x, double y) {
			return ProxyQGraphicsTextItem().MapToParent(x,y);
		}
		[SmokeMethod("mapToScene", "(qreal, qreal) const", "$$")]
		public QPointF MapToScene(double x, double y) {
			return ProxyQGraphicsTextItem().MapToScene(x,y);
		}
		[SmokeMethod("mapFromItem", "(const QGraphicsItem*, qreal, qreal) const", "#$$")]
		public QPointF MapFromItem(QGraphicsItem item, double x, double y) {
			return ProxyQGraphicsTextItem().MapFromItem(item,x,y);
		}
		[SmokeMethod("mapFromParent", "(qreal, qreal) const", "$$")]
		public QPointF MapFromParent(double x, double y) {
			return ProxyQGraphicsTextItem().MapFromParent(x,y);
		}
		[SmokeMethod("mapFromScene", "(qreal, qreal) const", "$$")]
		public QPointF MapFromScene(double x, double y) {
			return ProxyQGraphicsTextItem().MapFromScene(x,y);
		}
		[SmokeMethod("isAncestorOf", "(const QGraphicsItem*) const", "#")]
		public bool IsAncestorOf(QGraphicsItem child) {
			return ProxyQGraphicsTextItem().IsAncestorOf(child);
		}
		[SmokeMethod("data", "(int) const", "$")]
		public QVariant Data(int key) {
			return ProxyQGraphicsTextItem().Data(key);
		}
		[SmokeMethod("setData", "(int, const QVariant&)", "$#")]
		public void SetData(int key, QVariant value) {
			ProxyQGraphicsTextItem().SetData(key,value);
		}
		[SmokeMethod("installSceneEventFilter", "(QGraphicsItem*)", "#")]
		public void InstallSceneEventFilter(QGraphicsItem filterItem) {
			ProxyQGraphicsTextItem().InstallSceneEventFilter(filterItem);
		}
		[SmokeMethod("removeSceneEventFilter", "(QGraphicsItem*)", "#")]
		public void RemoveSceneEventFilter(QGraphicsItem filterItem) {
			ProxyQGraphicsTextItem().RemoveSceneEventFilter(filterItem);
		}
		[SmokeMethod("sceneEventFilter", "(QGraphicsItem*, QEvent*)", "##")]
		protected virtual bool SceneEventFilter(QGraphicsItem watched, QEvent arg2) {
			return ProxyQGraphicsTextItem().SceneEventFilter(watched,arg2);
		}
		[SmokeMethod("wheelEvent", "(QGraphicsSceneWheelEvent*)", "#")]
		protected virtual void WheelEvent(QGraphicsSceneWheelEvent arg1) {
			ProxyQGraphicsTextItem().WheelEvent(arg1);
		}
		[SmokeMethod("itemChange", "(QGraphicsItem::GraphicsItemChange, const QVariant&)", "$#")]
		protected virtual QVariant ItemChange(QGraphicsItem.GraphicsItemChange change, QVariant value) {
			return ProxyQGraphicsTextItem().ItemChange(change,value);
		}
		[SmokeMethod("addToIndex", "()", "")]
		protected void AddToIndex() {
			ProxyQGraphicsTextItem().AddToIndex();
		}
		[SmokeMethod("removeFromIndex", "()", "")]
		protected void RemoveFromIndex() {
			ProxyQGraphicsTextItem().RemoveFromIndex();
		}
		[SmokeMethod("prepareGeometryChange", "()", "")]
		protected void PrepareGeometryChange() {
			ProxyQGraphicsTextItem().PrepareGeometryChange();
		}
		protected new IQGraphicsTextItemSignals Emit {
			get {
				return (IQGraphicsTextItemSignals) Q_EMIT;
			}
		}
	}

	public interface IQGraphicsTextItemSignals : IQObjectSignals {
		[Q_SIGNAL("void linkActivated(const QString&)")]
		void LinkActivated(string arg1);
		[Q_SIGNAL("void linkHovered(const QString&)")]
		void LinkHovered(string arg1);
	}
}
