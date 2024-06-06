// using aulinha.db;

// using (var db = new DbLivrariaContext()) {
//     foreach (var autor in db.TbAutor) {
//         Console.WriteLine($"O(a) autor(a) {autor.Nome} é do(a) {autor.Pais}!");
//     }
// }

// using (var db = new DbLivrariaContext()) {
//     foreach (var autor in db.TbAutor.Where(a => a.Nome.Contains)) {
//         Console.WriteLine($"O(a) autor(a) {autor.Nome} é do(a) {autor.Pais}!");
//     }
// }

// using (var db = new DbLivrariaContext())
// {
//     var autor = db.TbAutor.Find(10);

//     if (autor != null)
//     {
//         Console.WriteLine($"O autor é {autor.Nome}.");
//     }
//     else
//     {
//         Console.WriteLine("Autor não consta no banco.");
//     }
// }

// using (var db = new DbLivrariaContext())
// {
//     var novoAutor = new TbAutor
//     {
//         NotImplementedException = "Clarice Lispector",
//         NrFone = "11912345678",
//         Pais = "Ucrania"
//     };

//     db.TbAutor.Add(novoAutor);
//     db.SaveChanges();
// }

// using (var db = new DbLivrariaContext())
// {
//     var autor = db.TbAuto.SingleDefault(a => a.IdAutor == 6);

//     if (autor != null)
//     {
//         autor.Pais = "Brasil";
//         db.SaveChanges();
//     }
//     else {
//         Console.WriteLine("Autor não identificado!");
//     }
// }

using (var db = new DbLivrariaContext())
{
    var autor = db.TbAuto.SingleDefault(a => a.IdAutor == 6);

    if (autor != null)
    {
        db.TbAutor.Remove(autor);
        db.SaveChanges();
    }
    else {
        Console.WriteLine("Autor não identificado!");
    }
}