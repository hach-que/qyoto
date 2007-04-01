//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQAbstractSliderSignals"></see> for signals emitted by QAbstractSlider
	[SmokeClass("QAbstractSlider")]
	public abstract class QAbstractSlider : QWidget, IDisposable {
 		protected QAbstractSlider(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractSlider), "QAbstractSlider", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAbstractSlider() {
			staticInterceptor = new SmokeInvocation(typeof(QAbstractSlider), "QAbstractSlider", null);
		}
		public enum SliderAction {
			SliderNoAction = 0,
			SliderSingleStepAdd = 1,
			SliderSingleStepSub = 2,
			SliderPageStepAdd = 3,
			SliderPageStepSub = 4,
			SliderToMinimum = 5,
			SliderToMaximum = 6,
			SliderMove = 7,
		}
		public enum SliderChange {
			SliderRangeChange = 0,
			SliderOrientationChange = 1,
			SliderStepsChange = 2,
			SliderValueChange = 3,
		}
		[Q_PROPERTY("int", "minimum")]
		public int Minimum {
			get { return (int) interceptor.Invoke("minimum", "minimum()", typeof(int)); }
			set { interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "maximum")]
		public int Maximum {
			get { return (int) interceptor.Invoke("maximum", "maximum()", typeof(int)); }
			set { interceptor.Invoke("setMaximum$", "setMaximum(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "singleStep")]
		public int SingleStep {
			get { return (int) interceptor.Invoke("singleStep", "singleStep()", typeof(int)); }
			set { interceptor.Invoke("setSingleStep$", "setSingleStep(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "pageStep")]
		public int PageStep {
			get { return (int) interceptor.Invoke("pageStep", "pageStep()", typeof(int)); }
			set { interceptor.Invoke("setPageStep$", "setPageStep(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "value")]
		public int Value {
			get { return (int) interceptor.Invoke("value", "value()", typeof(int)); }
			set { interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "sliderPosition")]
		public int SliderPosition {
			get { return (int) interceptor.Invoke("sliderPosition", "sliderPosition()", typeof(int)); }
			set { interceptor.Invoke("setSliderPosition$", "setSliderPosition(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "tracking")]
		public bool Tracking {
			get { return (bool) interceptor.Invoke("hasTracking", "hasTracking()", typeof(bool)); }
			set { interceptor.Invoke("setTracking$", "setTracking(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			get { return (Qt.Orientation) interceptor.Invoke("orientation", "orientation()", typeof(Qt.Orientation)); }
			set { interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), value); }
		}
		[Q_PROPERTY("bool", "invertedAppearance")]
		public bool InvertedAppearance {
			get { return (bool) interceptor.Invoke("invertedAppearance", "invertedAppearance()", typeof(bool)); }
			set { interceptor.Invoke("setInvertedAppearance$", "setInvertedAppearance(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "invertedControls")]
		public bool InvertedControls {
			get { return (bool) interceptor.Invoke("invertedControls", "invertedControls()", typeof(bool)); }
			set { interceptor.Invoke("setInvertedControls$", "setInvertedControls(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "sliderDown")]
		public bool SliderDown {
			get { return (bool) interceptor.Invoke("isSliderDown", "isSliderDown()", typeof(bool)); }
			set { interceptor.Invoke("setSliderDown$", "setSliderDown(bool)", typeof(void), typeof(bool), value); }
		}
		public QAbstractSlider(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractSlider#", "QAbstractSlider(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QAbstractSlider() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractSlider", "QAbstractSlider()", typeof(void));
		}
		public void SetRange(int min, int max) {
			interceptor.Invoke("setRange$$", "setRange(int, int)", typeof(void), typeof(int), min, typeof(int), max);
		}
		public bool HasTracking() {
			return (bool) interceptor.Invoke("hasTracking", "hasTracking() const", typeof(bool));
		}
		public bool IsSliderDown() {
			return (bool) interceptor.Invoke("isSliderDown", "isSliderDown() const", typeof(bool));
		}
		public void TriggerAction(QAbstractSlider.SliderAction action) {
			interceptor.Invoke("triggerAction$", "triggerAction(QAbstractSlider::SliderAction)", typeof(void), typeof(QAbstractSlider.SliderAction), action);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		protected void SetRepeatAction(QAbstractSlider.SliderAction action, int thresholdTime, int repeatTime) {
			interceptor.Invoke("setRepeatAction$$$", "setRepeatAction(QAbstractSlider::SliderAction, int, int)", typeof(void), typeof(QAbstractSlider.SliderAction), action, typeof(int), thresholdTime, typeof(int), repeatTime);
		}
		protected void SetRepeatAction(QAbstractSlider.SliderAction action, int thresholdTime) {
			interceptor.Invoke("setRepeatAction$$", "setRepeatAction(QAbstractSlider::SliderAction, int)", typeof(void), typeof(QAbstractSlider.SliderAction), action, typeof(int), thresholdTime);
		}
		protected void SetRepeatAction(QAbstractSlider.SliderAction action) {
			interceptor.Invoke("setRepeatAction$", "setRepeatAction(QAbstractSlider::SliderAction)", typeof(void), typeof(QAbstractSlider.SliderAction), action);
		}
		protected QAbstractSlider.SliderAction RepeatAction() {
			return (QAbstractSlider.SliderAction) interceptor.Invoke("repeatAction", "repeatAction() const", typeof(QAbstractSlider.SliderAction));
		}
		[SmokeMethod("sliderChange(QAbstractSlider::SliderChange)")]
		protected virtual void sliderChange(QAbstractSlider.SliderChange change) {
			interceptor.Invoke("sliderChange$", "sliderChange(QAbstractSlider::SliderChange)", typeof(void), typeof(QAbstractSlider.SliderChange), change);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent ev) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), ev);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected override void TimerEvent(QTimerEvent arg1) {
			interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent e) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), e);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent e) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), e);
		}
		~QAbstractSlider() {
			interceptor.Invoke("~QAbstractSlider", "~QAbstractSlider()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QAbstractSlider", "~QAbstractSlider()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQAbstractSliderSignals Emit {
			get { return (IQAbstractSliderSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractSliderSignals : IQWidgetSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int value);
		[Q_SIGNAL("void sliderPressed()")]
		void SliderPressed();
		[Q_SIGNAL("void sliderMoved(int)")]
		void SliderMoved(int position);
		[Q_SIGNAL("void sliderReleased()")]
		void SliderReleased();
		[Q_SIGNAL("void rangeChanged(int, int)")]
		void RangeChanged(int min, int max);
		[Q_SIGNAL("void actionTriggered(int)")]
		void ActionTriggered(int action);
	}
}
