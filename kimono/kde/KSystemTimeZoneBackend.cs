//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Runtime.InteropServices;

	/// <remarks>
	///  Backend class for KSystemTimeZone class.
	///  This class implements KSystemTimeZone's constructors and methods. A
	///  backend class is required for all classes inherited from KTimeZone to
	///  allow KTimeZone methods to work together with reference counting of
	///  private data.
	/// </remarks>		<author> David Jarvie <djarvie@kde.org>.
	///  </author>
	/// 		<short> Backend class for KSystemTimeZone class.</short>
	/// 		<see> KTimeZoneBackend</see>
	/// 		<see> KSystemTimeZone</see>
	/// 		<see> KTimeZone</see>
	/// 		<see> @ingroup</see>
	/// 		<see> timezones</see>

	[SmokeClass("KSystemTimeZoneBackend")]
	public class KSystemTimeZoneBackend : KTimeZoneBackend, IDisposable {
 		protected KSystemTimeZoneBackend(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KSystemTimeZoneBackend), this);
		}
		/// <remarks> Implements KSystemTimeZone.KSystemTimeZone(). </remarks>		<short>   Implements KSystemTimeZone.KSystemTimeZone().</short>
		public KSystemTimeZoneBackend(KSystemTimeZoneSource source, string name, string countryCode, float latitude, float longitude, string comment) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KSystemTimeZoneBackend#$$$$$", "KSystemTimeZoneBackend(KSystemTimeZoneSource*, const QString&, const QString&, float, float, const QString&)", typeof(void), typeof(KSystemTimeZoneSource), source, typeof(string), name, typeof(string), countryCode, typeof(float), latitude, typeof(float), longitude, typeof(string), comment);
		}
		/// <remarks>
		///  Creates a copy of this instance.
		/// </remarks>		<return> new copy
		///      </return>
		/// 		<short>    Creates a copy of this instance.</short>
		[SmokeMethod("clone() const")]
		public override KTimeZoneBackend Clone() {
			return (KTimeZoneBackend) interceptor.Invoke("clone", "clone() const", typeof(KTimeZoneBackend));
		}
		/// <remarks>
		///  Returns the class name of the data represented by this instance.
		/// </remarks>		<return> "KSystemTimeZone"
		///      </return>
		/// 		<short>    Returns the class name of the data represented by this instance.</short>
		[SmokeMethod("type() const")]
		public override QByteArray type() {
			return (QByteArray) interceptor.Invoke("type", "type() const", typeof(QByteArray));
		}
		/// <remarks>
		///  Implements KSystemTimeZone.OffsetAtZoneTime().
		///  Returns the offset of this time zone to UTC at the given local date/time.
		///  Because of daylight savings time shifts, the date/time may occur twice. Optionally,
		///  the offsets at both occurrences of <code>dateTime</code> are calculated.
		///  The offset is the number of seconds which you must add to UTC to get
		///  local time in this time zone.
		/// <param> name="caller" calling KSystemTimeZone object
		/// </param><param> name="zoneDateTime" the date/time at which the offset is to be calculated. This
		///                      is interpreted as a local time in this time zone. An error
		///                      occurs if <code>zoneDateTime.timeSpec</code>() is not Qt.LocalTime.
		/// </param><param> name="secondOffset" if non-null, and the <code>zoneDateTime</code> occurs twice, receives the
		///                      UTC offset for the second occurrence. Otherwise, it is set
		///                      the same as the return value.
		/// </param></remarks>		<return> offset in seconds. If <code>zoneDateTime</code> occurs twice, it is the offset at the
		///          first occurrence which is returned.
		///      </return>
		/// 		<short>    Implements KSystemTimeZone.OffsetAtZoneTime().</short>
		[SmokeMethod("offsetAtZoneTime(const KTimeZone*, const QDateTime&, int*) const")]
		public override int OffsetAtZoneTime(KTimeZone caller, QDateTime zoneDateTime, ref int secondOffset) {
			StackItem[] stack = new StackItem[4];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caller);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caller);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(zoneDateTime);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(zoneDateTime);
