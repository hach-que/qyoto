//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  It shows the list of available plugins
	///  Since the user needs a way to know what a specific plugin does every plugin
	///  sould install a desktop file containing a name, comment and category field.
	///  The category is useful for applications that can use different kinds of
	///  plugins like a playlist, skin or visualization
	///  The location of these desktop files is the
	///  share/apps/&lt;instancename&gt;/&lt;plugindir&gt; directory. But if you need
	///  you may use a different directory
	///  You can add plugins from different KConfig[group], by just calling all times
	///  you want addPlugins method with the correct parameters
	///  Additionally, calls to constructor with same <code>categoryName</code>, will add new
	///  items to the same category, even if plugins are from different categories
	///  See <see cref="IKPluginSelectorSignals"></see> for signals emitted by KPluginSelector
	/// </remarks>		<author> Rafael Fernández López <ereslibre@gmail.com>
	///   </author>
	/// 		<short> A widget to select what plugins to load and configure the plugins. </short>

	[SmokeClass("KPluginSelector")]
	public class KPluginSelector : QWidget, IDisposable {
 		protected KPluginSelector(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPluginSelector), this);
		}
		public enum PluginLoadMethod {
			ReadConfigFile = 0,
			IgnoreConfigFile = 1,
		}
		// void addPlugins(const QString& arg1,const QString& arg2,const QString& arg3,KSharedConfig::Ptr arg4); >>>> NOT CONVERTED
		// void addPlugins(const KComponentData& arg1,const QString& arg2,const QString& arg3,const KSharedConfig::Ptr& arg4); >>>> NOT CONVERTED
		// void addPlugins(const QList<KPluginInfo>& arg1,KPluginSelector::PluginLoadMethod arg2,const QString& arg3,const QString& arg4,const KSharedConfig::Ptr& arg5); >>>> NOT CONVERTED
		// void addPlugins(const QList<KPluginInfo>& arg1,KPluginSelector::PluginLoadMethod arg2,const QString& arg3,const QString& arg4); >>>> NOT CONVERTED
		// void addPlugins(const QList<KPluginInfo>& arg1,KPluginSelector::PluginLoadMethod arg2,const QString& arg3); >>>> NOT CONVERTED
		// void addPlugins(const QList<KPluginInfo>& arg1,KPluginSelector::PluginLoadMethod arg2); >>>> NOT CONVERTED
		// void addPlugins(const QList<KPluginInfo>& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Create a new KPluginSelector
		///       </remarks>		<short>    Create a new KPluginSelector       </short>
		public KPluginSelector(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPluginSelector#", "KPluginSelector(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPluginSelector() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPluginSelector", "KPluginSelector()", typeof(void));
		}
		/// <remarks>
		///  Add a list of KParts plugins
		///  The information about the plugins will be loaded from the
		///  share/apps/&lt;instancename&gt;/kpartplugins directory
		/// <param> name="componentName" The name of the KComponentData of the plugin's parent.
		/// </param><param> name="categoryName" The translated name of the category. This is the
		///                       name that is shown in the title. If the category
		///                       did exist before because of another call to
		///                       addPlugins, then they will be shown in that
		///                       category. If <code>categoryName</code> is a new one, then
		///                       a new category will be shown on the plugin window,
		///                       and the list of plugins added to it
		/// </param><param> name="categoryKey" When you have different categories of KParts
		///                       plugins you distinguish between the plugins using
		///                       the Category key in the .desktop file. Use this
		///                       parameter to select only those KParts plugins
		///                       with the Category key == <code>categoryKey.</code> If
		///                       <code>categoryKey</code> is not set the Category key is
		///                       ignored and all plugins are shown. Not match case
		/// </param><param> name="config" The KConfig object that holds the state of the
		///                       plugins being enabled or not. By default it should
		///                       be componentData.config(). It is recommended to
		///                       always pass a KConfig object if you use
		///                       KSettings.PluginPage since you never know from where the
		///                       page will be called (think global config app).
		///                       For example KViewCanvas passes KConfig(
		///                       "kviewcanvas" )
		///       </param></remarks>		<short>    Add a list of KParts plugins </short>
		public void AddPlugins(string componentName, string categoryName, string categoryKey) {
			interceptor.Invoke("addPlugins$$$", "addPlugins(const QString&, const QString&, const QString&)", typeof(void), typeof(string), componentName, typeof(string), categoryName, typeof(string), categoryKey);
		}
		public void AddPlugins(string componentName, string categoryName) {
			interceptor.Invoke("addPlugins$$", "addPlugins(const QString&, const QString&)", typeof(void), typeof(string), componentName, typeof(string), categoryName);
		}
		public void AddPlugins(string componentName) {
			interceptor.Invoke("addPlugins$", "addPlugins(const QString&)", typeof(void), typeof(string), componentName);
		}
		/// <remarks>
		///  Add a list of KParts plugins. Convenience method for the one above.
		///  If not set explicitly, <code>config</code> is set to componentData.config()
		///       </remarks>		<short>    Add a list of KParts plugins.</short>
		public void AddPlugins(KComponentData instance, string categoryName, string categoryKey) {
			interceptor.Invoke("addPlugins#$$", "addPlugins(const KComponentData&, const QString&, const QString&)", typeof(void), typeof(KComponentData), instance, typeof(string), categoryName, typeof(string), categoryKey);
		}
		public void AddPlugins(KComponentData instance, string categoryName) {
			interceptor.Invoke("addPlugins#$", "addPlugins(const KComponentData&, const QString&)", typeof(void), typeof(KComponentData), instance, typeof(string), categoryName);
		}
		public void AddPlugins(KComponentData instance) {
			interceptor.Invoke("addPlugins#", "addPlugins(const KComponentData&)", typeof(void), typeof(KComponentData), instance);
		}
		/// <remarks>
		///  Add a list of non-KParts plugins
		/// <param> name="pluginInfoList" A list of KPluginInfo objects containing the
		///                          necessary information for the plugins you want to
		///                          add to the list
		/// </param><param> name="pluginLoadMethod" If KPluginSelector will try to load the
		///                          state of the plugin when loading the
		///                          dialog from the configuration file or not.
		///                          This is useful if for some reason you
		///                          called the setPluginEnabled() for each plugin
		///                          individually before loading the dialog, and
		///                          don't want KPluginSelector to override them
		///                          when loading
		/// </param><param> name="categoryName" The translated name of the category. This is the
		///                          name that is shown in the title. If the category
		///                          did exist before because of another call to
		///                          addPlugins, then they will be shown in that
		///                          category. If <code>categoryName</code> is a new one, then
		///                          a new category will be shown on the plugin window,
		///                          and the list of plugins added to it
		/// </param><param> name="categoryKey" When you have different categories of KParts
		///                          plugins you distinguish between the plugins using
		///                          the Category key in the .desktop file. Use this
		///                          parameter to select only those KParts plugins
		///                          with the Category key == <code>categoryKey.</code> If
		///                          <code>categoryKey</code> is not set the Category key is
		///                          ignored and all plugins are shown. Not match case
		/// </param><param> name="config" The KConfig object that holds the state of the
		///                          plugins being enabled or not. By default it will
		///                          use KGlobal.Config(). It is recommended to
		///                          always pass a KConfig object if you use
		///                          KSettings.PluginPage since you never know from
		///                          where the page will be called (think global
		///                          config app). For example KViewCanvas passes
		///                          KConfig("kviewcanvas")
		/// </param> @note   All plugins that were set a config group using setConfig() method
		///          will load and save their information from there. For those that
		///          weren't any config object, <code>config</code> will be used
		///       </remarks>		<short>    Add a list of non-KParts plugins </short>
		/// <remarks>
		///  Load the state of the plugins (selected or not) from the KPluginInfo
		///  objects
		///       </remarks>		<short>    Load the state of the plugins (selected or not) from the KPluginInfo  objects       </short>
		public void Load() {
			interceptor.Invoke("load", "load()", typeof(void));
		}
		/// <remarks>
		///  Save the configuration
		///       </remarks>		<short>    Save the configuration       </short>
		public void Save() {
			interceptor.Invoke("save", "save()", typeof(void));
		}
		/// <remarks>
		///  Change to applications defaults
		///       </remarks>		<short>    Change to applications defaults       </short>
		public void Defaults() {
			interceptor.Invoke("defaults", "defaults()", typeof(void));
		}
		/// <remarks>
		///  Updates plugins state (enabled or not)
		///  This method won't save anything on any configuration file. It will just
		///  be useful if you added plugins with the method:
		///  <pre>
		///  void addPlugins(const QList<KPluginInfo> &pluginInfoList,
		///                  stringcategoryName = string(),
		///                  stringcategoryKey = string(),
		///                  const KSharedConfig.Ptr &config = KSharedConfig.Ptr());
		///  </pre>
		///  To sum up, this method will update your plugins state depending if plugins
		///  are ticked or not on the KPluginSelector dialog, without saving anything
		///  anywhere
		///       </remarks>		<short>    Updates plugins state (enabled or not) </short>
		public void UpdatePluginsState() {
			interceptor.Invoke("updatePluginsState", "updatePluginsState()", typeof(void));
		}
		~KPluginSelector() {
			interceptor.Invoke("~KPluginSelector", "~KPluginSelector()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPluginSelector", "~KPluginSelector()", typeof(void));
		}
		protected new IKPluginSelectorSignals Emit {
			get { return (IKPluginSelectorSignals) Q_EMIT; }
		}
	}

	public interface IKPluginSelectorSignals : IQWidgetSignals {
		/// <remarks>
		///  Tells you whether the configuration is changed or not.
		///       </remarks>		<short>    Tells you whether the configuration is changed or not.</short>
		[Q_SIGNAL("void changed(bool)")]
		void Changed(bool hasChanged);
		/// <remarks>
		///  Emitted after the config of an embedded KCM has been saved. The
		///  argument is the name of the parent component that needs to reload
		///  its config
		///       </remarks>		<short>    Emitted after the config of an embedded KCM has been saved.</short>
		[Q_SIGNAL("void configCommitted(const QByteArray&)")]
		void ConfigCommitted(QByteArray componentName);
	}
}
