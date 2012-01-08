//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QSqlDatabase")]
    public class QSqlDatabase : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QSqlDatabase(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSqlDatabase), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QSqlDatabase() {
            staticInterceptor = new SmokeInvocation(typeof(QSqlDatabase), null);
        }
        public static string DefaultConnection() {
            return (string) staticInterceptor.Invoke("defaultConnection", "defaultConnection()", typeof(string));
        }
        // void registerSqlDriver(const QString& arg1,QSqlDriverCreatorBase* arg2); >>>> NOT CONVERTED
        public QSqlDatabase() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlDatabase", "QSqlDatabase()", typeof(void));
        }
        public QSqlDatabase(QSqlDatabase other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlDatabase#", "QSqlDatabase(const QSqlDatabase&)", typeof(void), typeof(QSqlDatabase), other);
        }
        public bool Open() {
            return (bool) interceptor.Invoke("open", "open()", typeof(bool));
        }
        public bool Open(string user, string password) {
            return (bool) interceptor.Invoke("open$$", "open(const QString&, const QString&)", typeof(bool), typeof(string), user, typeof(string), password);
        }
        public void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        public bool IsOpen() {
            return (bool) interceptor.Invoke("isOpen", "isOpen() const", typeof(bool));
        }
        public bool IsOpenError() {
            return (bool) interceptor.Invoke("isOpenError", "isOpenError() const", typeof(bool));
        }
        public List<string> Tables(QSql.TableType type) {
            return (List<string>) interceptor.Invoke("tables$", "tables(QSql::TableType) const", typeof(List<string>), typeof(QSql.TableType), type);
        }
        public List<string> Tables() {
            return (List<string>) interceptor.Invoke("tables", "tables() const", typeof(List<string>));
        }
        public QSqlIndex PrimaryIndex(string tablename) {
            return (QSqlIndex) interceptor.Invoke("primaryIndex$", "primaryIndex(const QString&) const", typeof(QSqlIndex), typeof(string), tablename);
        }
        public QSqlRecord Record(string tablename) {
            return (QSqlRecord) interceptor.Invoke("record$", "record(const QString&) const", typeof(QSqlRecord), typeof(string), tablename);
        }
        public QSqlQuery Exec(string query) {
            return (QSqlQuery) interceptor.Invoke("exec$", "exec(const QString&) const", typeof(QSqlQuery), typeof(string), query);
        }
        public QSqlQuery Exec() {
            return (QSqlQuery) interceptor.Invoke("exec", "exec() const", typeof(QSqlQuery));
        }
        public QSqlError LastError() {
            return (QSqlError) interceptor.Invoke("lastError", "lastError() const", typeof(QSqlError));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public bool Transaction() {
            return (bool) interceptor.Invoke("transaction", "transaction()", typeof(bool));
        }
        public bool Commit() {
            return (bool) interceptor.Invoke("commit", "commit()", typeof(bool));
        }
        public bool Rollback() {
            return (bool) interceptor.Invoke("rollback", "rollback()", typeof(bool));
        }
        public void SetDatabaseName(string name) {
            interceptor.Invoke("setDatabaseName$", "setDatabaseName(const QString&)", typeof(void), typeof(string), name);
        }
        public void SetUserName(string name) {
            interceptor.Invoke("setUserName$", "setUserName(const QString&)", typeof(void), typeof(string), name);
        }
        public void SetPassword(string password) {
            interceptor.Invoke("setPassword$", "setPassword(const QString&)", typeof(void), typeof(string), password);
        }
        public void SetHostName(string host) {
            interceptor.Invoke("setHostName$", "setHostName(const QString&)", typeof(void), typeof(string), host);
        }
        public void SetPort(int p) {
            interceptor.Invoke("setPort$", "setPort(int)", typeof(void), typeof(int), p);
        }
        public void SetConnectOptions(string options) {
            interceptor.Invoke("setConnectOptions$", "setConnectOptions(const QString&)", typeof(void), typeof(string), options);
        }
        public void SetConnectOptions() {
            interceptor.Invoke("setConnectOptions", "setConnectOptions()", typeof(void));
        }
        public string DatabaseName() {
            return (string) interceptor.Invoke("databaseName", "databaseName() const", typeof(string));
        }
        public string UserName() {
            return (string) interceptor.Invoke("userName", "userName() const", typeof(string));
        }
        public string Password() {
            return (string) interceptor.Invoke("password", "password() const", typeof(string));
        }
        public string HostName() {
            return (string) interceptor.Invoke("hostName", "hostName() const", typeof(string));
        }
        public string DriverName() {
            return (string) interceptor.Invoke("driverName", "driverName() const", typeof(string));
        }
        public int Port() {
            return (int) interceptor.Invoke("port", "port() const", typeof(int));
        }
        public string ConnectOptions() {
            return (string) interceptor.Invoke("connectOptions", "connectOptions() const", typeof(string));
        }
        public string ConnectionName() {
            return (string) interceptor.Invoke("connectionName", "connectionName() const", typeof(string));
        }
        public QSqlDriver Driver() {
            return (QSqlDriver) interceptor.Invoke("driver", "driver() const", typeof(QSqlDriver));
        }
        public QSqlDatabase(string type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlDatabase$", "QSqlDatabase(const QString&)", typeof(void), typeof(string), type);
        }
        public QSqlDatabase(QSqlDriver driver) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlDatabase#", "QSqlDatabase(QSqlDriver*)", typeof(void), typeof(QSqlDriver), driver);
        }
        ~QSqlDatabase() {
            interceptor.Invoke("~QSqlDatabase", "~QSqlDatabase()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QSqlDatabase", "~QSqlDatabase()", typeof(void));
        }
        public static QSqlDatabase AddDatabase(string type, string connectionName) {
            return (QSqlDatabase) staticInterceptor.Invoke("addDatabase$$", "addDatabase(const QString&, const QString&)", typeof(QSqlDatabase), typeof(string), type, typeof(string), connectionName);
        }
        public static QSqlDatabase AddDatabase(string type) {
            return (QSqlDatabase) staticInterceptor.Invoke("addDatabase$", "addDatabase(const QString&)", typeof(QSqlDatabase), typeof(string), type);
        }
        public static QSqlDatabase AddDatabase(QSqlDriver driver, string connectionName) {
            return (QSqlDatabase) staticInterceptor.Invoke("addDatabase#$", "addDatabase(QSqlDriver*, const QString&)", typeof(QSqlDatabase), typeof(QSqlDriver), driver, typeof(string), connectionName);
        }
        public static QSqlDatabase AddDatabase(QSqlDriver driver) {
            return (QSqlDatabase) staticInterceptor.Invoke("addDatabase#", "addDatabase(QSqlDriver*)", typeof(QSqlDatabase), typeof(QSqlDriver), driver);
        }
        public static QSqlDatabase CloneDatabase(QSqlDatabase other, string connectionName) {
            return (QSqlDatabase) staticInterceptor.Invoke("cloneDatabase#$", "cloneDatabase(const QSqlDatabase&, const QString&)", typeof(QSqlDatabase), typeof(QSqlDatabase), other, typeof(string), connectionName);
        }
        public static QSqlDatabase Database(string connectionName, bool open) {
            return (QSqlDatabase) staticInterceptor.Invoke("database$$", "database(const QString&, bool)", typeof(QSqlDatabase), typeof(string), connectionName, typeof(bool), open);
        }
        public static QSqlDatabase Database(string connectionName) {
            return (QSqlDatabase) staticInterceptor.Invoke("database$", "database(const QString&)", typeof(QSqlDatabase), typeof(string), connectionName);
        }
        public static QSqlDatabase Database() {
            return (QSqlDatabase) staticInterceptor.Invoke("database", "database()", typeof(QSqlDatabase));
        }
        public static void RemoveDatabase(string connectionName) {
            staticInterceptor.Invoke("removeDatabase$", "removeDatabase(const QString&)", typeof(void), typeof(string), connectionName);
        }
        public static bool Contains(string connectionName) {
            return (bool) staticInterceptor.Invoke("contains$", "contains(const QString&)", typeof(bool), typeof(string), connectionName);
        }
        public static bool Contains() {
            return (bool) staticInterceptor.Invoke("contains", "contains()", typeof(bool));
        }
        public static List<string> Drivers() {
            return (List<string>) staticInterceptor.Invoke("drivers", "drivers()", typeof(List<string>));
        }
        public static List<string> ConnectionNames() {
            return (List<string>) staticInterceptor.Invoke("connectionNames", "connectionNames()", typeof(List<string>));
        }
        public static bool IsDriverAvailable(string name) {
            return (bool) staticInterceptor.Invoke("isDriverAvailable$", "isDriverAvailable(const QString&)", typeof(bool), typeof(string), name);
        }
    }
}