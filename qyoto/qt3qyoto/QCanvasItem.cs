//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;

	public class QCanvasItem : Qt {
 		protected QCanvasItem(Type dummy) : base((Type) null) {}
		interface IQCanvasItemProxy {
		}

		protected void CreateQCanvasItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCanvasItem), this);
			_interceptor = (QCanvasItem) realProxy.GetTransparentProxy();
		}
		private QCanvasItem ProxyQCanvasItem() {
			return (QCanvasItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCanvasItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCanvasItemProxy), null);
			_staticInterceptor = (IQCanvasItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQCanvasItemProxy StaticQCanvasItem() {
			return (IQCanvasItemProxy) _staticInterceptor;
		}

		enum RttiValues {
			Rtti_Item = 0,
			Rtti_Sprite = 1,
			Rtti_PolygonalItem = 2,
			Rtti_Text = 3,
			Rtti_Polygon = 4,
			Rtti_Rectangle = 5,
			Rtti_Ellipse = 6,
			Rtti_Line = 7,
			Rtti_Spline = 8,
		}
		[SmokeMethod("x() const")]
		public double X() {
			return ProxyQCanvasItem().X();
		}
		[SmokeMethod("y() const")]
		public double Y() {
			return ProxyQCanvasItem().Y();
		}
		[SmokeMethod("z() const")]
		public double Z() {
			return ProxyQCanvasItem().Z();
		}
		[SmokeMethod("moveBy(double, double)")]
		public virtual void MoveBy(double dx, double dy) {
			ProxyQCanvasItem().MoveBy(dx,dy);
		}
		[SmokeMethod("move(double, double)")]
		public void Move(double x, double y) {
			ProxyQCanvasItem().Move(x,y);
		}
		[SmokeMethod("setX(double)")]
		public void SetX(double a) {
			ProxyQCanvasItem().SetX(a);
		}
		[SmokeMethod("setY(double)")]
		public void SetY(double a) {
			ProxyQCanvasItem().SetY(a);
		}
		[SmokeMethod("setZ(double)")]
		public void SetZ(double a) {
			ProxyQCanvasItem().SetZ(a);
		}
		[SmokeMethod("animated() const")]
		public bool Animated() {
			return ProxyQCanvasItem().Animated();
		}
		[SmokeMethod("setAnimated(bool)")]
		public virtual void SetAnimated(bool y) {
			ProxyQCanvasItem().SetAnimated(y);
		}
		[SmokeMethod("setVelocity(double, double)")]
		public virtual void SetVelocity(double vx, double vy) {
			ProxyQCanvasItem().SetVelocity(vx,vy);
		}
		[SmokeMethod("setXVelocity(double)")]
		public void SetXVelocity(double vx) {
			ProxyQCanvasItem().SetXVelocity(vx);
		}
		[SmokeMethod("setYVelocity(double)")]
		public void SetYVelocity(double vy) {
			ProxyQCanvasItem().SetYVelocity(vy);
		}
		[SmokeMethod("xVelocity() const")]
		public double XVelocity() {
			return ProxyQCanvasItem().XVelocity();
		}
		[SmokeMethod("yVelocity() const")]
		public double YVelocity() {
			return ProxyQCanvasItem().YVelocity();
		}
		[SmokeMethod("advance(int)")]
		public virtual void Advance(int stage) {
			ProxyQCanvasItem().Advance(stage);
		}
		[SmokeMethod("collidesWith(const QCanvasItem*) const")]
		public virtual bool CollidesWith(QCanvasItem arg1) {
			return ProxyQCanvasItem().CollidesWith(arg1);
		}
		[SmokeMethod("collisions(bool) const")]
		public ArrayList Collisions(bool exact) {
			return ProxyQCanvasItem().Collisions(exact);
		}
		[SmokeMethod("setCanvas(QCanvas*)")]
		public virtual void SetCanvas(QCanvas arg1) {
			ProxyQCanvasItem().SetCanvas(arg1);
		}
		[SmokeMethod("draw(QPainter&)")]
		public virtual void Draw(QPainter arg1) {
			ProxyQCanvasItem().Draw(arg1);
		}
		[SmokeMethod("show()")]
		public void Show() {
			ProxyQCanvasItem().Show();
		}
		[SmokeMethod("hide()")]
		public void Hide() {
			ProxyQCanvasItem().Hide();
		}
		[SmokeMethod("setVisible(bool)")]
		public virtual void SetVisible(bool yes) {
			ProxyQCanvasItem().SetVisible(yes);
		}
		[SmokeMethod("isVisible() const")]
		public bool IsVisible() {
			return ProxyQCanvasItem().IsVisible();
		}
		[SmokeMethod("setSelected(bool)")]
		public virtual void SetSelected(bool yes) {
			ProxyQCanvasItem().SetSelected(yes);
		}
		[SmokeMethod("isSelected() const")]
		public bool IsSelected() {
			return ProxyQCanvasItem().IsSelected();
		}
		[SmokeMethod("setEnabled(bool)")]
		public virtual void SetEnabled(bool yes) {
			ProxyQCanvasItem().SetEnabled(yes);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQCanvasItem().IsEnabled();
		}
		[SmokeMethod("setActive(bool)")]
		public virtual void SetActive(bool yes) {
			ProxyQCanvasItem().SetActive(yes);
		}
		[SmokeMethod("isActive() const")]
		public bool IsActive() {
			return ProxyQCanvasItem().IsActive();
		}
		[SmokeMethod("visible() const")]
		public bool Visible() {
			return ProxyQCanvasItem().Visible();
		}
		[SmokeMethod("selected() const")]
		public bool Selected() {
			return ProxyQCanvasItem().Selected();
		}
		[SmokeMethod("enabled() const")]
		public bool Enabled() {
			return ProxyQCanvasItem().Enabled();
		}
		[SmokeMethod("active() const")]
		public bool Active() {
			return ProxyQCanvasItem().Active();
		}
		[SmokeMethod("rtti() const")]
		public virtual int Rtti() {
			return ProxyQCanvasItem().Rtti();
		}
		[SmokeMethod("boundingRect() const")]
		public virtual QRect BoundingRect() {
			return ProxyQCanvasItem().BoundingRect();
		}
		[SmokeMethod("boundingRectAdvanced() const")]
		public virtual QRect BoundingRectAdvanced() {
			return ProxyQCanvasItem().BoundingRectAdvanced();
		}
		[SmokeMethod("canvas() const")]
		public QCanvas Canvas() {
			return ProxyQCanvasItem().Canvas();
		}
	}
}