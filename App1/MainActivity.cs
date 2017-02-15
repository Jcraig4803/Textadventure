using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //charName = int;
            //chatNext transitions the chatbox
            //chatbox will be something automatically created
            
            // going to have the user talking to the "computer" and have the computer say something simple back.
            // maybe an typical introduction
            // have the user tell the computer their name, age, gender, and then the computer respond with 
            // all the information they gave along with a simple introduction of the "computer"
             

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

