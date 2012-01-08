//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQToolBarSignals"></see> for signals emitted by QToolBar
    /// </remarks>
    [SmokeClass("QToolBar")]
    public class QToolBar : QWidget, IDisposable {
        protected QToolBar(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QToolBar), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QToolBar() {
            staticInterceptor = new SmokeInvocation(typeof(QToolBar), null);
        }
        [Q_PROPERTY("bool", "movable")]
        public bool Movable {
            get { return (bool) interceptor.Invoke("isMovable", "isMovable()", typeof(bool)); }
            set { interceptor.Invoke("setMovable$", "setMovable(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("Qt::ToolBarAreas", "allowedAreas")]
        public uint AllowedAreas {
            get { return (uint) interceptor.Invoke("allowedAreas", "allowedAreas()", typeof(uint)); }
            set { interceptor.Invoke("setAllowedAreas$", "setAllowedAreas(Qt::ToolBarAreas)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("Qt::Orientation", "orientation")]
        public new Qt.Orientation Orientation {
            get { return (Qt.Orientation) interceptor.Invoke("orientation", "orientation()", typeof(Qt.Orientation)); }
            set { interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), value); }
        }
        [Q_PROPERTY("QSize", "iconSize")]
        public QSize IconSize {
            get { return (QSize) interceptor.Invoke("iconSize", "iconSize()", typeof(QSize)); }
            set { interceptor.Invoke("setIconSize#", "setIconSize(QSize)", typeof(void), typeof(QSize), value); }
        }
        [Q_PROPERTY("Qt::ToolButtonStyle", "toolButtonStyle")]
        public new Qt.ToolButtonStyle ToolButtonStyle {
            get { return (Qt.ToolButtonStyle) interceptor.Invoke("toolButtonStyle", "toolButtonStyle()", typeof(Qt.ToolButtonStyle)); }
            set { interceptor.Invoke("setToolButtonStyle$", "setToolButtonStyle(Qt::ToolButtonStyle)", typeof(void), typeof(Qt.ToolButtonStyle), value); }
        }
        [Q_PROPERTY("bool", "floating")]
        public bool Floating {
            get { return (bool) interceptor.Invoke("isFloating", "isFloating()", typeof(bool)); }
        }
        [Q_PROPERTY("bool", "floatable")]
        public bool Floatable {
            get { return (bool) interceptor.Invoke("isFloatable", "isFloatable()", typeof(bool)); }
            set { interceptor.Invoke("setFloatable$", "setFloatable(bool)", typeof(void), typeof(bool), value); }
        }
        public QToolBar(string title, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBar$#", "QToolBar(const QString&, QWidget*)", typeof(void), typeof(string), title, typeof(QWidget), parent);
        }
        public QToolBar(string title) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBar$", "QToolBar(const QString&)", typeof(void), typeof(string), title);
        }
        public QToolBar(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBar#", "QToolBar(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QToolBar() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QToolBar", "QToolBar()", typeof(void));
        }
        public bool IsAreaAllowed(Qt.ToolBarArea area) {
            return (bool) interceptor.Invoke("isAreaAllowed$", "isAreaAllowed(Qt::ToolBarArea) const", typeof(bool), typeof(Qt.ToolBarArea), area);
        }
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public new void AddAction(QAction action) {
            interceptor.Invoke("addAction#", "addAction(QAction*)", typeof(void), typeof(QAction), action);
        }
        public QAction AddAction(string text) {
            return (QAction) interceptor.Invoke("addAction$", "addAction(const QString&)", typeof(QAction), typeof(string), text);
        }
        public QAction AddAction(QIcon icon, string text) {
            return (QAction) interceptor.Invoke("addAction#$", "addAction(const QIcon&, const QString&)", typeof(QAction), typeof(QIcon), icon, typeof(string), text);
        }
        public QAction AddAction(string text, QObject receiver, string member) {
            return (QAction) interceptor.Invoke("addAction$#$", "addAction(const QString&, const QObject*, const char*)", typeof(QAction), typeof(string), text, typeof(QObject), receiver, typeof(string), member);
        }
        public QAction AddAction(QIcon icon, string text, QObject receiver, string member) {
            return (QAction) interceptor.Invoke("addAction#$#$", "addAction(const QIcon&, const QString&, const QObject*, const char*)", typeof(QAction), typeof(QIcon), icon, typeof(string), text, typeof(QObject), receiver, typeof(string), member);
        }
        public QAction AddSeparator() {
            return (QAction) interceptor.Invoke("addSeparator", "addSeparator()", typeof(QAction));
        }
        public QAction InsertSeparator(QAction before) {
            return (QAction) interceptor.Invoke("insertSeparator#", "insertSeparator(QAction*)", typeof(QAction), typeof(QAction), before);
        }
        public QAction AddWidget(QWidget widget) {
            return (QAction) interceptor.Invoke("addWidget#", "addWidget(QWidget*)", typeof(QAction), typeof(QWidget), widget);
        }
        public QAction InsertWidget(QAction before, QWidget widget) {
            return (QAction) interceptor.Invoke("insertWidget##", "insertWidget(QAction*, QWidget*)", typeof(QAction), typeof(QAction), before, typeof(QWidget), widget);
        }
        public QRect ActionGeometry(QAction action) {
            return (QRect) interceptor.Invoke("actionGeometry#", "actionGeometry(QAction*) const", typeof(QRect), typeof(QAction), action);
        }
        public QAction ActionAt(QPoint p) {
            return (QAction) interceptor.Invoke("actionAt#", "actionAt(const QPoint&) const", typeof(QAction), typeof(QPoint), p);
        }
        public QAction ActionAt(int x, int y) {
            return (QAction) interceptor.Invoke("actionAt$$", "actionAt(int, int) const", typeof(QAction), typeof(int), x, typeof(int), y);
        }
        public QAction ToggleViewAction() {
            return (QAction) interceptor.Invoke("toggleViewAction", "toggleViewAction() const", typeof(QAction));
        }
        public QWidget WidgetForAction(QAction action) {
            return (QWidget) interceptor.Invoke("widgetForAction#", "widgetForAction(QAction*) const", typeof(QWidget), typeof(QAction), action);
        }
        [Q_SLOT("void setIconSize(QSize)")]
        public void SetIconSize(QSize iconSize) {
            interceptor.Invoke("setIconSize#", "setIconSize(const QSize&)", typeof(void), typeof(QSize), iconSize);
        }
        [Q_SLOT("void setToolButtonStyle(Qt::ToolButtonStyle)")]
        public void SetToolButtonStyle(Qt.ToolButtonStyle toolButtonStyle) {
            interceptor.Invoke("setToolButtonStyle$", "setToolButtonStyle(Qt::ToolButtonStyle)", typeof(void), typeof(Qt.ToolButtonStyle), toolButtonStyle);
        }
        [SmokeMethod("actionEvent(QActionEvent*)")]
        protected override void ActionEvent(QActionEvent arg1) {
            interceptor.Invoke("actionEvent#", "actionEvent(QActionEvent*)", typeof(void), typeof(QActionEvent), arg1);
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("childEvent(QChildEvent*)")]
        protected override void ChildEvent(QChildEvent arg1) {
            interceptor.Invoke("childEvent#", "childEvent(QChildEvent*)", typeof(void), typeof(QChildEvent), arg1);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        protected void InitStyleOption(QStyleOptionToolBar option) {
            interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionToolBar*) const", typeof(void), typeof(QStyleOptionToolBar), option);
        }
        ~QToolBar() {
            interceptor.Invoke("~QToolBar", "~QToolBar()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QToolBar", "~QToolBar()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQToolBarSignals Emit {
            get { return (IQToolBarSignals) Q_EMIT; }
        }
    }

    public interface IQToolBarSignals : IQWidgetSignals {
        [Q_SIGNAL("void actionTriggered(QAction*)")]
        void ActionTriggered(QAction action);
        [Q_SIGNAL("void movableChanged(bool)")]
        void MovableChanged(bool movable);
        [Q_SIGNAL("void allowedAreasChanged(Qt::ToolBarAreas)")]
        void AllowedAreasChanged(uint allowedAreas);
        [Q_SIGNAL("void orientationChanged(Qt::Orientation)")]
        void OrientationChanged(Qt.Orientation orientation);
        [Q_SIGNAL("void iconSizeChanged(QSize)")]
        void IconSizeChanged(QSize iconSize);
        [Q_SIGNAL("void toolButtonStyleChanged(Qt::ToolButtonStyle)")]
        void ToolButtonStyleChanged(Qt.ToolButtonStyle toolButtonStyle);
    }
}