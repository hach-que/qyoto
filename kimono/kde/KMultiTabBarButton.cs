//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Use KMultiTabBar.AppendButton to append a button, which creates a KMultiTabBarButton instance
	///   See <see cref="IKMultiTabBarButtonSignals"></see> for signals emitted by KMultiTabBarButton
	/// </remarks>		<short>    Use KMultiTabBar.AppendButton to append a button, which creates a KMultiTabBarButton instance  </short>

	[SmokeClass("KMultiTabBarButton")]
	public class KMultiTabBarButton : QPushButton, IDisposable {
 		protected KMultiTabBarButton(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KMultiTabBarButton), this);
		}
		public int Id() {
			return (int) interceptor.Invoke("id", "id() const", typeof(int));
		}
		[Q_SLOT("void setText(const QString&)")]
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected override void HideEvent(QHideEvent arg1) {
			interceptor.Invoke("hideEvent#", "hideEvent(QHideEvent*)", typeof(void), typeof(QHideEvent), arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		/// <remarks> Should not be created directly. Use KMultiTabBar.AppendButton
		///     </remarks>		<short>   Should not be created directly.</short>
		public KMultiTabBarButton(QPixmap pic, string arg2, int id, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMultiTabBarButton#$$#", "KMultiTabBarButton(const QPixmap&, const QString&, int, QWidget*)", typeof(void), typeof(QPixmap), pic, typeof(string), arg2, typeof(int), id, typeof(QWidget), parent);
		}
		[Q_SLOT("void slotClicked()")]
		[SmokeMethod("slotClicked()")]
		protected virtual void SlotClicked() {
			interceptor.Invoke("slotClicked", "slotClicked()", typeof(void));
		}
		~KMultiTabBarButton() {
			interceptor.Invoke("~KMultiTabBarButton", "~KMultiTabBarButton()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KMultiTabBarButton", "~KMultiTabBarButton()", typeof(void));
		}
		protected new IKMultiTabBarButtonSignals Emit {
			get { return (IKMultiTabBarButtonSignals) Q_EMIT; }
		}
	}

	public interface IKMultiTabBarButtonSignals : IQPushButtonSignals {
		/// <remarks>
		///  this is emitted if  the button is clicked
		/// <param> name="id" the ID identifying the button
		///      </param></remarks>		<short>    this is emitted if  the button is clicked </short>
		[Q_SIGNAL("void clicked(int)")]
		void Clicked(int id);
	}
}
