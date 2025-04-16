using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace QuoteMachine_ExerciceGit
{
    public class QuoteManager
    {
        private List<Quote> _quotes;

        public QuoteManager()
        {
            _quotes = new List<Quote>
            {
                new Quote { Text = "Le succès, c’est d’aller d’échec en échec sans perdre son enthousiasme.", Author = "Winston Churchill" },
                new Quote { Text = "Soyez vous-même, tous les autres sont déjà pris.", Author = "Oscar Wilde" },
                new Quote { Text = "La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre.", Author = "Albert Einstein" }
            };
        }

        public Quote GetRandomQuote()
        {
            //Avant de commencer, décommenter le test suivant:
            //GetRandomQuote_ShouldReturnNonNullQuote

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            throw new NotImplementedException("À implémenter dans feature/random-quote");
        }

        public void AddQuote(string text, string author)
        {
            //Avant de commencer, décommenter le test suivant:
            //AddQuote_ShouldIncreaseQuoteCount

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            throw new NotImplementedException("À implémenter dans feature/add-quote");
        }

        public void SaveToCSVFile(string path)
        {
            //Avant de commencer, décommenter les tests suivants:
            //SaveToFile_ShouldCreateFile
            //SaveToFile_ShouldThrowIfNotInCSVExtension

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            throw new NotImplementedException("À implémenter dans feature/save-to-file");
        }

        public void LoadFromCSVFile(string path)
        {
            //Avant de commencer, décommenter les tests suivants:
            //LoadFromFile_ShouldAppendQuotesToList
            //LoadFromFile_ShouldThrowIfFileMissing
            //LoadFromFile_ShouldThrowIfNotInCSVExtension
            if (IsCSVFile(path))
            {
                StreamReader fichier = new StreamReader(path);
                string contenuFichier = fichier.ReadToEnd();
                fichier.Close();

                contenuFichier = contenuFichier.Replace("\r", "");
                string[] vectLignes = contenuFichier.Split("\n");

                int nbQuotes;

                if (vectLignes[vectLignes.Length] != "")
                    // Il y a des données sur la dernière ligne.
                    nbQuotes = vectLignes.Length;
                else
                    // La dernière ligne est vide.
                    nbQuotes = vectLignes.Length - 1;

                for (int i = 0; i < nbQuotes; i++)
                {
                    string[] vectChamps = vectLignes[i].Split(",");
                    if (vectChamps.Length > 2)
                    {
                        string textFusion = "";
                        int j;
                        for (j = 0; j < vectChamps.Length - 2; j++)
                        {
                            textFusion += vectChamps[j] + ", ";
                        }
                        textFusion += vectChamps[j - 1];

                        _quotes.Add(
                            new Quote { Text = textFusion, Author = vectChamps[1].Trim() }
                        );

                    }
                    _quotes.Add(
                        new Quote { Text = vectChamps[0].Trim(), Author = vectChamps[1].Trim() }
                    );
                }


                //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.

                //throw new NotImplementedException("À implémenter dans feature/load-from-file");
            }

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
