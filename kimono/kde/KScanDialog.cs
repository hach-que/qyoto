//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  This is a base class for scanning dialogs. You can derive from this class
	///  and implement your own dialog. An implementation is available in
	///  kdegraphics/libkscan.
	///  Application developers that wish to add scanning support to their program
	///  can use the static method <code>KScanDialog</code>.GetScanDialog() to get an instance
	///  of the user's preferred scanning dialog.
	///  Typical usage looks like this (e.g. in a slotShowScanDialog() method):
	///  <pre>
	///  if ( !m_scanDialog ) {
	///      m_scanDialog = KScanDialog.GetScanDialog( this );
	///      if ( !m_scanDialog ) // no scanning support installed?
	///          return;
	///      connect( m_scanDialog, SIGNAL("finalImage( QImage, int )"),
	///               SLOT("slotScanned( QImage, int )"));
	///  }
	///  if ( m_scanDialog.Setup() ) // only if scanner configured/available
	///      m_scanDialog.Show();
	///  </pre>
	///  This will create and show a non-modal scanning dialog. Connect to more
	///  signals if you like.
	///  See <see cref="IKScanDialogSignals"></see> for signals emitted by KScanDialog
	/// </remarks>		<author> Carsten Pfeiffer <pfeiffer@kde.org>
	///  </author>
	/// 		<short> A baseclass and accessor for Scanning Dialogs.</short>

	[SmokeClass("KScanDialog")]
	public class KScanDialog : KPageDialog, IDisposable {
 		protected KScanDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KScanDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KScanDialog() {
			staticInterceptor = new SmokeInvocation(typeof(KScanDialog), null);
		}
		/// <remarks>
		///  Reimplement this if you need to set up some things, before showing the
		///  dialog, e.g. to ask the user for the scanner device to use. If you
		///  return false (e.g. there is no device available or the user aborted
		///  device selection), the dialog will not be shown.
		/// </remarks>		<return> true by default.
		///      </return>
		/// 		<short>    Reimplement this if you need to set up some things, before showing the  dialog, e.</short>
		[SmokeMethod("setup()")]
		public virtual bool Setup() {
			return (bool) interceptor.Invoke("setup", "setup()", typeof(bool));
		}
		/// <remarks>
		///  Constructs the scan dialog. If you implement an own dialog, you can
		///  customize it with the usual KPageDialog flags.
		/// <param> name="dialogFace" The KPageDialog.FaceType
		/// </param><param> name="buttonMask" An ORed mask of all buttons (see
		///  KDialog.ButtonCode)
		/// </param><param> name="parent" The QWidget's parent, or 0
		/// </param></remarks>		<short>    Constructs the scan dialog.</short>
		/// 		<see> KPageDialog</see>
		public KScanDialog(int dialogFace, int buttonMask, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KScanDialog$$#", "KScanDialog(int, int, QWidget*)", typeof(void), typeof(int), dialogFace, typeof(int), buttonMask, typeof(QWidget), parent);
		}
		public KScanDialog(int dialogFace, int buttonMask) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KScanDialog$$", "KScanDialog(int, int)", typeof(void), typeof(int), dialogFace, typeof(int), buttonMask);
		}
		public KScanDialog(int dialogFace) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KScanDialog$", "KScanDialog(int)", typeof(void), typeof(int), dialogFace);
		}
		public KScanDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KScanDialog", "KScanDialog()", typeof(void));
		}
		/// <remarks>
		///  Returns the current id for an image. You can use that in your subclass
		///  for the signals. The id is used in the signals to let people know
		///  which preview and which text-recognition belongs to which scan.
		/// </remarks>		<return> the current id for the image
		/// </return>
		/// 		<short>    Returns the current id for an image.</short>
		/// 		<see> nextId</see>
		/// 		<see> finalImage</see>
		/// 		<see> preview</see>
		/// 		<see> textRecognized</see>
		protected int Id() {
			return (int) interceptor.Invoke("id", "id() const", typeof(int));
		}
		/// <remarks>
		///  Returns the id for the next image. You can use that in your subclass
		///  for the signals.
		///      </remarks>		<return> the id for the next image
		/// </return>
		/// 		<short>    Returns the id for the next image.</short>
		/// 		<see> id</see>
		/// 		<see> finalImage</see>
		/// 		<see> preview</see>
		/// 		<see> textRecognized</see>
		protected int NextId() {
			return (int) interceptor.Invoke("nextId", "nextId()", typeof(int));
		}
		~KScanDialog() {
			interceptor.Invoke("~KScanDialog", "~KScanDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KScanDialog", "~KScanDialog()", typeof(void));
		}
		/// <remarks>
		///  Creates the user's preferred scanning dialog and returns it,
		///  or null if no scan-support
		///  is available. Pass a suitable <code>parent</code> widget, if you like. If you
		///  don't you have to 'delete' the returned pointer yourself.
		/// <param> name="parent" the QWidget's parent, or 0
		/// </param></remarks>		<return> the KScanDialog, or 0 if the function failed
		///      </return>
		/// 		<short>    Creates the user's preferred scanning dialog and returns it,  or 0L if no scan-support  is available.</short>
		public static KScanDialog GetScanDialog(QWidget parent) {
			return (KScanDialog) staticInterceptor.Invoke("getScanDialog#", "getScanDialog(QWidget*)", typeof(KScanDialog), typeof(QWidget), parent);
		}
		public static KScanDialog GetScanDialog() {
			return (KScanDialog) staticInterceptor.Invoke("getScanDialog", "getScanDialog()", typeof(KScanDialog));
		}
		protected new IKScanDialogSignals Emit {
			get { return (IKScanDialogSignals) Q_EMIT; }
		}
	}

	public interface IKScanDialogSignals : IKPageDialogSignals {
		/// <remarks>
		///  Informs you that an image has been previewed.
		/// <param> name="img" the image
		/// </param><param> name="id" the image's id
		///      </param></remarks>		<short>    Informs you that an image has been previewed.</short>
		[Q_SIGNAL("void preview(const QImage&, int)")]
		void Preview(QImage img, int id);
		/// <remarks>
		///  Informs you that an image has scanned. <code>id</code> is the same as in the
		///  <code>preview</code>() signal, if this image had been previewed before.
		///  Note, that those id's may not be properly implemented in the current
		///  libkscan.
		/// <param> name="img" the image
		/// </param><param> name="id" the image's id
		///      </param></remarks>		<short>    Informs you that an image has scanned.</short>
		[Q_SIGNAL("void finalImage(const QImage&, int)")]
		void FinalImage(QImage img, int id);
		/// <remarks>
		///  Informs you that the image with the id <code>id</code> has been run through
		///  text-recognition. The text is in the string parameter. In the future,
		///  a compound document, using rich text will be used instead.
		/// <param> name="text" the text that has been recognized
		/// </param><param> name="id" the id of the image
		///      </param></remarks>		<short>    Informs you that the image with the id <code>id</code> has been run through  text-recognition.</short>
		[Q_SIGNAL("void textRecognized(const QString&, int)")]
		void TextRecognized(string text, int id);
	}
}
