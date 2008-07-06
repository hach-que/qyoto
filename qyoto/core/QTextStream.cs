//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Text;
    [SmokeClass("QTextStream")]
    public class QTextStream : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTextStream(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTextStream), this);
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
        // QTextStream& operator>>(signed short& arg1); >>>> NOT CONVERTED
        // QTextStream& operator>>(signed int& arg1); >>>> NOT CONVERTED
        // QTextStream& operator>>(signed long& arg1); >>>> NOT CONVERTED
        // QTextStream& operator>>(qlonglong& arg1); >>>> NOT CONVERTED
        // QTextStream& operator>>(qulonglong& arg1); >>>> NOT CONVERTED
        // QTextStream& operator<<(signed short arg1); >>>> NOT CONVERTED
        // QTextStream& operator<<(signed int arg1); >>>> NOT CONVERTED
        // QTextStream& operator<<(signed long arg1); >>>> NOT CONVERTED
        // QTextStream& operator<<(const void* arg1); >>>> NOT CONVERTED
        public QTextStream() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextStream", "QTextStream()", typeof(void));
        }
        public QTextStream(QIODevice device) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextStream#", "QTextStream(QIODevice*)", typeof(void), typeof(QIODevice), device);
        }
        public QTextStream(StringBuilder arg1, uint openMode) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextStream$$", "QTextStream(QString*, QIODevice::OpenMode)", typeof(void), typeof(StringBuilder), arg1, typeof(uint), openMode);
        }
        public QTextStream(StringBuilder arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextStream$", "QTextStream(QString*)", typeof(void), typeof(StringBuilder), arg1);
        }
        public QTextStream(QByteArray array, uint openMode) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextStream#$", "QTextStream(QByteArray*, QIODevice::OpenMode)", typeof(void), typeof(QByteArray), array, typeof(uint), openMode);
        }
        public QTextStream(QByteArray array) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextStream#", "QTextStream(QByteArray*)", typeof(void), typeof(QByteArray), array);
        }
        public void SetCodec(QTextCodec codec) {
            interceptor.Invoke("setCodec#", "setCodec(QTextCodec*)", typeof(void), typeof(QTextCodec), codec);
        }
        public void SetCodec(string codecName) {
            interceptor.Invoke("setCodec$", "setCodec(const char*)", typeof(void), typeof(string), codecName);
        }
        public QTextCodec Codec() {
            return (QTextCodec) interceptor.Invoke("codec", "codec() const", typeof(QTextCodec));
        }
        public void SetAutoDetectUnicode(bool enabled) {
            interceptor.Invoke("setAutoDetectUnicode$", "setAutoDetectUnicode(bool)", typeof(void), typeof(bool), enabled);
        }
        public bool AutoDetectUnicode() {
            return (bool) interceptor.Invoke("autoDetectUnicode", "autoDetectUnicode() const", typeof(bool));
        }
        public void SetGenerateByteOrderMark(bool generate) {
            interceptor.Invoke("setGenerateByteOrderMark$", "setGenerateByteOrderMark(bool)", typeof(void), typeof(bool), generate);
        }
        public bool GenerateByteOrderMark() {
            return (bool) interceptor.Invoke("generateByteOrderMark", "generateByteOrderMark() const", typeof(bool));
        }
        public void SetDevice(QIODevice device) {
            interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), device);
        }
        public QIODevice Device() {
            return (QIODevice) interceptor.Invoke("device", "device() const", typeof(QIODevice));
        }
        public void SetString(StringBuilder arg1, uint openMode) {
            interceptor.Invoke("setString$$", "setString(QString*, QIODevice::OpenMode)", typeof(void), typeof(StringBuilder), arg1, typeof(uint), openMode);
        }
        public void SetString(StringBuilder arg1) {
            interceptor.Invoke("setString$", "setString(QString*)", typeof(void), typeof(StringBuilder), arg1);
        }
        public string String() {
            return (string) interceptor.Invoke("string", "string() const", typeof(string));
        }
        public QTextStream.Status status() {
            return (QTextStream.Status) interceptor.Invoke("status", "status() const", typeof(QTextStream.Status));
        }
        public void SetStatus(QTextStream.Status status) {
            interceptor.Invoke("setStatus$", "setStatus(QTextStream::Status)", typeof(void), typeof(QTextStream.Status), status);
        }
        public void ResetStatus() {
            interceptor.Invoke("resetStatus", "resetStatus()", typeof(void));
        }
        public bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        public void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        public void Flush() {
            interceptor.Invoke("flush", "flush()", typeof(void));
        }
        public bool Seek(long pos) {
            return (bool) interceptor.Invoke("seek$", "seek(qint64)", typeof(bool), typeof(long), pos);
        }
        public long Pos() {
            return (long) interceptor.Invoke("pos", "pos() const", typeof(long));
        }
        public void SkipWhiteSpace() {
            interceptor.Invoke("skipWhiteSpace", "skipWhiteSpace()", typeof(void));
        }
        public string ReadLine(long maxlen) {
            return (string) interceptor.Invoke("readLine$", "readLine(qint64)", typeof(string), typeof(long), maxlen);
        }
        public string ReadLine() {
            return (string) interceptor.Invoke("readLine", "readLine()", typeof(string));
        }
        public string ReadAll() {
            return (string) interceptor.Invoke("readAll", "readAll()", typeof(string));
        }
        public string Read(long maxlen) {
            return (string) interceptor.Invoke("read$", "read(qint64)", typeof(string), typeof(long), maxlen);
        }
        public void SetFieldAlignment(QTextStream.FieldAlignment alignment) {
            interceptor.Invoke("setFieldAlignment$", "setFieldAlignment(QTextStream::FieldAlignment)", typeof(void), typeof(QTextStream.FieldAlignment), alignment);
        }
        public QTextStream.FieldAlignment fieldAlignment() {
            return (QTextStream.FieldAlignment) interceptor.Invoke("fieldAlignment", "fieldAlignment() const", typeof(QTextStream.FieldAlignment));
        }
        public void SetPadChar(QChar ch) {
            interceptor.Invoke("setPadChar#", "setPadChar(QChar)", typeof(void), typeof(QChar), ch);
        }
        public QChar PadChar() {
            return (QChar) interceptor.Invoke("padChar", "padChar() const", typeof(QChar));
        }
        public void SetFieldWidth(int width) {
            interceptor.Invoke("setFieldWidth$", "setFieldWidth(int)", typeof(void), typeof(int), width);
        }
        public int FieldWidth() {
            return (int) interceptor.Invoke("fieldWidth", "fieldWidth() const", typeof(int));
        }
        public void SetNumberFlags(uint flags) {
            interceptor.Invoke("setNumberFlags$", "setNumberFlags(QTextStream::NumberFlags)", typeof(void), typeof(uint), flags);
        }
        public uint NumberFlags() {
            return (uint) interceptor.Invoke("numberFlags", "numberFlags() const", typeof(uint));
        }
        public void SetIntegerBase(int arg1) {
            interceptor.Invoke("setIntegerBase$", "setIntegerBase(int)", typeof(void), typeof(int), arg1);
        }
        public int IntegerBase() {
            return (int) interceptor.Invoke("integerBase", "integerBase() const", typeof(int));
        }
        public void SetRealNumberNotation(QTextStream.RealNumberNotation notation) {
            interceptor.Invoke("setRealNumberNotation$", "setRealNumberNotation(QTextStream::RealNumberNotation)", typeof(void), typeof(QTextStream.RealNumberNotation), notation);
        }
        public QTextStream.RealNumberNotation realNumberNotation() {
            return (QTextStream.RealNumberNotation) interceptor.Invoke("realNumberNotation", "realNumberNotation() const", typeof(QTextStream.RealNumberNotation));
        }
        public void SetRealNumberPrecision(int precision) {
            interceptor.Invoke("setRealNumberPrecision$", "setRealNumberPrecision(int)", typeof(void), typeof(int), precision);
        }
        public int RealNumberPrecision() {
            return (int) interceptor.Invoke("realNumberPrecision", "realNumberPrecision() const", typeof(int));
        }
        public QTextStream Read(QChar ch) {
            return (QTextStream) interceptor.Invoke("operator>>#", "operator>>(QChar&)", typeof(QTextStream), typeof(QChar), ch);
        }
        public QTextStream Read(char ch) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(char&)", typeof(QTextStream), typeof(char), ch);
        }
        public QTextStream Read(ushort i) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(unsigned short&)", typeof(QTextStream), typeof(ushort), i);
        }
        public QTextStream Read(uint i) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(unsigned int&)", typeof(QTextStream), typeof(uint), i);
        }
        public QTextStream Read(ulong i) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(unsigned long&)", typeof(QTextStream), typeof(ulong), i);
        }
        public QTextStream Read(float f) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(float&)", typeof(QTextStream), typeof(float), f);
        }
        public QTextStream Read(double f) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(double&)", typeof(QTextStream), typeof(double), f);
        }
        public QTextStream Read(StringBuilder s) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(QString&)", typeof(QTextStream), typeof(StringBuilder), s);
        }
        public QTextStream Read(QByteArray array) {
            return (QTextStream) interceptor.Invoke("operator>>#", "operator>>(QByteArray&)", typeof(QTextStream), typeof(QByteArray), array);
        }
        public QTextStream Read(string c) {
            return (QTextStream) interceptor.Invoke("operator>>$", "operator>>(char*)", typeof(QTextStream), typeof(string), c);
        }
        public QTextStream Write(QBool b) {
            return (QTextStream) interceptor.Invoke("operator<<#", "operator<<(QBool)", typeof(QTextStream), typeof(QBool), b);
        }
        public QTextStream Write(QChar ch) {
            return (QTextStream) interceptor.Invoke("operator<<#", "operator<<(QChar)", typeof(QTextStream), typeof(QChar), ch);
        }
        public QTextStream Write(char ch) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(char)", typeof(QTextStream), typeof(char), ch);
        }
        public QTextStream Write(ushort i) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(unsigned short)", typeof(QTextStream), typeof(ushort), i);
        }
        public QTextStream Write(uint i) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(unsigned int)", typeof(QTextStream), typeof(uint), i);
        }
        public QTextStream Write(ulong i) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(unsigned long)", typeof(QTextStream), typeof(ulong), i);
        }
        public QTextStream Write(long i) {
            return (QTextStream) interceptor.Invoke("operator<<?", "operator<<(qlonglong)", typeof(QTextStream), typeof(long), i);
        }
        public QTextStream Write(float f) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(float)", typeof(QTextStream), typeof(float), f);
        }
        public QTextStream Write(double f) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(double)", typeof(QTextStream), typeof(double), f);
        }
        public QTextStream Write(string s) {
            return (QTextStream) interceptor.Invoke("operator<<$", "operator<<(const QString&)", typeof(QTextStream), typeof(string), s);
        }
        public QTextStream Write(QByteArray array) {
            return (QTextStream) interceptor.Invoke("operator<<#", "operator<<(const QByteArray&)", typeof(QTextStream), typeof(QByteArray), array);
        }
        ~QTextStream() {
            interceptor.Invoke("~QTextStream", "~QTextStream()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTextStream", "~QTextStream()", typeof(void));
        }
    }
}
