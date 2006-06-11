//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QLibraryInfo")]
	public class QLibraryInfo : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QLibraryInfo(Type dummy) {}
		interface IQLibraryInfoProxy {
			string Licensee();
			string LicensedProducts();
			string BuildKey();
			string Location(QLibraryInfo.LibraryLocation arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLibraryInfo), this);
			_interceptor = (QLibraryInfo) realProxy.GetTransparentProxy();
		}
		private QLibraryInfo ProxyQLibraryInfo() {
			return (QLibraryInfo) _interceptor;
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
		[SmokeMethod("licensee()")]
		public static string Licensee() {
			return StaticQLibraryInfo().Licensee();
		}
		[SmokeMethod("licensedProducts()")]
		public static string LicensedProducts() {
			return StaticQLibraryInfo().LicensedProducts();
		}
		[SmokeMethod("buildKey()")]
		public static string BuildKey() {
			return StaticQLibraryInfo().BuildKey();
		}
		[SmokeMethod("location(QLibraryInfo::LibraryLocation)")]
		public static string Location(QLibraryInfo.LibraryLocation arg1) {
			return StaticQLibraryInfo().Location(arg1);
		}
		~QLibraryInfo() {
			DisposeQLibraryInfo();
		}
		public void Dispose() {
			DisposeQLibraryInfo();
		}
		[SmokeMethod("~QLibraryInfo()")]
		private void DisposeQLibraryInfo() {
			ProxyQLibraryInfo().DisposeQLibraryInfo();
		}
	}
}
