//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QDBusMessage")]
	public class QDBusMessage : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDBusMessage(Type dummy) {}
		interface IQDBusMessageProxy {
			QDBusMessage op_write(QDBusMessage lhs, QVariant arg);
			QDBusMessage Signal(string path, string arg2, string name, QDBusConnection connection);
			QDBusMessage MethodCall(string destination, string path, string arg3, string method, QDBusConnection connection);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusMessage), this);
			_interceptor = (QDBusMessage) realProxy.GetTransparentProxy();
		}
		private QDBusMessage ProxyQDBusMessage() {
			return (QDBusMessage) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusMessage() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusMessageProxy), null);
			_staticInterceptor = (IQDBusMessageProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusMessageProxy StaticQDBusMessage() {
			return (IQDBusMessageProxy) _staticInterceptor;
		}

		public enum MessageType {
			InvalidMessage = 0,
			MethodCallMessage = 1,
			ReplyMessage = 2,
			ErrorMessage = 3,
			SignalMessage = 4,
		}
		public QDBusMessage() : this((Type) null) {
			CreateProxy();
			NewQDBusMessage();
		}
		[SmokeMethod("QDBusMessage()")]
		private void NewQDBusMessage() {
			ProxyQDBusMessage().NewQDBusMessage();
		}
		public QDBusMessage(QDBusMessage other) : this((Type) null) {
			CreateProxy();
			NewQDBusMessage(other);
		}
		[SmokeMethod("QDBusMessage(const QDBusMessage&)")]
		private void NewQDBusMessage(QDBusMessage other) {
			ProxyQDBusMessage().NewQDBusMessage(other);
		}
		[SmokeMethod("connection() const")]
		public QDBusConnection Connection() {
			return ProxyQDBusMessage().Connection();
		}
		[SmokeMethod("service() const")]
		public string Service() {
			return ProxyQDBusMessage().Service();
		}
		[SmokeMethod("path() const")]
		public string Path() {
			return ProxyQDBusMessage().Path();
		}
		[SmokeMethod("interface() const")]
		public string Interface() {
			return ProxyQDBusMessage().Interface();
		}
		[SmokeMethod("member() const")]
		public string Member() {
			return ProxyQDBusMessage().Member();
		}
		[SmokeMethod("type() const")]
		public QDBusMessage.MessageType type() {
			return ProxyQDBusMessage().type();
		}
		[SmokeMethod("isReplyRequired() const")]
		public bool IsReplyRequired() {
			return ProxyQDBusMessage().IsReplyRequired();
		}
		[SmokeMethod("signature() const")]
		public string Signature() {
			return ProxyQDBusMessage().Signature();
		}
		[SmokeMethod("setDelayedReply(bool) const")]
		public void SetDelayedReply(bool enable) {
			ProxyQDBusMessage().SetDelayedReply(enable);
		}
		[SmokeMethod("isDelayedReply() const")]
		public bool IsDelayedReply() {
			return ProxyQDBusMessage().IsDelayedReply();
		}
		[SmokeMethod("setArguments(const QList<QVariant>&)")]
		public void SetArguments(ArrayList arguments) {
			ProxyQDBusMessage().SetArguments(arguments);
		}
		[SmokeMethod("arguments() const")]
		public ArrayList Arguments() {
			return ProxyQDBusMessage().Arguments();
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQDBusMessage().Count();
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQDBusMessage().IsEmpty();
		}
		[SmokeMethod("at(int) const")]
		public QVariant At(int index) {
			return ProxyQDBusMessage().At(index);
		}
		[SmokeMethod("operator<<(const QVariant&)")]
		public static QDBusMessage op_write(QDBusMessage lhs, QVariant arg) {
			return StaticQDBusMessage().op_write(lhs,arg);
		}
		[SmokeMethod("append(const QVariant&)")]
		public void Append(QVariant arg) {
			ProxyQDBusMessage().Append(arg);
		}
		[SmokeMethod("send()")]
		public bool Send() {
			return ProxyQDBusMessage().Send();
		}
		[SmokeMethod("sendError(const QString&, const QString&) const")]
		public bool SendError(string name, string message) {
			return ProxyQDBusMessage().SendError(name,message);
		}
		[SmokeMethod("sendError(const QString&) const")]
		public bool SendError(string name) {
			return ProxyQDBusMessage().SendError(name);
		}
		[SmokeMethod("sendError(const QDBusError&) const")]
		public bool SendError(QDBusError error) {
			return ProxyQDBusMessage().SendError(error);
		}
		[SmokeMethod("sendReply(const QVariantList&) const")]
		public bool SendReply(ArrayList arguments) {
			return ProxyQDBusMessage().SendReply(arguments);
		}
		[SmokeMethod("sendReply() const")]
		public bool SendReply() {
			return ProxyQDBusMessage().SendReply();
		}
		[SmokeMethod("sendReply(const QVariant&) const")]
		public bool SendReply(QVariant returnValue) {
			return ProxyQDBusMessage().SendReply(returnValue);
		}
		[SmokeMethod("signal(const QString&, const QString&, const QString&, const QDBusConnection&)")]
		public static QDBusMessage Signal(string path, string arg2, string name, QDBusConnection connection) {
			return StaticQDBusMessage().Signal(path,arg2,name,connection);
		}
		[SmokeMethod("methodCall(const QString&, const QString&, const QString&, const QString&, const QDBusConnection&)")]
		public static QDBusMessage MethodCall(string destination, string path, string arg3, string method, QDBusConnection connection) {
			return StaticQDBusMessage().MethodCall(destination,path,arg3,method,connection);
		}
		~QDBusMessage() {
			DisposeQDBusMessage();
		}
		public void Dispose() {
			DisposeQDBusMessage();
		}
		[SmokeMethod("~QDBusMessage()")]
		private void DisposeQDBusMessage() {
			ProxyQDBusMessage().DisposeQDBusMessage();
		}
	}
}
