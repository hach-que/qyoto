//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QColorDialog")]
	public class QColorDialog : QDialog {
 		protected QColorDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QColorDialog")]
		interface IQColorDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("getColor", "(const QColor&, QWidget*)", "##")]
			QColor GetColor(QColor init, QWidget parent);
			[SmokeMethod("getColor", "(const QColor&)", "#")]
			QColor GetColor(QColor init);
			[SmokeMethod("getColor", "()", "")]
			QColor GetColor();
			[SmokeMethod("getRgba", "(QRgb, bool*, QWidget*)", "$$#")]
			uint GetRgba(uint arg1, out bool ok, QWidget parent);
			[SmokeMethod("getRgba", "(QRgb, bool*)", "$$")]
			uint GetRgba(uint arg1, out bool ok);
			[SmokeMethod("getRgba", "(QRgb)", "$")]
			uint GetRgba(uint arg1);
			[SmokeMethod("customCount", "()", "")]
			int CustomCount();
			[SmokeMethod("customColor", "(int)", "$")]
			uint CustomColor(int arg1);
			[SmokeMethod("setCustomColor", "(int, QRgb)", "$$")]
			void SetCustomColor(int arg1, uint arg2);
			[SmokeMethod("setStandardColor", "(int, QRgb)", "$$")]
			void SetStandardColor(int arg1, uint arg2);
		}
		private static Object _staticInterceptor = null;
		static QColorDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQColorDialogProxy), null);
			_staticInterceptor = (IQColorDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQColorDialogProxy StaticQColorDialog() {
			return (IQColorDialogProxy) _staticInterceptor;
		}
		public static string Tr(string s, string c) {
			return StaticQColorDialog().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQColorDialog().Tr(s);
		}
		public static QColor GetColor(QColor init, QWidget parent) {
			return StaticQColorDialog().GetColor(init,parent);
		}
		public static QColor GetColor(QColor init) {
			return StaticQColorDialog().GetColor(init);
		}
		public static QColor GetColor() {
			return StaticQColorDialog().GetColor();
		}
		public static uint GetRgba(uint arg1, out bool ok, QWidget parent) {
			return StaticQColorDialog().GetRgba(arg1,out ok,parent);
		}
		public static uint GetRgba(uint arg1, out bool ok) {
			return StaticQColorDialog().GetRgba(arg1,out ok);
		}
		public static uint GetRgba(uint arg1) {
			return StaticQColorDialog().GetRgba(arg1);
		}
		public static int CustomCount() {
			return StaticQColorDialog().CustomCount();
		}
		public static uint CustomColor(int arg1) {
			return StaticQColorDialog().CustomColor(arg1);
		}
		public static void SetCustomColor(int arg1, uint arg2) {
			StaticQColorDialog().SetCustomColor(arg1,arg2);
		}
		public static void SetStandardColor(int arg1, uint arg2) {
			StaticQColorDialog().SetStandardColor(arg1,arg2);
		}
		protected new IQColorDialogSignals Emit {
			get { return (IQColorDialogSignals) Q_EMIT; }
		}
	}

	public interface IQColorDialogSignals : IQDialogSignals {
	}
}
