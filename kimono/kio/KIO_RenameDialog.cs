//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  A dialog for the options to rename two files.
	/// </remarks>		<short> A dialog for renaming files.  </short>

	[SmokeClass("KIO::RenameDialog")]
	public class RenameDialog : QDialog, IDisposable {
 		protected RenameDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(RenameDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static RenameDialog() {
			staticInterceptor = new SmokeInvocation(typeof(RenameDialog), null);
		}
		// KIO::RenameDialog* RenameDialog(QWidget* arg1,const QString& arg2,const KUrl& arg3,const KUrl& arg4,KIO::RenameDialog_Mode arg5,KIO::filesize_t arg6,KIO::filesize_t arg7,time_t arg8,time_t arg9,time_t arg10,time_t arg11); >>>> NOT CONVERTED
		// KIO::RenameDialog* RenameDialog(QWidget* arg1,const QString& arg2,const KUrl& arg3,const KUrl& arg4,KIO::RenameDialog_Mode arg5,KIO::filesize_t arg6,KIO::filesize_t arg7,time_t arg8,time_t arg9,time_t arg10); >>>> NOT CONVERTED
		// KIO::RenameDialog* RenameDialog(QWidget* arg1,const QString& arg2,const KUrl& arg3,const KUrl& arg4,KIO::RenameDialog_Mode arg5,KIO::filesize_t arg6,KIO::filesize_t arg7,time_t arg8,time_t arg9); >>>> NOT CONVERTED
		// KIO::RenameDialog* RenameDialog(QWidget* arg1,const QString& arg2,const KUrl& arg3,const KUrl& arg4,KIO::RenameDialog_Mode arg5,KIO::filesize_t arg6,KIO::filesize_t arg7,time_t arg8); >>>> NOT CONVERTED
		// KIO::RenameDialog* RenameDialog(QWidget* arg1,const QString& arg2,const KUrl& arg3,const KUrl& arg4,KIO::RenameDialog_Mode arg5,KIO::filesize_t arg6,KIO::filesize_t arg7); >>>> NOT CONVERTED
		// KIO::RenameDialog* RenameDialog(QWidget* arg1,const QString& arg2,const KUrl& arg3,const KUrl& arg4,KIO::RenameDialog_Mode arg5,KIO::filesize_t arg6); >>>> NOT CONVERTED
		/// <remarks>
		///  Construct a "rename" dialog.
		/// <param> name="parent" parent widget (often 0)
		/// </param><param> name="caption" the caption for the dialog box
		/// </param><param> name="src" the url to the file/dir we're trying to copy, as it's part of the text message
		/// </param><param> name="dest" the path to destination file/dir, i.e. the one that already exists
		/// </param><param> name="mode" parameters for the dialog (which buttons to show...),
		/// </param><param> name="sizeSrc" size of source file
		/// </param><param> name="sizeDest" size of destination file
		/// </param><param> name="ctimeSrc" creation time of source file
		/// </param><param> name="ctimeDest" creation time of destination file
		/// </param><param> name="mtimeSrc" modification time of source file
		/// </param><param> name="mtimeDest" modification time of destination file
		/// </param></remarks>		<short>    Construct a "rename" dialog.</short>
		/// 		<see> RenameDialog_Mode</see>
		public RenameDialog(QWidget parent, string caption, KUrl src, KUrl dest, KIO.RenameDialog_Mode mode) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("RenameDialog#$##$", "RenameDialog(QWidget*, const QString&, const KUrl&, const KUrl&, KIO::RenameDialog_Mode)", typeof(void), typeof(QWidget), parent, typeof(string), caption, typeof(KUrl), src, typeof(KUrl), dest, typeof(KIO.RenameDialog_Mode), mode);
		}
		/// <remarks>
		/// </remarks>		<return> the new destination
		///  valid only if RENAME was chosen
		///    </return>
		/// 		<short>   </short>
		public KUrl NewDestUrl() {
			return (KUrl) interceptor.Invoke("newDestUrl", "newDestUrl()", typeof(KUrl));
		}
		[Q_SLOT("void cancelPressed()")]
		public void CancelPressed() {
			interceptor.Invoke("cancelPressed", "cancelPressed()", typeof(void));
		}
		[Q_SLOT("void renamePressed()")]
		public void RenamePressed() {
			interceptor.Invoke("renamePressed", "renamePressed()", typeof(void));
		}
		[Q_SLOT("void skipPressed()")]
		public void SkipPressed() {
			interceptor.Invoke("skipPressed", "skipPressed()", typeof(void));
		}
		[Q_SLOT("void autoSkipPressed()")]
		public void AutoSkipPressed() {
			interceptor.Invoke("autoSkipPressed", "autoSkipPressed()", typeof(void));
		}
		[Q_SLOT("void overwritePressed()")]
		public void OverwritePressed() {
			interceptor.Invoke("overwritePressed", "overwritePressed()", typeof(void));
		}
		[Q_SLOT("void overwriteAllPressed()")]
		public void OverwriteAllPressed() {
			interceptor.Invoke("overwriteAllPressed", "overwriteAllPressed()", typeof(void));
		}
		[Q_SLOT("void resumePressed()")]
		public void ResumePressed() {
			interceptor.Invoke("resumePressed", "resumePressed()", typeof(void));
		}
		[Q_SLOT("void resumeAllPressed()")]
		public void ResumeAllPressed() {
			interceptor.Invoke("resumeAllPressed", "resumeAllPressed()", typeof(void));
		}
		[Q_SLOT("void suggestNewNamePressed()")]
		public void SuggestNewNamePressed() {
			interceptor.Invoke("suggestNewNamePressed", "suggestNewNamePressed()", typeof(void));
		}
		[Q_SLOT("void enableRenameButton(const QString&)")]
		protected void EnableRenameButton(string arg1) {
			interceptor.Invoke("enableRenameButton$", "enableRenameButton(const QString&)", typeof(void), typeof(string), arg1);
		}
		~RenameDialog() {
			interceptor.Invoke("~RenameDialog", "~RenameDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~RenameDialog", "~RenameDialog()", typeof(void));
		}
		/// <remarks>
		///  Given a directory path and a filename (which usually exists already),
		///  this function returns a suggested name for a file that doesn't exist
		///  in that directory. The existence is only checked for local urls though.
		///  The suggested file name is of the form foo_1 foo_2 etc.
		///    </remarks>		<short>    Given a directory path and a filename (which usually exists already),  this function returns a suggested name for a file that doesn't exist  in that directory.</short>
		public static string SuggestName(KUrl baseURL, string oldName) {
			return (string) staticInterceptor.Invoke("suggestName#$", "suggestName(const KUrl&, const QString&)", typeof(string), typeof(KUrl), baseURL, typeof(string), oldName);
		}
		protected new IRenameDialogSignals Emit {
			get { return (IRenameDialogSignals) Q_EMIT; }
		}
	}

	public interface IRenameDialogSignals : IQDialogSignals {
	}
}
