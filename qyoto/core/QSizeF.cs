//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSizeF")]
	public class QSizeF : MarshalByRefObject, IDisposable {
		protected QSizeF interceptor = null;
		private IntPtr smokeObject;
		protected QSizeF(Type dummy) {}
		[SmokeClass("QSizeF")]
		interface IQSizeFProxy {
			[SmokeMethod("operator*=", "(qreal)", "$")]
			QSizeF op_mult(QSizeF lhs, double c);
			[SmokeMethod("operator/=", "(qreal)", "$")]
			QSizeF op_div(QSizeF lhs, double c);
			[SmokeMethod("operator==", "(const QSizeF&, const QSizeF&)", "##")]
			bool op_equals(QSizeF s1, QSizeF s2);
			[SmokeMethod("operator+", "(const QSizeF&, const QSizeF&)", "##")]
			QSizeF op_plus(QSizeF s1, QSizeF s2);
			[SmokeMethod("operator-", "(const QSizeF&, const QSizeF&)", "##")]
			QSizeF op_minus(QSizeF s1, QSizeF s2);
			[SmokeMethod("operator*", "(qreal, const QSizeF&)", "$#")]
			QSizeF op_mult(double c, QSizeF s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSizeF), this);
			interceptor = (QSizeF) realProxy.GetTransparentProxy();
		}
		private static IQSizeFProxy staticInterceptor = null;
		static QSizeF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSizeFProxy), null);
			staticInterceptor = (IQSizeFProxy) realProxy.GetTransparentProxy();
		}
		public QSizeF() : this((Type) null) {
			CreateProxy();
			NewQSizeF();
		}
		[SmokeMethod("QSizeF", "()", "")]
		private void NewQSizeF() {
			((QSizeF) interceptor).NewQSizeF();
		}
		public QSizeF(QSize sz) : this((Type) null) {
			CreateProxy();
			NewQSizeF(sz);
		}
		[SmokeMethod("QSizeF", "(const QSize&)", "#")]
		private void NewQSizeF(QSize sz) {
			((QSizeF) interceptor).NewQSizeF(sz);
		}
		public QSizeF(double w, double h) : this((Type) null) {
			CreateProxy();
			NewQSizeF(w,h);
		}
		[SmokeMethod("QSizeF", "(qreal, qreal)", "$$")]
		private void NewQSizeF(double w, double h) {
			((QSizeF) interceptor).NewQSizeF(w,h);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ((QSizeF) interceptor).IsNull();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ((QSizeF) interceptor).IsEmpty();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ((QSizeF) interceptor).IsValid();
		}
		[SmokeMethod("width", "() const", "")]
		public double Width() {
			return ((QSizeF) interceptor).Width();
		}
		[SmokeMethod("height", "() const", "")]
		public double Height() {
			return ((QSizeF) interceptor).Height();
		}
		[SmokeMethod("setWidth", "(qreal)", "$")]
		public void SetWidth(double w) {
			((QSizeF) interceptor).SetWidth(w);
		}
		[SmokeMethod("setHeight", "(qreal)", "$")]
		public void SetHeight(double h) {
			((QSizeF) interceptor).SetHeight(h);
		}
		[SmokeMethod("transpose", "()", "")]
		public void Transpose() {
			((QSizeF) interceptor).Transpose();
		}
		[SmokeMethod("scale", "(qreal, qreal, Qt::AspectRatioMode)", "$$$")]
		public void Scale(double w, double h, Qt.AspectRatioMode mode) {
			((QSizeF) interceptor).Scale(w,h,mode);
		}
		[SmokeMethod("scale", "(const QSizeF&, Qt::AspectRatioMode)", "#$")]
		public void Scale(QSizeF s, Qt.AspectRatioMode mode) {
			((QSizeF) interceptor).Scale(s,mode);
		}
		[SmokeMethod("expandedTo", "(const QSizeF&) const", "#")]
		public QSizeF ExpandedTo(QSizeF arg1) {
			return ((QSizeF) interceptor).ExpandedTo(arg1);
		}
		[SmokeMethod("boundedTo", "(const QSizeF&) const", "#")]
		public QSizeF BoundedTo(QSizeF arg1) {
			return ((QSizeF) interceptor).BoundedTo(arg1);
		}
		[SmokeMethod("rwidth", "()", "")]
		public  double Rwidth() {
			return ((QSizeF) interceptor).Rwidth();
		}
		[SmokeMethod("rheight", "()", "")]
		public  double Rheight() {
			return ((QSizeF) interceptor).Rheight();
		}
		[SmokeMethod("toSize", "() const", "")]
		public QSize ToSize() {
			return ((QSizeF) interceptor).ToSize();
		}
		~QSizeF() {
			DisposeQSizeF();
		}
		public void Dispose() {
			DisposeQSizeF();
		}
		[SmokeMethod("~QSizeF", "()", "")]
		private void DisposeQSizeF() {
			((QSizeF) interceptor).DisposeQSizeF();
		}
		public override bool Equals(object o) {
			if (!(o is QSizeF)) { return false; }
			return this == (QSizeF) o;
		}
		public override int GetHashCode() {
			return ((QSizeF) interceptor).GetHashCode();
		}
		public static QSizeF operator*(QSizeF lhs, double c) {
			return staticInterceptor.op_mult(lhs,c);
		}
		public static QSizeF operator/(QSizeF lhs, double c) {
			return staticInterceptor.op_div(lhs,c);
		}
		public static bool operator==(QSizeF s1, QSizeF s2) {
			return staticInterceptor.op_equals(s1,s2);
		}
		public static bool operator!=(QSizeF s1, QSizeF s2) {
			return !staticInterceptor.op_equals(s1,s2);
		}
		public static QSizeF operator+(QSizeF s1, QSizeF s2) {
			return staticInterceptor.op_plus(s1,s2);
		}
		public static QSizeF operator-(QSizeF s1, QSizeF s2) {
			return staticInterceptor.op_minus(s1,s2);
		}
		public static QSizeF operator*(double c, QSizeF s) {
			return staticInterceptor.op_mult(c,s);
		}
	}
}
