//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTemporaryFile")]
	public class QTemporaryFile : QFile, IDisposable {
 		protected QTemporaryFile(Type dummy) : base((Type) null) {}
		[SmokeClass("QTemporaryFile")]
		interface IQTemporaryFileProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("createLocalFile", "(const QString&)", "$")]
			QTemporaryFile CreateLocalFile(string fileName);
			[SmokeMethod("createLocalFile", "(QFile&)", "#")]
			QTemporaryFile CreateLocalFile(QFile file);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTemporaryFile), this);
			interceptor = (QTemporaryFile) realProxy.GetTransparentProxy();
		}
		private static IQTemporaryFileProxy staticInterceptor = null;
		static QTemporaryFile() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTemporaryFileProxy), null);
			staticInterceptor = (IQTemporaryFileProxy) realProxy.GetTransparentProxy();
		}
		public QTemporaryFile() : this((Type) null) {
			CreateProxy();
			NewQTemporaryFile();
		}
		[SmokeMethod("QTemporaryFile", "()", "")]
		private void NewQTemporaryFile() {
			((QTemporaryFile) interceptor).NewQTemporaryFile();
		}
		public QTemporaryFile(string templateName) : this((Type) null) {
			CreateProxy();
			NewQTemporaryFile(templateName);
		}
		[SmokeMethod("QTemporaryFile", "(const QString&)", "$")]
		private void NewQTemporaryFile(string templateName) {
			((QTemporaryFile) interceptor).NewQTemporaryFile(templateName);
		}
		public QTemporaryFile(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQTemporaryFile(parent);
		}
		[SmokeMethod("QTemporaryFile", "(QObject*)", "#")]
		private void NewQTemporaryFile(QObject parent) {
			((QTemporaryFile) interceptor).NewQTemporaryFile(parent);
		}
		public QTemporaryFile(string templateName, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQTemporaryFile(templateName,parent);
		}
		[SmokeMethod("QTemporaryFile", "(const QString&, QObject*)", "$#")]
		private void NewQTemporaryFile(string templateName, QObject parent) {
			((QTemporaryFile) interceptor).NewQTemporaryFile(templateName,parent);
		}
		[SmokeMethod("autoRemove", "() const", "")]
		public bool AutoRemove() {
			return ((QTemporaryFile) interceptor).AutoRemove();
		}
		[SmokeMethod("setAutoRemove", "(bool)", "$")]
		public void SetAutoRemove(bool b) {
			((QTemporaryFile) interceptor).SetAutoRemove(b);
		}
		[SmokeMethod("open", "()", "")]
		public bool Open() {
			return ((QTemporaryFile) interceptor).Open();
		}
		[SmokeMethod("fileName", "() const", "")]
		public string FileName() {
			return ((QTemporaryFile) interceptor).FileName();
		}
		[SmokeMethod("fileTemplate", "() const", "")]
		public string FileTemplate() {
			return ((QTemporaryFile) interceptor).FileTemplate();
		}
		[SmokeMethod("setFileTemplate", "(const QString&)", "$")]
		public void SetFileTemplate(string name) {
			((QTemporaryFile) interceptor).SetFileTemplate(name);
		}
		[SmokeMethod("fileEngine", "() const", "")]
		public override QAbstractFileEngine FileEngine() {
			return ((QTemporaryFile) interceptor).FileEngine();
		}
		[SmokeMethod("open", "(OpenMode)", "$")]
		protected new virtual bool Open(int flags) {
			return ((QTemporaryFile) interceptor).Open(flags);
		}
		~QTemporaryFile() {
			DisposeQTemporaryFile();
		}
		public new void Dispose() {
			DisposeQTemporaryFile();
		}
		[SmokeMethod("~QTemporaryFile", "()", "")]
		private void DisposeQTemporaryFile() {
			((QTemporaryFile) interceptor).DisposeQTemporaryFile();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		public static QTemporaryFile CreateLocalFile(string fileName) {
			return staticInterceptor.CreateLocalFile(fileName);
		}
		public static QTemporaryFile CreateLocalFile(QFile file) {
			return staticInterceptor.CreateLocalFile(file);
		}
		protected new IQTemporaryFileSignals Emit {
			get { return (IQTemporaryFileSignals) Q_EMIT; }
		}
	}

	public interface IQTemporaryFileSignals : IQFileSignals {
	}
}
