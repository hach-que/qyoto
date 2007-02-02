//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QLine")]
	public class QLine : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QLine(Type dummy) {}
		interface IQLineProxy {
			bool op_equals(QLine lhs, QLine d);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLine), this);
			_interceptor = (QLine) realProxy.GetTransparentProxy();
		}
		private QLine ProxyQLine() {
			return (QLine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLineProxy), null);
			_staticInterceptor = (IQLineProxy) realProxy.GetTransparentProxy();
		}
		private static IQLineProxy StaticQLine() {
			return (IQLineProxy) _staticInterceptor;
		}

		public QLine() : this((Type) null) {
			CreateProxy();
			NewQLine();
		}
		[SmokeMethod("QLine", "()")]
		private void NewQLine() {
			ProxyQLine().NewQLine();
		}
		public QLine(QPoint pt1, QPoint pt2) : this((Type) null) {
			CreateProxy();
			NewQLine(pt1,pt2);
		}
		[SmokeMethod("QLine##", "(const QPoint&, const QPoint&)")]
		private void NewQLine(QPoint pt1, QPoint pt2) {
			ProxyQLine().NewQLine(pt1,pt2);
		}
		public QLine(int x1, int y1, int x2, int y2) : this((Type) null) {
			CreateProxy();
			NewQLine(x1,y1,x2,y2);
		}
		[SmokeMethod("QLine$$$$", "(int, int, int, int)")]
		private void NewQLine(int x1, int y1, int x2, int y2) {
			ProxyQLine().NewQLine(x1,y1,x2,y2);
		}
		[SmokeMethod("isNull", "() const")]
		public bool IsNull() {
			return ProxyQLine().IsNull();
		}
		[SmokeMethod("p1", "() const")]
		public QPoint P1() {
			return ProxyQLine().P1();
		}
		[SmokeMethod("p2", "() const")]
		public QPoint P2() {
			return ProxyQLine().P2();
		}
		[SmokeMethod("x1", "() const")]
		public int X1() {
			return ProxyQLine().X1();
		}
		[SmokeMethod("y1", "() const")]
		public int Y1() {
			return ProxyQLine().Y1();
		}
		[SmokeMethod("x2", "() const")]
		public int X2() {
			return ProxyQLine().X2();
		}
		[SmokeMethod("y2", "() const")]
		public int Y2() {
			return ProxyQLine().Y2();
		}
		[SmokeMethod("dx", "() const")]
		public int Dx() {
			return ProxyQLine().Dx();
		}
		[SmokeMethod("dy", "() const")]
		public int Dy() {
			return ProxyQLine().Dy();
		}
		[SmokeMethod("translate#", "(const QPoint&)")]
		public void Translate(QPoint p) {
			ProxyQLine().Translate(p);
		}
		[SmokeMethod("translate$$", "(int, int)")]
		public void Translate(int dx, int dy) {
			ProxyQLine().Translate(dx,dy);
		}
		[SmokeMethod("operator==#", "(const QLine&) const")]
		public static bool operator==(QLine lhs, QLine d) {
			return StaticQLine().op_equals(lhs,d);
		}
		public static bool operator!=(QLine lhs, QLine d) {
			return !StaticQLine().op_equals(lhs,d);
		}
		public override bool Equals(object o) {
			if (!(o is QLine)) { return false; }
			return this == (QLine) o;
		}
		public override int GetHashCode() {
			return ProxyQLine().GetHashCode();
		}
		~QLine() {
			DisposeQLine();
		}
		public void Dispose() {
			DisposeQLine();
		}
		[SmokeMethod("~QLine", "()")]
		private void DisposeQLine() {
			ProxyQLine().DisposeQLine();
		}
	}
}
