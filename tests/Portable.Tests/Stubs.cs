namespace System.Windows { public class RoutedEventArgs : System.EventArgs {} public static class MessageBox { public static void Show(string s) {} } }
namespace System.Windows.Controls { public class ValidationErrorEventArgs : System.EventArgs {} }
namespace System.Windows.Documents { class Marker {} }
namespace System.Windows.Input { public class GestureEventArgs : System.EventArgs {} public class ManipulationStartedEventArgs : System.EventArgs {} public class ManipulationCompletedEventArgs : System.EventArgs {} }
namespace System.Windows.Media { class Marker {} }
namespace System.Windows.Media.Animation { class Marker {} }
namespace System.Windows.Shapes { class Marker {} }
namespace Microsoft.Phone.Controls { public class PhoneApplicationPage {} }
namespace Noooooo.Resources { class Marker {} }
namespace System.Device.Location { class Marker {} }
namespace System.Windows.Media.Imaging { public class BitmapImage { public BitmapImage(System.Uri u) {} } }
namespace Coding4Fun.Phone.Controls { public class AboutPrompt { public void Show(params object[] x) {} } public class AboutPersonItem { public string WebSiteUrl; } }
namespace System.Windows.Controls { public class MediaElement { public System.Uri Source; public double Volume; public System.TimeSpan Position; public int Plays; public void Play() {Plays++;} } }
namespace Noooooo { public partial class MainPage { public System.Windows.Controls.MediaElement no=new System.Windows.Controls.MediaElement(); public Image button2=new Image();void InitializeComponent(){} } public class Image { public object Source; } }
