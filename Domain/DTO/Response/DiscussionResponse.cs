using Domain.Entities;
namespace Domain.DTO.Response
{
    public class DiscussionResponse
    {
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
        public List<AttachmentResponse> Attachments { get; set; }
    }
}