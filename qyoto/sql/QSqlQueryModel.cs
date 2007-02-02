//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QSqlQueryModel")]
	public class QSqlQueryModel : QAbstractTableModel, IDisposable {
 		protected QSqlQueryModel(Type dummy) : base((Type) null) {}
		interface IQSqlQueryModelProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlQueryModel), this);
			_interceptor = (QSqlQueryModel) realProxy.GetTransparentProxy();
		}
		private QSqlQueryModel ProxyQSqlQueryModel() {
			return (QSqlQueryModel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlQueryModel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlQueryModelProxy), null);
			_staticInterceptor = (IQSqlQueryModelProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlQueryModelProxy StaticQSqlQueryModel() {
			return (IQSqlQueryModelProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSqlQueryModel(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSqlQueryModel(parent);
		}
		[SmokeMethod("QSqlQueryModel#", "(QObject*)")]
		private void NewQSqlQueryModel(QObject parent) {
			ProxyQSqlQueryModel().NewQSqlQueryModel(parent);
		}
		public QSqlQueryModel() : this((Type) null) {
			CreateProxy();
			NewQSqlQueryModel();
		}
		[SmokeMethod("QSqlQueryModel", "()")]
		private void NewQSqlQueryModel() {
			ProxyQSqlQueryModel().NewQSqlQueryModel();
		}
		[SmokeMethod("rowCount#", "(const QModelIndex&) const")]
		public new int RowCount(QModelIndex parent) {
			return ProxyQSqlQueryModel().RowCount(parent);
		}
		[SmokeMethod("rowCount", "() const")]
		public new int RowCount() {
			return ProxyQSqlQueryModel().RowCount();
		}
		[SmokeMethod("columnCount#", "(const QModelIndex&) const")]
		public new int ColumnCount(QModelIndex parent) {
			return ProxyQSqlQueryModel().ColumnCount(parent);
		}
		[SmokeMethod("columnCount", "() const")]
		public new int ColumnCount() {
			return ProxyQSqlQueryModel().ColumnCount();
		}
		[SmokeMethod("record$", "(int) const")]
		public QSqlRecord Record(int row) {
			return ProxyQSqlQueryModel().Record(row);
		}
		[SmokeMethod("record", "() const")]
		public QSqlRecord Record() {
			return ProxyQSqlQueryModel().Record();
		}
		[SmokeMethod("data##", "(const QModelIndex&, int) const")]
		public new QVariant Data(QModelIndex item, int role) {
			return ProxyQSqlQueryModel().Data(item,role);
		}
		[SmokeMethod("data#", "(const QModelIndex&) const")]
		public new QVariant Data(QModelIndex item) {
			return ProxyQSqlQueryModel().Data(item);
		}
		[SmokeMethod("headerData$$$", "(int, Qt::Orientation, int) const")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return ProxyQSqlQueryModel().HeaderData(section,orientation,role);
		}
		[SmokeMethod("headerData$$", "(int, Qt::Orientation) const")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation) {
			return ProxyQSqlQueryModel().HeaderData(section,orientation);
		}
		[SmokeMethod("setHeaderData$$$$", "(int, Qt::Orientation, const QVariant&, int)")]
		public new bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value, int role) {
			return ProxyQSqlQueryModel().SetHeaderData(section,orientation,value,role);
		}
		[SmokeMethod("setHeaderData$$$", "(int, Qt::Orientation, const QVariant&)")]
		public new bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value) {
			return ProxyQSqlQueryModel().SetHeaderData(section,orientation,value);
		}
		[SmokeMethod("insertColumns$$$", "(int, int, const QModelIndex&)")]
		public new bool InsertColumns(int column, int count, QModelIndex parent) {
			return ProxyQSqlQueryModel().InsertColumns(column,count,parent);
		}
		[SmokeMethod("insertColumns$$", "(int, int)")]
		public new bool InsertColumns(int column, int count) {
			return ProxyQSqlQueryModel().InsertColumns(column,count);
		}
		[SmokeMethod("removeColumns$$$", "(int, int, const QModelIndex&)")]
		public new bool RemoveColumns(int column, int count, QModelIndex parent) {
			return ProxyQSqlQueryModel().RemoveColumns(column,count,parent);
		}
		[SmokeMethod("removeColumns$$", "(int, int)")]
		public new bool RemoveColumns(int column, int count) {
			return ProxyQSqlQueryModel().RemoveColumns(column,count);
		}
		[SmokeMethod("setQuery#", "(const QSqlQuery&)")]
		public void SetQuery(IQSqlQuery query) {
			ProxyQSqlQueryModel().SetQuery(query);
		}
		[SmokeMethod("setQuery$$", "(const QString&, const QSqlDatabase&)")]
		public void SetQuery(string query, QSqlDatabase db) {
			ProxyQSqlQueryModel().SetQuery(query,db);
		}
		[SmokeMethod("setQuery$", "(const QString&)")]
		public void SetQuery(string query) {
			ProxyQSqlQueryModel().SetQuery(query);
		}
		[SmokeMethod("query", "() const")]
		public IQSqlQuery Query() {
			return ProxyQSqlQueryModel().Query();
		}
		[SmokeMethod("clear", "()")]
		public virtual void Clear() {
			ProxyQSqlQueryModel().Clear();
		}
		[SmokeMethod("lastError", "() const")]
		public QSqlError LastError() {
			return ProxyQSqlQueryModel().LastError();
		}
		[SmokeMethod("fetchMore#", "(const QModelIndex&)")]
		public new void FetchMore(QModelIndex parent) {
			ProxyQSqlQueryModel().FetchMore(parent);
		}
		[SmokeMethod("fetchMore", "()")]
		public new void FetchMore() {
			ProxyQSqlQueryModel().FetchMore();
		}
		[SmokeMethod("canFetchMore#", "(const QModelIndex&) const")]
		public new bool CanFetchMore(QModelIndex parent) {
			return ProxyQSqlQueryModel().CanFetchMore(parent);
		}
		[SmokeMethod("canFetchMore", "() const")]
		public new bool CanFetchMore() {
			return ProxyQSqlQueryModel().CanFetchMore();
		}
		public static new string Tr(string s, string c) {
			return StaticQSqlQueryModel().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQSqlQueryModel().Tr(s);
		}
		[SmokeMethod("queryChange", "()")]
		protected virtual void QueryChange() {
			ProxyQSqlQueryModel().QueryChange();
		}
		[SmokeMethod("indexInQuery#", "(const QModelIndex&) const")]
		protected QModelIndex IndexInQuery(QModelIndex item) {
			return ProxyQSqlQueryModel().IndexInQuery(item);
		}
		[SmokeMethod("setLastError#", "(const QSqlError&)")]
		protected void SetLastError(QSqlError error) {
			ProxyQSqlQueryModel().SetLastError(error);
		}
		~QSqlQueryModel() {
			DisposeQSqlQueryModel();
		}
		public new void Dispose() {
			DisposeQSqlQueryModel();
		}
		[SmokeMethod("~QSqlQueryModel", "()")]
		private void DisposeQSqlQueryModel() {
			ProxyQSqlQueryModel().DisposeQSqlQueryModel();
		}
		protected new IQSqlQueryModelSignals Emit {
			get {
				return (IQSqlQueryModelSignals) Q_EMIT;
			}
		}
	}

	public interface IQSqlQueryModelSignals : IQAbstractTableModelSignals {
	}
}
