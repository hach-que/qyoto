//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QSslCertificate")]
	public class QSslCertificate : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QSslCertificate(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSslCertificate), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSslCertificate() {
			staticInterceptor = new SmokeInvocation(typeof(QSslCertificate), null);
		}
		public enum SubjectInfo {
			Organization = 0,
			CommonName = 1,
			LocalityName = 2,
			OrganizationalUnitName = 3,
			CountryName = 4,
			StateOrProvinceName = 5,
		}
		// QList<QSslCertificate> fromDevice(QIODevice* arg1); >>>> NOT CONVERTED
		// QList<QSslCertificate> fromData(const QByteArray& arg1); >>>> NOT CONVERTED
		public QSslCertificate(QIODevice device) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslCertificate#", "QSslCertificate(QIODevice*)", typeof(void), typeof(QIODevice), device);
		}
		public QSslCertificate(QByteArray encoded) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslCertificate#", "QSslCertificate(const QByteArray&)", typeof(void), typeof(QByteArray), encoded);
		}
		public QSslCertificate() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslCertificate", "QSslCertificate()", typeof(void));
		}
		public QSslCertificate(QSslCertificate other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslCertificate#", "QSslCertificate(const QSslCertificate&)", typeof(void), typeof(QSslCertificate), other);
		}
		public override bool Equals(object o) {
			if (!(o is QSslCertificate)) { return false; }
			return this == (QSslCertificate) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public QByteArray Version() {
			return (QByteArray) interceptor.Invoke("version", "version() const", typeof(QByteArray));
		}
		public QByteArray SerialNumber() {
			return (QByteArray) interceptor.Invoke("serialNumber", "serialNumber() const", typeof(QByteArray));
		}
		public QByteArray Digest(QCryptographicHash.Algorithm algorithm) {
			return (QByteArray) interceptor.Invoke("digest$", "digest(QCryptographicHash::Algorithm) const", typeof(QByteArray), typeof(QCryptographicHash.Algorithm), algorithm);
		}
		public QByteArray Digest() {
			return (QByteArray) interceptor.Invoke("digest", "digest() const", typeof(QByteArray));
		}
		public string IssuerInfo(QSslCertificate.SubjectInfo info) {
			return (string) interceptor.Invoke("issuerInfo$", "issuerInfo(QSslCertificate::SubjectInfo) const", typeof(string), typeof(QSslCertificate.SubjectInfo), info);
		}
		public string IssuerInfo(QByteArray tag) {
			return (string) interceptor.Invoke("issuerInfo#", "issuerInfo(const QByteArray&) const", typeof(string), typeof(QByteArray), tag);
		}
		public string subjectInfo(QSslCertificate.SubjectInfo info) {
			return (string) interceptor.Invoke("subjectInfo$", "subjectInfo(QSslCertificate::SubjectInfo) const", typeof(string), typeof(QSslCertificate.SubjectInfo), info);
		}
		public string subjectInfo(QByteArray tag) {
			return (string) interceptor.Invoke("subjectInfo#", "subjectInfo(const QByteArray&) const", typeof(string), typeof(QByteArray), tag);
		}
		public List<string> AlternateSubjectNames() {
			return (List<string>) interceptor.Invoke("alternateSubjectNames", "alternateSubjectNames() const", typeof(List<string>));
		}
		public QDateTime NotValidBefore() {
			return (QDateTime) interceptor.Invoke("notValidBefore", "notValidBefore() const", typeof(QDateTime));
		}
		public QDateTime NotValidAfter() {
			return (QDateTime) interceptor.Invoke("notValidAfter", "notValidAfter() const", typeof(QDateTime));
		}
		public QSslKey PublicKey() {
			return (QSslKey) interceptor.Invoke("publicKey", "publicKey() const", typeof(QSslKey));
		}
		public QByteArray ToPem() {
			return (QByteArray) interceptor.Invoke("toPem", "toPem() const", typeof(QByteArray));
		}
		public QByteArray ToDer() {
			return (QByteArray) interceptor.Invoke("toDer", "toDer() const", typeof(QByteArray));
		}
		~QSslCertificate() {
			interceptor.Invoke("~QSslCertificate", "~QSslCertificate()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QSslCertificate", "~QSslCertificate()", typeof(void));
		}
		public static bool operator==(QSslCertificate lhs, QSslCertificate other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QSslCertificate&) const", typeof(bool), typeof(QSslCertificate), lhs, typeof(QSslCertificate), other);
		}
		public static bool operator!=(QSslCertificate lhs, QSslCertificate other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QSslCertificate&) const", typeof(bool), typeof(QSslCertificate), lhs, typeof(QSslCertificate), other);
		}
	}
}
