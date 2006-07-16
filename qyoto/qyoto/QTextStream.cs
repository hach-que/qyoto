//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QTextStream")]
	public class QTextStream : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QTextStream(Type dummy) {}
		interface IQTextStreamProxy {
			QTextStream op_read(QTextStream lhs, char ch);
			QTextStream op_read(QTextStream lhs, ushort i);
			QTextStream op_read(QTextStream lhs, uint i);
			QTextStream op_read(QTextStream lhs, ulong i);
			QTextStream op_read(QTextStream lhs, float f);
			QTextStream op_read(QTextStream lhs, double f);
			QTextStream op_read(QTextStream lhs, StringBuilder s);
			QTextStream op_read(QTextStream lhs, QByteArray array);
			QTextStream op_read(QTextStream lhs, string c);
			QTextStream op_write(QTextStream lhs, QBool b);
			QTextStream op_write(QTextStream lhs, char ch);
			QTextStream op_write(QTextStream lhs, ushort i);
			QTextStream op_write(QTextStream lhs, uint i);
			QTextStream op_write(QTextStream lhs, ulong i);
			QTextStream op_write(QTextStream lhs, float f);
			QTextStream op_write(QTextStream lhs, double f);
			QTextStream op_write(QTextStream lhs, string s);
			QTextStream op_write(QTextStream lhs, QByteArray array);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextStream), this);
			_interceptor = (QTextStream) realProxy.GetTransparentProxy();
		}
		private QTextStream ProxyQTextStream() {
			return (QTextStream) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextStream() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextStreamProxy), null);
			_staticInterceptor = (IQTextStreamProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextStreamProxy StaticQTextStream() {
			return (IQTextStreamProxy) _staticInterceptor;
		}

		public enum RealNumberNotation {
			SmartNotation = 0,
			FixedNotation = 1,
			ScientificNotation = 2,
		}
		public enum FieldAlignment {
			AlignLeft = 0,
			AlignRight = 1,
			AlignCenter = 2,
			AlignAccountingStyle = 3,
		}
		public enum Status {
			Ok = 0,
			ReadPastEnd = 1,
			ReadCorruptData = 2,
		}
		public enum NumberFlag {
			ShowBase = 0x1,
			ForcePoint = 0x2,
			ForceSign = 0x4,
			UppercaseBase = 0x8,
			UppercaseDigits = 0x10,
		}
		public QTextStream() : this((Type) null) {
			CreateProxy();
			NewQTextStream();
		}
		[SmokeMethod("QTextStream()")]
		private void NewQTextStream() {
			ProxyQTextStream().NewQTextStream();
		}
		public QTextStream(IQIODevice device) : this((Type) null) {
			CreateProxy();
			NewQTextStream(device);
		}
		[SmokeMethod("QTextStream(QIODevice*)")]
		private void NewQTextStream(IQIODevice device) {
			ProxyQTextStream().NewQTextStream(device);
		}
		public QTextStream(StringBuilder arg1, int openMode) : this((Type) null) {
			CreateProxy();
			NewQTextStream(arg1,openMode);
		}
		[SmokeMethod("QTextStream(QString*, QIODevice::OpenMode)")]
		private void NewQTextStream(StringBuilder arg1, int openMode) {
			ProxyQTextStream().NewQTextStream(arg1,openMode);
		}
		public QTextStream(StringBuilder arg1) : this((Type) null) {
			CreateProxy();
			NewQTextStream(arg1);
		}
		[SmokeMethod("QTextStream(QString*)")]
		private void NewQTextStream(StringBuilder arg1) {
			ProxyQTextStream().NewQTextStream(arg1);
		}
		public QTextStream(QByteArray array, int openMode) : this((Type) null) {
			CreateProxy();
			NewQTextStream(array,openMode);
		}
		[SmokeMethod("QTextStream(QByteArray*, QIODevice::OpenMode)")]
		private void NewQTextStream(QByteArray array, int openMode) {
			ProxyQTextStream().NewQTextStream(array,openMode);
		}
		public QTextStream(QByteArray array) : this((Type) null) {
			CreateProxy();
			NewQTextStream(array);
		}
		[SmokeMethod("QTextStream(QByteArray*)")]
		private void NewQTextStream(QByteArray array) {
			ProxyQTextStream().NewQTextStream(array);
		}
		[SmokeMethod("setCodec(QTextCodec*)")]
		public void SetCodec(QTextCodec codec) {
			ProxyQTextStream().SetCodec(codec);
		}
		[SmokeMethod("setCodec(const char*)")]
		public void SetCodec(string codecName) {
			ProxyQTextStream().SetCodec(codecName);
		}
		[SmokeMethod("codec() const")]
		public QTextCodec Codec() {
			return ProxyQTextStream().Codec();
		}
		[SmokeMethod("setAutoDetectUnicode(bool)")]
		public void SetAutoDetectUnicode(bool enabled) {
			ProxyQTextStream().SetAutoDetectUnicode(enabled);
		}
		[SmokeMethod("autoDetectUnicode() const")]
		public bool AutoDetectUnicode() {
			return ProxyQTextStream().AutoDetectUnicode();
		}
		[SmokeMethod("setGenerateByteOrderMark(bool)")]
		public void SetGenerateByteOrderMark(bool generate) {
			ProxyQTextStream().SetGenerateByteOrderMark(generate);
		}
		[SmokeMethod("generateByteOrderMark() const")]
		public bool GenerateByteOrderMark() {
			return ProxyQTextStream().GenerateByteOrderMark();
		}
		[SmokeMethod("setDevice(QIODevice*)")]
		public void SetDevice(IQIODevice device) {
			ProxyQTextStream().SetDevice(device);
		}
		[SmokeMethod("device() const")]
		public IQIODevice Device() {
			return ProxyQTextStream().Device();
		}
		[SmokeMethod("setString(QString*, QIODevice::OpenMode)")]
		public void SetString(StringBuilder arg1, int openMode) {
			ProxyQTextStream().SetString(arg1,openMode);
		}
		[SmokeMethod("setString(QString*)")]
		public void SetString(StringBuilder arg1) {
			ProxyQTextStream().SetString(arg1);
		}
		[SmokeMethod("string() const")]
		public string String() {
			return ProxyQTextStream().String();
		}
		[SmokeMethod("status() const")]
		public QTextStream.Status status() {
			return ProxyQTextStream().status();
		}
		[SmokeMethod("setStatus(QTextStream::Status)")]
		public void SetStatus(QTextStream.Status status) {
			ProxyQTextStream().SetStatus(status);
		}
		[SmokeMethod("resetStatus()")]
		public void ResetStatus() {
			ProxyQTextStream().ResetStatus();
		}
		[SmokeMethod("atEnd() const")]
		public bool AtEnd() {
			return ProxyQTextStream().AtEnd();
		}
		[SmokeMethod("reset()")]
		public void Reset() {
			ProxyQTextStream().Reset();
		}
		[SmokeMethod("flush()")]
		public void Flush() {
			ProxyQTextStream().Flush();
		}
		// bool seek(qint64 arg1); >>>> NOT CONVERTED
		// qint64 pos(); >>>> NOT CONVERTED
		[SmokeMethod("skipWhiteSpace()")]
		public void SkipWhiteSpace() {
			ProxyQTextStream().SkipWhiteSpace();
		}
		// QString readLine(qint64 arg1); >>>> NOT CONVERTED
		[SmokeMethod("readLine()")]
		public string ReadLine() {
			return ProxyQTextStream().ReadLine();
		}
		[SmokeMethod("readAll()")]
		public string ReadAll() {
			return ProxyQTextStream().ReadAll();
		}
		// QString read(qint64 arg1); >>>> NOT CONVERTED
		[SmokeMethod("setFieldAlignment(QTextStream::FieldAlignment)")]
		public void SetFieldAlignment(QTextStream.FieldAlignment alignment) {
			ProxyQTextStream().SetFieldAlignment(alignment);
		}
		[SmokeMethod("fieldAlignment() const")]
		public QTextStream.FieldAlignment fieldAlignment() {
			return ProxyQTextStream().fieldAlignment();
		}
		[SmokeMethod("setPadChar(QChar)")]
		public void SetPadChar(char ch) {
			ProxyQTextStream().SetPadChar(ch);
		}
		[SmokeMethod("padChar() const")]
		public char PadChar() {
			return ProxyQTextStream().PadChar();
		}
		[SmokeMethod("setFieldWidth(int)")]
		public void SetFieldWidth(int width) {
			ProxyQTextStream().SetFieldWidth(width);
		}
		[SmokeMethod("fieldWidth() const")]
		public int FieldWidth() {
			return ProxyQTextStream().FieldWidth();
		}
		[SmokeMethod("setNumberFlags(NumberFlags)")]
		public void SetNumberFlags(int flags) {
			ProxyQTextStream().SetNumberFlags(flags);
		}
		[SmokeMethod("numberFlags() const")]
		public int NumberFlags() {
			return ProxyQTextStream().NumberFlags();
		}
		[SmokeMethod("setIntegerBase(int)")]
		public void SetIntegerBase(int arg1) {
			ProxyQTextStream().SetIntegerBase(arg1);
		}
		[SmokeMethod("integerBase() const")]
		public int IntegerBase() {
			return ProxyQTextStream().IntegerBase();
		}
		[SmokeMethod("setRealNumberNotation(QTextStream::RealNumberNotation)")]
		public void SetRealNumberNotation(QTextStream.RealNumberNotation notation) {
			ProxyQTextStream().SetRealNumberNotation(notation);
		}
		[SmokeMethod("realNumberNotation() const")]
		public QTextStream.RealNumberNotation realNumberNotation() {
			return ProxyQTextStream().realNumberNotation();
		}
		[SmokeMethod("setRealNumberPrecision(int)")]
		public void SetRealNumberPrecision(int precision) {
			ProxyQTextStream().SetRealNumberPrecision(precision);
		}
		[SmokeMethod("realNumberPrecision() const")]
		public int RealNumberPrecision() {
			return ProxyQTextStream().RealNumberPrecision();
		}
		[SmokeMethod("operator>>(QChar&)")]
		public static QTextStream op_read(QTextStream lhs, char ch) {
			return StaticQTextStream().op_read(lhs,ch);
		}
		// QTextStream& operator>>(signed short& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(unsigned short&)")]
		public static QTextStream op_read(QTextStream lhs, ushort i) {
			return StaticQTextStream().op_read(lhs,i);
		}
		// QTextStream& operator>>(signed int& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(unsigned int&)")]
		public static QTextStream op_read(QTextStream lhs, uint i) {
			return StaticQTextStream().op_read(lhs,i);
		}
		// QTextStream& operator>>(signed long& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(unsigned long&)")]
		public static QTextStream op_read(QTextStream lhs, ulong i) {
			return StaticQTextStream().op_read(lhs,i);
		}
		// QTextStream& operator>>(qlonglong& arg1); >>>> NOT CONVERTED
		// QTextStream& operator>>(qulonglong& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(float&)")]
		public static QTextStream op_read(QTextStream lhs, float f) {
			return StaticQTextStream().op_read(lhs,f);
		}
		[SmokeMethod("operator>>(double&)")]
		public static QTextStream op_read(QTextStream lhs, double f) {
			return StaticQTextStream().op_read(lhs,f);
		}
		[SmokeMethod("operator>>(QString&)")]
		public static QTextStream op_read(QTextStream lhs, StringBuilder s) {
			return StaticQTextStream().op_read(lhs,s);
		}
		[SmokeMethod("operator>>(QByteArray&)")]
		public static QTextStream op_read(QTextStream lhs, QByteArray array) {
			return StaticQTextStream().op_read(lhs,array);
		}
		[SmokeMethod("operator>>(char*)")]
		public static QTextStream op_read(QTextStream lhs, string c) {
			return StaticQTextStream().op_read(lhs,c);
		}
		[SmokeMethod("operator<<(QBool)")]
		public static QTextStream op_write(QTextStream lhs, QBool b) {
			return StaticQTextStream().op_write(lhs,b);
		}
		[SmokeMethod("operator<<(QChar)")]
		public static QTextStream op_write(QTextStream lhs, char ch) {
			return StaticQTextStream().op_write(lhs,ch);
		}
		// QTextStream& operator<<(signed short arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator<<(unsigned short)")]
		public static QTextStream op_write(QTextStream lhs, ushort i) {
			return StaticQTextStream().op_write(lhs,i);
		}
		// QTextStream& operator<<(signed int arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator<<(unsigned int)")]
		public static QTextStream op_write(QTextStream lhs, uint i) {
			return StaticQTextStream().op_write(lhs,i);
		}
		// QTextStream& operator<<(signed long arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator<<(unsigned long)")]
		public static QTextStream op_write(QTextStream lhs, ulong i) {
			return StaticQTextStream().op_write(lhs,i);
		}
		// QTextStream& operator<<(qlonglong arg1); >>>> NOT CONVERTED
		// QTextStream& operator<<(qulonglong arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator<<(float)")]
		public static QTextStream op_write(QTextStream lhs, float f) {
			return StaticQTextStream().op_write(lhs,f);
		}
		[SmokeMethod("operator<<(double)")]
		public static QTextStream op_write(QTextStream lhs, double f) {
			return StaticQTextStream().op_write(lhs,f);
		}
		[SmokeMethod("operator<<(const QString&)")]
		public static QTextStream op_write(QTextStream lhs, string s) {
			return StaticQTextStream().op_write(lhs,s);
		}
		[SmokeMethod("operator<<(const QByteArray&)")]
		public static QTextStream op_write(QTextStream lhs, QByteArray array) {
			return StaticQTextStream().op_write(lhs,array);
		}
		// QTextStream& operator<<(const void* arg1); >>>> NOT CONVERTED
		~QTextStream() {
			DisposeQTextStream();
		}
		public void Dispose() {
			DisposeQTextStream();
		}
		[SmokeMethod("~QTextStream()")]
		private void DisposeQTextStream() {
			ProxyQTextStream().DisposeQTextStream();
		}
	}
}
