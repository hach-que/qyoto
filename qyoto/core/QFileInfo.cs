//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFileInfo")]
	public class QFileInfo : MarshalByRefObject, IDisposable {
		protected QFileInfo interceptor = null;
		private IntPtr smokeObject;
		protected QFileInfo(Type dummy) {}
		[SmokeClass("QFileInfo")]
		interface IQFileInfoProxy {
			[SmokeMethod("operator==", "(const QFileInfo&)", "#")]
			bool op_equals(QFileInfo lhs, QFileInfo fileinfo);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileInfo), this);
			interceptor = (QFileInfo) realProxy.GetTransparentProxy();
		}
		private static IQFileInfoProxy staticInterceptor = null;
		static QFileInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileInfoProxy), null);
			staticInterceptor = (IQFileInfoProxy) realProxy.GetTransparentProxy();
		}
		public QFileInfo() : this((Type) null) {
			CreateProxy();
			NewQFileInfo();
		}
		[SmokeMethod("QFileInfo", "()", "")]
		private void NewQFileInfo() {
			((QFileInfo) interceptor).NewQFileInfo();
		}
		public QFileInfo(string file) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(file);
		}
		[SmokeMethod("QFileInfo", "(const QString&)", "$")]
		private void NewQFileInfo(string file) {
			((QFileInfo) interceptor).NewQFileInfo(file);
		}
		public QFileInfo(QFile file) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(file);
		}
		[SmokeMethod("QFileInfo", "(const QFile&)", "#")]
		private void NewQFileInfo(QFile file) {
			((QFileInfo) interceptor).NewQFileInfo(file);
		}
		public QFileInfo(QDir dir, string file) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(dir,file);
		}
		[SmokeMethod("QFileInfo", "(const QDir&, const QString&)", "#$")]
		private void NewQFileInfo(QDir dir, string file) {
			((QFileInfo) interceptor).NewQFileInfo(dir,file);
		}
		public QFileInfo(QFileInfo fileinfo) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(fileinfo);
		}
		[SmokeMethod("QFileInfo", "(const QFileInfo&)", "#")]
		private void NewQFileInfo(QFileInfo fileinfo) {
			((QFileInfo) interceptor).NewQFileInfo(fileinfo);
		}
		public override bool Equals(object o) {
			if (!(o is QFileInfo)) { return false; }
			return this == (QFileInfo) o;
		}
		public override int GetHashCode() {
			return ((QFileInfo) interceptor).GetHashCode();
		}
		[SmokeMethod("setFile", "(const QString&)", "$")]
		public void SetFile(string file) {
			((QFileInfo) interceptor).SetFile(file);
		}
		[SmokeMethod("setFile", "(const QFile&)", "#")]
		public void SetFile(QFile file) {
			((QFileInfo) interceptor).SetFile(file);
		}
		[SmokeMethod("setFile", "(const QDir&, const QString&)", "#$")]
		public void SetFile(QDir dir, string file) {
			((QFileInfo) interceptor).SetFile(dir,file);
		}
		[SmokeMethod("exists", "() const", "")]
		public bool Exists() {
			return ((QFileInfo) interceptor).Exists();
		}
		[SmokeMethod("refresh", "()", "")]
		public void Refresh() {
			((QFileInfo) interceptor).Refresh();
		}
		[SmokeMethod("filePath", "() const", "")]
		public string FilePath() {
			return ((QFileInfo) interceptor).FilePath();
		}
		[SmokeMethod("absoluteFilePath", "() const", "")]
		public string AbsoluteFilePath() {
			return ((QFileInfo) interceptor).AbsoluteFilePath();
		}
		[SmokeMethod("canonicalFilePath", "() const", "")]
		public string CanonicalFilePath() {
			return ((QFileInfo) interceptor).CanonicalFilePath();
		}
		[SmokeMethod("fileName", "() const", "")]
		public string FileName() {
			return ((QFileInfo) interceptor).FileName();
		}
		[SmokeMethod("baseName", "() const", "")]
		public string BaseName() {
			return ((QFileInfo) interceptor).BaseName();
		}
		[SmokeMethod("completeBaseName", "() const", "")]
		public string CompleteBaseName() {
			return ((QFileInfo) interceptor).CompleteBaseName();
		}
		[SmokeMethod("suffix", "() const", "")]
		public string Suffix() {
			return ((QFileInfo) interceptor).Suffix();
		}
		[SmokeMethod("completeSuffix", "() const", "")]
		public string CompleteSuffix() {
			return ((QFileInfo) interceptor).CompleteSuffix();
		}
		[SmokeMethod("path", "() const", "")]
		public string Path() {
			return ((QFileInfo) interceptor).Path();
		}
		[SmokeMethod("absolutePath", "() const", "")]
		public string AbsolutePath() {
			return ((QFileInfo) interceptor).AbsolutePath();
		}
		[SmokeMethod("canonicalPath", "() const", "")]
		public string CanonicalPath() {
			return ((QFileInfo) interceptor).CanonicalPath();
		}
		[SmokeMethod("dir", "() const", "")]
		public QDir Dir() {
			return ((QFileInfo) interceptor).Dir();
		}
		[SmokeMethod("absoluteDir", "() const", "")]
		public QDir AbsoluteDir() {
			return ((QFileInfo) interceptor).AbsoluteDir();
		}
		[SmokeMethod("isReadable", "() const", "")]
		public bool IsReadable() {
			return ((QFileInfo) interceptor).IsReadable();
		}
		[SmokeMethod("isWritable", "() const", "")]
		public bool IsWritable() {
			return ((QFileInfo) interceptor).IsWritable();
		}
		[SmokeMethod("isExecutable", "() const", "")]
		public bool IsExecutable() {
			return ((QFileInfo) interceptor).IsExecutable();
		}
		[SmokeMethod("isHidden", "() const", "")]
		public bool IsHidden() {
			return ((QFileInfo) interceptor).IsHidden();
		}
		[SmokeMethod("isRelative", "() const", "")]
		public bool IsRelative() {
			return ((QFileInfo) interceptor).IsRelative();
		}
		[SmokeMethod("isAbsolute", "() const", "")]
		public bool IsAbsolute() {
			return ((QFileInfo) interceptor).IsAbsolute();
		}
		[SmokeMethod("makeAbsolute", "()", "")]
		public bool MakeAbsolute() {
			return ((QFileInfo) interceptor).MakeAbsolute();
		}
		[SmokeMethod("isFile", "() const", "")]
		public bool IsFile() {
			return ((QFileInfo) interceptor).IsFile();
		}
		[SmokeMethod("isDir", "() const", "")]
		public bool IsDir() {
			return ((QFileInfo) interceptor).IsDir();
		}
		[SmokeMethod("isSymLink", "() const", "")]
		public bool IsSymLink() {
			return ((QFileInfo) interceptor).IsSymLink();
		}
		[SmokeMethod("isRoot", "() const", "")]
		public bool IsRoot() {
			return ((QFileInfo) interceptor).IsRoot();
		}
		[SmokeMethod("readLink", "() const", "")]
		public string ReadLink() {
			return ((QFileInfo) interceptor).ReadLink();
		}
		[SmokeMethod("symLinkTarget", "() const", "")]
		public string SymLinkTarget() {
			return ((QFileInfo) interceptor).SymLinkTarget();
		}
		[SmokeMethod("owner", "() const", "")]
		public string Owner() {
			return ((QFileInfo) interceptor).Owner();
		}
		[SmokeMethod("ownerId", "() const", "")]
		public uint OwnerId() {
			return ((QFileInfo) interceptor).OwnerId();
		}
		[SmokeMethod("group", "() const", "")]
		public string Group() {
			return ((QFileInfo) interceptor).Group();
		}
		[SmokeMethod("groupId", "() const", "")]
		public uint GroupId() {
			return ((QFileInfo) interceptor).GroupId();
		}
		[SmokeMethod("permission", "(QFile::Permissions) const", "$")]
		public bool Permission(int permissions) {
			return ((QFileInfo) interceptor).Permission(permissions);
		}
		[SmokeMethod("permissions", "() const", "")]
		public int Permissions() {
			return ((QFileInfo) interceptor).Permissions();
		}
		[SmokeMethod("size", "() const", "")]
		public long Size() {
			return ((QFileInfo) interceptor).Size();
		}
		[SmokeMethod("created", "() const", "")]
		public QDateTime Created() {
			return ((QFileInfo) interceptor).Created();
		}
		[SmokeMethod("lastModified", "() const", "")]
		public QDateTime LastModified() {
			return ((QFileInfo) interceptor).LastModified();
		}
		[SmokeMethod("lastRead", "() const", "")]
		public QDateTime LastRead() {
			return ((QFileInfo) interceptor).LastRead();
		}
		[SmokeMethod("detach", "()", "")]
		public void Detach() {
			((QFileInfo) interceptor).Detach();
		}
		[SmokeMethod("caching", "() const", "")]
		public bool Caching() {
			return ((QFileInfo) interceptor).Caching();
		}
		[SmokeMethod("setCaching", "(bool)", "$")]
		public void SetCaching(bool on) {
			((QFileInfo) interceptor).SetCaching(on);
		}
		~QFileInfo() {
			DisposeQFileInfo();
		}
		public void Dispose() {
			DisposeQFileInfo();
		}
		[SmokeMethod("~QFileInfo", "()", "")]
		private void DisposeQFileInfo() {
			((QFileInfo) interceptor).DisposeQFileInfo();
		}
		public static bool operator==(QFileInfo lhs, QFileInfo fileinfo) {
			return staticInterceptor.op_equals(lhs,fileinfo);
		}
		public static bool operator!=(QFileInfo lhs, QFileInfo fileinfo) {
			return !staticInterceptor.op_equals(lhs,fileinfo);
		}
	}
}
