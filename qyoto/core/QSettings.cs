//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QSettings")]
	public class QSettings : QObject, IDisposable {
 		protected QSettings(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSettings), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSettings() {
			staticInterceptor = new SmokeInvocation(typeof(QSettings), null);
		}
		public enum Status {
			NoError = 0,
			AccessError = 1,
			FormatError = 2,
		}
		public enum Format {
			NativeFormat = 0,
			IniFormat = 1,
			InvalidFormat = 16,
			CustomFormat1 = 17,
			CustomFormat2 = 18,
			CustomFormat3 = 19,
			CustomFormat4 = 20,
			CustomFormat5 = 21,
			CustomFormat6 = 22,
			CustomFormat7 = 23,
			CustomFormat8 = 24,
			CustomFormat9 = 25,
			CustomFormat10 = 26,
			CustomFormat11 = 27,
			CustomFormat12 = 28,
			CustomFormat13 = 29,
			CustomFormat14 = 30,
			CustomFormat15 = 31,
			CustomFormat16 = 32,
		}
		public enum Scope {
			UserScope = 0,
			SystemScope = 1,
		}
		// QSettings::Format registerFormat(const QString& arg1,ReadFunc arg2,WriteFunc arg3,Qt::CaseSensitivity arg4); >>>> NOT CONVERTED
		// QSettings::Format registerFormat(const QString& arg1,ReadFunc arg2,WriteFunc arg3); >>>> NOT CONVERTED
		public QSettings(string organization, string application, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$#", "QSettings(const QString&, const QString&, QObject*)", typeof(void), typeof(string), organization, typeof(string), application, typeof(QObject), parent);
		}
		public QSettings(string organization, string application) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$", "QSettings(const QString&, const QString&)", typeof(void), typeof(string), organization, typeof(string), application);
		}
		public QSettings(string organization) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$", "QSettings(const QString&)", typeof(void), typeof(string), organization);
		}
		public QSettings(QSettings.Scope scope, string organization, string application, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$$#", "QSettings(QSettings::Scope, const QString&, const QString&, QObject*)", typeof(void), typeof(QSettings.Scope), scope, typeof(string), organization, typeof(string), application, typeof(QObject), parent);
		}
		public QSettings(QSettings.Scope scope, string organization, string application) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$$", "QSettings(QSettings::Scope, const QString&, const QString&)", typeof(void), typeof(QSettings.Scope), scope, typeof(string), organization, typeof(string), application);
		}
		public QSettings(QSettings.Scope scope, string organization) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$", "QSettings(QSettings::Scope, const QString&)", typeof(void), typeof(QSettings.Scope), scope, typeof(string), organization);
		}
		public QSettings(QSettings.Format format, QSettings.Scope scope, string organization, string application, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$$$#", "QSettings(QSettings::Format, QSettings::Scope, const QString&, const QString&, QObject*)", typeof(void), typeof(QSettings.Format), format, typeof(QSettings.Scope), scope, typeof(string), organization, typeof(string), application, typeof(QObject), parent);
		}
		public QSettings(QSettings.Format format, QSettings.Scope scope, string organization, string application) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$$$", "QSettings(QSettings::Format, QSettings::Scope, const QString&, const QString&)", typeof(void), typeof(QSettings.Format), format, typeof(QSettings.Scope), scope, typeof(string), organization, typeof(string), application);
		}
		public QSettings(QSettings.Format format, QSettings.Scope scope, string organization) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$$", "QSettings(QSettings::Format, QSettings::Scope, const QString&)", typeof(void), typeof(QSettings.Format), format, typeof(QSettings.Scope), scope, typeof(string), organization);
		}
		public QSettings(string fileName, QSettings.Format format, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$#", "QSettings(const QString&, QSettings::Format, QObject*)", typeof(void), typeof(string), fileName, typeof(QSettings.Format), format, typeof(QObject), parent);
		}
		public QSettings(string fileName, QSettings.Format format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings$$", "QSettings(const QString&, QSettings::Format)", typeof(void), typeof(string), fileName, typeof(QSettings.Format), format);
		}
		public QSettings(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings#", "QSettings(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QSettings() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSettings", "QSettings()", typeof(void));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public void Sync() {
			interceptor.Invoke("sync", "sync()", typeof(void));
		}
		public QSettings.Status status() {
			return (QSettings.Status) interceptor.Invoke("status", "status() const", typeof(QSettings.Status));
		}
		public void BeginGroup(string prefix) {
			interceptor.Invoke("beginGroup$", "beginGroup(const QString&)", typeof(void), typeof(string), prefix);
		}
		public void EndGroup() {
			interceptor.Invoke("endGroup", "endGroup()", typeof(void));
		}
		public string Group() {
			return (string) interceptor.Invoke("group", "group() const", typeof(string));
		}
		public int BeginReadArray(string prefix) {
			return (int) interceptor.Invoke("beginReadArray$", "beginReadArray(const QString&)", typeof(int), typeof(string), prefix);
		}
		public void BeginWriteArray(string prefix, int size) {
			interceptor.Invoke("beginWriteArray$$", "beginWriteArray(const QString&, int)", typeof(void), typeof(string), prefix, typeof(int), size);
		}
		public void BeginWriteArray(string prefix) {
			interceptor.Invoke("beginWriteArray$", "beginWriteArray(const QString&)", typeof(void), typeof(string), prefix);
		}
		public void EndArray() {
			interceptor.Invoke("endArray", "endArray()", typeof(void));
		}
		public void SetArrayIndex(int i) {
			interceptor.Invoke("setArrayIndex$", "setArrayIndex(int)", typeof(void), typeof(int), i);
		}
		public List<string> AllKeys() {
			return (List<string>) interceptor.Invoke("allKeys", "allKeys() const", typeof(List<string>));
		}
		public List<string> ChildKeys() {
			return (List<string>) interceptor.Invoke("childKeys", "childKeys() const", typeof(List<string>));
		}
		public List<string> ChildGroups() {
			return (List<string>) interceptor.Invoke("childGroups", "childGroups() const", typeof(List<string>));
		}
		public bool IsWritable() {
			return (bool) interceptor.Invoke("isWritable", "isWritable() const", typeof(bool));
		}
		public void SetValue(string key, QVariant value) {
			interceptor.Invoke("setValue$#", "setValue(const QString&, const QVariant&)", typeof(void), typeof(string), key, typeof(QVariant), value);
		}
		public QVariant Value(string key, QVariant defaultValue) {
			return (QVariant) interceptor.Invoke("value$#", "value(const QString&, const QVariant&) const", typeof(QVariant), typeof(string), key, typeof(QVariant), defaultValue);
		}
		public QVariant Value(string key) {
			return (QVariant) interceptor.Invoke("value$", "value(const QString&) const", typeof(QVariant), typeof(string), key);
		}
		public void Remove(string key) {
			interceptor.Invoke("remove$", "remove(const QString&)", typeof(void), typeof(string), key);
		}
		public bool Contains(string key) {
			return (bool) interceptor.Invoke("contains$", "contains(const QString&) const", typeof(bool), typeof(string), key);
		}
		public void SetFallbacksEnabled(bool b) {
			interceptor.Invoke("setFallbacksEnabled$", "setFallbacksEnabled(bool)", typeof(void), typeof(bool), b);
		}
		public bool FallbacksEnabled() {
			return (bool) interceptor.Invoke("fallbacksEnabled", "fallbacksEnabled() const", typeof(bool));
		}
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		[SmokeMethod("event(QEvent*)")]
		protected new virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		~QSettings() {
			interceptor.Invoke("~QSettings", "~QSettings()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QSettings", "~QSettings()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static void SetSystemIniPath(string dir) {
			staticInterceptor.Invoke("setSystemIniPath$", "setSystemIniPath(const QString&)", typeof(void), typeof(string), dir);
		}
		public static void SetUserIniPath(string dir) {
			staticInterceptor.Invoke("setUserIniPath$", "setUserIniPath(const QString&)", typeof(void), typeof(string), dir);
		}
		public static void SetPath(QSettings.Format format, QSettings.Scope scope, string path) {
			staticInterceptor.Invoke("setPath$$$", "setPath(QSettings::Format, QSettings::Scope, const QString&)", typeof(void), typeof(QSettings.Format), format, typeof(QSettings.Scope), scope, typeof(string), path);
		}
		protected new IQSettingsSignals Emit {
			get { return (IQSettingsSignals) Q_EMIT; }
		}
	}

	public interface IQSettingsSignals : IQObjectSignals {
	}
}
