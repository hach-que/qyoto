//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQDateTimeEditSignals"></see> for signals emitted by QDateTimeEdit
	[SmokeClass("QDateTimeEdit")]
	public class QDateTimeEdit : QAbstractSpinBox, IDisposable {
 		protected QDateTimeEdit(Type dummy) : base((Type) null) {}
		[SmokeClass("QDateTimeEdit")]
		interface IQDateTimeEditProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
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
		[Q_PROPERTY("QDateTime", "dateTime")]
		public QDateTime DateTime {
			get { return Property("dateTime").Value<QDateTime>(); }
			set { SetProperty("dateTime", QVariant.FromValue<QDateTime>(value)); }
		}
		[Q_PROPERTY("QDate", "date")]
		public QDate Date {
			get { return Property("date").Value<QDate>(); }
			set { SetProperty("date", QVariant.FromValue<QDate>(value)); }
		}
		[Q_PROPERTY("QTime", "time")]
		public QTime Time {
			get { return Property("time").Value<QTime>(); }
			set { SetProperty("time", QVariant.FromValue<QTime>(value)); }
		}
		[Q_PROPERTY("QDate", "maximumDate")]
		public QDate MaximumDate {
			get { return Property("maximumDate").Value<QDate>(); }
			set { SetProperty("maximumDate", QVariant.FromValue<QDate>(value)); }
		}
		[Q_PROPERTY("QDate", "minimumDate")]
		public QDate MinimumDate {
			get { return Property("minimumDate").Value<QDate>(); }
			set { SetProperty("minimumDate", QVariant.FromValue<QDate>(value)); }
		}
		[Q_PROPERTY("QTime", "maximumTime")]
		public QTime MaximumTime {
			get { return Property("maximumTime").Value<QTime>(); }
			set { SetProperty("maximumTime", QVariant.FromValue<QTime>(value)); }
		}
		[Q_PROPERTY("QTime", "minimumTime")]
		public QTime MinimumTime {
			get { return Property("minimumTime").Value<QTime>(); }
			set { SetProperty("minimumTime", QVariant.FromValue<QTime>(value)); }
		}
		[Q_PROPERTY("QDateTimeEdit::Section", "currentSection")]
		public QDateTimeEdit.Section CurrentSection {
			get { return Property("currentSection").Value<QDateTimeEdit.Section>(); }
			set { SetProperty("currentSection", QVariant.FromValue<QDateTimeEdit.Section>(value)); }
		}
		[Q_PROPERTY("Sections", "displayedSections")]
		public int DisplayedSections {
			get { return Property("displayedSections").Value<int>(); }
		}
		[Q_PROPERTY("QString", "displayFormat")]
		public string DisplayFormat {
			get { return Property("displayFormat").Value<string>(); }
			set { SetProperty("displayFormat", QVariant.FromValue<string>(value)); }
		}
		[Q_PROPERTY("bool", "calendarPopup")]
		public bool CalendarPopup {
			get { return Property("calendarPopup").Value<bool>(); }
			set { SetProperty("calendarPopup", QVariant.FromValue<bool>(value)); }
		}
		public QDateTimeEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(parent);
		}
		[SmokeMethod("QDateTimeEdit", "(QWidget*)", "#")]
		private void NewQDateTimeEdit(QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(parent);
		}
		public QDateTimeEdit() : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit();
		}
		[SmokeMethod("QDateTimeEdit", "()", "")]
		private void NewQDateTimeEdit() {
			ProxyQDateTimeEdit().NewQDateTimeEdit();
		}
		public QDateTimeEdit(QDateTime dt, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(dt,parent);
		}
		[SmokeMethod("QDateTimeEdit", "(const QDateTime&, QWidget*)", "##")]
		private void NewQDateTimeEdit(QDateTime dt, QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(dt,parent);
		}
		public QDateTimeEdit(QDateTime dt) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(dt);
		}
		[SmokeMethod("QDateTimeEdit", "(const QDateTime&)", "#")]
		private void NewQDateTimeEdit(QDateTime dt) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(dt);
		}
		public QDateTimeEdit(QDate d, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(d,parent);
		}
		[SmokeMethod("QDateTimeEdit", "(const QDate&, QWidget*)", "##")]
		private void NewQDateTimeEdit(QDate d, QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(d,parent);
		}
		public QDateTimeEdit(QDate d) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(d);
		}
		[SmokeMethod("QDateTimeEdit", "(const QDate&)", "#")]
		private void NewQDateTimeEdit(QDate d) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(d);
		}
		public QDateTimeEdit(QTime t, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(t,parent);
		}
		[SmokeMethod("QDateTimeEdit", "(const QTime&, QWidget*)", "##")]
		private void NewQDateTimeEdit(QTime t, QWidget parent) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(t,parent);
		}
		public QDateTimeEdit(QTime t) : this((Type) null) {
			CreateProxy();
			NewQDateTimeEdit(t);
		}
		[SmokeMethod("QDateTimeEdit", "(const QTime&)", "#")]
		private void NewQDateTimeEdit(QTime t) {
			ProxyQDateTimeEdit().NewQDateTimeEdit(t);
		}
		[SmokeMethod("clearMinimumDate", "()", "")]
		public void ClearMinimumDate() {
			ProxyQDateTimeEdit().ClearMinimumDate();
		}
		[SmokeMethod("clearMaximumDate", "()", "")]
		public void ClearMaximumDate() {
			ProxyQDateTimeEdit().ClearMaximumDate();
		}
		[SmokeMethod("setDateRange", "(const QDate&, const QDate&)", "##")]
		public void SetDateRange(QDate min, QDate max) {
			ProxyQDateTimeEdit().SetDateRange(min,max);
		}
		[SmokeMethod("clearMinimumTime", "()", "")]
		public void ClearMinimumTime() {
			ProxyQDateTimeEdit().ClearMinimumTime();
		}
		[SmokeMethod("clearMaximumTime", "()", "")]
		public void ClearMaximumTime() {
			ProxyQDateTimeEdit().ClearMaximumTime();
		}
		[SmokeMethod("setTimeRange", "(const QTime&, const QTime&)", "##")]
		public void SetTimeRange(QTime min, QTime max) {
			ProxyQDateTimeEdit().SetTimeRange(min,max);
		}
		[SmokeMethod("setSelectedSection", "(QDateTimeEdit::Section)", "$")]
		public void SetSelectedSection(QDateTimeEdit.Section section) {
			ProxyQDateTimeEdit().SetSelectedSection(section);
		}
		[SmokeMethod("sectionText", "(QDateTimeEdit::Section) const", "$")]
		public string SectionText(QDateTimeEdit.Section section) {
			return ProxyQDateTimeEdit().SectionText(section);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ProxyQDateTimeEdit().SizeHint();
		}
		[SmokeMethod("clear", "()", "")]
		public override void Clear() {
			ProxyQDateTimeEdit().Clear();
		}
		[SmokeMethod("stepBy", "(int)", "$")]
		public override void StepBy(int steps) {
			ProxyQDateTimeEdit().StepBy(steps);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public override bool Event(QEvent arg1) {
			return ProxyQDateTimeEdit().Event(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			ProxyQDateTimeEdit().KeyPressEvent(arg1);
		}
		[SmokeMethod("wheelEvent", "(QWheelEvent*)", "#")]
		protected override void WheelEvent(QWheelEvent arg1) {
			ProxyQDateTimeEdit().WheelEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			ProxyQDateTimeEdit().FocusInEvent(arg1);
		}
		[SmokeMethod("focusNextPrevChild", "(bool)", "$")]
		protected override bool FocusNextPrevChild(bool next) {
			return ProxyQDateTimeEdit().FocusNextPrevChild(next);
		}
		[SmokeMethod("validate", "(QString&, int&) const", "$$")]
		protected new virtual int Validate(StringBuilder input, out int pos) {
			return ProxyQDateTimeEdit().Validate(input,out pos);
		}
		[SmokeMethod("fixup", "(QString&) const", "$")]
		protected new virtual void Fixup(StringBuilder input) {
			ProxyQDateTimeEdit().Fixup(input);
		}
		[SmokeMethod("dateTimeFromText", "(const QString&) const", "$")]
		protected virtual QDateTime DateTimeFromText(string text) {
			return ProxyQDateTimeEdit().DateTimeFromText(text);
		}
		[SmokeMethod("textFromDateTime", "(const QDateTime&) const", "#")]
		protected virtual string TextFromDateTime(QDateTime dt) {
			return ProxyQDateTimeEdit().TextFromDateTime(dt);
		}
		[SmokeMethod("stepEnabled", "() const", "")]
		protected override int StepEnabled() {
			return ProxyQDateTimeEdit().StepEnabled();
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			ProxyQDateTimeEdit().MousePressEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			ProxyQDateTimeEdit().PaintEvent(arg1);
		}
		~QDateTimeEdit() {
			DisposeQDateTimeEdit();
		}
		public new void Dispose() {
			DisposeQDateTimeEdit();
		}
		[SmokeMethod("~QDateTimeEdit", "()", "")]
		private void DisposeQDateTimeEdit() {
			ProxyQDateTimeEdit().DisposeQDateTimeEdit();
		}
		public static string Tr(string s, string c) {
			return StaticQDateTimeEdit().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQDateTimeEdit().Tr(s);
		}
		protected new IQDateTimeEditSignals Emit {
			get { return (IQDateTimeEditSignals) Q_EMIT; }
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
