using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BukenTrainerPortal.Models
{
    public enum MenstrualCyclePhase
    {
        Menstrual,
        Folicular,
        Obulation,
        Luteal,
    }

    public enum HungerLevel
    {
        [Description(
            "Senti hambre en varias ocasiones durante el dia, las comidas no me llenaban y pasaba bastante tiempo esperando con ansias la siguiente comida"
        )]
        VeryHungryThroughoutDay,

        [Description(
            "Senti mucha hambre entre mis comidas, y estas me llenaban solo momentaneamente"
        )]
        VeryHungryBetweenMeals,

        [Description("Senti poca hambre durante el dia, por lo general justo antes de mis comidas")]
        LittleHungerDuringDay,

        [Description(
            "Me senti satisfecho durante todo el dia esta semana. Ni lleno ni con hambre."
        )]
        SatisfiedThroughoutDay,

        [Description("Me senti levemente lleno despues de mis comidas, pero de manera placentera")]
        SlightlyFullAfterMeals,

        [Description("Me senti incomodamente lleno despues de algunas comidas del dia")]
        UncomfortablyFullAfterMeals,
    }

    public class CheckIn
    {
        [Key]
        public int ID { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("AthleteId")]
        public required Athlete Athlete { get; set; }
        public int AthleteId { get; set; }

        [ForeignKey("CoachId")]
        public required Coach Coach { get; set; }
        public int CoachId { get; set; }

        [DisplayName("Weekly Achievements")]
        public string? WeeklyAchievements { get; set; }

        [DisplayName("Weekly Challenges")]
        public string? WeeklyChallenges { get; set; }

        [DisplayName("Next week's challenges")]
        public string? NextWeekChallenges { get; set; }

        [DisplayName("Plans to address challenges")]
        public string? PlansToAddressChalllenges { get; set; }

        [DisplayName("Other information")]
        public string? OtherInformation { get; set; }

        [DisplayName("Energy Levels")]
        [Range(1, 10, ErrorMessage = "Energy level must be between 1 and 10")]
        public int? EnergyLevel { get; set; }

        [DisplayName("Stress Levels")]
        [Range(1, 5, ErrorMessage = "Stress level must be between 1 and 5")]
        public int? StressLevel { get; set; }

        [DisplayName("Sleep Quality")]
        [Range(1, 5, ErrorMessage = "Sleep quality must be between 1 and 5")]
        public int? SleepQuality { get; set; }

        [DisplayName("Diet Adherence")]
        [Range(1, 5, ErrorMessage = "Diet adherence must be between 1 and 5")]
        public int? DietAdherence { get; set; }

        [DisplayName("Off Plan Meals")]
        public string? OffPlanMeals { get; set; }

        [DisplayName("Adherencia al plan de actividad")]
        [Range(1, 5, ErrorMessage = "Activity adherence must be between 1 and 5")]
        public int? ActivityAdherence { get; set; }

        [DisplayName("Hunger Levels")]
        public HungerLevel? HungerLevel { get; set; }

        [DisplayName("Muscle Recovery")]
        [Range(1, 10, ErrorMessage = "Diet adherence must be between 1 and 5")]
        public int? MuscleRecovery { get; set; }

        [DisplayName("Affected Muscles or Sessions?")]
        public string? AffectedMuscleOrSession { get; set; }

        [DisplayName("Average Bodyweight")]
        public decimal? AverageWeight { get; set; }

        [DisplayName("Menstrual Phase Cycle")]
        public MenstrualCyclePhase? MenstrualCyclePhase { get; set; }

        [DisplayName("Progres Picture URLs (Comma Separated)")]
        public string? ProgressPictureURLs { get; set; }

        [DisplayName("Systolic Blood Pressure (Optional)")]
        public short? SystolicBloodPressure { get; set; }

        [DisplayName("Diastolic Blood Pressure (Optional)")]
        public short? DiastolicBloodPressure { get; set; }

        [DisplayName("Fasting Glucose Levels (Optional)")]
        public decimal? FastingGlucoseLevels { get; set; }
    }
}
