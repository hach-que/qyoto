//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQTabBarSignals"></see> for signals emitted by QTabBar
    /// </remarks>
    [SmokeClass("QTabBar")]
    public class QTabBar : QWidget, IDisposable {
        protected QTabBar(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTabBar), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTabBar() {
            staticInterceptor = new SmokeInvocation(typeof(QTabBar), null);
        }
        public enum Shape {
            RoundedNorth = 0,
            RoundedSouth = 1,
            RoundedWest = 2,
            RoundedEast = 3,
            TriangularNorth = 4,
            TriangularSouth = 5,
            TriangularWest = 6,
            TriangularEast = 7,
        }
        public enum ButtonPosition {
            LeftSide = 0,
            RightSide = 1,
        }
        public enum SelectionBehavior {
            SelectLeftTab = 0,
            SelectRightTab = 1,
            SelectPreviousTab = 2,
        }
        [Q_PROPERTY("QTabBar::Shape", "shape")]
        public QTabBar.Shape shape {
            get { return (QTabBar.Shape) interceptor.Invoke("shape", "shape()", typeof(QTabBar.Shape)); }
            set { interceptor.Invoke("setShape$", "setShape(QTabBar::Shape)", typeof(void), typeof(QTabBar.Shape), value); }
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
        [Q_PROPERTY("bool", "drawBase")]
        public bool DrawBase {
            get { return (bool) interceptor.Invoke("drawBase", "drawBase()", typeof(bool)); }
            set { interceptor.Invoke("setDrawBase$", "setDrawBase(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QSize", "iconSize")]
        public QSize IconSize {
            get { return (QSize) interceptor.Invoke("iconSize", "iconSize()", typeof(QSize)); }
            set { interceptor.Invoke("setIconSize#", "setIconSize(QSize)", typeof(void), typeof(QSize), value); }
        }
        [Q_PROPERTY("Qt::TextElideMode", "elideMode")]
        public Qt.TextElideMode ElideMode {
            get { return (Qt.TextElideMode) interceptor.Invoke("elideMode", "elideMode()", typeof(Qt.TextElideMode)); }
            set { interceptor.Invoke("setElideMode$", "setElideMode(Qt::TextElideMode)", typeof(void), typeof(Qt.TextElideMode), value); }
        }
        [Q_PROPERTY("bool", "usesScrollButtons")]
        public bool UsesScrollButtons {
            get { return (bool) interceptor.Invoke("usesScrollButtons", "usesScrollButtons()", typeof(bool)); }
            set { interceptor.Invoke("setUsesScrollButtons$", "setUsesScrollButtons(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "tabsClosable")]
        public bool TabsClosable {
            get { return (bool) interceptor.Invoke("tabsClosable", "tabsClosable()", typeof(bool)); }
            set { interceptor.Invoke("setTabsClosable$", "setTabsClosable(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QTabBar::SelectionBehavior", "selectionBehaviorOnRemove")]
        public QTabBar.SelectionBehavior SelectionBehaviorOnRemove {
            get { return (QTabBar.SelectionBehavior) interceptor.Invoke("selectionBehaviorOnRemove", "selectionBehaviorOnRemove()", typeof(QTabBar.SelectionBehavior)); }
            set { interceptor.Invoke("setSelectionBehaviorOnRemove$", "setSelectionBehaviorOnRemove(QTabBar::SelectionBehavior)", typeof(void), typeof(QTabBar.SelectionBehavior), value); }
        }
        [Q_PROPERTY("bool", "expanding")]
        public bool Expanding {
            get { return (bool) interceptor.Invoke("expanding", "expanding()", typeof(bool)); }
            set { interceptor.Invoke("setExpanding$", "setExpanding(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "movable")]
        public bool Movable {
            get { return (bool) interceptor.Invoke("isMovable", "isMovable()", typeof(bool)); }
            set { interceptor.Invoke("setMovable$", "setMovable(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "documentMode")]
        public bool DocumentMode {
            get { return (bool) interceptor.Invoke("documentMode", "documentMode()", typeof(bool)); }
            set { interceptor.Invoke("setDocumentMode$", "setDocumentMode(bool)", typeof(void), typeof(bool), value); }
        }
        public QTabBar(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTabBar#", "QTabBar(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QTabBar() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTabBar", "QTabBar()", typeof(void));
        }
        public int AddTab(string text) {
            return (int) interceptor.Invoke("addTab$", "addTab(const QString&)", typeof(int), typeof(string), text);
        }
        public int AddTab(QIcon icon, string text) {
            return (int) interceptor.Invoke("addTab#$", "addTab(const QIcon&, const QString&)", typeof(int), typeof(QIcon), icon, typeof(string), text);
        }
        public int InsertTab(int index, string text) {
            return (int) interceptor.Invoke("insertTab$$", "insertTab(int, const QString&)", typeof(int), typeof(int), index, typeof(string), text);
        }
        public int InsertTab(int index, QIcon icon, string text) {
            return (int) interceptor.Invoke("insertTab$#$", "insertTab(int, const QIcon&, const QString&)", typeof(int), typeof(int), index, typeof(QIcon), icon, typeof(string), text);
        }
        public void RemoveTab(int index) {
            interceptor.Invoke("removeTab$", "removeTab(int)", typeof(void), typeof(int), index);
        }
        public void MoveTab(int from, int to) {
            interceptor.Invoke("moveTab$$", "moveTab(int, int)", typeof(void), typeof(int), from, typeof(int), to);
        }
        public bool IsTabEnabled(int index) {
            return (bool) interceptor.Invoke("isTabEnabled$", "isTabEnabled(int) const", typeof(bool), typeof(int), index);
        }
        public void SetTabEnabled(int index, bool arg2) {
            interceptor.Invoke("setTabEnabled$$", "setTabEnabled(int, bool)", typeof(void), typeof(int), index, typeof(bool), arg2);
        }
        public string TabText(int index) {
            return (string) interceptor.Invoke("tabText$", "tabText(int) const", typeof(string), typeof(int), index);
        }
        public void SetTabText(int index, string text) {
            interceptor.Invoke("setTabText$$", "setTabText(int, const QString&)", typeof(void), typeof(int), index, typeof(string), text);
        }
        public QColor TabTextColor(int index) {
            return (QColor) interceptor.Invoke("tabTextColor$", "tabTextColor(int) const", typeof(QColor), typeof(int), index);
        }
        public void SetTabTextColor(int index, QColor color) {
            interceptor.Invoke("setTabTextColor$#", "setTabTextColor(int, const QColor&)", typeof(void), typeof(int), index, typeof(QColor), color);
        }
        public QIcon TabIcon(int index) {
            return (QIcon) interceptor.Invoke("tabIcon$", "tabIcon(int) const", typeof(QIcon), typeof(int), index);
        }
        public void SetTabIcon(int index, QIcon icon) {
            interceptor.Invoke("setTabIcon$#", "setTabIcon(int, const QIcon&)", typeof(void), typeof(int), index, typeof(QIcon), icon);
        }
        public void SetTabToolTip(int index, string tip) {
            interceptor.Invoke("setTabToolTip$$", "setTabToolTip(int, const QString&)", typeof(void), typeof(int), index, typeof(string), tip);
        }
        public string TabToolTip(int index) {
            return (string) interceptor.Invoke("tabToolTip$", "tabToolTip(int) const", typeof(string), typeof(int), index);
        }
        public void SetTabWhatsThis(int index, string text) {
            interceptor.Invoke("setTabWhatsThis$$", "setTabWhatsThis(int, const QString&)", typeof(void), typeof(int), index, typeof(string), text);
        }
        public string TabWhatsThis(int index) {
            return (string) interceptor.Invoke("tabWhatsThis$", "tabWhatsThis(int) const", typeof(string), typeof(int), index);
        }
        public void SetTabData(int index, QVariant data) {
            interceptor.Invoke("setTabData$#", "setTabData(int, const QVariant&)", typeof(void), typeof(int), index, typeof(QVariant), data);
        }
        public QVariant TabData(int index) {
            return (QVariant) interceptor.Invoke("tabData$", "tabData(int) const", typeof(QVariant), typeof(int), index);
        }
        public QRect TabRect(int index) {
            return (QRect) interceptor.Invoke("tabRect$", "tabRect(int) const", typeof(QRect), typeof(int), index);
        }
        public int TabAt(QPoint pos) {
            return (int) interceptor.Invoke("tabAt#", "tabAt(const QPoint&) const", typeof(int), typeof(QPoint), pos);
        }
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        [SmokeMethod("minimumSizeHint() const")]
        public override QSize MinimumSizeHint() {
            return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
        }
        public void SetTabButton(int index, QTabBar.ButtonPosition position, QWidget widget) {
            interceptor.Invoke("setTabButton$$#", "setTabButton(int, QTabBar::ButtonPosition, QWidget*)", typeof(void), typeof(int), index, typeof(QTabBar.ButtonPosition), position, typeof(QWidget), widget);
        }
        public QWidget TabButton(int index, QTabBar.ButtonPosition position) {
            return (QWidget) interceptor.Invoke("tabButton$$", "tabButton(int, QTabBar::ButtonPosition) const", typeof(QWidget), typeof(int), index, typeof(QTabBar.ButtonPosition), position);
        }
        [Q_SLOT("void setCurrentIndex(int)")]
        public void SetCurrentIndex(int index) {
            interceptor.Invoke("setCurrentIndex$", "setCurrentIndex(int)", typeof(void), typeof(int), index);
        }
        [SmokeMethod("tabSizeHint(int) const")]
        protected virtual QSize TabSizeHint(int index) {
            return (QSize) interceptor.Invoke("tabSizeHint$", "tabSizeHint(int) const", typeof(QSize), typeof(int), index);
        }
        [SmokeMethod("tabInserted(int)")]
        protected virtual void TabInserted(int index) {
            interceptor.Invoke("tabInserted$", "tabInserted(int)", typeof(void), typeof(int), index);
        }
        [SmokeMethod("tabRemoved(int)")]
        protected virtual void TabRemoved(int index) {
            interceptor.Invoke("tabRemoved$", "tabRemoved(int)", typeof(void), typeof(int), index);
        }
        [SmokeMethod("tabLayoutChange()")]
        protected virtual void TabLayoutChange() {
            interceptor.Invoke("tabLayoutChange", "tabLayoutChange()", typeof(void));
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
        }
        [SmokeMethod("showEvent(QShowEvent*)")]
        protected override void ShowEvent(QShowEvent arg1) {
            interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
        }
        [SmokeMethod("hideEvent(QHideEvent*)")]
        protected override void HideEvent(QHideEvent arg1) {
            interceptor.Invoke("hideEvent#", "hideEvent(QHideEvent*)", typeof(void), typeof(QHideEvent), arg1);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("mousePressEvent(QMouseEvent*)")]
        protected override void MousePressEvent(QMouseEvent arg1) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
        protected override void MouseMoveEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
        protected override void MouseReleaseEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        [SmokeMethod("wheelEvent(QWheelEvent*)")]
        protected override void WheelEvent(QWheelEvent arg1) {
            interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
        }
        [SmokeMethod("keyPressEvent(QKeyEvent*)")]
        protected override void KeyPressEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        protected void InitStyleOption(QStyleOptionTab option, int tabIndex) {
            interceptor.Invoke("initStyleOption#$", "initStyleOption(QStyleOptionTab*, int) const", typeof(void), typeof(QStyleOptionTab), option, typeof(int), tabIndex);
        }
        ~QTabBar() {
            interceptor.Invoke("~QTabBar", "~QTabBar()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTabBar", "~QTabBar()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTabBarSignals Emit {
            get { return (IQTabBarSignals) Q_EMIT; }
        }
    }

    public interface IQTabBarSignals : IQWidgetSignals {
        [Q_SIGNAL("void currentChanged(int)")]
        void CurrentChanged(int index);
        [Q_SIGNAL("void tabCloseRequested(int)")]
        void TabCloseRequested(int index);
        [Q_SIGNAL("void tabMoved(int, int)")]
        void TabMoved(int from, int to);
    }
}