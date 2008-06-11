//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;


	[SmokeClass("KUrlComboRequester")]
	public class KUrlComboRequester : KUrlRequester, IDisposable {
 		protected KUrlComboRequester(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KUrlComboRequester), this);
		}
		/// <remarks>
		///  Constructs a KUrlRequester widget with a combobox.
		///      </remarks>		<short>    Constructs a KUrlRequester widget with a combobox.</short>
		public KUrlComboRequester(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUrlComboRequester#", "KUrlComboRequester(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KUrlComboRequester() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUrlComboRequester", "KUrlComboRequester()", typeof(void));
		}
		~KUrlComboRequester() {
			interceptor.Invoke("~KUrlComboRequester", "~KUrlComboRequester()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KUrlComboRequester", "~KUrlComboRequester()", typeof(void));
		}
		protected new IKUrlComboRequesterSignals Emit {
			get { return (IKUrlComboRequesterSignals) Q_EMIT; }
		}
	}

	public interface IKUrlComboRequesterSignals : IKUrlRequesterSignals {
	}
}
