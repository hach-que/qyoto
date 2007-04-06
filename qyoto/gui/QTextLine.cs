//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextLine")]
	public class QTextLine : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QTextLine(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextLine), this);
		}
		public enum Edge {
			Leading = 0,
			Trailing = 1,
		}
		public enum CursorPosition {
			CursorBetweenCharacters = 0,
			CursorOnCharacter = 1,
		}
		// void draw(QPainter* arg1,const QPointF& arg2,const QTextLayout::FormatRange* arg3); >>>> NOT CONVERTED
		public QTextLine() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLine", "QTextLine()", typeof(void));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public QRectF Rect() {
			return (QRectF) interceptor.Invoke("rect", "rect() const", typeof(QRectF));
		}
		public double X() {
			return (double) interceptor.Invoke("x", "x() const", typeof(double));
		}
		public double Y() {
			return (double) interceptor.Invoke("y", "y() const", typeof(double));
		}
		public double Width() {
			return (double) interceptor.Invoke("width", "width() const", typeof(double));
		}
		public double Ascent() {
			return (double) interceptor.Invoke("ascent", "ascent() const", typeof(double));
		}
		public double Descent() {
			return (double) interceptor.Invoke("descent", "descent() const", typeof(double));
		}
		public double Height() {
			return (double) interceptor.Invoke("height", "height() const", typeof(double));
		}
		public double NaturalTextWidth() {
			return (double) interceptor.Invoke("naturalTextWidth", "naturalTextWidth() const", typeof(double));
		}
		public QRectF NaturalTextRect() {
			return (QRectF) interceptor.Invoke("naturalTextRect", "naturalTextRect() const", typeof(QRectF));
		}
		public double CursorToX(int cursorPos, QTextLine.Edge edge) {
			return (double) interceptor.Invoke("cursorToX$$", "cursorToX(int*, QTextLine::Edge) const", typeof(double), typeof(int), cursorPos, typeof(QTextLine.Edge), edge);
		}
		public double CursorToX(int cursorPos) {
			return (double) interceptor.Invoke("cursorToX$", "cursorToX(int*) const", typeof(double), typeof(int), cursorPos);
		}
		public int XToCursor(double x, QTextLine.CursorPosition arg2) {
			return (int) interceptor.Invoke("xToCursor$$", "xToCursor(qreal, QTextLine::CursorPosition) const", typeof(int), typeof(double), x, typeof(QTextLine.CursorPosition), arg2);
		}
		public int XToCursor(double x) {
			return (int) interceptor.Invoke("xToCursor$", "xToCursor(qreal) const", typeof(int), typeof(double), x);
		}
		public void SetLineWidth(double width) {
			interceptor.Invoke("setLineWidth$", "setLineWidth(qreal)", typeof(void), typeof(double), width);
		}
		public void SetNumColumns(int columns) {
			interceptor.Invoke("setNumColumns$", "setNumColumns(int)", typeof(void), typeof(int), columns);
		}
		public void SetNumColumns(int columns, double alignmentWidth) {
			interceptor.Invoke("setNumColumns$$", "setNumColumns(int, qreal)", typeof(void), typeof(int), columns, typeof(double), alignmentWidth);
		}
		public void SetPosition(QPointF pos) {
			interceptor.Invoke("setPosition#", "setPosition(const QPointF&)", typeof(void), typeof(QPointF), pos);
		}
		public QPointF Position() {
			return (QPointF) interceptor.Invoke("position", "position() const", typeof(QPointF));
		}
		public int TextStart() {
			return (int) interceptor.Invoke("textStart", "textStart() const", typeof(int));
		}
		public int TextLength() {
			return (int) interceptor.Invoke("textLength", "textLength() const", typeof(int));
		}
		public int LineNumber() {
			return (int) interceptor.Invoke("lineNumber", "lineNumber() const", typeof(int));
		}
		public void Draw(QPainter p, QPointF point) {
			interceptor.Invoke("draw##", "draw(QPainter*, const QPointF&) const", typeof(void), typeof(QPainter), p, typeof(QPointF), point);
		}
		~QTextLine() {
			interceptor.Invoke("~QTextLine", "~QTextLine()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QTextLine", "~QTextLine()", typeof(void));
		}
	}
}
