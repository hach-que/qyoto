//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QCanvasView : QScrollView, IDisposable {
 		protected QCanvasView(Type dummy) : base((Type) null) {}
		interface IQCanvasViewProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQCanvasViewProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCanvasView), this);
			_interceptor = (QCanvasView) realProxy.GetTransparentProxy();
		}
		private QCanvasView ProxyQCanvasView() {
			return (QCanvasView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCanvasView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCanvasViewProxy), null);
			_staticInterceptor = (IQCanvasViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQCanvasViewProxy StaticQCanvasView() {
			return (IQCanvasViewProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQCanvasView().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQCanvasView().ClassName();
		}
		public QCanvasView(QWidget parent, string name, int f) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(parent,name,f);
		}
		[SmokeMethod("QCanvasView(QWidget*, const char*, Qt::WFlags)")]
		private void NewQCanvasView(QWidget parent, string name, int f) {
			ProxyQCanvasView().NewQCanvasView(parent,name,f);
		}
		public QCanvasView(QWidget parent, string name) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(parent,name);
		}
		[SmokeMethod("QCanvasView(QWidget*, const char*)")]
		private void NewQCanvasView(QWidget parent, string name) {
			ProxyQCanvasView().NewQCanvasView(parent,name);
		}
		public QCanvasView(QWidget parent) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(parent);
		}
		[SmokeMethod("QCanvasView(QWidget*)")]
		private void NewQCanvasView(QWidget parent) {
			ProxyQCanvasView().NewQCanvasView(parent);
		}
		public QCanvasView() : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView();
		}
		[SmokeMethod("QCanvasView()")]
		private void NewQCanvasView() {
			ProxyQCanvasView().NewQCanvasView();
		}
		public QCanvasView(QCanvas viewing, QWidget parent, string name, int f) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(viewing,parent,name,f);
		}
		[SmokeMethod("QCanvasView(QCanvas*, QWidget*, const char*, Qt::WFlags)")]
		private void NewQCanvasView(QCanvas viewing, QWidget parent, string name, int f) {
			ProxyQCanvasView().NewQCanvasView(viewing,parent,name,f);
		}
		public QCanvasView(QCanvas viewing, QWidget parent, string name) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(viewing,parent,name);
		}
		[SmokeMethod("QCanvasView(QCanvas*, QWidget*, const char*)")]
		private void NewQCanvasView(QCanvas viewing, QWidget parent, string name) {
			ProxyQCanvasView().NewQCanvasView(viewing,parent,name);
		}
		public QCanvasView(QCanvas viewing, QWidget parent) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(viewing,parent);
		}
		[SmokeMethod("QCanvasView(QCanvas*, QWidget*)")]
		private void NewQCanvasView(QCanvas viewing, QWidget parent) {
			ProxyQCanvasView().NewQCanvasView(viewing,parent);
		}
		public QCanvasView(QCanvas viewing) : this((Type) null) {
			CreateQCanvasViewProxy();
			CreateQCanvasViewSignalProxy();
			NewQCanvasView(viewing);
		}
		[SmokeMethod("QCanvasView(QCanvas*)")]
		private void NewQCanvasView(QCanvas viewing) {
			ProxyQCanvasView().NewQCanvasView(viewing);
		}
		[SmokeMethod("canvas() const")]
		public QCanvas Canvas() {
			return ProxyQCanvasView().Canvas();
		}
		[SmokeMethod("setCanvas(QCanvas*)")]
		public void SetCanvas(QCanvas v) {
			ProxyQCanvasView().SetCanvas(v);
		}
		[SmokeMethod("worldMatrix() const")]
		public QWMatrix WorldMatrix() {
			return ProxyQCanvasView().WorldMatrix();
		}
		[SmokeMethod("inverseWorldMatrix() const")]
		public QWMatrix InverseWorldMatrix() {
			return ProxyQCanvasView().InverseWorldMatrix();
		}
		[SmokeMethod("setWorldMatrix(const QWMatrix&)")]
		public bool SetWorldMatrix(QWMatrix arg1) {
			return ProxyQCanvasView().SetWorldMatrix(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQCanvasView().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQCanvasView().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQCanvasView().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQCanvasView().TrUtf8(arg1);
		}
		[SmokeMethod("drawContents(QPainter*, int, int, int, int)")]
		protected new void DrawContents(QPainter arg1, int cx, int cy, int cw, int ch) {
			ProxyQCanvasView().DrawContents(arg1,cx,cy,cw,ch);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQCanvasView().SizeHint();
		}
		~QCanvasView() {
			DisposeQCanvasView();
		}
		public new void Dispose() {
			DisposeQCanvasView();
		}
		private void DisposeQCanvasView() {
			ProxyQCanvasView().DisposeQCanvasView();
		}
		protected void CreateQCanvasViewSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQCanvasViewSignals), this);
			_signalInterceptor = (IQCanvasViewSignals) realProxy.GetTransparentProxy();
		}
		protected new IQCanvasViewSignals Emit() {
			return (IQCanvasViewSignals) _signalInterceptor;
		}
	}

	public interface IQCanvasViewSignals : IQScrollViewSignals {
	}
}