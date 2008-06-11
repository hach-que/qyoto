//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  This event is sent by the part manager when the active part changes.
	///  Each time the active part changes, it will send first a PartActivateEvent
	///  with activated=false, part=oldActivePart, widget=oldActiveWidget
	///  and then another PartActivateEvent
	///  with activated=true, part=newPart, widget=newWidget.
	/// </remarks>		<short>    This event is sent by the part manager when the active part changes.</short>
	/// 		<see> Part.PartActivateEvent</see>

	[SmokeClass("KParts::PartActivateEvent")]
	public class PartActivateEvent : KParts.Event, IDisposable {
 		protected PartActivateEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(PartActivateEvent), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static PartActivateEvent() {
			staticInterceptor = new SmokeInvocation(typeof(PartActivateEvent), null);
		}
		public PartActivateEvent(bool activated, KParts.Part part, QWidget widget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("PartActivateEvent$##", "PartActivateEvent(bool, KParts::Part*, QWidget*)", typeof(void), typeof(bool), activated, typeof(KParts.Part), part, typeof(QWidget), widget);
		}
		public bool Activated() {
			return (bool) interceptor.Invoke("activated", "activated() const", typeof(bool));
		}
		public KParts.Part Part() {
			return (KParts.Part) interceptor.Invoke("part", "part() const", typeof(KParts.Part));
		}
		public QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
		}
		~PartActivateEvent() {
			interceptor.Invoke("~PartActivateEvent", "~PartActivateEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~PartActivateEvent", "~PartActivateEvent()", typeof(void));
		}
		public static new bool Test(QEvent arg1) {
			return (bool) staticInterceptor.Invoke("test#", "test(const QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
	}
}
