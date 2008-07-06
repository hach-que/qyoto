//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QDBusConnection")]
    public class QDBusConnection : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QDBusConnection(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDBusConnection), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QDBusConnection() {
            staticInterceptor = new SmokeInvocation(typeof(QDBusConnection), null);
        }
        public enum BusType {
            SessionBus = 0,
            SystemBus = 1,
            ActivationBus = 2,
        }
        public enum RegisterOption {
            ExportAdaptors = 0x01,
            ExportScriptableSlots = 0x10,
            ExportScriptableSignals = 0x20,
            ExportScriptableProperties = 0x40,
            ExportScriptableContents = 0xf0,
            ExportNonScriptableSlots = 0x100,
            ExportNonScriptableSignals = 0x200,
            ExportNonScriptableProperties = 0x400,
            ExportNonScriptableContents = 0xf00,
            ExportAllSlots = ExportScriptableSlots|ExportNonScriptableSlots,
            ExportAllSignals = ExportScriptableSignals|ExportNonScriptableSignals,
            ExportAllProperties = ExportScriptableProperties|ExportNonScriptableProperties,
            ExportAllContents = ExportScriptableContents|ExportNonScriptableContents,
            ExportAllSignal = ExportAllSignals,
            ExportChildObjects = 0x1000,
        }
        public enum UnregisterMode {
            UnregisterNode = 0,
            UnregisterTree = 1,
        }
        // QDBusConnection* QDBusConnection(QDBusConnectionPrivate* arg1); >>>> NOT CONVERTED
        public QDBusConnection(string name) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDBusConnection$", "QDBusConnection(const QString&)", typeof(void), typeof(string), name);
        }
        public QDBusConnection(QDBusConnection other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDBusConnection#", "QDBusConnection(const QDBusConnection&)", typeof(void), typeof(QDBusConnection), other);
        }
        public bool IsConnected() {
            return (bool) interceptor.Invoke("isConnected", "isConnected() const", typeof(bool));
        }
        public string BaseService() {
            return (string) interceptor.Invoke("baseService", "baseService() const", typeof(string));
        }
        public QDBusError LastError() {
            return (QDBusError) interceptor.Invoke("lastError", "lastError() const", typeof(QDBusError));
        }
        public bool Send(QDBusMessage message) {
            return (bool) interceptor.Invoke("send#", "send(const QDBusMessage&) const", typeof(bool), typeof(QDBusMessage), message);
        }
        public bool CallWithCallback(QDBusMessage message, QObject receiver, string returnMethod, string errorMethod, int timeout) {
            return (bool) interceptor.Invoke("callWithCallback##$$$", "callWithCallback(const QDBusMessage&, QObject*, const char*, const char*, int) const", typeof(bool), typeof(QDBusMessage), message, typeof(QObject), receiver, typeof(string), returnMethod, typeof(string), errorMethod, typeof(int), timeout);
        }
        public bool CallWithCallback(QDBusMessage message, QObject receiver, string returnMethod, string errorMethod) {
            return (bool) interceptor.Invoke("callWithCallback##$$", "callWithCallback(const QDBusMessage&, QObject*, const char*, const char*) const", typeof(bool), typeof(QDBusMessage), message, typeof(QObject), receiver, typeof(string), returnMethod, typeof(string), errorMethod);
        }
        public bool CallWithCallback(QDBusMessage message, QObject receiver, string slot, int timeout) {
            return (bool) interceptor.Invoke("callWithCallback##$$", "callWithCallback(const QDBusMessage&, QObject*, const char*, int) const", typeof(bool), typeof(QDBusMessage), message, typeof(QObject), receiver, typeof(string), slot, typeof(int), timeout);
        }
        public bool CallWithCallback(QDBusMessage message, QObject receiver, string slot) {
            return (bool) interceptor.Invoke("callWithCallback##$", "callWithCallback(const QDBusMessage&, QObject*, const char*) const", typeof(bool), typeof(QDBusMessage), message, typeof(QObject), receiver, typeof(string), slot);
        }
        public QDBusMessage Call(QDBusMessage message, QDBus.CallMode mode, int timeout) {
            return (QDBusMessage) interceptor.Invoke("call#$$", "call(const QDBusMessage&, QDBus::CallMode, int) const", typeof(QDBusMessage), typeof(QDBusMessage), message, typeof(QDBus.CallMode), mode, typeof(int), timeout);
        }
        public QDBusMessage Call(QDBusMessage message, QDBus.CallMode mode) {
            return (QDBusMessage) interceptor.Invoke("call#$", "call(const QDBusMessage&, QDBus::CallMode) const", typeof(QDBusMessage), typeof(QDBusMessage), message, typeof(QDBus.CallMode), mode);
        }
        public QDBusMessage Call(QDBusMessage message) {
            return (QDBusMessage) interceptor.Invoke("call#", "call(const QDBusMessage&) const", typeof(QDBusMessage), typeof(QDBusMessage), message);
        }
        public bool Connect(string service, string path, string arg3, string name, QObject receiver, string slot) {
            return (bool) interceptor.Invoke("connect$$$$#$", "connect(const QString&, const QString&, const QString&, const QString&, QObject*, const char*)", typeof(bool), typeof(string), service, typeof(string), path, typeof(string), arg3, typeof(string), name, typeof(QObject), receiver, typeof(string), slot);
        }
        public bool Disconnect(string service, string path, string arg3, string name, QObject receiver, string slot) {
            return (bool) interceptor.Invoke("disconnect$$$$#$", "disconnect(const QString&, const QString&, const QString&, const QString&, QObject*, const char*)", typeof(bool), typeof(string), service, typeof(string), path, typeof(string), arg3, typeof(string), name, typeof(QObject), receiver, typeof(string), slot);
        }
        public bool Connect(string service, string path, string arg3, string name, string signature, QObject receiver, string slot) {
            return (bool) interceptor.Invoke("connect$$$$$#$", "connect(const QString&, const QString&, const QString&, const QString&, const QString&, QObject*, const char*)", typeof(bool), typeof(string), service, typeof(string), path, typeof(string), arg3, typeof(string), name, typeof(string), signature, typeof(QObject), receiver, typeof(string), slot);
        }
        public bool Disconnect(string service, string path, string arg3, string name, string signature, QObject receiver, string slot) {
            return (bool) interceptor.Invoke("disconnect$$$$$#$", "disconnect(const QString&, const QString&, const QString&, const QString&, const QString&, QObject*, const char*)", typeof(bool), typeof(string), service, typeof(string), path, typeof(string), arg3, typeof(string), name, typeof(string), signature, typeof(QObject), receiver, typeof(string), slot);
        }
        public bool RegisterObject(string path, QObject arg2, uint options) {
            return (bool) interceptor.Invoke("registerObject$#$", "registerObject(const QString&, QObject*, QDBusConnection::RegisterOptions)", typeof(bool), typeof(string), path, typeof(QObject), arg2, typeof(uint), options);
        }
        public bool RegisterObject(string path, QObject arg2) {
            return (bool) interceptor.Invoke("registerObject$#", "registerObject(const QString&, QObject*)", typeof(bool), typeof(string), path, typeof(QObject), arg2);
        }
        public void UnregisterObject(string path, QDBusConnection.UnregisterMode mode) {
            interceptor.Invoke("unregisterObject$$", "unregisterObject(const QString&, QDBusConnection::UnregisterMode)", typeof(void), typeof(string), path, typeof(QDBusConnection.UnregisterMode), mode);
        }
        public void UnregisterObject(string path) {
            interceptor.Invoke("unregisterObject$", "unregisterObject(const QString&)", typeof(void), typeof(string), path);
        }
        public QObject ObjectRegisteredAt(string path) {
            return (QObject) interceptor.Invoke("objectRegisteredAt$", "objectRegisteredAt(const QString&) const", typeof(QObject), typeof(string), path);
        }
        public bool RegisterService(string serviceName) {
            return (bool) interceptor.Invoke("registerService$", "registerService(const QString&)", typeof(bool), typeof(string), serviceName);
        }
        public bool UnregisterService(string serviceName) {
            return (bool) interceptor.Invoke("unregisterService$", "unregisterService(const QString&)", typeof(bool), typeof(string), serviceName);
        }
        public QDBusConnectionInterface Interface() {
            return (QDBusConnectionInterface) interceptor.Invoke("interface", "interface() const", typeof(QDBusConnectionInterface));
        }
        ~QDBusConnection() {
            interceptor.Invoke("~QDBusConnection", "~QDBusConnection()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QDBusConnection", "~QDBusConnection()", typeof(void));
        }
        public static QDBusConnection ConnectToBus(QDBusConnection.BusType type, string name) {
            return (QDBusConnection) staticInterceptor.Invoke("connectToBus$$", "connectToBus(QDBusConnection::BusType, const QString&)", typeof(QDBusConnection), typeof(QDBusConnection.BusType), type, typeof(string), name);
        }
        public static QDBusConnection ConnectToBus(string address, string name) {
            return (QDBusConnection) staticInterceptor.Invoke("connectToBus$$", "connectToBus(const QString&, const QString&)", typeof(QDBusConnection), typeof(string), address, typeof(string), name);
        }
        public static void DisconnectFromBus(string name) {
            staticInterceptor.Invoke("disconnectFromBus$", "disconnectFromBus(const QString&)", typeof(void), typeof(string), name);
        }
        public static QDBusConnection SessionBus() {
            return (QDBusConnection) staticInterceptor.Invoke("sessionBus", "sessionBus()", typeof(QDBusConnection));
        }
        public static QDBusConnection SystemBus() {
            return (QDBusConnection) staticInterceptor.Invoke("systemBus", "systemBus()", typeof(QDBusConnection));
        }
        public static QDBusConnection Sender() {
            return (QDBusConnection) staticInterceptor.Invoke("sender", "sender()", typeof(QDBusConnection));
        }
    }
}
