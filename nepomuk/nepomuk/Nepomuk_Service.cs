//Auto-generated by kalyptus. DO NOT EDIT.
namespace Nepomuk {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \class Service nepomukservice.h Nepomuk/Service
    ///  \brief Base class for all Nepomuk services.
    ///  A %Nepomuk service is intended to perform some kind of
    ///  operation on the %Nepomuk data storage. This can include
    ///  data gathering, data enrichment, or enhanced data query.
    ///  %Nepomuk services are started and managed by the %Nepomuk
    ///  server. Very much like KDED modules a %Nepomuk service
    ///  has autostart and start-on-demand properties. In addition
    ///  a %Nepomuk service can define an arbitrary number of
    ///  dependencies which are necessary to run the service. These
    ///  dependencies name other services.
    ///  To create a new %Nepomuk service one derives a new class from
    ///  Nepomuk.Service and exports it as a standard KDE module, i.e.
    ///  plugin.
    ///  <pre>
    ///  class MyService : public Nepomuk.Service
    ///  {
    ///     // do fancy stuff
    ///  }
    ///  </pre>
    ///  Export it as a %Nepomuk service plugin:
    ///  <pre>
    ///  NEPOMUK_EXPORT_SERVICE(MyService, "mynepomukservice")
    ///  </pre>
    ///  A desktop file describes the service's properties:
    ///  <pre>
    ///  [Desktop Entry]
    ///  Type=Service
    ///  X-KDE-ServiceTypes=NepomukService
    ///  X-KDE-Library=mynepomukservice
    ///  X-KDE-Nepomuk-autostart=true
    ///  X-KDE-Nepomuk-start-on-demand=false
    ///  # Dependencies default to 'nepomukstorage'
    ///  X-KDE-Nepomuk-dependencies=nepomukfoobar
    ///  Name=My fancy Nepomuk Service
    ///  Comment=A Nepomuk service that does fancy things
    ///  </pre>
    ///  The %Nepomuk server will automatically export all D-Bus
    ///  interfaces defined on the service instance. Thus, the 
    ///  simplest way to export methods via D-Bus is by marking
    ///  them with Q_SCRIPTABLE.
    ///  \author Sebastian Trueg <trueg@kde.org>
    ///  \since 4.1
    ///      </remarks>        <short>    \class Service nepomukservice.</short>
    [SmokeClass("Nepomuk::Service")]
    public class Service : QObject, IDisposable {
        protected Service(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Service), this);
        }
        /// <remarks>
        ///  Create a new Service.
        ///  \param parent The parent object
        ///  \param delayedInitialization If <pre>true</pre> the service will not
        ///  be usable until setServiceInitialized has been called.
        ///  This allows to design services that need to perform 
        ///  long initialization tasks.
        ///          </remarks>        <short>    Create a new Service.</short>
        public Service(QObject parent, bool delayedInitialization) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Service#$", "Service(QObject*, bool)", typeof(void), typeof(QObject), parent, typeof(bool), delayedInitialization);
        }
        public Service(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Service#", "Service(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public Service() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Service", "Service()", typeof(void));
        }
        /// <remarks>
        ///  \return A wrapper model which provides
        ///  a connection to the %Nepomuk server.
        ///          </remarks>        <short>    \return A wrapper model which provides  a connection to the %Nepomuk server.</short>
        protected Soprano.Model MainModel() {
            return (Soprano.Model) interceptor.Invoke("mainModel", "mainModel()", typeof(Soprano.Model));
        }
        /// <remarks>
        ///  A %Nepomuk service can make use of a warmup phase in which
        ///  it is not usable yet. Call this method once your service
        ///  is fully initialized.
        ///  Most services do not need to call this method.
        ///  \param success Set to <pre>true</pre> if initialization was
        ///  successful, <pre>false</pre> otherwise.
        ///  \sa Service.Service
        ///          </remarks>        <short>    A %Nepomuk service can make use of a warmup phase in which  it is not usable yet.</short>
        protected void SetServiceInitialized(bool succcess) {
            interceptor.Invoke("setServiceInitialized$", "setServiceInitialized(bool)", typeof(void), typeof(bool), succcess);
        }
        ~Service() {
            interceptor.Invoke("~Service", "~Service()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~Service", "~Service()", typeof(void));
        }
        protected new IServiceSignals Emit {
            get { return (IServiceSignals) Q_EMIT; }
        }
    }

    public interface IServiceSignals : IQObjectSignals {
    }
}