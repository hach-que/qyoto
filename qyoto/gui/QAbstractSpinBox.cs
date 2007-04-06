//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	///<remarks> See <see cref="IQAbstractSpinBoxSignals"></see> for signals emitted by QAbstractSpinBox
	///</remarks>

	[SmokeClass("QAbstractSpinBox")]
	public abstract class QAbstractSpinBox : QWidget {
 		protected QAbstractSpinBox(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractSpinBox), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAbstractSpinBox() {
			staticInterceptor = new SmokeInvocation(typeof(QAbstractSpinBox), null);
		}
		public enum StepEnabledFlag {
			StepNone = 0x00,
			StepUpEnabled = 0x01,
			StepDownEnabled = 0x02,
		}
		public enum ButtonSymbols {
			UpDownArrows = 0,
			PlusMinus = 1,
			NoButtons = 2,
		}
		public enum CorrectionMode {
			CorrectToPreviousValue = 0,
			CorrectToNearestValue = 1,
		}
		[Q_PROPERTY("bool", "modified")]
		public bool Modified {
			get { return (bool) interceptor.Invoke("isModified", "isModified()", typeof(bool)); }
			set { interceptor.Invoke("setModified$", "setModified(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "wrapping")]
		public bool Wrapping {
			get { return (bool) interceptor.Invoke("wrapping", "wrapping()", typeof(bool)); }
			set { interceptor.Invoke("setWrapping$", "setWrapping(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "frame")]
		public bool Frame {
			get { return (bool) interceptor.Invoke("hasFrame", "hasFrame()", typeof(bool)); }
			set { interceptor.Invoke("setFrame$", "setFrame(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public int Alignment {
			get { return (int) interceptor.Invoke("alignment", "alignment()", typeof(int)); }
			set { interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "readOnly")]
		public bool ReadOnly {
			get { return (bool) interceptor.Invoke("isReadOnly", "isReadOnly()", typeof(bool)); }
			set { interceptor.Invoke("setReadOnly$", "setReadOnly(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QAbstractSpinBox::ButtonSymbols", "buttonSymbols")]
		public QAbstractSpinBox.ButtonSymbols buttonSymbols {
			get { return (QAbstractSpinBox.ButtonSymbols) interceptor.Invoke("buttonSymbols", "buttonSymbols()", typeof(QAbstractSpinBox.ButtonSymbols)); }
			set { interceptor.Invoke("setButtonSymbols$", "setButtonSymbols(QAbstractSpinBox::ButtonSymbols)", typeof(void), typeof(QAbstractSpinBox.ButtonSymbols), value); }
		}
		[Q_PROPERTY("QString", "specialValueText")]
		public string SpecialValueText {
			get { return (string) interceptor.Invoke("specialValueText", "specialValueText()", typeof(string)); }
			set { interceptor.Invoke("setSpecialValueText$", "setSpecialValueText(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
		}
		[Q_PROPERTY("bool", "accelerated")]
		public bool Accelerated {
			get { return (bool) interceptor.Invoke("isAccelerated", "isAccelerated()", typeof(bool)); }
			set { interceptor.Invoke("setAccelerated$", "setAccelerated(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QAbstractSpinBox::CorrectionMode", "correctionMode")]
		public QAbstractSpinBox.CorrectionMode correctionMode {
			get { return (QAbstractSpinBox.CorrectionMode) interceptor.Invoke("correctionMode", "correctionMode()", typeof(QAbstractSpinBox.CorrectionMode)); }
			set { interceptor.Invoke("setCorrectionMode$", "setCorrectionMode(QAbstractSpinBox::CorrectionMode)", typeof(void), typeof(QAbstractSpinBox.CorrectionMode), value); }
		}
		[Q_PROPERTY("bool", "undoAvailable")]
		public bool UndoAvailable {
			get { return (bool) interceptor.Invoke("isUndoAvailable", "isUndoAvailable()", typeof(bool)); }
		}
		[Q_PROPERTY("bool", "redoAvailable")]
		public bool RedoAvailable {
			get { return (bool) interceptor.Invoke("isRedoAvailable", "isRedoAvailable()", typeof(bool)); }
		}
		[Q_PROPERTY("bool", "acceptableInput")]
		public bool AcceptableInput {
			get { return (bool) interceptor.Invoke("hasAcceptableInput", "hasAcceptableInput()", typeof(bool)); }
		}
		public QAbstractSpinBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractSpinBox#", "QAbstractSpinBox(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QAbstractSpinBox() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractSpinBox", "QAbstractSpinBox()", typeof(void));
		}
		public bool HasAcceptableInput() {
			return (bool) interceptor.Invoke("hasAcceptableInput", "hasAcceptableInput() const", typeof(bool));
		}
		public bool IsReadOnly() {
			return (bool) interceptor.Invoke("isReadOnly", "isReadOnly() const", typeof(bool));
		}
		public bool HasFrame() {
			return (bool) interceptor.Invoke("hasFrame", "hasFrame() const", typeof(bool));
		}
		public bool IsAccelerated() {
			return (bool) interceptor.Invoke("isAccelerated", "isAccelerated() const", typeof(bool));
		}
		public bool IsUndoAvailable() {
			return (bool) interceptor.Invoke("isUndoAvailable", "isUndoAvailable() const", typeof(bool));
		}
		public bool IsRedoAvailable() {
			return (bool) interceptor.Invoke("isRedoAvailable", "isRedoAvailable() const", typeof(bool));
		}
		public bool IsModified() {
			return (bool) interceptor.Invoke("isModified", "isModified() const", typeof(bool));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		public void InterpretText() {
			interceptor.Invoke("interpretText", "interpretText()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		public new virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public virtual int Validate(StringBuilder input, int pos) {
			return (int) interceptor.Invoke("validate$$", "validate(QString&, int&) const", typeof(int), typeof(StringBuilder), input, typeof(int), pos);
		}
		[SmokeMethod("fixup(QString&) const")]
		public virtual void Fixup(StringBuilder input) {
			interceptor.Invoke("fixup$", "fixup(QString&) const", typeof(void), typeof(StringBuilder), input);
		}
		[SmokeMethod("stepBy(int)")]
		public virtual void StepBy(int steps) {
			interceptor.Invoke("stepBy$", "stepBy(int)", typeof(void), typeof(int), steps);
		}
		[Q_SLOT("void stepUp()")]
		public void StepUp() {
			interceptor.Invoke("stepUp", "stepUp()", typeof(void));
		}
		[Q_SLOT("void stepDown()")]
		public void StepDown() {
			interceptor.Invoke("stepDown", "stepDown()", typeof(void));
		}
		[Q_SLOT("void selectAll()")]
		public void SelectAll() {
			interceptor.Invoke("selectAll", "selectAll()", typeof(void));
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[Q_SLOT("void undo()")]
		public void Undo() {
			interceptor.Invoke("undo", "undo()", typeof(void));
		}
		[Q_SLOT("void redo()")]
		public void Redo() {
			interceptor.Invoke("redo", "redo()", typeof(void));
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected override void KeyReleaseEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyReleaseEvent#", "keyReleaseEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent arg1) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("closeEvent(QCloseEvent*)")]
		protected override void CloseEvent(QCloseEvent arg1) {
			interceptor.Invoke("closeEvent#", "closeEvent(QCloseEvent*)", typeof(void), typeof(QCloseEvent), arg1);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected override void HideEvent(QHideEvent arg1) {
			interceptor.Invoke("hideEvent#", "hideEvent(QHideEvent*)", typeof(void), typeof(QHideEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected override void TimerEvent(QTimerEvent arg1) {
			interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		protected void InitStyleOption(QStyleOptionSpinBox option) {
			interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionSpinBox*) const", typeof(void), typeof(QStyleOptionSpinBox), option);
		}
		protected QLineEdit LineEdit() {
			return (QLineEdit) interceptor.Invoke("lineEdit", "lineEdit() const", typeof(QLineEdit));
		}
		protected void SetLineEdit(QLineEdit edit) {
			interceptor.Invoke("setLineEdit#", "setLineEdit(QLineEdit*)", typeof(void), typeof(QLineEdit), edit);
		}
		[SmokeMethod("stepEnabled() const")]
		protected virtual int StepEnabled() {
			return (int) interceptor.Invoke("stepEnabled", "stepEnabled() const", typeof(int));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQAbstractSpinBoxSignals Emit {
			get { return (IQAbstractSpinBoxSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractSpinBoxSignals : IQWidgetSignals {
		[Q_SIGNAL("void editingFinished()")]
		void EditingFinished();
	}
}
