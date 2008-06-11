//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///   KCmdLineArgs provides simple access to the command-line arguments
	///   for an application. It takes into account Qt-specific options,
	///   KDE-specific options and application specific options.
	///   This class is used in %main() via the static method
	///   init().
	///   A typical %KDE application using %KCmdLineArgs should look like this:
	///   @code
	///   int main(string[] args)
	///   {
	///      // Initialize command line args
	///      KCmdLineArgs.Init(args, appName, programName, version, description);
	///      // Define the command line options using KCmdLineOptions
	///      KCmdLineOptions options;
	///      ....
	///      // Register the supported options
	///      KCmdLineArgs.AddCmdLineOptions( options );
	///      // Add options from other components
	///      KUniqueApplication.AddCmdLineOptions();
	///      ....
	///      // Create application object without passing 'argc' and 'argv' again.
	///      KUniqueApplication app;
	///      ....
	///      // Handle our own options/arguments
	///      // A KApplication will usually do this in main but this is not
	///      // necessary.
	///      // A KUniqueApplication might want to handle it in newInstance().
	///      KCmdLineArgs args = KCmdLineArgs.ParsedArgs();
	///      // A binary option (on / off)
	///      if (args.IsSet("some-option"))
	///         ....
	///      // An option which takes an additional argument
	///      string anotherOptionArg = args.GetOption("another-option");
	///      // Arguments (e.g. files to open)
	///      for(int i = 0; i < args.Count(); i++) // Counting start at 0!
	///      {
	///         openFile( args.Arg(i));
	///         // Or more convenient:
	///         // openUrl( args.Url(i));
	///      }
	///      args.Clear(); // Free up some memory.
	///      ....
	///   }
	///   @endcode
	///   The options that an application supports are configured using the
	///   KCmdLineOptions class. An example is shown below:
	///   @code
	///   KCmdLineOptions options;
	///   options.add("a", ki18n("A short binary option"));
	///   options.add("b \<file>", ki18n("A short option which takes an argument"));
	///   options.add("c \<speed>", ki18n("As above but with a default value"), "9600");
	///   options.add("option1", ki18n("A long binary option, off by default"));
	///   options.add("nooption2", ki18n("A long binary option, on by default"));
	///   options.add(":", ki18n("Extra options:"));
	///   options.add("option3 \<file>", ki18n("A long option which takes an argument"));
	///   options.add("option4 \<speed>", ki18n("A long option which takes an argument, defaulting to 9600"), "9600");
	///   options.add("d");
	///   options.add("option5", ki18n("A long option which has a short option as alias"));
	///   options.add("e");
	///   options.add("nooption6", ki18n("Another long option with an alias"));
	///   options.add("f");
	///   options.add("option7 \<speed>", ki18n("'--option7 speed' is the same as '-f speed'"));
	///   options.add("!option8 \<cmd>", ki18n("All options following this one will be treated as arguments"));
	///   options.add("+file", ki18n("A required argument 'file'"));
	///   options.add("+[arg1]", ki18n("An optional argument 'arg1'"));
	///   options.add("!+command", ki18n("A required argument 'command', that can contain multiple words, even starting with '-'"));
	///   options.add("", ki18n("Additional help text not associated with any particular option"));
	///   @endcode
	///   The ki18n calls are used for translation instead of the more usual i18n
	///   calls, because the translation needs to be delayed until after the
	///   message catalogs have been initialized.
	///   Note that a program should define the options before any arguments.
	///   When a long option has a short option as an alias, a program should
	///   only test for the long option.
	///   With the above options a command line could look like:
	///   @code
	///      myapp -a -c 4800 --display localhost:0.0 --nooption5 -d /tmp/file
	///   @endcode
	///   Long binary options can be in the form 'option' and 'nooption'.
	///   A command line may contain the same binary option multiple times,
	///   the last option determines the outcome:
	///   @code
	///      myapp --nooption4 --option4 --nooption4
	///   @endcode
	///   is the same as:
	///   @code
	///      myapp --nooption4
	///   @endcode
	///   If an option value is provided multiple times, normally only the last
	///   value is used:
	///   @code
	///      myapp -c 1200 -c 2400 -c 4800
	///   @endcode
	///   is usually the same as:
	///   @code
	///      myapp -c 4800
	///   @endcode
	///   However, an application can choose to use all values specified as well.
	///   As an example of this, consider that you may wish to specify a
	///   number of directories to use:
	///   @code
	///      myapp -I /usr/include -I /opt/kde/include -I /usr/X11/include
	///   @endcode
	///   When an application does this it should mention this in the description
	///   of the option. To access these options, use getOptionList()
	///   Tips for end-users:
	/// 
	/// <li>
	/// Single char options like "-a -b -c" may be combined into "-abc"
	/// </li>
	/// 
	/// <li>
	/// The option "--foo bar" may also be written "--foo=bar"
	/// </li>
	/// 
	/// <li>
	/// The option "-P lp1" may also be written "-P=lp1" or "-Plp1"
	/// </li>
	/// 
	/// <li>
	/// The option "--foo bar" may also be written "-foo bar"
	/// </li>
	/// </remarks>		<author> Waldo Bastian
	/// </author>
	/// 		<version> 0.0.4
	///  </version>
	/// 		<short> A class for command-line argument handling. </short>

	[SmokeClass("KCmdLineArgs")]
	public class KCmdLineArgs : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KCmdLineArgs(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KCmdLineArgs), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KCmdLineArgs() {
			staticInterceptor = new SmokeInvocation(typeof(KCmdLineArgs), null);
		}
		public enum StdCmdLineArg {
			CmdLineArgQt = 0x01,
			CmdLineArgKDE = 0x02,
			CmdLineArgsMask = 0x03,
			CmdLineArgNone = 0x00,
			Reserved = 0xff,
		}
		/// <remarks>
		///   Read out a string option.
		///   The option must have a corresponding KCmdLineOptions entry
		///   of the form:
		///   @code
		///     options.add("option \<argument>", ki18n("Description"), "default");
		///   @endcode
		///   You cannot test for the presence of an alias - you must always
		///   test for the full option.
		/// <param> name="option" The name of the option without '-'.
		/// </param></remarks>		<return> The value of the option. If the option was not
		///           present on the command line the default is returned.
		///           If the option was present more than once, the value of the
		///           last occurrence is used.
		///    </return>
		/// 		<short>     Read out a string option.</short>
		public string GetOption(QByteArray option) {
			return (string) interceptor.Invoke("getOption#", "getOption(const QByteArray&) const", typeof(string), typeof(QByteArray), option);
		}
		/// <remarks>
		///   Read out all occurrences of a string option.
		///   The option must have a corresponding KCmdLineOptions entry
		///   of the form:
		///   @code
		///     options.add("option \<argument>", ki18n("Description"), "default");
		///   @endcode
		///   You cannot test for the presence of an alias - you must always
		///   test for the full option.
		/// <param> name="option" The name of the option, without '-' or '-no'.
		/// </param></remarks>		<return> A list of all option values. If no option was present
		///           on the command line, an empty list is returned.
		///    </return>
		/// 		<short>     Read out all occurrences of a string option.</short>
		public List<string> GetOptionList(QByteArray option) {
			return (List<string>) interceptor.Invoke("getOptionList#", "getOptionList(const QByteArray&) const", typeof(List<string>), typeof(QByteArray), option);
		}
		/// <remarks>
		///   Read out a boolean option or check for the presence of string option.
		/// <param> name="option" The name of the option without '-' or '-no'.
		/// </param></remarks>		<return> The value of the option. It will be true if the option
		///   was specifically turned on in the command line, or if the option
		///   is turned on by default (in the KCmdLineOptions list) and was
		///   not specifically turned off in the command line. Equivalently,
		///   it will be false if the option was specifically turned off in
		///   the command line, or if the option is turned off by default (in
		///   the KCmdLineOptions list) and was not specifically turned on in
		///   the command line.
		///    </return>
		/// 		<short>     Read out a boolean option or check for the presence of string option.</short>
		public bool IsSet(QByteArray option) {
			return (bool) interceptor.Invoke("isSet#", "isSet(const QByteArray&) const", typeof(bool), typeof(QByteArray), option);
		}
		/// <remarks>
		///   Read the number of arguments that aren't options (but,
		///   for example, filenames).
		/// </remarks>		<return> The number of arguments that aren't options
		///    </return>
		/// 		<short>     Read the number of arguments that aren't options (but,   for example, filenames).</short>
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		/// <remarks>
		///   Read out an argument.
		/// <param> name="n" The argument to read. 0 is the first argument.
		///            count()-1 is the last argument.
		/// </param></remarks>		<return> n-th argument
		///    </return>
		/// 		<short>     Read out an argument.</short>
		public string Arg(int n) {
			return (string) interceptor.Invoke("arg$", "arg(int) const", typeof(string), typeof(int), n);
		}
		/// <remarks>
		///   Read out an argument representing a URL.
		///   The argument can be
		/// 
		/// <li>
		/// an absolute filename
		/// </li>
		/// 
		/// <li>
		/// a relative filename
		/// </li>
		/// 
		/// <li>
		/// a URL
		/// </li>
		/// <param> name="n" The argument to read. 0 is the first argument.
		///  count()-1 is the last argument.
		/// </param></remarks>		<return> a URL representing the n'th argument.
		///    </return>
		/// 		<short>     Read out an argument representing a URL.</short>
		public KUrl Url(int n) {
			return (KUrl) interceptor.Invoke("url$", "url(int) const", typeof(KUrl), typeof(int), n);
		}
		/// <remarks>
		///   Clear all options and arguments.
		///    </remarks>		<short>     Clear all options and arguments.</short>
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		/// <remarks>
		///   Constructor.
		///    </remarks>		<short>   </short>
		public KCmdLineArgs(KCmdLineOptions _options, KLocalizedString _name, QByteArray _id) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCmdLineArgs###", "KCmdLineArgs(const KCmdLineOptions&, const KLocalizedString&, const QByteArray&)", typeof(void), typeof(KCmdLineOptions), _options, typeof(KLocalizedString), _name, typeof(QByteArray), _id);
		}
		/// <remarks>
		///  Initialize class.
		///  This function should be called as the very first thing in
		///   your application.
		/// <param> name="argv" As passed to <code>main</code>(...).
		/// </param><param> name="appname" The untranslated name of your application. This should
		///                 match with <code>argv</code>[0].
		/// </param><param> name="catalog" Translation catalog name, if empty <code>appname</code> will be used.
		/// </param><param> name="programName" A program name string to be used for display
		///         purposes. This string should be marked for translation.
		///         Example: ki18n("KEdit")
		/// </param><param> name="version" A version.
		/// </param><param> name="description" A short description of what your application is about.
		///                     Also marked for translation.
		/// </param><param> name="stdargs" KDE/Qt or no default parameters
		///    </param></remarks>		<short>    Initialize class.</short>
		public static void Init(string argv, QByteArray appname, QByteArray catalog, KLocalizedString programName, QByteArray version, KLocalizedString description, uint stdargs) {
			staticInterceptor.Invoke("init$?#####$", "init(int, char**, const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KCmdLineArgs::StdCmdLineArgs)", typeof(void), typeof(string), argv, typeof(QByteArray), appname, typeof(QByteArray), catalog, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), description, typeof(uint), stdargs);
		}
		public static void Init(string argv, QByteArray appname, QByteArray catalog, KLocalizedString programName, QByteArray version, KLocalizedString description) {
			staticInterceptor.Invoke("init$?#####", "init(int, char**, const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&)", typeof(void), typeof(string), argv, typeof(QByteArray), appname, typeof(QByteArray), catalog, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), description);
		}
		public static void Init(string argv, QByteArray appname, QByteArray catalog, KLocalizedString programName, QByteArray version) {
			staticInterceptor.Invoke("init$?####", "init(int, char**, const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&)", typeof(void), typeof(string), argv, typeof(QByteArray), appname, typeof(QByteArray), catalog, typeof(KLocalizedString), programName, typeof(QByteArray), version);
		}
		/// <remarks>
		///  Initialize class.
		///  This function should be called as the very first thing in
		///   your application. It uses KAboutData to replace some of the
		///   arguments that would otherwise be required.
		/// <param> name="_argv" As passed to <code>main</code>(...).
		/// </param><param> name="about" A KAboutData object describing your program.
		/// </param><param> name="stdargs" KDE/Qt or no default parameters
		///    </param></remarks>		<short>    Initialize class.</short>
		public static void Init(string _argv, KAboutData about, uint stdargs) {
			staticInterceptor.Invoke("init$?#$", "init(int, char**, const KAboutData*, KCmdLineArgs::StdCmdLineArgs)", typeof(void), typeof(string), _argv, typeof(KAboutData), about, typeof(uint), stdargs);
		}
		public static void Init(string _argv, KAboutData about) {
			staticInterceptor.Invoke("init$?#", "init(int, char**, const KAboutData*)", typeof(void), typeof(string), _argv, typeof(KAboutData), about);
		}
		/// <remarks>
		///  Initialize Class
		///  This function should be called as the very first thing in your
		///  application. This method will rarely be used, since it doesn't
		///  provide any argument parsing. It does provide access to the
		///  KAboutData information.
		///  This method is exactly the same as calling
		///  init(0,0, const KAboutData about, CmdLineArgNone).
		/// <param> name="about" the about data.
		/// </param></remarks>		<short>    Initialize Class </short>
		/// 		<see> KAboutData</see>
		public static void Init(KAboutData about) {
			staticInterceptor.Invoke("init#", "init(const KAboutData*)", typeof(void), typeof(KAboutData), about);
		}
		/// <remarks>
		///  add standard Qt/KDE command-line args
		///    </remarks>		<short>    add standard Qt/KDE command-line args    </short>
		public static void AddStdCmdLineOptions(uint stdargs) {
			staticInterceptor.Invoke("addStdCmdLineOptions$", "addStdCmdLineOptions(KCmdLineArgs::StdCmdLineArgs)", typeof(void), typeof(uint), stdargs);
		}
		public static void AddStdCmdLineOptions() {
			staticInterceptor.Invoke("addStdCmdLineOptions", "addStdCmdLineOptions()", typeof(void));
		}
		/// <remarks>
		///  Add options to your application.
		///  You must make sure that all possible options have been added before
		///  any class uses the command line arguments.
		///  The list of options should look like this:
		///  @code
		///  KCmdLineOptions options;
		///  options.add("option1 \<argument>", ki18n("Description 1"), "my_extra_arg");
		///  options.add("o");
		///  options.add("option2", ki18n("Description 2"));
		///  options.add("nooption3", ki18n("Description 3"));
		///  options.add("+file", ki18n("A required argument 'file'"));
		///  @endcode
		/// 
		/// <li>
		/// "option1" is an option that requires an additional argument,
		///      but if one is not provided, it uses "my_extra_arg".
		/// </li>
		/// 
		/// <li>
		/// "option2" is an option that can be turned on. The default is off.
		/// </li>
		/// 
		/// <li>
		/// "option3" is an option that can be turned off. The default is on.
		/// </li>
		/// 
		/// <li>
		/// "o" does not have a description. It is an alias for the option
		///      that follows. In this case "option2".
		/// </li>
		/// 
		/// <li>
		/// "+file" specifies an argument. The '+' is removed. If your program
		///      doesn't specify that it can use arguments your program will abort
		///      when an argument is passed to it. Note that the reverse is not
		///      true. If required, you must check yourself the number of arguments
		///      specified by the user:
		///      @code
		///        KCmdLineArgs args = KCmdLineArgs.ParsedArgs();
		///        if (args.Count() == 0) KCmdLineArgs.Usage(i18n("No file specified"));
		///      @endcode
		/// </li>
		///  In BNF:
		///  @code
		///  cmd = myapp [options] file
		///  options = (option)
		///  option = --option1 \<argument> |
		///           (-o | --option2 | --nooption2) |
		///           ( --option3 | --nooption3 )
		///  @endcode
		///  Instead of "--option3" one may also use "-option3"
		///  Usage examples:
		/// 
		/// <li>
		/// "myapp --option1 test"
		/// </li>
		/// 
		/// <li>
		/// "myapp" (same as "myapp --option1 my_extra_arg")
		/// </li>
		/// 
		/// <li>
		/// "myapp --option2"
		/// </li>
		/// 
		/// <li>
		/// "myapp --nooption2" (same as "myapp", since it is off by default)
		/// </li>
		/// 
		/// <li>
		/// "myapp -o" (same as "myapp --option2")
		/// </li>
		/// 
		/// <li>
		/// "myapp --nooption3"
		/// </li>
		/// 
		/// <li>
		/// "myapp --option3 (same as "myapp", since it is on by default)
		/// </li>
		/// 
		/// <li>
		/// "myapp --option2 --nooption2" (same as "myapp", because it
		///      option2 is off by default, and the last usage applies)
		/// </li>
		/// 
		/// <li>
		/// "myapp /tmp/file"
		/// </li>
		/// <param> name="options" A list of options that your code supplies.
		/// </param><param> name="name" the name of the option list, as displayed by
		///              the help output. Can be empty.
		/// </param><param> name="id" A name with which these options can be identified, can be empty.
		/// </param><param> name="afterId" The options are inserted after this set of options, can be empty.
		///    </param></remarks>		<short>    Add options to your application.</short>
		public static void AddCmdLineOptions(KCmdLineOptions options, KLocalizedString name, QByteArray id, QByteArray afterId) {
			staticInterceptor.Invoke("addCmdLineOptions####", "addCmdLineOptions(const KCmdLineOptions&, const KLocalizedString&, const QByteArray&, const QByteArray&)", typeof(void), typeof(KCmdLineOptions), options, typeof(KLocalizedString), name, typeof(QByteArray), id, typeof(QByteArray), afterId);
		}
		public static void AddCmdLineOptions(KCmdLineOptions options, KLocalizedString name, QByteArray id) {
			staticInterceptor.Invoke("addCmdLineOptions###", "addCmdLineOptions(const KCmdLineOptions&, const KLocalizedString&, const QByteArray&)", typeof(void), typeof(KCmdLineOptions), options, typeof(KLocalizedString), name, typeof(QByteArray), id);
		}
		public static void AddCmdLineOptions(KCmdLineOptions options, KLocalizedString name) {
			staticInterceptor.Invoke("addCmdLineOptions##", "addCmdLineOptions(const KCmdLineOptions&, const KLocalizedString&)", typeof(void), typeof(KCmdLineOptions), options, typeof(KLocalizedString), name);
		}
		public static void AddCmdLineOptions(KCmdLineOptions options) {
			staticInterceptor.Invoke("addCmdLineOptions#", "addCmdLineOptions(const KCmdLineOptions&)", typeof(void), typeof(KCmdLineOptions), options);
		}
		/// <remarks>
		///  Access parsed arguments.
		///  This function returns all command line arguments that your code
		///  handles. If unknown command-line arguments are encountered the program
		///  is aborted and usage information is shown.
		/// <param> name="id" The name of the options you are interested in, can be empty.
		///    </param></remarks>		<short>    Access parsed arguments.</short>
		public static KCmdLineArgs ParsedArgs(QByteArray id) {
			return (KCmdLineArgs) staticInterceptor.Invoke("parsedArgs#", "parsedArgs(const QByteArray&)", typeof(KCmdLineArgs), typeof(QByteArray), id);
		}
		public static KCmdLineArgs ParsedArgs() {
			return (KCmdLineArgs) staticInterceptor.Invoke("parsedArgs", "parsedArgs()", typeof(KCmdLineArgs));
		}
		/// <remarks>
		///  Get the CWD (Current Working Directory) associated with the
		///  current command line arguments.
		///  Typically this is needed in KUniqueApplication.NewInstance()
		///  since the CWD of the process may be different from the CWD
		///  where the user started a second instance.
		/// </remarks>		<return> the current working directory
		/// </return>
		/// 		<short>    Get the CWD (Current Working Directory) associated with the  current command line arguments.</short>
		public static string Cwd() {
			return (string) staticInterceptor.Invoke("cwd", "cwd()", typeof(string));
		}
		/// <remarks>
		///  Get the appname according to argv[0].
		/// </remarks>		<return> the name of the application
		/// </return>
		/// 		<short>    Get the appname according to argv[0].</short>
		public static string AppName() {
			return (string) staticInterceptor.Invoke("appName", "appName()", typeof(string));
		}
		/// <remarks>
		///  Print the usage help to stdout and exit.
		/// <param> name="id" if empty, print all options. If id is set, only print the
		///         option specified by id. The id is the value set by
		///         addCmdLineOptions().
		/// </param></remarks>		<short>    Print the usage help to stdout and exit.</short>
		public static void Usage(QByteArray id) {
			staticInterceptor.Invoke("usage#", "usage(const QByteArray&)", typeof(void), typeof(QByteArray), id);
		}
		public static void Usage() {
			staticInterceptor.Invoke("usage", "usage()", typeof(void));
		}
		/// <remarks>
		///  Print an error to stderr and the usage help to stdout and exit.
		/// <param> name="error" the error to print
		/// </param></remarks>		<short>    Print an error to stderr and the usage help to stdout and exit.</short>
		public static void UsageError(string error) {
			staticInterceptor.Invoke("usageError$", "usageError(const QString&)", typeof(void), typeof(string), error);
		}
		/// <remarks>
		///  Enable i18n to be able to print a translated error message.
		///  N.B.: This function leaks memory, therefore you are expected to exit
		///  afterwards (e.g., by calling usage()).
		/// </remarks>		<short>    Enable i18n to be able to print a translated error message.</short>
		public static void Enable_i18n() {
			staticInterceptor.Invoke("enable_i18n", "enable_i18n()", typeof(void));
		}
		/// <remarks>
		///  Used by url().
		///  Made public for apps that don't use KCmdLineArgs
		/// <param> name="urlArg" the argument
		/// </param></remarks>		<return> the url.
		///    </return>
		/// 		<short>    Used by url().</short>
		public static KUrl MakeURL(QByteArray urlArg) {
			return (KUrl) staticInterceptor.Invoke("makeURL#", "makeURL(const QByteArray&)", typeof(KUrl), typeof(QByteArray), urlArg);
		}
		/// <remarks>
		///  Made public for apps that don't use KCmdLineArgs
		///  To be done before makeURL, to set the current working
		///  directory in case makeURL needs it.
		/// <param> name="cwd" the new working directory
		///    </param></remarks>		<short>    Made public for apps that don't use KCmdLineArgs  To be done before makeURL, to set the current working  directory in case makeURL needs it.</short>
		public static void SetCwd(QByteArray cwd) {
			staticInterceptor.Invoke("setCwd#", "setCwd(const QByteArray&)", typeof(void), typeof(QByteArray), cwd);
		}
		/// <remarks>
		///   Reset all option definitions, i.e. cancel all addCmdLineOptions calls.
		///   Note that KApplication's options are removed too, you might want to
		///   call KApplication.AddCmdLineOptions if you want them back.
		///   You usually don't want to call this method.
		///    </remarks>		<short>     Reset all option definitions, i.</short>
		public static void Reset() {
			staticInterceptor.Invoke("reset", "reset()", typeof(void));
		}
		/// <remarks>
		///  Load arguments from a stream.
		///    </remarks>		<short>    Load arguments from a stream.</short>
		public static void LoadAppArgs(QDataStream arg1) {
			staticInterceptor.Invoke("loadAppArgs#", "loadAppArgs(QDataStream&)", typeof(void), typeof(QDataStream), arg1);
		}
		/// <remarks>
		///  Save all but the Qt and KDE arguments to a stream.
		///    </remarks>		<short>   </short>
		public static void SaveAppArgs(QDataStream arg1) {
			staticInterceptor.Invoke("saveAppArgs#", "saveAppArgs(QDataStream&)", typeof(void), typeof(QDataStream), arg1);
		}
		/// <remarks>
		///  Add standard option --tempfile
		///    </remarks>		<short>    Add standard option --tempfile    </short>
		public static void AddTempFileOption() {
			staticInterceptor.Invoke("addTempFileOption", "addTempFileOption()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> true if --tempfile was set
		///    </return>
		/// 		<short>   </short>
		public static bool IsTempFileSet() {
			return (bool) staticInterceptor.Invoke("isTempFileSet", "isTempFileSet()", typeof(bool));
		}
		/// <remarks>
		///  Returns the number of arguments returned by qtArgv()
		/// </remarks>		<short>    Returns the number of arguments returned by qtArgv() </short>
		/// 		<see> qtArgv</see>
		public static int QtArgc() {
			return (int) staticInterceptor.Invoke("qtArgc", "qtArgc()", typeof(int));
		}
		/// <remarks>
		///  Returns command line options for consumption by Qt after parsing them in a way that
		///  is consistent with KDE's general command line handling. In particular this ensures
		///  that Qt command line options can be specified as either -option or --option and that
		///  any options specified after '--' will be ignored.
		/// </remarks>		<short>    Returns command line options for consumption by Qt after parsing them in a way that  is consistent with KDE's general command line handling.</short>
		/// 		<see> qt_argc</see>
		public static string QtArgv() {
			return (string) staticInterceptor.Invoke("qtArgv", "qtArgv()", typeof(string));
		}
		/// <remarks>
		///  Returns the KAboutData for consumption by KComponentData
		///    </remarks>		<short>    Returns the KAboutData for consumption by KComponentData    </short>
		public static KAboutData AboutData() {
			return (KAboutData) staticInterceptor.Invoke("aboutData", "aboutData()", typeof(KAboutData));
		}
	}
}
