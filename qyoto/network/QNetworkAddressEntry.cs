//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QNetworkAddressEntry")]
	public class QNetworkAddressEntry : MarshalByRefObject, IDisposable {
		protected QNetworkAddressEntry interceptor = null;
		private IntPtr smokeObject;
		protected QNetworkAddressEntry(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QNetworkAddressEntry), this);
			interceptor = (QNetworkAddressEntry) realProxy.GetTransparentProxy();
		}
		public QNetworkAddressEntry() : this((Type) null) {
			CreateProxy();
			NewQNetworkAddressEntry();
		}
		[SmokeMethod("QNetworkAddressEntry", "()", "")]
		private void NewQNetworkAddressEntry() {
			((QNetworkAddressEntry) interceptor).NewQNetworkAddressEntry();
		}
		public QNetworkAddressEntry(QNetworkAddressEntry other) : this((Type) null) {
			CreateProxy();
			NewQNetworkAddressEntry(other);
		}
		[SmokeMethod("QNetworkAddressEntry", "(const QNetworkAddressEntry&)", "#")]
		private void NewQNetworkAddressEntry(QNetworkAddressEntry other) {
			((QNetworkAddressEntry) interceptor).NewQNetworkAddressEntry(other);
		}
		[SmokeMethod("ip", "() const", "")]
		public QHostAddress Ip() {
			return ((QNetworkAddressEntry) interceptor).Ip();
		}
		[SmokeMethod("setIp", "(const QHostAddress&)", "#")]
		public void SetIp(QHostAddress newIp) {
			((QNetworkAddressEntry) interceptor).SetIp(newIp);
		}
		[SmokeMethod("netmask", "() const", "")]
		public QHostAddress Netmask() {
			return ((QNetworkAddressEntry) interceptor).Netmask();
		}
		[SmokeMethod("setNetmask", "(const QHostAddress&)", "#")]
		public void SetNetmask(QHostAddress newNetmask) {
			((QNetworkAddressEntry) interceptor).SetNetmask(newNetmask);
		}
		[SmokeMethod("broadcast", "() const", "")]
		public QHostAddress Broadcast() {
			return ((QNetworkAddressEntry) interceptor).Broadcast();
		}
		[SmokeMethod("setBroadcast", "(const QHostAddress&)", "#")]
		public void SetBroadcast(QHostAddress newBroadcast) {
			((QNetworkAddressEntry) interceptor).SetBroadcast(newBroadcast);
		}
		~QNetworkAddressEntry() {
			DisposeQNetworkAddressEntry();
		}
		public void Dispose() {
			DisposeQNetworkAddressEntry();
		}
		[SmokeMethod("~QNetworkAddressEntry", "()", "")]
		private void DisposeQNetworkAddressEntry() {
			((QNetworkAddressEntry) interceptor).DisposeQNetworkAddressEntry();
		}
	}
}
