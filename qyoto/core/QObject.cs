//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Reflection;
	using System.Collections.Generic;

	/// See <see cref="IQObjectSignals"></see> for signals emitted by QObject
	[SmokeClass("QObject")]
	public partial class QObject : Qt, IDisposable {
		private IntPtr smokeObject;
		protected Object Q_EMIT = null;
		protected QObject(Type dummy) {
			try {
				Type proxyInterface = Qyoto.GetSignalsInterface(GetType());
				SignalInvocation realProxy = new SignalInvocation(proxyInterface, this);
				Q_EMIT = realProxy.GetTransparentProxy();
			}
			catch {
				Console.WriteLine("Could not retrieve signal interface");
			}
		}
		[SmokeMethod("metaObject()")]
		public virtual QMetaObject MetaObject() {
			if (SmokeMarshallers.IsSmokeClass(GetType())) {
				return (QMetaObject) interceptor.Invoke("metaObject", "metaObject()", typeof(QMetaObject));
			} else {
				return Qyoto.GetMetaObject(this);
			}
		}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QObject), "QObject", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QObject() {
			staticInterceptor = new SmokeInvocation(typeof(QObject), "QObject", null);
		}
		public static QMetaObject StaticQtMetaObject() {
			return (QMetaObject) staticInterceptor.Invoke("staticQtMetaObject", "staticQtMetaObject()", typeof(QMetaObject));
		}
		[Q_PROPERTY("QString", "objectName")]
		public string ObjectName {
			get { return (string) interceptor.Invoke("objectName", "objectName()", typeof(string)); }
			set { interceptor.Invoke("setObjectName$", "setObjectName(QString)", typeof(void), typeof(string), value); }
		}
		// QThread* thread(); >>>> NOT CONVERTED
		// void moveToThread(QThread* arg1); >>>> NOT CONVERTED
		// void setUserData(uint arg1,QObjectUserData* arg2); >>>> NOT CONVERTED
		// QObjectUserData* userData(uint arg1); >>>> NOT CONVERTED
		public QObject(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QObject#", "QObject(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QObject() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QObject", "QObject()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		public virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		public bool IsWidgetType() {
			return (bool) interceptor.Invoke("isWidgetType", "isWidgetType() const", typeof(bool));
		}
		public bool SignalsBlocked() {
			return (bool) interceptor.Invoke("signalsBlocked", "signalsBlocked() const", typeof(bool));
		}
		public bool BlockSignals(bool b) {
			return (bool) interceptor.Invoke("blockSignals$", "blockSignals(bool)", typeof(bool), typeof(bool), b);
		}
		public int StartTimer(int interval) {
			return (int) interceptor.Invoke("startTimer$", "startTimer(int)", typeof(int), typeof(int), interval);
		}
		public void KillTimer(int id) {
			interceptor.Invoke("killTimer$", "killTimer(int)", typeof(void), typeof(int), id);
		}
		public List<QObject> Children() {
			return (List<QObject>) interceptor.Invoke("children", "children() const", typeof(List<QObject>));
		}
		public void SetParent(QObject arg1) {
			interceptor.Invoke("setParent#", "setParent(QObject*)", typeof(void), typeof(QObject), arg1);
		}
		public void InstallEventFilter(QObject arg1) {
			interceptor.Invoke("installEventFilter#", "installEventFilter(QObject*)", typeof(void), typeof(QObject), arg1);
		}
		public void RemoveEventFilter(QObject arg1) {
			interceptor.Invoke("removeEventFilter#", "removeEventFilter(QObject*)", typeof(void), typeof(QObject), arg1);
		}
		public bool Connect(QObject sender, string signal, string member, Qt.ConnectionType type) {
			return (bool) interceptor.Invoke("connect#$$$", "connect(const QObject*, const char*, const char*, Qt::ConnectionType) const", typeof(bool), typeof(QObject), sender, typeof(string), signal, typeof(string), member, typeof(Qt.ConnectionType), type);
		}
		public bool Connect(QObject sender, string signal, string member) {
			return (bool) interceptor.Invoke("connect#$$", "connect(const QObject*, const char*, const char*) const", typeof(bool), typeof(QObject), sender, typeof(string), signal, typeof(string), member);
		}
		public bool Disconnect(string signal, QObject receiver, string member) {
			return (bool) interceptor.Invoke("disconnect$#$", "disconnect(const char*, const QObject*, const char*)", typeof(bool), typeof(string), signal, typeof(QObject), receiver, typeof(string), member);
		}
		public bool Disconnect(string signal, QObject receiver) {
			return (bool) interceptor.Invoke("disconnect$#", "disconnect(const char*, const QObject*)", typeof(bool), typeof(string), signal, typeof(QObject), receiver);
		}
		public bool Disconnect(string signal) {
			return (bool) interceptor.Invoke("disconnect$", "disconnect(const char*)", typeof(bool), typeof(string), signal);
		}
		public bool Disconnect() {
			return (bool) interceptor.Invoke("disconnect", "disconnect()", typeof(bool));
		}
		public bool Disconnect(QObject receiver, string member) {
			return (bool) interceptor.Invoke("disconnect#$", "disconnect(const QObject*, const char*)", typeof(bool), typeof(QObject), receiver, typeof(string), member);
		}
		public bool Disconnect(QObject receiver) {
			return (bool) interceptor.Invoke("disconnect#", "disconnect(const QObject*)", typeof(bool), typeof(QObject), receiver);
		}
		public void DumpObjectTree() {
			interceptor.Invoke("dumpObjectTree", "dumpObjectTree()", typeof(void));
		}
		public void DumpObjectInfo() {
			interceptor.Invoke("dumpObjectInfo", "dumpObjectInfo()", typeof(void));
		}
		public bool SetProperty(string name, QVariant value) {
			return (bool) interceptor.Invoke("setProperty$#", "setProperty(const char*, const QVariant&)", typeof(bool), typeof(string), name, typeof(QVariant), value);
		}
		public QVariant Property(string name) {
			return (QVariant) interceptor.Invoke("property$", "property(const char*) const", typeof(QVariant), typeof(string), name);
		}
		public List<QByteArray> DynamicPropertyNames() {
			return (List<QByteArray>) interceptor.Invoke("dynamicPropertyNames", "dynamicPropertyNames() const", typeof(List<QByteArray>));
		}
		public QObject Parent() {
			return (QObject) interceptor.Invoke("parent", "parent() const", typeof(QObject));
		}
		public bool Inherits(string classname) {
			return (bool) interceptor.Invoke("inherits$", "inherits(const char*) const", typeof(bool), typeof(string), classname);
		}
		[Q_SLOT("void deleteLater()")]
		public void DeleteLater() {
			interceptor.Invoke("deleteLater", "deleteLater()", typeof(void));
		}
		protected QObject Sender() {
			return (QObject) interceptor.Invoke("sender", "sender() const", typeof(QObject));
		}
		protected int Receivers(string signal) {
			return (int) interceptor.Invoke("receivers$", "receivers(const char*) const", typeof(int), typeof(string), signal);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected virtual void TimerEvent(QTimerEvent arg1) {
			interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
		}
		[SmokeMethod("childEvent(QChildEvent*)")]
		protected virtual void ChildEvent(QChildEvent arg1) {
			interceptor.Invoke("childEvent#", "childEvent(QChildEvent*)", typeof(void), typeof(QChildEvent), arg1);
		}
		[SmokeMethod("customEvent(QEvent*)")]
		protected virtual void CustomEvent(QEvent arg1) {
			interceptor.Invoke("customEvent#", "customEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("connectNotify(const char*)")]
		protected virtual void ConnectNotify(string signal) {
			interceptor.Invoke("connectNotify$", "connectNotify(const char*)", typeof(void), typeof(string), signal);
		}
		[SmokeMethod("disconnectNotify(const char*)")]
		protected virtual void DisconnectNotify(string signal) {
			interceptor.Invoke("disconnectNotify$", "disconnectNotify(const char*)", typeof(void), typeof(string), signal);
		}
		~QObject() {
			interceptor.Invoke("~QObject", "~QObject()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QObject", "~QObject()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static bool Connect(QObject sender, string signal, QObject receiver, string member, Qt.ConnectionType arg5) {
			return (bool) staticInterceptor.Invoke("connect#$#$$", "connect(const QObject*, const char*, const QObject*, const char*, Qt::ConnectionType)", typeof(bool), typeof(QObject), sender, typeof(string), signal, typeof(QObject), receiver, typeof(string), member, typeof(Qt.ConnectionType), arg5);
		}
		public static bool Connect(QObject sender, string signal, QObject receiver, string member) {
			return (bool) staticInterceptor.Invoke("connect#$#$", "connect(const QObject*, const char*, const QObject*, const char*)", typeof(bool), typeof(QObject), sender, typeof(string), signal, typeof(QObject), receiver, typeof(string), member);
		}
		public static bool Disconnect(QObject sender, string signal, QObject receiver, string member) {
			return (bool) staticInterceptor.Invoke("disconnect#$#$", "disconnect(const QObject*, const char*, const QObject*, const char*)", typeof(bool), typeof(QObject), sender, typeof(string), signal, typeof(QObject), receiver, typeof(string), member);
		}
		public static uint RegisterUserData() {
			return (uint) staticInterceptor.Invoke("registerUserData", "registerUserData()", typeof(uint));
		}
		protected new IQObjectSignals Emit {
			get { return (IQObjectSignals) Q_EMIT; }
		}
	}

	public interface IQObjectSignals {
		[Q_SIGNAL("void destroyed(QObject*)")]
		void Destroyed(QObject arg1);
		[Q_SIGNAL("void destroyed()")]
		void Destroyed();
	}
}
