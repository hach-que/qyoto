//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDateTime")]
	public class QDateTime : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDateTime(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDateTime), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDateTime() {
			staticInterceptor = new SmokeInvocation(typeof(QDateTime), null);
		}
		public QDateTime() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTime", "QDateTime()", typeof(void));
		}
		public QDateTime(QDate arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTime#", "QDateTime(const QDate&)", typeof(void), typeof(QDate), arg1);
		}
		public QDateTime(QDate arg1, QTime arg2, Qt.TimeSpec spec) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTime##$", "QDateTime(const QDate&, const QTime&, Qt::TimeSpec)", typeof(void), typeof(QDate), arg1, typeof(QTime), arg2, typeof(Qt.TimeSpec), spec);
		}
		public QDateTime(QDate arg1, QTime arg2) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTime##", "QDateTime(const QDate&, const QTime&)", typeof(void), typeof(QDate), arg1, typeof(QTime), arg2);
		}
		public QDateTime(QDateTime other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTime#", "QDateTime(const QDateTime&)", typeof(void), typeof(QDateTime), other);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public QDate Date() {
			return (QDate) interceptor.Invoke("date", "date() const", typeof(QDate));
		}
		public QTime Time() {
			return (QTime) interceptor.Invoke("time", "time() const", typeof(QTime));
		}
		public Qt.TimeSpec TimeSpec() {
			return (Qt.TimeSpec) interceptor.Invoke("timeSpec", "timeSpec() const", typeof(Qt.TimeSpec));
		}
		public uint ToTime_t() {
			return (uint) interceptor.Invoke("toTime_t", "toTime_t() const", typeof(uint));
		}
		public void SetDate(QDate date) {
			interceptor.Invoke("setDate#", "setDate(const QDate&)", typeof(void), typeof(QDate), date);
		}
		public void SetTime(QTime time) {
			interceptor.Invoke("setTime#", "setTime(const QTime&)", typeof(void), typeof(QTime), time);
		}
		public void SetTimeSpec(Qt.TimeSpec spec) {
			interceptor.Invoke("setTimeSpec$", "setTimeSpec(Qt::TimeSpec)", typeof(void), typeof(Qt.TimeSpec), spec);
		}
		public void SetTime_t(uint secsSince1Jan1970UTC) {
			interceptor.Invoke("setTime_t$", "setTime_t(uint)", typeof(void), typeof(uint), secsSince1Jan1970UTC);
		}
		public string ToString(Qt.DateFormat f) {
			return (string) interceptor.Invoke("toString$", "toString(Qt::DateFormat) const", typeof(string), typeof(Qt.DateFormat), f);
		}
		public new string ToString() {
			return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
		}
		public string ToString(string format) {
			return (string) interceptor.Invoke("toString$", "toString(const QString&) const", typeof(string), typeof(string), format);
		}
		public QDateTime AddDays(int days) {
			return (QDateTime) interceptor.Invoke("addDays$", "addDays(int) const", typeof(QDateTime), typeof(int), days);
		}
		public QDateTime AddMonths(int months) {
			return (QDateTime) interceptor.Invoke("addMonths$", "addMonths(int) const", typeof(QDateTime), typeof(int), months);
		}
		public QDateTime AddYears(int years) {
			return (QDateTime) interceptor.Invoke("addYears$", "addYears(int) const", typeof(QDateTime), typeof(int), years);
		}
		public QDateTime AddSecs(int secs) {
			return (QDateTime) interceptor.Invoke("addSecs$", "addSecs(int) const", typeof(QDateTime), typeof(int), secs);
		}
		public QDateTime AddMSecs(long msecs) {
			return (QDateTime) interceptor.Invoke("addMSecs$", "addMSecs(qint64) const", typeof(QDateTime), typeof(long), msecs);
		}
		public QDateTime ToTimeSpec(Qt.TimeSpec spec) {
			return (QDateTime) interceptor.Invoke("toTimeSpec$", "toTimeSpec(Qt::TimeSpec) const", typeof(QDateTime), typeof(Qt.TimeSpec), spec);
		}
		public QDateTime ToLocalTime() {
			return (QDateTime) interceptor.Invoke("toLocalTime", "toLocalTime() const", typeof(QDateTime));
		}
		public QDateTime ToUTC() {
			return (QDateTime) interceptor.Invoke("toUTC", "toUTC() const", typeof(QDateTime));
		}
		public int DaysTo(QDateTime arg1) {
			return (int) interceptor.Invoke("daysTo#", "daysTo(const QDateTime&) const", typeof(int), typeof(QDateTime), arg1);
		}
		public int SecsTo(QDateTime arg1) {
			return (int) interceptor.Invoke("secsTo#", "secsTo(const QDateTime&) const", typeof(int), typeof(QDateTime), arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDateTime)) { return false; }
			return this == (QDateTime) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QDateTime() {
			interceptor.Invoke("~QDateTime", "~QDateTime()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDateTime", "~QDateTime()", typeof(void));
		}
		public static bool operator==(QDateTime lhs, QDateTime other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QDateTime&) const", typeof(bool), typeof(QDateTime), lhs, typeof(QDateTime), other);
		}
		public static bool operator!=(QDateTime lhs, QDateTime other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QDateTime&) const", typeof(bool), typeof(QDateTime), lhs, typeof(QDateTime), other);
		}
		public static bool operator<(QDateTime lhs, QDateTime other) {
			return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QDateTime&) const", typeof(bool), typeof(QDateTime), lhs, typeof(QDateTime), other);
		}
		public static bool operator<=(QDateTime lhs, QDateTime other) {
			return (bool) staticInterceptor.Invoke("operator<=#", "operator<=(const QDateTime&) const", typeof(bool), typeof(QDateTime), lhs, typeof(QDateTime), other);
		}
		public static bool operator>(QDateTime lhs, QDateTime other) {
			return (bool) staticInterceptor.Invoke("operator>#", "operator>(const QDateTime&) const", typeof(bool), typeof(QDateTime), lhs, typeof(QDateTime), other);
		}
		public static bool operator>=(QDateTime lhs, QDateTime other) {
			return (bool) staticInterceptor.Invoke("operator>=#", "operator>=(const QDateTime&) const", typeof(bool), typeof(QDateTime), lhs, typeof(QDateTime), other);
		}
		public static QDateTime CurrentDateTime() {
			return (QDateTime) staticInterceptor.Invoke("currentDateTime", "currentDateTime()", typeof(QDateTime));
		}
		public static QDateTime FromString(string s, Qt.DateFormat f) {
			return (QDateTime) staticInterceptor.Invoke("fromString$$", "fromString(const QString&, Qt::DateFormat)", typeof(QDateTime), typeof(string), s, typeof(Qt.DateFormat), f);
		}
		public static QDateTime FromString(string s) {
			return (QDateTime) staticInterceptor.Invoke("fromString$", "fromString(const QString&)", typeof(QDateTime), typeof(string), s);
		}
		public static QDateTime FromString(string s, string format) {
			return (QDateTime) staticInterceptor.Invoke("fromString$$", "fromString(const QString&, const QString&)", typeof(QDateTime), typeof(string), s, typeof(string), format);
		}
		public static QDateTime FromTime_t(uint secsSince1Jan1970UTC) {
			return (QDateTime) staticInterceptor.Invoke("fromTime_t$", "fromTime_t(uint)", typeof(QDateTime), typeof(uint), secsSince1Jan1970UTC);
		}
	}
}
