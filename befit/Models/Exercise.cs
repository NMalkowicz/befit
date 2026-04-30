using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace befit.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Display(Name ="Numer")]
        public int Weight { get; set; }
        [Display(Name = "Waga")]
        public int NumOfSeries { get; set; }
        [Display(Name = "Numer Serii")]
        public int NumOfReps { get; set; }
        [Display(Name = "Numer powtorzenia")]
        public int ExerciseTypeId { get; set; }
        public virtual ExerciseType? ExerciseType { get; set; }
        [Display(Name = "Typ cwiczenia")]
        public int SessionId { get; set; }
        public virtual Session? Session { get; set; }
        public string? UserId { get; set; }
        public IdentityUser? User { get; set; }


    }
}
