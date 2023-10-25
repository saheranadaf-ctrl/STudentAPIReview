using System.ComponentModel.DataAnnotations;

namespace StudentUI
{
    public class Student
    {

        [Key]
        [Required(ErrorMessage = "Student ID is required.")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Student ID must be 9 characters long.")]
        [RegularExpression("^STDN\\d{5}$", ErrorMessage = "Student ID must start with 'STDN' followed by 5 digits.")]
        public string Student_ID { get; set; } = null!;

        [Required(ErrorMessage = "Gender is required.")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? NationalIty { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? PlaceofBirth { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? StageId { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? GradeId { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? SectionId { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? Topic { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? Semester { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string? Relation { get; set; }

        [Required(ErrorMessage = "Raised Hands is required.")]
        [Range(0, 100, ErrorMessage = "Raised Hands must be between 0 and 100.")]
        public double? Raisedhands { get; set; }

        [Required(ErrorMessage = "VisItedResources View is required.")]
        [Range(0, 100, ErrorMessage = "VisItedResources View must be between 0 and 100.")]
        public double? VisItedResources { get; set; }

        [Required(ErrorMessage = "AnnouncementsView View is required.")]
        [Range(0, 100, ErrorMessage = "AnnouncementsView View must be between 0 and 100.")]
        public double? AnnouncementsView { get; set; }


        [Required(ErrorMessage = "Discussion View is required.")]
        [Range(0, 100, ErrorMessage = "Discussion View must be between 0 and 100.")]
        public double? Discussion { get; set; }

        [Required(ErrorMessage = "ParentAnsweringSurvey is required.")]
        public string? ParentAnsweringSurvey { get; set; }

        [Required(ErrorMessage = "ParentschoolSatisfaction is required.")]
        public string? ParentschoolSatisfaction { get; set; }

        [Required(ErrorMessage = "StudentAbsenceDays is required.")]
        public string? StudentAbsenceDays { get; set; }

        [Required(ErrorMessage = "AnnouncementsView View is required.")]
        [Range(0, 100, ErrorMessage = "VisItedResources View must be between 0 and 100.")]
        public double? Student_Marks { get; set; }

        [Required(ErrorMessage = "Class is required.")]
        public string? Class { get; set; }
    }
}
