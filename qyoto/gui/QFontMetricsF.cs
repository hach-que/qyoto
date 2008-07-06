//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    [SmokeClass("QFontMetricsF")]
    public class QFontMetricsF : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QFontMetricsF(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QFontMetricsF), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QFontMetricsF() {
            staticInterceptor = new SmokeInvocation(typeof(QFontMetricsF), null);
        }
        public QFontMetricsF(QFont arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFontMetricsF#", "QFontMetricsF(const QFont&)", typeof(void), typeof(QFont), arg1);
        }
        public QFontMetricsF(QFont arg1, IQPaintDevice pd) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFontMetricsF##", "QFontMetricsF(const QFont&, QPaintDevice*)", typeof(void), typeof(QFont), arg1, typeof(IQPaintDevice), pd);
        }
        public QFontMetricsF(QFontMetrics arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFontMetricsF#", "QFontMetricsF(const QFontMetrics&)", typeof(void), typeof(QFontMetrics), arg1);
        }
        public QFontMetricsF(QFontMetricsF arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFontMetricsF#", "QFontMetricsF(const QFontMetricsF&)", typeof(void), typeof(QFontMetricsF), arg1);
        }
        public double Ascent() {
            return (double) interceptor.Invoke("ascent", "ascent() const", typeof(double));
        }
        public double Descent() {
            return (double) interceptor.Invoke("descent", "descent() const", typeof(double));
        }
        public double Height() {
            return (double) interceptor.Invoke("height", "height() const", typeof(double));
        }
        public double Leading() {
            return (double) interceptor.Invoke("leading", "leading() const", typeof(double));
        }
        public double LineSpacing() {
            return (double) interceptor.Invoke("lineSpacing", "lineSpacing() const", typeof(double));
        }
        public double MinLeftBearing() {
            return (double) interceptor.Invoke("minLeftBearing", "minLeftBearing() const", typeof(double));
        }
        public double MinRightBearing() {
            return (double) interceptor.Invoke("minRightBearing", "minRightBearing() const", typeof(double));
        }
        public double MaxWidth() {
            return (double) interceptor.Invoke("maxWidth", "maxWidth() const", typeof(double));
        }
        public double XHeight() {
            return (double) interceptor.Invoke("xHeight", "xHeight() const", typeof(double));
        }
        public double AverageCharWidth() {
            return (double) interceptor.Invoke("averageCharWidth", "averageCharWidth() const", typeof(double));
        }
        public bool InFont(QChar arg1) {
            return (bool) interceptor.Invoke("inFont#", "inFont(QChar) const", typeof(bool), typeof(QChar), arg1);
        }
        public double LeftBearing(QChar arg1) {
            return (double) interceptor.Invoke("leftBearing#", "leftBearing(QChar) const", typeof(double), typeof(QChar), arg1);
        }
        public double RightBearing(QChar arg1) {
            return (double) interceptor.Invoke("rightBearing#", "rightBearing(QChar) const", typeof(double), typeof(QChar), arg1);
        }
        public double Width(string arg1) {
            return (double) interceptor.Invoke("width$", "width(const QString&) const", typeof(double), typeof(string), arg1);
        }
        public double Width(QChar arg1) {
            return (double) interceptor.Invoke("width#", "width(QChar) const", typeof(double), typeof(QChar), arg1);
        }
        public QRectF BoundingRect(string arg1) {
            return (QRectF) interceptor.Invoke("boundingRect$", "boundingRect(const QString&) const", typeof(QRectF), typeof(string), arg1);
        }
        public QRectF BoundingRect(QChar arg1) {
            return (QRectF) interceptor.Invoke("boundingRect#", "boundingRect(QChar) const", typeof(QRectF), typeof(QChar), arg1);
        }
        public QRectF BoundingRect(QRectF r, int flags, string arg3, int tabstops, ref int tabarray) {
            StackItem[] stack = new StackItem[6];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(r);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(r);
#endif
            stack[2].s_int = flags;
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(arg3);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(arg3);
#endif
            stack[4].s_int = tabstops;
            stack[5].s_int = tabarray;
            interceptor.Invoke("boundingRect#$$$$", "boundingRect(const QRectF&, int, const QString&, int, int*) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).Free();
#endif
            tabarray = stack[5].s_int;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).Free();
#endif
            return (QRectF) returnValue;
        }
        public QRectF BoundingRect(QRectF r, int flags, string arg3, int tabstops) {
            return (QRectF) interceptor.Invoke("boundingRect#$$$", "boundingRect(const QRectF&, int, const QString&, int) const", typeof(QRectF), typeof(QRectF), r, typeof(int), flags, typeof(string), arg3, typeof(int), tabstops);
        }
        public QRectF BoundingRect(QRectF r, int flags, string arg3) {
            return (QRectF) interceptor.Invoke("boundingRect#$$", "boundingRect(const QRectF&, int, const QString&) const", typeof(QRectF), typeof(QRectF), r, typeof(int), flags, typeof(string), arg3);
        }
        public QSizeF Size(int flags, string str, int tabstops, ref int tabarray) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = flags;
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(str);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(str);
#endif
            stack[3].s_int = tabstops;
            stack[4].s_int = tabarray;
            interceptor.Invoke("size$$$$", "size(int, const QString&, int, int*) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
            tabarray = stack[4].s_int;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).Free();
