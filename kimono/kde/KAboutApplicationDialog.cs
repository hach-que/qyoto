//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  This class provides the standard "About Application" dialog box
	///  that is used by KHelpMenu. It uses the information of the global
	///  KAboutData that is specified at the start of your program in
	///  main(). Normally you should not use this class directly but rather
	///  the KHelpMenu class or even better just subclass your toplevel
	///  window from KMainWindow. If you do the latter, the help menu and
	///  thereby this dialog box is available through the
	///  KMainWindow.HelpMenu() function.
	/// </remarks>		<author> Urs Wolfer uwolfer @ kde.org
	///  </author>
	/// 		<short> Standard "About Application" dialog box. </short>

	[SmokeClass("KAboutApplicationDialog")]
	public class KAboutApplicationDialog : KDialog, IDisposable {
 		protected KAboutApplicationDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KAboutApplicationDialog), this);
		}
		/// <remarks>
		///  Constructor. Creates a fully featured "About Application" dialog box.
		/// <param> name="aboutData" A pointer to a KAboutData object which data
		///         will be used for filling the dialog.
		/// </param><param> name="parent" The parent of the dialog box. You should use the
		///         toplevel window so that the dialog becomes centered.
		///          </param></remarks>		<short>    Constructor.</short>
		public KAboutApplicationDialog(KAboutData aboutData, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutApplicationDialog##", "KAboutApplicationDialog(const KAboutData*, QWidget*)", typeof(void), typeof(KAboutData), aboutData, typeof(QWidget), parent);
		}
		public KAboutApplicationDialog(KAboutData aboutData) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutApplicationDialog#", "KAboutApplicationDialog(const KAboutData*)", typeof(void), typeof(KAboutData), aboutData);
		}
		~KAboutApplicationDialog() {
			interceptor.Invoke("~KAboutApplicationDialog", "~KAboutApplicationDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KAboutApplicationDialog", "~KAboutApplicationDialog()", typeof(void));
		}
		protected new IKAboutApplicationDialogSignals Emit {
			get { return (IKAboutApplicationDialogSignals) Q_EMIT; }
		}
	}

	public interface IKAboutApplicationDialogSignals : IKDialogSignals {
	}
}
