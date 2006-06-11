//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QSqlDriver")]
	public class QSqlDriver : QObject {
 		protected QSqlDriver(Type dummy) : base((Type) null) {}
		interface IQSqlDriverProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlDriver), this);
			_interceptor = (QSqlDriver) realProxy.GetTransparentProxy();
		}
		private QSqlDriver ProxyQSqlDriver() {
			return (QSqlDriver) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlDriver() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlDriverProxy), null);
			_staticInterceptor = (IQSqlDriverProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlDriverProxy StaticQSqlDriver() {
			return (IQSqlDriverProxy) _staticInterceptor;
		}

		public enum DriverFeature {
			Transactions = 0,
			QuerySize = 1,
			BLOB = 2,
			Unicode = 3,
			PreparedQueries = 4,
			NamedPlaceholders = 5,
			PositionalPlaceholders = 6,
			LastInsertId = 7,
			BatchOperations = 8,
		}
		public enum StatementType {
			WhereStatement = 0,
			SelectStatement = 1,
			UpdateStatement = 2,
			InsertStatement = 3,
			DeleteStatement = 4,
		}
		public enum IdentifierType {
			FieldName = 0,
			TableName = 1,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSqlDriver(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSqlDriver(parent);
		}
		[SmokeMethod("QSqlDriver(QObject*)")]
		private void NewQSqlDriver(QObject parent) {
			ProxyQSqlDriver().NewQSqlDriver(parent);
		}
		public QSqlDriver() : this((Type) null) {
			CreateProxy();
			NewQSqlDriver();
		}
		[SmokeMethod("QSqlDriver()")]
		private void NewQSqlDriver() {
			ProxyQSqlDriver().NewQSqlDriver();
		}
		[SmokeMethod("isOpen() const")]
		public virtual bool IsOpen() {
			return ProxyQSqlDriver().IsOpen();
		}
		[SmokeMethod("isOpenError() const")]
		public bool IsOpenError() {
			return ProxyQSqlDriver().IsOpenError();
		}
		[SmokeMethod("beginTransaction()")]
		public virtual bool BeginTransaction() {
			return ProxyQSqlDriver().BeginTransaction();
		}
		[SmokeMethod("commitTransaction()")]
		public virtual bool CommitTransaction() {
			return ProxyQSqlDriver().CommitTransaction();
		}
		[SmokeMethod("rollbackTransaction()")]
		public virtual bool RollbackTransaction() {
			return ProxyQSqlDriver().RollbackTransaction();
		}
		[SmokeMethod("tables(QSql::TableType) const")]
		public virtual ArrayList Tables(QSql.TableType tableType) {
			return ProxyQSqlDriver().Tables(tableType);
		}
		[SmokeMethod("primaryIndex(const QString&) const")]
		public virtual QSqlIndex PrimaryIndex(string tableName) {
			return ProxyQSqlDriver().PrimaryIndex(tableName);
		}
		[SmokeMethod("record(const QString&) const")]
		public virtual QSqlRecord Record(string tableName) {
			return ProxyQSqlDriver().Record(tableName);
		}
		[SmokeMethod("formatValue(const QSqlField&, bool) const")]
		public virtual string FormatValue(QSqlField field, bool trimStrings) {
			return ProxyQSqlDriver().FormatValue(field,trimStrings);
		}
		[SmokeMethod("formatValue(const QSqlField&) const")]
		public virtual string FormatValue(QSqlField field) {
			return ProxyQSqlDriver().FormatValue(field);
		}
		[SmokeMethod("escapeIdentifier(const QString&, QSqlDriver::IdentifierType) const")]
		public virtual string EscapeIdentifier(string identifier, QSqlDriver.IdentifierType type) {
			return ProxyQSqlDriver().EscapeIdentifier(identifier,type);
		}
		[SmokeMethod("sqlStatement(QSqlDriver::StatementType, const QString&, const QSqlRecord&, bool) const")]
		public virtual string SqlStatement(QSqlDriver.StatementType type, string tableName, QSqlRecord rec, bool preparedStatement) {
			return ProxyQSqlDriver().SqlStatement(type,tableName,rec,preparedStatement);
		}
		[SmokeMethod("lastError() const")]
		public QSqlError LastError() {
			return ProxyQSqlDriver().LastError();
		}
		[SmokeMethod("hasFeature(QSqlDriver::DriverFeature) const")]
		public virtual bool HasFeature(QSqlDriver.DriverFeature f) {
			return ProxyQSqlDriver().HasFeature(f);
		}
		[SmokeMethod("close()")]
		public virtual void Close() {
			ProxyQSqlDriver().Close();
		}
		[SmokeMethod("createResult() const")]
		public virtual QSqlResult CreateResult() {
			return ProxyQSqlDriver().CreateResult();
		}
		[SmokeMethod("open(const QString&, const QString&, const QString&, const QString&, int, const QString&)")]
		public virtual bool Open(string db, string user, string password, string host, int port, string connOpts) {
			return ProxyQSqlDriver().Open(db,user,password,host,port,connOpts);
		}
		[SmokeMethod("open(const QString&, const QString&, const QString&, const QString&, int)")]
		public virtual bool Open(string db, string user, string password, string host, int port) {
			return ProxyQSqlDriver().Open(db,user,password,host,port);
		}
		[SmokeMethod("open(const QString&, const QString&, const QString&, const QString&)")]
		public virtual bool Open(string db, string user, string password, string host) {
			return ProxyQSqlDriver().Open(db,user,password,host);
		}
		[SmokeMethod("open(const QString&, const QString&, const QString&)")]
		public virtual bool Open(string db, string user, string password) {
			return ProxyQSqlDriver().Open(db,user,password);
		}
		[SmokeMethod("open(const QString&, const QString&)")]
		public virtual bool Open(string db, string user) {
			return ProxyQSqlDriver().Open(db,user);
		}
		[SmokeMethod("open(const QString&)")]
		public virtual bool Open(string db) {
			return ProxyQSqlDriver().Open(db);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSqlDriver().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSqlDriver().Tr(s);
		}
		~QSqlDriver() {
			DisposeQSqlDriver();
		}
		public new void Dispose() {
			DisposeQSqlDriver();
		}
		[SmokeMethod("~QSqlDriver()")]
		private void DisposeQSqlDriver() {
			ProxyQSqlDriver().DisposeQSqlDriver();
		}
		protected new IQSqlDriverSignals Emit() {
			return (IQSqlDriverSignals) Q_EMIT;
		}
	}

	public interface IQSqlDriverSignals : IQObjectSignals {
	}
}
