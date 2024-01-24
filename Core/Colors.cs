using System.Collections.Generic;
using UnityEngine;

namespace NanoVer.Core
{
    /// <summary>
    /// Utility classes related to colors.
    /// </summary>
    public static class Colors
    {
        /// <summary>
        /// Get a color from its web color name.
        /// </summary>
        /// <remarks>
        /// These colors are sources from the CSS3 specification
        /// (https://www.w3.org/TR/css-color-3/),
        /// which in turn is based upon the X11 color palette.
        /// </remarks>
        public static Color? GetColorFromName(string name)
        {
            if (colorsByName.TryGetValue(name.ToLower(), out var color))
                return color;
            return null;
        }

        private static readonly Dictionary<string, Color> colorsByName =
            new Dictionary<string, Color>()
            {
                ["pink"] = Pink,
                ["lightpink"] = LightPink,
                ["hotpink"] = HotPink,
                ["deeppink"] = DeepPink,
                ["palevioletred"] = PaleVioletRed,
                ["mediumvioletred"] = MediumVioletRed,
                ["lightsalmon"] = LightSalmon,
                ["salmon"] = Salmon,
                ["darksalmon"] = DarkSalmon,
                ["lightcoral"] = LightCoral,
                ["indianred"] = IndianRed,
                ["crimson"] = Crimson,
                ["firebrick"] = Firebrick,
                ["darkred"] = DarkRed,
                ["red"] = Red,
                ["orangered"] = OrangeRed,
                ["tomato"] = Tomato,
                ["coral"] = Coral,
                ["darkorange"] = DarkOrange,
                ["orange"] = Orange,
                ["yellow"] = Yellow,
                ["lightyellow"] = LightYellow,
                ["lemonchiffon"] = LemonChiffon,
                ["lightgoldenrodyellow "] = LightGoldenrodYellow,
                ["papayawhip"] = PapayaWhip,
                ["moccasin"] = Moccasin,
                ["peachpuff"] = PeachPuff,
                ["palegoldenrod"] = PaleGoldenrod,
                ["khaki"] = Khaki,
                ["darkkhaki"] = DarkKhaki,
                ["gold"] = Gold,
                ["cornsilk"] = Cornsilk,
                ["blanchedalmond"] = BlanchedAlmond,
                ["bisque"] = Bisque,
                ["navajowhite"] = NavajoWhite,
                ["wheat"] = Wheat,
                ["burlywood"] = Burlywood,
                ["tan"] = Tan,
                ["rosybrown"] = RosyBrown,
                ["sandybrown"] = SandyBrown,
                ["goldenrod"] = Goldenrod,
                ["darkgoldenrod"] = DarkGoldenrod,
                ["peru"] = Peru,
                ["chocolate"] = Chocolate,
                ["saddlebrown"] = SaddleBrown,
                ["sienna"] = Sienna,
                ["brown"] = Brown,
                ["maroon"] = Maroon,
                ["darkolivegreen"] = DarkOliveGreen,
                ["olive"] = Olive,
                ["olivedrab"] = OliveDrab,
                ["yellowgreen"] = YellowGreen,
                ["limegreen"] = LimeGreen,
                ["lime"] = Lime,
                ["lawngreen"] = LawnGreen,
                ["chartreuse"] = Chartreuse,
                ["greenyellow"] = GreenYellow,
                ["springgreen"] = SpringGreen,
                ["mediumspringgreen "] = MediumSpringGreen,
                ["lightgreen"] = LightGreen,
                ["palegreen"] = PaleGreen,
                ["darkseagreen"] = DarkSeaGreen,
                ["mediumaquamarine"] = MediumAquamarine,
                ["mediumseagreen"] = MediumSeaGreen,
                ["seagreen"] = SeaGreen,
                ["forestgreen"] = ForestGreen,
                ["green"] = Green,
                ["darkgreen"] = DarkGreen,
                ["aqua"] = Aqua,
                ["cyan"] = Cyan,
                ["lightcyan"] = LightCyan,
                ["paleturquoise"] = PaleTurquoise,
                ["aquamarine"] = Aquamarine,
                ["turquoise"] = Turquoise,
                ["mediumturquoise"] = MediumTurquoise,
                ["darkturquoise"] = DarkTurquoise,
                ["lightseagreen"] = LightSeaGreen,
                ["cadetblue"] = CadetBlue,
                ["darkcyan"] = DarkCyan,
                ["teal"] = Teal,
                ["lightsteelblue"] = LightSteelBlue,
                ["powderblue"] = PowderBlue,
                ["lightblue"] = LightBlue,
                ["skyblue"] = SkyBlue,
                ["lightskyblue"] = LightSkyBlue,
                ["deepskyblue"] = DeepSkyBlue,
                ["dodgerblue"] = DodgerBlue,
                ["cornflowerblue"] = CornflowerBlue,
                ["steelblue"] = SteelBlue,
                ["royalblue"] = RoyalBlue,
                ["blue"] = Blue,
                ["mediumblue"] = MediumBlue,
                ["darkblue"] = DarkBlue,
                ["navy"] = Navy,
                ["midnightblue"] = MidnightBlue,
                ["lavender"] = Lavender,
                ["thistle"] = Thistle,
                ["plum"] = Plum,
                ["violet"] = Violet,
                ["orchid"] = Orchid,
                ["fuchsia"] = Fuchsia,
                ["magenta"] = Magenta,
                ["mediumorchid"] = MediumOrchid,
                ["mediumpurple"] = MediumPurple,
                ["blueviolet"] = BlueViolet,
                ["darkviolet"] = DarkViolet,
                ["darkorchid"] = DarkOrchid,
                ["darkmagenta"] = DarkMagenta,
                ["purple"] = Purple,
                ["indigo"] = Indigo,
                ["darkslateblue"] = DarkSlateBlue,
                ["slateblue"] = SlateBlue,
                ["mediumslateblue "] = MediumSlateBlue,
                ["white"] = White,
                ["snow"] = Snow,
                ["honeydew"] = Honeydew,
                ["mintcream"] = MintCream,
                ["azure"] = Azure,
                ["aliceblue"] = AliceBlue,
                ["ghostwhite"] = GhostWhite,
                ["whitesmoke"] = WhiteSmoke,
                ["seashell"] = Seashell,
                ["beige"] = Beige,
                ["oldlace"] = OldLace,
                ["floralwhite"] = FloralWhite,
                ["ivory"] = Ivory,
                ["antiquewhite"] = AntiqueWhite,
                ["linen"] = Linen,
                ["lavenderblush"] = LavenderBlush,
                ["mistyrose"] = MistyRose,
                ["gainsboro"] = Gainsboro,
                ["lightgray"] = LightGray,
                ["lightgrey"] = LightGrey,
                ["silver"] = Silver,
                ["darkgray"] = DarkGray,
                ["darkgrey"] = DarkGrey,
                ["gray"] = Gray,
                ["grey"] = Grey,
                ["dimgray"] = DimGray,
                ["dimgrey"] = DimGrey,
                ["lightslategray"] = LightSlateGray,
                ["lightslategrey"] = LightSlateGrey,
                ["slategray"] = SlateGray,
                ["slategrey"] = SlateGrey,
                ["darkslategray"] = DarkSlateGray,
                ["darkslategrey"] = DarkSlateGrey,
                ["black"] = Black,
            };

