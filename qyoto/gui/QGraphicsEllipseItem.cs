//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsEllipseItem")]
	public class QGraphicsEllipseItem : QAbstractGraphicsShapeItem, IDisposable {
 		protected QGraphicsEllipseItem(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGraphicsEllipseItem), "QGraphicsEllipseItem", this);
		}
		public const int Type = 4;

		public QGraphicsEllipseItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem##", "QGraphicsEllipseItem(QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsEllipseItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem#", "QGraphicsEllipseItem(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), parent);
		}
		public QGraphicsEllipseItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem", "QGraphicsEllipseItem()", typeof(void));
		}
		public QGraphicsEllipseItem(QRectF rect, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem###", "QGraphicsEllipseItem(const QRectF&, QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(QRectF), rect, typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsEllipseItem(QRectF rect, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem##", "QGraphicsEllipseItem(const QRectF&, QGraphicsItem*)", typeof(void), typeof(QRectF), rect, typeof(QGraphicsItem), parent);
		}
		public QGraphicsEllipseItem(QRectF rect) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem#", "QGraphicsEllipseItem(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public QGraphicsEllipseItem(double x, double y, double w, double h, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem$$$$##", "QGraphicsEllipseItem(qreal, qreal, qreal, qreal, QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsEllipseItem(double x, double y, double w, double h, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem$$$$#", "QGraphicsEllipseItem(qreal, qreal, qreal, qreal, QGraphicsItem*)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(QGraphicsItem), parent);
		}
		public QGraphicsEllipseItem(double x, double y, double w, double h) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsEllipseItem$$$$", "QGraphicsEllipseItem(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QRectF Rect() {
			return (QRectF) interceptor.Invoke("rect", "rect() const", typeof(QRectF));
		}
		public void SetRect(QRectF rect) {
			interceptor.Invoke("setRect#", "setRect(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void SetRect(double x, double y, double w, double h) {
			interceptor.Invoke("setRect$$$$", "setRect(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public int StartAngle() {
			return (int) interceptor.Invoke("startAngle", "startAngle() const", typeof(int));
		}
		public void SetStartAngle(int angle) {
			interceptor.Invoke("setStartAngle$", "setStartAngle(int)", typeof(void), typeof(int), angle);
		}
		public int SpanAngle() {
			return (int) interceptor.Invoke("spanAngle", "spanAngle() const", typeof(int));
		}
		public void SetSpanAngle(int angle) {
			interceptor.Invoke("setSpanAngle$", "setSpanAngle(int)", typeof(void), typeof(int), angle);
		}
		[SmokeMethod("boundingRect() const")]
		public override QRectF BoundingRect() {
			return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
		}
		[SmokeMethod("shape() const")]
		public override QPainterPath Shape() {
			return (QPainterPath) interceptor.Invoke("shape", "shape() const", typeof(QPainterPath));
		}
		[SmokeMethod("contains(const QPointF&) const")]
		public override bool Contains(QPointF point) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPointF&) const", typeof(bool), typeof(QPointF), point);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public override void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*)")]
		public virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			interceptor.Invoke("paint##", "paint(QPainter*, const QStyleOptionGraphicsItem*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option);
		}
		[SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
		public override bool IsObscuredBy(QGraphicsItem item) {
			return (bool) interceptor.Invoke("isObscuredBy#", "isObscuredBy(const QGraphicsItem*) const", typeof(bool), typeof(QGraphicsItem), item);
		}
		[SmokeMethod("opaqueArea() const")]
		public override QPainterPath OpaqueArea() {
			return (QPainterPath) interceptor.Invoke("opaqueArea", "opaqueArea() const", typeof(QPainterPath));
		}
		[SmokeMethod("type() const")]
		public override int type() {
			return (int) interceptor.Invoke("type", "type() const", typeof(int));
		}
		[SmokeMethod("supportsExtension(QGraphicsItem::Extension) const")]
		protected override bool SupportsExtension(QGraphicsItem.Extension extension) {
			return (bool) interceptor.Invoke("supportsExtension$", "supportsExtension(QGraphicsItem::Extension) const", typeof(bool), typeof(QGraphicsItem.Extension), extension);
		}
		[SmokeMethod("setExtension(QGraphicsItem::Extension, const QVariant&)")]
		protected override void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			interceptor.Invoke("setExtension$#", "setExtension(QGraphicsItem::Extension, const QVariant&)", typeof(void), typeof(QGraphicsItem.Extension), extension, typeof(QVariant), variant);
		}
		[SmokeMethod("extension(const QVariant&) const")]
		protected override QVariant extension(QVariant variant) {
			return (QVariant) interceptor.Invoke("extension#", "extension(const QVariant&) const", typeof(QVariant), typeof(QVariant), variant);
		}
		~QGraphicsEllipseItem() {
			interceptor.Invoke("~QGraphicsEllipseItem", "~QGraphicsEllipseItem()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QGraphicsEllipseItem", "~QGraphicsEllipseItem()", typeof(void));
		}
	}
}
