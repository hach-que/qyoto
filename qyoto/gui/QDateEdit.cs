//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDateEdit")]
	public class QDateEdit : QDateTimeEdit, IDisposable {
 		protected QDateEdit(Type dummy) : base((Type) null) {}
		interface IQDateEditProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDateEdit), this);
			_interceptor = (QDateEdit) realProxy.GetTransparentProxy();
		}
		private QDateEdit ProxyQDateEdit() {
			return (QDateEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDateEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateEditProxy), null);
			_staticInterceptor = (IQDateEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateEditProxy StaticQDateEdit() {
			return (IQDateEditProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDateEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateEdit(parent);
		}
		[SmokeMethod("QDateEdit(QWidget*)")]
		private void NewQDateEdit(QWidget parent) {
			ProxyQDateEdit().NewQDateEdit(parent);
		}
		public QDateEdit() : this((Type) null) {
			CreateProxy();
			NewQDateEdit();
		}
		[SmokeMethod("QDateEdit()")]
		private void NewQDateEdit() {
			ProxyQDateEdit().NewQDateEdit();
		}
		public QDateEdit(QDate date, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDateEdit(date,parent);
		}
		[SmokeMethod("QDateEdit(const QDate&, QWidget*)")]
		private void NewQDateEdit(QDate date, QWidget parent) {
			ProxyQDateEdit().NewQDateEdit(date,parent);
		}
		public QDateEdit(QDate date) : this((Type) null) {
			CreateProxy();
			NewQDateEdit(date);
		}
		[SmokeMethod("QDateEdit(const QDate&)")]
		private void NewQDateEdit(QDate date) {
			ProxyQDateEdit().NewQDateEdit(date);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDateEdit().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDateEdit().Tr(s);
		}
		~QDateEdit() {
			DisposeQDateEdit();
		}
		public new void Dispose() {
			DisposeQDateEdit();
		}
		[SmokeMethod("~QDateEdit()")]
		private void DisposeQDateEdit() {
			ProxyQDateEdit().DisposeQDateEdit();
		}
		protected new IQDateEditSignals Emit {
			get {
				return (IQDateEditSignals) Q_EMIT;
			}
		}
	}

	public interface IQDateEditSignals : IQDateTimeEditSignals {
	}
}
