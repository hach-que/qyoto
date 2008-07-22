//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  This class provides the interface of a QAbstractItemModel to
    ///  access all available agent types: their name, identifier,
    ///  supported mimetypes and capabilities.
    ///  @code
    ///  Akonadi.AgentTypeModel model = new Akonadi.AgentTypeModel( this );
    ///  QListView view = new QListView( this );
    ///  view.SetModel( model );
    ///  @endcode
    ///  To show only agent types that match a given mime type or special
    ///  capabilities, use the AgentFilterProxyModel on top of this model.
    /// </remarks>        <author> Tobias Koenig <tokoe@kde.org>
    ///  </author>
    ///         <short> Provides a data model for agent types. </short>
    [SmokeClass("Akonadi::AgentTypeModel")]
    public class AgentTypeModel : QAbstractItemModel, IDisposable {
        protected AgentTypeModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(AgentTypeModel), this);
        }
        /// <remarks>
        ///  Describes the roles of this model.
        ///      </remarks>        <short>    Describes the roles of this model.</short>
        public enum Roles {
            TypeRole = Qt.ItemDataRole.UserRole+1,
            IdentifierRole = 0,
            DescriptionRole = 1,
            MimeTypesRole = 2,
            CapabilitiesRole = 3,
            UserRole = Qt.ItemDataRole.UserRole+42,
        }
        /// <remarks>
        ///  Creates a new agent type model.
        ///      </remarks>        <short>    Creates a new agent type model.</short>
        public AgentTypeModel(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AgentTypeModel#", "AgentTypeModel(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public AgentTypeModel() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AgentTypeModel", "AgentTypeModel()", typeof(void));
        }
        [SmokeMethod("columnCount(const QModelIndex&) const")]
        public override int ColumnCount(QModelIndex parent) {
            return (int) interceptor.Invoke("columnCount#", "columnCount(const QModelIndex&) const", typeof(int), typeof(QModelIndex), parent);
        }
        [SmokeMethod("columnCount() const")]
        public virtual int ColumnCount() {
            return (int) interceptor.Invoke("columnCount", "columnCount() const", typeof(int));
        }
        [SmokeMethod("rowCount(const QModelIndex&) const")]
        public override int RowCount(QModelIndex parent) {
            return (int) interceptor.Invoke("rowCount#", "rowCount(const QModelIndex&) const", typeof(int), typeof(QModelIndex), parent);
        }
        [SmokeMethod("rowCount() const")]
        public virtual int RowCount() {
            return (int) interceptor.Invoke("rowCount", "rowCount() const", typeof(int));
        }
        [SmokeMethod("data(const QModelIndex&, int) const")]
        public override QVariant Data(QModelIndex index, int role) {
            return (QVariant) interceptor.Invoke("data#$", "data(const QModelIndex&, int) const", typeof(QVariant), typeof(QModelIndex), index, typeof(int), role);
        }
        [SmokeMethod("data(const QModelIndex&) const")]
        public virtual QVariant Data(QModelIndex index) {
            return (QVariant) interceptor.Invoke("data#", "data(const QModelIndex&) const", typeof(QVariant), typeof(QModelIndex), index);
        }
        [SmokeMethod("index(int, int, const QModelIndex&) const")]
        public override QModelIndex Index(int row, int column, QModelIndex parent) {
            return (QModelIndex) interceptor.Invoke("index$$#", "index(int, int, const QModelIndex&) const", typeof(QModelIndex), typeof(int), row, typeof(int), column, typeof(QModelIndex), parent);
        }
        [SmokeMethod("index(int, int) const")]
        public virtual QModelIndex Index(int row, int column) {
            return (QModelIndex) interceptor.Invoke("index$$", "index(int, int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column);
        }
        [SmokeMethod("parent(const QModelIndex&) const")]
        public override QModelIndex Parent(QModelIndex index) {
            return (QModelIndex) interceptor.Invoke("parent#", "parent(const QModelIndex&) const", typeof(QModelIndex), typeof(QModelIndex), index);
        }
        ~AgentTypeModel() {
            interceptor.Invoke("~AgentTypeModel", "~AgentTypeModel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~AgentTypeModel", "~AgentTypeModel()", typeof(void));
        }
        protected new IAgentTypeModelSignals Emit {
            get { return (IAgentTypeModelSignals) Q_EMIT; }
        }
    }

    public interface IAgentTypeModelSignals : IQAbstractItemModelSignals {
    }
}