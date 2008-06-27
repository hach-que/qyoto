//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  The <code>CSSPrimitiveValue</code> interface represents a single
	///  <a href="http://www.w3.org/TR/REC-CSS2/syndata.html#values"> CSS
	///  value </a> . This interface may be used to determine the value of a
	///  specific style property currently set in a block or to set a
	///  specific style properties explicitly within the block. An instance
	///  of this interface can be obtained from the
	///  <code>getPropertyCSSValue</code> method of the
	///  <code>CSSStyleDeclaration</code> interface.
	///  </remarks>		<short>    The <code>CSSPrimitiveValue</code> interface represents a single  <a href="http://www.</short>
	[SmokeClass("DOM::CSSPrimitiveValue")]
	public class CSSPrimitiveValue : DOM.CSSValue, IDisposable {
 		protected CSSPrimitiveValue(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(CSSPrimitiveValue), this);
		}
		/// <remarks>
		///  An integer indicating which type of unit applies to the value.
		///      </remarks>		<short>    An integer indicating which type of unit applies to the value.</short>
		public enum UnitTypes {
			CSS_UNKNOWN = 0,
			CSS_NUMBER = 1,
			CSS_PERCENTAGE = 2,
			CSS_EMS = 3,
			CSS_EXS = 4,
			CSS_PX = 5,
			CSS_CM = 6,
			CSS_MM = 7,
			CSS_IN = 8,
			CSS_PT = 9,
			CSS_PC = 10,
			CSS_DEG = 11,
			CSS_RAD = 12,
			CSS_GRAD = 13,
			CSS_MS = 14,
			CSS_S = 15,
			CSS_HZ = 16,
			CSS_KHZ = 17,
			CSS_DIMENSION = 18,
			CSS_STRING = 19,
			CSS_URI = 20,
			CSS_IDENT = 21,
			CSS_ATTR = 22,
			CSS_COUNTER = 23,
			CSS_RECT = 24,
			CSS_RGBCOLOR = 25,
			CSS_DPI = 26,
			CSS_DPCM = 27,
			CSS_PAIR = 100,
			CSS_HTML_RELATIVE = 255,
		}
		// DOM::CSSPrimitiveValue* CSSPrimitiveValue(DOM::CSSPrimitiveValueImpl* arg1); >>>> NOT CONVERTED
		public CSSPrimitiveValue() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSPrimitiveValue", "CSSPrimitiveValue()", typeof(void));
		}
		public CSSPrimitiveValue(DOM.CSSPrimitiveValue other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSPrimitiveValue#", "CSSPrimitiveValue(const DOM::CSSPrimitiveValue&)", typeof(void), typeof(DOM.CSSPrimitiveValue), other);
		}
		public CSSPrimitiveValue(DOM.CSSValue other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSPrimitiveValue#", "CSSPrimitiveValue(const DOM::CSSValue&)", typeof(void), typeof(DOM.CSSValue), other);
		}
		/// <remarks>
		///  The type of the value as defined by the constants specified
		///  above.
		///      </remarks>		<short>    The type of the value as defined by the constants specified  above.</short>
		public ushort PrimitiveType() {
			return (ushort) interceptor.Invoke("primitiveType", "primitiveType() const", typeof(ushort));
		}
		/// <remarks>
		///  A method to set the float value with a specified unit. If the
		///  property attached with this value can not accept the specified
		///  unit or the float value, the value will be unchanged and a
		///  <code>DOMException</code> will be raised.
		/// <param> name="unitType" A unit code as defined above. The unit code can
		///  only be a float unit type (e.g. <code>NUMBER</code> ,
		///  <code>PERCENTAGE</code> , <code>CSS_EMS</code> , <code>CSS_EXS</code>
		///  , <code>CSS_PX</code> , <code>CSS_PX</code> ,
		///  <code>CSS_CM</code> , <code>CSS_MM</code> , <code>CSS_IN</code>
		///  , <code>CSS_PT</code> , <code>CSS_PC</code> ,
		///  <code>CSS_DEG</code> , <code>CSS_RAD</code> ,
		///  <code>CSS_GRAD</code> , <code>CSS_MS</code> , <code>CSS_S</code>
		///  , <code>CSS_HZ</code> , <code>CSS_KHZ</code> ,
		///  <code>CSS_DIMENSION</code>  ).
		/// </param><param> name="floatValue" The new float value.
		/// </param>  NO_MODIFICATION_ALLOWED_ERR: Raised if this property is
		///  readonly.
		///      </remarks>		<short>    A method to set the float value with a specified unit.</short>
		public void SetFloatValue(ushort unitType, float floatValue) {
			interceptor.Invoke("setFloatValue$$", "setFloatValue(unsigned short, float)", typeof(void), typeof(ushort), unitType, typeof(float), floatValue);
		}
		/// <remarks>
		///  This method is used to get a float value in a specified unit.
		///  If this CSS value doesn't contain a float value or can't be
		///  converted into the specified unit, a <code>DOMException</code>
		///  is raised.
		/// <param> name="unitType" A unit code to get the float value. The unit
		///  code can only be a float unit type (e.g. <code>CSS_NUMBER</code>
		///  , <code>CSS_PERCENTAGE</code> , <code>CSS_EMS</code>
		///  , <code>CSS_EXS</code> , <code>CSS_PX</code> ,
		///  <code>CSS_PX</code> , <code>CSS_CM</code> , <code>CSS_MM</code>
		///  , <code>CSS_IN</code> , <code>CSS_PT</code> ,
		///  <code>CSS_PC</code> , <code>CSS_DEG</code> , <code>CSS_RAD</code>
		///  , <code>CSS_GRAD</code> , <code>CSS_MS</code> ,
		///  <code>CSS_S</code> , <code>CSS_HZ</code> , <code>CSS_KHZ</code>
		///  , <code>CSS_DIMENSION</code> ).
		/// </param>     </remarks>		<return> The float value in the specified unit.
		/// </return>
		/// 		<short>    This method is used to get a float value in a specified unit.</short>
		public float GetFloatValue(ushort unitType) {
			return (float) interceptor.Invoke("getFloatValue$", "getFloatValue(unsigned short) const", typeof(float), typeof(ushort), unitType);
		}
		/// <remarks>
		///  A method to set the string value with a specified unit. If the
		///  property attached to this value can't accept the specified unit
		///  or the string value, the value will be unchanged and a
		///  <code>DOMException</code> will be raised.
		/// <param> name="stringType" A string code as defined above. The string
		///  code can only be a string unit type (e.g. <code>CSS_URI</code>
		///  , <code>CSS_IDENT</code> , <code>CSS_INHERIT</code>
		///  and <code>CSS_ATTR</code> ).
		/// </param><param> name="stringValue" The new string value. If the
		///  <code>stringType</code> is equal to <code>CSS_INHERIT</code> , the
		///  <code>stringValue</code> should be <code>inherit</code> .
		/// </param>  NO_MODIFICATION_ALLOWED_ERR: Raised if this property is
		///  readonly.
		///      </remarks>		<short>    A method to set the string value with a specified unit.</short>
		public void SetStringValue(ushort stringType, DOM.DOMString stringValue) {
			interceptor.Invoke("setStringValue$#", "setStringValue(unsigned short, const DOM::DOMString&)", typeof(void), typeof(ushort), stringType, typeof(DOM.DOMString), stringValue);
		}
		/// <remarks>
		///  This method is used to get the string value in a specified
		///  unit. If the CSS value doesn't contain a string value, a
		///  <code>DOMException</code> is raised.
		///      </remarks>		<return> The string value in the current unit. The current
		///  <code>valueType</code> can only be a string unit type (e.g.
		///  <code>CSS_URI</code> , <code>CSS_IDENT</code> and
		///  <code>CSS_ATTR</code> ).
		/// </return>
		/// 		<short>    This method is used to get the string value in a specified  unit.</short>
		public DOM.DOMString GetStringValue() {
			return (DOM.DOMString) interceptor.Invoke("getStringValue", "getStringValue() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  This method is used to get the Counter value. If this CSS value
		///  doesn't contain a counter value, a <code>DOMException</code>
		///  is raised. Modification to the corresponding style property can
		///  be achieved using the <code>Counter</code> interface.
		///      </remarks>		<return> The Counter value.
		/// </return>
		/// 		<short>    This method is used to get the Counter value.</short>
		public DOM.Counter GetCounterValue() {
			return (DOM.Counter) interceptor.Invoke("getCounterValue", "getCounterValue() const", typeof(DOM.Counter));
		}
		/// <remarks>
		///  This method is used to get the Rect value. If this CSS value
		///  doesn't contain a rect value, a <code>DOMException</code> is
		///  raised. Modification to the corresponding style property can be
		///  achieved using the <code>Rect</code> interface.
		///      </remarks>		<return> The Rect value.
		/// </return>
		/// 		<short>    This method is used to get the Rect value.</short>
		public DOM.Rect GetRectValue() {
			return (DOM.Rect) interceptor.Invoke("getRectValue", "getRectValue() const", typeof(DOM.Rect));
		}
		/// <remarks>
		///  This method is used to get the RGB color. If this CSS value
		///  doesn't contain a RGB color value, a <code>DOMException</code>
		///  is raised. Modification to the corresponding style
		///  property can be achieved using the <code>RGBColor</code>
		///  interface.
		///      </remarks>		<return> the RGB color value.
		/// </return>
		/// 		<short>    This method is used to get the RGB color.</short>
		public DOM.RGBColor GetRGBColorValue() {
			return (DOM.RGBColor) interceptor.Invoke("getRGBColorValue", "getRGBColorValue() const", typeof(DOM.RGBColor));
		}
		~CSSPrimitiveValue() {
			interceptor.Invoke("~CSSPrimitiveValue", "~CSSPrimitiveValue()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~CSSPrimitiveValue", "~CSSPrimitiveValue()", typeof(void));
		}
	}
}