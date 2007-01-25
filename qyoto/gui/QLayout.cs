//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QLayout")]
	public class QLayout : QObject, IQLayoutItem {
 		protected QLayout(Type dummy) : base((Type) null) {}
		interface IQLayoutProxy {
			string Tr(string s, string c);
			string Tr(string s);
			QSize ClosestAcceptableSize(QWidget w, QSize s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLayout), this);
			_interceptor = (QLayout) realProxy.GetTransparentProxy();
		}
		private QLayout ProxyQLayout() {
			return (QLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLayoutProxy), null);
			_staticInterceptor = (IQLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQLayoutProxy StaticQLayout() {
			return (IQLayoutProxy) _staticInterceptor;
		}

		public enum SizeConstraint {
			SetDefaultConstraint = 0,
			SetNoConstraint = 1,
			SetMinimumSize = 2,
			SetFixedSize = 3,
			SetMaximumSize = 4,
			SetMinAndMaxSize = 5,
		}
		public int Margin {
			get {
				return Property("margin").Value<int>();
			}
			set {
				SetProperty("margin", QVariant.FromValue<int>(value));
			}
		}
		public int Spacing {
			get {
				return Property("spacing").Value<int>();
			}
			set {
				SetProperty("spacing", QVariant.FromValue<int>(value));
			}
		}
		public QLayout.SizeConstraint sizeConstraint {
			get {
				return Property("sizeConstraint").Value<QLayout.SizeConstraint>();
			}
			set {
				SetProperty("sizeConstraint", QVariant.FromValue<QLayout.SizeConstraint>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QLayout(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQLayout(parent);
		}
		[SmokeMethod("QLayout(QWidget*)")]
		private void NewQLayout(QWidget parent) {
			ProxyQLayout().NewQLayout(parent);
		}
		public QLayout() : this((Type) null) {
			CreateProxy();
			NewQLayout();
		}
		[SmokeMethod("QLayout()")]
		private void NewQLayout() {
			ProxyQLayout().NewQLayout();
		}
		[SmokeMethod("setAlignment(QWidget*, Qt::Alignment)")]
		public bool SetAlignment(QWidget w, int alignment) {
			return ProxyQLayout().SetAlignment(w,alignment);
		}
		[SmokeMethod("setAlignment(QLayout*, Qt::Alignment)")]
		public bool SetAlignment(QLayout l, int alignment) {
			return ProxyQLayout().SetAlignment(l,alignment);
		}
		[SmokeMethod("setAlignment(Qt::Alignment)")]
		public void SetAlignment(int alignment) {
			ProxyQLayout().SetAlignment(alignment);
		}
		[SmokeMethod("setMenuBar(QWidget*)")]
		public void SetMenuBar(QWidget w) {
			ProxyQLayout().SetMenuBar(w);
		}
		[SmokeMethod("menuBar() const")]
		public QMenuBar MenuBar() {
			return ProxyQLayout().MenuBar();
		}
		[SmokeMethod("parentWidget() const")]
		public QWidget ParentWidget() {
			return ProxyQLayout().ParentWidget();
		}
		[SmokeMethod("invalidate()")]
		public void Invalidate() {
			ProxyQLayout().Invalidate();
		}
		[SmokeMethod("geometry() const")]
		public QRect Geometry() {
			return ProxyQLayout().Geometry();
		}
		[SmokeMethod("activate()")]
		public bool Activate() {
			return ProxyQLayout().Activate();
		}
		[SmokeMethod("update()")]
		public void Update() {
			ProxyQLayout().Update();
		}
		[SmokeMethod("addWidget(QWidget*)")]
		public void AddWidget(QWidget w) {
			ProxyQLayout().AddWidget(w);
		}
		[SmokeMethod("addItem(QLayoutItem*)")]
		public virtual void AddItem(IQLayoutItem arg1) {
			ProxyQLayout().AddItem(arg1);
		}
		[SmokeMethod("removeWidget(QWidget*)")]
		public void RemoveWidget(QWidget w) {
			ProxyQLayout().RemoveWidget(w);
		}
		[SmokeMethod("removeItem(QLayoutItem*)")]
		public void RemoveItem(IQLayoutItem arg1) {
			ProxyQLayout().RemoveItem(arg1);
		}
		[SmokeMethod("expandingDirections() const")]
		public int ExpandingDirections() {
			return ProxyQLayout().ExpandingDirections();
		}
		[SmokeMethod("minimumSize() const")]
		public QSize MinimumSize() {
			return ProxyQLayout().MinimumSize();
		}
		[SmokeMethod("maximumSize() const")]
		public QSize MaximumSize() {
			return ProxyQLayout().MaximumSize();
		}
		[SmokeMethod("setGeometry(const QRect&)")]
		public void SetGeometry(QRect arg1) {
			ProxyQLayout().SetGeometry(arg1);
		}
		[SmokeMethod("itemAt(int) const")]
		public virtual IQLayoutItem ItemAt(int index) {
			return ProxyQLayout().ItemAt(index);
		}
		[SmokeMethod("takeAt(int)")]
		public virtual IQLayoutItem TakeAt(int index) {
			return ProxyQLayout().TakeAt(index);
		}
		[SmokeMethod("indexOf(QWidget*) const")]
		public virtual int IndexOf(QWidget arg1) {
			return ProxyQLayout().IndexOf(arg1);
		}
		[SmokeMethod("count() const")]
		public virtual int Count() {
			return ProxyQLayout().Count();
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQLayout().IsEmpty();
		}
		[SmokeMethod("totalHeightForWidth(int) const")]
		public int TotalHeightForWidth(int w) {
			return ProxyQLayout().TotalHeightForWidth(w);
		}
		[SmokeMethod("totalMinimumSize() const")]
		public QSize TotalMinimumSize() {
			return ProxyQLayout().TotalMinimumSize();
		}
		[SmokeMethod("totalMaximumSize() const")]
		public QSize TotalMaximumSize() {
			return ProxyQLayout().TotalMaximumSize();
		}
		[SmokeMethod("totalSizeHint() const")]
		public QSize TotalSizeHint() {
			return ProxyQLayout().TotalSizeHint();
		}
		[SmokeMethod("layout()")]
		public QLayout Layout() {
			return ProxyQLayout().Layout();
		}
		[SmokeMethod("setEnabled(bool)")]
		public void SetEnabled(bool arg1) {
			ProxyQLayout().SetEnabled(arg1);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQLayout().IsEnabled();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQLayout().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQLayout().Tr(s);
		}
		[SmokeMethod("closestAcceptableSize(const QWidget*, const QSize&)")]
		public static QSize ClosestAcceptableSize(QWidget w, QSize s) {
			return StaticQLayout().ClosestAcceptableSize(w,s);
		}
		~QLayout() {
			DisposeQLayout();
		}
		public new void Dispose() {
			DisposeQLayout();
		}
		[SmokeMethod("~QLayout()")]
		private void DisposeQLayout() {
			ProxyQLayout().DisposeQLayout();
		}
		[SmokeMethod("sizeHint() const")]
		public virtual QSize SizeHint() {
			return ProxyQLayout().SizeHint();
		}
		[SmokeMethod("hasHeightForWidth() const")]
		public virtual bool HasHeightForWidth() {
			return ProxyQLayout().HasHeightForWidth();
		}
		[SmokeMethod("heightForWidth(int) const")]
		public virtual int HeightForWidth(int arg1) {
			return ProxyQLayout().HeightForWidth(arg1);
		}
		[SmokeMethod("minimumHeightForWidth(int) const")]
		public virtual int MinimumHeightForWidth(int arg1) {
			return ProxyQLayout().MinimumHeightForWidth(arg1);
		}
		[SmokeMethod("widget()")]
		public virtual QWidget Widget() {
			return ProxyQLayout().Widget();
		}
		[SmokeMethod("spacerItem()")]
		public virtual QSpacerItem SpacerItem() {
			return ProxyQLayout().SpacerItem();
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQLayout().Alignment();
		}
		protected new IQLayoutSignals Emit {
			get {
				return (IQLayoutSignals) Q_EMIT;
			}
		}
	}

	public interface IQLayoutSignals : IQObjectSignals {
	}
}
