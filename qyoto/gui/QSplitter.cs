//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQSplitterSignals"></see> for signals emitted by QSplitter
	[SmokeClass("QSplitter")]
	public class QSplitter : QFrame, IDisposable {
 		protected QSplitter(Type dummy) : base((Type) null) {}
		[SmokeClass("QSplitter")]
		interface IQSplitterProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSplitter), this);
			interceptor = (QSplitter) realProxy.GetTransparentProxy();
		}
		private static IQSplitterProxy staticInterceptor = null;
		static QSplitter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSplitterProxy), null);
			staticInterceptor = (IQSplitterProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			get { return Property("orientation").Value<Qt.Orientation>(); }
			set { SetProperty("orientation", QVariant.FromValue<Qt.Orientation>(value)); }
		}
		[Q_PROPERTY("bool", "opaqueResize")]
		public bool OpaqueResize {
			get { return Property("opaqueResize").Value<bool>(); }
			set { SetProperty("opaqueResize", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("int", "handleWidth")]
		public int HandleWidth {
			get { return Property("handleWidth").Value<int>(); }
			set { SetProperty("handleWidth", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("bool", "childrenCollapsible")]
		public bool ChildrenCollapsible {
			get { return Property("childrenCollapsible").Value<bool>(); }
			set { SetProperty("childrenCollapsible", QVariant.FromValue<bool>(value)); }
		}
		public QSplitter(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSplitter(parent);
		}
		[SmokeMethod("QSplitter", "(QWidget*)", "#")]
		private void NewQSplitter(QWidget parent) {
			((QSplitter) interceptor).NewQSplitter(parent);
		}
		public QSplitter() : this((Type) null) {
			CreateProxy();
			NewQSplitter();
		}
		[SmokeMethod("QSplitter", "()", "")]
		private void NewQSplitter() {
			((QSplitter) interceptor).NewQSplitter();
		}
		public QSplitter(Qt.Orientation arg1, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSplitter(arg1,parent);
		}
		[SmokeMethod("QSplitter", "(Qt::Orientation, QWidget*)", "$#")]
		private void NewQSplitter(Qt.Orientation arg1, QWidget parent) {
			((QSplitter) interceptor).NewQSplitter(arg1,parent);
		}
		public QSplitter(Qt.Orientation arg1) : this((Type) null) {
			CreateProxy();
			NewQSplitter(arg1);
		}
		[SmokeMethod("QSplitter", "(Qt::Orientation)", "$")]
		private void NewQSplitter(Qt.Orientation arg1) {
			((QSplitter) interceptor).NewQSplitter(arg1);
		}
		[SmokeMethod("addWidget", "(QWidget*)", "#")]
		public void AddWidget(QWidget widget) {
			((QSplitter) interceptor).AddWidget(widget);
		}
		[SmokeMethod("insertWidget", "(int, QWidget*)", "$#")]
		public void InsertWidget(int index, QWidget widget) {
			((QSplitter) interceptor).InsertWidget(index,widget);
		}
		[SmokeMethod("setCollapsible", "(int, bool)", "$$")]
		public void SetCollapsible(int index, bool arg2) {
			((QSplitter) interceptor).SetCollapsible(index,arg2);
		}
		[SmokeMethod("isCollapsible", "(int) const", "$")]
		public bool IsCollapsible(int index) {
			return ((QSplitter) interceptor).IsCollapsible(index);
		}
		[SmokeMethod("refresh", "()", "")]
		public void Refresh() {
			((QSplitter) interceptor).Refresh();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QSplitter) interceptor).SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ((QSplitter) interceptor).MinimumSizeHint();
		}
		[SmokeMethod("sizes", "() const", "")]
		public List<int> Sizes() {
			return ((QSplitter) interceptor).Sizes();
		}
		[SmokeMethod("setSizes", "(const QList<int>&)", "?")]
		public void SetSizes(List<int> list) {
			((QSplitter) interceptor).SetSizes(list);
		}
		[SmokeMethod("saveState", "() const", "")]
		public QByteArray SaveState() {
			return ((QSplitter) interceptor).SaveState();
		}
		[SmokeMethod("restoreState", "(const QByteArray&)", "#")]
		public bool RestoreState(QByteArray state) {
			return ((QSplitter) interceptor).RestoreState(state);
		}
		[SmokeMethod("indexOf", "(QWidget*) const", "#")]
		public int IndexOf(QWidget w) {
			return ((QSplitter) interceptor).IndexOf(w);
		}
		[SmokeMethod("widget", "(int) const", "$")]
		public QWidget Widget(int index) {
			return ((QSplitter) interceptor).Widget(index);
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ((QSplitter) interceptor).Count();
		}
		[SmokeMethod("getRange", "(int, int*, int*) const", "$$$")]
		public void GetRange(int index, out int arg2, out int arg3) {
			((QSplitter) interceptor).GetRange(index,out arg2,out arg3);
		}
		[SmokeMethod("setStretchFactor", "(int, int)", "$$")]
		public void SetStretchFactor(int index, int stretch) {
			((QSplitter) interceptor).SetStretchFactor(index,stretch);
		}
		[SmokeMethod("createHandle", "()", "")]
		protected virtual QSplitterHandle CreateHandle() {
			return ((QSplitter) interceptor).CreateHandle();
		}
		[SmokeMethod("childEvent", "(QChildEvent*)", "#")]
		protected override void ChildEvent(QChildEvent arg1) {
			((QSplitter) interceptor).ChildEvent(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent arg1) {
			return ((QSplitter) interceptor).Event(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			((QSplitter) interceptor).ResizeEvent(arg1);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			((QSplitter) interceptor).ChangeEvent(arg1);
		}
		[SmokeMethod("moveSplitter", "(int, int)", "$$")]
		protected void MoveSplitter(int pos, int index) {
			((QSplitter) interceptor).MoveSplitter(pos,index);
		}
		[SmokeMethod("setRubberBand", "(int)", "$")]
		protected void SetRubberBand(int position) {
			((QSplitter) interceptor).SetRubberBand(position);
		}
		[SmokeMethod("closestLegalPosition", "(int, int)", "$$")]
		protected int ClosestLegalPosition(int arg1, int arg2) {
			return ((QSplitter) interceptor).ClosestLegalPosition(arg1,arg2);
		}
		~QSplitter() {
			DisposeQSplitter();
		}
		public new void Dispose() {
			DisposeQSplitter();
		}
		[SmokeMethod("~QSplitter", "()", "")]
		private void DisposeQSplitter() {
			((QSplitter) interceptor).DisposeQSplitter();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQSplitterSignals Emit {
			get { return (IQSplitterSignals) Q_EMIT; }
		}
	}

	public interface IQSplitterSignals : IQFrameSignals {
		[Q_SIGNAL("void splitterMoved(int, int)")]
		void SplitterMoved(int pos, int index);
	}
}
