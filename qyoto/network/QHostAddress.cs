//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QHostAddress")]
	public class QHostAddress : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QHostAddress(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QHostAddress), "QHostAddress", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QHostAddress() {
			staticInterceptor = new SmokeInvocation(typeof(QHostAddress), "QHostAddress", null);
		}
		public enum SpecialAddress {
			Null = 0,
			Broadcast = 1,
			LocalHost = 2,
			LocalHostIPv6 = 3,
			Any = 4,
			AnyIPv6 = 5,
		}
		// QHostAddress* QHostAddress(quint8* arg1); >>>> NOT CONVERTED
		// QHostAddress* QHostAddress(const Q_IPV6ADDR& arg1); >>>> NOT CONVERTED
		// QHostAddress* QHostAddress(const sockaddr* arg1); >>>> NOT CONVERTED
		// void setAddress(quint8* arg1); >>>> NOT CONVERTED
		// void setAddress(const Q_IPV6ADDR& arg1); >>>> NOT CONVERTED
		// void setAddress(const sockaddr* arg1); >>>> NOT CONVERTED
		// Q_IPV6ADDR toIPv6Address(); >>>> NOT CONVERTED
		public QHostAddress() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHostAddress", "QHostAddress()", typeof(void));
		}
		public QHostAddress(uint ip4Addr) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHostAddress$", "QHostAddress(quint32)", typeof(void), typeof(uint), ip4Addr);
		}
		public QHostAddress(string address) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHostAddress$", "QHostAddress(const QString&)", typeof(void), typeof(string), address);
		}
		public QHostAddress(QHostAddress copy) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHostAddress#", "QHostAddress(const QHostAddress&)", typeof(void), typeof(QHostAddress), copy);
		}
		public QHostAddress(QHostAddress.SpecialAddress address) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHostAddress$", "QHostAddress(QHostAddress::SpecialAddress)", typeof(void), typeof(QHostAddress.SpecialAddress), address);
		}
		public void SetAddress(uint ip4Addr) {
			interceptor.Invoke("setAddress$", "setAddress(quint32)", typeof(void), typeof(uint), ip4Addr);
		}
		public bool SetAddress(string address) {
			return (bool) interceptor.Invoke("setAddress$", "setAddress(const QString&)", typeof(bool), typeof(string), address);
		}
		public QAbstractSocket.NetworkLayerProtocol Protocol() {
			return (QAbstractSocket.NetworkLayerProtocol) interceptor.Invoke("protocol", "protocol() const", typeof(QAbstractSocket.NetworkLayerProtocol));
		}
		public uint ToIPv4Address() {
			return (uint) interceptor.Invoke("toIPv4Address", "toIPv4Address() const", typeof(uint));
		}
		public string ToString() {
			return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
		}
		public string ScopeId() {
			return (string) interceptor.Invoke("scopeId", "scopeId() const", typeof(string));
		}
		public void SetScopeId(string id) {
			interceptor.Invoke("setScopeId$", "setScopeId(const QString&)", typeof(void), typeof(string), id);
		}
		public override bool Equals(object o) {
			if (!(o is QHostAddress)) { return false; }
			return this == (QHostAddress) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		~QHostAddress() {
			interceptor.Invoke("~QHostAddress", "~QHostAddress()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QHostAddress", "~QHostAddress()", typeof(void));
		}
		public static bool operator==(QHostAddress lhs, QHostAddress address) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QHostAddress&) const", typeof(bool), typeof(QHostAddress), lhs, typeof(QHostAddress), address);
		}
		public static bool operator!=(QHostAddress lhs, QHostAddress address) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QHostAddress&) const", typeof(bool), typeof(QHostAddress), lhs, typeof(QHostAddress), address);
		}
		public static bool operator==(QHostAddress lhs, QHostAddress.SpecialAddress address) {
			return (bool) staticInterceptor.Invoke("operator==$", "operator==(QHostAddress::SpecialAddress) const", typeof(bool), typeof(QHostAddress), lhs, typeof(QHostAddress.SpecialAddress), address);
		}
		public static bool operator!=(QHostAddress lhs, QHostAddress.SpecialAddress address) {
			return !(bool) staticInterceptor.Invoke("operator==$", "operator==(QHostAddress::SpecialAddress) const", typeof(bool), typeof(QHostAddress), lhs, typeof(QHostAddress.SpecialAddress), address);
		}
		public static bool operator==(QHostAddress.SpecialAddress address1, QHostAddress address2) {
			return (bool) staticInterceptor.Invoke("operator==$#", "operator==(QHostAddress::SpecialAddress, const QHostAddress&)", typeof(bool), typeof(QHostAddress.SpecialAddress), address1, typeof(QHostAddress), address2);
		}
		public static bool operator!=(QHostAddress.SpecialAddress address1, QHostAddress address2) {
			return !(bool) staticInterceptor.Invoke("operator==$#", "operator==(QHostAddress::SpecialAddress, const QHostAddress&)", typeof(bool), typeof(QHostAddress.SpecialAddress), address1, typeof(QHostAddress), address2);
		}
	}
}
