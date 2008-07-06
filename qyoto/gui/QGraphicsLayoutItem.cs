//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;

    public interface IQGraphicsLayoutItem {
        void SetSizePolicy(QSizePolicy policy);
        void SetSizePolicy(QSizePolicy.Policy hPolicy, QSizePolicy.Policy vPolicy, QSizePolicy.ControlType controlType);
        void SetSizePolicy(QSizePolicy.Policy hPolicy, QSizePolicy.Policy vPolicy);
        QSizePolicy SizePolicy();
        void SetMinimumSize(QSizeF size);
        void SetMinimumSize(double w, double h);
        QSizeF MinimumSize();
        void SetMinimumWidth(double width);
        double MinimumWidth();
        void SetMinimumHeight(double height);
        double MinimumHeight();
        void SetPreferredSize(QSizeF size);
        void SetPreferredSize(double w, double h);
        QSizeF PreferredSize();
        void SetPreferredWidth(double width);
        double PreferredWidth();
        void SetPreferredHeight(double height);
        double PreferredHeight();
        void SetMaximumSize(QSizeF size);
        void SetMaximumSize(double w, double h);
        QSizeF MaximumSize();
        void SetMaximumWidth(double width);
        double MaximumWidth();
        void SetMaximumHeight(double height);
        double MaximumHeight();
        void SetGeometry(QRectF rect);
        QRectF Geometry();
        void GetContentsMargins(ref double left, ref double top, ref double right, ref double bottom);
        QRectF ContentsRect();
        QSizeF EffectiveSizeHint(Qt.SizeHint which, QSizeF constraint);
        QSizeF EffectiveSizeHint(Qt.SizeHint which);
        void UpdateGeometry();
        IQGraphicsLayoutItem ParentLayoutItem();
        void SetParentLayoutItem(IQGraphicsLayoutItem parent);
        bool IsLayout();
        QSizeF SizeHint(Qt.SizeHint which, QSizeF constraint);
    }
    [SmokeClass("QGraphicsLayoutItem")]
    public abstract class QGraphicsLayoutItem : Object, IQGraphicsLayoutItem {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QGraphicsLayoutItem(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGraphicsLayoutItem), this);
        }
        // QGraphicsLayoutItem* QGraphicsLayoutItem(QGraphicsLayoutItemPrivate& arg1); >>>> NOT CONVERTED
        public QGraphicsLayoutItem(IQGraphicsLayoutItem parent, bool isLayout) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsLayoutItem#$", "QGraphicsLayoutItem(QGraphicsLayoutItem*, bool)", typeof(void), typeof(IQGraphicsLayoutItem), parent, typeof(bool), isLayout);
        }
        public QGraphicsLayoutItem(IQGraphicsLayoutItem parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsLayoutItem#", "QGraphicsLayoutItem(QGraphicsLayoutItem*)", typeof(void), typeof(IQGraphicsLayoutItem), parent);
        }
        public QGraphicsLayoutItem() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsLayoutItem", "QGraphicsLayoutItem()", typeof(void));
        }
        public void SetSizePolicy(QSizePolicy policy) {
            interceptor.Invoke("setSizePolicy#", "setSizePolicy(const QSizePolicy&)", typeof(void), typeof(QSizePolicy), policy);
        }
        public void SetSizePolicy(QSizePolicy.Policy hPolicy, QSizePolicy.Policy vPolicy, QSizePolicy.ControlType controlType) {
            interceptor.Invoke("setSizePolicy$$$", "setSizePolicy(QSizePolicy::Policy, QSizePolicy::Policy, QSizePolicy::ControlType)", typeof(void), typeof(QSizePolicy.Policy), hPolicy, typeof(QSizePolicy.Policy), vPolicy, typeof(QSizePolicy.ControlType), controlType);
        }
        public void SetSizePolicy(QSizePolicy.Policy hPolicy, QSizePolicy.Policy vPolicy) {
            interceptor.Invoke("setSizePolicy$$", "setSizePolicy(QSizePolicy::Policy, QSizePolicy::Policy)", typeof(void), typeof(QSizePolicy.Policy), hPolicy, typeof(QSizePolicy.Policy), vPolicy);
        }
        public QSizePolicy SizePolicy() {
            return (QSizePolicy) interceptor.Invoke("sizePolicy", "sizePolicy() const", typeof(QSizePolicy));
        }
        public void SetMinimumSize(QSizeF size) {
            interceptor.Invoke("setMinimumSize#", "setMinimumSize(const QSizeF&)", typeof(void), typeof(QSizeF), size);
        }
        public void SetMinimumSize(double w, double h) {
            interceptor.Invoke("setMinimumSize$$", "setMinimumSize(qreal, qreal)", typeof(void), typeof(double), w, typeof(double), h);
        }
        public QSizeF MinimumSize() {
            return (QSizeF) interceptor.Invoke("minimumSize", "minimumSize() const", typeof(QSizeF));
        }
        public void SetMinimumWidth(double width) {
            interceptor.Invoke("setMinimumWidth$", "setMinimumWidth(qreal)", typeof(void), typeof(double), width);
        }
        public double MinimumWidth() {
            return (double) interceptor.Invoke("minimumWidth", "minimumWidth() const", typeof(double));
        }
        public void SetMinimumHeight(double height) {
            interceptor.Invoke("setMinimumHeight$", "setMinimumHeight(qreal)", typeof(void), typeof(double), height);
        }
        public double MinimumHeight() {
            return (double) interceptor.Invoke("minimumHeight", "minimumHeight() const", typeof(double));
        }
        public void SetPreferredSize(QSizeF size) {
            interceptor.Invoke("setPreferredSize#", "setPreferredSize(const QSizeF&)", typeof(void), typeof(QSizeF), size);
        }
        public void SetPreferredSize(double w, double h) {
            interceptor.Invoke("setPreferredSize$$", "setPreferredSize(qreal, qreal)", typeof(void), typeof(double), w, typeof(double), h);
        }
        public QSizeF PreferredSize() {
            return (QSizeF) interceptor.Invoke("preferredSize", "preferredSize() const", typeof(QSizeF));
        }
        public void SetPreferredWidth(double width) {
            interceptor.Invoke("setPreferredWidth$", "setPreferredWidth(qreal)", typeof(void), typeof(double), width);
        }
        public double PreferredWidth() {
            return (double) interceptor.Invoke("preferredWidth", "preferredWidth() const", typeof(double));
        }
        public void SetPreferredHeight(double height) {
            interceptor.Invoke("setPreferredHeight$", "setPreferredHeight(qreal)", typeof(void), typeof(double), height);
        }
        public double PreferredHeight() {
            return (double) interceptor.Invoke("preferredHeight", "preferredHeight() const", typeof(double));
        }
        public void SetMaximumSize(QSizeF size) {
            interceptor.Invoke("setMaximumSize#", "setMaximumSize(const QSizeF&)", typeof(void), typeof(QSizeF), size);
        }
        public void SetMaximumSize(double w, double h) {
            interceptor.Invoke("setMaximumSize$$", "setMaximumSize(qreal, qreal)", typeof(void), typeof(double), w, typeof(double), h);
        }
        public QSizeF MaximumSize() {
            return (QSizeF) interceptor.Invoke("maximumSize", "maximumSize() const", typeof(QSizeF));
        }
        public void SetMaximumWidth(double width) {
            interceptor.Invoke("setMaximumWidth$", "setMaximumWidth(qreal)", typeof(void), typeof(double), width);
        }
        public double MaximumWidth() {
            return (double) interceptor.Invoke("maximumWidth", "maximumWidth() const", typeof(double));
        }
        public void SetMaximumHeight(double height) {
            interceptor.Invoke("setMaximumHeight$", "setMaximumHeight(qreal)", typeof(void), typeof(double), height);
        }
        public double MaximumHeight() {
            return (double) interceptor.Invoke("maximumHeight", "maximumHeight() const", typeof(double));
        }
        [SmokeMethod("setGeometry(const QRectF&)")]
        public virtual void SetGeometry(QRectF rect) {
            interceptor.Invoke("setGeometry#", "setGeometry(const QRectF&)", typeof(void), typeof(QRectF), rect);
        }
        public QRectF Geometry() {
            return (QRectF) interceptor.Invoke("geometry", "geometry() const", typeof(QRectF));
        }
        [SmokeMethod("getContentsMargins(qreal*, qreal*, qreal*, qreal*) const")]
        public virtual void GetContentsMargins(ref double left, ref double top, ref double right, ref double bottom) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_double = left;
            stack[2].s_double = top;
            stack[3].s_double = right;
            stack[4].s_double = bottom;
            interceptor.Invoke("getContentsMargins$$$$", "getContentsMargins(qreal*, qreal*, qreal*, qreal*) const", stack);
            left = stack[1].s_double;
            top = stack[2].s_double;
            right = stack[3].s_double;
            bottom = stack[4].s_double;
            return;
        }
        public QRectF ContentsRect() {
            return (QRectF) interceptor.Invoke("contentsRect", "contentsRect() const", typeof(QRectF));
        }
        public QSizeF EffectiveSizeHint(Qt.SizeHint which, QSizeF constraint) {
            return (QSizeF) interceptor.Invoke("effectiveSizeHint$#", "effectiveSizeHint(Qt::SizeHint, const QSizeF&) const", typeof(QSizeF), typeof(Qt.SizeHint), which, typeof(QSizeF), constraint);
        }
        public QSizeF EffectiveSizeHint(Qt.SizeHint which) {
            return (QSizeF) interceptor.Invoke("effectiveSizeHint$", "effectiveSizeHint(Qt::SizeHint) const", typeof(QSizeF), typeof(Qt.SizeHint), which);
        }
        [SmokeMethod("updateGeometry()")]
        public virtual void UpdateGeometry() {
            interceptor.Invoke("updateGeometry", "updateGeometry()", typeof(void));
        }
        public IQGraphicsLayoutItem ParentLayoutItem() {
            return (IQGraphicsLayoutItem) interceptor.Invoke("parentLayoutItem", "parentLayoutItem() const", typeof(IQGraphicsLayoutItem));
        }
        public void SetParentLayoutItem(IQGraphicsLayoutItem parent) {
            interceptor.Invoke("setParentLayoutItem#", "setParentLayoutItem(QGraphicsLayoutItem*)", typeof(void), typeof(IQGraphicsLayoutItem), parent);
        }
        public bool IsLayout() {
            return (bool) interceptor.Invoke("isLayout", "isLayout() const", typeof(bool));
        }
        [SmokeMethod("sizeHint(Qt::SizeHint, const QSizeF&) const")]
        public abstract QSizeF SizeHint(Qt.SizeHint which, QSizeF constraint);
    }
}
