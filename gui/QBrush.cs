//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QBrush")]
    public partial class QBrush : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QBrush(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QBrush), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QBrush() {
            staticInterceptor = new SmokeInvocation(typeof(QBrush), null);
        }
        //  operator QVariant(); >>>> NOT CONVERTED
        // QBrushData*& data_ptr(); >>>> NOT CONVERTED
        public QBrush() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush", "QBrush()", typeof(void));
        }
        public QBrush(Qt.BrushStyle bs) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush$", "QBrush(Qt::BrushStyle)", typeof(void), typeof(Qt.BrushStyle), bs);
        }
        public QBrush(QColor color, Qt.BrushStyle bs) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush#$", "QBrush(const QColor&, Qt::BrushStyle)", typeof(void), typeof(QColor), color, typeof(Qt.BrushStyle), bs);
        }
        public QBrush(QColor color) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush#", "QBrush(const QColor&)", typeof(void), typeof(QColor), color);
        }
        public QBrush(Qt.GlobalColor color, Qt.BrushStyle bs) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush$$", "QBrush(Qt::GlobalColor, Qt::BrushStyle)", typeof(void), typeof(Qt.GlobalColor), color, typeof(Qt.BrushStyle), bs);
        }
        public QBrush(Qt.GlobalColor color) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush$", "QBrush(Qt::GlobalColor)", typeof(void), typeof(Qt.GlobalColor), color);
        }
        public QBrush(QColor color, QPixmap pixmap) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush##", "QBrush(const QColor&, const QPixmap&)", typeof(void), typeof(QColor), color, typeof(QPixmap), pixmap);
        }
        public QBrush(Qt.GlobalColor color, QPixmap pixmap) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush$#", "QBrush(Qt::GlobalColor, const QPixmap&)", typeof(void), typeof(Qt.GlobalColor), color, typeof(QPixmap), pixmap);
        }
        public QBrush(QPixmap pixmap) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush#", "QBrush(const QPixmap&)", typeof(void), typeof(QPixmap), pixmap);
        }
        public QBrush(QImage image) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush#", "QBrush(const QImage&)", typeof(void), typeof(QImage), image);
        }
        public QBrush(QBrush brush) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush#", "QBrush(const QBrush&)", typeof(void), typeof(QBrush), brush);
        }
        public QBrush(QGradient gradient) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QBrush#", "QBrush(const QGradient&)", typeof(void), typeof(QGradient), gradient);
        }
        public Qt.BrushStyle Style() {
            return (Qt.BrushStyle) interceptor.Invoke("style", "style() const", typeof(Qt.BrushStyle));
        }
        public void SetStyle(Qt.BrushStyle arg1) {
            interceptor.Invoke("setStyle$", "setStyle(Qt::BrushStyle)", typeof(void), typeof(Qt.BrushStyle), arg1);
        }
        public QMatrix Matrix() {
            return (QMatrix) interceptor.Invoke("matrix", "matrix() const", typeof(QMatrix));
        }
        public void SetMatrix(QMatrix mat) {
            interceptor.Invoke("setMatrix#", "setMatrix(const QMatrix&)", typeof(void), typeof(QMatrix), mat);
        }
        public QTransform Transform() {
            return (QTransform) interceptor.Invoke("transform", "transform() const", typeof(QTransform));
        }
        public void SetTransform(QTransform arg1) {
            interceptor.Invoke("setTransform#", "setTransform(const QTransform&)", typeof(void), typeof(QTransform), arg1);
        }
        public QPixmap Texture() {
            return (QPixmap) interceptor.Invoke("texture", "texture() const", typeof(QPixmap));
        }
        public void SetTexture(QPixmap pixmap) {
            interceptor.Invoke("setTexture#", "setTexture(const QPixmap&)", typeof(void), typeof(QPixmap), pixmap);
        }
        public QImage TextureImage() {
            return (QImage) interceptor.Invoke("textureImage", "textureImage() const", typeof(QImage));
        }
        public void SetTextureImage(QImage image) {
            interceptor.Invoke("setTextureImage#", "setTextureImage(const QImage&)", typeof(void), typeof(QImage), image);
        }
        public QColor Color() {
            return (QColor) interceptor.Invoke("color", "color() const", typeof(QColor));
        }
        public void SetColor(QColor color) {
            interceptor.Invoke("setColor#", "setColor(const QColor&)", typeof(void), typeof(QColor), color);
        }
        public void SetColor(Qt.GlobalColor color) {
            interceptor.Invoke("setColor$", "setColor(Qt::GlobalColor)", typeof(void), typeof(Qt.GlobalColor), color);
        }
        public QGradient Gradient() {
            return (QGradient) interceptor.Invoke("gradient", "gradient() const", typeof(QGradient));
        }
        public bool IsOpaque() {
            return (bool) interceptor.Invoke("isOpaque", "isOpaque() const", typeof(bool));
        }
        public override bool Equals(object o) {
            if (!(o is QBrush)) { return false; }
            return this == (QBrush) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public bool IsDetached() {
            return (bool) interceptor.Invoke("isDetached", "isDetached() const", typeof(bool));
        }
        ~QBrush() {
            interceptor.Invoke("~QBrush", "~QBrush()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QBrush", "~QBrush()", typeof(void));
        }
        public static bool operator==(QBrush lhs, QBrush b) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QBrush&) const", typeof(bool), typeof(QBrush), lhs, typeof(QBrush), b);
        }
        public static bool operator!=(QBrush lhs, QBrush b) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QBrush&) const", typeof(bool), typeof(QBrush), lhs, typeof(QBrush), b);
        }
    }
}
