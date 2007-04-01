//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTreeWidgetItem")]
	public class QTreeWidgetItem : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QTreeWidgetItem(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTreeWidgetItem), "QTreeWidgetItem", this);
		}
		public enum ItemType {
			Type = 0,
			UserType = 1000,
		}
		public QTreeWidgetItem(int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem$", "QTreeWidgetItem(int)", typeof(void), typeof(int), type);
		}
		public QTreeWidgetItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem", "QTreeWidgetItem()", typeof(void));
		}
		public QTreeWidgetItem(List<string> strings, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem?$", "QTreeWidgetItem(const QStringList&, int)", typeof(void), typeof(List<string>), strings, typeof(int), type);
		}
		public QTreeWidgetItem(List<string> strings) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem?", "QTreeWidgetItem(const QStringList&)", typeof(void), typeof(List<string>), strings);
		}
		public QTreeWidgetItem(QTreeWidget view, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#$", "QTreeWidgetItem(QTreeWidget*, int)", typeof(void), typeof(QTreeWidget), view, typeof(int), type);
		}
		public QTreeWidgetItem(QTreeWidget view) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#", "QTreeWidgetItem(QTreeWidget*)", typeof(void), typeof(QTreeWidget), view);
		}
		public QTreeWidgetItem(QTreeWidget view, List<string> strings, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#?$", "QTreeWidgetItem(QTreeWidget*, const QStringList&, int)", typeof(void), typeof(QTreeWidget), view, typeof(List<string>), strings, typeof(int), type);
		}
		public QTreeWidgetItem(QTreeWidget view, List<string> strings) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#?", "QTreeWidgetItem(QTreeWidget*, const QStringList&)", typeof(void), typeof(QTreeWidget), view, typeof(List<string>), strings);
		}
		public QTreeWidgetItem(QTreeWidget view, QTreeWidgetItem after, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem##$", "QTreeWidgetItem(QTreeWidget*, QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidget), view, typeof(QTreeWidgetItem), after, typeof(int), type);
		}
		public QTreeWidgetItem(QTreeWidget view, QTreeWidgetItem after) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem##", "QTreeWidgetItem(QTreeWidget*, QTreeWidgetItem*)", typeof(void), typeof(QTreeWidget), view, typeof(QTreeWidgetItem), after);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#$", "QTreeWidgetItem(QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), parent, typeof(int), type);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#", "QTreeWidgetItem(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), parent);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, List<string> strings, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#?$", "QTreeWidgetItem(QTreeWidgetItem*, const QStringList&, int)", typeof(void), typeof(QTreeWidgetItem), parent, typeof(List<string>), strings, typeof(int), type);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, List<string> strings) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem#?", "QTreeWidgetItem(QTreeWidgetItem*, const QStringList&)", typeof(void), typeof(QTreeWidgetItem), parent, typeof(List<string>), strings);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, QTreeWidgetItem after, int type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem##$", "QTreeWidgetItem(QTreeWidgetItem*, QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), parent, typeof(QTreeWidgetItem), after, typeof(int), type);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, QTreeWidgetItem after) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTreeWidgetItem##", "QTreeWidgetItem(QTreeWidgetItem*, QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), parent, typeof(QTreeWidgetItem), after);
		}
		[SmokeMethod("clone() const")]
		public virtual QTreeWidgetItem Clone() {
			return (QTreeWidgetItem) interceptor.Invoke("clone", "clone() const", typeof(QTreeWidgetItem));
		}
		public QTreeWidget TreeWidget() {
			return (QTreeWidget) interceptor.Invoke("treeWidget", "treeWidget() const", typeof(QTreeWidget));
		}
		public void SetSelected(bool select) {
			interceptor.Invoke("setSelected$", "setSelected(bool)", typeof(void), typeof(bool), select);
		}
		public bool IsSelected() {
			return (bool) interceptor.Invoke("isSelected", "isSelected() const", typeof(bool));
		}
		public void SetHidden(bool hide) {
			interceptor.Invoke("setHidden$", "setHidden(bool)", typeof(void), typeof(bool), hide);
		}
		public bool IsHidden() {
			return (bool) interceptor.Invoke("isHidden", "isHidden() const", typeof(bool));
		}
		public void SetExpanded(bool expand) {
			interceptor.Invoke("setExpanded$", "setExpanded(bool)", typeof(void), typeof(bool), expand);
		}
		public bool IsExpanded() {
			return (bool) interceptor.Invoke("isExpanded", "isExpanded() const", typeof(bool));
		}
		public int Flags() {
			return (int) interceptor.Invoke("flags", "flags() const", typeof(int));
		}
		public void SetFlags(int flags) {
			interceptor.Invoke("setFlags$", "setFlags(Qt::ItemFlags)", typeof(void), typeof(int), flags);
		}
		public string Text(int column) {
			return (string) interceptor.Invoke("text$", "text(int) const", typeof(string), typeof(int), column);
		}
		public void SetText(int column, string text) {
			interceptor.Invoke("setText$$", "setText(int, const QString&)", typeof(void), typeof(int), column, typeof(string), text);
		}
		public QIcon Icon(int column) {
			return (QIcon) interceptor.Invoke("icon$", "icon(int) const", typeof(QIcon), typeof(int), column);
		}
		public void SetIcon(int column, QIcon icon) {
			interceptor.Invoke("setIcon$#", "setIcon(int, const QIcon&)", typeof(void), typeof(int), column, typeof(QIcon), icon);
		}
		public string StatusTip(int column) {
			return (string) interceptor.Invoke("statusTip$", "statusTip(int) const", typeof(string), typeof(int), column);
		}
		public void SetStatusTip(int column, string statusTip) {
			interceptor.Invoke("setStatusTip$$", "setStatusTip(int, const QString&)", typeof(void), typeof(int), column, typeof(string), statusTip);
		}
		public string ToolTip(int column) {
			return (string) interceptor.Invoke("toolTip$", "toolTip(int) const", typeof(string), typeof(int), column);
		}
		public void SetToolTip(int column, string toolTip) {
			interceptor.Invoke("setToolTip$$", "setToolTip(int, const QString&)", typeof(void), typeof(int), column, typeof(string), toolTip);
		}
		public string WhatsThis(int column) {
			return (string) interceptor.Invoke("whatsThis$", "whatsThis(int) const", typeof(string), typeof(int), column);
		}
		public void SetWhatsThis(int column, string whatsThis) {
			interceptor.Invoke("setWhatsThis$$", "setWhatsThis(int, const QString&)", typeof(void), typeof(int), column, typeof(string), whatsThis);
		}
		public QFont Font(int column) {
			return (QFont) interceptor.Invoke("font$", "font(int) const", typeof(QFont), typeof(int), column);
		}
		public void SetFont(int column, QFont font) {
			interceptor.Invoke("setFont$#", "setFont(int, const QFont&)", typeof(void), typeof(int), column, typeof(QFont), font);
		}
		public int TextAlignment(int column) {
			return (int) interceptor.Invoke("textAlignment$", "textAlignment(int) const", typeof(int), typeof(int), column);
		}
		public void SetTextAlignment(int column, int alignment) {
			interceptor.Invoke("setTextAlignment$$", "setTextAlignment(int, int)", typeof(void), typeof(int), column, typeof(int), alignment);
		}
		public QColor BackgroundColor(int column) {
			return (QColor) interceptor.Invoke("backgroundColor$", "backgroundColor(int) const", typeof(QColor), typeof(int), column);
		}
		public void SetBackgroundColor(int column, QColor color) {
			interceptor.Invoke("setBackgroundColor$#", "setBackgroundColor(int, const QColor&)", typeof(void), typeof(int), column, typeof(QColor), color);
		}
		public QBrush Background(int column) {
			return (QBrush) interceptor.Invoke("background$", "background(int) const", typeof(QBrush), typeof(int), column);
		}
		public void SetBackground(int column, QBrush brush) {
			interceptor.Invoke("setBackground$#", "setBackground(int, const QBrush&)", typeof(void), typeof(int), column, typeof(QBrush), brush);
		}
		public QColor TextColor(int column) {
			return (QColor) interceptor.Invoke("textColor$", "textColor(int) const", typeof(QColor), typeof(int), column);
		}
		public void SetTextColor(int column, QColor color) {
			interceptor.Invoke("setTextColor$#", "setTextColor(int, const QColor&)", typeof(void), typeof(int), column, typeof(QColor), color);
		}
		public QBrush Foreground(int column) {
			return (QBrush) interceptor.Invoke("foreground$", "foreground(int) const", typeof(QBrush), typeof(int), column);
		}
		public void SetForeground(int column, QBrush brush) {
			interceptor.Invoke("setForeground$#", "setForeground(int, const QBrush&)", typeof(void), typeof(int), column, typeof(QBrush), brush);
		}
		public Qt.CheckState CheckState(int column) {
			return (Qt.CheckState) interceptor.Invoke("checkState$", "checkState(int) const", typeof(Qt.CheckState), typeof(int), column);
		}
		public void SetCheckState(int column, Qt.CheckState state) {
			interceptor.Invoke("setCheckState$$", "setCheckState(int, Qt::CheckState)", typeof(void), typeof(int), column, typeof(Qt.CheckState), state);
		}
		public QSize SizeHint(int column) {
			return (QSize) interceptor.Invoke("sizeHint$", "sizeHint(int) const", typeof(QSize), typeof(int), column);
		}
		public void SetSizeHint(int column, QSize size) {
			interceptor.Invoke("setSizeHint$#", "setSizeHint(int, const QSize&)", typeof(void), typeof(int), column, typeof(QSize), size);
		}
		[SmokeMethod("data(int, int) const")]
		public virtual QVariant Data(int column, int role) {
			return (QVariant) interceptor.Invoke("data$$", "data(int, int) const", typeof(QVariant), typeof(int), column, typeof(int), role);
		}
		[SmokeMethod("setData(int, int, const QVariant&)")]
		public virtual void SetData(int column, int role, QVariant value) {
			interceptor.Invoke("setData$$#", "setData(int, int, const QVariant&)", typeof(void), typeof(int), column, typeof(int), role, typeof(QVariant), value);
		}
		[SmokeMethod("read(QDataStream&)")]
		public virtual void Read(QDataStream arg1) {
			interceptor.Invoke("read#", "read(QDataStream&)", typeof(void), typeof(QDataStream), arg1);
		}
		[SmokeMethod("write(QDataStream&) const")]
		public virtual void Write(QDataStream arg1) {
			interceptor.Invoke("write#", "write(QDataStream&) const", typeof(void), typeof(QDataStream), arg1);
		}
		public QTreeWidgetItem Parent() {
			return (QTreeWidgetItem) interceptor.Invoke("parent", "parent() const", typeof(QTreeWidgetItem));
		}
		public QTreeWidgetItem Child(int index) {
			return (QTreeWidgetItem) interceptor.Invoke("child$", "child(int) const", typeof(QTreeWidgetItem), typeof(int), index);
		}
		public int ChildCount() {
			return (int) interceptor.Invoke("childCount", "childCount() const", typeof(int));
		}
		public int ColumnCount() {
			return (int) interceptor.Invoke("columnCount", "columnCount() const", typeof(int));
		}
		public int IndexOfChild(QTreeWidgetItem child) {
			return (int) interceptor.Invoke("indexOfChild#", "indexOfChild(QTreeWidgetItem*) const", typeof(int), typeof(QTreeWidgetItem), child);
		}
		public void AddChild(QTreeWidgetItem child) {
			interceptor.Invoke("addChild#", "addChild(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), child);
		}
		public void InsertChild(int index, QTreeWidgetItem child) {
			interceptor.Invoke("insertChild$#", "insertChild(int, QTreeWidgetItem*)", typeof(void), typeof(int), index, typeof(QTreeWidgetItem), child);
		}
		public QTreeWidgetItem TakeChild(int index) {
			return (QTreeWidgetItem) interceptor.Invoke("takeChild$", "takeChild(int)", typeof(QTreeWidgetItem), typeof(int), index);
		}
		public void AddChildren(List<QTreeWidgetItem> children) {
			interceptor.Invoke("addChildren?", "addChildren(const QList<QTreeWidgetItem*>&)", typeof(void), typeof(List<QTreeWidgetItem>), children);
		}
		public void InsertChildren(int index, List<QTreeWidgetItem> children) {
			interceptor.Invoke("insertChildren$?", "insertChildren(int, const QList<QTreeWidgetItem*>&)", typeof(void), typeof(int), index, typeof(List<QTreeWidgetItem>), children);
		}
		public List<QTreeWidgetItem> TakeChildren() {
			return (List<QTreeWidgetItem>) interceptor.Invoke("takeChildren", "takeChildren()", typeof(List<QTreeWidgetItem>));
		}
		public int type() {
			return (int) interceptor.Invoke("type", "type() const", typeof(int));
		}
		public void SortChildren(int column, Qt.SortOrder order) {
			interceptor.Invoke("sortChildren$$", "sortChildren(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
		}
		~QTreeWidgetItem() {
			interceptor.Invoke("~QTreeWidgetItem", "~QTreeWidgetItem()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QTreeWidgetItem", "~QTreeWidgetItem()", typeof(void));
		}
	}
}
