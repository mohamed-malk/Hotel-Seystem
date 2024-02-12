using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System.Models
{
    public class FeedbackRepository
    {
        private readonly HotelDbContext _context;

        public FeedbackRepository(HotelDbContext context)
        {
            _context = context;
        }

        public bool AddFeedback(int clientId, string feedbackText, int rating , int foodQuality)
        {
            var client =_context.Clients.Find(clientId);
            if (client == null)
            {
                return false; // Client not found
            }

            var feedback = new FeedBack
            {
                ClientId = clientId,
                Description = feedbackText,
                Rate = rating,
                Date = DateTime.Now,
                FoodQuality = foodQuality
            };

            _context.FeedBacks.Add(feedback);
            _context.SaveChanges();
            return true;
        }
        public bool RemoveFeedback(int feedbackId)
        {
            var feedback =  _context.FeedBacks.Find(feedbackId);
            if (feedback == null)
            {
                return false; // Feedback not found
            }

            _context.FeedBacks.Remove(feedback);
            _context.SaveChanges();
            return true;
        }
        public bool EditFeedback(int feedbackId, string newFeedbackText, int newRating , int foodQuality)
        {
            var feedback = _context.FeedBacks.Find(feedbackId);
            if (feedback == null)
            {
                return false; // Feedback not found
            }

            feedback.Description = newFeedbackText;
            feedback.Rate = newRating;
            feedback.FoodQuality = foodQuality;
            feedback.Date = DateTime.Now;

            _context.SaveChanges();
            return true;
        }
    }

}
