//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QFontMetricsF")]
	public class QFontMetricsF : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QFontMetricsF(Type dummy) {}
		interface IQFontMetricsFProxy {
			bool op_equals(QFontMetricsF lhs, QFontMetricsF other);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontMetricsF), this);
			_interceptor = (QFontMetricsF) realProxy.GetTransparentProxy();
		}
		private QFontMetricsF ProxyQFontMetricsF() {
			return (QFontMetricsF) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontMetricsF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontMetricsFProxy), null);
			_staticInterceptor = (IQFontMetricsFProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontMetricsFProxy StaticQFontMetricsF() {
			return (IQFontMetricsFProxy) _staticInterceptor;
		}

		public QFontMetricsF(QFont arg1) : this((Type) null) {
			CreateProxy();
			NewQFontMetricsF(arg1);
		}
		[SmokeMethod("QFontMetricsF(const QFont&)")]
		private void NewQFontMetricsF(QFont arg1) {
			ProxyQFontMetricsF().NewQFontMetricsF(arg1);
		}
		public QFontMetricsF(QFont arg1, IQPaintDevice pd) : this((Type) null) {
			CreateProxy();
			NewQFontMetricsF(arg1,pd);
		}
		[SmokeMethod("QFontMetricsF(const QFont&, QPaintDevice*)")]
		private void NewQFontMetricsF(QFont arg1, IQPaintDevice pd) {
			ProxyQFontMetricsF().NewQFontMetricsF(arg1,pd);
		}
		public QFontMetricsF(QFontMetricsF arg1) : this((Type) null) {
			CreateProxy();
			NewQFontMetricsF(arg1);
		}
		[SmokeMethod("QFontMetricsF(const QFontMetricsF&)")]
		private void NewQFontMetricsF(QFontMetricsF arg1) {
			ProxyQFontMetricsF().NewQFontMetricsF(arg1);
		}
		[SmokeMethod("ascent() const")]
		public double Ascent() {
			return ProxyQFontMetricsF().Ascent();
		}
		[SmokeMethod("descent() const")]
		public double Descent() {
			return ProxyQFontMetricsF().Descent();
		}
		[SmokeMethod("height() const")]
		public double Height() {
			return ProxyQFontMetricsF().Height();
		}
		[SmokeMethod("leading() const")]
		public double Leading() {
			return ProxyQFontMetricsF().Leading();
		}
		[SmokeMethod("lineSpacing() const")]
		public double LineSpacing() {
			return ProxyQFontMetricsF().LineSpacing();
		}
		[SmokeMethod("minLeftBearing() const")]
		public double MinLeftBearing() {
			return ProxyQFontMetricsF().MinLeftBearing();
		}
		[SmokeMethod("minRightBearing() const")]
		public double MinRightBearing() {
			return ProxyQFontMetricsF().MinRightBearing();
		}
		[SmokeMethod("maxWidth() const")]
		public double MaxWidth() {
			return ProxyQFontMetricsF().MaxWidth();
		}
		[SmokeMethod("xHeight() const")]
		public double XHeight() {
			return ProxyQFontMetricsF().XHeight();
		}
		[SmokeMethod("inFont(QChar) const")]
		public bool InFont(char arg1) {
			return ProxyQFontMetricsF().InFont(arg1);
		}
		[SmokeMethod("leftBearing(QChar) const")]
		public double LeftBearing(char arg1) {
			return ProxyQFontMetricsF().LeftBearing(arg1);
		}
		[SmokeMethod("rightBearing(QChar) const")]
		public double RightBearing(char arg1) {
			return ProxyQFontMetricsF().RightBearing(arg1);
		}
		[SmokeMethod("width(const QString&) const")]
		public double Width(string arg1) {
			return ProxyQFontMetricsF().Width(arg1);
		}
		[SmokeMethod("width(QChar) const")]
		public double Width(char arg1) {
			return ProxyQFontMetricsF().Width(arg1);
		}
		[SmokeMethod("boundingRect(const QString&) const")]
		public QRectF BoundingRect(string arg1) {
			return ProxyQFontMetricsF().BoundingRect(arg1);
		}
		[SmokeMethod("boundingRect(QChar) const")]
		public QRectF BoundingRect(char arg1) {
			return ProxyQFontMetricsF().BoundingRect(arg1);
		}
		[SmokeMethod("boundingRect(const QRectF&, int, const QString&, int, int*) const")]
		public QRectF BoundingRect(QRectF r, int flags, string arg3, int tabstops, out int tabarray) {
			return ProxyQFontMetricsF().BoundingRect(r,flags,arg3,tabstops,out tabarray);
		}
		[SmokeMethod("boundingRect(const QRectF&, int, const QString&, int) const")]
		public QRectF BoundingRect(QRectF r, int flags, string arg3, int tabstops) {
			return ProxyQFontMetricsF().BoundingRect(r,flags,arg3,tabstops);
		}
		[SmokeMethod("boundingRect(const QRectF&, int, const QString&) const")]
		public QRectF BoundingRect(QRectF r, int flags, string arg3) {
			return ProxyQFontMetricsF().BoundingRect(r,flags,arg3);
		}
		[SmokeMethod("size(int, const QString&, int, int*) const")]
		public QSizeF Size(int flags, string str, int tabstops, out int tabarray) {
			return ProxyQFontMetricsF().Size(flags,str,tabstops,out tabarray);
		}
		[SmokeMethod("size(int, const QString&, int) const")]
		public QSizeF Size(int flags, string str, int tabstops) {
			return ProxyQFontMetricsF().Size(flags,str,tabstops);
		}
		[SmokeMethod("size(int, const QString&) const")]
		public QSizeF Size(int flags, string str) {
			return ProxyQFontMetricsF().Size(flags,str);
		}
		[SmokeMethod("elidedText(const QString&, Qt::TextElideMode, qreal, int) const")]
		public string ElidedText(string text, Qt.TextElideMode mode, double width, int flags) {
			return ProxyQFontMetricsF().ElidedText(text,mode,width,flags);
		}
		[SmokeMethod("elidedText(const QString&, Qt::TextElideMode, qreal) const")]
		public string ElidedText(string text, Qt.TextElideMode mode, double width) {
			return ProxyQFontMetricsF().ElidedText(text,mode,width);
		}
		[SmokeMethod("underlinePos() const")]
		public double UnderlinePos() {
			return ProxyQFontMetricsF().UnderlinePos();
		}
		[SmokeMethod("overlinePos() const")]
		public double OverlinePos() {
			return ProxyQFontMetricsF().OverlinePos();
		}
		[SmokeMethod("strikeOutPos() const")]
		public double StrikeOutPos() {
			return ProxyQFontMetricsF().StrikeOutPos();
		}
		[SmokeMethod("lineWidth() const")]
		public double LineWidth() {
			return ProxyQFontMetricsF().LineWidth();
		}
		[SmokeMethod("operator==(const QFontMetricsF&)")]
		public static bool operator==(QFontMetricsF lhs, QFontMetricsF other) {
			return StaticQFontMetricsF().op_equals(lhs,other);
		}
		public static bool operator!=(QFontMetricsF lhs, QFontMetricsF other) {
			return !StaticQFontMetricsF().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QFontMetricsF)) { return false; }
			return this == (QFontMetricsF) o;
		}
		public override int GetHashCode() {
			return ProxyQFontMetricsF().GetHashCode();
		}
		~QFontMetricsF() {
			DisposeQFontMetricsF();
		}
		public void Dispose() {
			DisposeQFontMetricsF();
		}
		[SmokeMethod("~QFontMetricsF()")]
		private void DisposeQFontMetricsF() {
			ProxyQFontMetricsF().DisposeQFontMetricsF();
		}
	}
}
