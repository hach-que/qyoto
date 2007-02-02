//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsPathItem")]
	public class QGraphicsPathItem : QAbstractGraphicsShapeItem, IDisposable {
 		protected QGraphicsPathItem(Type dummy) : base((Type) null) {}
		interface IQGraphicsPathItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsPathItem), this);
			_interceptor = (QGraphicsPathItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsPathItem ProxyQGraphicsPathItem() {
			return (QGraphicsPathItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsPathItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsPathItemProxy), null);
			_staticInterceptor = (IQGraphicsPathItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsPathItemProxy StaticQGraphicsPathItem() {
			return (IQGraphicsPathItemProxy) _staticInterceptor;
		}

		public const int Type = 2;

		public QGraphicsPathItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPathItem(parent,scene);
		}
		[SmokeMethod("QGraphicsPathItem##", "(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsPathItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsPathItem().NewQGraphicsPathItem(parent,scene);
		}
		public QGraphicsPathItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPathItem(parent);
		}
		[SmokeMethod("QGraphicsPathItem#", "(QGraphicsItem*)")]
		private void NewQGraphicsPathItem(QGraphicsItem parent) {
			ProxyQGraphicsPathItem().NewQGraphicsPathItem(parent);
		}
		public QGraphicsPathItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsPathItem();
		}
		[SmokeMethod("QGraphicsPathItem", "()")]
		private void NewQGraphicsPathItem() {
			ProxyQGraphicsPathItem().NewQGraphicsPathItem();
		}
		public QGraphicsPathItem(QPainterPath path, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPathItem(path,parent,scene);
		}
		[SmokeMethod("QGraphicsPathItem###", "(const QPainterPath&, QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsPathItem(QPainterPath path, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsPathItem().NewQGraphicsPathItem(path,parent,scene);
		}
		public QGraphicsPathItem(QPainterPath path, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPathItem(path,parent);
		}
		[SmokeMethod("QGraphicsPathItem##", "(const QPainterPath&, QGraphicsItem*)")]
		private void NewQGraphicsPathItem(QPainterPath path, QGraphicsItem parent) {
			ProxyQGraphicsPathItem().NewQGraphicsPathItem(path,parent);
		}
		public QGraphicsPathItem(QPainterPath path) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPathItem(path);
		}
		[SmokeMethod("QGraphicsPathItem#", "(const QPainterPath&)")]
		private void NewQGraphicsPathItem(QPainterPath path) {
			ProxyQGraphicsPathItem().NewQGraphicsPathItem(path);
		}
		[SmokeMethod("path", "() const")]
		public QPainterPath Path() {
			return ProxyQGraphicsPathItem().Path();
		}
		[SmokeMethod("setPath#", "(const QPainterPath&)")]
		public void SetPath(QPainterPath path) {
			ProxyQGraphicsPathItem().SetPath(path);
		}
		[SmokeMethod("boundingRect", "() const")]
		public new QRectF BoundingRect() {
			return ProxyQGraphicsPathItem().BoundingRect();
		}
		[SmokeMethod("shape", "() const")]
		public new QPainterPath Shape() {
			return ProxyQGraphicsPathItem().Shape();
		}
		[SmokeMethod("contains#", "(const QPointF&) const")]
		public new bool Contains(QPointF point) {
			return ProxyQGraphicsPathItem().Contains(point);
		}
		[SmokeMethod("paint###", "(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsPathItem().Paint(painter,option,widget);
		}
		[SmokeMethod("paint##", "(QPainter*, const QStyleOptionGraphicsItem*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			ProxyQGraphicsPathItem().Paint(painter,option);
		}
		[SmokeMethod("isObscuredBy#", "(const QGraphicsItem*) const")]
		public new bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsPathItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea", "() const")]
		public new QPainterPath OpaqueArea() {
			return ProxyQGraphicsPathItem().OpaqueArea();
		}
		[SmokeMethod("type", "() const")]
		public new int type() {
			return ProxyQGraphicsPathItem().type();
		}
		[SmokeMethod("supportsExtension$", "(QGraphicsItem::Extension) const")]
		protected new bool SupportsExtension(QGraphicsItem.Extension extension) {
			return ProxyQGraphicsPathItem().SupportsExtension(extension);
		}
		[SmokeMethod("setExtension$$", "(QGraphicsItem::Extension, const QVariant&)")]
		protected new void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			ProxyQGraphicsPathItem().SetExtension(extension,variant);
		}
		[SmokeMethod("extension#", "(const QVariant&) const")]
		protected new QVariant Extension(QVariant variant) {
			return ProxyQGraphicsPathItem().Extension(variant);
		}
		~QGraphicsPathItem() {
			DisposeQGraphicsPathItem();
		}
		public void Dispose() {
			DisposeQGraphicsPathItem();
		}
		[SmokeMethod("~QGraphicsPathItem", "()")]
		private void DisposeQGraphicsPathItem() {
			ProxyQGraphicsPathItem().DisposeQGraphicsPathItem();
		}
	}
}
