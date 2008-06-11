//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  The KParts.OpenUrlEvent event informs that a given part has opened a given URL.
	///  Applications can use this event to send this information to interested plugins.
	///  The event should be sent before opening the URL in the part, so that the plugins
	///  can use part().Url() to get the old URL.
	///  </remarks>		<short>    The KParts.OpenUrlEvent event informs that a given part has opened a given URL.</short>

	[SmokeClass("KParts::OpenUrlEvent")]
	public class OpenUrlEvent : KParts.Event, IDisposable {
 		protected OpenUrlEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(OpenUrlEvent), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static OpenUrlEvent() {
			staticInterceptor = new SmokeInvocation(typeof(OpenUrlEvent), null);
		}
		public OpenUrlEvent(KParts.ReadOnlyPart part, KUrl url, KParts.OpenUrlArguments args, KParts.BrowserArguments browserArgs) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("OpenUrlEvent####", "OpenUrlEvent(KParts::ReadOnlyPart*, const KUrl&, const KParts::OpenUrlArguments&, const KParts::BrowserArguments&)", typeof(void), typeof(KParts.ReadOnlyPart), part, typeof(KUrl), url, typeof(KParts.OpenUrlArguments), args, typeof(KParts.BrowserArguments), browserArgs);
		}
		public OpenUrlEvent(KParts.ReadOnlyPart part, KUrl url, KParts.OpenUrlArguments args) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("OpenUrlEvent###", "OpenUrlEvent(KParts::ReadOnlyPart*, const KUrl&, const KParts::OpenUrlArguments&)", typeof(void), typeof(KParts.ReadOnlyPart), part, typeof(KUrl), url, typeof(KParts.OpenUrlArguments), args);
		}
		public OpenUrlEvent(KParts.ReadOnlyPart part, KUrl url) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("OpenUrlEvent##", "OpenUrlEvent(KParts::ReadOnlyPart*, const KUrl&)", typeof(void), typeof(KParts.ReadOnlyPart), part, typeof(KUrl), url);
		}
		public KParts.ReadOnlyPart Part() {
			return (KParts.ReadOnlyPart) interceptor.Invoke("part", "part() const", typeof(KParts.ReadOnlyPart));
		}
		public KUrl Url() {
			return (KUrl) interceptor.Invoke("url", "url() const", typeof(KUrl));
		}
		public KParts.OpenUrlArguments Arguments() {
			return (KParts.OpenUrlArguments) interceptor.Invoke("arguments", "arguments() const", typeof(KParts.OpenUrlArguments));
		}
		public KParts.BrowserArguments BrowserArguments() {
			return (KParts.BrowserArguments) interceptor.Invoke("browserArguments", "browserArguments() const", typeof(KParts.BrowserArguments));
		}
		~OpenUrlEvent() {
			interceptor.Invoke("~OpenUrlEvent", "~OpenUrlEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~OpenUrlEvent", "~OpenUrlEvent()", typeof(void));
		}
		public static new bool Test(QEvent arg1) {
			return (bool) staticInterceptor.Invoke("test#", "test(const QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
	}
}
