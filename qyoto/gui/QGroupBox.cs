//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQGroupBoxSignals"></see> for signals emitted by QGroupBox
	[SmokeClass("QGroupBox")]
	public class QGroupBox : QWidget, IDisposable {
 		protected QGroupBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QGroupBox")]
		interface IQGroupBoxProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGroupBox), this);
			_interceptor = (QGroupBox) realProxy.GetTransparentProxy();
		}
		private QGroupBox ProxyQGroupBox() {
			return (QGroupBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGroupBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGroupBoxProxy), null);
			_staticInterceptor = (IQGroupBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQGroupBoxProxy StaticQGroupBox() {
			return (IQGroupBoxProxy) _staticInterceptor;
		}
		[Q_PROPERTY("QString", "title")]
		public string Title {
			get { return Property("title").Value<string>(); }
			set { SetProperty("title", QVariant.FromValue<string>(value)); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public int Alignment {
			get { return Property("alignment").Value<int>(); }
			set { SetProperty("alignment", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("bool", "flat")]
		public bool Flat {
			get { return Property("flat").Value<bool>(); }
			set { SetProperty("flat", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("bool", "checkable")]
		public bool Checkable {
			get { return Property("checkable").Value<bool>(); }
			set { SetProperty("checkable", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("bool", "checked")]
		public bool Checked {
			get { return Property("checked").Value<bool>(); }
			set { SetProperty("checked", QVariant.FromValue<bool>(value)); }
		}
		public QGroupBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGroupBox(parent);
		}
		[SmokeMethod("QGroupBox", "(QWidget*)", "#")]
		private void NewQGroupBox(QWidget parent) {
			ProxyQGroupBox().NewQGroupBox(parent);
		}
		public QGroupBox() : this((Type) null) {
			CreateProxy();
			NewQGroupBox();
		}
		[SmokeMethod("QGroupBox", "()", "")]
		private void NewQGroupBox() {
			ProxyQGroupBox().NewQGroupBox();
		}
		public QGroupBox(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGroupBox(title,parent);
		}
		[SmokeMethod("QGroupBox", "(const QString&, QWidget*)", "$#")]
		private void NewQGroupBox(string title, QWidget parent) {
			ProxyQGroupBox().NewQGroupBox(title,parent);
		}
		public QGroupBox(string title) : this((Type) null) {
			CreateProxy();
			NewQGroupBox(title);
		}
		[SmokeMethod("QGroupBox", "(const QString&)", "$")]
		private void NewQGroupBox(string title) {
			ProxyQGroupBox().NewQGroupBox(title);
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ProxyQGroupBox().MinimumSizeHint();
		}
		[SmokeMethod("isFlat", "() const", "")]
		public bool IsFlat() {
			return ProxyQGroupBox().IsFlat();
		}
		[SmokeMethod("isCheckable", "() const", "")]
		public bool IsCheckable() {
			return ProxyQGroupBox().IsCheckable();
		}
		[SmokeMethod("isChecked", "() const", "")]
		public bool IsChecked() {
			return ProxyQGroupBox().IsChecked();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent arg1) {
			return ProxyQGroupBox().Event(arg1);
		}
		[SmokeMethod("childEvent", "(QChildEvent*)", "#")]
		protected override void ChildEvent(QChildEvent arg1) {
			ProxyQGroupBox().ChildEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			ProxyQGroupBox().ResizeEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			ProxyQGroupBox().PaintEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			ProxyQGroupBox().FocusInEvent(arg1);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			ProxyQGroupBox().ChangeEvent(arg1);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			ProxyQGroupBox().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQGroupBox().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQGroupBox().MouseReleaseEvent(arg1);
		}
		~QGroupBox() {
			DisposeQGroupBox();
		}
		public new void Dispose() {
			DisposeQGroupBox();
		}
		[SmokeMethod("~QGroupBox", "()", "")]
		private void DisposeQGroupBox() {
			ProxyQGroupBox().DisposeQGroupBox();
		}
		public static string Tr(string s, string c) {
			return StaticQGroupBox().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQGroupBox().Tr(s);
		}
		protected new IQGroupBoxSignals Emit {
			get { return (IQGroupBoxSignals) Q_EMIT; }
		}
	}

	public interface IQGroupBoxSignals : IQWidgetSignals {
		[Q_SIGNAL("void clicked(bool)")]
		void Clicked(bool arg1);
		[Q_SIGNAL("void clicked()")]
		void Clicked();
		[Q_SIGNAL("void toggled(bool)")]
		void Toggled(bool arg1);
	}
}
