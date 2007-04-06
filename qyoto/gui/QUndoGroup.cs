//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	///<remarks> See <see cref="IQUndoGroupSignals"></see> for signals emitted by QUndoGroup
	///</remarks>

	[SmokeClass("QUndoGroup")]
	public class QUndoGroup : QObject, IDisposable {
 		protected QUndoGroup(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QUndoGroup), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QUndoGroup() {
			staticInterceptor = new SmokeInvocation(typeof(QUndoGroup), null);
		}
		public QUndoGroup(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUndoGroup#", "QUndoGroup(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QUndoGroup() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUndoGroup", "QUndoGroup()", typeof(void));
		}
		public void AddStack(QUndoStack stack) {
			interceptor.Invoke("addStack#", "addStack(QUndoStack*)", typeof(void), typeof(QUndoStack), stack);
		}
		public void RemoveStack(QUndoStack stack) {
			interceptor.Invoke("removeStack#", "removeStack(QUndoStack*)", typeof(void), typeof(QUndoStack), stack);
		}
		public List<QUndoStack> Stacks() {
			return (List<QUndoStack>) interceptor.Invoke("stacks", "stacks() const", typeof(List<QUndoStack>));
		}
		public QUndoStack ActiveStack() {
			return (QUndoStack) interceptor.Invoke("activeStack", "activeStack() const", typeof(QUndoStack));
		}
		public QAction CreateUndoAction(QObject parent, string prefix) {
			return (QAction) interceptor.Invoke("createUndoAction#$", "createUndoAction(QObject*, const QString&) const", typeof(QAction), typeof(QObject), parent, typeof(string), prefix);
		}
		public QAction CreateUndoAction(QObject parent) {
			return (QAction) interceptor.Invoke("createUndoAction#", "createUndoAction(QObject*) const", typeof(QAction), typeof(QObject), parent);
		}
		public QAction CreateRedoAction(QObject parent, string prefix) {
			return (QAction) interceptor.Invoke("createRedoAction#$", "createRedoAction(QObject*, const QString&) const", typeof(QAction), typeof(QObject), parent, typeof(string), prefix);
		}
		public QAction CreateRedoAction(QObject parent) {
			return (QAction) interceptor.Invoke("createRedoAction#", "createRedoAction(QObject*) const", typeof(QAction), typeof(QObject), parent);
		}
		public bool CanUndo() {
			return (bool) interceptor.Invoke("canUndo", "canUndo() const", typeof(bool));
		}
		public bool CanRedo() {
			return (bool) interceptor.Invoke("canRedo", "canRedo() const", typeof(bool));
		}
		public string UndoText() {
			return (string) interceptor.Invoke("undoText", "undoText() const", typeof(string));
		}
		public string RedoText() {
			return (string) interceptor.Invoke("redoText", "redoText() const", typeof(string));
		}
		public bool IsClean() {
			return (bool) interceptor.Invoke("isClean", "isClean() const", typeof(bool));
		}
		[Q_SLOT("void undo()")]
		public void Undo() {
			interceptor.Invoke("undo", "undo()", typeof(void));
		}
		[Q_SLOT("void redo()")]
		public void Redo() {
			interceptor.Invoke("redo", "redo()", typeof(void));
		}
		[Q_SLOT("void setActiveStack(QUndoStack*)")]
		public void SetActiveStack(QUndoStack stack) {
			interceptor.Invoke("setActiveStack#", "setActiveStack(QUndoStack*)", typeof(void), typeof(QUndoStack), stack);
		}
		~QUndoGroup() {
			interceptor.Invoke("~QUndoGroup", "~QUndoGroup()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QUndoGroup", "~QUndoGroup()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQUndoGroupSignals Emit {
			get { return (IQUndoGroupSignals) Q_EMIT; }
		}
	}

	public interface IQUndoGroupSignals : IQObjectSignals {
		[Q_SIGNAL("void activeStackChanged(QUndoStack*)")]
		void ActiveStackChanged(QUndoStack stack);
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
