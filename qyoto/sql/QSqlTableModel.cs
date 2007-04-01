//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQSqlTableModelSignals"></see> for signals emitted by QSqlTableModel
	[SmokeClass("QSqlTableModel")]
	public class QSqlTableModel : QSqlQueryModel, IDisposable {
 		protected QSqlTableModel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSqlTableModel), "QSqlTableModel", this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSqlTableModel() {
			staticInterceptor = new SmokeInvocation(typeof(QSqlTableModel), "QSqlTableModel", null);
		}
		public enum EditStrategy {
			OnFieldChange = 0,
			OnRowChange = 1,
			OnManualSubmit = 2,
		}
		public QSqlTableModel(QObject parent, QSqlDatabase db) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSqlTableModel##", "QSqlTableModel(QObject*, QSqlDatabase)", typeof(void), typeof(QObject), parent, typeof(QSqlDatabase), db);
		}
		public QSqlTableModel(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSqlTableModel#", "QSqlTableModel(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QSqlTableModel() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSqlTableModel", "QSqlTableModel()", typeof(void));
		}
		[SmokeMethod("select()")]
		public virtual bool Select() {
			return (bool) interceptor.Invoke("select", "select()", typeof(bool));
		}
		[SmokeMethod("setTable(const QString&)")]
		public virtual void SetTable(string tableName) {
			interceptor.Invoke("setTable$", "setTable(const QString&)", typeof(void), typeof(string), tableName);
		}
		public string TableName() {
			return (string) interceptor.Invoke("tableName", "tableName() const", typeof(string));
		}
		[SmokeMethod("flags(const QModelIndex&) const")]
		public override int Flags(QModelIndex index) {
			return (int) interceptor.Invoke("flags#", "flags(const QModelIndex&) const", typeof(int), typeof(QModelIndex), index);
		}
		[SmokeMethod("data(const QModelIndex&, int) const")]
		public override QVariant Data(QModelIndex idx, int role) {
			return (QVariant) interceptor.Invoke("data#$", "data(const QModelIndex&, int) const", typeof(QVariant), typeof(QModelIndex), idx, typeof(int), role);
		}
		[SmokeMethod("data(const QModelIndex&) const")]
		public override QVariant Data(QModelIndex idx) {
			return (QVariant) interceptor.Invoke("data#", "data(const QModelIndex&) const", typeof(QVariant), typeof(QModelIndex), idx);
		}
		[SmokeMethod("setData(const QModelIndex&, const QVariant&, int)")]
		public override bool SetData(QModelIndex index, QVariant value, int role) {
			return (bool) interceptor.Invoke("setData##$", "setData(const QModelIndex&, const QVariant&, int)", typeof(bool), typeof(QModelIndex), index, typeof(QVariant), value, typeof(int), role);
		}
		[SmokeMethod("setData(const QModelIndex&, const QVariant&)")]
		public override bool SetData(QModelIndex index, QVariant value) {
			return (bool) interceptor.Invoke("setData##", "setData(const QModelIndex&, const QVariant&)", typeof(bool), typeof(QModelIndex), index, typeof(QVariant), value);
		}
		[SmokeMethod("headerData(int, Qt::Orientation, int) const")]
		public override QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return (QVariant) interceptor.Invoke("headerData$$$", "headerData(int, Qt::Orientation, int) const", typeof(QVariant), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(int), role);
		}
		[SmokeMethod("headerData(int, Qt::Orientation) const")]
		public override QVariant HeaderData(int section, Qt.Orientation orientation) {
			return (QVariant) interceptor.Invoke("headerData$$", "headerData(int, Qt::Orientation) const", typeof(QVariant), typeof(int), section, typeof(Qt.Orientation), orientation);
		}
		public bool IsDirty(QModelIndex index) {
			return (bool) interceptor.Invoke("isDirty#", "isDirty(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), index);
		}
		[SmokeMethod("clear()")]
		public override void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[SmokeMethod("setEditStrategy(QSqlTableModel::EditStrategy)")]
		public virtual void SetEditStrategy(QSqlTableModel.EditStrategy strategy) {
			interceptor.Invoke("setEditStrategy$", "setEditStrategy(QSqlTableModel::EditStrategy)", typeof(void), typeof(QSqlTableModel.EditStrategy), strategy);
		}
		public QSqlTableModel.EditStrategy editStrategy() {
			return (QSqlTableModel.EditStrategy) interceptor.Invoke("editStrategy", "editStrategy() const", typeof(QSqlTableModel.EditStrategy));
		}
		public QSqlIndex PrimaryKey() {
			return (QSqlIndex) interceptor.Invoke("primaryKey", "primaryKey() const", typeof(QSqlIndex));
		}
		public QSqlDatabase Database() {
			return (QSqlDatabase) interceptor.Invoke("database", "database() const", typeof(QSqlDatabase));
		}
		public int FieldIndex(string fieldName) {
			return (int) interceptor.Invoke("fieldIndex$", "fieldIndex(const QString&) const", typeof(int), typeof(string), fieldName);
		}
		[SmokeMethod("sort(int, Qt::SortOrder)")]
		public override void Sort(int column, Qt.SortOrder order) {
			interceptor.Invoke("sort$$", "sort(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
		}
		[SmokeMethod("setSort(int, Qt::SortOrder)")]
		public virtual void SetSort(int column, Qt.SortOrder order) {
			interceptor.Invoke("setSort$$", "setSort(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
		}
		public string Filter() {
			return (string) interceptor.Invoke("filter", "filter() const", typeof(string));
		}
		[SmokeMethod("setFilter(const QString&)")]
		public virtual void SetFilter(string filter) {
			interceptor.Invoke("setFilter$", "setFilter(const QString&)", typeof(void), typeof(string), filter);
		}
		[SmokeMethod("rowCount(const QModelIndex&) const")]
		public override int RowCount(QModelIndex parent) {
			return (int) interceptor.Invoke("rowCount#", "rowCount(const QModelIndex&) const", typeof(int), typeof(QModelIndex), parent);
		}
		[SmokeMethod("rowCount() const")]
		public override int RowCount() {
			return (int) interceptor.Invoke("rowCount", "rowCount() const", typeof(int));
		}
		[SmokeMethod("removeColumns(int, int, const QModelIndex&)")]
		public override bool RemoveColumns(int column, int count, QModelIndex parent) {
			return (bool) interceptor.Invoke("removeColumns$$#", "removeColumns(int, int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(int), count, typeof(QModelIndex), parent);
		}
		[SmokeMethod("removeColumns(int, int)")]
		public override bool RemoveColumns(int column, int count) {
			return (bool) interceptor.Invoke("removeColumns$$", "removeColumns(int, int)", typeof(bool), typeof(int), column, typeof(int), count);
		}
		[SmokeMethod("removeRows(int, int, const QModelIndex&)")]
		public override bool RemoveRows(int row, int count, QModelIndex parent) {
			return (bool) interceptor.Invoke("removeRows$$#", "removeRows(int, int, const QModelIndex&)", typeof(bool), typeof(int), row, typeof(int), count, typeof(QModelIndex), parent);
		}
		[SmokeMethod("removeRows(int, int)")]
		public override bool RemoveRows(int row, int count) {
			return (bool) interceptor.Invoke("removeRows$$", "removeRows(int, int)", typeof(bool), typeof(int), row, typeof(int), count);
		}
		[SmokeMethod("insertRows(int, int, const QModelIndex&)")]
		public override bool InsertRows(int row, int count, QModelIndex parent) {
			return (bool) interceptor.Invoke("insertRows$$#", "insertRows(int, int, const QModelIndex&)", typeof(bool), typeof(int), row, typeof(int), count, typeof(QModelIndex), parent);
		}
		[SmokeMethod("insertRows(int, int)")]
		public override bool InsertRows(int row, int count) {
			return (bool) interceptor.Invoke("insertRows$$", "insertRows(int, int)", typeof(bool), typeof(int), row, typeof(int), count);
		}
		public bool InsertRecord(int row, QSqlRecord record) {
			return (bool) interceptor.Invoke("insertRecord$#", "insertRecord(int, const QSqlRecord&)", typeof(bool), typeof(int), row, typeof(QSqlRecord), record);
		}
		public bool SetRecord(int row, QSqlRecord record) {
			return (bool) interceptor.Invoke("setRecord$#", "setRecord(int, const QSqlRecord&)", typeof(bool), typeof(int), row, typeof(QSqlRecord), record);
		}
		[SmokeMethod("revertRow(int)")]
		public virtual void RevertRow(int row) {
			interceptor.Invoke("revertRow$", "revertRow(int)", typeof(void), typeof(int), row);
		}
		[Q_SLOT("bool submit()")]
		[SmokeMethod("submit()")]
		public override bool Submit() {
			return (bool) interceptor.Invoke("submit", "submit()", typeof(bool));
		}
		[Q_SLOT("void revert()")]
		[SmokeMethod("revert()")]
		public override void Revert() {
			interceptor.Invoke("revert", "revert()", typeof(void));
		}
		[Q_SLOT("bool submitAll()")]
		public bool SubmitAll() {
			return (bool) interceptor.Invoke("submitAll", "submitAll()", typeof(bool));
		}
		[Q_SLOT("void revertAll()")]
		public void RevertAll() {
			interceptor.Invoke("revertAll", "revertAll()", typeof(void));
		}
		[SmokeMethod("updateRowInTable(int, const QSqlRecord&)")]
		protected virtual bool UpdateRowInTable(int row, QSqlRecord values) {
			return (bool) interceptor.Invoke("updateRowInTable$#", "updateRowInTable(int, const QSqlRecord&)", typeof(bool), typeof(int), row, typeof(QSqlRecord), values);
		}
		[SmokeMethod("insertRowIntoTable(const QSqlRecord&)")]
		protected virtual bool InsertRowIntoTable(QSqlRecord values) {
			return (bool) interceptor.Invoke("insertRowIntoTable#", "insertRowIntoTable(const QSqlRecord&)", typeof(bool), typeof(QSqlRecord), values);
		}
		[SmokeMethod("deleteRowFromTable(int)")]
		protected virtual bool DeleteRowFromTable(int row) {
			return (bool) interceptor.Invoke("deleteRowFromTable$", "deleteRowFromTable(int)", typeof(bool), typeof(int), row);
		}
		[SmokeMethod("orderByClause() const")]
		protected virtual string OrderByClause() {
			return (string) interceptor.Invoke("orderByClause", "orderByClause() const", typeof(string));
		}
		[SmokeMethod("selectStatement() const")]
		protected virtual string SelectStatement() {
			return (string) interceptor.Invoke("selectStatement", "selectStatement() const", typeof(string));
		}
		protected void SetPrimaryKey(QSqlIndex key) {
			interceptor.Invoke("setPrimaryKey#", "setPrimaryKey(const QSqlIndex&)", typeof(void), typeof(QSqlIndex), key);
		}
		protected void SetQuery(IQSqlQuery query) {
			interceptor.Invoke("setQuery#", "setQuery(const QSqlQuery&)", typeof(void), typeof(IQSqlQuery), query);
		}
		protected QModelIndex IndexInQuery(QModelIndex item) {
			return (QModelIndex) interceptor.Invoke("indexInQuery#", "indexInQuery(const QModelIndex&) const", typeof(QModelIndex), typeof(QModelIndex), item);
		}
		~QSqlTableModel() {
			interceptor.Invoke("~QSqlTableModel", "~QSqlTableModel()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QSqlTableModel", "~QSqlTableModel()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQSqlTableModelSignals Emit {
			get { return (IQSqlTableModelSignals) Q_EMIT; }
		}
	}

	public interface IQSqlTableModelSignals : IQSqlQueryModelSignals {
		[Q_SIGNAL("void primeInsert(int, QSqlRecord&)")]
		void PrimeInsert(int row, QSqlRecord record);
		[Q_SIGNAL("void beforeInsert(QSqlRecord&)")]
		void BeforeInsert(QSqlRecord record);
		[Q_SIGNAL("void beforeUpdate(int, QSqlRecord&)")]
		void BeforeUpdate(int row, QSqlRecord record);
		[Q_SIGNAL("void beforeDelete(int)")]
		void BeforeDelete(int row);
	}
}
