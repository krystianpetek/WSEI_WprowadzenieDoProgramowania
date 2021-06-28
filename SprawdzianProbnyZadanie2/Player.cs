using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianProbnyZadanie2
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {

                if (value.Length < 3)
                    throw new ArgumentException("Wrong name!");

                bool sprawdz = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetterOrDigit(value[i]) || char.IsWhiteSpace(value[i]))
                    {
                        sprawdz = true;

                    }
                    else
                    {
                        sprawdz = false;
                    }
                    if (sprawdz == false)
                        throw new ArgumentException("Wrong name!");


                }
                string wynik = "";
                for (int j = 0; j < value.Length; j++)
                {

                    value = value.ToLower();

                    if (value[j] != ' ')
                        wynik += value[j];
                    else
                        continue;
                }

                this.name = wynik.Trim();
            }
        }
        private void check(string pass)
        {

            if (pass.Length < 8 || pass.Length > 16 || pass == null)
                throw new ArgumentException("Wrong password!");
            bool sprawdzDuze = false;
            bool sprawdzMale = false;
            bool sprawdzInterpunkcje = false;
            bool sprawdzBialeZnaki = true;
            bool sprawdzCyfre = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLower(pass[i]))
                    sprawdzMale = true;
                if (char.IsDigit(pass[i]))
                    sprawdzCyfre = true;
                if (char.IsUpper(pass[i]))
                    sprawdzDuze = true;
                if (char.IsPunctuation(pass[i]))
                    sprawdzInterpunkcje = true;
                if (char.IsWhiteSpace(pass[0]) || char.IsWhiteSpace(pass[pass.Length - 1]))
                    sprawdzBialeZnaki = false;

            }
            if (sprawdzDuze == false && sprawdzMale == false && sprawdzInterpunkcje == false && sprawdzBialeZnaki == false && sprawdzCyfre == false)
                throw new ArgumentException("Wrong password!");
        }
        private string haslo;
        private string Password
        {
            get
            {
                return this.haslo;
            }
            set
            {
                check(value);
                this.haslo = value;
            }
        }
        private int BestScore = 0;
        private int LastScore = 0;
        private double punktySrednia = 0;

        private double AvgScore
        {
            get { return punktySrednia; }
            set { punktySrednia = Math.Round(value, 1); }
        }

        int licznikSredniej = 0;

        public Player(string name, string password)
        {
            if (password == null)
                throw new ArgumentException("Wrong password!");
            this.Name = name;
            this.Password = password;
        }

        public void AddScore(int currentScore)
        {
            if (currentScore < 0 || currentScore > 100)
            {
                Console.WriteLine("Wrong value!");

            }
            else
            {
                if (currentScore >= 0 || currentScore <= 100)
                {
                    LastScore = currentScore;

                    if (currentScore > BestScore)
                        BestScore = currentScore;

                    AvgScore = AvgScore * licznikSredniej;
                    licznikSredniej++;
                    double oblicz = AvgScore + currentScore;
                    oblicz /= licznikSredniej;
                    oblicz = Math.Round(oblicz, 1);
                    AvgScore = oblicz;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Wrong value!");
                }
            }
        }

        public bool TryAddScore(int currentScore)
        {
            if (currentScore < 0 || currentScore > 100)
            {
                return false;
            }

            if (currentScore >= 0 || currentScore <= 100)
            {
                LastScore = currentScore;

                if (currentScore > BestScore)
                    BestScore = currentScore;

                AvgScore = AvgScore * licznikSredniej;
                licznikSredniej++;
                double oblicz = AvgScore + currentScore;
                oblicz /= licznikSredniej;
                oblicz = Math.Round(oblicz, 1);
                AvgScore = oblicz;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (!VerifyPassword(oldPassword))
            {
                return false;
            }
            else
            {
                if (newPassword.Length < 8 || newPassword.Length > 16)
                    return false;
                bool sprawdzDuze = false;
                bool sprawdzMale = false;
                bool sprawdzInterpunkcje = false;
                bool sprawdzCyfre = false;
                bool sprawdzBialeZnaki = true;

                for (int i = 0; i < newPassword.Length; i++)
                {
                    if (char.IsLower(newPassword[i]))
                    {
                        sprawdzMale = true;
                    }
                    if (char.IsNumber(newPassword[i]))
                    {
                        sprawdzCyfre = true;
                    }
                    if (char.IsUpper(newPassword[i]))
                    {
                        sprawdzDuze = true;
                    }
                    if (char.IsPunctuation(newPassword[i]))
                    {
                        sprawdzInterpunkcje = true;
                    }
                    if (char.IsWhiteSpace(newPassword[0]) || char.IsWhiteSpace(newPassword[newPassword.Length - 1]))
                    {
                        sprawdzBialeZnaki = false;
                    }
                }
                if (sprawdzDuze && sprawdzMale && sprawdzCyfre && sprawdzInterpunkcje && sprawdzBialeZnaki)
                    this.haslo = newPassword;
                else
                {
                    return false;
                }
                return true;
            }
        }
        public bool VerifyPassword(string password)
        {
            if (password == Password)
                return true;
            else
                return false;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Score: last={LastScore}, best={BestScore}, avg={AvgScore}";
        }
    }
}
