//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	public interface IQGraphicsItem {
			QGraphicsScene Scene();
			QGraphicsItem ParentItem();
			QGraphicsItem TopLevelItem();
			void SetParentItem(QGraphicsItem parent);
			List<QGraphicsItem> Children();
			QGraphicsItemGroup Group();
			void SetGroup(QGraphicsItemGroup group);
			int Flags();
			void SetFlag(QGraphicsItem.GraphicsItemFlag flag, bool enabled);
			void SetFlag(QGraphicsItem.GraphicsItemFlag flag);
			void SetFlags(int flags);
			string ToolTip();
			void SetToolTip(string toolTip);
			QCursor Cursor();
			void SetCursor(QCursor cursor);
			bool HasCursor();
			void UnsetCursor();
			bool IsVisible();
			void SetVisible(bool visible);
			void Hide();
			void Show();
			bool IsEnabled();
			void SetEnabled(bool enabled);
			bool IsSelected();
			void SetSelected(bool selected);
			bool AcceptDrops();
			void SetAcceptDrops(bool on);
			int AcceptedMouseButtons();
			void SetAcceptedMouseButtons(int buttons);
			bool AcceptsHoverEvents();
			void SetAcceptsHoverEvents(bool enabled);
			bool HandlesChildEvents();
			void SetHandlesChildEvents(bool enabled);
			bool HasFocus();
			void SetFocus(Qt.FocusReason focusReason);
			void SetFocus();
			void ClearFocus();
			QPointF Pos();
			double X();
			double Y();
			QPointF ScenePos();
			void SetPos(QPointF pos);
			void SetPos(double x, double y);
			void MoveBy(double dx, double dy);
			void EnsureVisible(QRectF rect, int xmargin, int ymargin);
			void EnsureVisible(QRectF rect, int xmargin);
			void EnsureVisible(QRectF rect);
			void EnsureVisible();
			void EnsureVisible(double x, double y, double w, double h, int xmargin, int ymargin);
			void EnsureVisible(double x, double y, double w, double h, int xmargin);
			void EnsureVisible(double x, double y, double w, double h);
			QMatrix Matrix();
			QMatrix SceneMatrix();
			void SetMatrix(QMatrix matrix, bool combine);
			void SetMatrix(QMatrix matrix);
			void ResetMatrix();
			void Rotate(double angle);
			void Scale(double sx, double sy);
			void Shear(double sh, double sv);
			void Translate(double dx, double dy);
			void Advance(int phase);
			double ZValue();
			void SetZValue(double z);
			QRectF BoundingRect();
			QRectF ChildrenBoundingRect();
			QRectF SceneBoundingRect();
			QPainterPath Shape();
			bool Contains(QPointF point);
			bool CollidesWithItem(QGraphicsItem other, Qt.ItemSelectionMode mode);
			bool CollidesWithItem(QGraphicsItem other);
			bool CollidesWithPath(QPainterPath path, Qt.ItemSelectionMode mode);
			bool CollidesWithPath(QPainterPath path);
			List<QGraphicsItem> CollidingItems(Qt.ItemSelectionMode mode);
			List<QGraphicsItem> CollidingItems();
			bool IsObscured();
			bool IsObscuredBy(QGraphicsItem item);
			QPainterPath OpaqueArea();
			void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget);
			void Paint(QPainter painter, QStyleOptionGraphicsItem option);
			void Update(QRectF rect);
			void Update();
			void Update(double x, double y, double width, double height);
			QPointF MapToItem(QGraphicsItem item, QPointF point);
			QPointF MapToParent(QPointF point);
			QPointF MapToScene(QPointF point);
			QPolygonF MapToItem(QGraphicsItem item, QRectF rect);
			QPolygonF MapToParent(QRectF rect);
			QPolygonF MapToScene(QRectF rect);
			QPolygonF MapToItem(QGraphicsItem item, QPolygonF polygon);
			QPolygonF MapToParent(QPolygonF polygon);
			QPolygonF MapToScene(QPolygonF polygon);
			QPainterPath MapToItem(QGraphicsItem item, QPainterPath path);
			QPainterPath MapToParent(QPainterPath path);
			QPainterPath MapToScene(QPainterPath path);
			QPointF MapFromItem(QGraphicsItem item, QPointF point);
			QPointF MapFromParent(QPointF point);
			QPointF MapFromScene(QPointF point);
			QPolygonF MapFromItem(QGraphicsItem item, QRectF rect);
			QPolygonF MapFromParent(QRectF rect);
			QPolygonF MapFromScene(QRectF rect);
			QPolygonF MapFromItem(QGraphicsItem item, QPolygonF polygon);
			QPolygonF MapFromParent(QPolygonF polygon);
			QPolygonF MapFromScene(QPolygonF polygon);
			QPainterPath MapFromItem(QGraphicsItem item, QPainterPath path);
			QPainterPath MapFromParent(QPainterPath path);
			QPainterPath MapFromScene(QPainterPath path);
			QPointF MapToItem(QGraphicsItem item, double x, double y);
			QPointF MapToParent(double x, double y);
			QPointF MapToScene(double x, double y);
			QPointF MapFromItem(QGraphicsItem item, double x, double y);
			QPointF MapFromParent(double x, double y);
			QPointF MapFromScene(double x, double y);
			bool IsAncestorOf(QGraphicsItem child);
			QVariant Data(int key);
			void SetData(int key, QVariant value);
			int type();
			void InstallSceneEventFilter(QGraphicsItem filterItem);
			void RemoveSceneEventFilter(QGraphicsItem filterItem);
	}

	[SmokeClass("QGraphicsItem")]
	public class QGraphicsItem : MarshalByRefObject, IQGraphicsItem {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QGraphicsItem(Type dummy) {}
		interface IQGraphicsItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsItem), this);
			_interceptor = (QGraphicsItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsItem ProxyQGraphicsItem() {
			return (QGraphicsItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsItemProxy), null);
			_staticInterceptor = (IQGraphicsItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsItemProxy StaticQGraphicsItem() {
			return (IQGraphicsItemProxy) _staticInterceptor;
		}

		public enum GraphicsItemFlag {
			ItemIsMovable = 0x1,
			ItemIsSelectable = 0x2,
			ItemIsFocusable = 0x4,
		}
		public enum GraphicsItemChange {
			ItemPositionChange = 0,
			ItemMatrixChange = 1,
			ItemVisibleChange = 2,
			ItemEnabledChange = 3,
			ItemSelectedChange = 4,
			ItemParentChange = 5,
			ItemChildAddedChange = 6,
			ItemChildRemovedChange = 7,
		}
		public enum Extension : long {
			UserExtension = 0x80000000,
		}
		public const int Type = 1;
		public const int UserType = 65536;

		public QGraphicsItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsItem(parent,scene);
		}
		[SmokeMethod("QGraphicsItem##", "(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsItem().NewQGraphicsItem(parent,scene);
		}
		public QGraphicsItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsItem(parent);
		}
		[SmokeMethod("QGraphicsItem#", "(QGraphicsItem*)")]
		private void NewQGraphicsItem(QGraphicsItem parent) {
			ProxyQGraphicsItem().NewQGraphicsItem(parent);
		}
		public QGraphicsItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsItem();
		}
		[SmokeMethod("QGraphicsItem", "()")]
		private void NewQGraphicsItem() {
			ProxyQGraphicsItem().NewQGraphicsItem();
		}
		[SmokeMethod("scene", "() const")]
		public QGraphicsScene Scene() {
			return ProxyQGraphicsItem().Scene();
		}
		[SmokeMethod("parentItem", "() const")]
		public QGraphicsItem ParentItem() {
			return ProxyQGraphicsItem().ParentItem();
		}
		[SmokeMethod("topLevelItem", "() const")]
		public QGraphicsItem TopLevelItem() {
			return ProxyQGraphicsItem().TopLevelItem();
		}
		[SmokeMethod("setParentItem#", "(QGraphicsItem*)")]
		public void SetParentItem(QGraphicsItem parent) {
			ProxyQGraphicsItem().SetParentItem(parent);
		}
		[SmokeMethod("children", "() const")]
		public List<QGraphicsItem> Children() {
			return ProxyQGraphicsItem().Children();
		}
		[SmokeMethod("group", "() const")]
		public QGraphicsItemGroup Group() {
			return ProxyQGraphicsItem().Group();
		}
		[SmokeMethod("setGroup#", "(QGraphicsItemGroup*)")]
		public void SetGroup(QGraphicsItemGroup group) {
			ProxyQGraphicsItem().SetGroup(group);
		}
		[SmokeMethod("flags", "() const")]
		public int Flags() {
			return ProxyQGraphicsItem().Flags();
		}
		[SmokeMethod("setFlag$$", "(QGraphicsItem::GraphicsItemFlag, bool)")]
		public void SetFlag(QGraphicsItem.GraphicsItemFlag flag, bool enabled) {
			ProxyQGraphicsItem().SetFlag(flag,enabled);
		}
		[SmokeMethod("setFlag$", "(QGraphicsItem::GraphicsItemFlag)")]
		public void SetFlag(QGraphicsItem.GraphicsItemFlag flag) {
			ProxyQGraphicsItem().SetFlag(flag);
		}
		[SmokeMethod("setFlags$", "(GraphicsItemFlags)")]
		public void SetFlags(int flags) {
			ProxyQGraphicsItem().SetFlags(flags);
		}
		[SmokeMethod("toolTip", "() const")]
		public string ToolTip() {
			return ProxyQGraphicsItem().ToolTip();
		}
		[SmokeMethod("setToolTip$", "(const QString&)")]
		public void SetToolTip(string toolTip) {
			ProxyQGraphicsItem().SetToolTip(toolTip);
		}
		[SmokeMethod("cursor", "() const")]
		public QCursor Cursor() {
			return ProxyQGraphicsItem().Cursor();
		}
		[SmokeMethod("setCursor#", "(const QCursor&)")]
		public void SetCursor(QCursor cursor) {
			ProxyQGraphicsItem().SetCursor(cursor);
		}
		[SmokeMethod("hasCursor", "() const")]
		public bool HasCursor() {
			return ProxyQGraphicsItem().HasCursor();
		}
		[SmokeMethod("unsetCursor", "()")]
		public void UnsetCursor() {
			ProxyQGraphicsItem().UnsetCursor();
		}
		[SmokeMethod("isVisible", "() const")]
		public bool IsVisible() {
			return ProxyQGraphicsItem().IsVisible();
		}
		[SmokeMethod("setVisible$", "(bool)")]
		public void SetVisible(bool visible) {
			ProxyQGraphicsItem().SetVisible(visible);
		}
		[SmokeMethod("hide", "()")]
		public void Hide() {
			ProxyQGraphicsItem().Hide();
		}
		[SmokeMethod("show", "()")]
		public void Show() {
			ProxyQGraphicsItem().Show();
		}
		[SmokeMethod("isEnabled", "() const")]
		public bool IsEnabled() {
			return ProxyQGraphicsItem().IsEnabled();
		}
		[SmokeMethod("setEnabled$", "(bool)")]
		public void SetEnabled(bool enabled) {
			ProxyQGraphicsItem().SetEnabled(enabled);
		}
		[SmokeMethod("isSelected", "() const")]
		public bool IsSelected() {
			return ProxyQGraphicsItem().IsSelected();
		}
		[SmokeMethod("setSelected$", "(bool)")]
		public void SetSelected(bool selected) {
			ProxyQGraphicsItem().SetSelected(selected);
		}
		[SmokeMethod("acceptDrops", "() const")]
		public bool AcceptDrops() {
			return ProxyQGraphicsItem().AcceptDrops();
		}
		[SmokeMethod("setAcceptDrops$", "(bool)")]
		public void SetAcceptDrops(bool on) {
			ProxyQGraphicsItem().SetAcceptDrops(on);
		}
		[SmokeMethod("acceptedMouseButtons", "() const")]
		public int AcceptedMouseButtons() {
			return ProxyQGraphicsItem().AcceptedMouseButtons();
		}
		[SmokeMethod("setAcceptedMouseButtons$", "(Qt::MouseButtons)")]
		public void SetAcceptedMouseButtons(int buttons) {
			ProxyQGraphicsItem().SetAcceptedMouseButtons(buttons);
		}
		[SmokeMethod("acceptsHoverEvents", "() const")]
		public bool AcceptsHoverEvents() {
			return ProxyQGraphicsItem().AcceptsHoverEvents();
		}
		[SmokeMethod("setAcceptsHoverEvents$", "(bool)")]
		public void SetAcceptsHoverEvents(bool enabled) {
			ProxyQGraphicsItem().SetAcceptsHoverEvents(enabled);
		}
		[SmokeMethod("handlesChildEvents", "() const")]
		public bool HandlesChildEvents() {
			return ProxyQGraphicsItem().HandlesChildEvents();
		}
		[SmokeMethod("setHandlesChildEvents$", "(bool)")]
		public void SetHandlesChildEvents(bool enabled) {
			ProxyQGraphicsItem().SetHandlesChildEvents(enabled);
		}
		[SmokeMethod("hasFocus", "() const")]
		public bool HasFocus() {
			return ProxyQGraphicsItem().HasFocus();
		}
		[SmokeMethod("setFocus$", "(Qt::FocusReason)")]
		public void SetFocus(Qt.FocusReason focusReason) {
			ProxyQGraphicsItem().SetFocus(focusReason);
		}
		[SmokeMethod("setFocus", "()")]
		public void SetFocus() {
			ProxyQGraphicsItem().SetFocus();
		}
		[SmokeMethod("clearFocus", "()")]
		public void ClearFocus() {
			ProxyQGraphicsItem().ClearFocus();
		}
		[SmokeMethod("pos", "() const")]
		public QPointF Pos() {
			return ProxyQGraphicsItem().Pos();
		}
		[SmokeMethod("x", "() const")]
		public double X() {
			return ProxyQGraphicsItem().X();
		}
		[SmokeMethod("y", "() const")]
		public double Y() {
			return ProxyQGraphicsItem().Y();
		}
		[SmokeMethod("scenePos", "() const")]
		public QPointF ScenePos() {
			return ProxyQGraphicsItem().ScenePos();
		}
		[SmokeMethod("setPos#", "(const QPointF&)")]
		public void SetPos(QPointF pos) {
			ProxyQGraphicsItem().SetPos(pos);
		}
		[SmokeMethod("setPos$$", "(qreal, qreal)")]
		public void SetPos(double x, double y) {
			ProxyQGraphicsItem().SetPos(x,y);
		}
		[SmokeMethod("moveBy$$", "(qreal, qreal)")]
		public void MoveBy(double dx, double dy) {
			ProxyQGraphicsItem().MoveBy(dx,dy);
		}
		[SmokeMethod("ensureVisible###", "(const QRectF&, int, int)")]
		public void EnsureVisible(QRectF rect, int xmargin, int ymargin) {
			ProxyQGraphicsItem().EnsureVisible(rect,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible##", "(const QRectF&, int)")]
		public void EnsureVisible(QRectF rect, int xmargin) {
			ProxyQGraphicsItem().EnsureVisible(rect,xmargin);
		}
		[SmokeMethod("ensureVisible#", "(const QRectF&)")]
		public void EnsureVisible(QRectF rect) {
			ProxyQGraphicsItem().EnsureVisible(rect);
		}
		[SmokeMethod("ensureVisible", "()")]
		public void EnsureVisible() {
			ProxyQGraphicsItem().EnsureVisible();
		}
		[SmokeMethod("ensureVisible$$$$$$", "(qreal, qreal, qreal, qreal, int, int)")]
		public void EnsureVisible(double x, double y, double w, double h, int xmargin, int ymargin) {
			ProxyQGraphicsItem().EnsureVisible(x,y,w,h,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible$$$$$", "(qreal, qreal, qreal, qreal, int)")]
		public void EnsureVisible(double x, double y, double w, double h, int xmargin) {
			ProxyQGraphicsItem().EnsureVisible(x,y,w,h,xmargin);
		}
		[SmokeMethod("ensureVisible$$$$", "(qreal, qreal, qreal, qreal)")]
		public void EnsureVisible(double x, double y, double w, double h) {
			ProxyQGraphicsItem().EnsureVisible(x,y,w,h);
		}
		[SmokeMethod("matrix", "() const")]
		public QMatrix Matrix() {
			return ProxyQGraphicsItem().Matrix();
		}
		[SmokeMethod("sceneMatrix", "() const")]
		public QMatrix SceneMatrix() {
			return ProxyQGraphicsItem().SceneMatrix();
		}
		[SmokeMethod("setMatrix##", "(const QMatrix&, bool)")]
		public void SetMatrix(QMatrix matrix, bool combine) {
			ProxyQGraphicsItem().SetMatrix(matrix,combine);
		}
		[SmokeMethod("setMatrix#", "(const QMatrix&)")]
		public void SetMatrix(QMatrix matrix) {
			ProxyQGraphicsItem().SetMatrix(matrix);
		}
		[SmokeMethod("resetMatrix", "()")]
		public void ResetMatrix() {
			ProxyQGraphicsItem().ResetMatrix();
		}
		[SmokeMethod("rotate$", "(qreal)")]
		public void Rotate(double angle) {
			ProxyQGraphicsItem().Rotate(angle);
		}
		[SmokeMethod("scale$$", "(qreal, qreal)")]
		public void Scale(double sx, double sy) {
			ProxyQGraphicsItem().Scale(sx,sy);
		}
		[SmokeMethod("shear$$", "(qreal, qreal)")]
		public void Shear(double sh, double sv) {
			ProxyQGraphicsItem().Shear(sh,sv);
		}
		[SmokeMethod("translate$$", "(qreal, qreal)")]
		public void Translate(double dx, double dy) {
			ProxyQGraphicsItem().Translate(dx,dy);
		}
		[SmokeMethod("advance$", "(int)")]
		public virtual void Advance(int phase) {
			ProxyQGraphicsItem().Advance(phase);
		}
		[SmokeMethod("zValue", "() const")]
		public double ZValue() {
			return ProxyQGraphicsItem().ZValue();
		}
		[SmokeMethod("setZValue$", "(qreal)")]
		public void SetZValue(double z) {
			ProxyQGraphicsItem().SetZValue(z);
		}
		[SmokeMethod("boundingRect", "() const")]
		public virtual QRectF BoundingRect() {
			return ProxyQGraphicsItem().BoundingRect();
		}
		[SmokeMethod("childrenBoundingRect", "() const")]
		public QRectF ChildrenBoundingRect() {
			return ProxyQGraphicsItem().ChildrenBoundingRect();
		}
		[SmokeMethod("sceneBoundingRect", "() const")]
		public QRectF SceneBoundingRect() {
			return ProxyQGraphicsItem().SceneBoundingRect();
		}
		[SmokeMethod("shape", "() const")]
		public virtual QPainterPath Shape() {
			return ProxyQGraphicsItem().Shape();
		}
		[SmokeMethod("contains#", "(const QPointF&) const")]
		public virtual bool Contains(QPointF point) {
			return ProxyQGraphicsItem().Contains(point);
		}
		[SmokeMethod("collidesWithItem##", "(const QGraphicsItem*, Qt::ItemSelectionMode) const")]
		public virtual bool CollidesWithItem(QGraphicsItem other, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsItem().CollidesWithItem(other,mode);
		}
		[SmokeMethod("collidesWithItem#", "(const QGraphicsItem*) const")]
		public virtual bool CollidesWithItem(QGraphicsItem other) {
			return ProxyQGraphicsItem().CollidesWithItem(other);
		}
		[SmokeMethod("collidesWithPath##", "(const QPainterPath&, Qt::ItemSelectionMode) const")]
		public virtual bool CollidesWithPath(QPainterPath path, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsItem().CollidesWithPath(path,mode);
		}
		[SmokeMethod("collidesWithPath#", "(const QPainterPath&) const")]
		public virtual bool CollidesWithPath(QPainterPath path) {
			return ProxyQGraphicsItem().CollidesWithPath(path);
		}
		[SmokeMethod("collidingItems$", "(Qt::ItemSelectionMode) const")]
		public List<QGraphicsItem> CollidingItems(Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsItem().CollidingItems(mode);
		}
		[SmokeMethod("collidingItems", "() const")]
		public List<QGraphicsItem> CollidingItems() {
			return ProxyQGraphicsItem().CollidingItems();
		}
		[SmokeMethod("isObscured", "() const")]
		public bool IsObscured() {
			return ProxyQGraphicsItem().IsObscured();
		}
		[SmokeMethod("isObscuredBy#", "(const QGraphicsItem*) const")]
		public virtual bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea", "() const")]
		public virtual QPainterPath OpaqueArea() {
			return ProxyQGraphicsItem().OpaqueArea();
		}
		[SmokeMethod("paint###", "(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsItem().Paint(painter,option,widget);
		}
		[SmokeMethod("paint##", "(QPainter*, const QStyleOptionGraphicsItem*)")]
		public virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			ProxyQGraphicsItem().Paint(painter,option);
		}
		[SmokeMethod("update#", "(const QRectF&)")]
		public void Update(QRectF rect) {
			ProxyQGraphicsItem().Update(rect);
		}
		[SmokeMethod("update", "()")]
		public void Update() {
			ProxyQGraphicsItem().Update();
		}
		[SmokeMethod("update$$$$", "(qreal, qreal, qreal, qreal)")]
		public void Update(double x, double y, double width, double height) {
			ProxyQGraphicsItem().Update(x,y,width,height);
		}
		[SmokeMethod("mapToItem##", "(const QGraphicsItem*, const QPointF&) const")]
		public QPointF MapToItem(QGraphicsItem item, QPointF point) {
			return ProxyQGraphicsItem().MapToItem(item,point);
		}
		[SmokeMethod("mapToParent#", "(const QPointF&) const")]
		public QPointF MapToParent(QPointF point) {
			return ProxyQGraphicsItem().MapToParent(point);
		}
		[SmokeMethod("mapToScene#", "(const QPointF&) const")]
		public QPointF MapToScene(QPointF point) {
			return ProxyQGraphicsItem().MapToScene(point);
		}
		[SmokeMethod("mapToItem##", "(const QGraphicsItem*, const QRectF&) const")]
		public QPolygonF MapToItem(QGraphicsItem item, QRectF rect) {
			return ProxyQGraphicsItem().MapToItem(item,rect);
		}
		[SmokeMethod("mapToParent#", "(const QRectF&) const")]
		public QPolygonF MapToParent(QRectF rect) {
			return ProxyQGraphicsItem().MapToParent(rect);
		}
		[SmokeMethod("mapToScene#", "(const QRectF&) const")]
		public QPolygonF MapToScene(QRectF rect) {
			return ProxyQGraphicsItem().MapToScene(rect);
		}
		[SmokeMethod("mapToItem##", "(const QGraphicsItem*, const QPolygonF&) const")]
		public QPolygonF MapToItem(QGraphicsItem item, QPolygonF polygon) {
			return ProxyQGraphicsItem().MapToItem(item,polygon);
		}
		[SmokeMethod("mapToParent#", "(const QPolygonF&) const")]
		public QPolygonF MapToParent(QPolygonF polygon) {
			return ProxyQGraphicsItem().MapToParent(polygon);
		}
		[SmokeMethod("mapToScene#", "(const QPolygonF&) const")]
		public QPolygonF MapToScene(QPolygonF polygon) {
			return ProxyQGraphicsItem().MapToScene(polygon);
		}
		[SmokeMethod("mapToItem##", "(const QGraphicsItem*, const QPainterPath&) const")]
		public QPainterPath MapToItem(QGraphicsItem item, QPainterPath path) {
			return ProxyQGraphicsItem().MapToItem(item,path);
		}
		[SmokeMethod("mapToParent#", "(const QPainterPath&) const")]
		public QPainterPath MapToParent(QPainterPath path) {
			return ProxyQGraphicsItem().MapToParent(path);
		}
		[SmokeMethod("mapToScene#", "(const QPainterPath&) const")]
		public QPainterPath MapToScene(QPainterPath path) {
			return ProxyQGraphicsItem().MapToScene(path);
		}
		[SmokeMethod("mapFromItem##", "(const QGraphicsItem*, const QPointF&) const")]
		public QPointF MapFromItem(QGraphicsItem item, QPointF point) {
			return ProxyQGraphicsItem().MapFromItem(item,point);
		}
		[SmokeMethod("mapFromParent#", "(const QPointF&) const")]
		public QPointF MapFromParent(QPointF point) {
			return ProxyQGraphicsItem().MapFromParent(point);
		}
		[SmokeMethod("mapFromScene#", "(const QPointF&) const")]
		public QPointF MapFromScene(QPointF point) {
			return ProxyQGraphicsItem().MapFromScene(point);
		}
		[SmokeMethod("mapFromItem##", "(const QGraphicsItem*, const QRectF&) const")]
		public QPolygonF MapFromItem(QGraphicsItem item, QRectF rect) {
			return ProxyQGraphicsItem().MapFromItem(item,rect);
		}
		[SmokeMethod("mapFromParent#", "(const QRectF&) const")]
		public QPolygonF MapFromParent(QRectF rect) {
			return ProxyQGraphicsItem().MapFromParent(rect);
		}
		[SmokeMethod("mapFromScene#", "(const QRectF&) const")]
		public QPolygonF MapFromScene(QRectF rect) {
			return ProxyQGraphicsItem().MapFromScene(rect);
		}
		[SmokeMethod("mapFromItem##", "(const QGraphicsItem*, const QPolygonF&) const")]
		public QPolygonF MapFromItem(QGraphicsItem item, QPolygonF polygon) {
			return ProxyQGraphicsItem().MapFromItem(item,polygon);
		}
		[SmokeMethod("mapFromParent#", "(const QPolygonF&) const")]
		public QPolygonF MapFromParent(QPolygonF polygon) {
			return ProxyQGraphicsItem().MapFromParent(polygon);
		}
		[SmokeMethod("mapFromScene#", "(const QPolygonF&) const")]
		public QPolygonF MapFromScene(QPolygonF polygon) {
			return ProxyQGraphicsItem().MapFromScene(polygon);
		}
		[SmokeMethod("mapFromItem##", "(const QGraphicsItem*, const QPainterPath&) const")]
		public QPainterPath MapFromItem(QGraphicsItem item, QPainterPath path) {
			return ProxyQGraphicsItem().MapFromItem(item,path);
		}
		[SmokeMethod("mapFromParent#", "(const QPainterPath&) const")]
		public QPainterPath MapFromParent(QPainterPath path) {
			return ProxyQGraphicsItem().MapFromParent(path);
		}
		[SmokeMethod("mapFromScene#", "(const QPainterPath&) const")]
		public QPainterPath MapFromScene(QPainterPath path) {
			return ProxyQGraphicsItem().MapFromScene(path);
		}
		[SmokeMethod("mapToItem###", "(const QGraphicsItem*, qreal, qreal) const")]
		public QPointF MapToItem(QGraphicsItem item, double x, double y) {
			return ProxyQGraphicsItem().MapToItem(item,x,y);
		}
		[SmokeMethod("mapToParent$$", "(qreal, qreal) const")]
		public QPointF MapToParent(double x, double y) {
			return ProxyQGraphicsItem().MapToParent(x,y);
		}
		[SmokeMethod("mapToScene$$", "(qreal, qreal) const")]
		public QPointF MapToScene(double x, double y) {
			return ProxyQGraphicsItem().MapToScene(x,y);
		}
		[SmokeMethod("mapFromItem###", "(const QGraphicsItem*, qreal, qreal) const")]
		public QPointF MapFromItem(QGraphicsItem item, double x, double y) {
			return ProxyQGraphicsItem().MapFromItem(item,x,y);
		}
		[SmokeMethod("mapFromParent$$", "(qreal, qreal) const")]
		public QPointF MapFromParent(double x, double y) {
			return ProxyQGraphicsItem().MapFromParent(x,y);
		}
		[SmokeMethod("mapFromScene$$", "(qreal, qreal) const")]
		public QPointF MapFromScene(double x, double y) {
			return ProxyQGraphicsItem().MapFromScene(x,y);
		}
		[SmokeMethod("isAncestorOf#", "(const QGraphicsItem*) const")]
		public bool IsAncestorOf(QGraphicsItem child) {
			return ProxyQGraphicsItem().IsAncestorOf(child);
		}
		[SmokeMethod("data$", "(int) const")]
		public QVariant Data(int key) {
			return ProxyQGraphicsItem().Data(key);
		}
		[SmokeMethod("setData$$", "(int, const QVariant&)")]
		public void SetData(int key, QVariant value) {
			ProxyQGraphicsItem().SetData(key,value);
		}
		[SmokeMethod("type", "() const")]
		public virtual int type() {
			return ProxyQGraphicsItem().type();
		}
		[SmokeMethod("installSceneEventFilter#", "(QGraphicsItem*)")]
		public void InstallSceneEventFilter(QGraphicsItem filterItem) {
			ProxyQGraphicsItem().InstallSceneEventFilter(filterItem);
		}
		[SmokeMethod("removeSceneEventFilter#", "(QGraphicsItem*)")]
		public void RemoveSceneEventFilter(QGraphicsItem filterItem) {
			ProxyQGraphicsItem().RemoveSceneEventFilter(filterItem);
		}
		~QGraphicsItem() {
			DisposeQGraphicsItem();
		}
		public void Dispose() {
			DisposeQGraphicsItem();
		}
		[SmokeMethod("~QGraphicsItem", "()")]
		private void DisposeQGraphicsItem() {
			ProxyQGraphicsItem().DisposeQGraphicsItem();
		}
	}
}
