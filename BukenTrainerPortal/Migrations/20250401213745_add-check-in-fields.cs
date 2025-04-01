using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BukenTrainerPortal.Migrations
{
    /// <inheritdoc />
    public partial class addcheckinfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Athletes_AthleteID",
                table: "CheckIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Coaches_CoachID",
                table: "CheckIns");

            migrationBuilder.RenameColumn(
                name: "CoachID",
                table: "CheckIns",
                newName: "CoachId");

            migrationBuilder.RenameColumn(
                name: "AthleteID",
                table: "CheckIns",
                newName: "AthleteId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIns_CoachID",
                table: "CheckIns",
                newName: "IX_CheckIns_CoachId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIns_AthleteID",
                table: "CheckIns",
                newName: "IX_CheckIns_AthleteId");

            migrationBuilder.AddColumn<int>(
                name: "ActivityAdherence",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AffectedMuscleOrSession",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AverageWeight",
                table: "CheckIns",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "DiastolicBloodPressure",
                table: "CheckIns",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DietAdherence",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnergyLevel",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FastingGlucoseLevels",
                table: "CheckIns",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HungerLevel",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenstrualCyclePhase",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MuscleRecovery",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextWeekChallenges",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OffPlanMeals",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherInformation",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlansToAddressChalllenges",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProgressPictureURLs",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SleepQuality",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StressLevel",
                table: "CheckIns",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "SystolicBloodPressure",
                table: "CheckIns",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeeklyAchievements",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeeklyChallenges",
                table: "CheckIns",
                type: "text",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Athletes_AthleteId",
                table: "CheckIns",
                column: "AthleteId",
                principalTable: "Athletes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Coaches_CoachId",
                table: "CheckIns",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Athletes_AthleteId",
                table: "CheckIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Coaches_CoachId",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "ActivityAdherence",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "AffectedMuscleOrSession",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "AverageWeight",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "DiastolicBloodPressure",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "DietAdherence",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "EnergyLevel",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "FastingGlucoseLevels",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "HungerLevel",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "MenstrualCyclePhase",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "MuscleRecovery",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "NextWeekChallenges",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "OffPlanMeals",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "OtherInformation",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "PlansToAddressChalllenges",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "ProgressPictureURLs",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "SleepQuality",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "StressLevel",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "SystolicBloodPressure",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "WeeklyAchievements",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "WeeklyChallenges",
                table: "CheckIns");

            migrationBuilder.RenameColumn(
                name: "CoachId",
                table: "CheckIns",
                newName: "CoachID");

            migrationBuilder.RenameColumn(
                name: "AthleteId",
                table: "CheckIns",
                newName: "AthleteID");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIns_CoachId",
                table: "CheckIns",
                newName: "IX_CheckIns_CoachID");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIns_AthleteId",
                table: "CheckIns",
                newName: "IX_CheckIns_AthleteID");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Athletes_AthleteID",
                table: "CheckIns",
                column: "AthleteID",
                principalTable: "Athletes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Coaches_CoachID",
                table: "CheckIns",
                column: "CoachID",
                principalTable: "Coaches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
