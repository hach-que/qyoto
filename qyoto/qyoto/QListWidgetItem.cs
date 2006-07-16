//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QListWidgetItem")]
	public class QListWidgetItem : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QListWidgetItem(Type dummy) {}
		interface IQListWidgetItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QListWidgetItem), this);
			_interceptor = (QListWidgetItem) realProxy.GetTransparentProxy();
		}
		private QListWidgetItem ProxyQListWidgetItem() {
			return (QListWidgetItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QListWidgetItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQListWidgetItemProxy), null);
			_staticInterceptor = (IQListWidgetItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQListWidgetItemProxy StaticQListWidgetItem() {
			return (IQListWidgetItemProxy) _staticInterceptor;
		}

		public enum ItemType {
			Type = 0,
			UserType = 1000,
		}
		public QListWidgetItem(QListWidget view, int type) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(view,type);
		}
		[SmokeMethod("QListWidgetItem(QListWidget*, int)")]
		private void NewQListWidgetItem(QListWidget view, int type) {
			ProxyQListWidgetItem().NewQListWidgetItem(view,type);
		}
		public QListWidgetItem(QListWidget view) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(view);
		}
		[SmokeMethod("QListWidgetItem(QListWidget*)")]
		private void NewQListWidgetItem(QListWidget view) {
			ProxyQListWidgetItem().NewQListWidgetItem(view);
		}
		public QListWidgetItem() : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem();
		}
		[SmokeMethod("QListWidgetItem()")]
		private void NewQListWidgetItem() {
			ProxyQListWidgetItem().NewQListWidgetItem();
		}
		public QListWidgetItem(string text, QListWidget view, int type) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(text,view,type);
		}
		[SmokeMethod("QListWidgetItem(const QString&, QListWidget*, int)")]
		private void NewQListWidgetItem(string text, QListWidget view, int type) {
			ProxyQListWidgetItem().NewQListWidgetItem(text,view,type);
		}
		public QListWidgetItem(string text, QListWidget view) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(text,view);
		}
		[SmokeMethod("QListWidgetItem(const QString&, QListWidget*)")]
		private void NewQListWidgetItem(string text, QListWidget view) {
			ProxyQListWidgetItem().NewQListWidgetItem(text,view);
		}
		public QListWidgetItem(string text) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(text);
		}
		[SmokeMethod("QListWidgetItem(const QString&)")]
		private void NewQListWidgetItem(string text) {
			ProxyQListWidgetItem().NewQListWidgetItem(text);
		}
		public QListWidgetItem(QIcon icon, string text, QListWidget view, int type) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(icon,text,view,type);
		}
		[SmokeMethod("QListWidgetItem(const QIcon&, const QString&, QListWidget*, int)")]
		private void NewQListWidgetItem(QIcon icon, string text, QListWidget view, int type) {
			ProxyQListWidgetItem().NewQListWidgetItem(icon,text,view,type);
		}
		public QListWidgetItem(QIcon icon, string text, QListWidget view) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(icon,text,view);
		}
		[SmokeMethod("QListWidgetItem(const QIcon&, const QString&, QListWidget*)")]
		private void NewQListWidgetItem(QIcon icon, string text, QListWidget view) {
			ProxyQListWidgetItem().NewQListWidgetItem(icon,text,view);
		}
		public QListWidgetItem(QIcon icon, string text) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(icon,text);
		}
		[SmokeMethod("QListWidgetItem(const QIcon&, const QString&)")]
		private void NewQListWidgetItem(QIcon icon, string text) {
			ProxyQListWidgetItem().NewQListWidgetItem(icon,text);
		}
		public QListWidgetItem(QListWidgetItem other) : this((Type) null) {
			CreateProxy();
			NewQListWidgetItem(other);
		}
		[SmokeMethod("QListWidgetItem(const QListWidgetItem&)")]
		private void NewQListWidgetItem(QListWidgetItem other) {
			ProxyQListWidgetItem().NewQListWidgetItem(other);
		}
		[SmokeMethod("clone() const")]
		public virtual QListWidgetItem Clone() {
			return ProxyQListWidgetItem().Clone();
		}
		[SmokeMethod("listWidget() const")]
		public QListWidget ListWidget() {
			return ProxyQListWidgetItem().ListWidget();
		}
		[SmokeMethod("setSelected(bool)")]
		public void SetSelected(bool select) {
			ProxyQListWidgetItem().SetSelected(select);
		}
		[SmokeMethod("isSelected() const")]
		public bool IsSelected() {
			return ProxyQListWidgetItem().IsSelected();
		}
		[SmokeMethod("setHidden(bool)")]
		public void SetHidden(bool hide) {
			ProxyQListWidgetItem().SetHidden(hide);
		}
		[SmokeMethod("isHidden() const")]
		public bool IsHidden() {
			return ProxyQListWidgetItem().IsHidden();
		}
		[SmokeMethod("flags() const")]
		public int Flags() {
			return ProxyQListWidgetItem().Flags();
		}
		[SmokeMethod("setFlags(Qt::ItemFlags)")]
		public void SetFlags(int flags) {
			ProxyQListWidgetItem().SetFlags(flags);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQListWidgetItem().Text();
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string text) {
			ProxyQListWidgetItem().SetText(text);
		}
		[SmokeMethod("icon() const")]
		public QIcon Icon() {
			return ProxyQListWidgetItem().Icon();
		}
		[SmokeMethod("setIcon(const QIcon&)")]
		public void SetIcon(QIcon icon) {
			ProxyQListWidgetItem().SetIcon(icon);
		}
		[SmokeMethod("statusTip() const")]
		public string StatusTip() {
			return ProxyQListWidgetItem().StatusTip();
		}
		[SmokeMethod("setStatusTip(const QString&)")]
		public void SetStatusTip(string statusTip) {
			ProxyQListWidgetItem().SetStatusTip(statusTip);
		}
		[SmokeMethod("toolTip() const")]
		public string ToolTip() {
			return ProxyQListWidgetItem().ToolTip();
		}
		[SmokeMethod("setToolTip(const QString&)")]
		public void SetToolTip(string toolTip) {
			ProxyQListWidgetItem().SetToolTip(toolTip);
		}
		[SmokeMethod("whatsThis() const")]
		public string WhatsThis() {
			return ProxyQListWidgetItem().WhatsThis();
		}
		[SmokeMethod("setWhatsThis(const QString&)")]
		public void SetWhatsThis(string whatsThis) {
			ProxyQListWidgetItem().SetWhatsThis(whatsThis);
		}
		[SmokeMethod("font() const")]
		public QFont Font() {
			return ProxyQListWidgetItem().Font();
		}
		[SmokeMethod("setFont(const QFont&)")]
		public void SetFont(QFont font) {
			ProxyQListWidgetItem().SetFont(font);
		}
		[SmokeMethod("textAlignment() const")]
		public int TextAlignment() {
			return ProxyQListWidgetItem().TextAlignment();
		}
		[SmokeMethod("setTextAlignment(int)")]
		public void SetTextAlignment(int alignment) {
			ProxyQListWidgetItem().SetTextAlignment(alignment);
		}
		[SmokeMethod("backgroundColor() const")]
		public QColor BackgroundColor() {
			return ProxyQListWidgetItem().BackgroundColor();
		}
		[SmokeMethod("setBackgroundColor(const QColor&)")]
		public virtual void SetBackgroundColor(QColor color) {
			ProxyQListWidgetItem().SetBackgroundColor(color);
		}
		[SmokeMethod("textColor() const")]
		public QColor TextColor() {
			return ProxyQListWidgetItem().TextColor();
		}
		[SmokeMethod("setTextColor(const QColor&)")]
		public void SetTextColor(QColor color) {
			ProxyQListWidgetItem().SetTextColor(color);
		}
		[SmokeMethod("checkState() const")]
		public Qt.CheckState CheckState() {
			return ProxyQListWidgetItem().CheckState();
		}
		[SmokeMethod("setCheckState(Qt::CheckState)")]
		public void SetCheckState(Qt.CheckState state) {
			ProxyQListWidgetItem().SetCheckState(state);
		}
		[SmokeMethod("sizeHint() const")]
		public QSize SizeHint() {
			return ProxyQListWidgetItem().SizeHint();
		}
		[SmokeMethod("setSizeHint(const QSize&)")]
		public void SetSizeHint(QSize size) {
			ProxyQListWidgetItem().SetSizeHint(size);
		}
		[SmokeMethod("data(int) const")]
		public virtual QVariant Data(int role) {
			return ProxyQListWidgetItem().Data(role);
		}
		[SmokeMethod("setData(int, const QVariant&)")]
		public virtual void SetData(int role, QVariant value) {
			ProxyQListWidgetItem().SetData(role,value);
		}
		[SmokeMethod("read(QDataStream&)")]
		public virtual void Read(QDataStream arg1) {
			ProxyQListWidgetItem().Read(arg1);
		}
		[SmokeMethod("write(QDataStream&) const")]
		public virtual void Write(QDataStream arg1) {
			ProxyQListWidgetItem().Write(arg1);
		}
		[SmokeMethod("type() const")]
		public int type() {
			return ProxyQListWidgetItem().type();
		}
		~QListWidgetItem() {
			DisposeQListWidgetItem();
		}
		public void Dispose() {
			DisposeQListWidgetItem();
		}
		[SmokeMethod("~QListWidgetItem()")]
		private void DisposeQListWidgetItem() {
			ProxyQListWidgetItem().DisposeQListWidgetItem();
		}
	}
}
