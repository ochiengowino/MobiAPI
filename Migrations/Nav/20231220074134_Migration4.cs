using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobiAPI.Migrations.Nav
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NavTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanNo = table.Column<string>(name: "Loan_No", type: "nvarchar(max)", nullable: false),
                    ApplicationDate = table.Column<DateTime>(name: "Application_Date", type: "datetime2", nullable: false),
                    LoanProductType = table.Column<string>(name: "Loan_Product_Type", type: "nvarchar(max)", nullable: false),
                    LoanProductTypeName = table.Column<string>(name: "Loan_Product_Type_Name", type: "nvarchar(max)", nullable: false),
                    MemberNo = table.Column<string>(name: "Member_No", type: "nvarchar(max)", nullable: false),
                    MemberName = table.Column<string>(name: "Member_Name", type: "nvarchar(max)", nullable: false),
                    RequestedAmount = table.Column<decimal>(name: "Requested_Amount", type: "decimal(18,2)", nullable: false),
                    ApprovedAmount = table.Column<decimal>(name: "Approved_Amount", type: "decimal(18,2)", nullable: false),
                    Interest = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapturedBy = table.Column<string>(name: "Captured_By", type: "nvarchar(max)", nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global_Dimension_1_Code", type: "nvarchar(max)", nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global_Dimension_2_Code", type: "nvarchar(max)", nullable: false),
                    StaffNo = table.Column<string>(name: "Staff_No", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavTransactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NavTransactions");
        }
    }
}
