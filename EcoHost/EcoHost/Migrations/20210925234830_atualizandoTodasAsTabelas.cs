using Microsoft.EntityFrameworkCore.Migrations;

namespace EcoHost.Migrations
{
    public partial class atualizandoTodasAsTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ProdutosVenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "ProdutosVenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Carrinhos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_CarrinhoId",
                table: "Vendas",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_UsuarioId",
                table: "Vendas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosVenda_ProdutoId",
                table: "ProdutosVenda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosVenda_VendaId",
                table: "ProdutosVenda",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCarrinho_ProdutoId",
                table: "ItensCarrinho",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId1",
                table: "Carrinhos",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhos_Usuarios_UsuarioId1",
                table: "Carrinhos",
                column: "UsuarioId1",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensCarrinho_Produtos_ProdutoId",
                table: "ItensCarrinho",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosVenda_Produtos_ProdutoId",
                table: "ProdutosVenda",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosVenda_Vendas_VendaId",
                table: "ProdutosVenda",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Carrinhos_CarrinhoId",
                table: "Vendas",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Usuarios_UsuarioId",
                table: "Vendas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_Usuarios_UsuarioId1",
                table: "Carrinhos");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensCarrinho_Produtos_ProdutoId",
                table: "ItensCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosVenda_Produtos_ProdutoId",
                table: "ProdutosVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosVenda_Vendas_VendaId",
                table: "ProdutosVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Carrinhos_CarrinhoId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Usuarios_UsuarioId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_CarrinhoId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_UsuarioId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosVenda_ProdutoId",
                table: "ProdutosVenda");

            migrationBuilder.DropIndex(
                name: "IX_ProdutosVenda_VendaId",
                table: "ProdutosVenda");

            migrationBuilder.DropIndex(
                name: "IX_ItensCarrinho_ProdutoId",
                table: "ItensCarrinho");

            migrationBuilder.DropIndex(
                name: "IX_Carrinhos_UsuarioId1",
                table: "Carrinhos");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ProdutosVenda");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "ProdutosVenda");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Carrinhos");
        }
    }
}
