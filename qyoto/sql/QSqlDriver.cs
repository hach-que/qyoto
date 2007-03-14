//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QSqlDriver")]
	public abstract class QSqlDriver : QObject {
 		protected QSqlDriver(Type dummy) : base((Type) null) {}
		[SmokeClass("QSqlDriver")]
		interface IQSqlDriverProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
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
		public QSqlDriver(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSqlDriver(parent);
		}
		[SmokeMethod("QSqlDriver", "(QObject*)", "#")]
		private void NewQSqlDriver(QObject parent) {
			ProxyQSqlDriver().NewQSqlDriver(parent);
		}
		public QSqlDriver() : this((Type) null) {
			CreateProxy();
			NewQSqlDriver();
		}
		[SmokeMethod("QSqlDriver", "()", "")]
		private void NewQSqlDriver() {
			ProxyQSqlDriver().NewQSqlDriver();
		}
		[SmokeMethod("isOpen", "() const", "")]
		public virtual bool IsOpen() {
			return ProxyQSqlDriver().IsOpen();
		}
		[SmokeMethod("isOpenError", "() const", "")]
		public bool IsOpenError() {
			return ProxyQSqlDriver().IsOpenError();
		}
		[SmokeMethod("beginTransaction", "()", "")]
		public virtual bool BeginTransaction() {
			return ProxyQSqlDriver().BeginTransaction();
		}
		[SmokeMethod("commitTransaction", "()", "")]
		public virtual bool CommitTransaction() {
			return ProxyQSqlDriver().CommitTransaction();
		}
		[SmokeMethod("rollbackTransaction", "()", "")]
		public virtual bool RollbackTransaction() {
			return ProxyQSqlDriver().RollbackTransaction();
		}
		[SmokeMethod("tables", "(QSql::TableType) const", "$")]
		public virtual List<string> Tables(QSql.TableType tableType) {
			return ProxyQSqlDriver().Tables(tableType);
		}
		[SmokeMethod("primaryIndex", "(const QString&) const", "$")]
		public virtual QSqlIndex PrimaryIndex(string tableName) {
			return ProxyQSqlDriver().PrimaryIndex(tableName);
		}
		[SmokeMethod("record", "(const QString&) const", "$")]
		public virtual QSqlRecord Record(string tableName) {
			return ProxyQSqlDriver().Record(tableName);
		}
		[SmokeMethod("formatValue", "(const QSqlField&, bool) const", "#$")]
		public virtual string FormatValue(QSqlField field, bool trimStrings) {
			return ProxyQSqlDriver().FormatValue(field,trimStrings);
		}
		[SmokeMethod("formatValue", "(const QSqlField&) const", "#")]
		public virtual string FormatValue(QSqlField field) {
			return ProxyQSqlDriver().FormatValue(field);
		}
		[SmokeMethod("escapeIdentifier", "(const QString&, QSqlDriver::IdentifierType) const", "$$")]
		public virtual string EscapeIdentifier(string identifier, QSqlDriver.IdentifierType type) {
			return ProxyQSqlDriver().EscapeIdentifier(identifier,type);
		}
		[SmokeMethod("sqlStatement", "(QSqlDriver::StatementType, const QString&, const QSqlRecord&, bool) const", "$$#$")]
		public virtual string SqlStatement(QSqlDriver.StatementType type, string tableName, QSqlRecord rec, bool preparedStatement) {
			return ProxyQSqlDriver().SqlStatement(type,tableName,rec,preparedStatement);
		}
		[SmokeMethod("lastError", "() const", "")]
		public QSqlError LastError() {
			return ProxyQSqlDriver().LastError();
		}
		public abstract bool HasFeature(QSqlDriver.DriverFeature f);
		public abstract void Close();
		public abstract QSqlResult CreateResult();
		public abstract bool Open(string db, string user, string password, string host, int port, string connOpts);
		[SmokeMethod("setOpen", "(bool)", "$")]
		protected virtual void SetOpen(bool o) {
			ProxyQSqlDriver().SetOpen(o);
		}
		[SmokeMethod("setOpenError", "(bool)", "$")]
		protected virtual void SetOpenError(bool e) {
			ProxyQSqlDriver().SetOpenError(e);
		}
		[SmokeMethod("setLastError", "(const QSqlError&)", "#")]
		protected virtual void SetLastError(QSqlError e) {
			ProxyQSqlDriver().SetLastError(e);
		}
		public static string Tr(string s, string c) {
			return StaticQSqlDriver().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQSqlDriver().Tr(s);
		}
		protected new IQSqlDriverSignals Emit {
			get { return (IQSqlDriverSignals) Q_EMIT; }
		}
	}

	public interface IQSqlDriverSignals : IQObjectSignals {
	}
}
