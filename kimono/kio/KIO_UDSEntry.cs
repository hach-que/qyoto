//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  Universal Directory Service
	///  UDS entry is the data structure representing all the fields about a given URL
	///  (file or directory).
	///  The KIO.ListDir() and KIO:stat() operations use this data structure.
	///  KIO defines a number of standard fields, see the UDS_XXX enums (see StandardFieldTypes).
	///  at the moment UDSEntry only provides fields with numeric indexes,
	///  but there might be named fields with string indexes in the future.
	///  For instance, to retrieve the name of the entry, use:
	///  <pre>
	///  string displayName = entry.stringValue( KIO.UDSEntry.UDS_NAME );
	///  </pre>
	///  To know the modification time of the file/url:
	///  <pre>
	///   time_t mtime = entry.numberValue( KIO.UDSEntry.UDS_MODIFICATION_TIME, -1 );
	///   if ( mtime != -1 )
	///       ...
	///  </pre>
	///      </remarks>		<short>    Universal Directory Service </short>

	[SmokeClass("KIO::UDSEntry")]
	public class UDSEntry : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected UDSEntry(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(UDSEntry), this);
		}
		/// <remarks>
		///  Constants used to specify the type of a UDSField.
		///          </remarks>		<short>    Constants used to specify the type of a UDSField.</short>
		public enum StandardFieldTypes {
			UDS_STRING = 0x01000000,
			UDS_NUMBER = 0x02000000,
			UDS_TIME = 0x04000000|UDS_NUMBER,
			UDS_SIZE = 1|UDS_NUMBER,
			UDS_SIZE_LARGE = 2|UDS_NUMBER,
			UDS_USER = 3|UDS_STRING,
			UDS_ICON_NAME = 4|UDS_STRING,
			UDS_GROUP = 5|UDS_STRING,
			UDS_NAME = 6|UDS_STRING,
			UDS_LOCAL_PATH = 7|UDS_STRING,
			UDS_HIDDEN = 8|UDS_NUMBER,
			UDS_ACCESS = 9|UDS_NUMBER,
			UDS_MODIFICATION_TIME = 10|UDS_TIME,
			UDS_ACCESS_TIME = 11|UDS_TIME,
			UDS_CREATION_TIME = 12|UDS_TIME,
			UDS_FILE_TYPE = 13|UDS_NUMBER,
			UDS_LINK_DEST = 14|UDS_STRING,
			UDS_URL = 15|UDS_STRING,
			UDS_MIME_TYPE = 16|UDS_STRING,
			UDS_GUESSED_MIME_TYPE = 17|UDS_STRING,
			UDS_XML_PROPERTIES = 18|UDS_STRING,
			UDS_EXTENDED_ACL = 19|UDS_NUMBER,
			UDS_ACL_STRING = 20|UDS_STRING,
			UDS_DEFAULT_ACL_STRING = 21|UDS_STRING,
			UDS_DISPLAY_NAME = 22|UDS_STRING,
			UDS_TARGET_URL = 23|UDS_STRING,
			UDS_EXTRA = 100|UDS_STRING,
			UDS_EXTRA_END = 140|UDS_STRING,
		}
		// long long numberValue(uint arg1,long long arg2); >>>> NOT CONVERTED
		// long long numberValue(uint arg1); >>>> NOT CONVERTED
		// void insert(uint arg1,long long arg2); >>>> NOT CONVERTED
		public UDSEntry() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("UDSEntry", "UDSEntry()", typeof(void));
		}
		public UDSEntry(KIO.UDSEntry other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("UDSEntry#", "UDSEntry(const KIO::UDSEntry&)", typeof(void), typeof(KIO.UDSEntry), other);
		}
		/// <remarks>
		/// </remarks>		<return> value of a textual field
		///          </return>
		/// 		<short>   </short>
		public string StringValue(uint field) {
			return (string) interceptor.Invoke("stringValue$", "stringValue(uint) const", typeof(string), typeof(uint), field);
		}
		/// <remarks>
		/// </remarks>		<return> value of a numeric field
		///          </return>
		/// 		<short>   </short>
		public bool IsDir() {
			return (bool) interceptor.Invoke("isDir", "isDir() const", typeof(bool));
		}
		public bool IsLink() {
			return (bool) interceptor.Invoke("isLink", "isLink() const", typeof(bool));
		}
		/// <remarks>
		///  insert field with numeric value
		/// <param> name="field" numeric field id
		/// </param><param> name="value"          </param></remarks>		<short>    insert field with numeric value </short>
		public void Insert(uint field, string value) {
			interceptor.Invoke("insert$$", "insert(uint, const QString&)", typeof(void), typeof(uint), field, typeof(string), value);
		}
		/// <remarks>
		///  insert field with string value
		/// <param> name="field" numeric tield id
		/// </param><param> name="l" value to set
		///          </param></remarks>		<short>    insert field with string value </short>
		/// <remarks>
		///  count fields
		/// </remarks>		<return> the number of fields
		///          </return>
		/// 		<short>    count fields </short>
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		/// <remarks>
		///  check existence of a field
		/// <param> name="field"          </param></remarks>		<short>    check existence of a field </short>
		public bool Contains(uint field) {
			return (bool) interceptor.Invoke("contains$", "contains(uint) const", typeof(bool), typeof(uint), field);
		}
		/// <remarks>
		///  remove a field with a certain numeric id
		/// <param> name="field" numeric type id
		///          </param></remarks>		<short>    remove a field with a certain numeric id </short>
		public bool Remove(uint field) {
			return (bool) interceptor.Invoke("remove$", "remove(uint)", typeof(bool), typeof(uint), field);
		}
		/// <remarks>
		///  lists all fields
		///          </remarks>		<short>    lists all fields          </short>
		public List<uint> ListFields() {
			return (List<uint>) interceptor.Invoke("listFields", "listFields() const", typeof(List<uint>));
		}
		/// <remarks>
		///  remove all fields
		///          </remarks>		<short>    remove all fields          </short>
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		~UDSEntry() {
			interceptor.Invoke("~UDSEntry", "~UDSEntry()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~UDSEntry", "~UDSEntry()", typeof(void));
		}
	}
}
