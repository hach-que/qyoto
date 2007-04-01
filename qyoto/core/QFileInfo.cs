//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFileInfo")]
	public class QFileInfo : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QFileInfo(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFileInfo), "QFileInfo", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFileInfo() {
			staticInterceptor = new SmokeInvocation(typeof(QFileInfo), "QFileInfo", null);
		}
		public QFileInfo() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileInfo", "QFileInfo()", typeof(void));
		}
		public QFileInfo(string file) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileInfo$", "QFileInfo(const QString&)", typeof(void), typeof(string), file);
		}
		public QFileInfo(QFile file) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileInfo#", "QFileInfo(const QFile&)", typeof(void), typeof(QFile), file);
		}
		public QFileInfo(QDir dir, string file) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileInfo#$", "QFileInfo(const QDir&, const QString&)", typeof(void), typeof(QDir), dir, typeof(string), file);
		}
		public QFileInfo(QFileInfo fileinfo) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileInfo#", "QFileInfo(const QFileInfo&)", typeof(void), typeof(QFileInfo), fileinfo);
		}
		public override bool Equals(object o) {
			if (!(o is QFileInfo)) { return false; }
			return this == (QFileInfo) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public void SetFile(string file) {
			interceptor.Invoke("setFile$", "setFile(const QString&)", typeof(void), typeof(string), file);
		}
		public void SetFile(QFile file) {
			interceptor.Invoke("setFile#", "setFile(const QFile&)", typeof(void), typeof(QFile), file);
		}
		public void SetFile(QDir dir, string file) {
			interceptor.Invoke("setFile#$", "setFile(const QDir&, const QString&)", typeof(void), typeof(QDir), dir, typeof(string), file);
		}
		public bool Exists() {
			return (bool) interceptor.Invoke("exists", "exists() const", typeof(bool));
		}
		public void Refresh() {
			interceptor.Invoke("refresh", "refresh()", typeof(void));
		}
		public string FilePath() {
			return (string) interceptor.Invoke("filePath", "filePath() const", typeof(string));
		}
		public string AbsoluteFilePath() {
			return (string) interceptor.Invoke("absoluteFilePath", "absoluteFilePath() const", typeof(string));
		}
		public string CanonicalFilePath() {
			return (string) interceptor.Invoke("canonicalFilePath", "canonicalFilePath() const", typeof(string));
		}
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		public string BaseName() {
			return (string) interceptor.Invoke("baseName", "baseName() const", typeof(string));
		}
		public string CompleteBaseName() {
			return (string) interceptor.Invoke("completeBaseName", "completeBaseName() const", typeof(string));
		}
		public string Suffix() {
			return (string) interceptor.Invoke("suffix", "suffix() const", typeof(string));
		}
		public string CompleteSuffix() {
			return (string) interceptor.Invoke("completeSuffix", "completeSuffix() const", typeof(string));
		}
		public string Path() {
			return (string) interceptor.Invoke("path", "path() const", typeof(string));
		}
		public string AbsolutePath() {
			return (string) interceptor.Invoke("absolutePath", "absolutePath() const", typeof(string));
		}
		public string CanonicalPath() {
			return (string) interceptor.Invoke("canonicalPath", "canonicalPath() const", typeof(string));
		}
		public QDir Dir() {
			return (QDir) interceptor.Invoke("dir", "dir() const", typeof(QDir));
		}
		public QDir AbsoluteDir() {
			return (QDir) interceptor.Invoke("absoluteDir", "absoluteDir() const", typeof(QDir));
		}
		public bool IsReadable() {
			return (bool) interceptor.Invoke("isReadable", "isReadable() const", typeof(bool));
		}
		public bool IsWritable() {
			return (bool) interceptor.Invoke("isWritable", "isWritable() const", typeof(bool));
		}
		public bool IsExecutable() {
			return (bool) interceptor.Invoke("isExecutable", "isExecutable() const", typeof(bool));
		}
		public bool IsHidden() {
			return (bool) interceptor.Invoke("isHidden", "isHidden() const", typeof(bool));
		}
		public bool IsRelative() {
			return (bool) interceptor.Invoke("isRelative", "isRelative() const", typeof(bool));
		}
		public bool IsAbsolute() {
			return (bool) interceptor.Invoke("isAbsolute", "isAbsolute() const", typeof(bool));
		}
		public bool MakeAbsolute() {
			return (bool) interceptor.Invoke("makeAbsolute", "makeAbsolute()", typeof(bool));
		}
		public bool IsFile() {
			return (bool) interceptor.Invoke("isFile", "isFile() const", typeof(bool));
		}
		public bool IsDir() {
			return (bool) interceptor.Invoke("isDir", "isDir() const", typeof(bool));
		}
		public bool IsSymLink() {
			return (bool) interceptor.Invoke("isSymLink", "isSymLink() const", typeof(bool));
		}
		public bool IsRoot() {
			return (bool) interceptor.Invoke("isRoot", "isRoot() const", typeof(bool));
		}
		public string ReadLink() {
			return (string) interceptor.Invoke("readLink", "readLink() const", typeof(string));
		}
		public string SymLinkTarget() {
			return (string) interceptor.Invoke("symLinkTarget", "symLinkTarget() const", typeof(string));
		}
		public string Owner() {
			return (string) interceptor.Invoke("owner", "owner() const", typeof(string));
		}
		public uint OwnerId() {
			return (uint) interceptor.Invoke("ownerId", "ownerId() const", typeof(uint));
		}
		public string Group() {
			return (string) interceptor.Invoke("group", "group() const", typeof(string));
		}
		public uint GroupId() {
			return (uint) interceptor.Invoke("groupId", "groupId() const", typeof(uint));
		}
		public bool Permission(int permissions) {
			return (bool) interceptor.Invoke("permission$", "permission(QFile::Permissions) const", typeof(bool), typeof(int), permissions);
		}
		public int Permissions() {
			return (int) interceptor.Invoke("permissions", "permissions() const", typeof(int));
		}
		public long Size() {
			return (long) interceptor.Invoke("size", "size() const", typeof(long));
		}
		public QDateTime Created() {
			return (QDateTime) interceptor.Invoke("created", "created() const", typeof(QDateTime));
		}
		public QDateTime LastModified() {
			return (QDateTime) interceptor.Invoke("lastModified", "lastModified() const", typeof(QDateTime));
		}
		public QDateTime LastRead() {
			return (QDateTime) interceptor.Invoke("lastRead", "lastRead() const", typeof(QDateTime));
		}
		public void Detach() {
			interceptor.Invoke("detach", "detach()", typeof(void));
		}
		public bool Caching() {
			return (bool) interceptor.Invoke("caching", "caching() const", typeof(bool));
		}
		public void SetCaching(bool on) {
			interceptor.Invoke("setCaching$", "setCaching(bool)", typeof(void), typeof(bool), on);
		}
		~QFileInfo() {
			interceptor.Invoke("~QFileInfo", "~QFileInfo()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QFileInfo", "~QFileInfo()", typeof(void));
		}
		public static bool operator==(QFileInfo lhs, QFileInfo fileinfo) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QFileInfo&)", typeof(bool), typeof(QFileInfo), lhs, typeof(QFileInfo), fileinfo);
		}
		public static bool operator!=(QFileInfo lhs, QFileInfo fileinfo) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QFileInfo&)", typeof(bool), typeof(QFileInfo), lhs, typeof(QFileInfo), fileinfo);
		}
	}
}
