//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  A KFileItem is a generic class to handle a file, local or remote.
	///  In particular, it makes it easier to handle the result of KIO.ListDir
	///  (UDSEntry isn't very friendly to use).
	///  It includes many file attributes such as mimetype, icon, text, mode, link...
	///  KFileItem is implicitly shared, i.e. it can be used as a value and copied around at almost no cost.
	///  </remarks>		<short>    A KFileItem is a generic class to handle a file, local or remote.</short>

	[SmokeClass("KFileItem")]
	public class KFileItem : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KFileItem(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KFileItem), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KFileItem() {
			staticInterceptor = new SmokeInvocation(typeof(KFileItem), null);
		}
		/// <remarks>
		///  The timestamps associated with a file.
		///  - ModificationTime: the time the file's contents were last modified
		///  - AccessTime: the time the file was last accessed (last read or written to)
		///  - CreationTime: the time the file was created
		///      </remarks>		<short>    The timestamps associated with a file.</short>
		public enum FileTimes {
			ModificationTime = 0,
			AccessTime = 1,
			CreationTime = 2,
		}
		public const int Unknown = -1;

		// KMimeType::Ptr determineMimeType(); >>>> NOT CONVERTED
		// KMimeType::Ptr mimeTypePtr(); >>>> NOT CONVERTED
		//  operator QVariant(); >>>> NOT CONVERTED
		/// <remarks>
		///  Null KFileItem. Doesn't represent any file, only exists for convenience.
		///      </remarks>		<short>    Null KFileItem.</short>
		public KFileItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem", "KFileItem()", typeof(void));
		}
		/// <remarks>
		///  Creates an item representing a file, from a UDSEntry.
		///  This is the preferred constructor when using KIO.ListDir().
		/// <param> name="entry" the KIO entry used to get the file, contains info about it
		/// </param><param> name="url" the file url
		/// </param><param> name="delayedMimeTypes" specifies if the mimetype of the given
		///        URL should be determined immediately or on demand.
		///        See the bool delayedMimeTypes in the KDirLister constructor.
		/// </param><param> name="urlIsDirectory" specifies if the url is just the directory of the
		///        fileitem and the filename from the UDSEntry should be used.
		///      </param></remarks>		<short>    Creates an item representing a file, from a UDSEntry.</short>
		public KFileItem(KIO.UDSEntry entry, KUrl url, bool delayedMimeTypes, bool urlIsDirectory) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem##$$", "KFileItem(const KIO::UDSEntry&, const KUrl&, bool, bool)", typeof(void), typeof(KIO.UDSEntry), entry, typeof(KUrl), url, typeof(bool), delayedMimeTypes, typeof(bool), urlIsDirectory);
		}
		public KFileItem(KIO.UDSEntry entry, KUrl url, bool delayedMimeTypes) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem##$", "KFileItem(const KIO::UDSEntry&, const KUrl&, bool)", typeof(void), typeof(KIO.UDSEntry), entry, typeof(KUrl), url, typeof(bool), delayedMimeTypes);
		}
		public KFileItem(KIO.UDSEntry entry, KUrl url) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem##", "KFileItem(const KIO::UDSEntry&, const KUrl&)", typeof(void), typeof(KIO.UDSEntry), entry, typeof(KUrl), url);
		}
		/// <remarks>
		///  Creates an item representing a file, from all the necessary info for it.
		/// <param> name="mode" the file mode (according to stat() (e.g. S_IFDIR...)
		///  Set to KFileItem.Unknown if unknown. For local files, KFileItem will use stat().
		/// </param><param> name="permissions" the access permissions
		///  If you set both the mode and the permissions, you save a .Stat() for
		///  local files.
		///  Set to KFileItem.Unknown if you don't know the mode or the permission.
		/// </param><param> name="url" the file url
		/// </param><param> name="delayedMimeTypes" specify if the mimetype of the given URL
		///        should be determined immediately or on demand
		///      </param></remarks>		<short>    Creates an item representing a file, from all the necessary info for it.</short>
		public KFileItem(long mode, long permissions, KUrl url, bool delayedMimeTypes) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem$$#$", "KFileItem(mode_t, mode_t, const KUrl&, bool)", typeof(void), typeof(long), mode, typeof(long), permissions, typeof(KUrl), url, typeof(bool), delayedMimeTypes);
		}
		public KFileItem(long mode, long permissions, KUrl url) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem$$#", "KFileItem(mode_t, mode_t, const KUrl&)", typeof(void), typeof(long), mode, typeof(long), permissions, typeof(KUrl), url);
		}
		/// <remarks>
		///  Creates an item representing a file, for which the mimetype is already known.
		/// <param> name="url" the file url
		/// </param><param> name="mimeType" the name of the file's mimetype
		/// </param><param> name="mode" the mode (S_IFDIR...)
		///      </param></remarks>		<short>    Creates an item representing a file, for which the mimetype is already known.</short>
		public KFileItem(KUrl url, string mimeType, long mode) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem#$$", "KFileItem(const KUrl&, const QString&, mode_t)", typeof(void), typeof(KUrl), url, typeof(string), mimeType, typeof(long), mode);
		}
		/// <remarks>
		///  Copy constructor
		///      </remarks>		<short>    Copy constructor      </short>
		public KFileItem(KFileItem other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFileItem#", "KFileItem(const KFileItem&)", typeof(void), typeof(KFileItem), other);
		}
		/// <remarks>
		///  Throw away and re-read (for local files) all information about the file.
		///  This is called when the _file_ changes.
		///      </remarks>		<short>    Throw away and re-read (for local files) all information about the file.</short>
		public void Refresh() {
			interceptor.Invoke("refresh", "refresh()", typeof(void));
		}
		/// <remarks>
		///  Re-reads mimetype information.
		///  This is called when the mimetype database changes.
		///      </remarks>		<short>    Re-reads mimetype information.</short>
		public void RefreshMimeType() {
			interceptor.Invoke("refreshMimeType", "refreshMimeType()", typeof(void));
		}
		/// <remarks>
		///  Returns the url of the file.
		/// </remarks>		<return> the url of the file
		///      </return>
		/// 		<short>    Returns the url of the file.</short>
		public KUrl Url() {
			return (KUrl) interceptor.Invoke("url", "url() const", typeof(KUrl));
		}
		/// <remarks>
		///  Sets the item's URL. Do not call unless you know what you are doing!
		///  (used for example when an item got renamed).
		/// <param> name="url" the item's URL
		///      </param></remarks>		<short>    Sets the item's URL.</short>
		public void SetUrl(KUrl url) {
			interceptor.Invoke("setUrl#", "setUrl(const KUrl&)", typeof(void), typeof(KUrl), url);
		}
		/// <remarks>
		///  Sets the item's name (i.e. the filename).
		///  This is automatically done by setUrl, to set the name from the URL's fileName().
		///  This method is provided for some special cases like relative paths as names (KFindPart)
		/// <param> name="name" the item's name
		///      </param></remarks>		<short>    Sets the item's name (i.</short>
		public void SetName(string name) {
			interceptor.Invoke("setName$", "setName(const QString&)", typeof(void), typeof(string), name);
		}
		/// <remarks>
		///  Returns the permissions of the file (stat.st_mode containing only permissions).
		/// </remarks>		<return> the permissions of the file
		///      </return>
		/// 		<short>    Returns the permissions of the file (stat.</short>
		public long Permissions() {
			return (long) interceptor.Invoke("permissions", "permissions() const", typeof(long));
		}
		/// <remarks>
		///  Returns the access permissions for the file as a string.
		/// </remarks>		<return> the access persmission as string
		///      </return>
		/// 		<short>    Returns the access permissions for the file as a string.</short>
		public string PermissionsString() {
			return (string) interceptor.Invoke("permissionsString", "permissionsString() const", typeof(string));
		}
		/// <remarks>
		///  Tells if the file has extended access level information ( Posix ACL )
		/// </remarks>		<return> true if the file has extend ACL information or false if it hasn't
		///      </return>
		/// 		<short>    Tells if the file has extended access level information ( Posix ACL ) </short>
		public bool HasExtendedACL() {
			return (bool) interceptor.Invoke("hasExtendedACL", "hasExtendedACL() const", typeof(bool));
		}
		/// <remarks>
		///  Returns the access control list for the file.
		/// </remarks>		<return> the access control list as a KACL
		///      </return>
		/// 		<short>    Returns the access control list for the file.</short>
		public KACL ACL() {
			return (KACL) interceptor.Invoke("ACL", "ACL() const", typeof(KACL));
		}
		/// <remarks>
		///  Returns the default access control list for the directory.
		/// </remarks>		<return> the default access control list as a KACL
		///      </return>
		/// 		<short>    Returns the default access control list for the directory.</short>
		public KACL DefaultACL() {
			return (KACL) interceptor.Invoke("defaultACL", "defaultACL() const", typeof(KACL));
		}
		/// <remarks>
		///  Returns the file type (stat.st_mode containing only S_IFDIR, S_IFLNK, ...).
		/// </remarks>		<return> the file type
		///      </return>
		/// 		<short>    Returns the file type (stat.</short>
		public long Mode() {
			return (long) interceptor.Invoke("mode", "mode() const", typeof(long));
		}
		/// <remarks>
		///  Returns the owner of the file.
		/// </remarks>		<return> the file's owner
		///      </return>
		/// 		<short>    Returns the owner of the file.</short>
		public string User() {
			return (string) interceptor.Invoke("user", "user() const", typeof(string));
		}
		/// <remarks>
		///  Returns the group of the file.
		/// </remarks>		<return> the file's group
		///      </return>
		/// 		<short>    Returns the group of the file.</short>
		public string Group() {
			return (string) interceptor.Invoke("group", "group() const", typeof(string));
		}
		/// <remarks>
		///  Returns true if this item represents a link in the UNIX sense of
		///  a link.
		/// </remarks>		<return> true if the file is a link
		///      </return>
		/// 		<short>    Returns true if this item represents a link in the UNIX sense of  a link.</short>
		public bool IsLink() {
			return (bool) interceptor.Invoke("isLink", "isLink() const", typeof(bool));
		}
		/// <remarks>
		///  Returns true if this item represents a directory.
		/// </remarks>		<return> true if the item is a directory
		///      </return>
		/// 		<short>    Returns true if this item represents a directory.</short>
		public bool IsDir() {
			return (bool) interceptor.Invoke("isDir", "isDir() const", typeof(bool));
		}
		/// <remarks>
		///  Returns true if this item represents a file (and not a a directory)
		/// </remarks>		<return> true if the item is a file
		///      </return>
		/// 		<short>    Returns true if this item represents a file (and not a a directory) </short>
		public bool IsFile() {
			return (bool) interceptor.Invoke("isFile", "isFile() const", typeof(bool));
		}
		/// <remarks>
		///  Checks whether the file or directory is readable. In some cases
		///  (remote files), we may return true even though it can't be read.
		/// </remarks>		<return> true if the file can be read - more precisely,
		///          false if we know for sure it can't
		///      </return>
		/// 		<short>    Checks whether the file or directory is readable.</short>
		public bool IsReadable() {
			return (bool) interceptor.Invoke("isReadable", "isReadable() const", typeof(bool));
		}
		/// <remarks>
		///  Checks whether the file or directory is writable. In some cases
		///  (remote files), we may return true even though it can't be written to.
		/// </remarks>		<return> true if the file or directory can be written to - more precisely,
		///          false if we know for sure it can't
		///      </return>
		/// 		<short>    Checks whether the file or directory is writable.</short>
		public bool IsWritable() {
			return (bool) interceptor.Invoke("isWritable", "isWritable() const", typeof(bool));
		}
		/// <remarks>
		///  Checks whether the file is hidden.
		/// </remarks>		<return> true if the file is hidden.
		///      </return>
		/// 		<short>    Checks whether the file is hidden.</short>
		public bool IsHidden() {
			return (bool) interceptor.Invoke("isHidden", "isHidden() const", typeof(bool));
		}
		/// <remarks>
		///  Returns the link destination if isLink() == true.
		/// </remarks>		<return> the link destination. string() if the item is not a link
		///      </return>
		/// 		<short>    Returns the link destination if isLink() == true.</short>
		public string LinkDest() {
			return (string) interceptor.Invoke("linkDest", "linkDest() const", typeof(string));
		}
		/// <remarks>
		///  Returns the local path if isLocalFile() == true or the KIO item has
		///  a UDS_LOCAL_PATH atom.
		/// </remarks>		<return> the item local path, or string() if not known
		///      </return>
		/// 		<short>    Returns the local path if isLocalFile() == true or the KIO item has  a UDS_LOCAL_PATH atom.</short>
		public string LocalPath() {
			return (string) interceptor.Invoke("localPath", "localPath() const", typeof(string));
		}
		/// <remarks>
		///  Returns the size of the file, if known.
		/// </remarks>		<return> the file size, or 0 if not known
		///      </return>
		/// 		<short>    Returns the size of the file, if known.</short>
		public long Size() {
			return (long) interceptor.Invoke("size", "size() const", typeof(long));
		}
		/// <remarks>
		///  Requests the modification, access or creation time, depending on <code>which.</code>
		/// <param> name="which" the timestamp
		/// </param></remarks>		<return> the time asked for, (time_t)0 if not available
		/// </return>
		/// 		<short>    Requests the modification, access or creation time, depending on <code>which.</code></short>
		/// 		<see> timeString</see>
		public int Time(KFileItem.FileTimes which) {
			return (int) interceptor.Invoke("time$", "time(KFileItem::FileTimes) const", typeof(int), typeof(KFileItem.FileTimes), which);
		}
		/// <remarks>
		///  Requests the modification, access or creation time as a string, depending
		///  on <code>which.</code>
		/// <param> name="which" the timestamp
		/// </param></remarks>		<return> a formatted string of the requested time.
		/// </return>
		/// 		<short>    Requests the modification, access or creation time as a string, depending  on <code>which.</code></short>
		/// 		<see> time</see>
		public string TimeString(KFileItem.FileTimes which) {
			return (string) interceptor.Invoke("timeString$", "timeString(KFileItem::FileTimes) const", typeof(string), typeof(KFileItem.FileTimes), which);
		}
		public string TimeString() {
			return (string) interceptor.Invoke("timeString", "timeString() const", typeof(string));
		}
		/// <remarks>
		///  Returns true if the file is a local file.
		/// </remarks>		<return> true if the file is local, false otherwise
		///      </return>
		/// 		<short>    Returns true if the file is a local file.</short>
		public bool IsLocalFile() {
			return (bool) interceptor.Invoke("isLocalFile", "isLocalFile() const", typeof(bool));
		}
		/// <remarks>
		///  Returns the text of the file item.
		///  It's not exactly the filename since some decoding happens ('%2F'.'/').
		/// </remarks>		<return> the text of the file item
		///      </return>
		/// 		<short>    Returns the text of the file item.</short>
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		/// <remarks>
		///  Return the name of the file item (without a path).
		///  Similar to text(), but unencoded, i.e. the original name.
		/// <param> name="lowerCase" if true, the name will be returned in lower case,
		///  which is useful to speed up sorting by name, case insensitively.
		/// </param></remarks>		<return> the file's name
		///      </return>
		/// 		<short>    Return the name of the file item (without a path).</short>
		public string Name(bool lowerCase) {
			return (string) interceptor.Invoke("name$", "name(bool) const", typeof(string), typeof(bool), lowerCase);
		}
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		/// <remarks>
		///  Returns the mimetype of the file item.
		///  If <code>delayedMimeTypes</code> was used in the constructor, this will determine
		///  the mimetype first. Equivalent to determineMimeType().Name()
		/// </remarks>		<return> the mime type of the file
		///      </return>
		/// 		<short>    Returns the mimetype of the file item.</short>
		public string Mimetype() {
			return (string) interceptor.Invoke("mimetype", "mimetype() const", typeof(string));
		}
		/// <remarks>
		///  Returns the mimetype of the file item.
		///  If delayedMimeTypes was used in the constructor, this will determine
		///  the mimetype first.
		/// </remarks>		<return> the mime type
		///      </return>
		/// 		<short>    Returns the mimetype of the file item.</short>
		/// <remarks>
		///  Returns the currently known mimetype of the file item.
		///  This will not try to determine the mimetype if unknown.
		/// </remarks>		<return> the known mime type
		///      </return>
		/// 		<short>    Returns the currently known mimetype of the file item.</short>
		/// <remarks>
		/// </remarks>		<return> true if we have determined the mimetype of this file already,
		///  i.e. if determineMimeType() will be fast. Otherwise it will have to
		///  find what the mimetype is, which is a possibly slow operation; usually
		///  this is delayed until necessary.
		///      </return>
		/// 		<short>   </short>
		public bool IsMimeTypeKnown() {
			return (bool) interceptor.Invoke("isMimeTypeKnown", "isMimeTypeKnown() const", typeof(bool));
		}
		/// <remarks>
		///  Returns the descriptive comment for this mime type, or
		///  the mime type itself if none is present.
		/// </remarks>		<return> the mime type description, or the mime type itself
		///      </return>
		/// 		<short>    Returns the descriptive comment for this mime type, or  the mime type itself if none is present.</short>
		public string MimeComment() {
			return (string) interceptor.Invoke("mimeComment", "mimeComment() const", typeof(string));
		}
		/// <remarks>
		///  Returns the full path name to the icon that represents
		///  this mime type.
		/// </remarks>		<return> iconName the name of the file's icon
		///      </return>
		/// 		<short>    Returns the full path name to the icon that represents  this mime type.</short>
		public string IconName() {
			return (string) interceptor.Invoke("iconName", "iconName() const", typeof(string));
		}
		/// <remarks>
		///  Returns a pixmap representing the file.
		/// <param> name="_size" Size for the pixmap in pixels. Zero will return the
		///  globally configured default size.
		/// </param><param> name="_state" The state of the icon: K3Icon.DefaultState,
		///  K3Icon.ActiveState or K3Icon.DisabledState.
		/// </param></remarks>		<return> the pixmap
		///      </return>
		/// 		<short>    Returns a pixmap representing the file.</short>
		public QPixmap Pixmap(int _size, int _state) {
			return (QPixmap) interceptor.Invoke("pixmap$$", "pixmap(int, int) const", typeof(QPixmap), typeof(int), _size, typeof(int), _state);
		}
		public QPixmap Pixmap(int _size) {
			return (QPixmap) interceptor.Invoke("pixmap$", "pixmap(int) const", typeof(QPixmap), typeof(int), _size);
		}
		/// <remarks>
		///  Returns the overlays (bitfield of K3Icon.Overlay flags) that are used
		///  for this item's pixmap. Overlays are used to show for example, whether
		///  a file can be modified.
		/// </remarks>		<return> the overlays of the pixmap
		///      </return>
		/// 		<short>    Returns the overlays (bitfield of K3Icon. Overlay flags) that are used  for this item's pixmap.</short>
		public List<string> Overlays() {
			return (List<string>) interceptor.Invoke("overlays", "overlays() const", typeof(List<string>));
		}
		/// <remarks>
		///  Returns the string to be displayed in the statusbar,
		///  e.g. when the mouse is over this item
		/// </remarks>		<return> the status bar information
		///      </return>
		/// 		<short>    Returns the string to be displayed in the statusbar,  e.</short>
		public string GetStatusBarInfo() {
			return (string) interceptor.Invoke("getStatusBarInfo", "getStatusBarInfo() const", typeof(string));
		}
		/// <remarks>
		///  Returns the string to be displayed in the tool tip when the mouse
		///  is over this item. This may load a plugin to determine additional
		///  information specific to the mimetype of the file.
		/// <param> name="maxcount" the maximum number of entries shown
		/// </param></remarks>		<return> the tool tip string
		///      </return>
		/// 		<short>    Returns the string to be displayed in the tool tip when the mouse  is over this item.</short>
		public string GetToolTipText(int maxcount) {
			return (string) interceptor.Invoke("getToolTipText$", "getToolTipText(int) const", typeof(string), typeof(int), maxcount);
		}
		public string GetToolTipText() {
			return (string) interceptor.Invoke("getToolTipText", "getToolTipText() const", typeof(string));
		}
		/// <remarks>
		///  Let's "KRun" this file !
		///  (e.g. when file is clicked or double-clicked or return is pressed)
		///      </remarks>		<short>    Let's "KRun" this file !  (e.</short>
		public void Run(QWidget parentWidget) {
			interceptor.Invoke("run#", "run(QWidget*) const", typeof(void), typeof(QWidget), parentWidget);
		}
		public void Run() {
			interceptor.Invoke("run", "run() const", typeof(void));
		}
		/// <remarks>
		///  Returns the UDS entry. Used by the tree view to access all details
		///  by position.
		/// </remarks>		<return> the UDS entry
		///      </return>
		/// 		<short>    Returns the UDS entry.</short>
		public KIO.UDSEntry Entry() {
			return (KIO.UDSEntry) interceptor.Invoke("entry", "entry() const", typeof(KIO.UDSEntry));
		}
		/// <remarks>
		///  Used when updating a directory. marked == seen when refreshing.
		/// </remarks>		<return> true if the file item is marked
		///      </return>
		/// 		<short>    Used when updating a directory.</short>
		public bool IsMarked() {
			return (bool) interceptor.Invoke("isMarked", "isMarked() const", typeof(bool));
		}
		/// <remarks>
		///  Marks the item.
		/// </remarks>		<short>    Marks the item.</short>
		/// 		<see> isMarked</see>
		public void Mark() {
			interceptor.Invoke("mark", "mark()", typeof(void));
		}
		/// <remarks>
		///  Unmarks the item.
		/// </remarks>		<short>    Unmarks the item.</short>
		/// 		<see> isMarked</see>
		public void Unmark() {
			interceptor.Invoke("unmark", "unmark()", typeof(void));
		}
		/// <remarks>
		///  Somewhat like a comparison operator, but more explicit,
		///  and it can detect that two kfileitems are equal even when they do
		///  not share the same internal pointer - e.g. when KDirLister compares
		///  fileitems after listing a directory again, to detect changes.
		/// <param> name="item" the item to compare
		/// </param></remarks>		<return> true if all values are equal
		///      </return>
		/// 		<short>    Somewhat like a comparison operator, but more explicit,  and it can detect that two kfileitems are equal even when they do  not share the same internal pointer - e.</short>
		public bool Cmp(KFileItem item) {
			return (bool) interceptor.Invoke("cmp#", "cmp(const KFileItem&) const", typeof(bool), typeof(KFileItem), item);
		}
		public override bool Equals(object o) {
			if (!(o is KFileItem)) { return false; }
			return this == (KFileItem) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		/// <remarks>
		///  Converts this KFileItem to a QVariant, this allows to use KFileItem
		///  in QVariant() constructor
		///      </remarks>		<short>    Converts this KFileItem to a QVariant, this allows to use KFileItem  in QVariant() constructor      </short>
		/// <remarks>
		///  Sets the metainfo of this item to <code>info.</code>
		/// <param> name="info" the new meta info
		///      </param></remarks>		<short>    Sets the metainfo of this item to <code>info.</code></short>
		public void SetMetaInfo(KFileMetaInfo info) {
			interceptor.Invoke("setMetaInfo#", "setMetaInfo(const KFileMetaInfo&)", typeof(void), typeof(KFileMetaInfo), info);
		}
		/// <remarks>
		///  Returns the metainfo of this item.
		/// <param> name="autoget" if true, the metainfo will automatically be created
		/// </param><param> name="what" ignored
		///      </param></remarks>		<short>    Returns the metainfo of this item.</short>
		public KFileMetaInfo MetaInfo(bool autoget, int what) {
			return (KFileMetaInfo) interceptor.Invoke("metaInfo$$", "metaInfo(bool, int) const", typeof(KFileMetaInfo), typeof(bool), autoget, typeof(int), what);
		}
		public KFileMetaInfo MetaInfo(bool autoget) {
			return (KFileMetaInfo) interceptor.Invoke("metaInfo$", "metaInfo(bool) const", typeof(KFileMetaInfo), typeof(bool), autoget);
		}
		public KFileMetaInfo MetaInfo() {
			return (KFileMetaInfo) interceptor.Invoke("metaInfo", "metaInfo() const", typeof(KFileMetaInfo));
		}
		/// <remarks>
		///  Tries to give a local URL for this file item if possible.
		///  The given boolean indicates if the returned url is local or not.
		///      </remarks>		<short>    Tries to give a local URL for this file item if possible.</short>
		public KUrl MostLocalUrl(bool local) {
			return (KUrl) interceptor.Invoke("mostLocalUrl$", "mostLocalUrl(bool&) const", typeof(KUrl), typeof(bool), local);
		}
		/// <remarks>
		///  Return true if default-constructed
		///      </remarks>		<short>    Return true if default-constructed      </short>
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		~KFileItem() {
			interceptor.Invoke("~KFileItem", "~KFileItem()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KFileItem", "~KFileItem()", typeof(void));
		}
		public static bool operator==(KFileItem lhs, KFileItem other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const KFileItem&) const", typeof(bool), typeof(KFileItem), lhs, typeof(KFileItem), other);
		}
		public static bool operator!=(KFileItem lhs, KFileItem other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const KFileItem&) const", typeof(bool), typeof(KFileItem), lhs, typeof(KFileItem), other);
		}
	}
}
