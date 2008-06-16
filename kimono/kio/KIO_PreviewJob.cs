//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks> See <see cref="IPreviewJobSignals"></see> for signals emitted by PreviewJob
	/// </remarks>
	[SmokeClass("KIO::PreviewJob")]
	public class PreviewJob : KIO.Job, IDisposable {
 		protected PreviewJob(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(PreviewJob), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static PreviewJob() {
			staticInterceptor = new SmokeInvocation(typeof(PreviewJob), null);
		}
		/// <remarks>
		///  Creates a new PreviewJob.
		/// <param> name="items" a list of files to create previews for
		/// </param><param> name="width" the desired width
		/// </param><param> name="height" the desired height, 0 to use the <code>width</code>
		/// </param><param> name="iconSize" the size of the mimetype icon to overlay over the
		///  preview or zero to not overlay an icon. This has no effect if the
		///  preview plugin that will be used doesn't use icon overlays.
		/// </param><param> name="iconAlpha" transparency to use for the icon overlay
		/// </param><param> name="scale" if the image is to be scaled to the requested size or
		///  returned in its original size
		/// </param><param> name="save" if the image should be cached for later use
		/// </param><param> name="enabledPlugins" if non-zero, this points to a list containing
		///  the names of the plugins that may be used.
		/// 	 </param></remarks>		<short>    Creates a new PreviewJob.</short>
		public PreviewJob(List<KFileItem> items, int width, int height, int iconSize, int iconAlpha, bool scale, bool save, List<string> enabledPlugins) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("PreviewJob#$$$$$$?", "PreviewJob(const KFileItemList&, int, int, int, int, bool, bool, const QStringList*)", typeof(void), typeof(List<KFileItem>), items, typeof(int), width, typeof(int), height, typeof(int), iconSize, typeof(int), iconAlpha, typeof(bool), scale, typeof(bool), save, typeof(List<string>), enabledPlugins);
		}
		/// <remarks>
		///  Removes an item from preview processing. Use this if you passed
		///  an item to filePreview and want to delete it now.
		/// <param> name="url" the url of the item that should be removed from the preview queue
		///          </param></remarks>		<short>    Removes an item from preview processing.</short>
		public void RemoveItem(KUrl url) {
			interceptor.Invoke("removeItem#", "removeItem(const KUrl&)", typeof(void), typeof(KUrl), url);
		}
		/// <remarks>
		///  If <code>ignoreSize</code> is true, then the preview is always
		///  generated regardless of the settings
		/// </remarks>		<short>    If <code>ignoreSize</code> is true, then the preview is always  generated regardless of the settings </short>
		public void SetIgnoreMaximumSize(bool ignoreSize) {
			interceptor.Invoke("setIgnoreMaximumSize$", "setIgnoreMaximumSize(bool)", typeof(void), typeof(bool), ignoreSize);
		}
		public void SetIgnoreMaximumSize() {
			interceptor.Invoke("setIgnoreMaximumSize", "setIgnoreMaximumSize()", typeof(void));
		}
		[Q_SLOT("void slotResult(KJob*)")]
		[SmokeMethod("slotResult(KJob*)")]
		protected override void SlotResult(KJob job) {
			interceptor.Invoke("slotResult#", "slotResult(KJob*)", typeof(void), typeof(KJob), job);
		}
		~PreviewJob() {
			interceptor.Invoke("~PreviewJob", "~PreviewJob()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~PreviewJob", "~PreviewJob()", typeof(void));
		}
		/// <remarks>
		///  Returns a list of all available preview plugins. The list
		///  contains the basenames of the plugins' .desktop files (no path,
		///  no .desktop).
		/// </remarks>		<return> the list of plugins
		///          </return>
		/// 		<short>    Returns a list of all available preview plugins.</short>
		public static List<string> AvailablePlugins() {
			return (List<string>) staticInterceptor.Invoke("availablePlugins", "availablePlugins()", typeof(List<string>));
		}
		/// <remarks>
		///  Returns a list of all supported MIME types. The list can
		///  contain entries like text/  (without the space).
		/// </remarks>		<return> the list of mime types
		///          </return>
		/// 		<short>    Returns a list of all supported MIME types.</short>
		public static List<string> SupportedMimeTypes() {
			return (List<string>) staticInterceptor.Invoke("supportedMimeTypes", "supportedMimeTypes()", typeof(List<string>));
		}
		/// <remarks>
		///  Returns the default "maximum file size", in bytes, used by PreviewJob.
		///  This is useful for applications providing a GUI for letting the user change the size.
		/// </remarks>		<short>    Returns the default "maximum file size", in bytes, used by PreviewJob.</short>
		public static long MaximumFileSize() {
			return (long) staticInterceptor.Invoke("maximumFileSize", "maximumFileSize()", typeof(long));
		}
		protected new IPreviewJobSignals Emit {
			get { return (IPreviewJobSignals) Q_EMIT; }
		}
	}

	public interface IPreviewJobSignals : KIO.IJobSignals {
		/// <remarks>
		///  Emitted when a thumbnail picture for <code>item</code> has been successfully
		///  retrieved.
		/// <param> name="item" the file of the preview
		/// </param><param> name="preview" the preview image
		///          </param></remarks>		<short>    Emitted when a thumbnail picture for <code>item</code> has been successfully  retrieved.</short>
		[Q_SIGNAL("void gotPreview(const KFileItem&, const QPixmap&)")]
		void GotPreview(KFileItem item, QPixmap preview);
		/// <remarks>
		///  Emitted when a thumbnail for <code>item</code> could not be created,
		///  either because a ThumbCreator for its MIME type does not
		///  exist, or because something went wrong.
		/// <param> name="item" the file that failed
		///          </param></remarks>		<short>    Emitted when a thumbnail for <code>item</code> could not be created,  either because a ThumbCreator for its MIME type does not  exist, or because something went wrong.</short>
		[Q_SIGNAL("void failed(const KFileItem&)")]
		void Failed(KFileItem item);
	}
}
