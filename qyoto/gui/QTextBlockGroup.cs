//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTextBlockGroup")]
	public class QTextBlockGroup : QTextObject {
 		protected QTextBlockGroup(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextBlockGroup")]
		interface IQTextBlockGroupProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBlockGroup), this);
			interceptor = (QTextBlockGroup) realProxy.GetTransparentProxy();
		}
		private static IQTextBlockGroupProxy staticInterceptor = null;
		static QTextBlockGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBlockGroupProxy), null);
			staticInterceptor = (IQTextBlockGroupProxy) realProxy.GetTransparentProxy();
		}
		public QTextBlockGroup(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			NewQTextBlockGroup(doc);
		}
		[SmokeMethod("QTextBlockGroup", "(QTextDocument*)", "#")]
		private void NewQTextBlockGroup(QTextDocument doc) {
			((QTextBlockGroup) interceptor).NewQTextBlockGroup(doc);
		}
		[SmokeMethod("blockInserted", "(const QTextBlock&)", "#")]
		protected virtual void BlockInserted(QTextBlock block) {
			((QTextBlockGroup) interceptor).BlockInserted(block);
		}
		[SmokeMethod("blockRemoved", "(const QTextBlock&)", "#")]
		protected virtual void BlockRemoved(QTextBlock block) {
			((QTextBlockGroup) interceptor).BlockRemoved(block);
		}
		[SmokeMethod("blockFormatChanged", "(const QTextBlock&)", "#")]
		protected virtual void BlockFormatChanged(QTextBlock block) {
			((QTextBlockGroup) interceptor).BlockFormatChanged(block);
		}
		[SmokeMethod("blockList", "() const", "")]
		protected List<QTextBlock> BlockList() {
			return ((QTextBlockGroup) interceptor).BlockList();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQTextBlockGroupSignals Emit {
			get { return (IQTextBlockGroupSignals) Q_EMIT; }
		}
	}

	public interface IQTextBlockGroupSignals : IQTextObjectSignals {
	}
}
