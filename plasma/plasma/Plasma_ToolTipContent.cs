//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    [SmokeClass("Plasma::ToolTipContent")]
    public class ToolTipContent : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected ToolTipContent(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ToolTipContent), this);
        }
        /// <remarks> Creates an empty Content </remarks>        <short>   Creates an empty Content </short>
        public ToolTipContent() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ToolTipContent", "ToolTipContent()", typeof(void));
        }
        /// <remarks> Copy constructor </remarks>        <short>   Copy constructor </short>
        public ToolTipContent(Plasma.ToolTipContent other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ToolTipContent#", "ToolTipContent(const Plasma::ToolTipContent&)", typeof(void), typeof(Plasma.ToolTipContent), other);
        }
        /// <remarks> Constructor that sets the common fields </remarks>        <short>   Constructor that sets the common fields </short>
        public ToolTipContent(string mainText, string subText, QPixmap image) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ToolTipContent$$#", "ToolTipContent(const QString&, const QString&, const QPixmap&)", typeof(void), typeof(string), mainText, typeof(string), subText, typeof(QPixmap), image);
        }
        public ToolTipContent(string mainText, string subText) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ToolTipContent$$", "ToolTipContent(const QString&, const QString&)", typeof(void), typeof(string), mainText, typeof(string), subText);
        }
        /// <remarks> Constructor that sets the common fields </remarks>        <short>   Constructor that sets the common fields </short>
        public ToolTipContent(string mainText, string subText, QIcon icon) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ToolTipContent$$#", "ToolTipContent(const QString&, const QString&, const QIcon&)", typeof(void), typeof(string), mainText, typeof(string), subText, typeof(QIcon), icon);
        }
        /// <remarks> @return true if all the fields are empty </remarks>        <short>   @return true if all the fields are empty </short>
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        /// <remarks> Sets the main text which containts important information, e.g. the title </remarks>        <short>   Sets the main text which containts important information, e.</short>
        public void SetMainText(string text) {
            interceptor.Invoke("setMainText$", "setMainText(const QString&)", typeof(void), typeof(string), text);
        }
        /// <remarks> Important information, e.g. the title </remarks>        <short>   Important information, e.</short>
        public string MainText() {
            return (string) interceptor.Invoke("mainText", "mainText() const", typeof(string));
        }
        /// <remarks> Sets text which elaborates on the <code>mainText</code> </remarks>        <short>   Sets text which elaborates on the <code>mainText</code> </short>
        public void SetSubText(string text) {
            interceptor.Invoke("setSubText$", "setSubText(const QString&)", typeof(void), typeof(string), text);
        }
        /// <remarks> Elaborates on the <code>mainText</code> </remarks>        <short>   Elaborates on the <code>mainText</code> </short>
        public string SubText() {
            return (string) interceptor.Invoke("subText", "subText() const", typeof(string));
        }
        /// <remarks> Sets the icon to show *</remarks>        <short>   Sets the icon to show  </short>
        public void SetImage(QPixmap image) {
            interceptor.Invoke("setImage#", "setImage(const QPixmap&)", typeof(void), typeof(QPixmap), image);
        }
        /// <remarks> Sets the icon to show *</remarks>        <short>   Sets the icon to show  </short>
        public void SetImage(QIcon icon) {
            interceptor.Invoke("setImage#", "setImage(const QIcon&)", typeof(void), typeof(QIcon), icon);
        }
        /// <remarks> An icon to display </remarks>        <short>   An icon to display </short>
        public QPixmap Image() {
            return (QPixmap) interceptor.Invoke("image", "image() const", typeof(QPixmap));
        }
        /// <remarks> Sets the ID of the window to show a preview for </remarks>        <short>   Sets the ID of the window to show a preview for </short>
        public void SetWindowToPreview(uint id) {
            interceptor.Invoke("setWindowToPreview$", "setWindowToPreview(WId)", typeof(void), typeof(uint), id);
        }
        /// <remarks> Id of a window if you want to show a preview </remarks>        <short>   Id of a window if you want to show a preview </short>
        public uint WindowToPreview() {
            return (uint) interceptor.Invoke("windowToPreview", "windowToPreview() const", typeof(uint));
        }
        /// <remarks> Sets whether or not to autohide the tooltip, defaults to true </remarks>        <short>   Sets whether or not to autohide the tooltip, defaults to true </short>
        public void SetAutohide(bool autohide) {
            interceptor.Invoke("setAutohide$", "setAutohide(bool)", typeof(void), typeof(bool), autohide);
        }
        /// <remarks> Whether or not to autohide the tooltip, defaults to true </remarks>        <short>   Whether or not to autohide the tooltip, defaults to true </short>
        public bool Autohide() {
            return (bool) interceptor.Invoke("autohide", "autohide() const", typeof(bool));
        }
        ~ToolTipContent() {
            interceptor.Invoke("~ToolTipContent", "~ToolTipContent()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~ToolTipContent", "~ToolTipContent()", typeof(void));
        }
    }
}