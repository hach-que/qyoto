//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDBusAbstractAdaptor")]
	public abstract class QDBusAbstractAdaptor : QObject {
 		protected QDBusAbstractAdaptor(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDBusAbstractAdaptor), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDBusAbstractAdaptor() {
			staticInterceptor = new SmokeInvocation(typeof(QDBusAbstractAdaptor), null);
		}
		public QDBusAbstractAdaptor(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDBusAbstractAdaptor#", "QDBusAbstractAdaptor(QObject*)", typeof(void), typeof(QObject), parent);
		}
		protected void SetAutoRelaySignals(bool enable) {
			interceptor.Invoke("setAutoRelaySignals$", "setAutoRelaySignals(bool)", typeof(void), typeof(bool), enable);
		}
		protected bool AutoRelaySignals() {
			return (bool) interceptor.Invoke("autoRelaySignals", "autoRelaySignals() const", typeof(bool));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQDBusAbstractAdaptorSignals Emit {
			get { return (IQDBusAbstractAdaptorSignals) Q_EMIT; }
		}
	}

	public interface IQDBusAbstractAdaptorSignals : IQObjectSignals {
	}
}
