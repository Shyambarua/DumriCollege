using User.Api.DbEntities;

namespace User.Api.Models
{
    public class AddClass
    {
        public int Id { get; set; }

        public string ClassName { get; set; } = null!;

        public string Section { get; set; } = null!;

        public int ClassTeacherId { get; set; }

        public string RoomNumber { get; set; } = null!;

        public int Capacity { get; set; }

        public int AcademicYear { get; set; }

        public DateTime StartDate { get; set; }

        public string? Subjects { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedBy { get; set; }

        public bool? IsActive { get; set; }

        // Navigation Property (Foreign Key)
        public Teacher? ClassTeacher { get; set; }
    }
}