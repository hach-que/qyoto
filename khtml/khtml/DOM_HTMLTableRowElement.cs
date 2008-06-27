//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  A row in a table. See the <a
	///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#edef-TR">
	///  TR element definition </a> in HTML 4.0.
	///  </remarks>		<short>    A row in a table.</short>
	[SmokeClass("DOM::HTMLTableRowElement")]
	public class HTMLTableRowElement : DOM.HTMLElement, IDisposable {
 		protected HTMLTableRowElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLTableRowElement), this);
		}
		// DOM::HTMLTableRowElement* HTMLTableRowElement(DOM::HTMLTableRowElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLTableRowElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableRowElement", "HTMLTableRowElement()", typeof(void));
		}
		public HTMLTableRowElement(DOM.HTMLTableRowElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableRowElement#", "HTMLTableRowElement(const DOM::HTMLTableRowElement&)", typeof(void), typeof(DOM.HTMLTableRowElement), other);
		}
		public HTMLTableRowElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableRowElement#", "HTMLTableRowElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  The index of this row, relative to the entire table.
		///  This is in logical order and not in document order.
		///  The rowIndex does take into account sections
		///  (THEAD, TFOOT or TBODY) within the table,
		///  placing THEAD rows first in the index, followed by
		///  TBODY rows, followed by TFOOT rows.
		///      </remarks>		<short>    The index of this row, relative to the entire table.</short>
		public long RowIndex() {
			return (long) interceptor.Invoke("rowIndex", "rowIndex() const", typeof(long));
		}
		/// <remarks>
		///  see rowIndex
		///  This function is obsolete - the rowIndex property is actually supposed to be read-only
		///  (http://www.w3.org/DOM/updates/REC-DOM-Level-1-19981001-errata.html)
		///      </remarks>		<short>    see rowIndex </short>
		public void SetRowIndex(long arg1) {
			interceptor.Invoke("setRowIndex$", "setRowIndex(long)", typeof(void), typeof(long), arg1);
		}
		/// <remarks>
		///  The index of this row, relative to the current section (
		///  <code>THEAD</code> , <code>TFOOT</code> , or <code>TBODY</code>
		///  ).
		///      </remarks>		<short>    The index of this row, relative to the current section (  <code>THEAD</code> , <code>TFOOT</code> , or <code>TBODY</code>  ).</short>
		public long SectionRowIndex() {
			return (long) interceptor.Invoke("sectionRowIndex", "sectionRowIndex() const", typeof(long));
		}
		/// <remarks>
		///  see sectionRowIndex
		///  This function is obsolete - the sectionRowIndex property is actually supposed to be read-only
		///  (http://www.w3.org/DOM/updates/REC-DOM-Level-1-19981001-errata.html)
		///      </remarks>		<short>    see sectionRowIndex </short>
		public void SetSectionRowIndex(long arg1) {
			interceptor.Invoke("setSectionRowIndex$", "setSectionRowIndex(long)", typeof(void), typeof(long), arg1);
		}
		/// <remarks>
		///  The collection of cells in this row.
		///      </remarks>		<short>    The collection of cells in this row.</short>
		public DOM.HTMLCollection Cells() {
			return (DOM.HTMLCollection) interceptor.Invoke("cells", "cells() const", typeof(DOM.HTMLCollection));
		}
		/// <remarks>
		///  see cells
		///  This function is obsolete - the cells property is actually supposed to be read-only
		///  (http://www.w3.org/DOM/updates/REC-DOM-Level-1-19981001-errata.html)
		///      </remarks>		<short>    see cells </short>
		public void SetCells(DOM.HTMLCollection arg1) {
			interceptor.Invoke("setCells#", "setCells(const DOM::HTMLCollection&)", typeof(void), typeof(DOM.HTMLCollection), arg1);
		}
		/// <remarks>
		///  Horizontal alignment of data within cells of this row. See the
		///  <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-align-TD">
		///  align attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Horizontal alignment of data within cells of this row.</short>
		public DOM.DOMString Align() {
			return (DOM.DOMString) interceptor.Invoke("align", "align() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see align
		///      </remarks>		<short>    see align      </short>
		public void SetAlign(DOM.DOMString arg1) {
			interceptor.Invoke("setAlign#", "setAlign(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Background color for rows. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#adef-bgcolor">
		///  bgcolor attribute definition </a> in HTML 4.0. This attribute
		///  is deprecated in HTML 4.0.
		///      </remarks>		<short>    Background color for rows.</short>
		public DOM.DOMString BgColor() {
			return (DOM.DOMString) interceptor.Invoke("bgColor", "bgColor() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see bgColor
		///      </remarks>		<short>    see bgColor      </short>
		public void SetBgColor(DOM.DOMString arg1) {
			interceptor.Invoke("setBgColor#", "setBgColor(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Alignment character for cells in a column. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-char">
		///  char attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Alignment character for cells in a column.</short>
		public DOM.DOMString Ch() {
			return (DOM.DOMString) interceptor.Invoke("ch", "ch() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see ch
		///      </remarks>		<short>    see ch      </short>
		public void SetCh(DOM.DOMString arg1) {
			interceptor.Invoke("setCh#", "setCh(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Offset of alignment character. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-charoff">
		///  charoff attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Offset of alignment character.</short>
		public DOM.DOMString ChOff() {
			return (DOM.DOMString) interceptor.Invoke("chOff", "chOff() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see chOff
		///      </remarks>		<short>    see chOff      </short>
		public void SetChOff(DOM.DOMString arg1) {
			interceptor.Invoke("setChOff#", "setChOff(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Vertical alignment of data within cells of this row. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-valign">
		///  valign attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Vertical alignment of data within cells of this row.</short>
		public DOM.DOMString VAlign() {
			return (DOM.DOMString) interceptor.Invoke("vAlign", "vAlign() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see vAlign
		///      </remarks>		<short>    see vAlign      </short>
		public void SetVAlign(DOM.DOMString arg1) {
			interceptor.Invoke("setVAlign#", "setVAlign(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Insert an empty <code>TD</code> cell into this row.
		///  If index is -1 or equal to the number of cells, the new
		///  cell is appended.
		/// <param> name="index" The place to insert the cell.
		/// </param>     </remarks>		<return> The newly created cell.
		/// </return>
		/// 		<short>    Insert an empty <code>TD</code> cell into this row.</short>
		public DOM.HTMLElement InsertCell(long index) {
			return (DOM.HTMLElement) interceptor.Invoke("insertCell$", "insertCell(long)", typeof(DOM.HTMLElement), typeof(long), index);
		}
		/// <remarks>
		///  Delete a cell from the current row.
		/// <param> name="index" The index of the cell to delete, starting from 0.
		///  If the index is -1 the last cell in the row is deleted.
		/// </param>     </remarks>		<short>    Delete a cell from the current row.</short>
		public void DeleteCell(long index) {
			interceptor.Invoke("deleteCell$", "deleteCell(long)", typeof(void), typeof(long), index);
		}
		~HTMLTableRowElement() {
			interceptor.Invoke("~HTMLTableRowElement", "~HTMLTableRowElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLTableRowElement", "~HTMLTableRowElement()", typeof(void));
		}
	}
}