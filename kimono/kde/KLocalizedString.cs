//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  KLocalizedString handles translation and specific needs of argument
	///  substitution and formatting in localized message strings.
	///  Topics:
	///   - <see cref="#gen_usage"></see>
	///   - <see cref="#spec_usage"></see>
	///   - <see cref="#subs_notes"></see>
	///   - <see cref="#other_ref"></see>
	///  \section gen_usage General Usage
	///  This class should mostly not be used directly, but through wrapper i18n
	///  calls which return string, for localization of user visible messages in
	///  applications.
	///  For the most frequent message type, the one without any arguments, you would
	///  use simply:
	///  <pre>
	///    string msg = i18n("Just plain info");
	///  </pre>
	///  If there are arguments to be substitued into the message, you just add them
	///  after the message string:
	///  <pre>
	///    string msg = i18n("%1 has scored %2", playerName, score);
	///  </pre>
	///  There can be up to some final number of arguments added like this (i18n
	///  is realized by overloaded templates). If you overrun this number, use
	///  ki18n series of calls (described below). You can use several types as
	///  arguments, see subs methods.
	///  Sometimes a short message can be ambiguous in English, then you would use
	///  the context version, i18nc. There the first string is context, and the
	///  second is the message which really gets displayed:
	///  <pre>
	///    string msg = i18nc("Player name - score", "%1 - %2", playerName, score);
	///  </pre>
	///  While English diferentiates plural forms only between 1 and else, in other
	///  languages it might not be that simple, or it might be simpler. To handle
	///  this properly, use plural call, i18np:
	///  <pre>
	///    string msg = i18np("One image in album %2", "%1 images in album %2",
	///                        numImages, albumName);
	///  </pre>
	///  Note that the plural form shall be decided by first integer-valued argument,
	///  (numImages in the example above). In rare cases when there are two integer
	///  arguments, you should take care to order them properly.
	///  Finally, message might need both context and plural, which is provided by
	///  i18ncp call:
	///  <pre>
	///    string msg = i18ncp("Personal file", "One file", "%1 files", numFiles);
	///  </pre>
	///  Be carefull not to use literal string as first argument after message text
	///  in basic i18n() call. In debug mode, it will even trigger the static assert,
	///  giving error at compile time. This is in order to prevent misnamed calls:
	///  it may happen that you add context or plural to previously basic message,
	///  but forget to change the name of the call.
	///  All message strings are expected to pass for well-formed XML, whether or
	///  not the output device supports some form of markup.
	///  Thus, predefined XML entities are always available: &amp;lt;, &amp;gt;,
	///  &amp;amp;, &amp;apos;, and &amp;quot;. E.g. if you need a non-tag
	///  less-than sign, use &amp;lt; entity instead.
	///  The exception to the well-formed XML requirement is the ampersand (&amp;),
	///  which is used a lot for marking accelerators, so you should not write it
	///  as &amp;amp; (except in the very unlikely case when the construct with
	///  the naked ampersand can be interpreted as an entity in itself).
	///  \section spec_usage Specialized Usage
	///  There are some situations where i18n calls are not sufficient or
	///  convenient. For one, if you need to substitute many arguments. Or, if you
	///  find that you need to defer the substitution. For this you can use the
	///  ki18n call which returns a KLocalizedString, substitute arguments
	///  using its subs methods, and finalize the translation by calling
	///  its toString method. For example:
	///  <pre>
	///    KLocalizedString ks;
	///    case (reportSource) {
	///      SRC_ENG: ks = ki18n("Engineering reports: %1"); break;
	///      SRC_HEL: ks = ki18n("Helm reports: %1"); break;
	///      SRC_SON: ks = ki18n("Sonar reports: %1"); break;
	///      default: ks = ki18n("General report: %1");
	///    }
	///    string msg = ks.subs(reportText).toString();
	///  </pre>
	///  Another case is when you want extra formatting of arguments, like field
	///  width or number of decimals. subs methods can take these formatting
	///  parameters. In particular, you should @e never use some custom way to
	///  format arguments, as subs methods will also properly localize them:
	///  <pre>
	///    string s = i18n("Rounds: %1", myNumberFormat(n, 8)); // bad, number not localized
	///    string s = ki18n("Rounds: %1").subs(n, 8).toString(); // good, number localized
	///  </pre>
	///  There are also context, plural and context-plural variants:
	///  <pre>
	///    string s = ki18nc("No function", "None").toString();
	///    string s = ki18np("File found", "%1 files found").subs(n).toString();
	///    string s = ki18ncp("Personal file", "One file", "%1 files").subs(n).toString();
	///  </pre>
	///  If you need translation using locale (ie. KLocale object) other than the
	///  default, you can use overloaded toString method which takes pointer to a
	///  locale:
	///  <pre>
	///    KLocale myLocale;
	///    ...
	///    ki18n("Welcome").toString(myLocale);
	///  </pre>
	///  Translators have a capability to script translations at runtime, which is
	///  for the most part transparent to the programmer. However, sometimes the
	///  programmer may help by providing some @e dynamic context to the message,
	///  using the inContext method of KLocalizedString.  Unlike the ordinary
	///  context, this one changes at runtime; translators have the means to fetch
	///  it and use it to script the translation properly. An example:
	///  <pre>
	///    KLocalizedString ks = ki18nc("%1 is user name; may have "
	///                                 "dynamic context gender=[male,female]",
	///                                 "%1 went offline");
	///    if (knownUsers.contains(user) && !knownUsers[user].gender.isEmpty()) {
	///      ks = ks.inContext("gender", knownUsers[user].gender);
	///    }
	///    string msg = ks.subs(user).toString();
	///  </pre>
	///   Several dynamic contexts, with different keys, can be added like this.
	///  \section subs_notes Placeholder Substitution
	///  Hopefully, for the most part placeholders are being substituted the way
	///  you would intuitively expect them to be. Nevertheless:
	///  <li>Placeholders</li> are substituted in one pass, so no need to worry about
	///      argument itself containing a placeholder.
	///  <li>All</li> same-numbered placeholders are substituted with same argument.
	///  <li>Placeholders</li> directly index arguments: they should be numbered from 1
	///      upwards, without gaps in the sequence so that each argument is indexed.
	///      Otherwise you will get error marks in messages at runtime (when compiled
	///      in debug mode), and any invalid placeholder will be left unsubstituted.
	///      The exception is plural-deciding argument in plural call, where it is
	///      allowed to drop its placeholder in either singular or plural form.
	///  <li>If</li> none of the arguments supplied to a plural call is integer-valued,
	///      you will get an error mark in message at runtime (in debug mode).
	///  <li>Plain</li> number arguments will be normally formatted as if they denote
	///      amounts, according to language rules (thousands separation, etc.)
	///      But sometimes a number is a numerical identifier (e.g. port number),
	///      and to be treated as such, wrap the placeholder with the numid tag:
	///      <pre>
	///        string msg = i18n("Using port <numid>%1</numid>", port);
	///      </pre>
	///  \section other_ref Further References
	///  <a href="http://techbase.kde.org/">KDE Techbase</a> contains a
	///  <a href="http://techbase.kde.org/Development/Tutorials/Localization">
	///  series of tutorials</a> on preparing the code for localization (and on
	///  internationalization process in general), where the intended patterns of
	///  usage of i18n API are covered in great detail.
	///  All i18n'd messages, whether sent to widgets expecting plain text or
	///  allowing Qt rich text (HTML), support the new KDE semantic markup for
	///  user interface text, KUIT in short. Semantic markup both increases the
	///  consistency of visual presentation for the end user, and provides extra
	///  information to translators, so that translations can be of higher quality.
	///  KUIT is documented in an
	///  <a href="http://techbase.kde.org/Development/Tutorials/Localization/i18n_Semantics">
	///  Techbase article</a> as well.
	/// </remarks>		<author> Chusslove Illich \<caslav.ilic@gmx.net\>
	///  </author>
	/// 		<short> Class for producing and handling localized messages.</short>
	/// 		<see> KLocale</see>

	[SmokeClass("KLocalizedString")]
	public class KLocalizedString : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KLocalizedString(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KLocalizedString), this);
		}
		// void notifyCatalogsUpdated(const QStringList& arg1,const QList<KCatalogName>& arg2); >>>> NOT CONVERTED
		/// <remarks>
		///  Constructs an empty message, which is not valid for finalization.
		///  Useful when you later need to assign KLocalizedString obtained by one
		///  of ki18n calls.
		/// </remarks>		<short>    Constructs an empty message, which is not valid for finalization.</short>
		/// 		<see> isEmpty</see>
		public KLocalizedString() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KLocalizedString", "KLocalizedString()", typeof(void));
		}
		/// <remarks>
		///  Copy constructor.
		///      </remarks>		<short>    Copy constructor.</short>
		public KLocalizedString(KLocalizedString rhs) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KLocalizedString#", "KLocalizedString(const KLocalizedString&)", typeof(void), typeof(KLocalizedString), rhs);
		}
		/// <remarks>
		///  Finalizes the translation, creates string with placeholders
		///  substituted. Translations is obtained from default locale.
		///  If there was any mismatch between placeholders and arguments
		///  returned string will contain error marks (in debug mode).
		/// </remarks>		<return> finalized translation
		///      </return>
		/// 		<short>    Finalizes the translation, creates string with placeholders  substituted.</short>
		public new string ToString() {
			return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
		}
		/// <remarks>
		///  Finalizes the translation, creates string with placeholders
		///  substituted. Translations is obtained from given locale. If locale
		///  is NULL, original message is used instead of translated.
		///  If there was any mismatch between placeholders and arguments
		///  returned string will contain error marks (in debug mode).
		/// <param> name="locale" locale from which translations are to be taken
		/// </param></remarks>		<return> finalized translation
		///      </return>
		/// 		<short>    Finalizes the translation, creates string with placeholders  substituted.</short>
		public string ToString(KLocale locale) {
			return (string) interceptor.Invoke("toString#", "toString(const KLocale*) const", typeof(string), typeof(KLocale), locale);
		}
		/// <remarks>
		///  Checks whether the message is empty. This will happen if you just
		///  constructed the object via default constructor.
		///  Empty messages are not valid for finalization; if you use toString() on
		///  them, you will get error mark instead of empty string (in debug mode).
		/// </remarks>		<return> @c true if the message is empty, else @c false
		///      </return>
		/// 		<short>    Checks whether the message is empty.</short>
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		/// <remarks>
		///  Substitutes an int argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="base" the radix used to represent the number as a string.
		///              Valid values range from 2 to 36
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes an int argument into the message.</short>
		public KLocalizedString Subs(int a, int fieldWidth, int arg3, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs$$$#", "subs(int, int, int, const QChar&) const", typeof(KLocalizedString), typeof(int), a, typeof(int), fieldWidth, typeof(int), arg3, typeof(char), fillChar);
		}
		public KLocalizedString Subs(int a, int fieldWidth, int arg3) {
			return (KLocalizedString) interceptor.Invoke("subs$$$", "subs(int, int, int) const", typeof(KLocalizedString), typeof(int), a, typeof(int), fieldWidth, typeof(int), arg3);
		}
		public KLocalizedString Subs(int a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs$$", "subs(int, int) const", typeof(KLocalizedString), typeof(int), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(int a) {
			return (KLocalizedString) interceptor.Invoke("subs$", "subs(int) const", typeof(KLocalizedString), typeof(int), a);
		}
		/// <remarks>
		///  Substitutes an unsigned int argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="base" the radix used to represent the number as a string.
		///              Valid values range from 2 to 36
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes an unsigned int argument into the message.</short>
		public KLocalizedString Subs(uint a, int fieldWidth, int arg3, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs$$$#", "subs(uint, int, int, const QChar&) const", typeof(KLocalizedString), typeof(uint), a, typeof(int), fieldWidth, typeof(int), arg3, typeof(char), fillChar);
		}
		public KLocalizedString Subs(uint a, int fieldWidth, int arg3) {
			return (KLocalizedString) interceptor.Invoke("subs$$$", "subs(uint, int, int) const", typeof(KLocalizedString), typeof(uint), a, typeof(int), fieldWidth, typeof(int), arg3);
		}
		public KLocalizedString Subs(uint a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs$$", "subs(uint, int) const", typeof(KLocalizedString), typeof(uint), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(uint a) {
			return (KLocalizedString) interceptor.Invoke("subs$", "subs(uint) const", typeof(KLocalizedString), typeof(uint), a);
		}
		/// <remarks>
		///  Substitutes a long argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="base" the radix used to represent the number as a string.
		///              Valid values range from 2 to 36
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes a long argument into the message.</short>
		public KLocalizedString Subs(long a, int fieldWidth, int arg3, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs$$$#", "subs(long, int, int, const QChar&) const", typeof(KLocalizedString), typeof(long), a, typeof(int), fieldWidth, typeof(int), arg3, typeof(char), fillChar);
		}
		public KLocalizedString Subs(long a, int fieldWidth, int arg3) {
			return (KLocalizedString) interceptor.Invoke("subs$$$", "subs(long, int, int) const", typeof(KLocalizedString), typeof(long), a, typeof(int), fieldWidth, typeof(int), arg3);
		}
		public KLocalizedString Subs(long a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs$$", "subs(long, int) const", typeof(KLocalizedString), typeof(long), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(long a) {
			return (KLocalizedString) interceptor.Invoke("subs$", "subs(long) const", typeof(KLocalizedString), typeof(long), a);
		}
		/// <remarks>
		///  Substitutes an unsigned long argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="base" the radix used to represent the number as a string.
		///              Valid values range from 2 to 36
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes an unsigned long argument into the message.</short>
		public KLocalizedString Subs(ulong a, int fieldWidth, int arg3, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs$$$#", "subs(ulong, int, int, const QChar&) const", typeof(KLocalizedString), typeof(ulong), a, typeof(int), fieldWidth, typeof(int), arg3, typeof(char), fillChar);
		}
		public KLocalizedString Subs(ulong a, int fieldWidth, int arg3) {
			return (KLocalizedString) interceptor.Invoke("subs$$$", "subs(ulong, int, int) const", typeof(KLocalizedString), typeof(ulong), a, typeof(int), fieldWidth, typeof(int), arg3);
		}
		public KLocalizedString Subs(ulong a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs$$", "subs(ulong, int) const", typeof(KLocalizedString), typeof(ulong), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(ulong a) {
			return (KLocalizedString) interceptor.Invoke("subs$", "subs(ulong) const", typeof(KLocalizedString), typeof(ulong), a);
		}
		/// <remarks>
		///  Substitutes a double argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="format" type of floating point formating, like in string.Arg
		/// </param><param> name="precision" number of digits after the decimal separator
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes a double argument into the message.</short>
		public KLocalizedString Subs(double a, int fieldWidth, char format, int precision, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs$$$$#", "subs(double, int, char, int, const QChar&) const", typeof(KLocalizedString), typeof(double), a, typeof(int), fieldWidth, typeof(char), format, typeof(int), precision, typeof(char), fillChar);
		}
		public KLocalizedString Subs(double a, int fieldWidth, char format, int precision) {
			return (KLocalizedString) interceptor.Invoke("subs$$$$", "subs(double, int, char, int) const", typeof(KLocalizedString), typeof(double), a, typeof(int), fieldWidth, typeof(char), format, typeof(int), precision);
		}
		public KLocalizedString Subs(double a, int fieldWidth, char format) {
			return (KLocalizedString) interceptor.Invoke("subs$$$", "subs(double, int, char) const", typeof(KLocalizedString), typeof(double), a, typeof(int), fieldWidth, typeof(char), format);
		}
		public KLocalizedString Subs(double a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs$$", "subs(double, int) const", typeof(KLocalizedString), typeof(double), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(double a) {
			return (KLocalizedString) interceptor.Invoke("subs$", "subs(double) const", typeof(KLocalizedString), typeof(double), a);
		}
		/// <remarks>
		///  Substitutes a char argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes a char argument into the message.</short>
		public KLocalizedString Subs(char a, int fieldWidth, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs#$#", "subs(QChar, int, const QChar&) const", typeof(KLocalizedString), typeof(char), a, typeof(int), fieldWidth, typeof(char), fillChar);
		}
		public KLocalizedString Subs(char a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs#$", "subs(QChar, int) const", typeof(KLocalizedString), typeof(char), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(char a) {
			return (KLocalizedString) interceptor.Invoke("subs#", "subs(QChar) const", typeof(KLocalizedString), typeof(char), a);
		}
		/// <remarks>
		///  Substitutes a string argument into the message.
		/// <param> name="a" the argument
		/// </param><param> name="fieldWidth" width of the formatted field, padded by spaces.
		///                    Positive value aligns right, negative aligns left
		/// </param><param> name="fillChar" the character used to fill up the empty places when
		///                  field width is greater than argument width
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Substitutes a string argument into the message.</short>
		public KLocalizedString Subs(string a, int fieldWidth, char fillChar) {
			return (KLocalizedString) interceptor.Invoke("subs$$#", "subs(const QString&, int, const QChar&) const", typeof(KLocalizedString), typeof(string), a, typeof(int), fieldWidth, typeof(char), fillChar);
		}
		public KLocalizedString Subs(string a, int fieldWidth) {
			return (KLocalizedString) interceptor.Invoke("subs$$", "subs(const QString&, int) const", typeof(KLocalizedString), typeof(string), a, typeof(int), fieldWidth);
		}
		public KLocalizedString Subs(string a) {
			return (KLocalizedString) interceptor.Invoke("subs$", "subs(const QString&) const", typeof(KLocalizedString), typeof(string), a);
		}
		/// <remarks>
		///  Adds dynamic context to the message.
		/// <param> name="key" context key
		/// </param><param> name="text" context value
		/// </param></remarks>		<return> resultant KLocalizedString
		///      </return>
		/// 		<short>    Adds dynamic context to the message.</short>
		public KLocalizedString InContext(string key, string text) {
			return (KLocalizedString) interceptor.Invoke("inContext$$", "inContext(const QString&, const QString&) const", typeof(KLocalizedString), typeof(string), key, typeof(string), text);
		}
		~KLocalizedString() {
			interceptor.Invoke("~KLocalizedString", "~KLocalizedString()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KLocalizedString", "~KLocalizedString()", typeof(void));
		}
		/// <remarks>
		///      </remarks>		<short>   </short>
	}
}
