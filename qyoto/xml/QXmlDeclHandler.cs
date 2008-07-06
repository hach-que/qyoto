//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;

    public interface IQXmlDeclHandler {
        bool AttributeDecl(string eName, string aName, string type, string valueDefault, string value);
        bool InternalEntityDecl(string name, string value);
        bool ExternalEntityDecl(string name, string publicId, string systemId);
        string ErrorString();
    }
    [SmokeClass("QXmlDeclHandler")]
    public abstract class QXmlDeclHandler : Object, IQXmlDeclHandler {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QXmlDeclHandler(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QXmlDeclHandler), this);
        }
        [SmokeMethod("attributeDecl(const QString&, const QString&, const QString&, const QString&, const QString&)")]
        public abstract bool AttributeDecl(string eName, string aName, string type, string valueDefault, string value);
        [SmokeMethod("internalEntityDecl(const QString&, const QString&)")]
        public abstract bool InternalEntityDecl(string name, string value);
        [SmokeMethod("externalEntityDecl(const QString&, const QString&, const QString&)")]
        public abstract bool ExternalEntityDecl(string name, string publicId, string systemId);
        [SmokeMethod("errorString() const")]
        public abstract string ErrorString();
        public QXmlDeclHandler() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QXmlDeclHandler", "QXmlDeclHandler()", typeof(void));
        }
    }
}
