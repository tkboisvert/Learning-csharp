﻿using System;

namespace TKBoisvert.Cryptography.Core
{
    internal class ProgramForDecoding
    {
        public static void Decode(string toBeDecoded)
        {
            Scrambler scrambler = new Scrambler();

            Descrambler descrambler = new Descrambler();

            UserInteractions ATaP = new UserInteractions();

            Change change = new Change();

            int[] codedPhrase = change.ToCodedArray(toBeDecoded);

            int[] arrayOfNumbersThatRepresentsThePassPhrase = scrambler.ArrayOfUtf8Values(ATaP.GetAndVerifyPassPhrase());

            Console.WriteLine(descrambler.ArrayOfASCIIToString(descrambler.Descramble(codedPhrase, arrayOfNumbersThatRepresentsThePassPhrase)));

            Console.ReadLine();
        }
    }
}