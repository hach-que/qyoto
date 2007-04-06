//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextLayout")]
	public class QTextLayout : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QTextLayout(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextLayout), this);
		}
		public enum CursorMode {
			SkipCharacters = 0,
			SkipWords = 1,
		}
		// void setAdditionalFormats(const QList<QTextLayout::FormatRange>& arg1); >>>> NOT CONVERTED
		// QList<QTextLayout::FormatRange> additionalFormats(); >>>> NOT CONVERTED
		// void draw(QPainter* arg1,const QPointF& arg2,const QVector<QTextLayout::FormatRange>& arg3,const QRectF& arg4); >>>> NOT CONVERTED
		// void draw(QPainter* arg1,const QPointF& arg2,const QVector<QTextLayout::FormatRange>& arg3); >>>> NOT CONVERTED
		// QTextEngine* engine(); >>>> NOT CONVERTED
		public QTextLayout() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLayout", "QTextLayout()", typeof(void));
		}
		public QTextLayout(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLayout$", "QTextLayout(const QString&)", typeof(void), typeof(string), text);
		}
		public QTextLayout(string text, QFont font, IQPaintDevice paintdevice) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLayout$##", "QTextLayout(const QString&, const QFont&, QPaintDevice*)", typeof(void), typeof(string), text, typeof(QFont), font, typeof(IQPaintDevice), paintdevice);
		}
		public QTextLayout(string text, QFont font) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLayout$#", "QTextLayout(const QString&, const QFont&)", typeof(void), typeof(string), text, typeof(QFont), font);
		}
		public QTextLayout(QTextBlock b) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLayout#", "QTextLayout(const QTextBlock&)", typeof(void), typeof(QTextBlock), b);
		}
		public void SetFont(QFont f) {
			interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), f);
		}
		public QFont Font() {
			return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
		}
		public void SetText(string arg1) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public void SetTextOption(QTextOption option) {
			interceptor.Invoke("setTextOption#", "setTextOption(const QTextOption&)", typeof(void), typeof(QTextOption), option);
		}
		public QTextOption TextOption() {
			return (QTextOption) interceptor.Invoke("textOption", "textOption() const", typeof(QTextOption));
		}
		public void SetPreeditArea(int position, string text) {
			interceptor.Invoke("setPreeditArea$$", "setPreeditArea(int, const QString&)", typeof(void), typeof(int), position, typeof(string), text);
		}
		public int PreeditAreaPosition() {
			return (int) interceptor.Invoke("preeditAreaPosition", "preeditAreaPosition() const", typeof(int));
		}
		public string PreeditAreaText() {
			return (string) interceptor.Invoke("preeditAreaText", "preeditAreaText() const", typeof(string));
		}
		public void ClearAdditionalFormats() {
			interceptor.Invoke("clearAdditionalFormats", "clearAdditionalFormats()", typeof(void));
		}
		public void SetCacheEnabled(bool enable) {
			interceptor.Invoke("setCacheEnabled$", "setCacheEnabled(bool)", typeof(void), typeof(bool), enable);
		}
		public bool CacheEnabled() {
			return (bool) interceptor.Invoke("cacheEnabled", "cacheEnabled() const", typeof(bool));
		}
		public void BeginLayout() {
			interceptor.Invoke("beginLayout", "beginLayout()", typeof(void));
		}
		public void EndLayout() {
			interceptor.Invoke("endLayout", "endLayout()", typeof(void));
		}
		public QTextLine CreateLine() {
			return (QTextLine) interceptor.Invoke("createLine", "createLine()", typeof(QTextLine));
		}
		public int LineCount() {
			return (int) interceptor.Invoke("lineCount", "lineCount() const", typeof(int));
		}
		public QTextLine LineAt(int i) {
			return (QTextLine) interceptor.Invoke("lineAt$", "lineAt(int) const", typeof(QTextLine), typeof(int), i);
		}
		public QTextLine LineForTextPosition(int pos) {
			return (QTextLine) interceptor.Invoke("lineForTextPosition$", "lineForTextPosition(int) const", typeof(QTextLine), typeof(int), pos);
		}
		public bool IsValidCursorPosition(int pos) {
			return (bool) interceptor.Invoke("isValidCursorPosition$", "isValidCursorPosition(int) const", typeof(bool), typeof(int), pos);
		}
		public int NextCursorPosition(int oldPos, QTextLayout.CursorMode mode) {
			return (int) interceptor.Invoke("nextCursorPosition$$", "nextCursorPosition(int, QTextLayout::CursorMode) const", typeof(int), typeof(int), oldPos, typeof(QTextLayout.CursorMode), mode);
		}
		public int NextCursorPosition(int oldPos) {
			return (int) interceptor.Invoke("nextCursorPosition$", "nextCursorPosition(int) const", typeof(int), typeof(int), oldPos);
		}
		public int PreviousCursorPosition(int oldPos, QTextLayout.CursorMode mode) {
			return (int) interceptor.Invoke("previousCursorPosition$$", "previousCursorPosition(int, QTextLayout::CursorMode) const", typeof(int), typeof(int), oldPos, typeof(QTextLayout.CursorMode), mode);
		}
		public int PreviousCursorPosition(int oldPos) {
			return (int) interceptor.Invoke("previousCursorPosition$", "previousCursorPosition(int) const", typeof(int), typeof(int), oldPos);
		}
		public void Draw(QPainter p, QPointF pos) {
			interceptor.Invoke("draw##", "draw(QPainter*, const QPointF&) const", typeof(void), typeof(QPainter), p, typeof(QPointF), pos);
		}
		public void DrawCursor(QPainter p, QPointF pos, int cursorPosition) {
			interceptor.Invoke("drawCursor##$", "drawCursor(QPainter*, const QPointF&, int) const", typeof(void), typeof(QPainter), p, typeof(QPointF), pos, typeof(int), cursorPosition);
		}
		public void DrawCursor(QPainter p, QPointF pos, int cursorPosition, int width) {
			interceptor.Invoke("drawCursor##$$", "drawCursor(QPainter*, const QPointF&, int, int) const", typeof(void), typeof(QPainter), p, typeof(QPointF), pos, typeof(int), cursorPosition, typeof(int), width);
		}
		public QPointF Position() {
			return (QPointF) interceptor.Invoke("position", "position() const", typeof(QPointF));
		}
		public void SetPosition(QPointF p) {
			interceptor.Invoke("setPosition#", "setPosition(const QPointF&)", typeof(void), typeof(QPointF), p);
		}
		public QRectF BoundingRect() {
			return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
		}
		public double MinimumWidth() {
			return (double) interceptor.Invoke("minimumWidth", "minimumWidth() const", typeof(double));
		}
		public double MaximumWidth() {
			return (double) interceptor.Invoke("maximumWidth", "maximumWidth() const", typeof(double));
		}
		~QTextLayout() {
			interceptor.Invoke("~QTextLayout", "~QTextLayout()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QTextLayout", "~QTextLayout()", typeof(void));
		}
	}
}
