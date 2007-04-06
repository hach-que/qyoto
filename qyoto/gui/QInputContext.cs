//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QInputContext")]
	public abstract class QInputContext : QObject {
 		protected QInputContext(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QInputContext), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QInputContext() {
			staticInterceptor = new SmokeInvocation(typeof(QInputContext), null);
		}
		public enum StandardFormat {
			PreeditFormat = 0,
			SelectionFormat = 1,
		}
		public QInputContext(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QInputContext#", "QInputContext(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QInputContext() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QInputContext", "QInputContext()", typeof(void));
		}
		[SmokeMethod("identifierName()")]
		public abstract string IdentifierName();
		[SmokeMethod("language()")]
		public abstract string Language();
		[SmokeMethod("reset()")]
		public abstract void Reset();
		[SmokeMethod("update()")]
		public virtual void Update() {
			interceptor.Invoke("update", "update()", typeof(void));
		}
		[SmokeMethod("mouseHandler(int, QMouseEvent*)")]
		public virtual void MouseHandler(int x, QMouseEvent arg2) {
			interceptor.Invoke("mouseHandler$#", "mouseHandler(int, QMouseEvent*)", typeof(void), typeof(int), x, typeof(QMouseEvent), arg2);
		}
		[SmokeMethod("font() const")]
		public virtual QFont Font() {
			return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
		}
		[SmokeMethod("isComposing() const")]
		public abstract bool IsComposing();
		public QWidget FocusWidget() {
			return (QWidget) interceptor.Invoke("focusWidget", "focusWidget() const", typeof(QWidget));
		}
		[SmokeMethod("setFocusWidget(QWidget*)")]
		public virtual void SetFocusWidget(QWidget w) {
			interceptor.Invoke("setFocusWidget#", "setFocusWidget(QWidget*)", typeof(void), typeof(QWidget), w);
		}
		[SmokeMethod("widgetDestroyed(QWidget*)")]
		public virtual void WidgetDestroyed(QWidget w) {
			interceptor.Invoke("widgetDestroyed#", "widgetDestroyed(QWidget*)", typeof(void), typeof(QWidget), w);
		}
		[SmokeMethod("actions()")]
		public virtual List<QAction> Actions() {
			return (List<QAction>) interceptor.Invoke("actions", "actions()", typeof(List<QAction>));
		}
		[SmokeMethod("filterEvent(const QEvent*)")]
		public virtual bool FilterEvent(QEvent arg1) {
			return (bool) interceptor.Invoke("filterEvent#", "filterEvent(const QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		public void SendEvent(QInputMethodEvent arg1) {
			interceptor.Invoke("sendEvent#", "sendEvent(const QInputMethodEvent&)", typeof(void), typeof(QInputMethodEvent), arg1);
		}
		public QTextFormat standardFormat(QInputContext.StandardFormat s) {
			return (QTextFormat) interceptor.Invoke("standardFormat$", "standardFormat(QInputContext::StandardFormat) const", typeof(QTextFormat), typeof(QInputContext.StandardFormat), s);
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQInputContextSignals Emit {
			get { return (IQInputContextSignals) Q_EMIT; }
		}
	}

	public interface IQInputContextSignals : IQObjectSignals {
	}
}
