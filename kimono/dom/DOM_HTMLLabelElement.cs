//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	namespace DOM {

	using System;
	using Qyoto;

	/// <remarks>
	///  Form field label text. See the <a
	///  href="http://www.w3.org/TR/REC-html40/interact/forms.html#edef-LABEL">
	///  LABEL element definition </a> in HTML 4.0.
	///  </remarks>		<short>    Form field label text.</short>

	[SmokeClass("DOM::HTMLLabelElement")]
	public class HTMLLabelElement : DOM.HTMLElement, IDisposable {
 		protected HTMLLabelElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLLabelElement), this);
		}
		// DOM::HTMLLabelElement* HTMLLabelElement(DOM::HTMLLabelElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLLabelElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLLabelElement", "HTMLLabelElement()", typeof(void));
		}
		public HTMLLabelElement(DOM.HTMLLabelElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLLabelElement#", "HTMLLabelElement(const DOM::HTMLLabelElement&)", typeof(void), typeof(DOM.HTMLLabelElement), other);
		}
		public HTMLLabelElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLLabelElement#", "HTMLLabelElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  A single character access key to give access to the form
		///  control. See the <a
		///  href="http://www.w3.org/TR/REC-html40/interact/forms.html#adef-accesskey">
		///  accesskey attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    A single character access key to give access to the form  control.</short>
		public string AccessKey() {
			return (string) interceptor.Invoke("accessKey", "accessKey() const", typeof(string));
		}
		/// <remarks>
		///  see accessKey
		///      </remarks>		<short>    see accessKey      </short>
		public void SetAccessKey(string arg1) {
			interceptor.Invoke("setAccessKey#", "setAccessKey(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  This attribute links this label with another form control by
		///  <code>id</code> attribute. See the <a
		///  href="http://www.w3.org/TR/REC-html40/interact/forms.html#adef-for">
		///  for attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    This attribute links this label with another form control by  <code>id</code> attribute.</short>
		public string HtmlFor() {
			return (string) interceptor.Invoke("htmlFor", "htmlFor() const", typeof(string));
		}
		/// <remarks>
		///  see htmlFor
		///      </remarks>		<short>    see htmlFor      </short>
		public void SetHtmlFor(string arg1) {
			interceptor.Invoke("setHtmlFor#", "setHtmlFor(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		~HTMLLabelElement() {
			interceptor.Invoke("~HTMLLabelElement", "~HTMLLabelElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLLabelElement", "~HTMLLabelElement()", typeof(void));
		}
	}
	}
}