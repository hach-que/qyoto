//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @brief A set of data exported via a DataEngine
    ///  Plasma.DataContainer wraps the data exported by a DataEngine
    ///  implementation, providing a generic wrapper for the data.
    ///  A DataContainer may have zero or more associated pieces of data which
    ///  are keyed by strings. The data itself is stored as QVariants. This allows
    ///  easy and flexible retrieval of the information associated with this object
    ///  without writing DataContainer or DataEngine specific code in visualizations.
    ///  See <see cref="IDataContainerSignals"></see> for signals emitted by DataContainer
    /// </remarks>        <short>    @brief A set of data exported via a DataEngine </short>
    [SmokeClass("Plasma::DataContainer")]
    public class DataContainer : QObject, IDisposable {
        protected DataContainer(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(DataContainer), this);
        }
        /// <remarks>
        ///  Constructs a default DataContainer, which has no name or data
        ///  associated with it
        /// </remarks>        <short>    Constructs a default DataContainer, which has no name or data  associated with it </short>
        public DataContainer(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("DataContainer#", "DataContainer(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public DataContainer() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("DataContainer", "DataContainer()", typeof(void));
        }
        /// <remarks>
        ///  Returns the data for this DataContainer
        /// </remarks>        <short>    Returns the data for this DataContainer </short>
        public Dictionary<string, QVariant> Data() {
            return (Dictionary<string, QVariant>) interceptor.Invoke("data", "data() const", typeof(Dictionary<string, QVariant>));
        }
        /// <remarks>
        ///  Set a value for a key. This also marks this source as needing
        ///  to signal an update. After calling this, a call to checkForUpdate()
        ///  is done by the engine. This allows for batching updates.
        /// <param> name="key" a string used as the key for the data
        /// </param><param> name="value" a QVariant holding the actual data. If a null or invalid
        ///               QVariant is passed in and the key currently exists in the
        ///               data, then the data entry is removed
        /// </param></remarks>        <short>    Set a value for a key.</short>
        public void SetData(string key, QVariant value) {
            interceptor.Invoke("setData$#", "setData(const QString&, const QVariant&)", typeof(void), typeof(string), key, typeof(QVariant), value);
        }
        /// <remarks>
        ///  Removes all data currently associated with this source
        /// </remarks>        <short>    Removes all data currently associated with this source </short>
        public void RemoveAllData() {
            interceptor.Invoke("removeAllData", "removeAllData()", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> true if the visualization is currently connected
        ///          </return>
        ///         <short>   </short>
        public bool VisualizationIsConnected(QObject visualization) {
            return (bool) interceptor.Invoke("visualizationIsConnected#", "visualizationIsConnected(QObject*) const", typeof(bool), typeof(QObject), visualization);
        }
        /// <remarks>
        ///  Connects an object to this DataContainer. May be called repeatedly
        ///  for the same visualization without side effects
        /// <param> name="visualization" the object to connect to this DataContainer
        /// </param><param> name="pollingInterval" the time in milliseconds between updates
        /// </param></remarks>        <short>    Connects an object to this DataContainer.</short>
        public void ConnectVisualization(QObject visualization, uint pollingInterval, Plasma.IntervalAlignment alignment) {
            interceptor.Invoke("connectVisualization#$$", "connectVisualization(QObject*, uint, Plasma::IntervalAlignment)", typeof(void), typeof(QObject), visualization, typeof(uint), pollingInterval, typeof(Plasma.IntervalAlignment), alignment);
        }
        /// <remarks>
        ///  Disconnects an object from this DataContainer.
        /// </remarks>        <short>    Disconnects an object from this DataContainer.</short>
        [Q_SLOT("void disconnectVisualization(QObject*)")]
        public void DisconnectVisualization(QObject visualization) {
            interceptor.Invoke("disconnectVisualization#", "disconnectVisualization(QObject*)", typeof(void), typeof(QObject), visualization);
        }
        /// <remarks>
        ///  Checks for whether the data has changed and therefore an update
        ///  signal needs to be emitted.
        /// </remarks>        <short>    Checks for whether the data has changed and therefore an update  signal needs to be emitted.</short>
        protected void CheckForUpdate() {
            interceptor.Invoke("checkForUpdate", "checkForUpdate()", typeof(void));
        }
        /// <remarks>
        ///  Returns how long ago, in msecs, that the data in this container was last updated
        /// </remarks>        <short>    Returns how long ago, in msecs, that the data in this container was last updated </short>
        protected uint TimeSinceLastUpdate() {
            return (uint) interceptor.Invoke("timeSinceLastUpdate", "timeSinceLastUpdate() const", typeof(uint));
        }
        /// <remarks>
        ///  Indicates that the data should be treated as dirty the next time hasUpdates() is called.
        ///  why? because if one SignalRelay times out just after another, the minimum update
        ///  interval stops a real update from being done - but that relay still needs to be given
        ///  data, because it won't have been in the queue and won't have gotten that last update.
        ///  when it checks hasUpdates() we'll lie, and then everything will return to normal.
        /// </remarks>        <short>    Indicates that the data should be treated as dirty the next time hasUpdates() is called.</short>
        protected void SetNeedsUpdate(bool update) {
            interceptor.Invoke("setNeedsUpdate$", "setNeedsUpdate(bool)", typeof(void), typeof(bool), update);
        }
        protected void SetNeedsUpdate() {
            interceptor.Invoke("setNeedsUpdate", "setNeedsUpdate()", typeof(void));
        }
        /// <remarks>
        ///  Check if the DataContainer is still in use.
        ///  If not the signal "becameUnused" will be emitted.
        ///  Warning: The DataContainer may be invalid after calling this function.
        ///          </remarks>        <short>    Check if the DataContainer is still in use.</short>
        [Q_SLOT("void checkUsage()")]
        protected void CheckUsage() {
            interceptor.Invoke("checkUsage", "checkUsage()", typeof(void));
        }
        ~DataContainer() {
            interceptor.Invoke("~DataContainer", "~DataContainer()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~DataContainer", "~DataContainer()", typeof(void));
        }
        protected new IDataContainerSignals Emit {
            get { return (IDataContainerSignals) Q_EMIT; }
        }
    }

    public interface IDataContainerSignals : IQObjectSignals {
        /// <remarks>
        ///  Emitted when the data has been updated, allowing visualization to
        ///  reflect the new data.
        /// </remarks>        <short>    Emitted when the data has been updated, allowing visualization to  reflect the new data.</short>
        [Q_SIGNAL("void dataUpdated(QString, Plasma::DataEngine::Data)")]
        void DataUpdated(string source, Dictionary<string, QVariant> data);
        /// <remarks>
        ///  Emitted when this source becomes unused
        /// </remarks>        <short>    Emitted when this source becomes unused </short>
        [Q_SIGNAL("void becameUnused(QString)")]
        void BecameUnused(string source);
        /// <remarks>
        ///  Emitted when the source, usually due to an internal timer firing,
        ///  requests to be updated.
        /// </remarks>        <short>    Emitted when the source, usually due to an internal timer firing,  requests to be updated.</short>
        [Q_SIGNAL("void updateRequested(DataContainer*)")]
        void UpdateRequested(Plasma.DataContainer source);
    }
}
