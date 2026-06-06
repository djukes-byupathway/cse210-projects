using System;

class Video
{
    // properties
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //constructor
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;

    }

    public int getNumberOfComments()
    {
        return _comments.Count;
    }


    public void displayVideo()
    {
        //display the title, author, length, number of comments (from the method)
        Console.WriteLine($"Video: {_title}, author: {_author}  Length(sec):{_length} Number of Comments: {getNumberOfComments()}");
        //then list out all of the comments for that video
        displayComments();
    }

    private void displayComments()
    {
        //then list out all of the comments for that video
        foreach (var(comment, index) in _comments.Select((value, i) => (value, i)))
        {
            string myString = comment.getCommentDetail();
            Console.WriteLine($"      {index+1}.  {myString}");
        }
    }

}