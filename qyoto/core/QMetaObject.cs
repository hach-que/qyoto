//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QMetaObject")]
	public class QMetaObject : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QMetaObject(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QMetaObject), "QMetaObject", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QMetaObject() {
			staticInterceptor = new SmokeInvocation(typeof(QMetaObject), "QMetaObject", null);
		}
		public enum Call {
			InvokeMetaMethod = 0,
			ReadProperty = 1,
			WriteProperty = 2,
			ResetProperty = 3,
			QueryPropertyDesignable = 4,
			QueryPropertyScriptable = 5,
			QueryPropertyStored = 6,
			QueryPropertyEditable = 7,
			QueryPropertyUser = 8,
		}
		// void activate(QObject* arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		// void activate(QObject* arg1,int arg2,int arg3,void** arg4); >>>> NOT CONVERTED
		// void activate(QObject* arg1,const QMetaObject* arg2,int arg3,void** arg4); >>>> NOT CONVERTED
		// void activate(QObject* arg1,const QMetaObject* arg2,int arg3,int arg4,void** arg5); >>>> NOT CONVERTED
		// void addGuard(QObject** arg1); >>>> NOT CONVERTED
		// void removeGuard(QObject** arg1); >>>> NOT CONVERTED
		// void changeGuard(QObject** arg1,QObject* arg2); >>>> NOT CONVERTED
		public string ClassName() {
			return (string) interceptor.Invoke("className", "className() const", typeof(string));
		}
		public QMetaObject SuperClass() {
			return (QMetaObject) interceptor.Invoke("superClass", "superClass() const", typeof(QMetaObject));
		}
		public QObject Cast(QObject arg1) {
			return (QObject) interceptor.Invoke("cast#", "cast(QObject*) const", typeof(QObject), typeof(QObject), arg1);
		}
		public string Tr(string s, string c) {
			return (string) interceptor.Invoke("tr$$", "tr(const char*, const char*) const", typeof(string), typeof(string), s, typeof(string), c);
		}
		public string TrUtf8(string s, string c) {
			return (string) interceptor.Invoke("trUtf8$$", "trUtf8(const char*, const char*) const", typeof(string), typeof(string), s, typeof(string), c);
		}
		public string Tr(string s, string c, int n) {
			return (string) interceptor.Invoke("tr$$$", "tr(const char*, const char*, int) const", typeof(string), typeof(string), s, typeof(string), c, typeof(int), n);
		}
		public string TrUtf8(string s, string c, int n) {
			return (string) interceptor.Invoke("trUtf8$$$", "trUtf8(const char*, const char*, int) const", typeof(string), typeof(string), s, typeof(string), c, typeof(int), n);
		}
		public int MethodOffset() {
			return (int) interceptor.Invoke("methodOffset", "methodOffset() const", typeof(int));
		}
		public int EnumeratorOffset() {
			return (int) interceptor.Invoke("enumeratorOffset", "enumeratorOffset() const", typeof(int));
		}
		public int PropertyOffset() {
			return (int) interceptor.Invoke("propertyOffset", "propertyOffset() const", typeof(int));
		}
		public int ClassInfoOffset() {
			return (int) interceptor.Invoke("classInfoOffset", "classInfoOffset() const", typeof(int));
		}
		public int MethodCount() {
			return (int) interceptor.Invoke("methodCount", "methodCount() const", typeof(int));
		}
		public int EnumeratorCount() {
			return (int) interceptor.Invoke("enumeratorCount", "enumeratorCount() const", typeof(int));
		}
		public int PropertyCount() {
			return (int) interceptor.Invoke("propertyCount", "propertyCount() const", typeof(int));
		}
		public int ClassInfoCount() {
			return (int) interceptor.Invoke("classInfoCount", "classInfoCount() const", typeof(int));
		}
		public int IndexOfMethod(string method) {
			return (int) interceptor.Invoke("indexOfMethod$", "indexOfMethod(const char*) const", typeof(int), typeof(string), method);
		}
		public int IndexOfSignal(string signal) {
			return (int) interceptor.Invoke("indexOfSignal$", "indexOfSignal(const char*) const", typeof(int), typeof(string), signal);
		}
		public int IndexOfSlot(string slot) {
			return (int) interceptor.Invoke("indexOfSlot$", "indexOfSlot(const char*) const", typeof(int), typeof(string), slot);
		}
		public int IndexOfEnumerator(string name) {
			return (int) interceptor.Invoke("indexOfEnumerator$", "indexOfEnumerator(const char*) const", typeof(int), typeof(string), name);
		}
		public int IndexOfProperty(string name) {
			return (int) interceptor.Invoke("indexOfProperty$", "indexOfProperty(const char*) const", typeof(int), typeof(string), name);
		}
		public int IndexOfClassInfo(string name) {
			return (int) interceptor.Invoke("indexOfClassInfo$", "indexOfClassInfo(const char*) const", typeof(int), typeof(string), name);
		}
		public QMetaMethod Method(int index) {
			return (QMetaMethod) interceptor.Invoke("method$", "method(int) const", typeof(QMetaMethod), typeof(int), index);
		}
		public QMetaEnum Enumerator(int index) {
			return (QMetaEnum) interceptor.Invoke("enumerator$", "enumerator(int) const", typeof(QMetaEnum), typeof(int), index);
		}
		public QMetaProperty Property(int index) {
			return (QMetaProperty) interceptor.Invoke("property$", "property(int) const", typeof(QMetaProperty), typeof(int), index);
		}
		public QMetaClassInfo ClassInfo(int index) {
			return (QMetaClassInfo) interceptor.Invoke("classInfo$", "classInfo(int) const", typeof(QMetaClassInfo), typeof(int), index);
		}
		public QMetaProperty UserProperty() {
			return (QMetaProperty) interceptor.Invoke("userProperty", "userProperty() const", typeof(QMetaProperty));
		}
		public QMetaObject() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMetaObject", "QMetaObject()", typeof(void));
		}
		public static bool CheckConnectArgs(string signal, string method) {
			return (bool) staticInterceptor.Invoke("checkConnectArgs$$", "checkConnectArgs(const char*, const char*)", typeof(bool), typeof(string), signal, typeof(string), method);
		}
		public static QByteArray NormalizedSignature(string method) {
			return (QByteArray) staticInterceptor.Invoke("normalizedSignature$", "normalizedSignature(const char*)", typeof(QByteArray), typeof(string), method);
		}
		public static QByteArray NormalizedType(string type) {
			return (QByteArray) staticInterceptor.Invoke("normalizedType$", "normalizedType(const char*)", typeof(QByteArray), typeof(string), type);
		}
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type, int types) {
			return (bool) staticInterceptor.Invoke("connect#$#$$$", "connect(const QObject*, int, const QObject*, int, int, int*)", typeof(bool), typeof(QObject), sender, typeof(int), signal_index, typeof(QObject), receiver, typeof(int), method_index, typeof(int), type, typeof(int), types);
		}
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type) {
			return (bool) staticInterceptor.Invoke("connect#$#$$", "connect(const QObject*, int, const QObject*, int, int)", typeof(bool), typeof(QObject), sender, typeof(int), signal_index, typeof(QObject), receiver, typeof(int), method_index, typeof(int), type);
		}
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index) {
			return (bool) staticInterceptor.Invoke("connect#$#$", "connect(const QObject*, int, const QObject*, int)", typeof(bool), typeof(QObject), sender, typeof(int), signal_index, typeof(QObject), receiver, typeof(int), method_index);
		}
		public static bool Disconnect(QObject sender, int signal_index, QObject receiver, int method_index) {
			return (bool) staticInterceptor.Invoke("disconnect#$#$", "disconnect(const QObject*, int, const QObject*, int)", typeof(bool), typeof(QObject), sender, typeof(int), signal_index, typeof(QObject), receiver, typeof(int), method_index);
		}
		public static void ConnectSlotsByName(QObject o) {
			staticInterceptor.Invoke("connectSlotsByName#", "connectSlotsByName(QObject*)", typeof(void), typeof(QObject), o);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$###########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8, typeof(QGenericArgument), val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$##########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#######", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$######", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#####", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$####", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$###", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$##", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), arg3, typeof(QGenericReturnArgument), ret);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$###########", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8, typeof(QGenericArgument), val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$##########", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#########", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$########", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#######", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$######", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#####", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$####", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$###", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$##", "invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret, typeof(QGenericArgument), val0);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#", "invokeMethod(QObject*, const char*, QGenericReturnArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericReturnArgument), ret);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$##########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8, typeof(QGenericArgument), val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$########", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#######", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$######", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#####", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$####", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$###", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$##", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$#", "invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type, typeof(QGenericArgument), val0);
		}
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$$", "invokeMethod(QObject*, const char*, Qt::ConnectionType)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(Qt.ConnectionType), type);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$##########", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8, typeof(QGenericArgument), val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#########", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7, typeof(QGenericArgument), val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$########", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6, typeof(QGenericArgument), val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#######", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5, typeof(QGenericArgument), val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$######", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4, typeof(QGenericArgument), val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#####", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3, typeof(QGenericArgument), val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$####", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2, typeof(QGenericArgument), val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$###", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1, typeof(QGenericArgument), val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$##", "invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0, typeof(QGenericArgument), val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$#", "invokeMethod(QObject*, const char*, QGenericArgument)", typeof(bool), typeof(QObject), arg1, typeof(string), member, typeof(QGenericArgument), val0);
		}
		public static bool InvokeMethod(QObject arg1, string member) {
			return (bool) staticInterceptor.Invoke("invokeMethod#$", "invokeMethod(QObject*, const char*)", typeof(bool), typeof(QObject), arg1, typeof(string), member);
		}
	}
}
