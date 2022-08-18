using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUdemy2
{
    /*
     * So this is something that allow us to output diagnostic information
     * about all the objects that have being constructed by this factory
     * 
     */
    public class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> themes = new List<WeakReference<ITheme>>();
        private ITheme theme;

        public ITheme CreateTheme(bool dark)
        {
            if (dark)
            {
                theme = new DarkTheme();
            }
            else
            {
                theme = new LightTheme();
            }
            // Object Tracking
            themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var reference in themes)
                {
                    if (reference.TryGetTarget(out var theme))
                    {
                        bool dark = theme is DarkTheme;
                        sb.Append(dark ? "Dark" : "Light").AppendLine("theme");
                    }
                }
                return sb.ToString();
            }
        }
    }


    /*
     * This class is completely useless is just a wrapper
     * it does not do anything , give us the ability to track the objects which we are
     * just constructed but is able to perform bulk replacement 
     */
    public class Ref<T> where T : class
    {
        public T Value { get; set; }

        public Ref(T value)
        {
            Value = value;
        }
    }
}
