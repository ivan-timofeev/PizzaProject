﻿using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace PizzaProject.Utils
{
    public static class Algorithms
    {
        public static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;

        /// <summary>
        /// Итеративная реализация алгоритма "Расстояние Левенштейна"
        /// (Неточный поиск)
        /// Источник: https://programm.top/c-sharp/algorithm/levenshtein-distance/
        /// </summary>
        /// <param name="firstWord"></param>
        /// <param name="secondWord"></param>
        /// <returns></returns>
        public static int LevenshteinDistance(string firstWord, string secondWord)
        {
            var n = firstWord.Length + 1;
            var m = secondWord.Length + 1;
            var matrixD = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (var i = 0; i < n; i++)
            {
                matrixD[i, 0] = i;
            }

            for (var j = 0; j < m; j++)
            {
                matrixD[0, j] = j;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                    matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,          // удаление
                                            matrixD[i, j - 1] + insertionCost,         // вставка
                                            matrixD[i - 1, j - 1] + substitutionCost); // замена
                }
            }

            return matrixD[n - 1, m - 1];
        }

        public static string CalcPasswordHash(string password)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        /// <summary>
        /// Вернет вторую строку, если первая является пустой
        /// иначе вернет вторую строку
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static string SelectString(string t1, string t2)
        {
            if (string.IsNullOrWhiteSpace(t1))
                return t2;

            return t1;
        }

        /// <summary>
        /// Вернет первую строку, если предикат является истинным
        /// Иначе вернет вторую строку
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static string SelectString(bool predicate, string t1, string t2)
        {
            if (predicate) return t1;
            else return t2;
        }
    }
}