#endif
			stack[3].s_int = secondOffset;
			interceptor.Invoke("offsetAtZoneTime##$", "offsetAtZoneTime(const KTimeZone*, const QDateTime&, int*) const", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
			secondOffset = stack[3].s_int;
			return stack[0].s_int;
		}
		/// <remarks>
		///  Implements KSystemTimeZone.OffsetAtUtc().
		///  Returns the offset of this time zone to UTC at the given UTC date/time.
		///  The offset is the number of seconds which you must add to UTC to get
		///  local time in this time zone.
		///  Note that system times are represented using time_t. An error occurs if the date
		///  falls outside the range supported by time_t.
		/// <param> name="caller" calling KSystemTimeZone object
		/// </param><param> name="utcDateTime" the UTC date/time at which the offset is to be calculated.
		///                     An error occurs if <code>utcDateTime.timeSpec</code>() is not Qt.UTC.
		/// </param></remarks>		<return> offset in seconds, or 0 if error
		///      </return>
		/// 		<short>    Implements KSystemTimeZone.OffsetAtUtc().</short>
		[SmokeMethod("offsetAtUtc(const KTimeZone*, const QDateTime&) const")]
		public override int OffsetAtUtc(KTimeZone caller, QDateTime utcDateTime) {
			return (int) interceptor.Invoke("offsetAtUtc##", "offsetAtUtc(const KTimeZone*, const QDateTime&) const", typeof(int), typeof(KTimeZone), caller, typeof(QDateTime), utcDateTime);
		}
		/// <remarks>
		///  Implements KSystemTimeZone.Offset().
		///  Returns the offset of this time zone to UTC at a specified UTC time.
		///  The offset is the number of seconds which you must add to UTC to get
		///  local time in this time zone.
		/// <param> name="caller" calling KSystemTimeZone object
		/// </param><param> name="t" the UTC time at which the offset is to be calculated, measured in seconds
		///           since 00:00:00 UTC 1st January 1970 (as returned by time(2))
		/// </param></remarks>		<return> offset in seconds, or 0 if error
		///      </return>
		/// 		<short>    Implements KSystemTimeZone.Offset().</short>
		[SmokeMethod("offset(const KTimeZone*, time_t) const")]
		public override int Offset(KTimeZone caller, int t) {
			return (int) interceptor.Invoke("offset#$", "offset(const KTimeZone*, time_t) const", typeof(int), typeof(KTimeZone), caller, typeof(int), t);
		}
		/// <remarks>
		///  Implements KSystemTimeZone.IsDstAtUtc().
		///  Returns whether daylight savings time is in operation at the given UTC date/time.
		///  Note that system times are represented using time_t. An error occurs if the date
		///  falls outside the range supported by time_t.
		/// <param> name="caller" calling KSystemTimeZone object
		/// </param><param> name="utcDateTime" the UTC date/time. An error occurs if
		///                     <code>utcDateTime.timeSpec</code>() is not Qt.UTC.
		/// </param></remarks>		<return> @c true if daylight savings time is in operation, @c false otherwise
		///      </return>
		/// 		<short>    Implements KSystemTimeZone.IsDstAtUtc().</short>
		[SmokeMethod("isDstAtUtc(const KTimeZone*, const QDateTime&) const")]
		public override bool IsDstAtUtc(KTimeZone caller, QDateTime utcDateTime) {
			return (bool) interceptor.Invoke("isDstAtUtc##", "isDstAtUtc(const KTimeZone*, const QDateTime&) const", typeof(bool), typeof(KTimeZone), caller, typeof(QDateTime), utcDateTime);
		}
		/// <remarks>
		///  Implements KSystemTimeZone.IsDst().
		///  Returns whether daylight savings time is in operation at a specified UTC time.
		/// <param> name="caller" calling KSystemTimeZone object
		/// </param><param> name="t" the UTC time, measured in seconds since 00:00:00 UTC 1st January 1970
		///           (as returned by time(2))
		/// </param></remarks>		<return> @c true if daylight savings time is in operation, @c false otherwise
		///      </return>
		/// 		<short>    Implements KSystemTimeZone.IsDst().</short>
		[SmokeMethod("isDst(const KTimeZone*, time_t) const")]
		public override bool IsDst(KTimeZone caller, int t) {
			return (bool) interceptor.Invoke("isDst#$", "isDst(const KTimeZone*, time_t) const", typeof(bool), typeof(KTimeZone), caller, typeof(int), t);
		}
		~KSystemTimeZoneBackend() {
			interceptor.Invoke("~KSystemTimeZoneBackend", "~KSystemTimeZoneBackend()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KSystemTimeZoneBackend", "~KSystemTimeZoneBackend()", typeof(void));
		}
	}
}
