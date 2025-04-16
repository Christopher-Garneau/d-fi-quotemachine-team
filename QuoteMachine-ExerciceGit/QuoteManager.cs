using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMachine_ExerciceGit
{
    public class QuoteManager
    {
        private List<Quote> _quotes;
        private readonly Random _random = new Random();
        public QuoteManager()
        {
            string text1 ="Le succès, c’est d’aller d’échec en échec sans perdre son enthousiasme.";
            string auteur1 ="Winston Churchill";
            string text2= "Soyez vous-même, tous les autres sont déjà pris.";
            string auteur2="Oscar Wilde";
            string text3="La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre.";
            string auteur3="Albert Einstein";
            _quotes = new List<Quote>
            {  
                new Quote (text1, auteur1),
                new Quote (text2, auteur2),
                new Quote (text3, auteur3)
            };
        }

        public Quote GetRandomQuote()
        {
           
            if( _quotes.Count == 0  || _quotes == null)
                throw new InvalidOperationException("La liste de citations est vide.");

            int randomIndex = _random.Next(0, _quotes.Count);
            return _quotes[randomIndex];

        }

        public void AddQuote(string text, string author)
        {
            //Avant de commencer, décommenter le test suivant:
            //AddQuote_ShouldIncreaseQuoteCount

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            if(text !=null && author != null){
                Quote quote = new (text,author);
                _quotes.Add(quote);
            }
            else{
                throw new NotImplementedException("À implémenter dans feature/add-quote");
            };

           // throw new NotImplementedException("À implémenter dans feature/add-quote");
        }

        public void SaveToCSVFile(string path)
        {
            if (!IsCSVFile(path))
                throw new QuoteFileException("Erreur lors de la sauvegarde : le fichier doit avoir l'extension .csv");

            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    foreach (var quote in _quotes)
                    {
                        writer.WriteLine($"\"{quote.Text.Replace("\"", "\"\"")}\",\"{quote.Author.Replace("\"", "\"\"")}\"");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new QuoteFileException("Erreur lors de la sauvegarde des citations.", ex);
            }
        }

        public void LoadFromCSVFile(string path)
        {
            //Avant de commencer, décommenter les tests suivants:
            //LoadFromFile_ShouldAppendQuotesToList
            //LoadFromFile_ShouldThrowIfFileMissing
            //LoadFromFile_ShouldThrowIfNotInCSVExtension

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.

            throw new NotImplementedException("À implémenter dans feature/load-from-file");
        }

        public List<Quote> GetAllQuotes()
        {
            return _quotes; // Pas besoin d'ajouter de test pour cette méthode
        }

        private bool IsCSVFile(string path)
        {
            return path.EndsWith(".csv");
        }
    }
}
