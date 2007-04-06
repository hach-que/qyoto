//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	///<remarks> See <see cref="IQSplitterSignals"></see> for signals emitted by QSplitter
	///</remarks>

	[SmokeClass("QSplitter")]
	public class QSplitter : QFrame, IDisposable {
 		protected QSplitter(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSplitter), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSplitter() {
			staticInterceptor = new SmokeInvocation(typeof(QSplitter), null);
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public new Qt.Orientation Orientation {
			get { return (Qt.Orientation) interceptor.Invoke("orientation", "orientation()", typeof(Qt.Orientation)); }
			set { interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), value); }
		}
		[Q_PROPERTY("bool", "opaqueResize")]
		public bool OpaqueResize {
			get { return (bool) interceptor.Invoke("opaqueResize", "opaqueResize()", typeof(bool)); }
			set { interceptor.Invoke("setOpaqueResize$", "setOpaqueResize(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "handleWidth")]
		public int HandleWidth {
			get { return (int) interceptor.Invoke("handleWidth", "handleWidth()", typeof(int)); }
			set { interceptor.Invoke("setHandleWidth$", "setHandleWidth(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "childrenCollapsible")]
		public bool ChildrenCollapsible {
			get { return (bool) interceptor.Invoke("childrenCollapsible", "childrenCollapsible()", typeof(bool)); }
			set { interceptor.Invoke("setChildrenCollapsible$", "setChildrenCollapsible(bool)", typeof(void), typeof(bool), value); }
		}
		public QSplitter(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSplitter#", "QSplitter(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QSplitter() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSplitter", "QSplitter()", typeof(void));
		}
		public QSplitter(Qt.Orientation arg1, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSplitter$#", "QSplitter(Qt::Orientation, QWidget*)", typeof(void), typeof(Qt.Orientation), arg1, typeof(QWidget), parent);
		}
		public QSplitter(Qt.Orientation arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSplitter$", "QSplitter(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), arg1);
		}
		public void AddWidget(QWidget widget) {
			interceptor.Invoke("addWidget#", "addWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		public void InsertWidget(int index, QWidget widget) {
			interceptor.Invoke("insertWidget$#", "insertWidget(int, QWidget*)", typeof(void), typeof(int), index, typeof(QWidget), widget);
		}
		public void SetCollapsible(int index, bool arg2) {
			interceptor.Invoke("setCollapsible$$", "setCollapsible(int, bool)", typeof(void), typeof(int), index, typeof(bool), arg2);
		}
		public bool IsCollapsible(int index) {
			return (bool) interceptor.Invoke("isCollapsible$", "isCollapsible(int) const", typeof(bool), typeof(int), index);
		}
		public void Refresh() {
			interceptor.Invoke("refresh", "refresh()", typeof(void));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		public List<int> Sizes() {
			return (List<int>) interceptor.Invoke("sizes", "sizes() const", typeof(List<int>));
		}
		public void SetSizes(List<int> list) {
			interceptor.Invoke("setSizes?", "setSizes(const QList<int>&)", typeof(void), typeof(List<int>), list);
		}
		public QByteArray SaveState() {
			return (QByteArray) interceptor.Invoke("saveState", "saveState() const", typeof(QByteArray));
		}
		public bool RestoreState(QByteArray state) {
			return (bool) interceptor.Invoke("restoreState#", "restoreState(const QByteArray&)", typeof(bool), typeof(QByteArray), state);
		}
		public int IndexOf(QWidget w) {
			return (int) interceptor.Invoke("indexOf#", "indexOf(QWidget*) const", typeof(int), typeof(QWidget), w);
		}
		public QWidget Widget(int index) {
			return (QWidget) interceptor.Invoke("widget$", "widget(int) const", typeof(QWidget), typeof(int), index);
		}
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		public void GetRange(int index, int arg2, int arg3) {
			interceptor.Invoke("getRange$$$", "getRange(int, int*, int*) const", typeof(void), typeof(int), index, typeof(int), arg2, typeof(int), arg3);
		}
		public void SetStretchFactor(int index, int stretch) {
			interceptor.Invoke("setStretchFactor$$", "setStretchFactor(int, int)", typeof(void), typeof(int), index, typeof(int), stretch);
		}
		[SmokeMethod("createHandle()")]
		protected virtual QSplitterHandle CreateHandle() {
			return (QSplitterHandle) interceptor.Invoke("createHandle", "createHandle()", typeof(QSplitterHandle));
		}
		[SmokeMethod("childEvent(QChildEvent*)")]
		protected override void ChildEvent(QChildEvent arg1) {
			interceptor.Invoke("childEvent#", "childEvent(QChildEvent*)", typeof(void), typeof(QChildEvent), arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		protected void MoveSplitter(int pos, int index) {
			interceptor.Invoke("moveSplitter$$", "moveSplitter(int, int)", typeof(void), typeof(int), pos, typeof(int), index);
		}
		protected void SetRubberBand(int position) {
			interceptor.Invoke("setRubberBand$", "setRubberBand(int)", typeof(void), typeof(int), position);
		}
		protected int ClosestLegalPosition(int arg1, int arg2) {
			return (int) interceptor.Invoke("closestLegalPosition$$", "closestLegalPosition(int, int)", typeof(int), typeof(int), arg1, typeof(int), arg2);
		}
		~QSplitter() {
			interceptor.Invoke("~QSplitter", "~QSplitter()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QSplitter", "~QSplitter()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
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
