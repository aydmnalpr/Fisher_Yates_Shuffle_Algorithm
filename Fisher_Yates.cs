using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The Fisher-Yates Shuffle Algorithm
public static class Fisher_Yates 
{
    public static T[] ShuffleArray<T>(T[] array, int seed)
    {
        System.Random randomGenerator = new System.Random(seed);

        //last iteration will be ignored because of the algorithm
        for (int i = 0; i < array.Length-1; i++)
        {
            int randomIndex = randomGenerator.Next(i, array.Length);
            T tempItem = array[randomIndex];
            array[randomIndex] = array[i];
            array[i] = tempItem;
        }

        return array;
    }
}
