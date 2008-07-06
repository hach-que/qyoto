//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QVariant")]
    public partial class QVariant : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QVariant(Type dummy) {}
        [SmokeClass("QVariant::PrivateShared")]
        public class PrivateShared : Object {
            protected SmokeInvocation interceptor = null;
            private IntPtr smokeObject;
            protected PrivateShared(Type dummy) {}
            //  PrivateShared(); >>>> NOT CONVERTED
            //  PrivateShared(void* arg1); >>>> NOT CONVERTED
        }
        [SmokeClass("QVariant::Private")]
        public class Private : Object {
            protected SmokeInvocation interceptor = null;
            private IntPtr smokeObject;
            protected Private(Type dummy) {}
            //  Private(); >>>> NOT CONVERTED
            //  Private(); >>>> NOT CONVERTED
        }
        [SmokeClass("QVariant::Handler")]
        public class Handler : Object {
            protected SmokeInvocation interceptor = null;
            private IntPtr smokeObject;
            protected Handler(Type dummy) {}
        }
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QVariant), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QVariant() {
            staticInterceptor = new SmokeInvocation(typeof(QVariant), null);
        }
        public enum TypeOf : uint {
            Invalid = 0,
            Bool = 1,
            Int = 2,
            UInt = 3,
            LongLong = 4,
            ULongLong = 5,
            Double = 6,
            Char = 7,
            Map = 8,
            List = 9,
            String = 10,
            StringList = 11,
            ByteArray = 12,
            BitArray = 13,
            Date = 14,
            Time = 15,
            DateTime = 16,
            Url = 17,
            Locale = 18,
            Rect = 19,
            RectF = 20,
            Size = 21,
            SizeF = 22,
            Line = 23,
            LineF = 24,
            Point = 25,
            PointF = 26,
            RegExp = 27,
            LastCoreType = RegExp,
            Font = 64,
            Pixmap = 65,
            Brush = 66,
            Color = 67,
            Palette = 68,
            Icon = 69,
            Image = 70,
            Polygon = 71,
            Region = 72,
            Bitmap = 73,
            Cursor = 74,
            SizePolicy = 75,
            KeySequence = 76,
            Pen = 77,
            TextLength = 78,
            TextFormat = 79,
            Matrix = 80,
            Transform = 81,
            LastGuiType = Transform,
            UserType = 127,
            LastType = 0xffffffff,
        }
        // QVariant* QVariant(int arg1,const void* arg2); >>>> NOT CONVERTED
        // QVariant* QVariant(const QLatin1String& arg1); >>>> NOT CONVERTED
        // void* data(); >>>> NOT CONVERTED
        // const void* constData(); >>>> NOT CONVERTED
        // QVariant::Private& data_ptr(); >>>> NOT CONVERTED
        // void create(int arg1,const void* arg2); >>>> NOT CONVERTED
        // bool operator==(const QVariant& arg1,const QVariantComparisonHelper& arg2); >>>> NOT CONVERTED
        public QVariant() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant", "QVariant()", typeof(void));
        }
        public QVariant(QVariant.TypeOf type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(QVariant::Type)", typeof(void), typeof(QVariant.TypeOf), type);
        }
        public QVariant(QVariant other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QVariant&)", typeof(void), typeof(QVariant), other);
        }
        public QVariant(QDataStream s) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(QDataStream&)", typeof(void), typeof(QDataStream), s);
        }
        public QVariant(int i) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(int)", typeof(void), typeof(int), i);
        }
        public QVariant(uint ui) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(uint)", typeof(void), typeof(uint), ui);
        }
        public QVariant(long ll) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant?", "QVariant(qlonglong)", typeof(void), typeof(long), ll);
        }
        public QVariant(ulong ull) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(qulonglong)", typeof(void), typeof(ulong), ull);
        }
        public QVariant(bool b) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(bool)", typeof(void), typeof(bool), b);
        }
        public QVariant(double d) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(double)", typeof(void), typeof(double), d);
        }
        public QVariant(string str) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(const char*)", typeof(void), typeof(string), str);
        }
        public QVariant(QByteArray bytearray) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QByteArray&)", typeof(void), typeof(QByteArray), bytearray);
        }
        public QVariant(QBitArray bitarray) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QBitArray&)", typeof(void), typeof(QBitArray), bitarray);
        }
        public QVariant(List<string> stringlist) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant?", "QVariant(const QStringList&)", typeof(void), typeof(List<string>), stringlist);
        }
        public QVariant(QChar qchar) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QChar&)", typeof(void), typeof(QChar), qchar);
        }
        public QVariant(QDate date) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QDate&)", typeof(void), typeof(QDate), date);
        }
        public QVariant(QTime time) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QTime&)", typeof(void), typeof(QTime), time);
        }
        public QVariant(QDateTime datetime) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QDateTime&)", typeof(void), typeof(QDateTime), datetime);
        }
        public QVariant(List<QVariant> list) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant?", "QVariant(const QList<QVariant>&)", typeof(void), typeof(List<QVariant>), list);
        }
        public QVariant(Dictionary<string, QVariant> map) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant?", "QVariant(const QMap<QString, QVariant>&)", typeof(void), typeof(Dictionary<string, QVariant>), map);
        }
        public QVariant(QSize size) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QSize&)", typeof(void), typeof(QSize), size);
        }
        public QVariant(QSizeF size) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QSizeF&)", typeof(void), typeof(QSizeF), size);
        }
        public QVariant(QPoint pt) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QPoint&)", typeof(void), typeof(QPoint), pt);
        }
        public QVariant(QPointF pt) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QPointF&)", typeof(void), typeof(QPointF), pt);
        }
        public QVariant(QLine line) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QLine&)", typeof(void), typeof(QLine), line);
        }
        public QVariant(QLineF line) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QLineF&)", typeof(void), typeof(QLineF), line);
        }
        public QVariant(QRect rect) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QRect&)", typeof(void), typeof(QRect), rect);
        }
        public QVariant(QRectF rect) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QRectF&)", typeof(void), typeof(QRectF), rect);
        }
        public QVariant(QUrl url) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QUrl&)", typeof(void), typeof(QUrl), url);
        }
        public QVariant(QLocale locale) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QLocale&)", typeof(void), typeof(QLocale), locale);
        }
        public QVariant(QRegExp regExp) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant#", "QVariant(const QRegExp&)", typeof(void), typeof(QRegExp), regExp);
        }
        public QVariant(Qt.GlobalColor color) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QVariant$", "QVariant(Qt::GlobalColor)", typeof(void), typeof(Qt.GlobalColor), color);
        }
        public QVariant.TypeOf type() {
            return (QVariant.TypeOf) interceptor.Invoke("type", "type() const", typeof(QVariant.TypeOf));
        }
        public int UserType() {
            return (int) interceptor.Invoke("userType", "userType() const", typeof(int));
        }
        public string TypeName() {
            return (string) interceptor.Invoke("typeName", "typeName() const", typeof(string));
        }
        public bool CanConvert(QVariant.TypeOf t) {
            return (bool) interceptor.Invoke("canConvert$", "canConvert(QVariant::Type) const", typeof(bool), typeof(QVariant.TypeOf), t);
        }
        public bool Convert(QVariant.TypeOf t) {
            return (bool) interceptor.Invoke("convert$", "convert(QVariant::Type)", typeof(bool), typeof(QVariant.TypeOf), t);
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public bool IsNull() {
            return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
        }
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public void Detach() {
            interceptor.Invoke("detach", "detach()", typeof(void));
        }
        public bool IsDetached() {
            return (bool) interceptor.Invoke("isDetached", "isDetached() const", typeof(bool));
        }
        public int ToInt(ref bool ok) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_bool = ok;
            interceptor.Invoke("toInt$", "toInt(bool*) const", stack);
            ok = stack[1].s_bool;
            return stack[0].s_int;
        }
        public int ToInt() {
            return (int) interceptor.Invoke("toInt", "toInt() const", typeof(int));
        }
        public uint ToUInt(ref bool ok) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_bool = ok;
            interceptor.Invoke("toUInt$", "toUInt(bool*) const", stack);
            ok = stack[1].s_bool;
            return stack[0].s_uint;
        }
        public uint ToUInt() {
            return (uint) interceptor.Invoke("toUInt", "toUInt() const", typeof(uint));
        }
        public long ToLongLong(ref bool ok) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_bool = ok;
            interceptor.Invoke("toLongLong$", "toLongLong(bool*) const", stack);
            ok = stack[1].s_bool;
            return stack[0].s_long;
        }
        public long ToLongLong() {
            return (long) interceptor.Invoke("toLongLong", "toLongLong() const", typeof(long));
        }
        public ulong ToULongLong(ref bool ok) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_bool = ok;
            interceptor.Invoke("toULongLong$", "toULongLong(bool*) const", stack);
            ok = stack[1].s_bool;
            return stack[0].s_ulong;
        }
        public ulong ToULongLong() {
            return (ulong) interceptor.Invoke("toULongLong", "toULongLong() const", typeof(ulong));
        }
        public bool ToBool() {
            return (bool) interceptor.Invoke("toBool", "toBool() const", typeof(bool));
        }
        public double ToDouble(ref bool ok) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_bool = ok;
            interceptor.Invoke("toDouble$", "toDouble(bool*) const", stack);
            ok = stack[1].s_bool;
            return stack[0].s_double;
        }
        public double ToDouble() {
            return (double) interceptor.Invoke("toDouble", "toDouble() const", typeof(double));
        }
        public QByteArray ToByteArray() {
            return (QByteArray) interceptor.Invoke("toByteArray", "toByteArray() const", typeof(QByteArray));
        }
        public QBitArray ToBitArray() {
            return (QBitArray) interceptor.Invoke("toBitArray", "toBitArray() const", typeof(QBitArray));
        }
        public new string ToString() {
            return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
        }
        public List<string> ToStringList() {
            return (List<string>) interceptor.Invoke("toStringList", "toStringList() const", typeof(List<string>));
        }
        public QChar ToChar() {
            return (QChar) interceptor.Invoke("toChar", "toChar() const", typeof(QChar));
        }
        public QDate ToDate() {
            return (QDate) interceptor.Invoke("toDate", "toDate() const", typeof(QDate));
        }
        public QTime ToTime() {
            return (QTime) interceptor.Invoke("toTime", "toTime() const", typeof(QTime));
        }
        public QDateTime ToDateTime() {
            return (QDateTime) interceptor.Invoke("toDateTime", "toDateTime() const", typeof(QDateTime));
        }
        public List<QVariant> ToList() {
            return (List<QVariant>) interceptor.Invoke("toList", "toList() const", typeof(List<QVariant>));
        }
        public Dictionary<string, QVariant> ToMap() {
            return (Dictionary<string, QVariant>) interceptor.Invoke("toMap", "toMap() const", typeof(Dictionary<string, QVariant>));
        }
        public QPoint ToPoint() {
            return (QPoint) interceptor.Invoke("toPoint", "toPoint() const", typeof(QPoint));
        }
        public QPointF ToPointF() {
            return (QPointF) interceptor.Invoke("toPointF", "toPointF() const", typeof(QPointF));
        }
        public QRect ToRect() {
            return (QRect) interceptor.Invoke("toRect", "toRect() const", typeof(QRect));
        }
        public QSize ToSize() {
            return (QSize) interceptor.Invoke("toSize", "toSize() const", typeof(QSize));
        }
        public QSizeF ToSizeF() {
            return (QSizeF) interceptor.Invoke("toSizeF", "toSizeF() const", typeof(QSizeF));
        }
        public QLine ToLine() {
            return (QLine) interceptor.Invoke("toLine", "toLine() const", typeof(QLine));
        }
        public QLineF ToLineF() {
            return (QLineF) interceptor.Invoke("toLineF", "toLineF() const", typeof(QLineF));
        }
        public QRectF ToRectF() {
            return (QRectF) interceptor.Invoke("toRectF", "toRectF() const", typeof(QRectF));
        }
        public QUrl ToUrl() {
            return (QUrl) interceptor.Invoke("toUrl", "toUrl() const", typeof(QUrl));
        }
        public QLocale ToLocale() {
            return (QLocale) interceptor.Invoke("toLocale", "toLocale() const", typeof(QLocale));
        }
        public QRegExp ToRegExp() {
            return (QRegExp) interceptor.Invoke("toRegExp", "toRegExp() const", typeof(QRegExp));
        }
        public void Load(QDataStream ds) {
            interceptor.Invoke("load#", "load(QDataStream&)", typeof(void), typeof(QDataStream), ds);
        }
        public void Save(QDataStream ds) {
            interceptor.Invoke("save#", "save(QDataStream&) const", typeof(void), typeof(QDataStream), ds);
        }
        public override bool Equals(object o) {
            if (!(o is QVariant)) { return false; }
            return this == (QVariant) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        protected bool Cmp(QVariant other) {
            return (bool) interceptor.Invoke("cmp#", "cmp(const QVariant&) const", typeof(bool), typeof(QVariant), other);
        }
        ~QVariant() {
            interceptor.Invoke("~QVariant", "~QVariant()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QVariant", "~QVariant()", typeof(void));
        }
        public static bool operator==(QVariant lhs, QVariant v) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QVariant&) const", typeof(bool), typeof(QVariant), lhs, typeof(QVariant), v);
        }
        public static bool operator!=(QVariant lhs, QVariant v) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QVariant&) const", typeof(bool), typeof(QVariant), lhs, typeof(QVariant), v);
        }
        public static string TypeToName(QVariant.TypeOf type) {
            return (string) staticInterceptor.Invoke("typeToName$", "typeToName(QVariant::Type)", typeof(string), typeof(QVariant.TypeOf), type);
        }
        public static QVariant.TypeOf NameToType(string name) {
            return (QVariant.TypeOf) staticInterceptor.Invoke("nameToType$", "nameToType(const char*)", typeof(QVariant.TypeOf), typeof(string), name);
        }
    }
}
