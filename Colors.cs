using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winformdle;

namespace Winformdle
{
    internal class Colors
    {
        public static async void CheckGuess()
        {
            string attemptWord = Form2.attempt1Char1.Text + Form2.attempt1Char2.Text + Form2.attempt1Char3.Text + Form2.attempt1Char4.Text + Form2.attempt1Char5.Text;
            string guessWord = Form2.guessWord;

            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            //initialize TextBox array
            TextBox[] textBoxes = {Form2.attempt1Char1, Form2.attempt1Char2, Form2.attempt1Char3, Form2.attempt1Char4, Form2.attempt1Char5};

            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {

                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }

            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }

                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;                
                        break;
                    }
                }

                //gray
                if (result[i] == 'X')
                {
                    result[i] = 'D';
                    await Task.Delay(500);
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                switch (result[i])
                {
                    case 'G':
                        textBoxes[i].BackColor = Color.LightGreen;
                        break;
                    case 'Y':
                        textBoxes[i].BackColor = Color.Yellow;
                        break;
                    case 'D':
                        textBoxes[i].BackColor = Color.DarkGray;
                        break;
                }
                await Task.Delay(500);
            }
        }
        public static async void CheckGuess2()
        {
            string attemptWord = Form2.attempt2Char1.Text + Form2.attempt2Char2.Text + Form2.attempt2Char3.Text + Form2.attempt2Char4.Text + Form2.attempt2Char5.Text;
            string guessWord = Form2.guessWord;

            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            TextBox[] textBoxes = {Form2.attempt2Char1, Form2.attempt2Char2, Form2.attempt2Char3, Form2.attempt2Char4, Form2.attempt2Char5};

            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }

            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }

                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }

                //gray
                if (result[i] == 'X')
                {
                    result[i] = 'D';
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                switch (result[i])
                {
                    case 'G':
                        textBoxes[i].BackColor = Color.LightGreen;
                        break;
                    case 'Y':
                        textBoxes[i].BackColor = Color.Yellow;
                        break;
                    case 'D':
                        textBoxes[i].BackColor = Color.DarkGray;
                        break;
                }
                await Task.Delay(500);
            }
        }
        public static async void CheckGuess3()
        {
            string attemptWord = Form2.attempt3Char1.Text + Form2.attempt3Char2.Text + Form2.attempt3Char3.Text + Form2.attempt3Char4.Text + Form2.attempt3Char5.Text;
            string guessWord = Form2.guessWord;

            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            TextBox[] textBoxes = {Form2.attempt3Char1, Form2.attempt3Char2, Form2.attempt3Char3, Form2.attempt3Char4, Form2.attempt3Char5};

            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }

            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }

                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }

                //gray
                if (result[i] == 'X')
                {
                    result[i] = 'D';
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                switch (result[i])
                {
                    case 'G':
                        textBoxes[i].BackColor = Color.LightGreen;
                        break;
                    case 'Y':
                        textBoxes[i].BackColor = Color.Yellow;
                        break;
                    case 'D':
                        textBoxes[i].BackColor = Color.DarkGray;
                        break;
                }
                await Task.Delay(500);
            }
        }
        public static async void CheckGuess4()
        {
            string attemptWord = Form2.attempt4Char1.Text + Form2.attempt4Char2.Text + Form2.attempt4Char3.Text + Form2.attempt4Char4.Text + Form2.attempt4Char5.Text;
            string guessWord = Form2.guessWord;

            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            TextBox[] textBoxes = {Form2.attempt4Char1, Form2.attempt4Char2, Form2.attempt4Char3, Form2.attempt4Char4, Form2.attempt4Char5};

            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }

            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }

                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }

                //gray
                if (result[i] == 'X')
                {
                    result[i] = 'D';
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                switch (result[i])
                {
                    case 'G':
                        textBoxes[i].BackColor = Color.LightGreen;
                        break;
                    case 'Y':
                        textBoxes[i].BackColor = Color.Yellow;
                        break;
                    case 'D':
                        textBoxes[i].BackColor = Color.DarkGray;
                        break;
                }
                await Task.Delay(500);
            }
        }
        public static async void CheckGuess5()
        {
            string attemptWord = Form2.attempt5Char1.Text + Form2.attempt5Char2.Text + Form2.attempt5Char3.Text + Form2.attempt5Char4.Text + Form2.attempt5Char5.Text;
            string guessWord = Form2.guessWord;

            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            TextBox[] textBoxes = {Form2.attempt5Char1, Form2.attempt5Char2, Form2.attempt5Char3, Form2.attempt5Char4, Form2.attempt5Char5};

            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }

            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }

                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }

                //gray
                if (result[i] == 'X')
                {
                    result[i] = 'D';
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                switch (result[i])
                {
                    case 'G':
                        textBoxes[i].BackColor = Color.LightGreen;
                        break;
                    case 'Y':
                        textBoxes[i].BackColor = Color.Yellow;
                        break;
                    case 'D':
                        textBoxes[i].BackColor = Color.DarkGray;
                        break;
                }
                await Task.Delay(500);
            }
        }
        public static async void CheckGuess6()
        {
            string attemptWord = Form2.attempt6Char1.Text + Form2.attempt6Char2.Text + Form2.attempt6Char3.Text + Form2.attempt6Char4.Text + Form2.attempt6Char5.Text;
            string guessWord = Form2.guessWord;

            char[] result = new char[attemptWord.Length];
            bool[] guessWordUsed = new bool[guessWord.Length];

            TextBox[] textBoxes = {Form2.attempt6Char1, Form2.attempt6Char2, Form2.attempt6Char3, Form2.attempt6Char4, Form2.attempt6Char5};

            //green
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (attemptWord[i] == guessWord[i])
                {
                    result[i] = 'G';
                    guessWordUsed[i] = true;
                }
                else
                {
                    result[i] = 'X';
                }
            }

            //yellow
            for (int i = 0; i < attemptWord.Length; i++)
            {
                if (result[i] == 'G')
                {
                    continue;
                }

                for (int j = 0; j < guessWord.Length; j++)
                {
                    if (!guessWordUsed[j] && attemptWord[i] == guessWord[j])
                    {
                        result[i] = 'Y';
                        guessWordUsed[j] = true;
                        break;
                    }
                }

                //gray
                if (result[i] == 'X')
                {
                    result[i] = 'D';
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                switch (result[i])
                {
                    case 'G':
                        textBoxes[i].BackColor = Color.LightGreen;
                        break;
                    case 'Y':
                        textBoxes[i].BackColor = Color.Yellow;
                        break;
                    case 'D':
                        textBoxes[i].BackColor = Color.DarkGray;
                        break;
                }
                await Task.Delay(500);
            }
        }
    }
}
