//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	///<remarks> See <see cref="IQFtpSignals"></see> for signals emitted by QFtp
	///</remarks>

	[SmokeClass("QFtp")]
	public class QFtp : QObject, IDisposable {
 		protected QFtp(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFtp), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFtp() {
			staticInterceptor = new SmokeInvocation(typeof(QFtp), null);
		}
		public enum State {
			Unconnected = 0,
			HostLookup = 1,
			Connecting = 2,
			Connected = 3,
			LoggedIn = 4,
			Closing = 5,
		}
		public enum Error {
			NoError = 0,
			UnknownError = 1,
			HostNotFound = 2,
			ConnectionRefused = 3,
			NotConnected = 4,
		}
		public enum Command {
			None = 0,
			SetTransferMode = 1,
			SetProxy = 2,
			ConnectToHost = 3,
			Login = 4,
			Close = 5,
			List = 6,
			Cd = 7,
			Get = 8,
			Put = 9,
			Remove = 10,
			Mkdir = 11,
			Rmdir = 12,
			Rename = 13,
			RawCommand = 14,
		}
		public enum TransferMode {
			Active = 0,
			Passive = 1,
		}
		public enum TransferType {
			Binary = 0,
			Ascii = 1,
		}
		public QFtp(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFtp#", "QFtp(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QFtp() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFtp", "QFtp()", typeof(void));
		}
		public int SetProxy(string host, ushort port) {
			return (int) interceptor.Invoke("setProxy$$", "setProxy(const QString&, quint16)", typeof(int), typeof(string), host, typeof(ushort), port);
		}
		public int ConnectToHost(string host, ushort port) {
			return (int) interceptor.Invoke("connectToHost$$", "connectToHost(const QString&, quint16)", typeof(int), typeof(string), host, typeof(ushort), port);
		}
		public int ConnectToHost(string host) {
			return (int) interceptor.Invoke("connectToHost$", "connectToHost(const QString&)", typeof(int), typeof(string), host);
		}
		public int Login(string user, string password) {
			return (int) interceptor.Invoke("login$$", "login(const QString&, const QString&)", typeof(int), typeof(string), user, typeof(string), password);
		}
		public int Login(string user) {
			return (int) interceptor.Invoke("login$", "login(const QString&)", typeof(int), typeof(string), user);
		}
		public int Login() {
			return (int) interceptor.Invoke("login", "login()", typeof(int));
		}
		public int Close() {
			return (int) interceptor.Invoke("close", "close()", typeof(int));
		}
		public int SetTransferMode(QFtp.TransferMode mode) {
			return (int) interceptor.Invoke("setTransferMode$", "setTransferMode(QFtp::TransferMode)", typeof(int), typeof(QFtp.TransferMode), mode);
		}
		public int List(string dir) {
			return (int) interceptor.Invoke("list$", "list(const QString&)", typeof(int), typeof(string), dir);
		}
		public int List() {
			return (int) interceptor.Invoke("list", "list()", typeof(int));
		}
		public int Cd(string dir) {
			return (int) interceptor.Invoke("cd$", "cd(const QString&)", typeof(int), typeof(string), dir);
		}
		public int Get(string file, QIODevice dev, QFtp.TransferType type) {
			return (int) interceptor.Invoke("get$#$", "get(const QString&, QIODevice*, QFtp::TransferType)", typeof(int), typeof(string), file, typeof(QIODevice), dev, typeof(QFtp.TransferType), type);
		}
		public int Get(string file, QIODevice dev) {
			return (int) interceptor.Invoke("get$#", "get(const QString&, QIODevice*)", typeof(int), typeof(string), file, typeof(QIODevice), dev);
		}
		public int Get(string file) {
			return (int) interceptor.Invoke("get$", "get(const QString&)", typeof(int), typeof(string), file);
		}
		public int Put(QByteArray data, string file, QFtp.TransferType type) {
			return (int) interceptor.Invoke("put#$$", "put(const QByteArray&, const QString&, QFtp::TransferType)", typeof(int), typeof(QByteArray), data, typeof(string), file, typeof(QFtp.TransferType), type);
		}
		public int Put(QByteArray data, string file) {
			return (int) interceptor.Invoke("put#$", "put(const QByteArray&, const QString&)", typeof(int), typeof(QByteArray), data, typeof(string), file);
		}
		public int Put(QIODevice dev, string file, QFtp.TransferType type) {
			return (int) interceptor.Invoke("put#$$", "put(QIODevice*, const QString&, QFtp::TransferType)", typeof(int), typeof(QIODevice), dev, typeof(string), file, typeof(QFtp.TransferType), type);
		}
		public int Put(QIODevice dev, string file) {
			return (int) interceptor.Invoke("put#$", "put(QIODevice*, const QString&)", typeof(int), typeof(QIODevice), dev, typeof(string), file);
		}
		public int Remove(string file) {
			return (int) interceptor.Invoke("remove$", "remove(const QString&)", typeof(int), typeof(string), file);
		}
		public int Mkdir(string dir) {
			return (int) interceptor.Invoke("mkdir$", "mkdir(const QString&)", typeof(int), typeof(string), dir);
		}
		public int Rmdir(string dir) {
			return (int) interceptor.Invoke("rmdir$", "rmdir(const QString&)", typeof(int), typeof(string), dir);
		}
		public int Rename(string oldname, string newname) {
			return (int) interceptor.Invoke("rename$$", "rename(const QString&, const QString&)", typeof(int), typeof(string), oldname, typeof(string), newname);
		}
		public int RawCommand(string command) {
			return (int) interceptor.Invoke("rawCommand$", "rawCommand(const QString&)", typeof(int), typeof(string), command);
		}
		public long BytesAvailable() {
			return (long) interceptor.Invoke("bytesAvailable", "bytesAvailable() const", typeof(long));
		}
		public long Read(string data, long maxlen) {
			return (long) interceptor.Invoke("read$$", "read(char*, qint64)", typeof(long), typeof(string), data, typeof(long), maxlen);
		}
		public QByteArray ReadAll() {
			return (QByteArray) interceptor.Invoke("readAll", "readAll()", typeof(QByteArray));
		}
		public int CurrentId() {
			return (int) interceptor.Invoke("currentId", "currentId() const", typeof(int));
		}
		public QIODevice CurrentDevice() {
			return (QIODevice) interceptor.Invoke("currentDevice", "currentDevice() const", typeof(QIODevice));
		}
		public QFtp.Command CurrentCommand() {
			return (QFtp.Command) interceptor.Invoke("currentCommand", "currentCommand() const", typeof(QFtp.Command));
		}
		public bool HasPendingCommands() {
			return (bool) interceptor.Invoke("hasPendingCommands", "hasPendingCommands() const", typeof(bool));
		}
		public void ClearPendingCommands() {
			interceptor.Invoke("clearPendingCommands", "clearPendingCommands()", typeof(void));
		}
		public QFtp.State state() {
			return (QFtp.State) interceptor.Invoke("state", "state() const", typeof(QFtp.State));
		}
		public QFtp.Error error() {
			return (QFtp.Error) interceptor.Invoke("error", "error() const", typeof(QFtp.Error));
		}
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		[Q_SLOT("void abort()")]
		public void Abort() {
			interceptor.Invoke("abort", "abort()", typeof(void));
		}
		~QFtp() {
			interceptor.Invoke("~QFtp", "~QFtp()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QFtp", "~QFtp()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQFtpSignals Emit {
			get { return (IQFtpSignals) Q_EMIT; }
		}
	}

	public interface IQFtpSignals : IQObjectSignals {
		[Q_SIGNAL("void stateChanged(int)")]
		void StateChanged(int arg1);
		[Q_SIGNAL("void listInfo(const QUrlInfo&)")]
		void ListInfo(QUrlInfo arg1);
		[Q_SIGNAL("void readyRead()")]
		void ReadyRead();
		[Q_SIGNAL("void dataTransferProgress(qint64, qint64)")]
		void DataTransferProgress(long arg1, long arg2);
		[Q_SIGNAL("void rawCommandReply(int, const QString&)")]
		void RawCommandReply(int arg1, string arg2);
		[Q_SIGNAL("void commandStarted(int)")]
		void CommandStarted(int arg1);
		[Q_SIGNAL("void commandFinished(int, bool)")]
		void CommandFinished(int arg1, bool arg2);
		[Q_SIGNAL("void done(bool)")]
		void Done(bool arg1);
	}
}
