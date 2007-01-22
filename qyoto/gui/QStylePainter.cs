//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QStylePainter")]
	public class QStylePainter : QPainter, IDisposable {
 		protected QStylePainter(Type dummy) : base((Type) null) {}
		interface IQStylePainterProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStylePainter), this);
			_interceptor = (QStylePainter) realProxy.GetTransparentProxy();
		}
		private QStylePainter ProxyQStylePainter() {
			return (QStylePainter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStylePainter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStylePainterProxy), null);
			_staticInterceptor = (IQStylePainterProxy) realProxy.GetTransparentProxy();
		}
		private static IQStylePainterProxy StaticQStylePainter() {
			return (IQStylePainterProxy) _staticInterceptor;
		}

		public QStylePainter() : this((Type) null) {
			CreateProxy();
			NewQStylePainter();
		}
		[SmokeMethod("QStylePainter()")]
		private void NewQStylePainter() {
			ProxyQStylePainter().NewQStylePainter();
		}
		public QStylePainter(QWidget w) : this((Type) null) {
			CreateProxy();
			NewQStylePainter(w);
		}
		[SmokeMethod("QStylePainter(QWidget*)")]
		private void NewQStylePainter(QWidget w) {
			ProxyQStylePainter().NewQStylePainter(w);
		}
		public QStylePainter(IQPaintDevice pd, QWidget w) : this((Type) null) {
			CreateProxy();
			NewQStylePainter(pd,w);
		}
		[SmokeMethod("QStylePainter(QPaintDevice*, QWidget*)")]
		private void NewQStylePainter(IQPaintDevice pd, QWidget w) {
			ProxyQStylePainter().NewQStylePainter(pd,w);
		}
		[SmokeMethod("begin(QWidget*)")]
		public new bool Begin(QWidget w) {
			return ProxyQStylePainter().Begin(w);
		}
		[SmokeMethod("begin(QPaintDevice*, QWidget*)")]
		public new bool Begin(IQPaintDevice pd, QWidget w) {
			return ProxyQStylePainter().Begin(pd,w);
		}
		[SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, const QStyleOption&)")]
		public void DrawPrimitive(QStyle.PrimitiveElement pe, QStyleOption opt) {
			ProxyQStylePainter().DrawPrimitive(pe,opt);
		}
		[SmokeMethod("drawControl(QStyle::ControlElement, const QStyleOption&)")]
		public void DrawControl(QStyle.ControlElement ce, QStyleOption opt) {
			ProxyQStylePainter().DrawControl(ce,opt);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex&)")]
		public void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt) {
			ProxyQStylePainter().DrawComplexControl(cc,opt);
		}
		[SmokeMethod("drawItemText(const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole)")]
		public void DrawItemText(QRect r, int flags, QPalette pal, bool enabled, string text, QPalette.ColorRole textRole) {
			ProxyQStylePainter().DrawItemText(r,flags,pal,enabled,text,textRole);
		}
		[SmokeMethod("drawItemText(const QRect&, int, const QPalette&, bool, const QString&)")]
		public void DrawItemText(QRect r, int flags, QPalette pal, bool enabled, string text) {
			ProxyQStylePainter().DrawItemText(r,flags,pal,enabled,text);
		}
		[SmokeMethod("drawItemPixmap(const QRect&, int, const QPixmap&)")]
		public void DrawItemPixmap(QRect r, int flags, QPixmap pixmap) {
			ProxyQStylePainter().DrawItemPixmap(r,flags,pixmap);
		}
		[SmokeMethod("style() const")]
		public QStyle Style() {
			return ProxyQStylePainter().Style();
		}
		~QStylePainter() {
			DisposeQStylePainter();
		}
		public void Dispose() {
			DisposeQStylePainter();
		}
		[SmokeMethod("~QStylePainter()")]
		private void DisposeQStylePainter() {
			ProxyQStylePainter().DisposeQStylePainter();
		}
	}
}