//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QHGroupBox : QGroupBox, IDisposable {
 		protected QHGroupBox(Type dummy) : base((Type) null) {}
		interface IQHGroupBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQHGroupBoxProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHGroupBox), this);
			_interceptor = (QHGroupBox) realProxy.GetTransparentProxy();
		}
		private QHGroupBox ProxyQHGroupBox() {
			return (QHGroupBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHGroupBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHGroupBoxProxy), null);
			_staticInterceptor = (IQHGroupBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQHGroupBoxProxy StaticQHGroupBox() {
			return (IQHGroupBoxProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQHGroupBox().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQHGroupBox().ClassName();
		}
		public QHGroupBox(QWidget parent, string name) : this((Type) null) {
			CreateQHGroupBoxProxy();
			CreateQHGroupBoxSignalProxy();
			NewQHGroupBox(parent,name);
		}
		[SmokeMethod("QHGroupBox(QWidget*, const char*)")]
		private void NewQHGroupBox(QWidget parent, string name) {
			ProxyQHGroupBox().NewQHGroupBox(parent,name);
		}
		public QHGroupBox(QWidget parent) : this((Type) null) {
			CreateQHGroupBoxProxy();
			CreateQHGroupBoxSignalProxy();
			NewQHGroupBox(parent);
		}
		[SmokeMethod("QHGroupBox(QWidget*)")]
		private void NewQHGroupBox(QWidget parent) {
			ProxyQHGroupBox().NewQHGroupBox(parent);
		}
		public QHGroupBox() : this((Type) null) {
			CreateQHGroupBoxProxy();
			CreateQHGroupBoxSignalProxy();
			NewQHGroupBox();
		}
		[SmokeMethod("QHGroupBox()")]
		private void NewQHGroupBox() {
			ProxyQHGroupBox().NewQHGroupBox();
		}
		public QHGroupBox(string title, QWidget parent, string name) : this((Type) null) {
			CreateQHGroupBoxProxy();
			CreateQHGroupBoxSignalProxy();
			NewQHGroupBox(title,parent,name);
		}
		[SmokeMethod("QHGroupBox(const QString&, QWidget*, const char*)")]
		private void NewQHGroupBox(string title, QWidget parent, string name) {
			ProxyQHGroupBox().NewQHGroupBox(title,parent,name);
		}
		public QHGroupBox(string title, QWidget parent) : this((Type) null) {
			CreateQHGroupBoxProxy();
			CreateQHGroupBoxSignalProxy();
			NewQHGroupBox(title,parent);
		}
		[SmokeMethod("QHGroupBox(const QString&, QWidget*)")]
		private void NewQHGroupBox(string title, QWidget parent) {
			ProxyQHGroupBox().NewQHGroupBox(title,parent);
		}
		public QHGroupBox(string title) : this((Type) null) {
			CreateQHGroupBoxProxy();
			CreateQHGroupBoxSignalProxy();
			NewQHGroupBox(title);
		}
		[SmokeMethod("QHGroupBox(const QString&)")]
		private void NewQHGroupBox(string title) {
			ProxyQHGroupBox().NewQHGroupBox(title);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQHGroupBox().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQHGroupBox().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQHGroupBox().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQHGroupBox().TrUtf8(arg1);
		}
		~QHGroupBox() {
			DisposeQHGroupBox();
		}
		public new void Dispose() {
			DisposeQHGroupBox();
		}
		private void DisposeQHGroupBox() {
			ProxyQHGroupBox().DisposeQHGroupBox();
		}
		protected void CreateQHGroupBoxSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQHGroupBoxSignals), this);
			_signalInterceptor = (IQHGroupBoxSignals) realProxy.GetTransparentProxy();
		}
		protected new IQHGroupBoxSignals Emit() {
			return (IQHGroupBoxSignals) _signalInterceptor;
		}
	}

	public interface IQHGroupBoxSignals : IQGroupBoxSignals {
	}
}