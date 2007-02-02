//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQCoreApplicationSignals"></see> for signals emitted by QCoreApplication
	[SmokeClass("QCoreApplication")]
	public partial class QCoreApplication : QObject, IDisposable {
 		protected QCoreApplication(Type dummy) : base((Type) null) {}
		interface IQCoreApplicationProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
			[SmokeMethod("arguments", "()")]
			List<string> Arguments();
			[SmokeMethod("setAttribute$$", "(Qt::ApplicationAttribute, bool)")]
			void SetAttribute(Qt.ApplicationAttribute attribute, bool on);
			[SmokeMethod("setAttribute$", "(Qt::ApplicationAttribute)")]
			void SetAttribute(Qt.ApplicationAttribute attribute);
			[SmokeMethod("testAttribute$", "(Qt::ApplicationAttribute)")]
			bool TestAttribute(Qt.ApplicationAttribute attribute);
			[SmokeMethod("setOrganizationDomain$", "(const QString&)")]
			void SetOrganizationDomain(string orgDomain);
			[SmokeMethod("organizationDomain", "()")]
			string organizationDomain();
			[SmokeMethod("setOrganizationName$", "(const QString&)")]
			void SetOrganizationName(string orgName);
			[SmokeMethod("organizationName", "()")]
			string organizationName();
			[SmokeMethod("setApplicationName$", "(const QString&)")]
			void SetApplicationName(string application);
			[SmokeMethod("applicationName", "()")]
			string applicationName();
			[SmokeMethod("instance", "()")]
			QCoreApplication Instance();
			[SmokeMethod("exec", "()")]
			int Exec();
			[SmokeMethod("processEvents$", "(QEventLoop::ProcessEventsFlags)")]
			void ProcessEvents(uint flags);
			[SmokeMethod("processEvents", "()")]
			void ProcessEvents();
			[SmokeMethod("processEvents$$", "(QEventLoop::ProcessEventsFlags, int)")]
			void ProcessEvents(uint flags, int maxtime);
			[SmokeMethod("exit$", "(int)")]
			void Exit(int retcode);
			[SmokeMethod("exit", "()")]
			void Exit();
			[SmokeMethod("sendEvent##", "(QObject*, QEvent*)")]
			bool SendEvent(QObject receiver, QEvent arg2);
			[SmokeMethod("postEvent##", "(QObject*, QEvent*)")]
			void PostEvent(QObject receiver, QEvent arg2);
			[SmokeMethod("sendPostedEvents##", "(QObject*, int)")]
			void SendPostedEvents(QObject receiver, int event_type);
			[SmokeMethod("sendPostedEvents", "()")]
			void SendPostedEvents();
			[SmokeMethod("removePostedEvents#", "(QObject*)")]
			void RemovePostedEvents(QObject receiver);
			[SmokeMethod("hasPendingEvents", "()")]
			bool HasPendingEvents();
			[SmokeMethod("startingUp", "()")]
			bool StartingUp();
			[SmokeMethod("closingDown", "()")]
			bool ClosingDown();
			[SmokeMethod("applicationDirPath", "()")]
			string ApplicationDirPath();
			[SmokeMethod("applicationFilePath", "()")]
			string ApplicationFilePath();
			[SmokeMethod("setLibraryPaths?", "(const QStringList&)")]
			void SetLibraryPaths(List<string> arg1);
			[SmokeMethod("libraryPaths", "()")]
			List<string> LibraryPaths();
			[SmokeMethod("addLibraryPath$", "(const QString&)")]
			void AddLibraryPath(string arg1);
			[SmokeMethod("removeLibraryPath$", "(const QString&)")]
			void RemoveLibraryPath(string arg1);
			[SmokeMethod("installTranslator#", "(QTranslator*)")]
			void InstallTranslator(QTranslator messageFile);
			[SmokeMethod("removeTranslator#", "(QTranslator*)")]
			void RemoveTranslator(QTranslator messageFile);
			[SmokeMethod("translate$$$$", "(const char*, const char*, const char*, QCoreApplication::Encoding)")]
			string Translate(string context, string key, string comment, QCoreApplication.Encoding encoding);
			[SmokeMethod("translate$$$", "(const char*, const char*, const char*)")]
			string Translate(string context, string key, string comment);
			[SmokeMethod("translate$$", "(const char*, const char*)")]
			string Translate(string context, string key);
			[SmokeMethod("translate$$$$$", "(const char*, const char*, const char*, QCoreApplication::Encoding, int)")]
			string Translate(string context, string key, string comment, QCoreApplication.Encoding encoding, int n);
			[SmokeMethod("flush", "()")]
			void Flush();
			[SmokeMethod("quit", "()")]
			void Quit();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCoreApplication), this);
			_interceptor = (QCoreApplication) realProxy.GetTransparentProxy();
		}
		private QCoreApplication ProxyQCoreApplication() {
			return (QCoreApplication) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCoreApplication() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCoreApplicationProxy), null);
			_staticInterceptor = (IQCoreApplicationProxy) realProxy.GetTransparentProxy();
		}
		private static IQCoreApplicationProxy StaticQCoreApplication() {
			return (IQCoreApplicationProxy) _staticInterceptor;
		}

		public enum Encoding {
			CodecForTr = 0,
			UnicodeUTF8 = 1,
			DefaultCodec = CodecForTr,
		}
		[Q_PROPERTY("QString", "applicationName")]
		public string ApplicationName {
			get {
				return Property("applicationName").Value<string>();
			}
			set {
				SetProperty("applicationName", QVariant.FromValue<string>(value));
			}
		}
		[Q_PROPERTY("QString", "organizationName")]
		public string OrganizationName {
			get {
				return Property("organizationName").Value<string>();
			}
			set {
				SetProperty("organizationName", QVariant.FromValue<string>(value));
			}
		}
		[Q_PROPERTY("QString", "organizationDomain")]
		public string OrganizationDomain {
			get {
				return Property("organizationDomain").Value<string>();
			}
			set {
				SetProperty("organizationDomain", QVariant.FromValue<string>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("notify##", "(QObject*, QEvent*)")]
		public virtual bool Notify(QObject arg1, QEvent arg2) {
			return ProxyQCoreApplication().Notify(arg1,arg2);
		}
		// EventFilter setEventFilter(EventFilter arg1); >>>> NOT CONVERTED
		// bool filterEvent(void* arg1,long* arg2); >>>> NOT CONVERTED
		public static new string Tr(string s, string c) {
			return StaticQCoreApplication().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQCoreApplication().Tr(s);
		}
		public static List<string> Arguments() {
			return StaticQCoreApplication().Arguments();
		}
		public static void SetAttribute(Qt.ApplicationAttribute attribute, bool on) {
			StaticQCoreApplication().SetAttribute(attribute,on);
		}
		public static void SetAttribute(Qt.ApplicationAttribute attribute) {
			StaticQCoreApplication().SetAttribute(attribute);
		}
		public static bool TestAttribute(Qt.ApplicationAttribute attribute) {
			return StaticQCoreApplication().TestAttribute(attribute);
		}
		public static void SetOrganizationDomain(string orgDomain) {
			StaticQCoreApplication().SetOrganizationDomain(orgDomain);
		}
		public static string organizationDomain() {
			return StaticQCoreApplication().organizationDomain();
		}
		public static void SetOrganizationName(string orgName) {
			StaticQCoreApplication().SetOrganizationName(orgName);
		}
		public static string organizationName() {
			return StaticQCoreApplication().organizationName();
		}
		public static void SetApplicationName(string application) {
			StaticQCoreApplication().SetApplicationName(application);
		}
		public static string applicationName() {
			return StaticQCoreApplication().applicationName();
		}
		public static QCoreApplication Instance() {
			return StaticQCoreApplication().Instance();
		}
		public static int Exec() {
			return StaticQCoreApplication().Exec();
		}
		public static void ProcessEvents(uint flags) {
			StaticQCoreApplication().ProcessEvents(flags);
		}
		public static void ProcessEvents() {
			StaticQCoreApplication().ProcessEvents();
		}
		public static void ProcessEvents(uint flags, int maxtime) {
			StaticQCoreApplication().ProcessEvents(flags,maxtime);
		}
		public static void Exit(int retcode) {
			StaticQCoreApplication().Exit(retcode);
		}
		public static void Exit() {
			StaticQCoreApplication().Exit();
		}
		public static bool SendEvent(QObject receiver, QEvent arg2) {
			return StaticQCoreApplication().SendEvent(receiver,arg2);
		}
		public static void PostEvent(QObject receiver, QEvent arg2) {
			StaticQCoreApplication().PostEvent(receiver,arg2);
		}
		public static void SendPostedEvents(QObject receiver, int event_type) {
			StaticQCoreApplication().SendPostedEvents(receiver,event_type);
		}
		public static void SendPostedEvents() {
			StaticQCoreApplication().SendPostedEvents();
		}
		public static void RemovePostedEvents(QObject receiver) {
			StaticQCoreApplication().RemovePostedEvents(receiver);
		}
		public static bool HasPendingEvents() {
			return StaticQCoreApplication().HasPendingEvents();
		}
		public static bool StartingUp() {
			return StaticQCoreApplication().StartingUp();
		}
		public static bool ClosingDown() {
			return StaticQCoreApplication().ClosingDown();
		}
		public static string ApplicationDirPath() {
			return StaticQCoreApplication().ApplicationDirPath();
		}
		public static string ApplicationFilePath() {
			return StaticQCoreApplication().ApplicationFilePath();
		}
		public static void SetLibraryPaths(List<string> arg1) {
			StaticQCoreApplication().SetLibraryPaths(arg1);
		}
		public static List<string> LibraryPaths() {
			return StaticQCoreApplication().LibraryPaths();
		}
		public static void AddLibraryPath(string arg1) {
			StaticQCoreApplication().AddLibraryPath(arg1);
		}
		public static void RemoveLibraryPath(string arg1) {
			StaticQCoreApplication().RemoveLibraryPath(arg1);
		}
		public static void InstallTranslator(QTranslator messageFile) {
			StaticQCoreApplication().InstallTranslator(messageFile);
		}
		public static void RemoveTranslator(QTranslator messageFile) {
			StaticQCoreApplication().RemoveTranslator(messageFile);
		}
		public static string Translate(string context, string key, string comment, QCoreApplication.Encoding encoding) {
			return StaticQCoreApplication().Translate(context,key,comment,encoding);
		}
		public static string Translate(string context, string key, string comment) {
			return StaticQCoreApplication().Translate(context,key,comment);
		}
		public static string Translate(string context, string key) {
			return StaticQCoreApplication().Translate(context,key);
		}
		public static string Translate(string context, string key, string comment, QCoreApplication.Encoding encoding, int n) {
			return StaticQCoreApplication().Translate(context,key,comment,encoding,n);
		}
		public static void Flush() {
			StaticQCoreApplication().Flush();
		}
		[Q_SLOT("void ()")]
		public static void Quit() {
			StaticQCoreApplication().Quit();
		}
		[SmokeMethod("event#", "(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQCoreApplication().Event(arg1);
		}
		// bool compressEvent(QEvent* arg1,QObject* arg2,QPostEventList* arg3); >>>> NOT CONVERTED
		~QCoreApplication() {
			DisposeQCoreApplication();
		}
		public new void Dispose() {
			DisposeQCoreApplication();
		}
		[SmokeMethod("~QCoreApplication", "()")]
		private void DisposeQCoreApplication() {
			ProxyQCoreApplication().DisposeQCoreApplication();
		}
		protected new IQCoreApplicationSignals Emit {
			get {
				return (IQCoreApplicationSignals) Q_EMIT;
			}
		}
	}

	public interface IQCoreApplicationSignals : IQObjectSignals {
		[Q_SIGNAL("void ()")]
		void AboutToQuit();
		[Q_SIGNAL("void (int)")]
		void UnixSignal(int arg1);
	}
}
