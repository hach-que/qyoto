//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  This is just a small class to facilitate accessing e-mail settings in 
	///  a sane way, and allowing any program to manage multiple e-mail 
	///  profiles effortlessly
	/// </remarks>		<author> Alex Zepeda zipzippy@sonic.net
	/// </author>
	/// 		<short>    This is just a small class to facilitate accessing e-mail settings in   a sane way, and allowing any program to manage multiple e-mail   profiles effortlessly </short>

	[SmokeClass("KEMailSettings")]
	public class KEMailSettings : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KEMailSettings(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KEMailSettings), this);
		}
		/// <remarks>
		///  The list of settings that I thought of when I wrote this 
		///  class.  Any extra settings thought of later can be accessed 
		///  easily with getExtendedSetting and setExtendedSetting.
		/// </remarks>		<short>    The list of settings that I thought of when I wrote this   class.</short>
		/// 		<see> getSetting</see>
		/// 		<see> setSetting</see>
		/// 		<see> getExtendedSetting</see>
		/// 		<see> setExtendedSetting</see>
		public enum Setting {
			ClientProgram = 0,
			ClientTerminal = 1,
			RealName = 2,
			EmailAddress = 3,
			ReplyToAddress = 4,
			Organization = 5,
			OutServer = 6,
			OutServerLogin = 7,
			OutServerPass = 8,
			OutServerType = 9,
			OutServerCommand = 10,
			OutServerTLS = 11,
			InServer = 12,
			InServerLogin = 13,
			InServerPass = 14,
			InServerType = 15,
			InServerMBXType = 16,
			InServerTLS = 17,
		}
		/// <remarks>
		///  The various extensions allowed.
		/// </remarks>		<short>    The various extensions allowed.</short>
		public enum Extension {
			POP3 = 0,
			SMTP = 1,
			OTHER = 2,
		}
		/// <remarks>
		///  Default constructor, just sets things up.
		/// </remarks>		<short>    Default constructor, just sets things up.</short>
		public KEMailSettings() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEMailSettings", "KEMailSettings()", typeof(void));
		}
		/// <remarks>
		///  List of profiles available.
		/// </remarks>		<return> the list of profiles
		/// </return>
		/// 		<short>    List of profiles available.</short>
		public List<string> Profiles() {
			return (List<string>) interceptor.Invoke("profiles", "profiles() const", typeof(List<string>));
		}
		/// <remarks>
		///  Returns the name of the current profile.
		/// </remarks>		<return> what profile we're currently using
		/// </return>
		/// 		<short>    Returns the name of the current profile.</short>
		public string CurrentProfileName() {
			return (string) interceptor.Invoke("currentProfileName", "currentProfileName() const", typeof(string));
		}
		/// <remarks>
		///  Change the current profile.
		/// <param> name="s" the name of the new profile
		/// </param></remarks>		<short>    Change the current profile.</short>
		public void SetProfile(string s) {
			interceptor.Invoke("setProfile$", "setProfile(const QString&)", typeof(void), typeof(string), s);
		}
		/// <remarks>
		///  Returns the name of the default profile.
		/// </remarks>		<return> the name of the one that's currently default string() if none
		/// </return>
		/// 		<short>    Returns the name of the default profile.</short>
		public string DefaultProfileName() {
			return (string) interceptor.Invoke("defaultProfileName", "defaultProfileName() const", typeof(string));
		}
		/// <remarks>
		///  Sets a new default.
		/// <param> name="def" the new default
		/// </param></remarks>		<short>    Sets a new default.</short>
		public void SetDefault(string def) {
			interceptor.Invoke("setDefault$", "setDefault(const QString&)", typeof(void), typeof(string), def);
		}
		/// <remarks>
		///  Get one of the predefined "basic" settings.
		/// <param> name="s" the setting to get
		/// </param></remarks>		<return> the value of the setting, or string() if not 
		///          set
		/// </return>
		/// 		<short>    Get one of the predefined "basic" settings.</short>
		public string GetSetting(KEMailSettings.Setting s) {
			return (string) interceptor.Invoke("getSetting$", "getSetting(KEMailSettings::Setting) const", typeof(string), typeof(KEMailSettings.Setting), s);
		}
		/// <remarks>
		///  Set one of the predefined "basic" settings.
		/// <param> name="s" the setting to set
		/// </param><param> name="v" the new value of the setting, or string() to 
		///          unset
		/// </param></remarks>		<short>    Set one of the predefined "basic" settings.</short>
		public void SetSetting(KEMailSettings.Setting s, string v) {
			interceptor.Invoke("setSetting$$", "setSetting(KEMailSettings::Setting, const QString&)", typeof(void), typeof(KEMailSettings.Setting), s, typeof(string), v);
		}
		~KEMailSettings() {
			interceptor.Invoke("~KEMailSettings", "~KEMailSettings()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KEMailSettings", "~KEMailSettings()", typeof(void));
		}
	}
}