#endif
            return (QSizeF) returnValue;
        }
        public QSizeF Size(int flags, string str, int tabstops) {
            return (QSizeF) interceptor.Invoke("size$$$", "size(int, const QString&, int) const", typeof(QSizeF), typeof(int), flags, typeof(string), str, typeof(int), tabstops);
        }
        public QSizeF Size(int flags, string str) {
            return (QSizeF) interceptor.Invoke("size$$", "size(int, const QString&) const", typeof(QSizeF), typeof(int), flags, typeof(string), str);
        }
        public QRectF TightBoundingRect(string text) {
            return (QRectF) interceptor.Invoke("tightBoundingRect$", "tightBoundingRect(const QString&) const", typeof(QRectF), typeof(string), text);
        }
        public string ElidedText(string text, Qt.TextElideMode mode, double width, int flags) {
            return (string) interceptor.Invoke("elidedText$$$$", "elidedText(const QString&, Qt::TextElideMode, qreal, int) const", typeof(string), typeof(string), text, typeof(Qt.TextElideMode), mode, typeof(double), width, typeof(int), flags);
        }
        public string ElidedText(string text, Qt.TextElideMode mode, double width) {
            return (string) interceptor.Invoke("elidedText$$$", "elidedText(const QString&, Qt::TextElideMode, qreal) const", typeof(string), typeof(string), text, typeof(Qt.TextElideMode), mode, typeof(double), width);
        }
        public double UnderlinePos() {
            return (double) interceptor.Invoke("underlinePos", "underlinePos() const", typeof(double));
        }
        public double OverlinePos() {
            return (double) interceptor.Invoke("overlinePos", "overlinePos() const", typeof(double));
        }
        public double StrikeOutPos() {
            return (double) interceptor.Invoke("strikeOutPos", "strikeOutPos() const", typeof(double));
        }
        public double LineWidth() {
            return (double) interceptor.Invoke("lineWidth", "lineWidth() const", typeof(double));
        }
        public override bool Equals(object o) {
            if (!(o is QFontMetricsF)) { return false; }
            return this == (QFontMetricsF) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        ~QFontMetricsF() {
            interceptor.Invoke("~QFontMetricsF", "~QFontMetricsF()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QFontMetricsF", "~QFontMetricsF()", typeof(void));
        }
        public static bool operator==(QFontMetricsF lhs, QFontMetricsF other) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QFontMetricsF&)", typeof(bool), typeof(QFontMetricsF), lhs, typeof(QFontMetricsF), other);
        }
        public static bool operator!=(QFontMetricsF lhs, QFontMetricsF other) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QFontMetricsF&)", typeof(bool), typeof(QFontMetricsF), lhs, typeof(QFontMetricsF), other);
        }
    }
}
