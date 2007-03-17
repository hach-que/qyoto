//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTimeEdit")]
	public class QTimeEdit : QDateTimeEdit, IDisposable {
 		protected QTimeEdit(Type dummy) : base((Type) null) {}
		[SmokeClass("QTimeEdit")]
		interface IQTimeEditProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTimeEdit), this);
			interceptor = (QTimeEdit) realProxy.GetTransparentProxy();
		}
		private static IQTimeEditProxy staticInterceptor = null;
		static QTimeEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTimeEditProxy), null);
			staticInterceptor = (IQTimeEditProxy) realProxy.GetTransparentProxy();
		}
		public QTimeEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTimeEdit(parent);
		}
		[SmokeMethod("QTimeEdit", "(QWidget*)", "#")]
		private void NewQTimeEdit(QWidget parent) {
			((QTimeEdit) interceptor).NewQTimeEdit(parent);
		}
		public QTimeEdit() : this((Type) null) {
			CreateProxy();
			NewQTimeEdit();
		}
		[SmokeMethod("QTimeEdit", "()", "")]
		private void NewQTimeEdit() {
			((QTimeEdit) interceptor).NewQTimeEdit();
		}
		public QTimeEdit(QTime time, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTimeEdit(time,parent);
		}
		[SmokeMethod("QTimeEdit", "(const QTime&, QWidget*)", "##")]
		private void NewQTimeEdit(QTime time, QWidget parent) {
			((QTimeEdit) interceptor).NewQTimeEdit(time,parent);
		}
		public QTimeEdit(QTime time) : this((Type) null) {
			CreateProxy();
			NewQTimeEdit(time);
		}
		[SmokeMethod("QTimeEdit", "(const QTime&)", "#")]
		private void NewQTimeEdit(QTime time) {
			((QTimeEdit) interceptor).NewQTimeEdit(time);
		}
		~QTimeEdit() {
			DisposeQTimeEdit();
		}
		public new void Dispose() {
			DisposeQTimeEdit();
		}
		[SmokeMethod("~QTimeEdit", "()", "")]
		private void DisposeQTimeEdit() {
			((QTimeEdit) interceptor).DisposeQTimeEdit();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQTimeEditSignals Emit {
			get { return (IQTimeEditSignals) Q_EMIT; }
		}
	}

	public interface IQTimeEditSignals : IQDateTimeEditSignals {
	}
}
