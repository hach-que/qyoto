//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QNetworkProxy")]
	public class QNetworkProxy : MarshalByRefObject, IDisposable {
		protected QNetworkProxy interceptor = null;
		private IntPtr smokeObject;
		protected QNetworkProxy(Type dummy) {}
		[SmokeClass("QNetworkProxy")]
		interface IQNetworkProxyProxy {
			[SmokeMethod("setApplicationProxy", "(const QNetworkProxy&)", "#")]
			void SetApplicationProxy(QNetworkProxy proxy);
			[SmokeMethod("applicationProxy", "()", "")]
			QNetworkProxy ApplicationProxy();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QNetworkProxy), this);
			interceptor = (QNetworkProxy) realProxy.GetTransparentProxy();
		}
		private static IQNetworkProxyProxy staticInterceptor = null;
		static QNetworkProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQNetworkProxyProxy), null);
			staticInterceptor = (IQNetworkProxyProxy) realProxy.GetTransparentProxy();
		}
		public enum ProxyType {
			DefaultProxy = 0,
			Socks5Proxy = 1,
			NoProxy = 2,
		}
		public QNetworkProxy() : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy();
		}
		[SmokeMethod("QNetworkProxy", "()", "")]
		private void NewQNetworkProxy() {
			((QNetworkProxy) interceptor).NewQNetworkProxy();
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user, string password) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName,port,user,password);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&, quint16, const QString&, const QString&)", "$$$$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user, string password) {
			((QNetworkProxy) interceptor).NewQNetworkProxy(type,hostName,port,user,password);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName,port,user);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&, quint16, const QString&)", "$$$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user) {
			((QNetworkProxy) interceptor).NewQNetworkProxy(type,hostName,port,user);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName,port);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&, quint16)", "$$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port) {
			((QNetworkProxy) interceptor).NewQNetworkProxy(type,hostName,port);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&)", "$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName) {
			((QNetworkProxy) interceptor).NewQNetworkProxy(type,hostName);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType)", "$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type) {
			((QNetworkProxy) interceptor).NewQNetworkProxy(type);
		}
		public QNetworkProxy(QNetworkProxy other) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(other);
		}
		[SmokeMethod("QNetworkProxy", "(const QNetworkProxy&)", "#")]
		private void NewQNetworkProxy(QNetworkProxy other) {
			((QNetworkProxy) interceptor).NewQNetworkProxy(other);
		}
		[SmokeMethod("setType", "(QNetworkProxy::ProxyType)", "$")]
		public void SetType(QNetworkProxy.ProxyType type) {
			((QNetworkProxy) interceptor).SetType(type);
		}
		[SmokeMethod("type", "() const", "")]
		public QNetworkProxy.ProxyType type() {
			return ((QNetworkProxy) interceptor).type();
		}
		[SmokeMethod("setUser", "(const QString&)", "$")]
		public void SetUser(string userName) {
			((QNetworkProxy) interceptor).SetUser(userName);
		}
		[SmokeMethod("user", "() const", "")]
		public string User() {
			return ((QNetworkProxy) interceptor).User();
		}
		[SmokeMethod("setPassword", "(const QString&)", "$")]
		public void SetPassword(string password) {
			((QNetworkProxy) interceptor).SetPassword(password);
		}
		[SmokeMethod("password", "() const", "")]
		public string Password() {
			return ((QNetworkProxy) interceptor).Password();
		}
		[SmokeMethod("setHostName", "(const QString&)", "$")]
		public void SetHostName(string hostName) {
			((QNetworkProxy) interceptor).SetHostName(hostName);
		}
		[SmokeMethod("hostName", "() const", "")]
		public string HostName() {
			return ((QNetworkProxy) interceptor).HostName();
		}
		[SmokeMethod("setPort", "(quint16)", "$")]
		public void SetPort(ushort port) {
			((QNetworkProxy) interceptor).SetPort(port);
		}
		[SmokeMethod("port", "() const", "")]
		public ushort Port() {
			return ((QNetworkProxy) interceptor).Port();
		}
		~QNetworkProxy() {
			DisposeQNetworkProxy();
		}
		public void Dispose() {
			DisposeQNetworkProxy();
		}
		[SmokeMethod("~QNetworkProxy", "()", "")]
		private void DisposeQNetworkProxy() {
			((QNetworkProxy) interceptor).DisposeQNetworkProxy();
		}
		public static void SetApplicationProxy(QNetworkProxy proxy) {
			staticInterceptor.SetApplicationProxy(proxy);
		}
		public static QNetworkProxy ApplicationProxy() {
			return staticInterceptor.ApplicationProxy();
		}
	}
}
