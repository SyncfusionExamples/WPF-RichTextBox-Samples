using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DocumentEditor
{
    sealed class SR
    {
        #region Fields
        private ResourceManager resources;
        private static SR loader = null;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Syncfusion.Windows.Controls.RichTextBoxAdv.SR">SR</see> class. 
        /// </summary>
        /// <remarks></remarks>
        private SR()
        {
            //http://msdn.microsoft.com/en-us/library/windows/apps/xaml/Hh965329%28v=win.10%29.aspx
            ResourceManager localizedManager = GetLocalizedResourceManager(this.GetType().Assembly);
            if (localizedManager == null)
                this.resources = DocumentEditor.Resources.DocumentEditor.ResourceManager;
            else
                this.resources = localizedManager;
        }
        #endregion

        #region Implementation
        private static SR GetLoader()
        {
            lock (typeof(SR))
            {
                if (SR.loader == null)
                    SR.loader = new SR();
                return SR.loader;
            }
        }
        private static ResourceManager GetLocalizedResourceManager(Assembly controlAssembly)
        {
            Assembly assembly;
            if (Application.Current == null)
                assembly = Application.ResourceAssembly;
            else
                assembly = Application.Current.GetType().Assembly;
            try
            {
                ResourceManager manager = null;
                bool found = false;
                var sampleresourcename = string.Format("{0}.Resources.{1}.resources", assembly.FullName.Split(new char[] { ',' })[0], controlAssembly.FullName.Split(new char[] { ',' })[0]);
                foreach (var resourceName in assembly.GetManifestResourceNames())
                {
                    if (resourceName.Equals(sampleresourcename))
                    {
                        if (resourceName.Equals(string.Format("{0}.Resources.{1}.resources", assembly.FullName.Split(new char[] { ',' })[0], controlAssembly.FullName.Split(new char[] { ',' })[0])))
                        {
                            found = true;
                            break;
                        }
                    }
                }
                if (found || !CultureInfo.CurrentUICulture.Name.Equals("en-US"))
                {
                    var resourcemanagerName = string.Format("{0}.Resources.{1}", assembly.FullName.Split(new char[] { ',' })[0], controlAssembly.FullName.Split(new char[] { ',' })[0]);
                    manager = new System.Resources.ResourceManager(resourcemanagerName, assembly);
                }
                else
                {
                    var resourcemanagerName = string.Format("DocumentEditor.Resources.{0}", controlAssembly.FullName.Split(new char[] { ',' })[0]);
                    manager = new System.Resources.ResourceManager(resourcemanagerName, controlAssembly);
                }
                if (manager != null)
                {
                    var currentUICulture = CultureInfo.CurrentUICulture;
                    if (manager.GetResourceSet(currentUICulture, true, true) != null)
                        return manager;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
        public static void ReleaseResources()
        {
            SR.loader.resources.ReleaseAllResources();
        }
        public static string GetString(CultureInfo culture, string name, params object[] args)
        {
            SR sr = SR.GetLoader();
            if (sr == null)
                return null;
            try
            {
                string value = sr.resources.GetString(name, culture);
                if (value != null && args != null && args.Length > 0)
                    return String.Format(value, args);
                return value;
            }
            catch
            {
                return name;
            }
        }
        public static string GetString(string name)
        {
            return SR.GetString(null, name);
        }
        public static string GetString(string name, params object[] args)
        {
            return SR.GetString(null, name, args);
        }
        public static string GetString(CultureInfo culture, string name)
        {
            SR sr = SR.GetLoader();
            if (sr == null)
                return null;
            string value = "";
            try
            {
                value = sr.resources.GetString(name, culture);
            }
            catch
            {
                value = DocumentEditor.Resources.DocumentEditor.ResourceManager.GetString(name);
            }
            return value;
        }
        public static object GetObject(CultureInfo culture, string name)
        {
            SR sr = SR.GetLoader();
            if (sr == null)
                return null;
            return sr.resources.GetObject(name, culture);
        }
        public static object GetObject(string name)
        {
            return SR.GetObject(null, name);
        }
        public static bool GetBoolean(CultureInfo culture, string name)
        {
            bool value;
            SR sr = SR.GetLoader();
            object obj;
            value = false;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Boolean)
                    value = ((bool)obj);
            }
            return value;
        }
        public static bool GetBoolean(string name)
        {
            return SR.GetBoolean(name);
        }
        public static byte GetByte(CultureInfo culture, string name)
        {
            byte value;
            SR sr = SR.GetLoader();
            object obj;
            value = (byte)0;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Byte)
                    value = ((byte)obj);
            }
            return value;
        }
        public static byte GetByte(string name)
        {
            return SR.GetByte(null, name);
        }
        public static char GetChar(CultureInfo culture, string name)
        {
            char value;
            SR sr = SR.GetLoader();
            object obj;
            value = (char)0;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Char)
                    value = (char)obj;
            }
            return value;
        }
        public static char GetChar(string name)
        {
            return SR.GetChar(null, name);
        }
        public static double GetDouble(CultureInfo culture, string name)
        {
            double value;
            SR sr = SR.GetLoader();
            object obj;
            value = 0.0;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Double)
                    value = ((double)obj);
            }
            return value;
        }
        public static double GetDouble(string name)
        {
            return SR.GetDouble(null, name);
        }
        public static float GetFloat(CultureInfo culture, string name)
        {
            float value;
            SR sr = SR.GetLoader();
            object obj;
            value = 0.0f;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Single)
                    value = ((float)obj);
            }
            return value;
        }
        public static float GetFloat(string name)
        {
            return SR.GetFloat(null, name);
        }
        public static int GetInt(string name)
        {
            return SR.GetInt(null, name);
        }
        public static int GetInt(CultureInfo culture, string name)
        {
            int value;
            SR sr = SR.GetLoader();
            object obj;
            value = 0;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Int32)
                    value = ((int)obj);
            }
            return value;
        }
        public static long GetLong(string name)
        {
            return SR.GetLong(null, name);
        }
        public static long GetLong(CultureInfo culture, string name)
        {
            Int64 value;
            SR sr = SR.GetLoader();
            object obj;
            value = ((Int64)0);
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Int64)
                    value = ((Int64)obj);
            }
            return value;
        }
        public static short GetShort(CultureInfo culture, string name)
        {
            short value;
            SR sr = SR.GetLoader();
            object obj;
            value = (short)0;
            if (sr != null)
            {
                obj = sr.resources.GetObject(name, culture);
                if (obj is System.Int16)
                    value = ((short)obj);
            }
            return value;
        }
        public static short GetShort(string name)
        {
            return SR.GetShort(null, name);
        }
        #endregion
    }
}
