//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextFrameFormat")]
	public class QTextFrameFormat : QTextFormat, IDisposable {
 		protected QTextFrameFormat(Type dummy) : base((Type) null) {}
		interface IQTextFrameFormatProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextFrameFormat), this);
			_interceptor = (QTextFrameFormat) realProxy.GetTransparentProxy();
		}
		private QTextFrameFormat ProxyQTextFrameFormat() {
			return (QTextFrameFormat) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextFrameFormat() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextFrameFormatProxy), null);
			_staticInterceptor = (IQTextFrameFormatProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextFrameFormatProxy StaticQTextFrameFormat() {
			return (IQTextFrameFormatProxy) _staticInterceptor;
		}

		public enum Position {
			InFlow = 0,
			FloatLeft = 1,
			FloatRight = 2,
		}
		public QTextFrameFormat() : this((Type) null) {
			CreateProxy();
			NewQTextFrameFormat();
		}
		[SmokeMethod("QTextFrameFormat", "()")]
		private void NewQTextFrameFormat() {
			ProxyQTextFrameFormat().NewQTextFrameFormat();
		}
		[SmokeMethod("isValid", "() const")]
		public new bool IsValid() {
			return ProxyQTextFrameFormat().IsValid();
		}
		[SmokeMethod("setPosition$", "(QTextFrameFormat::Position)")]
		public void SetPosition(QTextFrameFormat.Position f) {
			ProxyQTextFrameFormat().SetPosition(f);
		}
		[SmokeMethod("position", "() const")]
		public QTextFrameFormat.Position position() {
			return ProxyQTextFrameFormat().position();
		}
		[SmokeMethod("setBorder$", "(qreal)")]
		public void SetBorder(double border) {
			ProxyQTextFrameFormat().SetBorder(border);
		}
		[SmokeMethod("border", "() const")]
		public double Border() {
			return ProxyQTextFrameFormat().Border();
		}
		[SmokeMethod("setMargin$", "(qreal)")]
		public void SetMargin(double margin) {
			ProxyQTextFrameFormat().SetMargin(margin);
		}
		[SmokeMethod("margin", "() const")]
		public double Margin() {
			return ProxyQTextFrameFormat().Margin();
		}
		[SmokeMethod("setPadding$", "(qreal)")]
		public void SetPadding(double padding) {
			ProxyQTextFrameFormat().SetPadding(padding);
		}
		[SmokeMethod("padding", "() const")]
		public double Padding() {
			return ProxyQTextFrameFormat().Padding();
		}
		[SmokeMethod("setWidth$", "(qreal)")]
		public void SetWidth(double width) {
			ProxyQTextFrameFormat().SetWidth(width);
		}
		[SmokeMethod("setWidth#", "(const QTextLength&)")]
		public void SetWidth(QTextLength length) {
			ProxyQTextFrameFormat().SetWidth(length);
		}
		[SmokeMethod("width", "() const")]
		public QTextLength Width() {
			return ProxyQTextFrameFormat().Width();
		}
		[SmokeMethod("setHeight$", "(qreal)")]
		public void SetHeight(double height) {
			ProxyQTextFrameFormat().SetHeight(height);
		}
		[SmokeMethod("setHeight#", "(const QTextLength&)")]
		public void SetHeight(QTextLength height) {
			ProxyQTextFrameFormat().SetHeight(height);
		}
		[SmokeMethod("height", "() const")]
		public QTextLength Height() {
			return ProxyQTextFrameFormat().Height();
		}
		[SmokeMethod("setPageBreakPolicy$", "(PageBreakFlags)")]
		public void SetPageBreakPolicy(int flags) {
			ProxyQTextFrameFormat().SetPageBreakPolicy(flags);
		}
		[SmokeMethod("pageBreakPolicy", "() const")]
		public int PageBreakPolicy() {
			return ProxyQTextFrameFormat().PageBreakPolicy();
		}
		~QTextFrameFormat() {
			DisposeQTextFrameFormat();
		}
		public void Dispose() {
			DisposeQTextFrameFormat();
		}
		[SmokeMethod("~QTextFrameFormat", "()")]
		private void DisposeQTextFrameFormat() {
			ProxyQTextFrameFormat().DisposeQTextFrameFormat();
		}
	}
}
