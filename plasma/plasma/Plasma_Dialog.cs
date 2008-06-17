//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks>
	///  Dialog provides a dialog-like widget that can be used to display additional
	///  information.
	///  Dialog uses the plasma theme, and usually has no window decoration. It's meant
	///  as an interim solution to display widgets as extension to plasma applets, for
	///  example when you click on an applet like the devicenotifier or the clock, the
	///  widget that is then displayed, is a Dialog.
	///  </remarks>		<short> A dialog that uses the Plasma style.</short>
	[SmokeClass("Plasma::Dialog")]
	public class Dialog : QWidget, IDisposable {
 		protected Dialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Dialog), this);
		}
		/// <remarks>
		///  @arg parent the parent widget, for plasmoids, this is usually 0.
		///  @arg f the Qt.WindowFlags, default is to not show a windowborder.
		///          </remarks>		<short>    @arg parent the parent widget, for plasmoids, this is usually 0.</short>
		public Dialog(QWidget parent, uint f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Dialog#$", "Dialog(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), f);
		}
		public Dialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Dialog#", "Dialog(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public Dialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Dialog", "Dialog()", typeof(void));
		}
		/// <remarks>
		///  @arg event the event that is used to position the dialog. Usually, you want
		///  to pass this on from the mouseevent.
		///  @arg boundingRect the boundingRect() from the applet.
		///  @arg scenePos the absolute position on the scene.
		///          </remarks>		<short>    @arg event the event that is used to position the dialog.</short>
		public void position(QGraphicsSceneEvent arg1, QRectF boundingRect, QPointF scenePos) {
			interceptor.Invoke("position###", "position(QGraphicsSceneEvent*, const QRectF, QPointF)", typeof(void), typeof(QGraphicsSceneEvent), arg1, typeof(QRectF), boundingRect, typeof(QPointF), scenePos);
		}
		/// <remarks>
		///  @arg view The QGV where is displayed the applet
		///  @arg scenePos the absolute position on the scene.
		///  @arg boundingRect the boundingRect() from the applet.
		///          </remarks>		<short>    @arg view The QGV where is displayed the applet  @arg scenePos the absolute position on the scene.</short>
		public void position(QGraphicsView view, QRectF boundingRect, QPointF scenePos) {
			interceptor.Invoke("position###", "position(QGraphicsView*, const QRectF, QPointF)", typeof(void), typeof(QGraphicsView), view, typeof(QRectF), boundingRect, typeof(QPointF), scenePos);
		}
		/// <remarks>
		///  Reimplemented from QWidget
		///          </remarks>		<short>    Reimplemented from QWidget          </short>
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent e) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent e) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), e);
		}
		~Dialog() {
			interceptor.Invoke("~Dialog", "~Dialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Dialog", "~Dialog()", typeof(void));
		}
		protected new IDialogSignals Emit {
			get { return (IDialogSignals) Q_EMIT; }
		}
	}

	public interface IDialogSignals : IQWidgetSignals {
	}
}