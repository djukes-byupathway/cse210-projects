class Comment
{
    //properties
    private string _name;
    private string _commentText;

    //constructor
    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }
    
    //class methods
    public string getCommentDetail()
    {
        return $"{_name} - '{_commentText}'";
    }


}