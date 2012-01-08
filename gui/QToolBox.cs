//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQToolBoxSignals"></see> for signals emitted by QToolBox
    /// </remarks>
    [SmokeClass("QToolBox")]
    public class QToolBox : QFrame, IDisposable {
        protected QToolBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QToolBox), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QToolBox() {
            staticInterceptor = new SmokeInvocation(typeof(QToolBox), null);
        }
        [Q_PROPERTY("int", "currentIndex")]
        public int CurrentIndex {
            get { return (int) interceptor.Invoke("currentIndex", "currentIndex()", typeof(int)); }
            set { interceptor.Invoke("setCurrentIndex$", "setCurrentIndex(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "count")]
        public int Count {
            get { return (int) interceptor.Invoke("count", "count()", typeof(int)); }
        }
        public QToolBox(QWidget parent, uint f) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBox#$", "QToolBox(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), f);
        }
        public QToolBox(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBox#", "QToolBox(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QToolBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBox", "QToolBox()", typeof(void));
        }
        public int AddItem(QWidget widget, string text) {
            return (int) interceptor.Invoke("addItem#$", "addItem(QWidget*, const QString&)", typeof(int), typeof(QWidget), widget, typeof(string), text);
        }
        public int AddItem(QWidget widget, QIcon icon, string text) {
            return (int) interceptor.Invoke("addItem##$", "addItem(QWidget*, const QIcon&, const QString&)", typeof(int), typeof(QWidget), widget, typeof(QIcon), icon, typeof(string), text);
        }
        public int InsertItem(int index, QWidget widget, string text) {
            return (int) interceptor.Invoke("insertItem$#$", "insertItem(int, QWidget*, const QString&)", typeof(int), typeof(int), index, typeof(QWidget), widget, typeof(string), text);
        }
        public int InsertItem(int index, QWidget widget, QIcon icon, string text) {
            return (int) interceptor.Invoke("insertItem$##$", "insertItem(int, QWidget*, const QIcon&, const QString&)", typeof(int), typeof(int), index, typeof(QWidget), widget, typeof(QIcon), icon, typeof(string), text);
        }
        public void RemoveItem(int index) {
            interceptor.Invoke("removeItem$", "removeItem(int)", typeof(void), typeof(int), index);
        }
        public void SetItemEnabled(int index, bool enabled) {
            interceptor.Invoke("setItemEnabled$$", "setItemEnabled(int, bool)", typeof(void), typeof(int), index, typeof(bool), enabled);
        }
        public bool IsItemEnabled(int index) {
            return (bool) interceptor.Invoke("isItemEnabled$", "isItemEnabled(int) const", typeof(bool), typeof(int), index);
        }
        public void SetItemText(int index, string text) {
            interceptor.Invoke("setItemText$$", "setItemText(int, const QString&)", typeof(void), typeof(int), index, typeof(string), text);
        }
        public string ItemText(int index) {
            return (string) interceptor.Invoke("itemText$", "itemText(int) const", typeof(string), typeof(int), index);
        }
        public void SetItemIcon(int index, QIcon icon) {
            interceptor.Invoke("setItemIcon$#", "setItemIcon(int, const QIcon&)", typeof(void), typeof(int), index, typeof(QIcon), icon);
        }
        public QIcon ItemIcon(int index) {
            return (QIcon) interceptor.Invoke("itemIcon$", "itemIcon(int) const", typeof(QIcon), typeof(int), index);
        }
        public void SetItemToolTip(int index, string toolTip) {
            interceptor.Invoke("setItemToolTip$$", "setItemToolTip(int, const QString&)", typeof(void), typeof(int), index, typeof(string), toolTip);
        }
        public string ItemToolTip(int index) {
            return (string) interceptor.Invoke("itemToolTip$", "itemToolTip(int) const", typeof(string), typeof(int), index);
        }
        public QWidget CurrentWidget() {
            return (QWidget) interceptor.Invoke("currentWidget", "currentWidget() const", typeof(QWidget));
        }
        public QWidget Widget(int index) {
            return (QWidget) interceptor.Invoke("widget$", "widget(int) const", typeof(QWidget), typeof(int), index);
        }
        public int IndexOf(QWidget widget) {
            return (int) interceptor.Invoke("indexOf#", "indexOf(QWidget*) const", typeof(int), typeof(QWidget), widget);
        }
        [Q_SLOT("void setCurrentIndex(int)")]
        public void SetCurrentIndex(int index) {
            interceptor.Invoke("setCurrentIndex$", "setCurrentIndex(int)", typeof(void), typeof(int), index);
        }
        [Q_SLOT("void setCurrentWidget(QWidget*)")]
        public void SetCurrentWidget(QWidget widget) {
            interceptor.Invoke("setCurrentWidget#", "setCurrentWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("itemInserted(int)")]
        protected virtual void ItemInserted(int index) {
            interceptor.Invoke("itemInserted$", "itemInserted(int)", typeof(void), typeof(int), index);
        }
        [SmokeMethod("itemRemoved(int)")]
        protected virtual void ItemRemoved(int index) {
            interceptor.Invoke("itemRemoved$", "itemRemoved(int)", typeof(void), typeof(int), index);
        }
        [SmokeMethod("showEvent(QShowEvent*)")]
        protected override void ShowEvent(QShowEvent e) {
            interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), e);
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        ~QToolBox() {
            interceptor.Invoke("~QToolBox", "~QToolBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QToolBox", "~QToolBox()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQToolBoxSignals Emit {
            get { return (IQToolBoxSignals) Q_EMIT; }
        }
    }

    public interface IQToolBoxSignals : IQFrameSignals {
        [Q_SIGNAL("void currentChanged(int)")]
        void CurrentChanged(int index);
    }
}