//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	public interface IQMimeSource {
		string Format(int n);
		bool Provides(string arg1);
		QByteArray EncodedData(string arg1);
	}

	[SmokeClass("QMimeSource")]
	public abstract class QMimeSource : Object, IQMimeSource {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QMimeSource(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QMimeSource), "QMimeSource", this);
		}
		[SmokeMethod("format(int) const")]
		public abstract string Format(int n);
		[SmokeMethod("provides(const char*) const")]
		public virtual bool Provides(string arg1) {
			return (bool) interceptor.Invoke("provides$", "provides(const char*) const", typeof(bool), typeof(string), arg1);
		}
		[SmokeMethod("encodedData(const char*) const")]
		public abstract QByteArray EncodedData(string arg1);
		public QMimeSource() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMimeSource", "QMimeSource()", typeof(void));
		}
	}
}
