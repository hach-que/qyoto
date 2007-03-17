//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPainter")]
	public class QPainter : MarshalByRefObject, IDisposable {
		protected QPainter interceptor = null;
		private IntPtr smokeObject;
		protected QPainter(Type dummy) {}
		[SmokeClass("QPainter")]
		interface IQPainterProxy {
			[SmokeMethod("setRedirected", "(const QPaintDevice*, QPaintDevice*, const QPoint&)", "###")]
			void SetRedirected(IQPaintDevice device, IQPaintDevice replacement, QPoint offset);
			[SmokeMethod("setRedirected", "(const QPaintDevice*, QPaintDevice*)", "##")]
			void SetRedirected(IQPaintDevice device, IQPaintDevice replacement);
			[SmokeMethod("redirected", "(const QPaintDevice*, QPoint*)", "##")]
			IQPaintDevice Redirected(IQPaintDevice device, QPoint offset);
			[SmokeMethod("redirected", "(const QPaintDevice*)", "#")]
			IQPaintDevice Redirected(IQPaintDevice device);
			[SmokeMethod("restoreRedirected", "(const QPaintDevice*)", "#")]
			void RestoreRedirected(IQPaintDevice device);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPainter), this);
			interceptor = (QPainter) realProxy.GetTransparentProxy();
		}
		private static IQPainterProxy staticInterceptor = null;
		static QPainter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPainterProxy), null);
			staticInterceptor = (IQPainterProxy) realProxy.GetTransparentProxy();
		}
		public enum RenderHint {
			Antialiasing = 0x01,
			TextAntialiasing = 0x02,
			SmoothPixmapTransform = 0x04,
		}
		public enum CompositionMode {
			CompositionMode_SourceOver = 0,
			CompositionMode_DestinationOver = 1,
			CompositionMode_Clear = 2,
			CompositionMode_Source = 3,
			CompositionMode_Destination = 4,
			CompositionMode_SourceIn = 5,
			CompositionMode_DestinationIn = 6,
			CompositionMode_SourceOut = 7,
			CompositionMode_DestinationOut = 8,
			CompositionMode_SourceAtop = 9,
			CompositionMode_DestinationAtop = 10,
			CompositionMode_Xor = 11,
		}
		public QPainter() : this((Type) null) {
			CreateProxy();
			NewQPainter();
		}
		[SmokeMethod("QPainter", "()", "")]
		private void NewQPainter() {
			((QPainter) interceptor).NewQPainter();
		}
		public QPainter(IQPaintDevice arg1) : this((Type) null) {
			CreateProxy();
			NewQPainter(arg1);
		}
		[SmokeMethod("QPainter", "(QPaintDevice*)", "#")]
		private void NewQPainter(IQPaintDevice arg1) {
			((QPainter) interceptor).NewQPainter(arg1);
		}
		[SmokeMethod("device", "() const", "")]
		public IQPaintDevice Device() {
			return ((QPainter) interceptor).Device();
		}
		[SmokeMethod("begin", "(QPaintDevice*)", "#")]
		public bool Begin(IQPaintDevice arg1) {
			return ((QPainter) interceptor).Begin(arg1);
		}
		[SmokeMethod("end", "()", "")]
		public bool End() {
			return ((QPainter) interceptor).End();
		}
		[SmokeMethod("isActive", "() const", "")]
		public bool IsActive() {
			return ((QPainter) interceptor).IsActive();
		}
		[SmokeMethod("initFrom", "(const QWidget*)", "#")]
		public void InitFrom(QWidget widget) {
			((QPainter) interceptor).InitFrom(widget);
		}
		[SmokeMethod("setCompositionMode", "(QPainter::CompositionMode)", "$")]
		public void SetCompositionMode(QPainter.CompositionMode mode) {
			((QPainter) interceptor).SetCompositionMode(mode);
		}
		[SmokeMethod("compositionMode", "() const", "")]
		public QPainter.CompositionMode compositionMode() {
			return ((QPainter) interceptor).compositionMode();
		}
		[SmokeMethod("font", "() const", "")]
		public QFont Font() {
			return ((QPainter) interceptor).Font();
		}
		[SmokeMethod("setFont", "(const QFont&)", "#")]
		public void SetFont(QFont f) {
			((QPainter) interceptor).SetFont(f);
		}
		[SmokeMethod("fontMetrics", "() const", "")]
		public QFontMetrics FontMetrics() {
			return ((QPainter) interceptor).FontMetrics();
		}
		[SmokeMethod("fontInfo", "() const", "")]
		public QFontInfo FontInfo() {
			return ((QPainter) interceptor).FontInfo();
		}
		[SmokeMethod("setPen", "(const QColor&)", "#")]
		public void SetPen(QColor color) {
			((QPainter) interceptor).SetPen(color);
		}
		[SmokeMethod("setPen", "(const QPen&)", "#")]
		public void SetPen(QPen pen) {
			((QPainter) interceptor).SetPen(pen);
		}
		[SmokeMethod("setPen", "(Qt::PenStyle)", "$")]
		public void SetPen(Qt.PenStyle style) {
			((QPainter) interceptor).SetPen(style);
		}
		[SmokeMethod("pen", "() const", "")]
		public QPen Pen() {
			return ((QPainter) interceptor).Pen();
		}
		[SmokeMethod("setBrush", "(const QBrush&)", "#")]
		public void SetBrush(QBrush brush) {
			((QPainter) interceptor).SetBrush(brush);
		}
		[SmokeMethod("setBrush", "(Qt::BrushStyle)", "$")]
		public void SetBrush(Qt.BrushStyle style) {
			((QPainter) interceptor).SetBrush(style);
		}
		[SmokeMethod("brush", "() const", "")]
		public QBrush Brush() {
			return ((QPainter) interceptor).Brush();
		}
		[SmokeMethod("setBackgroundMode", "(Qt::BGMode)", "$")]
		public void SetBackgroundMode(Qt.BGMode mode) {
			((QPainter) interceptor).SetBackgroundMode(mode);
		}
		[SmokeMethod("backgroundMode", "() const", "")]
		public Qt.BGMode BackgroundMode() {
			return ((QPainter) interceptor).BackgroundMode();
		}
		[SmokeMethod("brushOrigin", "() const", "")]
		public QPoint BrushOrigin() {
			return ((QPainter) interceptor).BrushOrigin();
		}
		[SmokeMethod("setBrushOrigin", "(int, int)", "$$")]
		public void SetBrushOrigin(int x, int y) {
			((QPainter) interceptor).SetBrushOrigin(x,y);
		}
		[SmokeMethod("setBrushOrigin", "(const QPoint&)", "#")]
		public void SetBrushOrigin(QPoint arg1) {
			((QPainter) interceptor).SetBrushOrigin(arg1);
		}
		[SmokeMethod("setBrushOrigin", "(const QPointF&)", "#")]
		public void SetBrushOrigin(QPointF arg1) {
			((QPainter) interceptor).SetBrushOrigin(arg1);
		}
		[SmokeMethod("setBackground", "(const QBrush&)", "#")]
		public void SetBackground(QBrush bg) {
			((QPainter) interceptor).SetBackground(bg);
		}
		[SmokeMethod("background", "() const", "")]
		public QBrush Background() {
			return ((QPainter) interceptor).Background();
		}
		[SmokeMethod("opacity", "() const", "")]
		public double Opacity() {
			return ((QPainter) interceptor).Opacity();
		}
		[SmokeMethod("setOpacity", "(qreal)", "$")]
		public void SetOpacity(double opacity) {
			((QPainter) interceptor).SetOpacity(opacity);
		}
		[SmokeMethod("clipRegion", "() const", "")]
		public QRegion ClipRegion() {
			return ((QPainter) interceptor).ClipRegion();
		}
		[SmokeMethod("clipPath", "() const", "")]
		public QPainterPath ClipPath() {
			return ((QPainter) interceptor).ClipPath();
		}
		[SmokeMethod("setClipRect", "(const QRectF&, Qt::ClipOperation)", "#$")]
		public void SetClipRect(QRectF arg1, Qt.ClipOperation op) {
			((QPainter) interceptor).SetClipRect(arg1,op);
		}
		[SmokeMethod("setClipRect", "(const QRectF&)", "#")]
		public void SetClipRect(QRectF arg1) {
			((QPainter) interceptor).SetClipRect(arg1);
		}
		[SmokeMethod("setClipRect", "(const QRect&, Qt::ClipOperation)", "#$")]
		public void SetClipRect(QRect arg1, Qt.ClipOperation op) {
			((QPainter) interceptor).SetClipRect(arg1,op);
		}
		[SmokeMethod("setClipRect", "(const QRect&)", "#")]
		public void SetClipRect(QRect arg1) {
			((QPainter) interceptor).SetClipRect(arg1);
		}
		[SmokeMethod("setClipRect", "(int, int, int, int, Qt::ClipOperation)", "$$$$$")]
		public void SetClipRect(int x, int y, int w, int h, Qt.ClipOperation op) {
			((QPainter) interceptor).SetClipRect(x,y,w,h,op);
		}
		[SmokeMethod("setClipRect", "(int, int, int, int)", "$$$$")]
		public void SetClipRect(int x, int y, int w, int h) {
			((QPainter) interceptor).SetClipRect(x,y,w,h);
		}
		[SmokeMethod("setClipRegion", "(const QRegion&, Qt::ClipOperation)", "#$")]
		public void SetClipRegion(QRegion arg1, Qt.ClipOperation op) {
			((QPainter) interceptor).SetClipRegion(arg1,op);
		}
		[SmokeMethod("setClipRegion", "(const QRegion&)", "#")]
		public void SetClipRegion(QRegion arg1) {
			((QPainter) interceptor).SetClipRegion(arg1);
		}
		[SmokeMethod("setClipPath", "(const QPainterPath&, Qt::ClipOperation)", "#$")]
		public void SetClipPath(QPainterPath path, Qt.ClipOperation op) {
			((QPainter) interceptor).SetClipPath(path,op);
		}
		[SmokeMethod("setClipPath", "(const QPainterPath&)", "#")]
		public void SetClipPath(QPainterPath path) {
			((QPainter) interceptor).SetClipPath(path);
		}
		[SmokeMethod("setClipping", "(bool)", "$")]
		public void SetClipping(bool enable) {
			((QPainter) interceptor).SetClipping(enable);
		}
		[SmokeMethod("hasClipping", "() const", "")]
		public bool HasClipping() {
			return ((QPainter) interceptor).HasClipping();
		}
		[SmokeMethod("save", "()", "")]
		public void Save() {
			((QPainter) interceptor).Save();
		}
		[SmokeMethod("restore", "()", "")]
		public void Restore() {
			((QPainter) interceptor).Restore();
		}
		[SmokeMethod("setMatrix", "(const QMatrix&, bool)", "#$")]
		public void SetMatrix(QMatrix matrix, bool combine) {
			((QPainter) interceptor).SetMatrix(matrix,combine);
		}
		[SmokeMethod("setMatrix", "(const QMatrix&)", "#")]
		public void SetMatrix(QMatrix matrix) {
			((QPainter) interceptor).SetMatrix(matrix);
		}
		[SmokeMethod("matrix", "() const", "")]
		public QMatrix Matrix() {
			return ((QPainter) interceptor).Matrix();
		}
		[SmokeMethod("deviceMatrix", "() const", "")]
		public QMatrix DeviceMatrix() {
			return ((QPainter) interceptor).DeviceMatrix();
		}
		[SmokeMethod("resetMatrix", "()", "")]
		public void ResetMatrix() {
			((QPainter) interceptor).ResetMatrix();
		}
		[SmokeMethod("setWorldMatrix", "(const QMatrix&, bool)", "#$")]
		public void SetWorldMatrix(QMatrix matrix, bool combine) {
			((QPainter) interceptor).SetWorldMatrix(matrix,combine);
		}
		[SmokeMethod("setWorldMatrix", "(const QMatrix&)", "#")]
		public void SetWorldMatrix(QMatrix matrix) {
			((QPainter) interceptor).SetWorldMatrix(matrix);
		}
		[SmokeMethod("worldMatrix", "() const", "")]
		public QMatrix WorldMatrix() {
			return ((QPainter) interceptor).WorldMatrix();
		}
		[SmokeMethod("combinedMatrix", "() const", "")]
		public QMatrix CombinedMatrix() {
			return ((QPainter) interceptor).CombinedMatrix();
		}
		[SmokeMethod("setMatrixEnabled", "(bool)", "$")]
		public void SetMatrixEnabled(bool enabled) {
			((QPainter) interceptor).SetMatrixEnabled(enabled);
		}
		[SmokeMethod("matrixEnabled", "() const", "")]
		public bool MatrixEnabled() {
			return ((QPainter) interceptor).MatrixEnabled();
		}
		[SmokeMethod("setWorldMatrixEnabled", "(bool)", "$")]
		public void SetWorldMatrixEnabled(bool enabled) {
			((QPainter) interceptor).SetWorldMatrixEnabled(enabled);
		}
		[SmokeMethod("worldMatrixEnabled", "() const", "")]
		public bool WorldMatrixEnabled() {
			return ((QPainter) interceptor).WorldMatrixEnabled();
		}
		[SmokeMethod("scale", "(qreal, qreal)", "$$")]
		public void Scale(double sx, double sy) {
			((QPainter) interceptor).Scale(sx,sy);
		}
		[SmokeMethod("shear", "(qreal, qreal)", "$$")]
		public void Shear(double sh, double sv) {
			((QPainter) interceptor).Shear(sh,sv);
		}
		[SmokeMethod("rotate", "(qreal)", "$")]
		public void Rotate(double a) {
			((QPainter) interceptor).Rotate(a);
		}
		[SmokeMethod("translate", "(const QPointF&)", "#")]
		public void Translate(QPointF offset) {
			((QPainter) interceptor).Translate(offset);
		}
		[SmokeMethod("translate", "(const QPoint&)", "#")]
		public void Translate(QPoint offset) {
			((QPainter) interceptor).Translate(offset);
		}
		[SmokeMethod("translate", "(qreal, qreal)", "$$")]
		public void Translate(double dx, double dy) {
			((QPainter) interceptor).Translate(dx,dy);
		}
		[SmokeMethod("window", "() const", "")]
		public QRect Window() {
			return ((QPainter) interceptor).Window();
		}
		[SmokeMethod("setWindow", "(const QRect&)", "#")]
		public void SetWindow(QRect window) {
			((QPainter) interceptor).SetWindow(window);
		}
		[SmokeMethod("setWindow", "(int, int, int, int)", "$$$$")]
		public void SetWindow(int x, int y, int w, int h) {
			((QPainter) interceptor).SetWindow(x,y,w,h);
		}
		[SmokeMethod("viewport", "() const", "")]
		public QRect Viewport() {
			return ((QPainter) interceptor).Viewport();
		}
		[SmokeMethod("setViewport", "(const QRect&)", "#")]
		public void SetViewport(QRect viewport) {
			((QPainter) interceptor).SetViewport(viewport);
		}
		[SmokeMethod("setViewport", "(int, int, int, int)", "$$$$")]
		public void SetViewport(int x, int y, int w, int h) {
			((QPainter) interceptor).SetViewport(x,y,w,h);
		}
		[SmokeMethod("setViewTransformEnabled", "(bool)", "$")]
		public void SetViewTransformEnabled(bool enable) {
			((QPainter) interceptor).SetViewTransformEnabled(enable);
		}
		[SmokeMethod("viewTransformEnabled", "() const", "")]
		public bool ViewTransformEnabled() {
			return ((QPainter) interceptor).ViewTransformEnabled();
		}
		[SmokeMethod("strokePath", "(const QPainterPath&, const QPen&)", "##")]
		public void StrokePath(QPainterPath path, QPen pen) {
			((QPainter) interceptor).StrokePath(path,pen);
		}
		[SmokeMethod("fillPath", "(const QPainterPath&, const QBrush&)", "##")]
		public void FillPath(QPainterPath path, QBrush brush) {
			((QPainter) interceptor).FillPath(path,brush);
		}
		[SmokeMethod("drawPath", "(const QPainterPath&)", "#")]
		public void DrawPath(QPainterPath path) {
			((QPainter) interceptor).DrawPath(path);
		}
		[SmokeMethod("drawPoint", "(const QPointF&)", "#")]
		public void DrawPoint(QPointF pt) {
			((QPainter) interceptor).DrawPoint(pt);
		}
		[SmokeMethod("drawPoint", "(const QPoint&)", "#")]
		public void DrawPoint(QPoint p) {
			((QPainter) interceptor).DrawPoint(p);
		}
		[SmokeMethod("drawPoint", "(int, int)", "$$")]
		public void DrawPoint(int x, int y) {
			((QPainter) interceptor).DrawPoint(x,y);
		}
		[SmokeMethod("drawPoints", "(const QPointF*, int)", "#$")]
		public void DrawPoints(QPointF points, int pointCount) {
			((QPainter) interceptor).DrawPoints(points,pointCount);
		}
		[SmokeMethod("drawPoints", "(const QPolygonF&)", "#")]
		public void DrawPoints(QPolygonF points) {
			((QPainter) interceptor).DrawPoints(points);
		}
		[SmokeMethod("drawPoints", "(const QPoint*, int)", "#$")]
		public void DrawPoints(QPoint points, int pointCount) {
			((QPainter) interceptor).DrawPoints(points,pointCount);
		}
		[SmokeMethod("drawPoints", "(const QPolygon&)", "#")]
		public void DrawPoints(QPolygon points) {
			((QPainter) interceptor).DrawPoints(points);
		}
		[SmokeMethod("drawLine", "(const QLineF&)", "#")]
		public void DrawLine(QLineF line) {
			((QPainter) interceptor).DrawLine(line);
		}
		[SmokeMethod("drawLine", "(const QLine&)", "#")]
		public void DrawLine(QLine line) {
			((QPainter) interceptor).DrawLine(line);
		}
		[SmokeMethod("drawLine", "(int, int, int, int)", "$$$$")]
		public void DrawLine(int x1, int y1, int x2, int y2) {
			((QPainter) interceptor).DrawLine(x1,y1,x2,y2);
		}
		[SmokeMethod("drawLine", "(const QPoint&, const QPoint&)", "##")]
		public void DrawLine(QPoint p1, QPoint p2) {
			((QPainter) interceptor).DrawLine(p1,p2);
		}
		[SmokeMethod("drawLine", "(const QPointF&, const QPointF&)", "##")]
		public void DrawLine(QPointF p1, QPointF p2) {
			((QPainter) interceptor).DrawLine(p1,p2);
		}
		[SmokeMethod("drawLines", "(const QLineF*, int)", "#$")]
		public void DrawLines(QLineF lines, int lineCount) {
			((QPainter) interceptor).DrawLines(lines,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QLineF>&)", "?")]
		public void DrawLines(List<QLineF> lines) {
			((QPainter) interceptor).DrawLines(lines);
		}
		[SmokeMethod("drawLines", "(const QPointF*, int)", "#$")]
		public void DrawLines(QPointF pointPairs, int lineCount) {
			((QPainter) interceptor).DrawLines(pointPairs,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QPointF>&)", "?")]
		public void DrawLines(List<QPointF> pointPairs) {
			((QPainter) interceptor).DrawLines(pointPairs);
		}
		[SmokeMethod("drawLines", "(const QLine*, int)", "#$")]
		public void DrawLines(QLine lines, int lineCount) {
			((QPainter) interceptor).DrawLines(lines,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QLine>&)", "?")]
		public void DrawLines(List<QLine> lines) {
			((QPainter) interceptor).DrawLines(lines);
		}
		[SmokeMethod("drawLines", "(const QPoint*, int)", "#$")]
		public void DrawLines(QPoint pointPairs, int lineCount) {
			((QPainter) interceptor).DrawLines(pointPairs,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QPoint>&)", "?")]
		public void DrawLines(List<QPoint> pointPairs) {
			((QPainter) interceptor).DrawLines(pointPairs);
		}
		[SmokeMethod("drawRect", "(const QRectF&)", "#")]
		public void DrawRect(QRectF rect) {
			((QPainter) interceptor).DrawRect(rect);
		}
		[SmokeMethod("drawRect", "(int, int, int, int)", "$$$$")]
		public void DrawRect(int x1, int y1, int w, int h) {
			((QPainter) interceptor).DrawRect(x1,y1,w,h);
		}
		[SmokeMethod("drawRect", "(const QRect&)", "#")]
		public void DrawRect(QRect rect) {
			((QPainter) interceptor).DrawRect(rect);
		}
		[SmokeMethod("drawRects", "(const QRectF*, int)", "#$")]
		public void DrawRects(QRectF rects, int rectCount) {
			((QPainter) interceptor).DrawRects(rects,rectCount);
		}
		[SmokeMethod("drawRects", "(const QVector<QRectF>&)", "?")]
		public void DrawRects(List<QRectF> rectangles) {
			((QPainter) interceptor).DrawRects(rectangles);
		}
		[SmokeMethod("drawRects", "(const QRect*, int)", "#$")]
		public void DrawRects(QRect rects, int rectCount) {
			((QPainter) interceptor).DrawRects(rects,rectCount);
		}
		[SmokeMethod("drawRects", "(const QVector<QRect>&)", "?")]
		public void DrawRects(List<QRect> rectangles) {
			((QPainter) interceptor).DrawRects(rectangles);
		}
		[SmokeMethod("drawEllipse", "(const QRectF&)", "#")]
		public void DrawEllipse(QRectF r) {
			((QPainter) interceptor).DrawEllipse(r);
		}
		[SmokeMethod("drawEllipse", "(const QRect&)", "#")]
		public void DrawEllipse(QRect r) {
			((QPainter) interceptor).DrawEllipse(r);
		}
		[SmokeMethod("drawEllipse", "(int, int, int, int)", "$$$$")]
		public void DrawEllipse(int x, int y, int w, int h) {
			((QPainter) interceptor).DrawEllipse(x,y,w,h);
		}
		[SmokeMethod("drawPolyline", "(const QPointF*, int)", "#$")]
		public void DrawPolyline(QPointF points, int pointCount) {
			((QPainter) interceptor).DrawPolyline(points,pointCount);
		}
		[SmokeMethod("drawPolyline", "(const QPolygonF&)", "#")]
		public void DrawPolyline(QPolygonF polyline) {
			((QPainter) interceptor).DrawPolyline(polyline);
		}
		[SmokeMethod("drawPolyline", "(const QPoint*, int)", "#$")]
		public void DrawPolyline(QPoint points, int pointCount) {
			((QPainter) interceptor).DrawPolyline(points,pointCount);
		}
		[SmokeMethod("drawPolyline", "(const QPolygon&)", "#")]
		public void DrawPolyline(QPolygon polygon) {
			((QPainter) interceptor).DrawPolyline(polygon);
		}
		[SmokeMethod("drawPolygon", "(const QPointF*, int, Qt::FillRule)", "#$$")]
		public void DrawPolygon(QPointF points, int pointCount, Qt.FillRule fillRule) {
			((QPainter) interceptor).DrawPolygon(points,pointCount,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPointF*, int)", "#$")]
		public void DrawPolygon(QPointF points, int pointCount) {
			((QPainter) interceptor).DrawPolygon(points,pointCount);
		}
		[SmokeMethod("drawPolygon", "(const QPolygonF&, Qt::FillRule)", "#$")]
		public void DrawPolygon(QPolygonF polygon, Qt.FillRule fillRule) {
			((QPainter) interceptor).DrawPolygon(polygon,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPolygonF&)", "#")]
		public void DrawPolygon(QPolygonF polygon) {
			((QPainter) interceptor).DrawPolygon(polygon);
		}
		[SmokeMethod("drawPolygon", "(const QPoint*, int, Qt::FillRule)", "#$$")]
		public void DrawPolygon(QPoint points, int pointCount, Qt.FillRule fillRule) {
			((QPainter) interceptor).DrawPolygon(points,pointCount,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPoint*, int)", "#$")]
		public void DrawPolygon(QPoint points, int pointCount) {
			((QPainter) interceptor).DrawPolygon(points,pointCount);
		}
		[SmokeMethod("drawPolygon", "(const QPolygon&, Qt::FillRule)", "#$")]
		public void DrawPolygon(QPolygon polygon, Qt.FillRule fillRule) {
			((QPainter) interceptor).DrawPolygon(polygon,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPolygon&)", "#")]
		public void DrawPolygon(QPolygon polygon) {
			((QPainter) interceptor).DrawPolygon(polygon);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPointF*, int)", "#$")]
		public void DrawConvexPolygon(QPointF points, int pointCount) {
			((QPainter) interceptor).DrawConvexPolygon(points,pointCount);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPolygonF&)", "#")]
		public void DrawConvexPolygon(QPolygonF polygon) {
			((QPainter) interceptor).DrawConvexPolygon(polygon);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPoint*, int)", "#$")]
		public void DrawConvexPolygon(QPoint points, int pointCount) {
			((QPainter) interceptor).DrawConvexPolygon(points,pointCount);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPolygon&)", "#")]
		public void DrawConvexPolygon(QPolygon polygon) {
			((QPainter) interceptor).DrawConvexPolygon(polygon);
		}
		[SmokeMethod("drawArc", "(const QRectF&, int, int)", "#$$")]
		public void DrawArc(QRectF rect, int a, int alen) {
			((QPainter) interceptor).DrawArc(rect,a,alen);
		}
		[SmokeMethod("drawArc", "(const QRect&, int, int)", "#$$")]
		public void DrawArc(QRect arg1, int a, int alen) {
			((QPainter) interceptor).DrawArc(arg1,a,alen);
		}
		[SmokeMethod("drawArc", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawArc(int x, int y, int w, int h, int a, int alen) {
			((QPainter) interceptor).DrawArc(x,y,w,h,a,alen);
		}
		[SmokeMethod("drawPie", "(const QRectF&, int, int)", "#$$")]
		public void DrawPie(QRectF rect, int a, int alen) {
			((QPainter) interceptor).DrawPie(rect,a,alen);
		}
		[SmokeMethod("drawPie", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawPie(int x, int y, int w, int h, int a, int alen) {
			((QPainter) interceptor).DrawPie(x,y,w,h,a,alen);
		}
		[SmokeMethod("drawPie", "(const QRect&, int, int)", "#$$")]
		public void DrawPie(QRect arg1, int a, int alen) {
			((QPainter) interceptor).DrawPie(arg1,a,alen);
		}
		[SmokeMethod("drawChord", "(const QRectF&, int, int)", "#$$")]
		public void DrawChord(QRectF rect, int a, int alen) {
			((QPainter) interceptor).DrawChord(rect,a,alen);
		}
		[SmokeMethod("drawChord", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawChord(int x, int y, int w, int h, int a, int alen) {
			((QPainter) interceptor).DrawChord(x,y,w,h,a,alen);
		}
		[SmokeMethod("drawChord", "(const QRect&, int, int)", "#$$")]
		public void DrawChord(QRect arg1, int a, int alen) {
			((QPainter) interceptor).DrawChord(arg1,a,alen);
		}
		[SmokeMethod("drawRoundRect", "(const QRectF&, int, int)", "#$$")]
		public void DrawRoundRect(QRectF r, int xround, int yround) {
			((QPainter) interceptor).DrawRoundRect(r,xround,yround);
		}
		[SmokeMethod("drawRoundRect", "(const QRectF&, int)", "#$")]
		public void DrawRoundRect(QRectF r, int xround) {
			((QPainter) interceptor).DrawRoundRect(r,xround);
		}
		[SmokeMethod("drawRoundRect", "(const QRectF&)", "#")]
		public void DrawRoundRect(QRectF r) {
			((QPainter) interceptor).DrawRoundRect(r);
		}
		[SmokeMethod("drawRoundRect", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawRoundRect(int x, int y, int w, int h, int arg5, int arg6) {
			((QPainter) interceptor).DrawRoundRect(x,y,w,h,arg5,arg6);
		}
		[SmokeMethod("drawRoundRect", "(int, int, int, int, int)", "$$$$$")]
		public void DrawRoundRect(int x, int y, int w, int h, int arg5) {
			((QPainter) interceptor).DrawRoundRect(x,y,w,h,arg5);
		}
		[SmokeMethod("drawRoundRect", "(int, int, int, int)", "$$$$")]
		public void DrawRoundRect(int x, int y, int w, int h) {
			((QPainter) interceptor).DrawRoundRect(x,y,w,h);
		}
		[SmokeMethod("drawRoundRect", "(const QRect&, int, int)", "#$$")]
		public void DrawRoundRect(QRect r, int xround, int yround) {
			((QPainter) interceptor).DrawRoundRect(r,xround,yround);
		}
		[SmokeMethod("drawRoundRect", "(const QRect&, int)", "#$")]
		public void DrawRoundRect(QRect r, int xround) {
			((QPainter) interceptor).DrawRoundRect(r,xround);
		}
		[SmokeMethod("drawRoundRect", "(const QRect&)", "#")]
		public void DrawRoundRect(QRect r) {
			((QPainter) interceptor).DrawRoundRect(r);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRectF&, const QPixmap&, const QPointF&)", "###")]
		public void DrawTiledPixmap(QRectF rect, QPixmap pm, QPointF offset) {
			((QPainter) interceptor).DrawTiledPixmap(rect,pm,offset);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRectF&, const QPixmap&)", "##")]
		public void DrawTiledPixmap(QRectF rect, QPixmap pm) {
			((QPainter) interceptor).DrawTiledPixmap(rect,pm);
		}
		[SmokeMethod("drawTiledPixmap", "(int, int, int, int, const QPixmap&, int, int)", "$$$$#$$")]
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5, int sx, int sy) {
			((QPainter) interceptor).DrawTiledPixmap(x,y,w,h,arg5,sx,sy);
		}
		[SmokeMethod("drawTiledPixmap", "(int, int, int, int, const QPixmap&, int)", "$$$$#$")]
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5, int sx) {
			((QPainter) interceptor).DrawTiledPixmap(x,y,w,h,arg5,sx);
		}
		[SmokeMethod("drawTiledPixmap", "(int, int, int, int, const QPixmap&)", "$$$$#")]
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5) {
			((QPainter) interceptor).DrawTiledPixmap(x,y,w,h,arg5);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRect&, const QPixmap&, const QPoint&)", "###")]
		public void DrawTiledPixmap(QRect arg1, QPixmap arg2, QPoint arg3) {
			((QPainter) interceptor).DrawTiledPixmap(arg1,arg2,arg3);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRect&, const QPixmap&)", "##")]
		public void DrawTiledPixmap(QRect arg1, QPixmap arg2) {
			((QPainter) interceptor).DrawTiledPixmap(arg1,arg2);
		}
		[SmokeMethod("drawPicture", "(const QPointF&, const QPicture&)", "##")]
		public void DrawPicture(QPointF p, QPicture picture) {
			((QPainter) interceptor).DrawPicture(p,picture);
		}
		[SmokeMethod("drawPicture", "(int, int, const QPicture&)", "$$#")]
		public void DrawPicture(int x, int y, QPicture picture) {
			((QPainter) interceptor).DrawPicture(x,y,picture);
		}
		[SmokeMethod("drawPicture", "(const QPoint&, const QPicture&)", "##")]
		public void DrawPicture(QPoint p, QPicture picture) {
			((QPainter) interceptor).DrawPicture(p,picture);
		}
		[SmokeMethod("drawPixmap", "(const QRectF&, const QPixmap&, const QRectF&)", "###")]
		public void DrawPixmap(QRectF targetRect, QPixmap pixmap, QRectF sourceRect) {
			((QPainter) interceptor).DrawPixmap(targetRect,pixmap,sourceRect);
		}
		[SmokeMethod("drawPixmap", "(const QRect&, const QPixmap&, const QRect&)", "###")]
		public void DrawPixmap(QRect targetRect, QPixmap pixmap, QRect sourceRect) {
			((QPainter) interceptor).DrawPixmap(targetRect,pixmap,sourceRect);
		}
		[SmokeMethod("drawPixmap", "(int, int, int, int, const QPixmap&, int, int, int, int)", "$$$$#$$$$")]
		public void DrawPixmap(int x, int y, int w, int h, QPixmap pm, int sx, int sy, int sw, int sh) {
			((QPainter) interceptor).DrawPixmap(x,y,w,h,pm,sx,sy,sw,sh);
		}
		[SmokeMethod("drawPixmap", "(int, int, const QPixmap&, int, int, int, int)", "$$#$$$$")]
		public void DrawPixmap(int x, int y, QPixmap pm, int sx, int sy, int sw, int sh) {
			((QPainter) interceptor).DrawPixmap(x,y,pm,sx,sy,sw,sh);
		}
		[SmokeMethod("drawPixmap", "(const QPointF&, const QPixmap&, const QRectF&)", "###")]
		public void DrawPixmap(QPointF p, QPixmap pm, QRectF sr) {
			((QPainter) interceptor).DrawPixmap(p,pm,sr);
		}
		[SmokeMethod("drawPixmap", "(const QPoint&, const QPixmap&, const QRect&)", "###")]
		public void DrawPixmap(QPoint p, QPixmap pm, QRect sr) {
			((QPainter) interceptor).DrawPixmap(p,pm,sr);
		}
		[SmokeMethod("drawPixmap", "(const QPointF&, const QPixmap&)", "##")]
		public void DrawPixmap(QPointF p, QPixmap pm) {
			((QPainter) interceptor).DrawPixmap(p,pm);
		}
		[SmokeMethod("drawPixmap", "(const QPoint&, const QPixmap&)", "##")]
		public void DrawPixmap(QPoint p, QPixmap pm) {
			((QPainter) interceptor).DrawPixmap(p,pm);
		}
		[SmokeMethod("drawPixmap", "(int, int, const QPixmap&)", "$$#")]
		public void DrawPixmap(int x, int y, QPixmap pm) {
			((QPainter) interceptor).DrawPixmap(x,y,pm);
		}
		[SmokeMethod("drawPixmap", "(const QRect&, const QPixmap&)", "##")]
		public void DrawPixmap(QRect r, QPixmap pm) {
			((QPainter) interceptor).DrawPixmap(r,pm);
		}
		[SmokeMethod("drawPixmap", "(int, int, int, int, const QPixmap&)", "$$$$#")]
		public void DrawPixmap(int x, int y, int w, int h, QPixmap pm) {
			((QPainter) interceptor).DrawPixmap(x,y,w,h,pm);
		}
		[SmokeMethod("drawImage", "(const QRectF&, const QImage&, const QRectF&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QRectF targetRect, QImage image, QRectF sourceRect, int flags) {
			((QPainter) interceptor).DrawImage(targetRect,image,sourceRect,flags);
		}
		[SmokeMethod("drawImage", "(const QRectF&, const QImage&, const QRectF&)", "###")]
		public void DrawImage(QRectF targetRect, QImage image, QRectF sourceRect) {
			((QPainter) interceptor).DrawImage(targetRect,image,sourceRect);
		}
		[SmokeMethod("drawImage", "(const QRect&, const QImage&, const QRect&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QRect targetRect, QImage image, QRect sourceRect, int flags) {
			((QPainter) interceptor).DrawImage(targetRect,image,sourceRect,flags);
		}
		[SmokeMethod("drawImage", "(const QRect&, const QImage&, const QRect&)", "###")]
		public void DrawImage(QRect targetRect, QImage image, QRect sourceRect) {
			((QPainter) interceptor).DrawImage(targetRect,image,sourceRect);
		}
		[SmokeMethod("drawImage", "(const QPointF&, const QImage&, const QRectF&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QPointF p, QImage image, QRectF sr, int flags) {
			((QPainter) interceptor).DrawImage(p,image,sr,flags);
		}
		[SmokeMethod("drawImage", "(const QPointF&, const QImage&, const QRectF&)", "###")]
		public void DrawImage(QPointF p, QImage image, QRectF sr) {
			((QPainter) interceptor).DrawImage(p,image,sr);
		}
		[SmokeMethod("drawImage", "(const QPoint&, const QImage&, const QRect&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QPoint p, QImage image, QRect sr, int flags) {
			((QPainter) interceptor).DrawImage(p,image,sr,flags);
		}
		[SmokeMethod("drawImage", "(const QPoint&, const QImage&, const QRect&)", "###")]
		public void DrawImage(QPoint p, QImage image, QRect sr) {
			((QPainter) interceptor).DrawImage(p,image,sr);
		}
		[SmokeMethod("drawImage", "(const QRectF&, const QImage&)", "##")]
		public void DrawImage(QRectF r, QImage image) {
			((QPainter) interceptor).DrawImage(r,image);
		}
		[SmokeMethod("drawImage", "(const QRect&, const QImage&)", "##")]
		public void DrawImage(QRect r, QImage image) {
			((QPainter) interceptor).DrawImage(r,image);
		}
		[SmokeMethod("drawImage", "(const QPointF&, const QImage&)", "##")]
		public void DrawImage(QPointF p, QImage image) {
			((QPainter) interceptor).DrawImage(p,image);
		}
		[SmokeMethod("drawImage", "(const QPoint&, const QImage&)", "##")]
		public void DrawImage(QPoint p, QImage image) {
			((QPainter) interceptor).DrawImage(p,image);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int, int, int, Qt::ImageConversionFlags)", "$$#$$$$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy, int sw, int sh, int flags) {
			((QPainter) interceptor).DrawImage(x,y,image,sx,sy,sw,sh,flags);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int, int, int)", "$$#$$$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy, int sw, int sh) {
			((QPainter) interceptor).DrawImage(x,y,image,sx,sy,sw,sh);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int, int)", "$$#$$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy, int sw) {
			((QPainter) interceptor).DrawImage(x,y,image,sx,sy,sw);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int)", "$$#$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy) {
			((QPainter) interceptor).DrawImage(x,y,image,sx,sy);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int)", "$$#$")]
		public void DrawImage(int x, int y, QImage image, int sx) {
			((QPainter) interceptor).DrawImage(x,y,image,sx);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&)", "$$#")]
		public void DrawImage(int x, int y, QImage image) {
			((QPainter) interceptor).DrawImage(x,y,image);
		}
		[SmokeMethod("setLayoutDirection", "(Qt::LayoutDirection)", "$")]
		public void SetLayoutDirection(Qt.LayoutDirection direction) {
			((QPainter) interceptor).SetLayoutDirection(direction);
		}
		[SmokeMethod("layoutDirection", "() const", "")]
		public Qt.LayoutDirection LayoutDirection() {
			return ((QPainter) interceptor).LayoutDirection();
		}
		[SmokeMethod("drawText", "(const QPointF&, const QString&)", "#$")]
		public void DrawText(QPointF p, string s) {
			((QPainter) interceptor).DrawText(p,s);
		}
		[SmokeMethod("drawText", "(const QPoint&, const QString&)", "#$")]
		public void DrawText(QPoint p, string s) {
			((QPainter) interceptor).DrawText(p,s);
		}
		[SmokeMethod("drawText", "(int, int, const QString&)", "$$$")]
		public void DrawText(int x, int y, string s) {
			((QPainter) interceptor).DrawText(x,y,s);
		}
		[SmokeMethod("drawText", "(const QRectF&, int, const QString&, QRectF*)", "#$$#")]
		public void DrawText(QRectF r, int flags, string text, QRectF br) {
			((QPainter) interceptor).DrawText(r,flags,text,br);
		}
		[SmokeMethod("drawText", "(const QRectF&, int, const QString&)", "#$$")]
		public void DrawText(QRectF r, int flags, string text) {
			((QPainter) interceptor).DrawText(r,flags,text);
		}
		[SmokeMethod("drawText", "(const QRect&, int, const QString&, QRect*)", "#$$#")]
		public void DrawText(QRect r, int flags, string text, QRect br) {
			((QPainter) interceptor).DrawText(r,flags,text,br);
		}
		[SmokeMethod("drawText", "(const QRect&, int, const QString&)", "#$$")]
		public void DrawText(QRect r, int flags, string text) {
			((QPainter) interceptor).DrawText(r,flags,text);
		}
		[SmokeMethod("drawText", "(int, int, int, int, int, const QString&, QRect*)", "$$$$$$#")]
		public void DrawText(int x, int y, int w, int h, int flags, string text, QRect br) {
			((QPainter) interceptor).DrawText(x,y,w,h,flags,text,br);
		}
		[SmokeMethod("drawText", "(int, int, int, int, int, const QString&)", "$$$$$$")]
		public void DrawText(int x, int y, int w, int h, int flags, string text) {
			((QPainter) interceptor).DrawText(x,y,w,h,flags,text);
		}
		[SmokeMethod("drawText", "(const QRectF&, const QString&, const QTextOption&)", "#$#")]
		public void DrawText(QRectF r, string text, QTextOption o) {
			((QPainter) interceptor).DrawText(r,text,o);
		}
		[SmokeMethod("drawText", "(const QRectF&, const QString&)", "#$")]
		public void DrawText(QRectF r, string text) {
			((QPainter) interceptor).DrawText(r,text);
		}
		[SmokeMethod("boundingRect", "(const QRectF&, int, const QString&)", "#$$")]
		public QRectF BoundingRect(QRectF rect, int flags, string text) {
			return ((QPainter) interceptor).BoundingRect(rect,flags,text);
		}
		[SmokeMethod("boundingRect", "(const QRect&, int, const QString&)", "#$$")]
		public QRect BoundingRect(QRect rect, int flags, string text) {
			return ((QPainter) interceptor).BoundingRect(rect,flags,text);
		}
		[SmokeMethod("boundingRect", "(int, int, int, int, int, const QString&)", "$$$$$$")]
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string text) {
			return ((QPainter) interceptor).BoundingRect(x,y,w,h,flags,text);
		}
		[SmokeMethod("boundingRect", "(const QRectF&, const QString&, const QTextOption&)", "#$#")]
		public QRectF BoundingRect(QRectF rect, string text, QTextOption o) {
			return ((QPainter) interceptor).BoundingRect(rect,text,o);
		}
		[SmokeMethod("boundingRect", "(const QRectF&, const QString&)", "#$")]
		public QRectF BoundingRect(QRectF rect, string text) {
			return ((QPainter) interceptor).BoundingRect(rect,text);
		}
		[SmokeMethod("fillRect", "(const QRectF&, const QBrush&)", "##")]
		public void FillRect(QRectF arg1, QBrush arg2) {
			((QPainter) interceptor).FillRect(arg1,arg2);
		}
		[SmokeMethod("fillRect", "(int, int, int, int, const QBrush&)", "$$$$#")]
		public void FillRect(int x, int y, int w, int h, QBrush arg5) {
			((QPainter) interceptor).FillRect(x,y,w,h,arg5);
		}
		[SmokeMethod("fillRect", "(const QRect&, const QBrush&)", "##")]
		public void FillRect(QRect arg1, QBrush arg2) {
			((QPainter) interceptor).FillRect(arg1,arg2);
		}
		[SmokeMethod("eraseRect", "(const QRectF&)", "#")]
		public void EraseRect(QRectF arg1) {
			((QPainter) interceptor).EraseRect(arg1);
		}
		[SmokeMethod("eraseRect", "(int, int, int, int)", "$$$$")]
		public void EraseRect(int x, int y, int w, int h) {
			((QPainter) interceptor).EraseRect(x,y,w,h);
		}
		[SmokeMethod("eraseRect", "(const QRect&)", "#")]
		public void EraseRect(QRect arg1) {
			((QPainter) interceptor).EraseRect(arg1);
		}
		[SmokeMethod("setRenderHint", "(QPainter::RenderHint, bool)", "$$")]
		public void SetRenderHint(QPainter.RenderHint hint, bool on) {
			((QPainter) interceptor).SetRenderHint(hint,on);
		}
		[SmokeMethod("setRenderHint", "(QPainter::RenderHint)", "$")]
		public void SetRenderHint(QPainter.RenderHint hint) {
			((QPainter) interceptor).SetRenderHint(hint);
		}
		[SmokeMethod("setRenderHints", "(RenderHints, bool)", "$$")]
		public void SetRenderHints(int hints, bool on) {
			((QPainter) interceptor).SetRenderHints(hints,on);
		}
		[SmokeMethod("setRenderHints", "(RenderHints)", "$")]
		public void SetRenderHints(int hints) {
			((QPainter) interceptor).SetRenderHints(hints);
		}
		[SmokeMethod("renderHints", "() const", "")]
		public int RenderHints() {
			return ((QPainter) interceptor).RenderHints();
		}
		[SmokeMethod("paintEngine", "() const", "")]
		public QPaintEngine PaintEngine() {
			return ((QPainter) interceptor).PaintEngine();
		}
		~QPainter() {
			DisposeQPainter();
		}
		public void Dispose() {
			DisposeQPainter();
		}
		[SmokeMethod("~QPainter", "()", "")]
		private void DisposeQPainter() {
			((QPainter) interceptor).DisposeQPainter();
		}
		public static void SetRedirected(IQPaintDevice device, IQPaintDevice replacement, QPoint offset) {
			staticInterceptor.SetRedirected(device,replacement,offset);
		}
		public static void SetRedirected(IQPaintDevice device, IQPaintDevice replacement) {
			staticInterceptor.SetRedirected(device,replacement);
		}
		public static IQPaintDevice Redirected(IQPaintDevice device, QPoint offset) {
			return staticInterceptor.Redirected(device,offset);
		}
		public static IQPaintDevice Redirected(IQPaintDevice device) {
			return staticInterceptor.Redirected(device);
		}
		public static void RestoreRedirected(IQPaintDevice device) {
			staticInterceptor.RestoreRedirected(device);
		}
	}
}
