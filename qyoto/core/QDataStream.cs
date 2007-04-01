//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDataStream")]
	public class QDataStream : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDataStream(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDataStream), "QDataStream", this);
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
			interceptor.Invoke("QDataStream", "QDataStream()", typeof(void));
		}
		public QDataStream(QIODevice arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDataStream#", "QDataStream(QIODevice*)", typeof(void), typeof(QIODevice), arg1);
		}
		public QDataStream(QByteArray arg1, int flags) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDataStream#$", "QDataStream(QByteArray*, QIODevice::OpenMode)", typeof(void), typeof(QByteArray), arg1, typeof(int), flags);
		}
		public QDataStream(QByteArray arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDataStream#", "QDataStream(const QByteArray&)", typeof(void), typeof(QByteArray), arg1);
		}
		public QIODevice Device() {
			return (QIODevice) interceptor.Invoke("device", "device() const", typeof(QIODevice));
		}
		public void SetDevice(QIODevice arg1) {
			interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), arg1);
		}
		public void UnsetDevice() {
			interceptor.Invoke("unsetDevice", "unsetDevice()", typeof(void));
		}
		public bool AtEnd() {
			return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
		}
		public QDataStream.Status status() {
			return (QDataStream.Status) interceptor.Invoke("status", "status() const", typeof(QDataStream.Status));
		}
		public void SetStatus(QDataStream.Status status) {
			interceptor.Invoke("setStatus$", "setStatus(QDataStream::Status)", typeof(void), typeof(QDataStream.Status), status);
		}
		public void ResetStatus() {
			interceptor.Invoke("resetStatus", "resetStatus()", typeof(void));
		}
		public int version() {
			return (int) interceptor.Invoke("version", "version() const", typeof(int));
		}
		public void SetVersion(int arg1) {
			interceptor.Invoke("setVersion$", "setVersion(int)", typeof(void), typeof(int), arg1);
		}
		public QDataStream Read(int i) {
			return (QDataStream) interceptor.Invoke("operator>>$", "operator>>(qint32&)", typeof(QDataStream), typeof(int), i);
		}
		public QDataStream Read(bool i) {
			return (QDataStream) interceptor.Invoke("operator>>$", "operator>>(bool&)", typeof(QDataStream), typeof(bool), i);
		}
		public QDataStream Read(float f) {
			return (QDataStream) interceptor.Invoke("operator>>$", "operator>>(float&)", typeof(QDataStream), typeof(float), f);
		}
		public QDataStream Read(double f) {
			return (QDataStream) interceptor.Invoke("operator>>$", "operator>>(double&)", typeof(QDataStream), typeof(double), f);
		}
		public QDataStream Read(string str) {
			return (QDataStream) interceptor.Invoke("operator>>?", "operator>>(char*&)", typeof(QDataStream), typeof(string), str);
		}
		public QDataStream Write(short i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(qint16)", typeof(QDataStream), typeof(short), i);
		}
		public QDataStream Write(ushort i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(quint16)", typeof(QDataStream), typeof(ushort), i);
		}
		public QDataStream Write(int i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(qint32)", typeof(QDataStream), typeof(int), i);
		}
		public QDataStream Write(uint i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(quint32)", typeof(QDataStream), typeof(uint), i);
		}
		public QDataStream Write(long i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(qint64)", typeof(QDataStream), typeof(long), i);
		}
		public QDataStream Write(ulong i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(quint64)", typeof(QDataStream), typeof(ulong), i);
		}
		public QDataStream Write(bool i) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(bool)", typeof(QDataStream), typeof(bool), i);
		}
		public QDataStream Write(float f) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(float)", typeof(QDataStream), typeof(float), f);
		}
		public QDataStream Write(double f) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(double)", typeof(QDataStream), typeof(double), f);
		}
		public QDataStream Write(string str) {
			return (QDataStream) interceptor.Invoke("operator<<$", "operator<<(const char*)", typeof(QDataStream), typeof(string), str);
		}
		public QDataStream ReadBytes(string arg1, uint len) {
			return (QDataStream) interceptor.Invoke("readBytes?$", "readBytes(char*&, uint&)", typeof(QDataStream), typeof(string), arg1, typeof(uint), len);
		}
		public int ReadRawData(string arg1, int len) {
			return (int) interceptor.Invoke("readRawData$$", "readRawData(char*, int)", typeof(int), typeof(string), arg1, typeof(int), len);
		}
		public QDataStream WriteBytes(string arg1, uint len) {
			return (QDataStream) interceptor.Invoke("writeBytes$$", "writeBytes(const char*, uint)", typeof(QDataStream), typeof(string), arg1, typeof(uint), len);
		}
		public int WriteRawData(string arg1, int len) {
			return (int) interceptor.Invoke("writeRawData$$", "writeRawData(const char*, int)", typeof(int), typeof(string), arg1, typeof(int), len);
		}
		public int SkipRawData(int len) {
			return (int) interceptor.Invoke("skipRawData$", "skipRawData(int)", typeof(int), typeof(int), len);
		}
		~QDataStream() {
			interceptor.Invoke("~QDataStream", "~QDataStream()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDataStream", "~QDataStream()", typeof(void));
		}
	}
}
