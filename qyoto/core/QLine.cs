//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QLine")]
	public class QLine : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QLine(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QLine), "QLine", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QLine() {
			staticInterceptor = new SmokeInvocation(typeof(QLine), "QLine", null);
		}
		public QLine() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLine", "QLine()", typeof(void));
		}
		public QLine(QPoint pt1, QPoint pt2) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLine##", "QLine(const QPoint&, const QPoint&)", typeof(void), typeof(QPoint), pt1, typeof(QPoint), pt2);
		}
		public QLine(int x1, int y1, int x2, int y2) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLine$$$$", "QLine(int, int, int, int)", typeof(void), typeof(int), x1, typeof(int), y1, typeof(int), x2, typeof(int), y2);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public QPoint P1() {
			return (QPoint) interceptor.Invoke("p1", "p1() const", typeof(QPoint));
		}
		public QPoint P2() {
			return (QPoint) interceptor.Invoke("p2", "p2() const", typeof(QPoint));
		}
		public int X1() {
			return (int) interceptor.Invoke("x1", "x1() const", typeof(int));
		}
		public int Y1() {
			return (int) interceptor.Invoke("y1", "y1() const", typeof(int));
		}
		public int X2() {
			return (int) interceptor.Invoke("x2", "x2() const", typeof(int));
		}
		public int Y2() {
			return (int) interceptor.Invoke("y2", "y2() const", typeof(int));
		}
		public int Dx() {
			return (int) interceptor.Invoke("dx", "dx() const", typeof(int));
		}
		public int Dy() {
			return (int) interceptor.Invoke("dy", "dy() const", typeof(int));
		}
		public void Translate(QPoint p) {
			interceptor.Invoke("translate#", "translate(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void Translate(int dx, int dy) {
			interceptor.Invoke("translate$$", "translate(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		public override bool Equals(object o) {
			if (!(o is QLine)) { return false; }
			return this == (QLine) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QLine() {
			interceptor.Invoke("~QLine", "~QLine()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QLine", "~QLine()", typeof(void));
		}
		public static bool operator==(QLine lhs, QLine d) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QLine&) const", typeof(bool), typeof(QLine), lhs, typeof(QLine), d);
		}
		public static bool operator!=(QLine lhs, QLine d) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QLine&) const", typeof(bool), typeof(QLine), lhs, typeof(QLine), d);
		}
		public static QLine operator*(QLine l, QMatrix m) {
			return (QLine) staticInterceptor.Invoke("operator*##", "operator*(const QLine&, const QMatrix&)", typeof(QLine), typeof(QLine), l, typeof(QMatrix), m);
		}
	}
}
