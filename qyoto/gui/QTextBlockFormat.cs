//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextBlockFormat")]
	public class QTextBlockFormat : QTextFormat, IDisposable {
 		protected QTextBlockFormat(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextBlockFormat), "QTextBlockFormat", this);
		}
		public QTextBlockFormat() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextBlockFormat", "QTextBlockFormat()", typeof(void));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public void SetAlignment(int alignment) {
			interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), alignment);
		}
		public int Alignment() {
			return (int) interceptor.Invoke("alignment", "alignment() const", typeof(int));
		}
		public void SetTopMargin(double margin) {
			interceptor.Invoke("setTopMargin$", "setTopMargin(qreal)", typeof(void), typeof(double), margin);
		}
		public double TopMargin() {
			return (double) interceptor.Invoke("topMargin", "topMargin() const", typeof(double));
		}
		public void SetBottomMargin(double margin) {
			interceptor.Invoke("setBottomMargin$", "setBottomMargin(qreal)", typeof(void), typeof(double), margin);
		}
		public double BottomMargin() {
			return (double) interceptor.Invoke("bottomMargin", "bottomMargin() const", typeof(double));
		}
		public void SetLeftMargin(double margin) {
			interceptor.Invoke("setLeftMargin$", "setLeftMargin(qreal)", typeof(void), typeof(double), margin);
		}
		public double LeftMargin() {
			return (double) interceptor.Invoke("leftMargin", "leftMargin() const", typeof(double));
		}
		public void SetRightMargin(double margin) {
			interceptor.Invoke("setRightMargin$", "setRightMargin(qreal)", typeof(void), typeof(double), margin);
		}
		public double RightMargin() {
			return (double) interceptor.Invoke("rightMargin", "rightMargin() const", typeof(double));
		}
		public void SetTextIndent(double margin) {
			interceptor.Invoke("setTextIndent$", "setTextIndent(qreal)", typeof(void), typeof(double), margin);
		}
		public double TextIndent() {
			return (double) interceptor.Invoke("textIndent", "textIndent() const", typeof(double));
		}
		public void SetIndent(int indent) {
			interceptor.Invoke("setIndent$", "setIndent(int)", typeof(void), typeof(int), indent);
		}
		public int Indent() {
			return (int) interceptor.Invoke("indent", "indent() const", typeof(int));
		}
		public void SetNonBreakableLines(bool b) {
			interceptor.Invoke("setNonBreakableLines$", "setNonBreakableLines(bool)", typeof(void), typeof(bool), b);
		}
		public bool NonBreakableLines() {
			return (bool) interceptor.Invoke("nonBreakableLines", "nonBreakableLines() const", typeof(bool));
		}
		public void SetPageBreakPolicy(int flags) {
			interceptor.Invoke("setPageBreakPolicy$", "setPageBreakPolicy(PageBreakFlags)", typeof(void), typeof(int), flags);
		}
		public int PageBreakPolicy() {
			return (int) interceptor.Invoke("pageBreakPolicy", "pageBreakPolicy() const", typeof(int));
		}
		~QTextBlockFormat() {
			interceptor.Invoke("~QTextBlockFormat", "~QTextBlockFormat()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QTextBlockFormat", "~QTextBlockFormat()", typeof(void));
		}
	}
}
