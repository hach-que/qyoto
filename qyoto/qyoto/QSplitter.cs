//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQSplitterSignals"></see> for signals emitted by QSplitter
	[SmokeClass("QSplitter")]
	public class QSplitter : QFrame, IDisposable {
 		protected QSplitter(Type dummy) : base((Type) null) {}
		interface IQSplitterProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSplitter), this);
			_interceptor = (QSplitter) realProxy.GetTransparentProxy();
		}
		private QSplitter ProxyQSplitter() {
			return (QSplitter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSplitter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSplitterProxy), null);
			_staticInterceptor = (IQSplitterProxy) realProxy.GetTransparentProxy();
		}
		private static IQSplitterProxy StaticQSplitter() {
			return (IQSplitterProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSplitter(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSplitter(parent);
		}
		[SmokeMethod("QSplitter(QWidget*)")]
		private void NewQSplitter(QWidget parent) {
			ProxyQSplitter().NewQSplitter(parent);
		}
		public QSplitter() : this((Type) null) {
			CreateProxy();
			NewQSplitter();
		}
		[SmokeMethod("QSplitter()")]
		private void NewQSplitter() {
			ProxyQSplitter().NewQSplitter();
		}
		public QSplitter(Qt.Orientation arg1, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSplitter(arg1,parent);
		}
		[SmokeMethod("QSplitter(Qt::Orientation, QWidget*)")]
		private void NewQSplitter(Qt.Orientation arg1, QWidget parent) {
			ProxyQSplitter().NewQSplitter(arg1,parent);
		}
		public QSplitter(Qt.Orientation arg1) : this((Type) null) {
			CreateProxy();
			NewQSplitter(arg1);
		}
		[SmokeMethod("QSplitter(Qt::Orientation)")]
		private void NewQSplitter(Qt.Orientation arg1) {
			ProxyQSplitter().NewQSplitter(arg1);
		}
		[SmokeMethod("addWidget(QWidget*)")]
		public void AddWidget(QWidget widget) {
			ProxyQSplitter().AddWidget(widget);
		}
		[SmokeMethod("insertWidget(int, QWidget*)")]
		public void InsertWidget(int index, QWidget widget) {
			ProxyQSplitter().InsertWidget(index,widget);
		}
		[SmokeMethod("setOrientation(Qt::Orientation)")]
		public void SetOrientation(Qt.Orientation arg1) {
			ProxyQSplitter().SetOrientation(arg1);
		}
		[SmokeMethod("orientation() const")]
		public Qt.Orientation Orientation() {
			return ProxyQSplitter().Orientation();
		}
		[SmokeMethod("setChildrenCollapsible(bool)")]
		public void SetChildrenCollapsible(bool arg1) {
			ProxyQSplitter().SetChildrenCollapsible(arg1);
		}
		[SmokeMethod("childrenCollapsible() const")]
		public bool ChildrenCollapsible() {
			return ProxyQSplitter().ChildrenCollapsible();
		}
		[SmokeMethod("setCollapsible(int, bool)")]
		public void SetCollapsible(int index, bool arg2) {
			ProxyQSplitter().SetCollapsible(index,arg2);
		}
		[SmokeMethod("isCollapsible(int) const")]
		public bool IsCollapsible(int index) {
			return ProxyQSplitter().IsCollapsible(index);
		}
		[SmokeMethod("setOpaqueResize(bool)")]
		public void SetOpaqueResize(bool opaque) {
			ProxyQSplitter().SetOpaqueResize(opaque);
		}
		[SmokeMethod("setOpaqueResize()")]
		public void SetOpaqueResize() {
			ProxyQSplitter().SetOpaqueResize();
		}
		[SmokeMethod("opaqueResize() const")]
		public bool OpaqueResize() {
			return ProxyQSplitter().OpaqueResize();
		}
		[SmokeMethod("refresh()")]
		public void Refresh() {
			ProxyQSplitter().Refresh();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQSplitter().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQSplitter().MinimumSizeHint();
		}
		[SmokeMethod("sizes() const")]
		public ArrayList Sizes() {
			return ProxyQSplitter().Sizes();
		}
		[SmokeMethod("setSizes(const QList<int>&)")]
		public void SetSizes(ArrayList list) {
			ProxyQSplitter().SetSizes(list);
		}
		[SmokeMethod("saveState() const")]
		public QByteArray SaveState() {
			return ProxyQSplitter().SaveState();
		}
		[SmokeMethod("restoreState(const QByteArray&)")]
		public bool RestoreState(QByteArray state) {
			return ProxyQSplitter().RestoreState(state);
		}
		[SmokeMethod("handleWidth() const")]
		public int HandleWidth() {
			return ProxyQSplitter().HandleWidth();
		}
		[SmokeMethod("setHandleWidth(int)")]
		public void SetHandleWidth(int arg1) {
			ProxyQSplitter().SetHandleWidth(arg1);
		}
		[SmokeMethod("indexOf(QWidget*) const")]
		public int IndexOf(QWidget w) {
			return ProxyQSplitter().IndexOf(w);
		}
		[SmokeMethod("widget(int) const")]
		public QWidget Widget(int index) {
			return ProxyQSplitter().Widget(index);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQSplitter().Count();
		}
		[SmokeMethod("getRange(int, int*, int*) const")]
		public void GetRange(int index, out int arg2, out int arg3) {
			ProxyQSplitter().GetRange(index,out arg2,out arg3);
		}
		[SmokeMethod("setStretchFactor(int, int)")]
		public void SetStretchFactor(int index, int stretch) {
			ProxyQSplitter().SetStretchFactor(index,stretch);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSplitter().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSplitter().Tr(s);
		}
		[SmokeMethod("createHandle()")]
		protected virtual QSplitterHandle CreateHandle() {
			return ProxyQSplitter().CreateHandle();
		}
		[SmokeMethod("childEvent(QChildEvent*)")]
		protected new void ChildEvent(QChildEvent arg1) {
			ProxyQSplitter().ChildEvent(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQSplitter().Event(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQSplitter().ResizeEvent(arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQSplitter().ChangeEvent(arg1);
		}
		[SmokeMethod("moveSplitter(int, int)")]
		protected void MoveSplitter(int pos, int index) {
			ProxyQSplitter().MoveSplitter(pos,index);
		}
		[SmokeMethod("setRubberBand(int)")]
		protected void SetRubberBand(int position) {
			ProxyQSplitter().SetRubberBand(position);
		}
		[SmokeMethod("closestLegalPosition(int, int)")]
		protected int ClosestLegalPosition(int arg1, int arg2) {
			return ProxyQSplitter().ClosestLegalPosition(arg1,arg2);
		}
		~QSplitter() {
			DisposeQSplitter();
		}
		public new void Dispose() {
			DisposeQSplitter();
		}
		[SmokeMethod("~QSplitter()")]
		private void DisposeQSplitter() {
			ProxyQSplitter().DisposeQSplitter();
		}
		protected new IQSplitterSignals Emit() {
			return (IQSplitterSignals) Q_EMIT;
		}
	}

	public interface IQSplitterSignals : IQFrameSignals {
		[Q_SIGNAL("void splitterMoved(int, int)")]
		void SplitterMoved(int pos, int index);
	}
}
