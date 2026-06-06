using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
// The list of videos
    static List<Video> _videos = [];
//This array is for the initial data population of video titles
    static string[] _videoTitles = { "Jam Boogie", "Redneckin'", "Who Am I?", "The Name is ..." };
//this array is for populating the authors, the index matches the titles
    static string[] _authors = ["Joe Blow", "Joe Dirt", "Jane Doe", "James Bond"];
    //this array is for populating the lengths, the index matches the titles
    static int[] _lengths = [60, 75, 85, 3600];
    //sort of a cheat here, but forcing 4 comments per title, ie. 0-3 is for title index 0 and so on
    //if I had more time I might make this a multi-dimensional array with title index and each one of those having an array of comment authors
    static string[] _commentAuthors = [
        "Jamal Owens",
        "Jerry Curl",
        "Afro Dee Zee Ack",
        "Boogie Night 3000",

        "Jeremiah Jones",
        "Sally Mae",
        "Wanda Winters",
        "Joane D'Arc",

        "John Young-Deere",
        "Jaime Alexander",
        "Thiren",
        "Beth Colon",

        "Auric Goldfinger",
        "Ernst Blofeld",
        "Alec Trvelyan",
        "Dr. Julius No",

    ];
//just like with the comment authors, index matches comment author
    static string[] _commentTexts = [
        "This Jam is on Fyre!!!",
        "Boogie this",
        "What in all of Creation did I just watch?!?",
        "Time to go to church brother, can I get an Amen!",

        "RED NECKS RULE!!!",
        "Oh Bro. Where art thou? could use some good Red Necks around here",
        "Give me a red neck every day of the week",
        "Ugh, married a red neck once, divorced and couldn't be happier. Thanks for the reminder why.",

        "I totally felt this movie.",
        "Haunting and sticks with you long after you watch it.",
        "A good time, keeps you guessing",
        "um.....",

        "whatever...who cares.",
        "This is awful. Could totally do without this experience.",
        "Pfft, I found this dude so pompous and insufferable that I just want to snuff him out.",
        "Terrible work, bad premise, over acted, ugh, waste of time.",
    ];

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        //start with collection
        _videos = getVideoCollection();

foreach (Video video in _videos)
        {
            video.displayVideo();
        }



    }

private static List<Video> getVideoCollection()
    {
        List<Video> videos = [];

        foreach (var (video, index) in _videoTitles.Select((value, i) => (value, i)))
        {
            Video myVideo = getVideo(index);
            videos.Add(myVideo);
        }
        return videos;
    }
    private static Video getVideo(int x)
    {
        string myTitle = _videoTitles[x];
        string myAuthor = _authors[x];
        int myLength = _lengths[x];

        List<Comment> myComments = [];
        int commentCounter = x * 4;
        int endCommentIndex = commentCounter + 4;
        do
        {
            Comment myComment = new Comment(_commentAuthors[commentCounter], _commentTexts[commentCounter]);
            myComments.Add(myComment);
            commentCounter++;
        } while (commentCounter < endCommentIndex);

        return new Video(myTitle, myAuthor, myLength, myComments);

    }



}