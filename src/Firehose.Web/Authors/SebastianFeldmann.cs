public class seebus : IAmACommunityMember
{
    public string FirstName => "Sebastian";
    public string LastName => "Feldmann";
    public string ShortBioOrTagLine => "sysadmin";
    public string StateOrRegion => "Bremen, Germany";
    public string EmailAddress => "sebastian@feldmann.io";
    public string TwitterHandle => "sebfieldman";

    public Uri WebSite => new Uri("http://blog.feldmann.io/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://blog.feldmann.io/feed/"); } }
}
