//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStylePainter")]
	public class QStylePainter : QPainter, IDisposable {
 		protected QStylePainter(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStylePainter), this);
			interceptor = (QStylePainter) realProxy.GetTransparentProxy();
		}
		public QStylePainter() : this((Type) null) {
			CreateProxy();
			NewQStylePainter();
		}
		[SmokeMethod("QStylePainter", "()", "")]
		private void NewQStylePainter() {
			((QStylePainter) interceptor).NewQStylePainter();
		}
		public QStylePainter(QWidget w) : this((Type) null) {
			CreateProxy();
			NewQStylePainter(w);
		}
		[SmokeMethod("QStylePainter", "(QWidget*)", "#")]
		private void NewQStylePainter(QWidget w) {
			((QStylePainter) interceptor).NewQStylePainter(w);
		}
		public QStylePainter(IQPaintDevice pd, QWidget w) : this((Type) null) {
			CreateProxy();
			NewQStylePainter(pd,w);
		}
		[SmokeMethod("QStylePainter", "(QPaintDevice*, QWidget*)", "##")]
		private void NewQStylePainter(IQPaintDevice pd, QWidget w) {
			((QStylePainter) interceptor).NewQStylePainter(pd,w);
		}
		[SmokeMethod("begin", "(QWidget*)", "#")]
		public bool Begin(QWidget w) {
			return ((QStylePainter) interceptor).Begin(w);
		}
		[SmokeMethod("begin", "(QPaintDevice*, QWidget*)", "##")]
		public bool Begin(IQPaintDevice pd, QWidget w) {
			return ((QStylePainter) interceptor).Begin(pd,w);
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption&)", "$#")]
		public void DrawPrimitive(QStyle.PrimitiveElement pe, QStyleOption opt) {
			((QStylePainter) interceptor).DrawPrimitive(pe,opt);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption&)", "$#")]
		public void DrawControl(QStyle.ControlElement ce, QStyleOption opt) {
			((QStylePainter) interceptor).DrawControl(ce,opt);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex&)", "$#")]
		public void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt) {
			((QStylePainter) interceptor).DrawComplexControl(cc,opt);
		}
		[SmokeMethod("drawItemText", "(const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole)", "#$#$$$")]
		public void DrawItemText(QRect r, int flags, QPalette pal, bool enabled, string text, QPalette.ColorRole textRole) {
			((QStylePainter) interceptor).DrawItemText(r,flags,pal,enabled,text,textRole);
		}
		[SmokeMethod("drawItemText", "(const QRect&, int, const QPalette&, bool, const QString&)", "#$#$$")]
		public void DrawItemText(QRect r, int flags, QPalette pal, bool enabled, string text) {
			((QStylePainter) interceptor).DrawItemText(r,flags,pal,enabled,text);
		}
		[SmokeMethod("drawItemPixmap", "(const QRect&, int, const QPixmap&)", "#$#")]
		public void DrawItemPixmap(QRect r, int flags, QPixmap pixmap) {
			((QStylePainter) interceptor).DrawItemPixmap(r,flags,pixmap);
		}
		[SmokeMethod("style", "() const", "")]
		public QStyle Style() {
			return ((QStylePainter) interceptor).Style();
		}
		~QStylePainter() {
			DisposeQStylePainter();
		}
		public void Dispose() {
			DisposeQStylePainter();
		}
		[SmokeMethod("~QStylePainter", "()", "")]
		private void DisposeQStylePainter() {
			((QStylePainter) interceptor).DisposeQStylePainter();
		}
	}
}
