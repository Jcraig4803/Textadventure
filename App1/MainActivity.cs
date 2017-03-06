using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;
using App1;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public List<string> Storyline;
        // computer telling story
        public Button chatNext;
        // name of character
        public Button enter;
        // when user inputs text click button to submit the said text
        public TextView userName;
        // pulling the users name from the edittext which will then be confirmed by the enter button
        public TextView charName;
        // the name of the computer on start and then changed to the users character name
        public TextView chatBox;
        // this is the shat box where all the chat is resolved
        public TextView Inventory;
        // inventory of the user
        public EditText userInput;
        // what the user inputs to tell the computer what the user wants to do
        public int counter { get; set; }

        //------------------------------------------------------------------------------------------------------------------
        // charName = string;
        // chatNext transitions the chatbox
        // chatbox will be something automatically created
        // going to have the user talking to the "computer" and have the computer say something simple back.
        // maybe a typical introduction
        // have the user tell the computer their name, age, gender, and then the computer respond with 
        // all the information they gave along with a simple introduction of the "computer"
        // Set our view from the "main" layout resource
        //------------------------------------------------------------------------------------------------------------------
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            this.loadStoryBoard();
            this.counter = 0;

            var enter = FindViewById<Button>(Resource.Id.enter);
            enter.Click += Enter_Click;

            var chatNext = FindViewById<Button>(Resource.Id.chatNext);
            chatNext.Click += chatNext_Click;

            var chatbox = FindViewById<TextView>(Resource.Id.chatbox);
            chatbox.Text = Storyline[counter];

        }
        private void chatNext_Click(object sender, EventArgs e)
        {
            var chatbox = FindViewById<TextView>(Resource.Id.chatbox);
            chatbox.Text = "";
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            // Get the user's text
            var userInput = FindViewById<TextView>(Resource.Id.userInput);
            string userText = userInput.Text;
            userInput.Text = "";
            // have the userInput go to the chatBox
            var chatbox = FindViewById<TextView>(Resource.Id.chatbox);
            chatbox.Text += "\n" + userText + "\n";

            counter++;
            chatbox.Text = this.Storyline[counter];

        }        

        // this is what the computer will say to the user(s) upon start
        public void loadStoryBoard() {
            List<string> Story = new List<string>();
            Story.Add("Welcome New Comer!");
            Story.Add("My name is CEJ,");
            Story.Add("I have no Age");
            Story.Add("I have no Gender");
            Story.Add("May i please be informed of your Name?");
            Story.Add("May i please be informed of your Age?");
            Story.Add("May i please be informed of your Gender?");
            this.Storyline = Story;
        }



        }
    }