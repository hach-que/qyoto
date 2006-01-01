//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QTranslatorMessage : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTranslatorMessage(Type dummy) {}
		interface IQTranslatorMessageProxy {
			bool op_equals(QTranslatorMessage lhs, QTranslatorMessage m);
			bool op_lt(QTranslatorMessage lhs, QTranslatorMessage m);
			bool op_lte(QTranslatorMessage lhs, QTranslatorMessage m);
			bool op_gt(QTranslatorMessage lhs, QTranslatorMessage m);
			bool op_gte(QTranslatorMessage lhs, QTranslatorMessage m);
		}

		protected void CreateQTranslatorMessageProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTranslatorMessage), this);
			_interceptor = (QTranslatorMessage) realProxy.GetTransparentProxy();
		}
		private QTranslatorMessage ProxyQTranslatorMessage() {
			return (QTranslatorMessage) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTranslatorMessage() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTranslatorMessageProxy), null);
			_staticInterceptor = (IQTranslatorMessageProxy) realProxy.GetTransparentProxy();
		}
		private static IQTranslatorMessageProxy StaticQTranslatorMessage() {
			return (IQTranslatorMessageProxy) _staticInterceptor;
		}

		enum Prefix {
			NoPrefix = 0,
			Hash = 1,
			HashContext = 2,
			HashContextSourceText = 3,
			HashContextSourceTextComment = 4,
		}
		public QTranslatorMessage() : this((Type) null) {
			CreateQTranslatorMessageProxy();
			NewQTranslatorMessage();
		}
		[SmokeMethod("QTranslatorMessage()")]
		private void NewQTranslatorMessage() {
			ProxyQTranslatorMessage().NewQTranslatorMessage();
		}
		public QTranslatorMessage(string context, string sourceText, string comment, string translation) : this((Type) null) {
			CreateQTranslatorMessageProxy();
			NewQTranslatorMessage(context,sourceText,comment,translation);
		}
		[SmokeMethod("QTranslatorMessage(const char*, const char*, const char*, const QString&)")]
		private void NewQTranslatorMessage(string context, string sourceText, string comment, string translation) {
			ProxyQTranslatorMessage().NewQTranslatorMessage(context,sourceText,comment,translation);
		}
		public QTranslatorMessage(string context, string sourceText, string comment) : this((Type) null) {
			CreateQTranslatorMessageProxy();
			NewQTranslatorMessage(context,sourceText,comment);
		}
		[SmokeMethod("QTranslatorMessage(const char*, const char*, const char*)")]
		private void NewQTranslatorMessage(string context, string sourceText, string comment) {
			ProxyQTranslatorMessage().NewQTranslatorMessage(context,sourceText,comment);
		}
		public QTranslatorMessage(QDataStream arg1) : this((Type) null) {
			CreateQTranslatorMessageProxy();
			NewQTranslatorMessage(arg1);
		}
		[SmokeMethod("QTranslatorMessage(QDataStream&)")]
		private void NewQTranslatorMessage(QDataStream arg1) {
			ProxyQTranslatorMessage().NewQTranslatorMessage(arg1);
		}
		public QTranslatorMessage(QTranslatorMessage m) : this((Type) null) {
			CreateQTranslatorMessageProxy();
			NewQTranslatorMessage(m);
		}
		[SmokeMethod("QTranslatorMessage(const QTranslatorMessage&)")]
		private void NewQTranslatorMessage(QTranslatorMessage m) {
			ProxyQTranslatorMessage().NewQTranslatorMessage(m);
		}
		[SmokeMethod("hash() const")]
		public uint Hash() {
			return ProxyQTranslatorMessage().Hash();
		}
		[SmokeMethod("context() const")]
		public string Context() {
			return ProxyQTranslatorMessage().Context();
		}
		[SmokeMethod("sourceText() const")]
		public string SourceText() {
			return ProxyQTranslatorMessage().SourceText();
		}
		[SmokeMethod("comment() const")]
		public string Comment() {
			return ProxyQTranslatorMessage().Comment();
		}
		[SmokeMethod("setTranslation(const QString&)")]
		public void SetTranslation(string translation) {
			ProxyQTranslatorMessage().SetTranslation(translation);
		}
		[SmokeMethod("translation() const")]
		public string Translation() {
			return ProxyQTranslatorMessage().Translation();
		}
		[SmokeMethod("write(QDataStream&, bool, QTranslatorMessage::Prefix) const")]
		public void Write(QDataStream s, bool strip, int prefix) {
			ProxyQTranslatorMessage().Write(s,strip,prefix);
		}
		[SmokeMethod("write(QDataStream&, bool) const")]
		public void Write(QDataStream s, bool strip) {
			ProxyQTranslatorMessage().Write(s,strip);
		}
		[SmokeMethod("write(QDataStream&) const")]
		public void Write(QDataStream s) {
			ProxyQTranslatorMessage().Write(s);
		}
		[SmokeMethod("commonPrefix(const QTranslatorMessage&) const")]
		public int CommonPrefix(QTranslatorMessage arg1) {
			return ProxyQTranslatorMessage().CommonPrefix(arg1);
		}
		[SmokeMethod("operator==(const QTranslatorMessage&) const")]
		public static bool operator==(QTranslatorMessage lhs, QTranslatorMessage m) {
			return StaticQTranslatorMessage().op_equals(lhs,m);
		}
		public static bool operator!=(QTranslatorMessage lhs, QTranslatorMessage m) {
			return !StaticQTranslatorMessage().op_equals(lhs,m);
		}
		public override bool Equals(object o) {
			if (!(o is QTranslatorMessage)) { return false; }
			return this == (QTranslatorMessage) o;
		}
		public override int GetHashCode() {
			return ProxyQTranslatorMessage().GetHashCode();
		}
		[SmokeMethod("operator<(const QTranslatorMessage&) const")]
		public static bool operator<(QTranslatorMessage lhs, QTranslatorMessage m) {
			return StaticQTranslatorMessage().op_lt(lhs,m);
		}
		[SmokeMethod("operator<=(const QTranslatorMessage&) const")]
		public static bool operator<=(QTranslatorMessage lhs, QTranslatorMessage m) {
			return StaticQTranslatorMessage().op_lte(lhs,m);
		}
		[SmokeMethod("operator>(const QTranslatorMessage&) const")]
		public static bool operator>(QTranslatorMessage lhs, QTranslatorMessage m) {
			return StaticQTranslatorMessage().op_gt(lhs,m);
		}
		[SmokeMethod("operator>=(const QTranslatorMessage&) const")]
		public static bool operator>=(QTranslatorMessage lhs, QTranslatorMessage m) {
			return StaticQTranslatorMessage().op_gte(lhs,m);
		}
		~QTranslatorMessage() {
			DisposeQTranslatorMessage();
		}
		public void Dispose() {
			DisposeQTranslatorMessage();
		}
		private void DisposeQTranslatorMessage() {
			ProxyQTranslatorMessage().DisposeQTranslatorMessage();
		}
	}
}