//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQUndoStackSignals"></see> for signals emitted by QUndoStack
	[SmokeClass("QUndoStack")]
	public class QUndoStack : QObject, IDisposable {
 		protected QUndoStack(Type dummy) : base((Type) null) {}
		[SmokeClass("QUndoStack")]
		interface IQUndoStackProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUndoStack), this);
			interceptor = (QUndoStack) realProxy.GetTransparentProxy();
		}
		private static IQUndoStackProxy staticInterceptor = null;
		static QUndoStack() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUndoStackProxy), null);
			staticInterceptor = (IQUndoStackProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("bool", "active")]
		public bool Active {
			get { return Property("active").Value<bool>(); }
			set { SetProperty("active", QVariant.FromValue<bool>(value)); }
		}
		public QUndoStack(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQUndoStack(parent);
		}
		[SmokeMethod("QUndoStack", "(QObject*)", "#")]
		private void NewQUndoStack(QObject parent) {
			((QUndoStack) interceptor).NewQUndoStack(parent);
		}
		public QUndoStack() : this((Type) null) {
			CreateProxy();
			NewQUndoStack();
		}
		[SmokeMethod("QUndoStack", "()", "")]
		private void NewQUndoStack() {
			((QUndoStack) interceptor).NewQUndoStack();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			((QUndoStack) interceptor).Clear();
		}
		[SmokeMethod("push", "(QUndoCommand*)", "#")]
		public void Push(QUndoCommand cmd) {
			((QUndoStack) interceptor).Push(cmd);
		}
		[SmokeMethod("canUndo", "() const", "")]
		public bool CanUndo() {
			return ((QUndoStack) interceptor).CanUndo();
		}
		[SmokeMethod("canRedo", "() const", "")]
		public bool CanRedo() {
			return ((QUndoStack) interceptor).CanRedo();
		}
		[SmokeMethod("undoText", "() const", "")]
		public string UndoText() {
			return ((QUndoStack) interceptor).UndoText();
		}
		[SmokeMethod("redoText", "() const", "")]
		public string RedoText() {
			return ((QUndoStack) interceptor).RedoText();
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ((QUndoStack) interceptor).Count();
		}
		[SmokeMethod("index", "() const", "")]
		public int Index() {
			return ((QUndoStack) interceptor).Index();
		}
		[SmokeMethod("text", "(int) const", "$")]
		public string Text(int idx) {
			return ((QUndoStack) interceptor).Text(idx);
		}
		[SmokeMethod("createUndoAction", "(QObject*, const QString&) const", "#$")]
		public QAction CreateUndoAction(QObject parent, string prefix) {
			return ((QUndoStack) interceptor).CreateUndoAction(parent,prefix);
		}
		[SmokeMethod("createUndoAction", "(QObject*) const", "#")]
		public QAction CreateUndoAction(QObject parent) {
			return ((QUndoStack) interceptor).CreateUndoAction(parent);
		}
		[SmokeMethod("createRedoAction", "(QObject*, const QString&) const", "#$")]
		public QAction CreateRedoAction(QObject parent, string prefix) {
			return ((QUndoStack) interceptor).CreateRedoAction(parent,prefix);
		}
		[SmokeMethod("createRedoAction", "(QObject*) const", "#")]
		public QAction CreateRedoAction(QObject parent) {
			return ((QUndoStack) interceptor).CreateRedoAction(parent);
		}
		[SmokeMethod("isActive", "() const", "")]
		public bool IsActive() {
			return ((QUndoStack) interceptor).IsActive();
		}
		[SmokeMethod("isClean", "() const", "")]
		public bool IsClean() {
			return ((QUndoStack) interceptor).IsClean();
		}
		[SmokeMethod("cleanIndex", "() const", "")]
		public int CleanIndex() {
			return ((QUndoStack) interceptor).CleanIndex();
		}
		[SmokeMethod("beginMacro", "(const QString&)", "$")]
		public void BeginMacro(string text) {
			((QUndoStack) interceptor).BeginMacro(text);
		}
		[SmokeMethod("endMacro", "()", "")]
		public void EndMacro() {
			((QUndoStack) interceptor).EndMacro();
		}
		[Q_SLOT("void setClean()")]
		[SmokeMethod("setClean", "()", "")]
		public void SetClean() {
			((QUndoStack) interceptor).SetClean();
		}
		[Q_SLOT("void setIndex(int)")]
		[SmokeMethod("setIndex", "(int)", "$")]
		public void SetIndex(int idx) {
			((QUndoStack) interceptor).SetIndex(idx);
		}
		[Q_SLOT("void undo()")]
		[SmokeMethod("undo", "()", "")]
		public void Undo() {
			((QUndoStack) interceptor).Undo();
		}
		[Q_SLOT("void redo()")]
		[SmokeMethod("redo", "()", "")]
		public void Redo() {
			((QUndoStack) interceptor).Redo();
		}
		~QUndoStack() {
			DisposeQUndoStack();
		}
		public new void Dispose() {
			DisposeQUndoStack();
		}
		[SmokeMethod("~QUndoStack", "()", "")]
		private void DisposeQUndoStack() {
			((QUndoStack) interceptor).DisposeQUndoStack();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQUndoStackSignals Emit {
			get { return (IQUndoStackSignals) Q_EMIT; }
		}
	}

	public interface IQUndoStackSignals : IQObjectSignals {
		[Q_SIGNAL("void indexChanged(int)")]
		void IndexChanged(int idx);
		[Q_SIGNAL("void cleanChanged(bool)")]
		void CleanChanged(bool clean);
		[Q_SIGNAL("void canUndoChanged(bool)")]
		void CanUndoChanged(bool canUndo);
		[Q_SIGNAL("void canRedoChanged(bool)")]
		void CanRedoChanged(bool canRedo);
		[Q_SIGNAL("void undoTextChanged(const QString&)")]
		void UndoTextChanged(string undoText);
		[Q_SIGNAL("void redoTextChanged(const QString&)")]
		void RedoTextChanged(string redoText);
	}
}
