//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	public interface IQIODevice {
			int OpenMode();
			void SetTextModeEnabled(bool enabled);
			bool IsTextModeEnabled();
			bool IsOpen();
			bool IsReadable();
			bool IsWritable();
			bool IsSequential();
			bool Open(int mode);
			void Close();
			long Pos();
			long Size();
			bool Seek(long pos);
			bool AtEnd();
			bool Reset();
			long BytesAvailable();
			long BytesToWrite();
			long Read(string data, long maxlen);
			QByteArray Read(long maxlen);
			QByteArray ReadAll();
			long ReadLine(string data, long maxlen);
			QByteArray ReadLine(long maxlen);
			QByteArray ReadLine();
			bool CanReadLine();
			long Write(string data, long len);
			long Write(QByteArray data);
			long Peek(string data, long maxlen);
			QByteArray Peek(long maxlen);
			bool WaitForReadyRead(int msecs);
			bool WaitForBytesWritten(int msecs);
			void UngetChar(char c);
			bool PutChar(char c);
			bool GetChar(string c);
			string ErrorString();
	}

	/// See <see cref="IQIODeviceSignals"></see> for signals emitted by QIODevice
	[SmokeClass("QIODevice")]
	public class QIODevice : QObject {
 		protected QIODevice(Type dummy) : base((Type) null) {}
		interface IQIODeviceProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIODevice), this);
			_interceptor = (QIODevice) realProxy.GetTransparentProxy();
		}
		private QIODevice ProxyQIODevice() {
			return (QIODevice) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIODevice() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIODeviceProxy), null);
			_staticInterceptor = (IQIODeviceProxy) realProxy.GetTransparentProxy();
		}
		private static IQIODeviceProxy StaticQIODevice() {
			return (IQIODeviceProxy) _staticInterceptor;
		}

		public enum OpenModeFlag {
			NotOpen = 0x0000,
			ReadOnly = 0x0001,
			WriteOnly = 0x0002,
			ReadWrite = ReadOnly|WriteOnly,
			Append = 0x0004,
			Truncate = 0x0008,
			Text = 0x0010,
			Unbuffered = 0x0020,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QIODevice() : this((Type) null) {
			CreateProxy();
			NewQIODevice();
		}
		[SmokeMethod("QIODevice()")]
		private void NewQIODevice() {
			ProxyQIODevice().NewQIODevice();
		}
		public QIODevice(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQIODevice(parent);
		}
		[SmokeMethod("QIODevice(QObject*)")]
		private void NewQIODevice(QObject parent) {
			ProxyQIODevice().NewQIODevice(parent);
		}
		[SmokeMethod("openMode() const")]
		public int OpenMode() {
			return ProxyQIODevice().OpenMode();
		}
		[SmokeMethod("setTextModeEnabled(bool)")]
		public void SetTextModeEnabled(bool enabled) {
			ProxyQIODevice().SetTextModeEnabled(enabled);
		}
		[SmokeMethod("isTextModeEnabled() const")]
		public bool IsTextModeEnabled() {
			return ProxyQIODevice().IsTextModeEnabled();
		}
		[SmokeMethod("isOpen() const")]
		public bool IsOpen() {
			return ProxyQIODevice().IsOpen();
		}
		[SmokeMethod("isReadable() const")]
		public bool IsReadable() {
			return ProxyQIODevice().IsReadable();
		}
		[SmokeMethod("isWritable() const")]
		public bool IsWritable() {
			return ProxyQIODevice().IsWritable();
		}
		[SmokeMethod("isSequential() const")]
		public virtual bool IsSequential() {
			return ProxyQIODevice().IsSequential();
		}
		[SmokeMethod("open(OpenMode)")]
		public virtual bool Open(int mode) {
			return ProxyQIODevice().Open(mode);
		}
		[SmokeMethod("close()")]
		public virtual void Close() {
			ProxyQIODevice().Close();
		}
		[SmokeMethod("pos() const")]
		public virtual long Pos() {
			return ProxyQIODevice().Pos();
		}
		[SmokeMethod("size() const")]
		public virtual long Size() {
			return ProxyQIODevice().Size();
		}
		[SmokeMethod("seek(qint64)")]
		public virtual bool Seek(long pos) {
			return ProxyQIODevice().Seek(pos);
		}
		[SmokeMethod("atEnd() const")]
		public virtual bool AtEnd() {
			return ProxyQIODevice().AtEnd();
		}
		[SmokeMethod("reset()")]
		public virtual bool Reset() {
			return ProxyQIODevice().Reset();
		}
		[SmokeMethod("bytesAvailable() const")]
		public virtual long BytesAvailable() {
			return ProxyQIODevice().BytesAvailable();
		}
		[SmokeMethod("bytesToWrite() const")]
		public virtual long BytesToWrite() {
			return ProxyQIODevice().BytesToWrite();
		}
		[SmokeMethod("read(char*, qint64)")]
		public long Read(string data, long maxlen) {
			return ProxyQIODevice().Read(data,maxlen);
		}
		[SmokeMethod("read(qint64)")]
		public QByteArray Read(long maxlen) {
			return ProxyQIODevice().Read(maxlen);
		}
		[SmokeMethod("readAll()")]
		public QByteArray ReadAll() {
			return ProxyQIODevice().ReadAll();
		}
		[SmokeMethod("readLine(char*, qint64)")]
		public long ReadLine(string data, long maxlen) {
			return ProxyQIODevice().ReadLine(data,maxlen);
		}
		[SmokeMethod("readLine(qint64)")]
		public QByteArray ReadLine(long maxlen) {
			return ProxyQIODevice().ReadLine(maxlen);
		}
		[SmokeMethod("readLine()")]
		public QByteArray ReadLine() {
			return ProxyQIODevice().ReadLine();
		}
		[SmokeMethod("canReadLine() const")]
		public virtual bool CanReadLine() {
			return ProxyQIODevice().CanReadLine();
		}
		[SmokeMethod("write(const char*, qint64)")]
		public long Write(string data, long len) {
			return ProxyQIODevice().Write(data,len);
		}
		[SmokeMethod("write(const QByteArray&)")]
		public long Write(QByteArray data) {
			return ProxyQIODevice().Write(data);
		}
		[SmokeMethod("peek(char*, qint64)")]
		public long Peek(string data, long maxlen) {
			return ProxyQIODevice().Peek(data,maxlen);
		}
		[SmokeMethod("peek(qint64)")]
		public QByteArray Peek(long maxlen) {
			return ProxyQIODevice().Peek(maxlen);
		}
		[SmokeMethod("waitForReadyRead(int)")]
		public virtual bool WaitForReadyRead(int msecs) {
			return ProxyQIODevice().WaitForReadyRead(msecs);
		}
		[SmokeMethod("waitForBytesWritten(int)")]
		public virtual bool WaitForBytesWritten(int msecs) {
			return ProxyQIODevice().WaitForBytesWritten(msecs);
		}
		[SmokeMethod("ungetChar(char)")]
		public void UngetChar(char c) {
			ProxyQIODevice().UngetChar(c);
		}
		[SmokeMethod("putChar(char)")]
		public bool PutChar(char c) {
			return ProxyQIODevice().PutChar(c);
		}
		[SmokeMethod("getChar(char*)")]
		public bool GetChar(string c) {
			return ProxyQIODevice().GetChar(c);
		}
		[SmokeMethod("errorString() const")]
		public string ErrorString() {
			return ProxyQIODevice().ErrorString();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQIODevice().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQIODevice().Tr(s);
		}
		~QIODevice() {
			DisposeQIODevice();
		}
		public void Dispose() {
			DisposeQIODevice();
		}
		[SmokeMethod("~QIODevice()")]
		private void DisposeQIODevice() {
			ProxyQIODevice().DisposeQIODevice();
		}
		protected new IQIODeviceSignals Emit {
			get {
				return (IQIODeviceSignals) Q_EMIT;
			}
		}
	}

	public interface IQIODeviceSignals : IQObjectSignals {
		[Q_SIGNAL("void readyRead()")]
		void ReadyRead();
		[Q_SIGNAL("void bytesWritten(qint64)")]
		void BytesWritten(long bytes);
		[Q_SIGNAL("void aboutToClose()")]
		void AboutToClose();
	}
}
