//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	[SmokeClass("Plasma::PanelSvg")]
	public class PanelSvg : Plasma.Svg, IDisposable {
 		protected PanelSvg(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(PanelSvg), this);
		}
		/// <remarks>
		///  These flags represents what borders should be drawn
		///          </remarks>		<short>    These flags represents what borders should be drawn          </short>
		public enum EnabledBorder {
			NoBorder = 0,
			TopBorder = 1,
			BottomBorder = 2,
			LeftBorder = 4,
			RightBorder = 8,
			AllBorders = TopBorder|BottomBorder|LeftBorder|RightBorder,
		}
		/// <remarks>
		///  Constructs a new PanelSvg that paints the proper named subelements
		///  as borders. It may also be used as a regular Plasma.Svg object
		///  for direct access to elements in the Svg.
		///  @arg parent options QObject to parent this to
		///  @related Plasma.Theme
		///          </remarks>		<short>    Constructs a new PanelSvg that paints the proper named subelements  as borders.</short>
		public PanelSvg(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("PanelSvg#", "PanelSvg(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public PanelSvg() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("PanelSvg", "PanelSvg()", typeof(void));
		}
		/// <remarks>
		///  Loads a new Svg
		///  @arg imagePath the new file
		///          </remarks>		<short>    Loads a new Svg  @arg imagePath the new file          </short>
		public void SetImagePath(string path) {
			interceptor.Invoke("setImagePath$", "setImagePath(const QString&)", typeof(void), typeof(string), path);
		}
		/// <remarks>
		///  Sets what borders should be painted
		///  @arg flags borders we want to paint
		///          </remarks>		<short>    Sets what borders should be painted  @arg flags borders we want to paint          </short>
		public void SetEnabledBorders(uint borders) {
			interceptor.Invoke("setEnabledBorders$", "setEnabledBorders(const Plasma::PanelSvg::EnabledBorders)", typeof(void), typeof(uint), borders);
		}
		/// <remarks>
		///  Convenience method to get the enabled borders
		/// </remarks>		<return> what borders are painted
		///          </return>
		/// 		<short>    Convenience method to get the enabled borders </short>
		public uint EnabledBorders() {
			return (uint) interceptor.Invoke("enabledBorders", "enabledBorders() const", typeof(uint));
		}
		/// <remarks>
		///  Resize the panel maintaining the same border size
		///  @arg size the new size of the panel
		///          </remarks>		<short>    Resize the panel maintaining the same border size  @arg size the new size of the panel          </short>
		public void ResizePanel(QSizeF size) {
			interceptor.Invoke("resizePanel#", "resizePanel(const QSizeF&)", typeof(void), typeof(QSizeF), size);
		}
		/// <remarks>
		/// </remarks>		<return> the size of the panel
		///          </return>
		/// 		<short>   </short>
		public QSizeF PanelSize() {
			return (QSizeF) interceptor.Invoke("panelSize", "panelSize() const", typeof(QSizeF));
		}
		/// <remarks>
		///  Returns the margin size given the margin edge we want
		///  @arg edge the margin edge we want, top, bottom, left or right
		/// </remarks>		<return> the margin size
		///          </return>
		/// 		<short>    Returns the margin size given the margin edge we want  @arg edge the margin edge we want, top, bottom, left or right </short>
		public double MarginSize(Plasma.MarginEdge edge) {
			return (double) interceptor.Invoke("marginSize$", "marginSize(const Plasma::MarginEdge) const", typeof(double), typeof(Plasma.MarginEdge), edge);
		}
		/// <remarks>
		///  Convenience method that extracts the size of the four margins
		///  in the four output parameters
		///  @arg left left margin size
		///  @arg top top margin size
		///  @arg right right margin size
		///  @arg bottom bottom margin size
		///          </remarks>		<short>    Convenience method that extracts the size of the four margins  in the four output parameters  @arg left left margin size  @arg top top margin size  @arg right right margin size  @arg bottom bottom margin size          </short>
		public void GetMargins(ref double left, ref double top, ref double right, ref double bottom) {
			StackItem[] stack = new StackItem[5];
			stack[1].s_double = left;
			stack[2].s_double = top;
			stack[3].s_double = right;
			stack[4].s_double = bottom;
			interceptor.Invoke("getMargins$$$$", "getMargins(qreal&, qreal&, qreal&, qreal&) const", stack);
			left = stack[1].s_double;
			top = stack[2].s_double;
			right = stack[3].s_double;
			bottom = stack[4].s_double;
			return;
		}
		/// <remarks>
		///  Sets the prefix (@see setElementPrefix) to 'north', 'south', 'west' and 'east'
		///  when the location is TopEdge, BottomEdge, LeftEdge and RightEdge,
		///  respectively. Clears the prefix in other cases.
		///  @arg location location
		///          </remarks>		<short>    Sets the prefix (@see setElementPrefix) to 'north', 'south', 'west' and 'east'  when the location is TopEdge, BottomEdge, LeftEdge and RightEdge,  respectively.</short>
		public void SetElementPrefix(Plasma.Location location) {
			interceptor.Invoke("setElementPrefix$", "setElementPrefix(Plasma::Location)", typeof(void), typeof(Plasma.Location), location);
		}
		/// <remarks>
		///  Sets the prefix for the SVG elements to be used for painting. For example,
		///  if prefix is 'active', then instead of using the 'top' element of the SVG
		///  file to paint the top border, 'active-top' element will be used. The same
		///  goes for other SVG elements.
		///  If the elements with prefixes are not present, the default ones are used.
		///  (for the sake of speed, the test is present only for the 'center' element)
		///  Setting the prefix manually resets the location to Floating.
		///  If the
		///  @arg prefix prefix for the SVG element names
		///          </remarks>		<short>    Sets the prefix for the SVG elements to be used for painting.</short>
		public void SetElementPrefix(string prefix) {
			interceptor.Invoke("setElementPrefix$", "setElementPrefix(const QString&)", typeof(void), typeof(string), prefix);
		}
		/// <remarks>
		/// </remarks>		<return> true if the svg has the necessary elements with the given prefix
		///  to draw a panel
		///  @arg prefix the given prefix we want to check if drawable
		///          </return>
		/// 		<short>   </short>
		public bool HasElementPrefix(string prefix) {
			return (bool) interceptor.Invoke("hasElementPrefix$", "hasElementPrefix(const QString&) const", typeof(bool), typeof(string), prefix);
		}
		/// <remarks>
		///  This is an overloaded method provided for convenience equivalent to 
		///  hasElementPrefix("north"), hasElementPrefix("south")
		///  hasElementPrefix("west") and hasElementPrefix("east")
		/// </remarks>		<return> true if the svg has the necessary elements with the given prefix
		///  to draw a panel.
		///  @arg location the given prefix we want to check if drawable
		///          </return>
		/// 		<short>    This is an overloaded method provided for convenience equivalent to   hasElementPrefix("north"), hasElementPrefix("south")  hasElementPrefix("west") and hasElementPrefix("east") </short>
		public bool HasElementPrefix(Plasma.Location location) {
			return (bool) interceptor.Invoke("hasElementPrefix$", "hasElementPrefix(Plasma::Location) const", typeof(bool), typeof(Plasma.Location), location);
		}
		/// <remarks>
		///  Returns the prefix for SVG elements of the PanelSvg
		/// </remarks>		<return> the prefix
		///          </return>
		/// 		<short>    Returns the prefix for SVG elements of the PanelSvg </short>
		public string Prefix() {
			return (string) interceptor.Invoke("prefix", "prefix()", typeof(string));
		}
		/// <remarks>
		///  Returns a monochrome mask that tightly contains the fully opaque areas of the svg
		/// </remarks>		<return> a monochrome bitmap of opaque areas
		///          </return>
		/// 		<short>    Returns a monochrome mask that tightly contains the fully opaque areas of the svg </short>
		public QBitmap Mask() {
			return (QBitmap) interceptor.Invoke("mask", "mask() const", typeof(QBitmap));
		}
		/// <remarks>
		///  Sets whether saving all the rendered prefixes in a cache or not
		///  @arg cache if use the cache or not
		///         </remarks>		<short>    Sets whether saving all the rendered prefixes in a cache or not  @arg cache if use the cache or not         </short>
		public void SetCacheAllRenderedPanels(bool cache) {
			interceptor.Invoke("setCacheAllRenderedPanels$", "setCacheAllRenderedPanels(bool)", typeof(void), typeof(bool), cache);
		}
		/// <remarks>
		/// </remarks>		<return> if all the different prefixes should be kept in a cache when rendered
		///         </return>
		/// 		<short>   </short>
		public bool CacheAllRenderedPanels() {
			return (bool) interceptor.Invoke("cacheAllRenderedPanels", "cacheAllRenderedPanels() const", typeof(bool));
		}
		/// <remarks>
		///  Deletes the internal cache freeing memory: use this if you want to switch the rendered 
		///  element and you don't plan to switch back to the previous one for a long time and you
		///  used setUseCache(true)
		///         </remarks>		<short>    Deletes the internal cache freeing memory: use this if you want to switch the rendered   element and you don't plan to switch back to the previous one for a long time and you  used setUseCache(true)         </short>
		public void ClearCache() {
			interceptor.Invoke("clearCache", "clearCache()", typeof(void));
		}
		/// <remarks>
		///  Paints the loaded SVG with the elements that represents the border
		///  @arg painter the QPainter to use
		///  @arg rect the exposed rect to draw into
		///          </remarks>		<short>    Paints the loaded SVG with the elements that represents the border  @arg painter the QPainter to use  @arg rect the exposed rect to draw into          </short>
		public void PaintPanel(QPainter painter, QRectF rect, QPointF pos) {
			interceptor.Invoke("paintPanel###", "paintPanel(QPainter*, const QRectF&, const QPointF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect, typeof(QPointF), pos);
		}
		public void PaintPanel(QPainter painter, QRectF rect) {
			interceptor.Invoke("paintPanel##", "paintPanel(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect);
		}
		~PanelSvg() {
			interceptor.Invoke("~PanelSvg", "~PanelSvg()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~PanelSvg", "~PanelSvg()", typeof(void));
		}
		protected new IPanelSvgSignals Emit {
			get { return (IPanelSvgSignals) Q_EMIT; }
		}
	}

	public interface IPanelSvgSignals : Plasma.ISvgSignals {
	}
}
