//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class ExtenderItem plasma/extenderitem.h <Plasma/ExtenderItem>
    ///  This class wraps around a QGraphicsWidget and provides drag&drop handling, a draghandle,
    ///  title and ability to display qactions as a row of icon, ability to expand, collapse, return
    ///  to source and tracks configuration associated with this item for you.
    ///  Typical usage of ExtenderItems in your applet could look like this:
    ///  @code
    ///  ExtenderItem item = new ExtenderItem(extender());
    ///  //name can be used to later access this item through extender().Item(name):
    ///  item.SetName("networkmonitoreth0");
    ///  item.Config().writeEntry("device", "eth0");
    ///  initExtenderItem(item);
    ///  @endcode
    ///  You'll then need to implement the initExtenderItem function. Having this function in your applet
    ///  makes sure that detached extender items get restored after plasma is restarted, just like applets
    ///  are. That is also the reason that we write an entry in item.Config().
    ///  In this function you should instantiate a QGraphicsWidget or QGraphicsItem and call the
    ///  setWidget function on the ExtenderItem. This is the only correct way of adding actual content to
    ///  a extenderItem. An example:
    ///  @code
    ///  void MyApplet.InitExtenderItem(Plasma.ExtenderItem item)
    ///  {
    ///      QGraphicsWidget myNetworkMonitorWidget = new NetworkMonitorWidget(item);
    ///      dataEngine("networktraffic").ConnectSource(item.Config().readEntry("device", ""),
    ///                                                  myNetworkMonitorWidget);
    ///      item.SetWidget(myNetworkMonitorWidget);
    ///  }
    ///  @endcode
    ///  </remarks>        <short> Provides detachable items for an Extender.</short>
    [SmokeClass("Plasma::ExtenderItem")]
    public class ExtenderItem : QGraphicsWidget, IDisposable {
        protected ExtenderItem(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ExtenderItem), this);
        }
        [Q_PROPERTY("QGraphicsItem*", "widget")]
        public IQGraphicsItem Widget {
            get { return (IQGraphicsItem) interceptor.Invoke("widget", "widget()", typeof(IQGraphicsItem)); }
            set { interceptor.Invoke("setWidget#", "setWidget(QGraphicsItem*)", typeof(void), typeof(IQGraphicsItem), value); }
        }
        [Q_PROPERTY("QString", "title")]
        public string Title {
            get { return (string) interceptor.Invoke("title", "title()", typeof(string)); }
            set { interceptor.Invoke("setTitle$", "setTitle(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "name")]
        public string Name {
            get { return (string) interceptor.Invoke("name", "name()", typeof(string)); }
            set { interceptor.Invoke("setName$", "setName(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QIcon", "icon")]
        public QIcon icon {
            get { return (QIcon) interceptor.Invoke("icon", "icon()", typeof(QIcon)); }
            set { interceptor.Invoke("setIcon#", "setIcon(QIcon)", typeof(void), typeof(QIcon), value); }
        }
        [Q_PROPERTY("Plasma::Extender*", "extender")]
        public Plasma.Extender Extender {
            get { return (Plasma.Extender) interceptor.Invoke("extender", "extender()", typeof(Plasma.Extender)); }
            set { interceptor.Invoke("setExtender#", "setExtender(Plasma::Extender*)", typeof(void), typeof(Plasma.Extender), value); }
        }
        [Q_PROPERTY("bool", "collapsed")]
        public bool Collapsed {
            get { return (bool) interceptor.Invoke("isCollapsed", "isCollapsed()", typeof(bool)); }
            set { interceptor.Invoke("setCollapsed$", "setCollapsed(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "detached")]
        public bool Detached {
            get { return (bool) interceptor.Invoke("isDetached", "isDetached()", typeof(bool)); }
        }
        [Q_PROPERTY("uint", "autoExpireDelay")]
        public uint AutoExpireDelay {
            get { return (uint) interceptor.Invoke("setAutoExpireDelay", "setAutoExpireDelay()", typeof(uint)); }
        }
        /// <remarks>
        ///  The constructor takes care of adding this item to an extender.
        /// <param> name="hostExtender" The extender the extender item belongs to.
        /// </param><param> name="extenderItemId" the id of the extender item. Use the default 0 to assign a new,
        ///  unique id to this extender item.
        ///          </param></remarks>        <short>    The constructor takes care of adding this item to an extender.</short>
        public ExtenderItem(Plasma.Extender hostExtender, uint extenderItemId) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ExtenderItem#$", "ExtenderItem(Plasma::Extender*, uint)", typeof(void), typeof(Plasma.Extender), hostExtender, typeof(uint), extenderItemId);
        }
        public ExtenderItem(Plasma.Extender hostExtender) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ExtenderItem#", "ExtenderItem(Plasma::Extender*)", typeof(void), typeof(Plasma.Extender), hostExtender);
        }
        /// <remarks>
        ///  fetch the configuration of this widget.
        /// </remarks>        <return> the configuration of this widget.
        ///          </return>
        ///         <short>    fetch the configuration of this widget.</short>
        public KConfigGroup Config() {
            return (KConfigGroup) interceptor.Invoke("config", "config() const", typeof(KConfigGroup));
        }
        /// <remarks>
        /// <param> name="extender" the extender this item belongs to.
        /// </param><param> name="pos" the position in the extender this item should be added. Defaults to 'just
        ///  append'.
        ///          </param></remarks>        <short>   </short>
        public void SetExtender(Plasma.Extender extender, QPointF pos) {
            interceptor.Invoke("setExtender##", "setExtender(Plasma::Extender*, const QPointF&)", typeof(void), typeof(Plasma.Extender), extender, typeof(QPointF), pos);
        }
        public void SetExtender(Plasma.Extender extender) {
            interceptor.Invoke("setExtender#", "setExtender(Plasma::Extender*)", typeof(void), typeof(Plasma.Extender), extender);
        }
        /// <remarks>
        /// <param> name="name" the name to store the action under in our collection.
        /// </param><param> name="action" the action to add. Actions will be displayed as an icon in the drag
        ///  handle.
        ///          </param></remarks>        <short>   </short>
        public void AddAction(string name, QAction action) {
            interceptor.Invoke("addAction$#", "addAction(const QString&, QAction*)", typeof(void), typeof(string), name, typeof(QAction), action);
        }
        /// <remarks>
        /// </remarks>        <return> the QAction with the given name from our collection. By default the action
        ///  collection contains a "movebacktosource" action which will be only shown when the
        ///  item is detached.
        ///          </return>
        ///         <short>   </short>
        public QAction Action(string name) {
            return (QAction) interceptor.Invoke("action$", "action(const QString&) const", typeof(QAction), typeof(string), name);
        }
        /// <remarks>
        ///  Destroys the extender item. As opposed to calling delete on this class, destroy also
        ///  removes the config group associated with this item.
        ///          </remarks>        <short>    Destroys the extender item.</short>
        [Q_SLOT("void destroy()")]
        public void Destroy() {
            interceptor.Invoke("destroy", "destroy()", typeof(void));
        }
        /// <remarks>
        ///  Collapse or expand the extender item. Defaults to false.
        ///          </remarks>        <short>    Collapse or expand the extender item.</short>
        [Q_SLOT("void setCollapsed(bool)")]
        public void SetCollapsed(bool collapsed) {
            interceptor.Invoke("setCollapsed$", "setCollapsed(bool)", typeof(void), typeof(bool), collapsed);
        }
        /// <remarks>
        ///  Returns the extender item to its source applet.
        ///          </remarks>        <short>    Returns the extender item to its source applet.</short>
        [Q_SLOT("void returnToSource()")]
        public void ReturnToSource() {
            interceptor.Invoke("returnToSource", "returnToSource()", typeof(void));
        }
        /// <remarks>
        ///  Shows a close button in this item's drag handle. By default a close button will not be
        ///  shown.
        ///          </remarks>        <short>    Shows a close button in this item's drag handle.</short>
        [Q_SLOT("void showCloseButton()")]
        public void ShowCloseButton() {
            interceptor.Invoke("showCloseButton", "showCloseButton()", typeof(void));
        }
        /// <remarks>
        ///  Hides the close button in this item's drag handle.
        ///          </remarks>        <short>    Hides the close button in this item's drag handle.</short>
        [Q_SLOT("void hideCloseButton()")]
        public void HideCloseButton() {
            interceptor.Invoke("hideCloseButton", "hideCloseButton()", typeof(void));
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        }
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        [SmokeMethod("mousePressEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseDoubleClickEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseMoveEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseReleaseEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("hoverMoveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverMoveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverMoveEvent#", "hoverMoveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("hoverLeaveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverLeaveEvent#", "hoverLeaveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        ~ExtenderItem() {
            interceptor.Invoke("~ExtenderItem", "~ExtenderItem()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ExtenderItem", "~ExtenderItem()", typeof(void));
        }
        protected new IExtenderItemSignals Emit {
            get { return (IExtenderItemSignals) Q_EMIT; }
        }
    }

    public interface IExtenderItemSignals : IQGraphicsWidgetSignals {
    }
}
