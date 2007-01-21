//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QVariant")]
	public partial class QVariant : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QVariant(Type dummy) {}
		interface IQVariantProxy {
			bool op_equals(QVariant lhs, QVariant v);
			string TypeToName(QVariant.E_Type type);
			QVariant.E_Type NameToType(string name);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QVariant), this);
			_interceptor = (QVariant) realProxy.GetTransparentProxy();
		}
		private QVariant ProxyQVariant() {
			return (QVariant) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QVariant() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQVariantProxy), null);
			_staticInterceptor = (IQVariantProxy) realProxy.GetTransparentProxy();
		}
		private static IQVariantProxy StaticQVariant() {
			return (IQVariantProxy) _staticInterceptor;
		}

		public enum E_Type : uint {
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
			LastGuiType = Matrix,
			UserType = 127,
			LastType = 0xffffffff,
		}
		public QVariant() : this((Type) null) {
			CreateProxy();
			NewQVariant();
		}
		[SmokeMethod("QVariant()")]
		private void NewQVariant() {
			ProxyQVariant().NewQVariant();
		}
		public QVariant(QVariant.E_Type type) : this((Type) null) {
			CreateProxy();
			NewQVariant(type);
		}
		[SmokeMethod("QVariant(QVariant::Type)")]
		private void NewQVariant(QVariant.E_Type type) {
			ProxyQVariant().NewQVariant(type);
		}
		// QVariant* QVariant(int arg1,const void* arg2); >>>> NOT CONVERTED
		public QVariant(QVariant other) : this((Type) null) {
			CreateProxy();
			NewQVariant(other);
		}
		[SmokeMethod("QVariant(const QVariant&)")]
		private void NewQVariant(QVariant other) {
			ProxyQVariant().NewQVariant(other);
		}
		public QVariant(QDataStream s) : this((Type) null) {
			CreateProxy();
			NewQVariant(s);
		}
		[SmokeMethod("QVariant(QDataStream&)")]
		private void NewQVariant(QDataStream s) {
			ProxyQVariant().NewQVariant(s);
		}
		public QVariant(int i) : this((Type) null) {
			CreateProxy();
			NewQVariant(i);
		}
		[SmokeMethod("QVariant(int)")]
		private void NewQVariant(int i) {
			ProxyQVariant().NewQVariant(i);
		}
		public QVariant(uint ui) : this((Type) null) {
			CreateProxy();
			NewQVariant(ui);
		}
		[SmokeMethod("QVariant(uint)")]
		private void NewQVariant(uint ui) {
			ProxyQVariant().NewQVariant(ui);
		}
		// QVariant* QVariant(qlonglong arg1); >>>> NOT CONVERTED
		// QVariant* QVariant(qulonglong arg1); >>>> NOT CONVERTED
		public QVariant(bool b) : this((Type) null) {
			CreateProxy();
			NewQVariant(b);
		}
		[SmokeMethod("QVariant(bool)")]
		private void NewQVariant(bool b) {
			ProxyQVariant().NewQVariant(b);
		}
		public QVariant(double d) : this((Type) null) {
			CreateProxy();
			NewQVariant(d);
		}
		[SmokeMethod("QVariant(double)")]
		private void NewQVariant(double d) {
			ProxyQVariant().NewQVariant(d);
		}
		public QVariant(string str) : this((Type) null) {
			CreateProxy();
			NewQVariant(str);
		}
		[SmokeMethod("QVariant(const char*)")]
		private void NewQVariant(string str) {
			ProxyQVariant().NewQVariant(str);
		}
		public QVariant(QByteArray bytearray) : this((Type) null) {
			CreateProxy();
			NewQVariant(bytearray);
		}
		[SmokeMethod("QVariant(const QByteArray&)")]
		private void NewQVariant(QByteArray bytearray) {
			ProxyQVariant().NewQVariant(bytearray);
		}
		// QVariant* QVariant(const QBitArray& arg1); >>>> NOT CONVERTED
		// QVariant* QVariant(const QLatin1String& arg1); >>>> NOT CONVERTED
		public QVariant(string[] stringlist) : this((Type) null) {
			CreateProxy();
			NewQVariant(stringlist);
		}
		[SmokeMethod("QVariant(const QStringList&)")]
		private void NewQVariant(string[] stringlist) {
			ProxyQVariant().NewQVariant(stringlist);
		}
		public QVariant(char qchar) : this((Type) null) {
			CreateProxy();
			NewQVariant(qchar);
		}
		[SmokeMethod("QVariant(const QChar&)")]
		private void NewQVariant(char qchar) {
			ProxyQVariant().NewQVariant(qchar);
		}
		public QVariant(QDate date) : this((Type) null) {
			CreateProxy();
			NewQVariant(date);
		}
		[SmokeMethod("QVariant(const QDate&)")]
		private void NewQVariant(QDate date) {
			ProxyQVariant().NewQVariant(date);
		}
		public QVariant(QTime time) : this((Type) null) {
			CreateProxy();
			NewQVariant(time);
		}
		[SmokeMethod("QVariant(const QTime&)")]
		private void NewQVariant(QTime time) {
			ProxyQVariant().NewQVariant(time);
		}
		public QVariant(QDateTime datetime) : this((Type) null) {
			CreateProxy();
			NewQVariant(datetime);
		}
		[SmokeMethod("QVariant(const QDateTime&)")]
		private void NewQVariant(QDateTime datetime) {
			ProxyQVariant().NewQVariant(datetime);
		}
		public QVariant(ArrayList list) : this((Type) null) {
			CreateProxy();
			NewQVariant(list);
		}
		[SmokeMethod("QVariant(const QList<QVariant>&)")]
		private void NewQVariant(ArrayList list) {
			ProxyQVariant().NewQVariant(list);
		}
		// QVariant* QVariant(const QMap<QString, QVariant>& arg1); >>>> NOT CONVERTED
		public QVariant(QSize size) : this((Type) null) {
			CreateProxy();
			NewQVariant(size);
		}
		[SmokeMethod("QVariant(const QSize&)")]
		private void NewQVariant(QSize size) {
			ProxyQVariant().NewQVariant(size);
		}
		public QVariant(QSizeF size) : this((Type) null) {
			CreateProxy();
			NewQVariant(size);
		}
		[SmokeMethod("QVariant(const QSizeF&)")]
		private void NewQVariant(QSizeF size) {
			ProxyQVariant().NewQVariant(size);
		}
		public QVariant(QPoint pt) : this((Type) null) {
			CreateProxy();
			NewQVariant(pt);
		}
		[SmokeMethod("QVariant(const QPoint&)")]
		private void NewQVariant(QPoint pt) {
			ProxyQVariant().NewQVariant(pt);
		}
		public QVariant(QPointF pt) : this((Type) null) {
			CreateProxy();
			NewQVariant(pt);
		}
		[SmokeMethod("QVariant(const QPointF&)")]
		private void NewQVariant(QPointF pt) {
			ProxyQVariant().NewQVariant(pt);
		}
		public QVariant(QLine line) : this((Type) null) {
			CreateProxy();
			NewQVariant(line);
		}
		[SmokeMethod("QVariant(const QLine&)")]
		private void NewQVariant(QLine line) {
			ProxyQVariant().NewQVariant(line);
		}
		public QVariant(QLineF line) : this((Type) null) {
			CreateProxy();
			NewQVariant(line);
		}
		[SmokeMethod("QVariant(const QLineF&)")]
		private void NewQVariant(QLineF line) {
			ProxyQVariant().NewQVariant(line);
		}
		public QVariant(QRect rect) : this((Type) null) {
			CreateProxy();
			NewQVariant(rect);
		}
		[SmokeMethod("QVariant(const QRect&)")]
		private void NewQVariant(QRect rect) {
			ProxyQVariant().NewQVariant(rect);
		}
		public QVariant(QRectF rect) : this((Type) null) {
			CreateProxy();
			NewQVariant(rect);
		}
		[SmokeMethod("QVariant(const QRectF&)")]
		private void NewQVariant(QRectF rect) {
			ProxyQVariant().NewQVariant(rect);
		}
		public QVariant(IQUrl url) : this((Type) null) {
			CreateProxy();
			NewQVariant(url);
		}
		[SmokeMethod("QVariant(const QUrl&)")]
		private void NewQVariant(IQUrl url) {
			ProxyQVariant().NewQVariant(url);
		}
		public QVariant(QLocale locale) : this((Type) null) {
			CreateProxy();
			NewQVariant(locale);
		}
		[SmokeMethod("QVariant(const QLocale&)")]
		private void NewQVariant(QLocale locale) {
			ProxyQVariant().NewQVariant(locale);
		}
		public QVariant(QRegExp regExp) : this((Type) null) {
			CreateProxy();
			NewQVariant(regExp);
		}
		[SmokeMethod("QVariant(const QRegExp&)")]
		private void NewQVariant(QRegExp regExp) {
			ProxyQVariant().NewQVariant(regExp);
		}
		public QVariant(Qt.GlobalColor color) : this((Type) null) {
			CreateProxy();
			NewQVariant(color);
		}
		[SmokeMethod("QVariant(Qt::GlobalColor)")]
		private void NewQVariant(Qt.GlobalColor color) {
			ProxyQVariant().NewQVariant(color);
		}
		[SmokeMethod("type() const")]
		public QVariant.E_Type type() {
			return ProxyQVariant().type();
		}
		[SmokeMethod("userType() const")]
		public int UserType() {
			return ProxyQVariant().UserType();
		}
		[SmokeMethod("typeName() const")]
		public string TypeName() {
			return ProxyQVariant().TypeName();
		}
		[SmokeMethod("canConvert(QVariant::Type) const")]
		public bool CanConvert(QVariant.E_Type t) {
			return ProxyQVariant().CanConvert(t);
		}
		[SmokeMethod("convert(QVariant::Type)")]
		public bool Convert(QVariant.E_Type t) {
			return ProxyQVariant().Convert(t);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQVariant().IsValid();
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQVariant().IsNull();
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQVariant().Clear();
		}
		[SmokeMethod("detach()")]
		public void Detach() {
			ProxyQVariant().Detach();
		}
		[SmokeMethod("isDetached() const")]
		public bool IsDetached() {
			return ProxyQVariant().IsDetached();
		}
		[SmokeMethod("toInt(bool*) const")]
		public int ToInt(out bool ok) {
			return ProxyQVariant().ToInt(out ok);
		}
		[SmokeMethod("toInt() const")]
		public int ToInt() {
			return ProxyQVariant().ToInt();
		}
		[SmokeMethod("toUInt(bool*) const")]
		public uint ToUInt(out bool ok) {
			return ProxyQVariant().ToUInt(out ok);
		}
		[SmokeMethod("toUInt() const")]
		public uint ToUInt() {
			return ProxyQVariant().ToUInt();
		}
		// qlonglong toLongLong(bool* arg1); >>>> NOT CONVERTED
		// qlonglong toLongLong(); >>>> NOT CONVERTED
		// qulonglong toULongLong(bool* arg1); >>>> NOT CONVERTED
		// qulonglong toULongLong(); >>>> NOT CONVERTED
		[SmokeMethod("toBool() const")]
		public bool ToBool() {
			return ProxyQVariant().ToBool();
		}
		[SmokeMethod("toDouble(bool*) const")]
		public double ToDouble(out bool ok) {
			return ProxyQVariant().ToDouble(out ok);
		}
		[SmokeMethod("toDouble() const")]
		public double ToDouble() {
			return ProxyQVariant().ToDouble();
		}
		[SmokeMethod("toByteArray() const")]
		public QByteArray ToByteArray() {
			return ProxyQVariant().ToByteArray();
		}
		// QBitArray toBitArray(); >>>> NOT CONVERTED
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQVariant().ToString();
		}
		[SmokeMethod("toStringList() const")]
		public ArrayList ToStringList() {
			return ProxyQVariant().ToStringList();
		}
		[SmokeMethod("toChar() const")]
		public char ToChar() {
			return ProxyQVariant().ToChar();
		}
		[SmokeMethod("toDate() const")]
		public QDate ToDate() {
			return ProxyQVariant().ToDate();
		}
		[SmokeMethod("toTime() const")]
		public QTime ToTime() {
			return ProxyQVariant().ToTime();
		}
		[SmokeMethod("toDateTime() const")]
		public QDateTime ToDateTime() {
			return ProxyQVariant().ToDateTime();
		}
		[SmokeMethod("toList() const")]
		public ArrayList ToList() {
			return ProxyQVariant().ToList();
		}
		// QMap<QString, QVariant> toMap(); >>>> NOT CONVERTED
		[SmokeMethod("toPoint() const")]
		public QPoint ToPoint() {
			return ProxyQVariant().ToPoint();
		}
		[SmokeMethod("toPointF() const")]
		public QPointF ToPointF() {
			return ProxyQVariant().ToPointF();
		}
		[SmokeMethod("toRect() const")]
		public QRect ToRect() {
			return ProxyQVariant().ToRect();
		}
		[SmokeMethod("toSize() const")]
		public QSize ToSize() {
			return ProxyQVariant().ToSize();
		}
		[SmokeMethod("toSizeF() const")]
		public QSizeF ToSizeF() {
			return ProxyQVariant().ToSizeF();
		}
		[SmokeMethod("toLine() const")]
		public QLine ToLine() {
			return ProxyQVariant().ToLine();
		}
		[SmokeMethod("toLineF() const")]
		public QLineF ToLineF() {
			return ProxyQVariant().ToLineF();
		}
		[SmokeMethod("toRectF() const")]
		public QRectF ToRectF() {
			return ProxyQVariant().ToRectF();
		}
		[SmokeMethod("toUrl() const")]
		public IQUrl ToUrl() {
			return ProxyQVariant().ToUrl();
		}
		[SmokeMethod("toLocale() const")]
		public QLocale ToLocale() {
			return ProxyQVariant().ToLocale();
		}
		[SmokeMethod("toRegExp() const")]
		public QRegExp ToRegExp() {
			return ProxyQVariant().ToRegExp();
		}
		[SmokeMethod("load(QDataStream&)")]
		public void Load(QDataStream ds) {
			ProxyQVariant().Load(ds);
		}
		[SmokeMethod("save(QDataStream&) const")]
		public void Save(QDataStream ds) {
			ProxyQVariant().Save(ds);
		}
		// void* data(); >>>> NOT CONVERTED
		// const void* constData(); >>>> NOT CONVERTED
		// const void* data(); >>>> NOT CONVERTED
		[SmokeMethod("operator==(const QVariant&) const")]
		public static bool operator==(QVariant lhs, QVariant v) {
			return StaticQVariant().op_equals(lhs,v);
		}
		public static bool operator!=(QVariant lhs, QVariant v) {
			return !StaticQVariant().op_equals(lhs,v);
		}
		public override bool Equals(object o) {
			if (!(o is QVariant)) { return false; }
			return this == (QVariant) o;
		}
		public override int GetHashCode() {
			return ProxyQVariant().GetHashCode();
		}
		[SmokeMethod("typeToName(QVariant::Type)")]
		public static string TypeToName(QVariant.E_Type type) {
			return StaticQVariant().TypeToName(type);
		}
		[SmokeMethod("nameToType(const char*)")]
		public static QVariant.E_Type NameToType(string name) {
			return StaticQVariant().NameToType(name);
		}
		// void create(int arg1,const void* arg2); >>>> NOT CONVERTED
		[SmokeMethod("cmp(const QVariant&) const")]
		protected bool Cmp(QVariant other) {
			return ProxyQVariant().Cmp(other);
		}
		~QVariant() {
			DisposeQVariant();
		}
		public void Dispose() {
			DisposeQVariant();
		}
		[SmokeMethod("~QVariant()")]
		private void DisposeQVariant() {
			ProxyQVariant().DisposeQVariant();
		}
	}
}
