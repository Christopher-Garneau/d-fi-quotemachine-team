﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
