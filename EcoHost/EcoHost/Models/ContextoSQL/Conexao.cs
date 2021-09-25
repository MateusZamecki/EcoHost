using Microsoft.EntityFrameworkCore;
using System;

namespace EcoHost.Models.ContextoSQL
{
    public class Conexao
    {
        public string Texto() => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EcoHost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
