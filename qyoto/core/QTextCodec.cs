//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTextCodec")]
	public abstract class QTextCodec : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTextCodec(Type dummy) {}
		[SmokeClass("QTextCodec")]
		interface IQTextCodecProxy {
			[SmokeMethod("codecForName", "(const QByteArray&)", "#")]
			QTextCodec CodecForName(QByteArray name);
			[SmokeMethod("codecForName", "(const char*)", "$")]
			QTextCodec CodecForName(string name);
			[SmokeMethod("codecForMib", "(int)", "$")]
			QTextCodec CodecForMib(int mib);
			[SmokeMethod("availableCodecs", "()", "")]
			List<QByteArray> AvailableCodecs();
			[SmokeMethod("availableMibs", "()", "")]
			List<int> AvailableMibs();
			[SmokeMethod("codecForLocale", "()", "")]
			QTextCodec CodecForLocale();
			[SmokeMethod("setCodecForLocale", "(QTextCodec*)", "#")]
			void SetCodecForLocale(QTextCodec c);
			[SmokeMethod("codecForTr", "()", "")]
			QTextCodec CodecForTr();
			[SmokeMethod("setCodecForTr", "(QTextCodec*)", "#")]
			void SetCodecForTr(QTextCodec c);
			[SmokeMethod("codecForCStrings", "()", "")]
			QTextCodec CodecForCStrings();
			[SmokeMethod("setCodecForCStrings", "(QTextCodec*)", "#")]
			void SetCodecForCStrings(QTextCodec c);
			[SmokeMethod("codecForHtml", "(const QByteArray&)", "#")]
			QTextCodec CodecForHtml(QByteArray ba);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextCodec), this);
			_interceptor = (QTextCodec) realProxy.GetTransparentProxy();
		}
		private QTextCodec ProxyQTextCodec() {
			return (QTextCodec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextCodec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextCodecProxy), null);
			_staticInterceptor = (IQTextCodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextCodecProxy StaticQTextCodec() {
			return (IQTextCodecProxy) _staticInterceptor;
		}
		public enum ConversionFlag : long {
			DefaultConversion = 0,
			ConvertInvalidToNull = 0x80000000,
			IgnoreHeader = 0x1,
		}
		// QString toUnicode(const char* arg1,int arg2,QTextCodec::ConverterState* arg3); >>>> NOT CONVERTED
		// QByteArray fromUnicode(const QChar* arg1,int arg2,QTextCodec::ConverterState* arg3); >>>> NOT CONVERTED
		// QString convertToUnicode(const char* arg1,int arg2,QTextCodec::ConverterState* arg3); >>>> NOT CONVERTED
		// QByteArray convertFromUnicode(const QChar* arg1,int arg2,QTextCodec::ConverterState* arg3); >>>> NOT CONVERTED
		[SmokeMethod("makeDecoder", "() const", "")]
		public QTextDecoder MakeDecoder() {
			return ProxyQTextCodec().MakeDecoder();
		}
		[SmokeMethod("makeEncoder", "() const", "")]
		public QTextEncoder MakeEncoder() {
			return ProxyQTextCodec().MakeEncoder();
		}
		[SmokeMethod("canEncode", "(QChar) const", "#")]
		public bool CanEncode(char arg1) {
			return ProxyQTextCodec().CanEncode(arg1);
		}
		[SmokeMethod("canEncode", "(const QString&) const", "$")]
		public bool CanEncode(string arg1) {
			return ProxyQTextCodec().CanEncode(arg1);
		}
		[SmokeMethod("toUnicode", "(const QByteArray&) const", "#")]
		public string ToUnicode(QByteArray arg1) {
			return ProxyQTextCodec().ToUnicode(arg1);
		}
		[SmokeMethod("toUnicode", "(const char*) const", "$")]
		public string ToUnicode(string chars) {
			return ProxyQTextCodec().ToUnicode(chars);
		}
		[SmokeMethod("fromUnicode", "(const QString&) const", "$")]
		public QByteArray FromUnicode(string uc) {
			return ProxyQTextCodec().FromUnicode(uc);
		}
		[SmokeMethod("toUnicode", "(const char*, int) const", "$$")]
		public string ToUnicode(string arg1, int length) {
			return ProxyQTextCodec().ToUnicode(arg1,length);
		}
		[SmokeMethod("fromUnicode", "(const QChar*, int) const", "#$")]
		public QByteArray FromUnicode(char arg1, int length) {
			return ProxyQTextCodec().FromUnicode(arg1,length);
		}
		public abstract QByteArray Name();
		[SmokeMethod("aliases", "() const", "")]
		public virtual List<QByteArray> Aliases() {
			return ProxyQTextCodec().Aliases();
		}
		public abstract int MibEnum();
		public QTextCodec() : this((Type) null) {
			CreateProxy();
			NewQTextCodec();
		}
		[SmokeMethod("QTextCodec", "()", "")]
		private void NewQTextCodec() {
			ProxyQTextCodec().NewQTextCodec();
		}
		public static QTextCodec CodecForName(QByteArray name) {
			return StaticQTextCodec().CodecForName(name);
		}
		public static QTextCodec CodecForName(string name) {
			return StaticQTextCodec().CodecForName(name);
		}
		public static QTextCodec CodecForMib(int mib) {
			return StaticQTextCodec().CodecForMib(mib);
		}
		public static List<QByteArray> AvailableCodecs() {
			return StaticQTextCodec().AvailableCodecs();
		}
		public static List<int> AvailableMibs() {
			return StaticQTextCodec().AvailableMibs();
		}
		public static QTextCodec CodecForLocale() {
			return StaticQTextCodec().CodecForLocale();
		}
		public static void SetCodecForLocale(QTextCodec c) {
			StaticQTextCodec().SetCodecForLocale(c);
		}
		public static QTextCodec CodecForTr() {
			return StaticQTextCodec().CodecForTr();
		}
		public static void SetCodecForTr(QTextCodec c) {
			StaticQTextCodec().SetCodecForTr(c);
		}
		public static QTextCodec CodecForCStrings() {
			return StaticQTextCodec().CodecForCStrings();
		}
		public static void SetCodecForCStrings(QTextCodec c) {
			StaticQTextCodec().SetCodecForCStrings(c);
		}
		public static QTextCodec CodecForHtml(QByteArray ba) {
			return StaticQTextCodec().CodecForHtml(ba);
		}
	}
}
