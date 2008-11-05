//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    [SmokeClass("Plasma::ConfigLoader")]
    public class ConfigLoader : KConfigSkeleton, IDisposable {
        protected ConfigLoader(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ConfigLoader), this);
        }
        /// <remarks>
        ///  Creates a KConfigSkeleton populated using the definition found in
        ///  the XML data passed in.
        /// <param> name="configFile" path to the configuration file to use
        /// </param><param> name="xml" the xml data; must be valid KConfigXT data
        /// </param><param> name="parent" optional QObject parent
        /// </param></remarks>        <short>    Creates a KConfigSkeleton populated using the definition found in  the XML data passed in.</short>
        public ConfigLoader(string configFile, QIODevice xml, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigLoader$##", "ConfigLoader(const QString&, QIODevice*, QObject*)", typeof(void), typeof(string), configFile, typeof(QIODevice), xml, typeof(QObject), parent);
        }
        public ConfigLoader(string configFile, QIODevice xml) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigLoader$#", "ConfigLoader(const QString&, QIODevice*)", typeof(void), typeof(string), configFile, typeof(QIODevice), xml);
        }
        /// <remarks>
        ///  Creates a KConfigSkeleton populated using the definition found in
        ///  the XML data passed in.
        /// <param> name="config" the configuration object to use
        /// </param><param> name="xml" the xml data; must be valid KConfigXT data
        /// </param><param> name="parent" optional QObject parent
        /// </param></remarks>        <short>    Creates a KConfigSkeleton populated using the definition found in  the XML data passed in.</short>
        public ConfigLoader(KSharedConfig config, QIODevice xml, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigLoader?##", "ConfigLoader(KSharedPtr<KSharedConfig>, QIODevice*, QObject*)", typeof(void), typeof(KSharedConfig), config, typeof(QIODevice), xml, typeof(QObject), parent);
        }
        public ConfigLoader(KSharedConfig config, QIODevice xml) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigLoader?#", "ConfigLoader(KSharedPtr<KSharedConfig>, QIODevice*)", typeof(void), typeof(KSharedConfig), config, typeof(QIODevice), xml);
        }
        /// <remarks>
        ///  Creates a KConfigSkeleton populated using the definition found in
        ///  the XML data passed in.
        /// <param> name="config" the group to use as the root for configuration items
        /// </param><param> name="xml" the xml data; must be valid KConfigXT data
        /// </param><param> name="parent" optional QObject parent
        /// </param></remarks>        <short>    Creates a KConfigSkeleton populated using the definition found in  the XML data passed in.</short>
        public ConfigLoader(KConfigGroup config, QIODevice xml, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigLoader###", "ConfigLoader(const KConfigGroup*, QIODevice*, QObject*)", typeof(void), typeof(KConfigGroup), config, typeof(QIODevice), xml, typeof(QObject), parent);
        }
        public ConfigLoader(KConfigGroup config, QIODevice xml) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigLoader##", "ConfigLoader(const KConfigGroup*, QIODevice*)", typeof(void), typeof(KConfigGroup), config, typeof(QIODevice), xml);
        }
        /// <remarks>
        ///  Finds the item for the given group and key.
        ///  @arg group the group in the config file to look in
        ///  @arg key the configuration key to find
        /// </remarks>        <return> the associated KConfigSkeletonItem, or 0 if none
        ///      </return>
        ///         <short>    Finds the item for the given group and key.</short>
        public KConfigSkeletonItem FindItem(string group, string key) {
            return (KConfigSkeletonItem) interceptor.Invoke("findItem$$", "findItem(const QString&, const QString&)", typeof(KConfigSkeletonItem), typeof(string), group, typeof(string), key);
        }
        /// <remarks>
        ///  Check to see if a group exists
        /// <param> name="group" the name of the group to check for
        /// </param></remarks>        <return> true if the group exists, or false if it does not
        ///      </return>
        ///         <short>    Check to see if a group exists </short>
        public bool HasGroup(string group) {
            return (bool) interceptor.Invoke("hasGroup$", "hasGroup(const QString&) const", typeof(bool), typeof(string), group);
        }
        /// <remarks>
        /// </remarks>        <return> the list of groups defined by the XML
        ///      </return>
        ///         <short>   </short>
        public List<string> GroupList() {
            return (List<string>) interceptor.Invoke("groupList", "groupList() const", typeof(List<string>));
        }
        ~ConfigLoader() {
            interceptor.Invoke("~ConfigLoader", "~ConfigLoader()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ConfigLoader", "~ConfigLoader()", typeof(void));
        }
        protected new IConfigLoaderSignals Emit {
            get { return (IConfigLoaderSignals) Q_EMIT; }
        }
    }

    public interface IConfigLoaderSignals : IKConfigSkeletonSignals {
    }
}