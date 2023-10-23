using System.Security.Cryptography.X509Certificates;

namespace Es02.Models
{
    public class StudenteBusinessLayer
    {
        List<Studente> elencoStudenti = new List<Studente>();
        public StudenteBusinessLayer()
        {
            int i=0;
            Studente studente = new Studente()
            {
                StudenteId = i++,
                Nome = "Carolina",
                Cognome = "Caroli",
                Sesso = "F",
                Eta = 18
            };
            elencoStudenti.Add(studente);
            studente = new Studente()
            {
                StudenteId = i++,
                Nome = "Giorgio",
                Cognome = "Bottazzi",
                Sesso = "M",
                Eta = 24
            };
            elencoStudenti.Add(studente);
            studente = new Studente()
            {
                StudenteId = i++,
                Nome = "Anna",
                Cognome = "Vespa",
                Sesso = "F",
                Eta = 24
            };
            elencoStudenti.Add(studente);
            studente = new Studente()
            {
                StudenteId = i++,
                Nome = "Giorgio",
                Cognome = "Bottazzi",
                Sesso = "M",
                Eta = 24
            };
            elencoStudenti.Add(studente);
        }

           public List<Studente> GetAll()
        {
            return elencoStudenti;
        }
        public Studente GetStudent(int id)
        {
            if(id<1 || id >= elencoStudenti.Count)
            {
               
            }
            return elencoStudenti[id - 1];
        }

        }
    
}
