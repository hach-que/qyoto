//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QSyntaxHighlighter")]
	public class QSyntaxHighlighter : QObject {
 		protected QSyntaxHighlighter(Type dummy) : base((Type) null) {}
		interface IQSyntaxHighlighterProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSyntaxHighlighter), this);
			_interceptor = (QSyntaxHighlighter) realProxy.GetTransparentProxy();
		}
		private QSyntaxHighlighter ProxyQSyntaxHighlighter() {
			return (QSyntaxHighlighter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSyntaxHighlighter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSyntaxHighlighterProxy), null);
			_staticInterceptor = (IQSyntaxHighlighterProxy) realProxy.GetTransparentProxy();
		}
		private static IQSyntaxHighlighterProxy StaticQSyntaxHighlighter() {
			return (IQSyntaxHighlighterProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSyntaxHighlighter(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSyntaxHighlighter(parent);
		}
		[SmokeMethod("QSyntaxHighlighter(QObject*)")]
		private void NewQSyntaxHighlighter(QObject parent) {
			ProxyQSyntaxHighlighter().NewQSyntaxHighlighter(parent);
		}
		// QSyntaxHighlighter* QSyntaxHighlighter(QTextDocument* arg1); >>>> NOT CONVERTED
		public QSyntaxHighlighter(QTextEdit parent) : this((Type) null) {
			CreateProxy();
			NewQSyntaxHighlighter(parent);
		}
		[SmokeMethod("QSyntaxHighlighter(QTextEdit*)")]
		private void NewQSyntaxHighlighter(QTextEdit parent) {
			ProxyQSyntaxHighlighter().NewQSyntaxHighlighter(parent);
		}
		// void setDocument(QTextDocument* arg1); >>>> NOT CONVERTED
		// QTextDocument* document(); >>>> NOT CONVERTED
		[SmokeMethod("rehighlight()")]
		public void Rehighlight() {
			ProxyQSyntaxHighlighter().Rehighlight();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSyntaxHighlighter().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSyntaxHighlighter().Tr(s);
		}
		~QSyntaxHighlighter() {
			DisposeQSyntaxHighlighter();
		}
		public new void Dispose() {
			DisposeQSyntaxHighlighter();
		}
		[SmokeMethod("~QSyntaxHighlighter()")]
		private void DisposeQSyntaxHighlighter() {
			ProxyQSyntaxHighlighter().DisposeQSyntaxHighlighter();
		}
		protected new IQSyntaxHighlighterSignals Emit() {
			return (IQSyntaxHighlighterSignals) Q_EMIT;
		}
	}

	public interface IQSyntaxHighlighterSignals : IQObjectSignals {
	}
}
