public class Post
{
    private int grade = 0;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; private set; }

    public Post(string title, string descripton)
    {
        Title = title;
        Description = descripton;
        CreatedDate = DateTime.Now;
    }


    public void gradeUp()
    {
        grade++;
    }

    public void gradeDown()
    {
        grade--;
    }

    public int getGrade()
    {
        return grade;
    }
}
