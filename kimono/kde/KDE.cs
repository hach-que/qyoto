//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  @name Typelist macros
	///  Convenience macros for transforming flat type enumerations into the
	///  recursive typelist structure. For a typelist with <code>N</code> items, the
	///  <code>K_TYPELIST_N</code> macro is used. For example:
	///  @code
	///   typedef K_TYPELIST_4(char, short, int, long) IntegralTypes;
	///  @endcode
	///  However, the preferred way is to use the KMakeTypeList template.
	///  @ingroup ktypelist
	///  </remarks>		<short>    @name Typelist macros </short>

	[SmokeClass("KDE")]
	public class KDE : Object {
		protected SmokeInvocation interceptor = null;
		private static SmokeInvocation staticInterceptor = null;
		static KDE() {
			staticInterceptor = new SmokeInvocation(typeof(KDE), null);
		}
		// bool urlcmp(const QString& arg1,const QString& arg2,const KUrl::EqualsOptions& arg3); >>>> NOT CONVERTED
		// QDataStream& operator>>(QDataStream& arg1,KProtocolInfo::ExtraField& arg2); >>>> NOT CONVERTED
		// QDataStream& operator<<(QDataStream& arg1,const KProtocolInfo::ExtraField& arg2); >>>> NOT CONVERTED
		/// <remarks>
		///  @brief Returns the encoded number of KDE's version, see the KDE_VERSION macro.
		///  In contrary to the macro KDE_VERSION
		///  this function returns the number of the actually
		///  installed KDE version, not the number of the KDE version that was
		///  installed when the program was compiled.
		/// </remarks>		<return> the version number, encoded in a single uint
		///      </return>
		/// 		<short>    @brief Returns the encoded number of KDE's version, see the KDE_VERSION macro.</short>
		public static uint Version() {
			return (uint) staticInterceptor.Invoke("version", "version()", typeof(uint));
		}
		/// <remarks>
		///  @brief Returns the major number of KDE's version, e.g.
		///  4 for KDE 4.1.2. 
		/// </remarks>		<return> the major version number
		///      </return>
		/// 		<short>    @brief Returns the major number of KDE's version, e.</short>
		public static uint VersionMajor() {
			return (uint) staticInterceptor.Invoke("versionMajor", "versionMajor()", typeof(uint));
		}
		/// <remarks>
		///  @brief Returns the minor number of KDE's version, e.g.
		///  1 for KDE 4.1.2. 
		/// </remarks>		<return> the minor version number
		///      </return>
		/// 		<short>    @brief Returns the minor number of KDE's version, e.</short>
		public static uint VersionMinor() {
			return (uint) staticInterceptor.Invoke("versionMinor", "versionMinor()", typeof(uint));
		}
		/// <remarks>
		///  @brief Returns the release of KDE's version, e.g.
		///  2 for KDE 4.1.2. 
		/// </remarks>		<return> the release number
		///      </return>
		/// 		<short>    @brief Returns the release of KDE's version, e.</short>
		public static uint VersionRelease() {
			return (uint) staticInterceptor.Invoke("versionRelease", "versionRelease()", typeof(uint));
		}
		/// <remarks>
		///  @brief Returns the KDE version as string, e.g. "4.1.2".
		///  On contrary to the macro KDE_VERSION_STRING this function returns
		///  the version number of KDE at runtime.
		/// </remarks>		<return> the KDE version. You can keep the string forever
		///      </return>
		/// 		<short>    @brief Returns the KDE version as string, e.</short>
		public static string VersionString() {
			return (string) staticInterceptor.Invoke("versionString", "versionString()", typeof(string));
		}
		public static uint QHash(int arg1) {
			return (uint) staticInterceptor.Invoke("qHash$", "qHash(int)", typeof(uint), typeof(int), arg1);
		}
		public static uint QHash(KShortcut key) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const KShortcut&)", typeof(uint), typeof(KShortcut), key);
		}
		public static uint QHash(QKeySequence key) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const QKeySequence&)", typeof(uint), typeof(QKeySequence), key);
		}
		public static uint QHash(KPluginInfo arg1) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const KPluginInfo&)", typeof(uint), typeof(KPluginInfo), arg1);
		}
		public static int Kasciistricmp(string str1, string str2) {
			return (int) staticInterceptor.Invoke("kasciistricmp$$", "kasciistricmp(const char*, const char*)", typeof(int), typeof(string), str1, typeof(string), str2);
		}
		public static string KAsciiToLower(string str) {
			return (string) staticInterceptor.Invoke("kAsciiToLower$", "kAsciiToLower(char*)", typeof(string), typeof(string), str);
		}
		public static string KAsciiToUpper(string str) {
			return (string) staticInterceptor.Invoke("kAsciiToUpper$", "kAsciiToUpper(char*)", typeof(string), typeof(string), str);
		}
		public static uint QHash(string key) {
			return (uint) staticInterceptor.Invoke("qHash$", "qHash(const QString&)", typeof(uint), typeof(string), key);
		}
		public static uint QHash(KFileItem item) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const KFileItem&)", typeof(uint), typeof(KFileItem), item);
		}
		public static QDataStream Write(QDataStream s, KFileItem a) {
			return (QDataStream) staticInterceptor.Invoke("operator<<##", "operator<<(QDataStream&, const KFileItem&)", typeof(QDataStream), typeof(QDataStream), s, typeof(KFileItem), a);
		}
		public static QDataStream Read(QDataStream s, KFileItem a) {
			return (QDataStream) staticInterceptor.Invoke("operator>>##", "operator>>(QDataStream&, KFileItem&)", typeof(QDataStream), typeof(QDataStream), s, typeof(KFileItem), a);
		}
		public static QDataStream Write(QDataStream s, KACL a) {
			return (QDataStream) staticInterceptor.Invoke("operator<<##", "operator<<(QDataStream&, const KACL&)", typeof(QDataStream), typeof(QDataStream), s, typeof(KACL), a);
		}
		public static QDataStream Read(QDataStream s, KACL a) {
			return (QDataStream) staticInterceptor.Invoke("operator>>##", "operator>>(QDataStream&, KACL&)", typeof(QDataStream), typeof(QDataStream), s, typeof(KACL), a);
		}
		public static uint QHash(KShapeGesture key) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const KShapeGesture&)", typeof(uint), typeof(KShapeGesture), key);
		}
		public static uint QHash(KRockerGesture key) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const KRockerGesture&)", typeof(uint), typeof(KRockerGesture), key);
		}
		public static bool Urlcmp(string _url1, string _url2) {
			return (bool) staticInterceptor.Invoke("urlcmp$$", "urlcmp(const QString&, const QString&)", typeof(bool), typeof(string), _url1, typeof(string), _url2);
		}
		public static uint QHash(KUrl kurl) {
			return (uint) staticInterceptor.Invoke("qHash#", "qHash(const KUrl&)", typeof(uint), typeof(KUrl), kurl);
		}
		public static QPixmap DesktopIcon(string name, int size, int state, List<string> overlays) {
			return (QPixmap) staticInterceptor.Invoke("DesktopIcon$$$?", "DesktopIcon(const QString&, int, int, const QStringList&)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state, typeof(List<string>), overlays);
		}
		public static QPixmap DesktopIcon(string name, int size, int state) {
			return (QPixmap) staticInterceptor.Invoke("DesktopIcon$$$", "DesktopIcon(const QString&, int, int)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state);
		}
		public static QPixmap DesktopIcon(string name, int size) {
			return (QPixmap) staticInterceptor.Invoke("DesktopIcon$$", "DesktopIcon(const QString&, int)", typeof(QPixmap), typeof(string), name, typeof(int), size);
		}
		public static QPixmap DesktopIcon(string name) {
			return (QPixmap) staticInterceptor.Invoke("DesktopIcon$", "DesktopIcon(const QString&)", typeof(QPixmap), typeof(string), name);
		}
		public static QPixmap BarIcon(string name, int size, int state, List<string> overlays) {
			return (QPixmap) staticInterceptor.Invoke("BarIcon$$$?", "BarIcon(const QString&, int, int, const QStringList&)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state, typeof(List<string>), overlays);
		}
		public static QPixmap BarIcon(string name, int size, int state) {
			return (QPixmap) staticInterceptor.Invoke("BarIcon$$$", "BarIcon(const QString&, int, int)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state);
		}
		public static QPixmap BarIcon(string name, int size) {
			return (QPixmap) staticInterceptor.Invoke("BarIcon$$", "BarIcon(const QString&, int)", typeof(QPixmap), typeof(string), name, typeof(int), size);
		}
		public static QPixmap BarIcon(string name) {
			return (QPixmap) staticInterceptor.Invoke("BarIcon$", "BarIcon(const QString&)", typeof(QPixmap), typeof(string), name);
		}
		public static QPixmap SmallIcon(string name, int size, int state, List<string> overlays) {
			return (QPixmap) staticInterceptor.Invoke("SmallIcon$$$?", "SmallIcon(const QString&, int, int, const QStringList&)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state, typeof(List<string>), overlays);
		}
		public static QPixmap SmallIcon(string name, int size, int state) {
			return (QPixmap) staticInterceptor.Invoke("SmallIcon$$$", "SmallIcon(const QString&, int, int)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state);
		}
		public static QPixmap SmallIcon(string name, int size) {
			return (QPixmap) staticInterceptor.Invoke("SmallIcon$$", "SmallIcon(const QString&, int)", typeof(QPixmap), typeof(string), name, typeof(int), size);
		}
		public static QPixmap SmallIcon(string name) {
			return (QPixmap) staticInterceptor.Invoke("SmallIcon$", "SmallIcon(const QString&)", typeof(QPixmap), typeof(string), name);
		}
		public static QPixmap MainBarIcon(string name, int size, int state, List<string> overlays) {
			return (QPixmap) staticInterceptor.Invoke("MainBarIcon$$$?", "MainBarIcon(const QString&, int, int, const QStringList&)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state, typeof(List<string>), overlays);
		}
		public static QPixmap MainBarIcon(string name, int size, int state) {
			return (QPixmap) staticInterceptor.Invoke("MainBarIcon$$$", "MainBarIcon(const QString&, int, int)", typeof(QPixmap), typeof(string), name, typeof(int), size, typeof(int), state);
		}
		public static QPixmap MainBarIcon(string name, int size) {
			return (QPixmap) staticInterceptor.Invoke("MainBarIcon$$", "MainBarIcon(const QString&, int)", typeof(QPixmap), typeof(string), name, typeof(int), size);
		}
		public static QPixmap MainBarIcon(string name) {
			return (QPixmap) staticInterceptor.Invoke("MainBarIcon$", "MainBarIcon(const QString&)", typeof(QPixmap), typeof(string), name);
		}
		public static QPixmap UserIcon(string name, int state, List<string> overlays) {
			return (QPixmap) staticInterceptor.Invoke("UserIcon$$?", "UserIcon(const QString&, int, const QStringList&)", typeof(QPixmap), typeof(string), name, typeof(int), state, typeof(List<string>), overlays);
		}
		public static QPixmap UserIcon(string name, int state) {
			return (QPixmap) staticInterceptor.Invoke("UserIcon$$", "UserIcon(const QString&, int)", typeof(QPixmap), typeof(string), name, typeof(int), state);
		}
		public static QPixmap UserIcon(string name) {
			return (QPixmap) staticInterceptor.Invoke("UserIcon$", "UserIcon(const QString&)", typeof(QPixmap), typeof(string), name);
		}
		public static int IconSize(KIconLoader.Group group) {
			return (int) staticInterceptor.Invoke("IconSize$", "IconSize(KIconLoader::Group)", typeof(int), typeof(KIconLoader.Group), group);
		}
		public static KLocalizedString Ki18n(string msg) {
			return (KLocalizedString) staticInterceptor.Invoke("ki18n$", "ki18n(const char*)", typeof(KLocalizedString), typeof(string), msg);
		}
		public static KLocalizedString Ki18nc(string ctxt, string msg) {
			return (KLocalizedString) staticInterceptor.Invoke("ki18nc$$", "ki18nc(const char*, const char*)", typeof(KLocalizedString), typeof(string), ctxt, typeof(string), msg);
		}
		public static KLocalizedString Ki18np(string singular, string plural) {
			return (KLocalizedString) staticInterceptor.Invoke("ki18np$$", "ki18np(const char*, const char*)", typeof(KLocalizedString), typeof(string), singular, typeof(string), plural);
		}
		public static KLocalizedString Ki18ncp(string ctxt, string singular, string plural) {
			return (KLocalizedString) staticInterceptor.Invoke("ki18ncp$$$", "ki18ncp(const char*, const char*, const char*)", typeof(KLocalizedString), typeof(string), ctxt, typeof(string), singular, typeof(string), plural);
		}
		public static string Tr2i18n(string message, string comment) {
			return (string) staticInterceptor.Invoke("tr2i18n$$", "tr2i18n(const char*, const char*)", typeof(string), typeof(string), message, typeof(string), comment);
		}
		public static string Tr2i18n(string message) {
			return (string) staticInterceptor.Invoke("tr2i18n$", "tr2i18n(const char*)", typeof(string), typeof(string), message);
		}
		public static string I18n(string text) {
			return (string) staticInterceptor.Invoke("i18n$", "i18n(const char*)", typeof(string), typeof(string), text);
		}
		public static string I18nc(string ctxt, string text) {
			return (string) staticInterceptor.Invoke("i18nc$$", "i18nc(const char*, const char*)", typeof(string), typeof(string), ctxt, typeof(string), text);
		}
		public static QDataStream Read(QDataStream str, KServiceAction act) {
			return (QDataStream) staticInterceptor.Invoke("operator>>##", "operator>>(QDataStream&, KServiceAction&)", typeof(QDataStream), typeof(QDataStream), str, typeof(KServiceAction), act);
		}
		public static QDataStream Write(QDataStream str, KServiceAction act) {
			return (QDataStream) staticInterceptor.Invoke("operator<<##", "operator<<(QDataStream&, const KServiceAction&)", typeof(QDataStream), typeof(QDataStream), str, typeof(KServiceAction), act);
		}
		public static QDataStream Write(QDataStream s, KIO.UDSEntry a) {
			return (QDataStream) staticInterceptor.Invoke("operator<<##", "operator<<(QDataStream&, const KIO::UDSEntry&)", typeof(QDataStream), typeof(QDataStream), s, typeof(KIO.UDSEntry), a);
		}
		public static QDataStream Read(QDataStream s, KIO.UDSEntry a) {
			return (QDataStream) staticInterceptor.Invoke("operator>>##", "operator>>(QDataStream&, KIO::UDSEntry&)", typeof(QDataStream), typeof(QDataStream), s, typeof(KIO.UDSEntry), a);
		}
	}
}
