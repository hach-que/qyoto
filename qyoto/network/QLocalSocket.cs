//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQLocalSocketSignals"></see> for signals emitted by QLocalSocket
    /// </remarks>
    [SmokeClass("QLocalSocket")]
    public class QLocalSocket : QIODevice, IDisposable {
        protected QLocalSocket(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QLocalSocket), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QLocalSocket() {
            staticInterceptor = new SmokeInvocation(typeof(QLocalSocket), null);
        }
        public enum LocalSocketError {
            ConnectionRefusedError = QAbstractSocket.SocketError.ConnectionRefusedError,
            PeerClosedError = QAbstractSocket.SocketError.RemoteHostClosedError,
            ServerNotFoundError = QAbstractSocket.SocketError.HostNotFoundError,
            SocketAccessError = QAbstractSocket.SocketError.SocketAccessError,
            SocketResourceError = QAbstractSocket.SocketError.SocketResourceError,
            SocketTimeoutError = QAbstractSocket.SocketError.SocketTimeoutError,
            DatagramTooLargeError = QAbstractSocket.SocketError.DatagramTooLargeError,
            ConnectionError = QAbstractSocket.SocketError.NetworkError,
            UnsupportedSocketOperationError = QAbstractSocket.SocketError.UnsupportedSocketOperationError,
            UnknownSocketError = QAbstractSocket.SocketError.UnknownSocketError,
        }
        public enum LocalSocketState {
            UnconnectedState = QAbstractSocket.SocketState.UnconnectedState,
            ConnectingState = QAbstractSocket.SocketState.ConnectingState,
            ConnectedState = QAbstractSocket.SocketState.ConnectedState,
            ClosingState = QAbstractSocket.SocketState.ClosingState,
        }
        // bool setSocketDescriptor(QUintForType<void*>::Type arg1,QLocalSocket::LocalSocketState arg2,QIODevice::OpenMode arg3); >>>> NOT CONVERTED
        // bool setSocketDescriptor(QUintForType<void*>::Type arg1,QLocalSocket::LocalSocketState arg2); >>>> NOT CONVERTED
        // bool setSocketDescriptor(QUintForType<void*>::Type arg1); >>>> NOT CONVERTED
        // QUintForType<void*>::Type socketDescriptor(); >>>> NOT CONVERTED
        public QLocalSocket(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLocalSocket#", "QLocalSocket(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QLocalSocket() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLocalSocket", "QLocalSocket()", typeof(void));
        }
        public void ConnectToServer(string name, uint openMode) {
            interceptor.Invoke("connectToServer$$", "connectToServer(const QString&, QIODevice::OpenMode)", typeof(void), typeof(string), name, typeof(uint), openMode);
        }
        public void ConnectToServer(string name) {
            interceptor.Invoke("connectToServer$", "connectToServer(const QString&)", typeof(void), typeof(string), name);
        }
        public void DisconnectFromServer() {
            interceptor.Invoke("disconnectFromServer", "disconnectFromServer()", typeof(void));
        }
        public string ServerName() {
            return (string) interceptor.Invoke("serverName", "serverName() const", typeof(string));
        }
        public string FullServerName() {
            return (string) interceptor.Invoke("fullServerName", "fullServerName() const", typeof(string));
        }
        public void Abort() {
            interceptor.Invoke("abort", "abort()", typeof(void));
        }
        [SmokeMethod("isSequential() const")]
        public override bool IsSequential() {
            return (bool) interceptor.Invoke("isSequential", "isSequential() const", typeof(bool));
        }
        [SmokeMethod("bytesAvailable() const")]
        public override long BytesAvailable() {
            return (long) interceptor.Invoke("bytesAvailable", "bytesAvailable() const", typeof(long));
        }
        [SmokeMethod("bytesToWrite() const")]
        public override long BytesToWrite() {
            return (long) interceptor.Invoke("bytesToWrite", "bytesToWrite() const", typeof(long));
        }
        [SmokeMethod("canReadLine() const")]
        public override bool CanReadLine() {
            return (bool) interceptor.Invoke("canReadLine", "canReadLine() const", typeof(bool));
        }
        [SmokeMethod("close()")]
        public override void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        public QLocalSocket.LocalSocketError Error() {
            return (QLocalSocket.LocalSocketError) interceptor.Invoke("error", "error() const", typeof(QLocalSocket.LocalSocketError));
        }
        public bool Flush() {
            return (bool) interceptor.Invoke("flush", "flush()", typeof(bool));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public long ReadBufferSize() {
            return (long) interceptor.Invoke("readBufferSize", "readBufferSize() const", typeof(long));
        }
        public void SetReadBufferSize(long size) {
            interceptor.Invoke("setReadBufferSize$", "setReadBufferSize(qint64)", typeof(void), typeof(long), size);
        }
        public QLocalSocket.LocalSocketState State() {
            return (QLocalSocket.LocalSocketState) interceptor.Invoke("state", "state() const", typeof(QLocalSocket.LocalSocketState));
        }
        [SmokeMethod("waitForBytesWritten(int)")]
        public override bool WaitForBytesWritten(int msecs) {
            return (bool) interceptor.Invoke("waitForBytesWritten$", "waitForBytesWritten(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForBytesWritten() {
            return (bool) interceptor.Invoke("waitForBytesWritten", "waitForBytesWritten()", typeof(bool));
        }
        public bool WaitForConnected(int msecs) {
            return (bool) interceptor.Invoke("waitForConnected$", "waitForConnected(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForConnected() {
            return (bool) interceptor.Invoke("waitForConnected", "waitForConnected()", typeof(bool));
        }
        public bool WaitForDisconnected(int msecs) {
            return (bool) interceptor.Invoke("waitForDisconnected$", "waitForDisconnected(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForDisconnected() {
            return (bool) interceptor.Invoke("waitForDisconnected", "waitForDisconnected()", typeof(bool));
        }
        [SmokeMethod("waitForReadyRead(int)")]
        public override bool WaitForReadyRead(int msecs) {
            return (bool) interceptor.Invoke("waitForReadyRead$", "waitForReadyRead(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForReadyRead() {
            return (bool) interceptor.Invoke("waitForReadyRead", "waitForReadyRead()", typeof(bool));
        }
        [SmokeMethod("readData(char*, qint64)")]
        protected override long ReadData(Pointer<sbyte> arg1, long arg2) {
            return (long) interceptor.Invoke("readData$$", "readData(char*, qint64)", typeof(long), typeof(Pointer<sbyte>), arg1, typeof(long), arg2);
        }
        [SmokeMethod("writeData(const char*, qint64)")]
        protected override long WriteData(string arg1, long arg2) {
            return (long) interceptor.Invoke("writeData$$", "writeData(const char*, qint64)", typeof(long), typeof(string), arg1, typeof(long), arg2);
        }
        ~QLocalSocket() {
            interceptor.Invoke("~QLocalSocket", "~QLocalSocket()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QLocalSocket", "~QLocalSocket()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQLocalSocketSignals Emit {
            get { return (IQLocalSocketSignals) Q_EMIT; }
        }
    }

    public interface IQLocalSocketSignals : IQIODeviceSignals {
        [Q_SIGNAL("void connected()")]
        void Connected();
        [Q_SIGNAL("void disconnected()")]
        void Disconnected();
        [Q_SIGNAL("void error(QLocalSocket::LocalSocketError)")]
        void Error(QLocalSocket.LocalSocketError socketError);
        [Q_SIGNAL("void stateChanged(QLocalSocket::LocalSocketState)")]
        void StateChanged(QLocalSocket.LocalSocketState socketState);
    }
}
