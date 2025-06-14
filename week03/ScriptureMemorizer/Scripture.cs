using System;
using System.Collections.Generic;



    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            
            string[] splitWords = text.Split(' ');
            foreach (string word in splitWords)
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            int count = 3; // Number of words to hide

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(_words.Count);

                
                if (!_words[index].IsHidden())
                {
                    _words[index].Hide();
                }
            }
        }

        public string GetDisplayText()
        {
            string result = _reference.GetDisplayText() + "\n";

            foreach (Word word in _words)
            {
                result += word.GetDisplayText() + " ";
            }

            return result.Trim();
        }

        public bool IsFullyHidden()
        {
            
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }

