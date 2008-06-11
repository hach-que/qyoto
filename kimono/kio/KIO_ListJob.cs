//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  A ListJob is allows you to get the get the content of a directory.
	///  Don't create the job directly, but use KIO.ListRecursive() or
	///  KIO.ListDir() instead.
	///  See <see cref="IListJobSignals"></see> for signals emitted by ListJob
	/// </remarks>		<short>    A ListJob is allows you to get the get the content of a directory.</short>
	/// 		<see> listRecursive</see>
	/// 		<see> listDir</see>

	[SmokeClass("KIO::ListJob")]
	public class ListJob : KIO.SimpleJob, IDisposable {
 		protected ListJob(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(ListJob), this);
		}
		// KIO::ListJob* ListJob(KIO::ListJobPrivate& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Returns the ListJob's redirection URL. This will be invalid if there
		///  was no redirection.
		/// </remarks>		<return> the redirection url
		///          </return>
		/// 		<short>    Returns the ListJob's redirection URL.</short>
		public KUrl RedirectionUrl() {
			return (KUrl) interceptor.Invoke("redirectionUrl", "redirectionUrl() const", typeof(KUrl));
		}
		/// <remarks>
		///  Do not apply any KIOSK restrictions to this job.
		///          </remarks>		<short>    Do not apply any KIOSK restrictions to this job.</short>
		public void SetUnrestricted(bool unrestricted) {
			interceptor.Invoke("setUnrestricted$", "setUnrestricted(bool)", typeof(void), typeof(bool), unrestricted);
		}
		[Q_SLOT("void slotFinished()")]
		[SmokeMethod("slotFinished()")]
		protected override void SlotFinished() {
			interceptor.Invoke("slotFinished", "slotFinished()", typeof(void));
		}
		[Q_SLOT("void slotMetaData(const KIO::MetaData&)")]
		[SmokeMethod("slotMetaData(const KIO::MetaData&)")]
		protected override void SlotMetaData(KIO.MetaData _metaData) {
			interceptor.Invoke("slotMetaData#", "slotMetaData(const KIO::MetaData&)", typeof(void), typeof(KIO.MetaData), _metaData);
		}
		[Q_SLOT("void slotResult(KJob*)")]
		[SmokeMethod("slotResult(KJob*)")]
		protected override void SlotResult(KJob job) {
			interceptor.Invoke("slotResult#", "slotResult(KJob*)", typeof(void), typeof(KJob), job);
		}
		~ListJob() {
			interceptor.Invoke("~ListJob", "~ListJob()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~ListJob", "~ListJob()", typeof(void));
		}
		protected new IListJobSignals Emit {
			get { return (IListJobSignals) Q_EMIT; }
		}
	}

	public interface IListJobSignals : KIO.ISimpleJobSignals {
		// void entries(KIO::Job* arg1,const KIO::UDSEntryList& arg2); >>>> NOT CONVERTED
		/// <remarks>
		///  Signals a redirection.
		///  Use to update the URL shown to the user.
		///  The redirection itself is handled internally.
		/// <param> name="job" the job that is redirected
		/// </param><param> name="url" the new url
		///          </param></remarks>		<short>    Signals a redirection.</short>
		[Q_SIGNAL("void redirection(KIO::Job*, const KUrl&)")]
		void Redirection(KIO.Job job, KUrl url);
		/// <remarks>
		///  Signals a permanent redirection.
		///  The redirection itself is handled internally.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="fromUrl" the original URL
		/// </param><param> name="toUrl" the new URL
		///          </param></remarks>		<short>    Signals a permanent redirection.</short>
		[Q_SIGNAL("void permanentRedirection(KIO::Job*, const KUrl&, const KUrl&)")]
		void PermanentRedirection(KIO.Job job, KUrl fromUrl, KUrl toUrl);
	}
}
