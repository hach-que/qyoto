//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QLibrary")]
    public class QLibrary : QObject, IDisposable {
        protected QLibrary(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QLibrary), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QLibrary() {
            staticInterceptor = new SmokeInvocation(typeof(QLibrary), null);
        }
        public enum LoadHint {
            ResolveAllSymbolsHint = 0x01,
            ExportExternalSymbolsHint = 0x02,
            LoadArchiveMemberHint = 0x04,
        }
        [Q_PROPERTY("QString", "fileName")]
        public string FileName {
            get { return (string) interceptor.Invoke("fileName", "fileName()", typeof(string)); }
            set { interceptor.Invoke("setFileName$", "setFileName(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QLibrary::LoadHints", "loadHints")]
        public uint LoadHints {
            get { return (uint) interceptor.Invoke("loadHints", "loadHints()", typeof(uint)); }
            set { interceptor.Invoke("setLoadHints$", "setLoadHints(QLibrary::LoadHints)", typeof(void), typeof(uint), value); }
        }
        // void* resolve(const char* arg1); >>>> NOT CONVERTED
        // void* resolve(const QString& arg1,const char* arg2); >>>> NOT CONVERTED
        // void* resolve(const QString& arg1,int arg2,const char* arg3); >>>> NOT CONVERTED
        // void* resolve(const QString& arg1,const QString& arg2,const char* arg3); >>>> NOT CONVERTED
        public QLibrary(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary#", "QLibrary(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QLibrary() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary", "QLibrary()", typeof(void));
        }
        public QLibrary(string fileName, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary$#", "QLibrary(const QString&, QObject*)", typeof(void), typeof(string), fileName, typeof(QObject), parent);
        }
        public QLibrary(string fileName) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary$", "QLibrary(const QString&)", typeof(void), typeof(string), fileName);
        }
        public QLibrary(string fileName, int verNum, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary$$#", "QLibrary(const QString&, int, QObject*)", typeof(void), typeof(string), fileName, typeof(int), verNum, typeof(QObject), parent);
        }
        public QLibrary(string fileName, int verNum) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary$$", "QLibrary(const QString&, int)", typeof(void), typeof(string), fileName, typeof(int), verNum);
        }
        public QLibrary(string fileName, string version, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary$$#", "QLibrary(const QString&, const QString&, QObject*)", typeof(void), typeof(string), fileName, typeof(string), version, typeof(QObject), parent);
        }
        public QLibrary(string fileName, string version) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QLibrary$$", "QLibrary(const QString&, const QString&)", typeof(void), typeof(string), fileName, typeof(string), version);
        }
        public bool Load() {
            return (bool) interceptor.Invoke("load", "load()", typeof(bool));
        }
        public bool Unload() {
            return (bool) interceptor.Invoke("unload", "unload()", typeof(bool));
        }
        public bool IsLoaded() {
            return (bool) interceptor.Invoke("isLoaded", "isLoaded() const", typeof(bool));
        }
        public void SetFileNameAndVersion(string fileName, int verNum) {
            interceptor.Invoke("setFileNameAndVersion$$", "setFileNameAndVersion(const QString&, int)", typeof(void), typeof(string), fileName, typeof(int), verNum);
        }
        public void SetFileNameAndVersion(string fileName, string version) {
            interceptor.Invoke("setFileNameAndVersion$$", "setFileNameAndVersion(const QString&, const QString&)", typeof(void), typeof(string), fileName, typeof(string), version);
        }
        public string ErrorString() {
            return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
        }
        ~QLibrary() {
            interceptor.Invoke("~QLibrary", "~QLibrary()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QLibrary", "~QLibrary()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        public static bool IsLibrary(string fileName) {
            return (bool) staticInterceptor.Invoke("isLibrary$", "isLibrary(const QString&)", typeof(bool), typeof(string), fileName);
        }
        protected new IQLibrarySignals Emit {
            get { return (IQLibrarySignals) Q_EMIT; }
        }
    }

    public interface IQLibrarySignals : IQObjectSignals {
    }
}