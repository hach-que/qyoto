//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QFrame")]
	public class QFrame : QWidget, IDisposable {
 		protected QFrame(Type dummy) : base((Type) null) {}
		interface IQFrameProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFrame), this);
			_interceptor = (QFrame) realProxy.GetTransparentProxy();
		}
		private QFrame ProxyQFrame() {
			return (QFrame) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFrame() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFrameProxy), null);
			_staticInterceptor = (IQFrameProxy) realProxy.GetTransparentProxy();
		}
		private static IQFrameProxy StaticQFrame() {
			return (IQFrameProxy) _staticInterceptor;
		}

		public enum Shape {
			NoFrame = 0,
			Box = 0x0001,
			Panel = 0x0002,
			WinPanel = 0x0003,
			HLine = 0x0004,
			VLine = 0x0005,
			StyledPanel = 0x0006,
		}
		public enum Shadow {
			Plain = 0x0010,
			Raised = 0x0020,
			Sunken = 0x0030,
		}
		public enum StyleMask {
			Shadow_Mask = 0x00f0,
			Shape_Mask = 0x000f,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QFrame(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQFrame(parent,f);
		}
		[SmokeMethod("QFrame(QWidget*, Qt::WindowFlags)")]
		private void NewQFrame(QWidget parent, int f) {
			ProxyQFrame().NewQFrame(parent,f);
		}
		public QFrame(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQFrame(parent);
		}
		[SmokeMethod("QFrame(QWidget*)")]
		private void NewQFrame(QWidget parent) {
			ProxyQFrame().NewQFrame(parent);
		}
		public QFrame() : this((Type) null) {
			CreateProxy();
			NewQFrame();
		}
		[SmokeMethod("QFrame()")]
		private void NewQFrame() {
			ProxyQFrame().NewQFrame();
		}
		[SmokeMethod("frameStyle() const")]
		public int FrameStyle() {
			return ProxyQFrame().FrameStyle();
		}
		[SmokeMethod("setFrameStyle(int)")]
		public void SetFrameStyle(int arg1) {
			ProxyQFrame().SetFrameStyle(arg1);
		}
		[SmokeMethod("frameWidth() const")]
		public int FrameWidth() {
			return ProxyQFrame().FrameWidth();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQFrame().SizeHint();
		}
		[SmokeMethod("frameShape() const")]
		public QFrame.Shape FrameShape() {
			return ProxyQFrame().FrameShape();
		}
		[SmokeMethod("setFrameShape(QFrame::Shape)")]
		public void SetFrameShape(QFrame.Shape arg1) {
			ProxyQFrame().SetFrameShape(arg1);
		}
		[SmokeMethod("frameShadow() const")]
		public QFrame.Shadow FrameShadow() {
			return ProxyQFrame().FrameShadow();
		}
		[SmokeMethod("setFrameShadow(QFrame::Shadow)")]
		public void SetFrameShadow(QFrame.Shadow arg1) {
			ProxyQFrame().SetFrameShadow(arg1);
		}
		[SmokeMethod("lineWidth() const")]
		public int LineWidth() {
			return ProxyQFrame().LineWidth();
		}
		[SmokeMethod("setLineWidth(int)")]
		public void SetLineWidth(int arg1) {
			ProxyQFrame().SetLineWidth(arg1);
		}
		[SmokeMethod("midLineWidth() const")]
		public int MidLineWidth() {
			return ProxyQFrame().MidLineWidth();
		}
		[SmokeMethod("setMidLineWidth(int)")]
		public void SetMidLineWidth(int arg1) {
			ProxyQFrame().SetMidLineWidth(arg1);
		}
		[SmokeMethod("frameRect() const")]
		public QRect FrameRect() {
			return ProxyQFrame().FrameRect();
		}
		[SmokeMethod("setFrameRect(const QRect&)")]
		public void SetFrameRect(QRect arg1) {
			ProxyQFrame().SetFrameRect(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQFrame().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQFrame().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQFrame().Event(e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQFrame().PaintEvent(arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQFrame().ChangeEvent(arg1);
		}
		[SmokeMethod("drawFrame(QPainter*)")]
		protected void DrawFrame(QPainter arg1) {
			ProxyQFrame().DrawFrame(arg1);
		}
		~QFrame() {
			DisposeQFrame();
		}
		public new void Dispose() {
			DisposeQFrame();
		}
		[SmokeMethod("~QFrame()")]
		private void DisposeQFrame() {
			ProxyQFrame().DisposeQFrame();
		}
		protected new IQFrameSignals Emit() {
			return (IQFrameSignals) Q_EMIT;
		}
	}

	public interface IQFrameSignals : IQWidgetSignals {
	}
}