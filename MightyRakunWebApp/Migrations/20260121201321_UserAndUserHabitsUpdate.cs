using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MightyRakunWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UserAndUserHabitsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserHabit_Habits_HabitId",
                table: "UserHabit");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHabit_Users_UserId",
                table: "UserHabit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHabit",
                table: "UserHabit");

            migrationBuilder.RenameTable(
                name: "UserHabit",
                newName: "UserHabits");

            migrationBuilder.RenameIndex(
                name: "IX_UserHabit_HabitId",
                table: "UserHabits",
                newName: "IX_UserHabits_HabitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHabits",
                table: "UserHabits",
                columns: new[] { "UserId", "HabitId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserHabits_Habits_HabitId",
                table: "UserHabits",
                column: "HabitId",
                principalTable: "Habits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHabits_Users_UserId",
                table: "UserHabits",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserHabits_Habits_HabitId",
                table: "UserHabits");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHabits_Users_UserId",
                table: "UserHabits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHabits",
                table: "UserHabits");

            migrationBuilder.RenameTable(
                name: "UserHabits",
                newName: "UserHabit");

            migrationBuilder.RenameIndex(
                name: "IX_UserHabits_HabitId",
                table: "UserHabit",
                newName: "IX_UserHabit_HabitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHabit",
                table: "UserHabit",
                columns: new[] { "UserId", "HabitId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserHabit_Habits_HabitId",
                table: "UserHabit",
                column: "HabitId",
                principalTable: "Habits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHabit_Users_UserId",
                table: "UserHabit",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
