//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QKeyEvent")]
	public class QKeyEvent : QInputEvent, IDisposable {
 		protected QKeyEvent(Type dummy) : base((Type) null) {}
		interface IQKeyEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QKeyEvent), this);
			_interceptor = (QKeyEvent) realProxy.GetTransparentProxy();
		}
		private QKeyEvent ProxyQKeyEvent() {
			return (QKeyEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QKeyEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQKeyEventProxy), null);
			_staticInterceptor = (IQKeyEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQKeyEventProxy StaticQKeyEvent() {
			return (IQKeyEventProxy) _staticInterceptor;
		}

		public QKeyEvent(QEvent.E_Type type, int key, int modifiers, string text, bool autorep, ushort count) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text,autorep,count);
		}
		[SmokeMethod("QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool, ushort)")]
		private void NewQKeyEvent(QEvent.E_Type type, int key, int modifiers, string text, bool autorep, ushort count) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers,text,autorep,count);
		}
		public QKeyEvent(QEvent.E_Type type, int key, int modifiers, string text, bool autorep) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text,autorep);
		}
		[SmokeMethod("QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool)")]
		private void NewQKeyEvent(QEvent.E_Type type, int key, int modifiers, string text, bool autorep) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers,text,autorep);
		}
		public QKeyEvent(QEvent.E_Type type, int key, int modifiers, string text) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text);
		}
		[SmokeMethod("QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, const QString&)")]
		private void NewQKeyEvent(QEvent.E_Type type, int key, int modifiers, string text) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers,text);
		}
		public QKeyEvent(QEvent.E_Type type, int key, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers);
		}
		[SmokeMethod("QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers)")]
		private void NewQKeyEvent(QEvent.E_Type type, int key, int modifiers) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers);
		}
		[SmokeMethod("key() const")]
		public int Key() {
			return ProxyQKeyEvent().Key();
		}
		[SmokeMethod("modifiers() const")]
		public new int Modifiers() {
			return ProxyQKeyEvent().Modifiers();
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQKeyEvent().Text();
		}
		[SmokeMethod("isAutoRepeat() const")]
		public bool IsAutoRepeat() {
			return ProxyQKeyEvent().IsAutoRepeat();
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQKeyEvent().Count();
		}
		~QKeyEvent() {
			DisposeQKeyEvent();
		}
		public new void Dispose() {
			DisposeQKeyEvent();
		}
		[SmokeMethod("~QKeyEvent()")]
		private void DisposeQKeyEvent() {
			ProxyQKeyEvent().DisposeQKeyEvent();
		}
	}
}
