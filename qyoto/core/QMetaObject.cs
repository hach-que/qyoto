//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QMetaObject")]
	public class QMetaObject : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QMetaObject(Type dummy) {}
		interface IQMetaObjectProxy {
			bool CheckConnectArgs(string signal, string method);
			QByteArray NormalizedSignature(string method);
			QByteArray NormalizedType(string type);
			bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type, out int types);
			bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type);
			bool Connect(QObject sender, int signal_index, QObject receiver, int method_index);
			bool Disconnect(QObject sender, int signal_index, QObject receiver, int method_index);
			void ConnectSlotsByName(QObject o);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaObject), this);
			_interceptor = (QMetaObject) realProxy.GetTransparentProxy();
		}
		private QMetaObject ProxyQMetaObject() {
			return (QMetaObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaObjectProxy), null);
			_staticInterceptor = (IQMetaObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaObjectProxy StaticQMetaObject() {
			return (IQMetaObjectProxy) _staticInterceptor;
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
		[SmokeMethod("className() const")]
		public string ClassName() {
			return ProxyQMetaObject().ClassName();
		}
		[SmokeMethod("superClass() const")]
		public QMetaObject SuperClass() {
			return ProxyQMetaObject().SuperClass();
		}
		[SmokeMethod("cast(QObject*) const")]
		public QObject Cast(QObject arg1) {
			return ProxyQMetaObject().Cast(arg1);
		}
		[SmokeMethod("tr(const char*, const char*) const")]
		public string Tr(string s, string c) {
			return ProxyQMetaObject().Tr(s,c);
		}
		[SmokeMethod("trUtf8(const char*, const char*) const")]
		public string TrUtf8(string s, string c) {
			return ProxyQMetaObject().TrUtf8(s,c);
		}
		[SmokeMethod("tr(const char*, const char*, int) const")]
		public string Tr(string s, string c, int n) {
			return ProxyQMetaObject().Tr(s,c,n);
		}
		[SmokeMethod("trUtf8(const char*, const char*, int) const")]
		public string TrUtf8(string s, string c, int n) {
			return ProxyQMetaObject().TrUtf8(s,c,n);
		}
		[SmokeMethod("methodOffset() const")]
		public int MethodOffset() {
			return ProxyQMetaObject().MethodOffset();
		}
		[SmokeMethod("enumeratorOffset() const")]
		public int EnumeratorOffset() {
			return ProxyQMetaObject().EnumeratorOffset();
		}
		[SmokeMethod("propertyOffset() const")]
		public int PropertyOffset() {
			return ProxyQMetaObject().PropertyOffset();
		}
		[SmokeMethod("classInfoOffset() const")]
		public int ClassInfoOffset() {
			return ProxyQMetaObject().ClassInfoOffset();
		}
		[SmokeMethod("methodCount() const")]
		public int MethodCount() {
			return ProxyQMetaObject().MethodCount();
		}
		[SmokeMethod("enumeratorCount() const")]
		public int EnumeratorCount() {
			return ProxyQMetaObject().EnumeratorCount();
		}
		[SmokeMethod("propertyCount() const")]
		public int PropertyCount() {
			return ProxyQMetaObject().PropertyCount();
		}
		[SmokeMethod("classInfoCount() const")]
		public int ClassInfoCount() {
			return ProxyQMetaObject().ClassInfoCount();
		}
		[SmokeMethod("indexOfMethod(const char*) const")]
		public int IndexOfMethod(string method) {
			return ProxyQMetaObject().IndexOfMethod(method);
		}
		[SmokeMethod("indexOfSignal(const char*) const")]
		public int IndexOfSignal(string signal) {
			return ProxyQMetaObject().IndexOfSignal(signal);
		}
		[SmokeMethod("indexOfSlot(const char*) const")]
		public int IndexOfSlot(string slot) {
			return ProxyQMetaObject().IndexOfSlot(slot);
		}
		[SmokeMethod("indexOfEnumerator(const char*) const")]
		public int IndexOfEnumerator(string name) {
			return ProxyQMetaObject().IndexOfEnumerator(name);
		}
		[SmokeMethod("indexOfProperty(const char*) const")]
		public int IndexOfProperty(string name) {
			return ProxyQMetaObject().IndexOfProperty(name);
		}
		[SmokeMethod("indexOfClassInfo(const char*) const")]
		public int IndexOfClassInfo(string name) {
			return ProxyQMetaObject().IndexOfClassInfo(name);
		}
		[SmokeMethod("method(int) const")]
		public QMetaMethod Method(int index) {
			return ProxyQMetaObject().Method(index);
		}
		[SmokeMethod("enumerator(int) const")]
		public QMetaEnum Enumerator(int index) {
			return ProxyQMetaObject().Enumerator(index);
		}
		[SmokeMethod("property(int) const")]
		public QMetaProperty Property(int index) {
			return ProxyQMetaObject().Property(index);
		}
		[SmokeMethod("classInfo(int) const")]
		public QMetaClassInfo ClassInfo(int index) {
			return ProxyQMetaObject().ClassInfo(index);
		}
		[SmokeMethod("userProperty() const")]
		public QMetaProperty UserProperty() {
			return ProxyQMetaObject().UserProperty();
		}
		public QMetaObject() : this((Type) null) {
			CreateProxy();
			NewQMetaObject();
		}
		[SmokeMethod("QMetaObject()")]
		private void NewQMetaObject() {
			ProxyQMetaObject().NewQMetaObject();
		}
		[SmokeMethod("checkConnectArgs(const char*, const char*)")]
		public static bool CheckConnectArgs(string signal, string method) {
			return StaticQMetaObject().CheckConnectArgs(signal,method);
		}
		[SmokeMethod("normalizedSignature(const char*)")]
		public static QByteArray NormalizedSignature(string method) {
			return StaticQMetaObject().NormalizedSignature(method);
		}
		[SmokeMethod("normalizedType(const char*)")]
		public static QByteArray NormalizedType(string type) {
			return StaticQMetaObject().NormalizedType(type);
		}
		[SmokeMethod("connect(const QObject*, int, const QObject*, int, int, int*)")]
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type, out int types) {
			return StaticQMetaObject().Connect(sender,signal_index,receiver,method_index,type,out types);
		}
		[SmokeMethod("connect(const QObject*, int, const QObject*, int, int)")]
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type) {
			return StaticQMetaObject().Connect(sender,signal_index,receiver,method_index,type);
		}
		[SmokeMethod("connect(const QObject*, int, const QObject*, int)")]
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index) {
			return StaticQMetaObject().Connect(sender,signal_index,receiver,method_index);
		}
		[SmokeMethod("disconnect(const QObject*, int, const QObject*, int)")]
		public static bool Disconnect(QObject sender, int signal_index, QObject receiver, int method_index) {
			return StaticQMetaObject().Disconnect(sender,signal_index,receiver,method_index);
		}
		[SmokeMethod("connectSlotsByName(QObject*)")]
		public static void ConnectSlotsByName(QObject o) {
			StaticQMetaObject().ConnectSlotsByName(o);
		}
		// void activate(QObject* arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		// void activate(QObject* arg1,int arg2,int arg3,void** arg4); >>>> NOT CONVERTED
		// void activate(QObject* arg1,const QMetaObject* arg2,int arg3,void** arg4); >>>> NOT CONVERTED
		// void activate(QObject* arg1,const QMetaObject* arg2,int arg3,int arg4,void** arg5); >>>> NOT CONVERTED
		// void addGuard(QObject** arg1); >>>> NOT CONVERTED
		// void removeGuard(QObject** arg1); >>>> NOT CONVERTED
		// void changeGuard(QObject** arg1,QObject* arg2); >>>> NOT CONVERTED
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericReturnArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType arg3, QGenericReturnArgument ret) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericReturnArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, Qt::ConnectionType)")]
		public static bool InvokeMethod(QObject arg1, string member, Qt.ConnectionType type) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*, QGenericArgument)")]
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0);
		}
		[SmokeMethod("invokeMethod(QObject*, const char*)")]
		public static bool InvokeMethod(QObject arg1, string member) {
			return StaticQMetaObject().InvokeMethod(arg1,member);
		}
		~QMetaObject() {
			DisposeQMetaObject();
		}
		public void Dispose() {
			DisposeQMetaObject();
		}
		[SmokeMethod("~QMetaObject()")]
		private void DisposeQMetaObject() {
			ProxyQMetaObject().DisposeQMetaObject();
		}
	}
}