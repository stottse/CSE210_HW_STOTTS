using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
    

        List<Video> vidList = new List<Video>(); 

        //The following sets up 3 different videos and adds them to a list

        Video video1 = new Video("How to write code", "Professor Blue", 12.5);
        Video video2 = new Video("How to test code", "Professor Black", 23.45);
        Video video3 = new Video("Why Coding is Awesome", "Professor White", 7.2);

        vidList.Add(video1);
        vidList.Add(video2);
        vidList.Add(video3);

        //The following is how comments are added to each video:

        vidList[0].store_Comments("User01", "Thanks for the help writing code");
        vidList[0].store_Comments("User02", "Glad I can learn code from your videos");
        vidList[0].store_Comments("User03", "Thanks for the video");

        vidList[1].store_Comments("User01", "Yay! Now I know how to test code!");
        vidList[1].store_Comments("User02", "Wow I didn't know testing code was so awesome!");
        vidList[1].store_Comments("User03", "Testing code is fun.");

        vidList[2].store_Comments("User01", "Coding is awesome!");
        vidList[2].store_Comments("User02", "Sweet video!");
        vidList[2].store_Comments("User03", "Fun Video!");

         foreach (var video in vidList)
        {
            video.Display_Info();
        }
    }
}