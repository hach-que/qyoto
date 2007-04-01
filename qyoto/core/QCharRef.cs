//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QCharRef")]
	public class QCharRef : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QCharRef(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QCharRef), "QCharRef", this);
		}
		//  operator QChar(); >>>> NOT CONVERTED
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public bool IsPrint() {
			return (bool) interceptor.Invoke("isPrint", "isPrint() const", typeof(bool));
		}
		public bool IsPunct() {
			return (bool) interceptor.Invoke("isPunct", "isPunct() const", typeof(bool));
		}
		public bool IsSpace() {
			return (bool) interceptor.Invoke("isSpace", "isSpace() const", typeof(bool));
		}
		public bool IsMark() {
			return (bool) interceptor.Invoke("isMark", "isMark() const", typeof(bool));
		}
		public bool IsLetter() {
			return (bool) interceptor.Invoke("isLetter", "isLetter() const", typeof(bool));
		}
		public bool IsNumber() {
			return (bool) interceptor.Invoke("isNumber", "isNumber() const", typeof(bool));
		}
		public bool IsLetterOrNumber() {
			return (bool) interceptor.Invoke("isLetterOrNumber", "isLetterOrNumber()", typeof(bool));
		}
		public bool IsDigit() {
			return (bool) interceptor.Invoke("isDigit", "isDigit() const", typeof(bool));
		}
		public int DigitValue() {
			return (int) interceptor.Invoke("digitValue", "digitValue() const", typeof(int));
		}
		public char ToLower() {
			return (char) interceptor.Invoke("toLower", "toLower() const", typeof(char));
		}
		public char ToUpper() {
			return (char) interceptor.Invoke("toUpper", "toUpper() const", typeof(char));
		}
		public char Category() {
			return (char) interceptor.Invoke("category", "category() const", typeof(char));
		}
		public char Direction() {
			return (char) interceptor.Invoke("direction", "direction() const", typeof(char));
		}
		public char Joining() {
			return (char) interceptor.Invoke("joining", "joining() const", typeof(char));
		}
		public bool HasMirrored() {
			return (bool) interceptor.Invoke("hasMirrored", "hasMirrored() const", typeof(bool));
		}
		public char MirroredChar() {
			return (char) interceptor.Invoke("mirroredChar", "mirroredChar() const", typeof(char));
		}
		public string Decomposition() {
			return (string) interceptor.Invoke("decomposition", "decomposition() const", typeof(string));
		}
		public char DecompositionTag() {
			return (char) interceptor.Invoke("decompositionTag", "decompositionTag() const", typeof(char));
		}
		public ushort CombiningClass() {
			return (ushort) interceptor.Invoke("combiningClass", "combiningClass() const", typeof(ushort));
		}
		public char UnicodeVersion() {
			return (char) interceptor.Invoke("unicodeVersion", "unicodeVersion() const", typeof(char));
		}
		public ushort Cell() {
			return (ushort) interceptor.Invoke("cell", "cell() const", typeof(ushort));
		}
		public ushort Row() {
			return (ushort) interceptor.Invoke("row", "row() const", typeof(ushort));
		}
		public void SetCell(ushort cell) {
			interceptor.Invoke("setCell$", "setCell(uchar)", typeof(void), typeof(ushort), cell);
		}
		public void SetRow(ushort row) {
			interceptor.Invoke("setRow$", "setRow(uchar)", typeof(void), typeof(ushort), row);
		}
		public char ToAscii() {
			return (char) interceptor.Invoke("toAscii", "toAscii() const", typeof(char));
		}
		public char ToLatin1() {
			return (char) interceptor.Invoke("toLatin1", "toLatin1() const", typeof(char));
		}
		public ushort Unicode() {
			return (ushort) interceptor.Invoke("unicode", "unicode() const", typeof(ushort));
		}
	}
}
