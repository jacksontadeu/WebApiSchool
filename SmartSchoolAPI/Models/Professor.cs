namespace SmartSchoolAPI.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
        

        public Professor() { }

        public Professor(int id, string nome)
        {
            Id = id;
            Nome = nome;
            
        }

        internal static object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
