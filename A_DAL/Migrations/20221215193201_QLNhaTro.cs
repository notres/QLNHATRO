using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class QLNhaTro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuTro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(47)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuTro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DichVu_ChuTro_ChuTroId",
                        column: x => x.ChuTroId,
                        principalTable: "ChuTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHopDong = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "Datetime", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HopDong_ChuTro_ChuTroId",
                        column: x => x.ChuTroId,
                        principalTable: "ChuTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhongTro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChuTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaPhong = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    SoNguoi = table.Column<int>(type: "int", nullable: false),
                    DienTich = table.Column<double>(type: "float", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DonGiaPhong = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongTro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhongTro_ChuTro_ChuTroId",
                        column: x => x.ChuTroId,
                        principalTable: "ChuTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HopDongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(47)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHang_HopDong_HopDongId",
                        column: x => x.HopDongId,
                        principalTable: "HopDong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTHopDong",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HopDongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhongTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DichVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTHopDong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CTHopDong_DichVu_DichVuId",
                        column: x => x.DichVuId,
                        principalTable: "DichVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CTHopDong_HopDong_HopDongId",
                        column: x => x.HopDongId,
                        principalTable: "HopDong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTHopDong_PhongTro_PhongTroId",
                        column: x => x.PhongTroId,
                        principalTable: "PhongTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTHopDong_DichVuId",
                table: "CTHopDong",
                column: "DichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_CTHopDong_HopDongId",
                table: "CTHopDong",
                column: "HopDongId");

            migrationBuilder.CreateIndex(
                name: "IX_CTHopDong_PhongTroId",
                table: "CTHopDong",
                column: "PhongTroId");

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_ChuTroId",
                table: "DichVu",
                column: "ChuTroId");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_ChuTroId",
                table: "HopDong",
                column: "ChuTroId");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_HopDongId",
                table: "KhachHang",
                column: "HopDongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhongTro_ChuTroId",
                table: "PhongTro",
                column: "ChuTroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTHopDong");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "PhongTro");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "ChuTro");
        }
    }
}