        public static Color Pink => new Color(1f, 0.753f, 0.796f);
        public static Color LightPink => new Color(1f, 0.714f, 0.757f);
        public static Color HotPink => new Color(1f, 0.412f, 0.706f);
        public static Color DeepPink => new Color(1f, 0.078f, 0.576f);
        public static Color PaleVioletRed => new Color(0.859f, 0.439f, 0.576f);
        public static Color MediumVioletRed => new Color(0.78f, 0.082f, 0.522f);
        public static Color LightSalmon => new Color(1f, 0.627f, 0.478f);
        public static Color Salmon => new Color(0.98f, 0.502f, 0.447f);
        public static Color DarkSalmon => new Color(0.914f, 0.588f, 0.478f);
        public static Color LightCoral => new Color(0.941f, 0.502f, 0.502f);
        public static Color IndianRed => new Color(0.804f, 0.361f, 0.361f);
        public static Color Crimson => new Color(0.863f, 0.078f, 0.235f);
        public static Color Firebrick => new Color(0.698f, 0.133f, 0.133f);
        public static Color DarkRed => new Color(0.545f, 0f, 0f);
        public static Color Red => new Color(1f, 0f, 0f);
        public static Color OrangeRed => new Color(1f, 0.271f, 0f);
        public static Color Tomato => new Color(1f, 0.388f, 0.278f);
        public static Color Coral => new Color(1f, 0.498f, 0.314f);
        public static Color DarkOrange => new Color(1f, 0.549f, 0f);
        public static Color Orange => new Color(1f, 0.647f, 0f);
        public static Color Yellow => new Color(1f, 1f, 0f);
        public static Color LightYellow => new Color(1f, 1f, 0.878f);
        public static Color LemonChiffon => new Color(1f, 0.98f, 0.804f);
        public static Color LightGoldenrodYellow => new Color(0.98f, 0.98f, 0.824f);
        public static Color PapayaWhip => new Color(1f, 0.937f, 0.835f);
        public static Color Moccasin => new Color(1f, 0.894f, 0.71f);
        public static Color PeachPuff => new Color(1f, 0.855f, 0.725f);
        public static Color PaleGoldenrod => new Color(0.933f, 0.91f, 0.667f);
        public static Color Khaki => new Color(0.941f, 0.902f, 0.549f);
        public static Color DarkKhaki => new Color(0.741f, 0.718f, 0.42f);
        public static Color Gold => new Color(1f, 0.843f, 0f);
        public static Color Cornsilk => new Color(1f, 0.973f, 0.863f);
        public static Color BlanchedAlmond => new Color(1f, 0.922f, 0.804f);
        public static Color Bisque => new Color(1f, 0.894f, 0.769f);
        public static Color NavajoWhite => new Color(1f, 0.871f, 0.678f);
        public static Color Wheat => new Color(0.961f, 0.871f, 0.702f);
        public static Color Burlywood => new Color(0.871f, 0.722f, 0.529f);
        public static Color Tan => new Color(0.824f, 0.706f, 0.549f);
        public static Color RosyBrown => new Color(0.737f, 0.561f, 0.561f);
        public static Color SandyBrown => new Color(0.957f, 0.643f, 0.376f);
        public static Color Goldenrod => new Color(0.855f, 0.647f, 0.125f);
        public static Color DarkGoldenrod => new Color(0.722f, 0.525f, 0.043f);
        public static Color Peru => new Color(0.804f, 0.522f, 0.247f);
        public static Color Chocolate => new Color(0.824f, 0.412f, 0.118f);
        public static Color SaddleBrown => new Color(0.545f, 0.271f, 0.075f);
        public static Color Sienna => new Color(0.627f, 0.322f, 0.176f);
        public static Color Brown => new Color(0.647f, 0.165f, 0.165f);
        public static Color Maroon => new Color(0.502f, 0f, 0f);
        public static Color DarkOliveGreen => new Color(0.333f, 0.42f, 0.184f);
        public static Color Olive => new Color(0.502f, 0.502f, 0f);
        public static Color OliveDrab => new Color(0.42f, 0.557f, 0.137f);
        public static Color YellowGreen => new Color(0.604f, 0.804f, 0.196f);
        public static Color LimeGreen => new Color(0.196f, 0.804f, 0.196f);
        public static Color Lime => new Color(0f, 1f, 0f);
        public static Color LawnGreen => new Color(0.486f, 0.988f, 0f);
        public static Color Chartreuse => new Color(0.498f, 1f, 0f);
        public static Color GreenYellow => new Color(0.678f, 1f, 0.184f);
        public static Color SpringGreen => new Color(0f, 1f, 0.498f);
        public static Color MediumSpringGreen => new Color(0f, 0.98f, 0.604f);
        public static Color LightGreen => new Color(0.565f, 0.933f, 0.565f);
        public static Color PaleGreen => new Color(0.596f, 0.984f, 0.596f);
        public static Color DarkSeaGreen => new Color(0.561f, 0.737f, 0.561f);
        public static Color MediumAquamarine => new Color(0.4f, 0.804f, 0.667f);
        public static Color MediumSeaGreen => new Color(0.235f, 0.702f, 0.443f);
        public static Color SeaGreen => new Color(0.18f, 0.545f, 0.341f);
        public static Color ForestGreen => new Color(0.133f, 0.545f, 0.133f);
        public static Color Green => new Color(0f, 0.502f, 0f);
        public static Color DarkGreen => new Color(0f, 0.392f, 0f);
        public static Color Aqua => new Color(0f, 1f, 1f);
        public static Color Cyan => new Color(0f, 1f, 1f);
        public static Color LightCyan => new Color(0.878f, 1f, 1f);
        public static Color PaleTurquoise => new Color(0.686f, 0.933f, 0.933f);
        public static Color Aquamarine => new Color(0.498f, 1f, 0.831f);
        public static Color Turquoise => new Color(0.251f, 0.878f, 0.816f);
        public static Color MediumTurquoise => new Color(0.282f, 0.82f, 0.8f);
        public static Color DarkTurquoise => new Color(0f, 0.808f, 0.82f);
        public static Color LightSeaGreen => new Color(0.125f, 0.698f, 0.667f);
        public static Color CadetBlue => new Color(0.373f, 0.62f, 0.627f);
        public static Color DarkCyan => new Color(0f, 0.545f, 0.545f);
        public static Color Teal => new Color(0f, 0.502f, 0.502f);
        public static Color LightSteelBlue => new Color(0.69f, 0.769f, 0.871f);
        public static Color PowderBlue => new Color(0.69f, 0.878f, 0.902f);
        public static Color LightBlue => new Color(0.678f, 0.847f, 0.902f);
        public static Color SkyBlue => new Color(0.529f, 0.808f, 0.922f);
        public static Color LightSkyBlue => new Color(0.529f, 0.808f, 0.98f);
        public static Color DeepSkyBlue => new Color(0f, 0.749f, 1f);
        public static Color DodgerBlue => new Color(0.118f, 0.565f, 1f);
        public static Color CornflowerBlue => new Color(0.392f, 0.584f, 0.929f);
        public static Color SteelBlue => new Color(0.275f, 0.51f, 0.706f);
        public static Color RoyalBlue => new Color(0.255f, 0.412f, 0.882f);
        public static Color Blue => new Color(0f, 0f, 1f);
        public static Color MediumBlue => new Color(0f, 0f, 0.804f);
        public static Color DarkBlue => new Color(0f, 0f, 0.545f);
        public static Color Navy => new Color(0f, 0f, 0.502f);
        public static Color MidnightBlue => new Color(0.098f, 0.098f, 0.439f);
        public static Color Lavender => new Color(0.902f, 0.902f, 0.98f);
        public static Color Thistle => new Color(0.847f, 0.749f, 0.847f);
        public static Color Plum => new Color(0.867f, 0.627f, 0.867f);
        public static Color Violet => new Color(0.933f, 0.51f, 0.933f);
        public static Color Orchid => new Color(0.855f, 0.439f, 0.839f);
        public static Color Fuchsia => new Color(1f, 0f, 1f);
        public static Color Magenta => new Color(1f, 0f, 1f);
        public static Color MediumOrchid => new Color(0.729f, 0.333f, 0.827f);
        public static Color MediumPurple => new Color(0.576f, 0.439f, 0.859f);
        public static Color BlueViolet => new Color(0.541f, 0.169f, 0.886f);
        public static Color DarkViolet => new Color(0.58f, 0f, 0.827f);
        public static Color DarkOrchid => new Color(0.6f, 0.196f, 0.8f);
        public static Color DarkMagenta => new Color(0.545f, 0f, 0.545f);
        public static Color Purple => new Color(0.502f, 0f, 0.502f);
        public static Color Indigo => new Color(0.294f, 0f, 0.51f);
        public static Color DarkSlateBlue => new Color(0.282f, 0.239f, 0.545f);
        public static Color SlateBlue => new Color(0.416f, 0.353f, 0.804f);
        public static Color MediumSlateBlue => new Color(0.482f, 0.408f, 0.933f);
        public static Color White => new Color(1f, 1f, 1f);
        public static Color Snow => new Color(1f, 0.98f, 0.98f);
        public static Color Honeydew => new Color(0.941f, 1f, 0.941f);
        public static Color MintCream => new Color(0.961f, 1f, 0.98f);
        public static Color Azure => new Color(0.941f, 1f, 1f);
        public static Color AliceBlue => new Color(0.941f, 0.973f, 1f);
        public static Color GhostWhite => new Color(0.973f, 0.973f, 1f);
        public static Color WhiteSmoke => new Color(0.961f, 0.961f, 0.961f);
        public static Color Seashell => new Color(1f, 0.961f, 0.933f);
        public static Color Beige => new Color(0.961f, 0.961f, 0.863f);
        public static Color OldLace => new Color(0.992f, 0.961f, 0.902f);
        public static Color FloralWhite => new Color(1f, 0.98f, 0.941f);
        public static Color Ivory => new Color(1f, 1f, 0.941f);
        public static Color AntiqueWhite => new Color(0.98f, 0.922f, 0.843f);
        public static Color Linen => new Color(0.98f, 0.941f, 0.902f);
        public static Color LavenderBlush => new Color(1f, 0.941f, 0.961f);
        public static Color MistyRose => new Color(1f, 0.894f, 0.882f);
        public static Color Gainsboro => new Color(0.863f, 0.863f, 0.863f);
        public static Color LightGray => new Color(0.827f, 0.827f, 0.827f);
        public static Color LightGrey => new Color(0.827f, 0.827f, 0.827f);
        public static Color Silver => new Color(0.753f, 0.753f, 0.753f);
        public static Color DarkGray => new Color(0.663f, 0.663f, 0.663f);
        public static Color DarkGrey => new Color(0.663f, 0.663f, 0.663f);
        public static Color Gray => new Color(0.502f, 0.502f, 0.502f);
        public static Color Grey => new Color(0.502f, 0.502f, 0.502f);
        public static Color DimGray => new Color(0.412f, 0.412f, 0.412f);
        public static Color DimGrey => new Color(0.412f, 0.412f, 0.412f);
        public static Color LightSlateGray => new Color(0.467f, 0.533f, 0.6f);
        public static Color LightSlateGrey => new Color(0.467f, 0.533f, 0.6f);
        public static Color SlateGray => new Color(0.439f, 0.502f, 0.565f);
        public static Color SlateGrey => new Color(0.439f, 0.502f, 0.565f);
        public static Color DarkSlateGray => new Color(0.184f, 0.31f, 0.31f);
        public static Color DarkSlateGrey => new Color(0.184f, 0.31f, 0.31f);
        public static Color Black => new Color(0f, 0f, 0f);
    }
}