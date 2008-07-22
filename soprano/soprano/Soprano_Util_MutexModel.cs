//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Util {
    using Soprano;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \class MutexModel mutexmodel.h Soprano/Util/MutexModel
    ///  \brief Protect a Model for multiple calls in multi-threaded
    ///  applications.
    ///  In most cases one does not need to use this FilterModel since Models
    ///  created by Soprano.CreateModel and Soprano.Backend.CreateModel
    ///  are thread-safe. It may, however, come in handy for custom models.
    ///  \author Sebastian Trueg <trueg@kde.org>
    ///          </remarks>        <short>    \class MutexModel mutexmodel.</short>
    [SmokeClass("Soprano::Util::MutexModel")]
    public class MutexModel : Soprano.FilterModel, IDisposable {
        protected MutexModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(MutexModel), this);
        }
        public enum ProtectionMode {
            PlainMultiThreading = 0,
            ReadWriteMultiThreading = 1,
            ReadWriteSingleThreading = 2,
        }
        /// <remarks>
        ///  Create a new MutexModel.
        ///  \param mode The mode to use.
        ///  \param parent The parent Model to forward
        ///         the actual calls to.
        ///              </remarks>        <short>    Create a new MutexModel.</short>
        public MutexModel(Soprano.Util.MutexModel.ProtectionMode mode, Soprano.Model parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("MutexModel$#", "MutexModel(Soprano::Util::MutexModel::ProtectionMode, Soprano::Model*)", typeof(void), typeof(Soprano.Util.MutexModel.ProtectionMode), mode, typeof(Soprano.Model), parent);
        }
        public MutexModel(Soprano.Util.MutexModel.ProtectionMode mode) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("MutexModel$", "MutexModel(Soprano::Util::MutexModel::ProtectionMode)", typeof(void), typeof(Soprano.Util.MutexModel.ProtectionMode), mode);
        }
        [SmokeMethod("addStatement(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode AddStatement(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("addStatement#", "addStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("removeStatement(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode RemoveStatement(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("removeStatement#", "removeStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("removeAllStatements(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode RemoveAllStatements(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("removeAllStatements#", "removeAllStatements(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("listStatements(const Soprano::Statement&) const")]
        public override Soprano.StatementIterator ListStatements(Soprano.Statement partial) {
            return (Soprano.StatementIterator) interceptor.Invoke("listStatements#", "listStatements(const Soprano::Statement&) const", typeof(Soprano.StatementIterator), typeof(Soprano.Statement), partial);
        }
        [SmokeMethod("listContexts() const")]
        public override Soprano.NodeIterator ListContexts() {
            return (Soprano.NodeIterator) interceptor.Invoke("listContexts", "listContexts() const", typeof(Soprano.NodeIterator));
        }
        [SmokeMethod("executeQuery(const QString&, Soprano::Query::QueryLanguage, const QString&) const")]
        public override Soprano.QueryResultIterator ExecuteQuery(string query, Soprano.Query.QueryLanguage language, string userQueryLanguage) {
            return (Soprano.QueryResultIterator) interceptor.Invoke("executeQuery$$$", "executeQuery(const QString&, Soprano::Query::QueryLanguage, const QString&) const", typeof(Soprano.QueryResultIterator), typeof(string), query, typeof(Soprano.Query.QueryLanguage), language, typeof(string), userQueryLanguage);
        }
        [SmokeMethod("executeQuery(const QString&, Soprano::Query::QueryLanguage) const")]
        public override Soprano.QueryResultIterator ExecuteQuery(string query, Soprano.Query.QueryLanguage language) {
            return (Soprano.QueryResultIterator) interceptor.Invoke("executeQuery$$", "executeQuery(const QString&, Soprano::Query::QueryLanguage) const", typeof(Soprano.QueryResultIterator), typeof(string), query, typeof(Soprano.Query.QueryLanguage), language);
        }
        [SmokeMethod("containsStatement(const Soprano::Statement&) const")]
        public override bool ContainsStatement(Soprano.Statement statement) {
            return (bool) interceptor.Invoke("containsStatement#", "containsStatement(const Soprano::Statement&) const", typeof(bool), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("containsAnyStatement(const Soprano::Statement&) const")]
        public override bool ContainsAnyStatement(Soprano.Statement statement) {
            return (bool) interceptor.Invoke("containsAnyStatement#", "containsAnyStatement(const Soprano::Statement&) const", typeof(bool), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("isEmpty() const")]
        public override bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        [SmokeMethod("statementCount() const")]
        public override int StatementCount() {
            return (int) interceptor.Invoke("statementCount", "statementCount() const", typeof(int));
        }
        ~MutexModel() {
            interceptor.Invoke("~MutexModel", "~MutexModel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~MutexModel", "~MutexModel()", typeof(void));
        }
        protected new IMutexModelSignals Emit {
            get { return (IMutexModelSignals) Q_EMIT; }
        }
    }

    public interface IMutexModelSignals : Soprano.IFilterModelSignals {
    }
}
