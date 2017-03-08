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
        public Button enter;
        // when user inputs text click button to submit the said text
        public EditText userInput;
        // what the user inputs to tell the computer what the user wants to do
        public TextView userName;
        // pulling the users name from the userInput after the stroyline asks for name
        public TextView userAge;
        // pulling the users age from the userInput after the stroyline asks for age 
        public TextView userGender;
        // pulling the users gender from the userInput after the stroyline asks for gender
        public TextView robotName;
        // the name of the robot
        public TextView chatBox;
        // this is the shat box where all the chat is resolved
        public TextView Inventory;
        // inventory of the user
       
        public int counter { get; set; }

        //------------------------------------------------------------------------------------------------------------------
        // chatbox will be something automatically created
        // going to have the user talking to the "computer" and have the computer say something simple back.
        // maybe a typical introduction
        // have the user tell the computer their name, age, gender, and then the computer respond with 
        //------------------------------------------------------------------------------------------------------------------
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            this.loadStoryBoard();
            this.counter = 0;

            var enter = FindViewById<Button>(Resource.Id.enter);
            enter.Click += Enter_Click;

            var chatbox = FindViewById<TextView>(Resource.Id.chatbox);
            chatbox.Text = Storyline[counter];

        }
        private void Enter_Click(object sender, EventArgs e)
        {
            // Get the user's text
            var userInput = FindViewById<TextView>(Resource.Id.userInput);
            string userText = userInput.Text;
            userInput.Text = "";
            // have the userInput go to the chatBox
            var chatbox = FindViewById<TextView>(Resource.Id.chatbox);
            chatbox.Text +="\n" + userText + "\n";

            counter++;
            chatbox.Text = this.Storyline[counter];

        }        

        // this is what the computer will say to the user(s) upon start
        public void loadStoryBoard() {
            List<string> Story = new List<string>();
            Story.Add("Press Enter to play a Text adventure game");

            Story.Add("The Year is 5001." + "\n" + 
            "A time where humans no longer excist." + "\n" +
            "Androids are the \"New humans\" that do not need any type of subsistence to survive. " + 
            "but the thing is that since Human life is no more the \"New Humans\" do not know how to live." +
            "The rumor has it that the last Human is in a frozen pod that has kept him preserved and, " +
            "That the OverLords have kept that knowledge from ever being know." +
            "but something has happened..."
            + "\n" + "\n" +
            "Press Enter To Contiune");
            // start of the app running
            Story.Add("You wake up from your sleeping chamber. "
            + "\n" +
            "You notice this flying... or hovering robot..." 
            + "\n" +
            "it starts to scans you..." 
            + "\n" + "\n" +
            "Press Enter To Contiune");

            Story.Add("The robot says \"PLEASE do not be alarmed\" it contiunes to scan you" 
            + "\n" +
            "The robot says \"Greetings human you are in need of rescue\" as it finishes scanning you" 
            + "\n" +
            "My name is CEJ," + "\n" + "I need to ask you a few question" 
            + "\n" + "\n" +
            "Press Enter To Contiune");

            Story.Add("i do not know you name?");
            // when the userInputs a value, take the value push it to userName
            Story.Add("Nice to meet" + userName);

            Story.Add("i can not tell how old you are?");
            // when the userInputs a value, take the value push it to userAge
            Story.Add("So you are " + userAge + " years of age");

            Story.Add("I can not tell are you Male or Female?");
            // when the userInputs a value, take the value push it to userGender
            Story.Add("So you are " + userGender + "correct");

            Story.Add("");
            Story.Add("");
            Story.Add("");
            Storyline = Story;
        }
        }
    }