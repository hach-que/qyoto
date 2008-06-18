//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QDir")]
	public class QDir : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDir(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDir), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDir() {
			staticInterceptor = new SmokeInvocation(typeof(QDir), null);
		}
		public enum Filter {
			Dirs = 0x001,
			Files = 0x002,
			Drives = 0x004,
			NoSymLinks = 0x008,
			AllEntries = Dirs|Files|Drives,
			TypeMask = 0x00f,
			Readable = 0x010,
			Writable = 0x020,
			Executable = 0x040,
			PermissionMask = 0x070,
			Modified = 0x080,
			Hidden = 0x100,
			System = 0x200,
			AccessMask = 0x3F0,
			AllDirs = 0x400,
			CaseSensitive = 0x800,
			NoDotAndDotDot = 0x1000,
			NoFilter = -1,
		}
		public enum SortFlag {
			Name = 0x00,
			Time = 0x01,
			Size = 0x02,
			Unsorted = 0x03,
			SortByMask = 0x03,
			DirsFirst = 0x04,
			Reversed = 0x08,
			IgnoreCase = 0x10,
			DirsLast = 0x20,
			LocaleAware = 0x40,
			Type = 0x80,
			NoSort = -1,
		}
		public QDir(QDir arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDir#", "QDir(const QDir&)", typeof(void), typeof(QDir), arg1);
		}
		public QDir(string path) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDir$", "QDir(const QString&)", typeof(void), typeof(string), path);
		}
		public QDir() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDir", "QDir()", typeof(void));
		}
		public QDir(string path, string nameFilter, uint sort, uint filter) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDir$$$$", "QDir(const QString&, const QString&, QDir::SortFlags, QDir::Filters)", typeof(void), typeof(string), path, typeof(string), nameFilter, typeof(uint), sort, typeof(uint), filter);
		}
		public QDir(string path, string nameFilter, uint sort) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDir$$$", "QDir(const QString&, const QString&, QDir::SortFlags)", typeof(void), typeof(string), path, typeof(string), nameFilter, typeof(uint), sort);
		}
		public QDir(string path, string nameFilter) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDir$$", "QDir(const QString&, const QString&)", typeof(void), typeof(string), path, typeof(string), nameFilter);
		}
		public void SetPath(string path) {
			interceptor.Invoke("setPath$", "setPath(const QString&)", typeof(void), typeof(string), path);
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
		public string DirName() {
			return (string) interceptor.Invoke("dirName", "dirName() const", typeof(string));
		}
		public string FilePath(string fileName) {
			return (string) interceptor.Invoke("filePath$", "filePath(const QString&) const", typeof(string), typeof(string), fileName);
		}
		public string AbsoluteFilePath(string fileName) {
			return (string) interceptor.Invoke("absoluteFilePath$", "absoluteFilePath(const QString&) const", typeof(string), typeof(string), fileName);
		}
		public string RelativeFilePath(string fileName) {
			return (string) interceptor.Invoke("relativeFilePath$", "relativeFilePath(const QString&) const", typeof(string), typeof(string), fileName);
		}
		public bool Cd(string dirName) {
			return (bool) interceptor.Invoke("cd$", "cd(const QString&)", typeof(bool), typeof(string), dirName);
		}
		public bool CdUp() {
			return (bool) interceptor.Invoke("cdUp", "cdUp()", typeof(bool));
		}
		public List<string> NameFilters() {
			return (List<string>) interceptor.Invoke("nameFilters", "nameFilters() const", typeof(List<string>));
		}
		public void SetNameFilters(List<string> nameFilters) {
			interceptor.Invoke("setNameFilters?", "setNameFilters(const QStringList&)", typeof(void), typeof(List<string>), nameFilters);
		}
		public uint filter() {
			return (uint) interceptor.Invoke("filter", "filter() const", typeof(uint));
		}
		public void SetFilter(uint filter) {
			interceptor.Invoke("setFilter$", "setFilter(QDir::Filters)", typeof(void), typeof(uint), filter);
		}
		public uint Sorting() {
			return (uint) interceptor.Invoke("sorting", "sorting() const", typeof(uint));
		}
		public void SetSorting(uint sort) {
			interceptor.Invoke("setSorting$", "setSorting(QDir::SortFlags)", typeof(void), typeof(uint), sort);
		}
		public uint Count() {
			return (uint) interceptor.Invoke("count", "count() const", typeof(uint));
		}
		public List<string> EntryList(uint filters, uint sort) {
			return (List<string>) interceptor.Invoke("entryList$$", "entryList(QDir::Filters, QDir::SortFlags) const", typeof(List<string>), typeof(uint), filters, typeof(uint), sort);
		}
		public List<string> EntryList(uint filters) {
			return (List<string>) interceptor.Invoke("entryList$", "entryList(QDir::Filters) const", typeof(List<string>), typeof(uint), filters);
		}
		public List<string> EntryList() {
			return (List<string>) interceptor.Invoke("entryList", "entryList() const", typeof(List<string>));
		}
		public List<string> EntryList(List<string> nameFilters, uint filters, uint sort) {
			return (List<string>) interceptor.Invoke("entryList?$$", "entryList(const QStringList&, QDir::Filters, QDir::SortFlags) const", typeof(List<string>), typeof(List<string>), nameFilters, typeof(uint), filters, typeof(uint), sort);
		}
		public List<string> EntryList(List<string> nameFilters, uint filters) {
			return (List<string>) interceptor.Invoke("entryList?$", "entryList(const QStringList&, QDir::Filters) const", typeof(List<string>), typeof(List<string>), nameFilters, typeof(uint), filters);
		}
		public List<string> EntryList(List<string> nameFilters) {
			return (List<string>) interceptor.Invoke("entryList?", "entryList(const QStringList&) const", typeof(List<string>), typeof(List<string>), nameFilters);
		}
		public List<QFileInfo> EntryInfoList(uint filters, uint sort) {
			return (List<QFileInfo>) interceptor.Invoke("entryInfoList$$", "entryInfoList(QDir::Filters, QDir::SortFlags) const", typeof(List<QFileInfo>), typeof(uint), filters, typeof(uint), sort);
		}
		public List<QFileInfo> EntryInfoList(uint filters) {
			return (List<QFileInfo>) interceptor.Invoke("entryInfoList$", "entryInfoList(QDir::Filters) const", typeof(List<QFileInfo>), typeof(uint), filters);
		}
		public List<QFileInfo> EntryInfoList() {
			return (List<QFileInfo>) interceptor.Invoke("entryInfoList", "entryInfoList() const", typeof(List<QFileInfo>));
		}
		public List<QFileInfo> EntryInfoList(List<string> nameFilters, uint filters, uint sort) {
			return (List<QFileInfo>) interceptor.Invoke("entryInfoList?$$", "entryInfoList(const QStringList&, QDir::Filters, QDir::SortFlags) const", typeof(List<QFileInfo>), typeof(List<string>), nameFilters, typeof(uint), filters, typeof(uint), sort);
		}
		public List<QFileInfo> EntryInfoList(List<string> nameFilters, uint filters) {
			return (List<QFileInfo>) interceptor.Invoke("entryInfoList?$", "entryInfoList(const QStringList&, QDir::Filters) const", typeof(List<QFileInfo>), typeof(List<string>), nameFilters, typeof(uint), filters);
		}
		public List<QFileInfo> EntryInfoList(List<string> nameFilters) {
			return (List<QFileInfo>) interceptor.Invoke("entryInfoList?", "entryInfoList(const QStringList&) const", typeof(List<QFileInfo>), typeof(List<string>), nameFilters);
		}
		public bool Mkdir(string dirName) {
			return (bool) interceptor.Invoke("mkdir$", "mkdir(const QString&) const", typeof(bool), typeof(string), dirName);
		}
		public bool Rmdir(string dirName) {
			return (bool) interceptor.Invoke("rmdir$", "rmdir(const QString&) const", typeof(bool), typeof(string), dirName);
		}
		public bool Mkpath(string dirPath) {
			return (bool) interceptor.Invoke("mkpath$", "mkpath(const QString&) const", typeof(bool), typeof(string), dirPath);
		}
		public bool Rmpath(string dirPath) {
			return (bool) interceptor.Invoke("rmpath$", "rmpath(const QString&) const", typeof(bool), typeof(string), dirPath);
		}
		public bool IsReadable() {
			return (bool) interceptor.Invoke("isReadable", "isReadable() const", typeof(bool));
		}
		public bool Exists() {
			return (bool) interceptor.Invoke("exists", "exists() const", typeof(bool));
		}
		public bool IsRoot() {
			return (bool) interceptor.Invoke("isRoot", "isRoot() const", typeof(bool));
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
		public override bool Equals(object o) {
			if (!(o is QDir)) { return false; }
			return this == (QDir) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool Remove(string fileName) {
			return (bool) interceptor.Invoke("remove$", "remove(const QString&)", typeof(bool), typeof(string), fileName);
		}
		public bool Rename(string oldName, string newName) {
			return (bool) interceptor.Invoke("rename$$", "rename(const QString&, const QString&)", typeof(bool), typeof(string), oldName, typeof(string), newName);
		}
		public bool Exists(string name) {
			return (bool) interceptor.Invoke("exists$", "exists(const QString&) const", typeof(bool), typeof(string), name);
		}
		public void Refresh() {
			interceptor.Invoke("refresh", "refresh() const", typeof(void));
		}
		~QDir() {
			interceptor.Invoke("~QDir", "~QDir()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDir", "~QDir()", typeof(void));
		}
		public static bool operator==(QDir lhs, QDir dir) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QDir&) const", typeof(bool), typeof(QDir), lhs, typeof(QDir), dir);
		}
		public static bool operator!=(QDir lhs, QDir dir) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QDir&) const", typeof(bool), typeof(QDir), lhs, typeof(QDir), dir);
		}
		public static void AddResourceSearchPath(string path) {
			staticInterceptor.Invoke("addResourceSearchPath$", "addResourceSearchPath(const QString&)", typeof(void), typeof(string), path);
		}
		public static void SetSearchPaths(string prefix, List<string> searchPaths) {
			staticInterceptor.Invoke("setSearchPaths$?", "setSearchPaths(const QString&, const QStringList&)", typeof(void), typeof(string), prefix, typeof(List<string>), searchPaths);
		}
		public static void AddSearchPath(string prefix, string path) {
			staticInterceptor.Invoke("addSearchPath$$", "addSearchPath(const QString&, const QString&)", typeof(void), typeof(string), prefix, typeof(string), path);
		}
		public static List<string> SearchPaths(string prefix) {
			return (List<string>) staticInterceptor.Invoke("searchPaths$", "searchPaths(const QString&)", typeof(List<string>), typeof(string), prefix);
		}
		public static string ToNativeSeparators(string pathName) {
			return (string) staticInterceptor.Invoke("toNativeSeparators$", "toNativeSeparators(const QString&)", typeof(string), typeof(string), pathName);
		}
		public static string FromNativeSeparators(string pathName) {
			return (string) staticInterceptor.Invoke("fromNativeSeparators$", "fromNativeSeparators(const QString&)", typeof(string), typeof(string), pathName);
		}
		public static List<string> NameFiltersFromString(string nameFilter) {
			return (List<string>) staticInterceptor.Invoke("nameFiltersFromString$", "nameFiltersFromString(const QString&)", typeof(List<string>), typeof(string), nameFilter);
		}
		public static bool IsRelativePath(string path) {
			return (bool) staticInterceptor.Invoke("isRelativePath$", "isRelativePath(const QString&)", typeof(bool), typeof(string), path);
		}
		public static bool IsAbsolutePath(string path) {
			return (bool) staticInterceptor.Invoke("isAbsolutePath$", "isAbsolutePath(const QString&)", typeof(bool), typeof(string), path);
		}
		public static List<QFileInfo> Drives() {
			return (List<QFileInfo>) staticInterceptor.Invoke("drives", "drives()", typeof(List<QFileInfo>));
		}
		public static QChar Separator() {
			return (QChar) staticInterceptor.Invoke("separator", "separator()", typeof(QChar));
		}
		public static bool SetCurrent(string path) {
			return (bool) staticInterceptor.Invoke("setCurrent$", "setCurrent(const QString&)", typeof(bool), typeof(string), path);
		}
		public static QDir Current() {
			return (QDir) staticInterceptor.Invoke("current", "current()", typeof(QDir));
		}
		public static string CurrentPath() {
			return (string) staticInterceptor.Invoke("currentPath", "currentPath()", typeof(string));
		}
		public static QDir Home() {
			return (QDir) staticInterceptor.Invoke("home", "home()", typeof(QDir));
		}
		public static string HomePath() {
			return (string) staticInterceptor.Invoke("homePath", "homePath()", typeof(string));
		}
		public static QDir Root() {
			return (QDir) staticInterceptor.Invoke("root", "root()", typeof(QDir));
		}
		public static string RootPath() {
			return (string) staticInterceptor.Invoke("rootPath", "rootPath()", typeof(string));
		}
		public static QDir Temp() {
			return (QDir) staticInterceptor.Invoke("temp", "temp()", typeof(QDir));
		}
		public static string TempPath() {
			return (string) staticInterceptor.Invoke("tempPath", "tempPath()", typeof(string));
		}
		public static bool Match(List<string> filters, string fileName) {
			return (bool) staticInterceptor.Invoke("match?$", "match(const QStringList&, const QString&)", typeof(bool), typeof(List<string>), filters, typeof(string), fileName);
		}
		public static bool Match(string filter, string fileName) {
			return (bool) staticInterceptor.Invoke("match$$", "match(const QString&, const QString&)", typeof(bool), typeof(string), filter, typeof(string), fileName);
		}
		public static string CleanPath(string path) {
			return (string) staticInterceptor.Invoke("cleanPath$", "cleanPath(const QString&)", typeof(string), typeof(string), path);
		}
	}
}
