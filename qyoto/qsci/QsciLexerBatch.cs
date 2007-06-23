//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto.QScintilla {

	using System;

	[SmokeClass("QsciLexerBatch")]
	public class QsciLexerBatch : QsciLexer, IDisposable {
 		protected QsciLexerBatch(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QsciLexerBatch), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QsciLexerBatch() {
			staticInterceptor = new SmokeInvocation(typeof(QsciLexerBatch), null);
		}
		public const int Default = 0;
		public const int Comment = 1;
		public const int Keyword = 2;
		public const int Label = 3;
		public const int HideCommandChar = 4;
		public const int ExternalCommand = 5;
		public const int Variable = 6;
		public const int Operator = 7;

		public QsciLexerBatch(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexerBatch#", "QsciLexerBatch(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QsciLexerBatch() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexerBatch", "QsciLexerBatch()", typeof(void));
		}
		[SmokeMethod("language() const")]
		public override string Language() {
			return (string) interceptor.Invoke("language", "language() const", typeof(string));
		}
		[SmokeMethod("lexer() const")]
		public override string Lexer() {
			return (string) interceptor.Invoke("lexer", "lexer() const", typeof(string));
		}
		[SmokeMethod("wordCharacters() const")]
		public override string WordCharacters() {
			return (string) interceptor.Invoke("wordCharacters", "wordCharacters() const", typeof(string));
		}
		[SmokeMethod("caseSensitive() const")]
		public override bool CaseSensitive() {
			return (bool) interceptor.Invoke("caseSensitive", "caseSensitive() const", typeof(bool));
		}
		[SmokeMethod("defaultColor(int) const")]
		public override QColor DefaultColor(int style) {
			return (QColor) interceptor.Invoke("defaultColor$", "defaultColor(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("defaultEolFill(int) const")]
		public override bool DefaultEolFill(int style) {
			return (bool) interceptor.Invoke("defaultEolFill$", "defaultEolFill(int) const", typeof(bool), typeof(int), style);
		}
		[SmokeMethod("defaultFont(int) const")]
		public override QFont DefaultFont(int style) {
			return (QFont) interceptor.Invoke("defaultFont$", "defaultFont(int) const", typeof(QFont), typeof(int), style);
		}
		[SmokeMethod("defaultPaper(int) const")]
		public override QColor DefaultPaper(int style) {
			return (QColor) interceptor.Invoke("defaultPaper$", "defaultPaper(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("keywords(int) const")]
		public override string Keywords(int set) {
			return (string) interceptor.Invoke("keywords$", "keywords(int) const", typeof(string), typeof(int), set);
		}
		[SmokeMethod("description(int) const")]
		public override string Description(int style) {
			return (string) interceptor.Invoke("description$", "description(int) const", typeof(string), typeof(int), style);
		}
		~QsciLexerBatch() {
			interceptor.Invoke("~QsciLexerBatch", "~QsciLexerBatch()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QsciLexerBatch", "~QsciLexerBatch()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQsciLexerBatchSignals Emit {
			get { return (IQsciLexerBatchSignals) Q_EMIT; }
		}
	}

	public interface IQsciLexerBatchSignals : IQsciLexerSignals {
	}
}