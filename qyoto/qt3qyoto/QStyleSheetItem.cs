//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QStyleSheetItem : Qt, IDisposable {
 		protected QStyleSheetItem(Type dummy) : base((Type) null) {}
		interface IQStyleSheetItemProxy {
		}

		protected void CreateQStyleSheetItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleSheetItem), this);
			_interceptor = (QStyleSheetItem) realProxy.GetTransparentProxy();
		}
		private QStyleSheetItem ProxyQStyleSheetItem() {
			return (QStyleSheetItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleSheetItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleSheetItemProxy), null);
			_staticInterceptor = (IQStyleSheetItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleSheetItemProxy StaticQStyleSheetItem() {
			return (IQStyleSheetItemProxy) _staticInterceptor;
		}

		enum AdditionalStyleValues {
			Undefined = -1,
		}
		enum E_DisplayMode {
			DisplayBlock = 0,
			DisplayInline = 1,
			DisplayListItem = 2,
			DisplayNone = 3,
			DisplayModeUndefined = -1,
		}
		enum E_VerticalAlignment {
			VAlignBaseline = 0,
			VAlignSub = 1,
			VAlignSuper = 2,
		}
		enum E_WhiteSpaceMode {
			WhiteSpaceNormal = 0,
			WhiteSpacePre = 1,
			WhiteSpaceNoWrap = 2,
			WhiteSpaceModeUndefined = -1,
		}
		enum E_Margin {
			MarginLeft = 0,
			MarginRight = 1,
			MarginTop = 2,
			MarginBottom = 3,
			MarginFirstLine = 4,
			MarginAll = 5,
			MarginVertical = 6,
			MarginHorizontal = 7,
			MarginUndefined = -1,
		}
		enum E_ListStyle {
			ListDisc = 0,
			ListCircle = 1,
			ListSquare = 2,
			ListDecimal = 3,
			ListLowerAlpha = 4,
			ListUpperAlpha = 5,
			ListStyleUndefined = -1,
		}
		public QStyleSheetItem(QStyleSheet parent, string name) : this((Type) null) {
			CreateQStyleSheetItemProxy();
			NewQStyleSheetItem(parent,name);
		}
		[SmokeMethod("QStyleSheetItem(QStyleSheet*, const QString&)")]
		private void NewQStyleSheetItem(QStyleSheet parent, string name) {
			ProxyQStyleSheetItem().NewQStyleSheetItem(parent,name);
		}
		public QStyleSheetItem(QStyleSheetItem arg1) : this((Type) null) {
			CreateQStyleSheetItemProxy();
			NewQStyleSheetItem(arg1);
		}
		[SmokeMethod("QStyleSheetItem(const QStyleSheetItem&)")]
		private void NewQStyleSheetItem(QStyleSheetItem arg1) {
			ProxyQStyleSheetItem().NewQStyleSheetItem(arg1);
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQStyleSheetItem().Name();
		}
		[SmokeMethod("styleSheet()")]
		public QStyleSheet StyleSheet() {
			return ProxyQStyleSheetItem().StyleSheet();
		}
		[SmokeMethod("displayMode() const")]
		public int DisplayMode() {
			return ProxyQStyleSheetItem().DisplayMode();
		}
		[SmokeMethod("setDisplayMode(QStyleSheetItem::DisplayMode)")]
		public void SetDisplayMode(int m) {
			ProxyQStyleSheetItem().SetDisplayMode(m);
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQStyleSheetItem().Alignment();
		}
		[SmokeMethod("setAlignment(int)")]
		public void SetAlignment(int f) {
			ProxyQStyleSheetItem().SetAlignment(f);
		}
		[SmokeMethod("verticalAlignment() const")]
		public int VerticalAlignment() {
			return ProxyQStyleSheetItem().VerticalAlignment();
		}
		[SmokeMethod("setVerticalAlignment(QStyleSheetItem::VerticalAlignment)")]
		public void SetVerticalAlignment(int valign) {
			ProxyQStyleSheetItem().SetVerticalAlignment(valign);
		}
		[SmokeMethod("fontWeight() const")]
		public int FontWeight() {
			return ProxyQStyleSheetItem().FontWeight();
		}
		[SmokeMethod("setFontWeight(int)")]
		public void SetFontWeight(int w) {
			ProxyQStyleSheetItem().SetFontWeight(w);
		}
		[SmokeMethod("logicalFontSize() const")]
		public int LogicalFontSize() {
			return ProxyQStyleSheetItem().LogicalFontSize();
		}
		[SmokeMethod("setLogicalFontSize(int)")]
		public void SetLogicalFontSize(int s) {
			ProxyQStyleSheetItem().SetLogicalFontSize(s);
		}
		[SmokeMethod("logicalFontSizeStep() const")]
		public int LogicalFontSizeStep() {
			return ProxyQStyleSheetItem().LogicalFontSizeStep();
		}
		[SmokeMethod("setLogicalFontSizeStep(int)")]
		public void SetLogicalFontSizeStep(int s) {
			ProxyQStyleSheetItem().SetLogicalFontSizeStep(s);
		}
		[SmokeMethod("fontSize() const")]
		public int FontSize() {
			return ProxyQStyleSheetItem().FontSize();
		}
		[SmokeMethod("setFontSize(int)")]
		public void SetFontSize(int s) {
			ProxyQStyleSheetItem().SetFontSize(s);
		}
		[SmokeMethod("fontFamily() const")]
		public string FontFamily() {
			return ProxyQStyleSheetItem().FontFamily();
		}
		[SmokeMethod("setFontFamily(const QString&)")]
		public void SetFontFamily(string arg1) {
			ProxyQStyleSheetItem().SetFontFamily(arg1);
		}
		[SmokeMethod("numberOfColumns() const")]
		public int NumberOfColumns() {
			return ProxyQStyleSheetItem().NumberOfColumns();
		}
		[SmokeMethod("setNumberOfColumns(int)")]
		public void SetNumberOfColumns(int ncols) {
			ProxyQStyleSheetItem().SetNumberOfColumns(ncols);
		}
		[SmokeMethod("color() const")]
		public QColor Color() {
			return ProxyQStyleSheetItem().Color();
		}
		[SmokeMethod("setColor(const QColor&)")]
		public void SetColor(QColor arg1) {
			ProxyQStyleSheetItem().SetColor(arg1);
		}
		[SmokeMethod("fontItalic() const")]
		public bool FontItalic() {
			return ProxyQStyleSheetItem().FontItalic();
		}
		[SmokeMethod("setFontItalic(bool)")]
		public void SetFontItalic(bool arg1) {
			ProxyQStyleSheetItem().SetFontItalic(arg1);
		}
		[SmokeMethod("definesFontItalic() const")]
		public bool DefinesFontItalic() {
			return ProxyQStyleSheetItem().DefinesFontItalic();
		}
		[SmokeMethod("fontUnderline() const")]
		public bool FontUnderline() {
			return ProxyQStyleSheetItem().FontUnderline();
		}
		[SmokeMethod("setFontUnderline(bool)")]
		public void SetFontUnderline(bool arg1) {
			ProxyQStyleSheetItem().SetFontUnderline(arg1);
		}
		[SmokeMethod("definesFontUnderline() const")]
		public bool DefinesFontUnderline() {
			return ProxyQStyleSheetItem().DefinesFontUnderline();
		}
		[SmokeMethod("fontStrikeOut() const")]
		public bool FontStrikeOut() {
			return ProxyQStyleSheetItem().FontStrikeOut();
		}
		[SmokeMethod("setFontStrikeOut(bool)")]
		public void SetFontStrikeOut(bool arg1) {
			ProxyQStyleSheetItem().SetFontStrikeOut(arg1);
		}
		[SmokeMethod("definesFontStrikeOut() const")]
		public bool DefinesFontStrikeOut() {
			return ProxyQStyleSheetItem().DefinesFontStrikeOut();
		}
		[SmokeMethod("isAnchor() const")]
		public bool IsAnchor() {
			return ProxyQStyleSheetItem().IsAnchor();
		}
		[SmokeMethod("setAnchor(bool)")]
		public void SetAnchor(bool anc) {
			ProxyQStyleSheetItem().SetAnchor(anc);
		}
		[SmokeMethod("whiteSpaceMode() const")]
		public int WhiteSpaceMode() {
			return ProxyQStyleSheetItem().WhiteSpaceMode();
		}
		[SmokeMethod("setWhiteSpaceMode(QStyleSheetItem::WhiteSpaceMode)")]
		public void SetWhiteSpaceMode(int m) {
			ProxyQStyleSheetItem().SetWhiteSpaceMode(m);
		}
		[SmokeMethod("margin(QStyleSheetItem::Margin) const")]
		public int Margin(int m) {
			return ProxyQStyleSheetItem().Margin(m);
		}
		[SmokeMethod("setMargin(QStyleSheetItem::Margin, int)")]
		public void SetMargin(int arg1, int arg2) {
			ProxyQStyleSheetItem().SetMargin(arg1,arg2);
		}
		[SmokeMethod("listStyle() const")]
		public int ListStyle() {
			return ProxyQStyleSheetItem().ListStyle();
		}
		[SmokeMethod("setListStyle(QStyleSheetItem::ListStyle)")]
		public void SetListStyle(int arg1) {
			ProxyQStyleSheetItem().SetListStyle(arg1);
		}
		[SmokeMethod("contexts() const")]
		public string Contexts() {
			return ProxyQStyleSheetItem().Contexts();
		}
		[SmokeMethod("setContexts(const QString&)")]
		public void SetContexts(string arg1) {
			ProxyQStyleSheetItem().SetContexts(arg1);
		}
		[SmokeMethod("allowedInContext(const QStyleSheetItem*) const")]
		public bool AllowedInContext(QStyleSheetItem arg1) {
			return ProxyQStyleSheetItem().AllowedInContext(arg1);
		}
		[SmokeMethod("selfNesting() const")]
		public bool SelfNesting() {
			return ProxyQStyleSheetItem().SelfNesting();
		}
		[SmokeMethod("setSelfNesting(bool)")]
		public void SetSelfNesting(bool arg1) {
			ProxyQStyleSheetItem().SetSelfNesting(arg1);
		}
		[SmokeMethod("setLineSpacing(int)")]
		public void SetLineSpacing(int ls) {
			ProxyQStyleSheetItem().SetLineSpacing(ls);
		}
		[SmokeMethod("lineSpacing() const")]
		public int LineSpacing() {
			return ProxyQStyleSheetItem().LineSpacing();
		}
		~QStyleSheetItem() {
			DisposeQStyleSheetItem();
		}
		public void Dispose() {
			DisposeQStyleSheetItem();
		}
		private void DisposeQStyleSheetItem() {
			ProxyQStyleSheetItem().DisposeQStyleSheetItem();
		}
	}
}