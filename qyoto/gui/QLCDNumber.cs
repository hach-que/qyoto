//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQLCDNumberSignals"></see> for signals emitted by QLCDNumber
	[SmokeClass("QLCDNumber")]
	public class QLCDNumber : QFrame, IDisposable {
 		protected QLCDNumber(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QLCDNumber), "QLCDNumber", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QLCDNumber() {
			staticInterceptor = new SmokeInvocation(typeof(QLCDNumber), "QLCDNumber", null);
		}
		public enum Mode {
			Hex = 0,
			Dec = 1,
			Oct = 2,
			Bin = 3,
		}
		public enum SegmentStyle {
			Outline = 0,
			Filled = 1,
			Flat = 2,
		}
		[Q_PROPERTY("bool", "smallDecimalPoint")]
		public bool SmallDecimalPoint {
			get { return (bool) interceptor.Invoke("smallDecimalPoint", "smallDecimalPoint()", typeof(bool)); }
			set { interceptor.Invoke("setSmallDecimalPoint$", "setSmallDecimalPoint(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "numDigits")]
		public int NumDigits {
			get { return (int) interceptor.Invoke("numDigits", "numDigits()", typeof(int)); }
			set { interceptor.Invoke("setNumDigits$", "setNumDigits(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("QLCDNumber::Mode", "mode")]
		public QLCDNumber.Mode mode {
			get { return (QLCDNumber.Mode) interceptor.Invoke("mode", "mode()", typeof(QLCDNumber.Mode)); }
			set { interceptor.Invoke("setMode$", "setMode(QLCDNumber::Mode)", typeof(void), typeof(QLCDNumber.Mode), value); }
		}
		[Q_PROPERTY("QLCDNumber::SegmentStyle", "segmentStyle")]
		public QLCDNumber.SegmentStyle segmentStyle {
			get { return (QLCDNumber.SegmentStyle) interceptor.Invoke("segmentStyle", "segmentStyle()", typeof(QLCDNumber.SegmentStyle)); }
			set { interceptor.Invoke("setSegmentStyle$", "setSegmentStyle(QLCDNumber::SegmentStyle)", typeof(void), typeof(QLCDNumber.SegmentStyle), value); }
		}
		[Q_PROPERTY("double", "value")]
		public double Value {
			get { return (double) interceptor.Invoke("value", "value()", typeof(double)); }
			set { interceptor.Invoke("display$", "display(double)", typeof(void), typeof(double), value); }
		}
		[Q_PROPERTY("int", "intValue")]
		public int IntValue {
			get { return (int) interceptor.Invoke("intValue", "intValue()", typeof(int)); }
			set { interceptor.Invoke("display$", "display(int)", typeof(void), typeof(int), value); }
		}
		public QLCDNumber(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLCDNumber#", "QLCDNumber(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QLCDNumber() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLCDNumber", "QLCDNumber()", typeof(void));
		}
		public QLCDNumber(uint numDigits, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLCDNumber$#", "QLCDNumber(uint, QWidget*)", typeof(void), typeof(uint), numDigits, typeof(QWidget), parent);
		}
		public QLCDNumber(uint numDigits) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLCDNumber$", "QLCDNumber(uint)", typeof(void), typeof(uint), numDigits);
		}
		public bool CheckOverflow(double num) {
			return (bool) interceptor.Invoke("checkOverflow$", "checkOverflow(double) const", typeof(bool), typeof(double), num);
		}
		public bool CheckOverflow(int num) {
			return (bool) interceptor.Invoke("checkOverflow$", "checkOverflow(int) const", typeof(bool), typeof(int), num);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[Q_SLOT("void display(const QString&)")]
		public void Display(string str) {
			interceptor.Invoke("display$", "display(const QString&)", typeof(void), typeof(string), str);
		}
		[Q_SLOT("void display(int)")]
		public void Display(int num) {
			interceptor.Invoke("display$", "display(int)", typeof(void), typeof(int), num);
		}
		[Q_SLOT("void display(double)")]
		public void Display(double num) {
			interceptor.Invoke("display$", "display(double)", typeof(void), typeof(double), num);
		}
		[Q_SLOT("void setHexMode()")]
		public void SetHexMode() {
			interceptor.Invoke("setHexMode", "setHexMode()", typeof(void));
		}
		[Q_SLOT("void setDecMode()")]
		public void SetDecMode() {
			interceptor.Invoke("setDecMode", "setDecMode()", typeof(void));
		}
		[Q_SLOT("void setOctMode()")]
		public void SetOctMode() {
			interceptor.Invoke("setOctMode", "setOctMode()", typeof(void));
		}
		[Q_SLOT("void setBinMode()")]
		public void SetBinMode() {
			interceptor.Invoke("setBinMode", "setBinMode()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		~QLCDNumber() {
			interceptor.Invoke("~QLCDNumber", "~QLCDNumber()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QLCDNumber", "~QLCDNumber()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQLCDNumberSignals Emit {
			get { return (IQLCDNumberSignals) Q_EMIT; }
		}
	}

	public interface IQLCDNumberSignals : IQFrameSignals {
		[Q_SIGNAL("void overflow()")]
		void Overflow();
	}
}
