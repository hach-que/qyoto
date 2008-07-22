//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  This job removes the given item from the Akonadi storage.
    ///  Example:
    ///  @code
    ///  Akonadi.Item item = ...
    ///  ItemDeleteJob job = new ItemDeleteJob( item );
    ///  if ( job.Exec() )
    ///    qDebug() << "Item deleted successfully";
    ///  else
    ///    qDebug() << "Error occurred";
    ///  @endcode
    /// </remarks>        <author> Volker Krause <vkrause@kde.org>
    ///  </author>
    ///         <short> Job that deletes an item from the Akonadi storage. </short>
    [SmokeClass("Akonadi::ItemDeleteJob")]
    public class ItemDeleteJob : Akonadi.Job, IDisposable {
        protected ItemDeleteJob(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ItemDeleteJob), this);
        }
        /// <remarks>
        ///  Creates a new item delete job.
        /// <param> name="item" The item to delete.
        /// </param><param> name="parent" The parent object.
        ///      </param></remarks>        <short>    Creates a new item delete job.</short>
        public ItemDeleteJob(Akonadi.Item item, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ItemDeleteJob##", "ItemDeleteJob(const Akonadi::Item&, QObject*)", typeof(void), typeof(Akonadi.Item), item, typeof(QObject), parent);
        }
        public ItemDeleteJob(Akonadi.Item item) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ItemDeleteJob#", "ItemDeleteJob(const Akonadi::Item&)", typeof(void), typeof(Akonadi.Item), item);
        }
        [SmokeMethod("doStart()")]
        protected override void DoStart() {
            interceptor.Invoke("doStart", "doStart()", typeof(void));
        }
        ~ItemDeleteJob() {
            interceptor.Invoke("~ItemDeleteJob", "~ItemDeleteJob()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ItemDeleteJob", "~ItemDeleteJob()", typeof(void));
        }
        protected new IItemDeleteJobSignals Emit {
            get { return (IItemDeleteJobSignals) Q_EMIT; }
        }
    }

    public interface IItemDeleteJobSignals : Akonadi.IJobSignals {
    }
}
