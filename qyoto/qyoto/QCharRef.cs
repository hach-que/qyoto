//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QCharRef")]
	public class QCharRef : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QCharRef(Type dummy) {}
		interface IQCharRefProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCharRef), this);
			_interceptor = (QCharRef) realProxy.GetTransparentProxy();
		}
		private QCharRef ProxyQCharRef() {
			return (QCharRef) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCharRef() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCharRefProxy), null);
			_staticInterceptor = (IQCharRefProxy) realProxy.GetTransparentProxy();
		}
		private static IQCharRefProxy StaticQCharRef() {
			return (IQCharRefProxy) _staticInterceptor;
		}

		//  operator QChar(); >>>> NOT CONVERTED
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQCharRef().IsNull();
		}
		[SmokeMethod("isPrint() const")]
		public bool IsPrint() {
			return ProxyQCharRef().IsPrint();
		}
		[SmokeMethod("isPunct() const")]
		public bool IsPunct() {
			return ProxyQCharRef().IsPunct();
		}
		[SmokeMethod("isSpace() const")]
		public bool IsSpace() {
			return ProxyQCharRef().IsSpace();
		}
		[SmokeMethod("isMark() const")]
		public bool IsMark() {
			return ProxyQCharRef().IsMark();
		}
		[SmokeMethod("isLetter() const")]
		public bool IsLetter() {
			return ProxyQCharRef().IsLetter();
		}
		[SmokeMethod("isNumber() const")]
		public bool IsNumber() {
			return ProxyQCharRef().IsNumber();
		}
		[SmokeMethod("isLetterOrNumber()")]
		public bool IsLetterOrNumber() {
			return ProxyQCharRef().IsLetterOrNumber();
		}
		[SmokeMethod("isDigit() const")]
		public bool IsDigit() {
			return ProxyQCharRef().IsDigit();
		}
		[SmokeMethod("digitValue() const")]
		public int DigitValue() {
			return ProxyQCharRef().DigitValue();
		}
		[SmokeMethod("toLower() const")]
		public char ToLower() {
			return ProxyQCharRef().ToLower();
		}
		[SmokeMethod("toUpper() const")]
		public char ToUpper() {
			return ProxyQCharRef().ToUpper();
		}
		[SmokeMethod("category() const")]
		public char Category() {
			return ProxyQCharRef().Category();
		}
		[SmokeMethod("direction() const")]
		public char Direction() {
			return ProxyQCharRef().Direction();
		}
		[SmokeMethod("joining() const")]
		public char Joining() {
			return ProxyQCharRef().Joining();
		}
		[SmokeMethod("hasMirrored() const")]
		public bool HasMirrored() {
			return ProxyQCharRef().HasMirrored();
		}
		[SmokeMethod("mirroredChar() const")]
		public char MirroredChar() {
			return ProxyQCharRef().MirroredChar();
		}
		[SmokeMethod("decomposition() const")]
		public string Decomposition() {
			return ProxyQCharRef().Decomposition();
		}
		[SmokeMethod("decompositionTag() const")]
		public char DecompositionTag() {
			return ProxyQCharRef().DecompositionTag();
		}
		[SmokeMethod("combiningClass() const")]
		public ushort CombiningClass() {
			return ProxyQCharRef().CombiningClass();
		}
		[SmokeMethod("unicodeVersion() const")]
		public char UnicodeVersion() {
			return ProxyQCharRef().UnicodeVersion();
		}
		[SmokeMethod("cell() const")]
		public ushort Cell() {
			return ProxyQCharRef().Cell();
		}
		[SmokeMethod("row() const")]
		public ushort Row() {
			return ProxyQCharRef().Row();
		}
		[SmokeMethod("setCell(uchar)")]
		public void SetCell(ushort cell) {
			ProxyQCharRef().SetCell(cell);
		}
		[SmokeMethod("setRow(uchar)")]
		public void SetRow(ushort row) {
			ProxyQCharRef().SetRow(row);
		}
		[SmokeMethod("toAscii() const")]
		public char ToAscii() {
			return ProxyQCharRef().ToAscii();
		}
		[SmokeMethod("toLatin1() const")]
		public char ToLatin1() {
			return ProxyQCharRef().ToLatin1();
		}
		[SmokeMethod("unicode() const")]
		public ushort Unicode() {
			return ProxyQCharRef().Unicode();
		}
		~QCharRef() {
			DisposeQCharRef();
		}
		public void Dispose() {
			DisposeQCharRef();
		}
		[SmokeMethod("~QCharRef()")]
		private void DisposeQCharRef() {
			ProxyQCharRef().DisposeQCharRef();
		}
	}
}
