#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

#endregion

namespace Naro.Infrastructure.Interface.Views
{
    public class ImageBitmapCache
    {
        private readonly SortedDictionary<string, BitmapImage> _iconNameMapping =
            new SortedDictionary<string, BitmapImage>();

        public BitmapImage GetImageFromName(string iconName)
        {
            if (string.IsNullOrEmpty(iconName))
            {
                return null;
            }
            BitmapImage result;
            if (_iconNameMapping.TryGetValue(iconName, out result))
            {
                return result;
            }

            result = new BitmapImage(new Uri(iconName, UriKind.RelativeOrAbsolute));
            _iconNameMapping[iconName] = result;

            return result;
        }
    }
}