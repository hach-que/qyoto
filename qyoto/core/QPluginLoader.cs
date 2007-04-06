//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPluginLoader")]
	public class QPluginLoader : QObject, IDisposable {
 		protected QPluginLoader(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPluginLoader), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QPluginLoader() {
			staticInterceptor = new SmokeInvocation(typeof(QPluginLoader), null);
		}
		[Q_PROPERTY("QString", "fileName")]
		public string FileName {
			get { return (string) interceptor.Invoke("fileName", "fileName()", typeof(string)); }
			set { interceptor.Invoke("setFileName$", "setFileName(QString)", typeof(void), typeof(string), value); }
		}
		public QPluginLoader(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPluginLoader#", "QPluginLoader(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QPluginLoader() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPluginLoader", "QPluginLoader()", typeof(void));
		}
		public QPluginLoader(string fileName, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPluginLoader$#", "QPluginLoader(const QString&, QObject*)", typeof(void), typeof(string), fileName, typeof(QObject), parent);
		}
		public QPluginLoader(string fileName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPluginLoader$", "QPluginLoader(const QString&)", typeof(void), typeof(string), fileName);
		}
		public QObject Instance() {
			return (QObject) interceptor.Invoke("instance", "instance()", typeof(QObject));
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
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		~QPluginLoader() {
			interceptor.Invoke("~QPluginLoader", "~QPluginLoader()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QPluginLoader", "~QPluginLoader()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static List<QObject> StaticInstances() {
			return (List<QObject>) staticInterceptor.Invoke("staticInstances", "staticInstances()", typeof(List<QObject>));
		}
		protected new IQPluginLoaderSignals Emit {
			get { return (IQPluginLoaderSignals) Q_EMIT; }
		}
	}

	public interface IQPluginLoaderSignals : IQObjectSignals {
	}
}
