using PBKDF2_Generator_WP.Resources;

namespace PBKDF2_Generator_WP
{
    /// <summary>
    /// Bietet Zugriff auf Zeichenfolgenressourcen.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}