//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFile")]
	public class QFile : QIODevice, IDisposable {
 		protected QFile(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFile), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFile() {
			staticInterceptor = new SmokeInvocation(typeof(QFile), null);
		}
		public enum FileError {
			NoError = 0,
			ReadError = 1,
			WriteError = 2,
			FatalError = 3,
			ResourceError = 4,
			OpenError = 5,
			AbortError = 6,
			TimeOutError = 7,
			UnspecifiedError = 8,
			RemoveError = 9,
			RenameError = 10,
			PositionError = 11,
			ResizeError = 12,
			PermissionsError = 13,
			CopyError = 14,
		}
		public enum Permission {
			ReadOwner = 0x4000,
			WriteOwner = 0x2000,
			ExeOwner = 0x1000,
			ReadUser = 0x0400,
			WriteUser = 0x0200,
			ExeUser = 0x0100,
			ReadGroup = 0x0040,
			WriteGroup = 0x0020,
			ExeGroup = 0x0010,
			ReadOther = 0x0004,
			WriteOther = 0x0002,
			ExeOther = 0x0001,
		}
		public QFile() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFile", "QFile()", typeof(void));
		}
		public QFile(string name) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFile$", "QFile(const QString&)", typeof(void), typeof(string), name);
		}
		public QFile(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFile#", "QFile(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QFile(string name, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFile$#", "QFile(const QString&, QObject*)", typeof(void), typeof(string), name, typeof(QObject), parent);
		}
		public QFile.FileError Error() {
			return (QFile.FileError) interceptor.Invoke("error", "error() const", typeof(QFile.FileError));
		}
		public void UnsetError() {
			interceptor.Invoke("unsetError", "unsetError()", typeof(void));
		}
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		public void SetFileName(string name) {
			interceptor.Invoke("setFileName$", "setFileName(const QString&)", typeof(void), typeof(string), name);
		}
		public bool Exists() {
			return (bool) interceptor.Invoke("exists", "exists() const", typeof(bool));
		}
		public string ReadLink() {
			return (string) interceptor.Invoke("readLink", "readLink() const", typeof(string));
		}
		public string SymLinkTarget() {
			return (string) interceptor.Invoke("symLinkTarget", "symLinkTarget() const", typeof(string));
		}
		public bool Remove() {
			return (bool) interceptor.Invoke("remove", "remove()", typeof(bool));
		}
		public bool Rename(string newName) {
			return (bool) interceptor.Invoke("rename$", "rename(const QString&)", typeof(bool), typeof(string), newName);
		}
		public bool Link(string newName) {
			return (bool) interceptor.Invoke("link$", "link(const QString&)", typeof(bool), typeof(string), newName);
		}
		public bool Copy(string newName) {
			return (bool) interceptor.Invoke("copy$", "copy(const QString&)", typeof(bool), typeof(string), newName);
		}
		[SmokeMethod("isSequential() const")]
		public override bool IsSequential() {
			return (bool) interceptor.Invoke("isSequential", "isSequential() const", typeof(bool));
		}
		[SmokeMethod("open(OpenMode)")]
		public override bool Open(int flags) {
			return (bool) interceptor.Invoke("open$", "open(OpenMode)", typeof(bool), typeof(int), flags);
		}
		public bool Open(int fd, int flags) {
			return (bool) interceptor.Invoke("open$$", "open(int, OpenMode)", typeof(bool), typeof(int), fd, typeof(int), flags);
		}
		[SmokeMethod("close()")]
		public override void Close() {
			interceptor.Invoke("close", "close()", typeof(void));
		}
		[SmokeMethod("size() const")]
		public override long Size() {
			return (long) interceptor.Invoke("size", "size() const", typeof(long));
		}
		[SmokeMethod("pos() const")]
		public override long Pos() {
			return (long) interceptor.Invoke("pos", "pos() const", typeof(long));
		}
		[SmokeMethod("seek(qint64)")]
		public override bool Seek(long offset) {
			return (bool) interceptor.Invoke("seek$", "seek(qint64)", typeof(bool), typeof(long), offset);
		}
		[SmokeMethod("atEnd() const")]
		public override bool AtEnd() {
			return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
		}
		public bool Flush() {
			return (bool) interceptor.Invoke("flush", "flush()", typeof(bool));
		}
		public bool Resize(long sz) {
			return (bool) interceptor.Invoke("resize$", "resize(qint64)", typeof(bool), typeof(long), sz);
		}
		public int Permissions() {
			return (int) interceptor.Invoke("permissions", "permissions() const", typeof(int));
		}
		public bool SetPermissions(int permissionSpec) {
			return (bool) interceptor.Invoke("setPermissions$", "setPermissions(Permissions)", typeof(bool), typeof(int), permissionSpec);
		}
		[SmokeMethod("fileEngine() const")]
		public virtual QAbstractFileEngine FileEngine() {
			return (QAbstractFileEngine) interceptor.Invoke("fileEngine", "fileEngine() const", typeof(QAbstractFileEngine));
		}
		[SmokeMethod("readData(char*, qint64)")]
		protected override long ReadData(string data, long maxlen) {
			return (long) interceptor.Invoke("readData$$", "readData(char*, qint64)", typeof(long), typeof(string), data, typeof(long), maxlen);
		}
		[SmokeMethod("writeData(const char*, qint64)")]
		protected override long WriteData(string data, long len) {
			return (long) interceptor.Invoke("writeData$$", "writeData(const char*, qint64)", typeof(long), typeof(string), data, typeof(long), len);
		}
		[SmokeMethod("readLineData(char*, qint64)")]
		protected override long ReadLineData(string data, long maxlen) {
			return (long) interceptor.Invoke("readLineData$$", "readLineData(char*, qint64)", typeof(long), typeof(string), data, typeof(long), maxlen);
		}
		~QFile() {
			interceptor.Invoke("~QFile", "~QFile()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QFile", "~QFile()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static QByteArray EncodeName(string fileName) {
			return (QByteArray) staticInterceptor.Invoke("encodeName$", "encodeName(const QString&)", typeof(QByteArray), typeof(string), fileName);
		}
		public static string DecodeName(QByteArray localFileName) {
			return (string) staticInterceptor.Invoke("decodeName#", "decodeName(const QByteArray&)", typeof(string), typeof(QByteArray), localFileName);
		}
		public static string DecodeName(string localFileName) {
			return (string) staticInterceptor.Invoke("decodeName$", "decodeName(const char*)", typeof(string), typeof(string), localFileName);
		}
		public static bool Exists(string fileName) {
			return (bool) staticInterceptor.Invoke("exists$", "exists(const QString&)", typeof(bool), typeof(string), fileName);
		}
		public static string ReadLink(string fileName) {
			return (string) staticInterceptor.Invoke("readLink$", "readLink(const QString&)", typeof(string), typeof(string), fileName);
		}
		public static string SymLinkTarget(string fileName) {
			return (string) staticInterceptor.Invoke("symLinkTarget$", "symLinkTarget(const QString&)", typeof(string), typeof(string), fileName);
		}
		public static bool Remove(string fileName) {
			return (bool) staticInterceptor.Invoke("remove$", "remove(const QString&)", typeof(bool), typeof(string), fileName);
		}
		public static bool Rename(string oldName, string newName) {
			return (bool) staticInterceptor.Invoke("rename$$", "rename(const QString&, const QString&)", typeof(bool), typeof(string), oldName, typeof(string), newName);
		}
		public static bool Link(string oldname, string newName) {
			return (bool) staticInterceptor.Invoke("link$$", "link(const QString&, const QString&)", typeof(bool), typeof(string), oldname, typeof(string), newName);
		}
		public static bool Copy(string fileName, string newName) {
			return (bool) staticInterceptor.Invoke("copy$$", "copy(const QString&, const QString&)", typeof(bool), typeof(string), fileName, typeof(string), newName);
		}
		public static bool Resize(string filename, long sz) {
			return (bool) staticInterceptor.Invoke("resize$$", "resize(const QString&, qint64)", typeof(bool), typeof(string), filename, typeof(long), sz);
		}
		public static int Permissions(string filename) {
			return (int) staticInterceptor.Invoke("permissions$", "permissions(const QString&)", typeof(int), typeof(string), filename);
		}
		public static bool SetPermissions(string filename, int permissionSpec) {
			return (bool) staticInterceptor.Invoke("setPermissions$$", "setPermissions(const QString&, Permissions)", typeof(bool), typeof(string), filename, typeof(int), permissionSpec);
		}
		protected new IQFileSignals Emit {
			get { return (IQFileSignals) Q_EMIT; }
		}
	}

	public interface IQFileSignals : IQIODeviceSignals {
	}
}
