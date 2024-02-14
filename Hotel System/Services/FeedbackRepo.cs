namespace Hotel_System.Services;
public class FeedbackRepo
{
    private readonly HotelDbContext _dbContext = new();

    public FeedBack Add(int clientId, string feedbackText, 
        int rating, int foodQuality)
    {
        var client = _dbContext.Clients.Find(clientId);
        if (client == null)
            throw Exceptions.NotFoundException("Client");

        FeedBack feedback = new()
        {
            ClientId = clientId,
            Description = feedbackText,
            Rate = rating,
            FoodQuality = foodQuality
        };

        _dbContext.FeedBacks.Add(feedback);
        _dbContext.SaveChanges();
        return feedback;
    }
    public void Remove(int feedbackId)
    {
        var feedback = _dbContext.FeedBacks.Find(feedbackId);
        if (feedback == null)
            throw Exceptions.NotFoundException("Feed Back");

        _dbContext.FeedBacks.Remove(feedback);
        _dbContext.SaveChanges();
    }
    public FeedBack Edit(int feedbackId, string newFeedbackText,
        int newRating, int foodQuality)
    {
        var feedback = _dbContext.FeedBacks.Find(feedbackId);
        if (feedback == null)
            throw Exceptions.NotFoundException("Feed Back");

        feedback.Description = newFeedbackText;
        feedback.Rate = newRating;
        feedback.FoodQuality = foodQuality;
        feedback.Date = DateTime.Now;

        _dbContext.SaveChanges();
        return feedback;
    }

    public List<FeedBack> GetFeedbackList() => _dbContext.FeedBacks.ToList();


}
