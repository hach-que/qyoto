//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSizeF")]
	public class QSizeF : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QSizeF(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSizeF), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSizeF() {
			staticInterceptor = new SmokeInvocation(typeof(QSizeF), null);
		}
		public QSizeF() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSizeF", "QSizeF()", typeof(void));
		}
		public QSizeF(QSize sz) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSizeF#", "QSizeF(const QSize&)", typeof(void), typeof(QSize), sz);
		}
		public QSizeF(double w, double h) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSizeF$$", "QSizeF(qreal, qreal)", typeof(void), typeof(double), w, typeof(double), h);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public double Width() {
			return (double) interceptor.Invoke("width", "width() const", typeof(double));
		}
		public double Height() {
			return (double) interceptor.Invoke("height", "height() const", typeof(double));
		}
		public void SetWidth(double w) {
			interceptor.Invoke("setWidth$", "setWidth(qreal)", typeof(void), typeof(double), w);
		}
		public void SetHeight(double h) {
			interceptor.Invoke("setHeight$", "setHeight(qreal)", typeof(void), typeof(double), h);
		}
		public void Transpose() {
			interceptor.Invoke("transpose", "transpose()", typeof(void));
		}
		public void Scale(double w, double h, Qt.AspectRatioMode mode) {
			interceptor.Invoke("scale$$$", "scale(qreal, qreal, Qt::AspectRatioMode)", typeof(void), typeof(double), w, typeof(double), h, typeof(Qt.AspectRatioMode), mode);
		}
		public void Scale(QSizeF s, Qt.AspectRatioMode mode) {
			interceptor.Invoke("scale#$", "scale(const QSizeF&, Qt::AspectRatioMode)", typeof(void), typeof(QSizeF), s, typeof(Qt.AspectRatioMode), mode);
		}
		public QSizeF ExpandedTo(QSizeF arg1) {
			return (QSizeF) interceptor.Invoke("expandedTo#", "expandedTo(const QSizeF&) const", typeof(QSizeF), typeof(QSizeF), arg1);
		}
		public QSizeF BoundedTo(QSizeF arg1) {
			return (QSizeF) interceptor.Invoke("boundedTo#", "boundedTo(const QSizeF&) const", typeof(QSizeF), typeof(QSizeF), arg1);
		}
		public double Rwidth() {
			return (double) interceptor.Invoke("rwidth", "rwidth()", typeof(double));
		}
		public double Rheight() {
			return (double) interceptor.Invoke("rheight", "rheight()", typeof(double));
		}
		public QSize ToSize() {
			return (QSize) interceptor.Invoke("toSize", "toSize() const", typeof(QSize));
		}
		~QSizeF() {
			interceptor.Invoke("~QSizeF", "~QSizeF()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QSizeF", "~QSizeF()", typeof(void));
		}
		public override bool Equals(object o) {
			if (!(o is QSizeF)) { return false; }
			return this == (QSizeF) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public static QSizeF operator*(QSizeF lhs, double c) {
			return (QSizeF) staticInterceptor.Invoke("operator*=$", "operator*=(qreal)", typeof(QSizeF), typeof(QSizeF), lhs, typeof(double), c);
		}
		public static QSizeF operator/(QSizeF lhs, double c) {
			return (QSizeF) staticInterceptor.Invoke("operator/=$", "operator/=(qreal)", typeof(QSizeF), typeof(QSizeF), lhs, typeof(double), c);
		}
		public static bool operator==(QSizeF s1, QSizeF s2) {
			return (bool) staticInterceptor.Invoke("operator==##", "operator==(const QSizeF&, const QSizeF&)", typeof(bool), typeof(QSizeF), s1, typeof(QSizeF), s2);
		}
		public static bool operator!=(QSizeF s1, QSizeF s2) {
			return !(bool) staticInterceptor.Invoke("operator==##", "operator==(const QSizeF&, const QSizeF&)", typeof(bool), typeof(QSizeF), s1, typeof(QSizeF), s2);
		}
		public static QSizeF operator+(QSizeF s1, QSizeF s2) {
			return (QSizeF) staticInterceptor.Invoke("operator+##", "operator+(const QSizeF&, const QSizeF&)", typeof(QSizeF), typeof(QSizeF), s1, typeof(QSizeF), s2);
		}
		public static QSizeF operator-(QSizeF s1, QSizeF s2) {
			return (QSizeF) staticInterceptor.Invoke("operator-##", "operator-(const QSizeF&, const QSizeF&)", typeof(QSizeF), typeof(QSizeF), s1, typeof(QSizeF), s2);
		}
		public static QSizeF operator*(double c, QSizeF s) {
			return (QSizeF) staticInterceptor.Invoke("operator*$#", "operator*(qreal, const QSizeF&)", typeof(QSizeF), typeof(double), c, typeof(QSizeF), s);
		}
	}
}
