//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QTextBlockGroup")]
	public class QTextBlockGroup : QTextObject {
 		protected QTextBlockGroup(Type dummy) : base((Type) null) {}
		interface IQTextBlockGroupProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBlockGroup), this);
			_interceptor = (QTextBlockGroup) realProxy.GetTransparentProxy();
		}
		private QTextBlockGroup ProxyQTextBlockGroup() {
			return (QTextBlockGroup) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextBlockGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBlockGroupProxy), null);
			_staticInterceptor = (IQTextBlockGroupProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextBlockGroupProxy StaticQTextBlockGroup() {
			return (IQTextBlockGroupProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTextBlockGroup().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTextBlockGroup().Tr(s);
		}
		// QTextBlockGroup* QTextBlockGroup(QTextDocument* arg1); >>>> NOT CONVERTED
		[SmokeMethod("blockInserted(const QTextBlock&)")]
		protected virtual void BlockInserted(QTextBlock block) {
			ProxyQTextBlockGroup().BlockInserted(block);
		}
		[SmokeMethod("blockRemoved(const QTextBlock&)")]
		protected virtual void BlockRemoved(QTextBlock block) {
			ProxyQTextBlockGroup().BlockRemoved(block);
		}
		[SmokeMethod("blockFormatChanged(const QTextBlock&)")]
		protected virtual void BlockFormatChanged(QTextBlock block) {
			ProxyQTextBlockGroup().BlockFormatChanged(block);
		}
		[SmokeMethod("blockList() const")]
		protected ArrayList BlockList() {
			return ProxyQTextBlockGroup().BlockList();
		}
		protected new IQTextBlockGroupSignals Emit() {
			return (IQTextBlockGroupSignals) Q_EMIT;
		}
	}

	public interface IQTextBlockGroupSignals : IQTextObjectSignals {
	}
}
