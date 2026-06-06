class VideoCollection
{
    // properties
    private string _collectionName;
    private List<Comment> _videos;

    //constructors
    public VideoCollection(string name)
    {
        _collectionName = name;
    }

    public VideoCollection(string name, List<Video> videos)
    {
        _collectionName = name;
    }
}