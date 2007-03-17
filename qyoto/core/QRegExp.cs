//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QRegExp")]
	public class QRegExp : MarshalByRefObject, IDisposable {
		protected QRegExp interceptor = null;
		private IntPtr smokeObject;
		protected QRegExp(Type dummy) {}
		[SmokeClass("QRegExp")]
		interface IQRegExpProxy {
			[SmokeMethod("operator==", "(const QRegExp&) const", "#")]
			bool op_equals(QRegExp lhs, QRegExp rx);
			[SmokeMethod("escape", "(const QString&)", "$")]
			string Escape(string str);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRegExp), this);
			interceptor = (QRegExp) realProxy.GetTransparentProxy();
		}
		private static IQRegExpProxy staticInterceptor = null;
		static QRegExp() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRegExpProxy), null);
			staticInterceptor = (IQRegExpProxy) realProxy.GetTransparentProxy();
		}
		public enum PatternSyntax {
			RegExp = 0,
			Wildcard = 1,
			FixedString = 2,
			RegExp2 = 3,
		}
		public enum CaretMode {
			CaretAtZero = 0,
			CaretAtOffset = 1,
			CaretWontMatch = 2,
		}
		public QRegExp() : this((Type) null) {
			CreateProxy();
			NewQRegExp();
		}
		[SmokeMethod("QRegExp", "()", "")]
		private void NewQRegExp() {
			((QRegExp) interceptor).NewQRegExp();
		}
		public QRegExp(string pattern, Qt.CaseSensitivity cs, QRegExp.PatternSyntax syntax) : this((Type) null) {
			CreateProxy();
			NewQRegExp(pattern,cs,syntax);
		}
		[SmokeMethod("QRegExp", "(const QString&, Qt::CaseSensitivity, QRegExp::PatternSyntax)", "$$$")]
		private void NewQRegExp(string pattern, Qt.CaseSensitivity cs, QRegExp.PatternSyntax syntax) {
			((QRegExp) interceptor).NewQRegExp(pattern,cs,syntax);
		}
		public QRegExp(string pattern, Qt.CaseSensitivity cs) : this((Type) null) {
			CreateProxy();
			NewQRegExp(pattern,cs);
		}
		[SmokeMethod("QRegExp", "(const QString&, Qt::CaseSensitivity)", "$$")]
		private void NewQRegExp(string pattern, Qt.CaseSensitivity cs) {
			((QRegExp) interceptor).NewQRegExp(pattern,cs);
		}
		public QRegExp(string pattern) : this((Type) null) {
			CreateProxy();
			NewQRegExp(pattern);
		}
		[SmokeMethod("QRegExp", "(const QString&)", "$")]
		private void NewQRegExp(string pattern) {
			((QRegExp) interceptor).NewQRegExp(pattern);
		}
		public QRegExp(QRegExp rx) : this((Type) null) {
			CreateProxy();
			NewQRegExp(rx);
		}
		[SmokeMethod("QRegExp", "(const QRegExp&)", "#")]
		private void NewQRegExp(QRegExp rx) {
			((QRegExp) interceptor).NewQRegExp(rx);
		}
		public override bool Equals(object o) {
			if (!(o is QRegExp)) { return false; }
			return this == (QRegExp) o;
		}
		public override int GetHashCode() {
			return ((QRegExp) interceptor).GetHashCode();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ((QRegExp) interceptor).IsEmpty();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ((QRegExp) interceptor).IsValid();
		}
		[SmokeMethod("pattern", "() const", "")]
		public string Pattern() {
			return ((QRegExp) interceptor).Pattern();
		}
		[SmokeMethod("setPattern", "(const QString&)", "$")]
		public void SetPattern(string pattern) {
			((QRegExp) interceptor).SetPattern(pattern);
		}
		[SmokeMethod("caseSensitivity", "() const", "")]
		public Qt.CaseSensitivity CaseSensitivity() {
			return ((QRegExp) interceptor).CaseSensitivity();
		}
		[SmokeMethod("setCaseSensitivity", "(Qt::CaseSensitivity)", "$")]
		public void SetCaseSensitivity(Qt.CaseSensitivity cs) {
			((QRegExp) interceptor).SetCaseSensitivity(cs);
		}
		[SmokeMethod("patternSyntax", "() const", "")]
		public QRegExp.PatternSyntax patternSyntax() {
			return ((QRegExp) interceptor).patternSyntax();
		}
		[SmokeMethod("setPatternSyntax", "(QRegExp::PatternSyntax)", "$")]
		public void SetPatternSyntax(QRegExp.PatternSyntax syntax) {
			((QRegExp) interceptor).SetPatternSyntax(syntax);
		}
		[SmokeMethod("isMinimal", "() const", "")]
		public bool IsMinimal() {
			return ((QRegExp) interceptor).IsMinimal();
		}
		[SmokeMethod("setMinimal", "(bool)", "$")]
		public void SetMinimal(bool minimal) {
			((QRegExp) interceptor).SetMinimal(minimal);
		}
		[SmokeMethod("exactMatch", "(const QString&) const", "$")]
		public bool ExactMatch(string str) {
			return ((QRegExp) interceptor).ExactMatch(str);
		}
		[SmokeMethod("indexIn", "(const QString&, int, QRegExp::CaretMode) const", "$$$")]
		public int IndexIn(string str, int offset, QRegExp.CaretMode caretMode) {
			return ((QRegExp) interceptor).IndexIn(str,offset,caretMode);
		}
		[SmokeMethod("indexIn", "(const QString&, int) const", "$$")]
		public int IndexIn(string str, int offset) {
			return ((QRegExp) interceptor).IndexIn(str,offset);
		}
		[SmokeMethod("indexIn", "(const QString&) const", "$")]
		public int IndexIn(string str) {
			return ((QRegExp) interceptor).IndexIn(str);
		}
		[SmokeMethod("lastIndexIn", "(const QString&, int, QRegExp::CaretMode) const", "$$$")]
		public int LastIndexIn(string str, int offset, QRegExp.CaretMode caretMode) {
			return ((QRegExp) interceptor).LastIndexIn(str,offset,caretMode);
		}
		[SmokeMethod("lastIndexIn", "(const QString&, int) const", "$$")]
		public int LastIndexIn(string str, int offset) {
			return ((QRegExp) interceptor).LastIndexIn(str,offset);
		}
		[SmokeMethod("lastIndexIn", "(const QString&) const", "$")]
		public int LastIndexIn(string str) {
			return ((QRegExp) interceptor).LastIndexIn(str);
		}
		[SmokeMethod("matchedLength", "() const", "")]
		public int MatchedLength() {
			return ((QRegExp) interceptor).MatchedLength();
		}
		[SmokeMethod("numCaptures", "() const", "")]
		public int NumCaptures() {
			return ((QRegExp) interceptor).NumCaptures();
		}
		[SmokeMethod("capturedTexts", "()", "")]
		public List<string> CapturedTexts() {
			return ((QRegExp) interceptor).CapturedTexts();
		}
		[SmokeMethod("cap", "(int)", "$")]
		public string Cap(int nth) {
			return ((QRegExp) interceptor).Cap(nth);
		}
		[SmokeMethod("cap", "()", "")]
		public string Cap() {
			return ((QRegExp) interceptor).Cap();
		}
		[SmokeMethod("pos", "(int)", "$")]
		public int Pos(int nth) {
			return ((QRegExp) interceptor).Pos(nth);
		}
		[SmokeMethod("pos", "()", "")]
		public int Pos() {
			return ((QRegExp) interceptor).Pos();
		}
		[SmokeMethod("errorString", "()", "")]
		public string ErrorString() {
			return ((QRegExp) interceptor).ErrorString();
		}
		~QRegExp() {
			DisposeQRegExp();
		}
		public void Dispose() {
			DisposeQRegExp();
		}
		[SmokeMethod("~QRegExp", "()", "")]
		private void DisposeQRegExp() {
			((QRegExp) interceptor).DisposeQRegExp();
		}
		public static bool operator==(QRegExp lhs, QRegExp rx) {
			return staticInterceptor.op_equals(lhs,rx);
		}
		public static bool operator!=(QRegExp lhs, QRegExp rx) {
			return !staticInterceptor.op_equals(lhs,rx);
		}
		public static string Escape(string str) {
			return staticInterceptor.Escape(str);
		}
	}
}
