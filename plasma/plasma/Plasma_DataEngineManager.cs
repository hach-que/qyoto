//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @brief DataEngine loader and life time manager
    ///  Plasma.DataEngineManager provides facilities for listing, loading and
    ///  according to reference count unloading of DataEngines.
    /// </remarks>        <short>    @brief DataEngine loader and life time manager </short>
    [SmokeClass("Plasma::DataEngineManager")]
    public class DataEngineManager : QObject {
        protected DataEngineManager(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(DataEngineManager), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static DataEngineManager() {
            staticInterceptor = new SmokeInvocation(typeof(DataEngineManager), null);
        }
        /// <remarks>
        ///  Returns a data engine object if one is loaded and available.
        ///  On failure, the fallback NullEngine (which does nothing and
        ///  !isValid()) is returned.
        /// <param> name="name" the name of the engine
        ///          </param></remarks>        <short>    Returns a data engine object if one is loaded and available.</short>
        public Plasma.DataEngine Engine(string name) {
            return (Plasma.DataEngine) interceptor.Invoke("engine$", "engine(const QString&) const", typeof(Plasma.DataEngine), typeof(string), name);
        }
        /// <remarks>
        ///  Loads a data engine and increases the reference count on it.
        ///  This should be called once per object (or set of objects) using the
        ///  DataEngine. Afterwards, dataEngine should be used or the return
        ///  value cached. Call unloadDataEngine when finished with the engine.
        /// <param> name="name" the name of the engine
        /// </param></remarks>        <return> the data engine that was loaded, or the NullEngine on failure.
        ///          </return>
        ///         <short>    Loads a data engine and increases the reference count on it.</short>
        public Plasma.DataEngine LoadEngine(string name) {
            return (Plasma.DataEngine) interceptor.Invoke("loadEngine$", "loadEngine(const QString&)", typeof(Plasma.DataEngine), typeof(string), name);
        }
        /// <remarks>
        ///  Decreases the reference count on the engine. If the count reaches
        ///  zero, then the engine is deleted to save resources.
        ///          </remarks>        <short>    Decreases the reference count on the engine.</short>
        public void UnloadEngine(string name) {
            interceptor.Invoke("unloadEngine$", "unloadEngine(const QString&)", typeof(void), typeof(string), name);
        }
        /// <remarks>
        ///  Singleton pattern accessor.
        ///          </remarks>        <short>    Singleton pattern accessor.</short>
        public static Plasma.DataEngineManager Self() {
            return (Plasma.DataEngineManager) staticInterceptor.Invoke("self", "self()", typeof(Plasma.DataEngineManager));
        }
        /// <remarks>
        ///  Returns a listing of all known engines by name
        ///          </remarks>        <short>    Returns a listing of all known engines by name          </short>
        public static List<string> ListAllEngines() {
            return (List<string>) staticInterceptor.Invoke("listAllEngines", "listAllEngines()", typeof(List<string>));
        }
        protected new IDataEngineManagerSignals Emit {
            get { return (IDataEngineManagerSignals) Q_EMIT; }
        }
    }

    public interface IDataEngineManagerSignals : IQObjectSignals {
    }
}
