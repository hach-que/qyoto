//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAbstractTableModel")]
	public abstract class QAbstractTableModel : QAbstractItemModel, IDisposable {
 		protected QAbstractTableModel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractTableModel), "QAbstractTableModel", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAbstractTableModel() {
			staticInterceptor = new SmokeInvocation(typeof(QAbstractTableModel), "QAbstractTableModel", null);
		}
		public QAbstractTableModel(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractTableModel#", "QAbstractTableModel(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QAbstractTableModel() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractTableModel", "QAbstractTableModel()", typeof(void));
		}
		[SmokeMethod("index(int, int, const QModelIndex&) const")]
		public override QModelIndex Index(int row, int column, QModelIndex parent) {
			return (QModelIndex) interceptor.Invoke("index$$#", "index(int, int, const QModelIndex&) const", typeof(QModelIndex), typeof(int), row, typeof(int), column, typeof(QModelIndex), parent);
		}
		[SmokeMethod("index(int, int) const")]
		public virtual QModelIndex Index(int row, int column) {
			return (QModelIndex) interceptor.Invoke("index$$", "index(int, int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column);
		}
		[SmokeMethod("dropMimeData(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)")]
		public override bool DropMimeData(QMimeData data, Qt.DropAction action, int row, int column, QModelIndex parent) {
			return (bool) interceptor.Invoke("dropMimeData#$$$#", "dropMimeData(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)", typeof(bool), typeof(QMimeData), data, typeof(Qt.DropAction), action, typeof(int), row, typeof(int), column, typeof(QModelIndex), parent);
		}
		~QAbstractTableModel() {
			interceptor.Invoke("~QAbstractTableModel", "~QAbstractTableModel()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QAbstractTableModel", "~QAbstractTableModel()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQAbstractTableModelSignals Emit {
			get { return (IQAbstractTableModelSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractTableModelSignals : IQAbstractItemModelSignals {
	}
}
