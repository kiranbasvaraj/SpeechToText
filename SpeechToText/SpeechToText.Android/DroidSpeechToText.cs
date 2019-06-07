
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using SpeechToText.Droid;
using Xamarin.Forms;
using Android.Speech;

[assembly: Dependency(typeof(DroidSpeechToText))]
namespace SpeechToText.Droid
{
    public class DroidSpeechToText : ConvertSpeechToText
    {




        public void Convert()
        {
            var contx = Forms.Context;
            contx.StartActivity(typeof(RecordActivity));
        }
    }
}