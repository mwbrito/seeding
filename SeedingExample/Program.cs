using SeedingExample.Data;
using SeedingExample.Models;
using Microsoft.EntityFrameworkCore;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using (var context = new AppDbContext())
{
    context.Database.EnsureCreated();
    var produtos = context.Produtos.ToList();
    Console.WriteLine("Produtos cadastrados:");
    foreach (var produto in produtos)
    {
        Console.WriteLine($"Id: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
    }
}
