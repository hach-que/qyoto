//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQStackedLayoutSignals"></see> for signals emitted by QStackedLayout
	[SmokeClass("QStackedLayout")]
	public class QStackedLayout : QLayout, IDisposable {
 		protected QStackedLayout(Type dummy) : base((Type) null) {}
		interface IQStackedLayoutProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStackedLayout), this);
			_interceptor = (QStackedLayout) realProxy.GetTransparentProxy();
		}
		private QStackedLayout ProxyQStackedLayout() {
			return (QStackedLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStackedLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStackedLayoutProxy), null);
			_staticInterceptor = (IQStackedLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQStackedLayoutProxy StaticQStackedLayout() {
			return (IQStackedLayoutProxy) _staticInterceptor;
		}

		public int CurrentIndex {
			get {
				return Property("currentIndex").Value<int>();
			}
			set {
				SetProperty("currentIndex", QVariant.FromValue<int>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QStackedLayout() : this((Type) null) {
			CreateProxy();
			NewQStackedLayout();
		}
		[SmokeMethod("QStackedLayout()")]
		private void NewQStackedLayout() {
			ProxyQStackedLayout().NewQStackedLayout();
		}
		public QStackedLayout(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQStackedLayout(parent);
		}
		[SmokeMethod("QStackedLayout(QWidget*)")]
		private void NewQStackedLayout(QWidget parent) {
			ProxyQStackedLayout().NewQStackedLayout(parent);
		}
		public QStackedLayout(QLayout parentLayout) : this((Type) null) {
			CreateProxy();
			NewQStackedLayout(parentLayout);
		}
		[SmokeMethod("QStackedLayout(QLayout*)")]
		private void NewQStackedLayout(QLayout parentLayout) {
			ProxyQStackedLayout().NewQStackedLayout(parentLayout);
		}
		[SmokeMethod("addWidget(QWidget*)")]
		public new int AddWidget(QWidget w) {
			return ProxyQStackedLayout().AddWidget(w);
		}
		[SmokeMethod("insertWidget(int, QWidget*)")]
		public int InsertWidget(int index, QWidget w) {
			return ProxyQStackedLayout().InsertWidget(index,w);
		}
		[SmokeMethod("currentWidget() const")]
		public QWidget CurrentWidget() {
			return ProxyQStackedLayout().CurrentWidget();
		}
		[SmokeMethod("widget()")]
		public new QWidget Widget() {
			return ProxyQStackedLayout().Widget();
		}
		[SmokeMethod("widget(int) const")]
		public new QWidget Widget(int arg1) {
			return ProxyQStackedLayout().Widget(arg1);
		}
		[SmokeMethod("count() const")]
		public new int Count() {
			return ProxyQStackedLayout().Count();
		}
		[SmokeMethod("addItem(QLayoutItem*)")]
		public new void AddItem(IQLayoutItem item) {
			ProxyQStackedLayout().AddItem(item);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQStackedLayout().SizeHint();
		}
		[SmokeMethod("minimumSize() const")]
		public new QSize MinimumSize() {
			return ProxyQStackedLayout().MinimumSize();
		}
		[SmokeMethod("itemAt(int) const")]
		public new IQLayoutItem ItemAt(int arg1) {
			return ProxyQStackedLayout().ItemAt(arg1);
		}
		[SmokeMethod("takeAt(int)")]
		public new IQLayoutItem TakeAt(int arg1) {
			return ProxyQStackedLayout().TakeAt(arg1);
		}
		[SmokeMethod("setGeometry(const QRect&)")]
		public new void SetGeometry(QRect rect) {
			ProxyQStackedLayout().SetGeometry(rect);
		}
		[SmokeMethod("setCurrentWidget(QWidget*)")]
		public void SetCurrentWidget(QWidget w) {
			ProxyQStackedLayout().SetCurrentWidget(w);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQStackedLayout().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQStackedLayout().Tr(s);
		}
		~QStackedLayout() {
			DisposeQStackedLayout();
		}
		public new void Dispose() {
			DisposeQStackedLayout();
		}
		[SmokeMethod("~QStackedLayout()")]
		private void DisposeQStackedLayout() {
			ProxyQStackedLayout().DisposeQStackedLayout();
		}
		protected new IQStackedLayoutSignals Emit() {
			return (IQStackedLayoutSignals) Q_EMIT;
		}
	}

	public interface IQStackedLayoutSignals : IQLayoutSignals {
		[Q_SIGNAL("void widgetRemoved(int)")]
		void WidgetRemoved(int index);
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int index);
	}
}
