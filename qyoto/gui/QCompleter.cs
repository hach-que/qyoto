//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQCompleterSignals"></see> for signals emitted by QCompleter
	[SmokeClass("QCompleter")]
	public class QCompleter : QObject, IDisposable {
 		protected QCompleter(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QCompleter), "QCompleter", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QCompleter() {
			staticInterceptor = new SmokeInvocation(typeof(QCompleter), "QCompleter", null);
		}
		public enum CompletionMode {
			PopupCompletion = 0,
			UnfilteredPopupCompletion = 1,
			InlineCompletion = 2,
		}
		public enum ModelSorting {
			UnsortedModel = 0,
			CaseSensitivelySortedModel = 1,
			CaseInsensitivelySortedModel = 2,
		}
		[Q_PROPERTY("QString", "completionPrefix")]
		public string CompletionPrefix {
			get { return (string) interceptor.Invoke("completionPrefix", "completionPrefix()", typeof(string)); }
			set { interceptor.Invoke("setCompletionPrefix$", "setCompletionPrefix(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QCompleter::ModelSorting", "modelSorting")]
		public QCompleter.ModelSorting modelSorting {
			get { return (QCompleter.ModelSorting) interceptor.Invoke("modelSorting", "modelSorting()", typeof(QCompleter.ModelSorting)); }
			set { interceptor.Invoke("setModelSorting$", "setModelSorting(QCompleter::ModelSorting)", typeof(void), typeof(QCompleter.ModelSorting), value); }
		}
		[Q_PROPERTY("QCompleter::CompletionMode", "completionMode")]
		public QCompleter.CompletionMode completionMode {
			get { return (QCompleter.CompletionMode) interceptor.Invoke("completionMode", "completionMode()", typeof(QCompleter.CompletionMode)); }
			set { interceptor.Invoke("setCompletionMode$", "setCompletionMode(QCompleter::CompletionMode)", typeof(void), typeof(QCompleter.CompletionMode), value); }
		}
		[Q_PROPERTY("int", "completionColumn")]
		public int CompletionColumn {
			get { return (int) interceptor.Invoke("completionColumn", "completionColumn()", typeof(int)); }
			set { interceptor.Invoke("setCompletionColumn$", "setCompletionColumn(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "completionRole")]
		public int CompletionRole {
			get { return (int) interceptor.Invoke("completionRole", "completionRole()", typeof(int)); }
			set { interceptor.Invoke("setCompletionRole$", "setCompletionRole(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("Qt::CaseSensitivity", "caseSensitivity")]
		public Qt.CaseSensitivity CaseSensitivity {
			get { return (Qt.CaseSensitivity) interceptor.Invoke("caseSensitivity", "caseSensitivity()", typeof(Qt.CaseSensitivity)); }
			set { interceptor.Invoke("setCaseSensitivity$", "setCaseSensitivity(Qt::CaseSensitivity)", typeof(void), typeof(Qt.CaseSensitivity), value); }
		}
		public QCompleter(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCompleter#", "QCompleter(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QCompleter() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCompleter", "QCompleter()", typeof(void));
		}
		public QCompleter(QAbstractItemModel model, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCompleter##", "QCompleter(QAbstractItemModel*, QObject*)", typeof(void), typeof(QAbstractItemModel), model, typeof(QObject), parent);
		}
		public QCompleter(QAbstractItemModel model) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCompleter#", "QCompleter(QAbstractItemModel*)", typeof(void), typeof(QAbstractItemModel), model);
		}
		public QCompleter(List<string> completions, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCompleter?#", "QCompleter(const QStringList&, QObject*)", typeof(void), typeof(List<string>), completions, typeof(QObject), parent);
		}
		public QCompleter(List<string> completions) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCompleter?", "QCompleter(const QStringList&)", typeof(void), typeof(List<string>), completions);
		}
		public void SetWidget(QWidget widget) {
			interceptor.Invoke("setWidget#", "setWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		public QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
		}
		public void SetModel(QAbstractItemModel c) {
			interceptor.Invoke("setModel#", "setModel(QAbstractItemModel*)", typeof(void), typeof(QAbstractItemModel), c);
		}
		public QAbstractItemModel Model() {
			return (QAbstractItemModel) interceptor.Invoke("model", "model() const", typeof(QAbstractItemModel));
		}
		public QAbstractItemView Popup() {
			return (QAbstractItemView) interceptor.Invoke("popup", "popup() const", typeof(QAbstractItemView));
		}
		public void SetPopup(QAbstractItemView popup) {
			interceptor.Invoke("setPopup#", "setPopup(QAbstractItemView*)", typeof(void), typeof(QAbstractItemView), popup);
		}
		public int CompletionCount() {
			return (int) interceptor.Invoke("completionCount", "completionCount() const", typeof(int));
		}
		public bool SetCurrentRow(int row) {
			return (bool) interceptor.Invoke("setCurrentRow$", "setCurrentRow(int)", typeof(bool), typeof(int), row);
		}
		public int CurrentRow() {
			return (int) interceptor.Invoke("currentRow", "currentRow() const", typeof(int));
		}
		public QModelIndex CurrentIndex() {
			return (QModelIndex) interceptor.Invoke("currentIndex", "currentIndex() const", typeof(QModelIndex));
		}
		public string CurrentCompletion() {
			return (string) interceptor.Invoke("currentCompletion", "currentCompletion() const", typeof(string));
		}
		public QAbstractItemModel CompletionModel() {
			return (QAbstractItemModel) interceptor.Invoke("completionModel", "completionModel() const", typeof(QAbstractItemModel));
		}
		[SmokeMethod("pathFromIndex(const QModelIndex&) const")]
		public virtual string PathFromIndex(QModelIndex index) {
			return (string) interceptor.Invoke("pathFromIndex#", "pathFromIndex(const QModelIndex&) const", typeof(string), typeof(QModelIndex), index);
		}
		[SmokeMethod("splitPath(const QString&) const")]
		public virtual List<string> SplitPath(string path) {
			return (List<string>) interceptor.Invoke("splitPath$", "splitPath(const QString&) const", typeof(List<string>), typeof(string), path);
		}
		[Q_SLOT("void complete(const QRect&)")]
		public void Complete(QRect rect) {
			interceptor.Invoke("complete#", "complete(const QRect&)", typeof(void), typeof(QRect), rect);
		}
		[Q_SLOT("void complete()")]
		public void Complete() {
			interceptor.Invoke("complete", "complete()", typeof(void));
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject o, QEvent e) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), o, typeof(QEvent), e);
		}
		[SmokeMethod("event(QEvent*)")]
		protected new virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		~QCompleter() {
			interceptor.Invoke("~QCompleter", "~QCompleter()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QCompleter", "~QCompleter()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQCompleterSignals Emit {
			get { return (IQCompleterSignals) Q_EMIT; }
		}
	}

	public interface IQCompleterSignals : IQObjectSignals {
		[Q_SIGNAL("void activated(const QString&)")]
		void Activated(string text);
		[Q_SIGNAL("void activated(const QModelIndex&)")]
		void Activated(QModelIndex index);
		[Q_SIGNAL("void highlighted(const QString&)")]
		void Highlighted(string text);
		[Q_SIGNAL("void highlighted(const QModelIndex&)")]
		void Highlighted(QModelIndex index);
	}
}
