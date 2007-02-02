//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QStandardItem")]
	public class QStandardItem : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QStandardItem(Type dummy) {}
		interface IQStandardItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStandardItem), this);
			_interceptor = (QStandardItem) realProxy.GetTransparentProxy();
		}
		private QStandardItem ProxyQStandardItem() {
			return (QStandardItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStandardItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStandardItemProxy), null);
			_staticInterceptor = (IQStandardItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQStandardItemProxy StaticQStandardItem() {
			return (IQStandardItemProxy) _staticInterceptor;
		}

		public enum ItemType {
			Type = 0,
			UserType = 1000,
		}
		public QStandardItem() : this((Type) null) {
			CreateProxy();
			NewQStandardItem();
		}
		[SmokeMethod("QStandardItem", "()")]
		private void NewQStandardItem() {
			ProxyQStandardItem().NewQStandardItem();
		}
		public QStandardItem(string text) : this((Type) null) {
			CreateProxy();
			NewQStandardItem(text);
		}
		[SmokeMethod("QStandardItem$", "(const QString&)")]
		private void NewQStandardItem(string text) {
			ProxyQStandardItem().NewQStandardItem(text);
		}
		public QStandardItem(QIcon icon, string text) : this((Type) null) {
			CreateProxy();
			NewQStandardItem(icon,text);
		}
		[SmokeMethod("QStandardItem##", "(const QIcon&, const QString&)")]
		private void NewQStandardItem(QIcon icon, string text) {
			ProxyQStandardItem().NewQStandardItem(icon,text);
		}
		public QStandardItem(int rows, int columns) : this((Type) null) {
			CreateProxy();
			NewQStandardItem(rows,columns);
		}
		[SmokeMethod("QStandardItem$$", "(int, int)")]
		private void NewQStandardItem(int rows, int columns) {
			ProxyQStandardItem().NewQStandardItem(rows,columns);
		}
		public QStandardItem(int rows) : this((Type) null) {
			CreateProxy();
			NewQStandardItem(rows);
		}
		[SmokeMethod("QStandardItem$", "(int)")]
		private void NewQStandardItem(int rows) {
			ProxyQStandardItem().NewQStandardItem(rows);
		}
		[SmokeMethod("data$", "(int) const")]
		public virtual QVariant Data(int role) {
			return ProxyQStandardItem().Data(role);
		}
		[SmokeMethod("data", "() const")]
		public virtual QVariant Data() {
			return ProxyQStandardItem().Data();
		}
		[SmokeMethod("setData##", "(const QVariant&, int)")]
		public virtual void SetData(QVariant value, int role) {
			ProxyQStandardItem().SetData(value,role);
		}
		[SmokeMethod("setData#", "(const QVariant&)")]
		public virtual void SetData(QVariant value) {
			ProxyQStandardItem().SetData(value);
		}
		[SmokeMethod("text", "() const")]
		public string Text() {
			return ProxyQStandardItem().Text();
		}
		[SmokeMethod("setText$", "(const QString&)")]
		public void SetText(string text) {
			ProxyQStandardItem().SetText(text);
		}
		[SmokeMethod("icon", "() const")]
		public QIcon Icon() {
			return ProxyQStandardItem().Icon();
		}
		[SmokeMethod("setIcon#", "(const QIcon&)")]
		public void SetIcon(QIcon icon) {
			ProxyQStandardItem().SetIcon(icon);
		}
		[SmokeMethod("toolTip", "() const")]
		public string ToolTip() {
			return ProxyQStandardItem().ToolTip();
		}
		[SmokeMethod("setToolTip$", "(const QString&)")]
		public void SetToolTip(string toolTip) {
			ProxyQStandardItem().SetToolTip(toolTip);
		}
		[SmokeMethod("statusTip", "() const")]
		public string StatusTip() {
			return ProxyQStandardItem().StatusTip();
		}
		[SmokeMethod("setStatusTip$", "(const QString&)")]
		public void SetStatusTip(string statusTip) {
			ProxyQStandardItem().SetStatusTip(statusTip);
		}
		[SmokeMethod("whatsThis", "() const")]
		public string WhatsThis() {
			return ProxyQStandardItem().WhatsThis();
		}
		[SmokeMethod("setWhatsThis$", "(const QString&)")]
		public void SetWhatsThis(string whatsThis) {
			ProxyQStandardItem().SetWhatsThis(whatsThis);
		}
		[SmokeMethod("sizeHint", "() const")]
		public QSize SizeHint() {
			return ProxyQStandardItem().SizeHint();
		}
		[SmokeMethod("setSizeHint#", "(const QSize&)")]
		public void SetSizeHint(QSize sizeHint) {
			ProxyQStandardItem().SetSizeHint(sizeHint);
		}
		[SmokeMethod("font", "() const")]
		public QFont Font() {
			return ProxyQStandardItem().Font();
		}
		[SmokeMethod("setFont#", "(const QFont&)")]
		public void SetFont(QFont font) {
			ProxyQStandardItem().SetFont(font);
		}
		[SmokeMethod("textAlignment", "() const")]
		public int TextAlignment() {
			return ProxyQStandardItem().TextAlignment();
		}
		[SmokeMethod("setTextAlignment$", "(Qt::Alignment)")]
		public void SetTextAlignment(int textAlignment) {
			ProxyQStandardItem().SetTextAlignment(textAlignment);
		}
		[SmokeMethod("background", "() const")]
		public QBrush Background() {
			return ProxyQStandardItem().Background();
		}
		[SmokeMethod("setBackground#", "(const QBrush&)")]
		public void SetBackground(QBrush brush) {
			ProxyQStandardItem().SetBackground(brush);
		}
		[SmokeMethod("foreground", "() const")]
		public QBrush Foreground() {
			return ProxyQStandardItem().Foreground();
		}
		[SmokeMethod("setForeground#", "(const QBrush&)")]
		public void SetForeground(QBrush brush) {
			ProxyQStandardItem().SetForeground(brush);
		}
		[SmokeMethod("checkState", "() const")]
		public Qt.CheckState CheckState() {
			return ProxyQStandardItem().CheckState();
		}
		[SmokeMethod("setCheckState$", "(Qt::CheckState)")]
		public void SetCheckState(Qt.CheckState checkState) {
			ProxyQStandardItem().SetCheckState(checkState);
		}
		[SmokeMethod("accessibleText", "() const")]
		public string AccessibleText() {
			return ProxyQStandardItem().AccessibleText();
		}
		[SmokeMethod("setAccessibleText$", "(const QString&)")]
		public void SetAccessibleText(string accessibleText) {
			ProxyQStandardItem().SetAccessibleText(accessibleText);
		}
		[SmokeMethod("accessibleDescription", "() const")]
		public string AccessibleDescription() {
			return ProxyQStandardItem().AccessibleDescription();
		}
		[SmokeMethod("setAccessibleDescription$", "(const QString&)")]
		public void SetAccessibleDescription(string accessibleDescription) {
			ProxyQStandardItem().SetAccessibleDescription(accessibleDescription);
		}
		[SmokeMethod("flags", "() const")]
		public int Flags() {
			return ProxyQStandardItem().Flags();
		}
		[SmokeMethod("setFlags$", "(Qt::ItemFlags)")]
		public void SetFlags(int flags) {
			ProxyQStandardItem().SetFlags(flags);
		}
		[SmokeMethod("isEnabled", "() const")]
		public bool IsEnabled() {
			return ProxyQStandardItem().IsEnabled();
		}
		[SmokeMethod("setEnabled$", "(bool)")]
		public void SetEnabled(bool enabled) {
			ProxyQStandardItem().SetEnabled(enabled);
		}
		[SmokeMethod("isEditable", "() const")]
		public bool IsEditable() {
			return ProxyQStandardItem().IsEditable();
		}
		[SmokeMethod("setEditable$", "(bool)")]
		public void SetEditable(bool editable) {
			ProxyQStandardItem().SetEditable(editable);
		}
		[SmokeMethod("isSelectable", "() const")]
		public bool IsSelectable() {
			return ProxyQStandardItem().IsSelectable();
		}
		[SmokeMethod("setSelectable$", "(bool)")]
		public void SetSelectable(bool selectable) {
			ProxyQStandardItem().SetSelectable(selectable);
		}
		[SmokeMethod("isCheckable", "() const")]
		public bool IsCheckable() {
			return ProxyQStandardItem().IsCheckable();
		}
		[SmokeMethod("setCheckable$", "(bool)")]
		public void SetCheckable(bool checkable) {
			ProxyQStandardItem().SetCheckable(checkable);
		}
		[SmokeMethod("isTristate", "() const")]
		public bool IsTristate() {
			return ProxyQStandardItem().IsTristate();
		}
		[SmokeMethod("setTristate$", "(bool)")]
		public void SetTristate(bool tristate) {
			ProxyQStandardItem().SetTristate(tristate);
		}
		[SmokeMethod("isDragEnabled", "() const")]
		public bool IsDragEnabled() {
			return ProxyQStandardItem().IsDragEnabled();
		}
		[SmokeMethod("setDragEnabled$", "(bool)")]
		public void SetDragEnabled(bool dragEnabled) {
			ProxyQStandardItem().SetDragEnabled(dragEnabled);
		}
		[SmokeMethod("isDropEnabled", "() const")]
		public bool IsDropEnabled() {
			return ProxyQStandardItem().IsDropEnabled();
		}
		[SmokeMethod("setDropEnabled$", "(bool)")]
		public void SetDropEnabled(bool dropEnabled) {
			ProxyQStandardItem().SetDropEnabled(dropEnabled);
		}
		[SmokeMethod("parent", "() const")]
		public QStandardItem Parent() {
			return ProxyQStandardItem().Parent();
		}
		[SmokeMethod("row", "() const")]
		public int Row() {
			return ProxyQStandardItem().Row();
		}
		[SmokeMethod("column", "() const")]
		public int Column() {
			return ProxyQStandardItem().Column();
		}
		[SmokeMethod("index", "() const")]
		public QModelIndex Index() {
			return ProxyQStandardItem().Index();
		}
		[SmokeMethod("model", "() const")]
		public QStandardItemModel Model() {
			return ProxyQStandardItem().Model();
		}
		[SmokeMethod("rowCount", "() const")]
		public int RowCount() {
			return ProxyQStandardItem().RowCount();
		}
		[SmokeMethod("setRowCount$", "(int)")]
		public void SetRowCount(int rows) {
			ProxyQStandardItem().SetRowCount(rows);
		}
		[SmokeMethod("columnCount", "() const")]
		public int ColumnCount() {
			return ProxyQStandardItem().ColumnCount();
		}
		[SmokeMethod("setColumnCount$", "(int)")]
		public void SetColumnCount(int columns) {
			ProxyQStandardItem().SetColumnCount(columns);
		}
		[SmokeMethod("hasChildren", "() const")]
		public bool HasChildren() {
			return ProxyQStandardItem().HasChildren();
		}
		[SmokeMethod("child$$", "(int, int) const")]
		public QStandardItem Child(int row, int column) {
			return ProxyQStandardItem().Child(row,column);
		}
		[SmokeMethod("child$", "(int) const")]
		public QStandardItem Child(int row) {
			return ProxyQStandardItem().Child(row);
		}
		[SmokeMethod("setChild$$$", "(int, int, QStandardItem*)")]
		public void SetChild(int row, int column, QStandardItem item) {
			ProxyQStandardItem().SetChild(row,column,item);
		}
		[SmokeMethod("setChild$$", "(int, QStandardItem*)")]
		public void SetChild(int row, QStandardItem item) {
			ProxyQStandardItem().SetChild(row,item);
		}
		[SmokeMethod("insertRow$$", "(int, const QList<QStandardItem*>&)")]
		public void InsertRow(int row, List<QStandardItem> items) {
			ProxyQStandardItem().InsertRow(row,items);
		}
		[SmokeMethod("insertColumn$$", "(int, const QList<QStandardItem*>&)")]
		public void InsertColumn(int column, List<QStandardItem> items) {
			ProxyQStandardItem().InsertColumn(column,items);
		}
		[SmokeMethod("insertRows$$", "(int, int)")]
		public void InsertRows(int row, int count) {
			ProxyQStandardItem().InsertRows(row,count);
		}
		[SmokeMethod("insertColumns$$", "(int, int)")]
		public void InsertColumns(int column, int count) {
			ProxyQStandardItem().InsertColumns(column,count);
		}
		[SmokeMethod("removeRow$", "(int)")]
		public void RemoveRow(int row) {
			ProxyQStandardItem().RemoveRow(row);
		}
		[SmokeMethod("removeColumn$", "(int)")]
		public void RemoveColumn(int column) {
			ProxyQStandardItem().RemoveColumn(column);
		}
		[SmokeMethod("removeRows$$", "(int, int)")]
		public void RemoveRows(int row, int count) {
			ProxyQStandardItem().RemoveRows(row,count);
		}
		[SmokeMethod("removeColumns$$", "(int, int)")]
		public void RemoveColumns(int column, int count) {
			ProxyQStandardItem().RemoveColumns(column,count);
		}
		[SmokeMethod("appendRow?", "(const QList<QStandardItem*>&)")]
		public void AppendRow(List<QStandardItem> items) {
			ProxyQStandardItem().AppendRow(items);
		}
		[SmokeMethod("appendColumn?", "(const QList<QStandardItem*>&)")]
		public void AppendColumn(List<QStandardItem> items) {
			ProxyQStandardItem().AppendColumn(items);
		}
		[SmokeMethod("insertRow$$", "(int, QStandardItem*)")]
		public void InsertRow(int row, QStandardItem item) {
			ProxyQStandardItem().InsertRow(row,item);
		}
		[SmokeMethod("appendRow#", "(QStandardItem*)")]
		public void AppendRow(QStandardItem item) {
			ProxyQStandardItem().AppendRow(item);
		}
		[SmokeMethod("takeChild$$", "(int, int)")]
		public QStandardItem TakeChild(int row, int column) {
			return ProxyQStandardItem().TakeChild(row,column);
		}
		[SmokeMethod("takeChild$", "(int)")]
		public QStandardItem TakeChild(int row) {
			return ProxyQStandardItem().TakeChild(row);
		}
		[SmokeMethod("takeRow$", "(int)")]
		public List<QStandardItem> TakeRow(int row) {
			return ProxyQStandardItem().TakeRow(row);
		}
		[SmokeMethod("takeColumn$", "(int)")]
		public List<QStandardItem> TakeColumn(int column) {
			return ProxyQStandardItem().TakeColumn(column);
		}
		[SmokeMethod("sortChildren$$", "(int, Qt::SortOrder)")]
		public void SortChildren(int column, Qt.SortOrder order) {
			ProxyQStandardItem().SortChildren(column,order);
		}
		[SmokeMethod("sortChildren$", "(int)")]
		public void SortChildren(int column) {
			ProxyQStandardItem().SortChildren(column);
		}
		[SmokeMethod("clone", "() const")]
		public virtual QStandardItem Clone() {
			return ProxyQStandardItem().Clone();
		}
		[SmokeMethod("type", "() const")]
		public virtual int type() {
			return ProxyQStandardItem().type();
		}
		[SmokeMethod("read#", "(QDataStream&)")]
		public virtual void Read(QDataStream arg1) {
			ProxyQStandardItem().Read(arg1);
		}
		[SmokeMethod("write#", "(QDataStream&) const")]
		public virtual void Write(QDataStream arg1) {
			ProxyQStandardItem().Write(arg1);
		}
		public QStandardItem(QStandardItem other) : this((Type) null) {
			CreateProxy();
			NewQStandardItem(other);
		}
		[SmokeMethod("QStandardItem#", "(const QStandardItem&)")]
		private void NewQStandardItem(QStandardItem other) {
			ProxyQStandardItem().NewQStandardItem(other);
		}
		// QStandardItem* QStandardItem(QStandardItemPrivate& arg1); >>>> NOT CONVERTED
		~QStandardItem() {
			DisposeQStandardItem();
		}
		public void Dispose() {
			DisposeQStandardItem();
		}
		[SmokeMethod("~QStandardItem", "()")]
		private void DisposeQStandardItem() {
			ProxyQStandardItem().DisposeQStandardItem();
		}
	}
}
