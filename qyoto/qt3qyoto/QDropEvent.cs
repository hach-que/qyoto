//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDropEvent : QEvent, IQMimeSource, IDisposable {
 		protected QDropEvent(Type dummy) : base((Type) null) {}
		interface IQDropEventProxy {
		}

		protected void CreateQDropEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDropEvent), this);
			_interceptor = (QDropEvent) realProxy.GetTransparentProxy();
		}
		private QDropEvent ProxyQDropEvent() {
			return (QDropEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDropEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDropEventProxy), null);
			_staticInterceptor = (IQDropEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQDropEventProxy StaticQDropEvent() {
			return (IQDropEventProxy) _staticInterceptor;
		}

		enum E_Action {
			Copy = 0,
			Link = 1,
			Move = 2,
			Private = 3,
			UserAction = 100,
		}
		public QDropEvent(QPoint pos, int typ) : this((Type) null) {
			CreateQDropEventProxy();
			NewQDropEvent(pos,typ);
		}
		[SmokeMethod("QDropEvent(const QPoint&, QEvent::Type)")]
		private void NewQDropEvent(QPoint pos, int typ) {
			ProxyQDropEvent().NewQDropEvent(pos,typ);
		}
		public QDropEvent(QPoint pos) : this((Type) null) {
			CreateQDropEventProxy();
			NewQDropEvent(pos);
		}
		[SmokeMethod("QDropEvent(const QPoint&)")]
		private void NewQDropEvent(QPoint pos) {
			ProxyQDropEvent().NewQDropEvent(pos);
		}
		[SmokeMethod("pos() const")]
		public QPoint Pos() {
			return ProxyQDropEvent().Pos();
		}
		[SmokeMethod("isAccepted() const")]
		public bool IsAccepted() {
			return ProxyQDropEvent().IsAccepted();
		}
		[SmokeMethod("accept(bool)")]
		public void Accept(bool y) {
			ProxyQDropEvent().Accept(y);
		}
		[SmokeMethod("accept()")]
		public void Accept() {
			ProxyQDropEvent().Accept();
		}
		[SmokeMethod("ignore()")]
		public void Ignore() {
			ProxyQDropEvent().Ignore();
		}
		[SmokeMethod("isActionAccepted() const")]
		public bool IsActionAccepted() {
			return ProxyQDropEvent().IsActionAccepted();
		}
		[SmokeMethod("acceptAction(bool)")]
		public void AcceptAction(bool y) {
			ProxyQDropEvent().AcceptAction(y);
		}
		[SmokeMethod("acceptAction()")]
		public void AcceptAction() {
			ProxyQDropEvent().AcceptAction();
		}
		[SmokeMethod("setAction(QDropEvent::Action)")]
		public void SetAction(int a) {
			ProxyQDropEvent().SetAction(a);
		}
		[SmokeMethod("action() const")]
		public int Action() {
			return ProxyQDropEvent().Action();
		}
		[SmokeMethod("source() const")]
		public QWidget Source() {
			return ProxyQDropEvent().Source();
		}
		[SmokeMethod("format(int) const")]
		public string Format(int n) {
			return ProxyQDropEvent().Format(n);
		}
		[SmokeMethod("format() const")]
		public string Format() {
			return ProxyQDropEvent().Format();
		}
		[SmokeMethod("encodedData(const char*) const")]
		public QByteArray EncodedData(string arg1) {
			return ProxyQDropEvent().EncodedData(arg1);
		}
		[SmokeMethod("provides(const char*) const")]
		public bool Provides(string arg1) {
			return ProxyQDropEvent().Provides(arg1);
		}
		[SmokeMethod("data(const char*) const")]
		public QByteArray Data(string f) {
			return ProxyQDropEvent().Data(f);
		}
		[SmokeMethod("setPoint(const QPoint&)")]
		public void SetPoint(QPoint np) {
			ProxyQDropEvent().SetPoint(np);
		}
		~QDropEvent() {
			DisposeQDropEvent();
		}
		public new void Dispose() {
			DisposeQDropEvent();
		}
		private void DisposeQDropEvent() {
			ProxyQDropEvent().DisposeQDropEvent();
		}
		[SmokeMethod("serialNumber() const")]
		public int SerialNumber() {
			return ProxyQDropEvent().SerialNumber();
		}
	}
}