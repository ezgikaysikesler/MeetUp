using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API.Dtos
{
    public class ActivityDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }

        [JsonPropertyName("attendees")]
        public ICollection<AttendeeDto> UserActivities { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }

    public class ActivityParams
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime? Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }


    public class ActivitiesEnvelope
    {
        public List<ActivityDto> Activities { get; set; }
        public int ActivityCount { get; set; }
    }
}