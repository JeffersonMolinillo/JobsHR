namespace Jobs.Dados
{
    public static class DbInitializer
    {
        public static void Initialize(ProfissionalContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}


//A instrução
//context.Database.EnsureCreated();
//cria o banco de dados, se este não existir.
