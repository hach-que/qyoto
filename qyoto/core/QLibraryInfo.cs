//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QLibraryInfo")]
	public class QLibraryInfo : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QLibraryInfo(Type dummy) {}
		[SmokeClass("QLibraryInfo")]
		interface IQLibraryInfoProxy {
			[SmokeMethod("licensee", "()", "")]
			string Licensee();
			[SmokeMethod("licensedProducts", "()", "")]
			string LicensedProducts();
			[SmokeMethod("buildKey", "()", "")]
			string BuildKey();
			[SmokeMethod("location", "(QLibraryInfo::LibraryLocation)", "$")]
			string Location(QLibraryInfo.LibraryLocation arg1);
		}
		private static Object _staticInterceptor = null;
		static QLibraryInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLibraryInfoProxy), null);
			_staticInterceptor = (IQLibraryInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQLibraryInfoProxy StaticQLibraryInfo() {
			return (IQLibraryInfoProxy) _staticInterceptor;
		}
		public enum LibraryLocation {
			PrefixPath = 0,
			DocumentationPath = 1,
			HeadersPath = 2,
			LibrariesPath = 3,
			BinariesPath = 4,
			PluginsPath = 5,
			DataPath = 6,
			TranslationsPath = 7,
			SettingsPath = 8,
			DemosPath = 9,
			ExamplesPath = 10,
		}
		public static string Licensee() {
			return StaticQLibraryInfo().Licensee();
		}
		public static string LicensedProducts() {
			return StaticQLibraryInfo().LicensedProducts();
		}
		public static string BuildKey() {
			return StaticQLibraryInfo().BuildKey();
		}
		public static string Location(QLibraryInfo.LibraryLocation arg1) {
			return StaticQLibraryInfo().Location(arg1);
		}
	}
}
