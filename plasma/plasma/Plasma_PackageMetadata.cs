//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class PackageMetadata plasma/packagemetadata.h <Plasma/PackageMetadata>
    /// </remarks>        <short> Provides metadata for a Package. </short>
    [SmokeClass("Plasma::PackageMetadata")]
    public class PackageMetadata : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected PackageMetadata(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(PackageMetadata), this);
        }
        /// <remarks>
        ///  Default constructor
        /// </remarks>        <short>    Default constructor </short>
        public PackageMetadata() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("PackageMetadata", "PackageMetadata()", typeof(void));
        }
        /// <remarks>
        ///  Constructs a metadata object using the values in the file at path
        /// <param> name="path" path to a metadata.desktop file
        /// </param></remarks>        <short>    Constructs a metadata object using the values in the file at path </short>
        public PackageMetadata(string path) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("PackageMetadata$", "PackageMetadata(const QString&)", typeof(void), typeof(string), path);
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        /// <remarks>
        ///  Writes out the metadata to filename, which should be a .desktop
        ///  file. It writes out the information in a format that is compatible
        ///  with KPluginInfo
        ///  @arg filename path to the file to write to
        /// </remarks>        <short>    Writes out the metadata to filename, which should be a .</short>
        ///         <see> KPluginInfo</see>
        public void Write(string filename) {
            interceptor.Invoke("write$", "write(const QString&) const", typeof(void), typeof(string), filename);
        }
        /// <remarks>
        ///  Reads in metadata from a file, which should be a .desktop
        ///  file. It writes out the information in a format that is compatible
        ///  with KPluginInfo
        ///  @arg filename path to the file to write to
        /// </remarks>        <short>    Reads in metadata from a file, which should be a .</short>
        ///         <see> KPluginInfo</see>
        public void Read(string filename) {
            interceptor.Invoke("read$", "read(const QString&)", typeof(void), typeof(string), filename);
        }
        public string Name() {
            return (string) interceptor.Invoke("name", "name() const", typeof(string));
        }
        public string Description() {
            return (string) interceptor.Invoke("description", "description() const", typeof(string));
        }
        public string ServiceType() {
            return (string) interceptor.Invoke("serviceType", "serviceType() const", typeof(string));
        }
        public string Author() {
            return (string) interceptor.Invoke("author", "author() const", typeof(string));
        }
        public string Email() {
            return (string) interceptor.Invoke("email", "email() const", typeof(string));
        }
        public string Version() {
            return (string) interceptor.Invoke("version", "version() const", typeof(string));
        }
        public string Website() {
            return (string) interceptor.Invoke("website", "website() const", typeof(string));
        }
        public string License() {
            return (string) interceptor.Invoke("license", "license() const", typeof(string));
        }
        public string Application() {
            return (string) interceptor.Invoke("application", "application() const", typeof(string));
        }
        public string Category() {
            return (string) interceptor.Invoke("category", "category() const", typeof(string));
        }
        public string RequiredVersion() {
            return (string) interceptor.Invoke("requiredVersion", "requiredVersion() const", typeof(string));
        }
        public string PluginName() {
            return (string) interceptor.Invoke("pluginName", "pluginName() const", typeof(string));
        }
        public string ImplementationApi() {
            return (string) interceptor.Invoke("implementationApi", "implementationApi() const", typeof(string));
        }
        public string type() {
            return (string) interceptor.Invoke("type", "type() const", typeof(string));
        }
        /// <remarks>
        ///  Set the name of the package used to displayed
        ///  a short describing name.
        ///      </remarks>        <short>    Set the name of the package used to displayed  a short describing name.</short>
        public void SetName(string arg1) {
            interceptor.Invoke("setName$", "setName(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the description used to provide some general
        ///  information what the package is about.
        ///      </remarks>        <short>    Set the description used to provide some general  information what the package is about.</short>
        public void SetDescription(string arg1) {
            interceptor.Invoke("setDescription$", "setDescription(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the service-type which defines the X-KDE-ServiceTypes
        ///  type within the desktop file. If not defined this
        ///  defaults to "Plasma/Applet,Plasma/Containment" in the
        ///  desktop file.
        ///      </remarks>        <short>    Set the service-type which defines the X-KDE-ServiceTypes  type within the desktop file.</short>
        public void SetServiceType(string arg1) {
            interceptor.Invoke("setServiceType$", "setServiceType(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the name of the author of the package.
        ///      </remarks>        <short>    Set the name of the author of the package.</short>
        public void SetAuthor(string arg1) {
            interceptor.Invoke("setAuthor$", "setAuthor(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the E-Mail address of the author or of the project
        ///  that provided the package.
        ///      </remarks>        <short>    Set the E-Mail address of the author or of the project  that provided the package.</short>
        public void SetEmail(string arg1) {
            interceptor.Invoke("setEmail$", "setEmail(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the version of the package.
        ///      </remarks>        <short>    Set the version of the package.</short>
        public void SetVersion(string arg1) {
            interceptor.Invoke("setVersion$", "setVersion(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the website URL where the package is hosted or
        ///  where additional details about the project are available.
        ///      </remarks>        <short>    Set the website URL where the package is hosted or  where additional details about the project are available.</short>
        public void SetWebsite(string arg1) {
            interceptor.Invoke("setWebsite$", "setWebsite(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the license the package is distributed under.
        ///      </remarks>        <short>    Set the license the package is distributed under.</short>
        public void SetLicense(string arg1) {
            interceptor.Invoke("setLicense$", "setLicense(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the name of the application this package may
        ///  belongs to. This is used only for display purposes
        ///  so far.
        ///      </remarks>        <short>    Set the name of the application this package may  belongs to.</short>
        public void SetApplication(string arg1) {
            interceptor.Invoke("setApplication$", "setApplication(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Sets the category this package belongs in
        ///      </remarks>        <short>    Sets the category this package belongs in      </short>
        public void SetCategory(string arg1) {
            interceptor.Invoke("setCategory$", "setCategory(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the required version. See also the setVersion()
        ///  method.
        ///      </remarks>        <short>    Set the required version.</short>
        public void SetRequiredVersion(string arg1) {
            interceptor.Invoke("setRequiredVersion$", "setRequiredVersion(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the type of the package. If not defined this
        ///  defaults to "Service" in the desktop file.
        ///      </remarks>        <short>    Set the type of the package.</short>
        public void SetType(string type) {
            interceptor.Invoke("setType$", "setType(const QString&)", typeof(void), typeof(string), type);
        }
        /// <remarks>
        ///  Set the plugin name of the package.
        ///  The plugin name is used to locate the package;
        ///  @code
        ///  string serviceName("plasma-applet-" + data.pluginName());
        ///  string service = KStandardDirs.LocateLocal("services", serviceName + ".desktop");
        ///  @endcode
        ///      </remarks>        <short>    Set the plugin name of the package.</short>
        public void SetPluginName(string name) {
            interceptor.Invoke("setPluginName$", "setPluginName(const QString&)", typeof(void), typeof(string), name);
        }
        /// <remarks>
        ///  Set the implementation API this package uses.
        ///      </remarks>        <short>    Set the implementation API this package uses.</short>
        public void SetImplementationApi(string api) {
            interceptor.Invoke("setImplementationApi$", "setImplementationApi(const QString&)", typeof(void), typeof(string), api);
        }
        ~PackageMetadata() {
            interceptor.Invoke("~PackageMetadata", "~PackageMetadata()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~PackageMetadata", "~PackageMetadata()", typeof(void));
        }
    }
}
