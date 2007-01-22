//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQDateTimeEditSignals"></see> for signals emitted by QDateTimeEdit
	[SmokeClass("QDateTimeEdit")]
	public class QDateTimeEdit : QAbstractSpinBox, IDisposable {
 		protected QDateTimeEdit(Type dummy) : base((Type) null) {}
		interface IQDateTimeEditProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDateTimeEdit), this);
			_interceptor = (QDateTimeEdit) realProxy.GetTransparentProxy();
		}
		private QDateTimeEdit ProxyQDateTimeEdit() {
			return (QDateTimeEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDateTimeEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateTimeEditProxy), null);
			_staticInterceptor = (IQDateTimeEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateTimeEditProxy StaticQDateTimeEdit() {
			return (IQDateTimeEditProxy) _staticInterceptor;
		}

		public enum Section {
			NoSection = 0x0000,
			AmPmSection = 0x0001,
			MSecSection = 0x0002,
			SecondSection = 0x0004,
			MinuteSection = 0x0008,
			HourSection = 0x0010,
			DaySection = 0x0100,
			MonthSection = 0x0200,
			YearSection = 0x0400,
			TimeSections_Mask = AmPmSection|MSecSection|SecondSection|MinuteSection|HourSection,
			DateSections_Mask = DaySection|MonthSection|YearSection,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDateTimeEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(parent);
		}
		[SmokeMethod("QDateTimeEdit(QWidget*)")]
		private void NewQDateTimeEdit(QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(parent);
		}
		public QDateTimeEdit() : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit();
		}
		[SmokeMethod("QDateTimeEdit()")]
		private void NewQDateTimeEdit() {
			ProxyQDateTimeEdit().NewQDateTimeEdit();
		}
		public QDateTimeEdit(QDateTime dt, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(dt,parent);
		}
		[SmokeMethod("QDateTimeEdit(const QDateTime&, QWidget*)")]
		private void NewQDateTimeEdit(QDateTime dt, QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(dt,parent);
		}
		public QDateTimeEdit(QDateTime dt) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(dt);
		}
		[SmokeMethod("QDateTimeEdit(const QDateTime&)")]
		private void NewQDateTimeEdit(QDateTime dt) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(dt);
		}
		public QDateTimeEdit(QDate d, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(d,parent);
		}
		[SmokeMethod("QDateTimeEdit(const QDate&, QWidget*)")]
		private void NewQDateTimeEdit(QDate d, QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(d,parent);
		}
		public QDateTimeEdit(QDate d) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(d);
		}
		[SmokeMethod("QDateTimeEdit(const QDate&)")]
		private void NewQDateTimeEdit(QDate d) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(d);
		}
		public QDateTimeEdit(QTime t, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(t,parent);
		}
		[SmokeMethod("QDateTimeEdit(const QTime&, QWidget*)")]
		private void NewQDateTimeEdit(QTime t, QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(t,parent);
		}
		public QDateTimeEdit(QTime t) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(t);
		}
		[SmokeMethod("QDateTimeEdit(const QTime&)")]
		private void NewQDateTimeEdit(QTime t) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(t);
		}
		[SmokeMethod("dateTime() const")]
		public QDateTime DateTime() {
			return ProxyQDateTimeEdit().DateTime();
		}
		[SmokeMethod("date() const")]
		public QDate Date() {
			return ProxyQDateTimeEdit().Date();
		}
		[SmokeMethod("time() const")]
		public QTime Time() {
			return ProxyQDateTimeEdit().Time();
		}
		[SmokeMethod("minimumDate() const")]
		public QDate MinimumDate() {
			return ProxyQDateTimeEdit().MinimumDate();
		}
		[SmokeMethod("setMinimumDate(const QDate&)")]
		public void SetMinimumDate(QDate min) {
			ProxyQDateTimeEdit().SetMinimumDate(min);
		}
		[SmokeMethod("clearMinimumDate()")]
		public void ClearMinimumDate() {
			ProxyQDateTimeEdit().ClearMinimumDate();
		}
		[SmokeMethod("maximumDate() const")]
		public QDate MaximumDate() {
			return ProxyQDateTimeEdit().MaximumDate();
		}
		[SmokeMethod("setMaximumDate(const QDate&)")]
		public void SetMaximumDate(QDate max) {
			ProxyQDateTimeEdit().SetMaximumDate(max);
		}
		[SmokeMethod("clearMaximumDate()")]
		public void ClearMaximumDate() {
			ProxyQDateTimeEdit().ClearMaximumDate();
		}
		[SmokeMethod("setDateRange(const QDate&, const QDate&)")]
		public void SetDateRange(QDate min, QDate max) {
			ProxyQDateTimeEdit().SetDateRange(min,max);
		}
		[SmokeMethod("minimumTime() const")]
		public QTime MinimumTime() {
			return ProxyQDateTimeEdit().MinimumTime();
		}
		[SmokeMethod("setMinimumTime(const QTime&)")]
		public void SetMinimumTime(QTime min) {
			ProxyQDateTimeEdit().SetMinimumTime(min);
		}
		[SmokeMethod("clearMinimumTime()")]
		public void ClearMinimumTime() {
			ProxyQDateTimeEdit().ClearMinimumTime();
		}
		[SmokeMethod("maximumTime() const")]
		public QTime MaximumTime() {
			return ProxyQDateTimeEdit().MaximumTime();
		}
		[SmokeMethod("setMaximumTime(const QTime&)")]
		public void SetMaximumTime(QTime max) {
			ProxyQDateTimeEdit().SetMaximumTime(max);
		}
		[SmokeMethod("clearMaximumTime()")]
		public void ClearMaximumTime() {
			ProxyQDateTimeEdit().ClearMaximumTime();
		}
		[SmokeMethod("setTimeRange(const QTime&, const QTime&)")]
		public void SetTimeRange(QTime min, QTime max) {
			ProxyQDateTimeEdit().SetTimeRange(min,max);
		}
		[SmokeMethod("displayedSections() const")]
		public int DisplayedSections() {
			return ProxyQDateTimeEdit().DisplayedSections();
		}
		[SmokeMethod("currentSection() const")]
		public QDateTimeEdit.Section CurrentSection() {
			return ProxyQDateTimeEdit().CurrentSection();
		}
		[SmokeMethod("setCurrentSection(QDateTimeEdit::Section)")]
		public void SetCurrentSection(QDateTimeEdit.Section section) {
			ProxyQDateTimeEdit().SetCurrentSection(section);
		}
		[SmokeMethod("setSelectedSection(QDateTimeEdit::Section)")]
		public void SetSelectedSection(QDateTimeEdit.Section section) {
			ProxyQDateTimeEdit().SetSelectedSection(section);
		}
		[SmokeMethod("sectionText(QDateTimeEdit::Section) const")]
		public string SectionText(QDateTimeEdit.Section section) {
			return ProxyQDateTimeEdit().SectionText(section);
		}
		[SmokeMethod("displayFormat() const")]
		public string DisplayFormat() {
			return ProxyQDateTimeEdit().DisplayFormat();
		}
		[SmokeMethod("setDisplayFormat(const QString&)")]
		public void SetDisplayFormat(string format) {
			ProxyQDateTimeEdit().SetDisplayFormat(format);
		}
		[SmokeMethod("calendarPopup() const")]
		public bool CalendarPopup() {
			return ProxyQDateTimeEdit().CalendarPopup();
		}
		[SmokeMethod("setCalendarPopup(bool)")]
		public void SetCalendarPopup(bool enable) {
			ProxyQDateTimeEdit().SetCalendarPopup(enable);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQDateTimeEdit().SizeHint();
		}
		[SmokeMethod("clear()")]
		public new virtual void Clear() {
			ProxyQDateTimeEdit().Clear();
		}
		[SmokeMethod("stepBy(int)")]
		public new virtual void StepBy(int steps) {
			ProxyQDateTimeEdit().StepBy(steps);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQDateTimeEdit().Event(arg1);
		}
		[SmokeMethod("setDateTime(const QDateTime&)")]
		public void SetDateTime(QDateTime dateTime) {
			ProxyQDateTimeEdit().SetDateTime(dateTime);
		}
		[SmokeMethod("setDate(const QDate&)")]
		public void SetDate(QDate date) {
			ProxyQDateTimeEdit().SetDate(date);
		}
		[SmokeMethod("setTime(const QTime&)")]
		public void SetTime(QTime time) {
			ProxyQDateTimeEdit().SetTime(time);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDateTimeEdit().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDateTimeEdit().Tr(s);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new virtual void KeyPressEvent(QKeyEvent arg1) {
			ProxyQDateTimeEdit().KeyPressEvent(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new virtual void WheelEvent(QWheelEvent arg1) {
			ProxyQDateTimeEdit().WheelEvent(arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected new virtual void FocusInEvent(QFocusEvent arg1) {
			ProxyQDateTimeEdit().FocusInEvent(arg1);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected new virtual bool FocusNextPrevChild(bool next) {
			return ProxyQDateTimeEdit().FocusNextPrevChild(next);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		protected new virtual int Validate(StringBuilder input, out int pos) {
			return ProxyQDateTimeEdit().Validate(input,out pos);
		}
		[SmokeMethod("fixup(QString&) const")]
		protected new virtual void Fixup(StringBuilder input) {
			ProxyQDateTimeEdit().Fixup(input);
		}
		[SmokeMethod("dateTimeFromText(const QString&) const")]
		protected virtual QDateTime DateTimeFromText(string text) {
			return ProxyQDateTimeEdit().DateTimeFromText(text);
		}
		[SmokeMethod("textFromDateTime(const QDateTime&) const")]
		protected virtual string TextFromDateTime(QDateTime dt) {
			return ProxyQDateTimeEdit().TextFromDateTime(dt);
		}
		[SmokeMethod("stepEnabled() const")]
		protected new virtual int StepEnabled() {
			return ProxyQDateTimeEdit().StepEnabled();
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new virtual void MousePressEvent(QMouseEvent arg1) {
			ProxyQDateTimeEdit().MousePressEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new virtual void PaintEvent(QPaintEvent arg1) {
			ProxyQDateTimeEdit().PaintEvent(arg1);
		}
		~QDateTimeEdit() {
			DisposeQDateTimeEdit();
		}
		public new void Dispose() {
			DisposeQDateTimeEdit();
		}
		[SmokeMethod("~QDateTimeEdit()")]
		private void DisposeQDateTimeEdit() {
			ProxyQDateTimeEdit().DisposeQDateTimeEdit();
		}
		protected new IQDateTimeEditSignals Emit() {
			return (IQDateTimeEditSignals) Q_EMIT;
		}
	}

	public interface IQDateTimeEditSignals : IQAbstractSpinBoxSignals {
		[Q_SIGNAL("void dateTimeChanged(const QDateTime&)")]
		void DateTimeChanged(QDateTime date);
		[Q_SIGNAL("void timeChanged(const QTime&)")]
		void TimeChanged(QTime date);
		[Q_SIGNAL("void dateChanged(const QDate&)")]
		void DateChanged(QDate date);
	}
}