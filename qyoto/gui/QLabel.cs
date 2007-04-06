//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	///<remarks> See <see cref="IQLabelSignals"></see> for signals emitted by QLabel
	///</remarks>

	[SmokeClass("QLabel")]
	public class QLabel : QFrame, IDisposable {
 		protected QLabel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QLabel), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QLabel() {
			staticInterceptor = new SmokeInvocation(typeof(QLabel), null);
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
			set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("Qt::TextFormat", "textFormat")]
		public new Qt.TextFormat TextFormat {
			get { return (Qt.TextFormat) interceptor.Invoke("textFormat", "textFormat()", typeof(Qt.TextFormat)); }
			set { interceptor.Invoke("setTextFormat$", "setTextFormat(Qt::TextFormat)", typeof(void), typeof(Qt.TextFormat), value); }
		}
		[Q_PROPERTY("QPixmap", "pixmap")]
		public QPixmap Pixmap {
			get { return (QPixmap) interceptor.Invoke("pixmap", "pixmap()", typeof(QPixmap)); }
			set { interceptor.Invoke("setPixmap#", "setPixmap(QPixmap)", typeof(void), typeof(QPixmap), value); }
		}
		[Q_PROPERTY("bool", "scaledContents")]
		public bool ScaledContents {
			get { return (bool) interceptor.Invoke("hasScaledContents", "hasScaledContents()", typeof(bool)); }
			set { interceptor.Invoke("setScaledContents$", "setScaledContents(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public int Alignment {
			get { return (int) interceptor.Invoke("alignment", "alignment()", typeof(int)); }
			set { interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "wordWrap")]
		public bool WordWrap {
			get { return (bool) interceptor.Invoke("wordWrap", "wordWrap()", typeof(bool)); }
			set { interceptor.Invoke("setWordWrap$", "setWordWrap(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "margin")]
		public int Margin {
			get { return (int) interceptor.Invoke("margin", "margin()", typeof(int)); }
			set { interceptor.Invoke("setMargin$", "setMargin(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "indent")]
		public int Indent {
			get { return (int) interceptor.Invoke("indent", "indent()", typeof(int)); }
			set { interceptor.Invoke("setIndent$", "setIndent(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "openExternalLinks")]
		public bool OpenExternalLinks {
			get { return (bool) interceptor.Invoke("openExternalLinks", "openExternalLinks()", typeof(bool)); }
			set { interceptor.Invoke("setOpenExternalLinks$", "setOpenExternalLinks(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("Qt::TextInteractionFlags", "textInteractionFlags")]
		public int TextInteractionFlags {
			get { return (int) interceptor.Invoke("textInteractionFlags", "textInteractionFlags()", typeof(int)); }
			set { interceptor.Invoke("setTextInteractionFlags$", "setTextInteractionFlags(Qt::TextInteractionFlags)", typeof(void), typeof(int), value); }
		}
		public QLabel(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLabel#$", "QLabel(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(int), f);
		}
		public QLabel(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLabel#", "QLabel(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QLabel() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLabel", "QLabel()", typeof(void));
		}
		public QLabel(string text, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLabel$#$", "QLabel(const QString&, QWidget*, Qt::WindowFlags)", typeof(void), typeof(string), text, typeof(QWidget), parent, typeof(int), f);
		}
		public QLabel(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLabel$#", "QLabel(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
		}
		public QLabel(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLabel$", "QLabel(const QString&)", typeof(void), typeof(string), text);
		}
		public QPicture Picture() {
			return (QPicture) interceptor.Invoke("picture", "picture() const", typeof(QPicture));
		}
		public QMovie Movie() {
			return (QMovie) interceptor.Invoke("movie", "movie() const", typeof(QMovie));
		}
		public bool HasScaledContents() {
			return (bool) interceptor.Invoke("hasScaledContents", "hasScaledContents() const", typeof(bool));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		public void SetBuddy(QWidget arg1) {
			interceptor.Invoke("setBuddy#", "setBuddy(QWidget*)", typeof(void), typeof(QWidget), arg1);
		}
		public QWidget Buddy() {
			return (QWidget) interceptor.Invoke("buddy", "buddy() const", typeof(QWidget));
		}
		[SmokeMethod("heightForWidth(int) const")]
		public override int HeightForWidth(int arg1) {
			return (int) interceptor.Invoke("heightForWidth$", "heightForWidth(int) const", typeof(int), typeof(int), arg1);
		}
		[Q_SLOT("void setPicture(const QPicture&)")]
		public void SetPicture(QPicture arg1) {
			interceptor.Invoke("setPicture#", "setPicture(const QPicture&)", typeof(void), typeof(QPicture), arg1);
		}
		[Q_SLOT("void setMovie(QMovie*)")]
		public void SetMovie(QMovie movie) {
			interceptor.Invoke("setMovie#", "setMovie(QMovie*)", typeof(void), typeof(QMovie), movie);
		}
		[Q_SLOT("void setNum(int)")]
		public void SetNum(int arg1) {
			interceptor.Invoke("setNum$", "setNum(int)", typeof(void), typeof(int), arg1);
		}
		[Q_SLOT("void setNum(double)")]
		public void SetNum(double arg1) {
			interceptor.Invoke("setNum$", "setNum(double)", typeof(void), typeof(double), arg1);
		}
		[Q_SLOT("void clear()")]
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent ev) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), ev);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent ev) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), ev);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent ev) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), ev);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent ev) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), ev);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent ev) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), ev);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent ev) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), ev);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent ev) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), ev);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		~QLabel() {
			interceptor.Invoke("~QLabel", "~QLabel()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QLabel", "~QLabel()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQLabelSignals Emit {
			get { return (IQLabelSignals) Q_EMIT; }
		}
	}

	public interface IQLabelSignals : IQFrameSignals {
		[Q_SIGNAL("void linkActivated(const QString&)")]
		void LinkActivated(string link);
		[Q_SIGNAL("void linkHovered(const QString&)")]
		void LinkHovered(string link);
	}
}
