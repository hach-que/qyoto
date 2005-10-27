//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QMatrix : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMatrix(Type dummy) {}
		interface IQMatrixProxy {
			bool op_equals(QMatrix lhs, QMatrix arg1);
			QMatrix op_mult(QMatrix lhs, QMatrix o);
		}

		protected void CreateQMatrixProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMatrix), this);
			_interceptor = (QMatrix) realProxy.GetTransparentProxy();
		}
		private QMatrix ProxyQMatrix() {
			return (QMatrix) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMatrix() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMatrixProxy), null);
			_staticInterceptor = (IQMatrixProxy) realProxy.GetTransparentProxy();
		}
		private static IQMatrixProxy StaticQMatrix() {
			return (IQMatrixProxy) _staticInterceptor;
		}

		public QMatrix() : this((Type) null) {
			CreateQMatrixProxy();
			NewQMatrix();
		}
		private void NewQMatrix() {
			ProxyQMatrix().NewQMatrix();
		}
		public QMatrix(double m11, double m12, double m21, double m22, double dx, double dy) : this((Type) null) {
			CreateQMatrixProxy();
			NewQMatrix(m11,m12,m21,m22,dx,dy);
		}
		private void NewQMatrix(double m11, double m12, double m21, double m22, double dx, double dy) {
			ProxyQMatrix().NewQMatrix(m11,m12,m21,m22,dx,dy);
		}
		public QMatrix(QMatrix matrix) : this((Type) null) {
			CreateQMatrixProxy();
			NewQMatrix(matrix);
		}
		private void NewQMatrix(QMatrix matrix) {
			ProxyQMatrix().NewQMatrix(matrix);
		}
		public void SetMatrix(double m11, double m12, double m21, double m22, double dx, double dy) {
			ProxyQMatrix().SetMatrix(m11,m12,m21,m22,dx,dy);
		}
		public double M11() {
			return ProxyQMatrix().M11();
		}
		public double M12() {
			return ProxyQMatrix().M12();
		}
		public double M21() {
			return ProxyQMatrix().M21();
		}
		public double M22() {
			return ProxyQMatrix().M22();
		}
		public double Dx() {
			return ProxyQMatrix().Dx();
		}
		public double Dy() {
			return ProxyQMatrix().Dy();
		}
		public void Map(int x, int y, out int tx, out int ty) {
			ProxyQMatrix().Map(x,y,out tx,out ty);
		}
		// void map(qreal arg1,qreal arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		public QRect MapRect(QRect arg1) {
			return ProxyQMatrix().MapRect(arg1);
		}
		public QRectF MapRect(QRectF arg1) {
			return ProxyQMatrix().MapRect(arg1);
		}
		public QPoint Map(QPoint p) {
			return ProxyQMatrix().Map(p);
		}
		public QPointF Map(QPointF p) {
			return ProxyQMatrix().Map(p);
		}
		public QLine Map(QLine l) {
			return ProxyQMatrix().Map(l);
		}
		public QLineF Map(QLineF l) {
			return ProxyQMatrix().Map(l);
		}
		public QPolygonF Map(QPolygonF a) {
			return ProxyQMatrix().Map(a);
		}
		public QPolygon Map(QPolygon a) {
			return ProxyQMatrix().Map(a);
		}
		public QRegion Map(QRegion r) {
			return ProxyQMatrix().Map(r);
		}
		public QPainterPath Map(QPainterPath p) {
			return ProxyQMatrix().Map(p);
		}
		public QPolygon MapToPolygon(QRect r) {
			return ProxyQMatrix().MapToPolygon(r);
		}
		public void Reset() {
			ProxyQMatrix().Reset();
		}
		public bool IsIdentity() {
			return ProxyQMatrix().IsIdentity();
		}
		public QMatrix Translate(double dx, double dy) {
			return ProxyQMatrix().Translate(dx,dy);
		}
		public QMatrix Scale(double sx, double sy) {
			return ProxyQMatrix().Scale(sx,sy);
		}
		public QMatrix Shear(double sh, double sv) {
			return ProxyQMatrix().Shear(sh,sv);
		}
		public QMatrix Rotate(double a) {
			return ProxyQMatrix().Rotate(a);
		}
		public bool IsInvertible() {
			return ProxyQMatrix().IsInvertible();
		}
		public double Det() {
			return ProxyQMatrix().Det();
		}
		public QMatrix Inverted(out bool invertible) {
			return ProxyQMatrix().Inverted(out invertible);
		}
		public QMatrix Inverted() {
			return ProxyQMatrix().Inverted();
		}
		public static bool operator==(QMatrix lhs, QMatrix arg1) {
			return StaticQMatrix().op_equals(lhs,arg1);
		}
		public static bool operator!=(QMatrix lhs, QMatrix arg1) {
			return !StaticQMatrix().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QMatrix)) { return false; }
			return this == (QMatrix) o;
		}
		public override int GetHashCode() {
			return ProxyQMatrix().GetHashCode();
		}
		public static QMatrix operator*(QMatrix lhs, QMatrix o) {
			return StaticQMatrix().op_mult(lhs,o);
		}
		~QMatrix() {
			ProxyQMatrix().Dispose();
		}
		public void Dispose() {
			ProxyQMatrix().Dispose();
		}
	}
}
