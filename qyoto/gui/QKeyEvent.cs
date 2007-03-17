//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QKeyEvent")]
	public class QKeyEvent : QInputEvent, IDisposable {
 		protected QKeyEvent(Type dummy) : base((Type) null) {}
		[SmokeClass("QKeyEvent")]
		interface IQKeyEventProxy {
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32, const QString&, bool, ushort)", "$$$$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep, ushort count);
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32, const QString&, bool)", "$$$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep);
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32, const QString&)", "$$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text);
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32)", "$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers);
			[SmokeMethod("operator==", "(QKeyEvent*, QKeySequence::StandardKey)", "#$")]
			bool op_equals(QKeyEvent e, QKeySequence.StandardKey key);
			[SmokeMethod("operator==", "(QKeySequence::StandardKey, QKeyEvent*)", "$#")]
			bool op_equals(QKeySequence.StandardKey key, QKeyEvent e);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QKeyEvent), this);
			interceptor = (QKeyEvent) realProxy.GetTransparentProxy();
		}
		private static IQKeyEventProxy staticInterceptor = null;
		static QKeyEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQKeyEventProxy), null);
			staticInterceptor = (IQKeyEventProxy) realProxy.GetTransparentProxy();
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep, ushort count) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text,autorep,count);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool, ushort)", "$$$$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep, ushort count) {
			((QKeyEvent) interceptor).NewQKeyEvent(type,key,modifiers,text,autorep,count);
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text,autorep);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool)", "$$$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep) {
			((QKeyEvent) interceptor).NewQKeyEvent(type,key,modifiers,text,autorep);
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, const QString&)", "$$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text) {
			((QKeyEvent) interceptor).NewQKeyEvent(type,key,modifiers,text);
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers)", "$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers) {
			((QKeyEvent) interceptor).NewQKeyEvent(type,key,modifiers);
		}
		[SmokeMethod("key", "() const", "")]
		public int Key() {
			return ((QKeyEvent) interceptor).Key();
		}
		[SmokeMethod("matches", "(QKeySequence::StandardKey) const", "$")]
		public bool Matches(QKeySequence.StandardKey key) {
			return ((QKeyEvent) interceptor).Matches(key);
		}
		[SmokeMethod("modifiers", "() const", "")]
		public int Modifiers() {
			return ((QKeyEvent) interceptor).Modifiers();
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ((QKeyEvent) interceptor).Text();
		}
		[SmokeMethod("isAutoRepeat", "() const", "")]
		public bool IsAutoRepeat() {
			return ((QKeyEvent) interceptor).IsAutoRepeat();
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ((QKeyEvent) interceptor).Count();
		}
		[SmokeMethod("hasExtendedInfo", "() const", "")]
		public bool HasExtendedInfo() {
			return ((QKeyEvent) interceptor).HasExtendedInfo();
		}
		[SmokeMethod("nativeScanCode", "() const", "")]
		public uint NativeScanCode() {
			return ((QKeyEvent) interceptor).NativeScanCode();
		}
		[SmokeMethod("nativeVirtualKey", "() const", "")]
		public uint NativeVirtualKey() {
			return ((QKeyEvent) interceptor).NativeVirtualKey();
		}
		[SmokeMethod("nativeModifiers", "() const", "")]
		public uint NativeModifiers() {
			return ((QKeyEvent) interceptor).NativeModifiers();
		}
		~QKeyEvent() {
			DisposeQKeyEvent();
		}
		public new void Dispose() {
			DisposeQKeyEvent();
		}
		[SmokeMethod("~QKeyEvent", "()", "")]
		private void DisposeQKeyEvent() {
			((QKeyEvent) interceptor).DisposeQKeyEvent();
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep, ushort count) {
			return staticInterceptor.CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers,text,autorep,count);
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep) {
			return staticInterceptor.CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers,text,autorep);
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text) {
			return staticInterceptor.CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers,text);
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers) {
			return staticInterceptor.CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers);
		}
		public static bool operator==(QKeyEvent e, QKeySequence.StandardKey key) {
			return staticInterceptor.op_equals(e,key);
		}
		public static bool operator!=(QKeyEvent e, QKeySequence.StandardKey key) {
			return !staticInterceptor.op_equals(e,key);
		}
		public static bool operator==(QKeySequence.StandardKey key, QKeyEvent e) {
			return staticInterceptor.op_equals(key,e);
		}
		public static bool operator!=(QKeySequence.StandardKey key, QKeyEvent e) {
			return !staticInterceptor.op_equals(key,e);
		}
	}
}
