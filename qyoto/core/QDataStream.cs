//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDataStream")]
	public class QDataStream : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QDataStream(Type dummy) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDataStream), this);
			_interceptor = (QDataStream) realProxy.GetTransparentProxy();
		}
		private QDataStream ProxyQDataStream() {
			return (QDataStream) _interceptor;
		}
		public enum Version {
			Qt_1_0 = 1,
			Qt_2_0 = 2,
			Qt_2_1 = 3,
			Qt_3_0 = 4,
			Qt_3_1 = 5,
			Qt_3_3 = 6,
			Qt_4_0 = 7,
			Qt_4_1 = Qt_4_0,
			Qt_4_2 = 8,
		}
		public enum Status {
			Ok = 0,
			ReadPastEnd = 1,
			ReadCorruptData = 2,
		}
		// QDataStream& operator>>(qint8& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint8& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(qint16& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint16& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint32& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(qint64& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint64& arg1); >>>> NOT CONVERTED
		// QDataStream& operator<<(qint8 arg1); >>>> NOT CONVERTED
		// QDataStream& operator<<(quint8 arg1); >>>> NOT CONVERTED
		public QDataStream() : this((Type) null) {
			CreateProxy();
			NewQDataStream();
		}
		[SmokeMethod("QDataStream", "()", "")]
		private void NewQDataStream() {
			ProxyQDataStream().NewQDataStream();
		}
		public QDataStream(QIODevice arg1) : this((Type) null) {
			CreateProxy();
			NewQDataStream(arg1);
		}
		[SmokeMethod("QDataStream", "(QIODevice*)", "#")]
		private void NewQDataStream(QIODevice arg1) {
			ProxyQDataStream().NewQDataStream(arg1);
		}
		public QDataStream(QByteArray arg1, int flags) : this((Type) null) {
			CreateProxy();
			NewQDataStream(arg1,flags);
		}
		[SmokeMethod("QDataStream", "(QByteArray*, QIODevice::OpenMode)", "#$")]
		private void NewQDataStream(QByteArray arg1, int flags) {
			ProxyQDataStream().NewQDataStream(arg1,flags);
		}
		public QDataStream(QByteArray arg1) : this((Type) null) {
			CreateProxy();
			NewQDataStream(arg1);
		}
		[SmokeMethod("QDataStream", "(const QByteArray&)", "#")]
		private void NewQDataStream(QByteArray arg1) {
			ProxyQDataStream().NewQDataStream(arg1);
		}
		[SmokeMethod("device", "() const", "")]
		public QIODevice Device() {
			return ProxyQDataStream().Device();
		}
		[SmokeMethod("setDevice", "(QIODevice*)", "#")]
		public void SetDevice(QIODevice arg1) {
			ProxyQDataStream().SetDevice(arg1);
		}
		[SmokeMethod("unsetDevice", "()", "")]
		public void UnsetDevice() {
			ProxyQDataStream().UnsetDevice();
		}
		[SmokeMethod("atEnd", "() const", "")]
		public bool AtEnd() {
			return ProxyQDataStream().AtEnd();
		}
		[SmokeMethod("status", "() const", "")]
		public QDataStream.Status status() {
			return ProxyQDataStream().status();
		}
		[SmokeMethod("setStatus", "(QDataStream::Status)", "$")]
		public void SetStatus(QDataStream.Status status) {
			ProxyQDataStream().SetStatus(status);
		}
		[SmokeMethod("resetStatus", "()", "")]
		public void ResetStatus() {
			ProxyQDataStream().ResetStatus();
		}
		[SmokeMethod("version", "() const", "")]
		public int version() {
			return ProxyQDataStream().version();
		}
		[SmokeMethod("setVersion", "(int)", "$")]
		public void SetVersion(int arg1) {
			ProxyQDataStream().SetVersion(arg1);
		}
		[SmokeMethod("operator>>", "(qint32&)", "$")]
		public QDataStream Read(int i) {
			return ProxyQDataStream().Read(i);
		}
		[SmokeMethod("operator>>", "(bool&)", "$")]
		public QDataStream Read(bool i) {
			return ProxyQDataStream().Read(i);
		}
		[SmokeMethod("operator>>", "(float&)", "$")]
		public QDataStream Read(float f) {
			return ProxyQDataStream().Read(f);
		}
		[SmokeMethod("operator>>", "(double&)", "$")]
		public QDataStream Read(double f) {
			return ProxyQDataStream().Read(f);
		}
		[SmokeMethod("operator>>", "(char*&)", "?")]
		public QDataStream Read(string str) {
			return ProxyQDataStream().Read(str);
		}
		[SmokeMethod("operator<<", "(qint16)", "$")]
		public QDataStream Write(short i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(quint16)", "$")]
		public QDataStream Write(ushort i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(qint32)", "$")]
		public QDataStream Write(int i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(quint32)", "$")]
		public QDataStream Write(uint i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(qint64)", "$")]
		public QDataStream Write(long i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(quint64)", "$")]
		public QDataStream Write(ulong i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(bool)", "$")]
		public QDataStream Write(bool i) {
			return ProxyQDataStream().Write(i);
		}
		[SmokeMethod("operator<<", "(float)", "$")]
		public QDataStream Write(float f) {
			return ProxyQDataStream().Write(f);
		}
		[SmokeMethod("operator<<", "(double)", "$")]
		public QDataStream Write(double f) {
			return ProxyQDataStream().Write(f);
		}
		[SmokeMethod("operator<<", "(const char*)", "$")]
		public QDataStream Write(string str) {
			return ProxyQDataStream().Write(str);
		}
		[SmokeMethod("readBytes", "(char*&, uint&)", "?$")]
		public QDataStream ReadBytes(string arg1, uint len) {
			return ProxyQDataStream().ReadBytes(arg1,len);
		}
		[SmokeMethod("readRawData", "(char*, int)", "$$")]
		public int ReadRawData(string arg1, int len) {
			return ProxyQDataStream().ReadRawData(arg1,len);
		}
		[SmokeMethod("writeBytes", "(const char*, uint)", "$$")]
		public QDataStream WriteBytes(string arg1, uint len) {
			return ProxyQDataStream().WriteBytes(arg1,len);
		}
		[SmokeMethod("writeRawData", "(const char*, int)", "$$")]
		public int WriteRawData(string arg1, int len) {
			return ProxyQDataStream().WriteRawData(arg1,len);
		}
		[SmokeMethod("skipRawData", "(int)", "$")]
		public int SkipRawData(int len) {
			return ProxyQDataStream().SkipRawData(len);
		}
		~QDataStream() {
			DisposeQDataStream();
		}
		public void Dispose() {
			DisposeQDataStream();
		}
		[SmokeMethod("~QDataStream", "()", "")]
		private void DisposeQDataStream() {
			ProxyQDataStream().DisposeQDataStream();
		}
	}
}
